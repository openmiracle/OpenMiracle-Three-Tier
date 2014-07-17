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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmSalesInvoice : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration Part
        /// </summary>
        ArrayList lstArrOfRemove = new ArrayList();
        ArrayList lstArrOfRemoveLedger = new ArrayList();
        frmSalesInvoiceRegister frmSalesinvoiceRegisterObj = null;
        frmVoucherSearch objVoucherSearch = null;
        frmSalesReport frmSalesReportObj = null;
        frmDayBook frmDayBookObj = null;//To use in call from frmDayBook
        frmVatReturnReport frmVatReturnReportObj = null;
        frmAgeingReport frmAgeingObj = null;//to use in call from Ageing function
        frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        frmEmployeeCreation frmEmployeeCreationObj = new frmEmployeeCreation(); // to add new salesman
        frmSalesman frmSalesManObj = new frmSalesman();
        frmLedgerDetails frmledgerDetailsObj;
        frmLedgerPopup frmLedgerPopUpObj = new frmLedgerPopup();
        frmEmployeePopup frmEmployeePopUpObj = new frmEmployeePopup();
        frmVoucherWiseProductSearch objVoucherProduct = null;
        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
        DataGridViewTextBoxEditingControl TextBoxControl;
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        int inMaxCount = 0;
        int inNarrationCount = 0;
        string strCashOrParty;
        string strSalesAccount;
        string strSalesMan;
        string strVoucherNo = string.Empty;
        string strPrefix = string.Empty;//to get the prefix string from frmvouchertypeselection
        string strSuffix = string.Empty;//to get the suffix string from frmvouchertypeselection
        decimal decSalesInvoiceIdToEdit = 0; // to get the details of sales order for editing purpous
        string strSalesManId = string.Empty;
        string strInvoiceNo = string.Empty;
        string strProductCode = string.Empty;
        string strPricingLevel;
        string strVoucherNoTostockPost = string.Empty; //' stock post
        string strInvoiceNoTostockPost = string.Empty; //' stock post
        decimal decVouchertypeIdTostockPost = 0; //' stock post
        decimal DecSalesInvoiceVoucherTypeId = 0;//to get the selected voucher type id from frmVoucherTypeSelection
        decimal decSalseInvoiceSuffixPrefixId = 0;
        decimal decGodownId = 0; // for fill rack using godown Id
        decimal decBankOrCashIdForEdit = 0; // to use delete the ledger posting cash or bank row
        decimal decCurrentConversionRate = 0;
        decimal decCurrentRate = 0;
        bool isValueChanged = false;
        bool isAutomatic = false;//to check whether the voucher number is automatically generated or not
        bool isValueChange = true;
        bool isFromEditMode = false;
        bool isFromSalesAccountCombo = false;       // for add new new account via button click
        bool isFromCashOrPartyCombo = false;        // for add new new account via button click
        bool isFromAgainest = false;
        bool IsSetGridValueChange = false;
        decimal decDeliveryNoteQty = 0;//To check quantity of sale against delivery note
        DataTable dtblDeliveryNoteDetails = new DataTable();
        #endregion
        #region Functions
        /// <summary>
        /// Create an instance for frmSalesInvoice Class
        /// </summary>
        public frmSalesInvoice()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cleare function and Generate the voucher no based on settings
        /// </summary>
        public void Clear()
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                //SalesMasterSP spSalesMaster = new SalesMasterSP();
                SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                if (isAutomatic)
                {
                    if (strVoucherNo == string.Empty)
                    {
                        strVoucherNo = "0";
                    }
                    strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecSalesInvoiceVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, "SalesMaster");
                    if (Convert.ToDecimal(strVoucherNo) != (BllSalesInvoice.SalesMasterVoucherMax(DecSalesInvoiceVoucherTypeId)))
                    {
                        strVoucherNo = BllSalesInvoice.SalesMasterVoucherMax(DecSalesInvoiceVoucherTypeId).ToString();
                        strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecSalesInvoiceVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, "SalesMaster");
                        if (BllSalesInvoice.SalesMasterVoucherMax(DecSalesInvoiceVoucherTypeId) == 0)
                        {
                            strVoucherNo = "0";
                            strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecSalesInvoiceVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, "SalesMaster");
                        }
                    }
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                   // SuffixPrefixSP spSuffisprefix = new SuffixPrefixSP();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(DecSalesInvoiceVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                    txtInvoiceNo.Text = strInvoiceNo;
                    txtInvoiceNo.ReadOnly = true;
                    decSalseInvoiceSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                }
                else
                {
                    txtInvoiceNo.ReadOnly = false;
                    txtInvoiceNo.Text = string.Empty;
                    strVoucherNo = string.Empty;
                    strInvoiceNo = strVoucherNo;
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
                cmbPricingLevel.SelectedIndex = 0;
                cmbSalesAccount.SelectedIndex = 0;
                cmbCashOrParty.SelectedIndex = 0;
                cmbSalesMan.SelectedIndex = 0;
                cmbSalesMode.SelectedIndex = 0;
                cmbDrorCr.SelectedIndex = 0;
                cmbCashOrbank.SelectedIndex = 0;
                cmbCurrency.Enabled = true;
                txtCustomer.Text = cmbCashOrParty.Text;
                txtTransportCompany.Text = string.Empty;
                txtVehicleNo.Text = string.Empty;
                txtNarration.Text = string.Empty;
                txtCreditPeriod.Text = "0";
                txtTotalAmount.Text = "0.00";
                txtBillDiscount.Text = "0";
                txtGrandTotal.Text = "0.00";
                lblTaxTotalAmount.Text = "0.00";
                lblLedgerTotalAmount.Text = "0.00";
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.Value = PublicVariables._dtCurrentDate;
                txtDate.Text = dtpDate.Value.ToString("dd-MMM-yyyy");
                dgvSalesInvoiceLedger.Rows.Clear();
                isFromEditMode = false;
                if (dgvSalesInvoice.DataSource != null)
                {
                    ((DataTable)dgvSalesInvoice.DataSource).Rows.Clear();
                }
                else
                {
                    dgvSalesInvoice.Rows.Clear();
                }
                gridCombofill();
                if (dgvSalesInvoiceTax.DataSource != null)
                {
                    ((DataTable)dgvSalesInvoiceTax.DataSource).Rows.Clear();
                }
                else
                {
                    dgvSalesInvoiceTax.Rows.Clear();
                }
                taxGridFill();
                if (!txtInvoiceNo.ReadOnly)
                {
                    txtInvoiceNo.Focus();
                }
                else
                {
                    txtDate.Select();
                }
                
                txtTotalAmount.Text = "0.00";
                txtGrandTotal.Text = "0.00";
                lblTotalQuantitydisplay.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI : 01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the settings and arrange the form controlls based on settings
        /// </summary>
        public void SalesInvoiceSettingsCheck()
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                cmbCashOrbank.Visible = false;
                lblcashOrBank.Visible = false;
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceGodown"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceGodown"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceRack"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceRack"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowBrand") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceBrand"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceBrand"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowSalesRate") == "yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceSalesRate"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceSalesRate"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowMRP") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceMrp"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceMrp"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    cmbCurrency.Enabled = true;
                }
                else
                {
                    cmbCurrency.Enabled = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoicembUnitName"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoicembUnitName"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowDiscountAmount") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountAmount"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountAmount"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceProductCode"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceProductCode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("Barcode") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceBarcode"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceBarcode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowDiscountPercentage") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountPercentage"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountPercentage"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceBatch"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceBatch"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowPurchaseRate") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoicePurchaseRate"].Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoicePurchaseRate"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("Tax") == "Yes")
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible = true;
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceTaxAmount"].Visible = true;
                    dgvSalesInvoiceTax.Visible = true;
                    lblTaxTotal.Visible = true;
                    lblTaxTotalAmount.Visible = true;
                }
                else
                {
                    dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible = false;
                    dgvSalesInvoice.Columns["dgvtxtSalesInvoiceTaxAmount"].Visible = false;
                    dgvSalesInvoiceTax.Visible = false;
                    lblTaxTotal.Visible = false;
                    lblTaxTotalAmount.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI : 02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the print after save status
        /// </summary>
        /// <returns></returns>
        public bool PrintAfetrSave()
        {
            bool isTick = false;
            try
            {
                isTick = TransactionGeneralFillObj.StatusOfPrintAfterSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        /// <summary>
        /// Cash or party combofill function
        /// </summary>
        /// <param name="cmbCashOrParty"></param>
        public void CashorPartyComboFill(ComboBox cmbCashOrParty)
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI : 04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Salesman combofill function
        /// </summary>
        public void salesManComboFill()
        {
            try
            {
                TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Sales account combofill function
        /// </summary>
        /// <param name="cmbSalesAccount"></param>
        public void SalesAccountComboFill(ComboBox cmbSalesAccount)
        {
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = BllSalesInvoice.SalesInvoiceSalesAccountModeComboFill();
                cmbSalesAccount.DataSource = listObj[0];
                cmbSalesAccount.DisplayMember = "ledgerName";
                cmbSalesAccount.ValueMember = "ledgerId";
                cmbSalesAccount.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Pricing level combofill function
        /// </summary>
        public void PricingLevelComboFill()
        {
            try
            {
                TransactionGeneralFillObj.PricingLevelViewAll(cmbPricingLevel, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Cash and bank combofill function
        /// </summary>
        public void cashAndBAnkCombofill()
        {
            List<DataTable> listObj = new List<DataTable>();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            try
            {
                listObj = BllSalesInvoice.BankOrCashComboFill();
                cmbCashOrbank.DataSource = listObj[0];
                cmbCashOrbank.ValueMember = "ledgerId";
                cmbCashOrbank.DisplayMember = "ledgerName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Vouchertype combofill function
        /// </summary>
        public void VoucherTypeComboFill()
        {
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            try
            {
                string typeOfVoucher = string.Empty;
                if (cmbSalesMode.Text == "Against SalesOrder")
                {
                    typeOfVoucher = "Sales Order";
                }
                else if (cmbSalesMode.Text == "Against Delivery Note")
                {
                    typeOfVoucher = "Delivery Note";
                }
                else if (cmbSalesMode.Text == "Against Quotation")
                {
                    typeOfVoucher = "Sales Quotation";
                }
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllSalesInvoice.VoucherTypesBasedOnTypeOfVouchers(typeOfVoucher);
                cmbVoucherType.DataSource = listObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid combofill function
        /// </summary>
        public void gridCombofill()
        {
            try
            {
                DgvUnitComboFill();
                DGVGodownComboFill();
                batchAllComboFill();
                dgvSalesInvoiceTaxComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Tax gridfill function
        /// </summary>
        public void taxGridFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllByVoucherTypeId(DecSalesInvoiceVoucherTypeId);
                dgvSalesInvoiceTax.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form load default functions
        /// </summary>
        public void formLoadDefaultFunctions()
        {
            try
            {
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.CustomFormat = "dd-MMMM-yyyy";
                dtpDate.Value = PublicVariables._dtCurrentDate;
                lblSalesModeOrderNo.Visible = false;
                cmbSalesModeOrderNo.Visible = false;
                CashorPartyComboFill(cmbCashOrParty);
                salesManComboFill();
                PricingLevelComboFill();
                SalesAccountComboFill(cmbSalesAccount);
                CurrencyComboFill();
                cashAndBAnkCombofill();
                VoucherTypeComboFill();
                FillProducts(false, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI : 12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Against Sales order combofill function
        /// </summary>
        public void againstOrderComboFill()
        {
            try
            {
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                //DeliveryNoteMasterSP spDeliveryNoteMasterSp = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
                List<DataTable> Listobj = new List<DataTable>();
                if (cmbCashOrParty.SelectedValue != null)
                {
                    if (cmbSalesMode.Text == "Against SalesOrder")
                    {
                        Listobj = bllSalesOrder.GetSalesOrderNoIncludePendingCorrespondingtoLedgerforSI(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), decSalesInvoiceIdToEdit, Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()));
                        DataRow dr = Listobj[0].NewRow();
                        dr["invoiceNo"] = "";
                        dr["salesOrderMasterId"] = 0;
                        Listobj[0].Rows.InsertAt(dr, 0);
                        isFromEditMode = true;
                        cmbSalesModeOrderNo.DataSource = Listobj[0];
                        cmbSalesModeOrderNo.ValueMember = "salesOrderMasterId";
                        cmbSalesModeOrderNo.DisplayMember = "invoiceNo";
                        isFromEditMode = false;
                    }
                    if (cmbSalesMode.Text == "Against Delivery Note")
                    {
                        List<DataTable> listObj = new List<DataTable>();
                        listObj = bllDeliveryNote.GetDeleveryNoteNoIncludePendingCorrespondingtoLedgerForSI(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), decSalesInvoiceIdToEdit, Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()));
                        DataRow dr = listObj[0].NewRow();
                        dr["invoiceNo"] = "";
                        dr["deliveryNoteMasterId"] = 0;
                        listObj[0].Rows.InsertAt(dr, 0);
                        isFromEditMode = true;
                        cmbSalesModeOrderNo.DataSource = listObj[0];
                        cmbSalesModeOrderNo.ValueMember = "deliveryNoteMasterId";
                        cmbSalesModeOrderNo.DisplayMember = "invoiceNo";
                        isFromEditMode = false;
                    }
                    if (cmbSalesMode.Text == "Against Quotation")
                    {
                        List<DataTable> listObj = new List<DataTable>();
                        listObj = bllSalesQuotation.GetSalesQuotationIncludePendingCorrespondingtoLedgerForSI(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), decSalesInvoiceIdToEdit, Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()));
                        DataRow dr = listObj[0].NewRow();
                        dr["invoiceNo"] = "";
                        dr["quotationMasterId"] = 0;
                        listObj[0].Rows.InsertAt(dr, 0);
                        isFromEditMode = true;
                        cmbSalesModeOrderNo.DataSource = listObj[0];
                        cmbSalesModeOrderNo.ValueMember = "quotationMasterId";
                        cmbSalesModeOrderNo.DisplayMember = "invoiceNo";
                        isFromEditMode = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherWiseProductSearch to view details and for updation
        /// </summary>
        /// <param name="frmVoucherwiseProductSearch"></param>
        /// <param name="decmasterId"></param>
        public void CallFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherwiseProductSearch, decimal decmasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                frmVoucherwiseProductSearch.Enabled = true;
                objVoucherProduct = frmVoucherwiseProductSearch;
                decSalesInvoiceIdToEdit = decmasterId;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="decSalesInvoiceVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decSalesInvoiceVoucherTypeId, string strVoucherTypeName)
        {
            decimal decDailySuffixPrefixId = 0;
            VoucherTypeBll BllVouchertype = new VoucherTypeBll();
            try
            {
                DecSalesInvoiceVoucherTypeId = decSalesInvoiceVoucherTypeId;
                isAutomatic = BllVouchertype.CheckMethodOfVoucherNumbering(DecSalesInvoiceVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(DecSalesInvoiceVoucherTypeId, dtpDate.Value);
                decDailySuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                this.Text = strVoucherTypeName;
                base.Show();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherSearch to view details and for updation 
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                base.Show();
                this.objVoucherSearch = frm;
                decSalesInvoiceIdToEdit = decId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDayBook to view details and for updation 
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void callFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                this.frmDayBookObj = frmDayBook;
                decSalesInvoiceIdToEdit = decMasterId;
                frmDayBook.Enabled = false;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVatReturnReport to view details and for updation 
        /// </summary>
        /// <param name="frmVatRetnRpot"></param>
        /// <param name="decMasterId"></param>
        public void callFromVatReturnReport(frmVatReturnReport frmVatRetnRpot, decimal decMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                this.frmVatReturnReportObj = frmVatRetnRpot;
                decSalesInvoiceIdToEdit = decMasterId;
                frmVatRetnRpot.Enabled = false;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create one account ledger from this form
        /// </summary>
        public void AccountLedgerCreation()
        {
            try
            {
                if (cmbCashOrParty.SelectedValue != null)
                {
                    strCashOrParty = cmbCashOrParty.SelectedValue.ToString();
                }
                else
                {
                    strCashOrParty = string.Empty;
                }
                if (cmbSalesAccount.SelectedValue != null)
                {
                    strSalesAccount = cmbSalesAccount.SelectedValue.ToString();
                }
                else
                {
                    strSalesAccount = string.Empty;
                }
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedgerObj.callFromSalesInvoice(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decAccountLedgerId"></param>
        public void ReturnFromAccountLedger(decimal decAccountLedgerId)
        {
            try
            {
                this.Enabled = true;
                CashorPartyComboFill(cmbCashOrParty);
                if (decAccountLedgerId != 0)
                {
                    cmbCashOrParty.SelectedValue = decAccountLedgerId;
                }
                else if (strCashOrParty != string.Empty)
                {
                    cmbCashOrParty.SelectedValue = strCashOrParty;
                }
                else
                {
                    cmbCashOrParty.SelectedValue = -1;
                }
                cmbCashOrParty.Focus();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decSalesAccountId"></param>
        public void ReturnFromSalesAccount(decimal decSalesAccountId)
        {
            try
            {
                this.Enabled = true;
                SalesAccountComboFill(cmbSalesAccount);
                if (decSalesAccountId != 0)
                {
                    cmbSalesAccount.SelectedValue = decSalesAccountId;
                }
                else if (strSalesAccount != string.Empty)
                {
                    cmbSalesAccount.SelectedValue = strSalesAccount;
                }
                else
                {
                    cmbSalesAccount.SelectedValue = -1;
                }
                cmbSalesAccount.Focus();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Pricing level combobox while return from Pricing level creation when creating new ledger 
        /// </summary>
        /// <param name="decPricingLevelId"></param>
        public void ReturnFromPricingLevel(decimal decPricingLevelId)
        {
            try
            {
                if (decPricingLevelId != 0)
                {
                    PricingLevelComboFill();
                    cmbPricingLevel.SelectedValue = decPricingLevelId;
                }
                else if (strPricingLevel != string.Empty)
                {
                    cmbPricingLevel.SelectedValue = strPricingLevel;
                }
                else
                {
                    cmbPricingLevel.SelectedValue = 0;
                }
                this.Enabled = true;
                cmbPricingLevel.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Salesman combobox while return from Salesman creation when creating new Salesman
        /// </summary>
        /// <param name="decSalesManId"></param>
        public void ReturnFromSalesManCreation(decimal decSalesManId)
        {
            try
            {
                if (decSalesManId != 0)
                {
                    salesManComboFill();
                    cmbSalesMan.SelectedValue = decSalesManId;
                }
                else if (strSalesMan != string.Empty)
                {
                    cmbSalesMan.SelectedValue = strSalesMan;
                }
                else
                {
                    cmbSalesMan.SelectedValue = -1;
                }
                this.Enabled = true;
                cmbSalesMan.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid Unit combofill, all are the unit fill here
        /// </summary>
        public void DgvUnitComboFill()
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAll();
                dgvtxtSalesInvoicembUnitName.DataSource = ListObj[0];
                dgvtxtSalesInvoicembUnitName.ValueMember = "unitId";
                dgvtxtSalesInvoicembUnitName.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Unitg fill function based on the products
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void UnitComboFill(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAllByProductId(decProductId);
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvSalesInvoice.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI : 25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Godown combo fill in the grid
        /// </summary>
        public void DGVGodownComboFill()
        {
            try
            {
                GodownBll BllGodown = new GodownBll();
                List<DataTable> listGodown = new List<DataTable>();
                listGodown = BllGodown.GodownViewAll();
                dgvcmbSalesInvoiceGodown.DataSource = listGodown[0];
                dgvcmbSalesInvoiceGodown.ValueMember = "godownId";
                dgvcmbSalesInvoiceGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Rack combofill based on the Godown
        /// </summary>
        /// <param name="decGodownId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void RackComboFill(decimal decGodownId, int inRow, int inColumn)
        {

            RackBll BllRack = new RackBll();
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                
                listObj = BllRack.RackNamesCorrespondingToGodownId(decGodownId);
                DataGridViewComboBoxCell dgvcmbRackCell = (DataGridViewComboBoxCell)dgvSalesInvoice.Rows[inRow].Cells[inColumn];
                dgvcmbRackCell.DataSource = listObj[0];
                dgvcmbRackCell.ValueMember = "rackId";
                dgvcmbRackCell.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Batch combofill curresponding to the products
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void BatchComboFill(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> list = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                list = BllBatch.BatchNamesCorrespondingToProduct(decProductId);
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvSalesInvoice.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Batch all combofill for Grid
        /// </summary>
        public void batchAllComboFill()
        {
            try
            {
                BatchBll BllBatch = new BatchBll();
                List<DataTable> listBatch = new List<DataTable>();
                listBatch = BllBatch.BatchViewAll();
                dgvcmbSalesInvoiceBatch.DataSource = listBatch[0];
                dgvcmbSalesInvoiceBatch.ValueMember = "batchId";
                dgvcmbSalesInvoiceBatch.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Currency combofill Based on the settings
        /// </summary>
        public void CurrencyComboFill()
        {
            SettingsBll BllSettings = new SettingsBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = TransactionGeneralFillObj.CurrencyComboByDate(dtpDate.Value);
                cmbCurrency.DataSource = listObj[0];
                cmbCurrency.DisplayMember = "currencyName";
                cmbCurrency.ValueMember = "exchangeRateId";
                cmbCurrency.SelectedValue = 1m;
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    cmbCurrency.Enabled = true;
                }
                else
                {
                    cmbCurrency.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Tax combofill in the grid under the vouchertype id
        /// </summary>
        public void dgvSalesInvoiceTaxComboFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllByVoucherTypeIdApplicaleForProduct(DecSalesInvoiceVoucherTypeId);
                DataRow drow = ListObj[0].NewRow();
                drow["taxName"] = string.Empty;
                drow["taxId"] = 0;
                ListObj[0].Rows.InsertAt(drow, 0);
                dgvcmbSalesInvoiceTaxName.DataSource = ListObj[0];
                dgvcmbSalesInvoiceTaxName.ValueMember = "taxId";
                dgvcmbSalesInvoiceTaxName.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no generation function for Sales invoice grid
        /// </summary>
        public void SerialNoforSalesInvoice()
        {
            try
            {
                IsSetGridValueChange = false;
                int inCount = 1;
                isValueChange = false;
                foreach (DataGridViewRow row in dgvSalesInvoice.Rows)
                {
                    row.Cells["dgvtxtSalesInvoiceSlno"].Value = inCount.ToString();
                    inCount++;
                }
                isValueChange = true;
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no generation function for Sales invoice Tax grid
        /// </summary>
        public void SerialNoforSalesInvoiceTax()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvSalesInvoiceTax.Rows)
                {
                    row.Cells["dgvtxtTSlno"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no generation function for Sales invoice Account ledger grid
        /// </summary>
        public void SerialNoforSalesInvoiceAccountLedger()
        {
            try
            {
                if (dgvSalesInvoice.RowCount > 0)
                {
                    int inCount = 1;
                    foreach (DataGridViewRow row in dgvSalesInvoiceLedger.Rows)
                    {
                        row.Cells["dgvtxtAditionalCostSlno"].Value = inCount.ToString();
                        inCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Getting the product rate based on the product, in the product coming under the offer or pricing level
        /// </summary>
        /// <param name="index"></param>
        /// <param name="decProductId"></param>
        /// <param name="decBatchId"></param>
        public void getProductRate(int index, decimal decProductId, decimal decBatchId)
        {
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            decimal decPricingLevelId = 0;
            try
            {
                DateTime dtcurrentDate = PublicVariables._dtCurrentDate;
                decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                decPricingLevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                decimal decRate = BllProductCreation.SalesInvoiceProductRateForSales(decProductId, dtcurrentDate, decBatchId, decPricingLevelId, decNodecplaces);
                dgvSalesInvoice.Rows[index].Cells["dgvtxtSalesInvoiceRate"].Value = decRate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 35 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// get the SalesInvoiceSalesDetailsId for delete
        /// </summary>
        public void GetSalesDetailsIdToDelete()
        {
            try
            {
                foreach (DataGridViewRow drow in dgvSalesInvoice.Rows)
                {
                    if (drow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value != null)
                    {
                        if (drow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() != string.Empty)
                        {
                            lstArrOfRemove.Add(drow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString());
                        }
                    }
                }
                dgvSalesInvoice.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 36 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
        /// <summary>
        /// Get the count of grid rows for Fill function
        /// </summary>
        /// <returns></returns>
        public int GetNextinRowIndex()
        {
            try
            {
                inMaxCount++;

            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 37 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            return inMaxCount;
        }
        /// <summary>
        /// Discount calculation function
        /// </summary>
        /// <param name="inIndexOfRow"></param>
        public void discountCalculation(int inIndexOfRow)
        {
            decimal dcDiscountAmount = 0;
            decimal dcDiscountPercentage = 0;
            decimal dcNetAmount = 0;
            decimal dcNetValue = 0;
            try
            {
                if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceRate"].Value != null && dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceRate"].Value.ToString() != string.Empty && dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceRate"].Value.ToString() != "0")
                {
                    if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceGrossValue"].Value != null && dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString() != string.Empty)
                    {
                        dcNetAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString());
                        if (dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountPercentage"].Visible)
                        {
                            if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value != null)
                            {
                                dcDiscountPercentage = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value.ToString());
                            }
                            if (dcDiscountPercentage > 100)
                            {
                                dcDiscountPercentage = 100;
                                IsSetGridValueChange = false;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = "100";
                                IsSetGridValueChange = true;
                            }
                            if (dcDiscountPercentage != 0)
                            {
                                dcDiscountAmount = dcNetAmount * dcDiscountPercentage / 100;
                                IsSetGridValueChange = false;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = Math.Round(dcDiscountAmount, PublicVariables._inNoOfDecimalPlaces);
                                IsSetGridValueChange = true;
                            }
                            else
                            {
                                IsSetGridValueChange = false;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = "0.00";
                                IsSetGridValueChange = true;
                            }
                        }
                        else if (dcNetAmount > 0)
                        {
                            IsSetGridValueChange = false;
                            dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = "0.00";
                            IsSetGridValueChange = true;
                        }
                        else
                        {
                            if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value != null)
                            {
                                dcDiscountAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                            }
                            if (dcDiscountAmount > dcNetAmount)
                            {
                                IsSetGridValueChange = false;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = 0;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = 0;
                                dcDiscountAmount = 0;
                                IsSetGridValueChange = true;
                            }
                            if (dcDiscountAmount > 0)
                            {
                                dcDiscountPercentage = (dcDiscountAmount * 100) / (dcNetAmount);
                                IsSetGridValueChange = false;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = Math.Round(dcDiscountPercentage, PublicVariables._inNoOfDecimalPlaces);
                                IsSetGridValueChange = true;
                            }
                        }
                        if (dcNetAmount != 0)
                        {
                            dcDiscountAmount = 0;
                            if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value != null)
                            {
                                dcDiscountAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                            }
                            decimal dcNewDiscountPercentage = 0;
                            if (dcDiscountAmount != 0)
                            {
                                dcDiscountPercentage = (dcDiscountAmount * 100) / (dcNetAmount);
                                IsSetGridValueChange = false;
                                if (dcDiscountPercentage > 100)
                                {
                                    dcDiscountPercentage = 100;
                                    dcDiscountAmount = dcNetAmount * dcNewDiscountPercentage / 100;
                                    dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = dcDiscountAmount;
                                    IsSetGridValueChange = true;
                                }
                                IsSetGridValueChange = false;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = Math.Round(dcDiscountPercentage, PublicVariables._inNoOfDecimalPlaces);
                                IsSetGridValueChange = true;
                            }
                            else
                            {
                                IsSetGridValueChange = false;
                                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = "0.00";
                                IsSetGridValueChange = true;
                            }
                        }
                        else
                        {
                            IsSetGridValueChange = false;
                            dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = "0.00";
                            IsSetGridValueChange = true;
                        }
                        if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value != null)
                        {
                            dcDiscountAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                        }
                    }
                    if (dcNetAmount > 0)
                    {
                        dcNetValue = dcNetAmount - dcDiscountAmount;
                        IsSetGridValueChange = false;
                        dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceNetAmount"].Value = Math.Round(dcNetValue, PublicVariables._inNoOfDecimalPlaces);
                        IsSetGridValueChange = true;
                    }
                }
                else
                {
                    IsSetGridValueChange = false;
                    dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceNetAmount"].Value = 0;
                    dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceAmount"].Value = 0;
                    IsSetGridValueChange = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI : 38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Sales invoice Total amount calculation function
        /// </summary>
        public void SiGridTotalAmountCalculation()
        {
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            try
            {
                decimal decTotalAmount = 0;
                decimal dcQtyTotal = 0;
                decimal decGridTotalAmount = 0;
                decimal decTaxApplicableonBill = 0;
                decimal declblLedgeramt = 0;
                foreach (DataGridViewRow dgrow in dgvSalesInvoice.Rows)
                {
                    if (dgrow.Cells["dgvtxtSalesInvoiceAmount"].Value != null)
                    {
                        if (dgrow.Cells["dgvtxtSalesInvoiceAmount"].Value.ToString() != string.Empty && dgrow.Cells["dgvtxtSalesInvoiceAmount"].Value.ToString() != "0")
                        {
                            decTotalAmount = Convert.ToDecimal(dgrow.Cells["dgvtxtSalesInvoiceAmount"].Value.ToString());
                            decGridTotalAmount = decGridTotalAmount + decTotalAmount;
                        }
                    }
                    if (dgrow.Cells["dgvtxtSalesInvoiceQty"].Value != null && dgrow.Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                    {
                        decimal dcTemp = dcQtyTotal;
                        dcQtyTotal = Convert.ToDecimal(dgrow.Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                        dcQtyTotal += dcTemp;
                    }
                }
                decGridTotalAmount += decTaxApplicableonBill;
                txtTotalAmount.Text = Math.Round(decGridTotalAmount, PublicVariables._inNoOfDecimalPlaces).ToString();
                if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                {
                    decTaxApplicableonBill = TaxAmountApplicableOnBill();
                    decGridTotalAmount += decTaxApplicableonBill;
                }
                if (cmbDrorCr.SelectedIndex == 1)
                {
                    declblLedgeramt = Convert.ToDecimal(lblLedgerTotalAmount.Text);
                }
                decGridTotalAmount += declblLedgeramt;
                txtTotalAmount.Text = Math.Round(decGridTotalAmount, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces.ToString())).ToString();
                lblTotalQuantitydisplay.Text = Math.Round(dcQtyTotal, PublicVariables._inNoOfDecimalPlaces).ToString();
                TotalTaxAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 39 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Tax total amount calculation function
        /// </summary>
        public void TotalTaxAmount()
        {
            decimal decTax = 0;
            decimal decTotalTaxAmount = 0;
            try
            {
                foreach (DataGridViewRow dgrow in dgvSalesInvoiceTax.Rows)
                {
                    if (dgrow.Cells["dgvtxtTtaxId"].Value != null)
                    {
                        if (dgrow.Cells["dgvtxtTtaxId"].Value.ToString() != string.Empty &&
                            dgrow.Cells["dgvtxtTtaxId"].Value.ToString() != "0")
                        {
                            if (dgrow.Cells["dgvtxtTtaxAmount"].Value != null)
                            {
                                if (dgrow.Cells["dgvtxtTtaxAmount"].Value.ToString() != string.Empty)
                                {
                                    decTax = Convert.ToDecimal(dgrow.Cells["dgvtxtTtaxAmount"].Value.ToString());
                                    decTotalTaxAmount = decTotalTaxAmount + decTax;
                                }
                            }
                        }
                    }
                }
                if (decTotalTaxAmount == 0)
                {
                    lblTaxTotalAmount.Text = "0.00"; ;
                }
                else
                {
                    lblTaxTotalAmount.Text = decTotalTaxAmount.ToString();
                    lblTaxTotalAmount.Text = Math.Round(decTotalTaxAmount, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger grid total amount calculation function
        /// </summary>
        public void LedgerGridTotalAmountCalculation()
        {
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            try
            {
                if (dgvSalesInvoiceLedger.RowCount > 1)
                {
                    if (dgvSalesInvoiceLedger.CurrentRow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null && dgvSalesInvoiceLedger.CurrentRow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != string.Empty)
                    {
                        decimal decLedgerTotalAmount = 0;
                        foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                        {
                            if (dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null)
                            {
                                if (dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != "")
                                {
                                    decLedgerTotalAmount = decLedgerTotalAmount + Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                                }
                            }
                        }
                        lblLedgerTotalAmount.Text = Math.Round(decLedgerTotalAmount, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces.ToString())).ToString();
                    }
                    else
                    {
                        decimal decLedgerTotalAmount = 0;
                        foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                        {
                            if (dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null)
                            {
                                if (dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != "")
                                {
                                    decLedgerTotalAmount = decLedgerTotalAmount + Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                                }
                            }
                        }
                        lblLedgerTotalAmount.Text = Math.Round(decLedgerTotalAmount, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces.ToString())).ToString();
                    }
                }
                else
                {
                    decimal decLedgerTotalAmount1 = 0;
                    foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null)
                        {
                            if (dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != "")
                            {
                                decLedgerTotalAmount1 = decLedgerTotalAmount1 + Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                            }
                        }
                    }
                    lblLedgerTotalAmount.Text = Math.Round(decLedgerTotalAmount1, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces.ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 41 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Get the tax amount sum coming under a Same tax type
        /// </summary>
        public void TaxAmountForTaxType()
        {
            decimal decTaxId = 0;
            decimal decAmount = 0;
            try
            {
                foreach (DataGridViewRow dgvTaxRow in dgvSalesInvoiceTax.Rows)
                {
                    if (dgvTaxRow.Cells["dgvtxtTtaxId"].Value != null)
                    {
                        if (dgvTaxRow.Cells["dgvtxtTtaxId"].Value.ToString() != string.Empty &&
                            dgvTaxRow.Cells["dgvtxtTtaxId"].Value.ToString() != "0")
                        {
                            decTaxId = Convert.ToDecimal(dgvTaxRow.Cells["dgvtxtTtaxId"].Value.ToString());
                            foreach (DataGridViewRow dgvSiRow in dgvSalesInvoice.Rows)
                            {
                                if (dgvSiRow.Cells["dgvtxtSalesInvoiceProductId"].Value != null)
                                {
                                    if (dgvSiRow.Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty &&
                                       Convert.ToDecimal(dgvSiRow.Cells["dgvtxtSalesInvoiceProductId"].Value) != 0)
                                    {
                                        if (dgvSiRow.Cells["dgvcmbSalesInvoiceTaxName"].Value != null)
                                        {
                                            if (dgvSiRow.Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString() != string.Empty &&
                                              Convert.ToDecimal(dgvSiRow.Cells["dgvcmbSalesInvoiceTaxName"].Value) != 0)
                                            {
                                                if (dgvSiRow.Cells["dgvtxtSalesInvoiceTaxAmount"].Value != null)
                                                {
                                                    if (dgvSiRow.Cells["dgvtxtSalesInvoiceTaxAmount"].Value.ToString() != string.Empty &&
                                                      Convert.ToDecimal(dgvSiRow.Cells["dgvtxtSalesInvoiceTaxAmount"].Value) != 0)
                                                    {
                                                        if (Convert.ToDecimal(dgvSiRow.Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString()) == decTaxId)
                                                        {
                                                            decAmount = decAmount + Convert.ToDecimal(dgvSiRow.Cells["dgvtxtSalesInvoiceTaxAmount"].Value.ToString());
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            dgvTaxRow.Cells["dgvtxtTtaxAmount"].Value = decAmount;
                            decAmount = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Gross value amount calculation
        /// </summary>
        /// <param name="inIndexOfRow"></param>
        public void GrossValueCalculation(int inIndexOfRow)
        {
            try
            {
                decimal dcRate = 0;
                decimal dcQty = 0;
                decimal dcGrossValue = 0;
                if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                {
                    if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceQty"].Value != null)
                    {
                        dcQty = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                    }
                    if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceRate"].Value != null)
                    {
                        dcRate = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                    }
                    dcGrossValue = dcQty * dcRate;
                    dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceGrossValue"].Value = Math.Round(dcGrossValue, PublicVariables._inNoOfDecimalPlaces);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 43 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Grid row total amount calculation( Including Tax)
        /// </summary>
        /// <param name="inIndexOfRow"></param>
        public void taxAndGridTotalAmountCalculation(int inIndexOfRow)
        {
            TaxBll bllTax = new TaxBll();
            try
            {
                decimal dTaxAmt = 0;
                decimal dcTotal = 0;
                decimal dcNetValue = 0;
                if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                {
                    dcNetValue = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceNetAmount"].Value.ToString());
                    if (dcNetValue != 0 && dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible && (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvcmbSalesInvoiceTaxName"].Value == null ? "" : dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString()) != "")
                    {
                        TaxInfo InfoTaxMaster = bllTax.TaxView(Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString()));
                        dTaxAmt = Math.Round(((dcNetValue * InfoTaxMaster.Rate) / (100)), PublicVariables._inNoOfDecimalPlaces);
                        dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceTaxAmount"].Value = dTaxAmt.ToString();
                    }
                    else
                    {
                        dTaxAmt = 0;
                        dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceTaxAmount"].Value = "0.00";
                    }
                }
                else
                {
                    dTaxAmt = 0;
                    dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceTaxAmount"].Value = "0.00";
                }
                dcTotal = dcNetValue + dTaxAmt;
                dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceAmount"].Value = dcTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 44 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Get the total tax amount applicable on bill calculation( to get Final total amount)
        /// </summary>
        /// <returns></returns>
        public decimal TaxAmountApplicableOnBill()
        {
            decimal decTaxId = 0;
            decimal decTaxRate = 0;
            decimal decTaxOnBill = 0;
            decimal decTotalTaxOnBill = 0;
            decimal decTaxOnTax = 0;
            decimal decTotalTaxOnTax = 0;
            decimal decTotalAmount = 0;
            decimal decTotalTax = 0;
            TaxBll bllTax = new TaxBll();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                TaxAmountForTaxType();
                if (txtTotalAmount.Text != string.Empty)
                {
                    decTotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                }
                foreach (DataGridViewRow dgvRow in dgvSalesInvoiceTax.Rows)
                {
                    if (dgvRow.Cells["dgvtxtTtaxId"].Value != null)
                    {
                        if (dgvRow.Cells["dgvtxtTApplicableOn"].Value != null && dgvRow.Cells["dgvtxtTCalculatingMode"].Value != null)
                        {
                            if (dgvRow.Cells["dgvtxtTApplicableOn"].Value.ToString() == "Bill" && dgvRow.Cells["dgvtxtTCalculatingMode"].Value.ToString() == "Bill Amount")
                            {
                                decTaxRate = Convert.ToDecimal(dgvRow.Cells["dgvtxtTTaxRate"].Value.ToString());
                                decTaxOnBill = (decTotalAmount * decTaxRate / 100);
                                dgvRow.Cells["dgvtxtTtaxAmount"].Value = Math.Round(decTaxOnBill, PublicVariables._inNoOfDecimalPlaces);
                                decTotalTaxOnBill = decTotalTaxOnBill + decTaxOnBill;
                            }
                        }
                    }
                }
                foreach (DataGridViewRow dgvRow1 in dgvSalesInvoiceTax.Rows)
                {
                    if (dgvRow1.Cells["dgvtxtTtaxId"].Value != null)
                    {
                        if (dgvRow1.Cells["dgvtxtTApplicableOn"].Value != null && dgvRow1.Cells["dgvtxtTCalculatingMode"].Value != null)
                        {
                            if (dgvRow1.Cells["dgvtxtTApplicableOn"].Value.ToString() == "Bill" && dgvRow1.Cells["dgvtxtTCalculatingMode"].Value.ToString() == "Tax Amount")
                            {
                                decTaxId = Convert.ToDecimal(dgvRow1.Cells["dgvtxtTtaxId"].Value.ToString());
                                ListObj = bllTax.TaxDetailsViewallByTaxId(decTaxId);
                                foreach (DataGridViewRow dgvRow2 in dgvSalesInvoiceTax.Rows)
                                {
                                    foreach (DataRow drow in ListObj[0].Rows)
                                    {
                                        if (dgvRow2.Cells["dgvtxtTtaxId"].Value != null)
                                        {
                                            if (dgvRow2.Cells["dgvtxtTtaxId"].Value.ToString() == drow.ItemArray[0].ToString())
                                            {
                                                decTaxRate = Convert.ToDecimal(dgvRow1.Cells["dgvtxtTTaxRate"].Value.ToString());
                                                decTotalAmount = Convert.ToDecimal(dgvRow2.Cells["dgvtxtTtaxAmount"].Value.ToString());
                                                decTaxOnTax = (decTotalAmount * decTaxRate / 100);
                                                dgvRow1.Cells["dgvtxtTtaxAmount"].Value = Math.Round(decTaxOnTax, PublicVariables._inNoOfDecimalPlaces);
                                                decTotalTaxOnTax = decTotalTaxOnTax + decTaxOnTax;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            decTotalTax = decTotalTaxOnBill + decTotalTaxOnTax;
            return decTotalTax;
        }
        /// <summary>
        /// Checking the same product repetation in grid
        /// </summary>
        /// <returns></returns>
        public bool ProductSameOccourance()
        {
            bool isSame = false;
            try
            {
                int index = dgvSalesInvoice.CurrentRow.Index;
                string strName = dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    string strOther = dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                    if (strName == strOther)
                    {
                        inCurrentIndex = dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].RowIndex;
                    }
                }
                dgvSalesInvoice.Rows[inCurrentIndex].HeaderCell.Value = "";
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSame;
        }
        /// <summary>
        /// Remove function
        /// </summary>
        public void RemoveFunction()
        {
            try
            {
                int inRowCount = dgvSalesInvoice.RowCount;
                int index = dgvSalesInvoice.CurrentRow.Index;
                int inC = 0;
                if (inRowCount > 2)
                {
                    if (dgvSalesInvoice.CurrentRow.HeaderCell.Value == null)
                    {
                        string strName = dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                        int inIndex = dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductName"].RowIndex;
                        string strOther;
                        for (int inI = 0; inI < inRowCount - 1; inI++)
                        {
                            inC++;
                            strOther = dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                            if (inIndex != dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].RowIndex)
                            {
                                if (ProductSameOccourance())
                                {
                                    dgvSalesInvoice.Rows.RemoveAt(index);
                                    return;
                                }
                                else
                                {
                                    if (inC == inRowCount - 1)
                                    {
                                        dgvSalesInvoice.Rows.RemoveAt(index);
                                        inC = 0;
                                    }
                                }
                            }
                            else
                            {
                                dgvSalesInvoice.Rows.RemoveAt(index);
                            }
                        }
                    }
                    else
                    {
                        dgvSalesInvoice.Rows.RemoveAt(index);
                    }
                }
                else
                {
                    dgvSalesInvoice.Rows.RemoveAt(index);
                }
                SerialNoforSalesInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger Grid Invalid Entrys Remove Function
        /// </summary>
        public void RemoveFunctionForAdditionalCost()
        {
            try
            {
                int inAddRowCount = dgvSalesInvoiceLedger.RowCount;
                int inAddIndex = dgvSalesInvoiceLedger.CurrentRow.Index;
                if (inAddRowCount > 2)
                {
                    dgvSalesInvoiceLedger.Rows.RemoveAt(inAddIndex);
                }
                else
                {
                    dgvSalesInvoiceLedger.Rows.RemoveAt(inAddIndex);
                }
                SerialNoforSalesInvoiceAccountLedger();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Grid column status based on the settings
        /// </summary>
        public void gridColumnMakeEnables()
        {
            try
            {
                if (isFromAgainest)
                {
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductCode"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductName"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceBarcode"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicePurchaseRate"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceMrp"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceSalesRate"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceGrossValue"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceTaxAmount"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceNetAmount"].ReadOnly = true;
                    dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceAmount"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid cleare function based on Fill the grid against
        /// </summary>
        public void ClearGridAgainest()
        {
            try
            {

                dgvSalesInvoice.Rows.Clear();
                cmbPricingLevel.Enabled = true;
                btnNewPricingLevel.Enabled = true;
                txtGrandTotal.Text = "0.00";
                txtTotalAmount.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid fill function Againest SalseOrderDetails
        /// </summary>
        public void gridFillAgainestSalseOrderDetails()
        {
            BrandBll BllBrand = new BrandBll();
            //SalesOrderBll bllSalesOrder = new SalesOrderBll();
            SalesOrderBll bllSalesOrder = new SalesOrderBll();
            ProductInfo infoproduct = new ProductInfo();
            //SalesMasterSP spSalesMaster = new SalesMasterSP();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            BrandInfo InfoBrand = new BrandInfo();
            TaxInfo infoTax = new TaxInfo();
            TaxBll bllTax = new TaxBll();
            try
            {
                if (cmbSalesModeOrderNo.SelectedIndex > 0)
                {
                    inMaxCount = 0;
                    isValueChange = false;
                    for (int i = 0; i < dgvSalesInvoice.RowCount - 1; i++)
                    {
                        if (dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value != null && dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() != string.Empty)
                        {
                            lstArrOfRemove.Add(dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString());
                        }
                    }
                    dgvSalesInvoice.Rows.Clear();
                    isValueChange = true;
                    List<DataTable> ListObj= bllSalesOrder.SalesInvoiceGridfillAgainestSalesOrder(Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString()));
                    cmbPricingLevel.SelectedValue = Convert.ToDecimal(ListObj[0].Rows[0]["pricingLevelId"].ToString());
                    cmbCurrency.SelectedValue = Convert.ToDecimal(ListObj[0].Rows[0]["exchangeRateId"].ToString());
                    if (ListObj[0].Rows[0]["employeeId"].ToString() != string.Empty)
                    {
                        strSalesManId = ListObj[0].Rows[0]["employeeId"].ToString();
                        cmbSalesMan.SelectedValue = strSalesManId;
                        if (cmbSalesMan.SelectedValue == null)
                        {
                            salesManComboFill();
                            cmbSalesMan.SelectedValue = ListObj[0].Rows[0]["employeeId"].ToString();
                        }
                    }
                    cmbPricingLevel.Enabled = false;
                    btnNewPricingLevel.Enabled = false;
                    cmbCurrency.Enabled = false;
                     ListObj = bllSalesOrder.SalesInvoiceGridfillAgainestSalesOrderUsingSalesDetails(Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString()), Convert.ToDecimal(decSalesInvoiceIdToEdit), DecSalesInvoiceVoucherTypeId);
                    int inRowIndex = 0;
                    foreach (DataRow drowDetails in ListObj[0].Rows)
                    {
                        dgvSalesInvoice.Rows.Add();
                        isValueChange = false;
                        IsSetGridValueChange = false;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSISalesOrderDetailsId"].Value = drowDetails["salesOrderDetailsId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductCode"].Value = drowDetails["productCode"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceBarcode"].Value = drowDetails["barcode"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvcmbSalesInvoiceBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherNo"].Value = drowDetails["voucherNo"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value = drowDetails["invoiceNo"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value = drowDetails["voucherTypeId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = "0";
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInRowIndex"].Value = drowDetails["salesOrderDetailsId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value = drowDetails.ItemArray[2].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value = drowDetails["unitConversionId"].ToString();
                        infoproduct = BllSalesInvoice.ProductViewByProductIdforSalesInvoice(Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value).ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductName"].Value = infoproduct.ProductName;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceMrp"].Value = infoproduct.Mrp;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicePurchaseRate"].Value = infoproduct.PurchaseRate;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceSalesRate"].Value = infoproduct.SalesRate;
                        InfoBrand = BllBrand.BrandView(infoproduct.BrandId);
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceBrand"].Value = InfoBrand.BrandName;
                        infoTax = bllTax.TaxViewByProductId(Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value).ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvcmbSalesInvoiceTaxName"].Value = infoTax.TaxId;
                        isValueChange = false;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicembUnitName"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicembUnitName"].ReadOnly = true;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceQty"].Value = drowDetails["Qty"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceRate"].Value = drowDetails["rate"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceAmount"].Value = drowDetails["amount"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceConversionRate"].Value = drowDetails["conversionRate"].ToString();
                        isFromAgainest = true;
                        gridColumnMakeEnables();
                        int intIndex = 0;
                        intIndex = Convert.ToInt32(drowDetails["salesOrderDetailsId"].ToString());
                        if (inMaxCount < intIndex)
                            inMaxCount = intIndex;
                        inRowIndex++;
                        isValueChange = true;
                        isFromAgainest = false;
                        GrossValueCalculation(dgvSalesInvoice.Rows.Count - 2);
                        discountCalculation(dgvSalesInvoice.Rows.Count - 2);
                        taxAndGridTotalAmountCalculation(dgvSalesInvoice.Rows.Count - 2);
                    }
                    IsSetGridValueChange = true;
                    for (int i = inRowIndex; i < dgvSalesInvoice.Rows.Count; ++i)
                        dgvSalesInvoice["dgvtxtSalesInvoiceInRowIndex", i].Value = GetNextinRowIndex().ToString();
                    SerialNoforSalesInvoice();
                    strVoucherNoTostockPost = dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherNo"].Value.ToString();
                    strInvoiceNoTostockPost = dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value.ToString();
                    decVouchertypeIdTostockPost = Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value);
                }
                else
                {
                    SiGridTotalAmountCalculation();
                    ClearGridAgainest();
                }
                SiGridTotalAmountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Grid fill function Againest QuotationDetails
        /// </summary>
        public void gridFillAgainestQuotationDetails()
        {
            BrandBll BllBrand = new BrandBll();
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            ProductInfo infoproduct = new ProductInfo();
            //SalesMasterSP spSalesMaster = new SalesMasterSP();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            BrandInfo InfoBrand = new BrandInfo();
            TaxInfo infoTax = new TaxInfo();
            TaxBll bllTax = new TaxBll();
            try
            {
                if (cmbSalesModeOrderNo.SelectedIndex > 0)
                {
                    inMaxCount = 0;
                    isValueChange = false;
                    for (int i = 0; i < dgvSalesInvoice.RowCount - 1; i++)
                    {
                        if (dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value != null && dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() != string.Empty)
                        {
                            lstArrOfRemove.Add(dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString());
                        }
                    }
                    dgvSalesInvoice.Rows.Clear();
                    isValueChange = true;
                    List<DataTable> ListSalesMaster = bllSalesQuotation.SalesInvoiceGridfillAgainestQuotation(Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString()));
                    cmbPricingLevel.SelectedValue = Convert.ToDecimal(ListSalesMaster[0].Rows[0]["pricingLevelId"].ToString());
                    cmbCurrency.SelectedValue = Convert.ToDecimal(ListSalesMaster[0].Rows[0]["exchangeRateId"].ToString());
                    if (ListSalesMaster[0].Rows[0]["employeeId"].ToString() != string.Empty)
                    {
                        strSalesManId = ListSalesMaster[0].Rows[0]["employeeId"].ToString();
                        cmbSalesMan.SelectedValue = strSalesManId;
                        if (cmbSalesMan.SelectedValue == null)
                        {
                            salesManComboFill();
                            cmbSalesMan.SelectedValue = ListSalesMaster[0].Rows[0]["employeeId"].ToString();
                        }
                    }
                    cmbPricingLevel.Enabled = false;
                    btnNewPricingLevel.Enabled = false;
                    cmbCurrency.Enabled = false;
                    List<DataTable> ListSalesDetals = bllSalesQuotation.SalesInvoiceGridfillAgainestQuotationUsingQuotationDetails(Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString()), decSalesInvoiceIdToEdit, DecSalesInvoiceVoucherTypeId);
                    int inRowIndex = 0;
                    foreach (DataRow drowDetails in ListSalesDetals[0].Rows)
                    {
                        dgvSalesInvoice.Rows.Add();
                        IsSetGridValueChange = false;
                        isValueChange = false;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value = drowDetails["quotationDetailsId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductCode"].Value = drowDetails["productCode"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceBarcode"].Value = drowDetails["barcode"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvcmbSalesInvoiceBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherNo"].Value = drowDetails["voucherNo"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value = drowDetails["invoiceNo"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value = drowDetails["voucherTypeId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = "0";
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInRowIndex"].Value = drowDetails["quotationDetailsId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value = drowDetails.ItemArray[2].ToString();
                        infoproduct = BllSalesInvoice.ProductViewByProductIdforSalesInvoice(Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value).ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductName"].Value = infoproduct.ProductName;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceMrp"].Value = infoproduct.Mrp;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicePurchaseRate"].Value = infoproduct.PurchaseRate;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceSalesRate"].Value = infoproduct.SalesRate;
                        InfoBrand = BllBrand.BrandView(infoproduct.BrandId);
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceBrand"].Value = InfoBrand.BrandName;
                        infoTax = bllTax.TaxViewByProductId(Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value).ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvcmbSalesInvoiceTaxName"].Value = infoTax.TaxId;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value = drowDetails["unitConversionId"].ToString();
                        isValueChange = false;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicembUnitName"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicembUnitName"].ReadOnly = true;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceQty"].Value = drowDetails["Qty"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceRate"].Value = drowDetails["rate"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceAmount"].Value = drowDetails["amount"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceConversionRate"].Value = drowDetails["conversionRate"].ToString();
                        isFromAgainest = true;
                        gridColumnMakeEnables();
                        int intIndex = 0;
                        intIndex = Convert.ToInt32(drowDetails["quotationDetailsId"].ToString());
                        if (inMaxCount < intIndex)
                            inMaxCount = intIndex;
                        inRowIndex++;
                        isValueChange = true;
                        isFromAgainest = false;
                        GrossValueCalculation(dgvSalesInvoice.Rows.Count - 2);
                        discountCalculation(dgvSalesInvoice.Rows.Count - 2);
                        taxAndGridTotalAmountCalculation(dgvSalesInvoice.Rows.Count - 2);
                    }
                    IsSetGridValueChange = true;
                    for (int i = inRowIndex; i < dgvSalesInvoice.Rows.Count; ++i)
                        dgvSalesInvoice["dgvtxtSalesInvoiceInRowIndex", i].Value = GetNextinRowIndex().ToString();
                    SerialNoforSalesInvoice();
                    strVoucherNoTostockPost = dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherNo"].Value.ToString();
                    strInvoiceNoTostockPost = dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value.ToString();
                    decVouchertypeIdTostockPost = Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value);
                }
                else
                {
                    SiGridTotalAmountCalculation();
                    ClearGridAgainest();
                }
                SiGridTotalAmountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Grid fill function Againest DeliveryNote
        /// </summary>
        public void gridFillAgainestDeliveryNote()
        {
            BrandBll BllBrand = new BrandBll();
            //DeliveryNoteMasterSP SPDeliveryNoteMaster = new DeliveryNoteMasterSP();
            //DeliveryNoteDetailsSP SPDeliveryNoteDetails = new DeliveryNoteDetailsSP();
            DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
            ProductInfo infoproduct = new ProductInfo();
            //SalesMasterSP spSalesMaster = new SalesMasterSP();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            BrandInfo InfoBrand = new BrandInfo();
            TaxInfo infoTax = new TaxInfo();
            TaxBll bllTax = new TaxBll();
            try
            {
                if (cmbSalesModeOrderNo.SelectedIndex > 0)
                {
                    inMaxCount = 0;
                    isValueChange = false;
                    for (int i = 0; i < dgvSalesInvoice.RowCount - 1; i++)
                    {
                        if (dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value != null && dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() != string.Empty)
                        {
                            lstArrOfRemove.Add(dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString());
                        }
                    }
                    dgvSalesInvoice.Rows.Clear();
                    isValueChange = true;
                    List<DataTable> listObjMaster = bllDeliveryNote.SalesInvoiceGridfillAgainestDeliveryNote(Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString()));
                    cmbPricingLevel.SelectedValue = Convert.ToDecimal(listObjMaster[0].Rows[0]["pricingLevelId"].ToString());
                    cmbCurrency.SelectedValue = Convert.ToDecimal(listObjMaster[0].Rows[0]["exchangeRateId"].ToString());
                    cmbPricingLevel.Enabled = false;
                    cmbCurrency.Enabled = false;
                    List<DataTable> listObjDetails = bllDeliveryNote.SalesInvoiceGridfillAgainestDeliveryNoteUsingDeliveryNoteDetails(Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString()), decSalesInvoiceIdToEdit, DecSalesInvoiceVoucherTypeId);
                    dtblDeliveryNoteDetails = listObjDetails[0];
                    int inRowIndex = 0;
                    foreach (DataRow drowDetails in listObjDetails[0].Rows)
                    {
                        dgvSalesInvoice.Rows.Add();
                        IsSetGridValueChange = false;
                        isValueChange = false;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value = drowDetails["deliveryNoteDetailsId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductCode"].Value = drowDetails["productCode"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceBarcode"].Value = drowDetails["barcode"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvcmbSalesInvoiceBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherNo"].Value = drowDetails["voucherNo"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value = drowDetails["invoiceNo"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value = drowDetails["voucherTypeId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = "0";
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInRowIndex"].Value = drowDetails["deliveryNoteDetailsId"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value = drowDetails.ItemArray[2].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value = drowDetails["unitConversionId"].ToString();
                        infoproduct = BllSalesInvoice.ProductViewByProductIdforSalesInvoice(Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value).ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductName"].Value = infoproduct.ProductName;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceMrp"].Value = infoproduct.Mrp;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicePurchaseRate"].Value = infoproduct.PurchaseRate;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceSalesRate"].Value = infoproduct.SalesRate;
                        InfoBrand = BllBrand.BrandView(infoproduct.BrandId);
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceBrand"].Value = InfoBrand.BrandName;
                        infoTax = bllTax.TaxViewByProductId(Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceProductId"].Value).ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvcmbSalesInvoiceTaxName"].Value = infoTax.TaxId;
                        isValueChange = false;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicembUnitName"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoicembUnitName"].ReadOnly = true;
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceQty"].Value = drowDetails["Qty"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceRate"].Value = drowDetails["rate"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceAmount"].Value = drowDetails["amount"].ToString();
                        dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceConversionRate"].Value = drowDetails["conversionRate"].ToString();
                        isFromAgainest = true;
                        gridColumnMakeEnables();
                        int intIndex = 0;
                        intIndex = Convert.ToInt32(drowDetails["deliveryNoteDetailsId"].ToString());
                        if (inMaxCount < intIndex)
                            inMaxCount = intIndex;
                        inRowIndex++;
                        isValueChange = true;
                        isFromAgainest = false;
                        GrossValueCalculation(dgvSalesInvoice.Rows.Count - 2);
                        discountCalculation(dgvSalesInvoice.Rows.Count - 2);
                        taxAndGridTotalAmountCalculation(dgvSalesInvoice.Rows.Count - 2);
                    }
                    IsSetGridValueChange = true;
                    for (int i = inRowIndex; i < dgvSalesInvoice.Rows.Count; ++i)
                        dgvSalesInvoice["dgvtxtSalesInvoiceInRowIndex", i].Value = GetNextinRowIndex().ToString();
                    SerialNoforSalesInvoice();
                    strVoucherNoTostockPost = dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherNo"].Value.ToString();
                    strInvoiceNoTostockPost = dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value.ToString();
                    decVouchertypeIdTostockPost = Convert.ToDecimal(dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value);
                }
                else
                {
                    SiGridTotalAmountCalculation();
                    ClearGridAgainest();
                }
                SiGridTotalAmountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the invalid entries of the grid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                if (dgvSalesInvoice.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductName"].Value == null || dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductName"].Value.ToString().Trim() ==string.Empty)
                        {
                            isValueChanged = true;
                            dgvSalesInvoice.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesInvoice.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceQty"].Value == null || dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceQty"].Value.ToString().Trim()==string.Empty || Convert.ToDecimal( dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceQty"].Value)==0)
                        {
                            isValueChanged = true;
                            dgvSalesInvoice.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesInvoice.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceRate"].Value == null || dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceRate"].Value.ToString().Trim() ==string.Empty)
                        {
                            isValueChanged = true;
                            dgvSalesInvoice.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesInvoice.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceGrossValue"].Value == null || dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvSalesInvoice.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesInvoice.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceAmount"].Value == null || dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceAmount"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvSalesInvoice.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesInvoice.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceRate"].Value) == 0)
                        {
                            isValueChanged = true;
                            dgvSalesInvoice.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesInvoice.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvSalesInvoice.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the InvalidEntries Of AdditionalCost Grid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntriesOfAdditionalCost(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalesInvoiceLedger.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvSalesInvoiceLedger.CurrentRow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value == null || dgvSalesInvoiceLedger.CurrentRow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvSalesInvoiceLedger.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesInvoiceLedger.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvSalesInvoiceLedger.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 55" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmAgeingReport to view details and for updation
        /// </summary>
        /// <param name="frmAgeing"></param>
        /// <param name="decMasterId"></param>
        public void callFromAgeing(frmAgeingReport frmAgeing, decimal decMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                frmAgeing.Enabled = false;
                this.frmAgeingObj = frmAgeing;
                decSalesInvoiceIdToEdit = decMasterId;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmLedgerPopup to view details and for updation
        /// </summary>
        /// <param name="frmLedgerPopup"></param>
        /// <param name="decId"></param>
        /// <param name="strComboTypes"></param>
        public void CallFromLedgerPopup(frmLedgerPopup frmLedgerPopup, decimal decId, string strComboTypes) //PopUp
        {
            try
            {
                this.Enabled = true;
                this.frmLedgerPopUpObj = frmLedgerPopup;
                if (strComboTypes == "CashOrSundryDeptors")
                {
                    CashorPartyComboFill(cmbCashOrParty);
                    cmbCashOrParty.SelectedValue = decId;
                }
                else if (strComboTypes == "SalesAccount")
                {
                    SalesAccountComboFill(cmbSalesAccount);
                    cmbSalesAccount.SelectedValue = decId;
                }
                frmLedgerPopUpObj.Close();
                frmLedgerPopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup form to select and view Employee
        /// </summary>
        /// <param name="frmEmployeePopup"></param>
        /// <param name="decId"></param>
        public void CallEmployeePopUp(frmEmployeePopup frmEmployeePopup, decimal decId) //PopUp
        {
            try
            {
                base.Show();
                this.frmEmployeePopUpObj = frmEmployeePopup;
                salesManComboFill();
                cmbSalesMan.SelectedValue = decId;
                cmbSalesMan.Focus();
                frmEmployeePopUpObj.Close();
                frmEmployeePopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmProductSearchPopup form to select and view a product
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation= new ProductCreationBll();
            try
            {
                base.Show();
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                infoProduct = BllProductCreation.ProductView(decproductId);
                int inRowcount = dgvSalesInvoice.Rows.Count;
                for (int i = 0; i < inRowcount; i++)
                {
                    if (i == decCurrentRowIndex)
                    {
                        dgvSalesInvoice.Rows.Add();
                        dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductCode"].Value = infoProduct.ProductCode;
                        strProductCode = infoProduct.ProductCode;
                        ProductDetailsFill(strProductCode, i, "ProductCode");
                    }
                }
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Product Details fill in the grid here
        /// </summary>
        /// <param name="strProduct"></param>
        /// <param name="inRowIndex"></param>
        /// <param name="strFillMode"></param>
        public void ProductDetailsFill(string strProduct, int inRowIndex, string strFillMode)
        {
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                gridCombofill();
                if (strFillMode == "ProductCode")
                {
                    listObj = BllSalesInvoice.SalesInvoiceDetailsViewByProductCodeForSI(DecSalesInvoiceVoucherTypeId, strProduct);
                }
                else if (strFillMode == "ProductName")
                {
                    listObj = BllSalesInvoice.SalesInvoiceDetailsViewByProductNameForSI(DecSalesInvoiceVoucherTypeId, strProduct);
                }
                else if (strFillMode == "Barcode")
                {
                    listObj = BllSalesInvoice.SalesInvoiceDetailsViewByBarcodeForSI(DecSalesInvoiceVoucherTypeId, strProduct);
                }
                if (listObj[0].Rows.Count != 0)
                {
                    IsSetGridValueChange = false;
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value = listObj[0].Rows[0]["salseDetailsId"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value = listObj[0].Rows[0]["salesOrderDetailsId"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value = listObj[0].Rows[0]["deliveryNoteDetailsId"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value = listObj[0].Rows[0]["salesQuotationDetailsId"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value = listObj[0].Rows[0]["productId"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceBrand"].Value = listObj[0].Rows[0]["brandName"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoicePurchaseRate"].Value = listObj[0].Rows[0]["purchaseRate"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceSalesRate"].Value = listObj[0].Rows[0]["salesRate"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceMrp"].Value = listObj[0].Rows[0]["Mrp"];
                    decimal decProductId = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value = listObj[0].Rows[0]["barcode"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value = listObj[0].Rows[0]["productCode"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value = listObj[0].Rows[0]["productName"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoicembUnitName"].Value = Convert.ToDecimal(listObj[0].Rows[0]["unitId"].ToString());
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value = listObj[0].Rows[0]["unitConversionId"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvcmbSalesInvoiceBatch"].Value = Convert.ToDecimal(listObj[0].Rows[0]["batchId"].ToString());
                    decimal decBatchId = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                    getProductRate(inRowIndex, decProductId, decBatchId);
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvcmbSalesInvoiceGodown"].Value = Convert.ToDecimal(listObj[0].Rows[0]["godownId"].ToString());
                    RackComboFill(Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString()), inRowIndex, dgvSalesInvoice.Rows[inRowIndex].Cells["dgvcmbSalesInvoiceRack"].ColumnIndex);
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvcmbSalesInvoiceRack"].Value = Convert.ToDecimal(listObj[0].Rows[0]["rackId"].ToString());
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = listObj[0].Rows[0]["discountPercent"].ToString();
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = listObj[0].Rows[0]["discount"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceNetAmount"].Value = listObj[0].Rows[0]["netvalue"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvcmbSalesInvoiceTaxName"].Value = listObj[0].Rows[0]["taxId"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceTaxAmount"].Value = listObj[0].Rows[0]["taxAmount"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceAmount"].Value = listObj[0].Rows[0]["amount"];
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceConversionRate"].Value = listObj[0].Rows[0]["conversionRate"];
                    GrossValueCalculation(inRowIndex);
                    DiscountCalculation(inRowIndex, 22);
                    DiscountCalculation(inRowIndex, 23);
                    taxAndGridTotalAmountCalculation(inRowIndex);
                    decCurrentRate = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                    decCurrentConversionRate = Convert.ToDecimal(listObj[0].Rows[0]["conversionRate"].ToString());
                    UnitConversionCalc(inRowIndex);
                    SiGridTotalAmountCalculation();
                    IsSetGridValueChange = true;
                }
                //else
                //{
                    //if (strProductCode != string.Empty)
                    //{
                    //    ProductDetailsFill(strProduct, inRowIndex, "ProductCode");
                    //}
                    else
                    {
                        if (dgvSalesInvoice.CurrentRow.Index < dgvSalesInvoice.RowCount - 1)
                        {
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceBrand"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceQty"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoicePurchaseRate"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceSalesRate"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceMrp"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceNetAmount"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceBrand"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceTaxAmount"].Value = string.Empty;
                            dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceAmount"].Value = string.Empty;
                            SerialNoforSalesInvoice();
                        }
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill the product name and the code for auto completeion
        /// </summary>
        /// <param name="isProductName"></param>
        /// <param name="editControl"></param>
        public void FillProducts(bool isProductName, DataGridViewTextBoxEditingControl editControl)
        {
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                List<DataTable> listObjProducts = new List<DataTable>();
                listObjProducts = BllProductCreation.ProductViewAll();
                ProductNames = new AutoCompleteStringCollection();
                ProductCodes = new AutoCompleteStringCollection();
                foreach (DataRow dr in listObjProducts[0].Rows)
                {
                    ProductNames.Add(dr["productName"].ToString());
                    ProductCodes.Add(dr["productCode"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To validation of Qty, Rate and Discount as Decimal values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvSalesInvoice.CurrentCell != null)
                {
                    if (dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceQty" || dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceRate" || dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceDiscountPercentage")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal va;idation in keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keypressevent(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// keypresseventforOther to make the cells as free
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void keypresseventforOther(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove Incomplete Rows From Grid while save or updation
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvSalesInvoice.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvSalesInvoice.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.HeaderCell.Value != null)
                        {
                            if (dgvrowCur.HeaderCell.Value.ToString() == "X" || dgvrowCur.Cells["dgvtxtSalesInvoiceProductName"].Value == null)
                            {
                                isOk = false;
                                if (inC == 0)
                                {
                                    strMessage = strMessage + Convert.ToString(dgvrowCur.Index + 1);
                                    inForFirst = dgvrowCur.Index;
                                    inC++;
                                }
                                else
                                {
                                    strMessage = strMessage + ", " + Convert.ToString(dgvrowCur.Index + 1);
                                }
                            }
                        }
                    }
                    inLastRow++;
                }
                inLastRow = 1;
                if (!isOk)
                {
                    strMessage = strMessage + " contains invalid entries. Do you want to continue?";
                    if (MessageBox.Show(strMessage, "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvSalesInvoice.Rows.Count; inK++)
                        {
                            if (dgvSalesInvoice.Rows[inK].HeaderCell.Value != null && dgvSalesInvoice.Rows[inK].HeaderCell.Value.ToString() == "X")
                            {
                                if (!dgvSalesInvoice.Rows[inK].IsNewRow)
                                {
                                    dgvSalesInvoice.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvSalesInvoice.Rows[inForFirst].Cells["dgvtxtSalesInvoiceProductName"].Selected = true;
                        dgvSalesInvoice.CurrentCell = dgvSalesInvoice.Rows[inForFirst].Cells["dgvtxtSalesInvoiceProductName"];
                        dgvSalesInvoice.Focus();
                    }
                }
                SerialNoforSalesInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Remove Incomplete Rows From AdditionalCost Grid While save or update
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromAdditionalCostGrid()
        {
            bool isOk = true;
            try
            {
                int inRowcount = dgvSalesInvoiceLedger.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvSalesInvoiceLedger.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.HeaderCell.Value != null)
                        {
                            if (dgvrowCur.HeaderCell.Value.ToString() == "X" || dgvrowCur.Cells["dgvCmbAdditionalCostledgerName"].Value == null)
                            {
                                isOk = false;
                                for (int inK = 0; inK < dgvSalesInvoiceLedger.Rows.Count; inK++)
                                {
                                    if (dgvSalesInvoiceLedger.Rows[inK].HeaderCell.Value != null && dgvSalesInvoiceLedger.Rows[inK].HeaderCell.Value.ToString() == "X")
                                    {
                                        if (!dgvSalesInvoiceLedger.Rows[inK].IsNewRow)
                                        {
                                            dgvSalesInvoiceLedger.Rows.RemoveAt(inK);
                                            inK--;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                SerialNoforSalesInvoiceAccountLedger();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 66" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// To get Total Net Amount For LedgerPosting 
        /// </summary>
        /// <returns></returns>
        public decimal TotalNetAmountForLedgerPosting()
        {
            decimal decNetAmount = 0;
            try
            {
                foreach (DataGridViewRow dgvrow in dgvSalesInvoice.Rows)
                {
                    if (dgvrow.Cells["dgvtxtSalesInvoiceProductId"].Value != null)
                    {
                        if (dgvrow.Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty)
                        {
                            decNetAmount = decNetAmount + Convert.ToDecimal(dgvrow.Cells["dgvtxtSalesInvoiceNetAmount"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decNetAmount;
        }
        /// <summary>
        ///  Save or edit function to checking the negative stock status
        /// </summary>
        public void SaveOrEditFunction()
        {
            try
            {
                decimal decProductId = 0;
                decimal decBatchId = 0;
                decimal decCalcQty = 0;
                StockPostingBll BllStockPosting = new StockPostingBll();
                SettingsBll BllSettings = new SettingsBll();
                string strStatus = BllSettings.SettingsStatusCheck("NegativeStockStatus");
                bool isNegativeLedger = false;
                int inRowCount = dgvSalesInvoice.RowCount;
                for (int i = 0; i < inRowCount - 1; i++)
                {
                    if (dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductId"].Value != null && dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty)
                    {
                        decProductId = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                        if (dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceBatch"].Value != null && dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString() != string.Empty)
                        {
                            decBatchId = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                        }
                        decimal decCurrentStock = BllStockPosting.StockCheckForProductSale(decProductId, decBatchId);
                        if (dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                        {
                            decCalcQty = decCurrentStock - Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                        }
                        if (decCalcQty < 0)
                        {
                            isNegativeLedger = true;
                            break;
                        }
                    }
                }
                if (isNegativeLedger)
                {
                    if (strStatus == "Warn")
                    {
                        if (MessageBox.Show("Negative Stock balance exists,Do you want to Continue", "Open miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            SaveOrEdit();
                        }
                    }
                    else if (strStatus == "Block")
                    {
                        MessageBox.Show("Cannot continue ,due to negative stock balance", "Open miracle", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        SaveOrEdit();
                    }
                }
                else
                {
                    SaveOrEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI : 68" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save or edit function checking the invalid entries of Form
        /// </summary>
        public void SaveOrEdit()
        {
            decimal decEdit = 0;
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            try
            {
                dgvSalesInvoice.ClearSelection();
                int inRow = dgvSalesInvoice.RowCount;
                if (txtInvoiceNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number");
                    txtInvoiceNo.Focus();
                }
                else if (BllSalesInvoice.SalesInvoiceInvoiceNumberCheckExistence(txtInvoiceNo.Text.Trim(), 0, DecSalesInvoiceVoucherTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Invoice number already exist");
                    txtInvoiceNo.Focus();
                }
                else if (txtDate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select a date in between financial year");
                    txtDate.Focus();
                }
                else if (cmbCashOrParty.SelectedValue == null)
                {
                    Messages.InformationMessage("Select Cash/Party");
                    cmbCashOrParty.Focus();
                }
                else if (cmbCurrency.SelectedValue == null)
                {
                    Messages.InformationMessage("Select Currency");
                    cmbCurrency.Focus();
                }
                else if (cmbSalesMode.SelectedText == "NA" && cmbSalesModeOrderNo.SelectedValue == null)
                {
                    Messages.InformationMessage("Select a Order No");
                    cmbSalesModeOrderNo.Focus();
                }
                else if (cmbSalesAccount.SelectedValue == null)
                {
                    Messages.InformationMessage("Select SalesAccount");
                    cmbSalesAccount.Focus();
                }
                else if (cmbSalesMan.SelectedValue == null)
                {
                    Messages.InformationMessage("Select SalesMan");
                    cmbSalesMan.Focus();
                }
                else if (txtDate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select Credit period");
                    txtCreditPeriod.Focus();
                }
                else if (inRow - 1 == 0 || dgvSalesInvoice.Rows[0].Cells["dgvtxtSalesInvoiceProductId"].Value as string == string.Empty)
                {
                    Messages.InformationMessage("Can't save Sales Invoice without atleast one product with complete details");
                    dgvSalesInvoice.Focus();
                }
                else
                {
                    if (RemoveIncompleteRowsFromGrid())
                    {
                        if (dgvSalesInvoice.Rows[0].Cells["dgvtxtSalesInvoiceProductName"].Value == null && dgvSalesInvoice.Rows[0].Cells["dgvtxtSalesInvoiceQty"].Value == null)
                        {
                            MessageBox.Show("Can't save Sales Invoice without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSalesInvoice.ClearSelection();
                            dgvSalesInvoice.Focus();
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                if (dgvSalesInvoice.Rows[0].Cells["dgvtxtSalesInvoiceProductName"].Value == null)
                                {
                                    MessageBox.Show("Can't save Sales Invoice without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvSalesInvoice.ClearSelection();
                                    dgvSalesInvoice.Focus();
                                }
                                else
                                {
                                    if (PublicVariables.isMessageAdd)
                                    {
                                        if (Messages.SaveMessage())
                                        {
                                            RemoveIncompleteRowsFromAdditionalCostGrid();
                                            SaveFunction();
                                        }
                                    }
                                    else
                                    {
                                        RemoveIncompleteRowsFromAdditionalCostGrid();
                                        SaveFunction();
                                    }
                                }
                            }
                            if (btnSave.Text == "Update")
                            {
                                if (QuantityCheckWithReference() == 1 && PartyBalanceCheckWithReference() == 1)
                                {
                                    if (dgvSalesInvoice.Rows[0].Cells["dgvtxtSalesInvoiceProductName"].Value == null)
                                    {
                                        MessageBox.Show("Can't Edit Sales Invoice without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvSalesInvoice.ClearSelection();
                                        dgvSalesInvoice.Focus();
                                    }
                                    else if (decEdit == 1)
                                    {
                                        MessageBox.Show("Can't Edit SalesInvoice with Invalid Quantity", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvSalesInvoice.ClearSelection();
                                        dgvSalesInvoice.Focus();
                                    }
                                    else
                                    {
                                        if (PublicVariables.isMessageEdit)
                                        {
                                            if (Messages.UpdateMessage())
                                            {
                                                EditFunction();
                                            }
                                        }
                                        else
                                        {
                                            EditFunction();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 69" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check quantity with reference
        /// </summary>
        /// <returns></returns>
        public int QuantityCheckWithReference()
        {
            decimal decQtySalesInvoice = 0;
            decimal decQtySalesReturn = 0;
            int inRef = 0;
            int inF1 = 1;
            decimal decSalesDetailsId = 0;
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            try
            {
                foreach (DataGridViewRow dgvrow in dgvSalesInvoice.Rows)
                {
                    if (dgvrow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value != null)
                    {
                        if (dgvrow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() != "0" || dgvrow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() != string.Empty)
                        {
                            decSalesDetailsId = Convert.ToDecimal(dgvrow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString());
                            inRef = BllSalesInvoice.SalseMasterReferenceCheck(decSalesInvoiceIdToEdit, decSalesDetailsId);
                            if (inRef == 1)
                            {
                                if (inF1 == 1)
                                {
                                    if (dgvrow.Cells["dgvtxtSalesInvoiceQty"].Value != null)
                                    {
                                        if (dgvrow.Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != "0" && dgvrow.Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                                        {
                                            decQtySalesInvoice = Convert.ToDecimal(dgvrow.Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                                            decQtySalesReturn = Math.Round(BllSalesInvoice.SalesReturnDetailsQtyViewBySalesDetailsId(decSalesDetailsId), PublicVariables._inNoOfDecimalPlaces);
                                            if (decQtySalesInvoice >= decQtySalesReturn)
                                            {
                                                inF1 = 1;
                                            }
                                            else
                                            {
                                                inF1 = 0;
                                                Messages.InformationMessage("Quantity in row " + (dgvrow.Index + 1) + " should be greater than " + decQtySalesReturn);
                                            }
                                        }
                                        else
                                        {
                                            inF1 = 0;
                                            Messages.InformationMessage("Quantity in row " + (dgvrow.Index + 1) + " should be greater than " + decQtySalesReturn);
                                        }
                                    }
                                    else
                                    {
                                        inF1 = 0;
                                        Messages.InformationMessage("Quantity in row " + (dgvrow.Index + 1) + " should be greater than " + decQtySalesReturn);
                                    }
                                }
                            }
                            else
                            {
                                inF1 = 1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inF1;
        }

        public int PartyBalanceCheckWithReference()
        {
            int inF1 = 0;
            decimal decPartyBalanceAmount = 0;
            decimal decGrandTotal = 0;
            try
            {
                bool isRef = false;
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                isRef = bllAccountLedger.PartyBalanceAgainstReferenceCheck(strVoucherNo, DecSalesInvoiceVoucherTypeId);
                if (isRef)
                {
                    decPartyBalanceAmount = BllPartyBalance.PartyBalanceAmountViewForSalesInvoice(strVoucherNo, DecSalesInvoiceVoucherTypeId, "Against");
                    decGrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                    if (decGrandTotal >= decPartyBalanceAmount)
                    {
                        inF1 = 1;
                    }
                    else
                    {
                        inF1 = 0;
                        Messages.InformationMessage("There is a Receipt voucher against this invoice so grand total should not be less than " + decPartyBalanceAmount);
                    }
                }
                else
                {
                    inF1 = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inF1;
        }

        /// <summary>
        ///  Save function
        /// </summary>
        public void SaveFunction()
        {
            StockPostingInfo infoStockPosting = new StockPostingInfo();
            SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
            SalesDetailsInfo InfoSalesDetails = new SalesDetailsInfo();
            StockPostingBll BllStockPosting = new StockPostingBll();
            AdditionalCostInfo infoAdditionalCost = new AdditionalCostInfo();
            AditionalCostBll bllAditionalCost = new AditionalCostBll();
            SalesBillTaxInfo infoSalesBillTax = new SalesBillTaxInfo();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
            try
            {
                InfoSalesMaster.AdditionalCost = Convert.ToDecimal(lblLedgerTotalAmount.Text);
                InfoSalesMaster.BillDiscount = Convert.ToDecimal(txtBillDiscount.Text.Trim());
                InfoSalesMaster.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text.Trim().ToString());
                InfoSalesMaster.CustomerName = txtCustomer.Text.Trim();
                InfoSalesMaster.Date = Convert.ToDateTime(txtDate.Text.ToString());
                InfoSalesMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                InfoSalesMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                InfoSalesMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoSalesMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                InfoSalesMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                InfoSalesMaster.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                if (isAutomatic)
                {
                    InfoSalesMaster.InvoiceNo = txtInvoiceNo.Text.Trim();
                    InfoSalesMaster.VoucherNo = strVoucherNo;
                    InfoSalesMaster.SuffixPrefixId = decSalseInvoiceSuffixPrefixId;
                }
                else
                {
                    InfoSalesMaster.InvoiceNo = txtInvoiceNo.Text.Trim();
                    InfoSalesMaster.VoucherNo = strVoucherNo;
                    InfoSalesMaster.SuffixPrefixId = 0;
                }
                if (cmbSalesMode.Text == "Against SalesOrder")
                {
                    InfoSalesMaster.OrderMasterId = Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.OrderMasterId = 0;
                }
                if (cmbSalesMode.Text == "Against Delivery Note")
                {
                    InfoSalesMaster.DeliveryNoteMasterId = Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.DeliveryNoteMasterId = 0;
                }
                if (cmbSalesMode.Text == "Against Quotation")
                {
                    InfoSalesMaster.QuotationMasterId = Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.QuotationMasterId = 0;
                }
                InfoSalesMaster.Narration = txtNarration.Text.Trim();
                InfoSalesMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                InfoSalesMaster.SalesAccount = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                InfoSalesMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text.Trim());
                if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                {
                    InfoSalesMaster.TaxAmount = Convert.ToDecimal(lblTaxTotalAmount.Text.Trim());
                }
                else
                {
                    InfoSalesMaster.TaxAmount = 0;
                }
                InfoSalesMaster.UserId = PublicVariables._decCurrentUserId;
                InfoSalesMaster.LrNo = txtVehicleNo.Text;
                InfoSalesMaster.TransportationCompany = txtTransportCompany.Text.Trim();
                InfoSalesMaster.POS = false;
                InfoSalesMaster.CounterId = 0;
                InfoSalesMaster.ExtraDate = DateTime.Now;
                InfoSalesMaster.Extra1 = string.Empty;
                InfoSalesMaster.Extra2 = string.Empty;
                decimal decSalesMasterId = BllSalesInvoice.SalesMasterAdd(InfoSalesMaster);
                int inRowCount = dgvSalesInvoice.RowCount;
                InfoSalesDetails.SalesMasterId = decSalesMasterId;
                InfoSalesDetails.ExtraDate = DateTime.Now;
                InfoSalesDetails.Extra1 = string.Empty;
                InfoSalesDetails.Extra2 = string.Empty;
                string strAgainstInvoiceN0 = txtInvoiceNo.Text.Trim();
                for (int inI = 0; inI < inRowCount - 1; inI++)
                {
                    if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty)
                    {
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                        {
                            if (cmbSalesMode.Text == "Against SalesOrder")
                            {
                                InfoSalesDetails.OrderDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString());
                            }
                            else
                            {
                                InfoSalesDetails.OrderDetailsId = 0;
                            }
                            if (cmbSalesMode.Text == "Against Delivery Note")
                            {
                                InfoSalesDetails.DeliveryNoteDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString());
                            }
                            else
                            {
                                InfoSalesDetails.DeliveryNoteDetailsId = 0;
                            }
                            if (cmbSalesMode.Text == "Against Quotation")
                            {
                                InfoSalesDetails.QuotationDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString());
                            }
                            else
                            {
                                InfoSalesDetails.QuotationDetailsId = 0;
                            }
                            InfoSalesDetails.SlNo = Convert.ToInt32(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceSlno"].Value.ToString());
                            InfoSalesDetails.ProductId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                            InfoSalesDetails.Qty = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                            InfoSalesDetails.Rate = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                            InfoSalesDetails.UnitId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoicembUnitName"].Value.ToString());
                            InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value.ToString());
                            InfoSalesDetails.Discount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                            InfoSalesDetails.BatchId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                            if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString() != string.Empty)
                            {
                                InfoSalesDetails.GodownId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString());
                            }
                            else
                            {
                                InfoSalesDetails.GodownId = 0;
                            }
                            if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString() != string.Empty)
                            {
                                InfoSalesDetails.RackId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString());
                            }
                            else
                            {
                                InfoSalesDetails.RackId = 0;
                            }
                            if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                            {
                                InfoSalesDetails.TaxId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString());
                                InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceTaxAmount"].Value.ToString());
                            }
                            else
                            {
                                InfoSalesDetails.TaxId = 1;
                                InfoSalesDetails.TaxAmount = 0;
                            }
                            InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString());
                            InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceNetAmount"].Value.ToString());
                            InfoSalesDetails.Amount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceAmount"].Value.ToString());
                            BllSalesInvoice.SalesDetailsAdd(InfoSalesDetails);
                            infoStockPosting.Date = Convert.ToDateTime(txtDate.Text.Trim().ToString());
                            infoStockPosting.ProductId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                            infoStockPosting.BatchId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                            infoStockPosting.UnitId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoicembUnitName"].Value.ToString());
                            if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString() != string.Empty)
                            {
                                infoStockPosting.GodownId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString());
                            }
                            else
                            {
                                infoStockPosting.GodownId = 0;
                            }
                            if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString() != string.Empty)
                            {
                                infoStockPosting.RackId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString());
                            }
                            else
                            {
                                infoStockPosting.RackId = 0;
                            }
                            infoStockPosting.Rate = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                            infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                            infoStockPosting.ExtraDate = DateTime.Now;
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                            if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value != null)
                            {
                                if (Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString()) != 0)
                                {
                                    infoStockPosting.InwardQty = InfoSalesDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(InfoSalesDetails.UnitConversionId);
                                    infoStockPosting.OutwardQty = 0;
                                    infoStockPosting.VoucherNo = strVoucherNoTostockPost;
                                    infoStockPosting.AgainstVoucherNo = strVoucherNo;
                                    infoStockPosting.InvoiceNo = strInvoiceNoTostockPost;
                                    infoStockPosting.AgainstInvoiceNo = strAgainstInvoiceN0;
                                    infoStockPosting.VoucherTypeId = decVouchertypeIdTostockPost;
                                    infoStockPosting.AgainstVoucherTypeId = DecSalesInvoiceVoucherTypeId;
                                    BllStockPosting.StockPostingAdd(infoStockPosting);
                                }
                            }
                            infoStockPosting.InwardQty = 0;
                            infoStockPosting.OutwardQty = InfoSalesDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(InfoSalesDetails.UnitConversionId);
                            infoStockPosting.VoucherNo = InfoSalesMaster.VoucherNo; ;
                            infoStockPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                            infoStockPosting.InvoiceNo = InfoSalesMaster.InvoiceNo;
                            infoStockPosting.AgainstInvoiceNo = "NA";
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                            BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                    }
                }
                if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                {
                    int inTaxRowCount = dgvSalesInvoiceTax.RowCount;
                    infoSalesBillTax.SalesMasterId = decSalesMasterId;
                    infoSalesBillTax.ExtraDate = DateTime.Now;
                    infoSalesBillTax.Extra1 = string.Empty;
                    infoSalesBillTax.Extra2 = string.Empty;
                    for (int inI = 0; inI < inTaxRowCount; inI++)
                    {
                        if (dgvSalesInvoiceTax.Rows[inI].Cells["dgvtxtTtaxId"].Value != null && dgvSalesInvoiceTax.Rows[inI].Cells["dgvtxtTtaxId"].Value.ToString() != string.Empty)
                        {
                            if (dgvSalesInvoiceTax.Rows[inI].Cells["dgvtxtTtaxAmount"].Value != null && dgvSalesInvoiceTax.Rows[inI].Cells["dgvtxtTtaxAmount"].Value.ToString() != string.Empty)
                            {
                                decimal decAmount = Convert.ToDecimal(dgvSalesInvoiceTax.Rows[inI].Cells["dgvtxtTtaxAmount"].Value);
                                if (decAmount > 0)
                                {
                                    infoSalesBillTax.TaxId = Convert.ToInt32(dgvSalesInvoiceTax.Rows[inI].Cells["dgvtxtTtaxId"].Value.ToString());
                                    infoSalesBillTax.TaxAmount = Convert.ToDecimal(dgvSalesInvoiceTax.Rows[inI].Cells["dgvtxtTtaxAmount"].Value.ToString());
                                    BllSalesInvoice.SalesBillTaxAdd(infoSalesBillTax);
                                }
                            }
                        }
                    }
                }
                int inAddRowCount = dgvSalesInvoiceLedger.RowCount;
                infoAdditionalCost.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                infoAdditionalCost.VoucherNo = strVoucherNo;
                infoAdditionalCost.ExtraDate = DateTime.Now;
                infoAdditionalCost.Extra1 = string.Empty;
                infoAdditionalCost.Extra2 = string.Empty;
                for (int inI = 0; inI < inAddRowCount; inI++)
                {
                    if (dgvSalesInvoiceLedger.Rows[inI].Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvSalesInvoiceLedger.Rows[inI].Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                    {
                        if (dgvSalesInvoiceLedger.Rows[inI].Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null && dgvSalesInvoiceLedger.Rows[inI].Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != string.Empty)
                        {
                            infoAdditionalCost.LedgerId = Convert.ToInt32(dgvSalesInvoiceLedger.Rows[inI].Cells["dgvCmbAdditionalCostledgerName"].Value.ToString());
                            if (!cmbCashOrbank.Visible)
                            {
                                infoAdditionalCost.Debit = 0;
                                infoAdditionalCost.Credit = Convert.ToDecimal(dgvSalesInvoiceLedger.Rows[inI].Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                            }
                            else
                            {
                                infoAdditionalCost.Debit = Convert.ToDecimal(dgvSalesInvoiceLedger.Rows[inI].Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                                infoAdditionalCost.Credit = 0;
                            }
                            bllAditionalCost.AdditionalCostAdd(infoAdditionalCost);
                        }
                    }
                }
                if (!cmbCashOrbank.Visible)
                {
                    decimal decCAshOrBankId = 0;
                    decCAshOrBankId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                    decimal decTotalAddAmount = Convert.ToDecimal(lblLedgerTotalAmount.Text.Trim().ToString());
                    if (decTotalAddAmount > 0)
                    {
                        infoAdditionalCost.Debit = decTotalAddAmount;
                        infoAdditionalCost.Credit = 0;
                        infoAdditionalCost.LedgerId = decCAshOrBankId;
                        infoAdditionalCost.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                        infoAdditionalCost.VoucherNo = strVoucherNo;
                        infoAdditionalCost.ExtraDate = DateTime.Now;
                        infoAdditionalCost.Extra1 = string.Empty;
                        infoAdditionalCost.Extra2 = string.Empty;
                        bllAditionalCost.AdditionalCostAdd(infoAdditionalCost);
                    }
                }
                else
                {
                    if (cmbCashOrbank.Visible)
                    {
                        decimal decCAshOrBankId = 0;
                        decCAshOrBankId = Convert.ToDecimal(cmbCashOrbank.SelectedValue.ToString());
                        decimal decTotalAddAmount = Convert.ToDecimal(lblLedgerTotalAmount.Text.Trim().ToString());
                        if (decTotalAddAmount > 0)
                        {
                            infoAdditionalCost.Debit = 0;
                            infoAdditionalCost.Credit = decTotalAddAmount;
                            infoAdditionalCost.LedgerId = decCAshOrBankId;
                            infoAdditionalCost.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                            infoAdditionalCost.VoucherNo = strVoucherNo;
                            infoAdditionalCost.ExtraDate = DateTime.Now;
                            infoAdditionalCost.Extra1 = string.Empty;
                            infoAdditionalCost.Extra2 = string.Empty;
                            bllAditionalCost.AdditionalCostAdd(infoAdditionalCost);
                        }
                    }
                }
                ledgerPostingAdd();
                if (BllSalesInvoice.SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString())))
                {
                    partyBalanceAdd();
                }
                Messages.SavedMessage();
                if (cbxPrintAfterSave.Checked == true)
                {
                    SettingsBll BllSettings = new SettingsBll();
                    if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(decSalesMasterId);
                    }
                    else
                    {
                        Print(decSalesMasterId);
                    }
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 70" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger posting save function
        /// </summary>
        public void ledgerPostingAdd()
        {
            LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
            SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
            LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            decimal decRate = 0;
            decimal decimalGrantTotal = 0;
            decimal decTotalAmount = 0;
            try
            {
                decimalGrantTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                decimalGrantTotal = decimalGrantTotal * decRate;
                infoLedgerPosting.Debit = decimalGrantTotal;
                infoLedgerPosting.Credit = 0;
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                decTotalAmount = TotalNetAmountForLedgerPosting();
                decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                decTotalAmount = decTotalAmount * decRate;
                infoLedgerPosting.Debit = 0;
                infoLedgerPosting.Credit = decTotalAmount;
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                decimal decBillDis = 0;
                decBillDis = Convert.ToDecimal(txtBillDiscount.Text.Trim().ToString());
                decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                decBillDis = decBillDis * decRate;
                if (decBillDis > 0)
                {
                    infoLedgerPosting.Debit = decBillDis;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                    infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                    infoLedgerPosting.LedgerId = 8;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }
                if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                {
                    foreach (DataGridViewRow dgvrow in dgvSalesInvoiceTax.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtTtaxId"].Value != null && dgvrow.Cells["dgvtxtTtaxId"].Value.ToString() != string.Empty)
                        {
                            decimal decTaxAmount = 0;
                            decTaxAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtTtaxAmount"].Value.ToString());
                            decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decTaxAmount = decTaxAmount * decRate;
                            if (decTaxAmount > 0)
                            {
                                infoLedgerPosting.Debit = 0;
                                infoLedgerPosting.Credit = decTaxAmount;
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvtxtTaxLedgerId"].Value.ToString());
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.DetailsId = 0;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                            }
                        }
                    }
                }
                if (cmbCashOrbank.Visible)
                {
                    foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                    {
                        if (dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                        {
                            decimal decAmount = 0;
                            decAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                            decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decAmount = decAmount * decRate;
                            if (decAmount > 0)
                            {
                                infoLedgerPosting.Debit = decAmount;
                                infoLedgerPosting.Credit = 0;
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString());
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.DetailsId = 0;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                            }
                        }
                    }
                    decimal decBankOrCashId = 0;
                    decBankOrCashId = Convert.ToDecimal(cmbCashOrbank.SelectedValue.ToString());
                    decimal decAmountForCr = 0;
                    decAmountForCr = Convert.ToDecimal(lblLedgerTotalAmount.Text.ToString());
                    decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                    decAmountForCr = decAmountForCr * decRate;
                    if (decAmountForCr > 0)
                    {
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = decAmountForCr;
                        infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                        infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                        infoLedgerPosting.VoucherNo = strVoucherNo;
                        infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                        infoLedgerPosting.LedgerId = decBankOrCashId;
                        infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                        infoLedgerPosting.DetailsId = 0;
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                        infoLedgerPosting.Extra1 = "AddCash";
                        infoLedgerPosting.Extra2 = string.Empty;
                        BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    }
                }
                else
                {
                    foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                    {
                        if (dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                        {
                            decimal decAmount = 0;
                            decAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                            decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decAmount = decAmount * decRate;
                            if (decAmount > 0)
                            {
                                infoLedgerPosting.Debit = 0;
                                infoLedgerPosting.Credit = decAmount;
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString());
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.DetailsId = 0;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 71" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Party balance save function
        /// </summary>
        public void partyBalanceAdd()
        {
            PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
            SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
            PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
            try
            {
                infoPartyBalance.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoPartyBalance.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoPartyBalance.VoucherNo = strVoucherNo;
                infoPartyBalance.InvoiceNo = txtInvoiceNo.Text.Trim();
                infoPartyBalance.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                infoPartyBalance.AgainstVoucherTypeId = 0;
                infoPartyBalance.AgainstVoucherNo = "0";
                infoPartyBalance.AgainstInvoiceNo = "0";
                infoPartyBalance.ReferenceType = "New";
                infoPartyBalance.Debit = Convert.ToDecimal(txtGrandTotal.Text.Trim().ToString());
                infoPartyBalance.Credit = 0;
                infoPartyBalance.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text.ToString());
                infoPartyBalance.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPartyBalance.ExtraDate = DateTime.Now;
                infoPartyBalance.Extra1 = string.Empty;
                infoPartyBalance.Extra2 = string.Empty;
                BllPartyBalance.PartyBalanceAdd(infoPartyBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 72" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Print function in crystal report
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        public void Print(decimal decSalesMasterId)
        {
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
            try
            {
                DataSet dsSalesInvoice = BllSalesInvoice.salesInvoicePrintAfterSave(decSalesMasterId, 1, InfoSalesMaster.OrderMasterId, InfoSalesMaster.DeliveryNoteMasterId, InfoSalesMaster.QuotationMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.SalesInvoicePrinting(dsSalesInvoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 73" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Print function for dotmatrix printer
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        public void PrintForDotMatrix(decimal decSalesMasterId)
        {
            try
            {
                DataTable dtblOtherDetails = new DataTable();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                dtblOtherDetails = bllCompanyCreation.CompanyViewForDotMatrix();
                DataTable dtblGridDetails = new DataTable();
                dtblGridDetails.Columns.Add("SlNo");
                dtblGridDetails.Columns.Add("BarCode");
                dtblGridDetails.Columns.Add("ProductCode");
                dtblGridDetails.Columns.Add("ProductName");
                dtblGridDetails.Columns.Add("Qty");
                dtblGridDetails.Columns.Add("Unit");
                dtblGridDetails.Columns.Add("Godown");
                dtblGridDetails.Columns.Add("Brand");
                dtblGridDetails.Columns.Add("Tax");
                dtblGridDetails.Columns.Add("TaxAmount");
                dtblGridDetails.Columns.Add("NetAmount");
                dtblGridDetails.Columns.Add("DiscountAmount");
                dtblGridDetails.Columns.Add("DiscountPercentage");
                dtblGridDetails.Columns.Add("SalesRate");
                dtblGridDetails.Columns.Add("PurchaseRate");
                dtblGridDetails.Columns.Add("MRP");
                dtblGridDetails.Columns.Add("Rack");
                dtblGridDetails.Columns.Add("Batch");
                dtblGridDetails.Columns.Add("Rate");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvSalesInvoice.Rows)
                {
                    if (!dRow.IsNewRow)
                    {
                        DataRow dr = dtblGridDetails.NewRow();
                        dr["SlNo"] = ++inRowCount;
                        if (dRow.Cells["dgvtxtSalesInvoiceBarcode"].Value != null)
                        {
                            dr["BarCode"] = dRow.Cells["dgvtxtSalesInvoiceBarcode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceProductCode"].Value != null)
                        {
                            dr["ProductCode"] = dRow.Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceProductName"].Value != null)
                        {
                            dr["ProductName"] = dRow.Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceQty"].Value != null)
                        {
                            dr["Qty"] = dRow.Cells["dgvtxtSalesInvoiceQty"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoicembUnitName"].Value != null)
                        {
                            dr["Unit"] = dRow.Cells["dgvtxtSalesInvoicembUnitName"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbSalesInvoiceGodown"].Value != null)
                        {
                            dr["Godown"] = dRow.Cells["dgvcmbSalesInvoiceGodown"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbSalesInvoiceRack"].Value != null)
                        {
                            dr["Rack"] = dRow.Cells["dgvcmbSalesInvoiceRack"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbSalesInvoiceBatch"].Value != null)
                        {
                            dr["Batch"] = dRow.Cells["dgvcmbSalesInvoiceBatch"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceRate"].Value != null)
                        {
                            dr["Rate"] = dRow.Cells["dgvtxtSalesInvoiceRate"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceAmount"].Value != null)
                        {
                            dr["Amount"] = dRow.Cells["dgvtxtSalesInvoiceAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvcmbSalesInvoiceTaxName"].Value != null)
                        {
                            dr["Tax"] = dRow.Cells["dgvcmbSalesInvoiceTaxName"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceBrand"].Value != null)
                        {
                            dr["Brand"] = dRow.Cells["dgvtxtSalesInvoiceBrand"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceTaxAmount"].Value != null)
                        {
                            dr["TaxAmount"] = dRow.Cells["dgvtxtSalesInvoiceTaxAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceNetAmount"].Value != null)
                        {
                            dr["NetAmount"] = dRow.Cells["dgvtxtSalesInvoiceNetAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceDiscountAmount"].Value != null)
                        {
                            dr["DiscountAmount"] = dRow.Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value != null)
                        {
                            dr["DiscountPercentage"] = dRow.Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceSalesRate"].Value != null)
                        {
                            dr["SalesRate"] = dRow.Cells["dgvtxtSalesInvoiceSalesRate"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoicePurchaseRate"].Value != null)
                        {
                            dr["PurchaseRate"] = dRow.Cells["dgvtxtSalesInvoicePurchaseRate"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtSalesInvoiceMrp"].Value != null)
                        {
                            dr["MRP"] = dRow.Cells["dgvtxtSalesInvoiceMrp"].Value.ToString();
                        }
                        dtblGridDetails.Rows.Add(dr);
                    }
                }
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("SalesMode");
                dtblOtherDetails.Columns.Add("SalesAccount");
                dtblOtherDetails.Columns.Add("SalesMan");
                dtblOtherDetails.Columns.Add("CreditPeriod");
                dtblOtherDetails.Columns.Add("VoucherType");
                dtblOtherDetails.Columns.Add("PricingLevel");
                dtblOtherDetails.Columns.Add("Customer");
                dtblOtherDetails.Columns.Add("CustomerAddress");
                dtblOtherDetails.Columns.Add("CustomerTIN");
                dtblOtherDetails.Columns.Add("CustomerCST");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("BillDiscount");
                dtblOtherDetails.Columns.Add("GrandTotal");
                dtblOtherDetails.Columns.Add("AmountInWords");
                dtblOtherDetails.Columns.Add("Declaration");
                dtblOtherDetails.Columns.Add("Heading1");
                dtblOtherDetails.Columns.Add("Heading2");
                dtblOtherDetails.Columns.Add("Heading3");
                dtblOtherDetails.Columns.Add("Heading4");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["voucherNo"] = txtInvoiceNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["SalesMode"] = cmbSalesMode.Text;
                dRowOther["SalesAccount"] = cmbSalesAccount.Text;
                dRowOther["SalesMan"] = cmbSalesMan.SelectedText;
                dRowOther["CreditPeriod"] = (txtCreditPeriod.Text) + " Days";
                dRowOther["PricingLevel"] = cmbPricingLevel.Text;
                dRowOther["Customer"] = txtCustomer.Text;
                dRowOther["BillDiscount"] = txtBillDiscount.Text;
                dRowOther["GrandTotal"] = txtGrandTotal.Text;
                dRowOther["TotalAmount"] = txtTotalAmount.Text;
                dRowOther["VoucherType"] = cmbVoucherType.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtGrandTotal.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(DecSalesInvoiceVoucherTypeId);
                dRowOther["Declaration"] = dtblDeclaration.Rows[0]["Declaration"].ToString();
                dRowOther["Heading1"] = dtblDeclaration.Rows[0]["Heading1"].ToString();
                dRowOther["Heading2"] = dtblDeclaration.Rows[0]["Heading2"].ToString();
                dRowOther["Heading3"] = dtblDeclaration.Rows[0]["Heading3"].ToString();
                dRowOther["Heading4"] = dtblDeclaration.Rows[0]["Heading4"].ToString();
                int inFormId = BllVoucherType.FormIdGetForPrinterSettings(Convert.ToInt32(dtblDeclaration.Rows[0]["masterId"].ToString()));
                PrintWorks.DotMatrixPrint.PrintDesign(inFormId, dtblOtherDetails, dtblGridDetails, dtblOtherDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 74" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmSalesInvoiceRegister to view details and for updation
        /// </summary>
        /// <param name="frmSalesinvoiceRegister"></param>
        /// <param name="decSalesinvoiceMasterId"></param>
        public void CallFromSalesInvoiceRegister(frmSalesInvoiceRegister frmSalesinvoiceRegister, decimal decSalesinvoiceMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                this.frmSalesinvoiceRegisterObj = frmSalesinvoiceRegister;
                decSalesInvoiceIdToEdit = decSalesinvoiceMasterId;
                frmSalesinvoiceRegisterObj.Enabled = false;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 75" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesReport to view details and for updation
        /// </summary>
        /// <param name="frmSalesinvoiceReport"></param>
        /// <param name="decSalesinvoiceMasterId"></param>
        public void CallFromSalesInvoiceReport(frmSalesReport frmSalesinvoiceReport, decimal decSalesinvoiceMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                this.frmSalesReportObj = frmSalesinvoiceReport;
                decSalesInvoiceIdToEdit = decSalesinvoiceMasterId;
                frmSalesReportObj.Enabled = false;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 76" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill function from coming from register or report or other forms
        /// </summary>
        public void FillRegisterOrReport()
        {
            //SalesMasterSP spSalesMaster = new SalesMasterSP();
            //SalesDetailsSP spSalesDetails = new SalesDetailsSP();
            VoucherTypeBll BllVoucherType = new VoucherTypeBll();
            //SalesBillTaxSP spSalesBillTax = new SalesBillTaxSP();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            try
            {
                isFromEditMode = true;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtInvoiceNo.ReadOnly = true;
                List<DataTable> listMaster = BllSalesInvoice.SalesInvoiceSalesMasterViewBySalesMasterId(decSalesInvoiceIdToEdit);
                DecSalesInvoiceVoucherTypeId = Convert.ToDecimal(listMaster[0].Rows[0]["voucherTypeId"].ToString());
                VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                infoVoucherType = BllVoucherType.VoucherTypeView(DecSalesInvoiceVoucherTypeId);
                this.Text = infoVoucherType.VoucherTypeName;
                txtDate.Text = listMaster[0].Rows[0]["date"].ToString();
                dtpDate.Value = DateTime.Parse(txtDate.Text);
                CurrencyComboFill();
                txtInvoiceNo.Text = listMaster[0].Rows[0]["invoiceNo"].ToString();
                txtCreditPeriod.Text = listMaster[0].Rows[0]["creditPeriod"].ToString();
                strVoucherNo = listMaster[0].Rows[0]["voucherNo"].ToString();
                decSalseInvoiceSuffixPrefixId = Convert.ToDecimal(listMaster[0].Rows[0]["suffixPrefixId"].ToString());
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(DecSalesInvoiceVoucherTypeId);
                cmbCashOrParty.SelectedValue = listMaster[0].Rows[0]["ledgerId"].ToString();
                cmbSalesAccount.SelectedValue = listMaster[0].Rows[0]["salesAccount"].ToString();
                cmbSalesMan.SelectedValue = listMaster[0].Rows[0]["employeeId"].ToString();
                txtCustomer.Text = listMaster[0].Rows[0]["customerName"].ToString();
                txtTransportCompany.Text = listMaster[0].Rows[0]["transportationCompany"].ToString();
                txtVehicleNo.Text = listMaster[0].Rows[0]["lrNo"].ToString();
                txtNarration.Text = listMaster[0].Rows[0]["narration"].ToString();
                cmbCurrency.SelectedValue = Convert.ToDecimal(listMaster[0].Rows[0]["exchangeRateId"].ToString());
                txtTotalAmount.Text = listMaster[0].Rows[0]["totalAmount"].ToString();
                lblTaxTotalAmount.Text = listMaster[0].Rows[0]["taxAmount"].ToString();
                cmbPricingLevel.SelectedValue = Convert.ToDecimal(listMaster[0].Rows[0]["pricingLevelId"].ToString());
                if (listMaster[0].Rows[0]["quotationMasterId"].ToString() != "0")
                {
                    cmbSalesMode.Text = "Against Quotation";
                    againstOrderComboFill();
                    cmbSalesModeOrderNo.SelectedValue = listMaster[0].Rows[0]["quotationMasterId"].ToString();
                    lblSalesModeOrderNo.Text = "Quotation No";
                    cmbCurrency.Enabled = false;
                    cmbPricingLevel.Enabled = false;
                }
                else if (listMaster[0].Rows[0]["orderMasterId"].ToString() != "0")
                {
                    cmbSalesMode.Text = "Against SalesOrder";
                    againstOrderComboFill();
                    cmbSalesModeOrderNo.SelectedValue = listMaster[0].Rows[0]["orderMasterId"].ToString();
                    lblSalesModeOrderNo.Text = "Order No";
                    cmbCurrency.Enabled = false;
                    cmbPricingLevel.Enabled = false;
                }
                else if (listMaster[0].Rows[0]["deliveryNoteMasterId"].ToString() != "0")
                {
                    cmbSalesMode.Text = "Against Delivery Note";
                    againstOrderComboFill();
                    cmbSalesModeOrderNo.SelectedValue = listMaster[0].Rows[0]["deliveryNoteMasterId"].ToString();
                    lblSalesModeOrderNo.Text = "Delivery Note No";
                    cmbCurrency.Enabled = false;
                    cmbPricingLevel.Enabled = false;
                }
                else
                {
                    cmbSalesMode.SelectedText = "NA";
                }
                if (txtInvoiceNo.Enabled)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtInvoiceNo.Focus();
                }
                //DataTable dtblDetails = new DataTable();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllSalesInvoice.SalesInvoiceSalesDetailsViewBySalesMasterId(decSalesInvoiceIdToEdit);
                dgvSalesInvoiceTaxComboFill();
                dgvSalesInvoice.Rows.Clear();
                for (int i = 0; i < listObj[0].Rows.Count; i++)
                {
                    dgvSalesInvoice.Rows.Add();
                    IsSetGridValueChange = false;
                    dgvSalesInvoice.Rows[i].HeaderCell.Value = string.Empty;
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value = Convert.ToDecimal(listObj[0].Rows[i]["salesDetailsId"].ToString());
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSlno"].Value = listObj[0].Rows[i]["slNo"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceBarcode"].Value = listObj[0].Rows[i]["barcode"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductCode"].Value = listObj[0].Rows[i]["productCode"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductName"].Value = listObj[0].Rows[i]["productName"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductId"].Value = listObj[0].Rows[i]["productId"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceBrand"].Value = listObj[0].Rows[i]["brandName"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceQty"].Value = listObj[0].Rows[i]["qty"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoicePurchaseRate"].Value = listObj[0].Rows[i]["purchaseRate"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceAmount"].Value = listObj[0].Rows[i]["amount"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceGrossValue"].Value = listObj[0].Rows[i]["grossAmount"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoicembUnitName"].Value = Convert.ToDecimal(listObj[0].Rows[i]["unitId"].ToString());
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceRate"].Value = listObj[0].Rows[i]["rate"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceGodown"].Value = Convert.ToDecimal(listObj[0].Rows[i]["godownId"].ToString());
                    RackComboFill(Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString()), i, dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceRack"].ColumnIndex);
                    dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceRack"].Value = Convert.ToDecimal(listObj[0].Rows[i]["rackId"].ToString());
                    if (listObj[0].Rows[i]["batchId"] != null && listObj[0].Rows[i]["batchId"].ToString() != string.Empty)
                    {
                        dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceBatch"].Value = Convert.ToDecimal(listObj[0].Rows[i]["batchId"].ToString());
                    }
                    else
                    {
                        dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceBatch"].Value = string.Empty;
                    }
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceMrp"].Value = listObj[0].Rows[i]["mrp"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceSalesRate"].Value = listObj[0].Rows[i]["salesRate"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = listObj[0].Rows[i]["discount"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceNetAmount"].Value = listObj[0].Rows[i]["netAmount"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceTaxName"].Value = Convert.ToDecimal(listObj[0].Rows[i]["taxId"].ToString());
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceTaxAmount"].Value = listObj[0].Rows[i]["taxAmount"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value = listObj[0].Rows[i]["unitConversionId"].ToString();
                    lblTotalQuantitydisplay.Text = listObj[0].Rows[i]["qty"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSISalesOrderDetailsId"].Value = Convert.ToDecimal(listObj[0].Rows[i]["orderDetailsId"].ToString());  // here get fill the grid colum for the editing prps
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value = listObj[0].Rows[i]["deliveryNoteDetailsId"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value = listObj[0].Rows[i]["quotationDetailsId"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value = Convert.ToDecimal(listObj[0].Rows[i]["voucherTypeRefNo"].ToString());  // here get fill the grid colum for the editing prps
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceVoucherNo"].Value = listObj[0].Rows[i]["voucherRefNo"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value = listObj[0].Rows[i]["invoiceRefNo"].ToString();
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceBarcode"].ReadOnly = true;
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductCode"].ReadOnly = true;
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceProductName"].ReadOnly = true;
                    dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceBrand"].ReadOnly = true;
                    dgvSalesInvoice.Rows[i].Cells["dgvcmbSalesInvoiceBatch"].ReadOnly = true;
                    if (cmbSalesMode.SelectedIndex != 0)
                    {
                        strVoucherNoTostockPost = dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceVoucherNo"].Value.ToString();
                        strInvoiceNoTostockPost = dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceInvoiceNo"].Value.ToString();
                        decVouchertypeIdTostockPost = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value);
                    }
                    GrossValueCalculation(i);
                    DiscountCalculation(i, dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceDiscountAmount"].ColumnIndex);
                    taxAndGridTotalAmountCalculation(i);
                    decCurrentRate = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                    decCurrentConversionRate = Convert.ToDecimal(listObj[0].Rows[i]["conversionRate"].ToString());
                    UnitConversionCalc(i);
                    if (cmbSalesModeOrderNo.Visible == true)
                    {
                        dgvSalesInvoice.Rows[i].Cells["dgvtxtSalesInvoicembUnitName"].ReadOnly = true;
                    }
                }
                List<DataTable> listAdditionalCost = new List<DataTable>();
                listAdditionalCost = BllSalesInvoice.SalesInvoiceAdditionalCostViewByVoucherNoUnderVoucherType(DecSalesInvoiceVoucherTypeId, strVoucherNo);
                for (int i = 0; i < listAdditionalCost[0].Rows.Count; i++)
                {
                    dgvSalesInvoiceLedger.Rows.Add();
                    dgvSalesInvoiceLedger.Rows[i].Cells["dgvtxtAdditionalCostId"].Value = listAdditionalCost[0].Rows[i]["additionalCostId"].ToString();
                    dgvSalesInvoiceLedger.Rows[i].Cells["dgvCmbAdditionalCostledgerName"].Value = Convert.ToDecimal(listAdditionalCost[0].Rows[i]["ledgerId"].ToString());
                    dgvSalesInvoiceLedger.Rows[i].Cells["dgvtxtAdditionalCoastledgerAmount"].Value = listAdditionalCost[0].Rows[i]["amount"].ToString();
                    List<DataTable> ListObj = new List<DataTable>();
                    AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                    ListObj = bllAccountLedger.AccountLedgerViewForAdditionalCost();
                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvSalesInvoiceLedger[dgvSalesInvoiceLedger.Columns["dgvCmbAdditionalCostledgerName"].Index, i];
                    dgvccVoucherType.DataSource = ListObj[0];
                    dgvccVoucherType.ValueMember = "ledgerId";
                    dgvccVoucherType.DisplayMember = "ledgerName";
                }
                List<DataTable> ListDrOrCr = BllSalesInvoice.salesinvoiceAdditionalCostCheckdrOrCrforSiEdit(DecSalesInvoiceVoucherTypeId, strVoucherNo);
                if (ListDrOrCr[0].Rows.Count > 0)
                {
                    if (Convert.ToDecimal(ListDrOrCr[0].Rows[0]["credit"].ToString()) != 0)
                    {
                        cmbCashOrbank.SelectedValue = Convert.ToDecimal(ListDrOrCr[0].Rows[0]["ledgerId"].ToString());
                        cmbCashOrbank.Visible = true;
                        lblcashOrBank.Visible = true;
                        cmbDrorCr.SelectedIndex = 0;
                        decBankOrCashIdForEdit = Convert.ToDecimal(cmbCashOrbank.SelectedValue.ToString());
                    }
                    else
                    {
                        cmbDrorCr.SelectedIndex = 1;
                    }
                }
                taxGridFill();
                List<DataTable> listTax = new List<DataTable>();
                listTax = BllSalesInvoice.SalesInvoiceSalesBillTaxViewAllBySalesMasterId(decSalesInvoiceIdToEdit);
                foreach (DataGridViewRow dgvrowTax in dgvSalesInvoiceTax.Rows)
                {
                    for (int ini = 0; ini < listTax[0].Rows.Count; ini++)
                    {
                        if (dgvrowTax.Cells["dgvtxtTtaxId"].Value != null && dgvrowTax.Cells["dgvtxtTtaxId"].Value.ToString() != string.Empty)
                        {
                            decimal decId = Convert.ToDecimal(listTax[0].Rows[ini]["taxId"].ToString());
                            if (dgvrowTax.Cells["dgvtxtTtaxId"].Value.ToString() == decId.ToString())
                            {
                                dgvrowTax.Cells["dgvtxtTtaxAmount"].Value = listTax[0].Rows[ini]["taxAmount"].ToString();
                                break;
                            }
                            else
                            {
                                dgvrowTax.Cells["dgvtxtTtaxAmount"].Value = "0.00";
                            }
                        }
                    }
                }
                LedgerGridTotalAmountCalculation();
                SiGridTotalAmountCalculation();
                txtGrandTotal.Text = listMaster[0].Rows[0]["grandTotal"].ToString();
                txtBillDiscount.Text = listMaster[0].Rows[0]["billDiscount"].ToString();
                bool isPartyBalanceRef = false;
                AccountLedgerBll bllAccountLedger1 = new AccountLedgerBll();
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                isPartyBalanceRef = bllAccountLedger1.PartyBalanceAgainstReferenceCheck(strVoucherNo, DecSalesInvoiceVoucherTypeId);
                if (isPartyBalanceRef)
                {
                    cmbCashOrParty.Enabled = false;
                }
                else
                {
                    cmbCashOrParty.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 77" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Edit Function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                removeSalesInvoiceDetails();
                SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
                InfoSalesMaster = BllSalesInvoice.SalesMasterView(decSalesInvoiceIdToEdit);
                if (InfoSalesMaster.DeliveryNoteMasterId != 0)
                {
                    DeliveryNoteMasterInfo infoDeliveryNote = new DeliveryNoteMasterInfo();
                    infoDeliveryNote = new DeliveryNoteBll().DeliveryNoteMasterView(InfoSalesMaster.DeliveryNoteMasterId);
                    new StockPostingBll().StockPostingDeleteForSalesInvoiceAgainstDeliveryNote
                        (InfoSalesMaster.VoucherTypeId, InfoSalesMaster.VoucherNo,
                        infoDeliveryNote.VoucherNo, infoDeliveryNote.VoucherTypeId);
                }
                new StockPostingBll().StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType
                        (0, "NA", InfoSalesMaster.VoucherNo, InfoSalesMaster.VoucherTypeId);
                InfoSalesMaster.SalesMasterId = decSalesInvoiceIdToEdit;
                InfoSalesMaster.AdditionalCost = Convert.ToDecimal(lblLedgerTotalAmount.Text);
                InfoSalesMaster.BillDiscount = Convert.ToDecimal(txtBillDiscount.Text.Trim());
                InfoSalesMaster.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text.Trim().ToString());
                InfoSalesMaster.CustomerName = txtCustomer.Text.Trim();
                InfoSalesMaster.Date = Convert.ToDateTime(txtDate.Text.ToString());
                InfoSalesMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                InfoSalesMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                InfoSalesMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoSalesMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                InfoSalesMaster.InvoiceNo = txtInvoiceNo.Text.Trim();
                InfoSalesMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                InfoSalesMaster.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                InfoSalesMaster.VoucherNo = strVoucherNo;
                if (isAutomatic)
                {
                    InfoSalesMaster.SuffixPrefixId = decSalseInvoiceSuffixPrefixId;
                }
                else
                {
                    InfoSalesMaster.SuffixPrefixId = 0;
                }
                if (cmbSalesMode.Text == "Against SalesOrder")
                {
                    InfoSalesMaster.OrderMasterId = Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.OrderMasterId = 0;
                }
                if (cmbSalesMode.Text == "Against Delivery Note")
                {
                    InfoSalesMaster.DeliveryNoteMasterId = Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.DeliveryNoteMasterId = 0;
                }
                if (cmbSalesMode.Text == "Against Quotation")
                {
                    InfoSalesMaster.QuotationMasterId = Convert.ToDecimal(cmbSalesModeOrderNo.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.QuotationMasterId = 0;
                }
                InfoSalesMaster.Narration = txtNarration.Text.Trim();
                InfoSalesMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                InfoSalesMaster.SalesAccount = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                InfoSalesMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text.Trim());
                if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                {
                    InfoSalesMaster.TaxAmount = Convert.ToDecimal(lblTaxTotalAmount.Text.Trim());
                }
                else
                {
                    InfoSalesMaster.TaxAmount = 0;
                }
                InfoSalesMaster.UserId = PublicVariables._decCurrentUserId;
                InfoSalesMaster.LrNo = txtVehicleNo.Text;
                InfoSalesMaster.TransportationCompany = txtTransportCompany.Text.Trim();
                InfoSalesMaster.POS = false;
                InfoSalesMaster.CounterId = 0;
                InfoSalesMaster.ExtraDate = DateTime.Now;
                InfoSalesMaster.Extra1 = string.Empty;
                InfoSalesMaster.Extra2 = string.Empty;
                BllSalesInvoice.SalesMasterEdit(InfoSalesMaster);
                removeSalesInvoiceDetails();
                SalesInvoiceDetailsEditFill();
                if (cmbCashOrParty.Enabled)
                {
                    LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                    BllLedgerPosting.LedgerPostDelete(strVoucherNo, DecSalesInvoiceVoucherTypeId);
                    ledgerPostingAdd();
                }
                else
                {
                    ledgerPostingEdit();
                }
                Messages.UpdatedMessage();
                if (cbxPrintAfterSave.Checked)
                {
                    SettingsBll BllSettings = new SettingsBll();
                    if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(decSalesInvoiceIdToEdit);
                    }
                    else
                    {
                        Print(decSalesInvoiceIdToEdit);
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 78" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete all sales invoice details here
        /// </summary>
        public void removeSalesInvoiceDetails()
        {
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            try
            {
                foreach (var strId in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strId);
                    BllSalesInvoice.SalesDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 79" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove all sales invoice additional cost details here
        /// </summary>
        public void removeSalesInvoiceAdditionalDetails()
        {
            AditionalCostBll bllAditionalCost = new AditionalCostBll();
            try
            {
                foreach (var strId in lstArrOfRemoveLedger)
                {
                    decimal decDeleteId = Convert.ToDecimal(strId);
                    bllAditionalCost.AdditionalCostDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 80" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill function for edit
        /// </summary>
        public void SalesInvoiceDetailsEditFill()
        {
            //SalesMasterSP spSalesMaster = new SalesMasterSP();
            //SalesDetailsSP spSalesDetails = new SalesDetailsSP();
            PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
            SalesDetailsInfo InfoSalesDetails = new SalesDetailsInfo();
            StockPostingInfo infoStockPosting = new StockPostingInfo();
            SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
            StockPostingBll BllStockPosting = new StockPostingBll();
            PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
            AdditionalCostInfo infoAdditionalCost = new AdditionalCostInfo();
            AditionalCostBll bllAditionalCost = new AditionalCostBll();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            SalesBillTaxInfo infoSalesBillTax = new SalesBillTaxInfo();
            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
            try
            {
                string strAgainstInvoiceN0 = txtInvoiceNo.Text.Trim();
                for (int inI = 0; inI < dgvSalesInvoice.Rows.Count - 1; inI++)
                {
                    decimal decRefStatus = BllSalesInvoice.SalesInvoiceReferenceCheckForEdit(decSalesInvoiceIdToEdit);
                    if (decRefStatus != 0)
                    {
                        dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductCode"].ReadOnly = true;
                        dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].ReadOnly = true;
                        dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceBarcode"].ReadOnly = true;
                        dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].ReadOnly = true;
                        dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].ReadOnly = true;
                    }
                    if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value == null || dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() == "0")   // here check the  row added or editing current row
                    {
                        InfoSalesDetails.SalesMasterId = decSalesInvoiceIdToEdit;
                        InfoSalesDetails.ExtraDate = DateTime.Now;
                        InfoSalesDetails.Extra1 = string.Empty;
                        InfoSalesDetails.Extra2 = string.Empty;
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty)
                        {
                            if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                            {
                                if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSISalesOrderDetailsId"].Value != null)
                                {
                                    InfoSalesDetails.OrderDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString());
                                }
                                else
                                {
                                    InfoSalesDetails.OrderDetailsId = 0;
                                }
                                if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value != null)
                                {
                                    InfoSalesDetails.DeliveryNoteDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString());
                                }
                                else
                                {
                                    InfoSalesDetails.DeliveryNoteDetailsId = 0;
                                }
                                if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value != null)
                                {
                                    InfoSalesDetails.QuotationDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString());
                                }
                                else
                                {
                                    InfoSalesDetails.QuotationDetailsId = 0;
                                }
                                InfoSalesDetails.SlNo = Convert.ToInt32(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceSlno"].Value.ToString());
                                InfoSalesDetails.ProductId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                                decimal decQty = BllSalesInvoice.SalesInvoiceQuantityDetailsAgainstSalesReturn(DecSalesInvoiceVoucherTypeId, strVoucherNo);
                                if (Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value.ToString()) < decQty)
                                {
                                    dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value = 0;
                                    decRefStatus = 1;
                                    MessageBox.Show("Quantity should be greater than " + decQty, "Open_Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvSalesInvoice.Focus();
                                }
                                else
                                {
                                    InfoSalesDetails.Qty = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                                    InfoSalesDetails.Rate = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                                    InfoSalesDetails.UnitId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoicembUnitName"].Value.ToString());
                                    InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value.ToString());
                                    InfoSalesDetails.Discount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                                    if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                                    {
                                        InfoSalesDetails.TaxId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString());
                                        InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceTaxAmount"].Value.ToString());
                                    }
                                    else
                                    {
                                        InfoSalesDetails.TaxId = 0;
                                        InfoSalesDetails.TaxAmount = 0;
                                    }
                                    if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString() != string.Empty)
                                    {
                                        InfoSalesDetails.BatchId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                                    }
                                    else
                                    {
                                        InfoSalesDetails.BatchId = 0;
                                    }
                                    if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString() != string.Empty)
                                    {
                                        InfoSalesDetails.GodownId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString());
                                    }
                                    else
                                    {
                                        InfoSalesDetails.GodownId = 0;
                                    }
                                    if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString() != string.Empty)
                                    {
                                        InfoSalesDetails.RackId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString());
                                    }
                                    else
                                    {
                                        InfoSalesDetails.RackId = 0;
                                    }
                                    InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString());
                                    InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceNetAmount"].Value.ToString());
                                    InfoSalesDetails.Amount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceAmount"].Value.ToString());
                                    BllSalesInvoice.SalesDetailsAdd(InfoSalesDetails);
                                }
                            }
                        }
                    }
                    else
                    {
                        InfoSalesDetails.SalesMasterId = decSalesInvoiceIdToEdit;
                        InfoSalesDetails.SalesDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value);
                        InfoSalesDetails.SlNo = Convert.ToInt32(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceSlno"].Value.ToString());
                        InfoSalesDetails.ProductId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                        InfoSalesDetails.Qty = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                        InfoSalesDetails.UnitId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoicembUnitName"].Value.ToString());
                        InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value.ToString());
                        InfoSalesDetails.Rate = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                        InfoSalesDetails.Discount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                        if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                        {
                            InfoSalesDetails.TaxId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString());
                            InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceTaxAmount"].Value.ToString());
                        }
                        else
                        {
                            InfoSalesDetails.TaxId = 0;
                            InfoSalesDetails.TaxAmount = 0;
                        }
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString() != string.Empty)
                        {
                            InfoSalesDetails.BatchId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                        }
                        else
                        {
                            InfoSalesDetails.BatchId = 0;
                        }
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString() != string.Empty)
                        {
                            InfoSalesDetails.GodownId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString());
                            RackComboFill(InfoSalesDetails.GodownId, inI, dgvSalesInvoice.Columns["dgvcmbSalesInvoiceRack"].Index);
                        }
                        else
                        {
                            InfoSalesDetails.GodownId = 0;
                        }
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString() != string.Empty)
                        {
                            InfoSalesDetails.RackId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString());
                        }
                        else
                        {
                            InfoSalesDetails.RackId = 0;
                        }
                        InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString());
                        InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceNetAmount"].Value.ToString());
                        InfoSalesDetails.Amount = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceAmount"].Value.ToString());
                        InfoSalesDetails.ExtraDate = DateTime.Now;
                        InfoSalesDetails.Extra1 = string.Empty;
                        InfoSalesDetails.Extra2 = string.Empty;
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSISalesOrderDetailsId"].Value != null)
                        {
                            InfoSalesDetails.OrderDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString());
                        }
                        else
                        {
                            InfoSalesDetails.OrderDetailsId = 0;
                        }
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value != null)
                        {
                            InfoSalesDetails.DeliveryNoteDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString());
                        }
                        else
                        {
                            InfoSalesDetails.DeliveryNoteDetailsId = 0;
                        }
                        if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value != null)
                        {
                            InfoSalesDetails.QuotationDetailsId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString());
                        }
                        else
                        {
                            InfoSalesDetails.QuotationDetailsId = 0;
                        }
                        BllSalesInvoice.SalesDetailsEdit(InfoSalesDetails);
                    }
                    infoStockPosting.Date = Convert.ToDateTime(txtDate.Text.Trim().ToString());
                    infoStockPosting.ProductId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                    infoStockPosting.BatchId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                    infoStockPosting.UnitId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoicembUnitName"].Value.ToString());
                    if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString() != string.Empty)
                    {
                        infoStockPosting.GodownId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceGodown"].Value.ToString());
                    }
                    else
                    {
                        infoStockPosting.GodownId = 0;
                    }
                    if (dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value != null && dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString() != string.Empty)
                    {
                        infoStockPosting.RackId = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvcmbSalesInvoiceRack"].Value.ToString());
                    }
                    else
                    {
                        infoStockPosting.RackId = 0;
                    }
                    if (Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceVoucherTypeId"].Value) == 0)
                    {
                        decimal decResult =BllStockPosting.StockPostingDeleteForSalesInvoiceAgainstDeliveryNote(0, "NA", strVoucherNo, DecSalesInvoiceVoucherTypeId);
                    }
                    else
                    {
                        decimal decResult = BllStockPosting.StockPostingDeleteForSalesInvoiceAgainstDeliveryNote(DecSalesInvoiceVoucherTypeId, strVoucherNo, strVoucherNoTostockPost, decVouchertypeIdTostockPost);
                    }
                    infoStockPosting.Rate = Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                    infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoStockPosting.ExtraDate = DateTime.Now;
                    infoStockPosting.Extra1 = string.Empty;
                    infoStockPosting.Extra2 = string.Empty;
                    if (dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value != null)
                    {
                        if (Convert.ToDecimal(dgvSalesInvoice.Rows[inI].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString()) != 0)
                        {
                            infoStockPosting.InwardQty = InfoSalesDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(InfoSalesDetails.UnitConversionId);
                            infoStockPosting.OutwardQty = 0;
                            infoStockPosting.VoucherNo = strVoucherNoTostockPost;
                            infoStockPosting.AgainstVoucherNo = strVoucherNo;
                            infoStockPosting.InvoiceNo = strInvoiceNoTostockPost;
                            infoStockPosting.AgainstInvoiceNo = strAgainstInvoiceN0;
                            infoStockPosting.VoucherTypeId = decVouchertypeIdTostockPost;
                            infoStockPosting.AgainstVoucherTypeId = DecSalesInvoiceVoucherTypeId;
                            BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                    }
                    infoStockPosting.InwardQty = 0;
                    infoStockPosting.OutwardQty = InfoSalesDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(InfoSalesDetails.UnitConversionId);
                    infoStockPosting.VoucherNo = strVoucherNo;
                    infoStockPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                    infoStockPosting.InvoiceNo = strAgainstInvoiceN0;
                    infoStockPosting.AgainstInvoiceNo = "NA";
                    infoStockPosting.AgainstVoucherNo = "NA";
                    infoStockPosting.AgainstVoucherTypeId = 0;
                    BllStockPosting.StockPostingAdd(infoStockPosting);
                }
                int inAddRowCount = dgvSalesInvoiceLedger.RowCount;
                infoAdditionalCost.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                if (isAutomatic)
                {
                    infoAdditionalCost.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoAdditionalCost.VoucherNo = txtInvoiceNo.Text;
                }
                infoAdditionalCost.ExtraDate = DateTime.Now;
                infoAdditionalCost.Extra1 = string.Empty;
                infoAdditionalCost.Extra2 = string.Empty;
                for (int inIAdc = 0; inIAdc < inAddRowCount; inIAdc++)
                {
                    if (dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                    {
                        if (dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null && dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != string.Empty)
                        {
                            infoAdditionalCost.LedgerId = Convert.ToInt32(dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvCmbAdditionalCostledgerName"].Value.ToString());
                            if (cmbDrorCr.SelectedItem.ToString() != "Dr")
                            {
                                infoAdditionalCost.Debit = 0;
                                infoAdditionalCost.Credit = Convert.ToDecimal(dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                            }
                            else
                            {
                                infoAdditionalCost.Debit = Convert.ToDecimal(dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                                infoAdditionalCost.Credit = 0;
                            }
                            if (dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvtxtAdditionalCostId"].Value != null && dgvSalesInvoiceLedger.Rows[inIAdc].Cells["dgvtxtAdditionalCostId"].Value.ToString() != string.Empty)
                            {
                                bllAditionalCost.AdditionalCostEditByVoucherTypeIdAndVoucherNo(infoAdditionalCost);
                            }
                            else
                            {
                                bllAditionalCost.AdditionalCostAdd(infoAdditionalCost);
                            }
                        }
                    }
                }
                if (cmbDrorCr.SelectedItem.ToString() != "Dr")               // here we are debit the cash or bank
                {
                    decimal decCAshOrPartyId = 0;
                    decCAshOrPartyId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                    decimal decTotalAddAmount = Convert.ToDecimal(lblLedgerTotalAmount.Text.Trim().ToString());
                    infoAdditionalCost.Debit = decTotalAddAmount;
                    infoAdditionalCost.Credit = 0;
                    infoAdditionalCost.LedgerId = decCAshOrPartyId;
                    infoAdditionalCost.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                    infoAdditionalCost.VoucherNo = strVoucherNo;
                    infoAdditionalCost.ExtraDate = DateTime.Now;
                    infoAdditionalCost.Extra1 = string.Empty;
                    infoAdditionalCost.Extra2 = string.Empty;
                    bllAditionalCost.AdditionalCostEditByVoucherTypeIdAndVoucherNo(infoAdditionalCost);
                }
                else
                {
                    decimal decCAshOrBankId = 0;                    // here we are credit the cash or bank
                    decCAshOrBankId = Convert.ToDecimal(cmbCashOrbank.SelectedValue.ToString());
                    decimal decTotalAddAmount = Convert.ToDecimal(lblLedgerTotalAmount.Text.Trim().ToString());
                    infoAdditionalCost.Debit = 0;
                    infoAdditionalCost.Credit = decTotalAddAmount;
                    infoAdditionalCost.LedgerId = decCAshOrBankId;
                    infoAdditionalCost.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                    infoAdditionalCost.VoucherNo = strVoucherNo;
                    infoAdditionalCost.ExtraDate = DateTime.Now;
                    infoAdditionalCost.Extra1 = string.Empty;
                    infoAdditionalCost.Extra2 = string.Empty;
                    bllAditionalCost.AdditionalCostEditByVoucherTypeIdAndVoucherNo(infoAdditionalCost);
                }
                removeSalesInvoiceAdditionalDetails();
                if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                {
                    int inTaxRowCount = dgvSalesInvoiceTax.RowCount;
                    infoSalesBillTax.SalesMasterId = decSalesInvoiceIdToEdit;
                    infoSalesBillTax.ExtraDate = DateTime.Now;
                    infoSalesBillTax.Extra1 = string.Empty;
                    infoSalesBillTax.Extra2 = string.Empty;
                    for (int inTax = 0; inTax < inTaxRowCount; inTax++)
                    {
                        if (dgvSalesInvoiceTax.Rows[inTax].Cells["dgvtxtTtaxId"].Value != null && dgvSalesInvoiceTax.Rows[inTax].Cells["dgvtxtTtaxId"].Value.ToString() != string.Empty)
                        {
                            if (dgvSalesInvoiceTax.Rows[inTax].Cells["dgvtxtTtaxAmount"].Value != null && dgvSalesInvoiceTax.Rows[inTax].Cells["dgvtxtTtaxAmount"].Value.ToString() != string.Empty)
                            {
                                decimal decAmount = Convert.ToDecimal(dgvSalesInvoiceTax.Rows[inTax].Cells["dgvtxtTtaxAmount"].Value);
                                if (decAmount > 0)
                                {
                                    infoSalesBillTax.TaxId = Convert.ToInt32(dgvSalesInvoiceTax.Rows[inTax].Cells["dgvtxtTtaxId"].Value.ToString());
                                    infoSalesBillTax.TaxAmount = Convert.ToDecimal(dgvSalesInvoiceTax.Rows[inTax].Cells["dgvtxtTtaxAmount"].Value.ToString());
                                    BllSalesInvoice.SalesBillTaxEditBySalesMasterIdAndTaxId(infoSalesBillTax);
                                }
                            }
                        }
                    }
                }
                if (BllSalesInvoice.SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString())))
                {
                    infoPartyBalance.Date = Convert.ToDateTime(txtDate.Text.ToString());
                    infoPartyBalance.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                    infoPartyBalance.VoucherNo = strVoucherNo;
                    infoPartyBalance.InvoiceNo = txtInvoiceNo.Text.Trim();
                    infoPartyBalance.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                    infoPartyBalance.AgainstVoucherTypeId = 0;
                    infoPartyBalance.AgainstVoucherNo = "0";
                    infoPartyBalance.AgainstInvoiceNo = "0";
                    infoPartyBalance.ReferenceType = "New";
                    infoPartyBalance.Debit = Convert.ToDecimal(txtGrandTotal.Text.Trim().ToString());
                    decimal decBalAmount = BllSalesInvoice.SalesInvoiceReciptVoucherDetailsAgainstSI(DecSalesInvoiceVoucherTypeId, strVoucherNo);
                    decimal decCurrentAmount = Convert.ToDecimal(txtGrandTotal.Text.ToString());
                    if (decCurrentAmount < decBalAmount)
                    {
                        MessageBox.Show("Amount should be greater than " + decBalAmount, "Open_Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSalesInvoice.Focus();
                    }
                    else
                    {
                        infoPartyBalance.Credit = 0;
                        infoPartyBalance.CreditPeriod = Convert.ToInt32(txtCreditPeriod.Text.ToString());
                        infoPartyBalance.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue);
                        infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                        infoPartyBalance.ExtraDate = DateTime.Now;
                        infoPartyBalance.Extra1 = string.Empty;
                        infoPartyBalance.Extra2 = string.Empty;
                        BllPartyBalance.PartyBalanceEditByVoucherNoVoucherTypeIdAndReferenceType(infoPartyBalance);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 81" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger posting edit function
        /// </summary>
        public void ledgerPostingEdit()
        {
            LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
            SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
            LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            decimal decRate = 0;
            decimal decimalGrantTotal = 0;
            decimal decTotalAmount = 0;
            try
            {
                decimalGrantTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                decimalGrantTotal = decimalGrantTotal * decRate;
                infoLedgerPosting.Debit = decimalGrantTotal;
                infoLedgerPosting.Credit = 0;
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
                decTotalAmount = TotalNetAmountForLedgerPosting();
                decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                decTotalAmount = decTotalAmount * decRate;
                infoLedgerPosting.Debit = 0;
                infoLedgerPosting.Credit = decTotalAmount;
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
                decimal decBillDis = 0;
                decBillDis = Convert.ToDecimal(txtBillDiscount.Text.Trim().ToString());
                decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                decBillDis = decBillDis * decRate;
                if (decBillDis > 0)
                {
                    infoLedgerPosting.Debit = decBillDis;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                    infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                    infoLedgerPosting.LedgerId = 8;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    BllLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
                }
                if (dgvSalesInvoice.Columns["dgvcmbSalesInvoiceTaxName"].Visible)
                {
                    foreach (DataGridViewRow dgvrow in dgvSalesInvoiceTax.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtTtaxId"].Value != null && dgvrow.Cells["dgvtxtTtaxId"].Value.ToString() != string.Empty)
                        {
                            decimal decTaxAmount = 0;
                            decTaxAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtTtaxAmount"].Value.ToString());
                            decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decTaxAmount = decTaxAmount * decRate;
                            if (decTaxAmount > 0)
                            {
                                infoLedgerPosting.Debit = 0;
                                infoLedgerPosting.Credit = decTaxAmount;
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvtxtTaxLedgerId"].Value.ToString());
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.DetailsId = 0;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                BllLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
                            }
                        }
                    }
                }
                if (cmbDrorCr.SelectedItem.ToString() != "Cr")
                {
                    foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                    {
                        if (dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                        {
                            decimal decAmount = 0;
                            decAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                            decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decAmount = decAmount * decRate;
                            if (decAmount > 0)
                            {
                                infoLedgerPosting.Debit = decAmount;
                                infoLedgerPosting.Credit = 0;
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString());
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.DetailsId = 0;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                BllLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
                            }
                        }
                    }
                    if (cmbCashOrbank.Visible)
                    {
                        decimal decBankOrCashId = 0;
                        decimal decAmountForCr = 0;
                        decBankOrCashId = Convert.ToDecimal(cmbCashOrbank.SelectedValue.ToString());
                        decAmountForCr = Convert.ToDecimal(lblLedgerTotalAmount.Text.ToString());
                        decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                        decAmountForCr = decAmountForCr * decRate;
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = decAmountForCr;
                        infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                        infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                        infoLedgerPosting.VoucherNo = strVoucherNo;
                        infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                        infoLedgerPosting.LedgerId = decBankOrCashId;
                        infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                        infoLedgerPosting.DetailsId = 0;
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                        infoLedgerPosting.Extra1 = "AddCash";
                        infoLedgerPosting.Extra2 = string.Empty;
                        BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    }
                    else
                    {
                        decimal decBankOrCashId = 0;
                        decimal decAmountForCr = 0;
                        decBankOrCashId = Convert.ToDecimal(cmbCashOrbank.SelectedValue.ToString());
                        decAmountForCr = Convert.ToDecimal(lblLedgerTotalAmount.Text.ToString());
                        decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                        decAmountForCr = decAmountForCr * decRate;
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = decAmountForCr;
                        infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                        infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                        infoLedgerPosting.VoucherNo = strVoucherNo;
                        infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                        infoLedgerPosting.LedgerId = decBankOrCashId;
                        infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                        infoLedgerPosting.DetailsId = 0;
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                        infoLedgerPosting.Extra1 = "AddCash";
                        infoLedgerPosting.Extra2 = string.Empty;
                        BllLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
                    }
                }
                else
                {
                    string strVno = string.Empty;
                    strVno = infoLedgerPosting.VoucherNo;
                    BllLedgerPosting.LedgerPostingDeleteByVoucherTypeIdAndLedgerIdAndVoucherNoAndExtra(DecSalesInvoiceVoucherTypeId, decBankOrCashIdForEdit, strVno, "AddCash");
                    foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                    {
                        if (dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                        {
                            decimal decAmount = 0;
                            decAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString());
                            decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decAmount = decAmount * decRate;
                            if (decAmount > 0)
                            {
                                infoLedgerPosting.Debit = 0;
                                infoLedgerPosting.Credit = decAmount;
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecSalesInvoiceVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtInvoiceNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString());
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.DetailsId = 0;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                BllLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 82" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmLedgerDetails to view details and for updation
        /// </summary>
        /// <param name="LedgerDetailsObj"></param>
        /// <param name="decMasterId"></param>
        public void CallFromLedgerDetails(frmLedgerDetails LedgerDetailsObj, decimal decMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                frmledgerDetailsObj = LedgerDetailsObj;
                frmledgerDetailsObj.Enabled = false;
                decSalesInvoiceIdToEdit = decMasterId;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 83" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Unit conversion calculation function
        /// </summary>
        /// <param name="inIndexOfRow"></param>
        public void UnitConversionCalc(int inIndexOfRow)
        {
            try
            {
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                List<DataTable> listUnitByProduct = new List<DataTable>();
                if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceProductId"].Value != null)
                {
                    listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString()
                        == string.Empty ? "0" : dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                    foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                    {
                        if (dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoicembUnitName"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                        {
                            IsSetGridValueChange = false;
                            dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                            dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                            decimal decNewConversionRate = Convert.ToDecimal(dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceConversionRate"].Value.ToString());
                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                            IsSetGridValueChange = true;
                            dgvSalesInvoice.Rows[inIndexOfRow].Cells["dgvtxtSalesInvoiceRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 84" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete function, deleting all are the details here
        /// </summary>
        /// <param name="SalesMasterId"></param>
        public void DeleteFunction(decimal SalesMasterId)
        {
            //SalesMasterSP spSalesMaster = new SalesMasterSP();
            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
            try
            {
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                if (!BllSalesInvoice.SalesReturnCheckReferenceForSIDelete(decSalesInvoiceIdToEdit))
                {
                    if (!BllPartyBalance.PartyBalanceCheckReference(DecSalesInvoiceVoucherTypeId, strVoucherNo))
                    {
                        BllSalesInvoice.SalesInvoiceDelete(decSalesInvoiceIdToEdit, DecSalesInvoiceVoucherTypeId, strVoucherNo);
                        Messages.DeletedMessage();
                        if (frmSalesinvoiceRegisterObj != null)
                        {
                            this.Close();
                            frmSalesinvoiceRegisterObj.Enabled = true;
                        }
                        else if (frmSalesReportObj != null)
                        {
                            this.Close();
                            frmSalesReportObj.Enabled = true;
                        }
                        else if (objVoucherSearch != null)
                        {
                            this.Close();
                            objVoucherSearch.GridFill();
                        }
                        else if (frmDayBookObj != null)
                        {
                            this.Close();
                        }
                        else if (frmledgerDetailsObj != null)
                        {
                            this.Close();
                        }
                        else
                        {
                            Clear();
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Reference exist. Cannot delete");
                        txtDate.Focus();
                    }
                }
                else
                {
                    Messages.InformationMessage("Reference exist. Cannot delete");
                    txtDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 85" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the total amount status, is valid or not
        /// </summary>
        /// <param name="isMessageShown"></param>
        /// <returns></returns>
        public bool CheckTotalAmount(bool isMessageShown)
        {
            try
            {
                bool isMessage = isMessageShown;
                if (txtTotalAmount.Text.Split('.')[0].Length > 13)
                {
                    if (isMessageShown)
                    {
                        MessageBox.Show("Amount exeed than limit");
                    }
                    isMessageShown = false;
                    dgvSalesInvoice.Rows.RemoveAt(dgvSalesInvoice.Rows.Count - 2);
                    SiGridTotalAmountCalculation();
                    CheckTotalAmount(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 86" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dgvSalesInvoice.Rows.Count > 1 ? true : false;
        }
        /// <summary>
        /// Checking the total ledger amount status, is valid or not
        /// </summary>
        /// <param name="isMessageShown"></param>
        /// <returns></returns>
        public bool CheckTotalAmountLedger(bool isMessageShown)
        {
            try
            {
                bool isMessage = isMessageShown;
                if (lblLedgerTotalAmount.Text.Split('.')[0].Length > 13)
                {
                    if (isMessageShown)
                    {
                        MessageBox.Show("Ledger amount exeed than limit");
                    }
                    isMessageShown = false;
                    dgvSalesInvoiceLedger.Rows.RemoveAt(dgvSalesInvoiceLedger.Rows.Count - 2);
                    LedgerGridTotalAmountCalculation();
                    SiGridTotalAmountCalculation();
                    CheckTotalAmountLedger(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 87" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dgvSalesInvoice.Rows.Count > 1 ? true : false;
        }
        /// <summary>
        /// Function to fill Sales invoice grid while return from Product creation when creating Product 
        /// </summary>
        /// <param name="decProductId"></param>
        public void ReturnFromProductCreation(decimal decProductId)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                this.Enabled = true;
                this.Activate();
                if (decProductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decProductId);
                    strProductCode = infoProduct.ProductCode;
                    ProductDetailsFill(strProductCode, dgvSalesInvoice.CurrentRow.Index, "ProductCode");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 88" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Discount calculation for fill
        /// </summary>
        /// <param name="inRowIndex"></param>
        /// <param name="inColumnIndex"></param>
        public void DiscountCalculation(int inRowIndex, int inColumnIndex)
        {
            try
            {
                decimal decDiscountAmount = 0;
                decimal decDiscountPercent = 0;
                decimal decGrossAmount = 0;
                if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value != null)
                {
                    if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString() != string.Empty)
                    {
                        decGrossAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString());
                        if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString() != string.Empty)
                            {
                                decDiscountAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                            }
                        }
                        if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value.ToString() != string.Empty)
                            {
                                decDiscountPercent = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value.ToString());
                            }
                        }
                        if (inColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountPercentage"].Index)
                        {
                            if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value != null && dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value.ToString()!=string.Empty)
                            {
                                decDiscountPercent = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value.ToString());
                            }
                            if (decGrossAmount > 0)
                            {
                                decDiscountAmount = decGrossAmount * decDiscountPercent / 100;
                            }
                            if (decDiscountAmount > 0)
                            {
                                dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = Math.Round(decDiscountAmount, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                        else if (inColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountAmount"].Index)
                        {
                            if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value!=null && dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString() != string.Empty)
                            {
                                decDiscountAmount = Convert.ToDecimal(dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString());
                            }
                            if (decGrossAmount > 0)
                            {
                                decDiscountPercent = decDiscountAmount * 100 / decGrossAmount;
                            }
                            if (decDiscountPercent > 0)
                            {
                                dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = Math.Round(decDiscountPercent, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                    }
                }
                if (decGrossAmount >= decDiscountAmount)
                {
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceNetAmount"].Value = (decGrossAmount - decDiscountAmount).ToString();
                }
                else
                {
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value = "0.00";
                    dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 89" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calculate the grid amount calculations
        /// </summary>
        /// <param name="inRowIndex"></param>
        /// <param name="e"></param>
        /// <param name="inGridColumn"></param>
        public void CalculateAmountFromGrid(int inRowIndex, DataGridViewCellEventArgs e, int inGridColumn)
        {
            try
            {
                if (dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value != null && dgvSalesInvoice.Rows[inRowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString() != string.Empty)
                {
                    UnitConversionCalc(inRowIndex);
                    GrossValueCalculation(inRowIndex);
                    DiscountCalculation(inRowIndex, inGridColumn);
                    taxAndGridTotalAmountCalculation(inRowIndex);
                }
                CheckInvalidEntries(e);
                SiGridTotalAmountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 90" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// When form load call the clear function and checking the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                SalesInvoiceSettingsCheck();
                formLoadDefaultFunctions();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 91" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new ledger or cashorParty using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewLedger_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = true;
                isFromSalesAccountCombo = false;
                if (cmbCashOrParty.SelectedValue != null)
                {
                    strCashOrParty = cmbCashOrParty.SelectedValue.ToString();
                }
                else
                {
                    strCashOrParty = string.Empty;
                }
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;//Edited by Najma
                    frmAccountLedgerObj.callFromSalesInvoice(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.callFromSalesInvoice(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 92" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// setting the date textbox value based on the datetimepicker value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpDate.Value;
                this.txtDate.Text = date.ToString("dd-MMM-yyyy");
                CurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 93" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the date validation function and change the date time picker value as per current date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtDate);
                if (txtDate.Text == string.Empty)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string strdate = txtDate.Text;
                dtpDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 94" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To checking the Sales mode and arrange the controls based on the mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetSalesDetailsIdToDelete();
                if (cmbSalesMode.Text == "NA")
                {
                    lblSalesModeOrderNo.Visible = false;
                    cmbSalesModeOrderNo.Visible = false;
                    cmbPricingLevel.Enabled = true;
                    dgvSalesInvoice.Rows.Clear();
                    lblTaxTotalAmount.Text = "0.00";
                    txtTotalAmount.Text = "0.00";
                    cmbVoucherType.Visible = false;
                    lblVoucherType.Visible = false;
                    dgvSalesInvoice.Rows.Clear();
                }
                else if (cmbSalesMode.Text == "Against SalesOrder")
                {
                    lblSalesModeOrderNo.Text = "Order No";
                    lblSalesModeOrderNo.Visible = true;
                    cmbSalesModeOrderNo.Visible = true;
                    cmbVoucherType.Visible = true;
                    lblVoucherType.Visible = true;
                    dgvSalesInvoice.Rows.Clear();
                }
                else if (cmbSalesMode.Text == "Against Delivery Note")
                {
                    lblSalesModeOrderNo.Text = "Delivery Note No";
                    lblSalesModeOrderNo.Visible = true;
                    cmbSalesModeOrderNo.Visible = true;
                    cmbVoucherType.Visible = true;
                    lblVoucherType.Visible = true;
                    dgvSalesInvoice.Rows.Clear();
                }
                else if (cmbSalesMode.Text == "Against Quotation")
                {
                    lblSalesModeOrderNo.Text = "Quotation No";
                    lblSalesModeOrderNo.Visible = true;
                    cmbSalesModeOrderNo.Visible = true;
                    cmbVoucherType.Visible = true;
                    lblVoucherType.Visible = true;
                    dgvSalesInvoice.Rows.Clear();
                }
                VoucherTypeComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 95" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// To create a new Sales account from this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSalesAccount_Click(object sender, EventArgs e)
        {
            try
            {
                isFromSalesAccountCombo = true;
                isFromCashOrPartyCombo = false;
                if (cmbSalesAccount.SelectedValue != null)
                {
                    strSalesAccount = cmbSalesAccount.SelectedValue.ToString();
                }
                else
                {
                    strSalesAccount = string.Empty;
                }
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                    frmAccountLedgerObj.callFromSalesInvoice(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.callFromSalesInvoice(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 96" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// To create a new Salesman from this button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSalesman_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSalesMan.SelectedValue != null)
                {
                    strSalesMan = cmbSalesMan.SelectedValue.ToString();
                }
                else
                {
                    strSalesMan = string.Empty;
                }
                frmSalesman frmSalesmanObj = new frmSalesman();
                frmSalesmanObj.MdiParent = formMDI.MDIObj;
                frmSalesman open = Application.OpenForms["frmSalesman"] as frmSalesman;
                if (open == null)
                {
                    frmSalesmanObj.WindowState = FormWindowState.Normal;
                    frmSalesmanObj.MdiParent = formMDI.MDIObj;
                    frmSalesmanObj.callFromSalesInvoice(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.callFromSalesInvoice(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 97" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cash or party combo changed, call the order combofill function and fill the basic functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetSalesDetailsIdToDelete();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo InfoAccountLedger = new AccountLedgerInfo();
                if (isFromEditMode == false)
                {
                    if (cmbCashOrParty.Text != string.Empty)
                    {
                        if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView")
                        {
                            InfoAccountLedger = bllAccountLedger.accountLedgerviewbyId(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()));
                            txtCustomer.Text = InfoAccountLedger.LedgerName;
                            cmbPricingLevel.SelectedValue = InfoAccountLedger.PricinglevelId == 0 ? 1 : InfoAccountLedger.PricinglevelId;
                            if (InfoAccountLedger.PricinglevelId == 0)
                            {
                                cmbPricingLevel.SelectedIndex = 0;
                            }
                            txtCreditPeriod.Text = InfoAccountLedger.CreditPeriod.ToString();
                        }
                    }
                }
                else if (cmbSalesMode.SelectedIndex != 0)
                {
                    Clear();
                }
                againstOrderComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 98" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new PricingLevel from this button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPricingLevel_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPricingLevel.SelectedValue != null)
                {
                    strPricingLevel = cmbPricingLevel.SelectedValue.ToString();
                }
                else
                {
                    strPricingLevel = string.Empty;
                }
                frmPricingLevel frmPricingLevelObj = new frmPricingLevel();
                frmPricingLevelObj.MdiParent = formMDI.MDIObj;
                frmPricingLevel open = Application.OpenForms["frmPricingLevel"] as frmPricingLevel;
                if (open == null)
                {
                    frmPricingLevelObj.WindowState = FormWindowState.Normal;
                    frmPricingLevelObj.MdiParent = formMDI.MDIObj;//Edited by Najma
                    frmPricingLevelObj.callFromSalesInvoice(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.callFromSalesInvoice(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 99" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvSalesInvoice.SelectedCells.Count > 0 && dgvSalesInvoice.CurrentRow != null)
                {
                    if (!dgvSalesInvoice.Rows[dgvSalesInvoice.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value != null && dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString() != "")
                                {
                                    lstArrOfRemove.Add(dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceSalesDetailsId"].Value.ToString());
                                    RemoveFunction();
                                    SiGridTotalAmountCalculation();
                                }
                                else
                                {
                                    RemoveFunction();
                                    SiGridTotalAmountCalculation();
                                }
                            }
                            else
                            {
                                RemoveFunction();
                                SiGridTotalAmountCalculation();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 100" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Data errod to handle unexpected errors in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvSalesInvoice.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 101" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill the grid based on the Sales mode item selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesModeOrderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetSalesDetailsIdToDelete();
                if (isFromEditMode == false)
                {
                    if ((cmbSalesModeOrderNo.SelectedValue == null ? "" : cmbSalesModeOrderNo.SelectedValue.ToString()) != "")
                    {
                        if (cmbSalesModeOrderNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbSalesModeOrderNo.Text != "System.Data.DataRowView")
                        {
                            if (cmbSalesMode.Text == "Against SalesOrder")
                            {
                                gridFillAgainestSalseOrderDetails();
                            }
                            if (cmbSalesMode.Text == "Against Delivery Note")
                            {
                                gridFillAgainestDeliveryNote();
                            }
                            else if (cmbSalesMode.Text == "Against Quotation")
                            {
                                gridFillAgainestQuotationDetails();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 102" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the SerialNo generation function here for tax grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceTax_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNoforSalesInvoiceTax();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 103" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// make each and every changes of grid has to be commited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoice_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalesInvoice.IsCurrentCellDirty)
                {
                    dgvSalesInvoice.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 104" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Sales grid cell leave event to calculate the basic functions and calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoice_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (IsSetGridValueChange == true)
            {
                BatchBll BllBatch = new BatchBll();

                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
               List< DataTable > listUnitConversion = new List<DataTable>();
                decimal decBatchId = 0;
                string strBarcode = string.Empty;
                try
                {
                    if (e.RowIndex != -1 && e.ColumnIndex != -1)
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty)
                            {
                                if (dgvSalesInvoice.RowCount > 1)
                                {
                                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value != null)
                                    {
                                        try
                                        {
                                            if (decimal.Parse(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString()) > 0)
                                            {
                                                if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value != null)
                                                {
                                                    if (decimal.Parse(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value.ToString()) > decimal.Parse(dtblDeliveryNoteDetails.Rows[e.RowIndex]["qty"].ToString()))
                                                    {
                                                        dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value = dtblDeliveryNoteDetails.Rows[e.RowIndex]["qty"].ToString();
                                                        if (decDeliveryNoteQty < decimal.Parse(dtblDeliveryNoteDetails.Rows[e.RowIndex]["qty"].ToString()))
                                                        {
                                                            dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value = decDeliveryNoteQty;
                                                            decDeliveryNoteQty = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                    }
                                    if (dgvSalesInvoice.Columns[e.ColumnIndex].Name == "dgvtxtSalesInvoicembUnitName")
                                    {
                                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoicembUnitName"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoicembUnitName"].Value.ToString() != string.Empty)
                                        {
                                            UnitConversionCalc(e.RowIndex);
                                        }
                                    }
                                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDiscountPercentage"].Value.ToString() != string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDiscountAmount"].Value.ToString() != string.Empty
                                        || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty
                                        || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value.ToString() != string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty
                                       || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString() != string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty)
                                    {
                                        DiscountCalculation(e.RowIndex, e.ColumnIndex);
                                    }
                                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbSalesInvoiceTaxName" || dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtSalesInvoiceGrossValue" || dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtSalesInvoiceDiscountPercentage")
                                    {
                                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvcmbSalesInvoiceTaxName"].Visible)
                                        {
                                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvcmbSalesInvoiceTaxName"].Value != null && (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceNetAmount"].Value != null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value != null))
                                            {
                                                if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvcmbSalesInvoiceTaxName"].Value.ToString() != string.Empty && (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceNetAmount"].Value.ToString() != string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceGrossValue"].Value.ToString() != string.Empty))
                                                {
                                                    {
                                                        taxAndGridTotalAmountCalculation(e.RowIndex);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            taxAndGridTotalAmountCalculation(e.RowIndex);
                                        }
                                    }
                                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtSalesInvoiceRate" || dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtSalesInvoiceQty")
                                    {
                                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value != null)
                                        {
                                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value.ToString() != string.Empty && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value.ToString() != string.Empty)
                                            {
                                                {
                                                    GrossValueCalculation(e.RowIndex);
                                                }
                                            }
                                        }
                                    }
                                }
                                if (e.ColumnIndex == dgvSalesInvoice.Columns["dgvcmbSalesInvoiceBatch"].Index)
                                {
                                    if (dgvSalesInvoice.CurrentRow.Cells["dgvcmbSalesInvoiceBatch"].Value != null)
                                    {
                                        if (dgvSalesInvoice.CurrentRow.Cells["dgvcmbSalesInvoiceBatch"].Value.ToString() != string.Empty && dgvSalesInvoice.CurrentRow.Cells["dgvcmbSalesInvoiceBatch"].Value.ToString() != "0")
                                        {
                                            decBatchId = Convert.ToDecimal(dgvSalesInvoice.CurrentRow.Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                                            strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                                            dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceBarcode"].Value = strBarcode;
                                            if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value != null)      // here get product rate for sales(standard rate)
                                            {
                                                getProductRate(e.RowIndex, Convert.ToDecimal(dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value.ToString()), decBatchId);
                                                UnitConversionCalc(e.RowIndex);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceConversionRate"].Value != null)
                            {
                                decCurrentConversionRate = Convert.ToDecimal(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceConversionRate"].Value.ToString());
                            }
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value != null)
                            {
                                decCurrentRate = Convert.ToDecimal(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                            }
                        }
                        CheckInvalidEntries(e);
                        SiGridTotalAmountCalculation();
                        CalculateAmountFromGrid(e.RowIndex, e, e.ColumnIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SI: 105" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        ///  Ledger grid cell begin edit for Combo box item fill and remove from the list once it has selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceLedger_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dgvSalesInvoice.RowCount > 1)
                {
                    List<DataTable> ListObj = new List<DataTable>();
                    AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                    if (dgvSalesInvoiceLedger.CurrentCell.ColumnIndex == dgvSalesInvoiceLedger.Columns["dgvCmbAdditionalCostledgerName"].Index)
                    {
                        ListObj = bllAccountLedger.AccountLedgerViewForAdditionalCost();
                        if (ListObj[0].Rows.Count > 0)
                        {
                            if (dgvSalesInvoiceLedger.RowCount > 1)
                            {
                                int inGridRowCount = dgvSalesInvoiceLedger.RowCount;
                                for (int inI = 0; inI < inGridRowCount - 1; inI++)
                                {
                                    if (inI != e.RowIndex)
                                    {
                                        int inTableRowcount = ListObj[0].Rows.Count;
                                        for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                        {
                                            if (dgvSalesInvoiceLedger.Rows[inI].Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvSalesInvoiceLedger.Rows[inI].Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                                            {
                                                if (ListObj[0].Rows[inJ]["ledgerId"].ToString() == dgvSalesInvoiceLedger.Rows[inI].Cells["dgvCmbAdditionalCostledgerName"].Value.ToString())
                                                {
                                                    ListObj[0].Rows.RemoveAt(inJ);
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvSalesInvoiceLedger[dgvSalesInvoiceLedger.Columns["dgvCmbAdditionalCostledgerName"].Index, e.RowIndex];
                            dgvccVoucherType.DataSource = ListObj[0];
                            dgvccVoucherType.ValueMember = "ledgerId";
                            dgvccVoucherType.DisplayMember = "ledgerName";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 106" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the serial no generation function to ledger grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceLedger_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNoforSalesInvoiceAccountLedger();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 107" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger cell value changed for basic calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceLedger_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvSalesInvoiceLedger.Rows[e.RowIndex].Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null && dgvSalesInvoiceLedger.Rows[e.RowIndex].Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != string.Empty)
                    {
                        LedgerGridTotalAmountCalculation();
                        foreach (DataGridViewRow dgvrow in dgvSalesInvoiceLedger.Rows)
                        {
                            if (dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value != null && dgvrow.Cells["dgvtxtAdditionalCoastledgerAmount"].Value.ToString() != string.Empty)
                            {
                                if (cmbDrorCr.SelectedIndex == 1)
                                {
                                    SiGridTotalAmountCalculation();
                                }
                            }
                        }
                    }
                    CheckInvalidEntriesOfAdditionalCost(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 108" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Bill discount text change for discount calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBillDiscount.Text.Trim() != string.Empty)
                {
                    decimal decTotal = Convert.ToDecimal(txtTotalAmount.Text.ToString());
                    decimal decGrandTotal = 0;
                    decimal decBilldiscount = Convert.ToDecimal(txtBillDiscount.Text.ToString());
                    if (decBilldiscount > decTotal)
                    {
                        txtGrandTotal.Text = "0.00";
                        txtBillDiscount.Text = "0.00";
                    }
                    else
                    {
                        decGrandTotal = decTotal - decBilldiscount;
                        txtGrandTotal.Text = decGrandTotal.ToString();
                    }
                }
                else
                {
                    txtGrandTotal.Text = txtTotalAmount.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 109" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Bill discount leave for discount calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBillDiscount.Text == string.Empty)
                {
                    txtBillDiscount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 110" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger cell click for making enable the grid columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceLedger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvSalesInvoiceLedger.Rows[e.RowIndex].Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvSalesInvoiceLedger.Rows[e.RowIndex].Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                    {
                        dgvSalesInvoiceLedger.Rows[e.RowIndex].Cells["dgvtxtAdditionalCoastledgerAmount"].ReadOnly = false;
                    }
                    else
                    {
                        dgvSalesInvoiceLedger.Rows[e.RowIndex].Cells["dgvtxtAdditionalCoastledgerAmount"].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 111" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// combobox Dr or Cr index change, call the calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDrorCr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDrorCr.SelectedIndex == 1)
                {
                    cmbCashOrbank.Visible = false;
                    lblcashOrBank.Visible = false;
                    SiGridTotalAmountCalculation();
                }
                else
                {
                    cmbCashOrbank.Visible = true;
                    lblcashOrBank.Visible = true;
                    SiGridTotalAmountCalculation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 112" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  grid EditingControlShowing event To handle the keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoice_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvSalesInvoice.CurrentCell != null && dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    if (dgvSalesInvoice.CurrentCell != null && dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvSalesInvoice.CurrentCell != null && dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceBarcode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvSalesInvoice.CurrentCell != null && dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name != "dgvtxtSalesInvoiceProductCode" && dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name != "dgvtxtSalesInvoiceProductName" && dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name != "dgvtxtSalesInvoiceBarcode")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvSalesInvoice.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;
                    if (dgvSalesInvoice.CurrentCell.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvSalesInvoice.CurrentCell.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceQty"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvSalesInvoice.CurrentCell.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountPercentage"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvSalesInvoice.CurrentCell.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceDiscountAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvSalesInvoice.CurrentCell.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceRate"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvSalesInvoice.CurrentCell.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceGrossValue"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvSalesInvoice.CurrentCell.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceNetAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else
                    {
                        TextBoxControl.KeyPress += keypresseventforOther;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 113" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid CellEndEdit for product details fill to curresponding row in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string strProductCode = string.Empty;
            string strProductName = string.Empty;
            string strBarcode = string.Empty;
            try
            {
                if (e.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceProductCode"].Index)
                {
                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value == null)
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString();
                            }
                        }
                        ProductDetailsFill(strProductCode, e.RowIndex, "ProductCode");
                    }
                    else if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString() == string.Empty)
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString();
                            }
                        }
                        ProductDetailsFill(strProductCode, e.RowIndex, "ProductCode");
                    }
                    else if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString() == "0" && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString() == "0" || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString() == "0")
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString();
                            }
                        }
                        ProductDetailsFill(strProductCode, e.RowIndex, "ProductCode");
                    }
                    gridColumnMakeEnables();
                }
                if (e.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceProductName"].Index)
                {
                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value == null)
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                            }
                        }
                        ProductDetailsFill(strProductName, e.RowIndex, "ProductName");
                    }
                    else if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString() == string.Empty)
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                            }
                        }
                        ProductDetailsFill(strProductName, e.RowIndex, "ProductName");
                    }
                    else if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString() == "0" && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString() == "0" || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString() == "0")
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductName"].Value.ToString();
                            }
                        }
                        ProductDetailsFill(strProductName, e.RowIndex, "ProductName");
                    }
                    gridColumnMakeEnables();
                }
                if (e.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoiceBarcode"].Index)
                {
                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value == null || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value == null)
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value.ToString();
                                ProductDetailsFill(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                    else if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString() == string.Empty || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString() == string.Empty)
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value.ToString();
                                ProductDetailsFill(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                    else if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSISalesOrderDetailsId"].Value.ToString() == "0" && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString() == "0" || dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQuotationDetailsId"].Value.ToString() == "0")
                    {
                        if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value != null)
                        {
                            if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceBarcode"].Value.ToString();
                                ProductDetailsFill(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                    gridColumnMakeEnables();
                }
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 114" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Total amount text change for total amount calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtGrandTotal.Text = txtTotalAmount.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 115" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Save button click Check the user privilage and call the functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (dgvSalesInvoice.RowCount == 1 || dgvSalesInvoice.Rows[0].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() == string.Empty)
                    {
                        Messages.InformationMessage("Can't save Sales Invoice without atleast one product with complete details");
                        dgvSalesInvoice.Focus();
                    }
                    else if (CheckTotalAmount(true) && CheckTotalAmountLedger(true))
                    {
                        SaveOrEditFunction();
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 116" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear button click, check the other form are opend or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                if (frmSalesinvoiceRegisterObj != null)
                {
                    frmSalesinvoiceRegisterObj.Close();
                    frmSalesinvoiceRegisterObj = null;
                }
                if (frmSalesReportObj != null)
                {
                    frmSalesReportObj.Close();
                    frmSalesReportObj = null;
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Close();
                    frmDayBookObj = null;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Close();
                    frmAgeingObj = null;
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Close();
                    objVoucherSearch = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 117" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Data error event for handle unexpected errors in ledger grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceLedger_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvSalesInvoiceLedger.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvSalesInvoiceLedger.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 118" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage())
                        {
                            DeleteFunction(decSalesInvoiceIdToEdit);
                        }
                        dgvSalesInvoice.Focus();
                    }
                    else
                    {
                        DeleteFunction(decSalesInvoiceIdToEdit);
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 119" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Close button click
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
                MessageBox.Show("SI: 120" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// form closing, checling the other forms status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmSalesinvoiceRegisterObj != null)
                {
                    frmSalesinvoiceRegisterObj.Enabled = true;
                    frmSalesinvoiceRegisterObj.gridFill();
                }
                if (frmSalesReportObj != null)
                {
                    frmSalesReportObj.Enabled = true;
                    frmSalesReportObj.gridFill();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj = null;
                }
                if (frmVatReturnReportObj != null)
                {
                    frmVatReturnReportObj.Enabled = true;
                    frmVatReturnReportObj.GridFill();
                    frmVatReturnReportObj = null;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj.FillGrid();
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                }
                if (objVoucherProduct != null)
                {
                    objVoucherProduct.Enabled = true;
                    objVoucherProduct.FillGrid();
                }
                if (frmledgerDetailsObj != null)
                {
                    frmledgerDetailsObj.Enabled = true;
                    frmledgerDetailsObj.Activate();
                    frmledgerDetailsObj.LedgerDetailsView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 121" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// "e"></param>
        /// private void cmbVoucherType combo index change 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetSalesDetailsIdToDelete();
                againstOrderComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 122" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in keypress event of bill discount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 123" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell enter event for basic fill function and calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoice_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvSalesInvoice.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvSalesInvoice.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                decimal decProductId = 0;
                IsSetGridValueChange = true;
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value != null && dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty)
                    {
                        if (dgvSalesInvoice.Columns[e.ColumnIndex].Name == "dgvtxtSalesInvoicembUnitName")
                        {
                            decCurrentConversionRate = Convert.ToDecimal(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceConversionRate"].Value.ToString());
                            decCurrentRate = Convert.ToDecimal(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                        }
                        decCurrentConversionRate = Convert.ToDecimal(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceConversionRate"].Value.ToString());
                        decCurrentRate = Convert.ToDecimal(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceRate"].Value.ToString());
                    }
                    if (e.ColumnIndex == dgvSalesInvoice.Columns["dgvcmbSalesInvoiceBatch"].Index)
                    {
                        if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value != null)
                        {
                            if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value);
                                BatchComboFill(decProductId, e.RowIndex, e.ColumnIndex);
                            }
                        }
                    }
                    if (e.ColumnIndex == dgvSalesInvoice.Columns["dgvcmbSalesInvoiceRack"].Index)
                    {
                        if (dgvSalesInvoice.CurrentRow.Cells["dgvcmbSalesInvoiceGodown"].Value != null)
                        {
                            if (dgvSalesInvoice.CurrentRow.Cells["dgvcmbSalesInvoiceGodown"].Value.ToString() != string.Empty)
                            {
                                decGodownId = Convert.ToDecimal(dgvSalesInvoice.CurrentRow.Cells["dgvcmbSalesInvoiceGodown"].Value);
                                RackComboFill(decGodownId, e.RowIndex, e.ColumnIndex);
                            }
                        }
                    }
                    if (e.ColumnIndex == dgvSalesInvoice.Columns["dgvtxtSalesInvoicembUnitName"].Index)
                    {
                        if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value != null)
                        {
                            if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductId"].Value);
                                UnitComboFill(decProductId, e.RowIndex, e.ColumnIndex);
                            }
                            else
                            {
                                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                dgvcmbUnitCell.DataSource = null;
                            }
                        }
                        else
                        {
                            DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvSalesInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            dgvcmbUnitCell.DataSource = null;
                        }
                    }
                }
                if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value != null)
                {
                    if (dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString() != string.Empty)
                    {
                        if (decimal.Parse(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceDeliveryNoteDetailsId"].Value.ToString()) > 0)
                        {
                            decDeliveryNoteQty = decimal.Parse(dgvSalesInvoice.Rows[e.RowIndex].Cells["dgvtxtSalesInvoiceQty"].Value.ToString());
                        }
                    }
                }
                SerialNoforSalesInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 124" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calling the keypress event here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceLedger_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvSalesInvoiceLedger.CurrentCell.ColumnIndex == dgvSalesInvoiceLedger.Columns["dgvtxtAdditionalCoastledgerAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 125" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Ledger grid remove button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblLedgerGridRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvSalesInvoiceLedger.SelectedCells.Count > 0 && dgvSalesInvoiceLedger.CurrentRow != null)
                {
                    if (!dgvSalesInvoiceLedger.Rows[dgvSalesInvoiceLedger.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvSalesInvoiceLedger.CurrentRow.Cells["dgvCmbAdditionalCostledgerName"].Value != null && dgvSalesInvoiceLedger.CurrentRow.Cells["dgvCmbAdditionalCostledgerName"].Value.ToString() != string.Empty)
                                {
                                    if (dgvSalesInvoiceLedger.CurrentRow.Cells["dgvtxtAdditionalCostId"].Value != null && dgvSalesInvoiceLedger.CurrentRow.Cells["dgvtxtAdditionalCostId"].Value.ToString() != string.Empty)
                                    {
                                        lstArrOfRemoveLedger.Add(dgvSalesInvoiceLedger.CurrentRow.Cells["dgvtxtAdditionalCostId"].Value.ToString());
                                    }
                                    RemoveFunctionForAdditionalCost();
                                    LedgerGridTotalAmountCalculation();
                                    SiGridTotalAmountCalculation();
                                }
                                else
                                {
                                    RemoveFunctionForAdditionalCost();
                                    LedgerGridTotalAmountCalculation();
                                    SiGridTotalAmountCalculation();
                                }
                            }
                            else
                            {
                                RemoveFunctionForAdditionalCost();
                                LedgerGridTotalAmountCalculation();
                                SiGridTotalAmountCalculation();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 126" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To bill discount calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_Enter(object sender, EventArgs e)
        {
            try
            {
                txtBillDiscount.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 127" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// NumberOnly validation on Credit perion text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreditPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.NumberOnly(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI 128:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for default value keep CreditPeriod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreditPeriod_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCreditPeriod.Text == string.Empty)
                {
                    txtCreditPeriod.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 129" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Pricing level index changed for get product rate under the pricing level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPricingLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal decBatchId = 0;
            decimal decProductId = 0;
            int inRowIndex = 0;
            try
            {
                if (dgvSalesInvoice.Rows.Count > 1)
                {
                    foreach (DataGridViewRow dgvRow in dgvSalesInvoice.Rows)
                    {
                        inRowIndex = dgvRow.Index;
                        if (dgvRow.Cells["dgvtxtSalesInvoiceProductId"].Value != null && dgvRow.Cells["dgvtxtSalesInvoiceProductId"].Value.ToString() != string.Empty)
                        {
                            if (dgvRow.Cells["dgvcmbSalesInvoiceBatch"].Value != null && dgvRow.Cells["dgvcmbSalesInvoiceBatch"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvRow.Cells["dgvtxtSalesInvoiceProductId"].Value.ToString());
                                decBatchId = Convert.ToDecimal(dgvRow.Cells["dgvcmbSalesInvoiceBatch"].Value.ToString());
                                getProductRate(inRowIndex, decProductId, decBatchId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 130" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Form key down For quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    if (dgvSalesInvoice.CurrentCell != null)
                    {
                        if (dgvSalesInvoice.CurrentCell == dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductName"] || dgvSalesInvoice.CurrentCell == dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductCode"])
                        {
                            SendKeys.Send("{F10}");
                            if (dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceProductName" || dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceProductCode")
                            {
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                frmProductCreationObj.CallFromDSalesInvoice(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 132" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCreditPeriod.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDate.Enabled == true)
                    {
                        txtDate.Focus();
                        txtDate.SelectionLength = 0;
                        txtDate.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewLedger_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbCashOrParty.Focused)
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbCashOrParty.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromSalesInvoice(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryDeptors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 133" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCustomer.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPricingLevel.Enabled == true)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else
                    {
                        cmbSalesModeOrderNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewSalesAccount_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbSalesAccount.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromSalesInvoice(this, Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString()), "SalesAccount");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any Sales Account");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 134" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCurrency.Enabled == true)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        dgvSalesInvoice.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtCustomer.Focus();
                    txtCustomer.SelectionLength = 0;
                    txtCustomer.SelectionStart = 0;
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewSalesman_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    frmEmployeePopup frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbSalesMan.SelectedIndex > -1)
                    {
                        frmEmployeePopupObj.callFromSalesInvoice(this, Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select any Sales Man");
                        cmbSalesMan.Focus();
                    }
                    if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                    {
                        SendKeys.Send("{F10}");
                        btnNewSalesman_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 135" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCreditPeriod_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMode.Focus();
                }
                if (txtCreditPeriod.Text == string.Empty || txtCreditPeriod.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        cmbCashOrParty.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 136" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbSalesMode.SelectedIndex == 0)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else
                    {
                        cmbVoucherType.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtCreditPeriod.Focus();
                    txtCreditPeriod.SelectionStart = 0;
                    txtCreditPeriod.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 137" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesModeOrderNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 138" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesModeOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPricingLevel.Enabled == true)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else
                    {
                        cmbSalesAccount.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbVoucherType.Visible == true)
                    {
                        cmbVoucherType.Focus();
                    }
                    else
                    {
                        cmbSalesMode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 139" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPricingLevel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    dgvSalesInvoice.CurrentCell = null;
                    SendKeys.Send("{F10}");
                    btnNewPricingLevel_Click(sender, e);
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesAccount.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesModeOrderNo.Visible == true)
                    {
                        cmbSalesMode.Focus();
                    }
                    else
                    {
                        cmbSalesMode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 140" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMan.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtCustomer.Text == string.Empty || txtCustomer.SelectionStart == 0)
                    {
                        cmbSalesAccount.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 141" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvSalesInvoice.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 142" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int inDgvSalesRowCount = dgvSalesInvoice.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesInvoice.CurrentCell == dgvSalesInvoice.Rows[inDgvSalesRowCount - 1].Cells["dgvtxtSalesInvoiceAmount"])
                    {
                        cmbDrorCr.Focus();
                        dgvSalesInvoice.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvSalesInvoice.CurrentCell == dgvSalesInvoice.Rows[0].Cells["dgvtxtSalesInvoiceSlno"])
                    {
                        if (cmbCurrency.Enabled == false)
                        {
                            cmbSalesMan.Focus();
                        }
                        else
                        {
                            cmbCurrency.Focus();
                        }
                        dgvSalesInvoice.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceProductName" || dgvSalesInvoice.Columns[dgvSalesInvoice.CurrentCell.ColumnIndex].Name == "dgvtxtSalesInvoiceProductCode")
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        if (dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductCode"].Value != null || dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductName"].Value != null)
                        {
                            frmProductSearchPopupObj.CallFromSalesInvoice(this, dgvSalesInvoice.CurrentRow.Index, dgvSalesInvoice.CurrentRow.Cells["dgvtxtSalesInvoiceProductCode"].Value.ToString());
                        }
                        else
                        {
                            frmProductSearchPopupObj.CallFromSalesInvoice(this, dgvSalesInvoice.CurrentRow.Index, string.Empty);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 143" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDrorCr_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbDrorCr.SelectedIndex != 1)
                    {
                        cmbCashOrbank.Focus();
                    }
                    else
                    {
                        dgvSalesInvoiceLedger.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    dgvSalesInvoice.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 144" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrbank_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvSalesInvoiceLedger.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbDrorCr.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 145" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesInvoiceLedger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int inDgvSalesRowCount = dgvSalesInvoiceLedger.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesInvoiceLedger.CurrentCell == dgvSalesInvoiceLedger.Rows[inDgvSalesRowCount - 1].Cells["dgvtxtAdditionalCoastledgerAmount"])
                    {
                        txtTransportCompany.Focus();
                        dgvSalesInvoiceLedger.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvSalesInvoiceLedger.CurrentCell == dgvSalesInvoiceLedger.Rows[0].Cells["dgvtxtAditionalCostSlno"])
                    {
                        cmbCurrency.Focus();
                        dgvSalesInvoiceLedger.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 146" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTransportCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVehicleNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtTransportCompany.Text == string.Empty || txtTransportCompany.SelectionStart == 0)
                    {
                        dgvSalesInvoiceTax.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 147" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVehicleNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBillDiscount.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVehicleNo.Text == string.Empty || txtVehicleNo.SelectionStart == 0)
                    {
                        txtTransportCompany.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 148" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBillDiscount.Text == string.Empty || txtBillDiscount.SelectionStart == 0)
                    {
                        txtVehicleNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 149" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        cbxPrintAfterSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        txtBillDiscount.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 150" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPrintAfterSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 151" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnClear.Enabled)
                    {
                        btnClear.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    cbxPrintAfterSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 152" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 153" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrParty.Focus();
                }
                if (txtDate.Text == string.Empty || txtDate.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (!txtInvoiceNo.ReadOnly)
                        {
                            txtInvoiceNo.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 154" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}