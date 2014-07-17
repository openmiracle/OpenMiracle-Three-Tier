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
    public partial class frmSalesReturnRegister : Form
    {
        #region PublicVariables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        SalesReturnBll bllSalesReturn = new SalesReturnBll();
        TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
        int inCurrenRowIndex = 0;
        bool isFromRegister = false;
        string strdate = string.Empty;
        bool isSalesReturnActive = false;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmSalesReturnRegister
        /// </summary>
        public frmSalesReturnRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        /// 
        public void invoiceNumberfill()
        {
            decimal decVoucherTypeId = 0;
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                if (cmpvoucherType.SelectedIndex > -1)
                {
                    if (cmpvoucherType.SelectedValue.ToString() != "System.Data.DataRowView" && cmpvoucherType.Text != "System.Data.DataRowView")
                    {

                        SalesReturnBll bllSalesReturn = new SalesReturnBll();
                        decVoucherTypeId = Convert.ToDecimal(cmpvoucherType.SelectedValue.ToString());
                        ListObj = bllSalesReturn.invoicenumberviewallforvouchertypeIdforSR(decVoucherTypeId);
                        DataRow drow = ListObj[0].NewRow();
                        drow["invoiceNo"] = "All";
                        ListObj[0].Rows.InsertAt(drow, 0);
                        cmbInvoiceNo.DataSource = ListObj;
                        cmbInvoiceNo.ValueMember = "salesReturnMasterId";
                        cmbInvoiceNo.DisplayMember = "invoiceNo";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        public void Clear()
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                CashOrPartyComboFill(cmbCashOrParty);
                txtFromDate.Focus();
                txtFromDate.SelectionStart = 0;
                txtFromDate.SelectionLength = 2;
                txtSalesReturnNumber.Clear();
                InvoiceNoComboFill(cmbInvoiceNo);
                vouchertypecombofill();
                SalesReturnGrideFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>

        public void vouchertypecombofill()
        {
            try
            {

                bllSalesReturn.VoucherTypeComboFillOfSalesReturnReport(cmpvoucherType, "Sales Return", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR0:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        public void SalesReturnGrideFill()
        {
            try
            {
                decimal decvouchertypeId = 0;
                decimal decAgainstInvoiceNo = 0;
                decimal decLedgerId = 0;
                string strInvoiceNo = string.Empty;
                strInvoiceNo = (txtSalesReturnNumber.Text.Trim() == string.Empty) ? string.Empty : txtSalesReturnNumber.Text;
                decLedgerId = (cmbCashOrParty.SelectedIndex == 0 || cmbCashOrParty.SelectedIndex == -1) ? -1 : Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                decAgainstInvoiceNo = (cmbInvoiceNo.SelectedIndex == 0 || cmbInvoiceNo.SelectedIndex == -1) ? 0 : Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString());
                decvouchertypeId = (cmpvoucherType.SelectedIndex == 0 || cmpvoucherType.SelectedIndex == -1) ? -1 : Convert.ToDecimal(cmpvoucherType.SelectedValue.ToString());
                DateTime FromDate = this.dtpFromDate.Value;
                DateTime ToDate = this.dtpToDate.Value;
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllSalesReturn.SalesReturnRegisterGrideFill(FromDate, ToDate, decLedgerId, strInvoiceNo, decAgainstInvoiceNo, decvouchertypeId);
                dgvSalesReturnRegister.DataSource = ListObj[0];

            }
          
            
            catch (Exception ex)
            {
                MessageBox.Show("SRR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate SerialNumber in Datagridview
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvSalesReturnRegister.Rows)
                {
                    row.Cells["dgvSINo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash/Party combobox
        /// </summary>
        /// <param name="cmbCashorParty"></param>
        public void CashOrPartyComboFill(ComboBox cmbCashorParty)
        {
            try
            {
                obj.CashOrPartyUnderSundryDrComboFill(cmbCashorParty, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesReturnNo combobox
        /// </summary>
        /// <param name="cmbSalesReturnNo"></param>
        public void SalesReturnNoComboFill(ComboBox cmbSalesReturnNo)
        {
            try
            {
                bllSalesReturn.SalesReturnNoComboFillOfSalesReturnRegister(cmbSalesReturnNo, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill InvoiceNo combobox
        /// </summary>
        /// <param name="cmbInvoiceNo"></param>
        public void InvoiceNoComboFill(ComboBox cmbInvoiceNo)
        {
            try
            {
                bllSalesReturn.InvoiceNoComboFillOfSalesReturnRegister(cmbInvoiceNo, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        #region ButtonClick
        /// <summary>
        /// On 'Reset' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");

                cmbCashOrParty.SelectedIndex = 0;
                cmbInvoiceNo.SelectedIndex = 0;
                cmpvoucherType.SelectedIndex = 0;
                txtSalesReturnNumber.Clear();
                invoiceNumberfill();
                SalesReturnGrideFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SalesReturnGrideFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SRR9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvSalesReturnRegister.CurrentRow != null)
                {
                    DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvSalesReturnRegister.CurrentCell.ColumnIndex, dgvSalesReturnRegister.CurrentCell.RowIndex);
                    dgvSalesReturnRegister_CellDoubleClick(sender, ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
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
                MessageBox.Show("SRR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SRR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls corresponding voucher on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturnRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvSalesReturnRegister.CurrentRow != null)
                    {
                        isFromRegister = true;
                        inCurrenRowIndex = dgvSalesReturnRegister.CurrentRow.Index;
                        frmSalesReturn objfrmfrmSalesReturn = new frmSalesReturn();
                        frmSalesReturn open = Application.OpenForms["frmSalesReturn"] as frmSalesReturn;
                        if (open == null)
                        {
                            objfrmfrmSalesReturn.WindowState = FormWindowState.Normal;
                            objfrmfrmSalesReturn.MdiParent = formMDI.MDIObj;
                            objfrmfrmSalesReturn.Show();
                            objfrmfrmSalesReturn.CallFromSalesReturnRegister(this, Convert.ToDecimal(dgvSalesReturnRegister.CurrentRow.Cells["dgvSalesReturnMasterId"].Value.ToString()), isFromRegister, isSalesReturnActive);
                        }
                        else
                        {
                            isSalesReturnActive = true;
                            open.MdiParent = formMDI.MDIObj;
                            if (open.WindowState == FormWindowState.Minimized)
                            {
                                open.WindowState = FormWindowState.Normal;
                            }
                            else
                            {
                                open.Activate();
                            }
                            open.ClearToCallFromSaesReturnRegister();
                            open.CallFromSalesReturnRegister(this, Convert.ToDecimal(dgvSalesReturnRegister.CurrentRow.Cells["dgvSalesReturnMasterId"].Value.ToString()), isFromRegister, isSalesReturnActive);
                            open.BringToFront();
                        }
                        this.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesReturnRegister_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SRR15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SRR16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region navigation
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalesReturnNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (cmpvoucherType.Enabled)
                    {
                        cmpvoucherType.Focus();
                    }
                    else if (btnRefresh.Enabled)
                    {
                        btnRefresh.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtSalesReturnNumber.Text.Trim() == string.Empty)
                    {
                        if (txtToDate.Enabled)
                        {
                            txtToDate.Focus();
                        }
                        else if (txtFromDate.Enabled)
                        {
                            txtFromDate.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Back)
                {
                    if (cmpvoucherType.Enabled)
                    {
                        cmpvoucherType.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (txtSalesReturnNumber.Enabled)
                    {
                        txtSalesReturnNumber.Focus();
                    }
                    else if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesReturnRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SRR19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else if (txtSalesReturnNumber.Enabled)
                    {
                        txtSalesReturnNumber.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (cmpvoucherType.Enabled)
                    {
                        cmpvoucherType.Focus();
                    }
                    else if (btnReset.Enabled)
                    {
                        btnReset.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txtSalesReturnNumber.Enabled)
                    {
                        txtSalesReturnNumber.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else
                    {
                        cmpvoucherType.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text.Trim() == string.Empty && txtToDate.SelectionStart == 0)
                    {
                        if (txtFromDate.Enabled)
                        {
                            txtFromDate.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesReturnNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else
                    {
                        cmpvoucherType.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmpvoucherType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtSalesReturnNumber.Enabled)
                    {
                        txtSalesReturnNumber.Focus();
                    }
                    else if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (txtSalesReturnNumber.Enabled)
                    {
                        txtSalesReturnNumber.Focus();
                    }
                    else if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                    else
                    {
                        txtFromDate.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnRefresh.Enabled)
                    {
                        btnRefresh.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SRR24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void dgvSalesReturnRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnViewDetails_Click(sender, e);
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtSalesReturnNumber.Focus();
                    txtSalesReturnNumber.SelectionStart = txtSalesReturnNumber.TextLength;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRR:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}
