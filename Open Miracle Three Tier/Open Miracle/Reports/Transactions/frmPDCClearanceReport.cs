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
    public partial class frmPDCClearanceReport : Form
    {
        #region Public Variables
        /// <summary>
        /// public variable declaration part
        /// </summary>
        bool isDontExecuteVoucherType = false;
        #endregion
        #region Functions
        /// <summary>
        /// Create an instance for frmPDCClearanceReport
        /// </summary>
        public frmPDCClearanceReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill AccountLedger combobox
        /// </summary>
        public void AccountLedgerComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                ListObj = bllAccountLedger.AccountLedgerViewAll();
                DataRow dr = ListObj[0].NewRow();
                dr[0] = 0;
                dr[2] = "All";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbAccountLedger.DataSource = ListObj[0];
                cmbAccountLedger.ValueMember = "ledgerId";
                cmbAccountLedger.DisplayMember = "ledgerName";
                cmbAccountLedger.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                isDontExecuteVoucherType = true;
                PDCClearanceBll BllPDCClearance = new PDCClearanceBll();
                List<DataTable> listObj = new List<DataTable>();
                cmbVoucherType.DataSource = null;
                listObj = BllPDCClearance.VouchertypeComboFill();
                DataRow dr = listObj[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.DataSource = listObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
                isDontExecuteVoucherType = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear function the form will reset here
        /// </summary>
        public void Clear()
        {
            try
            {
                FinancialYearDate();
                AccountLedgerComboFill();
                dtpFrmDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                VoucherTypeComboFill();
                txtFromDate.Select();
                txtVoucherNo.Text = string.Empty;
                ReportSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To set the financial year status
        /// </summary>
        public void FinancialYearDate()
        {
            try
            {
                
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtFromDate = infoComapany.CurrentDate;
                dtpFrmDate.Value = dtFromDate;
                dtpFrmDate.Text = dtFromDate.ToString("dd-MMM-yyyy");
                dtpFrmDate.Value = Convert.ToDateTime(txtFromDate.Text);
                txtFromDate.Focus();
                txtFromDate.SelectAll();
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtToDate = infoComapany.CurrentDate;
                dtpToDate.Value = dtToDate;
                txtToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
                txtToDate.Focus();
                txtToDate.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search function to fill the grid based on condition
        /// </summary>
        public void ReportSearch()
        {
            try
            {
                PDCClearanceBll BllPDCClearance = new PDCClearanceBll();
                List<DataTable> ListPDCClearnceReport = new List<DataTable>();
                ListPDCClearnceReport = BllPDCClearance.PDCClearanceReportSearch(Convert.ToDateTime(dtpFrmDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), cmbAccountLedger.Text.ToString(), cmbVoucherType.Text.ToString(), txtVoucherNo.Text.ToString());
                DGVClraranceReport.DataSource = ListPDCClearnceReport[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Reset button click to call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// when form load call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPDCClearanceReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
/// <summary>
        /// to set txtFromDate as dtp's selected value
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void dtpFrmDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFrmDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to set txtFromDate as dtp's selected value
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
                MessageBox.Show("PCREP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search button click to call the fill the grid based on condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpToDate.Value >= dtpFrmDate.Value)
                {
                    ReportSearch();
                }
                else
                {
                    Messages.InformationMessage("To date less than from date");
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click for selected details updation in frmPdcClearance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVClraranceReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    frmPdcClearance frmpdcClearanceObj = new frmPdcClearance();
                    decimal decMasterId = Convert.ToDecimal(DGVClraranceReport.Rows[e.RowIndex].Cells["PDCClearanceMasterId"].Value.ToString());
                    decimal decAgainstId = Convert.ToDecimal(DGVClraranceReport.Rows[e.RowIndex].Cells["AgainstId"].Value.ToString());
                    frmPdcClearance open = Application.OpenForms["frmPdcClearance"] as frmPdcClearance;
                    if (open == null)
                    {
                        frmpdcClearanceObj.WindowState = FormWindowState.Normal;
                        frmpdcClearanceObj = new frmPdcClearance();
                        frmpdcClearanceObj.MdiParent = formMDI.MDIObj;
                        frmpdcClearanceObj.CallFromPDCClearanceReport(this, decMasterId);
                    }
                    else
                    {
                        open.CallFromPDCClearanceReport(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// print button click, call the print function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVClraranceReport.RowCount > 0)
                {
                    PDCClearanceBll BllPDCClearance = new PDCClearanceBll();
                    DataSet dsPDCClearance = new DataSet();
                    dsPDCClearance = BllPDCClearance.PDCClearanceReportPrinting(Convert.ToDateTime(dtpFrmDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), cmbAccountLedger.Text.ToString(), cmbVoucherType.Text.ToString(), txtVoucherNo.Text.ToString(), 1);
                    frmReport frmreport = new frmReport();
                    frmreport.MdiParent = formMDI.MDIObj;
                    frmreport.PDCClearanceReportPrinting(dsPDCClearance);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation and set dtp's current value as textbox text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string strdate = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation and set dtp's current value as textbox text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string strdate = txtFromDate.Text;
                dtpFrmDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(DGVClraranceReport, "PDC Clearance Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        #region Navigation
        /// <summary>
        /// For enter key and backspace navigation
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
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtFromDate.SelectionStart == 0 || txtFromDate.Text == string.Empty)
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.SelectionStart == 0 || txtToDate.Text == string.Empty)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionLength = 0;
                        txtFromDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbAccountLedger.Focus();
                }
                if (e.KeyCode==Keys.Back)
                {
                    
                
                
                    if (txtVoucherNo.Text.Trim() == string.Empty || txtVoucherNo.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();
                    
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountLedger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnReset.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbAccountLedger.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPDCClearanceReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PCREP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("PCREP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion 
    }
}
