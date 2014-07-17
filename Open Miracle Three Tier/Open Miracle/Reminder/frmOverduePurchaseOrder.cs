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
using System.Collections;
using System.Diagnostics;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmOverduePurchaseOrder : Form
    {
        #region  Variables
        /// <summary>
        /// Public Varaible declaration part
        /// </summary>
        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
        frmReminderPopUp frmReminderPopupObj = null;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmOverduePurchaseOrder class
        /// </summary>
        public frmOverduePurchaseOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Accountledger combobox
        /// </summary>
        private void AccountLedgerComboFill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionsGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionsGeneralFillObj.CashOrPartyComboFill(cmbAccountLedger, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODPO:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        private void OverDuePurchaseOrderGridFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RemainderBll bllRemainder = new RemainderBll();
                if (cmbAccountLedger.SelectedValue.ToString() != "System.Data.DataRowView" && cmbAccountLedger.Text != "System.Data.DataRowView")
                {
                    decimal decLedgerId = decimal.Parse(cmbAccountLedger.SelectedValue.ToString());
                    listObj = bllRemainder.OverDuePurchaseOrdersCorrespondingAccountLedger(decLedgerId);
                    dgvOverduePurchaseOrder.DataSource = listObj[0];
                    dgvOverduePurchaseOrder.Columns["PurchaseOrderMasterId"].Visible = false;
                    dgvOverduePurchaseOrder.Columns["InvoicedMasterId"].Visible = false;
                    dgvOverduePurchaseOrder.Columns["MR_OrderMasterId"].Visible = false;
                    dgvOverduePurchaseOrder.Columns["ledgerId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODPO:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this from from frmReminderPopUp form to view details
        /// </summary>
        /// <param name="frmReminderPopup"></param>
        public void CallFromReminder(frmReminderPopUp frmReminderPopup)
        {
            try
            {
                base.Show();
                frmReminderPopupObj = frmReminderPopup;
                frmReminderPopupObj.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODPO:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOverduePurchaseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                AccountLedgerComboFill();
                OverDuePurchaseOrderGridFill();
                cmbAccountLedger.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODPO:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills datagridview on AccountLedger combobox SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountLedger_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OverDuePurchaseOrderGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODPO:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("ODPO:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enable sobject of other forms on form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOverduePurchaseOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmReminderPopupObj != null)
                {
                    frmReminderPopupObj.Enabled = true;
                    frmReminderPopupObj.Activate();
                    frmReminderPopupObj.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODPO:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountLedger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClose.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODPO:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
