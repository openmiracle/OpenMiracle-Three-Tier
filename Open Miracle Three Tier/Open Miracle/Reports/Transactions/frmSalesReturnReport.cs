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
    public partial class frmSalesReturnReport : Form
    {
        #region PublicVariables
        SalesReturnBll bllSalesReturn = new SalesReturnBll();
        TransactionsGeneralFillBll objTransactionsGeneralFillBll = new TransactionsGeneralFillBll();
        bool isFromReport = false;
        int inCurrenRowIndex = 0;
        decimal decMasterId = -2;
        ArrayList arrlstMasterId = new ArrayList();
        bool isSalesReturnActive = false;
        #endregion
        #region Functions
        
        /// <summary>
        /// Creates an instance of frmSalesReturnReport class
        /// </summary>
        public frmSalesReturnReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtProductCode.Clear();
                txtVoucherNo.Clear();
                dgvsalesReturnReport.Enabled = true;
                CashOrPartyComboFill(cmbCashOrParty);
                VoucherTypeComboFill(cmbVoucherType);
                SalesManComboFill(cmbSalesMan);
                SalesReturnReportGrideFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this from from frmVoucherWiseProductSearch to view details and for updation
        /// </summary>
        /// <param name="frmVoucherwiseProductSearch"></param>
        /// <param name="decmasterId"></param>
        public void CallFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherwiseProductSearch, decimal decmasterId)
        {
            try
            {
                base.Show();
                frmVoucherwiseProductSearch.Enabled = true;
                decMasterId = decmasterId;
                arrlstMasterId.Add(decMasterId);
                SalesReturnReportGrideFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash/Party combobox
        /// </summary>
        /// <param name="cmbCashorParty"></param>
        public void CashOrPartyComboFill(ComboBox cmbCashorParty)
        {
            try
            {
                objTransactionsGeneralFillBll.CashOrPartyUnderSundryDrComboFill(cmbCashorParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        /// <param name="cmbVoucherType"></param>
        public void VoucherTypeComboFill(ComboBox cmbVoucherType)
        {
            try
            {
                bllSalesReturn.VoucherTypeComboFillOfSalesReturnReport(cmbVoucherType, "Sales Return", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesMan combobox
        /// </summary>
        /// <param name="cmbSalesMan"></param>
        public void SalesManComboFill(ComboBox cmbSalesMan)
        {
            try
            {
                bllSalesReturn.SalesManComboFillOfSalesReturnReport(cmbSalesMan, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill datagridview
        /// </summary>
        public void SalesReturnReportGrideFill()
        {
            try
            {
                if (cmbCashOrParty.SelectedValue != null && cmbSalesMan.SelectedValue != null && cmbVoucherType.SelectedValue != null)
                {
                    if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbSalesMan.SelectedValue.ToString() != "System.Data.DataRowView" && cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        List<DataTable> ListObj = new List<DataTable>();
                        ListObj = bllSalesReturn.SalesReturnReportGrideFill(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text), Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()), Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()), txtProductCode.Text, txtVoucherNo.Text);
                        dgvsalesReturnReport.DataSource = ListObj[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt6:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decSalesMan"></param>
        /// <param name="decCashOrParty"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decVoucherTypeName"></param>
        /// <param name="strProductCode"></param>
        public void Print(DateTime fromDate, DateTime toDate, decimal decSalesMan, decimal decCashOrParty, string strVoucherNo, decimal decVoucherTypeName, string strProductCode)
        {
            try
            {
                DataSet dsSalesReturnReport = bllSalesReturn.SalesReturnReportPrinting(fromDate, toDate, decSalesMan, decCashOrParty, strVoucherNo, decVoucherTypeName, strProductCode);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.SalesReturnReportPrinting(dsSalesReturnReport);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt7:" + ex.Message, "Open sssMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void griddoubleclick()
        {
            try
            {
                 
                    if (dgvsalesReturnReport.CurrentRow != null)
                    {
                        isFromReport = true;
                        inCurrenRowIndex = dgvsalesReturnReport.CurrentRow.Index;
                        frmSalesReturn objfrmfrmSalesReturn = new frmSalesReturn();
                        frmSalesReturn open = Application.OpenForms["frmSalesReturn"] as frmSalesReturn;
                        if (open == null)
                        {
                            objfrmfrmSalesReturn.WindowState = FormWindowState.Normal;
                            objfrmfrmSalesReturn.MdiParent = formMDI.MDIObj;
                            objfrmfrmSalesReturn.Show();
                            objfrmfrmSalesReturn.CallFromSalesReturnReport(this, Convert.ToDecimal(dgvsalesReturnReport.CurrentRow.Cells["dgvSalesReturnMasterId"].Value.ToString()), isFromReport, isSalesReturnActive);
                        }
                        else
                        {
                            isSalesReturnActive = true;
                            open.MdiParent = formMDI.MDIObj;
                            if (open.WindowState == FormWindowState.Minimized)
                            {
                                open.WindowState = FormWindowState.Normal;
                            }
                            else
                            {
                                open.Activate();
                            }
                            open.ClearToCallFromSaesReturnRegister();
                            open.CallFromSalesReturnReport(this, Convert.ToDecimal(dgvsalesReturnReport.CurrentRow.Cells["dgvSalesReturnMasterId"].Value.ToString()), isFromReport, isSalesReturnActive);
                            open.BringToFront();
                        }
                        this.Enabled = false;
                    }
                }
            
            catch (Exception ex)
            {
                
               MessageBox.Show("SRRprt45:" + ex.Message, "Open sssMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                {
                    MessageBox.Show("todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    SalesReturnReportGrideFill();
                }
                else
                {
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    SalesReturnReportGrideFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt8:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding SalesReturn voucher to view details and for updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvsalesReturnReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex!=-1)
                {
                    griddoubleclick();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt9:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvsalesReturnReport.Rows.Count > 0)
                {
                    Print(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text), Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()), Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), txtVoucherNo.Text, Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()), txtProductCode.Text);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt10:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'reset' button click
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
                MessageBox.Show("SRRprt11:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesReturnReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt12:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpFromDate datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt13:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpToDate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt14:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datevalidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtToDate);
                if (!isInvalid)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt15:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datevalidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtFromDate);
                if (!isInvalid)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt16:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvsalesReturnReport, "Sales Return Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt26 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Toview salesreturn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvsalesReturnReport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    griddoubleclick();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesReturnReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SRRprt17:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Enabled)
                    {
                        txtProductCode.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt18:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (txtProductCode.Enabled)
                    {
                        txtProductCode.Focus();
                    }
                    else
                    {
                        btnPrint.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text.Trim() == string.Empty && txtToDate.SelectionStart == 0)
                    {
                        if (txtFromDate.Enabled)
                        {
                            txtFromDate.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt19:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key  navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (txtProductCode.Enabled)
                    {
                        txtProductCode.Focus();
                    }
                    else if (btnSearch.Enabled)
                    {
                        btnSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt20:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (txtProductCode.Enabled)
                    {
                        txtProductCode.Focus();
                    }
                    else
                    {
                        btnPrint.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt21:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (txtProductCode.Enabled)
                    {
                        txtProductCode.Focus();
                    }
                    else
                    {
                        btnPrint.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text.Trim() == string.Empty)
                    {
                        if (cmbVoucherType.Enabled)
                        {
                            cmbVoucherType.Focus();
                        }
                        else if (txtToDate.Enabled)
                        {
                            txtToDate.Focus();
                        }
                        else
                        {
                            txtFromDate.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt22:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (txtProductCode.Enabled)
                    {
                        txtProductCode.Focus();
                    }
                    else
                    {
                        btnPrint.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt23:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtProductCode.Enabled)
                    {
                        txtProductCode.Focus();
                    }
                    else
                    {
                        btnPrint.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt24:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnReset.Enabled)
                    {
                        btnSearch.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Text.Trim() == string.Empty)
                    {
                        if (cmbSalesMan.Enabled)
                        {
                            cmbSalesMan.Focus();
                        }
                        else if (cmbCashOrParty.Enabled)
                        {
                            cmbCashOrParty.Focus();
                        }
                        else if (txtVoucherNo.Enabled)
                        {
                            txtVoucherNo.Focus();
                        }
                        else if (cmbVoucherType.Enabled)
                        {
                            cmbVoucherType.Focus();
                        }
                        else if (txtToDate.Enabled)
                        {
                            txtToDate.Focus();
                        }
                        else
                        {
                            txtFromDate.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRRprt25:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

      
       
    }
}
