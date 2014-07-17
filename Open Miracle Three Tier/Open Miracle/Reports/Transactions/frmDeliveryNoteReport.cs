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
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmDeliveryNoteReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        VoucherTypeBll BllVoucherType = new VoucherTypeBll();
        //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
        DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
        TransactionsGeneralFillBll TransactionGenerateFillObj = new TransactionsGeneralFillBll();
        SalesOrderBll bllSalesOrder = new SalesOrderBll();
        SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
        VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
        decimal decVoucherTypes = 0;
        string strTypeOfVoucher = string.Empty;
        #endregion
        #region Functions
        /// <summary>
        /// Create an instance for  frmDeliveryNoteReport class
        /// </summary>
        public frmDeliveryNoteReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                List<DataTable> listObjVoucher = new List<DataTable>();
                listObjVoucher = BllVoucherType.VoucherTypeSelectionComboFill("Delivery Note");
                cmbVoucherType.DataSource = listObjVoucher[0];
                DataRow drawselect = listObjVoucher[0].NewRow();
                drawselect["voucherTypeId"] = 0;
                drawselect["voucherTypeName"] = "All";
                listObjVoucher[0].Rows.InsertAt(drawselect, 0);
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash / party combobox
        /// </summary>
        public void CashOrpartyComboFill()
        {
            try
            {
                TransactionGenerateFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP02: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Salesman combobox
        /// </summary>
        public void SalesmanComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                listObj = TransactionGenerateFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
                cmbSalesMan.DataSource = listObj[0];
                cmbSalesMan.ValueMember = "employeeId";
                cmbSalesMan.DisplayMember = "employeeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP03: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the grid
        /// </summary>
        public void GridFill()
        {
            decimal decVoucherTypeId = 0;
            try
            {
                DateTime fromDate = this.dtpFromDate.Value;
                DateTime toDate = this.dtpToDate.Value;
                string strDeliveryMode = cmbDeliveryMode.Text;
                string strInvoiceNo = cmbOrderNo.Text;
                if (cmbCashOrParty.SelectedValue != null && cmbSalesMan.SelectedValue != null)
                {
                    if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbSalesMan.SelectedValue.ToString() != "System.Data.DataRowView" && cmbStatus.Text != "")
                    {
                        if (cmbVoucherType.Text == "All")
                        {
                            decVoucherTypeId = 0;
                        }
                        else
                        {
                            decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                        }
                        if (cmbOrderNo.Text == string.Empty)
                        {
                            strInvoiceNo = "0";
                        }
                        else
                        {
                            strInvoiceNo = cmbOrderNo.Text;
                        }
                        List<DataTable> listObjReport = new List<DataTable>();
                        listObjReport = bllDeliveryNote.DeliveryNoteReportGridFill(fromDate, toDate, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()), txtProductCode.Text, txtVoucherNo.Text, decVoucherTypeId, cmbStatus.Text, PublicVariables._inNoOfDecimalPlaces, strDeliveryMode, strInvoiceNo, Convert.ToDecimal(cmbDeliveryMode.SelectedValue.ToString()));
                        dgvDeliveryNoteReport.DataSource = listObjReport[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP04:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Voucher combobox
        /// </summary>
        public void VoucherComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                listObj = bllDeliveryNote.VoucherTypeViewAllCorrespondingToSalesOrderAndSalesQuotation();
                cmbDeliveryMode.DataSource = listObj[0];
                DataRow drawselect = listObj[0].NewRow();
                drawselect["voucherTypeId"] = 0;
                drawselect["voucherTypeName"] = "All";
                listObj[0].Rows.InsertAt(drawselect, 0);
                cmbDeliveryMode.ValueMember = "voucherTypeId";
                cmbDeliveryMode.DisplayMember = "voucherTypeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP05: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill AgainstOrder combobox
        /// </summary>
        public void AgainstOrderComboFill()
        {
            try
            {
                bool isEveryComboFill = false;
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                SalesQuotationBll bllQuotation = new SalesQuotationBll();
                List<DataTable> ListObj = new List<DataTable>();
                if (cmbCashOrParty.SelectedValue.ToString() != null && cmbDeliveryMode.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    cmbOrderNo.Text = string.Empty;
                    if (strTypeOfVoucher == "Sales Order")
                    {
                        ListObj = bllSalesOrder.GetSalesOrderInvoiceNumberCorrespondingToLedgerId(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbDeliveryMode.SelectedValue.ToString()));
                        DataRow dr = ListObj[0].NewRow();
                        dr[0] = "0";
                        dr[1] = string.Empty;
                        ListObj[0].Rows.InsertAt(dr, 0);
                        cmbOrderNo.DataSource = ListObj[0];
                        if (ListObj[0].Rows.Count > 0)
                        {
                            cmbOrderNo.DisplayMember = "invoiceNo";
                            cmbOrderNo.ValueMember = "salesOrderMasterId";
                            cmbOrderNo.SelectedIndex = 0;
                        }
                    }
                    else if (strTypeOfVoucher == "Sales Quotation")
                    {
                        ListObj = bllQuotation.GetSalesQuotationNumberCorrespondingToLedger(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbDeliveryMode.SelectedValue.ToString()));
                        DataRow dr = ListObj[0].NewRow();
                        dr[0] = "0";
                        dr[1] = string.Empty;
                        ListObj[0].Rows.InsertAt(dr, 0);
                        cmbOrderNo.DataSource = ListObj[0];
                        if (ListObj[0].Rows.Count > 0)
                        {
                            cmbOrderNo.DisplayMember = "invoiceNo";
                            cmbOrderNo.ValueMember = "quotationMasterId";
                        }
                    }
                    else
                    {
                        GridFill();
                    }
                }
                isEveryComboFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP06: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the form controls
        /// </summary>
        public void Clear()
        {
            try
            {
                txtFromDate.Text = dtpFromDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                cmbVoucherType.Text = "All";
                txtVoucherNo.Text = string.Empty;
                cmbCashOrParty.Text = "All";
                cmbSalesMan.Text = "All";
                cmbDeliveryMode.Text = "All";
                cmbOrderNo.Text = string.Empty;
                txtProductCode.Text = string.Empty;
                cmbStatus.Text = "All";
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP07 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// When form load call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDeliveryNoteReport_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.Text = "All";
                CashOrpartyComboFill();
                VoucherComboFill();
                VoucherTypeComboFill();
                SalesmanComboFill();
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP08 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click to view curresponding details to updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDeliveryNoteReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    frmDeliveryNote frmDeliveryNoteObj = new frmDeliveryNote();
                    frmDeliveryNoteObj.MdiParent = formMDI.MDIObj;

                    frmDeliveryNote open = Application.OpenForms["frmDeliveryNote"] as frmDeliveryNote;
                    if (open == null)
                    {
                        frmDeliveryNoteObj.WindowState = FormWindowState.Normal;
                        frmDeliveryNoteObj.MdiParent = formMDI.MDIObj;
                        frmDeliveryNoteObj.CallFromDeliveryNoteReport(this, Convert.ToDecimal(dgvDeliveryNoteReport.CurrentRow.Cells["dgvtxtDeliveryNoteMasterId"].Value.ToString()));
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.CallFromDeliveryNoteReport(this, Convert.ToDecimal(dgvDeliveryNoteReport.CurrentRow.Cells["dgvtxtDeliveryNoteMasterId"].Value.ToString()));
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP09:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Print button click, to print the selected details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            decimal decVoucherTypeId = 0;
            try
            {
                string strDeliveryMode = cmbDeliveryMode.Text;
                string strInvoiceNo = cmbOrderNo.Text;
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                if (dgvDeliveryNoteReport.RowCount > 0)
                {
                    if (cmbVoucherType.Text == "All")
                    {
                        decVoucherTypeId = 0;
                    }
                    else
                    {
                        decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                    }
                    DataSet dsDeliveryNoteReport = bllDeliveryNote.DeliveryNoteReportPrinting(1, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), decVoucherTypeId, this.dtpFromDate.Value, this.dtpToDate.Value, cmbStatus.Text, strDeliveryMode, strInvoiceNo);
                    frmReport frmReport = new frmReport();
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.DeliveryNoteReportPrinting(dsDeliveryNoteReport);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset button click, call the clear function
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
                MessageBox.Show("DNREP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the order no combobox  based on the deliverymode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDeliveryMode_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDeliveryMode.SelectedIndex != 0)
                {
                    cmbOrderNo.Enabled = true;
                    DataTable dtbl = new DataTable();
                    if (cmbDeliveryMode.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        decVoucherTypes = Convert.ToDecimal(cmbDeliveryMode.SelectedValue.ToString());
                    }
                    if (cmbVoucherType.SelectedValue != null)
                    {
                        infoVoucherType = BllVoucherType.TypeOfVoucherBasedOnVoucherTypeId(Convert.ToDecimal(cmbDeliveryMode.SelectedValue.ToString()));
                        strTypeOfVoucher = infoVoucherType.TypeOfVoucher;
                        AgainstOrderComboFill();
                    }
                }
                else
                {
                    cmbOrderNo.DataSource = null;
                    cmbOrderNo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP12: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Fromdate formate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = this.dtpFromDate.Value;
                txtFromDate.Text = fromDate.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP13: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// /// Function to fill the Todate formate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                DateTime toDate = this.dtpToDate.Value;
                txtToDate.Text = toDate.ToString("dd-MMM-yyyy");
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP14: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For date validation and Set the date format
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
                MessageBox.Show("DNREP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For date validation and Set the date format
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
                MessageBox.Show("DNREP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Butten Search click for grid fill 
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
                MessageBox.Show("DNREP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvDeliveryNoteReport, "Delivery Note Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP32 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDeliveryNoteReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("DNREP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP19: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP20: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP21: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbCashOrParty.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.TextLength == 0)
                    {
                        cmbVoucherType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP22: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMan.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP23: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbDeliveryMode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP24: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDeliveryMode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbDeliveryMode.Text != "All")
                    {
                        cmbOrderNo.Focus();
                    }
                    else
                    {
                        txtProductCode.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP25: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductCode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbDeliveryMode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP26: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbStatus.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.TextLength == 0)
                    {
                        if (cmbDeliveryMode.Text != "NA")
                        {
                            cmbOrderNo.Focus();
                        }
                        else
                        {
                            cmbDeliveryMode.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP27: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtProductCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP28: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbStatus.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP29: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP30: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvDeliveryNoteReport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvDeliveryNoteReport.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvDeliveryNoteReport.CurrentCell.ColumnIndex, dgvDeliveryNoteReport.CurrentCell.RowIndex);
                        dgvDeliveryNoteReport_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DNREP31 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
