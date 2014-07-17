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
using System.Data.SqlClient;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmProfitAndLoss : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable Declaration part
        /// </summary>
        string calculationMethod = string.Empty;
        bool isFormLoad = false;
        string strGroupId = string.Empty;
        string strLedgerId = string.Empty;
        int inCurrenRowIndex = 0;// To keep row index while returning from voucher 
        int inCurrentColunIndex = 0;// To keep column index while returning from voucher 
        string strformName = string.Empty;
        decimal decgranExTotal = 0;
        decimal decgranIncTotal = 0;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmProfitAndLoss class
        /// </summary>
        public frmProfitAndLoss()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void Gridfill()
        {
            try
            {
                if (!isFormLoad)
                {
                    DateValidation objValidation = new DateValidation();
                    objValidation.DateValidationFunction(txtFromDate);
                    if (txtFromDate.Text == string.Empty)
                        txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                    objValidation.DateValidationFunction(txtToDate);
                    if (txtToDate.Text == string.Empty)
                        txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                    Font newFont = new Font(dgvProfitAndLoss.Font, FontStyle.Bold);
                    CurrencyInfo InfoCurrency = new CurrencyInfo();
                    CurrencyBll BllCurrency = new CurrencyBll();
                    InfoCurrency = BllCurrency.CurrencyView(1);
                    int inDecimalPlaces = InfoCurrency.NoOfDecimalPlaces;
                    dgvProfitAndLoss.Rows.Clear();
                    FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                    
                    DataTable dtblFinancial = new DataTable();
                    DataSet DsetProfitAndLoss = new DataSet();
                    SettingsInfo infoSettings = new SettingsInfo();
                    SettingsBll BllSettings = new SettingsBll();
                    //---------check  calculation method
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
                    DsetProfitAndLoss = bllFinancialStatement.ProfitAndLossAnalysis(DateTime.Parse(txtFromDate.Text), DateTime.Parse(txtToDate.Text));
                    //---- Opening Stock
                    dgvProfitAndLoss.Rows.Add();
                    decimal dcOpeningStock = bllFinancialStatement.StockValueGetOnDate(DateTime.Parse(txtFromDate.Text), DateTime.Parse(txtToDate.Text), calculationMethod, true, false);
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtExpenses"].Value = "Opening Stock";
                    if (dcOpeningStock > 0)
                    {
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = Math.Round(dcOpeningStock, inDecimalPlaces);
                    }
                    else
                    {
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = -(Math.Round(dcOpeningStock, inDecimalPlaces));
                    }
                    //Closing Stock 
                    decimal dcClosingStock = 0;
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtIncome"].Value = "Closing Stock";
                    dcClosingStock = bllFinancialStatement.StockValueGetOnDate(DateTime.Parse(txtToDate.Text), calculationMethod, false, false);
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = Math.Round(dcClosingStock, inDecimalPlaces);
                    /// ---Purchase Account  - Debit
                    dtblFinancial = new DataTable();
                    dtblFinancial = DsetProfitAndLoss.Tables[0];
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtExpenses"].Value = "Purchase Accounts";
                    decimal dcPurchaseAccount = 0m;
                    if (dtblFinancial.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dtblFinancial.Rows)
                        {
                            decimal dcBalance = decimal.Parse(rw["Debit"].ToString().ToString());
                            dcPurchaseAccount += dcBalance;
                        }
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtGroupId1"].Value = "11";
                    }
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcPurchaseAccount.ToString();
                    //---Sales Account  -Credit
                    dtblFinancial = new DataTable();
                    dtblFinancial = DsetProfitAndLoss.Tables[1];
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtIncome"].Value = "Sales Accounts";
                    decimal dcSalesAccount = 0m;
                    if (dtblFinancial.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dtblFinancial.Rows)
                        {
                            decimal dcBalance = decimal.Parse(rw["Credit"].ToString().ToString());
                            dcSalesAccount += dcBalance;
                        }
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtGroupId2"].Value = "10";
                    }
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcSalesAccount.ToString();
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows.Add();
                    //---Direct Expense
                    dtblFinancial = new DataTable();
                    dtblFinancial = DsetProfitAndLoss.Tables[2];
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtExpenses"].Value = "Direct Expenses";
                    decimal dcDirectExpense = 0m;
                    if (dtblFinancial.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dtblFinancial.Rows)
                        {
                            decimal dcBalance = Convert.ToDecimal(rw["Debit"].ToString());
                            dcDirectExpense += dcBalance;
                        }
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtGroupId1"].Value = "13";
                    }
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcDirectExpense.ToString();
                    //----Direct Income 
                    dtblFinancial = new DataTable();
                    dtblFinancial = DsetProfitAndLoss.Tables[3];
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtIncome"].Value = "Direct Incomes";
                    decimal dcDirectIncoome = 0m;
                    if (dtblFinancial.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dtblFinancial.Rows)
                        {
                            decimal dcBalance = Convert.ToDecimal(rw["Credit"].ToString());
                            dcDirectIncoome += dcBalance;
                        }
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtGroupId2"].Value = "12";
                    }
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcDirectIncoome.ToString();
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = "_______________________";
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = "_______________________";
                    dgvProfitAndLoss.Rows.Add();
                    decimal dcTotalExpense = 0;
                    decimal dcTotalIncome = 0;
                    dcTotalExpense = dcOpeningStock + dcPurchaseAccount + dcDirectExpense;
                    dcTotalIncome = dcClosingStock + dcSalesAccount + dcDirectIncoome;
                    dcTotalExpense = Math.Round(dcTotalExpense, inDecimalPlaces);
                    dcTotalIncome = Math.Round(dcTotalIncome, inDecimalPlaces);
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtExpenses"].Value = "Total";
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtIncome"].Value = "Total";
                    decimal dcGrossProfit = 0;
                    decimal dcGrossLoss = 0;
                    if (dcTotalExpense > dcTotalIncome)
                    {
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcTotalExpense.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcTotalExpense.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtIncome"].Value = "Gross Loss b/d ";
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount2"].Value = dcTotalExpense - dcTotalIncome;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount2"].Style.ForeColor = Color.Red;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtIncome"].Style.ForeColor = Color.Red;
                        dgvProfitAndLoss.Rows.Add();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtExpenses"].Value = "Gross Loss b/d ";
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcTotalExpense - dcTotalIncome;
                        dcGrossLoss = dcTotalExpense - dcTotalIncome;
                    }
                    else
                    {
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcTotalIncome.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcTotalIncome.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtExpenses"].Value = "Gross Profit c/d ";
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount1"].Value = dcTotalIncome - dcTotalExpense;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount1"].Style.ForeColor = Color.Green;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtExpenses"].Style.ForeColor = Color.Green;
                        dgvProfitAndLoss.Rows.Add();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtIncome"].Value = "Gross Profit c/d ";
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcTotalIncome - dcTotalExpense;
                        dcGrossProfit = dcTotalIncome - dcTotalExpense;
                    }
                    dgvProfitAndLoss.Rows.Add();
                    ///------Indirect Expense 
                    dtblFinancial = new DataTable();
                    dtblFinancial = DsetProfitAndLoss.Tables[4];
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtExpenses"].Value = "Indirect Expenses";
                    decimal dcIndirectExpense = 0;
                    if (dtblFinancial.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dtblFinancial.Rows)
                        {
                            decimal dcBalance = Convert.ToDecimal(rw["Debit"].ToString());
                            dcIndirectExpense += dcBalance;
                        }
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtGroupId1"].Value = "15";
                    }
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcIndirectExpense.ToString();
                    ///---Indirect Income 
                    dtblFinancial = new DataTable();
                    dtblFinancial = DsetProfitAndLoss.Tables[5];
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtIncome"].Value = "Indirect Incomes";
                    decimal dcIndirectIncome = 0m;
                    if (dtblFinancial.Rows.Count > 0)
                    {
                        foreach (DataRow rw in dtblFinancial.Rows)
                        {
                            decimal dcBalance = Convert.ToDecimal(rw["Credit"].ToString());
                            dcIndirectIncome += dcBalance;
                        }
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtGroupId2"].Value = "14";
                    }
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcIndirectIncome.ToString();
                    //---- Calculating Grand total
                    decimal dcGrandTotalExpense = dcGrossLoss + dcIndirectExpense;
                    decimal dcGrandTotalIncome = dcGrossProfit + dcIndirectIncome;
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = "_______________________";
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = "_______________________";
                    dgvProfitAndLoss.Rows.Add();
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtExpenses"].Value = "Grand Total";
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtIncome"].Value = "Grand Total";
                    dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                    if (dcGrandTotalExpense > dcGrandTotalIncome)
                    {
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcGrandTotalExpense.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcGrandTotalExpense.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtIncome"].Value = "Net Loss ";
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount2"].Value = dcGrandTotalExpense - dcGrandTotalIncome;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtIncome"].Style.ForeColor = Color.Red;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount2"].Style.ForeColor = Color.Red;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].DefaultCellStyle.Font = newFont;
                        decgranExTotal = dcGrandTotalExpense;
                    }
                    else
                    {
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = dcGrandTotalIncome.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = dcGrandTotalIncome.ToString();
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtExpenses"].Value = "Net Profit";
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount1"].Value = dcGrandTotalIncome - dcGrandTotalExpense;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtExpenses"].Style.ForeColor = Color.Green;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].Cells["dgvtxtAmount1"].Style.ForeColor = Color.Green;
                        dgvProfitAndLoss.Rows[dgvProfitAndLoss.Rows.Count - 3].DefaultCellStyle.Font = newFont;
                        decgranIncTotal = dcGrandTotalIncome;
                    }
                    if (dgvProfitAndLoss.Columns.Count > 0)
                    {
                        dgvProfitAndLoss.Columns["dgvtxtAmount1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvProfitAndLoss.Columns["dgvtxtAmount2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (inCurrenRowIndex >= 0 && dgvProfitAndLoss.Rows.Count > 0 && inCurrenRowIndex < dgvProfitAndLoss.Rows.Count)
                    {
                        if (dgvProfitAndLoss.Rows[inCurrenRowIndex].Cells[inCurrentColunIndex].Visible)
                        {
                            dgvProfitAndLoss.CurrentCell = dgvProfitAndLoss.Rows[inCurrenRowIndex].Cells[inCurrentColunIndex];
                        }
                        else
                        {
                            dgvProfitAndLoss.CurrentCell = dgvProfitAndLoss.Rows[inCurrenRowIndex].Cells["dgvtxtExpenses"];
                        }
                        dgvProfitAndLoss.CurrentCell.Selected = true;
                    }
                    inCurrenRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to convert datagridview data to a datatable
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable()
        {
            DataTable dtblProfit = new DataTable();
            try
            {
                dtblProfit.Columns.Add("Expenses");
                dtblProfit.Columns.Add("Amount1");
                dtblProfit.Columns.Add("Income");
                dtblProfit.Columns.Add("Amount2");
                DataRow drow = null;
                foreach (DataGridViewRow dr in dgvProfitAndLoss.Rows)
                {
                    drow = dtblProfit.NewRow();
                    drow["Expenses"] = dr.Cells["dgvtxtExpenses"].Value;
                    drow["Amount1"] = dr.Cells["dgvtxtAmount1"].Value;
                    drow["Income"] = dr.Cells["dgvtxtIncome"].Value;
                    drow["Amount2"] = dr.Cells["dgvtxtAmount2"].Value;
                    dtblProfit.Rows.Add(drow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtblProfit;
        }
        /// <summary>
        /// Function to convert datatable to dataset
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            DataSet dsProfit = new DataSet();
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                DataTable dtblProfit = GetDataTable();
                List<DataTable> list = new List<DataTable>();
                list = bllFinancialStatement.ProfitAndLossReportPrintCompany(1);//(PublicVariables._decCurrentCompanyId);
                dsProfit.Tables.Add(dtblProfit);
                dsProfit.Tables.Add(list[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsProfit;
        }
        /// <summary>
        /// Function for Print
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void Print(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataSet dsProfit = GetDataSet();
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.ProfitAndLossReportPrinting(dsProfit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProfitAndLoss_Load(object sender, EventArgs e)
        {
            try
            {
                isFormLoad = true;
                dtpContraVoucherDate.MinDate = PublicVariables._dtFromDate;
                dtpContraVoucherDate.MaxDate = PublicVariables._dtToDate;
                dtpContraVoucherDate.Value = PublicVariables._dtFromDate;
                dtpContraVoucherDate.Text = dtpContraVoucherDate.Value.ToString("dd-MMM-yyyy");
                dtpTodate.Value = PublicVariables._dtToDate;
                dtpTodate.Text = dtpTodate.Value.ToString("dd-MMM-yyyy");
                isFormLoad = false;
                txtFromDate.Focus();
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpContraVoucherDate DatetimePicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpContraVoucherDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtFromDate.Text = dtpContraVoucherDate.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate textbox on dtpTodate DatetimePicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTodate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = dtpTodate.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpTodate.Value >= dtpContraVoucherDate.Value)
                {
                    Gridfill();
                }
                else
                {
                    Messages.InformationMessage("To date less than from date");
                    dtpTodate.Value = PublicVariables._dtToDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding Ledgers AccountGroupwise Report on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProfitAndLoss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProfitAndLoss.CurrentRow.Index != -1 && dgvProfitAndLoss.CurrentCell.ColumnIndex != -1)
                {
                    if (dgvProfitAndLoss.CurrentCell != null)
                    {
                        if (dgvProfitAndLoss.CurrentCell.Value != null && dgvProfitAndLoss.CurrentCell.Value.ToString().Trim() != string.Empty)
                        {
                            int inRowIndex = dgvProfitAndLoss.CurrentCell.RowIndex;
                            int inColIndex = dgvProfitAndLoss.CurrentCell.ColumnIndex;
                            string strGroupId = string.Empty;
                            if (dgvProfitAndLoss.Columns[inColIndex].Name == "dgvtxtExpenses" || dgvProfitAndLoss.Columns[inColIndex].Name == "dgvtxtAmount1")
                            {
                                try
                                {
                                    if (dgvProfitAndLoss.Rows[inRowIndex].Cells["dgvtxtGroupId1"].Value != null && dgvProfitAndLoss.Rows[inRowIndex].Cells["dgvtxtGroupId1"].Value.ToString() != string.Empty)
                                    {
                                        strGroupId = dgvProfitAndLoss.Rows[inRowIndex].Cells["dgvtxtGroupId1"].Value.ToString();
                                    }
                                }
                                catch
                                {
                                    strGroupId = string.Empty;
                                }
                            }
                            else if (dgvProfitAndLoss.Columns[inColIndex].Name == "dgvtxtIncome" || dgvProfitAndLoss.Columns[inColIndex].Name == "dgvtxtAmount2")
                            {
                                try
                                {
                                    if (dgvProfitAndLoss.Rows[inRowIndex].Cells["dgvtxtGroupId2"].Value != null && dgvProfitAndLoss.Rows[inRowIndex].Cells["dgvtxtGroupId2"].Value.ToString() != string.Empty)
                                    {
                                        strGroupId = dgvProfitAndLoss.Rows[inRowIndex].Cells["dgvtxtGroupId2"].Value.ToString();
                                    }
                                }
                                catch
                                {
                                    strGroupId = string.Empty;
                                }
                            }
                            if (strGroupId != string.Empty)
                            {
                                inCurrenRowIndex = inRowIndex;
                                inCurrentColunIndex = inColIndex;
                                frmAccountGroupwiseReport objForm = new frmAccountGroupwiseReport();
                                objForm.WindowState = FormWindowState.Normal;
                                objForm.MdiParent = formMDI.MDIObj;
                                objForm.CallFromProfitAndLoss(txtFromDate.Text, txtToDate.Text, strGroupId, this);
                                this.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dtpContraVoucherDate.MinDate = PublicVariables._dtFromDate;
                dtpContraVoucherDate.MaxDate = PublicVariables._dtToDate;
                dtpContraVoucherDate.Value = PublicVariables._dtFromDate;
                dtpContraVoucherDate.Text = dtpContraVoucherDate.Value.ToString("dd-MMM-yyyy");
                dtpTodate.Value = PublicVariables._dtToDate;
                dtpTodate.Text = dtpTodate.Value.ToString("dd-MMM-yyyy");
                txtFromDate.Text = Convert.ToDateTime(PublicVariables._dtFromDate).ToString();
                txtToDate.Text = Convert.ToDateTime(PublicVariables._dtToDate).ToString();
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button click to print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (decgranExTotal == 0 && decgranIncTotal == 0)
                {
                    MessageBox.Show("No row to print", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Print(PublicVariables._dtFromDate, PublicVariables._dtToDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                }
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProfitAndLoss_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        Messages.CloseMessage(this);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvProfitAndLoss.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnClear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.SelectionLength != 11)
                    {
                        if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                        {
                            txtFromDate.Focus();
                            txtFromDate.SelectionStart = 0;
                            txtFromDate.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClear.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PAL :18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
