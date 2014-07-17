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
using System.Data.SqlClient;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmPurchaseInvoiceRegister : Form
    {
        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmPurchaseInvoiceRegister class
        /// </summary>
        public frmPurchaseInvoiceRegister()
        {
            InitializeComponent();
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
                MessageBox.Show("PIREG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeComboFill()
        {
            VoucherTypeBll BllVoucherType = new VoucherTypeBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = BllVoucherType.VoucherTypeSelectionComboFill("Purchase Invoice");
                DataRow drow = listObj[0].NewRow();
                drow["voucherTypeId"] = 0;
                drow["voucherTypeName"] = "All";
                listObj[0].Rows.InsertAt(drow, 0);
                cmbVoucherType.DataSource = listObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                rbtnVoucherDate.Checked = true;
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                cmbCashOrParty.SelectedIndex = 0;
                cmbPurchaseMode.SelectedIndex = 0;
                cmbVoucherType.SelectedIndex = 0;
                txtVoucherNo.Text = string.Empty;
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            string strColumn = string.Empty;
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (rbtnInvoiceDate.Checked)
                {
                    strColumn = rbtnInvoiceDate.Text;
                }
                else
                {
                    strColumn = rbtnVoucherDate.Text;
                }
                ListObj = BllPurchaseInvoice.PurchaseInvoiceRegisterFill(strColumn, dtpFromDate.Value, dtpToDate.Value, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), cmbPurchaseMode.Text, Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()), txtVoucherNo.Text);
                dgvPurchaseRegister.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate serial number
        /// </summary>
        public void SerialNo()
        {
            try
            {
                foreach (DataGridViewRow row in dgvPurchaseRegister.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = row.Index + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseInvoiceRegister_Load(object sender, EventArgs e)
        {
            try
            {
                CashOrPartyComboFill();
                VoucherTypeComboFill();
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
                MessageBox.Show("PIREG8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PIREG9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PIREG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtpToDate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PIREG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PIREG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvPurchaseRegister.CurrentRow != null)
                {
                    decimal decMasterId = Convert.ToDecimal(dgvPurchaseRegister.CurrentRow.Cells["dgvtxtPurchaseMasterId"].Value.ToString());
                    frmPurchaseInvoice frmPurchaseInvoiceObj = new frmPurchaseInvoice();
                    frmPurchaseInvoice frmPurchaseInvoiceOpen = Application.OpenForms["frmPurchaseInvoice"] as frmPurchaseInvoice;
                    if (frmPurchaseInvoiceOpen == null)
                    {
                        frmPurchaseInvoiceObj.MdiParent = formMDI.MDIObj;
                        frmPurchaseInvoiceObj.CallFromPurchaseInvoiceRegister(this, Convert.ToDecimal(dgvPurchaseRegister.CurrentRow.Cells["dgvtxtPurchaseMasterId"].Value.ToString()));
                    }
                    else
                    {
                        frmPurchaseInvoiceOpen.CallFromPurchaseInvoiceRegister(this, Convert.ToDecimal(dgvPurchaseRegister.CurrentRow.Cells["dgvtxtPurchaseMasterId"].Value.ToString()));
                        frmPurchaseInvoiceOpen.BringToFront();
                        if (frmPurchaseInvoiceOpen.WindowState == FormWindowState.Minimized)
                        {
                            frmPurchaseInvoiceOpen.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG14:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    btnViewDetails_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG15:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Commits edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseRegister_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPurchaseRegister.IsCurrentCellDirty)
                {
                    dgvPurchaseRegister.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG16:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Generate serial no when rows added in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseRegister_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG17:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtToDate.Text == string.Empty && !txtToDate.Focused)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG18:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFromDate.Text == string.Empty && !txtFromDate.Focused)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG19:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseInvoiceRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PIREG20:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnVoucherDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rbtnInvoiceDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG21:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnInvoiceDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFromDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    rbtnVoucherDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG22:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtFromDate.SelectionStart == 0)
                    {
                        rbtnInvoiceDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG23:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtToDate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG24:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbPurchaseMode.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG25:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPurchaseMode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG26:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtVoucherNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbPurchaseMode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG27:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtVoucherNo.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG28:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG29:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG30:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPurchaseRegister.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvPurchaseRegister.CurrentCell.ColumnIndex, dgvPurchaseRegister.CurrentCell.RowIndex);
                        dgvPurchaseRegister_CellDoubleClick(sender, ex);
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnRefresh.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG31:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                }
                if (e.KeyCode == Keys.Back)
                {
                    dgvPurchaseRegister.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG32:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnViewDetails.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIREG33:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
