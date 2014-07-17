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
    public partial class frmSalesOrderRegister : Form
    {
        #region PublicVariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strCondition = string.Empty;
        string strInvoiceNo = string.Empty;
        decimal decLedgerId = 0;
        decimal decQuotationMasterId = 0;
        SalesOrderBll bllSalesOrder = new SalesOrderBll();
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmSalesOrderRegister class
        /// </summary>
        public frmSalesOrderRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                rbtnAll.Checked = true;
                rbtnOverdue.Checked = false;
                rbtnPendingOrder.Checked = false;
                txtFromDate.Focus();
                rbtnCancelled.Checked = false;
                CashOrPartyComboFill();
                SalesOrderNoComboFill(cmbSalesOrderNo);
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                if (cmbSalesOrderNo.SelectedIndex == 0 || cmbSalesOrderNo.SelectedIndex == -1)
                {
                    strInvoiceNo = "All";
                }
                else
                {
                    strInvoiceNo = cmbSalesOrderNo.Text;
                }
                if (cmbCashOrParty.SelectedIndex == 0 || cmbCashOrParty.SelectedIndex == -1)
                {
                    decLedgerId = -1;
                }
                else
                {
                    decLedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                }
                if (rbtnAll.Checked == true)
                {
                    strCondition = "All";
                }
                if (rbtnPendingOrder.Checked == true)
                {
                    strCondition = "Pending";
                }
                if (rbtnOverdue.Checked == true)
                {
                    strCondition = "Due";
                }
                if (rbtnCancelled.Checked == true)
                {
                    strCondition = "Cancelled";
                }
                DateTime FromDate = this.dtpFromDate.Value;
                DateTime ToDate = this.dtpToDate.Value;
                ListObj = bllSalesOrder.SalesOrderRegisterSearch(strInvoiceNo, decLedgerId, FromDate, ToDate, strCondition);
                dgvSalesOrderRegister.DataSource = ListObj[0];
                if (dgvSalesOrderRegister.Columns.Count > 0)
                {
                    dgvSalesOrderRegister.Columns["dgvtxtBillAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SOREG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesOrderNo combobox
        /// </summary>
        /// <param name="cmbSalesOrderNo"></param>
        public void SalesOrderNoComboFill(ComboBox cmbSalesOrderNo)
        {
            try
            {
                bllSalesOrder.SalesOrderNoComboFillOfSalesOrderRegister(cmbSalesOrderNo, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        ///  On 'Close' button click
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
                MessageBox.Show("SOREG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpfromDate Datetimepicker ValueChanged
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
                MessageBox.Show("SOREG6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fiils txtTodate textbox on dtpTodate Datetimepicker ValueChanged
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
                MessageBox.Show("SOREG7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SOREG8:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SOREG9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrderRegister_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrderRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalesOrderRegister.CurrentRow != null)
                {
                    if (dgvSalesOrderRegister.Rows.Count > 0 && e.ColumnIndex > -1)
                    {
                        if (dgvSalesOrderRegister.CurrentRow.Cells["dgvtxtSalesOrderMasterId"].Value != null)
                        {
                            frmSalesOrder frmSalesOrderObj = new frmSalesOrder();
                            frmSalesOrder frmSalesOrderOpen = Application.OpenForms["frmSalesOrder"] as frmSalesOrder;
                            if (frmSalesOrderOpen == null)
                            {
                                frmSalesOrderObj.MdiParent = formMDI.MDIObj;
                                frmSalesOrderObj.WindowState = FormWindowState.Normal;
                                frmSalesOrderObj.CallFromSalesOrderRegister(this, Convert.ToDecimal(dgvSalesOrderRegister.CurrentRow.Cells["dgvtxtSalesOrderMasterId"].Value.ToString()));
                            }
                            else
                            {
                                frmSalesOrderOpen.CallFromSalesOrderRegister(this, Convert.ToDecimal(dgvSalesOrderRegister.CurrentRow.Cells["dgvtxtSalesOrderMasterId"].Value.ToString()));
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
                MessageBox.Show("SOREG11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvSalesOrderRegister.CurrentRow != null)
                {
                    DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvSalesOrderRegister.CurrentCell.ColumnIndex, dgvSalesOrderRegister.CurrentCell.RowIndex);
                    dgvSalesOrderRegister_CellDoubleClick(sender, ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SOREG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SOREG15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbSalesOrderNo.Enabled == true)
                    {
                        cmbSalesOrderNo.Focus();
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
                MessageBox.Show("SOREG16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesOrderNo_KeyDown(object sender, KeyEventArgs e)
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
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrderRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesOrderRegister.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvSalesOrderRegister.CurrentCell.ColumnIndex, dgvSalesOrderRegister.CurrentCell.RowIndex);
                        dgvSalesOrderRegister_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    rbtnAll.Focus();
                    rbtnAll.Checked = false;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesOrderNo.Enabled)
                    {
                        cmbSalesOrderNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnAll_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rbtnPendingOrder.Enabled == true)
                    {
                        rbtnPendingOrder.Focus();
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
                MessageBox.Show("SOREG20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnPendingOrder_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rbtnCancelled.Enabled == true)
                    {
                        rbtnCancelled.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnAll.Enabled == true)
                    {
                        rbtnAll.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnCancelled_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rbtnOverdue.Enabled == true)
                    {
                        rbtnOverdue.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnPendingOrder.Enabled == true)
                    {
                        rbtnPendingOrder.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnOverdue_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnRefresh.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnCancelled.Enabled == true)
                    {
                        rbtnCancelled.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnRefresh.Enabled == true)
                    {
                        btnRefresh.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnCancelled.Enabled == true)
                    {
                        rbtnCancelled.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesOrderRegister.Enabled == true)
                    {
                        dgvSalesOrderRegister.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnReset.Enabled == true)
                    {
                        btnReset.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SOREG25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrderRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SOREG26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
