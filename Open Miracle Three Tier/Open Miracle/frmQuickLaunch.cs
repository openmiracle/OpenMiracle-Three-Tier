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
    public partial class frmQuickLaunch : Form
    {
        #region Public Varibles
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        QuickLaunchItemsBll BllQuickLaunchItems = new QuickLaunchItemsBll();
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmQuickLaunch class
        /// </summary>
        public frmQuickLaunch()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to assign the VoucherName for buttons in QuickLaunch while returning from frmMenuCustomization form
        /// </summary>
        public void ReturnFromCustomization()
        {
            try
            {
                base.Show();
                AssignButtonText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("QL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to assign VoucherName to corresponding Buttons
        /// </summary>
        public void AssignButtonText()
        {
            try
            {
                List<DataTable> listObjSelectedItems = BllQuickLaunchItems.QuickLaunchNonSelectedViewAll(true);
                for (int i = 0; i < 19; i++)
                {
                    string strText = i >= listObjSelectedItems[0].Rows.Count ? string.Empty : listObjSelectedItems[0].Rows[i]["itemsName"].ToString();
                    switch (i)
                    {
                        case 0:
                            btn1.Text = strText;
                            break;
                        case 1:
                            btn2.Text = strText;
                            break;
                        case 2:
                            btn3.Text = strText;
                            break;
                        case 3:
                            btn4.Text = strText;
                            break;
                        case 4:
                            btn5.Text = strText;
                            break;
                        case 5:
                            btn6.Text = strText;
                            break;
                        case 6:
                            btn7.Text = strText;
                            break;
                        case 7:
                            btn8.Text = strText;
                            break;
                        case 8:
                            btn9.Text = strText;
                            break;
                        case 9:
                            btn10.Text = strText;
                            break;
                        case 10:
                            btn11.Text = strText;
                            break;
                        case 11:
                            btn12.Text = strText;
                            break;
                        case 12:
                            btn13.Text = strText;
                            break;
                        case 13:
                            btn14.Text = strText;
                            break;
                        case 14:
                            btn15.Text = strText;
                            break;
                        case 15:
                            btn16.Text = strText;
                            break;
                        case 16:
                            btn17.Text = strText;
                            break;
                        case 17:
                            btn18.Text = strText;
                            break;
                        case 18:
                            btn19.Text = strText;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Calls frmMenuCustomization form to customize as per user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomizeMenu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                frmMenuCustomization objMenuCustomization = new frmMenuCustomization();
                frmMenuCustomization open = Application.OpenForms["frmMenuCustomization"] as frmMenuCustomization;
                if (open == null)
                {
                    objMenuCustomization.MdiParent = this.MdiParent;
                    objMenuCustomization.Shows(this);
                }
                else
                {
                    open.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls the corresponding voucher on click in Quick Launch menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            Form frmObj = null;
            Form open = null;
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                string str = ((Button)sender).Text;
                btnFocus.Focus();
                switch (str)
                {
                    case "Contra Voucher":
                        formMDI.MDIObj.ContraVoucherClick();
                        break;
                    case "Payment Voucher":
                        formMDI.MDIObj.PaymentVoucherClick();
                        break;
                    case "Receipt Voucher":
                        formMDI.MDIObj.ReceiptVoucherClick();
                        break;
                    case "Journal Voucher":
                        formMDI.MDIObj.JournalVoucherClick();
                        break;
                    case "Sales Invoice":
                        formMDI.MDIObj.SalesInvoiceClick();
                        break;
                    case "Purchase Invoice":
                        formMDI.MDIObj.PurchaseInvoiceClick();
                        break;
                    case "POS":
                        formMDI.MDIObj.POSClick();
                        break;
                    case "PDC Payable":
                        formMDI.MDIObj.PDCPayableClick();
                        break;
                    case "PDC Receivable":
                        formMDI.MDIObj.PDCReceivableClick();
                        break;
                    case "PDC Clearance":
                        formMDI.MDIObj.PDCClearenceClick();
                        break;
                    case "Bank Reconciliation":
                        frmObj = new frmBankReconciliation();
                        open = Application.OpenForms["frmBankReconciliation"] as frmBankReconciliation;
                        break;
                    case "Purchase Order":
                        formMDI.MDIObj.PurchaseOrderClick();
                        break;
                    case "Material Reciept":
                        formMDI.MDIObj.MaterialReceiptClick();
                        break;
                    case "Rejection Out":
                        formMDI.MDIObj.RejectionOutClick();
                        break;
                    case "Purchase Return":
                        formMDI.MDIObj.PurchaseReturnClick();
                        break;
                    case "Sales Quotation":
                        formMDI.MDIObj.SalesQuotationClick();
                        break;
                    case "Sales Order":
                        formMDI.MDIObj.SalesOrderClick();
                        break;
                    case "Delivery Note":
                        formMDI.MDIObj.DeliveryNoteClick();
                        break;
                    case "Rejection In":
                        formMDI.MDIObj.RejectionInClick();
                        break;
                    case "Sales Return":
                        formMDI.MDIObj.SalesReturnClick();
                        break;
                    case "Physical Stock":
                        formMDI.MDIObj.PhysicalStockClick();
                        break;
                    case "Service Voucher":
                        formMDI.MDIObj.ServiceVoucherClick();
                        break;
                    case "Credit Note":
                        formMDI.MDIObj.CreditNoteClick();
                        break;
                    case "Debit Note":
                        formMDI.MDIObj.DebitNoteClick();
                        break;
                    case "Stock Journal":
                        //frmObj = new frmStockJournal();
                        //open = Application.OpenForms["frmStockJournal"] as frmStockJournal;
                        formMDI.MDIObj.StockJournalClick();
                        break;
                    case "Bill Allocation":
                        frmObj = new frmBillallocation();
                        open = Application.OpenForms["frmBillallocation"] as frmBillallocation;
                        break;
                    case "Account Group":
                        frmObj = new frmAccountGroup();
                        open = Application.OpenForms["frmAccountGroup"] as frmAccountGroup;
                        break;
                    case "Account Ledger":
                        frmObj = new frmAccountLedger();
                        open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                        break;
                    case "Multiple Account Ledgers":
                        frmObj = new frmmultipleAccountLedger();
                        open = Application.OpenForms["frmmultipleAccountLedger"] as frmmultipleAccountLedger;
                        break;
                    case "Product Group":
                        frmObj = new frmProductGroup();
                        open = Application.OpenForms["frmProductGroup"] as frmProductGroup;
                        break;
                    case "Product Creation":
                        frmObj = new frmProductCreation();
                        open = Application.OpenForms["frmProductCreation"] as frmProductCreation;
                        break;
                    case "Multiple Product Creation":
                        frmObj = new frmMultipleProductCreation();
                        open = Application.OpenForms["frmMultipleProductCreation"] as frmMultipleProductCreation;
                        break;
                    case "Batch":
                        if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                        {
                            frmObj = new frmBatch();
                            open = Application.OpenForms["frmBatch"] as frmBatch;
                        }
                        break;
                    case "Brand":
                        frmObj = new frmBrand();
                        open = Application.OpenForms["frmBrand"] as frmBrand;
                        break;
                    case "Model Number":
                        if (BllSettings.SettingsStatusCheck("AllowModelNo") == "Yes")
                        {
                            frmObj = new frmModalNo();
                            open = Application.OpenForms["frmModalNo"] as frmModalNo;
                        }
                        break;
                    case "Size":
                        if (BllSettings.SettingsStatusCheck("AllowSize") == "Yes")
                        {
                            frmObj = new frmSize();
                            open = Application.OpenForms["frmSize"] as frmSize;
                        }
                        break;
                    case "Unit":
                        frmObj = new frmUnit();
                        open = Application.OpenForms["frmUnit"] as frmUnit;
                        break;
                    case "Godown":
                        if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                        {
                            frmObj = new frmGodown();
                            open = Application.OpenForms["frmGodown"] as frmGodown;
                        }
                        break;
                    case "Rack":
                        if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                        {
                            frmObj = new frmRack();
                            open = Application.OpenForms["frmRack"] as frmRack;
                        }
                        break;
                    case "Pricing Level":
                        frmObj = new frmPricingLevel();
                        open = Application.OpenForms["frmPricingLevel"] as frmPricingLevel;
                        break;
                    case "Price List":
                        frmObj = new frmPriceList();
                        open = Application.OpenForms["frmPriceList"] as frmPriceList;
                        break;
                    case "Standard Rate":
                        frmObj = new frmStandardRate();
                        open = Application.OpenForms["frmStandardRate"] as frmStandardRate;
                        break;
                    case "Tax":
                        if (BllSettings.SettingsStatusCheck("Tax") == "Yes")
                        {
                            frmObj = new frmTax();
                            open = Application.OpenForms["frmTax"] as frmTax;
                        }
                        break;
                    case "Currency":
                        if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                        {
                            frmObj = new frmCurrency();
                            open = Application.OpenForms["frmCurrency"] as frmCurrency;
                        }
                        break;
                    case "Exchange Rate":
                        frmObj = new frmExchangeRate();
                        open = Application.OpenForms["frmExchangeRate"] as frmExchangeRate;
                        break;
                    case "Service Category":
                        frmObj = new frmServiceCategory();
                        open = Application.OpenForms["frmServiceCategory"] as frmServiceCategory;
                        break;
                    case "Services":
                        frmObj = new frmServices();
                        open = Application.OpenForms["frmServices"] as frmServices;
                        break;
                    case "Voucher Type":
                        frmObj = new frmVoucherType();
                        open = Application.OpenForms["frmVoucherType"] as frmVoucherType;
                        break;
                    case "Area":
                        frmObj = new frmArea();
                        open = Application.OpenForms["frmArea"] as frmArea;
                        break;
                    case "Route":
                        frmObj = new frmRoute();
                        open = Application.OpenForms["frmRoute"] as frmRoute;
                        break;
                    case "Counter":
                        frmObj = new frmCounter();
                        open = Application.OpenForms["frmCounter"] as frmCounter;
                        break;
                    case "Product Register":
                        frmObj = new frmProductRegister();
                        open = Application.OpenForms["frmProductRegister"] as frmProductRegister;
                        break;
                    case "Salesman":
                        frmObj = new frmSalesman();
                        open = Application.OpenForms["frmSalesman"] as frmSalesman;
                        break;
                    case "Contra Register":
                        frmObj = new frmContraRegister();
                        open = Application.OpenForms["frmContraRegister"] as frmContraRegister;
                        break;
                    case "Payment Register":
                        frmObj = new frmPaymentRegister();
                        open = Application.OpenForms["frmPaymentRegister"] as frmPaymentRegister;
                        break;
                    case "Receipt Register":
                        frmObj = new frmReceiptRegister();
                        open = Application.OpenForms["frmReceiptRegister"] as frmReceiptRegister;
                        break;
                    case "Journal Register":
                        frmObj = new frmJournalRegister();
                        open = Application.OpenForms["frmJournalRegister"] as frmJournalRegister;
                        break;
                    case "PDC Payable Register":
                        frmObj = new frmPDCPayableRegister();
                        open = Application.OpenForms["frmPDCPayableRegister"] as frmPDCPayableRegister;
                        break;
                    case "PDC Receivable Register":
                        frmObj = new frmPDCReceivableRegister();
                        open = Application.OpenForms["frmPDCReceivableRegister"] as frmPDCReceivableRegister;
                        break;
                    case "PDC Clearance Register":
                        frmObj = new frmPdcClearanceRegister();
                        open = Application.OpenForms["frmPdcClearanceRegister"] as frmPdcClearanceRegister;
                        break;
                    case "Purchase Order Register":
                        frmObj = new frmPurchaseOrderRegister();
                        open = Application.OpenForms["frmPurchaseOrderRegister"] as frmPurchaseOrderRegister;
                        break;
                    case "Material Receipt Register":
                        frmObj = new frmMaterialReceiptRegister();
                        open = Application.OpenForms["frmMaterialReceiptRegister"] as frmMaterialReceiptRegister;
                        break;
                    case "Rejection Out Register":
                        frmObj = new frmRejectionOutRegister();
                        open = Application.OpenForms["frmRejectionOutRegister"] as frmRejectionOutRegister;
                        break;
                    case "Purchase Invoice Register":
                        frmObj = new frmPurchaseInvoiceRegister();
                        open = Application.OpenForms["frmPurchaseInvoiceRegister"] as frmPurchaseInvoiceRegister;
                        break;
                    case "Purchase Return Register":
                        frmObj = new frmPurchaseReturnRegister();
                        open = Application.OpenForms["frmPurchaseReturnRegister"] as frmPurchaseReturnRegister;
                        break;
                    case "Sales Quotation Register":
                        frmObj = new frmSalesQuotationRegister();
                        open = Application.OpenForms["frmSalesQuotationRegister"] as frmSalesQuotationRegister;
                        break;
                    case "Sales Order Register":
                        frmObj = new frmSalesOrderRegister();
                        open = Application.OpenForms["frmSalesOrderRegister"] as frmSalesOrderRegister;
                        break;
                    case "Delivery Note Register":
                        frmObj = new frmDeliveryNoteRegister();
                        open = Application.OpenForms["frmDeliveryNoteRegister"] as frmDeliveryNoteRegister;
                        break;
                    case "Rejection In Register":
                        frmObj = new frmRejectionInRegister();
                        open = Application.OpenForms["frmRejectionInRegister"] as frmRejectionInRegister;
                        break;
                    case "Sales Invoice Register":
                        frmObj = new frmSalesInvoiceRegister();
                        open = Application.OpenForms["frmSalesInvoiceRegister"] as frmSalesInvoiceRegister;
                        break;
                    case "Sales Return Register":
                        frmObj = new frmSalesReturnRegister();
                        open = Application.OpenForms["frmSalesReturnRegister"] as frmSalesReturnRegister;
                        break;
                    case "Physical Stock Register":
                        frmObj = new frmPhysicalStockRegister();
                        open = Application.OpenForms["frmPhysicalStockRegister"] as frmPhysicalStockRegister;
                        break;
                    case "Service Voucher Register":
                        frmObj = new frmServiceVoucherRegister();
                        open = Application.OpenForms["frmServiceVoucherRegister"] as frmServiceVoucherRegister;
                        break;
                    case "Credit Note Register":
                        frmObj = new frmCreditNoteRegister();
                        open = Application.OpenForms["frmCreditNoteRegister"] as frmCreditNoteRegister;
                        break;
                    case "Debit Note Register":
                        frmObj = new frmDebitNoteRegister();
                        open = Application.OpenForms["frmDebitNoteRegister"] as frmDebitNoteRegister;
                        break;
                    case "Stock Journal Register":
                        frmObj = new frmStockJournalRegister();
                        open = Application.OpenForms["frmStockJournalRegister"] as frmStockJournalRegister;
                        break;
                    case "Designation":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmDesignation();
                            open = Application.OpenForms["frmDesignation"] as frmDesignation;
                        }
                        break;
                    case "Pay Head":
                        {
                            frmObj = new frmPayHead();
                            open = Application.OpenForms["frmPayHead"] as frmPayHead;
                        }
                        break;
                    case "Salary Package Creation":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmSalaryPackageCreation();
                            open = Application.OpenForms["frmSalaryPackageCreation"] as frmSalaryPackageCreation;
                        }
                        break;
                    case "Salary Package Register":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmSalaryPackageRegister();
                            open = Application.OpenForms["frmSalaryPackageRegister"] as frmSalaryPackageRegister;
                        }
                        break;
                    case "Employee Creation":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmEmployeeCreation();
                            open = Application.OpenForms["frmEmployeeCreation"] as frmEmployeeCreation;
                        }
                        break;
                    case "Employee Register":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmEmployeeRegister();
                            open = Application.OpenForms["frmEmployeeRegister"] as frmEmployeeRegister;
                        }
                        break;
                    case "Holiday Settings":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmHolydaySettings();
                            open = Application.OpenForms["frmHolydaySettings"] as frmHolydaySettings;
                        }
                        break;
                    case "Monthly Salary Settings":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmMonthlySalarySettings();
                            open = Application.OpenForms["frmMonthlySalarySettings"] as frmMonthlySalarySettings;
                        }
                        break;
                    case "Attendance":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmAttendance();
                            open = Application.OpenForms["frmAttendance"] as frmAttendance;
                        }
                        break;
                    case "Advance Payment":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmAdvancePayment();
                            open = Application.OpenForms["frmAdvancePayment"] as frmAdvancePayment;
                        }
                        break;
                    case "Advance Register":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmAdvanceRegister();
                            open = Application.OpenForms["frmAdvanceRegister"] as frmAdvanceRegister;
                        }
                        break;
                    case "Bonus Deduction":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmBonusDeduction();
                            open = Application.OpenForms["frmBonusDeduction"] as frmBonusDeduction;
                        }
                        break;
                    case "Bonus Deduction Register":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmBonusDeductionRegister();
                            open = Application.OpenForms["frmBonusDeductionRegister"] as frmBonusDeductionRegister;
                        }
                        break;
                    case "Monthly Salary Voucher":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmMonthlySalaryVoucher();
                            open = Application.OpenForms["frmMonthlySalaryVoucher"] as frmMonthlySalaryVoucher;
                        }
                        break;
                    case "Monthly Salary Register":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmMonthlySalaryRegister();
                            open = Application.OpenForms["frmMonthlySalaryRegister"] as frmMonthlySalaryRegister;
                        }
                        break;
                    case "Daily Salary Voucher":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmDailySalaryVoucher();
                            open = Application.OpenForms["frmDailySalaryVoucher"] as frmDailySalaryVoucher;
                        }
                        break;
                    case "Daily Salary Register":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmDailySalaryRegister();
                            open = Application.OpenForms["frmDailySalaryRegister"] as frmDailySalaryRegister;
                        }
                        break;
                    case "Pay Slip":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmPaySlip();
                            open = Application.OpenForms["frmPaySlip"] as frmPaySlip;
                        }
                        break;
                    case "Budget":
                        if (BllSettings.SettingsStatusCheck("Budget") == "Yes")
                        {
                            frmObj = new frmBudget();
                            open = Application.OpenForms["frmBudget"] as frmBudget;
                        }
                        break;
                    case "Budget Variance":
                        if (BllSettings.SettingsStatusCheck("Budget") == "Yes")
                        {
                            frmObj = new frmBudgetVariance();
                            open = Application.OpenForms["frmBudgetVariance"] as frmBudgetVariance;
                        }
                        break;
                    case "Change Current Date":
                        frmObj = new frmChangeCurrentDate();
                        open = Application.OpenForms["frmChangeCurrentDate"] as frmChangeCurrentDate;
                        break;
                    case "Settings":
                        frmObj = new frmSettings();
                        open = Application.OpenForms["frmSettings"] as frmSettings;
                        break;
                    case "Role":
                        frmObj = new frmRole();
                        open = Application.OpenForms["frmRole"] as frmRole;
                        break;
                    case "Role Privilege Settings":
                        frmObj = new frmRolePrivilegeSettings();
                        open = Application.OpenForms["frmRolePrivilegeSettings"] as frmRolePrivilegeSettings;
                        break;
                    case "User Creation":
                        frmObj = new frmUserCreation();
                        open = Application.OpenForms["frmUserCreation"] as frmUserCreation;
                        break;
                    case "Change Password":
                        frmObj = new frmChangePassword();
                        open = Application.OpenForms["frmChangePassword"] as frmChangePassword;
                        break;
                    case "New Financial Year":
                        frmObj = new frmNewFinancialYear();
                        open = Application.OpenForms["frmNewFinancialYear"] as frmNewFinancialYear;
                        break;
                    case "Change Financial Year":
                        frmObj = new frmChangeFinancialYear();
                        open = Application.OpenForms["frmChangeFinancialYear"] as frmChangeFinancialYear;
                        break;
                    case "Barcode Settings":
                        frmObj = new frmBarcodeSettings();
                        open = Application.OpenForms["frmBarcodeSettings"] as frmBarcodeSettings;
                        break;
                    case "Barcode Printing":
                        frmObj = new frmBarcodePrinting();
                        open = Application.OpenForms["frmBarcodePrinting"] as frmBarcodePrinting;
                        break;
                    case "Suffix Prefix Settings":
                        frmObj = new frmSuffixPrefixSettings();
                        open = Application.OpenForms["frmSuffixPrefixSettings"] as frmSuffixPrefixSettings;
                        break;
                    case "Change Product Tax":
                        frmObj = new frmChangeProductTax();
                        open = Application.OpenForms["frmChangeProductTax"] as frmChangeProductTax;
                        break;
                    case "Product Search":
                        frmObj = new frmProductSearch();
                        open = Application.OpenForms["frmProductSearch"] as frmProductSearch;
                        break;
                    case "Voucher Search":
                        frmObj = new frmVoucherSearch();
                        open = Application.OpenForms["frmVoucherSearch"] as frmVoucherSearch;
                        break;
                    case "Voucher Wise Product Search":
                        frmObj = new frmVoucherWiseProductSearch();
                        open = Application.OpenForms["frmVoucherWiseProductSearch"] as frmVoucherWiseProductSearch;
                        break;
                    case "Personal Reminder":
                        frmObj = new frmPersonalReminder();
                        open = Application.OpenForms["frmPersonalReminder"] as frmPersonalReminder;
                        break;
                    case "Overdue Purchase Order":
                        frmObj = new frmOverduePurchaseOrder();
                        open = Application.OpenForms["frmOverduePurchaseOrder"] as frmOverduePurchaseOrder;
                        break;
                    case "Overdue Sales Order":
                        frmObj = new frmOverdueSalesOrder();
                        open = Application.OpenForms["frmOverdueSalesOrder"] as frmOverdueSalesOrder;
                        break;
                    case "Short Expiry":
                        frmObj = new frmShortExpiry();
                        open = Application.OpenForms["frmShortExpiry"] as frmShortExpiry;
                        break;
                    case "Stock":
                        frmObj = new frmStock();
                        open = Application.OpenForms["frmStock"] as frmStock;
                        break;
                    case "Trial Balance":
                        frmObj = new frmTrialBalance();
                        open = Application.OpenForms["frmTrialBalance"] as frmTrialBalance;
                        break;
                    case "Balance Sheet":
                        frmObj = new frmBalanceSheet();
                        open = Application.OpenForms["frmBalanceSheet"] as frmBalanceSheet;
                        break;
                    case "Profit and Loss":
                        frmObj = new frmProfitAndLoss();
                        open = Application.OpenForms["frmProfitAndLoss"] as frmProfitAndLoss;
                        break;
                    case "Cash Flow":
                        frmObj = new frmCashFlow();
                        open = Application.OpenForms["frmCashFlow"] as frmCashFlow;
                        break;
                    case "Fund Flow":
                        frmObj = new frmFundFlow();
                        open = Application.OpenForms["frmFundFlow"] as frmFundFlow;
                        break;
                    case "Chart of Account":
                        frmObj = new frmChartOfAccount();
                        open = Application.OpenForms["frmChartOfAccount"] as frmChartOfAccount;
                        break;
                    case "Contra Report":
                        frmObj = new frmContraReport();
                        open = Application.OpenForms["frmContraReport"] as frmContraReport;
                        break;
                    case "Payment Report":
                        frmObj = new frmPaymentReport();
                        open = Application.OpenForms["frmPaymentReport"] as frmPaymentReport;
                        break;
                    case "Receipt Report":
                        frmObj = new frmReceiptReport();
                        open = Application.OpenForms["frmReceiptReport"] as frmReceiptReport;
                        break;
                    case "Journal Report":
                        frmObj = new frmJournalReport();
                        open = Application.OpenForms["frmJournalReport"] as frmJournalReport;
                        break;
                    case "PDC Payable Report":
                        frmObj = new frmPDCPayableReport();
                        open = Application.OpenForms["frmPDCPayableReport"] as frmPDCPayableReport;
                        break;
                    case "PDC Receivable Report":
                        frmObj = new frmPDCRecievableReport();
                        open = Application.OpenForms["frmPDCRecievableReport"] as frmPDCRecievableReport;
                        break;
                    case "PDC Clearance Report":
                        frmObj = new frmPDCClearanceReport();
                        open = Application.OpenForms["frmPDCClearanceReport"] as frmPDCClearanceReport;
                        break;
                    case "Purchase Order Report":
                        frmObj = new frmPurchaseOrderReport();
                        open = Application.OpenForms["frmPurchaseOrderReport"] as frmPurchaseOrderReport;
                        break;
                    case "Material Receipt Report":
                        frmObj = new frmMaterialReceiptReport();
                        open = Application.OpenForms["frmMaterialReceiptReport"] as frmMaterialReceiptReport;
                        break;
                    case "Rejection Out Report":
                        frmObj = new frmRejectionOutReport();
                        open = Application.OpenForms["frmRejectionOutReport"] as frmRejectionOutReport;
                        break;
                    case "Purchase Invoice Report":
                        frmObj = new frmPurchaseReport();
                        open = Application.OpenForms["frmPurchaseReport"] as frmPurchaseReport;
                        break;
                    case "Purchase Return Report":
                        frmObj = new frmPurchaseReturnReport();
                        open = Application.OpenForms["frmPurchaseReturnReport"] as frmPurchaseReturnReport;
                        break;
                    case "Sales Quotation Report":
                        frmObj = new frmSalesQuotationReport();
                        open = Application.OpenForms["frmSalesQuotationReport"] as frmSalesQuotationReport;
                        break;
                    case "Sales Order Report":
                        frmObj = new frmSalesOrderReport();
                        open = Application.OpenForms["frmSalesOrderReport"] as frmSalesOrderReport;
                        break;
                    case "Delivery Note Report":
                        frmObj = new frmDeliveryNoteReport();
                        open = Application.OpenForms["frmDeliveryNoteReport"] as frmDeliveryNoteReport;
                        break;
                    case "Rejection In Report":
                        frmObj = new frmRejectionInReport();
                        open = Application.OpenForms["frmRejectionInReport"] as frmRejectionInReport;
                        break;
                    case "Sales Invoice Report":
                        frmObj = new frmSalesReport();
                        open = Application.OpenForms["frmSalesReport"] as frmSalesReport;
                        break;
                    case "Sales Return Report":
                        frmObj = new frmSalesReturnReport();
                        open = Application.OpenForms["frmSalesReturnReport"] as frmSalesReturnReport;
                        break;
                    case "Physical Stock Report":
                        frmObj = new frmPhysicalStockReport();
                        open = Application.OpenForms["frmPhysicalStockReport"] as frmPhysicalStockReport;
                        break;
                    case "Service Report":
                        frmObj = new frmServiceReport();
                        open = Application.OpenForms["frmServiceReport"] as frmServiceReport;
                        break;
                    case "Credit Note Report":
                        frmObj = new frmCreditNoteReport();
                        open = Application.OpenForms["frmCreditNoteReport"] as frmCreditNoteReport;
                        break;
                    case "Debit Note Report":
                        frmObj = new frmDebitNoteReport();
                        open = Application.OpenForms["frmDebitNoteReport"] as frmDebitNoteReport;
                        break;
                    case "Stock Journal Report":
                        frmObj = new frmStockJournelReport();
                        open = Application.OpenForms["frmStockJournelReport"] as frmStockJournelReport;
                        break;
                    case "Employee Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmEmployeeReport();
                            open = Application.OpenForms["frmEmployeeReport"] as frmEmployeeReport;
                        }
                        break;
                    case "Daily Attendance Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmDailyAttendanceReport();
                            open = Application.OpenForms["frmDailyAttendanceReport"] as frmDailyAttendanceReport;
                        }
                        break;
                    case "Monthly Attendance Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmMonthlyAttendanceReport();
                            open = Application.OpenForms["frmMonthlyAttendanceReport"] as frmMonthlyAttendanceReport;
                        }
                        break;
                    case "Daily Salary Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmDailySalaryReport();
                            open = Application.OpenForms["frmDailySalaryReport"] as frmDailySalaryReport;
                        }
                        break;
                    case "Monthly Salary Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmMonthlySalaryReport();
                            open = Application.OpenForms["frmMonthlySalaryReport"] as frmMonthlySalaryReport;
                        }
                        break;
                    case "Payhead Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmPayHeadReport();
                            open = Application.OpenForms["frmPayHeadReport"] as frmPayHeadReport;
                        }
                        break;
                    case "Salary Package Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmSalaryPackageReport();
                            open = Application.OpenForms["frmSalaryPackageReport"] as frmSalaryPackageReport;
                        }
                        break;
                    case "Advance Payment Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmAdvancePaymentReport();
                            open = Application.OpenForms["frmAdvancePaymentReport"] as frmAdvancePaymentReport;
                        }
                        break;
                    case "Bonus Deduction Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmBonusDeductionReport();
                            open = Application.OpenForms["frmBonusDeductionReport"] as frmBonusDeductionReport;
                        }
                        break;
                    case "Employee Address Book Report":
                        if (BllSettings.SettingsStatusCheck("Payroll") == "Yes")
                        {
                            frmObj = new frmEmployeeAddressBook();
                            open = Application.OpenForms["frmEmployeeAddressBook"] as frmEmployeeAddressBook;
                        }
                        break;
                    case "Day Book":
                        frmObj = new frmDayBook();
                        open = Application.OpenForms["frmDayBook"] as frmDayBook;
                        break;
                    case "Cash/Bank Book":
                        frmObj = new frmCashBankBookReport();
                        open = Application.OpenForms["frmCashBankBookReport"] as frmCashBankBookReport;
                        break;
                    case "Account Groupwise Report":
                        frmObj = new frmAccountGroupwiseReport();
                        open = Application.OpenForms["frmAccountGroupwiseReport"] as frmAccountGroupwiseReport;
                        break;
                    case "Account Ledger Report":
                        frmObj = new frmAccountLedgerReport();
                        open = Application.OpenForms["frmAccountLedgerReport"] as frmAccountLedgerReport;
                        break;
                    case "Outstanding Report":
                        frmObj = new frmOutstandingReport();
                        open = Application.OpenForms["frmOutstandingReport"] as frmOutstandingReport;
                        break;
                    case "Ageing Report":
                        frmObj = new frmAgeingReport();
                        open = Application.OpenForms["frmAgeingReport"] as frmAgeingReport;
                        break;
                    case "Party's Address Book":
                        frmObj = new frmPartyAddressBook();
                        open = Application.OpenForms["frmPartyAddressBook"] as frmPartyAddressBook;
                        break;
                    case "Stock Report":
                        frmObj = new frmStockReport();
                        open = Application.OpenForms["frmStockReport"] as frmStockReport;
                        break;
                    case "Short Expiry Report":
                        frmObj = new frmShortExpiryReport();
                        open = Application.OpenForms["frmShortExpiryReport"] as frmShortExpiryReport;
                        break;
                    case "Product Statistics":
                        frmObj = new frmProductStatistics();
                        open = Application.OpenForms["frmProductStatistics"] as frmProductStatistics;
                        break;
                    case "Price List Report":
                        frmObj = new frmPriceListReport();
                        open = Application.OpenForms["frmPriceListReport"] as frmPriceListReport;
                        break;
                    case "Tax Report":
                        frmObj = new frmTaxReport();
                        open = Application.OpenForms["frmTaxReport"] as frmTaxReport;
                        break;
                    case "VAT Report":
                        frmObj = new frmVatReturnReport();
                        open = Application.OpenForms["frmVatReturnReport"] as frmVatReturnReport;
                        break;
                    case "Cheque Report":
                        frmObj = new frmChequeReport();
                        open = Application.OpenForms["frmChequeReport"] as frmChequeReport;
                        break;
                    case "Free Sale Report":
                        frmObj = new frmFreeSaleReport();
                        open = Application.OpenForms["frmFreeSaleReport"] as frmFreeSaleReport;
                        break;
                    case "Product Vs Batch Report":
                        frmObj = new frmProductVsBatchReport();
                        open = Application.OpenForms["frmProductVsBatchReport"] as frmProductVsBatchReport;
                        break;

                    case "Customer":
                        frmObj = new frmCustomer();
                        open = Application.OpenForms["frmCustomer"] as frmCustomer;
                        break;

                    case "Supplier":
                        frmObj = new frmSupplier();
                        open = Application.OpenForms["frmSupplier"] as frmSupplier;
                        break;
                }
                if (frmObj != null)
                {
                    if (open == null)
                    {
                        frmObj.MdiParent = formMDI.MDIObj;
                        frmObj.Show();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("QL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQuickLaunch_Load(object sender, EventArgs e)
        {
            try
            {
                btnFocus.SendToBack();
                AssignButtonText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("QL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
