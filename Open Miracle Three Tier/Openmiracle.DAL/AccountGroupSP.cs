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
//Summary description for AccountGroupSP    
//</summary>    
namespace OpenMiracle.DAL
{
     public class AccountGroupSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to account group Table
        /// </summary>
        /// <param name="accountgroupinfo"></param>
        public void AccountGroupAdd(AccountGroupInfo accountgroupinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountgroupinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountGroupName;
                sprmparam = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
                sprmparam.Value = accountgroupinfo.GroupUnder;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Nature;
                sprmparam = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.AffectGrossProfit;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountgroupinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra2;
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
        /// Function to Update values in account group Table
        /// </summary>
        /// <param name="accountgroupinfo"></param>
        public void AccountGroupEdit(AccountGroupInfo accountgroupinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountgroupinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountGroupName;
                sprmparam = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
                sprmparam.Value = accountgroupinfo.GroupUnder;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Nature;
                sprmparam = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.AffectGrossProfit;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = accountgroupinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra2;
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
        /// Function to get all the values from account group Table
        /// </summary>
        /// <returns></returns>
        public DataTable AccountGroupViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountGroupViewAll", sqlcon);
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
        /// Function to get particular values from account group table based on the parameter
        /// </summary>
        /// <param name="accountGroupId"></param>
        /// <returns></returns>
        public AccountGroupInfo AccountGroupView(decimal accountGroupId)
        {
            AccountGroupInfo accountgroupinfo = new AccountGroupInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountGroupId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    accountgroupinfo.AccountGroupId = decimal.Parse(sdrreader[0].ToString());
                    accountgroupinfo.AccountGroupName = sdrreader[1].ToString();
                    accountgroupinfo.GroupUnder = decimal.Parse(sdrreader[2].ToString());
                    accountgroupinfo.Narration = sdrreader[3].ToString();
                    accountgroupinfo.IsDefault = bool.Parse(sdrreader[4].ToString());
                    accountgroupinfo.Nature = sdrreader[5].ToString();
                    accountgroupinfo.AffectGrossProfit = sdrreader[6].ToString();
                    accountgroupinfo.ExtraDate = DateTime.Parse(sdrreader[7].ToString());
                    accountgroupinfo.Extra1 = sdrreader[8].ToString();
                    accountgroupinfo.Extra2 = sdrreader[9].ToString();
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
            return accountgroupinfo;
        }
        /// <summary>
        /// Function to get particular values from account group table based on the parameter for profit and loss balance
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupWiseReportForProfitAndLossLedger(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
                SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupWiseReportForProfitAndLossLedger", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sqlparam.Value = decAccountGroupId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = dtmFromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = dtmToDate;
                sqldadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="AccountGroupId"></param>
        public void AccountGroupDelete(decimal AccountGroupId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = AccountGroupId;
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
        /// Function to insert values to account group table and return the Curresponding row's Id
        /// </summary>
        /// <param name="accountgroupinfo"></param>
        /// <returns></returns>
        public decimal AccountGroupAddWithIdentity(AccountGroupInfo accountgroupinfo)
        {
            decimal decAccountGroupId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupAddWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountGroupName;
                sprmparam = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
                sprmparam.Value = accountgroupinfo.GroupUnder;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Nature;
                sprmparam = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AffectGrossProfit;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra2;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    decAccountGroupId = decimal.Parse(obj.ToString());
                }
                else
                {
                    decAccountGroupId = 0;
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
            return decAccountGroupId;
        }
        /// <summary>
        /// Function to get all the values from account group table for combobox fill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountGroupViewAllComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountGroupViewAllComboFill", sqlcon);
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
        /// Function to get particular values from account group table based on the parameter for update
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public AccountGroupInfo AccountGroupViewForUpdate(decimal decAccountGroupId)
        {
            AccountGroupInfo accountgroupinfo = new AccountGroupInfo();
            SqlDataReader sqldr = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupViewForUpdate", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
                sqldr = sccmd.ExecuteReader();
                while (sqldr.Read())
                {
                    accountgroupinfo.AccountGroupId = decimal.Parse(sqldr["accountGroupId"].ToString());
                    accountgroupinfo.AccountGroupName = sqldr["accountGroupName"].ToString();
                    accountgroupinfo.GroupUnder = decimal.Parse(sqldr["groupUnder"].ToString());
                    accountgroupinfo.Narration = sqldr["narration"].ToString();
                    accountgroupinfo.IsDefault = bool.Parse(sqldr["isDefault"].ToString());
                    accountgroupinfo.Nature = sqldr["nature"].ToString();
                   accountgroupinfo.AffectGrossProfit = sqldr["affectGrossProfit"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqldr.Close();
                sqlcon.Close();
            }
            return accountgroupinfo;
        }
        /// <summary>
        /// Function to check References of account group for add or delete
        /// </summary>
        /// <param name="strAccountGroupName"></param>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public bool AccountGroupCheckExistence(string strAccountGroupName, decimal decAccountGroupId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AccountGroupCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
                sprmparam.Value = strAccountGroupName;
                sprmparam = sqlcmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = decAccountGroupId;
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
        /// Account group Update based on the condition
        /// </summary>
        /// <param name="accountgroupinfo"></param>
        /// <returns></returns>
        public bool AccountGroupUpdate(AccountGroupInfo accountgroupinfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = accountgroupinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountGroupName;
                sprmparam = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
                sprmparam.Value = accountgroupinfo.GroupUnder;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@isDefault", SqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("@nature", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Nature;
                sprmparam = sccmd.Parameters.Add("@affectGrossProfit", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AffectGrossProfit;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra2;
                int inAffectedRows = sccmd.ExecuteNonQuery();
                if (inAffectedRows > 0)
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
        /// Function to Account Group Search based on the parameter
        /// </summary>
        /// <param name="strAccountGroupName"></param>
        /// <param name="strGroupUnder"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupSearch(string strAccountGroupName, string strGroupUnder)
        {
            DataTable dtblAccountGroup = new DataTable();
            List<DataTable> ListObj = new List<DataTable>();
           
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("AccountGroupSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtblAccountGroup.Columns.Add("Sl No", typeof(int));
                dtblAccountGroup.Columns["Sl No"].AutoIncrement = true;
                dtblAccountGroup.Columns["Sl No"].AutoIncrementSeed = 1;
                dtblAccountGroup.Columns["Sl No"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@AccountGroupName", SqlDbType.VarChar).Value = strAccountGroupName;
                sqlda.SelectCommand.Parameters.Add("@Under", SqlDbType.VarChar).Value = strGroupUnder;
                sqlda.Fill(dtblAccountGroup);
                ListObj.Add(dtblAccountGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get Account Group CheckExistence Of Under Group
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public bool AccountGroupCheckExistenceOfUnderGroup(decimal decAccountGroupId)
        {
            bool isDelete = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("AccountGroupCheckExistenceOfUnderGroup", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isDelete = true;
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
            return isDelete;
        }
        /// <summary>
        /// Function to get details of Account Group ViewAll ComboFill For AccountLedger
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountGroupViewAllComboFillForAccountLedger()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtblAccountGroup = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountGroupViewAllComboFillForAccountLedger", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtblAccountGroup);
                ListObj.Add(dtblAccountGroup);
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
        /// Function to get the status of Multiple AccountLedger Cr Or Dr 
        /// </summary>
        /// <param name="strAccountGroup"></param>
        /// <returns></returns>
        public string MultipleAccountLedgerCrOrDr(string strAccountGroup)
        {
            string strNature = string.Empty;
            try
            {
                SqlDataReader sqlDr = null;
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("MultipleAccountLedgerCrOrDr ", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@accountGroupName", SqlDbType.VarChar).Value = strAccountGroup;
                sqlDr = sqlCmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    strNature = sqlDr["nature"].ToString();
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
            return strNature;
        }
        /// <summary>
        /// Function to Check Wheather the Ledger Under Cash
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CheckWheatherLedgerUnderCash()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CheckWheatherLedgerUnderCash", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGSP :1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get Account Group Reference Delete
        /// </summary>
        /// <param name="AccountGroupId"></param>
        /// <returns></returns>
        public decimal AccountGroupReferenceDelete(decimal AccountGroupId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupReferenceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sprmparam.Value = AccountGroupId;
                decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
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
        /// function to get the status of Account Group with LedgerId
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public bool AccountGroupwithLedgerId(decimal decLedgerId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("AccountGroupwithLedgerId", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
                sprmparam.Value = decLedgerId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGSP :2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return isExist;
        }
        /// <summary>
        /// Function to get all the  Account Groups Under the account group
        /// </summary>
        /// <param name="decaccountGroupId"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupViewAllByGroupUnder(decimal decaccountGroupId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupViewAllByGroupUnder", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sqlparam.Value = decaccountGroupId;
                sqldadapter.Fill(dtbl);
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
        /// Function to get Account Group Report ViewAll
        /// </summary>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupReportFill(DateTime dtmFromDate, DateTime dtmToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupReportViewAll", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = dtmFromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = dtmToDate;
                sqldadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGSP :3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get Account GroupWise Report 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
                SqlDataAdapter sqldadapter = new SqlDataAdapter("AccountGroupWiseReportViewAll", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sqlparam.Value = decAccountGroupId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = dtmFromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = dtmToDate;
                sqldadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGSP :4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Cash flow Account Group WiseReport View All
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> CashflowAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
                SqlDataAdapter sqldadapter = new SqlDataAdapter("CashFlowCommen", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sqlparam.Value = decAccountGroupId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = dtmFromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = dtmToDate;
                sqldadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGSP :5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Cash In flow Loans Account Group WiseReport View All
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> CashInflowLoansAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
                SqlDataAdapter sqldadapter = new SqlDataAdapter("CashInflowLoansLiablity", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sqlparam.Value = decAccountGroupId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = dtmFromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = dtmToDate;
                sqldadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGSP :6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Cash Out flow CurrentAsset Account GroupWise Report ViewAll
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> CashOutflowCurrentAssetAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
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
                SqlDataAdapter sqldadapter = new SqlDataAdapter("CashOutflowCurrentAsset", sqlcon);
                sqldadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparam = new SqlParameter();
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@accountGroupId", SqlDbType.Decimal);
                sqlparam.Value = decAccountGroupId;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sqlparam.Value = dtmFromDate;
                sqlparam = sqldadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sqlparam.Value = dtmToDate;
                sqldadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGSP :7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to Group Name View For ComboFill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> GroupNameViewForComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("GroupNameViewForComboFill", sqlcon);
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
        /// FUnction to Cash Bank Book Printing
        /// </summary>
        /// <param name="decCompanyId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="openingBalance"></param>
        /// <returns></returns>
        public DataSet CashBankBookPrinting(decimal decCompanyId, DateTime fromDate, DateTime toDate, bool openingBalance)
        {
            DataSet ds = new DataSet();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("CashBankBookPrinting", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                
                sprmparam = sqlda.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
                sprmparam.Value = decCompanyId;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime);
                sprmparam.Value = fromDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime);
                sprmparam.Value = toDate;
                sprmparam = sqlda.SelectCommand.Parameters.Add("@isShowOpeningBalance", SqlDbType.Bit);
                sprmparam.Value = openingBalance;
                
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
        /// Function to Bill Allocation Account Group Fill
        /// </summary>
        /// <param name="cmbAccountGroup"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> BillAllocationAccountGroupFill(ComboBox cmbAccountGroup, bool isAll)
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BillAllocationAccountGroupFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
                if (isAll)
                {
                    DataRow dr = ListObj[0].NewRow();
                    dr["accountGroupName"] = "All";
                    dr["accountGroupId"] = 0;
                    ListObj[0].Rows.InsertAt(dr, 0);
                }
                cmbAccountGroup.DataSource = ListObj[0];
                cmbAccountGroup.DisplayMember = "accountGroupName";
                cmbAccountGroup.ValueMember = "accountGroupId";
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
        public string AccountGroupNatureUnderGroup(decimal decAccountGroupId)
        {
            string strNature = string.Empty;
            try
            {
                SqlDataReader sqlDr = null;
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("AccountGroupNatureUnderGroup ", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@accountGroupId", SqlDbType.Decimal).Value = decAccountGroupId;
                sqlDr = sqlCmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    strNature = sqlDr["nature"].ToString();
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
            return strNature;
        }
    }
}