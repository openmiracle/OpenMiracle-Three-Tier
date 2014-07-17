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
    public partial class frmServiceVoucherRegister : Form
    {
        #region Functions
        /// <summary>
        /// Creates an instance of frmServiceVoucherRegister class
        /// </summary>
        public frmServiceVoucherRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill current date on txtFromdate, txtTodate and corresponding datetime pickers dtpFromDate, dtpToDate
        /// </summary>
        public void VoucherDate()
        {
            try
            {
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 1 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                if (cmbCashOrParty.Text.Trim() == string.Empty)
                {
                    cmbCashOrParty.Text = "All";
                }
                ServicesBll BllService = new ServicesBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllService.ServiceVoucherRegisterSearch(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), txtVoucherNo.Text.Trim(), cmbCashOrParty.Text.ToString());
                dgvServiceVoucherRegister.DataSource = listObj[0];
                if (cmbCashOrParty.Text == "All")
                {
                    cmbCashOrParty.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 2 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill  Cash/Party combobox
        /// </summary>
        public void CashOrPartyComboFill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 3 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtVoucherNo.Text = string.Empty;
                VoucherDate();
                CashOrPartyComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 4 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call corresponding voucher for updation
        /// </summary>
        public void DetailsView()
        {
            try
            {
                frmServiceVoucher objfrmServiceVoucher = new frmServiceVoucher();
                if (dgvServiceVoucherRegister.CurrentRow != null)
                {
                    decimal decMasterId = Convert.ToDecimal(dgvServiceVoucherRegister.CurrentRow.Cells["dgvtxtServiceMasterId"].Value.ToString());
                    decimal decVoucherNo = Convert.ToDecimal(dgvServiceVoucherRegister.CurrentRow.Cells["dgvtxtVoucherNo"].Value.ToString());
                    frmServiceVoucher open = Application.OpenForms["frmServiceVoucher"] as frmServiceVoucher;
                    if (open == null)
                    {
                        objfrmServiceVoucher.WindowState = FormWindowState.Normal;
                        objfrmServiceVoucher.MdiParent = formMDI.MDIObj;
                        objfrmServiceVoucher.CallFromServiceVoucherRegister(this, decMasterId, decVoucherNo);
                    }
                    else
                    {
                        open.CallFromServiceVoucherRegister(this, decMasterId, decVoucherNo);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 5 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="dtp"></param>
        public void DateValidation(TextBox txt, DateTimePicker dtp)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txt);
                if (txt.Text == String.Empty)
                {
                    txt.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtp.Value = DateTime.Parse(txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 6 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to close form as  per settings
        /// </summary>
        public void FormClose()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(" SVR 7 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceVoucherRegister_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 8 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SVR 9 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        DateTime dt;
                        DateTime.TryParse(txtToDate.Text, out dt);
                        dtpToDate.Value = dt;
                        dtpFromDate.Value = dt;
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString();
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    dtpFromDate.Value = dt;
                }
                GridFill();
                dgvServiceVoucherRegister.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 10 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SVR 11 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DetailsView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 12 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceVoucherRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)   // Checks for atleast one row, then only  details view works
                {
                    DetailsView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 13 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation(txtFromDate, dtpFromDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 14 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation(txtToDate, dtpToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 15 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate texbox on dtpFromDate datetimepicker ValueChanged
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
                MessageBox.Show("SVR 16 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate texbox on dtpToDate datetimepicker ValueChanged
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
                MessageBox.Show("SVR 17 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmServiceVoucherRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    FormClose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 18 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = txtToDate.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 19 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SVR 20 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtVoucherNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Text == string.Empty || cmbCashOrParty.SelectionStart == 0)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 21 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnRefresh.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text == string.Empty || txtVoucherNo.SelectionStart == 0)
                    {
                        cmbCashOrParty.Focus();
                        cmbCashOrParty.SelectionStart = 0;
                        cmbCashOrParty.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 22 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key  navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceVoucherRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    btnViewDetails.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SVR 23 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
