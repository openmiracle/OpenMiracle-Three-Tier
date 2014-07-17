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
   
    public partial class frmCurrencyDetails : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmExchangeRate frmExchangeRateObj;
        frmCompanyCreation frmCompanyCreationObj;
        frmContraVoucher frmContraVoucherObj;
        frmPaymentVoucher frmPaymentVoucherObj;
        frmReceiptVoucher frmReceiptVoucherObj;
        frmJournalVoucher frmJournalVoucherObj;
        frmDebitNote frmDebitNoteObj = null;
        frmCreditNote frmCreditNoteObj = null;

        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmCurrencyDetails class
        /// </summary>
        public frmCurrencyDetails()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                CurrencyBll BllCurrency = new CurrencyBll();
                List<DataTable> listObj = new List<DataTable>();
                if (txtCurrencyName.Text == string.Empty && txtCurrencySymbol.Text == string.Empty)
                {
                    txtCurrencyName.Text = string.Empty;
                    txtCurrencySymbol.Text = string.Empty;
                }
                listObj = BllCurrency.CurrencySearch(txtCurrencyName.Text, txtCurrencySymbol.Text);
                dgvCurrency.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtCurrencyName.Clear();
                txtCurrencySymbol.Clear();
                txtCurrencyName.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmExchangeRate
        /// </summary>
        /// <param name="frmExchangeRate"></param>
        /// <param name="decId"></param>
        public void CallFromExchangerate(frmExchangeRate frmExchangeRate, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmExchangeRateObj = frmExchangeRate;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[ini].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmCompanyCreation
        /// </summary>
        /// <param name="frmCompanyCreation"></param>
        /// <param name="decId"></param>
        public void CallFromCmpany(frmCompanyCreation frmCompanyCreation, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmCompanyCreationObj = frmCompanyCreation;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[i].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
        /// Function to call this form from frmContraVoucher
       /// </summary>
       /// <param name="frmContraVoucher"></param>
       /// <param name="decId"></param>
        public void CallFromContraVoucher(frmContraVoucher frmContraVoucher, decimal decId)
        {
            try
            {
                base.Show();
                this.frmContraVoucherObj = frmContraVoucher;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[ini].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
        /// Function to call this form from frmPaymentVoucher
       /// </summary>
       /// <param name="frmPaymentVoucher"></param>
       /// <param name="decId"></param>
        public void CallFromPaymentVoucher(frmPaymentVoucher frmPaymentVoucher, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmPaymentVoucherObj = frmPaymentVoucher;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[ini].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
        ///  Function to call this form from frmReceiptVoucher
       /// </summary>
       /// <param name="frmReceiptVoucher"></param>
       /// <param name="decId"></param>
        public void CallFromReceiptVoucher(frmReceiptVoucher frmReceiptVoucher, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmReceiptVoucherObj = frmReceiptVoucher;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[ini].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmJournalVoucher
        /// </summary>
        /// <param name="frmJournalVoucher"></param>
        /// <param name="decId"></param>
        public void CallFromJournalVoucher(frmJournalVoucher frmJournalVoucher, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmJournalVoucherObj = frmJournalVoucher;
                frmJournalVoucherObj.Enabled = false;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[ini].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDebitNote
        /// </summary>
        /// <param name="frmDebitNote"></param>
        /// <param name="decId"></param>
        public void CallFromDebitNoteVoucher(frmDebitNote frmDebitNote, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmDebitNoteObj = frmDebitNote;
                frmDebitNoteObj.Enabled = false;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[ini].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from frmCreditNote
        /// </summary>
        /// <param name="frmCreditNote"></param>
        /// <param name="decId"></param>
       
        public void CallFromCreditNote(frmCreditNote frmCreditNote, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmCreditNoteObj = frmCreditNote;
                frmCreditNoteObj.Enabled = false;
                int inRowCount = dgvCurrency.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvCurrency.Rows[ini].Cells["dgvtxtCurrencyId"].Value.ToString()) == decId)
                    {
                        dgvCurrency.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtCurrencyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrencyDetails_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("CDP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on Search Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On FormClosing opens the form from which frmCurrencyDetails form has opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrencyDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmExchangeRateObj != null)
                {
                    frmExchangeRateObj = Application.OpenForms["frmExchangeRate"] as frmExchangeRate;
                    if (frmExchangeRateObj == null)
                    {
                        frmExchangeRateObj = new frmExchangeRate();
                        frmExchangeRateObj.MdiParent = formMDI.MDIObj;
                        frmExchangeRateObj.Show();
                    }
                    else
                    {
                        frmExchangeRateObj.Activate();
                    }
                }
                if (frmCompanyCreationObj != null)
                {
                    frmCompanyCreationObj = Application.OpenForms["frmCompanyCreation"] as frmCompanyCreation;
                    if (frmCompanyCreationObj == null)
                    {
                        frmCompanyCreationObj = new frmCompanyCreation();
                        frmCompanyCreationObj.MdiParent = formMDI.MDIObj;
                        frmCompanyCreationObj.Show();
                    }
                    else
                    {
                        frmCompanyCreationObj.Activate();
                    }
                }
                if (frmJournalVoucherObj != null)
                {
                    frmJournalVoucherObj.Enabled = true;
                }
                if (frmDebitNoteObj != null)
                {
                    frmDebitNoteObj.Enabled = true;
                }
                if (frmCreditNoteObj != null)
                {
                    frmCreditNoteObj.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears the datagridview selection on binding complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCurrency_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvCurrency.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Opens the respective forms on Datagridview cell double click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCurrency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (frmExchangeRateObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmExchangeRateObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
                if (frmCompanyCreationObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmCompanyCreationObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
                if (frmContraVoucherObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmContraVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
                if (frmJournalVoucherObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmJournalVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
                if (frmPaymentVoucherObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmPaymentVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
                if (frmReceiptVoucherObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmReceiptVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
                if (frmDebitNoteObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmDebitNoteObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
                if (frmCreditNoteObj != null)
                {
                    if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                    {
                        frmCreditNoteObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Closes form on Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCurrencyDetails_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("CDP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCurrencyName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCurrencySymbol.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation on txtCurrencySymbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCurrencySymbol_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCurrencySymbol.Text == string.Empty || txtCurrencySymbol.SelectionStart == 0)
                    {
                        txtCurrencyName.Focus();
                        txtCurrencyName.SelectionStart = 0;
                        txtCurrencyName.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation on btnSearch 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtCurrencySymbol.Focus();
                    txtCurrencySymbol.SelectionLength = 0;
                    txtCurrencySymbol.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enetr key and backspace navigation on Datagridview KeyUp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCurrency_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvCurrency.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvCurrency.CurrentCell.ColumnIndex, dgvCurrency.CurrentCell.RowIndex);
                        if (frmExchangeRateObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmExchangeRateObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmCompanyCreationObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmCompanyCreationObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtCurrencySymbol.Focus();
                    txtCurrencySymbol.SelectionLength = 0;
                    txtCurrencySymbol.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       /// <summary>
        /// Enter key navigation on datagridview KeyDown
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void dgvCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvCurrency.CurrentRow.Index != -1)
                    {
                        if (frmExchangeRateObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmExchangeRateObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmCompanyCreationObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmCompanyCreationObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmContraVoucherObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmContraVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmJournalVoucherObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmJournalVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmPaymentVoucherObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmPaymentVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmReceiptVoucherObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmReceiptVoucherObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmDebitNoteObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmDebitNoteObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                        if (frmCreditNoteObj != null)
                        {
                            if (dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Selected == true)
                            {
                                frmCreditNoteObj.CallFromCurrenCyDetails(this, Convert.ToDecimal(dgvCurrency.CurrentRow.Cells["dgvtxtCurrencyId"].Value.ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CDP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}

