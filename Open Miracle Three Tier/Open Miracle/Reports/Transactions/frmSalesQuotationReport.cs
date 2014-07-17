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
    public partial class frmSalesQuotationReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll TransactionGenericFillObj = new TransactionsGeneralFillBll();//used to fill cashorparty combofill  
        SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();// used to fill voucherType
        ProductCreationBll BllProductCreation = new ProductCreationBll();//uded for viewing all productCode
        string strVoucherNo = string.Empty;// used to get curesponding invoice no
        string strProductCode = string.Empty;
        decimal decLedgerId = 0;//getting curesponding ledger id while changing in ledger combofill
        decimal decVoucherTypeId = 0;
        decimal decEmployeeId = 0;
        decimal decProductId = 0;
        string strStatus = string.Empty;//to check the conditions
        //SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
        DateValidation dateValidationObj = new DateValidation();//for change date in Date time picker
        DataTable dtblSalesQuotationReport = new DataTable();
        //CompanySP spCompany = new CompanySP();
        CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmSalesQuotationReport class
        /// </summary>
        public frmSalesQuotationReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void clear()
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                CashOrPartyComboFill();
                VoucherTypeCombofill();
                SalesManComboFill();
                cmbStatus.SelectedIndex = 0;
                txtVoucherNo.Clear();
                txtProductCode.Text = string.Empty;
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRT:01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash/Party combobox
        /// </summary>
        public void CashOrPartyComboFill()
        {
            try
            {
                TransactionGenericFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRT:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Salesman combobox
        /// </summary>
        public void SalesManComboFill()
        {
            try
            {
                TransactionGenericFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRT:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeCombofill()
        {
            try
            {
                List<DataTable> ListObj = bllSalesQuotation.VoucherTypeCombofillforSalesQuotationReport();
                cmbVoucherType.DataSource = ListObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                if (txtVoucherNo.Text.Trim() == string.Empty)
                {
                    strVoucherNo = string.Empty;
                }
                else
                {
                    strVoucherNo = txtVoucherNo.Text;
                }
                if (cmbCashOrParty.SelectedIndex == 0 || cmbCashOrParty.SelectedIndex == -1)
                {
                    decLedgerId = -1;
                }
                else
                {
                    decLedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                }
                if (cmbVoucherType.SelectedIndex == 0 || cmbVoucherType.SelectedIndex == -1)
                {
                    decVoucherTypeId = -1;
                }
                else
                {
                    decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                }
                if (cmbSalesMan.SelectedIndex == 0 || cmbSalesMan.SelectedIndex == -1)
                {
                    decEmployeeId = -1;
                }
                else
                {
                    decEmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                }
                if (txtProductCode.Text.Trim() == string.Empty)
                {
                    strProductCode = string.Empty;
                }
                else
                {
                    strProductCode = txtProductCode.Text;
                }
                if (cmbStatus.SelectedIndex == 0 || cmbStatus.SelectedIndex == -1)
                {
                    strStatus = "All";
                }
                if (cmbStatus.SelectedIndex == 1)
                {
                    strStatus = "True";
                }
                if (cmbStatus.SelectedIndex == 2)
                {
                    strStatus = "False";
                }
                DateTime FromDate = this.dtpFromDate.Value;
                DateTime ToDate = this.dtpToDate.Value;
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllSalesQuotation.SalesQuotationReportSearch(strVoucherNo, decLedgerId, FromDate, ToDate, strStatus, decEmployeeId, decVoucherTypeId, strProductCode);
                if (dtblSalesQuotationReport.Rows.Count > 0)
                {
                    decimal decTotal = 0;
                    for (int i = 0; i < dtblSalesQuotationReport.Rows.Count; i++)
                    {
                        if (dtblSalesQuotationReport.Rows[i]["totalAmount"].ToString() != null)
                        {
                            decTotal = decTotal + Convert.ToDecimal(dtblSalesQuotationReport.Rows[i]["totalAmount"].ToString());
                        }
                    }
                    decTotal = Math.Round(decTotal, 2);
                    txtTotalAmount.Text = decTotal.ToString();
                }
                else
                {
                    txtTotalAmount.Text = "0.00";
                }
                dgvSalesQuotationReport.DataSource = dtblSalesQuotationReport;
                if (dgvSalesQuotationReport.Columns.Count > 0)
                {
                    dgvSalesQuotationReport.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesQuotationReport_Load(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRT:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SQRP:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate textbox on dtpToDate datetimepicker ValueChanged 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("SQRP:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on Status combobox selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtFromDate.Focus();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'search' button clcik fills datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateValidation ObjValidation = new DateValidation();
                ObjValidation.DateValidationFunction(txtToDate);
                if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                {
                    MessageBox.Show("todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    GridFill();
                }
                else
                {
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button clcik for print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                List<DataTable> listObjCompany = new List<DataTable>();
                   listObjCompany= bllCompanyCreation.CompanyViewDataTable(1);
                DataTable dtblDetails = new DataTable();
                dtblDetails = dtblSalesQuotationReport.Copy();
                if (dtblSalesQuotationReport.Rows.Count > 0)
                {
                    ds.Tables.Add(listObjCompany[0]);
                    ds.Tables.Add(dtblDetails);
                    frmReport frmReport = new frmReport();
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.SalesQuotationReportPrinting(ds, txtTotalAmount.Text);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// calls corresponding SalesQuotationvoucher on cell double click for updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesQuotationReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    frmSalesQuotation frmSalesQuotationObj = new frmSalesQuotation();
                    frmSalesQuotationObj.MdiParent = formMDI.MDIObj;
                    frmSalesQuotation frmSalesQuotationOpen = Application.OpenForms["frmSalesQuotation"] as frmSalesQuotation;
                    if (frmSalesQuotationOpen == null)
                    {
                        frmSalesQuotationObj.WindowState = FormWindowState.Normal;
                        frmSalesQuotationObj.CallFRomSalesQuotationReport(this, Convert.ToDecimal(dgvSalesQuotationReport.CurrentRow.Cells["dgvtxtQuotationMasterId"].Value));
                    }
                    else
                    {
                        frmSalesQuotationOpen.CallFRomSalesQuotationReport(this, Convert.ToDecimal(dgvSalesQuotationReport.CurrentRow.Cells["dgvtxtQuotationMasterId"].Value));
                        frmSalesQuotationOpen.BringToFront();
                        if (frmSalesQuotationOpen.WindowState == FormWindowState.Minimized)
                        {
                            frmSalesQuotationOpen.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dateValidationObj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dateValidationObj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtFromDate.Text;
                dtpFromDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvSalesQuotationReport, "Sales Quotation Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesQuotationReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SQRP:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SQRP:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
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
                    cmbVoucherType.SelectionLength = 0;
                    cmbVoucherType.SelectionStart = 0;
                }
                if (txtToDate.SelectionLength != 11)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionLength = 0;
                        txtFromDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
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
                    txtVoucherNo.SelectionLength = 0;
                    txtVoucherNo.SelectionStart = 0;
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
                MessageBox.Show("SQRP:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrParty.Focus();
                    cmbCashOrParty.SelectionLength = 0;
                    cmbCashOrParty.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text.Trim() == string.Empty && txtVoucherNo.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();
                        cmbVoucherType.SelectionLength = 0;
                        cmbVoucherType.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbStatus.Focus();
                    cmbStatus.SelectionLength = 0;
                    cmbStatus.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductCode.Focus();
                    txtProductCode.SelectionLength = 0;
                    txtProductCode.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                    cmbCashOrParty.SelectionLength = 0;
                    cmbCashOrParty.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMan.Focus();
                    cmbSalesMan.SelectionLength = 0;
                    cmbSalesMan.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbStatus.Focus();
                    cmbStatus.SelectionLength = 0;
                    cmbStatus.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtProductCode.Focus();
                    txtProductCode.SelectionLength = 0;
                    txtProductCode.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnReset.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMan.Focus();
                    cmbSalesMan.SelectionLength = 0;
                    cmbSalesMan.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvSalesQuotationReport.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesQuotationReport_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesQuotationReport.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvSalesQuotationReport.CurrentCell.ColumnIndex, dgvSalesQuotationReport.CurrentCell.RowIndex);
                        dgvSalesQuotationReport_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMan.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbStatus.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQRP:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
