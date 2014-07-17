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
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms;
namespace OpenMiracle.BLL
{
    public class AccountGroupBll
    {
        AccountGroupSP spAccountGroup = new AccountGroupSP();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAccountGroupName"></param>
        /// <param name="strGroupUnder"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupSearch(string strAccountGroupName, string strGroupUnder)
        {
             List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.AccountGroupSearch(strAccountGroupName, strGroupUnder);
            }
            catch(Exception ex)
            {
                MessageBox.Show("AG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountGroupViewAllComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.AccountGroupViewAllComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAccountGroupName"></param>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public bool AccountGroupCheckExistence(string strAccountGroupName, decimal decAccountGroupId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spAccountGroup.AccountGroupCheckExistence(strAccountGroupName, decAccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infoAccountGroup"></param>
        /// <returns></returns>
        public decimal AccountGroupAddWithIdentity(AccountGroupInfo infoAccountGroup)
        {
            decimal decAccountGroupId = 0;
            try
            {
                decAccountGroupId = spAccountGroup.AccountGroupAddWithIdentity(infoAccountGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decAccountGroupId;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infoAccountGroup"></param>
        /// <returns></returns>
        public bool AccountGroupUpdate(AccountGroupInfo infoAccountGroup)
        {
            bool isEdit = false;
            try
            {
                isEdit = spAccountGroup.AccountGroupUpdate(infoAccountGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public decimal AccountGroupReferenceDelete(decimal decAccountGroupId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spAccountGroup.AccountGroupReferenceDelete(decAccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public AccountGroupInfo AccountGroupViewForUpdate(decimal decAccountGroupId)
        {
            AccountGroupInfo AccountGroupinfo = new AccountGroupInfo();
            try
            {
                AccountGroupinfo = spAccountGroup.AccountGroupViewForUpdate(decAccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return AccountGroupinfo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public string AccountGroupNatureUnderGroup(decimal decAccountGroupId)
        {
            string strNature = string.Empty;
            try
            {
                strNature = spAccountGroup.AccountGroupNatureUnderGroup(decAccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strNature;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public bool AccountGroupCheckExistenceOfUnderGroup(decimal decAccountGroupId)
        {
            bool isDelete = false;
            try
            {
                isDelete = spAccountGroup.AccountGroupCheckExistenceOfUnderGroup(decAccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isDelete;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AccountGroupId"></param>
        /// <returns></returns>
        public AccountGroupInfo AccountGroupView(decimal AccountGroupId)
        {
            AccountGroupInfo infoAccountGroup = new AccountGroupInfo();
            try
            {
                infoAccountGroup = spAccountGroup.AccountGroupView(AccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoAccountGroup;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupViewAllByGroupUnder(decimal decAccountGroupId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.AccountGroupViewAllByGroupUnder(decAccountGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj; 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupReportFill(DateTime dtmFromDate, DateTime dtmToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.AccountGroupReportFill(dtmFromDate, dtmToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> AccountGroupViewAllComboFillForAccountLedger()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.AccountGroupViewAllComboFillForAccountLedger();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.AccountGroupWiseReportViewAll(decAccountGroupId, dtmFromDate, dtmToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> GroupNameViewForComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.GroupNameViewForComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmbAccountGroup"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<DataTable> BillAllocationAccountGroupFill(ComboBox cmbAccountGroup, bool isAll)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.BillAllocationAccountGroupFill(cmbAccountGroup, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
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
                ds = spAccountGroup.CashBankBookPrinting(decCompanyId, fromDate, toDate, openingBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAccountGroup"></param>
        /// <returns></returns>
        public string MultipleAccountLedgerCrOrDr(string strAccountGroup)
        {
            string strNature = string.Empty;
            try
            {
                strNature = spAccountGroup.MultipleAccountLedgerCrOrDr(strAccountGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strNature;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> CheckWheatherLedgerUnderCash()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.CheckWheatherLedgerUnderCash();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public bool AccountGroupwithLedgerId(decimal decLedgerId)
        {
            bool isExist = false;
            try
            {
                isExist = spAccountGroup.AccountGroupwithLedgerId(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> AccountGroupWiseReportForProfitAndLossLedger(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.AccountGroupWiseReportForProfitAndLossLedger(decAccountGroupId, dtmFromDate, dtmToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> CashflowAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.CashflowAccountGroupWiseReportViewAll(decAccountGroupId, dtmFromDate, dtmToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> CashOutflowCurrentAssetAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.CashOutflowCurrentAssetAccountGroupWiseReportViewAll(decAccountGroupId, dtmFromDate, dtmToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decAccountGroupId"></param>
        /// <param name="dtmFromDate"></param>
        /// <param name="dtmToDate"></param>
        /// <returns></returns>
        public List<DataTable> CashInflowLoansAccountGroupWiseReportViewAll(decimal decAccountGroupId, DateTime dtmFromDate, DateTime dtmToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAccountGroup.CashInflowLoansAccountGroupWiseReportViewAll(decAccountGroupId, dtmFromDate, dtmToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AG24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
          
    }
}
