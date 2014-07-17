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
    public partial class frmPOS : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        ArrayList lstArrOfRemove = new ArrayList();
        SalesMasterInfo InfoSalesMaster = new SalesMasterInfo();
        SalesDetailsInfo InfoSalesDetails = new SalesDetailsInfo();
        StockPostingInfo infoStockPosting = new StockPostingInfo();
        PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
        SalesBillTaxInfo InfoSalesBillTax = new SalesBillTaxInfo();
        //SalesMasterSP spSalesMaster = new SalesMasterSP();
        LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
        PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
        //StockPostingSP spStockPosting = new StockPostingSP();
        StockPostingBll BllStockPosting = new StockPostingBll();
        SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();

        decimal DecPOSVoucherTypeId = 0;        //to get the selected voucher type id from frmVoucherTypeSelection       
        decimal decPOSSuffixPrefixId = 0;
        decimal decProductId = 0;               //to fill product using barcode
        decimal decBatchId;
        decimal decCurrentConversionRate;
        decimal decCurrentRate;
        decimal decSalesMasterId = 0;
        decimal decSalesDetailsId = 0;
        string strCashOrParty;
        string strSalesAccount;
        string strCounter;
        string strSalesMan;
        string strPrefix = string.Empty;        //to get the prefix string from frmvouchertypeselection
        string strSuffix = string.Empty;        //to get the suffix string from frmvouchertypeselection
        string strVoucherNo = string.Empty;
        string strTableName = "SalesMaster";
        string strCurrencySymbol = "";
        int rowIdToEdit = 0;
        int maxSerialNo = 0;
        int inNarrationCount = 0;
        bool isAutomatic = false;               //to check whether the voucher number is automatically generated or not
        bool isdontExecuteTextchange = false;
        bool isFromSalesAccountCombo = false;   // for add new new account via button click
        bool isFromCashOrPartyCombo = false;    // for add new new account via button click
        bool isFromSalesManCombo = false;
        bool isFormIdtoEdit = false;
        bool isFromCounterCombo = false;
        bool isAfterFillControls = false;
        bool isFromDiscAmt = false;
        bool isFromBarcode = false;

        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        frmSalesman frmSalesmanObj = new frmSalesman();
        frmSalesInvoiceRegister objfrmSalesInvoiceRegister;
        frmSalesReport frmSalesReportObj;
        frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();//to use in call from account ledger function
        frmDayBook frmDayBookObj = null;       //To use in call from frmDayBook
        frmAgeingReport frmAgeingObj = null;   //To use in call from frmDayBook
        frmVoucherSearch objVoucherSearch = null;
        frmVoucherWiseProductSearch objVoucherProduct = null;
        frmVatReturnReport frmvatReturnReportObj = null;
        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
        frmLedgerDetails frmledgerDetailsObj;
        #endregion
        #region Functions
        /// <summary>
        /// Create an instance for frmPOS Class
        /// </summary>
        public frmPOS()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="decPOSVoucherTypeId"></param>
        /// <param name="strPOSVoucheTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decPOSVoucherTypeId, string strPOSVoucheTypeName)
        {
            decimal decDailySuffixPrefixId = 0;
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DecPOSVoucherTypeId = decPOSVoucherTypeId;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(DecPOSVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(DecPOSVoucherTypeId, dtpDate.Value);
                decDailySuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                this.Text = strPOSVoucheTypeName;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Functions to clear the form controls based on the settings
        /// </summary>
        public void ClearFunctions()
        {
            try
            {
                CurrencyBll BllCurrency = new CurrencyBll();
                SettingsBll BllSettings = new SettingsBll();
                strCurrencySymbol = BllCurrency.CurrencyView(PublicVariables._decCurrencyId).CurrencySymbol;
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    cmbGodown.Visible = true;
                    lblGodown.Visible = true;
                }
                else
                {
                    cmbGodown.Visible = false;
                    lblGodown.Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    cmbRack.Visible = true;
                    lblRack.Visible = true;
                }
                else
                {
                    cmbRack.Visible = false;
                    lblRack.Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    cmbBatch.Visible = true;
                    lblBatch.Visible = true;
                }
                else
                {
                    cmbBatch.Visible = false;
                    lblBatch.Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    lblProductcode.Visible = true;
                    txtProductCode.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtProductCode"].Visible = true;
                }
                else
                {
                    lblProductcode.Visible = false;
                    txtProductCode.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtProductCode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("Barcode") == "Yes")
                {
                    lblBarcode.Visible = true;
                    txtBarcode.Visible = true;
                }
                else
                {
                    lblBarcode.Visible = false;
                    txtBarcode.Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowDiscountAmount") == "Yes")
                {
                    txtDiscountAmount.Visible = true;
                    lblDiscountAmt.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtDiscount"].Visible = true;
                }
                else
                {
                    txtDiscountAmount.Visible = false;
                    lblDiscountAmt.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtDiscount"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowDiscountPercentage") == "Yes")
                {
                    txtDiscountPercentage.Visible = true;
                    lblDiscountPercentage.Visible = true;
                }
                else
                {
                    txtDiscountPercentage.Visible = false;
                    lblDiscountPercentage.Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    cmbUnit.Visible = true;
                    lblUnit.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtUnit"].Visible = true;
                }
                else
                {
                    cmbUnit.Visible = false;
                    lblUnit.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtUnit"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("Tax") == "Yes")
                {
                    cmbTax.Visible = true;
                    lblTax.Visible = true;
                    txtTaxAmount.Visible = true;
                    lblTaxAmount.Visible = true;
                    lblTaxTotalAmount.Visible = true;
                    lblLedgerTotal.Visible = true;
                    dgvPointOfSales.Columns["dgvtxtTaxPercentage"].Visible = true;
                    dgvPointOfSales.Columns["dgvtxtTaxAmount"].Visible = true;
                    dgvPOSTax.Visible = true;
                }
                else
                {
                    cmbTax.Visible = false;
                    lblTax.Visible = false;
                    txtTaxAmount.Visible = false;
                    lblTaxAmount.Visible = false;
                    lblTaxTotalAmount.Visible = false;
                    lblLedgerTotal.Visible = false;
                    dgvPointOfSales.Columns["dgvtxtTaxPercentage"].Visible = false;
                    dgvPointOfSales.Columns["dgvtxtTaxAmount"].Visible = false;
                    dgvPOSTax.Visible = false;
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.CustomFormat = "dd-MMMM-yyyy";
                CashorPartyComboFill();
                PricingLevelComboFill();
                salesManComboFill();
                SalesAccountComboFill();
                CounterComboFill();
                ItemComboFill();
                taxGridFill();
                cmbTaxComboFill();
                if (isAutomatic)
                {
                    VoucherNumberGeneration();
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                cmbPricingLevel.SelectedIndex = 0;
                cmbSalesAccount.SelectedIndex = 0;
                cmbCashOrParty.SelectedIndex = 0;
                cmbSalesMan.SelectedIndex = 0;
                cmbCounter.SelectedIndex = 0;
                txtBarcode.Clear();
                txtProductCode.Clear();
                cmbItem.SelectedIndex = -1;
                txtQuantity.Text = "0";
                txtRate.Text = "0";
                txtDiscountAmount.Text = "0";
                dgvPointOfSales.Rows.Clear();
                txtNarration.Clear();
                txtPaidAmount.Text = "0";
                txtBalance.Text = "0";
                txtTotalAmount.Text = "0";
                txtBillDiscount.Text = "0";
                txtGrandTotal.Text = "0";
                lblTaxTotalAmount.Text = "00.00";
                btnDelete.Enabled = false;
                btnSave.Text = "Save";
                btnClear.Text = "Clear";
                if (!txtVoucherNo.ReadOnly)
                {
                    txtVoucherNo.Clear();
                    txtVoucherNo.Focus();
                }
                else
                {
                    if (BllSettings.SettingsStatusCheck("Barcode") == "Yes")
                    {
                        txtBarcode.Select();
                    }
                    else
                    {
                        txtProductCode.Select();
                    }
                }
                ClearGroupbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear the form Groupbox controls
        /// </summary>
        public void ClearGroupbox()
        {
            try
            {
                isdontExecuteTextchange = true;
                txtBarcode.Clear();
                txtProductCode.Clear();
                cmbItem.SelectedIndex = -1;
                cmbGodown.SelectedIndex = -1;
                cmbUnit.SelectedIndex = -1;
                cmbRack.SelectedIndex = -1;
                cmbBatch.SelectedIndex = -1;
                txtQuantity.Text = "0";
                txtRate.Text = "0";
                txtGrossValue.Text = "0";
                txtTaxAmount.Text = "0";
                cmbTax.SelectedIndex = -1;
                txtAmount.Text = "0";
                txtNetAmount.Text = "0";
                txtDiscountPercentage.Text = "0";
                txtDiscountAmount.Text = "0";
                isdontExecuteTextchange = false;
                btnAdd.Text = "Add";
                rowIdToEdit = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate Voucher number as per settings
        /// </summary>
        public void VoucherNumberGeneration()
        {
            try
            {
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecPOSVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                if (Convert.ToDecimal(strVoucherNo) != (BllSalesInvoice.SalesMasterVoucherMax(DecPOSVoucherTypeId)))
                {
                    strVoucherNo = BllSalesInvoice.SalesMasterVoucherMax(DecPOSVoucherTypeId).ToString();
                    strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecPOSVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                    if (BllSalesInvoice.SalesMasterVoucherMax(DecPOSVoucherTypeId) == 0)
                    {
                        strVoucherNo = "0";
                        strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(DecPOSVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                    }
                }
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(DecPOSVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decPOSSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    txtVoucherNo.Text = strPrefix + strVoucherNo + strSuffix;
                    txtVoucherNo.ReadOnly = true;
                }
                else
                {
                    txtVoucherNo.ReadOnly = false;
                    txtVoucherNo.Text = string.Empty;
                    strVoucherNo = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the cash or party combobox
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
                MessageBox.Show("POS:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the cash or party combobox in Edit mode
        /// </summary>
        public void CashorPartyComboFill()
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Pricing Level Combo Fill
        /// </summary>
        public void PricingLevelComboFill()
        {
            try
            {
                TransactionGeneralFillObj.PricingLevelViewAll(cmbPricingLevel, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Function to use the salesMan Combo Fill
        /// </summary>
        public void salesManComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
                listObj = TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
                cmbSalesMan.DataSource = listObj[0];
                cmbSalesMan.ValueMember = "employeeId";
                cmbSalesMan.DisplayMember = "employeeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Sales Account Combo Fill
        /// </summary>
        public void SalesAccountComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = BllSalesInvoice.SalesInvoiceSalesAccountModeComboFill();
                cmbSalesAccount.DataSource = listObj[0];
                cmbSalesAccount.DisplayMember = "ledgerName";
                cmbSalesAccount.ValueMember = "ledgerId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Function to use the Counter Combo Fill
        /// </summary>
        public void CounterComboFill()
        {
            CounterBll bllCounter = new CounterBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = bllCounter.CounterOnlyViewAll();
                cmbCounter.DataSource = listObj[0];
                cmbCounter.DisplayMember = "counterName";
                cmbCounter.ValueMember = "counterId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Function to use the Unit Combo Fill
        /// </summary>
        public void UnitComboFill()
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAllByProductId(decProductId); ;
                cmbUnit.DataSource = ListObj[0];
                cmbUnit.ValueMember = "unitId";
                cmbUnit.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Godown Combo Fill
        /// </summary>
        public void GodownComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                GodownBll BllGodown = new GodownBll();
                listObj = BllGodown.GodownViewAll();
                cmbGodown.DataSource = listObj[0];
                cmbGodown.ValueMember = "godownId";
                cmbGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Rack Combo Fill
        /// </summary>
        public void RackComboFill()
        {
            try
            {
               
                List<DataTable> listObjRack = new List<DataTable>();
                RackBll BllRack = new RackBll();
                listObjRack = BllRack.RackViewAll();
                cmbRack.DataSource = listObjRack[0];
                cmbRack.ValueMember = "rackId";
                cmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Rack Combo Fill by under the Godown
        /// </summary>
        /// <param name="dcGodownId"></param>
        public void RackComboFillByGodownId(decimal dcGodownId)
        {
            try
            {
                List<DataTable> listObjRack = new List<DataTable>();
                
                RackBll BllRack = new RackBll();
                listObjRack = BllRack.RackNamesCorrespondingToGodownId(dcGodownId);
                cmbRack.DataSource = listObjRack[0];
                cmbRack.ValueMember = "rackId";
                cmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Tax Combo Fill 
        /// </summary>
        public void cmbTaxComboFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllByVoucherTypeIdApplicaleForProduct(DecPOSVoucherTypeId);               
                DataRow dr = ListObj[0].NewRow();
                dr[1] = "NA";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbTax.DataSource = ListObj[0];
                cmbTax.ValueMember = "taxId";
                cmbTax.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Items Combo Fill 
        /// </summary>
        public void ItemComboFill()
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllProductCreation.ProductViewAll();
                cmbItem.DataSource = listObj[0];
                cmbItem.ValueMember = "productId";
                cmbItem.DisplayMember = "productName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Tax Combo Fill 
        /// </summary>
        public void ComboTaxFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewByProductIdApplicableForProduct(decProductId);
                cmbTax.DataSource = ListObj[0];
                cmbTax.ValueMember = "taxId";
                cmbTax.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Batch Combo Fill based on the product
        /// </summary>
        public void batchcombofill()
        {
            try
            {
                BatchBll BllBatch = new BatchBll();
                List<DataTable> listBatch = new List<DataTable>();
                listBatch = BllBatch.BatchNoViewByProductId(decProductId);
                cmbBatch.DataSource = listBatch[0];
                cmbBatch.ValueMember = "batchId";
                cmbBatch.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Tax grid
        /// </summary>
        public void taxGridFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                ListObj = bllTax.TaxViewAllByVoucherTypeId(DecPOSVoucherTypeId);
                dgvPOSTax.DataSource = ListObj[0];
                this.dgvPOSTax.Columns["dgvtxtTaxAmt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create one account ledger from this form
        /// </summary>
        public void AccountLedgerCreation()
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmAccountLedger", "Save"))
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
                    frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                    if (open == null)
                    {
                        frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                        frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                        frmAccountLedgerObj.callFromPOS(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.callFromPOS(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    this.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You don’t have privilege", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decAccountLedgerId"></param>
        public void ReturnFromAccountLedgerForm(decimal decAccountLedgerId)
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
                MessageBox.Show("POS: 22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to fill the Salesman combofill
        /// </summary>
        /// <param name="cmbSalesAccount"></param>
        public void SalesAccountComboFill(ComboBox cmbSalesAccount)
        {
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
                MessageBox.Show("POS :22 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Function to fill SalesAccount combobox while return from SalesAccount creation when creating new SalesAccount 
        /// </summary>
        /// <param name="decAccountLedgerId"></param>
        public void ReturnFromSalesAccount(decimal decAccountLedgerId)
        {
            try
            {
                this.Enabled = true;
                SalesAccountComboFill(cmbSalesAccount);
                if (decAccountLedgerId != 0)
                {
                    cmbSalesAccount.SelectedValue = decAccountLedgerId;
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
                MessageBox.Show("POS: 23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to fill Counter combobox while return from Counter creation when creating new Counter 
        /// </summary>
        /// <param name="decCounterId"></param>
        public void ReturnFromCounter(decimal decCounterId)
        {
            try
            {
                this.Enabled = true;
                CounterComboFill();
                if (decCounterId != 0)
                {
                    cmbCounter.SelectedValue = decCounterId;
                }
                else if (strCounter != string.Empty)
                {
                    cmbCounter.SelectedValue = strCounter;
                }
                else
                {
                    cmbCounter.SelectedValue = -1;
                }
                cmbCounter.Focus();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fil Controls based on the barcode
        /// </summary>
        /// <param name="strBarcode"></param>
        public void FillControlsByBarcode(string strBarcode)
        {
            try
            {
                BatchInfo infoBatch = new BatchInfo();
                BatchBll BllBatch = new BatchBll();
                PriceListInfo InfoPriceList = new PriceListInfo();
                PriceListBll BllPriceList = new PriceListBll();
                infoBatch = BllBatch.BatchAndProductViewByBarcode(strBarcode);
                cmbBatch.Text = infoBatch.BatchNo;
                decProductId = infoBatch.ProductId;
                decBatchId = infoBatch.BatchId;
                InfoPriceList = BllPriceList.PriceListViewByBatchIdORProduct(decBatchId);
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                infoProduct = BllProductCreation.ProductView(decProductId);
                txtProductCode.Text = infoProduct.ProductCode;
                string strProductCode = infoProduct.ProductCode;
                isFromBarcode = true;
                cmbItem.Text = infoProduct.ProductName;
                isFromBarcode = false;
                cmbGodown.SelectedValue = infoProduct.GodownId;
                cmbRack.SelectedValue = infoProduct.RackId;
                UnitComboFill();
                UnitInfo infoUnit = new UnitInfo();
                infoUnit = new UnitBll().unitVieWForStandardRate(decProductId);
                cmbUnit.SelectedValue = infoUnit.UnitId;
                if (InfoPriceList.PricinglevelId != 0)
                {
                    cmbPricingLevel.SelectedValue = InfoPriceList.PricinglevelId;
                }
                else
                {
                    cmbPricingLevel.SelectedIndex = 0;
                }
                ComboTaxFill();
                cmbTax.SelectedValue = infoProduct.TaxId;
                if (txtProductCode.Text.Trim() != string.Empty && cmbItem.SelectedIndex != -1)
                {
                    decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                    decimal dcRate = BllProductCreation.ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                    txtRate.Text = dcRate.ToString();
                    try
                    {
                        if (decimal.Parse(txtQuantity.Text) == 0)
                            txtQuantity.Text = "1";
                    }
                    catch { txtQuantity.Text = "1"; }
                    txtQuantity.Focus();

                }
                else
                {
                    txtRate.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fil Controls based on the ProductCode
        /// </summary>
        /// <param name="isCode"></param>
        public void FillControlByProductCode(bool isCode)
        {
            decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
            try
            {
                if (isCode)
                {
                    PriceListInfo InfoPriceList = new PriceListInfo();
                    ProductInfo infoProduct = new ProductInfo();
                    ProductBatchInfo infoProductBatch = new ProductBatchInfo();
                    ProductCreationBll BllProductCreation = new ProductCreationBll();
                    PriceListBll BllPriceList = new PriceListBll();
                    infoProduct = BllProductCreation.ProductViewByCode(txtProductCode.Text.Trim());
                    infoProductBatch = BllProductCreation.BarcodeViewByProductCode(txtProductCode.Text);
                    decProductId = infoProductBatch.ProductId;
                    decBatchId = infoProductBatch.BatchId;
                    InfoPriceList = BllPriceList.PriceListViewByBatchIdORProduct(decBatchId);
                    batchcombofill();
                    txtBarcode.Text = infoProductBatch.Barcode;
                    cmbItem.Text = infoProduct.ProductName;
                    cmbGodown.SelectedValue = infoProduct.GodownId;
                    cmbRack.SelectedValue = infoProduct.RackId;
                    UnitComboFill();
                    UnitInfo infoUnit = new UnitInfo();
                    infoUnit = new UnitBll().unitVieWForStandardRate(decProductId);
                    cmbUnit.SelectedValue = infoUnit.UnitId;
                    if (InfoPriceList.PricinglevelId != 0)
                    {
                        cmbPricingLevel.SelectedValue = InfoPriceList.PricinglevelId;
                    }
                    else
                    {
                        cmbPricingLevel.SelectedIndex = 0;
                    }
                    ComboTaxFill();
                    cmbTax.SelectedValue = infoProduct.TaxId;
                    if (txtProductCode.Text.Trim() != String.Empty && cmbItem.SelectedIndex != -1)
                    {
                        decimal dcRate = BllProductCreation.ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                        txtRate.Text = dcRate.ToString();
                        try
                        {
                            if (decimal.Parse(txtQuantity.Text) == 0)
                                txtQuantity.Text = "1";
                        }
                        catch { txtQuantity.Text = "1"; }
                        txtQuantity.Focus();

                    }
                    else
                    {
                        decimal dcRate = BllProductCreation.ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                        txtRate.Text = dcRate.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to fil Controls based on the ProductName
        /// </summary>
        /// <param name="decProductId"></param>
        public void FillControlsByProductName(decimal decProductId)
        {
            try
            {
                PriceListInfo InfoPriceList = new PriceListInfo();
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                PriceListBll BllPriceList = new PriceListBll();
                ProductBatchInfo infoProductBatch = new ProductBatchInfo();
                infoProduct = BllProductCreation.ProductView(decProductId);
                txtProductCode.Text = infoProduct.ProductCode;
                infoProductBatch = BllProductCreation.BarcodeViewByProductCode(txtProductCode.Text);
                decProductId = infoProductBatch.ProductId;
                decBatchId = infoProductBatch.BatchId;
                InfoPriceList = BllPriceList.PriceListViewByBatchIdORProduct(decBatchId);
                batchcombofill();
                txtBarcode.Text = infoProductBatch.Barcode;
                cmbItem.Text = infoProduct.ProductName;
                cmbGodown.SelectedValue = infoProduct.GodownId;
                cmbRack.SelectedValue = infoProduct.RackId;
                UnitComboFill();
                UnitInfo infoUnit = new UnitInfo();
                infoUnit = new UnitBll().unitVieWForStandardRate(decProductId);
                cmbUnit.SelectedValue = infoUnit.UnitId;
                if (InfoPriceList.PricinglevelId != 0)
                {
                    cmbPricingLevel.SelectedValue = InfoPriceList.PricinglevelId;
                }
                else
                {
                    cmbPricingLevel.SelectedIndex = 0;
                }
                ComboTaxFill();
                cmbTax.SelectedValue = infoProduct.TaxId;
                if (txtProductCode.Text.Trim() != string.Empty && cmbItem.SelectedIndex != -1)
                {
                    decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                    decimal dcRate = BllProductCreation.ProductRateForSales(decProductId, Convert.ToDateTime(txtDate.Text), decBatchId, decNodecplaces);
                    txtRate.Text = dcRate.ToString();
                    try
                    {
                        if (decimal.Parse(txtQuantity.Text) == 0)
                            txtQuantity.Text = "1";
                    }
                    catch { txtQuantity.Text = "1"; }
                    txtQuantity.Focus();

                }
                TaxAmountCalculation();
                isAfterFillControls = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the gross amount
        /// </summary>
        public void GrossValueCalculation()
        {
            decimal dcRate = 0;
            decimal dcQty = 0;
            decimal dcGrossValue = 0;
            try
            {
                if (txtQuantity.Text.Trim() == String.Empty)
                {
                    txtQuantity.Text = "0";
                }
                dcQty = Convert.ToDecimal(txtQuantity.Text.Trim());
                if (txtRate.Text.Trim() == string.Empty)
                {
                    txtRate.Text = "0";
                }
                dcRate = Convert.ToDecimal(txtRate.Text.Trim());
                if (dcRate > 0)
                {
                    dcGrossValue = dcQty * dcRate;
                    txtGrossValue.Text = Math.Round(dcGrossValue, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
                else
                {
                    txtGrossValue.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Tax Amount Calculation
        /// </summary>
        public void TaxAmountCalculation()
        {
            decimal dcVatAmount = 0;
            decimal dTaxAmt = 0;
            decimal dcTotal = 0;
            decimal dcNetAmount = 0;
            dcNetAmount = Convert.ToDecimal(txtNetAmount.Text.Trim());
            TaxBll bllTax = new TaxBll();
            try
            {
                if (dcNetAmount != 0 && cmbTax.Visible && cmbTax.SelectedValue != null)
                {
                    TaxInfo InfoTaxMaster = bllTax.TaxView(Convert.ToDecimal(cmbTax.SelectedValue.ToString()));
                    dcVatAmount = dTaxAmt = Math.Round(((dcNetAmount * InfoTaxMaster.Rate) / (100)), PublicVariables._inNoOfDecimalPlaces);
                    txtTaxAmount.Text = dTaxAmt.ToString();
                }
                else
                {
                    dTaxAmt = 0;
                    txtTaxAmount.Text = "0";
                }
                dcTotal = dcNetAmount + dTaxAmt;
                txtAmount.Text = dcTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Discount Calculation
        /// </summary>
        public void DiscountCalculation()
        {
            decimal dcDiscountAmount = 0;
            decimal dcDiscountPercentage = 0;
            decimal dcGrossValue = 0;
            decimal dcNetValue = 0;
            try
            {
                if (txtGrossValue.Text.Trim() != null && txtGrossValue.Text.Trim() != string.Empty)
                {
                    dcGrossValue = Convert.ToDecimal(txtGrossValue.Text.Trim());
                }
                if (txtDiscountPercentage.Text.Trim() != null && txtDiscountPercentage.Text.Trim() != string.Empty)
                {
                    dcDiscountPercentage = Convert.ToDecimal(txtDiscountPercentage.Text.Trim());
                }
                if (dcDiscountPercentage > 100)
                {
                    dcDiscountPercentage = 100;
                    txtDiscountPercentage.Text = dcDiscountPercentage.ToString();
                }
                if (dcDiscountPercentage != 0)
                {
                    dcDiscountAmount = dcGrossValue * dcDiscountPercentage / 100;
                    txtDiscountAmount.Text = Math.Round(dcDiscountAmount, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
                else
                {
                    txtDiscountAmount.Text = "0";
                }
                dcNetValue = dcGrossValue;
                if (dcGrossValue > 0)
                {
                    if (txtDiscountPercentage.Text.Trim() != null && txtDiscountPercentage.Text.Trim() != string.Empty)
                    {
                        dcNetValue = dcGrossValue - dcDiscountAmount;
                        txtNetAmount.Text = Math.Round(dcNetValue, PublicVariables._inNoOfDecimalPlaces).ToString();
                    }
                    else
                    {
                        txtNetAmount.Text = dcNetValue.ToString();
                    }
                }
                else
                {
                    txtNetAmount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Discount Percentage Calculation
        /// </summary>
        public void DiscountPerCalculation()
        {
            decimal dcGrossValue = 0;
            decimal dcDiscountAmount = 0;
            decimal dcDiscountPercentage = 0;
            try
            {

                if (txtGrossValue.Text.Trim() != null && txtGrossValue.Text.Trim() != string.Empty)
                {
                    dcGrossValue = Convert.ToDecimal(txtGrossValue.Text.Trim());
                }
                if (txtDiscountAmount.Text.Trim() != null && txtDiscountAmount.Text.Trim() != string.Empty)
                {
                    dcDiscountAmount = Convert.ToDecimal(txtDiscountAmount.Text.Trim());
                }
                if (dcGrossValue > 0)
                {
                    if (txtDiscountAmount.Text.Trim() != null && txtDiscountAmount.Text.Trim() != string.Empty)
                    {
                        dcDiscountPercentage = dcDiscountAmount * 100 / dcGrossValue;
                        txtDiscountPercentage.Text = Math.Round(dcDiscountPercentage, PublicVariables._inNoOfDecimalPlaces).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Function to Serial No for POS Tax
        /// </summary>
        public void SerialNoforPOSTax()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvPOSTax.Rows)
                {
                    row.Cells["dgvtxtSINO"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Serial No for POS 
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvPointOfSales.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to add the products to grid
        /// </summary>
        public void AddToGrid()
        {
            BatchBll BllBatch = new BatchBll();
            GodownBll BllGodown = new GodownBll();
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (txtProductCode.Text.Trim() == null && txtProductCode.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter product code");
                    txtProductCode.Focus();
                }
                else if (cmbItem.SelectedIndex == -1 && cmbItem.SelectedValue == null)
                {
                    Messages.InformationMessage("Select a product");
                    cmbItem.Focus();
                }
                else if (Convert.ToDecimal(txtQuantity.Text.Trim()) <= 0 || txtQuantity.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter quantity");
                    txtQuantity.Focus();
                }
                else if (cmbUnit.SelectedValue == null)
                {
                    Messages.InformationMessage("Select a unit");
                    cmbUnit.Focus();
                }
                else if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && decimal.Parse(txtRate.Text.Trim()) <= 0 || txtRate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter rate");
                    txtRate.Focus();
                }
                else
                {
                    int inCurrentRowIndex = new int();
                    bool isExecutef = false;
                    if (rowIdToEdit == 0)
                    {
                        dgvPointOfSales.Rows.Add();
                        inCurrentRowIndex = dgvPointOfSales.Rows.Count - 1;
                        isExecutef = true;
                    }
                    else
                    {
                        for (int i = 0; i < dgvPointOfSales.Rows.Count; ++i)
                        {
                            if (dgvPointOfSales.Rows[i].Cells["rowId"].Value.ToString() == rowIdToEdit.ToString())
                            {
                                isExecutef = true;
                                inCurrentRowIndex = i;
                                break;
                            }
                        }
                    }
                    if (!isExecutef)
                    {
                        dgvPointOfSales.Rows.Add();
                        inCurrentRowIndex = dgvPointOfSales.Rows.Count - 1;
                    }
                    ProductInfo infoProduct = new ProductInfo();
                    BatchInfo infoBatch = new BatchInfo();
                    RackInfo infoRack = new RackInfo();
                    ProductCreationBll BllProductCreation = new ProductCreationBll();
                    UnitConvertionInfo InfoUnitConvertion = new UnitConvertionInfo();
                    infoProduct = BllProductCreation.ProductView(decProductId);
                    decimal dcProductBatch = BllBatch.BatchIdViewByProductId(decProductId);
                    InfoUnitConvertion = new UnitConvertionBll().UnitViewAllByProductId(decProductId);
                    infoBatch = BllBatch.BatchView(dcProductBatch);
                    decimal dcGodownId = infoProduct.GodownId;
                    GodownInfo infoGodown = new GodownInfo();
                    infoGodown = BllGodown.GodownView(dcGodownId);
                    decimal dcRackId = infoProduct.RackId;
                    infoRack = new RackBll().RackView(dcRackId);
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtProductCode"].Value = txtProductCode.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtProductName"].Value = cmbItem.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtQuantity"].Value = txtQuantity.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtUnit"].Value = cmbUnit.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = txtRate.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtGrossValue"].Value = txtGrossValue.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtTaxPercentage"].Value = cmbTax.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtTaxAmount"].Value = txtTaxAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtNetAmount"].Value = txtNetAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtDiscount"].Value = txtDiscountAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtTotalAmount"].Value = txtAmount.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxttaxid"].Value = Convert.ToDecimal(cmbTax.SelectedValue);
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtProductId"].Value = infoProduct.ProductId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtBatchId"].Value = dcProductBatch;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtRackId"].Value = infoProduct.RackId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtGodownId"].Value = infoProduct.GodownId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtUnitId"].Value = Convert.ToDecimal(cmbUnit.SelectedValue);
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtunitconversionId"].Value = InfoUnitConvertion.UnitconvertionId;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtBarcode"].Value = txtBarcode.Text;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtBatchno"].Value = infoBatch.BatchNo;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtGodownName"].Value = infoGodown.GodownName;
                    dgvPointOfSales.Rows[inCurrentRowIndex].Cells["dgvtxtRackName"].Value = infoRack.RackName;
                    TotalAmountCalculation();
                    ClearGroupbox();
                    dgvPointOfSales.CurrentCell = dgvPointOfSales[0, dgvPointOfSales.Rows.Count - 1];
                    txtBarcode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the Total amount
        /// </summary>
        public void TotalAmountCalculation()
        {
            TaxGridAmountCalculation();
            TaxTotal();
            decimal dTotal = 0;
            decimal dcTotal = 0;
            decimal dcTaxTotal = 0;
            decimal dcTotalAmount = 0;
            try
            {
                foreach (DataGridViewRow dgvrow in dgvPointOfSales.Rows)
                {
                    if (dgvrow.Cells["dgvtxtTaxAmount"].Value != null)
                    {
                        dcTotal = dcTotal + decimal.Parse(dgvrow.Cells["dgvtxtTaxAmount"].Value.ToString());
                    }
                }
                foreach (DataGridViewRow dgvrow in dgvPointOfSales.Rows)
                {
                    if (dgvrow.Cells["dgvtxtTotalAmount"].Value != null && dgvrow.Cells["dgvtxtTotalAmount"].Value.ToString() != string.Empty)
                    {
                        dcTotalAmount = dcTotalAmount + Convert.ToDecimal(dgvrow.Cells["dgvtxtTotalAmount"].Value.ToString());
                    }
                }
                if (dgvPOSTax.Rows.Count > 0)
                {
                    dcTaxTotal = Convert.ToDecimal(lblTaxTotalAmount.Text.Trim());
                    dTotal = dcTaxTotal - dcTotal;
                    txtTotalAmount.Text = (dcTotalAmount + dTotal).ToString();
                }
                else
                {
                    txtTotalAmount.Text = dcTotalAmount.ToString();
                }
                decimal dcTOT = Convert.ToDecimal(txtTotalAmount.Text);
                try
                {
                    decimal.Parse(txtBillDiscount.Text);
                }
                catch
                {
                    txtBillDiscount.Text = "0";
                }
                decimal dcGrandTotal = dcTOT - Convert.ToDecimal(txtBillDiscount.Text);
                txtGrandTotal.Text = dcGrandTotal.ToString();
                decimal dcBalance = 0;
                if (txtPaidAmount.Text != string.Empty)
                {
                    dcBalance = Convert.ToDecimal(txtPaidAmount.Text) - dcGrandTotal;
                }
                else
                {
                    dcBalance = dcBalance - dcGrandTotal;
                }
                txtBalance.Text = dcBalance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the total amount
        /// </summary>
        public void TaxTotal()
        {
            try
            {
                decimal dTaxTot = 0;
                foreach (DataGridViewRow dgvrow in dgvPOSTax.Rows)
                {
                    if (dgvrow.Cells["dgvtxtTaxAmt"].Value != null && dgvrow.Cells["dgvtxtTaxAmt"].Value.ToString() != string.Empty && dgvrow.Cells["dgvtxtTaxAmt"].Value.ToString() != "0")
                    {
                        dTaxTot = dTaxTot + Convert.ToDecimal(dgvrow.Cells["dgvtxtTaxAmt"].Value.ToString());
                    }
                }
                dTaxTot = Math.Round(dTaxTot, PublicVariables._inNoOfDecimalPlaces);
                lblTaxTotalAmount.Text = dTaxTot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the tax amount under tax type
        /// </summary>
        public void TaxAmountForTaxType()
        {
            decimal dTotal = 0;
            try
            {
                foreach (DataGridViewRow dgvrowTax in dgvPOSTax.Rows)
                {
                    foreach (DataGridViewRow dgvrowProduct in dgvPointOfSales.Rows)
                    {
                        if (dgvrowProduct.Cells["dgvtxtTaxPercentage"].Value != null && dgvrowProduct.Cells["dgvtxtTaxAmount"].Value != null)
                        {
                            if (dgvrowProduct.Cells["dgvtxtTaxPercentage"].Value.ToString() != string.Empty && dgvrowProduct.Cells["dgvtxtTaxAmount"].Value.ToString() != string.Empty)
                            {
                                if (dgvrowProduct.Cells["dgvtxttaxid"].Value.ToString() == dgvrowTax.Cells["dgvtxttax"].Value.ToString())
                                {
                                    dTotal = dTotal + Convert.ToDecimal(dgvrowProduct.Cells["dgvtxtTaxAmount"].Value.ToString());
                                    dTotal = Math.Round(dTotal, PublicVariables._inNoOfDecimalPlaces);
                                }
                            }
                        }
                    }
                    dgvrowTax.Cells["dgvtxtTaxAmt"].Value = dTotal.ToString();
                    dTotal = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get tax grid total amount calculation
        /// </summary>
        public void TaxGridAmountCalculation()
        {
            decimal dTotal = 0;
            decimal decTaxId = 0;
            decimal decTaxRate = 0;
            decimal dcTCessTotal = 0;
            decimal decTaxTotal;
            try
            {
                TaxAmountForTaxType();
                foreach (DataGridViewRow dgvrow in dgvPointOfSales.Rows)
                {
                    if (dgvrow.Cells["dgvtxtTotalAmount"].Value != null && dgvrow.Cells["dgvtxtTotalAmount"].Value.ToString() != string.Empty)
                    {
                        dTotal = dTotal + Convert.ToDecimal(dgvrow.Cells["dgvtxtTotalAmount"].Value.ToString());
                    }
                }
                foreach (DataGridViewRow dgvrowTax in dgvPOSTax.Rows)
                {
                    if (dgvrowTax.Cells["dgvtxttax"].Value != null)
                    {
                        if (dgvrowTax.Cells["dgvtxtTaxApplicableOn"].Value != null && dgvrowTax.Cells["dgvtxttaxCalculateMode"].Value != null)
                        {
                            if (dgvrowTax.Cells["dgvtxtTaxApplicableOn"].Value.ToString() == "Bill" && dgvrowTax.Cells["dgvtxttaxCalculateMode"].Value.ToString() == "Bill Amount")
                            {
                                decTaxRate = Convert.ToDecimal(dgvrowTax.Cells["dgvtxttaxrate"].Value.ToString());
                                decTaxTotal = (dTotal * decTaxRate / 100);
                                dgvrowTax.Cells["dgvtxtTaxAmt"].Value = Math.Round(decTaxTotal, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                    }
                }
                foreach (DataGridViewRow dgvRow1 in dgvPOSTax.Rows)
                {
                    if (dgvRow1.Cells["dgvtxttax"].Value != null)
                    {
                        if (dgvRow1.Cells["dgvtxtTaxApplicableOn"].Value != null && dgvRow1.Cells["dgvtxttaxCalculateMode"].Value != null)
                        {
                            if (dgvRow1.Cells["dgvtxtTaxApplicableOn"].Value.ToString() == "Bill" && dgvRow1.Cells["dgvtxttaxCalculateMode"].Value.ToString() == "Tax Amount")
                            {
                                decTaxId = Convert.ToDecimal(dgvRow1.Cells["dgvtxttax"].Value.ToString());
                                List<DataTable> ListObj = new List<DataTable>();
                                TaxBll bllTax = new TaxBll();
                                ListObj = bllTax.TaxDetailsViewallByTaxId(decTaxId);
                                foreach (DataGridViewRow dgvRow2 in dgvPOSTax.Rows)
                                {
                                    foreach (DataRow drow in ListObj[0].Rows)
                                    {
                                        if (dgvRow2.Cells["dgvtxtTaxAmt"].Value != null)
                                        {
                                            decimal deca = 0;
                                            deca = Convert.ToDecimal(dgvRow2.Cells["dgvtxtTaxAmt"].Value.ToString());
                                            if (dgvRow2.Cells["dgvtxttax"].Value != null && deca != 0)
                                            {
                                                if (dgvRow2.Cells["dgvtxttax"].Value.ToString() == drow.ItemArray[0].ToString())
                                                {
                                                    decTaxRate = Convert.ToDecimal(dgvRow1.Cells["dgvtxttaxrate"].Value.ToString());
                                                    dTotal = Convert.ToDecimal(dgvRow2.Cells["dgvtxtTaxAmt"].Value.ToString());
                                                    dcTCessTotal = (dTotal * decTaxRate / 100);
                                                    dgvRow1.Cells["temp"].Value = Math.Round(dcTCessTotal, PublicVariables._inNoOfDecimalPlaces);
                                                    if (dgvRow1.Cells["dgvtxttax"].Value.ToString() == decTaxId.ToString())
                                                    {
                                                        dgvRow1.Cells["dgvtxtTaxAmt"].Value = dgvRow1.Cells["temp"].Value;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            dgvRow1.Cells["dgvtxtTaxAmt"].Value = 0;
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
                MessageBox.Show("POS:38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove a row from grid
        /// </summary>
        public void RemoveRow()
        {
            try
            {
                bool isok = true;
                if (isok)
                {
                    dgvPointOfSales.Rows.RemoveAt(dgvPointOfSales.CurrentRow.Index);
                    SerialNo();
                    TotalAmountCalculation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Salesman  while return from Product creation when creating new Salesman 
        /// </summary>
        /// <param name="decSalesmanId"></param>
        public void ReturnFromSalesman(decimal decSalesmanId)
        {
            try
            {
                if (decSalesmanId != 0)
                {
                    salesManComboFill();
                    cmbSalesMan.SelectedValue = decSalesmanId;
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
                MessageBox.Show("POS:40 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill product Details while return from Product creation when creating new Product 
        /// </summary>
        /// <param name="decProductId"></param>
        public void ReturnFromProductCreation(decimal decProductId)
        {
            try
            {
                ItemComboFill();
                if (decProductId != 0)
                {
                    cmbItem.SelectedValue = decProductId;
                }
                else
                {
                    cmbItem.SelectedValue = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:41 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Quantity Status Check
        /// </summary>
        public void QuantityStatusCheck()
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
                if (cmbItem.SelectedIndex != -1)
                {
                    decProductId = Convert.ToDecimal(cmbItem.SelectedValue.ToString());
                    batchcombofill();
                    decBatchId = Convert.ToDecimal(cmbBatch.SelectedValue.ToString());
                    decimal decCurrentStock = BllStockPosting.StockCheckForProductSale(decProductId, decBatchId);
                    if (txtQuantity.Text != null || txtQuantity.Text != string.Empty)
                    {
                        decCalcQty = decCurrentStock - Convert.ToDecimal(txtQuantity.Text.Trim().ToString());
                    }
                    if (decCalcQty < 0)
                    {
                        isNegativeLedger = true;
                    }
                }
                if (isNegativeLedger)
                {
                    if (strStatus == "Warn")
                    {
                        if (MessageBox.Show("Negative Stock balance exists,Do you want to Continue", "Open miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            AddToGrid();
                        }
                        else
                        {
                            cmbItem.Focus();
                        }
                    }
                    else if (strStatus == "Block")
                    {
                        MessageBox.Show("Cannot continue ,due to negative stock balance", "Open miracle", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cmbItem.Focus();
                    }
                    else
                    {
                        AddToGrid();
                    }
                }
                else
                {
                    AddToGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :42 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to Save or edit and checking the invalid entries
        /// </summary>
        public void SaveOrEdit()
        {
            bool isAllOk = true;
            try
            {
                dgvPointOfSales.ClearSelection();
                int inRow = dgvPointOfSales.RowCount;
                if (txtVoucherNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number");
                    txtVoucherNo.Focus();
                }
                else if (BllSalesInvoice.SalesInvoiceInvoiceNumberCheckExistence(txtVoucherNo.Text.Trim(), 0, DecPOSVoucherTypeId) && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Invoice number already exist");
                    txtVoucherNo.Focus();
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
                else if (cmbSalesAccount.SelectedValue == null)
                {
                    Messages.InformationMessage("Select sales a/c");
                    cmbSalesAccount.Focus();
                }
                else if (inRow == 0)
                {
                    Messages.InformationMessage("Can't save sales invoice without atleast one product with complete details");
                    txtBarcode.Focus();
                }
                else
                {
                    if (btnSave.Text == "Save")
                    {
                        if (dgvPointOfSales.Rows.Count > 0)
                        {
                            isAllOk = true;
                        }
                        if (isAllOk)
                        {
                            TotalAmountCalculation();
                            decimal dcGrandTot = Convert.ToDecimal(txtTotalAmount.Text.ToString());
                            if (Convert.ToDecimal(txtBillDiscount.Text.ToString()) >= dcGrandTot)
                            {
                                Messages.InformationMessage("Bill discount cannot be greater than net amount");
                                txtBillDiscount.Focus();
                            }
                            else
                            {
                                if (PublicVariables.isMessageAdd)
                                {
                                    if (Messages.SaveMessage())
                                    {
                                        SaveFunction();
                                    }
                                    else
                                    {
                                        txtBillDiscount.Focus();
                                    }
                                }
                                else
                                {
                                    SaveFunction();
                                }
                            }
                        }
                    }
                    else if (btnSave.Text == "Update")
                    {
                        if (dgvPointOfSales.Rows.Count > 0)
                        {
                            isAllOk = true;
                        }
                        if (isAllOk)
                        {
                            TotalAmountCalculation();
                            decimal dcGrandTot = Convert.ToDecimal(txtGrandTotal.Text.ToString());
                            if (Convert.ToDecimal(txtBillDiscount.Text.ToString()) > dcGrandTot)
                            {
                                Messages.InformationMessage("Bill discount cannot be greater than net amount");
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
            catch (Exception ex)
            {
                MessageBox.Show("POS:43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save An items to table 
        /// </summary>
        public void SaveFunction()
        {
            LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
            LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
            UnitConvertionBll bllUnitConversion = new UnitConvertionBll();
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            try
            {
                InfoSalesMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                InfoSalesMaster.AdditionalCost = 0;
                InfoSalesMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                InfoSalesMaster.BillDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                if (cmbCounter.SelectedIndex > -1)
                {
                    InfoSalesMaster.CounterId = Convert.ToDecimal(cmbCounter.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.CounterId = 0;
                }
                InfoSalesMaster.CreditPeriod = 0;
                InfoSalesMaster.CustomerName = string.Empty;
                InfoSalesMaster.Date = Convert.ToDateTime(txtDate.Text);
                InfoSalesMaster.DeliveryNoteMasterId = 0;
                if (cmbSalesMan.SelectedValue.ToString() != null)
                {
                    InfoSalesMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.EmployeeId = 0;
                }
                decimal decExachangeRateId = BllExchangeRate.ExchangerateViewByCurrencyId(PublicVariables._decCurrencyId);
                InfoSalesMaster.ExchangeRateId = decExachangeRateId;
                InfoSalesMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoSalesMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                InfoSalesMaster.LrNo = string.Empty;
                InfoSalesMaster.Narration = txtNarration.Text.Trim();
                InfoSalesMaster.OrderMasterId = 0;
                InfoSalesMaster.POS = true;
                if (cmbPricingLevel.SelectedValue.ToString() != null)
                {
                    InfoSalesMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.PricinglevelId = 0;
                }
                InfoSalesMaster.QuotationMasterId = 0;
                InfoSalesMaster.SalesAccount = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                InfoSalesMaster.TaxAmount = Convert.ToDecimal(lblTaxTotalAmount.Text.ToString());
                InfoSalesMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                InfoSalesMaster.TransportationCompany = string.Empty;
                InfoSalesMaster.UserId = PublicVariables._decCurrentUserId;
                InfoSalesMaster.VoucherTypeId = DecPOSVoucherTypeId;
                if (isAutomatic)
                {
                    InfoSalesMaster.SuffixPrefixId = decPOSSuffixPrefixId;
                    InfoSalesMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    InfoSalesMaster.SuffixPrefixId = 0;
                    InfoSalesMaster.VoucherNo = txtVoucherNo.Text;
                }
                InfoSalesMaster.ExtraDate = DateTime.Now;
                InfoSalesMaster.Extra1 = string.Empty;
                InfoSalesMaster.Extra2 = string.Empty;
                decSalesMasterId = BllSalesInvoice.SalesMasterAdd(InfoSalesMaster);
                int inRowCount = dgvPointOfSales.RowCount;
                InfoSalesDetails.SalesMasterId = decSalesMasterId;
                InfoSalesDetails.ExtraDate = DateTime.Now;
                InfoSalesDetails.Extra1 = string.Empty;
                InfoSalesDetails.Extra2 = string.Empty;
                for (int inI = 0; inI < inRowCount; inI++)
                {
                    if (dgvPointOfSales.Rows[inI].Cells["dgvtxtProductName"].Value != null && dgvPointOfSales.Rows[inI].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                    {
                        if (dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value != null && dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString() != string.Empty)
                        {
                            InfoSalesDetails.SlNo = Convert.ToInt32(dgvPointOfSales.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                            InfoSalesDetails.ProductId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtProductId"].Value.ToString());
                            InfoSalesDetails.Qty = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString());
                            InfoSalesDetails.Rate = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                            InfoSalesDetails.UnitId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtUnitId"].Value.ToString());
                            InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtunitconversionId"].Value.ToString());
                            InfoSalesDetails.Discount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtDiscount"].Value.ToString());
                            InfoSalesDetails.TaxId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxttaxid"].Value.ToString());
                            InfoSalesDetails.BatchId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtBatchId"].Value.ToString());
                            InfoSalesDetails.GodownId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGodownId"].Value.ToString());
                            InfoSalesDetails.RackId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRackId"].Value.ToString());
                            InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTaxAmount"].Value.ToString());
                            InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGrossValue"].Value.ToString());
                            InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtNetAmount"].Value.ToString());
                            InfoSalesDetails.Amount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTotalAmount"].Value.ToString());
                            BllSalesInvoice.SalesDetailsAdd(InfoSalesDetails);
                            infoStockPosting.Date = InfoSalesMaster.Date;
                            infoStockPosting.VoucherTypeId = DecPOSVoucherTypeId;
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.AgainstInvoiceNo = "NA";
                            infoStockPosting.ProductId = InfoSalesDetails.ProductId;
                            infoStockPosting.BatchId = InfoSalesDetails.BatchId;
                            infoStockPosting.UnitId = InfoSalesDetails.UnitId;
                            infoStockPosting.GodownId = InfoSalesDetails.GodownId;
                            infoStockPosting.RackId = InfoSalesDetails.RackId;
                            infoStockPosting.InwardQty = 0;
                            infoStockPosting.OutwardQty = InfoSalesDetails.Qty / bllUnitConversion.UnitConversionRateByUnitConversionId(InfoSalesDetails.UnitConversionId); ;
                            infoStockPosting.Rate = InfoSalesDetails.Rate;
                            infoStockPosting.FinancialYearId = InfoSalesMaster.FinancialYearId;
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                            BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                    }
                }
                int inTaxRowCount = dgvPOSTax.RowCount;
                InfoSalesBillTax.SalesMasterId = decSalesMasterId;
                InfoSalesBillTax.ExtraDate = DateTime.Now;
                InfoSalesBillTax.Extra1 = string.Empty;
                InfoSalesBillTax.Extra2 = string.Empty;
                for (int inI = 0; inI < inTaxRowCount; inI++)
                {
                    if (dgvPOSTax.Rows[inI].Cells["dgvtxttax"].Value != null && dgvPOSTax.Rows[inI].Cells["dgvtxttax"].Value.ToString() != string.Empty)
                    {
                        if (dgvPOSTax.Rows[inI].Cells["dgvtxtTaxAmt"].Value != null && dgvPOSTax.Rows[inI].Cells["dgvtxtTaxAmt"].Value.ToString() != string.Empty)
                        {
                            InfoSalesBillTax.TaxId = Convert.ToInt32(dgvPOSTax.Rows[inI].Cells["dgvtxttax"].Value.ToString());
                            InfoSalesBillTax.TaxAmount = Convert.ToDecimal(dgvPOSTax.Rows[inI].Cells["dgvtxtTaxAmt"].Value.ToString());
                            BllSalesInvoice.SalesBillTaxAdd(InfoSalesBillTax);
                        }
                    }
                }
                ledgerPostingAdd();
                if (BllSalesInvoice.SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString())))
                {
                    partyBalanceAdd();
                }
                Messages.SavedMessage();
                if (cbxPrintAfterSave.Checked)
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
                ClearFunctions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to add ledger Posting table
        /// </summary>
        public void ledgerPostingAdd()
        {
            try
            {
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.ChequeNo = String.Empty;
                infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue);
                infoLedgerPosting.Debit = Convert.ToDecimal(txtGrandTotal.Text); ;
                infoLedgerPosting.Credit = 0;
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                infoLedgerPosting.VoucherNo = strVoucherNo;
                infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                infoLedgerPosting.Debit = 0;
                infoLedgerPosting.Credit = Convert.ToDecimal(txtTotalAmount.Text);
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.DetailsId = 0;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                decimal decBillDis = 0;
                decBillDis = Convert.ToDecimal(txtBillDiscount.Text.Trim().ToString());
                if (decBillDis > 0)
                {
                    infoLedgerPosting.Debit = decBillDis;
                    infoLedgerPosting.Credit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                    infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                    infoLedgerPosting.LedgerId = 8;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }
                if (dgvPointOfSales.Columns["dgvtxtTaxPercentage"].Visible)
                {
                    foreach (DataGridViewRow dgvrow in dgvPOSTax.Rows)
                    {
                        if (dgvrow.Cells["dgvtxttax"].Value != null && dgvrow.Cells["dgvtxttax"].Value.ToString() != string.Empty)
                        {
                            decimal decTaxAmount = 0;
                            decTaxAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtTaxAmt"].Value.ToString());
                            if (decTaxAmount > 0)
                            {
                                infoLedgerPosting.Debit = 0;
                                infoLedgerPosting.Credit = Convert.ToDecimal(dgvrow.Cells["dgvtxtTaxAmt"].Value.ToString());
                                infoLedgerPosting.Date = Convert.ToDateTime(txtDate.Text.ToString());
                                infoLedgerPosting.VoucherTypeId = DecPOSVoucherTypeId;
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to add Party balance table
        /// </summary>
        public void partyBalanceAdd()
        {
            try
            {
                infoPartyBalance.Date = InfoSalesMaster.Date;
                infoPartyBalance.LedgerId = InfoSalesMaster.LedgerId;
                infoPartyBalance.VoucherNo = strVoucherNo;
                infoPartyBalance.InvoiceNo = txtVoucherNo.Text.Trim();
                infoPartyBalance.VoucherTypeId = DecPOSVoucherTypeId;
                infoPartyBalance.AgainstVoucherTypeId = 0;
                infoPartyBalance.AgainstVoucherNo = "NA";
                infoPartyBalance.AgainstInvoiceNo = "NA";
                infoPartyBalance.ReferenceType = "New";
                infoPartyBalance.Debit = InfoSalesMaster.GrandTotal;
                infoPartyBalance.Credit = 0;
                infoPartyBalance.CreditPeriod = 0;
                infoPartyBalance.ExchangeRateId = InfoSalesMaster.ExchangeRateId;
                infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPartyBalance.ExtraDate = DateTime.Now;
                infoPartyBalance.Extra1 = string.Empty;
                infoPartyBalance.Extra2 = string.Empty;
                BllPartyBalance.PartyBalanceAdd(infoPartyBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print
        /// </summary>
        /// <param name="decSalesMasterId"></param>
        public void Print(decimal decSalesMasterId)
        {
            try
            {
                DataSet dsSalesInvoiceTest = BllSalesInvoice.salesInvoicePrintAfterSave(decSalesMasterId, 1, InfoSalesMaster.OrderMasterId, InfoSalesMaster.DeliveryNoteMasterId, InfoSalesMaster.QuotationMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.SalesInvoicePrinting(dsSalesInvoiceTest);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print an item in a dotmatrix
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
                foreach (DataGridViewRow dRow in dgvPointOfSales.Rows)
                {
                    if (!dRow.IsNewRow)
                    {
                        DataRow dr = dtblGridDetails.NewRow();
                        dr["SlNo"] = ++inRowCount;
                        if (dRow.Cells["dgvtxtBarcode"].Value != null)
                        {
                            dr["BarCode"] = dRow.Cells["dgvtxtBarcode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtProductCode"].Value != null)
                        {
                            dr["ProductCode"] = dRow.Cells["dgvtxtProductCode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            dr["ProductName"] = dRow.Cells["dgvtxtProductName"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtQuantity"].Value != null)
                        {
                            dr["Qty"] = dRow.Cells["dgvtxtQuantity"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtUnit"].Value != null)
                        {
                            dr["Unit"] = dRow.Cells["dgvtxtUnit"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtRate"].Value != null)
                        {
                            dr["Rate"] = dRow.Cells["dgvtxtRate"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtTotalAmount"].Value != null)
                        {
                            dr["Amount"] = dRow.Cells["dgvtxtTotalAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtTaxAmount"].Value != null)
                        {
                            dr["TaxAmount"] = dRow.Cells["dgvtxtTaxAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtNetAmount"].Value != null)
                        {
                            dr["NetAmount"] = dRow.Cells["dgvtxtNetAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtDiscount"].Value != null)
                        {
                            dr["DiscountAmount"] = dRow.Cells["dgvtxtDiscount"].Value.ToString();
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
                dtblOtherDetails.Columns.Add("CustomerAddress");
                dtblOtherDetails.Columns.Add("CustomerTIN");
                dtblOtherDetails.Columns.Add("CustomerCST");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["voucherNo"] = txtVoucherNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["SalesAccount"] = cmbSalesAccount.Text;
                dRowOther["SalesMan"] = cmbSalesMan.Text;
                dRowOther["PricingLevel"] = cmbPricingLevel.Text;
                dRowOther["BillDiscount"] = txtBillDiscount.Text;
                dRowOther["GrandTotal"] = txtGrandTotal.Text;
                dRowOther["TotalAmount"] = txtTotalAmount.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtGrandTotal.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(DecPOSVoucherTypeId);
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
                MessageBox.Show("POS: 48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to set the status of Print Afetr Save checkbox
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
                MessageBox.Show("POS: 49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }


        /// <summary>
        /// Function to update the details
        /// </summary>
        public void EditFunction()
        {
            try
            {
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                InfoSalesMaster.SalesMasterId = decSalesMasterId;
                InfoSalesMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                InfoSalesMaster.AdditionalCost = 0;
                InfoSalesMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                InfoSalesMaster.BillDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                InfoSalesMaster.CounterId = Convert.ToDecimal(cmbCounter.SelectedValue.ToString());
                InfoSalesMaster.CreditPeriod = 0;
                InfoSalesMaster.CustomerName = "";
                InfoSalesMaster.Date = Convert.ToDateTime(txtDate.Text.Trim());
                InfoSalesMaster.DeliveryNoteMasterId = 0;
                if (cmbSalesMan.SelectedValue.ToString() != null)
                {
                    InfoSalesMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                }
                else
                {
                    InfoSalesMaster.EmployeeId = 0;
                }
                decimal decExachangeRateId = BllExchangeRate.ExchangerateViewByCurrencyId(PublicVariables._decCurrencyId);
                InfoSalesMaster.ExchangeRateId = decExachangeRateId;
                InfoSalesMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoSalesMaster.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
                InfoSalesMaster.LrNo = string.Empty;
                InfoSalesMaster.Narration = txtNarration.Text.Trim();
                InfoSalesMaster.OrderMasterId = 0;
                InfoSalesMaster.POS = true;
                InfoSalesMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                InfoSalesMaster.QuotationMasterId = 0;
                InfoSalesMaster.SalesAccount = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                InfoSalesMaster.TaxAmount = Convert.ToDecimal(lblTaxTotalAmount.Text);
                InfoSalesMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                InfoSalesMaster.TransportationCompany = "";
                InfoSalesMaster.UserId = PublicVariables._decCurrentUserId;
                InfoSalesMaster.VoucherTypeId = DecPOSVoucherTypeId;
                if (isAutomatic)
                {
                    InfoSalesMaster.SuffixPrefixId = decPOSSuffixPrefixId;
                }
                else
                {
                    InfoSalesMaster.SuffixPrefixId = 0;
                }
                if (isAutomatic)
                {
                    InfoSalesMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    InfoSalesMaster.VoucherNo = txtVoucherNo.Text.Trim();
                }
                InfoSalesMaster.ExtraDate = DateTime.Now;
                InfoSalesMaster.Extra1 = string.Empty;
                InfoSalesMaster.Extra2 = string.Empty;
                BllSalesInvoice.SalesMasterEdit(InfoSalesMaster);
                decimal dcAgainstVopucherTypeId = 0;
                string strAgainstVoucherNo = "NA";
                BllStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(dcAgainstVopucherTypeId, strAgainstVoucherNo, strVoucherNo, InfoSalesMaster.VoucherTypeId);
                BllLedgerPosting.LedgerPostDelete(InfoSalesMaster.VoucherNo, InfoSalesMaster.VoucherTypeId);
                removeSalesInvoiceDetails();
                SalesInvoiceDetailsEdit();
                Messages.UpdatedMessage();
                if (objfrmSalesInvoiceRegister != null)
                {
                    if (cbxPrintAfterSave.Checked)
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
                    objfrmSalesInvoiceRegister.gridFill();
                }
                if (frmSalesReportObj != null)
                {
                    if (cbxPrintAfterSave.Checked)
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
                    frmSalesReportObj.gridFill();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete the details from table while updating
        /// </summary>
        public void removeSalesInvoiceDetails()
        {
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
                MessageBox.Show("POS: 51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FUnction to edit the details 
        /// </summary>
        public void SalesInvoiceDetailsEdit()
        {
            try
            {
                for (int inI = 0; inI < dgvPointOfSales.Rows.Count; inI++)
                {
                    decimal decRefStatus = BllSalesInvoice.SalesInvoiceReferenceCheckForEdit(decSalesMasterId);
                    if (Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtSalesDetailsId"].Value) == 0 || dgvPointOfSales.Rows[inI].Cells["dgvtxtSalesDetailsId"].Value == null)   // here check the  row added or editing current row
                    {
                        InfoSalesDetails.SalesMasterId = decSalesMasterId;
                        InfoSalesDetails.ExtraDate = DateTime.Now;
                        InfoSalesDetails.Extra1 = string.Empty;
                        InfoSalesDetails.Extra2 = string.Empty;
                        if (dgvPointOfSales.Rows[inI].Cells["dgvtxtProductName"].Value != null && dgvPointOfSales.Rows[inI].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                        {
                            if (dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value != null && dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString() != string.Empty)
                            {
                                InfoSalesDetails.SlNo = Convert.ToInt32(dgvPointOfSales.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                                InfoSalesDetails.ProductId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtProductId"].Value.ToString());
                                InfoSalesDetails.Qty = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString());
                                InfoSalesDetails.Rate = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                                InfoSalesDetails.UnitId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtUnitId"].Value.ToString());
                                InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtunitconversionId"].Value.ToString());
                                InfoSalesDetails.Discount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtDiscount"].Value.ToString());
                                InfoSalesDetails.TaxId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxttaxid"].Value.ToString());
                                InfoSalesDetails.BatchId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtBatchId"].Value.ToString());
                                InfoSalesDetails.GodownId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGodownId"].Value.ToString());
                                InfoSalesDetails.RackId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRackId"].Value.ToString());
                                InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTaxAmount"].Value.ToString());
                                InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGrossValue"].Value.ToString());
                                InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtNetAmount"].Value.ToString());
                                InfoSalesDetails.Amount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTotalAmount"].Value.ToString());
                                BllSalesInvoice.SalesDetailsAdd(InfoSalesDetails);
                            }
                        }
                    }
                    else
                    {
                        InfoSalesDetails.SalesMasterId = decSalesMasterId;
                        InfoSalesDetails.ExtraDate = DateTime.Now;
                        InfoSalesDetails.Extra1 = string.Empty;
                        InfoSalesDetails.Extra2 = string.Empty;
                        InfoSalesDetails.SalesDetailsId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtSalesDetailsId"].Value);
                        InfoSalesDetails.SlNo = Convert.ToInt32(dgvPointOfSales.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        InfoSalesDetails.ProductId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtProductId"].Value.ToString());
                        InfoSalesDetails.Qty = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtQuantity"].Value.ToString());
                        InfoSalesDetails.Rate = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        InfoSalesDetails.UnitId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtUnitId"].Value.ToString());
                        InfoSalesDetails.UnitConversionId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtunitconversionId"].Value.ToString());
                        InfoSalesDetails.Discount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtDiscount"].Value.ToString());
                        InfoSalesDetails.TaxId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxttaxid"].Value.ToString());
                        InfoSalesDetails.BatchId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtBatchId"].Value.ToString());
                        InfoSalesDetails.GodownId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGodownId"].Value.ToString());
                        InfoSalesDetails.RackId = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtRackId"].Value.ToString());
                        InfoSalesDetails.TaxAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTaxAmount"].Value.ToString());
                        InfoSalesDetails.GrossAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtGrossValue"].Value.ToString());
                        InfoSalesDetails.NetAmount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtNetAmount"].Value.ToString());
                        InfoSalesDetails.Amount = Convert.ToDecimal(dgvPointOfSales.Rows[inI].Cells["dgvtxtTotalAmount"].Value.ToString());
                        BllSalesInvoice.SalesDetailsEdit(InfoSalesDetails);
                    }
                    int inTaxRowCount = dgvPOSTax.RowCount;
                    InfoSalesBillTax.SalesMasterId = decSalesMasterId;
                    InfoSalesBillTax.ExtraDate = DateTime.Now;
                    InfoSalesBillTax.Extra1 = string.Empty;
                    InfoSalesBillTax.Extra2 = string.Empty;
                    for (int inTax = 0; inTax < inTaxRowCount; inTax++)
                    {
                        if (dgvPOSTax.Rows[inTax].Cells["dgvtxttax"].Value != null && dgvPOSTax.Rows[inTax].Cells["dgvtxttax"].Value.ToString() != string.Empty)
                        {
                            if (dgvPOSTax.Rows[inTax].Cells["dgvtxtTaxAmt"].Value != null && dgvPOSTax.Rows[inTax].Cells["dgvtxtTaxAmt"].Value.ToString() != string.Empty)
                            {
                                InfoSalesBillTax.TaxId = Convert.ToInt32(dgvPOSTax.Rows[inTax].Cells["dgvtxttax"].Value.ToString());
                                InfoSalesBillTax.TaxAmount = Convert.ToDecimal(dgvPOSTax.Rows[inTax].Cells["dgvtxtTaxAmt"].Value.ToString());
                                BllSalesInvoice.SalesBillTaxEditBySalesMasterIdAndTaxId(InfoSalesBillTax);
                            }
                        }
                    }
                    infoStockPosting.Date = InfoSalesMaster.Date;
                    infoStockPosting.VoucherTypeId = DecPOSVoucherTypeId;
                    infoStockPosting.VoucherNo = strVoucherNo;
                    infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                    infoStockPosting.AgainstVoucherTypeId = 0;
                    infoStockPosting.AgainstVoucherNo = "NA";
                    infoStockPosting.AgainstInvoiceNo = "NA";
                    infoStockPosting.ProductId = InfoSalesDetails.ProductId;
                    infoStockPosting.BatchId = InfoSalesDetails.BatchId;
                    infoStockPosting.UnitId = InfoSalesDetails.UnitId;
                    infoStockPosting.GodownId = InfoSalesDetails.GodownId;
                    infoStockPosting.RackId = InfoSalesDetails.RackId;
                    infoStockPosting.InwardQty = 0;
                    infoStockPosting.OutwardQty = InfoSalesDetails.Qty;
                    infoStockPosting.Rate = InfoSalesDetails.Rate;
                    infoStockPosting.FinancialYearId = InfoSalesMaster.FinancialYearId;
                    infoStockPosting.Extra1 = string.Empty;
                    infoStockPosting.Extra2 = string.Empty;
                    BllStockPosting.StockPostingAdd(infoStockPosting);
                }
                ledgerPostingAdd();
                if (BllSalesInvoice.SalesInvoiceInvoicePartyCheckEnableBillByBillOrNot(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString())))
                {
                    infoPartyBalance.Date = InfoSalesMaster.Date;
                    infoPartyBalance.LedgerId = InfoSalesMaster.LedgerId;
                    infoPartyBalance.VoucherNo = strVoucherNo;
                    infoPartyBalance.InvoiceNo = txtVoucherNo.Text.Trim();
                    infoPartyBalance.VoucherTypeId = DecPOSVoucherTypeId;
                    infoPartyBalance.AgainstVoucherTypeId = 0;
                    infoPartyBalance.AgainstVoucherNo = "NA";
                    infoPartyBalance.AgainstInvoiceNo = "NA";
                    infoPartyBalance.ReferenceType = "New";
                    infoPartyBalance.Debit = InfoSalesMaster.GrandTotal;
                    infoPartyBalance.Credit = 0;
                    infoPartyBalance.CreditPeriod = 0;
                    infoPartyBalance.ExchangeRateId = InfoSalesMaster.ExchangeRateId;
                    infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoPartyBalance.ExtraDate = DateTime.Now;
                    infoPartyBalance.Extra1 = string.Empty;
                    infoPartyBalance.Extra2 = string.Empty;
                    BllPartyBalance.PartyBalanceEdit(infoPartyBalance);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                decSalesMasterId = decId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesInvoiceRegister to view details and for updation 
        /// </summary>
        /// <param name="decSalesMasterid"></param>
        /// <param name="frmSiRegister"></param>
        public void CallFromSalesRegister(decimal decSalesMasterid, frmSalesInvoiceRegister frmSiRegister)
        {
            try
            {
                objfrmSalesInvoiceRegister = frmSiRegister;
                objfrmSalesInvoiceRegister.Enabled = false;
                decSalesMasterId = decSalesMasterid;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesReport to view details and for updation 
        /// </summary>
        /// <param name="decSalesMasterid"></param>
        /// <param name="frmSIReport"></param>
        public void CallFromSalesInvoiceReport(decimal decSalesMasterid, frmSalesReport frmSIReport)
        {
            try
            {
                frmSalesReportObj = frmSIReport;
                decSalesMasterId = decSalesMasterid;
                frmSIReport.Enabled = false;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 55" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the details here for updation
        /// </summary>
        public void DetailsFillForEdit()
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isFormIdtoEdit = true;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtVoucherNo.ReadOnly = true;
                txtPaidAmount.Text = "0";
                txtBalance.Text = "0";
                txtDate.Focus();
                List<DataTable> listMaster = BllSalesInvoice.POSSalesMasterViewBySalesMasterId(decSalesMasterId);
                txtVoucherNo.Text = listMaster[0].Rows[0]["invoiceNo"].ToString();
                strVoucherNo = listMaster[0].Rows[0]["voucherNo"].ToString();
                decPOSSuffixPrefixId = Convert.ToDecimal(listMaster[0].Rows[0]["suffixPrefixId"].ToString());
                DecPOSVoucherTypeId = Convert.ToDecimal(listMaster[0].Rows[0]["voucherTypeId"].ToString());
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(DecPOSVoucherTypeId);
                txtDate.Text = listMaster[0].Rows[0]["date"].ToString();
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                cmbCashOrParty.SelectedValue = listMaster[0].Rows[0]["ledgerId"].ToString();
                txtNarration.Text = listMaster[0].Rows[0]["narration"].ToString();
                txtTotalAmount.Text = listMaster[0].Rows[0]["totalAmount"].ToString();
                txtBillDiscount.Text = listMaster[0].Rows[0]["billDiscount"].ToString();
                txtGrandTotal.Text = listMaster[0].Rows[0]["grandTotal"].ToString();
                cmbSalesAccount.SelectedValue = listMaster[0].Rows[0]["salesAccount"].ToString();
                cmbCounter.SelectedValue = listMaster[0].Rows[0]["counterId"].ToString();
                cmbPricingLevel.SelectedValue = listMaster[0].Rows[0]["pricingLevelId"].ToString();
                cmbSalesMan.SelectedValue = listMaster[0].Rows[0]["employeeId"].ToString();
                txtBalance.Text = listMaster[0].Rows[0]["grandTotal"].ToString();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllSalesInvoice.SalesDetailsViewBySalesMasterId(decSalesMasterId);
                for (int i = 0; i < listObj[0].Rows.Count; i++)
                {
                    dgvPointOfSales.Rows.Add();
                    decSalesDetailsId = Convert.ToDecimal(listObj[0].Rows[i]["salesDetailsId"].ToString());
                    dgvPointOfSales.Rows[i].Cells["dgvtxtSalesDetailsId"].Value = decSalesDetailsId;
                    dgvPointOfSales.Rows[i].Cells["dgvtxtSlNo"].Value = listObj[0].Rows[i]["slNo"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtProductCode"].Value = listObj[0].Rows[i]["productCode"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtProductName"].Value = listObj[0].Rows[i]["productName"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtQuantity"].Value = listObj[0].Rows[i]["qty"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtUnit"].Value = listObj[0].Rows[i]["unitName"].ToString();
                    decimal dcrate = Convert.ToDecimal(listObj[0].Rows[i]["rate"].ToString());
                    dgvPointOfSales.Rows[i].Cells["dgvtxtRate"].Value = Math.Round(dcrate, PublicVariables._inNoOfDecimalPlaces);
                    dgvPointOfSales.Rows[i].Cells["dgvtxtGrossValue"].Value = listObj[0].Rows[i]["grossAmount"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtDiscount"].Value = listObj[0].Rows[i]["discount"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtNetAmount"].Value = listObj[0].Rows[i]["netAmount"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtTaxPercentage"].Value = listObj[0].Rows[i]["taxName"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtTaxAmount"].Value = listObj[0].Rows[i]["taxAmount"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtTotalAmount"].Value = listObj[0].Rows[i]["amount"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtBarcode"].Value = listObj[0].Rows[i]["barcode"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtunitconversionId"].Value = listObj[0].Rows[i]["unitConversionId"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtBatchId"].Value = listObj[0].Rows[i]["batchId"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtRackId"].Value = listObj[0].Rows[i]["rackId"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtGodownId"].Value = listObj[0].Rows[i]["godownId"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtBatchno"].Value = listObj[0].Rows[i]["batchNo"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtGodownName"].Value = listObj[0].Rows[i]["godownName"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtRackName"].Value = listObj[0].Rows[i]["rackName"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxttaxid"].Value = listObj[0].Rows[i]["taxId"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtProductId"].Value = listObj[0].Rows[i]["productId"].ToString();
                    dgvPointOfSales.Rows[i].Cells["dgvtxtUnitId"].Value = listObj[0].Rows[i]["unitId"].ToString();
                }
                
                taxGridFill();
                listObj = BllSalesInvoice.SalesInvoiceSalesBillTaxViewAllBySalesMasterId(decSalesMasterId);
                foreach (DataGridViewRow dgvrowTax in dgvPOSTax.Rows)
                {
                    for (int i = 0; i < listObj[0].Rows.Count; i++)
                    {
                        if (dgvPOSTax.Rows[i].Cells["dgvtxttax"].Value != null && dgvPOSTax.Rows[i].Cells["dgvtxttax"].Value.ToString() != string.Empty)
                        {
                            dgvPOSTax.Rows[i].Cells["dgvtxttax"].Value = listObj[0].Rows[i]["taxId"].ToString();
                            dgvPOSTax.Rows[i].Cells["dgvtxtTaxAmt"].Value = listObj[0].Rows[i]["taxAmount"].ToString();
                        }
                    }
                }
                TaxTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete an item from table
        /// </summary>
        /// <param name="decSalesInvoiceid"></param>
        public void DeleteFunction(decimal decSalesInvoiceid)
        {
            try
            {
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                BllSalesInvoice.SalesInvoiceDelete(decSalesMasterId, DecPOSVoucherTypeId, strVoucherNo);
                Messages.DeletedMessage();
                if (objfrmSalesInvoiceRegister != null)
                {
                    this.Close();
                    objfrmSalesInvoiceRegister.Enabled = true;
                    objfrmSalesInvoiceRegister.gridFill();
                }
                else if (frmSalesReportObj != null)
                {
                    this.Close();
                    frmSalesReportObj.Enabled = true;
                    frmSalesReportObj.gridFill();
                }
                else if (frmDayBookObj != null)
                {
                    this.Close();
                }
                else
                {
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                base.Show();
                frmDayBookObj = frmDayBook;
                frmDayBook.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVatReturnReport to view details and for updation 
        /// </summary>
        /// <param name="frmVatReport"></param>
        /// <param name="decMasterId"></param>
        public void callFromVatReturnReport(frmVatReturnReport frmVatReport, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmvatReturnReportObj = frmVatReport;
                frmVatReport.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                base.Show();
                frmAgeingObj = frmAgeing;
                frmAgeing.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherWiseProductSearch to view details and for updation 
        /// </summary>
        /// <param name="frmVoucherProductObj"></param>
        /// <param name="decMasterId"></param>
        public void callFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherProductObj, decimal decMasterId)
        {
            try
            {
                base.Show();
                objVoucherProduct = frmVoucherProductObj;
                frmVoucherProductObj.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                base.Show();
                frmledgerDetailsObj = LedgerDetailsObj;
                frmledgerDetailsObj.Enabled = false;
                decSalesMasterId = decMasterId;
                DetailsFillForEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO: 62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                base.Show();
                this.frmProductSearchPopupObj = frmProductSearchPopup;

                cmbItem.SelectedValue = decproductId;

                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// here set the textbox value as dtp value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpDate.Value;
                this.txtDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When form load call the cleart function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPOS_Load(object sender, EventArgs e)
        {
            try
            {
                ClearFunctions();
            }
            catch (Exception ex)
            {

                MessageBox.Show("POS:64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Gridview row added event for generate the Serial No
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPointOfSales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
                maxSerialNo++;
                dgvPointOfSales.Rows[e.RowIndex].Cells["rowId"].Value = maxSerialNo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Gridview row added event for generate the Serial No in rtax grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPOSTax_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNoforPOSTax();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:66" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To add a new ledger from this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewLedger_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = true;
                isFromSalesAccountCombo = false;
                AccountLedgerCreation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// TO create a new counter using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewCounter_Click(object sender, EventArgs e)
        {
            isFromCounterCombo = true;
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmCounter", "Save"))
                {
                    if (cmbCounter.SelectedValue != null)
                    {
                        strCounter = cmbCounter.SelectedValue.ToString();
                    }
                    else
                    {
                        strCounter = string.Empty;
                    }
                    frmCounter frmCounterObj = new frmCounter();
                    frmCounterObj.MdiParent = formMDI.MDIObj;
                    frmCounter open = Application.OpenForms["frmCounter"] as frmCounter;
                    if (open == null)
                    {
                        frmCounterObj.WindowState = FormWindowState.Normal;
                        frmCounterObj.MdiParent = formMDI.MDIObj;
                        frmCounterObj.callFromPOS(this, isFromCounterCombo);
                    }
                    else
                    {
                        open.callFromPOS(this, isFromCounterCombo);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("You don’t have privilege", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 68" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new Salesman using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSalesMan_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesman", "Save"))
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
                        frmSalesmanObj.callFromPOS(this);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.callFromPOS(this);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    this.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You don’t have privilege", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 69" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new SalesAccount using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSalesAccount_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = false;
                isFromSalesAccountCombo = true;
                AccountLedgerCreation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 70" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFunctions();
                if (objfrmSalesInvoiceRegister != null)
                {
                    objfrmSalesInvoiceRegister.Close();
                    objfrmSalesInvoiceRegister = null;
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
                if (frmledgerDetailsObj != null)
                {
                    frmledgerDetailsObj.Enabled = true;
                    frmledgerDetailsObj = null;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj = null;
                }

                this.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 71" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Add button click, call the status check function here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                QuantityStatusCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 72" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Save button click, call the save or edit function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    SaveOrEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 73" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button click, here closing the form based on the settings
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
                MessageBox.Show("POS : 74" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Delete button click, call the delete function here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, "Delete"))
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage())
                        {
                            DeleteFunction(decSalesMasterId);
                        }
                        dgvPointOfSales.Focus();
                    }
                    else
                    {
                        DeleteFunction(decSalesMasterId);
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 75" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Remove button click, call the remove function here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                if (dgvPointOfSales.SelectedCells.Count > 0 && dgvPointOfSales.CurrentRow != null)
                {
                    int inRowIndex = dgvPointOfSales.CurrentRow.Index;
                    if (MessageBox.Show("Do you want to remove current row?", "Open Miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        if (btnSave.Text == "Update")
                        {
                            if (dgvPointOfSales.CurrentRow.Cells["dgvtxtSalesDetailsId"].Value != null && dgvPointOfSales.CurrentRow.Cells["dgvtxtSalesDetailsId"].Value.ToString() != "")
                            {
                                lstArrOfRemove.Add(dgvPointOfSales.CurrentRow.Cells["dgvtxtSalesDetailsId"].Value.ToString());
                                RemoveRow();
                                ClearGroupbox();
                                TotalAmountCalculation();
                            }
                            else
                            {
                                RemoveRow();
                                ClearGroupbox();
                                TotalAmountCalculation();
                            }
                        }
                        else
                        {
                            RemoveRow();
                            ClearGroupbox();
                            TotalAmountCalculation();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 76" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Grid dopuble click for edit the items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPointOfSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPointOfSales.Rows.Count > 0 && dgvPointOfSales.CurrentRow != null)
                {
                    if (dgvPointOfSales.CurrentRow.Cells["dgvtxtProductCode"].Value != null)
                    {
                        if (dgvPointOfSales.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                        {
                            txtProductCode.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString();
                            cmbItem.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                            txtQuantity.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtQuantity"].Value.ToString();
                            cmbUnit.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtUnit"].Value.ToString();
                            txtRate.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtRate"].Value.ToString();
                            txtGrossValue.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtGrossValue"].Value.ToString();
                            cmbTax.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtTaxPercentage"].Value.ToString();
                            txtTaxAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtTaxAmount"].Value.ToString();
                            txtNetAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtNetAmount"].Value.ToString();
                            txtDiscountAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtDiscount"].Value.ToString();
                            txtAmount.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtTotalAmount"].Value.ToString();
                            txtBarcode.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtBarcode"].Value.ToString();
                            cmbBatch.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtBatchno"].Value.ToString();
                            cmbGodown.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtGodownName"].Value.ToString();
                            cmbRack.Text = dgvPointOfSales.CurrentRow.Cells["dgvtxtRackName"].Value.ToString();
                            if (dgvPointOfSales.CurrentRow.Cells["rowId"].Value != null && dgvPointOfSales.CurrentRow.Cells["rowId"].Value.ToString() != string.Empty)
                            {
                                rowIdToEdit = int.Parse(dgvPointOfSales.CurrentRow.Cells["rowId"].Value.ToString());
                            }
                            btnAdd.Text = "Edit";
                            txtQuantity.Focus();
                            txtQuantity.SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 77" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// barcode leave call the fill function here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            try
            {
                string strBarcode = txtBarcode.Text.Trim();
                FillControlsByBarcode(strBarcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 78" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// call the fill function based on the selected product code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProductCode.Text.Trim() != string.Empty)
                {
                    FillControlByProductCode(true);
                }
                else
                {
                    txtBarcode.Text = string.Empty;
                    txtProductCode.Text = string.Empty;
                    cmbItem.SelectedIndex = -1;
                    txtQuantity.Text = string.Empty;
                    txtRate.Text = string.Empty;
                    cmbGodown.DataSource = null;
                    cmbRack.DataSource = null;
                    cmbBatch.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS : 79" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// date validation and set the textbox value as dtp value
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
                MessageBox.Show("POS :80" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// doing the grand total amount calculations here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal decGrandTotal = 0;
                if (txtBillDiscount.Text.Trim() != string.Empty)
                {
                    decimal decTotal = Convert.ToDecimal(txtTotalAmount.Text.Trim());

                    decimal decBilldiscount = Convert.ToDecimal(txtBillDiscount.Text.Trim());
                    if (decBilldiscount > decTotal)
                    {
                        //txtGrandTotal.Text = "0.00";
                        txtGrandTotal.Text = decTotal.ToString();

                    }
                    else
                    {
                        decGrandTotal = decTotal - decBilldiscount;
                        txtGrandTotal.Text = decGrandTotal.ToString();
                    }
                }
                else
                {
                    txtGrandTotal.Text = txtTotalAmount.Text.Trim(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :81" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Qty text change here call the gross value calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrossValueCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :82" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the discount calculations here in gross value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGrossValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DiscountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :83" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the gross value calculations in rate changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrossValueCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :84" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the discount calculation in DiscountPercentage textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (isFromDiscAmt == true)
                {
                    DiscountCalculation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :85" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the tax amount calculations in net amount text changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNetAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TaxAmountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :86" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the DiscountPercentage Calculation in discount amount ctext change 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                isFromDiscAmt = false;
                DiscountPerCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :87" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// TO get total amount calculation in paid amount textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalAmountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :88" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the product fill function based on the product here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isFromBarcode == false)
                {
                    cmbUnit.DataSource = null;
                    if (cmbItem.SelectedIndex > -1 && cmbItem.SelectedValue != null)
                    {
                        if (cmbItem.SelectedValue.ToString() != "System.Data.DataRowView" && cmbItem.Text != "System.Data.DataRowView")
                        {
                            GodownComboFill();
                            RackComboFill();
                            decProductId = Convert.ToDecimal(cmbItem.SelectedValue.ToString());
                            FillControlsByProductName(decProductId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :89" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in bill discount keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :90" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in  discount amount keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :91" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in Rate keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :92" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in Qty keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :93" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing event, checking the other opend form status here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj.Activate();
                    frmDayBookObj = null;
                }
                if (objVoucherProduct != null)
                {
                    objVoucherProduct.Enabled = true;
                    objVoucherProduct.FillGrid();
                    objVoucherProduct.Activate();
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                    objVoucherSearch.Activate();
                }
                if (frmvatReturnReportObj != null)
                {
                    frmvatReturnReportObj.Enabled = true;
                    frmvatReturnReportObj.GridFill();
                    frmvatReturnReportObj.Activate();
                }
                if (frmSalesReportObj != null)
                {
                    frmSalesReportObj.Enabled = true;
                    frmSalesReportObj.gridFill();
                    frmSalesReportObj.Activate();
                }
                if (objfrmSalesInvoiceRegister != null)
                {
                    objfrmSalesInvoiceRegister.Enabled = true;
                    objfrmSalesInvoiceRegister.Activate();
                    objfrmSalesInvoiceRegister.gridFill();
                }
                if (frmledgerDetailsObj != null)
                {
                    frmledgerDetailsObj.Enabled = true;
                    frmledgerDetailsObj.Activate();
                    frmledgerDetailsObj.LedgerDetailsView();
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj.BringToFront();
                    frmAgeingObj.FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :94" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Doing the unit conversion here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                if (cmbUnit.SelectedValue != null)
                {
                    List<DataTable> ListObj = new List<DataTable>();
                    ListObj = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(decProductId.ToString());
                    foreach (DataRow drUnitByProduct in ListObj[0].Rows)
                    {
                        if (cmbUnit.SelectedValue.ToString() == drUnitByProduct.ItemArray[0].ToString())
                        {
                            lblUnitConversion.Text = drUnitByProduct.ItemArray[2].ToString();
                            lblUnitConversionRate.Text = drUnitByProduct.ItemArray[3].ToString();
                            if (isAfterFillControls)
                            {
                                decimal decNewConversionRate = Convert.ToDecimal(lblUnitConversionRate.Text.ToString());
                                decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                txtRate.Text = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :95" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Get the product current unit rate here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUnit_Enter(object sender, EventArgs e)
        {
            try
            {
                if (lblUnitConversionRate.Text.Trim() != string.Empty)
                {
                    decCurrentConversionRate = Convert.ToDecimal(lblUnitConversionRate.Text);
                }
                if (txtRate.Text != string.Empty)
                {
                    decCurrentRate = Convert.ToDecimal(txtRate.Text);
                }
                else
                {
                    decCurrentRate = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 92" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Set the bill discount as 0 if its empty, its checking in leave event
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
                MessageBox.Show("POS: 93" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// set the field as empty whilw entering to edit
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
                MessageBox.Show("POS: 94" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in paid amount textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 95" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// set the field as 0 while leaving if its empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountPercentage_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscountPercentage.Text.Trim() == string.Empty)
                {
                    txtDiscountPercentage.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 96" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// set the field as 0 while leaving if its empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                isFromDiscAmt = true;
                if (txtDiscountAmount.Text.Trim() == string.Empty)
                {
                    txtDiscountAmount.Text = "0";
                }
                DiscountCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 97" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// For Decimal validation in Discount percentage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS :98" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// For enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtProductCode.Visible)
                    {
                        txtProductCode.Focus();
                        txtProductCode.SelectionStart = 0;
                        txtProductCode.SelectionLength = 0;
                    }
                    else
                    {
                        cmbItem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 99" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbItem.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Text.Trim() == string.Empty || txtProductCode.SelectionStart == 0)
                    {
                        if (txtBarcode.Visible)
                        {
                            txtBarcode.SelectionStart = 0;
                            txtBarcode.SelectionLength = 0;
                            txtBarcode.Focus();
                        }
                        else
                        {
                            cmbCounter.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 100" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            string strtxt = txtQuantity.Text.Trim();
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (e.KeyCode == Keys.Enter)
                {
                    if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                    {
                        cmbUnit.Focus();
                    }
                    else
                    {
                        txtRate.Focus();
                        txtRate.Select();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtQuantity.SelectionLength > 0)
                    {
                        txtQuantity.Text = strtxt.Trim();
                        txtQuantity.SelectionStart = 0;
                        txtQuantity.SelectionLength = 0;
                        if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                        {
                            cmbBatch.Focus();
                        }
                        else if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                        {
                            cmbRack.Focus();
                        }
                        else
                        {
                            cmbItem.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 101" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 102" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPaidAmount.Focus();
                    txtPaidAmount.SelectAll();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtBillDiscount.Text.Trim() == string.Empty || txtBillDiscount.SelectionStart == 0)
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionStart = 0;
                        txtNarration.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 103" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
                else if (e.Control && e.KeyCode == Keys.S)
                {
                    btnSave_Click(sender, e);
                }
                else if (e.Control && e.KeyCode == Keys.D)
                {
                    if (btnDelete.Enabled)
                        btnDelete_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F9)
                {
                    txtBillDiscount.Focus();
                    txtBillDiscount.SelectAll();
                }
                else if (e.KeyCode == Keys.F4)
                {
                    txtPaidAmount.Focus();
                    txtPaidAmount.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 104" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtPaidAmount.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 105" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPaidAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (txtPaidAmount.Text.Trim() == string.Empty && txtGrandTotal.Text.Trim() != string.Empty)
                {
                    txtBalance.Text = "-" + txtGrandTotal.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 106" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbPricingLevel.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 107" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPricingLevel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMan.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 108" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation and short cut to create a new Salesman
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrParty.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbPricingLevel.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewSalesMan_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbSalesMan.Focused)
                    {
                        cmbSalesMan.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbSalesMan.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbSalesMan.SelectedIndex > -1)
                    {
                        frmEmployeePopup frmEmployeePopupObj = new frmEmployeePopup();
                        frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                        frmEmployeePopupObj.callFromPOS(this, Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select any Sales Man");
                        cmbSalesMan.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 109" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCounter.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewSalesAccount_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbSalesAccount.Focused)
                    {
                        cmbSalesAccount.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbSalesAccount.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbSalesAccount.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromPOS(this, Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString()), "SalesAccount");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 110" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCounter_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBarcode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSalesAccount.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewCounter_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 111" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                isFromDiscAmt = true;
                if (e.KeyCode == Keys.Enter)
                {
                    txtDiscountAmount.SelectionStart = 0;
                    txtDiscountAmount.SelectionLength = 0;
                    txtDiscountAmount.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtDiscountPercentage.Text.Trim() == string.Empty || txtDiscountPercentage.SelectionStart == 0)
                    {
                        txtQuantity.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 112" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal dcTotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                decimal dcBillDisc = 0;
                decimal dcGrandTotal = 0;
                if (txtBillDiscount.Text.Trim() != string.Empty)
                {
                    dcBillDisc = Convert.ToDecimal(txtBillDiscount.Text);
                }
                else
                {
                    dcBillDisc = 0;
                }
                if (dcBillDisc < dcTotalAmount)
                {
                    dcGrandTotal = dcTotalAmount - dcBillDisc;
                }
                else
                {
                    dcGrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                }

                decimal dcBalance = 0;
                if (txtPaidAmount.Text != string.Empty)
                {
                    dcBalance = decimal.Parse(txtPaidAmount.Text) - dcGrandTotal;
                }
                txtBalance.Text = dcBalance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 113" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("POS: 114" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbSalesAccount.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMan.Focus();
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewLedger_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up For ProductSearch
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
                        frmLedgerPopupObj.CallFromPOS(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryDeptors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 115" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbItem_KeyDown(object sender, KeyEventArgs e)
        {
            string strProductName;
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (e.KeyCode == Keys.Enter)
                {
                    if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                    {
                        cmbGodown.Focus();
                        cmbGodown.SelectionStart = 0;
                    }
                    else if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                    {
                        cmbBatch.Focus();
                    }
                    else
                    {
                        txtQuantity.Focus();
                        txtQuantity.Select();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Visible)
                    {
                        if (txtProductCode.Text.Trim() != string.Empty || txtProductCode.SelectionLength == 0)
                        {
                            txtProductCode.SelectionStart = 0;
                            txtProductCode.Focus();
                        }
                    }
                    else
                    {
                        txtBarcode.Focus();
                        txtBarcode.Select();
                    }
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbItem.Focused)
                    {
                        cmbItem.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbItem.SelectedIndex != -1)
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        frmProductSearchPopupObj.CallFromPOS(this, cmbItem.SelectedIndex, txtProductCode.Text);
                    }
                    else
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        frmProductSearchPopupObj.CallFromPOS(this, cmbItem.SelectedIndex, string.Empty);
                    }
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt) //Creation
                {
                    frmProductCreation frmProductCreationObj = new frmProductCreation();
                    bool isFromItemCombo = true;
                    if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmProductCreation", "Save"))
                    {
                        if (cmbItem.SelectedValue != null)
                        {
                            strProductName = cmbItem.SelectedValue.ToString();
                        }
                        else
                        {
                            strProductName = string.Empty;
                        }
                        frmProductCreationObj.MdiParent = formMDI.MDIObj;
                        frmProductCreationObj.CallFromPOSForProductCreation(this, isFromItemCombo);
                    }
                    else
                    {
                        MessageBox.Show("You don’t have privilege", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 116" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGodown_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbRack.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbItem.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 117" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRack_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbBatch.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbGodown.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 118" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBatch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (e.KeyCode == Keys.Enter)
                {
                    txtQuantity.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                    {
                        cmbRack.Focus();
                    }
                    else
                    {
                        cmbItem.Focus();
                        cmbItem.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 119" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtRate.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtQuantity.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 120" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtRate.SelectionStart == 0)
                    {
                        txtQuantity.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 121" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGodown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGodown.SelectedIndex > -1)
                {
                    if (cmbGodown.SelectedValue.ToString() != "System.Data.DataRowView" && cmbGodown.Text != "System.Data.DataRowView")
                    {
                        decimal dcGodownId = Convert.ToDecimal(cmbGodown.SelectedValue.ToString());
                        RackComboFillByGodownId(dcGodownId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS: 122" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
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
                        txtRate.Focus();
                        txtRate.SelectionStart = 0;
                        txtRate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:123" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
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
                MessageBox.Show("POS:124" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiscountAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDiscountAmount.SelectionStart == 0)
                    {
                        txtDiscountPercentage.Focus();
                        txtDiscountPercentage.SelectionLength = 0;
                        txtDiscountPercentage.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:125" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTax_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtRate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:126" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Set the PaidAmount textbox as 0 while leaving, if its empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPaidAmount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPaidAmount.Text.Trim() == string.Empty)
                {
                    txtPaidAmount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("POS:127" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
