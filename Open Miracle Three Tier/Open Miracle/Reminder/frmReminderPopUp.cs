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
namespace Open_Miracle
{
    public partial class frmReminderPopUp : Form
    {
        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        bool isFromNegativeStock = false;
        bool isFromMinStock = false;
        bool isFromMaxStock = false;
        bool isFromreorderLevel = false;
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of frmReminderPopUp class
        /// </summary>
        public frmReminderPopUp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to show labels
        /// </summary>
        /// <param name="Salesreminder"></param>
        /// <param name="Purchasereminder"></param>
        /// <param name="Personalreminder"></param>
        /// <param name="ShortExpiryReminder"></param>
        /// <param name="NegativeStkreminder"></param>
        /// <param name="MinStkreminder"></param>
        /// <param name="MaxStkreminder"></param>
        /// <param name="ReordrStkreminder"></param>
        public void ChangeLabel(string Salesreminder, string Purchasereminder, string Personalreminder, string ShortExpiryReminder, string NegativeStkreminder, string MinStkreminder, string MaxStkreminder, string ReordrStkreminder)
        {
            try
            {
                base.Show();
                if (Salesreminder.Trim() != string.Empty)
                {
                    lblReminderSalesdue.Visible = true;
                    lnklblReminderSalesdue.Visible = true;
                    lblReminderSalesdue.Text = Salesreminder;
                }
                else
                {
                    lblReminderSalesdue.Visible = false;
                    lnklblReminderSalesdue.Visible = false;
                }
                if (Purchasereminder.Trim() != string.Empty)
                {
                    lblReminderPurchaseDue.Visible = true;
                    lnklblReminderPurchaseDue.Visible = true;
                    lblReminderPurchaseDue.Text = Purchasereminder;
                }
                else
                {
                    lblReminderPurchaseDue.Visible = false;
                    lnklblReminderPurchaseDue.Visible = false;
                }
                if (Personalreminder.Trim() != string.Empty)
                {
                    lblReminderPersonal.Visible = true;
                    lnklblReminderPersonal.Visible = true;
                    lblReminderPersonal.Text = Personalreminder;
                }
                else
                {
                    lblReminderPersonal.Visible = false;
                    lnklblReminderPersonal.Visible = false;
                }
                if (ShortExpiryReminder.Trim() != string.Empty)
                {
                    lblReminderShortExpiry.Visible = true;
                    lnklblReminderExpiry.Visible = true;
                    lblReminderShortExpiry.Text = ShortExpiryReminder;
                }
                else
                {
                    lblReminderShortExpiry.Visible = false;
                    lnklblReminderExpiry.Visible = false;
                }
                if (NegativeStkreminder.Trim() != string.Empty)
                {
                    lblReminderNegStock.Visible = true;
                    lnklblNegStock.Visible = true;
                    lblReminderNegStock.Text = NegativeStkreminder;
                }
                else
                {
                    lblReminderNegStock.Visible = false;
                    lnklblNegStock.Visible = false;
                }
                if (MinStkreminder.Trim() != string.Empty)
                {
                    lblReminderMinStk.Visible = true;
                    lnklblMinStkReminder.Visible = true;
                    lblReminderMinStk.Text = MinStkreminder;
                }
                else
                {
                    lblReminderMinStk.Visible = false;
                    lnklblMinStkReminder.Visible = false;
                }
                if (MaxStkreminder.Trim() != string.Empty)
                {
                    lblReminderMaxStk.Visible = true;
                    lnklblMaxStkReminder.Visible = true;
                    lblReminderMaxStk.Text = MaxStkreminder;
                }
                else
                {
                    lblReminderMaxStk.Visible = false;
                    lnklblMaxStkReminder.Visible = false;
                }
                if (ReordrStkreminder.Trim() != string.Empty)
                {
                    lblReminderReorder.Visible = true;
                    lnklblReorderReminder.Visible = true;
                    lblReminderReorder.Text = ReordrStkreminder;
                }
                else
                {
                    lblReminderReorder.Visible = false;
                    lnklblReorderReminder.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReminderPopUp_Load(object sender, EventArgs e)
        {
            btnOk.Focus();
        }
        /// <summary>
        /// Calls frmOverduePurchaseOrder form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblReminderPurchaseDue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmOverduePurchaseOrder frmOverduePurchaseOrderObj = new frmOverduePurchaseOrder();
                frmOverduePurchaseOrder open = Application.OpenForms["frmOverduePurchaseOrder"] as frmOverduePurchaseOrder;
                if (open == null)
                {
                    frmOverduePurchaseOrderObj.MdiParent = formMDI.MDIObj;
                    frmOverduePurchaseOrderObj.CallFromReminder(this);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Calls frmOverdueSalesOrder form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblReminderSalesdue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmOverdueSalesOrder frmoverdueSalesOrderObj = new frmOverdueSalesOrder();
                frmOverdueSalesOrder open = Application.OpenForms["frmOverdueSalesOrder"] as frmOverdueSalesOrder;
                if (open == null)
                {
                    frmoverdueSalesOrderObj.MdiParent = formMDI.MDIObj;
                    frmoverdueSalesOrderObj.CallFromReminder(this);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPersonalReminder form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblReminderPersonal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmPersonalReminder frmPersonalReminderObj = new frmPersonalReminder();
                frmPersonalReminder open = Application.OpenForms["frmPersonalReminder"] as frmPersonalReminder;
                if (open == null)
                {
                    frmPersonalReminderObj.MdiParent = formMDI.MDIObj;
                    frmPersonalReminderObj.CallFromReminder(this);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmShortExpiry form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblReminderExpiry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmShortExpiry frmShortExpiryobj = new frmShortExpiry();
                frmShortExpiry open = Application.OpenForms["frmShortExpiry"] as frmShortExpiry;
                if (open == null)
                {
                    frmShortExpiryobj.MdiParent = formMDI.MDIObj;
                    frmShortExpiryobj.CallFromReminder(this);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStock form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblNegStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                isFromNegativeStock = true;
                frmStock frmStockObj = new frmStock();
                frmStock open = Application.OpenForms["frmStock"] as frmStock;
                if (open == null)
                {
                    frmStockObj.MdiParent = formMDI.MDIObj;
                    frmStockObj.CallFromNegativeStockReminder(this, isFromNegativeStock);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStock form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblMinStkReminder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                isFromMinStock = true;
                frmStock frmStockObj = new frmStock();
                frmStock open = Application.OpenForms["frmStock"] as frmStock;
                if (open == null)
                {
                    frmStockObj.MdiParent = formMDI.MDIObj;
                    frmStockObj.CallFromMinStockReminder(this, isFromMinStock);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStock form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblMaxStkReminder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                isFromMaxStock = true;
                frmStock frmStockObj = new frmStock();
                frmStock open = Application.OpenForms["frmStock"] as frmStock;
                if (open == null)
                {
                    frmStockObj.MdiParent = formMDI.MDIObj;
                    frmStockObj.CallFromMaxStockReminder(this, isFromMaxStock);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStock form to view details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblReorderReminder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                isFromreorderLevel = true;
                frmStock frmStockObj = new frmStock();
                frmStock open = Application.OpenForms["frmStock"] as frmStock;
                if (open == null)
                {
                    frmStockObj.MdiParent = formMDI.MDIObj;
                    frmStockObj.CallFromReorderStockReminder(this, isFromreorderLevel);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Closes on 'OK' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReminderPopUp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPU:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
