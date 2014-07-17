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
//Summary description for AccountLedgerSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class AccountLedgerSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to account ledger table
        /// </summary>
        /// <param name="accountledgerinfo"></param>
        public void AccountLedgerAdd(AccountLedgerInfo accountledgerinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Email;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = accountledgerinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.CreditLimit;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.BillByBill;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountledgerinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.IsDefault;
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
        /// Function to Update values in account ledger table
        /// </summary>
        /// <param name="accountledgerinfo"></param>
        public void AccountLedgerEdit(AccountLedgerInfo accountledgerinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Email;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = accountledgerinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.CreditLimit;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.BillByBill;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountledgerinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.IsDefault;
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
        /// Function to get all the values from account ledger table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Account Ledger ViewAll For ComboBox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerViewAllForComboBox()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewAllForComboBox", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Account Ledger Search For ServiceAccount Under Income
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerSearchForServiceAccountUnderIncome()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerSearchForServiceAccountUnderIncome", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Function to get particular values from account ledger table based on the parameter
        /// </summary>
        /// <param name="ledgerId"></param>
        /// <returns></returns>
        public AccountLedgerInfo AccountLedgerView(decimal ledgerId)
        {
            AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    accountledgerinfo.LedgerId = Convert.ToDecimal(sdrreader["ledgerId"].ToString());
                    accountledgerinfo.AccountGroupId = Convert.ToDecimal(sdrreader["accountGroupId"].ToString());
                    accountledgerinfo.LedgerName = sdrreader["ledgerName"].ToString();
                    accountledgerinfo.OpeningBalance = Convert.ToDecimal(sdrreader["openingBalance"].ToString());
                    accountledgerinfo.CrOrDr = sdrreader["crOrDr"].ToString();
                    accountledgerinfo.Narration = sdrreader["narration"].ToString();
                    accountledgerinfo.MailingName = sdrreader["mailingName"].ToString();
                    accountledgerinfo.Address = sdrreader["address"].ToString();
                    accountledgerinfo.Phone = sdrreader["phone"].ToString();
                    accountledgerinfo.Mobile = sdrreader["mobile"].ToString();
                    accountledgerinfo.Email = sdrreader["email"].ToString();
                    accountledgerinfo.CreditPeriod = Convert.ToInt32(sdrreader["creditPeriod"].ToString());
                    accountledgerinfo.CreditLimit = Convert.ToDecimal(sdrreader["creditLimit"].ToString());
                    accountledgerinfo.PricinglevelId = Convert.ToDecimal(sdrreader["pricinglevelId"].ToString());
                    accountledgerinfo.BillByBill = Convert.ToBoolean(sdrreader["billByBill"].ToString());
                    accountledgerinfo.Tin = sdrreader["tin"].ToString();
                    accountledgerinfo.Cst = sdrreader["cst"].ToString();
                    accountledgerinfo.Pan = sdrreader["pan"].ToString();
                    accountledgerinfo.RouteId = Convert.ToDecimal(sdrreader["routeId"].ToString());
                    accountledgerinfo.BankAccountNumber = sdrreader["bankAccountNumber"].ToString();
                    accountledgerinfo.BranchName = sdrreader["branchName"].ToString();
                    accountledgerinfo.BranchCode = sdrreader["branchCode"].ToString();
                    accountledgerinfo.ExtraDate = Convert.ToDateTime(sdrreader["extraDate"].ToString());
                    accountledgerinfo.Extra1 = sdrreader["extra1"].ToString();
                    accountledgerinfo.Extra2 = sdrreader["extra2"].ToString();
                    accountledgerinfo.AreaId = Convert.ToDecimal(sdrreader["areaId"].ToString());
                    accountledgerinfo.IsDefault = Convert.ToBoolean(sdrreader["isDefault"].ToString());
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
            return accountledgerinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="LedgerId"></param>
        public void AccountLedgerDelete(decimal LedgerId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = LedgerId;
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
        /// To get the next id for accountledger
        /// </summary>
        /// <returns></returns>
        public int AccountLedgerGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerMax", sqlcon);
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
        /// Function to insert values to account ledger table and returns the id of inserted
        /// </summary>
        /// <param name="accountledgerinfo"></param>
        /// <returns></returns>
        public decimal AccountLedgerAddWithIdentity(AccountLedgerInfo accountledgerinfo)
        {
            decimal decLedgerId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerAddWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Email;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = accountledgerinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.CreditLimit;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.BillByBill;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountledgerinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.IsDefault;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decLedgerId = Convert.ToDecimal(obj.ToString());
                }
                else
                {
                    decLedgerId = 0;
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
            return decLedgerId;
        }
        /// <summary>
        /// Function to Account ledger Search based on the parameter
        /// </summary>
        /// <param name="straccountgroupname"></param>
        /// <param name="strledgername"></param>
        /// <returns></returns>
        public List<DataTable> AccountLedgerSearch(String straccountgroupname, String strledgername)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblAccountLedger = new DataTable();
            dtblAccountLedger.Columns.Add("SL.NO", typeof(decimal));
            dtblAccountLedger.Columns["SL.NO"].AutoIncrement = true;
            dtblAccountLedger.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtblAccountLedger.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = straccountgroupname;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
                sqlda.Fill(dtblAccountLedger);
                ListObj.Add(dtblAccountLedger);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Function to view the account ledger details for perticular ledgerId for edit
        /// </summary>
        /// <param name="ledgerId"></param>
        /// <returns></returns>
        public AccountLedgerInfo AccountLedgerViewForEdit(decimal ledgerId)
        {
            AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerViewForEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    accountledgerinfo.LedgerId = decimal.Parse(sdrreader[0].ToString());
                    accountledgerinfo.AccountGroupId = decimal.Parse(sdrreader[1].ToString());
                    accountledgerinfo.LedgerName = sdrreader[2].ToString();
                    accountledgerinfo.OpeningBalance = decimal.Parse(sdrreader[3].ToString());
                    accountledgerinfo.CrOrDr = sdrreader[4].ToString();
                    accountledgerinfo.Narration = sdrreader[5].ToString();
                    accountledgerinfo.MailingName = sdrreader[6].ToString();
                    accountledgerinfo.Address = sdrreader[7].ToString();
                    accountledgerinfo.Phone = sdrreader[8].ToString();
                    accountledgerinfo.Mobile = sdrreader[9].ToString();
                    accountledgerinfo.Email = sdrreader[10].ToString();
                    accountledgerinfo.CreditPeriod = int.Parse(sdrreader[11].ToString());
                    accountledgerinfo.CreditLimit = decimal.Parse(sdrreader[12].ToString());
                    accountledgerinfo.PricinglevelId = decimal.Parse(sdrreader[13].ToString());
                    accountledgerinfo.BillByBill = bool.Parse(sdrreader[14].ToString());
                    accountledgerinfo.Tin = sdrreader[15].ToString();
                    accountledgerinfo.Cst = sdrreader[16].ToString();
                    accountledgerinfo.Pan = sdrreader[17].ToString();
                    accountledgerinfo.RouteId = decimal.Parse(sdrreader[18].ToString());
                    accountledgerinfo.BankAccountNumber = sdrreader[19].ToString();
                    accountledgerinfo.BranchName = sdrreader[20].ToString();
                    accountledgerinfo.BranchCode = sdrreader[21].ToString();
                    accountledgerinfo.ExtraDate = DateTime.Parse(sdrreader[22].ToString());
                    accountledgerinfo.Extra1 = sdrreader[23].ToString();
                    accountledgerinfo.Extra2 = sdrreader[24].ToString();
                    accountledgerinfo.AreaId = decimal.Parse(sdrreader[25].ToString());
                    accountledgerinfo.IsDefault = bool.Parse(sdrreader[26].ToString());
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
            return accountledgerinfo;
        }
        /// <summary>
        /// Function to get the secondary details of accountledger
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerForSecondaryDetails()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblAccountLedger = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerForSecondaryDetails", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtblAccountLedger);
                ListObj.Add(dtblAccountLedger);
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
        /// Function to ckeck the existance of accountledger
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public bool AccountLedgerCheckExistence(String strLedgerName, decimal decLedgerId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strLedgerName;
                sprmparam = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
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
        /// Function to fill the multiple accountledger combobox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> MultipleAccountLedgerComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblAccountLedger = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("MultipleAccountLedgerComboFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtblAccountLedger);
                ListObj.Add(dtblAccountLedger);
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
        /// Function to fill the area combobox for customer
        /// </summary>
        /// <returns></returns>
        public List<DataTable> cmbAreafillInCustomer()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblAccountLedger = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AreafillInCustomer", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtblAccountLedger);
                ListObj.Add(dtblAccountLedger);
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
        /// Function for pricinglevelcombobox fill for customer
        /// </summary>
        /// <returns></returns>
        public List<DataTable> cmbPricingLevelInCustomer()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblAccountLedger = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PricingLevelFillinCustomer", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtblAccountLedger);
                ListObj.Add(dtblAccountLedger);
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
        /// Function for routecombobox fill for customer
        /// </summary>
        /// <param name="decAreaId"></param>
        /// <returns></returns>
        public List<DataTable> cmbRoutInCustomer(decimal decAreaId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RoutFillinCustomer", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal).Value = decAreaId;
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
        /// Function to insert values to account ledger Table for customer
        /// </summary>
        /// <param name="accountledgerinfo"></param>
        /// <returns></returns>
        public decimal AccountLedgerAddForCustomer(AccountLedgerInfo accountledgerinfo)
        {
            decimal decledgerid = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerAddForCustomer", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Email;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = accountledgerinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.CreditLimit;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.BillByBill;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Extra2;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountledgerinfo.ExtraDate;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decledgerid = Convert.ToDecimal(obj.ToString());
                }
                else
                {
                    decledgerid = 0;
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
            return decledgerid;
        }
        /// <summary>
        /// Account ledger check existance for customer
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public bool AccountLedgerCheckExistenceForCustomer(String strLedgerName, decimal decLedgerId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistenceForCustomer", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strLedgerName;
                sprmparam = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
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
        /// Account ledger search for customer
        /// </summary>
        /// <param name="decAreaId"></param>
        /// <param name="decRouteId"></param>
        /// <param name="strledgername"></param>
        /// <returns></returns>
        public List<DataTable> AccountLedgerSearchforCustomer(decimal decAreaId, decimal decRouteId, string strledgername)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblAccountLedger = new DataTable();
            dtblAccountLedger.Columns.Add("Sl.No", typeof(decimal));
            dtblAccountLedger.Columns["Sl.No"].AutoIncrement = true;
            dtblAccountLedger.Columns["Sl.No"].AutoIncrementSeed = 1;
            dtblAccountLedger.Columns["Sl.No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerSearchforCustomer", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@areaId", SqlDbType.VarChar).Value = decAreaId;
                sqlda.SelectCommand.Parameters.Add("@routeId", SqlDbType.VarChar).Value = decRouteId;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
                sqlda.Fill(dtblAccountLedger);
                ListObj.Add(dtblAccountLedger);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ListObj;
        }
        /// <summary>
        /// Account ledger details view for customer
        /// </summary>
        /// <param name="ledgerId"></param>
        /// <returns></returns>
        public AccountLedgerInfo AccountLedgerViewForCustomer(decimal ledgerId)
        {
            AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerViewForCustomer", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    accountledgerinfo.LedgerId = decimal.Parse(sdrreader[0].ToString());
                    accountledgerinfo.LedgerName = sdrreader[1].ToString();
                    accountledgerinfo.OpeningBalance = decimal.Parse(sdrreader[2].ToString());
                    accountledgerinfo.CrOrDr = sdrreader[3].ToString();
                    accountledgerinfo.Narration = sdrreader[4].ToString();
                    accountledgerinfo.MailingName = sdrreader[5].ToString();
                    accountledgerinfo.Address = sdrreader[6].ToString();
                    accountledgerinfo.Phone = sdrreader[7].ToString();
                    accountledgerinfo.Mobile = sdrreader[8].ToString();
                    accountledgerinfo.Email = sdrreader[9].ToString();
                    accountledgerinfo.CreditPeriod = int.Parse(sdrreader[10].ToString());
                    accountledgerinfo.CreditLimit = decimal.Parse(sdrreader[11].ToString());
                    accountledgerinfo.PricinglevelId = decimal.Parse(sdrreader[12].ToString());
                    accountledgerinfo.BillByBill = bool.Parse(sdrreader[13].ToString());
                    accountledgerinfo.Tin = sdrreader[14].ToString();
                    accountledgerinfo.Cst = sdrreader[15].ToString();
                    accountledgerinfo.Pan = sdrreader[16].ToString();
                    accountledgerinfo.RouteId = decimal.Parse(sdrreader[17].ToString());
                    accountledgerinfo.BankAccountNumber = sdrreader[18].ToString();
                    accountledgerinfo.BranchName = sdrreader[19].ToString();
                    accountledgerinfo.BranchCode = sdrreader[20].ToString();
                    accountledgerinfo.AreaId = decimal.Parse(sdrreader[21].ToString());
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
            return accountledgerinfo;
        }
        /// <summary>
        /// Account ledger edit for customer
        /// </summary>
        /// <param name="accountledgerinfo"></param>
        public void AccountLedgerEditForCustomer(AccountLedgerInfo accountledgerinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerEditForCustomer", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Email;
                sprmparam = sccmd.Parameters.Add("@creditPeriod", SqlDbType.Int);
                sprmparam.Value = accountledgerinfo.CreditPeriod;
                sprmparam = sccmd.Parameters.Add("@creditLimit", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.CreditLimit;
                sprmparam = sccmd.Parameters.Add("@pricinglevelId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.PricinglevelId;
                sprmparam = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.BillByBill;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountledgerinfo.ExtraDate;
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
        /// Supplier search based on the ledgername, routeId, areaId
        /// </summary>
        /// <param name="deecAreaId"></param>
        /// <param name="decRouteId"></param>
        /// <param name="strledgername"></param>
        /// <returns></returns>
        public List<DataTable> SupplierSearchAll(decimal deecAreaId, decimal decRouteId, string strledgername)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl.No", typeof(decimal));
            dtbl.Columns["Sl.No"].AutoIncrement = true;
            dtbl.Columns["Sl.No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl.No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SupplierSearchAll", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@areaId", SqlDbType.Decimal).Value = deecAreaId;
                sqlda.SelectCommand.Parameters.Add("@routeId", SqlDbType.Decimal).Value = decRouteId;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
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
        /// Account ledger edit for salesman
        /// </summary>
        /// <param name="accountledgerinfo"></param>
        public void AccountLedgerEditForSalesman(AccountLedgerInfo accountledgerinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerEditForSalesman", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("@openingBalance", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@mailingName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.MailingName;
                sprmparam = sccmd.Parameters.Add("@address", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Address;
                sprmparam = sccmd.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Phone;
                sprmparam = sccmd.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Mobile;
                sprmparam = sccmd.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Email;
                sprmparam = sccmd.Parameters.Add("@billByBill", SqlDbType.Bit);
                sprmparam.Value = accountledgerinfo.BillByBill;
                sprmparam = sccmd.Parameters.Add("@tin", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Tin;
                sprmparam = sccmd.Parameters.Add("@cst", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Cst;
                sprmparam = sccmd.Parameters.Add("@pan", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.Pan;
                sprmparam = sccmd.Parameters.Add("@RouteId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.RouteId;
                sprmparam = sccmd.Parameters.Add("@bankAccountNumber", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("@branchName", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("@branchCode", SqlDbType.VarChar);
                sprmparam.Value = accountledgerinfo.BranchCode;
                sprmparam = sccmd.Parameters.Add("@areaId", SqlDbType.Decimal);
                sprmparam.Value = accountledgerinfo.AreaId;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountledgerinfo.ExtraDate;
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
        /// Account ledger check existance for salesman
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public bool AccountLedgerCheckExistenceForSalesman(String strLedgerName, decimal decLedgerId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistenceForSalesman", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strLedgerName;
                sprmparam = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
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
        /// Account ledger view details for supplier
        /// </summary>
        /// <param name="ledgerId"></param>
        /// <returns></returns>
        public AccountLedgerInfo AccountLedgerViewForSupplier(decimal ledgerId)
        {
            AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerViewForSupplier", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    accountledgerinfo.LedgerId = Convert.ToDecimal(sdrreader[0].ToString());
                    accountledgerinfo.LedgerName = sdrreader[1].ToString();
                    accountledgerinfo.OpeningBalance = Convert.ToDecimal(sdrreader[2].ToString());
                    accountledgerinfo.CrOrDr = sdrreader[3].ToString();
                    accountledgerinfo.Narration = sdrreader[4].ToString();
                    accountledgerinfo.MailingName = sdrreader[5].ToString();
                    accountledgerinfo.Address = sdrreader[6].ToString();
                    accountledgerinfo.Phone = sdrreader[7].ToString();
                    accountledgerinfo.Mobile = sdrreader[8].ToString();
                    accountledgerinfo.Email = sdrreader[9].ToString();
                    accountledgerinfo.BillByBill = Convert.ToBoolean(sdrreader[10].ToString());
                    accountledgerinfo.Tin = sdrreader[11].ToString();
                    accountledgerinfo.Cst = sdrreader[12].ToString();
                    accountledgerinfo.Pan = sdrreader[13].ToString();
                    accountledgerinfo.RouteId = Convert.ToDecimal(sdrreader[14].ToString());
                    accountledgerinfo.BankAccountNumber = sdrreader[15].ToString();
                    accountledgerinfo.BranchName = sdrreader[16].ToString();
                    accountledgerinfo.BranchCode = sdrreader[17].ToString();
                    accountledgerinfo.AreaId = Convert.ToDecimal(sdrreader[18].ToString());
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
            return accountledgerinfo;
        }
        /// <summary>
        /// ledger search for popup
        /// </summary>
        /// <param name="strledgername"></param>
        /// <param name="straccountgroupname"></param>
        /// <param name="decId1"></param>
        /// <param name="decId2"></param>
        /// <returns></returns>
        public List<DataTable> LedgerPopupSearch(String strledgername, String straccountgroupname, decimal decId1, decimal decId2)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No", typeof(decimal));
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("LedgerPopupSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgername;
                sqlda.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = straccountgroupname;
                sqlda.SelectCommand.Parameters.Add("@id1", SqlDbType.Decimal).Value = decId1;
                sqlda.SelectCommand.Parameters.Add("@id2", SqlDbType.Decimal).Value = decId2;
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
        /// Ledger popupsearch for ServiceAccounts under income
        /// </summary>
        /// <returns></returns>
        public List<DataTable> LedgerPopupSearchForServiceAccountsUnderIncome()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No", typeof(decimal));
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerSearchForServiceAccountUnderIncome", sqlcon);
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
        /// Account ledger details view under bank
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerForBankDetails()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable btblAccountLedger = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerForBankDetails", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(btblAccountLedger);
                ListObj.Add(btblAccountLedger);
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
        /// Account ledger referance check
        /// </summary>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public decimal AccountLedgerCheckReferences(decimal decledgerId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckReferences", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decledgerId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
        }
        /// <summary>
        /// Supplier reference check and delete
        /// </summary>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public decimal SupplierCheckreferenceAndDelete(decimal decledgerId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SupplierCheckreferenceAndDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decledgerId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
        }
        /// <summary>
        /// Accountgroup Id check by ledgername 
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <returns></returns>
        public bool AccountGroupIdCheck(string strLedgerName)
        {
            bool isSundryCreditOrDebit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupIdCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strLedgerName;
                isSundryCreditOrDebit = Convert.ToBoolean(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isSundryCreditOrDebit;
        }
        /// <summary>
        /// credit or debit checking based on the nature
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public String CreditOrDebitChecking(decimal decLedgerId)
        {
            string strNature = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CreditOrDebitChecking", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                strNature = sccmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return strNature;
        }
        /// <summary>
        /// Ledgerposting delete by voucherNo and voucherType
        /// </summary>
        /// <param name="strVocuherNumber"></param>
        /// <param name="decvoucherTypeId"></param>
        public void LedgerPostingDeleteByVoucherTypeAndVoucherNo(string strVocuherNumber, decimal decvoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("LedgerPostingDeleteByVoucherTypeAndVoucherNo", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVocuherNumber;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decvoucherTypeId;
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
        /// Party balance delete by vouchertype and voucherNo
        /// </summary>
        /// <param name="strVocuherNumber"></param>
        /// <param name="decVoucherTypeId"></param>
        public void PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType(string strVocuherNumber, decimal decVoucherTypeId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVocuherNumber;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = decVoucherTypeId;
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
        /// Partybalance against reference check
        /// </summary>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public bool PartyBalanceAgainstReferenceCheck(string strVoucherNo, decimal decVoucherTypeId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PartyBalanceAgainstReferenceCheck", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = decVoucherTypeId;
                isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
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
        /// ckecking account ledger lies under bank or cash
        /// </summary>
        /// <param name="strLedgerId"></param>
        /// <returns></returns>
        public bool AccountLedgerUnderBankOrCash(string strLedgerId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerUnderCashOrParty", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
                sprmparam.Value = strLedgerId;
                isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Suit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isExist;
        }
        /// <summary>
        /// Account ledger negative balance check
        /// </summary>
        /// <param name="strLedgerId"></param>
        /// <param name="strCrOrDr"></param>
        /// <param name="dcAmount"></param>
        /// <param name="strVoucherType"></param>
        /// <param name="strVoucherNo"></param>
        /// <returns></returns>
        public bool AccountLedgerCheckNegativeBalance(string strLedgerId, string strCrOrDr, decimal dcAmount, string strVoucherType, string strVoucherNo)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerGetCurerntBalanceOfLedgerToCheckNegativeBalance", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
                sprmparam.Value = strLedgerId;
                sprmparam = sccmd.Parameters.Add("@crOrDr", SqlDbType.VarChar);
                sprmparam.Value = strCrOrDr;
                sprmparam = sccmd.Parameters.Add("@amt", SqlDbType.Decimal);
                sprmparam.Value = dcAmount;
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.VarChar);
                sprmparam.Value = strVoucherType;
                sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
                sprmparam.Value = strVoucherNo;
                isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
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
        /// Account ledger view for additional cost
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountLedgerViewForAdditionalCost()
        {
            DataTable dtbl = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewForAdditionalCost", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Account ledger details view by id
        /// </summary>
        /// <param name="ledgerId"></param>
        /// <returns></returns>
        public AccountLedgerInfo accountLedgerviewbyId(decimal ledgerId)
        {
            AccountLedgerInfo accountledgerinfo = new AccountLedgerInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = ledgerId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    accountledgerinfo.LedgerId = Convert.ToDecimal(sdrreader["ledgerId"].ToString());
                    accountledgerinfo.LedgerName = sdrreader["ledgerName"].ToString();
                    accountledgerinfo.CreditPeriod = Convert.ToInt32(sdrreader["creditPeriod"].ToString());
                    accountledgerinfo.PricinglevelId = Convert.ToDecimal(sdrreader["pricinglevelId"].ToString());
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
            return accountledgerinfo;
        }
        /// <summary>
        /// check ledger balance
        /// </summary>
        /// <param name="decledgerId"></param>
        /// <returns></returns>
        public decimal CheckLedgerBalance(decimal decledgerId)
        {
            decimal inBalance = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("CheckLedgerBalance", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.VarChar);
                sprmparam.Value = decledgerId;
                inBalance = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return inBalance;
        }
        /// <summary>
        /// Account ledger Id get by name
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <returns></returns>
        public decimal AccountLedgerIdGetByName(string strLedgerName)
        {
            decimal decLedgerId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountLedgerIdGetByName", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strLedgerName;
                decLedgerId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decLedgerId;
        }
        /// <summary>
        /// Account groupId check for sundry creditor
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <returns></returns>
        public bool AccountGroupIdCheckSundryCreditorOnly(string strLedgerName)
        {
            bool isSundrycredit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupIdCheckSundryCreditorOnly", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strLedgerName;
                isSundrycredit = Convert.ToBoolean(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isSundrycredit;
        }
        /// <summary>
        /// AccountgroupId check for sundry deptors
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <returns></returns>
        public bool AccountGroupIdCheckSundryDeptor(string strLedgerName)
        {
            bool isSundryDebit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupIdCheckSundryDeptor", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strLedgerName;
                isSundryDebit = Convert.ToBoolean(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isSundryDebit;
        }
        /// <summary>
        /// Account ledger view details by accountgroupId
        /// </summary>
        /// <param name="decaccountGroupId"></param>
        /// <returns></returns>
        public List<DataTable> AccountLedgerViewAllByLedgerName(decimal decaccountGroupId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerViewAllByLedgerName", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decaccountGroupId;
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
        /// Party addressbook search
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="strmobile"></param>
        /// <param name="strphone"></param>
        /// <param name="stremail"></param>
        /// <param name="strledgerName"></param>
        /// <returns></returns>
        public List<DataTable> PartyAddressBookSearch(string strType, string strmobile, string strphone, string stremail, string strledgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Sl No", typeof(int));
            dtbl.Columns["Sl No"].AutoIncrement = true;
            dtbl.Columns["Sl No"].AutoIncrementSeed = 1;
            dtbl.Columns["Sl No"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("PartyAddressBookSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = strType;
                sqlda.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strledgerName;
                sqlda.SelectCommand.Parameters.Add("@mobile", SqlDbType.VarChar).Value = strmobile;
                sqlda.SelectCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = strphone;
                sqlda.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = stremail;
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
        /// Function to print party addressbook
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="strmobile"></param>
        /// <param name="strphone"></param>
        /// <param name="stremail"></param>
        /// <param name="strledgerName"></param>
        /// <returns></returns>
        public List<DataTable> PartyAddressBookPrint(string strType, string strmobile, string strphone, string stremail, string strledgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
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
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PartyAddressBookPrint", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@type", SqlDbType.VarChar);
                sprmparam.Value = strType;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar);
                sprmparam.Value = strledgerName;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@mobile", SqlDbType.VarChar);
                sprmparam.Value = strmobile;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@phone", SqlDbType.VarChar);
                sprmparam.Value = strphone;
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar);
                sprmparam.Value = stremail;
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
        /// Account ledger report fill
        /// </summary>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="decAccountGroupId"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public List<DataTable> AccountLedgerReportFill(DateTime dtFromDate, DateTime dtToDate, decimal decAccountGroupId, decimal decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerReportFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
                sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
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
        /// Account ledger view by account group
        /// </summary>
        /// <param name="decAccounGroupId"></param>
        /// <returns></returns>
        public List<DataTable> AccountLedgerViewByAccountGroup(decimal decAccounGroupId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerViewByAccountGroup", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccounGroupId;
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
        /// Additional cost get
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AdditionalCostGet()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerViewForAdditionalCost", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        /// Acount ledger report printing 
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decAccountGroupId"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public DataSet AccountLedgerReportPrinting(decimal decCompanyId, DateTime fromDate, DateTime toDate, decimal decAccountGroupId, decimal decLedgerId)
        {
            DataSet dSt = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountLedgerReportPrint", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                param.Value = decCompanyId;
                param = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                param.Value = fromDate;
                param = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                param.Value = toDate;
                param = sqlda.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                param.Value = decAccountGroupId;
                param = sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                param.Value = decLedgerId;
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
        /// Ledger details fill corresponding to ledgerId
        /// </summary>
        /// <param name="dtFromDate"></param>
        /// <param name="dtToDate"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public DataSet LedgerDetailsFillCorrespondingToledgerId(DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId)
        {
            DataSet dsLedgerDetails = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("LedgerDetailsFillCorrespondingToledgerId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromDate;
                sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
                sqlda.SelectCommand.Parameters.Add("@ledgerId", SqlDbType.Decimal).Value = decLedgerId;
                sqlda.SelectCommand.Parameters.Add("@noOfDecimalPlace", SqlDbType.Decimal).Value = PublicVariables._inNoOfDecimalPlaces;
                sqlda.Fill(dsLedgerDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dsLedgerDetails;
        }
        /// <summary>
        /// Bill allocation ledger fill
        /// </summary>
        /// <param name="cmbAccountLedger"></param>
        /// <param name="strAccountGroup"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> BillAllocationLedgerFill(ComboBox cmbAccountLedger, string strAccountGroup, bool isAll)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BillAllocationLedgerFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sdaadapter.SelectCommand.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
                sprmparam.Value = strAccountGroup;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
                if (isAll)
                {
                    DataRow dr = ListObj[0].NewRow();
                    dr["ledgerName"] = "All";
                    dr["ledgerId"] = 0;
                    ListObj[0].Rows.InsertAt(dr, 0);
                }
                cmbAccountLedger.DataSource = ListObj[0];
                cmbAccountLedger.DisplayMember = "ledgerName";
                cmbAccountLedger.ValueMember = "ledgerId";
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
        /// Function to ckeck the existance of accountledger
        /// </summary>
        /// <param name="strLedgerName"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public bool AccountLedgerCheckExistenceForTax(string strTaxName)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AccountLedgerCheckExistenceForTax", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@taxName", SqlDbType.VarChar);
                sprmparam.Value = strTaxName;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
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
    }
}
