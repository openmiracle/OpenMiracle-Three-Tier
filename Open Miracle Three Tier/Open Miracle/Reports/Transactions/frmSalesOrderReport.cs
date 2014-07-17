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
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmSalesOrderReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strInvoiceNo = string.Empty;
        string strStatus = string.Empty;
        string strSalesQuotationNo = string.Empty;
        string strProductCode = string.Empty;
        decimal decLedgerId = 0;
        decimal decProductCode = 0;
        decimal decVoucherTypeId = 0;
        decimal decEmployeeId = 0;
        decimal decQuotationMasterId = 0;
        decimal decAreaId = 0;
        decimal decGroupId = 0;
        decimal decRouteId = 0;
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        SalesOrderBll bllSalesOrder = new SalesOrderBll();
        SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
        List<DataTable> ListObjSOMaster = new List<DataTable>();      
        ProductCreationBll BllProductCreation = new ProductCreationBll();
        List<DataTable> ListObj = new List<DataTable>();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmSalesOrderReport class
        /// </summary>
        public frmSalesOrderReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset from
        /// </summary>
        public void Clear()
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
                QuotationNoComboFill();
                ProductGroupViewForComboFill();
                txtVoucherNo.Text = string.Empty;
                txtProductCode.Text = string.Empty;
                AreaForComboFill();
                RouteViewForComboFill();
                cmbStatus.SelectedIndex = 0;
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash/party combobox
        /// </summary>
        public void CashOrPartyComboFill()
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeCombofill()
        {
            try
            {
                ListObj = bllSalesOrder.VoucherTypeCombofillforSalesOrderReport();
                cmbVoucherType.DataSource = ListObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesMan combobox
        /// </summary>
        public void SalesManComboFill()
        {
            try
            {
                TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ProductGroup combobox
        /// </summary>
        public void ProductGroupViewForComboFill()
        {
            try
            {
                ProductGroupBll BllProductGroup = new ProductGroupBll();
                List<DataTable> listObj= BllProductGroup.ProductGroupViewForComboFill();
                cmbProductGroup.DataSource = listObj[0];
                cmbProductGroup.DisplayMember = "groupName";
                cmbProductGroup.ValueMember = "groupId";
                cmbProductGroup.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Area combobox
        /// </summary>
        public void AreaForComboFill()
        {
            try
            {
                AreaBll BllArea = new AreaBll();
                List<DataTable> dtbl = BllArea.AreaViewFOrCombofill();
                cmbArea.DataSource = dtbl[0];
                cmbArea.DisplayMember = "areaName";
                cmbArea.ValueMember = "areaId";
                cmbArea.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Route combobox
        /// </summary>
        public void RouteViewForComboFill()
        {
            try
            {
                RouteBll BllRoute = new RouteBll();
                List<DataTable> listObj = BllRoute.RouteViewForComboFill();
                cmbRoute.DataSource = listObj[0];
                cmbRoute.DisplayMember = "routeName";
                cmbRoute.ValueMember = "routeId";
                cmbRoute.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill QuotationNo combobox
        /// </summary>
        public void QuotationNoComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
                ListObj = bllSalesQuotation.GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()));
                if (ListObj != null)
                {
                    cmbQuotationNo.DataSource = ListObj[0];
                    cmbQuotationNo.DisplayMember = "invoiceNo";
                    cmbQuotationNo.ValueMember = "quotationMasterId";
                    DataRow dr = ListObj[0].NewRow();
                    dr["invoiceNo"] = "All";
                    dr["quotationMasterId"] = 0;
                    ListObj[0].Rows.InsertAt(dr, 0);
                    cmbQuotationNo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                if (txtVoucherNo.Text.Trim() == string.Empty)
                {
                    strInvoiceNo = "-1";
                }
                else
                {
                    strInvoiceNo = txtVoucherNo.Text;
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
                if (cmbArea.SelectedIndex == 0 || cmbArea.SelectedIndex == -1)
                {
                    decAreaId = -1;
                }
                else
                {
                    decAreaId = Convert.ToDecimal(cmbArea.SelectedValue.ToString());
                }
                if (cmbRoute.SelectedIndex == 0 || cmbRoute.SelectedIndex == -1)
                {
                    decRouteId = -1;
                }
                else
                {
                    decRouteId = Convert.ToDecimal(cmbRoute.SelectedValue.ToString());
                }
                if (cmbProductGroup.SelectedIndex == 0 || cmbProductGroup.SelectedIndex == -1)
                {
                    decGroupId = -1;
                }
                else
                {
                    decGroupId = Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString());
                }
                if (cmbQuotationNo.SelectedIndex == 0)
                {
                    strSalesQuotationNo = "-1";
                }
                else
                {
                    strSalesQuotationNo = cmbQuotationNo.SelectedValue.ToString();
                }
                if (cmbStatus.SelectedIndex == 0 || cmbStatus.SelectedIndex == -1)
                {
                    strStatus = "All";
                }
                else
                {
                    strStatus = cmbStatus.SelectedItem.ToString();
                }
                DateTime FromDate = this.dtpFromDate.Value;
                DateTime ToDate = this.dtpToDate.Value;
                ListObjSOMaster = bllSalesOrder.SalesOrderReportViewAll(strInvoiceNo, decLedgerId, strProductCode, decVoucherTypeId, FromDate, ToDate, strStatus, decEmployeeId, strSalesQuotationNo, decAreaId, decGroupId, decRouteId);
                if (ListObjSOMaster[0].Rows.Count > 0)
                {
                    decimal decTotal = 0;
                    for (int i = 0; i < ListObjSOMaster[0].Rows.Count; i++)
                    {
                        if (ListObjSOMaster[0].Rows[i]["totalAmount"].ToString() != null)
                        {
                            decTotal = decTotal + Convert.ToDecimal(ListObjSOMaster[0].Rows[i]["totalAmount"].ToString());
                        }
                    }
                    decTotal = Math.Round(decTotal, 2);
                    txtTotalAmount.Text = decTotal.ToString();
                }
                else
                {
                    txtTotalAmount.Text = "0.00";
                }
                dgvSalesOrderReport.DataSource = ListObj[0];
                if (dgvSalesOrderReport.Columns.Count > 0)
                {
                    dgvSalesOrderReport.Columns["dgvtxtTotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrderReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SORP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SORP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on 'Search' button clcik
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
                MessageBox.Show("SORP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Reset' button click resets form
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
                MessageBox.Show("SORP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding SalesOrder voucher for updation on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrderReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalesOrderReport.CurrentRow != null)
                {
                    if (dgvSalesOrderReport.Rows.Count > 0 && e.ColumnIndex > -1)
                    {
                        if (dgvSalesOrderReport.CurrentRow.Cells["dgvtxtSalesOrderMasterId"].Value != null)
                        {
                            frmSalesOrder frmSalesOrderObj = new frmSalesOrder();
                            frmSalesOrder frmSalesOrderOpen = Application.OpenForms["frmSalesOrder"] as frmSalesOrder;
                            if (frmSalesOrderOpen == null)
                            {
                                frmSalesOrderObj.MdiParent = formMDI.MDIObj;
                                frmSalesOrderObj.WindowState = FormWindowState.Normal;
                                frmSalesOrderObj.CallFromSalesOrderReport(this, Convert.ToDecimal(dgvSalesOrderReport.CurrentRow.Cells["dgvtxtSalesOrderMasterId"].Value.ToString()));
                            }
                            else
                            {
                                frmSalesOrderOpen.CallFromSalesOrderReport(this, Convert.ToDecimal(dgvSalesOrderReport.CurrentRow.Cells["dgvtxtSalesOrderMasterId"].Value.ToString()));
                                if (frmSalesOrderOpen.WindowState == FormWindowState.Minimized)
                                {
                                    frmSalesOrderOpen.WindowState = FormWindowState.Normal;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DataSet dsSalesOrderReport = new DataSet();
               // CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                DataTable dtblDetails = new DataTable();
                dtblDetails = ListObj[0].Copy();
                if (ListObj[0].Rows.Count > 0)
                {
                    dsSalesOrderReport.Tables.Add(listObjCompany[0]);
                    dsSalesOrderReport.Tables.Add(dtblDetails);
                    frmReport frmReport = new frmReport();
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.SalesOrderReportPrinting(dsSalesOrderReport, txtTotalAmount.Text);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
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
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
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
                MessageBox.Show("SORP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvSalesOrderReport, "Sales Order Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
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
                    if (txtToDate.Enabled == true)
                    {
                        txtToDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbVoucherType.Enabled == true)
                    {
                        cmbVoucherType.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                    if (txtFromDate.Enabled)
                    {
                        if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                        {
                            txtFromDate.Focus();
                            txtFromDate.SelectionLength = 0;
                            txtFromDate.SelectionStart = 0;
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtVoucherNo.Enabled == true)
                    {
                        txtVoucherNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtFromDate.Enabled == true)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionLength = 0;
                        txtToDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbCashOrParty.Enabled == true)
                    {
                        cmbCashOrParty.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text.Trim() == string.Empty || txtVoucherNo.SelectionStart == 0)
                    {
                        if (cmbVoucherType.Enabled == true)
                        {
                            cmbVoucherType.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbStatus.Enabled == true)
                    {
                        cmbStatus.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Enabled == true)
                    {
                        txtVoucherNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbSalesMan.Enabled == true)
                    {
                        cmbSalesMan.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled == true)
                    {
                        cmbCashOrParty.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbQuotationNo.Enabled == true)
                    {
                        cmbQuotationNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbStatus.Enabled == true)
                    {
                        cmbStatus.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbQuotationNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbProductGroup.Enabled == true)
                    {
                        cmbProductGroup.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesMan.Enabled == true)
                    {
                        cmbSalesMan.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtProductCode.Enabled == true)
                    {
                        txtProductCode.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbQuotationNo.Enabled == true)
                    {
                        cmbQuotationNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbArea.Enabled == true)
                    {
                        cmbArea.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbProductGroup.Enabled == true)
                    {
                        cmbProductGroup.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbArea_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbRoute.Enabled == true)
                    {
                        cmbRoute.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Enabled == true)
                    {
                        txtProductCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRoute_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnSearch.Enabled == true)
                    {
                        btnSearch.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbArea.Enabled == true)
                    {
                        cmbArea.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnReset.Enabled == true)
                    {
                        btnReset.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbRoute.Enabled == true)
                    {
                        cmbRoute.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (dgvSalesOrderReport.Enabled == true)
                    {
                        dgvSalesOrderReport.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnSearch.Enabled == true)
                    {
                        btnSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrderReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SORP33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbArea.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbProductGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SORP27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
