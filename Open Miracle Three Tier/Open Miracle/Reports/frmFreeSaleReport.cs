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
    public partial class frmFreeSaleReport : Form
    {


        #region public variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        //TransactionsGeneralFill TransactionsGeneralFillObj = new TransactionsGeneralFill();
        VoucherTypeBll BllVoucherType = new VoucherTypeBll();
        //ProductSP spproduct = new ProductSP();
        ProductCreationBll BllProductCreation = new ProductCreationBll();
        //SalesMasterSP spsalemaster = new SalesMasterSP();
        SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
        bool isFormLoad = false;
        #endregion

        #region Functions
        /// <summary>
        /// Create an Instance of a frmDayBook class
        /// </summary>
        public frmFreeSaleReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill the grid
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                DataTable dtbl = new DataTable();
                DateTime fromDate, toDate;
                fromDate = Convert.ToDateTime(txtFromDate.Text);
                toDate = Convert.ToDateTime(txtToDate.Text);
                string voucherNo = txtVoucherNo.Text.ToString();
                decimal voucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                decimal groupId = Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString());
                decimal ledgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                decimal employeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                string productCode = cmbProductCode.Text.ToString();
                listObj = BllSalesInvoice.FreeSaleReportGridFill(fromDate, toDate, voucherNo, voucherTypeId, groupId, productCode, ledgerId, employeeId);
                dgvFreeSalesReport.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void reset()
        {
            try
            {
                dtpFrmDate.Value = PublicVariables._dtFromDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                txtVoucherNo.Text = string.Empty;
                txtFromDate.Focus();
                productComboFill();
                ProductCodeComboFill();
                salesManComboFill();
                CashorPartyComboFill();
                VoucherTypeComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Vouchertype combobox fill
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                BllVoucherType.voucherTypeComboFill(cmbVoucherType, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Productcode combobox fill
        /// </summary>
        public void ProductCodeComboFill()
        {
            try
            {
                List<DataTable> listObj = BllProductCreation.ProductCodeViewAll(cmbProductCode, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Product combobox fill
        /// </summary>
        public void productComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                listObj = TransactionGeneralFillObj.ProductGroupViewAll(cmbProductGroup, true);
                cmbProductGroup.DataSource = listObj[0];
                cmbProductGroup.DisplayMember = "groupName";
                cmbProductGroup.ValueMember = "groupId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cash or party combobox fill
        /// </summary>
        public void CashorPartyComboFill()
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Salesman combobox fill
        /// </summary>
        public void salesManComboFill()
        {
            try
            {
                TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR: 07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// On reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR: 08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFreeSaleReport_Load(object sender, EventArgs e)
        {
            try
            {
                isFormLoad = true;
                dtpFrmDate.MinDate = PublicVariables._dtFromDate;
                dtpFrmDate.MaxDate = PublicVariables._dtToDate;
                dtpFrmDate.Value = PublicVariables._dtFromDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                txtFromDate.Text = dtpFrmDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                isFormLoad = false;
                productComboFill();
                ProductCodeComboFill();
                salesManComboFill();
                CashorPartyComboFill();
                VoucherTypeComboFill();
                GridFill();
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// On value change of dtpFrmDate
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
                MessageBox.Show("FSR :10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("FSR :11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtFromDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objValidation = new DateValidation();
                objValidation.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == "")
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtFromDate.Text, out dt);
                dtpFrmDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DateValidation objValidation = new DateValidation();
                objValidation.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// On closeup event of dtpFrmDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFrmDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                txtFromDate.Text = dtpFrmDate.Value.ToString("dd-MMM-yyyy");
                txtFromDate.SelectAll();
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// On closeup event of dtpToDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.SelectAll();
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// On search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFromDate.Text != string.Empty && txtToDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                        DateTime dt;
                        DateTime.TryParse(txtToDate.Text, out dt);
                        dtpToDate.Value = dt;
                        dtpFrmDate.Value = dt;
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString();
                    txtToDate.Text = PublicVariables._dtToDate.ToString();
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    dtpFrmDate.Value = dt;
                }
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On print button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet dsfree = new DataSet();
            try
            {
                //SalesMasterSP spSalesMaster = new SalesMasterSP();
                SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                DateTime fromDate, toDate;
                fromDate = Convert.ToDateTime(txtFromDate.Text);
                toDate = Convert.ToDateTime(txtToDate.Text);
                string voucherNo = txtVoucherNo.Text.ToString();
                decimal voucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                decimal groupId = Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString());
                decimal companyId = 1;
                decimal ledgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                decimal employeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                string productCode = cmbProductCode.Text.ToString();
                dsfree = BllSalesInvoice.FreeSaleReportPrint(fromDate, toDate, voucherNo, voucherTypeId, groupId, productCode, ledgerId, employeeId, companyId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                if (dgvFreeSalesReport.Rows.Count > 0)
                {
                    frmReport.freeSaleReport(dsfree);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvFreeSalesReport, "Free Sale Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :27 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
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
                MessageBox.Show("FSR :18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionStart = 0;
                        txtFromDate.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbVoucherType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtVoucherNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text == "" || txtVoucherNo.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrParty.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbCashOrParty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    {
                        txtVoucherNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbSalesMan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    {
                        cmbCashOrParty.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbProductGroup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    {
                        cmbSalesMan.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// backspace navigation of cmbProductCode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    {
                        cmbProductGroup.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FSR :25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFreeSaleReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("FSR :26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
