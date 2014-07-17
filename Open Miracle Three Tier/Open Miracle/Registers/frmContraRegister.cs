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
    public partial class frmContraRegister : Form
    {
        #region Functions
        /// <summary>
        /// Creates an instance of frmContraRegister class
        /// </summary>
        public frmContraRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Bank/Cash combobox
        /// </summary>
        public void BankOrCashComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                TransactionsGeneralFillBll Obj = new TransactionsGeneralFillBll();
                listObj = Obj.BankOrCashComboFill(false);
                DataRow dr = listObj[0].NewRow();
                dr[1] = 0;
                dr[0] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbBankOrCash.DataSource = listObj[0];
                cmbBankOrCash.ValueMember = "ledgerId";
                cmbBankOrCash.DisplayMember = "ledgerName";
                cmbBankOrCash.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void Gridfill()
        {
            try
            {
                string strType = string.Empty;
                if (rbtnDeposit.Checked)
                {
                    strType = "Deposit";
                }
                else
                {
                    strType = "Withdraw";
                }
                //ContraMasterSP spContraMaster = new ContraMasterSP();
                ContraVoucherDetailsBll bllContraVoucherDetails = new ContraVoucherDetailsBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = bllContraVoucherDetails.ContraVoucherRegisterSearch(Convert.ToDateTime(dtpFromDate.Value), Convert.ToDateTime(dtpToDate.Value), txtVoucherNo.Text.Trim(), cmbBankOrCash.Text, strType);
                dgvContraRegister.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                rbtnDeposit.Checked = true;            
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtFromDate.Select();
                txtVoucherNo.Text = string.Empty;
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmContraRegister_Load(object sender, EventArgs e)
        {
            try
            {
                BankOrCashComboFill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls ContraVoucher to view details and for updation on cell doubleclick in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvContraRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dgvContraRegister.CurrentRow.Index == e.RowIndex)
                    {
                        if (dgvContraRegister.CurrentRow.Index != -1 && dgvContraRegister.CurrentCell.ColumnIndex != 0)
                        {
                            btnViewDetails_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //---for change date in Date time picker----//
                string strdate = txtFromDate.Text.Trim();
                dtpFromDate.Value = Convert.ToDateTime(strdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("CR:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                obj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtToDate.Text.Trim();
                dtpToDate.Value = Convert.ToDateTime(strdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("CR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On "Search' button click
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
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                BankOrCashComboFill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'ViewDetails button click calls CountraVoucher to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContraRegister.CurrentRow != null)
                {
                    frmContraVoucher objfrmContraVoucher = new frmContraVoucher();
                    decimal decMasterId = Convert.ToDecimal(dgvContraRegister.CurrentRow.Cells["dgvtxtMasterId"].Value.ToString());
                    frmContraVoucher open = Application.OpenForms["frmContraVoucher"] as frmContraVoucher;
                    if (open == null)
                    {
                        objfrmContraVoucher.WindowState = FormWindowState.Normal;
                        objfrmContraVoucher.MdiParent = formMDI.MDIObj;
                        objfrmContraVoucher.CallFromContraRegister(this, decMasterId);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.CallFromContraRegister(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        # endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmContraRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("CR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
                MessageBox.Show("CR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and BackSpace key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnWithdrawal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFromDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    rbtnDeposit.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and BackSpace key navigation
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
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and BackSpace key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbBankOrCash.Focus();
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
                MessageBox.Show("CR:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and BackSpace key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBankOrCash_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherNo.Focus();
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
                MessageBox.Show("CR:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and BackSpace key navigation
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
                    if (txtVoucherNo.Text.Trim() == string.Empty || txtVoucherNo.SelectionStart == 0)
                    {
                        cmbBankOrCash.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter and BackSpace key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvContraRegister_KeyDown(object sender, KeyEventArgs e)
        {
            
                try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvContraRegister.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvContraRegister.CurrentCell.ColumnIndex, dgvContraRegister.CurrentCell.RowIndex);
                        dgvContraRegister_CellDoubleClick(sender, ex);
                    }
                }
            
                else if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                    txtVoucherNo.SelectionStart = txtVoucherNo.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CR:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
