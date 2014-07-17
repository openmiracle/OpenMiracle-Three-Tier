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
    public partial class frmDebitNoteReport : Form
    {
        
        #region Functions
        /// <summary>
        /// Create an instance for frmDebitNoteReport
        /// </summary>
        public frmDebitNoteReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset the form controls here
        /// </summary>
        public void Clear()
        {
            try
            {
                FinancialYearDate();
                VoucherTypeComboLoad();
                AccountLedgerComboFill();
                dtpFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                dtpToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
                txtFromDate.SelectionStart = txtFromDate.TextLength;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeComboLoad()
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> listObjVouchetType = new List<DataTable>();
                listObjVouchetType = BllVoucherType.VoucherTypeSelectionComboFill("Debit Note");
                DataRow dr = listObjVouchetType[0].NewRow();
                dr[0] = 0;
                dr[1] = "ALL";
                listObjVouchetType[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.DataSource = listObjVouchetType[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                dr[2] = "ALL";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbAccountLedger.DataSource = ListObj[0];
                cmbAccountLedger.ValueMember = "ledgerId";
                cmbAccountLedger.DisplayMember = "ledgerName";
                cmbAccountLedger.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To set the from date and todate in the curresponding feilds
        /// </summary>
        public void FinancialYearDate()
        {
            try
            {
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
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtToDate = infoComapany.CurrentDate;
                dtpToDate.Value = dtToDate;
                dtpToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
                txtToDate.Focus();
                txtToDate.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// TO serch the datas and fill the grid
        /// </summary>
        public void Search()
        {
            try
            {
                if (cmbVoucherType.Items.Count != 0 && cmbAccountLedger.Items.Count != 0)
                {
                    if ((cmbAccountLedger.SelectedValue.ToString() != "System.Data.DataRowView") && (cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView"))
                    {
                        if (txtFromDate.Text.Trim() != string.Empty && txtToDate.Text.Trim() != string.Empty)
                        {
                            string strFromDate = txtFromDate.Text;
                            string strToDate = txtToDate.Text;
                            decimal decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                            decimal decLedgerId = Convert.ToDecimal(cmbAccountLedger.SelectedValue.ToString());
                            List<DataTable> listObjDebitNoteReport = new List<DataTable>();
                            //DebitNoteMasterSP spDebitNoteMaster = new DebitNoteMasterSP();
                            DebitNoteBll bllDebitNote = new DebitNoteBll();
                            listObjDebitNoteReport = bllDebitNote.DebitNoteReportSearch(strFromDate, strToDate, decVoucherTypeId, decLedgerId);
                            dgvDebitNoteReport.DataSource = listObjDebitNoteReport[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the details
        /// </summary>
        public void Print()
        {
            try
            {
                if (dgvDebitNoteReport.Rows.Count > 0)
                {
                    string strFromDate = txtFromDate.Text;
                    string strToDate = txtToDate.Text;
                    decimal decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                    decimal decLedgerId = Convert.ToDecimal(cmbAccountLedger.SelectedValue.ToString());
                    //DebitNoteMasterSP SpDebitNoteMaster = new DebitNoteMasterSP();
                    DebitNoteBll bllDebitNote = new DebitNoteBll();
                    DataSet dsDebitNoteReport = bllDebitNote.DebitNoteReportPrinting(strFromDate, strToDate, decVoucherTypeId, decLedgerId, 1);
                    frmReport frmReport = new frmReport();
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.DebitNoteReportPrinting(dsDebitNoteReport);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// When form load call the clear function to reset the controls 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDebitNoteReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to set the Fromdate in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// /// to set the Todate in the textbox
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
                MessageBox.Show("DRNTREP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation and set the dtp value as textbox text
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
                MessageBox.Show("DRNTREP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// /// Date validation and set the dtp value as textbox text
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
                MessageBox.Show("DRNTREP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset button click, Call the clear function and clear the controls
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
                MessageBox.Show("DRNTREP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search button click to call the clear function
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
                    Search();
                }
                else
                {
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    Search();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PORP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Print button click call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDebitNoteReport.RowCount > 0)
                {
                    Print();
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click for open formDebitNote to updation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDebitNoteReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvDebitNoteReport.CurrentRow.Index == e.RowIndex)
                    {
                        decimal decMasterId = Convert.ToDecimal(dgvDebitNoteReport.Rows[e.RowIndex].Cells["dgvtxtDebitNoteMasterId"].Value.ToString());
                        frmDebitNote frmDebitNoteObj = new frmDebitNote();
                        frmDebitNoteObj.MdiParent = formMDI.MDIObj;
                        frmDebitNote open = Application.OpenForms["frmDebitNote"] as frmDebitNote;
                        if (open == null)
                        {
                            frmDebitNoteObj.WindowState = FormWindowState.Normal;
                            frmDebitNoteObj.MdiParent = formMDI.MDIObj;
                            frmDebitNoteObj.CallFromDebitNoteReport(this, decMasterId);
                        }
                        else
                        {
                            open.MdiParent = formMDI.MDIObj;
                            open.BringToFront();
                            open.CallFromDebitNoteReport(this, decMasterId);
                            if (open.WindowState == FormWindowState.Minimized)
                            {
                                open.WindowState = FormWindowState.Normal;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvDebitNoteReport, "Debit Note Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP23: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDebitNoteReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("DRNTREP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
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
                    txtToDate.SelectionStart = txtToDate.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
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
                        txtFromDate.SelectionStart = txtFromDate.TextLength;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbAccountLedger.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionStart = txtToDate.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
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
                    cmbVoucherType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbAccountLedger.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDebitNoteReport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnPrint_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DRNTREP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
