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
    public partial class frmRejectionOutReport : Form
    {

        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strInvoiceNo = string.Empty;
        string strCashOrParty = string.Empty;
        string strRejectionOutNo = string.Empty;
        string strProductCode = string.Empty;
        string strinvoiceNo = string.Empty;
        string strVoucherNo = string.Empty; 
        string strProductName = string.Empty;
        decimal decLedgerId = 0;
        decimal decVoucherTypeId = 0;
        decimal decmaterialReceiptMasterId = 0;
        decimal decReceiptMasterId = 0;
        #endregion

        #region Functions
        /// <summary>
        /// Create an instance for frmRejectionOutReport Class
        /// </summary>
        public frmRejectionOutReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to clear the form controls
        /// </summary>
        public void Clear()
        {
            try
            {
                txtProductCode.Clear();
                txtVoucherNo.Clear();
                txtProductName.Clear();
                DateSettings();
                GridFill();
                CashOrPartyCombofill();
                VoucherTypeComboFill();
                MaterialReceiptComboFill();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to st the date as based on settings
        /// </summary>
        public void DateSettings()
        {
            try
            {
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;

            }
            catch (Exception ex)
            {

                MessageBox.Show("RORP02:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function toprint
        /// </summary>
        public void ReportPrint()
        {
            try
            {
                
                RejectionOutBll bllRejectionOut = new RejectionOutBll();
                decimal decMaterialReceiptNo = 0;
                if (cmbMaterialReceiptNo.SelectedIndex != -1)
                {
                    decMaterialReceiptNo = Convert.ToDecimal(cmbMaterialReceiptNo.SelectedValue.ToString());
                }
                strVoucherNo = txtVoucherNo.Text;
                strProductCode = txtProductCode.Text;
                DataSet dsRejectionOut = bllRejectionOut.RejectionOutReportPrinting(decmaterialReceiptMasterId, 1, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text), Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()), strVoucherNo, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), strProductCode, strProductName);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.RejectionOutReportPrinting(dsRejectionOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RORP03:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to fill CashOrParty combobox
        /// </summary>
        public void CashOrPartyCombofill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionGenericFillObj = new TransactionsGeneralFillBll();
                TransactionGenericFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP04:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
             
                RejectionOutBll bllRejectionOut = new RejectionOutBll();
                List<DataTable> list = new List<DataTable>();
                list = bllRejectionOut.VoucherTypeComboFillForRejectionOutReport();
                cmbVoucherType.DataSource = list[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP05:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill MaterialReceipt combobox
        /// </summary>
        public void MaterialReceiptComboFill()
        {
            try
            {
                MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
                List<DataTable> listobj = new List<DataTable>();
                listobj = bllMaterialReceiptMaster.MaterialReceiptNoCorrespondingToLedgerForReport(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()));
                cmbMaterialReceiptNo.DataSource = listobj[0];
                cmbMaterialReceiptNo.DisplayMember = "invoiceNo";
                cmbMaterialReceiptNo.ValueMember = "materialReceiptMasterId";
                cmbMaterialReceiptNo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP06:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to fill the grid based on conditions
        /// </summary>
        public void GridFill()
        {
            try
            {

                //RejectionOutMasterSP spRejectionOutMaster = new RejectionOutMasterSP();
                RejectionOutBll bllRejectionOut = new RejectionOutBll();
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
                    decLedgerId = 0;
                }
                else
                {
                    decLedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                }
                if (cmbVoucherType.SelectedIndex == 0 || cmbVoucherType.SelectedIndex == -1)
                {
                    decVoucherTypeId = 0;

                }
                else
                {
                    decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                }
                if (cmbMaterialReceiptNo.SelectedIndex == 0 || cmbMaterialReceiptNo.SelectedIndex == -1)
                {
                    decReceiptMasterId = 0;
                }
                else
                {
                    decReceiptMasterId = Convert.ToDecimal(cmbMaterialReceiptNo.SelectedValue.ToString());

                }
                if (txtProductCode.Text.Trim() == string.Empty)
                {
                    strProductCode = string.Empty;
                }
                else
                {
                    strProductCode = txtProductCode.Text;
                }
                if (txtProductName.Text.Trim() == string.Empty)
                {
                    strProductName = string.Empty;
                }
                else
                {
                    strProductName = txtProductName.Text;
                }
                DateTime FromDate = this.dtpFromDate.Value;
                DateTime ToDate = this.dtpToDate.Value;
                List<DataTable>list = bllRejectionOut.RejectionOutReportFill(strinvoiceNo, strProductCode, strProductName, decLedgerId, FromDate, ToDate, decReceiptMasterId, decVoucherTypeId);
                dgvRejectionOutReport.DataSource = list[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP07:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Form load , call the clear to clear the form controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRejectionOutReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP08:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Print button click , call the print function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRejectionOutReport.RowCount > 0)
                {
                    ReportPrint();
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the Material Receipt combo fill function based on cash or party
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCashOrParty.SelectedIndex > -1)
                {
                    if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView")
                    {
                        MaterialReceiptComboFill();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// set the textbox value as dtp's selected value
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// set the textbox value as dtp's selected value
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search button click, to call the grid fill function
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
                MessageBox.Show("ROREP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset button click, call the Clear function
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

                MessageBox.Show("ROREP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For date validation and set the dtp value as text box value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {

            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtFromDate);
                if (!isInvalid)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtFromDate.Text;
                dtpFromDate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For date validation and set the dtp value as text box value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtToDate);
                if (!isInvalid)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvRejectionOutReport, "Rejection Out Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Navigations
        /// <summary>
        /// Form keydown for Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRejectionOutReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("ROREP17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    if (txtToDate.Enabled == true)
                    {
                        txtToDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrParty.Focus();

                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionStart = 0;
                        txtFromDate.SelectionLength = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbMaterialReceiptNo.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {

                    txtToDate.Focus();
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMaterialReceiptNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbMaterialReceiptNo.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtProductCode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text == string.Empty || txtVoucherNo.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtProductName.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Text == string.Empty || txtProductCode.SelectionStart == 0)
                    {
                        txtVoucherNo.Focus();
                        txtVoucherNo.SelectionStart = 0;
                        txtVoucherNo.SelectionLength = 0;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtProductName.Text == string.Empty || txtProductName.SelectionStart == 0)
                    {
                        txtProductCode.Focus();
                        txtProductCode.SelectionStart = 0;
                        txtProductCode.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnPrint.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtProductName.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRejectionOutReport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvRejectionOutReport.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvRejectionOutReport.CurrentCell.ColumnIndex, dgvRejectionOutReport.CurrentCell.RowIndex);
                        dgvRejectionOutReport_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROREP27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Enter)
                {
                    ReportPrint();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click for Updation in selected item frmRejectionOut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRejectionOutReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {

                    frmRejectionOut frmRejectionOutObj = new frmRejectionOut();
                    frmRejectionOutObj.MdiParent = formMDI.MDIObj;


                    frmRejectionOut frmRejectionOutOpen = Application.OpenForms["frmRejectionOut"] as frmRejectionOut;
                    if (frmRejectionOutOpen == null)
                    {
                        frmRejectionOutObj.MdiParent = formMDI.MDIObj;
                        frmRejectionOutObj.CallFromRejectionOutReport(this, Convert.ToDecimal(dgvRejectionOutReport.CurrentRow.Cells["rejectionOutMasterId"].Value));

                    }
                    else
                    {
                        frmRejectionOutOpen.CallFromRejectionOutReport(this, Convert.ToDecimal(dgvRejectionOutReport.CurrentRow.Cells["rejectionOutMasterId"].Value));
                        frmRejectionOutOpen.BringToFront();
                        if (frmRejectionOutOpen.WindowState == FormWindowState.Minimized)
                        {
                            frmRejectionOutOpen.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ROREP29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
        #endregion
}
