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
    public partial class frmPDCPayableRegister : Form
    {
        #region Functions
        /// <summary>
        /// Creates an instance of frmPDCPayableRegister class
        /// </summary>
        public frmPDCPayableRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridSearchRegister()
        {
            try
            {
                if (cmbAccountLedger.Text.Trim() == string.Empty)
                {
                    cmbAccountLedger.Text = "ALL";
                }
                List<DataTable> ListObj = new List<DataTable>();
                PDCPayableBll BllPDCPayable = new PDCPayableBll();
                ListObj = BllPDCPayable.PDCpayableRegisterSearch(Convert.ToDateTime(dtpfromDate.Value.ToString()), Convert.ToDateTime(dtpTodate.Value.ToString()), txtvoucherNo.Text.Trim(), cmbAccountLedger.Text.ToString());
                dgvpdcPayableRegister.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill dates
        /// </summary>
        public void FinancialYearDate()
        {
            try
            {
                dtpfromDate.MinDate = PublicVariables._dtFromDate;
                dtpfromDate.MaxDate = PublicVariables._dtToDate;
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtFromDate = infoComapany.CurrentDate;
                dtpfromDate.Value = dtFromDate;
                txtFromDate.Text = dtFromDate.ToString("dd-MMM-yyyy");
                dtpfromDate.Value = Convert.ToDateTime(txtFromDate.Text);
                dtpTodate.MinDate = PublicVariables._dtFromDate;
                dtpTodate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtToDate = infoComapany.CurrentDate;
                dtpTodate.Value = dtToDate;
                txtTodate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpTodate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PPREG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPDCPayableRegister_Load(object sender, EventArgs e)
        {
            try
            {
                InitialDateSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtFromDate textbox on dtpfromDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpfromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpfromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtTodate textbox on dtpTodate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTodate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpTodate.Value;
                this.txtTodate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill  controls as per Settings
        /// </summary>
        public void InitialDateSettings()
        {
            try
            {
                dtpfromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpTodate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                AccountLedgerComboFill();
                GridSearchRegister();
                txtvoucherNo.Text = string.Empty;
                FinancialYearDate();
                txtFromDate.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("POREG8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFromDate.Text != string.Empty && txtTodate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtTodate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTodate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        DateTime dt;
                        DateTime.TryParse(txtTodate.Text, out dt);
                        dtpTodate.Value = dt;
                        dtpfromDate.Value = dt;
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString();
                    txtTodate.Text = PublicVariables._dtCurrentDate.ToString();
                    DateTime dt;
                    DateTime.TryParse(txtTodate.Text, out dt);
                    dtpTodate.Value = dt;
                    dtpfromDate.Value = dt;
                }
                GridSearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTodate_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
               
                if (txtTodate.Text == string.Empty && !txtTodate.Focused)
                {
                    DateValidation obj = new DateValidation();
                    bool isInvalid = obj.DateValidationFunction(txtTodate);
                    if (!isInvalid)
                    {
                        txtTodate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    }
                    string date = txtTodate.Text;
                    dtpTodate.Value = Convert.ToDateTime(date);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                bool isInvalid = obj.DateValidationFunction(txtFromDate);
                if (!isInvalid)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtFromDate.Text;
                dtpfromDate.Value = Convert.ToDateTime(date);
  
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTodate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                bool isInvalid = obj.DateValidationFunction(txtTodate);
                if (!isInvalid)
                {
                    txtTodate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtTodate.Text;
                dtpTodate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvpdcPayableRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvpdcPayableRegister.CurrentRow != null)
                    {
                        decimal decMasterId = Convert.ToDecimal(dgvpdcPayableRegister.Rows[e.RowIndex].Cells["dgvpdcPayableMasterId"].Value.ToString());
                        frmPdcPayable frmpdcPayableObj = new frmPdcPayable();
                       
                        frmpdcPayableObj.MdiParent = formMDI.MDIObj;
                        frmpdcPayableObj.CallFromPDCPayableRegister(this, decMasterId);
                        txtFromDate.Focus();
                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvpdcPayableRegister.CurrentRow != null)
                {
                    decimal decMasterId = Convert.ToDecimal(dgvpdcPayableRegister.CurrentRow.Cells["dgvpdcPayableMasterId"].Value.ToString());
                    frmPdcPayable frmpdcPayableObj = new frmPdcPayable();
                    frmpdcPayableObj.MdiParent = formMDI.MDIObj;
                    frmpdcPayableObj.CallFromPDCPayableRegister(this, decMasterId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclose_Click(object sender, EventArgs e)
        {
            try
            {
                if (Messages.CloseConfirmation())
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// commits edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvpdcPayableRegister_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvpdcPayableRegister.IsCurrentCellDirty)
                {
                    dgvpdcPayableRegister.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
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
                    if (txtTodate.Enabled == true)
                    {
                        txtTodate.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTodate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtTodate.Enabled == true)
                    {
                        cmbAccountLedger.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtTodate.Text == string.Empty || txtTodate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionStart = 0;
                        txtFromDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPDCPayableRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PPREG19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvpdcPayableRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PPREG20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (e.KeyCode == Keys.Back)
                {
                    txtTodate.Focus();
                    txtTodate.SelectionStart = 0;
                    txtTodate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PPREG21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    dgvpdcPayableRegister.Focus();
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
                MessageBox.Show("PPREG21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
