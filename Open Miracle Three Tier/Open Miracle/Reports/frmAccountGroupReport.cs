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
    public partial class frmAccountGroupReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string calculationMethod = string.Empty;
        #endregion
        #region FUNCTIONS
        /// <summary>
        /// Create an Instance of a frmAccountGroupReport class
        /// </summary>
        public frmAccountGroupReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to print report
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void Print(DateTime fromDate, DateTime toDate)
        {
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                DataSet dsAccountGroup = new DataSet();
                List<DataTable> ListObj = bllAccountGroup.AccountGroupReportFill(fromDate, toDate);
                string strSum = lblBalanceTotal.Text;
                DataTable dtblSum = new DataTable();
                dtblSum.Columns.Add("Sum", typeof(string));
                DataRow dr = dtblSum.NewRow();
                dr[0] = strSum;
                dtblSum.Rows.InsertAt(dr, 0);

                List<DataTable> listCompany = bllFinancialStatement.FundFlowReportPrintCompany(1);
                dsAccountGroup.Tables.Add(ListObj[0]);
                dsAccountGroup.Tables.Add(listCompany[0]);
                dsAccountGroup.Tables.Add(dtblSum);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.AccountGroup(dsAccountGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                FinancialYearDate();
                dtpFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                dtpToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
                txtFromDate.SelectionStart = txtFromDate.TextLength;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("AGR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the report in grid
        /// </summary>
        public void AccountGroupGridFill()
        {
            decimal decBalanceTotal = 0;
            DateTime dtmFromDate = DateTime.Now;
            DateTime dtmToDate = DateTime.Now;
            AccountGroupBll bllAccountGroup = new AccountGroupBll();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (txtFromDate.Text != string.Empty)
                {
                    dtmFromDate = Convert.ToDateTime(txtFromDate.Text);
                }
                if (txtToDate.Text != string.Empty)
                {
                    dtmToDate = Convert.ToDateTime(txtToDate.Text);
                }
                ListObj = bllAccountGroup.AccountGroupReportFill(dtmFromDate, dtmToDate);
                for (int i = 0; i < ListObj[0].Rows.Count; i++)
                {
                    if (Convert.ToDecimal(ListObj[0].Rows[i]["accountGroupId"].ToString()) == 6)
                    {
                        FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                        CalculationMethod();
                        decimal dcOpeninggStock = bllFinancialStatement.StockValueGetOnDate(PublicVariables._dtFromDate, calculationMethod, true, true);
                        dcOpeninggStock = Math.Round(dcOpeninggStock, PublicVariables._inNoOfDecimalPlaces);
                        decimal decOpBalance = Convert.ToDecimal(ListObj[0].Rows[i]["OpBalance"].ToString()) + dcOpeninggStock;
                        decimal decClosing = Convert.ToDecimal(ListObj[0].Rows[i]["balance1"].ToString()) + dcOpeninggStock;
                        if (decOpBalance >= 0)
                        {
                            ListObj[0].Rows[i]["OpeningBalance"] = decOpBalance.ToString() + "Dr";
                        }
                        else
                        {
                            ListObj[0].Rows[i]["OpeningBalance"] = decOpBalance.ToString() + "Cr";
                        }
                        if (decClosing >= 0)
                        {
                            ListObj[0].Rows[i]["balance"] = decClosing.ToString() + "Dr";
                        }
                        else
                        {
                            ListObj[0].Rows[i]["balance"] = decClosing.ToString() + "Cr";
                        }
                        ListObj[0].Rows[i]["balance1"] = decClosing.ToString();
                    }
                }
                dgvAccountGroupReport.DataSource = ListObj[0];
                if (dgvAccountGroupReport.RowCount > 0)
                {
                    for (int i = 0; i < dgvAccountGroupReport.RowCount; i++)
                    {
                        decBalanceTotal = decBalanceTotal + Convert.ToDecimal(dgvAccountGroupReport.Rows[i].Cells["dgvtxtBalance1"].Value.ToString());
                    }
                }
                if (decBalanceTotal < 0)
                {
                    decBalanceTotal = -1 * decBalanceTotal;
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Cr";
                }
                else
                {
                    lblBalanceTotal.Text = decBalanceTotal.ToString() + "Dr"; ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate serial number
        /// </summary>
        public void SlNo()
        {
            int inRowNo = 1;
            try
            {
                foreach (DataGridViewRow dr in dgvAccountGroupReport.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvAccountGroupReport.Rows.Count - 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("AGR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region EVENTS
        /// <summary>
        /// On leave from txtFromDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
            {
            try
            {
                DateValidation ObjValidation = new DateValidation();
                ObjValidation.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }
                DateTime dt;
                DateTime.TryParse(txtFromDate.Text, out dt);
                dtpFromDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtToDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation ObjValidation = new DateValidation();
                ObjValidation.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                }
                
                DateTime dt;
                DateTime.TryParse(txtToDate.Text, out dt);
                dtpToDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// On load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroupReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                AccountGroupGridFill();
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AccountGroupGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AccountGroupGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When doubleclicking on the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAccountGroupReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAccountGroupReport.CurrentRow.Index == e.RowIndex)
                {
                    decimal decAccountGroupId = Convert.ToDecimal(dgvAccountGroupReport.Rows[e.RowIndex].Cells["dgvtxtAccountGroupId"].Value.ToString());
                    frmAccountGroupwiseReport frmAccountGroupwiseReportObj = new frmAccountGroupwiseReport();
                    frmAccountGroupwiseReportObj.MdiParent = formMDI.MDIObj;
                    frmAccountGroupwiseReportObj.CallFromAccountGroupReport(this, decAccountGroupId, txtFromDate.Text, txtToDate.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// btnPrint click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccountGroupReport.Rows.Count > 0)
                {
                    Print(PublicVariables._dtFromDate, PublicVariables._dtToDate);
                
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On 'Export' button click to export the report to Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExportNew ex = new ExportNew();
                ex.ExportExcel(dgvAccountGroupReport, "Account Group Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGR:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        #endregion
        #region NAVIGATION
        /// <summary>
        /// Enterkey navigation of txtFromDate
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
                MessageBox.Show("AGR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtToDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.Focus();
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.SelectionLength != 11)
                    {
                        if (txtToDate.Text == string.Empty)
                        {
                            if (txtToDate.SelectionStart == 0)
                            {
                                txtFromDate.Focus();
                                txtFromDate.SelectionStart = 0;
                                txtFromDate.SelectionLength = 0;
                            }
                        }
                        if (txtToDate.SelectionStart == 0)
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
                MessageBox.Show("AGR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For shortcut key
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAccountGroupReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("AGR:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        #endregion       
    }
}
