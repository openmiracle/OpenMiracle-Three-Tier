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
//Summary description for RemainderSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ReminderSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Remainder Table
        /// </summary>
        /// <param name="reminderinfo"></param>
        /// <returns></returns>
        public bool ReminderAdd(ReminderInfo reminderinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReminderAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = reminderinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = reminderinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@remindAbout", SqlDbType.VarChar);
                sprmparam.Value = reminderinfo.RemindAbout;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = reminderinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = reminderinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = reminderinfo.ExtraDate;
                int inEffectedRows = sccmd.ExecuteNonQuery();
                if (inEffectedRows > 0)
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
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to Update values in Remainder Table
        /// </summary>
        /// <param name="remainderinfo"></param>
        /// <returns></returns>
        public bool RemainderEdit(ReminderInfo remainderinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReminderEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@reminderId", SqlDbType.Decimal);
                sprmparam.Value = remainderinfo.ReminderId;
                sprmparam = sccmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = remainderinfo.FromDate;
                sprmparam = sccmd.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = remainderinfo.ToDate;
                sprmparam = sccmd.Parameters.Add("@remindAbout", SqlDbType.VarChar);
                sprmparam.Value = remainderinfo.RemindAbout;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = remainderinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = remainderinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = remainderinfo.ExtraDate;
                int inEffectedRows = sccmd.ExecuteNonQuery();
                if (inEffectedRows > 0)
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
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get all the values from Remainder Table
        /// </summary>
        /// <returns></returns>
        public DataTable RemainderViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ReminderViewAll", sqlcon);
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
        /// Function to get particular values from Remainder Table based on the parameter
        /// </summary>
        /// <param name="remainder"></param>
        /// <returns></returns>
        public ReminderInfo RemainderView(decimal remainder)
        {
            ReminderInfo remainderinfo = new ReminderInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReminderView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@reminderId", SqlDbType.Decimal);
                sprmparam.Value = remainder;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    remainderinfo.FromDate = DateTime.Parse(sdrreader["fromDate"].ToString());
                    remainderinfo.ToDate = DateTime.Parse(sdrreader["toDate"].ToString());
                    remainderinfo.RemindAbout = sdrreader["remindAbout"].ToString();
                    remainderinfo.Extra1 = sdrreader["extra1"].ToString();
                    remainderinfo.Extra2 = sdrreader["extra2"].ToString();
                    remainderinfo.ExtraDate = DateTime.Parse(sdrreader["extraDate"].ToString());
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
            return remainderinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter From Table Remainder
        /// </summary>
        /// <param name="Remainder"></param>
        /// <returns></returns>
        public bool RemainderDelete(decimal Remainder)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReminderDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@reminderId", SqlDbType.Decimal);
                sprmparam.Value = Remainder;
                decimal decNoEffectedRows = sccmd.ExecuteNonQuery();
                if (decNoEffectedRows > 0)
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
        /// Function to  get the next id for Remainder Table
        /// </summary>
        /// <returns></returns>
        public int RemainderGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ReminderMax", sqlcon);
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
        /// Function to use the Reminder search
        /// </summary>
        /// <param name="strfromDate"></param>
        /// <param name="strToDate"></param>
        /// <returns></returns>
        public List<DataTable> ReminderSearch(string strfromDate, string strToDate)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> list = new List<DataTable>();
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
                SqlDataAdapter sqlda = new SqlDataAdapter("ReminderSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = strfromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = strToDate;
                sqlda.SelectCommand.Parameters.Add("@userId", SqlDbType.VarChar).Value = PublicVariables._decCurrentUserId.ToString();
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
        /// Function to OverDue PurchaseOrders Corresponding to the AccountLedger
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> OverDuePurchaseOrdersCorrespondingAccountLedger(decimal decLedgerId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> list = new List<DataTable>();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("OverDuePurchaseOrdersCorrespondingAccountLedger", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@accountLedgerId", SqlDbType.Decimal).Value = decLedgerId;
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
        /// Function to use ShortExpiry Reminder Grid Fill
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="productId"></param>
        /// <param name="brandId"></param>
        /// <param name="sizeId"></param>
        /// <param name="modelNoId"></param>
        /// <param name="taxId"></param>
        /// <param name="godownId"></param>
        /// <param name="rackId"></param>
        /// <returns></returns>
        public List<DataTable> ShortExpiryReminderGridFill(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId)
        {
            List<DataTable> list = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReminderGridSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                param.Value = groupId;
                param = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                param.Value = productId;
                param = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
                param.Value = brandId;
                param = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
                param.Value = sizeId;
                param = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                param.Value = modelNoId;
                param = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                param.Value = taxId;
                param = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
                param.Value = godownId;
                param = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
                param.Value = rackId;
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
        /// Function to use Overdue SalesOrder Corresponding AccountLedger
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> OverdueSalesOrderCorrespondingAccountLedger(decimal decLedgerId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> list = new List<DataTable>();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("OverdueSalesOrderCorrespondingAccountLedger", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@accountLedgerId", SqlDbType.Decimal).Value = decLedgerId;
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
        /// Function to do the search in Stock report
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="productId"></param>
        /// <param name="brandId"></param>
        /// <param name="sizeId"></param>
        /// <param name="modelNoId"></param>
        /// <param name="taxId"></param>
        /// <param name="godownId"></param>
        /// <param name="rackId"></param>
        /// <param name="strcriteria"></param>
        /// <returns></returns>
        public List<DataTable> StockSearch(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId, string strcriteria)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> list = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("StockSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("Sl No", typeof(decimal));
                dtbl.Columns["Sl No"].AutoIncrement = true;
                dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
                dtbl.Columns["Sl No"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                param.Value = groupId;
                param = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                param.Value = productId;
                param = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
                param.Value = brandId;
                param = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
                param.Value = sizeId;
                param = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                param.Value = modelNoId;
                param = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                param.Value = taxId;
                param = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
                param.Value = godownId;
                param = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
                param.Value = rackId;
                param = sqlda.SelectCommand.Parameters.Add("@criteria", SqlDbType.VarChar);
                param.Value = strcriteria;
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
        /// Function to use ShortExpiry Report GridFill
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="productId"></param>
        /// <param name="brandId"></param>
        /// <param name="sizeId"></param>
        /// <param name="modelNoId"></param>
        /// <param name="godownId"></param>
        /// <param name="rackId"></param>
        /// <param name="tExpiry"></param>
        /// <param name="cExpiry"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        public List<DataTable> ShortExpiryReportGridFill(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal godownId, decimal rackId, decimal tExpiry, string cExpiry, DateTime today)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> list = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReportGridSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                param.Value = groupId;
                param = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                param.Value = productId;
                param = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
                param.Value = brandId;
                param = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
                param.Value = sizeId;
                param = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                param.Value = modelNoId;
                param = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
                param.Value = godownId;
                param = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
                param.Value = rackId;
                param = sqlda.SelectCommand.Parameters.Add("@tExpiry", SqlDbType.Decimal);
                param.Value = tExpiry;
                param = sqlda.SelectCommand.Parameters.Add("@cExpiry", SqlDbType.VarChar);
                param.Value = cExpiry;
                param = sqlda.SelectCommand.Parameters.Add("@today", SqlDbType.DateTime);
                param.Value = today;
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
        /// Function to use ShortExpiry Report Printing based on searching condition
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="productId"></param>
        /// <param name="brandId"></param>
        /// <param name="sizeId"></param>
        /// <param name="modelNoId"></param>
        /// <param name="godownId"></param>
        /// <param name="rackId"></param>
        /// <param name="tExpiry"></param>
        /// <param name="cExpiry"></param>
        /// <param name="today"></param>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public DataSet ShortExpiryReportPrinting(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal godownId, decimal rackId, decimal tExpiry, string cExpiry, DateTime today, decimal companyId)
        {
            DataSet dtblSER = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReportPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                param.Value = groupId;
                param = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                param.Value = productId;
                param = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
                param.Value = brandId;
                param = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
                param.Value = sizeId;
                param = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                param.Value = modelNoId;
                param = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
                param.Value = godownId;
                param = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
                param.Value = rackId;
                param = sqlda.SelectCommand.Parameters.Add("@tExpiry", SqlDbType.Decimal);
                param.Value = tExpiry;
                param = sqlda.SelectCommand.Parameters.Add("@cExpiry", SqlDbType.VarChar);
                param.Value = cExpiry;
                param = sqlda.SelectCommand.Parameters.Add("@today", SqlDbType.DateTime);
                param.Value = today;
                param = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                param.Value = companyId;
                sqlda.Fill(dtblSER);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dtblSER;
        }
        /// <summary>
        /// Function to use ShortExpiryReminder For popup
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="productId"></param>
        /// <param name="brandId"></param>
        /// <param name="sizeId"></param>
        /// <param name="modelNoId"></param>
        /// <param name="taxId"></param>
        /// <param name="godownId"></param>
        /// <param name="rackId"></param>
        /// <returns></returns>
        public List<DataTable> ShortExpiryReminder(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId)
        {
            DataTable dtbl = new DataTable();
            List<DataTable> list = new List<DataTable>();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("ShortExpiryReminder", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("slNo", typeof(decimal));
                dtbl.Columns["slNo"].AutoIncrement = true;
                dtbl.Columns["slNo"].AutoIncrementSeed = 1;
                dtbl.Columns["slNo"].AutoIncrementStep = 1;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal);
                param.Value = groupId;
                param = sqlda.SelectCommand.Parameters.Add("@productId", SqlDbType.Decimal);
                param.Value = productId;
                param = sqlda.SelectCommand.Parameters.Add("@brandId", SqlDbType.Decimal);
                param.Value = brandId;
                param = sqlda.SelectCommand.Parameters.Add("@sizeId", SqlDbType.Decimal);
                param.Value = sizeId;
                param = sqlda.SelectCommand.Parameters.Add("@modelNoId", SqlDbType.Decimal);
                param.Value = modelNoId;
                param = sqlda.SelectCommand.Parameters.Add("@taxId", SqlDbType.Decimal);
                param.Value = taxId;
                param = sqlda.SelectCommand.Parameters.Add("@godownId", SqlDbType.Decimal);
                param.Value = godownId;
                param = sqlda.SelectCommand.Parameters.Add("@rackId", SqlDbType.Decimal);
                param.Value = rackId;
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
    }
}
