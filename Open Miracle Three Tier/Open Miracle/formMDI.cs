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
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrintWorks;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Reflection;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class formMDI : Form
    {
        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        public static formMDI MDIObj;
        private int childFormNumber = 0;
        public static string DBConnectionType;
        public static bool isEstimateDB = false;
        public static string strEstimateCompanyPath = string.Empty;
        public static bool demoProject = false;
        public static string strVouchertype;
        SettingsBll BllSettings = new SettingsBll();
        frmLoading frmLoadingObj = new frmLoading();
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of formMDI class
        /// </summary>
        public formMDI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to check the Date
        /// </summary>
        public void CurrentDateBefore()
        {
            try
            {
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                DateTime sysDate = System.DateTime.Today;
                PublicVariables._dtCurrentDate = sysDate;
                DateTime date = new DateTime(sysDate.Year, 04, 01);
                DateTime dtFromDate = new DateTime();
                DateTime dtToDate = new DateTime();
                if (sysDate < date)
                {
                    dtFromDate = new DateTime(sysDate.Year - 1, 04, 01);
                    dtToDate = new DateTime(sysDate.Year, 03, 31);
                }
                else
                {
                    dtFromDate = new DateTime(sysDate.Year, 04, 01);
                    dtToDate = new DateTime(sysDate.Year + 1, 03, 31);
                }
                PublicVariables._dtFromDate = dtFromDate;
                PublicVariables._dtToDate = dtToDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 1 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the current Date
        /// </summary>
        public void CurrentDate()
        {
            try
            {
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                FinancialYearInfo infoFinancialYear = new FinancialYearInfo();
                FinancialYearBll bllFinancialYear = new FinancialYearBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                PublicVariables._dtCurrentDate = infoComapany.CurrentDate;
                infoFinancialYear = bllFinancialYear.FinancialYearView(1);
                PublicVariables._dtFromDate = infoFinancialYear.FromDate;
                PublicVariables._dtToDate = infoFinancialYear.ToDate;
                dateToolStripMenuItem.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 2 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the status of settings
        /// </summary>
        public void CurrentSettings()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                SettingsInfo infoSettings = new SettingsInfo();
                if (BllSettings.SettingsStatusCheck("AddConfirmationFor") == "Yes")
                {
                    if (BllSettings.SettingsStatusCheck("Add") == "Yes")
                    {
                        PublicVariables.isMessageAdd = true;
                    }
                    else
                    {
                        PublicVariables.isMessageAdd = false;
                    }
                    if (BllSettings.SettingsStatusCheck("Edit") == "Yes")
                    {
                        PublicVariables.isMessageEdit = true;
                    }
                    else
                    {
                        PublicVariables.isMessageEdit = false;
                    }
                    if (BllSettings.SettingsStatusCheck("Delete") == "Yes")
                    {
                        PublicVariables.isMessageDelete = true;
                    }
                    else
                    {
                        PublicVariables.isMessageDelete = false;
                    }
                    if (BllSettings.SettingsStatusCheck("Close") == "Yes")
                    {
                        PublicVariables.isMessageClose = true;
                    }
                    else
                    {
                        PublicVariables.isMessageClose = false;
                    }
                }
                else
                {
                    PublicVariables.isMessageAdd = PublicVariables.isMessageClose = PublicVariables.isMessageDelete = PublicVariables.isMessageEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to display the current date
        /// </summary>
        public void ShowCurrentDate()
        {
            try
            {
                dateToolStripMenuItem.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 4: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the count of created companies
        /// </summary>
        public void CompanyCount()
        {
            try
            {
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                decimal decCount = bllCompanyCreation.CompanyCount();
                if (decCount > 0)
                {
                    SelectCompanyToolStripMenuItem.Enabled = true;
                }
                else
                {
                    SelectCompanyToolStripMenuItem.Enabled = false;
                }
                SelectCompanyToolStripMenuItem.Enabled = true;
                createCompanyToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 5: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to enable controls when logging 
        /// </summary>
        public void CallFromLogin()
        {
            try
            {
                MenuStripEnabling();
                createCompanyToolStripMenuItem.Enabled = false;
                SelectCompanyToolStripMenuItem.Enabled = false;
                editCompanyToolStripMenuItem1.Enabled = true;
                BackUpToolStripMenuItem.Enabled = true;
                RestoreToolStripMenuItem.Enabled = true;
                dateToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to disable menus on logging
        /// </summary>
        public void MenuStripDisabling()
        {
            try
            {
                companyToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in companyToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                mastersToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in mastersToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }

                transactionToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in transactionToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                registerToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in registerToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                payrollToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in payrollToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                settingsToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in settingsToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                searchToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in searchToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                reminderToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in reminderToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                financialStatementToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in financialStatementToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                reportsToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in reportsToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                budgetToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in budgetToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                exitToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in exitToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
                logoutToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem mi in logoutToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to enable menus
        /// </summary>
        public void MenuStripEnabling()
        {
            try
            {
                companyToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in companyToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                mastersToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in mastersToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                transactionToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in transactionToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                registerToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in registerToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                payrollToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in payrollToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                settingsToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in settingsToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                searchToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in searchToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                reminderToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in reminderToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                financialStatementToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in financialStatementToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                reportsToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in reportsToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                budgetToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in budgetToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                helpToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in helpToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                exitToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in exitToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
                logoutToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem mi in logoutToolStripMenuItem.DropDownItems)
                {
                    mi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to enable and disable  menus on logout
        /// </summary>
        public void LogOut()
        {
            try
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                MenuStripDisabling();
                companyToolStripMenuItem.Enabled = true;
                exitToolStripMenuItem.Enabled = true;
                frmLogin frmLoginObj = new frmLogin();
                frmLoginObj.MdiParent = formMDI.MDIObj;
                frmLoginObj.CallFromFormMdi(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to show quick launch menu
        /// </summary>
        public void ShowQuickLaunchMenu()
        {
            try
            {
                frmQuickLaunch objHedder = new frmQuickLaunch();
                objHedder.MdiParent = this;
                objHedder.Location = this.Location;
                int a = this.Size.Width;
                int b = this.Size.Height;
                objHedder.Size = new Size(200, b - 120);
                objHedder.Location = new Point(a - 212, 0);
                objHedder.Anchor = AnchorStyles.Left;
                objHedder.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call ContraVoucher form on menu Click 
        /// </summary>
        public void ContraVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmContraVoucher))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Contra Voucher";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary> 
        /// Function to call StockJournal voucher on menu click
        /// </summary>
        public void StockJournalClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmStockJournal))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Stock Journal";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PaymentVoucher  on menu click
        /// </summary>
        public void PaymentVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPaymentVoucher))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Payment Voucher";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PdcPayable voucher on menu click
        /// </summary>
        public void PDCPayableClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPdcPayable))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "PDC Payable";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call ReceiptVoucher voucher on menu click
        /// </summary>
        public void ReceiptVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmReceiptVoucher))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Receipt Voucher";
                    frm.CallFromVoucherMenu(strVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call JournalVoucher voucher on menu click
        /// </summary>
        public void JournalVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmJournalVoucher))
                    {
                        frm.Activate();
                        IsActivate = true;
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strJournalVoucherType = "Journal Voucher";
                    frm.CallFromVoucherMenu(strJournalVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PdcReceivable voucher on menu click
        /// </summary>
        public void PDCReceivableClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPdcReceivable))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "PDC Receivable";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PurchaseOrder voucher on menu click
        /// </summary>
        public void PurchaseOrderClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPurchaseOrder))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Purchase Order";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call MaterialReceipt voucher on menu click
        /// </summary>
        public void MaterialReceiptClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmMaterialReceipt))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Material Receipt";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call RejectionOut voucher on menu click
        /// </summary>
        public void RejectionOutClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmRejectionOut))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Rejection Out";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PurchaseInvoice voucher on menu click
        /// </summary>
        public void PurchaseInvoiceClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPurchaseInvoice))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Purchase Invoice";
                    frm.CallFromVoucherMenu(strVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PurchaseReturn voucher on menu click
        /// </summary>
        public void PurchaseReturnClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPurchaseReturn))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Purchase Return";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call SalesQuotation voucher on menu click
        /// </summary>
        public void SalesQuotationClick()
        {
            try
            {
                bool IsActive = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmSalesQuotation))
                    {
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                        form.Activate();
                        IsActive = true;
                    }
                }
                if (IsActive == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Sales Quotation";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call SalesOrder voucher on menu click
        /// </summary>
        public void SalesOrderClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmSalesOrder))
                    {
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                        form.Activate();
                        IsActivate = true;
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Sales Order";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call RejectionIn voucher on menu click
        /// </summary>
        public void RejectionInClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmRejectionIn))
                    {
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                        form.Activate();
                        IsActivate = true;
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Rejection In";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call SalesInvoice voucher on menu click
        /// </summary>
        public void SalesInvoiceClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmSalesInvoice))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Sales Invoice";
                    frm.CallFromVoucherMenu(strVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call SalesReturn voucher on menu click
        /// </summary>
        public void SalesReturnClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmSalesReturn))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Sales Return";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call CreditNote voucher on menu click
        /// </summary>
        public void CreditNoteClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmCreditNote))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strCreditNote = "Credit Note";
                    frm.CallFromVoucherMenu(strCreditNote);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call DebitNote voucher on menu click
        /// </summary>
        public void DebitNoteClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmDebitNote))
                    {
                        frm.Activate();
                        IsActivate = true;
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDebitVoucherType = "Debit Note";
                    frm.CallFromVoucherMenu(strDebitVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PhysicalStock voucher on menu click
        /// </summary>
        public void PhysicalStockClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPhysicalStock))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strPhysicalStockVoucherType = "Physical Stock";
                    frm.CallFromVoucherMenu(strPhysicalStockVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call ServiceVoucher voucher on menu click
        /// </summary>
        public void ServiceVoucherClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmServiceVoucher))
                    {
                        frm.Activate();
                        IsActivate = true;
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (!IsActivate)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strServiceVoucherType = "Service Voucher";
                    frm.CallFromVoucherMenu(strServiceVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call DeliveryNote voucher on menu click
        /// </summary>
        public void DeliveryNoteClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmDeliveryNote))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "Delivery Note";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call PdcClearance voucher on menu click
        /// </summary>
        public void PDCClearenceClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPdcClearance))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strDailyVoucherType = "PDC Clearance";
                    frm.CallFromVoucherMenu(strDailyVoucherType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call POS voucher on menu click
        /// </summary>
        public void POSClick()
        {
            try
            {
                bool IsActivate = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmPOS))
                    {
                        form.Activate();
                        IsActivate = true;
                        if (form.WindowState == FormWindowState.Minimized)
                        {
                            form.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        frm = open;
                        frm.Activate();
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                    string strVoucherType = "Sales Invoice";
                    strVouchertype = "POS";
                    frm.CallFromVoucherMenu(strVoucherType);
                    strVouchertype = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the updation status messages
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void UpdateSetting(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[key].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch { }
        }
        /// <summary>
        /// Function to compare the versions
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="expected"></param>
        /// <returns></returns>
        private static string Test(string lhs, string rhs, int expected)
        {
            int result = 0;
            try
            {
                result = CompareVersions(lhs, rhs);
            }
            catch
            {
            }
            return result.Equals(expected) ? "New" : "Same";
        }
        /// <summary>
        /// Function to replace the version
        /// </summary>
        /// <param name="strA"></param>
        /// <param name="strB"></param>
        /// <returns></returns>
        public static int CompareVersions(String strA, String strB)
        {
            Version vA = new Version(strA.Replace(",", "."));
            Version vB = new Version(strB.Replace(",", "."));
            return vA.CompareTo(vB);
        }
        /// <summary>
        /// Function to check the version and to display the message for upfdation
        /// </summary>
        public void CheckNewVersionComesOfOpenMiracle()
        {
            DateTime dtLastCheckDate = DateTime.Today;
            int inInterval = 0;
            try
            {
                dtLastCheckDate = DateTime.Parse(ConfigurationManager.AppSettings["LastCheckDay"].ToString());
                inInterval = int.Parse(ConfigurationManager.AppSettings["UpdateCheck"].ToString());
            }
            catch { /*catch any exception */}
            if (DateTime.Today >= dtLastCheckDate.AddDays(inInterval))
            {
                if (CheckForInternetConnection())
                {
                    try
                    {
                        Assembly assembly = Assembly.GetExecutingAssembly();
                        FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                        string version = fileVersionInfo.ProductVersion;
                        var result = string.Empty;
                        using (WebClient client = new WebClient())
                        {
                            string htmlCode = client.DownloadString("http://www.openmiracle.com/open_miracle_version.htm");
                            var regex = new Regex(@"<span id=""version"" class=""version"">(.*?)</span>");
                            var match = regex.Match("@" + htmlCode);
                            result = match.Groups[1].Value;
                            var msg = new Regex(@"<span id=""msg"" class=""msg"">(.*?)</span>");
                            var message = msg.Match("@" + htmlCode);
                            var messageToShow = message.Groups[1].Value;
                            var head = new Regex(@"<span id=""heading"" class=""heading"">(.*?)</span>");
                            var check = head.Match("@" + htmlCode);
                            var heading = check.Groups[1].Value;
                            if (messageToShow.ToString().Trim() != string.Empty)
                            {
                                PublicVariables.MessageToShow = messageToShow.ToString();
                                PublicVariables.MessageHeadear = heading.ToString().Trim();
                            }
                        }
                        if (Test(version, result, -1) == "New")
                        {
                            ntfyVersionUpdate.Visible = true;
                            ntfyVersionUpdate.BalloonTipIcon = ToolTipIcon.Info;
                            ntfyVersionUpdate.BalloonTipText = "New version available";
                            ntfyVersionUpdate.BalloonTipTitle = "Open Miracle";
                            ntfyVersionUpdate.ShowBalloonTip(1000);
                            ntfyVersionUpdate.Text = "Update Open Miracle from " + version + " to " + result;
                        }
                        UpdateSetting("LastCheckDay", DateTime.Today.ToString("dd-MMM-yyyy"));
                    }
                    catch { }
                }
            }
        }
        /// <summary>
        /// Function to check the internet connection
        /// </summary>
        /// <returns></returns>
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Function to show the new Form for message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowNewForm(object sender, EventArgs e)
        {
            try
            {
                Form childForm = new Form();
                childForm.MdiParent = this;
                childForm.Text = "Window " + childFormNumber++;
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to open file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formMDI_Load(object sender, EventArgs e)
        {
            try
            {
                CheckNewVersionComesOfOpenMiracle();
                MDIObj = this;
                MenuStripDisabling();
                companyToolStripMenuItem.Enabled = true;
                editCompanyToolStripMenuItem1.Enabled = false;
                BackUpToolStripMenuItem.Enabled = false;
                RestoreToolStripMenuItem.Enabled = false;
                dateToolStripMenuItem.Enabled = false;
                exitToolStripMenuItem.Enabled = true;
                createCompanyToolStripMenuItem.Enabled = true;
                SelectCompanyToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = false;
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                decimal decCompanyCount = bllCompanyCreation.CompanyCount();
                if (decCompanyCount != -1)
                {
                    if (decCompanyCount == 1)
                    {
                        PublicVariables._decCurrentCompanyId = bllCompanyCreation.CompanyGetIdIfSingleCompany();
                        CurrentDate();
                        frmLogin frmLoginObj = new frmLogin();
                        frmLoginObj.MdiParent = MDIObj;
                        frmLoginObj.CallFromFormMdi(this);
                    }
                    else if (decCompanyCount < 1)
                    {
                        CurrentDateBefore();
                        frmCompanyCreation frmCompanyCreationObj = new frmCompanyCreation();
                        frmCompanyCreationObj.MdiParent = formMDI.MDIObj;
                        frmCompanyCreationObj.CallFromFormMdi();
                        SelectCompanyToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        PublicVariables._decCurrentCompanyId = 0;
                        //CompanyPathSP spCompanyPath = new CompanyPathSP();
                        CompanyPathBll bllCompanyPath = new CompanyPathBll();
                        decimal decDefaultCompanyId = bllCompanyPath.CompanyViewForDefaultCompany();
                        if (decDefaultCompanyId > 0)
                        {
                            PublicVariables._decCurrentCompanyId = decDefaultCompanyId;
                            CurrentDate();
                            frmLogin frmLoginObj = new frmLogin();
                            frmLoginObj.MdiParent = formMDI.MDIObj;
                            frmLoginObj.CallFromFormMdi(this);
                        }
                        else
                        {
                            CurrentDate();
                            frmSelectCompany frmSelectCompanyObj = new frmSelectCompany();
                            frmSelectCompanyObj.MdiParent = formMDI.MDIObj;
                            frmSelectCompanyObj.CallFromMdi();
                        }
                    }
                    CurrentSettings();
                }
                else
                {
                    createCompanyToolStripMenuItem.Enabled = false;
                    SelectCompanyToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 40 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'SaveAs' menu click saves the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 41: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Exit' menu click to exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 42: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Changes the Layout of MDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LayoutMdi(MdiLayout.Cascade);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 43: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Changes the Layout of MDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LayoutMdi(MdiLayout.TileVertical);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 44 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Changes the Layout of MDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LayoutMdi(MdiLayout.TileHorizontal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 45 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Changes the Layout of MDI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LayoutMdi(MdiLayout.ArrangeIcons);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 46: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Closes all  child windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 47 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmEmployeeCreation form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployeeCreation frm = new frmEmployeeCreation();
                frmEmployeeCreation open = Application.OpenForms["frmEmployeeCreation"] as frmEmployeeCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 48 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalaryPackageCreation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryPackageCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalaryPackageCreation frm = new frmSalaryPackageCreation();
                frmSalaryPackageCreation open = Application.OpenForms["frmSalaryPackageCreation"] as frmSalaryPackageCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 49: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAdvancePayment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void advancePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsActivate = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmAdvancePayment))
                    {
                        frm.Activate();
                        IsActivate = true;
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    string strVoucherType = "Advance Payment";
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.CallFromVoucherMenu(strVoucherType);
                    }
                    else
                    {
                        open.CallFromVoucherMenu(strVoucherType);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 50 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmEmployeeRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployeeRegister frmEmployeeRegister = new frmEmployeeRegister();
                frmEmployeeRegister open = Application.OpenForms["frmEmployeeRegister"] as frmEmployeeRegister;
                if (open == null)
                {
                    frmEmployeeRegister.MdiParent = this;
                    frmEmployeeRegister.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 51: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAttendance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                frmAttendance objAttendance = new frmAttendance();
                frmAttendance open = Application.OpenForms["frmAttendance"] as frmAttendance;
                if (open == null)
                {
                    objAttendance.MdiParent = this;
                    objAttendance.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 52: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAdvanceRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmadvanceRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdvanceRegister objAdvanceRegister = new frmAdvanceRegister();
                frmAdvanceRegister open = Application.OpenForms["frmAdvanceRegister"] as frmAdvanceRegister;
                if (open == null)
                {
                    objAdvanceRegister.MdiParent = this;
                    objAdvanceRegister.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 53: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls  frmMonthlySalarySettings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthlySalarySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMonthlySalarySettings objMonthlySalarySettings = new frmMonthlySalarySettings();
                frmMonthlySalarySettings open = Application.OpenForms["frmMonthlySalarySettings"] as frmMonthlySalarySettings;
                if (open == null)
                {
                    objMonthlySalarySettings.MdiParent = this;
                    objMonthlySalarySettings.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 54: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmMonthlySalaryVoucher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonthlySalaryVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsActivate = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmMonthlySalaryVoucher))
                    {
                        frm.Activate();
                        IsActivate = true;
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    string strVoucherType = "Monthly Salary Voucher";
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.CallFromVoucherMenu(strVoucherType);
                    }
                    else
                    {
                        open.CallFromVoucherMenu(strVoucherType);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 55 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmHolydaySettings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void holidaySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHolydaySettings frm = new frmHolydaySettings();
                frmHolydaySettings open = Application.OpenForms["frmHolydaySettings"] as frmHolydaySettings;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 56: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Calls frmBonusDeduction form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonusDeductionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmBonusDeduction frm = new frmBonusDeduction();
                frmBonusDeduction open = Application.OpenForms["frmBonusDeduction"] as frmBonusDeduction;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 57: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Calls frmBonusDeductionRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonusDeductionRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmBonusDeductionRegister frm = new frmBonusDeductionRegister();
                frmBonusDeductionRegister open = Application.OpenForms["frmBonusDeductionRegister"] as frmBonusDeductionRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 58 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Calls frmAccountGroup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountGroup frm = new frmAccountGroup();
                frmAccountGroup open = Application.OpenForms["frmAccountGroup"] as frmAccountGroup;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 59: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Calls frmProductGroup form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductGroup frm = new frmProductGroup();
                frmProductGroup open = Application.OpenForms["frmProductGroup"] as frmProductGroup;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 60: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmmultipleAccountLedger form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multipleAccountLedgersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmmultipleAccountLedger frm = new frmmultipleAccountLedger();
                frmmultipleAccountLedger open = Application.OpenForms["frmmultipleAccountLedger"] as frmmultipleAccountLedger;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 61: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBatch form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBatch frm = new frmBatch();
                frmBatch open = Application.OpenForms["frmBatch"] as frmBatch;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 62 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBrand form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBrand frm = new frmBrand();
                frmBrand open = Application.OpenForms["frmBrand"] as frmBrand;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 63 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmModalNo form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modelNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModalNo frm = new frmModalNo();
                frmModalNo open = Application.OpenForms["frmModalNo"] as frmModalNo;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 64 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSize form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSize frm = new frmSize();
                frmSize open = Application.OpenForms["frmSize"] as frmSize;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 65 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmUnit form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUnit frm = new frmUnit();
                frmUnit open = Application.OpenForms["frmUnit"] as frmUnit;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 66 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCurrency form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCurrency frm = new frmCurrency();
                frmCurrency open = Application.OpenForms["frmCurrency"] as frmCurrency;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 67 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmExchangeRate form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exchangeRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmExchangeRate frm = new frmExchangeRate();
                frmExchangeRate open = Application.OpenForms["frmExchangeRate"] as frmExchangeRate;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 68 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmGodown form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void godownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGodown frm = new frmGodown();
                frmGodown open = Application.OpenForms["frmGodown"] as frmGodown;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 69 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Callls frmMultipleProductCreation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multipleProductCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMultipleProductCreation frm = new frmMultipleProductCreation();
                frmMultipleProductCreation open = Application.OpenForms["frmMultipleProductCreation"] as frmMultipleProductCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 70: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPriceList form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPriceList frm = new frmPriceList();
                frmPriceList open = Application.OpenForms["frmPriceList"] as frmPriceList;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 71: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPricingLevel form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pricingLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPricingLevel frm = new frmPricingLevel();
                frmPricingLevel open = Application.OpenForms["frmPricingLevel"] as frmPricingLevel;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 72: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProductRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductRegister", "View"))
                {

                    frmProductRegister frm = new frmProductRegister();
                    frmProductRegister open = Application.OpenForms["frmProductRegister"] as frmProductRegister;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 73: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRack form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRack frm = new frmRack();
                frmRack open = Application.OpenForms["frmRack"] as frmRack;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 74 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmServiceCategory form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServiceCategory frm = new frmServiceCategory();
                frmServiceCategory open = Application.OpenForms["frmServiceCategory"] as frmServiceCategory;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 75 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmServices form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServices frm = new frmServices();
                frmServices open = Application.OpenForms["frmServices"] as frmServices;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 76 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStandardRate form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standardRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmStandardRate frm = new frmStandardRate();
                frmStandardRate open = Application.OpenForms["frmStandardRate"] as frmStandardRate;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 77 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmTax form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTax frm = new frmTax();
                frmTax open = Application.OpenForms["frmTax"] as frmTax;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 78 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmVoucherType form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voucherTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVoucherType frm = new frmVoucherType();
                frmVoucherType open = Application.OpenForms["frmVoucherType"] as frmVoucherType;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 79 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAccountLedger form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountLedger frm = new frmAccountLedger();
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 80 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDailySalaryRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dailySalaryRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDailySalaryRegister frm = new frmDailySalaryRegister();
                frmDailySalaryRegister open = Application.OpenForms["frmDailySalaryRegister"] as frmDailySalaryRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 81 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDailySalaryVoucher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailySalaryVouchertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsActivate = false;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmDailySalaryVoucher))
                    {
                        frm.Activate();
                        IsActivate = true;
                        if (frm.WindowState == FormWindowState.Minimized)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                if (IsActivate == false)
                {
                    string strVoucherType = "Daily Salary Voucher";
                    frmVoucherTypeSelection frm = new frmVoucherTypeSelection();
                    frmVoucherTypeSelection open = Application.OpenForms["frmVoucherTypeSelection"] as frmVoucherTypeSelection;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.CallFromVoucherMenu(strVoucherType);
                    }
                    else
                    {
                        open.CallFromVoucherMenu(strVoucherType);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 82 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalaryPackageRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryPackageRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalaryPackageRegister frm = new frmSalaryPackageRegister();
                frmSalaryPackageRegister open = Application.OpenForms["frmSalaryPackageRegister"] as frmSalaryPackageRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 83 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmMonthlySalaryRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthlySalaryRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMonthlySalaryRegister frm = new frmMonthlySalaryRegister();
                frmMonthlySalaryRegister open = Application.OpenForms["frmMonthlySalaryRegister"] as frmMonthlySalaryRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 84 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmArea form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmArea frm = new frmArea();
                frmArea open = Application.OpenForms["frmArea"] as frmArea;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 85 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCounter form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void counterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCounter frm = new frmCounter();
                frmCounter open = Application.OpenForms["frmCounter"] as frmCounter;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 86 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCustomer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomer frm = new frmCustomer();
                frmCustomer open = Application.OpenForms["frmCustomer"] as frmCustomer;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 87 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSupplier form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSupplier frm = new frmSupplier();
                frmSupplier open = Application.OpenForms["frmSupplier"] as frmSupplier;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 88 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProductBatch form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductBatch frm = new frmProductBatch();
                frmProductBatch open = Application.OpenForms["frmProductBatch"] as frmProductBatch;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 89 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProductCreation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductCreation frm = new frmProductCreation();
                frmProductCreation open = Application.OpenForms["frmProductCreation"] as frmProductCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 90 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRoute form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRoute frm = new frmRoute();
                frmRoute open = Application.OpenForms["frmRoute"] as frmRoute;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 91 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesman form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalesman frm = new frmSalesman();
                frmSalesman open = Application.OpenForms["frmSalesman"] as frmSalesman;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 92 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProductBom form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productBomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductBom frm = new frmProductBom();
                frmProductBom open = Application.OpenForms["frmProductBom"] as frmProductBom;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 93 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Callls frmProductMultipleUnit form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productMultipleUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductMultipleUnit frm = new frmProductMultipleUnit();
                frmProductMultipleUnit open = Application.OpenForms["frmProductMultipleUnit"] as frmProductMultipleUnit;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 94 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call frmDesignation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void designationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmDesignation frm = new frmDesignation();
                frmDesignation open = Application.OpenForms["frmDesignation"] as frmDesignation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 95 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPayHead form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void payHeadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPayHead frm = new frmPayHead();
                frmPayHead open = Application.OpenForms["frmPayHead"] as frmPayHead;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 96 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmContraVoucher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contraVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ContraVoucherClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 97 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call frmPaymentVoucher forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentVoucherClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 98 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCPayable form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdcPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PDCPayableClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 99 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmReceiptVoucher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReceiptVoucherClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 100: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmJournalVoucher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void journalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                JournalVoucherClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 101: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCReceivable form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdcReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PDCReceivableClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 102 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBankReconciliation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankReconciliationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankReconciliation frm = new frmBankReconciliation();
                frmBankReconciliation open = Application.OpenForms["frmBankReconciliation"] as frmBankReconciliation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 103: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseOrder frm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseOrderClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 104:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmMaterialReceipt form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialReceiptClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 105: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRejectionOut form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rejectionOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RejectionOutClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 106 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseInvoice form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseInvoiceClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 107 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseReturn form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PurchaseReturnClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 108: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesQuotation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesQuatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesQuotationClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 109: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesOrder form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesOrderClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI  110: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRejectionIn form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rejectionInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RejectionInClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 111: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesInvoice form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesInvoiceClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 112: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesReturn form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SalesReturnClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 113: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPhysicalStock form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void physicalStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PhysicalStockClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 114: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmServiceVoucher form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceVoucherClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 115: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCreditNote form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CreditNoteClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 116: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDebitNote form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debitNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DebitNoteClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 117: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPartyBalance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void partyBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPartyBalance frm = new frmPartyBalance();
                frmPartyBalance open = Application.OpenForms["frmPartyBalance"] as frmPartyBalance;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 118: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCompanyCreation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PublicVariables._decCurrentCompanyId = 0;
                PublicVariables._dtFromDate = Convert.ToDateTime("01-Jan-0001");
                PublicVariables._dtToDate = Convert.ToDateTime("31-Dec-9999");
                List<Form> openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);
                foreach (Form f in openForms)
                {
                    if (f.Name != "formMDI")
                        f.Close();
                }
                frmCompanyCreation frm = new frmCompanyCreation();
                frmCompanyCreation open = Application.OpenForms["frmCompanyCreation"] as frmCompanyCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 119: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPaySlip form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPaySlip objPaySlip = new frmPaySlip();
                frmPaySlip open = Application.OpenForms["frmPaySlip"] as frmPaySlip;
                if (open == null)
                {
                    objPaySlip.MdiParent = this;
                    objPaySlip.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 120: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmContraRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContraRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmContraRegister", "View"))
                {
                    frmContraRegister objContraRegister = new frmContraRegister();
                    frmContraRegister open = Application.OpenForms["frmContraRegister"] as frmContraRegister;
                    if (open == null)
                    {
                        objContraRegister.MdiParent = this;
                        objContraRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 121: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPaymentRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paymentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPaymentRegister", "View"))
                {
                    frmPaymentRegister objPaymentRegister = new frmPaymentRegister();
                    frmPaymentRegister open = Application.OpenForms["frmPaymentRegister"] as frmPaymentRegister;
                    if (open == null)
                    {
                        objPaymentRegister.MdiParent = this;
                        objPaymentRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 122: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmReceiptRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receiptRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmReceiptRegister", "View"))
                {
                    frmReceiptRegister objReceiptRegister = new frmReceiptRegister();
                    frmReceiptRegister open = Application.OpenForms["frmReceiptRegister"] as frmReceiptRegister;
                    if (open == null)
                    {
                        objReceiptRegister.MdiParent = this;
                        objReceiptRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 123: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmJournalRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void journalRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmJournalRegister", "View"))
                {
                    frmJournalRegister objJournalRegister = new frmJournalRegister();
                    frmJournalRegister open = Application.OpenForms["frmJournalRegister"] as frmJournalRegister;
                    if (open == null)
                    {
                        objJournalRegister.MdiParent = this;
                        objJournalRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 124: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCPayableRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PDCPayableRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCPayableRegister", "View"))
                {
                    frmPDCPayableRegister objPDCPayableRegister = new frmPDCPayableRegister();
                    frmPDCPayableRegister open = Application.OpenForms["frmPDCPayableRegister"] as frmPDCPayableRegister;
                    if (open == null)
                    {
                        objPDCPayableRegister.MdiParent = this;
                        objPDCPayableRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 125: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCReceivableRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PDCReceivableRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCReceivableRegister", "View"))
                {
                    frmPDCReceivableRegister objPDCReceivableRegister = new frmPDCReceivableRegister();
                    frmPDCReceivableRegister open = Application.OpenForms["frmPDCReceivableRegister"] as frmPDCReceivableRegister;
                    if (open == null)
                    {
                        objPDCReceivableRegister.MdiParent = this;
                        objPDCReceivableRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 126: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmMaterialReceiptRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialReceiptRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMaterialReceiptRegister", "View"))
                {
                    frmMaterialReceiptRegister objMaterialReceiptRegister = new frmMaterialReceiptRegister();
                    frmMaterialReceiptRegister open = Application.OpenForms["frmMaterialReceiptRegister"] as frmMaterialReceiptRegister;
                    if (open == null)
                    {
                        objMaterialReceiptRegister.MdiParent = this;
                        objMaterialReceiptRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 127: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRejectionOutRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rejectionOutRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionOutRegister", "View"))
                {
                    frmRejectionOutRegister objRejectionOutRegister = new frmRejectionOutRegister();
                    frmRejectionOutRegister open = Application.OpenForms["frmRejectionOutRegister"] as frmRejectionOutRegister;
                    if (open == null)
                    {
                        objRejectionOutRegister.MdiParent = this;
                        objRejectionOutRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 128: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseInvoiceRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseInvoiceRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPurchaseInvoiceRegister objPurchaseInvoiceRegister = new frmPurchaseInvoiceRegister();
                frmPurchaseInvoiceRegister open = Application.OpenForms["frmPurchaseInvoiceRegister"] as frmPurchaseInvoiceRegister;
                if (open == null)
                {
                    objPurchaseInvoiceRegister.MdiParent = this;
                    objPurchaseInvoiceRegister.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 129: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseReturnRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseReturnRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseReturnRegister", "View"))
                {
                    frmPurchaseReturnRegister objPurchaseReturnRegister = new frmPurchaseReturnRegister();
                    frmPurchaseReturnRegister open = Application.OpenForms["frmPurchaseReturnRegister"] as frmPurchaseReturnRegister;
                    if (open == null)
                    {
                        objPurchaseReturnRegister.MdiParent = this;
                        objPurchaseReturnRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 130: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesQuotationRegister form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesQuotationRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesQuotationRegister", "View"))
                {
                    frmSalesQuotationRegister objSalesQuotationRegister = new frmSalesQuotationRegister();
                    frmSalesQuotationRegister open = Application.OpenForms["frmSalesQuotationRegister"] as frmSalesQuotationRegister;
                    if (open == null)
                    {
                        objSalesQuotationRegister.MdiParent = this;
                        objSalesQuotationRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 131: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesOrderRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesOrderRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesOrderRegister", "View"))
                {
                    frmSalesOrderRegister objSalesOrderRegister = new frmSalesOrderRegister();
                    frmSalesOrderRegister open = Application.OpenForms["frmSalesOrderRegister"] as frmSalesOrderRegister;
                    if (open == null)
                    {
                        objSalesOrderRegister.MdiParent = this;
                        objSalesOrderRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 132: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDeliveryNoteRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deliveryNoteRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDeliveryNoteRegister", "View"))
                {
                    frmDeliveryNoteRegister objDeliveryNoteRegister = new frmDeliveryNoteRegister();
                    frmDeliveryNoteRegister open = Application.OpenForms["frmDeliveryNoteRegister"] as frmDeliveryNoteRegister;
                    if (open == null)
                    {
                        objDeliveryNoteRegister.MdiParent = this;
                        objDeliveryNoteRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 133: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRejectionInRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rejectionInRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionInRegister", "View"))
                {
                    frmRejectionInRegister objRejectionInRegister = new frmRejectionInRegister();
                    frmRejectionInRegister open = Application.OpenForms["frmRejectionInRegister"] as frmRejectionInRegister;
                    if (open == null)
                    {
                        objRejectionInRegister.MdiParent = this;
                        objRejectionInRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 134: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesInvoiceRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesInvoiceRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesInvoiceRegister", "View"))
                {
                    frmSalesInvoiceRegister objSalesInvoiceRegister = new frmSalesInvoiceRegister();
                    frmSalesInvoiceRegister open = Application.OpenForms["frmSalesInvoiceRegister"] as frmSalesInvoiceRegister;
                    if (open == null)
                    {
                        objSalesInvoiceRegister.MdiParent = this;
                        objSalesInvoiceRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 135: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesReturnRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesReturnRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesReturnRegister", "View"))
                {
                    frmSalesReturnRegister objSalesReturnRegister = new frmSalesReturnRegister();
                    frmSalesReturnRegister open = Application.OpenForms["frmSalesReturnRegister"] as frmSalesReturnRegister;
                    if (open == null)
                    {
                        objSalesReturnRegister.MdiParent = this;
                        objSalesReturnRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 136: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPhysicalStockRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void physicalStockRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPhysicalStockRegister", "View"))
                {
                    frmPhysicalStockRegister objPhysicalStockRegister = new frmPhysicalStockRegister();
                    frmPhysicalStockRegister open = Application.OpenForms["frmPhysicalStockRegister"] as frmPhysicalStockRegister;
                    if (open == null)
                    {
                        objPhysicalStockRegister.MdiParent = this;
                        objPhysicalStockRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 137: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmServiceVoucherRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceVoucherRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmServiceVoucherRegister", "View"))
                {
                    frmServiceVoucherRegister objServiceVoucherRegister = new frmServiceVoucherRegister();
                    frmServiceVoucherRegister open = Application.OpenForms["frmServiceVoucherRegister"] as frmServiceVoucherRegister;
                    if (open == null)
                    {
                        objServiceVoucherRegister.MdiParent = this;
                        objServiceVoucherRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 138: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCreditNoteRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creditNoteRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCreditNoteRegister", "View"))
                {
                    frmCreditNoteRegister objCreditNoteRegister = new frmCreditNoteRegister();
                    frmCreditNoteRegister open = Application.OpenForms["frmCreditNoteRegister"] as frmCreditNoteRegister;
                    if (open == null)
                    {
                        objCreditNoteRegister.MdiParent = this;
                        objCreditNoteRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 139: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDebitNoteRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debitNoteRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDebitNoteRegister", "View"))
                {
                    frmDebitNoteRegister objDebitNoteRegister = new frmDebitNoteRegister();
                    frmDebitNoteRegister open = Application.OpenForms["frmDebitNoteRegister"] as frmDebitNoteRegister;
                    if (open == null)
                    {
                        objDebitNoteRegister.MdiParent = this;
                        objDebitNoteRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 140: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStockJournalRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockJournalRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStockJournalRegister", "View"))
                {
                    frmStockJournalRegister objStockJournalRegister = new frmStockJournalRegister();
                    frmStockJournalRegister open = Application.OpenForms["frmStockJournalRegister"] as frmStockJournalRegister;
                    if (open == null)
                    {
                        objStockJournalRegister.MdiParent = this;
                        objStockJournalRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 141 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStockjournel form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StockJournalClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 142: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBarcodePrinting form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodePrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmBarcodePrinting", "View"))
                {
                    frmBarcodePrinting objBarcodePrinting = new frmBarcodePrinting();
                    frmBarcodePrinting open = Application.OpenForms["frmBarcodePrinting"] as frmBarcodePrinting;
                    if (open == null)
                    {
                        objBarcodePrinting.MdiParent = this;
                        objBarcodePrinting.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 143: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBarcodeSettings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bracodeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBarcodeSettings objBracodeSettings = new frmBarcodeSettings();
                frmBarcodeSettings open = Application.OpenForms["frmBarcodeSettings"] as frmBarcodeSettings;
                if (open == null)
                {
                    objBracodeSettings.MdiParent = this;
                    objBracodeSettings.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 144: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmChangeCurrentDate form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeCurrentDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangeCurrentDate objChangeCurrentDate = new frmChangeCurrentDate();
                frmChangeCurrentDate open = Application.OpenForms["frmChangeCurrentDate"] as frmChangeCurrentDate;
                if (open == null)
                {
                    objChangeCurrentDate.MdiParent = this;
                    objChangeCurrentDate.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 145: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmChangeFinancialYear form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeFinancialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmChangeFinancialYear", "View"))
                {
                    frmChangeFinancialYear objChangeFinancialYear = new frmChangeFinancialYear();
                    frmChangeFinancialYear open = Application.OpenForms["frmChangeFinancialYear"] as frmChangeFinancialYear;
                    if (open == null)
                    {
                        objChangeFinancialYear.MdiParent = this;
                        objChangeFinancialYear.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI  146: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmChangePassword form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangePassword objChangePassword = new frmChangePassword();
                frmChangePassword open = Application.OpenForms["frmChangePassword"] as frmChangePassword;
                if (open == null)
                {
                    objChangePassword.MdiParent = this;
                    objChangePassword.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 147: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmNewFinancialYear form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFinancialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewFinancialYear objNewFinancialYear = new frmNewFinancialYear();
                frmNewFinancialYear open = Application.OpenForms["frmNewFinancialYear"] as frmNewFinancialYear;
                if (open == null)
                {
                    objNewFinancialYear.MdiParent = this;
                    objNewFinancialYear.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 148: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSettings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmSettings objSettings = new frmSettings();
                frmSettings open = Application.OpenForms["frmSettings"] as frmSettings;
                if (open == null)
                {
                    objSettings.MdiParent = this;
                    objSettings.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 149: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmUserCreation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userCreationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserCreation objUserCreation = new frmUserCreation();
                frmUserCreation open = Application.OpenForms["frmUserCreation"] as frmUserCreation;
                if (open == null)
                {
                    objUserCreation.MdiParent = this;
                    objUserCreation.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 150: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProductSearch form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductSearch", "View"))
                {
                    frmProductSearch objProductSearch = new frmProductSearch();
                    frmProductSearch open = Application.OpenForms["frmProductSearch"] as frmProductSearch;
                    if (open == null)
                    {
                        objProductSearch.MdiParent = this;
                        objProductSearch.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 151: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmVoucherSearch form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voucherSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmVoucherSearch", "View"))
                {
                    frmVoucherSearch objVoucherSearch = new frmVoucherSearch();
                    frmVoucherSearch open = Application.OpenForms["frmVoucherSearch"] as frmVoucherSearch;
                    if (open == null)
                    {
                        objVoucherSearch.MdiParent = this;
                        objVoucherSearch.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 152: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmVoucherWiseProductSearch form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voucherWiseProductSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmVoucherWiseProductSearch", "View"))
                {
                    frmVoucherWiseProductSearch objVoucherWiseProductSearch = new frmVoucherWiseProductSearch();
                    frmVoucherWiseProductSearch open = Application.OpenForms["frmVoucherWiseProductSearch"] as frmVoucherWiseProductSearch;
                    if (open == null)
                    {
                        objVoucherWiseProductSearch.MdiParent = this;
                        objVoucherWiseProductSearch.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 153: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmOverduePurchaseOrder form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overduePurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmOverduePurchaseOrder", "View"))
                {
                    frmOverduePurchaseOrder objOverduePurchaseOrder = new frmOverduePurchaseOrder();
                    frmOverduePurchaseOrder open = Application.OpenForms["frmOverduePurchaseOrder"] as frmOverduePurchaseOrder;
                    if (open == null)
                    {
                        objOverduePurchaseOrder.MdiParent = this;
                        objOverduePurchaseOrder.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 154: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmOverdueSalesOrder form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void overdueSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmOverdueSalesOrder", "View"))
                {
                    frmOverdueSalesOrder objOverdueSalesOrder = new frmOverdueSalesOrder();
                    frmOverdueSalesOrder open = Application.OpenForms["frmOverdueSalesOrder"] as frmOverdueSalesOrder;
                    if (open == null)
                    {
                        objOverdueSalesOrder.MdiParent = this;
                        objOverdueSalesOrder.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 155: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPersonalReminder form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personalReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPersonalReminder", "View"))
                {
                    frmPersonalReminder objPersonalReminder = new frmPersonalReminder();
                    frmPersonalReminder open = Application.OpenForms["frmPersonalReminder"] as frmPersonalReminder;
                    if (open == null)
                    {
                        objPersonalReminder.MdiParent = this;
                        objPersonalReminder.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 156: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmShortExpiry form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shortExpiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmShortExpiry", "View"))
                {
                    frmShortExpiry objShortExpiry = new frmShortExpiry();
                    frmShortExpiry open = Application.OpenForms["frmShortExpiry"] as frmShortExpiry;
                    if (open == null)
                    {
                        objShortExpiry.MdiParent = this;
                        objShortExpiry.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 157: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStock form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStock", "View"))
                {
                    frmStock objStock = new frmStock();
                    frmStock open = Application.OpenForms["frmStock"] as frmStock;
                    if (open == null)
                    {
                        objStock.MdiParent = this;
                        objStock.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 158: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmChangeCurrentDate form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateToolStripMenuItem.Text != string.Empty)
                {
                    changeCurrentDateToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 159: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCompanyCreation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editCompanyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCompanyCreation frm = new frmCompanyCreation();
                frmCompanyCreation open = Application.OpenForms["frmCompanyCreation"] as frmCompanyCreation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                    frm.CompanyViewForEdit();
                }
                else
                {
                    open.Activate();
                    open.CompanyViewForEdit();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 160: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRolePrivilegeSettings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rolePrivileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRolePrivilegeSettings frm = new frmRolePrivilegeSettings();
                frmRolePrivilegeSettings open = Application.OpenForms["frmRolePrivilegeSettings"] as frmRolePrivilegeSettings;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 161: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBudget form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void budgetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBudget frm = new frmBudget();
                frmBudget open = Application.OpenForms["frmBudget"] as frmBudget;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 162: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBudgetVariance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void budgetVarianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBudgetVariance frm = new frmBudgetVariance();
                frmBudgetVariance open = Application.OpenForms["frmBudgetVariance"] as frmBudgetVariance;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 163: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRole form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRole frm = new frmRole();
                frmRole open = Application.OpenForms["frmRole"] as frmRole;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 164: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmEmployeeAddressBook form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeAddressBookToolStripMenuItem_Click(object sender, EventArgs e)//Coded by Swafiyy
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmEmployeeAddressBook", "View"))
                {
                    frmEmployeeAddressBook frmEmployeeAddressBookObj = new frmEmployeeAddressBook();
                    frmEmployeeAddressBook open = Application.OpenForms["frmEmployeeAddressBook"] as frmEmployeeAddressBook;
                    if (open == null)
                    {
                        frmEmployeeAddressBookObj.MdiParent = this;
                        frmEmployeeAddressBookObj.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 164: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPayHeadReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void payheadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPayHeadReport", "View"))
                {
                    frmPayHeadReport frm = new frmPayHeadReport();
                    frmPayHeadReport open = Application.OpenForms["frmPayHeadReport"] as frmPayHeadReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 165: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDailySalaryReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dailySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDailySalaryReport", "View"))
                {
                    frmDailySalaryReport frm = new frmDailySalaryReport();
                    frmDailySalaryReport open = Application.OpenForms["frmDailySalaryReport"] as frmDailySalaryReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 166: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmChangeProductTax form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeProductTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChangeProductTax frm = new frmChangeProductTax();
                frmChangeProductTax open = Application.OpenForms["frmChangeProductTax"] as frmChangeProductTax;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 167: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSuffixPrefixSettings form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suffixPrefixSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSuffixPrefixSettings frm = new frmSuffixPrefixSettings();
                frmSuffixPrefixSettings open = Application.OpenForms["frmSuffixPrefixSettings"] as frmSuffixPrefixSettings;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 168: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmEmployeeReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmEmployeeReport", "View"))
                {
                    frmEmployeeReport frm = new frmEmployeeReport();
                    frmEmployeeReport open = Application.OpenForms["frmEmployeeReport"] as frmEmployeeReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 169: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDailyAttendanceReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dailyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDailyAttendanceReport", "View"))
                {
                    frmDailyAttendanceReport frm = new frmDailyAttendanceReport();
                    frmDailyAttendanceReport open = Application.OpenForms["frmDailyAttendanceReport"] as frmDailyAttendanceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 170 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmMonthlyAttendanceReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthlyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMonthlyAttendanceReport", "View"))
                {
                    frmMonthlyAttendanceReport frm = new frmMonthlyAttendanceReport();
                    frmMonthlyAttendanceReport open = Application.OpenForms["frmMonthlyAttendanceReport"] as frmMonthlyAttendanceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 171: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmMonthlySalaryReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthlySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMonthlySalaryReport", "View"))
                {
                    frmMonthlySalaryReport frm = new frmMonthlySalaryReport();
                    frmMonthlySalaryReport open = Application.OpenForms["frmMonthlySalaryReport"] as frmMonthlySalaryReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 172: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAdvancePaymentReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void advancePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAdvancePaymentReport", "View"))
                {
                    frmAdvancePaymentReport frm = new frmAdvancePaymentReport();
                    frmAdvancePaymentReport open = Application.OpenForms["frmAdvancePaymentReport"] as frmAdvancePaymentReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 173 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBonusDeductionReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonusDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmBonusDeductionReport", "View"))
                {
                    frmBonusDeductionReport frm = new frmBonusDeductionReport();
                    frmBonusDeductionReport open = Application.OpenForms["frmBonusDeductionReport"] as frmBonusDeductionReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 174 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDayBook form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dayBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDayBook", "View"))
                {
                    frmDayBook frm = new frmDayBook();
                    frmDayBook open = Application.OpenForms["frmDayBook"] as frmDayBook;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 175 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCashBankBookReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCashBankBook", "View"))
                {
                    frmCashBankBookReport frm = new frmCashBankBookReport();
                    frmCashBankBookReport open = Application.OpenForms["frmCashBankBookReport"] as frmCashBankBookReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 176: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAccountLedgerReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountLedgerReport", "View"))
                {
                    frmAccountLedgerReport frm = new frmAccountLedgerReport();
                    frmAccountLedgerReport open = Application.OpenForms["frmAccountLedgerReport"] as frmAccountLedgerReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 177: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmOutstandingReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmOutstandingReport", "View"))
                {
                    frmOutstandingReport frm = new frmOutstandingReport();
                    frmOutstandingReport open = Application.OpenForms["frmOutstandingReport"] as frmOutstandingReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 178 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAgeingReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAgeingReport", "View"))
                {
                    frmAgeingReport frm = new frmAgeingReport();
                    frmAgeingReport open = Application.OpenForms["frmAgeingReport"] as frmAgeingReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 179: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAccountGroupReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountGroupwiseReport", "View"))
                {
                    frmAccountGroupReport frm = new frmAccountGroupReport();
                    frmAccountGroupReport open = Application.OpenForms["frmAccountGroupReport"] as frmAccountGroupReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 180: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalaryPackageReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalaryPackageReport", "View"))
                {
                    frmSalaryPackageReport frm = new frmSalaryPackageReport();
                    frmSalaryPackageReport open = Application.OpenForms["frmSalaryPackageReport"] as frmSalaryPackageReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 181: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Exits application on Exit menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms.Count > 2)
                {
                    string strForm = Application.OpenForms.Count - 2 == 1 ? " form." : " froms.";
                    if (MessageBox.Show("You are about to close " + (Application.OpenForms.Count - 2).ToString() + strForm + " Are you sure to exit? ", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    if (Messages.CloseConfirmation())
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 182: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalaryPackageDetailsReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryPackageDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalaryPackageDetailsReport", "View"))
                {
                    frmSalaryPackageDetailsReport frm = new frmSalaryPackageDetailsReport();
                    frmSalaryPackageDetailsReport open = Application.OpenForms["frmSalaryPackageDetailsReport"] as frmSalaryPackageDetailsReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 183: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseOrderRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseOrderRegistertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseOrderRegister", "View"))
                {
                    frmPurchaseOrderRegister frm = new frmPurchaseOrderRegister();
                    frmPurchaseOrderRegister open = Application.OpenForms["frmPurchaseOrderRegister"] as frmPurchaseOrderRegister;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 184: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPdcClearanceRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PDCClearanceRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPdcClearanceRegister", "View"))
                {
                    frmPdcClearanceRegister frm = new frmPdcClearanceRegister();
                    frmPdcClearanceRegister open = Application.OpenForms["frmPdcClearanceRegister"] as frmPdcClearanceRegister;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 185: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmContraReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contraReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmContraReport", "View"))
                {
                    frmContraReport frm = new frmContraReport();
                    frmContraReport open = Application.OpenForms["frmContraReport"] as frmContraReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 186: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPaymentReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPaymentReport", "View"))
                {
                    frmPaymentReport frm = new frmPaymentReport();
                    frmPaymentReport open = Application.OpenForms["frmPaymentReport"] as frmPaymentReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 187: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCreditNoteReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creditNoteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCreditNoteReport", "View"))
                {
                    frmCreditNoteReport frm = new frmCreditNoteReport();
                    frmCreditNoteReport open = Application.OpenForms["frmCreditNoteReport"] as frmCreditNoteReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 188: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDebitNoteReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void debitNoteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDebitNoteReport", "View"))
                {
                    frmDebitNoteReport frm = new frmDebitNoteReport();
                    frmDebitNoteReport open = Application.OpenForms["frmDebitNoteReport"] as frmDebitNoteReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 189: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmJournalReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void journalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmJournalReport", "View"))
                {
                    frmJournalReport frm = new frmJournalReport();
                    frmJournalReport open = Application.OpenForms["frmJournalReport"] as frmJournalReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 190: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCClearanceReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pDCClearanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCClearanceReport", "View"))
                {
                    frmPDCClearanceReport frm = new frmPDCClearanceReport();
                    frmPDCClearanceReport open = Application.OpenForms["frmPDCClearanceReport"] as frmPDCClearanceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 191: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmServiceReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmServiceReport", "View"))
                {
                    frmServiceReport frm = new frmServiceReport();
                    frmServiceReport open = Application.OpenForms["frmServiceReport"] as frmServiceReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 192: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCPayableReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pDCPayableReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCPayableReport", "View"))
                {
                    frmPDCPayableReport frm = new frmPDCPayableReport();
                    frmPDCPayableReport open = Application.OpenForms["frmPDCPayableReport"] as frmPDCPayableReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 193: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCRecievableReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pDCReceivableReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPDCReceivableReport", "View"))
                {
                    frmPDCRecievableReport frm = new frmPDCRecievableReport();
                    frmPDCRecievableReport open = Application.OpenForms["frmPDCRecievableReport"] as frmPDCRecievableReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 194: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseOrderReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseOrderReport", "View"))
                {
                    frmPurchaseOrderReport frm = new frmPurchaseOrderReport();
                    frmPurchaseOrderReport open = Application.OpenForms["frmPurchaseOrderReport"] as frmPurchaseOrderReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 195: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmReceiptReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void receiptReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmReceiptReport", "View"))
                {
                    frmReceiptReport frmReceptReport = new frmReceiptReport();
                    frmReceiptReport open = Application.OpenForms["frmReceiptReport"] as frmReceiptReport;
                    if (open == null)
                    {
                        frmReceptReport.MdiParent = this;
                        frmReceptReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 196: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPhysicalStockReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void physicalStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPhysicalStockReport", "View"))
                {
                    frmPhysicalStockReport frm = new frmPhysicalStockReport();
                    frmPhysicalStockReport open = Application.OpenForms["frmPhysicalStockReport"] as frmPhysicalStockReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 197: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPartyAddressBook form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartyAddressBooktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPartyAddressBook", "View"))
                {
                    frmPartyAddressBook frm = new frmPartyAddressBook();
                    frmPartyAddressBook open = Application.OpenForms["frmPartyAddressBook"] as frmPartyAddressBook;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 198: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPriceListReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriceListReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPriceListReport", "View"))
                {
                    frmPriceListReport frm = new frmPriceListReport();
                    frmPriceListReport open = Application.OpenForms["frmPriceListReport"] as frmPriceListReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 199: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmTaxReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaxReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmTaxReport", "View"))
                {
                    frmTaxReport frm = new frmTaxReport();
                    frmTaxReport open = Application.OpenForms["frmTaxReport"] as frmTaxReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 200: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmChequeReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChequeReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmChequeReport", "View"))
                {
                    frmChequeReport frm = new frmChequeReport();
                    frmChequeReport open = Application.OpenForms["frmChequeReport"] as frmChequeReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 201: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmShortExpiryReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShortExpiryReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmShortExpiryReport", "View"))
                {
                    frmShortExpiryReport frm = new frmShortExpiryReport();
                    frmShortExpiryReport open = Application.OpenForms["frmShortExpiryReport"] as frmShortExpiryReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 202: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProductStatistics form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStaticstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductStatistics", "View"))
                {
                    frmProductStatistics frm = new frmProductStatistics();
                    frmProductStatistics open = Application.OpenForms["frmProductStatistics"] as frmProductStatistics;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 203: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmVatReturnReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VatReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmVatReturnReport", "View"))
                {
                    frmVatReturnReport frm = new frmVatReturnReport();
                    frmVatReturnReport open = Application.OpenForms["frmVatReturnReport"] as frmVatReturnReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 204: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStockReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StockReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStockReport", "View"))
                {
                    frmStockReport frm = new frmStockReport();
                    frmStockReport open = Application.OpenForms["frmStockReport"] as frmStockReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 205: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmFreeSaleReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void freeSaleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmFreeSaleReport", "View"))
                {
                    frmFreeSaleReport frm = new frmFreeSaleReport();
                    frmFreeSaleReport open = Application.OpenForms["frmFreeSaleReport"] as frmFreeSaleReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 206: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProductVsBatchReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productVsBatchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductVsBatchReport", "View"))
                {
                    frmProductVsBatchReport frm = new frmProductVsBatchReport();
                    frmProductVsBatchReport open = Application.OpenForms["frmProductVsBatchReport"] as frmProductVsBatchReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 207: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Logouts the Company
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Are you sure to logout ? ", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    LogOut();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 208" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDeliveryNote form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                DeliveryNoteClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 209: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPDCClearance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdcClearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PDCClearenceClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 210: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseInvoiceRegister form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseInvoiceRegisterToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseInvoiceRegister", "View"))
                {
                    frmPurchaseInvoiceRegister objPurchaseInvoiceRegister = new frmPurchaseInvoiceRegister();
                    frmPurchaseInvoiceRegister open = Application.OpenForms["frmPurchaseInvoiceRegister"] as frmPurchaseInvoiceRegister;
                    if (open == null)
                    {
                        objPurchaseInvoiceRegister.MdiParent = this;
                        objPurchaseInvoiceRegister.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 211: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmMaterialReceiptReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialReceiptReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmMaterialReceiptReport", "View"))
                {
                    frmMaterialReceiptReport objMaterialReceiptReport = new frmMaterialReceiptReport();
                    frmMaterialReceiptReport open = Application.OpenForms["frmMaterialReceiptReport"] as frmMaterialReceiptReport;
                    if (open == null)
                    {
                        objMaterialReceiptReport.MdiParent = this;
                        objMaterialReceiptReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 212: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBillallocation form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void billAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBillallocation objBillallocation = new frmBillallocation();
                frmBillallocation open = Application.OpenForms["frmBillallocation"] as frmBillallocation;
                if (open == null)
                {
                    objBillallocation.MdiParent = this;
                    objBillallocation.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 213 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Disables the menus and Logouts company
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Form> openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                    openForms.Add(f);
                foreach (Form f in openForms)
                {
                    if (f.Name != "formMDI")
                        f.Close();
                }
                MDIObj = this;
                PublicVariables._decCurrentCompanyId = 0;
                MenuStripDisabling();
                companyToolStripMenuItem.Enabled = true;
                editCompanyToolStripMenuItem1.Enabled = false;
                BackUpToolStripMenuItem.Enabled = false;
                RestoreToolStripMenuItem.Enabled = false;
                dateToolStripMenuItem.Enabled = false;
                exitToolStripMenuItem.Enabled = true;
                createCompanyToolStripMenuItem.Enabled = true;
                SelectCompanyToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;
                formMDI.MDIObj.Text = "OpenMiracle";
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                decimal decCompanyCount = bllCompanyCreation.CompanyCount();
                if (decCompanyCount == 1)
                {
                    PublicVariables._decCurrentCompanyId = bllCompanyCreation.CompanyGetIdIfSingleCompany();
                    CurrentDate();
                    frmLogin frmLoginObj = new frmLogin();
                    frmLoginObj.MdiParent = MDIObj;
                    frmLoginObj.CallFromFormMdi(this);
                }
                else if (decCompanyCount < 1)
                {
                    CurrentDateBefore();
                    frmCompanyCreation frmCompanyCreationObj = new frmCompanyCreation();
                    frmCompanyCreationObj.MdiParent = formMDI.MDIObj;
                    frmCompanyCreationObj.CallFromFormMdi();
                }
                else
                {
                    PublicVariables._decCurrentCompanyId = 0;
                    //CompanyPathSP spCompanyPath = new CompanyPathSP();
                    CompanyPathBll bllCompanyPath = new CompanyPathBll();
                    decimal decDefaultCompanyId = bllCompanyPath.CompanyViewForDefaultCompany();
                    if (decDefaultCompanyId > 0)
                    {
                        PublicVariables._decCurrentCompanyId = decDefaultCompanyId;
                        CurrentDate();
                        frmLogin frmLoginObj = new frmLogin();
                        frmLoginObj.MdiParent = formMDI.MDIObj;
                        frmLoginObj.CallFromFormMdi(this);
                    }
                    else
                    {
                        CurrentDate();
                        frmSelectCompany frmSelectCompanyObj = new frmSelectCompany();
                        frmSelectCompanyObj.MdiParent = formMDI.MDIObj;
                        frmSelectCompanyObj.CallFromMdi();
                    }
                }
                CurrentSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 214: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Closes selected company by checking the privilege
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCompany", "Close"))
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
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 215:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmTrialBalance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmTrialBalance", "View"))
                {
                    frmTrialBalance objTrialBalance = new frmTrialBalance();
                    frmTrialBalance open = Application.OpenForms["frmTrialBalance"] as frmTrialBalance;
                    if (open == null)
                    {
                        objTrialBalance.MdiParent = this;
                        objTrialBalance.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 216 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmBalanceSheet form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmBalanceSheet", "View"))
                {
                    frmBalanceSheet objBalanceSheet = new frmBalanceSheet();
                    frmBalanceSheet open = Application.OpenForms["frmBalanceSheet"] as frmBalanceSheet;
                    if (open == null)
                    {
                        objBalanceSheet.MdiParent = this;
                        objBalanceSheet.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 217: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmProfitAndLoss form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profitAndLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProfitAndLoss", "View"))
                {
                    frmProfitAndLoss objProfitAndLoss = new frmProfitAndLoss();
                    frmProfitAndLoss open = Application.OpenForms["frmProfitAndLoss"] as frmProfitAndLoss;
                    if (open == null)
                    {
                        objProfitAndLoss.MdiParent = this;
                        objProfitAndLoss.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 218: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmCashFlow form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCashFlow", "View"))
                {
                    frmCashFlow objCashFlow = new frmCashFlow();
                    frmCashFlow open = Application.OpenForms["frmCashFlow"] as frmCashFlow;
                    if (open == null)
                    {
                        objCashFlow.MdiParent = this;
                        objCashFlow.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 219: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmFundFlow form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fundFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmFundFlow", "View"))
                {
                    frmFundFlow objFundFlow = new frmFundFlow();
                    frmFundFlow open = Application.OpenForms["frmFundFlow"] as frmFundFlow;
                    if (open == null)
                    {
                        objFundFlow.MdiParent = this;
                        objFundFlow.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 220: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmChartOfAccount form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartOfAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmChartOfAccount", "View"))
                {
                    frmChartOfAccount objChartOfAccount = new frmChartOfAccount();
                    frmChartOfAccount open = Application.OpenForms["frmChartOfAccount"] as frmChartOfAccount;
                    if (open == null)
                    {
                        objChartOfAccount.MdiParent = this;
                        objChartOfAccount.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 221 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmStockJournelReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockJournalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmStockJournalReport", "View"))
                {
                    frmStockJournelReport objStockJournel = new frmStockJournelReport();
                    frmStockJournelReport open = Application.OpenForms["frmStockJournelReport"] as frmStockJournelReport;
                    if (open == null)
                    {
                        objStockJournel.MdiParent = this;
                        objStockJournel.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 222: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesReturnReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesReturnReport", "View"))
                {
                    frmSalesReturnReport objSalesReturnReport = new frmSalesReturnReport();
                    frmSalesReturnReport open = Application.OpenForms["frmSalesReturnReport"] as frmSalesReturnReport;
                    if (open == null)
                    {
                        objSalesReturnReport.MdiParent = this;
                        objSalesReturnReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 223: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesInvoiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesInvoiceReport", "View"))
                {
                    frmSalesReport objSalesReport = new frmSalesReport();
                    frmSalesReport open = Application.OpenForms["frmSalesReport"] as frmSalesReport;
                    if (open == null)
                    {
                        objSalesReport.MdiParent = this;
                        objSalesReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 224: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRejectionOutReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rejectionOutReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionOutReport", "View"))
                {
                    frmRejectionOutReport objRejectionOutReport = new frmRejectionOutReport();
                    frmRejectionOutReport open = Application.OpenForms["frmRejectionOutReport"] as frmRejectionOutReport;
                    if (open == null)
                    {
                        objRejectionOutReport.MdiParent = this;
                        objRejectionOutReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 225: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseInvoiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseInvoiceReport", "View"))
                {
                    frmPurchaseReport objPurchaseReport = new frmPurchaseReport();
                    frmPurchaseReport open = Application.OpenForms["frmPurchaseReport"] as frmPurchaseReport;
                    if (open == null)
                    {
                        objPurchaseReport.MdiParent = this;
                        objPurchaseReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 226: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPurchaseReturnReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmPurchaseReturnReport", "View"))
                {
                    frmPurchaseReturnReport objPurchaseReturnReport = new frmPurchaseReturnReport();
                    frmPurchaseReturnReport open = Application.OpenForms["frmPurchaseReturnReport"] as frmPurchaseReturnReport;
                    if (open == null)
                    {
                        objPurchaseReturnReport.MdiParent = this;
                        objPurchaseReturnReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 227 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesQuotationReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesQuotationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesQuotationReport", "View"))
                {
                    frmSalesQuotationReport objSalesQuotationReport = new frmSalesQuotationReport();
                    frmSalesQuotationReport open = Application.OpenForms["frmSalesQuotationReport"] as frmSalesQuotationReport;
                    if (open == null)
                    {
                        objSalesQuotationReport.MdiParent = this;
                        objSalesQuotationReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 228: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSalesOrderReport from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesOrderReport", "View"))
                {
                    frmSalesOrderReport objSalesOrderReport = new frmSalesOrderReport();
                    frmSalesOrderReport open = Application.OpenForms["frmSalesOrderReport"] as frmSalesOrderReport;
                    if (open == null)
                    {
                        objSalesOrderReport.MdiParent = this;
                        objSalesOrderReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 229: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmDeliveryNoteReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deliveryNoteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmDeliveryNoteReport", "View"))
                {
                    frmDeliveryNoteReport objDeliveryNoteReport = new frmDeliveryNoteReport();
                    frmDeliveryNoteReport open = Application.OpenForms["frmDeliveryNoteReport"] as frmDeliveryNoteReport;
                    if (open == null)
                    {
                        objDeliveryNoteReport.MdiParent = this;
                        objDeliveryNoteReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 230: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmRejectionInReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rejectionInReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmRejectionInReport", "View"))
                {
                    frmRejectionInReport objRejectionInReport = new frmRejectionInReport();
                    frmRejectionInReport open = Application.OpenForms["frmRejectionInReport"] as frmRejectionInReport;
                    if (open == null)
                    {
                        objRejectionInReport.MdiParent = this;
                        objRejectionInReport.Show();
                    }
                    else
                    {
                        open.Activate();
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 231: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPos form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                POSClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 232: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmPrintDesigner form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dotmatrixPrintDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrintDesigner frmPrintDesignerObj = new frmPrintDesigner();
                frmPrintDesigner Open = Application.OpenForms["frmPrintDesigner"] as frmPrintDesigner;
                if (Open == null)
                {
                    frmPrintDesignerObj.Show();
                }
                else
                {
                    Open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 233: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAccountGroupwiseReport form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountGroupWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountGroupwiseReport", "View"))
                {
                    frmAccountGroupwiseReport frm = new frmAccountGroupwiseReport();
                    frmAccountGroupwiseReport open = Application.OpenForms["frmAccountGroupwiseReport"] as frmAccountGroupwiseReport;
                    if (open == null)
                    {
                        frm.MdiParent = this;
                        frm.Show();
                    }
                    else
                    {
                        open.Activate();
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 234 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmSelectCompany  form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectCompany frm = new frmSelectCompany();
                frmSelectCompany open = Application.OpenForms["frmSelectCompany"] as frmSelectCompany;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    frm = open;
                    frm.Activate();
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 235 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Backup' menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCompany", "BackUp"))
                {
                    BackUpRestoreBll backUpRestoreObj = new BackUpRestoreBll();
                    backUpRestoreObj.TakeBackUp();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 236: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Restores data on restore menu click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCompany", "Restore"))
                {
                    BackUpRestoreBll backUpRestoreObj = new BackUpRestoreBll();
                    backUpRestoreObj.ReStoreDB();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 237: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmQueryLogin form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formMDI_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Alt && e.Shift && e.KeyCode == Keys.Q)// posible only in system where DB located)
                {
                    frmQueryLogin frm = new frmQueryLogin();
                    frmQueryLogin _isOpen = Application.OpenForms["frmQueryLogin"] as frmQueryLogin;
                    if (_isOpen == null)
                    {
                        frm.WindowState = FormWindowState.Normal;
                        frm.MdiParent = MDIObj;
                        frm.Show();
                    }
                    else
                    {
                        _isOpen.MdiParent = MDIObj;
                        if (_isOpen.WindowState == FormWindowState.Minimized)
                        {
                            _isOpen.WindowState = FormWindowState.Normal;
                        }
                        if (_isOpen.Enabled)
                        {
                            _isOpen.Activate();
                            _isOpen.BringToFront();
                        }
                    }
                    SendKeys.Send("{F10}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 238: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Resizes the forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formMDI_Resize(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(frmMessage))
                    {
                        form.Location = new Point(0, formMDI.MDIObj.Height - 270);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 239: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On Notify versionUpdate click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ntfyVersionUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.openmiracle.com/update.aspx");
                ntfyVersionUpdate.Visible = false;
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// Calls OpenMiracleHelp.chm file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("hh.exe", Application.StartupPath + "\\OpenMiracleHelp.chm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 240: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls frmAboutUs form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAboutUs frmAboutUs = new frmAboutUs();
                frmAboutUs _isOpen = Application.OpenForms["frmAboutUs"] as frmAboutUs;
                if (_isOpen == null)
                {
                    frmAboutUs.WindowState = FormWindowState.Normal;
                    frmAboutUs.MdiParent = MDIObj;
                    frmAboutUs.Show();
                }
                else
                {
                    _isOpen.MdiParent = MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    if (_isOpen.Enabled)
                    {
                        _isOpen.Activate();
                        _isOpen.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 241 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void rebuildIndexingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                BackgrndWrkrLoading.RunWorkerAsync();
                frmLoadingObj.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 242 : " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BackgrndWrkrLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                frmLoadingObj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 234:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BackgrndWrkrLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //ExecuteIndex spExicuteIndex = new ExecuteIndex();
                //spExicuteIndex.ExicuteIdex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 235:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSendMail objfrmSendMail = new frmSendMail();
                frmSendMail open = Application.OpenForms["frmSendMail"] as frmSendMail;
                if (open == null)
                {
                    objfrmSendMail.MdiParent = this;
                    objfrmSendMail.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MDI 151: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
