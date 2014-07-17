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
    public partial class frmPDCReceivableRegister : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmPdcReceivable frmpdcreceivableObj = new frmPdcReceivable();
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of frmPDCReceivableRegister class
        /// </summary>
        public frmPDCReceivableRegister()
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
                MessageBox.Show("PRREG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill controls 
        /// </summary>
        public void InitialDateSettings()
        {
            try
            {
                dtpDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpTodate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                GridSearchRegister();
                FinancialYearDate();
                txtvoucherNo.Text = string.Empty;
                AccountLedgerComboFill();
                txtDate.Select();
                GridSearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill date
        /// </summary>
        public void FinancialYearDate()
        {
            try
            {
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtFromDate = infoComapany.CurrentDate;
                dtpDate.Value = dtFromDate;
                txtDate.Text = dtFromDate.ToString("dd-MMM-yyyy");
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                dtpTodate.MinDate = PublicVariables._dtFromDate;
                dtpTodate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtToDate = infoComapany.CurrentDate;
                dtpTodate.Value = dtToDate;
                txtToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpTodate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to set Date
        /// </summary>
        public void SetDate()
        {
            try
            {
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtToDate.Text, out dt);
                dtpTodate.Value = dt;
                dtpDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridSearchRegister()
        {
            try
            {
                if (txtDate.Text != string.Empty && txtToDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetDate();
                    }
                }
                else if (txtDate.Text == string.Empty)
                {
                    SetDate();
                }
                if (cmbAccountLedger.Text.Trim() == string.Empty)
                {
                    cmbAccountLedger.Text = "ALL";
                }
                List<DataTable> ListObj = new List<DataTable>();
                PDCRecivebleBll BllPDCReciveble = new PDCRecivebleBll();
                ListObj = BllPDCReciveble.PDCReceivableRegisterSearch(Convert.ToDateTime(dtpDate.Value.ToString()), Convert.ToDateTime(dtpTodate.Value.ToString()), txtvoucherNo.Text.Trim(), cmbAccountLedger.Text.ToString());
                DgvPdCreceivable.DataSource = ListObj[0];
                if (cmbAccountLedger.Text == "ALL")
                {
                    cmbAccountLedger.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPDCReceivableRegister_Load(object sender, EventArgs e)
        {
            try
            {
                InitialDateSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtDate textbox on dtpDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpDate.Value;
                this.txtDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtToDate textbox on dtpTodate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTodate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpTodate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                InitialDateSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridSearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on ViewDetails button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvPdCreceivable.CurrentRow != null)
                {
                    frmPdcReceivable frmpdcreceivableObj = new frmPdcReceivable();
                    decimal decMasterId = Convert.ToDecimal(DgvPdCreceivable.CurrentRow.Cells["pdcReceivableMasterId"].Value.ToString());
                    frmPdcReceivable open = Application.OpenForms["frmPdcReceivable"] as frmPdcReceivable;
                    if (open == null)
                    {
                        frmpdcreceivableObj.WindowState = FormWindowState.Normal;
                        frmpdcreceivableObj.MdiParent = formMDI.MDIObj;
                        frmpdcreceivableObj.CallFromPDCReceivableRegister(this, decMasterId);
                        txtDate.Focus();
                    }
                    else
                    {
                        open.CallFromPDCReceivableRegister(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvPdCreceivable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnViewDetails_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
        /// <summary>
        /// Datevalidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtDate);
                if (!isInvalid)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtDate.Text;
                dtpDate.Value = Convert.ToDateTime(date);
                GridSearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtToDate.Enabled == true)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtDate.Focus();
                    txtDate.SelectionStart = 0;
                    txtDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                bool isInvalid = obj.DateValidationFunction(txtToDate);
                if (!isInvalid)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtToDate.Text;
                dtpTodate.Value = Convert.ToDateTime(date);
                GridSearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtToDate.Enabled == true)
                    {
                        cmbAccountLedger.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDate.Enabled == true)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtvoucherNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionStart = txtToDate.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtvoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DgvPdCreceivable.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtvoucherNo.Text == string.Empty || txtvoucherNo.SelectionStart == 0)
                    {
                        cmbAccountLedger.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPDCReceivableRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PRREG20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvPdCreceivable_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    btnViewDetails_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtvoucherNo.Focus();
                    txtvoucherNo.SelectionStart = txtvoucherNo.TextLength;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRREG21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
