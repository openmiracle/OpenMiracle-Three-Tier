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
    public partial class frmPdcClearanceRegister : Form
    {

        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        bool isDontExecuteVoucherType = false;//To keep voucher Type Execute
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of frmPdcClearanceRegister class
        /// </summary>
        public frmPdcClearanceRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to check the settings and fill accordingly
        /// </summary>
        public void InitialDataSettings()
        {
            try
            {
                dtpFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpTodate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtCheckno.Text = string.Empty;
                AccountLedgerComboFill();
                VoucherTypeComboFill();
                cmbBankAccountFill();
                cmbStatus.SelectedIndex = 0;
                cmbVouchertype.SelectedIndex = 0;
                cmbAccountLedger.SelectedIndex = 0;
                cmbBank.SelectedIndex = 0;
                cmbVouchertype.SelectedIndex = 0;
                FinancialYearDate();
                txtFromDate.Select();
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill dates
        /// </summary>
        public void SetDate()
        {
            txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
            txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
            DateTime dt;
            DateTime.TryParse(txtToDate.Text, out dt);
            dtpTodate.Value = dt;
            dtpFromDate.Value = dt;
        }
        /// <summary>
        /// Function to fill AccountLedger combobox
        /// </summary>
        public void AccountLedgerComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                PDCPayableBll BllPDCPayable = new PDCPayableBll();
                ListObj = BllPDCPayable.AccountLedgerComboFill(false);
                DataRow dr = ListObj[0].NewRow();
                dr["ledgerId"] = 0;
                dr["ledgerName"] = "All";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbAccountLedger.DataSource = ListObj[0];
                cmbAccountLedger.ValueMember = "ledgerId";
                cmbAccountLedger.DisplayMember = "ledgerName";
                cmbAccountLedger.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Bank combobox
        /// </summary>
        public void cmbBankAccountFill()
        {

            try
            {
                PDCPayableBll BllPDCPayable = new PDCPayableBll();
                cmbBank.DataSource = null;
                List<DataTable> ListBank = BllPDCPayable.BankAccountComboFill();
                DataRow dr = ListBank[0].NewRow();
                dr["ledgerId"] = 0;
                dr["ledgerName"] = "All";
                ListBank[0].Rows.InsertAt(dr, 0);
                cmbBank.DataSource = ListBank[0];
                cmbBank.DisplayMember = "ledgerName";
                cmbBank.ValueMember = "ledgerId";
                cmbBank.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                List<DataTable> listObj = new List<DataTable>();
                PDCClearanceBll BllPDCClearance = new PDCClearanceBll();
                cmbVouchertype.DataSource = null;
                listObj = BllPDCClearance.VouchertypeComboFill();
                DataRow dr = listObj[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbVouchertype.DataSource = listObj[0];
                cmbVouchertype.ValueMember = "voucherTypeId";
                cmbVouchertype.DisplayMember = "voucherTypeName";
                cmbVouchertype.SelectedIndex = 0;
                isDontExecuteVoucherType = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Dates
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
                txtFromDate.Text = dtFromDate.ToString("dd-MMM-yyyy");
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
                dtpTodate.MinDate = PublicVariables._dtFromDate;
                dtpTodate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtToDate = infoComapany.CurrentDate;
                dtpTodate.Value = dtToDate;
                txtToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpTodate.Value = Convert.ToDateTime(txtToDate.Text);
                dtpCheckdate.MinDate = PublicVariables._dtFromDate;
                dtpCheckdate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtCheckDate = infoComapany.CurrentDate;
                dtpCheckdate.Value = dtCheckDate;
                txtCheckDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpCheckdate.Value = Convert.ToDateTime(txtCheckDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void Search()
        {
            try
            {
                List<DataTable> ListPDCClearnceRegister = new List<DataTable>();
                PDCClearanceBll BllPDCClearance = new PDCClearanceBll();
                ListPDCClearnceRegister = BllPDCClearance.PDCClearanceRegisterSearch(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpTodate.Value.ToString()), cmbAccountLedger.Text, cmbVouchertype.Text, txtCheckno.Text.Trim(), Convert.ToDecimal(cmbBank.SelectedValue), cmbStatus.Text);
                dgvClearanceSearch.DataSource = ListPDCClearnceRegister[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPdcClearanceRegister_Load(object sender, EventArgs e)
        {
            try
            {
                InitialDataSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                InitialDataSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (Messages.CloseConfirmation())
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClearanceSearch.CurrentRow != null)
                {
                    decimal decMasterId = Convert.ToDecimal(dgvClearanceSearch.CurrentRow.Cells["PDCClearanceMasterId"].Value.ToString());
                    decimal decAgainstId = Convert.ToDecimal(dgvClearanceSearch.CurrentRow.Cells["AgainstId"].Value.ToString());
                    frmPdcClearance frmpdcclerance = new frmPdcClearance();
                    frmPdcClearance open = Application.OpenForms["frmPdcClearance"] as frmPdcClearance;
                    if (open == null)
                    {
                        frmpdcclerance = new frmPdcClearance();
                        frmpdcclerance.WindowState = FormWindowState.Normal;
                        frmpdcclerance.MdiParent = formMDI.MDIObj;
                        frmpdcclerance.CallFromPDCClearanceRegister(this, decMasterId);
                        txtFromDate.Focus();
                    }
                    else
                    {
                        open.CallFromPDCClearanceRegister(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
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
                dtpFromDate.Value = Convert.ToDateTime(strdate.ToString());
                if (txtFromDate.Text != string.Empty && txtToDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Date validation
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
                dtpTodate.Value = Convert.ToDateTime(date);
                if (txtFromDate.Text != string.Empty && txtToDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    }
                }
                else if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCheckDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtCheckDate);
                if (!isInvalid)
                {
                    txtCheckDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtToDate.Text;
                dtpCheckdate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtCheckDate textbox on dtpCheckdate ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpCheckdate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpCheckdate.Value;
                this.txtCheckDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFromDate.Text != string.Empty && txtToDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetDate();
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    SetDate();
                }
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClearanceSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvClearanceSearch.CurrentRow != null)
                    {
                        btnViewDetails_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtFromDate.Focus();
                txtFromDate.SelectionStart = 0;
                txtFromDate.SelectionLength = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate textbox on dtpTodate ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTodate_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                DateTime date = this.dtpTodate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
                txtToDate.Focus();
                txtToDate.SelectionStart = 0;
                txtToDate.SelectionLength = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region navigations
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
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbAccountLedger.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountLedger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbStatus.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtCheckno.Focus();
                    txtCheckno.SelectionLength = 0;
                    txtCheckno.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbAccountLedger.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCheckno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCheckDate.Focus();
                    txtCheckDate.SelectionLength = 0;
                    txtCheckDate.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCheckno.SelectionStart == 0 || txtCheckno.Text == string.Empty)
                    {
                        cmbStatus.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCheckDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbBank.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCheckDate.Text == string.Empty || txtCheckDate.SelectionStart == 0)
                    {
                        txtCheckno.Focus();
                        txtCheckno.SelectionStart = 0;
                        txtCheckno.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBank_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVouchertype.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtCheckDate.Focus();
                    txtCheckDate.SelectionStart = 0;
                    txtCheckDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVouchertype_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvClearanceSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbBank.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbVouchertype.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClearanceSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    btnViewDetails_Click(sender, e);
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnRefresh.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key  navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPdcClearanceRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (Messages.CloseConfirmation())
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PCREG29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
        #endregion