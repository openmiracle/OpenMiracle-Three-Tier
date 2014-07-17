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
    public partial class frmOverdueSalesOrder : Form
    {
        #region  Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll TransactionsGeneralFillObj = new TransactionsGeneralFillBll();
        frmReminderPopUp frmReminderPopupObj;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of  frmOverdueSalesOrder class
        /// </summary>
        public frmOverdueSalesOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Cash/Party combobox
        /// </summary>
        public void AccountLedgerComboFill()
        {
            try
            {
                TransactionsGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbAccountLeadger, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODSO1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void OverDueSalesOrderGridFill()
        {
            RemainderBll bllRemainder = new RemainderBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                
               
                if (cmbAccountLeadger.SelectedValue.ToString() != "System.Data.DataRowView" && cmbAccountLeadger.Text != "System.Data.DataRowView")
                {
                    decimal decLedgerId = decimal.Parse(cmbAccountLeadger.SelectedValue.ToString());
                    listObj=bllRemainder.OverdueSalesOrderCorrespondingAccountLedger(decLedgerId);
                    dgvOverdueSalesOrder.DataSource = listObj[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODSO2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmReminderPopUp to view details
        /// </summary>
        /// <param name="frmreminder"></param>
        public void CallFromReminder(frmReminderPopUp frmreminder)
        {
            try
            {
                base.Show();
                this.frmReminderPopupObj = frmreminder;
                frmReminderPopupObj.Enabled = false;
                OverDueSalesOrderGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODSO3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOverdueSalesOrder_Load(object sender, EventArgs e)
        {
            try
            {
                AccountLedgerComboFill();
                OverDueSalesOrderGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODSO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on cmbAccountLeadger combobox SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountLeadger_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OverDueSalesOrderGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODSO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enables the object of other forms on Formclosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOverdueSalesOrder_FormClosing(object sender, FormClosingEventArgs e)
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
                MessageBox.Show("ODSO6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclose_Click(object sender, EventArgs e)
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
                MessageBox.Show("ODSO7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        # region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOverdueSalesOrder_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("ODSO8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountLeadger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnclose.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ODSO9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
