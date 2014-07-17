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
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmBalanceSheet : Form
    {
        #region Public Variables
        /// <summary>
        /// public variable declaration part
        /// </summary>
        bool isFormLoad = false;
        int inCurrenRowIndex = 0;
        int inCurentcolIndex = 0;
        string calculationMethod = string.Empty;
        decimal decPrintOrNot = 0;
        decimal decPrintOrNot1 = 0;
        DateTime dtfromdate = PublicVariables._dtFromDate;
        #endregion
        #region FUNCTIONS
        /// <summary>
        /// Creates an instance of frmBalanceSheet  class
        /// </summary>
        public frmBalanceSheet()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void FillGrid()
        {
            try
            {
                if (!isFormLoad)
                {
                    DateValidation objValidation = new DateValidation();
                    objValidation.DateValidationFunction(txtToDate);
                    if (txtToDate.Text == string.Empty)
                        txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                    Font newFont = new Font(dgvReport.Font, FontStyle.Bold);
                    CurrencyInfo InfoCurrency = new CurrencyInfo();
                    CurrencyBll BllCurrency = new CurrencyBll();
                    InfoCurrency = BllCurrency.CurrencyView(1);
                    int inDecimalPlaces = InfoCurrency.NoOfDecimalPlaces;
                    dgvReport.Rows.Clear();
                    FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();

                   // FinancialStatementSP SpFinance = new FinancialStatementSP();
                    DataSet DsetBalanceSheet = new DataSet();
                    DataTable dtbl = new DataTable();
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
                    DsetBalanceSheet = bllFinancialStatement.BalanceSheet(PublicVariables._dtFromDate, DateTime.Parse(txtToDate.Text));
                    //------------------- Asset -------------------------------// 
                    dtbl = DsetBalanceSheet.Tables[0];
                    foreach (DataRow rw in dtbl.Rows)
                    {
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = rw["Name"].ToString();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value = rw["Balance"].ToString();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["GroupId1"].Value = rw["ID"].ToString();
                    }
                    decimal dcTotalAsset = 0;
                    if (dtbl.Rows.Count > 0)
                    {
                        dcTotalAsset = decimal.Parse(dtbl.Compute("Sum(Balance)", string.Empty).ToString());
                    }
                    //------------------------ Liability ---------------------//
                    dtbl = new DataTable();
                    dtbl = DsetBalanceSheet.Tables[1];
                    int index = 0;
                    foreach (DataRow rw in dtbl.Rows)
                    {
                        if (index < dgvReport.Rows.Count)
                        {
                            dgvReport.Rows[index].Cells["dgvtxtLiability"].Value = rw["Name"].ToString();
                            dgvReport.Rows[index].Cells["Amount2"].Value = rw["Balance"].ToString();
                            dgvReport.Rows[index].Cells["GroupId2"].Value = rw["ID"].ToString();
                        }
                        else
                        {
                            dgvReport.Rows.Add();
                            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = rw["Name"].ToString();
                            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value = rw["Balance"].ToString();
                            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["GroupId2"].Value = rw["ID"].ToString();
                        }
                        index++;
                    }
                    decimal dcTotalLiability = 0;
                    if (dtbl.Rows.Count > 0)
                    {
                        dcTotalLiability = decimal.Parse(dtbl.Compute("Sum(Balance)", string.Empty).ToString());
                    }
                    decimal dcClosingStock = bllFinancialStatement.StockValueGetOnDate(Convert.ToDateTime(txtToDate.Text), calculationMethod, false, false);
                    dcClosingStock = Math.Round(dcClosingStock, inDecimalPlaces);
                    //---------------------Opening Stock---------------------------------------------------------------------------------------------------------------
                    decimal dcOpeninggStock = bllFinancialStatement.StockValueGetOnDate(PublicVariables._dtFromDate, calculationMethod, true, true);
                    decimal dcProfit = 0;
                    DataSet dsetProfitAndLoss = new DataSet();
                    dsetProfitAndLoss = bllFinancialStatement.ProfitAndLossAnalysisUpToaDateForBalansheet(PublicVariables._dtFromDate, DateTime.Parse(txtToDate.Text));
                    DataTable dtblProfit = new DataTable();
                    dtblProfit = dsetProfitAndLoss.Tables[0];
                    for (int i = 0; i < dsetProfitAndLoss.Tables.Count; ++i)
                    {
                        dtbl = dsetProfitAndLoss.Tables[i];
                        decimal dcSum = 0;
                        if (i == 0 || (i % 2) == 0)
                        {
                            if (dtbl.Rows.Count > 0)
                            {
                                dcSum = decimal.Parse(dtbl.Compute("Sum(Debit)", string.Empty).ToString());
                                dcProfit = dcProfit - dcSum;
                            }
                        }
                        else
                        {
                            if (dtbl.Rows.Count > 0)
                            {
                                dcSum = decimal.Parse(dtbl.Compute("Sum(Credit)", string.Empty).ToString());
                                dcProfit = dcProfit + dcSum;
                            }
                        }
                    }
                    decimal decCurrentProfitLoss = 0;
                    decCurrentProfitLoss = dcProfit + (dcClosingStock - dcOpeninggStock);
                    decimal dcProfitOpening = 0;
                    DataSet dsetProfitAndLossOpening = new DataSet();
                    dsetProfitAndLossOpening = bllFinancialStatement.ProfitAndLossAnalysisUpToaDateForPreviousYears(PublicVariables._dtFromDate);
                    DataTable dtblProfitOpening = new DataTable();
                    dtblProfitOpening = dsetProfitAndLossOpening.Tables[0];
                    for (int i = 0; i < dsetProfitAndLossOpening.Tables.Count; ++i)
                    {
                        dtbl = dsetProfitAndLossOpening.Tables[i];
                        decimal dcSum = 0;
                        if (i == 0 || (i % 2) == 0)
                        {
                            if (dtbl.Rows.Count > 0)
                            {
                                dcSum = decimal.Parse(dtbl.Compute("Sum(Debit)", string.Empty).ToString());
                                dcProfitOpening = dcProfitOpening - dcSum;
                            }
                        }
                        else
                        {
                            if (dtbl.Rows.Count > 0)
                            {
                                dcSum = decimal.Parse(dtbl.Compute("Sum(Credit)", string.Empty).ToString());
                                dcProfitOpening = dcProfitOpening + dcSum;
                            }
                        }
                    }
                    DataTable dtblProfitLedgerOpening = new DataTable();
                    dtblProfitLedgerOpening = DsetBalanceSheet.Tables[3];
                    decimal decProfitLedgerOpening = 0;
                    foreach (DataRow dRow in dtblProfitLedgerOpening.Rows)
                    {
                        decProfitLedgerOpening += decimal.Parse(dRow["Balance"].ToString());
                    }
                    DataTable dtblProf = new DataTable();
                    dtblProf = DsetBalanceSheet.Tables[2];
                    decimal decProfitLedger = 0;
                    if (dtblProf.Rows.Count > 0)
                    {
                        decProfitLedger = decimal.Parse(dtblProf.Compute("Sum(Balance)", string.Empty).ToString());
                    }
                    decimal decTotalProfitAndLoss = 0;
                    if (dcProfitOpening >= 0)
                    {
                        decTotalProfitAndLoss = decProfitLedger;
                    }
                    else if (dcProfitOpening < 0)
                    {
                        decTotalProfitAndLoss = decProfitLedger;
                    }
                    index = 0;
                    if (dcClosingStock >= 0)
                    {
                        //---------- Asset ----------//
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = "Closing Stock";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value = Math.Round(dcClosingStock, inDecimalPlaces);
                        dcTotalAsset += dcClosingStock;
                    }
                    else
                    {
                        //--------- Liability ---------//
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = "Closing Stock";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value = -(Math.Round(dcClosingStock, inDecimalPlaces));
                        dcTotalLiability += -dcClosingStock;
                    }
                    dgvReport.Rows.Add();
                    decimal decOpeningOfProfitAndLoss = decProfitLedgerOpening + dcProfitOpening;
                    decimal decTotalProfitAndLossOverAll = decTotalProfitAndLoss + decOpeningOfProfitAndLoss + decCurrentProfitLoss;
                    if (decTotalProfitAndLossOverAll <= 0)
                    {
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = "----------------------------------------";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                        foreach (DataRow dRow in dtblProf.Rows)
                        {
                            if (dRow["Name"].ToString() == "Profit And Loss Account")
                            {
                                dgvReport.Rows.Add();
                                dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                                dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.DarkSlateGray;
                                dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = dRow["Name"].ToString();
                                if (decCurrentProfitLoss < 0)
                                {
                                    decCurrentProfitLoss = decCurrentProfitLoss * -1;
                                }
                                dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value =Math.Round(decTotalProfitAndLoss + decCurrentProfitLoss,PublicVariables._inNoOfDecimalPlaces);
                                dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["GroupId1"].Value = dRow["ID"].ToString();
                            }
                        }
                        //-------------- Asset ---------------//
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = "Profit And Loss (Opening)";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value = Math.Round(decTotalProfitAndLoss, PublicVariables._inNoOfDecimalPlaces);
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Style.ForeColor = Color.DarkSlateGray;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Style.ForeColor = Color.DarkSlateGray;
                        //-------------- Asset ---------------//
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = "Current Period";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value = Math.Round(decCurrentProfitLoss, PublicVariables._inNoOfDecimalPlaces);
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Style.ForeColor = Color.DarkSlateGray;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Style.ForeColor = Color.DarkSlateGray;
                        dcTotalAsset = dcTotalAsset + (decCurrentProfitLoss + decTotalProfitAndLoss);
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = "----------------------------------------";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                    }
                    else if (decTotalProfitAndLossOverAll > 0)
                    {
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = "----------------------------------------";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                        foreach (DataRow dRow in dtblProf.Rows)
                        {
                            if (dRow["Name"].ToString() == "Profit And Loss Account")
                            {
                                dgvReport.Rows.Add();
                                dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                                dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.DarkSlateGray;
                                dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = dRow[1].ToString();
                                dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value =Math.Round(decTotalProfitAndLoss + decCurrentProfitLoss,PublicVariables._inNoOfDecimalPlaces);
                                dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["GroupId2"].Value = dRow[0].ToString();
                            }
                        }
                        //------------ Liability ------------//
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = "Profit And Loss (Opening)";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value = Math.Round(decTotalProfitAndLoss, inDecimalPlaces);
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Style.ForeColor = Color.DarkSlateGray;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Style.ForeColor = Color.DarkSlateGray;
                        dcTotalLiability += decOpeningOfProfitAndLoss;
                        //------------ Liability ------------//
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = "Current Period";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value = Math.Round(decCurrentProfitLoss, inDecimalPlaces);
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Style.ForeColor = Color.DarkSlateGray;
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Style.ForeColor = Color.DarkSlateGray;
                        dcTotalLiability = dcTotalLiability + (decCurrentProfitLoss + decTotalProfitAndLoss); //dcProfit;
                        dgvReport.Rows.Add();
                        dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = "----------------------------------------";
                        dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                    }
                    dgvReport.Rows.Add();
                    decimal dcDiffAsset = 0;
                    decimal dcDiffLiability = 0;
                    decimal dcTotalValue = dcTotalAsset;
                    if (dcTotalAsset != dcTotalLiability)
                    {
                        if (dcTotalAsset > dcTotalLiability)
                        {
                            //--------------- Liability exceeds so in asset side ----------------//
                            dgvReport.Rows.Add();
                            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = "Difference";
                            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value = Math.Round((dcTotalAsset - dcTotalLiability), inDecimalPlaces);
                            dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                            dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.DarkRed;
                            dcDiffLiability = dcTotalAsset - dcTotalLiability;
                        }
                        else
                        {
                            //--------------- Asset exceeds so in liability side ----------------//
                            dgvReport.Rows.Add();
                            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = "Difference";
                            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value = Math.Round((dcTotalLiability - dcTotalAsset), inDecimalPlaces); ;
                            dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                            dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.DarkRed;
                            dcDiffAsset = dcTotalLiability - dcTotalAsset;
                        }
                    }
                    dgvReport.Rows.Add();
                    dgvReport.Rows.Add();
                    dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value = "__________________________";
                    dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value = "__________________________";
                    dgvReport.Rows.Add();
                    dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                    dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtLiability"].Value = "Total";
                    dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["dgvtxtAsset"].Value = "Total";
                    dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount1"].Value = Math.Round((dcTotalAsset + dcDiffAsset), inDecimalPlaces);
                    dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Amount2"].Value = Math.Round((dcTotalLiability + dcDiffLiability), inDecimalPlaces);
                    if (dgvReport.Columns.Count > 0)
                    {
                        dgvReport.Columns["Amount1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvReport.Columns["Amount2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    decPrintOrNot = dcTotalAsset + dcDiffAsset;
                    decPrintOrNot1 = dcTotalLiability + dcDiffLiability;
                    if (inCurrenRowIndex >= 0 && dgvReport.Rows.Count > 0 && inCurrenRowIndex < dgvReport.Rows.Count)
                    {
                        if (dgvReport.Rows[inCurrenRowIndex].Cells[inCurentcolIndex].Visible)
                        {
                            dgvReport.CurrentCell = dgvReport.Rows[inCurrenRowIndex].Cells[inCurentcolIndex];
                        }
                        if (dgvReport.CurrentCell != null && dgvReport.CurrentCell.Visible)
                            dgvReport.CurrentCell.Selected = true;
                    }
                    inCurrenRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to create Datatables
        /// </summary>
        /// <returns></returns>
        public DataTable dtblBalanceSheet()
        {
            DataTable dtLocalC = new DataTable();
            try
            {
                dtLocalC.Columns.Add("Liability");
                dtLocalC.Columns.Add("Amount2");
                dtLocalC.Columns.Add("Asset");
                dtLocalC.Columns.Add("Amount1");
                DataRow drLocal = null;
                foreach (DataGridViewRow dr in dgvReport.Rows)
                {
                    drLocal = dtLocalC.NewRow();
                    drLocal["Liability"] = dr.Cells["dgvtxtLiability"].Value;
                    drLocal["Amount2"] = dr.Cells["Amount2"].Value;
                    drLocal["Asset"] = dr.Cells["dgvtxtAsset"].Value;
                    drLocal["Amount1"] = dr.Cells["Amount1"].Value;
                    dtLocalC.Rows.Add(drLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtLocalC;
        }
        /// <summary>
        /// Function to get dataset
        /// </summary>
        /// <returns></returns>
        public DataSet getdataset()
        {
            DataSet dsFundFlow = new DataSet();
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                DataTable dtblFund = dtblBalanceSheet();
               List< DataTable> list = new List<DataTable>();
               list = bllFinancialStatement.FundFlowReportPrintCompany(1);
                dsFundFlow.Tables.Add(dtblFund);
                dsFundFlow.Tables.Add(list[0]);
                return dsFundFlow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsFundFlow;
        }
        /// <summary>
        /// Function for Print
        /// </summary>
        /// <param name="toDate"></param>
        public void Print(DateTime toDate)
        {
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                DataSet destBalance = getdataset();
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.BalanceSheetReportPrint(destBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region EVENTS
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtToDate.Text != string.Empty)
                {
                    FillGrid();
                }
                else if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                dtpdate.MinDate = PublicVariables._dtFromDate;
                dtpdate.MaxDate = PublicVariables._dtToDate;
                dtpdate.Value = PublicVariables._dtToDate;
                txtToDate.Text = dtpdate.Value.ToString("dd-MMM-yyyy");
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date Validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpdate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objValidation = new DateValidation();
                objValidation.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtToDate.Text, out dt);
                dtpdate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBalanceSheet_Load(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                isFormLoad = true;
                dtpdate.MinDate = PublicVariables._dtFromDate;
                dtpdate.MaxDate = PublicVariables._dtToDate;
                dtpdate.Value = PublicVariables._dtToDate;
                txtToDate.Text = dtpdate.Value.ToString("dd-MMM-yyyy");
                isFormLoad = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Shows details of corresponding Ledgers on Cell double click in Datagirdview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvReport.CurrentRow.Index == e.RowIndex)
                {
                    if (dgvReport.CurrentCell != null)
                    {
                        if (dgvReport.CurrentCell.Value != null && dgvReport.CurrentCell.Value.ToString().Trim() != string.Empty)
                        {
                            int inRowIndex = dgvReport.CurrentCell.RowIndex;
                            int inColIndex = dgvReport.CurrentCell.ColumnIndex;
                            string strGroupId = string.Empty;
                            string strLedgerId = string.Empty;
                            if (dgvReport.Columns[inColIndex].Name == "dgvtxtAsset" || dgvReport.Columns[inColIndex].Name == "Amount1")
                            {
                                try
                                {
                                    if (Convert.ToDecimal(dgvReport.Rows[e.RowIndex].Cells["Amount1"].Value.ToString()) != 0)
                                        if (dgvReport.Rows[inRowIndex].Cells["ID1"].Value != null && dgvReport.Rows[inRowIndex].Cells["ID1"].Value.ToString() != string.Empty)
                                        {
                                            strLedgerId = dgvReport.Rows[inRowIndex].Cells["ID1"].Value.ToString();
                                            strGroupId = string.Empty;
                                        }
                                        else if (dgvReport.Rows[inRowIndex].Cells["GroupId1"].Value != null && dgvReport.Rows[inRowIndex].Cells["GroupId1"].Value.ToString() != string.Empty)
                                        {
                                            strGroupId = dgvReport.Rows[inRowIndex].Cells["GroupId1"].Value.ToString();
                                            strLedgerId = string.Empty;
                                        }
                                }
                                catch
                                {
                                    strGroupId = string.Empty;
                                    strLedgerId = string.Empty;
                                }
                            }
                            else if (dgvReport.Columns[inColIndex].Name == "dgvtxtLiability" || dgvReport.Columns[inColIndex].Name == "Amount2")
                            {
                                try
                                {
                                    if (Convert.ToDecimal(dgvReport.Rows[e.RowIndex].Cells["Amount2"].Value.ToString()) != 0)
                                        if (dgvReport.Rows[inRowIndex].Cells["ID2"].Value != null && dgvReport.Rows[inRowIndex].Cells["ID2"].Value.ToString() != string.Empty)
                                        {
                                            strLedgerId = dgvReport.Rows[inRowIndex].Cells["ID2"].Value.ToString();
                                            strGroupId = string.Empty;
                                        }
                                        else if (dgvReport.Rows[inRowIndex].Cells["GroupId2"].Value != null && dgvReport.Rows[inRowIndex].Cells["GroupId2"].Value.ToString() != string.Empty)
                                        {
                                            strGroupId = dgvReport.Rows[inRowIndex].Cells["GroupId2"].Value.ToString();
                                            strLedgerId = string.Empty;
                                        }
                                }
                                catch
                                {
                                    strGroupId = string.Empty;
                                    strLedgerId = string.Empty;
                                }
                            }
                            if (strLedgerId != string.Empty || strGroupId != string.Empty)
                            {
                                inCurrenRowIndex = inRowIndex;
                                frmAccountGroupwiseReport objForm1 = new frmAccountGroupwiseReport();
                                objForm1.WindowState = FormWindowState.Normal;
                                objForm1.MdiParent = formMDI.MDIObj;
                                objForm1.CallFromBalancesheet(dtfromdate.ToString(), txtToDate.Text, strGroupId, this);
                                this.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Enabled = true;
                MessageBox.Show("BS :9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checks on Form Closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBalanceSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                isFormLoad = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (decPrintOrNot == 0 && decPrintOrNot1 == 0)
                {
                    MessageBox.Show("No Row To Print", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    Print(PublicVariables._dtToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    DateValidation objValidation = new DateValidation();
                    objValidation.DateValidationFunction(txtToDate);
                    if (txtToDate.Text == string.Empty)
                        txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpdate.Value = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate textbox on dtpdate datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpdate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpdate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region NAVIGATION
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBalanceSheet_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("BS :14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Back space navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dgvReport.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnsearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnsearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnsearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnclear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("BS :19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
