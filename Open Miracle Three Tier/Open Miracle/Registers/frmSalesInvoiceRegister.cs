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
    public partial class frmSalesInvoiceRegister : Form
    {
        #region PublicVariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
        
        int inCurrenRowIndex = 0;// To keep row index while returning from voucher 
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmSalesInvoiceRegister class
        /// </summary>
        public frmSalesInvoiceRegister()
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
                dtpFormDate.Value = PublicVariables._dtCurrentDate;
                dtpFormDate.MinDate = PublicVariables._dtFromDate;
                dtpFormDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                CashorPartyComboFill();
                VoucherTypeComboFill();
                cmbSalesMode.SelectedIndex = 0;
                gridFill();
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void gridFill()
        {
            decimal decVoucherTypeId = 0;
            decimal decLedgerId = 0;
            string strVoucherNo = string.Empty;
            string strSalesMode = string.Empty;
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                DateTime dtFromdate = this.dtpFormDate.Value;
                DateTime dtTodate = this.dtpToDate.Value;
                if (cmbVoucherType.SelectedIndex > -1)
                {
                    if (cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView" && cmbVoucherType.Text != "System.Data.DataRowView")
                    {
                        if (cmbVoucherType.SelectedIndex == 0 || cmbVoucherType.SelectedIndex == -1)
                        {
                            decVoucherTypeId = 0;
                        }
                        else
                        {
                            decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                        }
                    }
                }
                if (cmbCashorParty.SelectedIndex > -1)
                {
                    if (cmbCashorParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashorParty.Text != "System.Data.DataRowView")
                    {
                        if (cmbCashorParty.SelectedIndex == 0 || cmbCashorParty.SelectedIndex == -1)
                        {
                            decLedgerId = 0;
                        }
                        else
                        {
                            decLedgerId = Convert.ToDecimal(cmbCashorParty.SelectedValue.ToString());
                        }
                    }
                }
                if (cmbVoucherNo.SelectedIndex == 0 || cmbVoucherNo.SelectedIndex == -1)
                {
                    strVoucherNo = string.Empty;
                }
                else
                {
                    strVoucherNo = cmbVoucherNo.Text;
                }
                strSalesMode = cmbSalesMode.Text;
                listObj = BllSalesInvoice.SalesInvoiceRegisterGridfill(dtFromdate, dtTodate, decVoucherTypeId, decLedgerId, strVoucherNo, strSalesMode);
                dgvSiRegister.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR : 2 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash/Party combobox
        /// </summary>
        public void CashorPartyComboFill()
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashorParty, true);
                cmbCashorParty.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR :3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType combobox
        /// </summary>
        public void VoucherTypeComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = BllSalesInvoice.VoucherTypeNameComboFillForSalesInvoiceRegister();
                cmbVoucherType.DataSource = listObj[0];
                DataRow dr = listObj[0].NewRow();
                dr[0] = 0;
                dr[1] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR :4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherNo combobox
        /// </summary>
        public void VoucherNoComboFill()
        {
            decimal decVoucherTypeId = 0;
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                if (cmbVoucherType.SelectedIndex > -1)
                {
                    if (cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView" && cmbVoucherType.Text != "System.Data.DataRowView")
                    {
                        decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                        listObj = BllSalesInvoice.voucherNoViewAllByVoucherTypeIdForSi(decVoucherTypeId);
                        DataRow drow = listObj[0].NewRow();
                        drow["invoiceNo"] = "All";
                        listObj[0].Rows.InsertAt(drow, 0);
                        cmbVoucherNo.DataSource = listObj[0];
                        cmbVoucherNo.DisplayMember = "invoiceNo";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR :5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Fills txtFromDate textbox on dtpfromDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFormDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFormDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SIR: 7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesInvoiceRegister_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills VoucherNo on VoucherType combobox SelectedValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                VoucherNoComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string strdate = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR  : 10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string strdate = txtFromDate.Text;
                dtpFormDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR  : 11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SIR: 12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvSiRegister.CurrentRow != null)
                {
                    inCurrenRowIndex = dgvSiRegister.CurrentRow.Index;
                    if (bool.Parse(dgvSiRegister.CurrentRow.Cells["dgvtxtPos"].Value.ToString()))
                    {
                        frmPOS objfrmpos = new frmPOS();
                        decimal dcRegister = Convert.ToDecimal(dgvSiRegister.CurrentRow.Cells["dgvtxtsalesMasterId"].Value.ToString());
                        frmPOS openpos = Application.OpenForms["frmPOS"] as frmPOS;
                        if (openpos == null)
                        {
                            objfrmpos.WindowState = FormWindowState.Normal;
                            objfrmpos.MdiParent = formMDI.MDIObj;
                            objfrmpos.Show();
                            objfrmpos.CallFromSalesRegister(dcRegister, this);
                        }
                        else
                        {
                            openpos.MdiParent = formMDI.MDIObj;
                            openpos.BringToFront();
                            openpos.CallFromSalesRegister(dcRegister, this);
                            if (openpos.WindowState == FormWindowState.Minimized)
                            {
                                openpos.WindowState = FormWindowState.Normal;
                            }
                        }
                    }
                    else
                    {
                        frmSalesInvoice objfrmSalesInvoice = new frmSalesInvoice();
                        frmSalesInvoice open = Application.OpenForms["frmSalesInvoice"] as frmSalesInvoice;
                        decimal dcRegister = Convert.ToDecimal(dgvSiRegister.CurrentRow.Cells["dgvtxtsalesMasterId"].Value.ToString());
                        if (open == null)
                        {
                            objfrmSalesInvoice.WindowState = FormWindowState.Normal;
                            objfrmSalesInvoice.MdiParent = formMDI.MDIObj;
                            objfrmSalesInvoice.Show();
                            objfrmSalesInvoice.CallFromSalesInvoiceRegister(this, dcRegister);
                        }
                        else
                        {
                            objfrmSalesInvoice.MdiParent = formMDI.MDIObj;
                            open.BringToFront();
                            open.CallFromSalesInvoiceRegister(this, dcRegister);
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
                MessageBox.Show("SIR: 13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSiRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                MessageBox.Show("SIR: 14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SIR :15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        dtpFormDate.Value = dt;
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString();
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    dtpFormDate.Value = dt;
                }
                gridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtToDate.Focus();
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbVoucherType.Focus();
                }
                else if (e.KeyCode == Keys.Back)
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
                MessageBox.Show("SIR: 18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbVoucherNo.Focus();
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
                MessageBox.Show("SIR: 19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashorParty.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbVoucherType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashorParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnReset.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbCashorParty.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnRefresh.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnViewDetails.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnClose.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    btnRefresh.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClose_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    btnViewDetails.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSiRegister_KeyDown(object sender, KeyEventArgs e)
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
                    cmbSalesMode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SIR: 27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesInvoiceRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SIR: 28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
