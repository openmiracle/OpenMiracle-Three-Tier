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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmAccountGroupwiseReport : Form
    {
        #region PUBLIC VARIABLES
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        ArrayList arrlstGroupId = new ArrayList();
        decimal decAccountGroupId = -2;
        string AccountGroupName = string.Empty;
        string calculationMethod = string.Empty;
        frmAccountGroupReport frmAccountGroupReportObj = null;
        frmCashFlow frmCashFlowObj = null;
        frmProfitAndLoss ObjfrmProfitAndLoss = null;
        frmBalanceSheet objfrmBalancesheet = null;
        frmFundFlow objfrmFundFlow = null;
        frmTrialBalance frmTrialBalanceObj = null;
        frmCashBankBookReport objCashBankBookReport = new frmCashBankBookReport();
        decimal decClosingStockGroupWise = 0;
        #endregion
        #region Functions
        /// <summary>
        /// Create an Instance of a frmAccountGroupwiseReport class
        /// </summary>
        public frmAccountGroupwiseReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                FinancialYearDate();
                dtpFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
                txtFromDate.SelectionStart = txtFromDate.TextLength;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the report in grid
        /// </summary>
        public void GridFill()
        {
            decimal decBalanceTotal = 0;
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.AccountGroupWiseReportViewAll(decAccountGroupId, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text));
                if (decAccountGroupId == 6)
                {
                    FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                    CalculationMethod();
                    decimal dcOpeninggStock = bllFinancialStatement.StockValueGetOnDate(PublicVariables._dtFromDate, calculationMethod, true, true);
                    dcOpeninggStock = Math.Round(dcOpeninggStock, PublicVariables._inNoOfDecimalPlaces);
                    int inRowCount = ListObj[0].Rows.Count;
                    DataRow dr = ListObj[0].NewRow();
                    dr["SlNo"] = inRowCount+1;
                    dr["accountGroupId"] = -2;
                    dr["ledgerId"] = 0;
                    dr["name"] = "Opening Stock";
                    if (dcOpeninggStock >= 0)
                    {
                        dr["OpeningBalance"] = dcOpeninggStock + "Dr";
                        dr["Balance"] = dcOpeninggStock + "Dr";
                    }
                    else
                    {
                        dr["OpeningBalance"] = dcOpeninggStock + "Cr";
                        dr["Balance"] = dcOpeninggStock + "Cr";
                    }
                    dr["debit"] = Math.Round(Convert.ToDecimal(0.00000), PublicVariables._inNoOfDecimalPlaces).ToString()+".00" ;
                    dr["credit"] = Math.Round(Convert.ToDecimal(0.00000), PublicVariables._inNoOfDecimalPlaces).ToString()+".00";
                    dr["balance1"] = dcOpeninggStock;
                    ListObj[0].Rows.InsertAt(dr, inRowCount);
                }
                dgvAccountGroupWiseReport.DataSource = ListObj[0];
                if (ListObj[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dgvAccountGroupWiseReport.RowCount; i++)
                    {
                        decBalanceTotal += Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[i].Cells["balance1"].Value.ToString());
                        
                    }   
                }
                if (decBalanceTotal < 0)
                {
                    decBalanceTotal = -1 * decBalanceTotal;
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Cr";
                }
                else
                {
                    lblBalanceTotal.Text = decBalanceTotal.ToString()+"Dr";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP02:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// Function to fill the report in grid for fundflow
        /// </summary>
        /// <param name="decCS"></param>
        public void GridFillForFundFlow(decimal decCS)
        {
            decimal decBalanceTotal = 0;
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.AccountGroupWiseReportViewAll(decAccountGroupId, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text));
                DataRow drow = ListObj[0].NewRow();
                decimal decCsop = 0;
                drow[1] = -2;
                drow[2] = 0;
                drow[3] = "Closing Stock";
                drow[4] = decCsop .ToString ()+ ".00Dr";
                drow[5] = decCS;
                drow[6] = "0.00";      
                drow[7] = decCS.ToString ()+"Dr";
                drow[8] = decCS.ToString();
                ListObj[0].Rows.InsertAt(drow, ListObj[0].Rows.Count);
                dgvAccountGroupWiseReport.DataSource = ListObj[0];
                if (ListObj[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dgvAccountGroupWiseReport.RowCount; i++)
                    {
                        decBalanceTotal += Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[i].Cells["balance1"].Value.ToString());
                    }
                }
                if (decBalanceTotal < 0)
                {
                    decBalanceTotal = -1 * decBalanceTotal;
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Cr";
                }
                else
                {
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Dr";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP03:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to set financial year date
        /// </summary>
        public void FinancialYearDate()
        {
            try
            {
                //-----For FromDate----//
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtFromDate = infoComapany.CurrentDate;
                dtpFromDate.Value = dtFromDate;
                dtpFromDate.Text = dtFromDate.ToString("dd-MMM-yyyy");
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
                txtFromDate.Focus();
                txtFromDate.SelectAll();
                //==============================//
                //-----For ToDate-----------------//
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtToDate = infoComapany.CurrentDate;
                dtpToDate.Value = dtToDate;
                dtpToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
                txtToDate.Focus();
                txtToDate.SelectAll();
                //=====================//
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP04:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to call from profitandloss
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="groupId"></param>
        /// <param name="frmProfitAndLossObj"></param>
        public void CallFromProfitAndLoss(string fromDate, string toDate, string groupId, frmProfitAndLoss frmProfitAndLossObj)
        {
            try
            {
                base.Show();
                frmProfitAndLossObj.Enabled = true;
                ObjfrmProfitAndLoss = frmProfitAndLossObj;
                txtFromDate.Text = fromDate;
                txtToDate.Text = toDate;
                decAccountGroupId = Convert.ToDecimal(groupId);
                arrlstGroupId.Add(decAccountGroupId);
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP05:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
       /// Function to call from Balancesheet
       /// </summary>
       /// <param name="FromDate"></param>
       /// <param name="toDate"></param>
       /// <param name="groupId"></param>
       /// <param name="frmbalancesheetObj"></param>
        public void CallFromBalancesheet(string FromDate, string toDate, string groupId, frmBalanceSheet frmbalancesheetObj)
        {
            
            try
            {
                base.Show();
                frmbalancesheetObj.Enabled = true;
                objfrmBalancesheet = frmbalancesheetObj;
                dtpFromDate.Value = Convert.ToDateTime(FromDate);
                dtpToDate.Value = Convert.ToDateTime(toDate);
                decAccountGroupId = Convert.ToDecimal(groupId);
                arrlstGroupId.Add(decAccountGroupId);
                
                if (decAccountGroupId == 0)
                {
                    AccountGroupWiseReportForProfitAndLossLedgerGridfill();
                }
                else
                {
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP06:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to find the total balance while from balancesheet and trial balance
        /// </summary>
        public void AccountGroupWiseReportForProfitAndLossLedgerGridfill()
        {
            decimal decBalanceTotal = 0;
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.AccountGroupWiseReportForProfitAndLossLedger(decAccountGroupId, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text));
                dgvAccountGroupWiseReport.DataSource = ListObj;
                if (ListObj[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dgvAccountGroupWiseReport.RowCount; i++)
                    {
                        decBalanceTotal += Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[i].Cells["balance1"].Value.ToString());
                    }
                }
                if (decBalanceTotal < 0)
                {
                    decBalanceTotal = -1 * decBalanceTotal;
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Cr";
                }
                else
                {
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Dr";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP07:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from CashFlow
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="groupId"></param>
        /// <param name="frmCashFlowObj"></param>
        /// <param name="inCurrenRowIndex"></param>
        /// <param name="inCurentcolIndex"></param>
        public void CallFromCashFlow(string FromDate, string toDate, string groupId, frmCashFlow frmCashFlowObj, int inCurrenRowIndex, int inCurentcolIndex)
        {
            try
            {
                base.Show();
                this.frmCashFlowObj = frmCashFlowObj;
                frmCashFlowObj.Enabled = true;
                txtFromDate.Text = FromDate;
                txtToDate.Text = toDate;
                decAccountGroupId = Convert.ToDecimal(groupId);
                arrlstGroupId.Add(decAccountGroupId);
                if (decAccountGroupId == 2)
                {
                    CashflowLoansGridFill();
                }
                else if (decAccountGroupId == 6)
                {
                    CashOutflowCurrentAssetGridFill();
                }
                else
                {
                    CashflowCommonGridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP08:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from CashFlow
        /// </summary>
        public void CashflowCommonGridFill()
        {
            decimal decBalanceTotal = 0;
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.CashflowAccountGroupWiseReportViewAll(decAccountGroupId, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text));
                dgvAccountGroupWiseReport.DataSource = ListObj[0];
                if (ListObj[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dgvAccountGroupWiseReport.RowCount; i++)
                    {
                        decBalanceTotal += Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[i].Cells["balance1"].Value.ToString());
                    }
                }
                if (decBalanceTotal < 0)
                {
                    decBalanceTotal = -1 * decBalanceTotal;
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Cr";
                }
                else
                {
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Dr";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP09:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from CashFlow
        /// </summary>
        public void CashflowLoansGridFill()
        {
            decimal decBalanceTotal = 0;
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.CashInflowLoansAccountGroupWiseReportViewAll(decAccountGroupId, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text));
                dgvAccountGroupWiseReport.DataSource = ListObj;
                if (ListObj[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dgvAccountGroupWiseReport.RowCount; i++)
                    {
                        decBalanceTotal += Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[i].Cells["balance1"].Value.ToString());
                    }
                }
                if (decBalanceTotal < 0)
                {
                    decBalanceTotal = -1 * decBalanceTotal;
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Cr";
                }
                else
                {
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Dr";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from CashFlow for current asset grid fill
        /// </summary>
        public void CashOutflowCurrentAssetGridFill()
        {
            decimal decBalanceTotal = 0;
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.CashOutflowCurrentAssetAccountGroupWiseReportViewAll(decAccountGroupId, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text));
                dgvAccountGroupWiseReport.DataSource = ListObj;
                if (ListObj[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dgvAccountGroupWiseReport.RowCount; i++)
                    {
                        decBalanceTotal += Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[i].Cells["balance1"].Value.ToString());
                    }
                }
                if (decBalanceTotal < 0)
                {
                    decBalanceTotal = -1 * decBalanceTotal;
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Cr";
                }
                else
                {
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Dr";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// Function to call from FundFlow
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="groupId"></param>
        /// <param name="frmFundFlowObj"></param>
        /// <param name="decClosingStock"></param>
        public void CallFromFundFlow(string FromDate, string toDate, string groupId, frmFundFlow frmFundFlowObj, decimal decClosingStock)
        {
            try
            {
                base.Show();
                frmFundFlowObj.Enabled = false;
                objfrmFundFlow = frmFundFlowObj;
                dtpFromDate.Value = Convert.ToDateTime(FromDate);
                dtpToDate.Value = Convert.ToDateTime(toDate);
                decAccountGroupId = Convert.ToDecimal(groupId);
                arrlstGroupId.Add(decAccountGroupId);
                decClosingStockGroupWise = decClosingStock;
                GridFillForFundFlow(decClosingStock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from FundFlow
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="groupId"></param>
        /// <param name="frmFundFlowObj"></param>
        public void CallFromFundFlow(string FromDate, string toDate, string groupId, frmFundFlow frmFundFlowObj)
        {
            try
            {
                base.Show();
                frmFundFlowObj.Enabled = false;
                objfrmFundFlow = frmFundFlowObj;
                dtpFromDate.Value =Convert.ToDateTime(FromDate);
                dtpToDate.Value =Convert.ToDateTime(toDate);
                decAccountGroupId = Convert.ToDecimal(groupId);
                arrlstGroupId.Add(decAccountGroupId);
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from AccountGroupReport
        /// </summary>
        /// <param name="frmAccountGroupObj"></param>
        /// <param name="decGroupId"></param>
        /// <param name="strFromdate"></param>
        /// <param name="strToDate"></param>
        public void CallFromAccountGroupReport(frmAccountGroupReport frmAccountGroupObj, decimal decGroupId, string strFromdate, string strToDate)
        {
            try
            {
                base.Show();
                frmAccountGroupReportObj = frmAccountGroupObj;
                frmAccountGroupReportObj.Enabled = false;
                txtFromDate.Text = strFromdate;
                txtToDate.Text = strToDate;
                decAccountGroupId = decGroupId;
                arrlstGroupId.Add(decAccountGroupId);
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from TrialBalance
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decGroupId"></param>
        /// <param name="frmTrailbalance"></param>
        public void CallFromTrailBalance(string FromDate, string toDate, decimal decGroupId, frmTrialBalance frmTrailbalance)
        {
            try
            {
                base.Show();
                frmTrialBalanceObj = frmTrailbalance;
                frmTrialBalanceObj.Enabled = false;
                dtpFromDate.Value = Convert.ToDateTime(FromDate);
                dtpToDate.Value = Convert.ToDateTime(toDate);
                decAccountGroupId = decGroupId;
                arrlstGroupId.Add(decAccountGroupId);
                if (decAccountGroupId == 0)
                {
                    AccountGroupWiseReportForProfitAndLossLedgerGridfill();
                }
                else
                {
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from CashBankBook
        /// </summary>
        /// <param name="FromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decGroupId"></param>
        /// <param name="frmCashBankBookObj"></param>
        public void CallFromCashBankBook(string FromDate, string toDate, decimal decGroupId, frmCashBankBookReport frmCashBankBookObj)
        {
            try
            {
                base.Show();
                objCashBankBookReport = frmCashBankBookObj;
                dtpFromDate.Value = Convert.ToDateTime(FromDate);
                dtpToDate.Value = Convert.ToDateTime(toDate);
                decAccountGroupId = decGroupId;
                arrlstGroupId.Add(decAccountGroupId);
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to set the calculation method by checking the settings
        /// </summary>
        public void CalculationMethod()
        {
            try
            {
                SettingsInfo InfoSettings = new SettingsInfo();
                SettingsBll BllSettings = new SettingsBll();
                //--------------- Selection Of Calculation Method According To Settings ------------------// 
                if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "FIFO")
                {
                    calculationMethod = "FIFO";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Average Cost")
                {
                    calculationMethod = "Average Cost";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "High Cost")
                {
                    calculationMethod = "High Cost";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Low Cost")
                {
                    calculationMethod = "Low Cost";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Last Purchase Rate")
                {
                    calculationMethod = "Last Purchase Rate";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroupwiseReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On value change of dtpFromDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On value change of dtpToDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpToDate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When doubleclicking on the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountGroupWiseReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    decimal decLedgerId = Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[e.RowIndex].Cells["dgvtxtLedgerId"].Value.ToString());
                    if (Convert.ToInt32(dgvAccountGroupWiseReport.Rows[e.RowIndex].Cells["dgvtxtAccountGroupId"].Value.ToString()) != -2)
                    {
                        decAccountGroupId = Convert.ToDecimal(dgvAccountGroupWiseReport.Rows[e.RowIndex].Cells["dgvtxtAccountGroupId"].Value.ToString());
                        arrlstGroupId.Add(decAccountGroupId);
                        GridFill();
                    }
                    else if (Convert.ToInt32(dgvAccountGroupWiseReport.Rows[e.RowIndex].Cells["dgvtxtLedgerId"].Value.ToString()) != 0)
                    {
                        frmLedgerDetails frmLedgerDetailsObj = new frmLedgerDetails();
                        frmLedgerDetailsObj.MdiParent = formMDI.MDIObj;
                        
                        frmLedgerDetailsObj.CallFromAccountGroupWiseReport(this, decLedgerId, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For shortcut key
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroupwiseReport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (Messages.CloseConfirmation())
                    {
                        if (frmCashFlowObj != null)
                        {
                            int inCount = arrlstGroupId.Count;
                            if (inCount != 1)
                            {
                                {
                                    decAccountGroupId = Convert.ToDecimal(arrlstGroupId[inCount - 2].ToString());
                                    arrlstGroupId.RemoveAt(inCount - 1);
                                    if (decAccountGroupId == 2)
                                    {
                                        CashflowLoansGridFill();
                                    }
                                    else if (decAccountGroupId == 6)
                                    {
                                        CashOutflowCurrentAssetGridFill();
                                    }
                                    else
                                    {
                                        CashflowCommonGridFill();
                                    }
                                }
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else if (objfrmFundFlow != null)
                        {
                            int inCount = arrlstGroupId.Count;
                            if (inCount != 1)
                            {
                                decAccountGroupId = Convert.ToDecimal(arrlstGroupId[inCount - 2].ToString());
                                if (decAccountGroupId == 6)
                                {
                                    arrlstGroupId.RemoveAt(inCount - 1);
                                    GridFillForFundFlow(decClosingStockGroupWise);
                                }
                                else
                                {
                                    arrlstGroupId.RemoveAt(inCount - 1);
                                    GridFill();
                                }
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            int inCount = arrlstGroupId.Count;
                            if (inCount != 1)
                            {
                                decAccountGroupId = Convert.ToDecimal(arrlstGroupId[inCount - 2].ToString());
                                arrlstGroupId.RemoveAt(inCount - 1);
                                GridFill();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroupwiseReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmAccountGroupReportObj != null)
                {
                    frmAccountGroupReportObj.Enabled = true;
                    frmAccountGroupReportObj.BringToFront();
                }
                if (ObjfrmProfitAndLoss != null)
                {
                    ObjfrmProfitAndLoss.Enabled = true;
                    ObjfrmProfitAndLoss.BringToFront();
                }
                if (frmCashFlowObj !=null)
                {
                    frmCashFlowObj.Enabled = true;
                    frmCashFlowObj.BringToFront();
                }
                if (objfrmBalancesheet != null)
                {
                    objfrmBalancesheet.Enabled = true;
                    objfrmBalancesheet.BringToFront();
                    objfrmBalancesheet.FillGrid();
                }
                if (objfrmFundFlow != null)
                {
                    objfrmFundFlow.Enabled = true;
                    objfrmFundFlow.BringToFront();
                }
                if (frmTrialBalanceObj != null)
                {
                    frmTrialBalanceObj.Enabled = true;
                    frmTrialBalanceObj.GridFill();
                    frmTrialBalanceObj.BringToFront();
                }
                if (objCashBankBookReport != null)
                {
                    objCashBankBookReport.Enabled = true;
                    objCashBankBookReport.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGWREP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
