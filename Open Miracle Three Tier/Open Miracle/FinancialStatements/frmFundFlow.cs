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
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmFundFlow : Form
    {
        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        bool isFormLoad = false;
        int inCurrenRowIndex = 0;
        string strCalculationMethod = string.Empty;
        public decimal dcClosingStock = 0;
        frmProfitAndLoss frm = new frmProfitAndLoss();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmFundFlow class
        /// </summary>
        public frmFundFlow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to add DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable()
        {
            DataTable dtblFundFlow = new DataTable();
            try
            {
                dtblFundFlow.Columns.Add("Source");
                dtblFundFlow.Columns.Add("Amount1");
                dtblFundFlow.Columns.Add("Application");
                dtblFundFlow.Columns.Add("Amount2");
                DataRow drow = null;
                foreach (DataGridViewRow dr in dgvFundFlow.Rows)
                {
                    drow = dtblFundFlow.NewRow();
                    drow["Source"] = dr.Cells["dgvtxtSource"].Value;
                    drow["Amount1"] = dr.Cells["dgvtxtAmount1"].Value;
                    drow["Application"] = dr.Cells["dgvtxtApplication"].Value;
                    drow["Amount2"] = dr.Cells["dgvtxtAmount2"].Value;
                    dtblFundFlow.Rows.Add(drow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtblFundFlow;
        }
        /// <summary>
        /// Function to add data to DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetDatagrid2()
        {
            DataTable dtblFundFlow2 = new DataTable();
            try
            {
                dtblFundFlow2.Columns.Add("Particulars");
                dtblFundFlow2.Columns.Add("OpeningBalance");
                dtblFundFlow2.Columns.Add("ClosingBalance");
                dtblFundFlow2.Columns.Add("WorkingCapitalIncrease");
                DataRow drow = null;
                foreach (DataGridViewRow dr in dgvFundFlow2.Rows)
                {
                    drow = dtblFundFlow2.NewRow();
                    drow["Particulars"] = dr.Cells["dgvtxtParticulars"].Value;
                    drow["OpeningBalance"] = dr.Cells["dgvtxtOpeningBalance"].Value;
                    drow["ClosingBalance"] = dr.Cells["dgvtxtClosingBalance"].Value;
                    drow["WorkingCapitalIncrease"] = dr.Cells["dgvtxtWorkingCapitalIncrease"].Value;
                    dtblFundFlow2.Rows.Add(drow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtblFundFlow2;
        }
        /// <summary>
        /// Function to Convert DataTable to DataSet
        /// </summary>
        /// <returns></returns>
        public DataSet GetdataSet()
        {
            FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
            DataSet dsFundFlow = new DataSet();
            try
            {
                DataTable dtblFund = GetDataTable();
                DataTable dtblWC = GetDatagrid2();
               List< DataTable> listCompany = new List<DataTable>();
               listCompany = bllFinancialStatement.FundFlowReportPrintCompany(1);
                dsFundFlow.Tables.Add(dtblFund);
                dsFundFlow.Tables.Add(listCompany[0]);
                dsFundFlow.Tables.Add(dtblWC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsFundFlow;
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
                DataSet dsFundFlow = GetdataSet();
                frmReport frmReport = new frmReport();
                frmReport open = Application.OpenForms["frmReport"] as frmReport;
                if (open == null)
                {
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.FundFlow(dsFundFlow);
                    frmReport.Show();
                }
                else
                {
                    open.Activate();
                    open.FundFlow(dsFundFlow);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                isFormLoad = true;
                dtpFundFlowFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFundFlowFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFundFlowFromDate.Value = PublicVariables._dtFromDate;
                dtpFundFlowToDate.MinDate = PublicVariables._dtFromDate;
                dtpFundFlowToDate.MaxDate = PublicVariables._dtToDate;
                dtpFundFlowToDate.Value = PublicVariables._dtToDate;
                txtFundFlowFromDate.Text = dtpFundFlowFromDate.Value.ToString("dd-MMM-yyyy");
                txtFundflowToDate.Text = dtpFundFlowToDate.Value.ToString("dd-MMM-yyyy");
                isFormLoad = false;
                txtFundFlowFromDate.SelectAll();
                txtFundFlowFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview after calculation
        /// </summary>
        public void GridFill()
        {
            try
            {
                if (!isFormLoad)
                {
                    DateValidation objValidation = new DateValidation();
                    objValidation.DateValidationFunction(txtFundFlowFromDate);
                    if (txtFundFlowFromDate.Text == string.Empty)
                        txtFundFlowFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                    objValidation.DateValidationFunction(txtFundflowToDate);
                    if (txtFundflowToDate.Text == string.Empty)
                        txtFundflowToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                    //-------------------------------------First gridfill-------------------------------------//
                    DateTime strFromDate = Convert.ToDateTime(txtFundFlowFromDate.Text.ToString());
                    DateTime strTodate = Convert.ToDateTime(txtFundflowToDate.Text.ToString());
                    FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                    DataSet dsetFinancial = new DataSet();
                    SettingsInfo InfoSettings = new SettingsInfo();
                    SettingsBll BllSettings = new SettingsBll();
                    //--------------- Selection Of Calculation Method According To Settings ------------------// 
                    if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "FIFO")
                    {
                        strCalculationMethod = "FIFO";
                    }
                    else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Average Cost")
                    {
                        strCalculationMethod = "Average Cost";
                    }
                    else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "High Cost")
                    {
                        strCalculationMethod = "High Cost";
                    }
                    else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Low Cost")
                    {
                        strCalculationMethod = "Low Cost";
                    }
                    else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Last Purchase Rate")
                    {
                        strCalculationMethod = "Last Purchase Rate";
                    }
                    dsetFinancial = bllFinancialStatement.FundFlow(strFromDate, strTodate);
                    DataTable dtbl = new DataTable();
                    Font newFont = new Font(dgvFundFlow.Font, FontStyle.Bold);
                    CurrencyInfo InfoCurrency = new CurrencyInfo();
                    CurrencyBll BllCurrency = new CurrencyBll();
                    InfoCurrency = BllCurrency.CurrencyView(1);
                    int inDecimalPlaces = InfoCurrency.NoOfDecimalPlaces;
                    dgvFundFlow.Rows.Clear();
                    ////-------------------Source--------------------------------------------------------------
                    dtbl = dsetFinancial.Tables[0];
                    foreach (DataRow rw in dtbl.Rows)
                    {
                        dgvFundFlow.Rows.Add();
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtSource"].Value = rw["Name"].ToString();
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = rw["Balance"].ToString();
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtgroupId1"].Value = rw["ID"].ToString();
                    }
                    decimal dcTotalAsset = 0;
                    if (dtbl.Rows.Count > 0)
                    {
                        dcTotalAsset = decimal.Parse(dtbl.Compute("Sum(Balance)", string.Empty).ToString());
                    }
                    ////-----------------Application------------------------------------------------------------
                    dtbl = new DataTable();
                    dtbl = dsetFinancial.Tables[1];
                    int index = 0;
                    foreach (DataRow rw in dtbl.Rows)
                    {
                        if (index < dgvFundFlow.Rows.Count)
                        {
                            dgvFundFlow.Rows[index].Cells["dgvtxtApplication"].Value = rw["Name"].ToString();
                            dgvFundFlow.Rows[index].Cells["dgvtxtAmount2"].Value = rw["Balance"].ToString();
                            dgvFundFlow.Rows[index].Cells["dgvtxtgroupId2"].Value = rw["ID"].ToString();
                        }
                        else
                        {
                            dgvFundFlow.Rows.Add();
                            dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtApplication"].Value = rw["Name"].ToString();
                            dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = rw["Balance"].ToString();
                            dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtgroupId2"].Value = rw["ID"].ToString();
                        }
                        index++;
                    }
                    decimal dcTotalLiability = 0;
                    if (dtbl.Rows.Count > 0)
                    {
                        dcTotalLiability = Convert.ToDecimal(dtbl.Compute("Sum(Balance)", string.Empty).ToString());
                    }
                    //-------------------- Closing Stock -----------------------//  With Calculation
                    dcClosingStock = bllFinancialStatement.StockValueGetOnDate(Convert.ToDateTime(txtFundflowToDate.Text), strCalculationMethod, false, false);
                    dcClosingStock = Math.Round(dcClosingStock, inDecimalPlaces);
                    //---------------------Opening Stock-----------------------
                    decimal dcOpeninggStock = bllFinancialStatement.StockValueGetOnDate(Convert.ToDateTime(txtFundFlowFromDate.Text), strCalculationMethod, true, false);
                    //------------- Profit Or Loss -----------// With Calculation
                    decimal dcProfit = 0;
                    DataSet dsetProfitAndLoss = new DataSet();
                    dsetProfitAndLoss = bllFinancialStatement.ProfitAndLossAnalysisUpToaDateForBalansheet(Convert.ToDateTime(txtFundFlowFromDate.Text), Convert.ToDateTime(txtFundflowToDate.Text));
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
                                dcSum = Convert.ToDecimal(dtbl.Compute("Sum(Debit)", string.Empty).ToString());
                                dcProfit = dcProfit - dcSum;
                            }
                        }
                        else
                        {
                            if (dtbl.Rows.Count > 0)
                            {
                                dcSum = Convert.ToDecimal(dtbl.Compute("Sum(Credit)", string.Empty).ToString());
                                dcProfit = dcProfit + dcSum;
                            }
                        }
                    }
                    //---------------------NetProfit/NetLoss Calculation--------------------------
                    dcProfit = dcProfit + dcClosingStock - dcOpeninggStock;
                    if (dcProfit > 0)
                    {
                        //------------ Liability ------------//
                        dgvFundFlow.Rows.Add();
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtSource"].Value = "Net Profit";
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = Math.Round(dcProfit, inDecimalPlaces);
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount1"].Style.ForeColor = Color.Green;
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtSource"].Style.ForeColor = Color.Green;
                        //dcTotalLiability += dcProfit;
                    }
                    else
                    {
                        //-------------- Asset ---------------//
                        dgvFundFlow.Rows.Add();
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtApplication"].Value = "Net Loss";
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = -Math.Round(dcProfit, inDecimalPlaces);
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount2"].Style.ForeColor = Color.Red;
                        dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtApplication"].Style.ForeColor = Color.Red;
                    }
                    if (dcProfit > 0)
                    {
                        dcTotalAsset += (dcProfit);
                    }
                    else
                    {
                        dcTotalLiability += (-dcProfit);
                    }
                    decimal dcTotalValue = dcTotalAsset;
                    dgvFundFlow.Rows.Add();
                    dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = "_______________________";
                    dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = "_______________________";
                    dgvFundFlow.Rows.Add();
                    dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                    dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtApplication"].Value = "Total";
                    dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtSource"].Value = "Total";
                    dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount1"].Value = Math.Round((dcTotalAsset), inDecimalPlaces);
                    dgvFundFlow.Rows[dgvFundFlow.Rows.Count - 1].Cells["dgvtxtAmount2"].Value = Math.Round((dcTotalLiability), inDecimalPlaces);
                    //----------------------------------------Second gridfill----------------------------------------------
                    //--------------------------------------Current Assets-------------------------------------------
                    Font newFont2 = new Font(dgvFundFlow2.Font, FontStyle.Bold);
                    dgvFundFlow2.Rows.Clear();
                    dtbl = dsetFinancial.Tables[3];
                    decimal decWC = 0;
                    foreach (DataRow rw in dtbl.Rows)
                    {
                        dgvFundFlow2.Rows.Add();
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtgroupId"].Value = rw["ID"].ToString();
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtParticulars"].Value = rw["Name"].ToString();
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtOpeningBalance"].Value = rw["OpeningBalance"].ToString() + "Dr";
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtop"].Value = rw["OpeningBalance"].ToString();
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtcb"].Value = rw["ClosingBalance"].ToString();
                        decimal decOB = Convert.ToDecimal(rw["OpeningBalance"].ToString());
                        decimal decCB = Convert.ToDecimal(rw["ClosingBalance"].ToString());
                        decCB = decCB + dcClosingStock;
                        if (decCB > 0)
                        {
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtClosingBalance"].Value = Math.Round(decCB, inDecimalPlaces).ToString() + "Dr";
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtcb"].Value = Math.Round(decCB, inDecimalPlaces).ToString();
                        }
                        else
                        {
                            decCB = -1 * decCB;
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtClosingBalance"].Value = Math.Round(decCB, inDecimalPlaces).ToString() + "Dr";
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtcb"].Value = Math.Round(decCB, inDecimalPlaces).ToString();
                        }
                        decWC = decOB - decCB;
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtWorkingCapitalIncrease"].Value = Math.Round(decWC, inDecimalPlaces).ToString();
                    }
                    //--------------------------------------Current Liability-------------------------------------------
                    dtbl = dsetFinancial.Tables[5];
                    decimal decWCCL = 0;
                    foreach (DataRow rw in dtbl.Rows)
                    {
                        dgvFundFlow2.Rows.Add();
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtgroupId"].Value = rw["ID"].ToString();
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtParticulars"].Value = rw["Name"].ToString();
                        decimal decOp = Convert.ToDecimal(rw["OpeningBalance"].ToString());
                        decimal decCb = Convert.ToDecimal(rw["ClosingBalance"].ToString());
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtOpeningBalance"].Value = decOp.ToString() + "Cr";
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtop"].Value = rw["OpeningBalance"].ToString();
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtcb"].Value = rw["ClosingBalance"].ToString();
                        if (decCb > 0)
                        {
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtClosingBalance"].Value = decCb.ToString() + "Cr";
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtcb"].Value = decCb.ToString();
                        }
                        else
                        {
                            decCb = -1 * decCb;
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtClosingBalance"].Value = decCb.ToString() + "Cr";
                            dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtcb"].Value = decCb.ToString();
                        }
                        decimal decOB = Convert.ToDecimal(rw["OpeningBalance"].ToString());
                        decimal decCB = Convert.ToDecimal(rw["ClosingBalance"].ToString());
                        decWCCL = decOp - decCb;
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtWorkingCapitalIncrease"].Value = decWCCL.ToString();
                    }
                    //-----------------Calculating Working capital---------------
                    decimal decOpen = 0;
                    decimal decClose = 0;
                    decimal decWork = 0;
                    decOpen = Convert.ToDecimal(dgvFundFlow2.Rows[0].Cells[3].Value.ToString()) - Convert.ToDecimal(dgvFundFlow2.Rows[1].Cells[3].Value.ToString());
                    decClose = Convert.ToDecimal(dgvFundFlow2.Rows[0].Cells[5].Value.ToString()) - Convert.ToDecimal(dgvFundFlow2.Rows[1].Cells[5].Value.ToString());
                    decWork = Convert.ToDecimal(dgvFundFlow2.Rows[0].Cells[6].Value.ToString()) - Convert.ToDecimal(dgvFundFlow2.Rows[1].Cells[6].Value.ToString());
                    decimal decW1 = Convert.ToDecimal(dgvFundFlow2.Rows[0].Cells[6].Value.ToString());
                    decimal decW2 = Convert.ToDecimal(dgvFundFlow2.Rows[1].Cells[6].Value.ToString());
                    dgvFundFlow2.Rows.Add();
                    dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtParticulars"].Value = "Working Capital";
                    if (decOpen > 0)
                    {
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtOpeningBalance"].Value = decOpen.ToString() + "Dr";
                    }
                    else
                    {
                        decOpen *= -1;
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtOpeningBalance"].Value = decOpen.ToString() + "Cr";
                    }
                    if (decClose > 0)
                    {
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtClosingBalance"].Value = decClose.ToString() + "Dr";
                    }
                    else
                    {
                        decClose *= -1;
                        dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtClosingBalance"].Value = decClose.ToString() + "Cr";
                    }
                    dgvFundFlow2.Rows[dgvFundFlow2.Rows.Count - 1].Cells["dgvtxtWorkingCapitalIncrease"].Value = decWork.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFundFlow_Load(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = true;
                Clear();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //On 'Print' button click
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFundFlow.Rows.Count > 0 && dgvFundFlow2.Rows.Count > 0)
                {
                    Print(PublicVariables._dtFromDate, PublicVariables._dtToDate);
                }
                else
                {
                    MessageBox.Show("No data found", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls Corresponding Ledgers AccountGroupWiseReprt to view Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFundFlow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFundFlow.CurrentRow.Index == e.RowIndex)
                {
                    if (dgvFundFlow.CurrentCell != null)
                    {
                        if (dgvFundFlow.CurrentCell.Value != null && dgvFundFlow.CurrentCell.Value.ToString().Trim() != string.Empty)
                        {
                            int inRowIndex = dgvFundFlow.CurrentCell.RowIndex;
                            int inColIndex = dgvFundFlow.CurrentCell.ColumnIndex;
                            string strGroupId = string.Empty;
                            if (dgvFundFlow.Columns[inColIndex].Name == "dgvtxtSource" || dgvFundFlow.Columns[inColIndex].Name == "dgvtxtAmount1")
                            {
                                if (Convert.ToString(dgvFundFlow.Rows[e.RowIndex].Cells["dgvtxtAmount1"].Value) != "_______________________")
                                {
                                    if (Convert.ToDecimal(dgvFundFlow.Rows[e.RowIndex].Cells["dgvtxtAmount1"].Value.ToString()) != 0)
                                    {
                                        if (dgvFundFlow.Rows[inRowIndex].Cells["dgvtxtgroupId1"].Value != null && dgvFundFlow.Rows[inRowIndex].Cells["dgvtxtgroupId1"].Value.ToString() != string.Empty)
                                        {
                                            strGroupId = dgvFundFlow.Rows[inRowIndex].Cells["dgvtxtgroupId1"].Value.ToString();
                                        }
                                    }
                                }
                            }
                            else if (dgvFundFlow.Columns[inColIndex].Name == "dgvtxtApplication" || dgvFundFlow.Columns[inColIndex].Name == "dgvtxtAmount2")
                            {
                                if (Convert.ToString(dgvFundFlow.Rows[e.RowIndex].Cells["dgvtxtAmount2"].Value) != "________________________")
                                {
                                    if (Convert.ToDecimal(dgvFundFlow.Rows[e.RowIndex].Cells["dgvtxtAmount2"].Value.ToString()) != 0)
                                    {
                                        if (dgvFundFlow.Rows[inRowIndex].Cells["dgvtxtgroupId2"].Value != null && dgvFundFlow.Rows[inRowIndex].Cells["dgvtxtgroupId2"].Value.ToString() != string.Empty)
                                        {
                                            strGroupId = dgvFundFlow.Rows[inRowIndex].Cells["dgvtxtgroupId2"].Value.ToString();
                                        }
                                    }
                                }
                            }
                            if (strGroupId != string.Empty)
                            {
                                inCurrenRowIndex = inRowIndex;
                                frmAccountGroupwiseReport objForm1 = new frmAccountGroupwiseReport();
                                objForm1.WindowState = FormWindowState.Normal;
                                objForm1.MdiParent = formMDI.MDIObj;
                                objForm1.CallFromFundFlow(txtFundFlowFromDate.Text, txtFundflowToDate.Text, strGroupId, this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls Corresponding Ledgers AccountGroupWiseReprt to view Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFundFlow2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFundFlow2.CurrentRow.Index == e.RowIndex)
                {
                    if (dgvFundFlow2.CurrentCell != null)
                    {
                        if (dgvFundFlow2.CurrentCell.Value != null && dgvFundFlow2.CurrentCell.Value.ToString().Trim() != string.Empty)
                        {
                            int inRowIndex = dgvFundFlow2.CurrentCell.RowIndex;
                            int inColIndex = dgvFundFlow2.CurrentCell.ColumnIndex;
                            string strGroupId = string.Empty;
                            if (dgvFundFlow2.Columns[inColIndex].Name == "dgvtxtParticulars" || dgvFundFlow2.Columns[inColIndex].Name == "dgvtxtOpeningBalance" || dgvFundFlow2.Columns[inColIndex].Name == "dgvtxtClosingBalance")
                            {
                                if (Convert.ToDecimal(dgvFundFlow2.Rows[e.RowIndex].Cells["dgvtxtop"].Value) != 0 || Convert.ToDecimal(dgvFundFlow2.Rows[e.RowIndex].Cells["dgvtxtcb"].Value) != 0)
                                {
                                    try
                                    {
                                        if (dgvFundFlow2.Rows[inRowIndex].Cells["dgvtxtgroupId"].Value != null && dgvFundFlow2.Rows[inRowIndex].Cells["dgvtxtgroupId"].Value.ToString() != string.Empty)
                                        {
                                            strGroupId = dgvFundFlow2.Rows[inRowIndex].Cells["dgvtxtgroupId"].Value.ToString();
                                        }
                                    }
                                    catch
                                    {
                                        strGroupId = string.Empty;
                                    }
                                }
                            }
                            if (strGroupId != string.Empty)
                            {
                                inCurrenRowIndex = inRowIndex;
                                frmAccountGroupwiseReport objForm1 = new frmAccountGroupwiseReport();
                                objForm1.WindowState = FormWindowState.Normal;
                                objForm1.MdiParent = formMDI.MDIObj;
                                if (strGroupId == "6")
                                {
                                    objForm1.CallFromFundFlow(txtFundFlowFromDate.Text, txtFundflowToDate.Text, strGroupId, this, dcClosingStock);
                                }
                                else
                                {
                                    objForm1.CallFromFundFlow(txtFundFlowFromDate.Text, txtFundflowToDate.Text, strGroupId, this);
                                }
                                this.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFundFlowFromDate textbox on dtpFundFlowFromDate datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFundFlowFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFundFlowFromDate.Value;
                this.txtFundFlowFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFundflowToDate textbox on dtpFundFlowToDate datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFundFlowToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFundFlowToDate.Value;
                this.txtFundflowToDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFundFlowFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objValidation = new DateValidation();
                objValidation.DateValidationFunction(txtFundFlowFromDate);
                if (txtFundFlowFromDate.Text == string.Empty)
                    txtFundFlowFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtFundFlowFromDate.Text, out dt);
                dtpFundFlowFromDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFundflowToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objValidation = new DateValidation();
                objValidation.DateValidationFunction(txtFundflowToDate);
                if (txtFundflowToDate.Text == string.Empty)
                    txtFundflowToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtFundflowToDate.Text, out dt);
                dtpFundFlowToDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFundFlow_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("FF:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFundFlowFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFundflowToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFundflowToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtFundflowToDate.Text == string.Empty && txtFundflowToDate.SelectionStart == 0)
                    {
                        txtFundFlowFromDate.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
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
                    txtFundflowToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvFundFlow.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFundFlow_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvFundFlow2.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    dgvFundFlow.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFundFlow2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    dgvFundFlow2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
