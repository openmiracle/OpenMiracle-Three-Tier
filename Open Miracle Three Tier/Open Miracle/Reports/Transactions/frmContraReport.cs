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
    public partial class frmContraReport : Form
    {
        #region PublicVariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strType; 
        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmContraReport class
        /// </summary>
        public frmContraReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Cash/Bank combobox
        /// </summary>
        public void BankOrCashComboFill()
        {
            try
            {
                //ContraMasterSP spContraMaster = new ContraMasterSP();
                ContraVoucherDetailsBll bllContraVoucherDetails = new ContraVoucherDetailsBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = bllContraVoucherDetails.CashOrBankComboFill();
                DataRow dr = listObj[0].NewRow();
                dr[0] = "ALL";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbCashOrBank.DataSource = listObj[0];
                cmbCashOrBank.ValueMember = "ledgerId";
                cmbCashOrBank.DisplayMember = "ledgerName";
                cmbCashOrBank.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> listObjVouchetType = new List<DataTable>();
                listObjVouchetType = BllVoucherType.VoucherTypeSelectionComboFill("Contra Voucher");
                DataRow dr = listObjVouchetType[0].NewRow();
                dr[1] = "ALL";
                listObjVouchetType[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.DataSource = listObjVouchetType[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                //ContraMasterSP spContraMaster = new ContraMasterSP();
                ContraVoucherDetailsBll bllContraVoucherDetails = new ContraVoucherDetailsBll();
                List<DataTable> listObj = new List<DataTable>();
                if (rbtnDeposit.Checked)
                {
                    strType = "Deposit";
                }
                else
                {
                    strType = "Withdraw";
                }
                listObj = bllContraVoucherDetails.ContraReport(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), cmbVoucherType.Text, cmbCashOrBank.Text, strType);
                dgvContraReport.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                BankOrCashComboFill();
                VoucherTypeComboFill();
                rbtnDeposit.Checked = true;
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                cmbVoucherType.SelectedIndex = 0;
                cmbCashOrBank.SelectedIndex = 0;
                GridFill();
                cmbVoucherType.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmContraReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click fills Datagridview
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
                MessageBox.Show("CF:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate textbox on dtpToDate ValueChanged
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
                MessageBox.Show("CRT:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpFromDate ValueChanged
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
                MessageBox.Show("CRT:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtToDate);
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
                MessageBox.Show("CRT:9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtFromDate);
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
                MessageBox.Show("CRT:10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Reset' button click
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
                MessageBox.Show("CRT:11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvContraReport.RowCount > 0)
                {
                    DataSet ds = new DataSet();
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    frmReport reportobj = new frmReport();
                    //ContraMasterSP spContraMaster = new ContraMasterSP();
                    ContraVoucherDetailsBll bllContraVoucherDetails = new ContraVoucherDetailsBll();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    List<DataTable> listObjCotraReport = bllContraVoucherDetails.ContraReport(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), cmbVoucherType.Text, cmbCashOrBank.Text, strType);
                    ds.Tables.Add(listObjCompany[0]);
                    ds.Tables.Add(listObjCotraReport[0]);
                    reportobj.MdiParent = formMDI.MDIObj;
                    reportobj.ContraVoucherReport(ds);
                }
                else
                {
                    MessageBox.Show("No data found", "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding ContraVoucher to view details and for updation on cell doubleclick in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvContraReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmContraVoucher objfrmContraVoucher = new frmContraVoucher();
                if (e.RowIndex != -1)
                {
                    decimal decMasterId = Convert.ToDecimal(dgvContraReport.Rows[e.RowIndex].Cells["dgvtxtMasterId"].Value.ToString());
                    frmContraVoucher open = Application.OpenForms["frmContraVoucher"] as frmContraVoucher;
                    if (open == null)
                    {
                        objfrmContraVoucher.WindowState = FormWindowState.Normal;
                        objfrmContraVoucher = new frmContraVoucher();
                        objfrmContraVoucher.MdiParent = formMDI.MDIObj;
                        objfrmContraVoucher.CallFromContraReport(this, decMasterId);
                    }
                    else
                    {
                        open.CallFromContraReport(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvContraReport, "Contra Voucher Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnDeposit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rbtnWithdrawal.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnWithdrawal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    rbtnDeposit.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbCashOrBank.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    rbtnWithdrawal.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrBank_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFromDate.Focus();
                    txtFromDate.SelectionLength = 0;
                    txtFromDate.SelectionStart = txtFromDate.Text.Length;
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbVoucherType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
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
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = txtFromDate.Text.Length;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtFromDate.Text == string.Empty || txtFromDate.SelectionStart == 0)
                    {
                        cmbCashOrBank.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:18" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text == string.Empty && txtToDate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionLength = 0;
                        txtFromDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvContraReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("CRT:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtToDate.Focus();
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmContraReport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (Messages.CloseConfirmation())
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRT:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
