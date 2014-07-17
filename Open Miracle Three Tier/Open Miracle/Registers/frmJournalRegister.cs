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
    public partial class frmJournalRegister : Form
    {
        #region Functions
        /// <summary>
        /// Creates an instance of frmJournalRegister class
        /// </summary>
        public frmJournalRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Dates
        /// </summary>
        public void SetDate()
        {
            try
            {
                txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtToDate.Text, out dt);
                dtpToDate.Value = dt;
                dtpFromDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the controls
        /// </summary>
        public void Reset()
        {
            try
            {
                dtpFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtVoucherNo.Text = string.Empty;
                txtFromDate.Focus();
                SearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview 
        /// </summary>
        public void SearchRegister()
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
                string strVoucherNo = txtVoucherNo.Text;
                string strToDate = string.Empty;
                string strFromDate = string.Empty;
                if (txtToDate.Text == string.Empty)
                {
                    strToDate = DateTime.Now.ToString();
                }
                else
                {
                    strToDate = txtToDate.Text;
                }
                if (txtFromDate.Text == string.Empty)
                {
                    strFromDate = DateTime.Now.ToString();
                }
                else
                {
                    strFromDate = txtFromDate.Text;
                }
                JournalVoucherBll blljournalMasterSp = new JournalVoucherBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = blljournalMasterSp.JournalRegisterSearch(strVoucherNo, strFromDate, strToDate);
                dgvJournalRegister.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Dates
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
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtToDate = infoComapany.CurrentDate;
                dtpToDate.Value = dtToDate;
                dtpToDate.Text = dtToDate.ToString("dd-MMM-yyyy");
                dtpToDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On Form Load fills the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmJournalRegister_Load(object sender, EventArgs e)
        {
            try
            {
                FinancialYearDate();
                dtpFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                SearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls Corresponding voucher for updation on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvJournalRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnViewDetails_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Commits edit on CurrentCellDirtyStateChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvJournalRegister_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvJournalRegister.IsCurrentCellDirty)
                {
                    dgvJournalRegister.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls Corresponding voucher for updation on 'ViewDetails' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvJournalRegister.CurrentRow != null)
                {
                    frmJournalVoucher frmJournalVoucherObj = new frmJournalVoucher();
                    frmJournalVoucher open = Application.OpenForms["frmJournalVoucher"] as frmJournalVoucher;
                    decimal decMasterId = Convert.ToDecimal(dgvJournalRegister.CurrentRow.Cells["dgvtxtJournalMasterId"].Value.ToString());
                    if (open == null)
                    {
                        frmJournalVoucherObj.WindowState = FormWindowState.Normal;
                        frmJournalVoucherObj.MdiParent = formMDI.MDIObj;
                        frmJournalVoucherObj.CallFromJournalRegister(this, decMasterId);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.CallFromJournalRegister(this, decMasterId);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("JREG9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtpFromDate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date Validation
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
                MessageBox.Show("JREG11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpFromDate datetimepicker ValueChanged 
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
                MessageBox.Show("JREG12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate textbox on dtpToDate datetimepicker ValueChanged 
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
                MessageBox.Show("JREG13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SearchRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmJournalRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("JREG16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherNo.Focus();
                }
                if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionStart = 0;
                        txtFromDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtToDate.SelectionStart = txtToDate.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvJournalRegister.Focus();
                }
                if (txtVoucherNo.Text == string.Empty || txtVoucherNo.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionStart = 0;
                        txtToDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvJournalRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnViewDetails_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                    txtVoucherNo.SelectionStart = txtVoucherNo.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JREG20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
