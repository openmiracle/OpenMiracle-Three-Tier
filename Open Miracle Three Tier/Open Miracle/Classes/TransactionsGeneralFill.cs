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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
namespace Open_Miracle
{
    class TransactionsGeneralFill : DBConnection
    {
        /// <summary>
        /// Function to fill all cash or bank ledgers for combobox
        /// </summary>
        /// <param name="cmbCashOrBank"></param>
        /// <param name="isAll"></param>
        public void CashOrBankComboFill(ComboBox cmbCashOrBank, bool isAll)
        {
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                cmbCashOrBank.DataSource = dtbl;
                cmbCashOrBank.ValueMember = "ledgerId";
                cmbCashOrBank.DisplayMember = "ledgerName";
                cmbCashOrBank.SelectedIndex = -1;
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
        /// Function to fill all cash or parties ledgers to combobox
        /// </summary>
        /// <param name="cmbCashOrParty"></param>
        /// <param name="isAll"></param>
        public void CashOrPartyComboFill(ComboBox cmbCashOrParty, bool isAll)
        {
            // Fill all cash or party under Sundry Crediter
            DataTable dtblCashOrParty = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("CashOrPartyComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblCashOrParty);
                cmbCashOrParty.SelectedIndex = -1;
                if (isAll)
                {
                    DataRow dr = dtblCashOrParty.NewRow();
                    dr["ledgerName"] = "All";
                    dr["ledgerId"] = 0;
                    dtblCashOrParty.Rows.InsertAt(dr, 0);
                }
                cmbCashOrParty.DataSource = dtblCashOrParty;
                cmbCashOrParty.DisplayMember = "ledgerName";
                cmbCashOrParty.ValueMember = "ledgerId";
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
        /// Function to get next VoucherNo for voucher on Automatic generation 
        /// </summary>
        /// <param name="VoucherTypeId"></param>
        /// <param name="txtBox"></param>
        /// <param name="date"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public string VoucherNumberAutomaicGeneration(decimal VoucherTypeId, decimal txtBox, DateTime date, string tableName)
        {
            string strVoucherNo = string.Empty;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("VoucherNumberAutomaicGeneration", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
                sprmparam.Value = VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("@txtBox", SqlDbType.Decimal);
                sprmparam.Value = txtBox;
                sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
                sprmparam.Value = date;
                sprmparam = sccmd.Parameters.Add("@tab_name", SqlDbType.VarChar);
                sprmparam.Value = tableName;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    strVoucherNo = obj.ToString();
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
            return strVoucherNo;
        }
        public DataTable VoucherTypeComboFill(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
        {
            DataTable dtblVoucherType = new DataTable();
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("VoucherTypeSelectionComboFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@strVoucherType", SqlDbType.VarChar).Value = strVoucherType;
                sdaadapter.Fill(dtblVoucherType);
                cmbVoucherType.SelectedIndex = -1;
                if (isAll)
                {
                    DataRow dRow = dtblVoucherType.NewRow();
                    dRow["voucherTypeId"] = 0;
                    dRow["voucherTypeName"] = "All";
                    dtblVoucherType.Rows.InsertAt(dRow, 0);
                }
                cmbVoucherType.DataSource = dtblVoucherType;
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.ValueMember = "voucherTypeId";
            }
            catch (Exception ex)
            {

                MessageBox.Show("TGF:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtblVoucherType;

        }
        /// <summary>
        /// Function to fill all Currencies created for combobx
        /// </summary>
        /// <returns></returns>
        public DataTable CurrencyComboFill()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("CurrencyComboFill", sqlcon);
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
        /// Function to fill all AccountLedgers under Expenses forcombox
        /// </summary>
        /// <param name="cmbType"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable AccountLedgerUnderExpenses(ComboBox cmbType, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AccountLedgerUnderExpenses", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["ledgerName"] = "All";
                    dr["ledgerId"] = 0;
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbType.DataSource = dtbl;
                cmbType.DisplayMember = "ledgerName";
                cmbType.ValueMember = "ledgerId";
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
        /// Function to fill all the units corresponding to product in combobox in Datagridview
        /// </summary>
        /// <param name="dgvCurrent"></param>
        /// <param name="strProductId"></param>
        /// <param name="inRowIndex"></param>
        /// <returns></returns>
        public DataTable UnitViewAllByProductId(DataGridView dgvCurrent, string strProductId, int inRowIndex)
        {
            DataTable dtblUnitViewAll = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAllByProductId", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter = sdaadapter.SelectCommand.Parameters.Add("@productId", SqlDbType.VarChar);
                sqlparameter.Value = strProductId;
                sdaadapter.Fill(dtblUnitViewAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            try
            {
                DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvCurrent[dgvCurrent.Columns["dgvcmbUnit"].Index, inRowIndex];
                dgvCurrent[dgvCurrent.Columns["dgvcmbUnit"].Index, inRowIndex].Value = null;
                if (dtblUnitViewAll.Rows.Count > 0)
                {
                    dgvcmbUnit.DataSource = dtblUnitViewAll;
                    dgvcmbUnit.DisplayMember = "unitName";
                    dgvcmbUnit.ValueMember = "unitId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtblUnitViewAll;
        }
        /// <summary>
        /// Function to fill AccountLedgers for combobox
        /// </summary>
        /// <returns></returns>
        public DataTable AccountLedgerComboFill()
        {
            DataTable dtbl = new DataTable();
            try
            {
                AccountLedgerSP spaccountledger = new AccountLedgerSP();
                dtbl = spaccountledger.AccountLedgerViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TGF:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtbl;
        }
        /// <summary>
        /// Function to fill All cash/Bank ledgers for Combobox
        /// </summary>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable BankOrCashComboFill(bool isAll)
        {
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
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
        /// Function to check the status of PrintAfterSave and returns the status
        /// </summary>
        /// <returns></returns>
        public bool StatusOfPrintAfterSave()
        {
            string strStatus = "";
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("PrintAfterSave", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strStatus = sccmd.ExecuteScalar().ToString();
                if (strStatus == "Yes")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to check the status of Tax and return the status
        /// </summary>
        /// <returns></returns>
        public bool TaxStatus()
        {
            string strStatus = "";
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("TaxStatus", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strStatus = sccmd.ExecuteScalar().ToString();
                if (strStatus == "Yes")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to check the status of Godown and return the status
        /// </summary>
        /// <returns></returns>
        public bool GodownStatus()
        {
            string strStatus = "";
            bool isTrue = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("GodownStatus", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                strStatus = sccmd.ExecuteScalar().ToString();
                if (strStatus == "Yes")
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
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
            return isTrue;
        }
        /// <summary>
        /// Function to fill All Currencies created On Each Date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DataTable CurrencyComboByDate(DateTime date)
        {
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
        /// Function to View all SalesMan for combobox
        /// </summary>
        /// <param name="cmbSalesMan"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable SalesmanViewAllForComboFill(ComboBox cmbSalesMan, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalesmanViewAllForComboFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["employeeId"] = 0;
                    dr["employeeName"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbSalesMan.DisplayMember = "EmployeeName";
                cmbSalesMan.ValueMember = "EmployeeId";
                cmbSalesMan.DataSource = dtbl;
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
        /// Function to fill all Cash or Party Ledgers created under SundryDebtor for Combobox
        /// </summary>
        /// <param name="cmbCashOrParty"></param>
        /// <param name="isAll"></param>
        public void CashOrPartyUnderSundryDrComboFill(ComboBox cmbCashOrParty, bool isAll)
        {
            // Fill All  Cash or party Under Sundry Debter
            DataTable dtblCashOrParty = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("CashOrPartyUnderSundryDrComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblCashOrParty);
                if (isAll)
                {
                    DataRow dr = dtblCashOrParty.NewRow();
                    dr["ledgerName"] = "All";
                    dr["ledgerId"] = 0;
                    dtblCashOrParty.Rows.InsertAt(dr, 0);
                }
                cmbCashOrParty.DataSource = dtblCashOrParty;
                cmbCashOrParty.ValueMember = "ledgerId";
                cmbCashOrParty.DisplayMember = "ledgerName";
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
        /// Function to fill all PricingLevel for combobox
        /// </summary>
        /// <param name="cmbPricingLevel"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable PricingLevelViewAll(ComboBox cmbPricingLevel, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("PricingLevelViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                cmbPricingLevel.DataSource = dtbl;
                cmbPricingLevel.DisplayMember = "pricinglevelName";
                cmbPricingLevel.ValueMember = "pricinglevelId";
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
        /// Function to fill all Ledgers created under SalesAccount for Combobox 
        /// </summary>
        /// <param name="cmbSalesAccount"></param>
        /// <param name="isAll"></param>
        public void SalesAccountComboFill(ComboBox cmbSalesAccount, bool isAll)
        {
            DataTable dtblSalesAccount = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("SalesAccountComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblSalesAccount);
                if (isAll)
                {
                    DataRow dr = dtblSalesAccount.NewRow();
                    dr["ledgerName"] = "All";
                    dr["ledgerId"] = 0;
                    dtblSalesAccount.Rows.InsertAt(dr, 0);
                }
                cmbSalesAccount.DataSource = dtblSalesAccount;
                cmbSalesAccount.DisplayMember = "ledgerName";
                cmbSalesAccount.ValueMember = "ledgerId";
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
        /// Function to fill all ProductGroup for Combobox
        /// </summary>
        /// <param name="cmbProductGroup"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable ProductGroupViewAll(ComboBox cmbProductGroup, bool isAll)
        {
            DataTable dtblProductGroup = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductGroupViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtblProductGroup);
                if (isAll)
                {
                    DataRow dr = dtblProductGroup.NewRow();
                    dr["groupName"] = "All";
                    dr["groupId"] = 0;
                    dtblProductGroup.Rows.InsertAt(dr, 0);
                }
                cmbProductGroup.DataSource = dtblProductGroup;
                cmbProductGroup.ValueMember = "groupId";
                cmbProductGroup.DisplayMember = "groupName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dtblProductGroup;
        }
        /// <summary>
        /// Function to fill all Units for combobox
        /// </summary>
        /// <param name="cmbUnit"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable UnitViewAll(ComboBox cmbUnit, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("UnitViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["unitId"] = 0;
                    dr["unitName"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbUnit.DataSource = dtbl;
                cmbUnit.ValueMember = "unitId";
                cmbUnit.DisplayMember = "unitName";
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
        /// Function to fill all Tax for combobox
        /// </summary>
        /// <param name="cmbTax"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable TaxViewAll(ComboBox cmbTax, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("TaxViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["taxId"] = 0;
                    dr["taxName"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbTax.DataSource = dtbl;
                cmbTax.ValueMember = "taxId";
                cmbTax.DisplayMember = "taxName";
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
        /// Function to fill all Brand for combobox
        /// </summary>
        /// <param name="cmbBrand"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable BrandViewAll(ComboBox cmbBrand, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("BrandViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["brandId"] = 0;
                    dr["brandName"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbBrand.DataSource = dtbl;
                cmbBrand.ValueMember = "brandId";
                cmbBrand.DisplayMember = "brandName";
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
        /// Function to fill all ModelNo for combobox
        /// </summary>
        /// <param name="cmbModelNo"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable ModelNoViewAll(ComboBox cmbModelNo, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ModelNoViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["modelNoId"] = 0;
                    dr["modelNo"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbModelNo.DataSource = dtbl;
                cmbModelNo.ValueMember = "modelNoId";
                cmbModelNo.DisplayMember = "modelNo";
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
        /// Function to fill all Tax for combobox
        /// </summary>
        /// <param name="cmbSize"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable SizeViewAll(ComboBox cmbSize, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SizeViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["sizeId"] = 0;
                    dr["size"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbSize.DataSource = dtbl;
                cmbSize.ValueMember = "sizeId";
                cmbSize.DisplayMember = "size";
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
        /// Function to fill all Bank ledgers for combobox
        /// </summary>
        /// <returns></returns>
        public DataTable BankComboFill()
        {
            DataTable dtblAccount = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sqlda = new SqlDataAdapter("BankAccountComboFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.Fill(dtblAccount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dtblAccount;
        }
        /// <summary>
        /// Function to fill all Routes for combobox
        /// </summary>
        /// <param name="cmbSize"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable RouteViewAll(ComboBox cmbSize, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("RouteViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["routeId"] = 0;
                    dr["routeName"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbSize.DataSource = dtbl;
                cmbSize.ValueMember = "routeId";
                cmbSize.DisplayMember = "routeName";
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
        /// Function to fill all Area for combobox
        /// </summary>
        /// <param name="cmbSize"></param>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable AreaViewAll(ComboBox cmbSize, bool isAll)
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("AreaViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                if (isAll)
                {
                    DataRow dr = dtbl.NewRow();
                    dr["areaId"] = 0;
                    dr["areaName"] = "All";
                    dtbl.Rows.InsertAt(dr, 0);
                }
                cmbSize.DataSource = dtbl;
                cmbSize.ValueMember = "areaId";
                cmbSize.DisplayMember = "areaName";
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
