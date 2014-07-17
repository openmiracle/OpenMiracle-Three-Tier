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
    public partial class frmPurchaseOrderRegister : Form
    {
        #region PublicVariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strInvoiceNo = string.Empty;
        string strCondition = string.Empty;
        decimal decLedgerId = 0;
        bool isPendingOrder = false;
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmPurchaseOrderRegister class
        /// </summary>
        public frmPurchaseOrderRegister()
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
                txtOrderNo.Text = string.Empty;
                CashOrPartyComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG1:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
            try
            {
                
                List<DataTable> ListObjPurchaseOrderRegister = new List<DataTable>();
                
                if (txtOrderNo.Text.Trim() == string.Empty)
                {
                    strInvoiceNo = string.Empty;
                }
                else
                {
                    strInvoiceNo = txtOrderNo.Text;
                }
                if (cmbCashOrParty.SelectedIndex == 0 || cmbCashOrParty.SelectedIndex == -1)
                {
                    decLedgerId = -1;
                }
                else
                {
                    decLedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                }
                if (rbtnAll.Checked)
                {
                    strCondition = "All";
                }
                if (rbtnPendingOrder.Checked)
                {
                    strCondition = "Pending";
                }
                if (rbtnOverdue.Checked)
                {
                    strCondition = "Due";
                }
                if (rbtnCancelled.Checked)
                {
                    strCondition = "Cancelled";
                }
                DateTime FromDate = this.dtpFromDate.Value;
                DateTime ToDate = this.dtpToDate.Value;
                ListObjPurchaseOrderRegister = BllPurchaseOrder.PurchaseOrderMasterViewAll(strInvoiceNo, decLedgerId, FromDate, ToDate, strCondition);
                dgvPurchaseOrderRegister.DataSource = ListObjPurchaseOrderRegister[0];
                if (dgvPurchaseOrderRegister.Columns.Count > 0)
                {
                    dgvPurchaseOrderRegister.Columns["dgvtxtBillAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG2:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash/Party combobox
        /// </summary>
        public void CashOrPartyComboFill()
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyComboFill(cmbCashOrParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG3:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Fiils txtFromDate textbox on dtpfromDate Datetimepicker ValueChanged
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
                MessageBox.Show("POREG3:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Fiils txtTodate textbox on dtpTodate Datetimepicker ValueChanged
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
                MessageBox.Show("POREG4:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("POREG5:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("POREG6:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseOrderRegister_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG7:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrderRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (dgvPurchaseOrderRegister.CurrentRow != null)
                    {
                        if (dgvPurchaseOrderRegister.Rows.Count > 0 && e.ColumnIndex > -1)
                        {
                            if (dgvPurchaseOrderRegister.CurrentRow.Cells["dgvtxtPurchaseOrderMasterId"].Value != null && dgvPurchaseOrderRegister.CurrentRow.Cells["dgvtxtPurchaseOrderMasterId"].Value != DBNull.Value)
                            {
                                frmPurchaseOrder.isEdit = true;
                                frmPurchaseOrder frmPurchaseOrderObj = new frmPurchaseOrder();
                                frmPurchaseOrderObj.MdiParent = formMDI.MDIObj;
                                frmPurchaseOrder open = Application.OpenForms["frmPurchaseOrder"] as frmPurchaseOrder;
                                if (open == null)
                                {
                                    frmPurchaseOrderObj.WindowState = FormWindowState.Normal;
                                    frmPurchaseOrderObj.MdiParent = formMDI.MDIObj;//Edited by Najma
                                    frmPurchaseOrderObj.CallFromPurchaseOrderRegister(this, Convert.ToDecimal(dgvPurchaseOrderRegister.CurrentRow.Cells["dgvtxtPurchaseOrderMasterId"].Value.ToString()), isPendingOrder);
                                }
                                else
                                {
                                    open.CallFromPurchaseOrderRegister(this, Convert.ToDecimal(dgvPurchaseOrderRegister.CurrentRow.Cells["dgvtxtPurchaseOrderMasterId"].Value.ToString()), isPendingOrder);
                                    if (open.WindowState == FormWindowState.Minimized)
                                    {
                                        open.WindowState = FormWindowState.Normal;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG8:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the pendingorder status 
        /// </summary >
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnPendingOrder_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnPendingOrder.Checked)
                {
                    isPendingOrder = true;
                }
                else
                {
                    isPendingOrder = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG9:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvPurchaseOrderRegister.CurrentRow != null)
                {
                    DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvPurchaseOrderRegister.CurrentCell.ColumnIndex, dgvPurchaseOrderRegister.CurrentCell.RowIndex);
                    dgvPurchaseOrderRegister_CellDoubleClick(sender, ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG10:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on enter in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrderRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPurchaseOrderRegister.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvPurchaseOrderRegister.CurrentCell.ColumnIndex, dgvPurchaseOrderRegister.CurrentCell.RowIndex);
                        dgvPurchaseOrderRegister_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG11:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("POREG12:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("POREG13:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information); MessageBox.Show("CR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseOrderRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("POREG14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PSR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
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
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG16:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (rbtnAll.Enabled)
                    {
                        rbtnAll.Focus();
                    }
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
                MessageBox.Show("POREG17:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (rbtnPendingOrder.Enabled)
                    {
                        rbtnPendingOrder.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionLength = 0;
                        txtToDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG18:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtOrderNo.Enabled)
                    {
                        txtOrderNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnAll.Enabled)
                    {
                        rbtnAll.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG19:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rbtnOverdue.Enabled)
                    {
                        rbtnOverdue.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtOrderNo.SelectionStart == 0 || txtOrderNo.Text == string.Empty)
                    {
                        if (rbtnPendingOrder.Enabled == true)
                        {
                            rbtnPendingOrder.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG20:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (rbtnCancelled.Enabled)
                    {
                        rbtnCancelled.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtOrderNo.Enabled)
                    {
                        txtOrderNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG21:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnOverdue.Enabled)
                    {
                        rbtnOverdue.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG22:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnReset.Enabled)
                    {
                        btnReset.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnCancelled.Enabled)
                    {
                        rbtnCancelled.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG23:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnRefresh.Enabled)
                    {
                        btnRefresh.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG24:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (dgvPurchaseOrderRegister.Enabled)
                    {
                        dgvPurchaseOrderRegister.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnReset.Enabled)
                    {
                        btnReset.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POREG25:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
