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
using System.Data.SqlClient;
using System.Collections;
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmPurchaseReturn : Form
    {
        #region Public Variables
        /// <summary>
        ///  public variable declaration part
        /// </summary>
        string strCashorParty = string.Empty;
        string strPurchaseAccount = string.Empty;
        string strProductCode = string.Empty;
        string strVoucherNo = string.Empty;
        string strTaxComboFill = string.Empty;
        string strInvoiceNo = string.Empty;
        string strReturnNo = string.Empty;
        bool isFromPurchaseAccountCombo = false;
        bool isFromCashOrPartyCombo = false;
        bool isFromPurchaseReturn = false;
        bool isDontExecuteCashorParty = false;
        bool isDontExecuteVoucherType = false;
        bool isAmountcalc = true;
        bool isAutomatic = false;
        bool isValueChanged = false;
        bool isInvoiceFil = false;
        bool isEditFill = false;
        decimal decPurchaseReturnVoucherTypeId = 0;
        decimal decPurchaseReturnSuffixPrefixId = 0;
        decimal decPurchaseReturnMasterId = 0;
        decimal decPurchaseReturnTypeId = 0;
        decimal decQty = 0;
        decimal decRate = 0;
        decimal decBatchId = 0;
        decimal decMasterId = -2;
        decimal decAgainstVoucherTypeId = 0;
        int inMaxCount = 0;
        int inNarrationCount = 0;
        frmPurchaseReturnRegister frmPurchaseReturnRegisterObj;
        frmVoucherSearch objVoucherSearch = null;
        frmDayBook frmDayBookObj = null;                                                          //To use in call from frmDayBook
        frmVoucherWiseProductSearch frmVoucher = null;                                            //To use in call from VoucherWiseProductSearch
        frmProductSearchPopup frmProductSearchPopupObj;
        frmLedgerDetails frmLedgerDetailsObj=null;
        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
        frmPurchaseReturnReport ObjPurchaseReturnReport = null;
        ArrayList lstArrOfRemove = new ArrayList();
        ArrayList arrlstMasterId = new ArrayList();
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        PurchaseMasterInfo infoPurchaseMaster = new PurchaseMasterInfo();
        PurchaseReturnMasterInfo infoPurchaseReturnMaster = new PurchaseReturnMasterInfo();
        #endregion

        #region Function
        /// <summary>
        /// Create an instance for frmPurchaseReturn Class
        /// </summary>
        public frmPurchaseReturn()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Cash or Party combobox
        /// </summary>
        public void CashOrPartyComboFill()
        {
            TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                TransactionGeneralFillObj.CashOrPartyComboFill(cmbCashOrParty, false);
                cmbCashOrParty.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:01 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Currency combobox
        /// </summary>
        public void CurrencyComboFill()
        {
            TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
            SettingsBll BllSettings = new SettingsBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                DateTime dtDate = Convert.ToDateTime(dtpDate.Value);
                List<DataTable> listObjCurrency = new List<DataTable>();
                listObjCurrency = TransactionGeneralFillObj.CurrencyComboByDate(dtDate);
                cmbCurrency.DataSource = listObjCurrency[0];
                cmbCurrency.DisplayMember = "currencyName";
                cmbCurrency.ValueMember = "exchangeRateId";
                cmbCurrency.Enabled = (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes") ? true : false;
                cmbCurrency.SelectedValue = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Purchase Account combobox
        /// </summary>
        public void PurchaseAccountComboFill()
        {
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = BllPurchaseInvoice.PurchaseInvoicePurchaseAccountFill();
                cmbPurchaseAccount.DataSource = ListObj[0];
                cmbPurchaseAccount.DisplayMember = "ledgerName";
                cmbPurchaseAccount.ValueMember = "ledgerId";
                if (ListObj[0].Rows.Count > 0)
                {
                    cmbPurchaseAccount.SelectedIndex = 0;
                    cmbPurchaseAccount.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Function to fill Voucher Type combobox
        /// </summary>       
        public void VoucherTypeCombofill()
        {
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = BllPurchaseInvoice.VoucherTypeComboFillForPurchaseInvoice();
                cmbVoucherType.DataSource = ListObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Invoice No combobox corresponding to voucher type
        /// </summary>
        /// <param name="decLedger"></param>
        /// <param name="decvoucherTypeId"></param>
        public void InvoiceNoComboFill(decimal decLedger, decimal decvoucherTypeId)
        {
            
            List<DataTable> ListObjInvoiceNo = new List<DataTable>();
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            try
            {
                isInvoiceFil = true;
                ListObjInvoiceNo = BllPurchaseInvoice.GetInvoiceNoCorrespondingtoLedger(decLedger, 0, decvoucherTypeId);
                cmbInvoiceNo.DataSource = ListObjInvoiceNo[0];
                if (cmbInvoiceNo.DataSource != null)
                {
                    cmbInvoiceNo.DisplayMember = "invoiceNo";
                    cmbInvoiceNo.ValueMember = "purchaseMasterId";
                    cmbInvoiceNo.SelectedIndex = -1;
                }
                isInvoiceFil = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill comboboxes of DataGridView
        /// </summary>
        public void gridComboFill()
        {
            try
            {
                DGVGodownComboFill();
                DGVRackComboFill();
                DGVTaxCombofill();
                DGVUnitComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView Unit combobox 
        /// </summary>
        public void DGVUnitComboFill()
        {
            TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAll();
                dgvcmbUnit.DataSource = ListObj[0];
                dgvcmbUnit.ValueMember = "unitId";
                dgvcmbUnit.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView Godown  combobox 
        /// </summary>
        public void DGVGodownComboFill()
        {
            try
            {
                GodownBll BllGodown = new GodownBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllGodown.GodownViewAll();
                dgvcmbGodown.DataSource = listObj[0];
                dgvcmbGodown.ValueMember = "godownId";
                dgvcmbGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView Rack  combobox 
        /// </summary>
        public void DGVRackComboFill()
        {
            try
            {
                RackBll BllRack = new RackBll();
                List<DataTable> listObjRack = new List<DataTable>();
                listObjRack = BllRack.RackViewAll();
                dgvcmbRack.DataSource = listObjRack[0];
                dgvcmbRack.ValueMember = "rackId";
                dgvcmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView Batch  combobox 
        /// </summary>
        public void DGVBatchComboFill()
        {
            try
            {
                BatchBll BllBatch = new BatchBll();
                List<DataTable> listBatch = new List<DataTable>();
                listBatch = BllBatch.BatchViewAll();
                dgvcmbBatch.DataSource = listBatch[0];
                dgvcmbBatch.ValueMember = "batchId";
                dgvcmbBatch.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView Tax combobox 
        /// </summary>
        public void DGVTaxCombofill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllByVoucherTypeIdApplicaleForProduct(decPurchaseReturnVoucherTypeId);
                strTaxComboFill = (ListObj[0].Rows.Count > 0) ? ListObj[0].Rows[0]["taxId"].ToString() : string.Empty;
                dgvcmbTax.DataSource = ListObj[0];
                dgvcmbTax.DisplayMember = "taxName";
                dgvcmbTax.ValueMember = "taxId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView Batch combobox corresponding to product
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
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvPurchaseReturn.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to fill DataGridView Unit combobox corresponding to product
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void UnitComboFill(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                UnitBll bllUnit = new UnitBll();
                ListObj = bllUnit.UnitViewAllByProductId(decProductId);
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvPurchaseReturn.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView Rack combobox corresponding to godown
        /// </summary>
        /// <param name="decGodownId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void RackComboFill(decimal decGodownId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RackBll BllRack = new RackBll();
                listObj = BllRack.RackNamesCorrespondingToGodownId(decGodownId);
                DataGridViewComboBoxCell dgvcmbRackCell = (DataGridViewComboBoxCell)dgvPurchaseReturn.Rows[inRow].Cells[inColumn];
                dgvcmbRackCell.DataSource = listObj[0];
                dgvcmbRackCell.ValueMember = "rackId";
                dgvcmbRackCell.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill DataGridView PurcahseReturnTax
        /// </summary>
        public void DGVPurchaseReturnTaxFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllByVoucherTypeId(decPurchaseReturnVoucherTypeId);
                dgvPurchaseReturnTax.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Settings Status Check
        /// </summary>
        public void PurchaseReturnSettingsCheck()
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                dgvPurchaseReturn.Columns["dgvcmbGodown"].Visible = (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes") ? true : false;
                dgvPurchaseReturn.Columns["dgvCmbRack"].Visible = (BllSettings.SettingsStatusCheck("AllowRack") == "Yes") ? true : false;
                dgvPurchaseReturn.Columns["dgvcmbBatch"].Visible = (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes") ? true : false;
                dgvPurchaseReturn.Columns["dgvtxtBarcode"].Visible = (BllSettings.SettingsStatusCheck("Barcode") == "Yes") ? true : false;
                dgvPurchaseReturn.Columns["dgvcmbUnit"].Visible = (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes") ? true : false;
                dgvPurchaseReturn.Columns["dgvtxtproductCode"].Visible = (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes") ? true : false;
                dgvPurchaseReturn.Columns["dgvtxtdiscount"].Visible = (BllSettings.SettingsStatusCheck("ShowDiscountAmount") == "Yes") ? true : false;
                dgvPurchaseReturn.Columns["dgvtxtrate"].Visible = (BllSettings.SettingsStatusCheck("ShowPurchaseRate") == "Yes") ? true : false;
                cbxPrintAfterSave.Checked = (BllSettings.SettingsStatusCheck("TickPrintAfterSave") == "Yes") ? true : false;
                if (BllSettings.SettingsStatusCheck("Tax") == "Yes")
                {
                    dgvcmbTax.Visible = true;
                    dgvPurchaseReturnTax.Visible = true;
                    lblTotalTaxAmount.Visible = true;
                    lblTaxAmount.Visible = true;
                    lblTotalTaxAmount.Visible = true;
                    dgvtxttaxAmount.Visible = true;
                }
                else
                {
                    dgvcmbTax.Visible = false;
                    dgvPurchaseReturnTax.Visible = false;
                    lblTaxAmount.Visible = false;
                    lblTaxAmount.Visible = false;
                    lblTotalTaxAmount.Visible = false;
                    dgvtxttaxAmount.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:16 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Clear the rows of PurchaseReturn grid and PurchaseReturn Tax grid
        /// </summary>
        private void gridClear()
        {
            try
            {
                dgvPurchaseReturn.Rows.Clear();
                lblTaxAmount.Text = "0.00";
                txtTotalAmount.Text = "0.00";
                txtBillDiscount.Text = "0.00";
                txtGrandTotal.Text = "0.00";
                if (dgvPurchaseReturn.DataSource != null)
                {
                    ((DataTable)dgvPurchaseReturn.DataSource).Rows.Clear();
                }
                else
                {
                    dgvPurchaseReturn.Rows.Clear();
                }
                DGVTaxCombofill();
                if (dgvPurchaseReturnTax.DataSource != null)
                {
                    ((DataTable)dgvPurchaseReturnTax.DataSource).Rows.Clear();
                }
                else
                {
                    dgvPurchaseReturnTax.Rows.Clear();
                }
                DGVPurchaseReturnTaxFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                if (isAutomatic)
                {
                    VoucherNumberGeneration();
                    txtDate.Focus();
                }
                else
                {
                    txtReturnNo.Text = string.Empty;
                    txtReturnNo.ReadOnly = false;
                }
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                CashOrPartyComboFill();
                PurchaseAccountComboFill();
                CurrencyComboFill();
                VoucherTypeCombofill();
                gridComboFill();
                cmbInvoiceNo.Visible = false;
                lblInvoiceNo.Visible = false;
                gridClear();
                txtTransportationCompany.Text = string.Empty;
                txtLrlNo.Text = string.Empty;
                txtNarration.Text = string.Empty;
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                txtDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for New Account Ledger creation for Cash or Party/Purchase Account 
        /// </summary>
        public void AccountLedgerCreation()
        {
            try
            {
                if (isFromCashOrPartyCombo)
                {
                    strCashorParty = (cmbCashOrParty.SelectedValue != null) ? cmbCashOrParty.SelectedValue.ToString() : string.Empty;
                }
                else if (isFromPurchaseAccountCombo)
                {
                    strPurchaseAccount = (cmbPurchaseAccount.SelectedValue != null) ? cmbPurchaseAccount.SelectedValue.ToString() : string.Empty;
                }
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                    frmAccountLedgerObj.CallFromPurchaseReturn(this, isFromCashOrPartyCombo, isFromPurchaseAccountCombo);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromPurchaseReturn(this, isFromCashOrPartyCombo, isFromPurchaseAccountCombo);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:19 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Return from Account Ledger for Cash or Party
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedger(decimal decId)
        {
            try
            {
                this.Enabled = true;
                this.Activate();
                CashOrPartyComboFill();
                if (decId != 0)
                {
                    cmbCashOrParty.SelectedValue = decId;
                }
                cmbCashOrParty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Return from Account Ledger for Purchase Account
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedgerOfPurchaseAccount(decimal decId)
        {
            try
            {
                this.Enabled = true;
                this.Activate();
                PurchaseAccountComboFill();
                if (decId != 0)
                {
                    cmbPurchaseAccount.SelectedValue = decId;
                }
                cmbPurchaseAccount.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Fill Product Details in grid
        /// </summary>
        /// <param name="strProductCode"></param>
        /// <param name="rowIndex"></param>
        private void FillProductDetails(string strProductCode, int rowIndex)
        {
            try
            {
                ProductInfo infoProductFill = new ProductInfo();
                infoProductFill = new ProductCreationBll().ProductViewByCode(strProductCode);
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                BatchBll BllBatch = new BatchBll();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                StockPostingBll BllStockPosting = new StockPostingBll();
               
                List<DataTable> list = new List<DataTable>();
                decimal decCurrentConversionRate = 0;
                if (infoProductFill.ProductId != 0)
                {
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtproductId"].Value = infoProductFill.ProductId;
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtproductCode"].Value = infoProductFill.ProductCode;
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtproductName"].Value = infoProductFill.ProductName;
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvcmbGodown"].Value = infoProductFill.GodownId;
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvcmbRack"].Value = infoProductFill.RackId;
                    UnitComboFill(infoProductFill.ProductId, rowIndex, dgvPurchaseReturn.CurrentRow.Cells["dgvcmbUnit"].ColumnIndex);
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvcmbUnit"].Value = infoProductFill.UnitId;
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtrate"].Value = Math.Round(infoProductFill.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(new UnitConvertionBll().UnitconversionIdViewByUnitIdAndProductId(infoProductFill.UnitId, infoProductFill.ProductId));
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtConversionRate"].Value = bllUnitConvertion.UnitConversionRateByUnitConversionId(Convert.ToDecimal(dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtUnitConversionId"].Value.ToString()));
                    BatchComboFill(infoProductFill.ProductId, rowIndex, dgvPurchaseReturn.CurrentRow.Cells["dgvcmbBatch"].ColumnIndex);
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvcmbBatch"].Value = BllStockPosting.BatchViewByProductId(Convert.ToDecimal(dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtproductId"].Value));
                    list = bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoProductFill.UnitId, infoProductFill.ProductName);
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtUnitConversionId"].Value = list[0].Rows[0]["unitconversionId"].ToString();
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtConversionRate"].Value = list[0].Rows[0]["conversionRate"].ToString();
                    decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                    //dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtqty"].Value = 0;
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvcmbTax"].Value = infoProductFill.TaxId;
                    AmountCalculation("dgvtxtqty", rowIndex);
                    decimal decProdtId = infoProductFill.ProductId;
                    decBatchId = BllStockPosting.BatchViewByProductId(decProdtId);
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvcmbBatch"].Value = decBatchId;
                    string strBarcode = Convert.ToString(BllProductCreation.BarcodeViewByBatchId(decBatchId));
                    dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtbarcode"].Value = strBarcode;
                    if (dgvPurchaseReturn.Rows[rowIndex + 1].Cells["dgvtxtproductCode"].Selected == true)
                    {
                        dgvPurchaseReturn.Rows[rowIndex].Cells["dgvtxtqty"].Selected = true;
                        dgvPurchaseReturn.Rows[rowIndex + 1].Selected = false;
                        dgvPurchaseReturn.Rows[rowIndex].HeaderCell.Value = "X";
                        dgvPurchaseReturn.Rows[rowIndex].HeaderCell.Style.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the dataGridView from productSearchPopup when Cntrl+F navigation key used
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                base.Show();
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();

                infoProduct = BllProductCreation.ProductView(decproductId);
                int inRowcount = dgvPurchaseReturn.Rows.Count;
                if (decCurrentRowIndex == inRowcount - 1)
                {
                    dgvPurchaseReturn.Rows.Add();
                }
                for (int i = 0; i < inRowcount; i++)
                {
                    if (i == decCurrentRowIndex)
                    {
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductCode"].Value = infoProduct.ProductCode;
                        FillProductDetails(infoProduct.ProductCode.ToString(), i);
                    }
                }
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the product details in dataGridView from productCreationPopup
        /// </summary>
        /// <param name="productcreation"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void productDetailsFillFromProductCreation(frmProductCreation productcreation, decimal decproductId, decimal decCurrentRowIndex)
        {
            try
            {
                decimal decCurrentConversionRate = 0;
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                List<DataTable> list = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                ProductInfo infoProductFill = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                ProductInfo infoProduct = new ProductInfo();
                int inI = dgvPurchaseReturn.CurrentRow.Index;
                if (inI == dgvPurchaseReturn.Rows.Count - 1)
                {
                    dgvPurchaseReturn.Rows.Add();
                }
                if (decproductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decproductId);
                    SerialNo();
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtproductCode"].Value = infoProduct.ProductCode;
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtproductId"].Value = decproductId.ToString();
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtproductName"].Value = infoProduct.ProductName;
                    dgvPurchaseReturn.Rows[inI].Cells["dgvcmbGodown"].Value = infoProduct.GodownId;
                    dgvPurchaseReturn.Rows[inI].Cells["dgvcmbRack"].Value = infoProduct.RackId;
                    UnitComboFill(infoProduct.ProductId, dgvPurchaseReturn.CurrentRow.Index, dgvPurchaseReturn.CurrentRow.Cells["dgvcmbUnit"].ColumnIndex);
                    dgvPurchaseReturn.Rows[inI].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtrate"].Value = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(new UnitConvertionBll().UnitconversionIdViewByUnitIdAndProductId(infoProduct.UnitId, infoProduct.ProductId));
                    dgvPurchaseReturn.CurrentRow.Cells["dgvtxtConversionRate"].Value = bllUnitConvertion.UnitConversionRateByUnitConversionId(Convert.ToDecimal(dgvPurchaseReturn.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString()));
                    BatchComboFill(decproductId, inI, dgvPurchaseReturn.Rows[inI].Cells["dgvcmbBatch"].ColumnIndex);
                    dgvPurchaseReturn.Rows[inI].Cells["dgvcmbBatch"].Value = BllBatch.BatchIdViewByProductId(decproductId);
                    RackComboFill(infoProduct.GodownId, inI, dgvPurchaseReturn.Rows[inI].Cells["dgvcmbRack"].ColumnIndex);
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtqty"].Value = "0";
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtbarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvPurchaseReturn.Rows[inI].Cells["dgvcmbBatch"].Value.ToString()));
                    list = bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoProduct.UnitId, infoProduct.ProductName);
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtConversionRate"].Value = list[0].Rows[0]["conversionRate"].ToString();
                    decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtConversionRate"].Value.ToString());
                    AmountCalculation("dgvtxtqty", inI);
                    dgvPurchaseReturn.Rows[inI].Cells["dgvtxtqty"].Selected = true;
                    dgvPurchaseReturn.Rows[inI + 1].Selected = false;
                }
                dgvPurchaseReturn.Rows[inI].HeaderCell.Value = "X";
                dgvPurchaseReturn.Rows[inI].HeaderCell.Style.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Return from productCreationPopup
        /// </summary>
        /// <param name="decProductId"></param>
        public void ReturnFromProductCreation(decimal decProductId)
        {
            frmProductCreation productcreation = new frmProductCreation();
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                int inI = dgvPurchaseReturn.CurrentRow.Index;
                this.Enabled = true;
                base.Show();
                if (decProductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decProductId);
                    strProductCode = infoProduct.ProductCode;
                    productDetailsFillFromProductCreation(productcreation, decProductId, inI);
                }
                dgvPurchaseReturn.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Call from Account Ledger popup
        /// </summary>
        /// <param name="frmLedgerPopup"></param>
        /// <param name="decId"></param>
        /// <param name="strComboTypes"></param>
        public void CallFromLedgerPopup(frmLedgerPopup frmLedgerPopup, decimal decId, string strComboTypes)
        {
            TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                base.Show();
                this.frmLedgerPopupObj = frmLedgerPopup;
                if (strComboTypes == "CashOrSundryCreditors")
                {
                    TransactionGeneralFillObj.CashOrPartyComboFill(cmbCashOrParty, false);
                    cmbCashOrParty.SelectedValue = decId;
                }
                else if (strComboTypes == "PurchaseAccount")
                {
                    PurchaseAccountComboFill();
                    cmbPurchaseAccount.SelectedValue = decId;
                }
                frmLedgerPopupObj.Close();
                frmLedgerPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Voucher Number Generation
        /// </summary>
        public void VoucherNumberGeneration()
        {
            string strPrefix = string.Empty;
            string strSuffix = string.Empty;
            string tableName = "PurchaseReturnMaster";
            string strReturnNo = string.Empty;
            TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
            PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
            try
            {
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPurchaseReturnVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                if (Convert.ToDecimal(strVoucherNo) != BllPurchaseReturn.PurchaseReturnMasterGetMaxPlusOne(decPurchaseReturnVoucherTypeId))
                {
                    strVoucherNo = BllPurchaseReturn.PurchaseReturnMasterGetMax(decPurchaseReturnVoucherTypeId).ToString();
                    strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPurchaseReturnVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    if (BllPurchaseReturn.PurchaseReturnMasterGetMax(decPurchaseReturnVoucherTypeId) == "0")
                    {
                        strVoucherNo = "0";
                        strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPurchaseReturnVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    }
                }
                if (isAutomatic)
                {

                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPurchaseReturnVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decPurchaseReturnSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    strReturnNo = strPrefix + strVoucherNo + strSuffix;
                    txtReturnNo.Text = strReturnNo;
                    txtReturnNo.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Decimal validation in keypress event
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
                MessageBox.Show("PR:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for getting row index
        /// </summary>
        public int GetNextinRowIndex()
        {
            try
            {
                inMaxCount++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inMaxCount;
        }
        /// <summary>
        /// Function for keypress event 
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
                MessageBox.Show("PR:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function for AutoCompletion of Product,productCode
        /// </summary>
        /// <param name="isProductName"></param>
        /// <param name="editControl"></param>
        public void FillProducts(bool isProductName, DataGridViewTextBoxEditingControl editControl)
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                List<DataTable> listObjProducts = new List<DataTable>();
                listObjProducts = BllProductCreation.ProductViewAll();
                ProductNames = new AutoCompleteStringCollection();
                ProductCodes = new AutoCompleteStringCollection();
                foreach (DataRow dr in listObjProducts[0].Rows)
                {
                    ProductNames.Add(dr["productName"].ToString());
                    ProductCodes.Add(dr["productCode"].ToString());
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Total Amount calculation
        /// </summary>
        private void CalculateTotalAmount()
        {
            try
            {
                lblTaxAmount.Visible = true;
                {
                    decimal decTotal = 0;
                    foreach (DataGridViewRow dgvrow in dgvPurchaseReturn.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtAmount"].Value != null && dgvrow.Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            decTotal = decTotal + Convert.ToDecimal(dgvrow.Cells["dgvtxtAmount"].Value.ToString());
                        }
                    }
                    txtTotalAmount.Text = (decTotal >= 0) ? Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces).ToString() : Math.Round(0.00, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Grand Total calculation
        /// </summary>
        public void CalculateGrandTotal()
        {
            decimal decTotalAmount = 0;
            decimal decTaxAmount = 0;
            decimal decBillDiscount = 0;
            decimal decGrandTotal = 0;
            try
            {
                if (dgvPurchaseReturnTax.Visible)
                {
                    TaxAmountApplicableOnBill();
                    foreach (DataGridViewRow dgvrow in dgvPurchaseReturnTax.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtTaxApplicableOn"].Value != null && dgvrow.Cells["dgvtxtTaxApplicableOn"].Value.ToString() == "Bill")
                        {
                            decTaxAmount = decTaxAmount + Convert.ToDecimal(dgvrow.Cells["dgvtxtAmounts"].Value.ToString());
                        }
                    }
                }
                if (txtBillDiscount.Text != string.Empty)
                {
                    if (txtTotalAmount.Text != string.Empty)
                    {
                        decBillDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                        decTotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                        if (decTotalAmount >= decBillDiscount)
                        {
                            decGrandTotal = decTotalAmount + decTaxAmount - decBillDiscount;
                            txtGrandTotal.Text = (decGrandTotal >= 0) ? Math.Round(decGrandTotal, PublicVariables._inNoOfDecimalPlaces).ToString() : Math.Round(0.00, PublicVariables._inNoOfDecimalPlaces).ToString();
                        }
                        else
                        {
                            txtBillDiscount.Text = "0.00";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Amount Calculations for Gross value, Net amount, Tax amount and Total amount
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="inIndexOfRow"></param>
        public void AmountCalculation(string columnName, int inIndexOfRow)
        {
            try
            {
                string strTaxRate = string.Empty;
                decimal decTaxAmt = 0;
                decimal decTotalAmnt = 0;
                decimal decdgvtxtgrossValue = 0, decDiscountCalc = 0, decNetAmount = 0;
                decimal decTaxPercent = 0;
                decimal decTaxId = 0;
                DataGridViewRow dgrow = dgvPurchaseReturn.Rows[inIndexOfRow];
                ProductInfo infoProduct = new ProductInfo();
                RackBll BllRack = new RackBll();
                TaxInfo infotax = new TaxInfo();
                TaxBll bllTax = new TaxBll();
                if (dgrow.Cells["dgvtxtqty"].Value != null && dgrow.Cells["dgvtxtqty"].Value.ToString() != string.Empty)
                {
                    decQty = Convert.ToDecimal(dgrow.Cells["dgvtxtqty"].Value.ToString());
                }

                if (dgrow.Cells["dgvtxtrate"].Value != null && dgrow.Cells["dgvtxtrate"].Value.ToString() != string.Empty)
                {
                    decRate = Convert.ToDecimal(dgrow.Cells["dgvtxtrate"].Value.ToString());
                    decdgvtxtgrossValue = decQty * decRate;
                    dgrow.Cells["dgvtxtgrossValue"].Value = Math.Round(decdgvtxtgrossValue, PublicVariables._inNoOfDecimalPlaces);
                }
                if (dgrow.Cells["dgvtxtgrossValue"].Value != null && dgrow.Cells["dgvtxtgrossValue"].Value.ToString() != string.Empty)
                {
                    dgrow.Cells["dgvtxtgrossValue"].Value = Math.Round(decdgvtxtgrossValue, PublicVariables._inNoOfDecimalPlaces);
                    if (dgrow.Cells["dgvtxtdiscount"].Value != null && dgrow.Cells["dgvtxtdiscount"].Value.ToString() != string.Empty)
                    {
                        decDiscountCalc = Convert.ToDecimal(dgrow.Cells["dgvtxtdiscount"].Value.ToString());
                        if (decdgvtxtgrossValue >= decDiscountCalc)
                        {
                            decNetAmount = Math.Round((decdgvtxtgrossValue - decDiscountCalc), PublicVariables._inNoOfDecimalPlaces);
                            dgrow.Cells["dgvtxtNetAmount"].Value = Math.Round(decNetAmount, PublicVariables._inNoOfDecimalPlaces);
                        }
                        else
                        {
                            dgrow.Cells["dgvtxtdiscount"].Value = 0;
                        }
                    }
                    else
                    {
                        dgrow.Cells["dgvtxtdiscount"].Value = 0;
                        dgrow.Cells["dgvtxtNetAmount"].Value = Math.Round(decNetAmount, PublicVariables._inNoOfDecimalPlaces);
                    }
                }
                if (dgrow.Cells["dgvtxtNetAmount"].Value != null && dgrow.Cells["dgvtxtNetAmount"].Value.ToString() != string.Empty)
                {
                    decNetAmount = Math.Round(decdgvtxtgrossValue - decDiscountCalc, PublicVariables._inNoOfDecimalPlaces);
                    decNetAmount = Convert.ToDecimal(dgrow.Cells["dgvtxtNetAmount"].Value.ToString());
                    dgrow.Cells["dgvtxtNetAmount"].Value = Math.Round(decNetAmount, PublicVariables._inNoOfDecimalPlaces);
                }
                if (dgvcmbTax.Visible)
                {
                    if (dgrow.Cells["dgvtxtproductId"].Value != null && dgrow.Cells["dgvtxtproductId"].Value.ToString() != string.Empty)
                    {
                        if (dgrow.Cells["dgvcmbTax"].Value != null && dgrow.Cells["dgvcmbTax"].Value.ToString() != string.Empty && dgrow.Cells["dgvcmbTax"].Value.ToString() != "NA")
                        {
                            decTaxId = Convert.ToDecimal(dgrow.Cells["dgvcmbTax"].Value.ToString());
                            infotax = bllTax.TaxView(decTaxId);
                            decTaxPercent = infotax.Rate;
                            if (decTaxPercent != 0)
                            {
                                if (strTaxComboFill != string.Empty)
                                {
                                    decTaxAmt = ((decNetAmount * decTaxPercent) / 100);
                                }
                                else
                                {
                                    dgrow.Cells["dgvtxttaxAmount"].Value = "0";
                                }
                                decTotalAmnt = Math.Round((decNetAmount + decTaxAmt), PublicVariables._inNoOfDecimalPlaces);
                                dgrow.Cells["dgvtxttaxAmount"].Value = Math.Round(decTaxAmt, PublicVariables._inNoOfDecimalPlaces);
                                decTaxAmt = Convert.ToDecimal(dgrow.Cells["dgvtxttaxAmount"].Value.ToString());
                                dgrow.Cells["dgvtxtAmount"].Value = Math.Round(decTotalAmnt, PublicVariables._inNoOfDecimalPlaces);
                            }
                            else
                            {
                                dgrow.Cells["dgvtxttaxAmount"].Value = "0";
                                dgrow.Cells["dgvtxtAmount"].Value = Math.Round(decNetAmount, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                        else
                        {
                            decTaxPercent = 0;
                            dgrow.Cells["dgvtxttaxAmount"].Value = "0";
                            dgrow.Cells["dgvtxtAmount"].Value = Math.Round(decNetAmount, PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                    Calculate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:34 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Unit Conversion Calculation
        /// </summary>
        /// <param name="inIndexOfRow"></param>
        public void UnitConversionCalc(int inIndexOfRow)
        {
            try
            {
                decimal decOldConversionRate = 0, decOldUnitConversionId = 0, decUnitId = 0, decProductId = 0;
                decimal decNewConversionRate = 0, decNewUnitConversionId = 0;
                decimal decProductRate = 0;
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                List<DataTable> ListObj = new List<DataTable>();
                UnitBll bllUnit = new UnitBll();
                if (dgvPurchaseReturn.Rows[inIndexOfRow].Cells["dgvtxtproductId"].Value != null)
                {
                    if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductId"].Value.ToString() != string.Empty &&
                                   dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductId"].Value.ToString() != "0")
                    {
                        decOldUnitConversionId = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtUnitConversionId"].Value.ToString());
                        decOldConversionRate = bllUnitConvertion.UnitConversionRateByUnitConversionId(decOldUnitConversionId);
                        decUnitId = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvcmbUnit"].Value.ToString());
                        decProductId = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductId"].Value.ToString());
                        decNewUnitConversionId = bllUnitConvertion.UnitconversionIdViewByUnitIdAndProductId(decUnitId, decProductId);
                        decNewConversionRate = bllUnitConvertion.UnitConversionRateByUnitConversionId(decNewUnitConversionId);
                        dgvPurchaseReturn.CurrentRow.Cells["dgvtxtUnitConversionId"].Value = decNewUnitConversionId;
                        if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtrate"].Value != null && dgvPurchaseReturn.CurrentRow.Cells["dgvtxtrate"].Value.ToString() != string.Empty)
                        {
                            decProductRate = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtrate"].Value.ToString());
                            decProductRate = decProductRate * decOldConversionRate / decNewConversionRate;
                            dgvPurchaseReturn.CurrentRow.Cells["dgvtxtrate"].Value = Math.Round(decProductRate, PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Total TaxAmount calculation for PurchaseReturn Tax grid
        /// </summary>
        public void TotalTaxAmount()
        {
            decimal decTotalTax = 0;
            decimal decTax = 0;
            try
            {
                foreach (DataGridViewRow dgrow in dgvPurchaseReturnTax.Rows)
                {
                    if (dgrow.Cells["dgvtxtTaxId"].Value != null)
                    {
                        if (dgrow.Cells["dgvtxtTaxId"].Value.ToString() != string.Empty && dgrow.Cells["dgvtxtTaxId"].Value.ToString() != "0")
                        {
                            if (dgrow.Cells["dgvtxtAmounts"].Value != null && dgrow.Cells["dgvtxtAmounts"].Value.ToString() != string.Empty)
                            {
                                decTax = Convert.ToDecimal(dgrow.Cells["dgvtxtAmounts"].Value.ToString());
                                decTotalTax = decTotalTax + decTax;
                            }
                        }
                    }
                }
                lblTaxAmount.Text = (decTotalTax == 0) ? "0.00" : decTotalTax.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Total NetAmount calculation for ledger posting
        /// </summary>
        public decimal TotalNetAmountCalculation()
        {
            decimal decNetVal = 0;
            try
            {
                foreach (DataGridViewRow dgvrow in dgvPurchaseReturn.Rows)
                {
                    if (dgvrow.Cells["dgvtxtNetAmount"].Value != null && dgvrow.Cells["dgvtxtNetAmount"].Value.ToString() != string.Empty)
                    {
                        decNetVal = decNetVal + Convert.ToDecimal(dgvrow.Cells["dgvtxtNetAmount"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decNetVal;
        }
        /// <summary>
        /// Function for Empty settings for grid fields
        /// </summary>
        public void StringEmptyDetailsInGrid()
        {
            try
            {
                dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductCode"].Value = string.Empty;
                dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductName"].Value = string.Empty;
                dgvPurchaseReturn.CurrentRow.Cells["dgvtxtbarcode"].Value = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for SerialNo generation in grid 
        /// </summary>
        public void SerialNo()
        {
            try
            {
                foreach (DataGridViewRow datarow in dgvPurchaseReturn.Rows)
                {
                    datarow.Cells["dgvtxtSlNo"].Value = datarow.Index + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:39 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for SerialNo generation in purchaseReturn Tax grid
        /// </summary>
        public void TaxSerialNo()
        {
            try
            {
                foreach (DataGridViewRow row in dgvPurchaseReturnTax.Rows)
                {
                    row.Cells["dgvSlNo"].Value = row.Index + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Call from voucher type selection
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            try
            {
                decPurchaseReturnVoucherTypeId = decVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decPurchaseReturnVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPurchaseReturnVoucherTypeId, dtpDate.Value);
                decPurchaseReturnSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtReturnNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Product details fill in grid corresponding to invoice number
        /// </summary>
        public void InvoiceDetailsFill()
        {
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            try
            {
                if (!isEditFill)
                {
                    inMaxCount = 0;
                    string strTaxRate1 = string.Empty;
                    string strproductId = string.Empty;
                    decimal decTaxAmount = 0;
                    decimal decAmount = 0;
                    decimal decNetAmount = 0;
                    decimal decTaxRate = 0;
                    decimal decDiscountAmount = 0;
                    decimal decGrossAmount = 0;
                    int inRowIndex = 0;
                    UnitConvertionBll bllUnitConversion = new UnitConvertionBll();
                    PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                    List<DataTable> ListObjDetails = BllPurchaseInvoice.PurchaseDetailsViewByPurchaseMasterIdWithRemaining(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()), decPurchaseReturnMasterId, decPurchaseReturnVoucherTypeId);
                    dgvPurchaseReturn.Rows.Clear();
                    foreach (DataRow drowDetails in ListObjDetails[0].Rows)
                    {
                        dgvPurchaseReturn.Rows.Add();
                        DGVUnitComboFill();
                        DGVBatchComboFill();
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtPurchaseDetailsId"].Value = drowDetails.ItemArray[0].ToString();
                        strproductId = drowDetails.ItemArray[2].ToString();
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtproductId"].Value = Convert.ToString(drowDetails.ItemArray[2]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtproductName"].Value = Convert.ToString(drowDetails.ItemArray[5]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtproductCode"].Value = Convert.ToString(drowDetails.ItemArray[6]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtVoucherTypeId"].Value = Convert.ToString(drowDetails.ItemArray[21]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtVoucherNo"].Value = Convert.ToString(drowDetails.ItemArray[23]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtInvoiceNo"].Value = Convert.ToString(drowDetails.ItemArray[22]);
                        decQty = Math.Round(Convert.ToDecimal(Convert.ToString(drowDetails.ItemArray[10])), PublicVariables._inNoOfDecimalPlaces);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtqty"].Value = decQty;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtrate"].Value = Convert.ToString(drowDetails.ItemArray[11]);
                        decRate = Math.Round(Convert.ToDecimal(Convert.ToString(drowDetails.ItemArray[11])), PublicVariables._inNoOfDecimalPlaces);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtbarcode"].Value = Convert.ToString(drowDetails.ItemArray[8]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value = bllUnitConversion.UnitConversionRateByUnitConversionId(Convert.ToDecimal(drowDetails.ItemArray[9].ToString()));
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drowDetails.ItemArray[9].ToString());
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbGodown"].Value = (Convert.ToString(drowDetails.ItemArray[17]) != null) ? Convert.ToDecimal(drowDetails.ItemArray[17].ToString()) : 0;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbRack"].Value = (drowDetails.ItemArray[18].ToString() != null) ? Convert.ToDecimal(drowDetails.ItemArray[18].ToString()) : 0;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbBatch"].Value = (drowDetails.ItemArray[19].ToString() != null) ? Convert.ToDecimal(drowDetails.ItemArray[19].ToString()) : 0;
                        decGrossAmount = decQty * decRate;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drowDetails.ItemArray[12].ToString());
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drowDetails.ItemArray[9]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtgrossValue"].Value = Math.Round(decGrossAmount, PublicVariables._inNoOfDecimalPlaces);

                        if (Convert.ToString(drowDetails.ItemArray[7]) != string.Empty)
                        {
                            dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtdiscount"].Value = Convert.ToString(drowDetails.ItemArray[7]);
                            decDiscountAmount = Math.Round(Convert.ToDecimal(Convert.ToString(drowDetails.ItemArray[7])), PublicVariables._inNoOfDecimalPlaces);
                        }
                        else
                        {
                            decDiscountAmount = 0;
                            dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtdiscount"].Value = 0;
                        }
                        decNetAmount = decGrossAmount - decDiscountAmount;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtNetAmount"].Value = (decNetAmount != 0) ? Math.Round(decNetAmount, PublicVariables._inNoOfDecimalPlaces) : 0;
                        if (strTaxComboFill != string.Empty)
                        {
                            if (drowDetails.ItemArray[13].ToString() != string.Empty && Convert.ToDecimal(drowDetails.ItemArray[13].ToString()) != 0)
                            {
                                dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbTax"].Value = Convert.ToDecimal(drowDetails.ItemArray[13].ToString());
                                strTaxRate1 = BllPurchaseReturn.TaxRateFromPurchaseDetails(Convert.ToDecimal(Convert.ToString(drowDetails.ItemArray[13])));
                            }
                            else
                            {
                                dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbTax"].Value = "NA";
                                strTaxRate1 = string.Empty;
                            }

                            if (strTaxRate1 != string.Empty)
                            {
                                decTaxRate = Convert.ToDecimal(strTaxRate1);
                                decTaxAmount = ((decNetAmount * decTaxRate) / 100);
                                dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxttaxAmount"].Value = Math.Round(decTaxAmount, PublicVariables._inNoOfDecimalPlaces);
                            }
                            else
                            {
                                dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxttaxAmount"].Value = 0;
                            }
                        }
                        else
                        {
                            dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxttaxAmount"].Value = 0;
                        }
                        decAmount = decNetAmount + decTaxAmount;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtAmount"].Value = Math.Round(decAmount, PublicVariables._inNoOfDecimalPlaces);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtproductCode"].ReadOnly = true;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtproductName"].ReadOnly = true;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtbarcode"].ReadOnly = true;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvcmbBatch"].ReadOnly = true;
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 2].Cells["dgvtxtInRowIndex"].Value = Convert.ToString(drowDetails["extra1"]);
                        dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 1].ReadOnly = true;
                        int intIndex = 0;
                        int.TryParse(Convert.ToString(drowDetails["extra1"]), out intIndex);
                        if (inMaxCount < intIndex)
                            inMaxCount = intIndex;
                        inRowIndex++;
                    }
                    for (int i = inRowIndex; i < dgvPurchaseReturn.Rows.Count; ++i)
                        dgvPurchaseReturn["dgvtxtInRowIndex", i].Value = Convert.ToString(GetNextinRowIndex());
                    CalculateTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Grid HeaderStyle For Invalid Entries of grid
        /// </summary>
        public void gridHeaderStyleForInvalidEntries()
        {
            try
            {
                isValueChanged = true;
                dgvPurchaseReturn.CurrentRow.HeaderCell.Value = "X";
                dgvPurchaseReturn.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function To check whether the values in grid is valid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (dgvPurchaseReturn.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductCode"].Value == null || dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductCode"].Value.ToString().Trim() == string.Empty)
                        {
                            gridHeaderStyleForInvalidEntries();
                        }
                        else if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtqty"].Value == null || dgvPurchaseReturn.CurrentRow.Cells["dgvtxtqty"].Value.ToString().Trim() == string.Empty ||
                          Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtqty"].Value.ToString()) == 0)
                        {
                            gridHeaderStyleForInvalidEntries();
                        }
                        else if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtrate"].Value) == 0)
                        {
                            gridHeaderStyleForInvalidEntries();
                        }
                        else if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtrate"].Value == null || dgvPurchaseReturn.CurrentRow.Cells["dgvtxtrate"].Value.ToString().Trim() == string.Empty)
                        {
                            gridHeaderStyleForInvalidEntries();
                        }
                        else if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductName"].Value == null || dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductName"].Value.ToString().Trim() == string.Empty)
                        {
                            gridHeaderStyleForInvalidEntries();
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvPurchaseReturn.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for calculations
        /// </summary>
        public void Calculate()
        {
            try
            {
                CalculateTotalAmount();
                TotalTaxAmount();
                CalculateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Remove Rows from grid
        /// </summary>
        public void RemoveFunction()
        {
            try
            {
                dgvPurchaseReturn.Rows.RemoveAt(dgvPurchaseReturn.CurrentRow.Index);
                dgvPurchaseReturn.CurrentCell = null;
                dgvPurchaseReturn.Focus();
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Remove incomplete Rows from grid
        /// </summary>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvPurchaseReturn.RowCount;
                int inLastRow = 1;
                if (inRowcount <= 2)
                {
                    if (dgvPurchaseReturn.Rows[0].Cells["dgvtxtproductName"].Value == null || dgvPurchaseReturn.Rows[0].Cells["dgvtxtproductName"].Value.ToString() == string.Empty ||
                        dgvPurchaseReturn.Rows[0].Cells["dgvtxtproductCode"].Value == null || dgvPurchaseReturn.Rows[0].Cells["dgvtxtproductCode"].Value.ToString() == string.Empty ||
                        dgvPurchaseReturn.Rows[0].Cells["dgvtxtrate"].Value == null || dgvPurchaseReturn.Rows[0].Cells["dgvtxtrate"].Value.ToString().Trim() == string.Empty ||
                        dgvPurchaseReturn.Rows[0].Cells["dgvtxtqty"].Value == null || dgvPurchaseReturn.Rows[0].Cells["dgvtxtqty"].Value.ToString().Trim() == string.Empty ||
                          Convert.ToDecimal(dgvPurchaseReturn.Rows[0].Cells["dgvtxtqty"].Value.ToString()) == 0 ||
                        (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvPurchaseReturn.Rows[0].Cells["dgvtxtrate"].Value) == 0))
                    {
                        Messages.InformationMessage("Can't save purchase return without atleast one product with complete details");
                        dgvPurchaseReturn.ClearSelection();
                        dgvPurchaseReturn.Focus();
                        isOk = false;
                    }
                }
                else
                {
                    foreach (DataGridViewRow dgvrowCur in dgvPurchaseReturn.Rows)
                    {
                        if (inLastRow < inRowcount && dgvrowCur.HeaderCell.Value != null)
                        {
                            if (dgvrowCur.HeaderCell.Value.ToString() == "X" || dgvrowCur.Cells["dgvtxtproductName"].Value == null)
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
                        inLastRow++;
                    }
                    inLastRow = 1;
                    if (!isOk)
                    {
                        strMessage = strMessage + " contains invalid entries. Do you want to continue?";
                        if (MessageBox.Show(strMessage, "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            isOk = true;
                            for (int inK = 0; inK < dgvPurchaseReturn.Rows.Count; inK++)
                            {
                                if (dgvPurchaseReturn.Rows[inK].HeaderCell.Value != null && dgvPurchaseReturn.Rows[inK].HeaderCell.Value.ToString() == "X" && !dgvPurchaseReturn.Rows[inK].IsNewRow)
                                {
                                    dgvPurchaseReturn.Rows.RemoveAt(inK);
                                    inK--;
                                    SerialNo();
                                }
                            }
                        }
                        else
                        {
                            isOk = false;
                            dgvPurchaseReturn.Rows[inForFirst].Cells["dgvtxtproductName"].Selected = true;
                            dgvPurchaseReturn.CurrentCell = dgvPurchaseReturn.Rows[inForFirst].Cells["dgvtxtproductName"];
                            dgvPurchaseReturn.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to check Negative Stock at the time of saving and updating
        /// </summary>
        public bool SaveOrEditCheck()
        {
            bool isOk = false;
            try
            {
                decimal decProductId = 0;
                decimal decBatchId = 0;
                decimal decCalcQty = 0;
                StockPostingBll BllStockPosting = new StockPostingBll();
                //StockPostingSP spStockPosting = new StockPostingSP();
                SettingsBll BllSettings = new SettingsBll();
                string strStatus = BllSettings.SettingsStatusCheck("NegativeStockStatus");
                bool isNegativeLedger = false;
                DataTable dtblPurchaseMasterViewById = new DataTable();
                PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                dgvPurchaseReturn.ClearSelection();
                int inRow = dgvPurchaseReturn.RowCount;
                if (txtReturnNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter Return number");
                    txtReturnNo.Focus();
                }
                else if (BllPurchaseReturn.PurchaseReturnNumberCheckExistence(txtReturnNo.Text.Trim(), decPurchaseReturnVoucherTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Return number already exist");
                    txtReturnNo.Focus();
                }
                else if ((btnSave.Text == "Update") && (txtReturnNo.Text != strReturnNo) && (BllPurchaseReturn.PurchaseReturnNumberCheckExistence(txtReturnNo.Text.Trim(), decPurchaseReturnVoucherTypeId) == true))
                {
                    Messages.InformationMessage("Return number already exist");
                    txtReturnNo.Focus();
                }
                else if (txtDate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select a date in between financial year");
                    txtDate.Focus();
                }
                else if (cmbInvoiceNo.Visible == true && cmbInvoiceNo.SelectedValue == null)
                {
                    Messages.InformationMessage("Select a invoice no");
                    cmbInvoiceNo.Focus();
                }
                else
                {
                    if (RemoveIncompleteRowsFromGrid())
                    {
                        int inRowCount = dgvPurchaseReturn.RowCount;
                        if (inRowCount > 1)
                        {
                            for (int i = 0; i < inRowCount - 1; i++)
                            {
                                if (dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductId"].Value != null && dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductId"].Value.ToString() != string.Empty)
                                {
                                    decProductId = Convert.ToDecimal(dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductId"].Value.ToString());
                                    if (dgvPurchaseReturn.Rows[i].Cells["dgvcmbBatch"].Value != null && dgvPurchaseReturn.Rows[i].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                                    {
                                        decBatchId = Convert.ToDecimal(dgvPurchaseReturn.Rows[i].Cells["dgvcmbBatch"].Value.ToString());
                                    }
                                    decimal decCurrentStock = BllStockPosting.StockCheckForProductSale(decProductId, decBatchId);
                                    if (dgvPurchaseReturn.Rows[i].Cells["dgvtxtqty"].Value != null && dgvPurchaseReturn.Rows[i].Cells["dgvtxtqty"].Value.ToString() != string.Empty)
                                    {
                                        decCalcQty = decCurrentStock - Convert.ToDecimal(dgvPurchaseReturn.Rows[i].Cells["dgvtxtqty"].Value.ToString());
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
                                        isOk = true;
                                    }
                                }
                                else if (strStatus == "Block")
                                {
                                    MessageBox.Show("Cannot continue ,due to negative stock balance", "Open miracle", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    isOk = false;
                                }
                                else
                                {
                                    isOk = true;
                                }
                            }
                            else
                            {
                                isOk = true;
                            }
                        }
                        else
                        {
                            isOk = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function for Save and Edit
        /// </summary>  
        public void SaveOrEdit()
        {
            try
            {
                PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
                PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                PurchaseReturnDetailsInfo infoPurchaseReturnDetails = new PurchaseReturnDetailsInfo();
                StockPostingInfo infoStockPosting = new StockPostingInfo();
                //StockPostingSP spStockPosting = new StockPostingSP();
                StockPostingBll BllStockPosting = new StockPostingBll();
                UnitConvertionBll BllUnitConvertion = new UnitConvertionBll();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();               
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                PurchaseReturnBilltaxInfo infoPurchaseReturnBillTax = new PurchaseReturnBilltaxInfo();

                SettingsBll BllSettings = new SettingsBll();
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                string strAgainstVoucherNo = string.Empty;
                string strAgainstInvoiceNo = string.Empty;
                decimal decPurchaseReturnMasterIds = 0;
                decimal decPurchaseMasterId = 0;
                decimal decDiscount = 0;
                decimal decExchangeRate = 0;
                decimal decDis = 0;

                if (isAutomatic)
                {
                    if (strVoucherNo != string.Empty)
                    {
                        infoPurchaseReturnMaster.VoucherNo = strVoucherNo;
                    }
                    if (txtReturnNo.Text != string.Empty)
                    {
                        infoPurchaseReturnMaster.InvoiceNo = txtReturnNo.Text;
                    }
                }
                else
                {
                    infoPurchaseReturnMaster.VoucherNo = strVoucherNo;
                    infoPurchaseReturnMaster.InvoiceNo = txtReturnNo.Text;
                }
                if (decPurchaseReturnVoucherTypeId != 0)
                {
                    infoPurchaseReturnMaster.VoucherTypeId = decPurchaseReturnVoucherTypeId;
                }
                infoPurchaseReturnMaster.SuffixPrefixId = (decPurchaseReturnSuffixPrefixId != 0) ? decPurchaseReturnSuffixPrefixId : 0;
                infoPurchaseReturnMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoPurchaseReturnMaster.PurchaseAccount = Convert.ToDecimal(cmbPurchaseAccount.SelectedValue.ToString());
                if (cmbInvoiceNo.SelectedValue != null && cmbInvoiceNo.Visible == true)
                {
                    infoPurchaseReturnMaster.PurchaseMasterId = Convert.ToDecimal((cmbInvoiceNo.SelectedValue.ToString()));
                    decPurchaseMasterId = Convert.ToDecimal((cmbInvoiceNo.SelectedValue.ToString()));
                }
                else
                {
                    infoPurchaseReturnMaster.PurchaseMasterId = 0;
                }
                infoPurchaseReturnMaster.ExchangeRateId = (cmbCurrency.SelectedValue != null) ? Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()) : 0;
                infoPurchaseReturnMaster.Narration = txtNarration.Text.Trim();
                infoPurchaseReturnMaster.UserId = PublicVariables._decCurrentUserId;
                infoPurchaseReturnMaster.LrNo = txtLrlNo.Text.Trim();
                infoPurchaseReturnMaster.TransportationCompany = txtTransportationCompany.Text.Trim();
                infoPurchaseReturnMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoPurchaseReturnMaster.TotalAmount = (txtTotalAmount.Text != string.Empty) ? Convert.ToDecimal(txtTotalAmount.Text) : 0;
                infoPurchaseReturnMaster.TotalTax = (lblTaxAmount.Text != string.Empty) ? Convert.ToDecimal(lblTaxAmount.Text) : 0;
                infoPurchaseReturnMaster.Discount = (txtBillDiscount.Text != string.Empty) ? Convert.ToDecimal(txtBillDiscount.Text) : 0;
                infoPurchaseReturnMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPurchaseReturnMaster.Extra1 = string.Empty;
                infoPurchaseReturnMaster.Extra2 = string.Empty;
                infoPurchaseReturnMaster.ExtraDate = DateTime.Now;
                infoPurchaseReturnMaster.GrandTotal = (txtGrandTotal.Text != string.Empty) ? Convert.ToDecimal(txtGrandTotal.Text) : 0;
                if (btnSave.Text == "Save")
                {
                    decPurchaseReturnMasterIds = BllPurchaseReturn.PurchaseReturnMasterAddWithReturnIdentity(infoPurchaseReturnMaster);
                }
                else
                {
                    infoPurchaseReturnMaster.PurchaseReturnMasterId = decPurchaseReturnMasterId;
                    decExchangeRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(infoPurchaseReturnMaster.ExchangeRateId);
                    BllPurchaseReturn.PurchaseReturnMasterEdit(infoPurchaseReturnMaster);
                    infoPurchaseMaster = BllPurchaseInvoice.PurchaseMasterView(infoPurchaseReturnMaster.PurchaseMasterId);
                    BllLedgerPosting.LedgerPostDelete(strVoucherNo, decPurchaseReturnVoucherTypeId);
                    bllAccountLedger.PartyBalanceDeleteByVoucherTypeVoucherNoAndReferenceType(strVoucherNo, decPurchaseReturnVoucherTypeId);
                }

                infoLedgerPosting.Date = infoPurchaseReturnMaster.Date;
                infoLedgerPosting.VoucherTypeId = infoPurchaseReturnMaster.VoucherTypeId;
                infoLedgerPosting.VoucherNo = infoPurchaseReturnMaster.VoucherNo;
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.InvoiceNo = infoPurchaseReturnMaster.InvoiceNo;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;

                infoLedgerPosting.LedgerId = infoPurchaseReturnMaster.PurchaseAccount;
                infoLedgerPosting.Debit = 0;
                if (btnSave.Text == "Save")
                {
                    infoLedgerPosting.Credit = TotalNetAmountCalculation() * BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                    infoLedgerPosting.ExtraDate = DateTime.Now;
                }
                else
                {
                    infoLedgerPosting.Credit = TotalNetAmountCalculation();
                }
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);

                infoLedgerPosting.LedgerId = infoPurchaseReturnMaster.LedgerId;
                if (btnSave.Text == "Save")
                {
                    infoLedgerPosting.Debit = Convert.ToDecimal(txtGrandTotal.Text) * BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                    infoLedgerPosting.ExtraDate = DateTime.Now;
                }
                else
                {
                    infoLedgerPosting.Debit = Convert.ToDecimal(txtGrandTotal.Text);
                }
                infoLedgerPosting.Credit = 0;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);

                foreach (DataGridViewRow dgvrow in dgvPurchaseReturnTax.Rows)
                {
                    if (dgvrow.Cells["dgvtxtTaxId"].Value != null && dgvrow.Cells["dgvtxtTaxId"].Value.ToString() != string.Empty)
                    {
                        infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvtxtledgerId"].Value.ToString());
                        infoLedgerPosting.Credit = (dgvrow.Cells["dgvtxtAmounts"].Value == null) ? 0 : Convert.ToDecimal(dgvrow.Cells["dgvtxtAmounts"].Value.ToString());
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.ExtraDate = DateTime.Now;
                        BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    }
                }

                if (txtBillDiscount.Text.Trim() != string.Empty)
                {
                    decDis = Convert.ToDecimal(txtBillDiscount.Text);
                }
                if (decDis >= 0)
                {
                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = decDis;
                    infoLedgerPosting.LedgerId = 9;
                    infoLedgerPosting.ExtraDate = DateTime.Now;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                }

                if (btnSave.Text == "Update")
                {
                    infoPurchaseReturnMaster = BllPurchaseReturn.PurchaseReturnMasterView(decPurchaseReturnMasterId);
                    if (infoPurchaseReturnMaster.PurchaseMasterId == 0)
                    {
                        BllStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(0, "NA", infoPurchaseReturnMaster.VoucherNo, infoPurchaseReturnMaster.VoucherTypeId);
                    }
                    if (infoPurchaseReturnMaster.PurchaseMasterId != 0)
                    {
                        infoPurchaseMaster = BllPurchaseInvoice.PurchaseMasterView(infoPurchaseReturnMaster.PurchaseMasterId);
                        BllStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(infoPurchaseMaster.VoucherTypeId, strInvoiceNo, strVoucherNo, infoPurchaseReturnMaster.VoucherTypeId);
                    }
                }

                foreach (DataGridViewRow dgvrow in dgvPurchaseReturn.Rows)
                {
                    if (dgvrow.Cells["dgvtxtProductId"].Value != null && dgvrow.Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                    {
                        infoPurchaseReturnDetails.ExtraDate = DateTime.Now;
                        infoPurchaseReturnDetails.Extra1 = string.Empty;
                        infoPurchaseReturnDetails.Extra2 = string.Empty;
                        infoPurchaseReturnDetails.PurchaseReturnMasterId = (btnSave.Text == "Save") ? decPurchaseReturnMasterIds : decPurchaseReturnMasterId;
                        infoPurchaseReturnDetails.ProductId = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtproductId"].Value));
                        infoPurchaseReturnDetails.Qty = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtqty"].Value));
                        infoPurchaseReturnDetails.Rate = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtrate"].Value));
                        if (btnSave.Text == "Save")
                        {
                            infoPurchaseReturnDetails.UnitId = Convert.ToDecimal(dgvrow.Cells["dgvcmbUnit"].Value.ToString());
                            infoPurchaseReturnDetails.UnitConversionId = BllUnitConvertion.UnitconversionIdViewByUnitIdAndProductId(infoPurchaseReturnDetails.UnitId, infoPurchaseReturnDetails.ProductId);
                        }
                        else
                        {
                            if (Convert.ToDecimal(dgvrow.Cells["dgvtxtPurchaseReturnDetailsId"].Value) == 0)
                            {
                                try
                                {
                                    infoPurchaseReturnDetails.UnitId = Convert.ToDecimal(dgvrow.Cells["dgvcmbUnit"].Value.ToString());
                                }
                                catch
                                {
                                    infoPurchaseReturnDetails.UnitId = bllUnit.UnitIdByUnitName(Convert.ToString(dgvrow.Cells["dgvcmbUnit"].Value.ToString()));
                                }
                                infoPurchaseReturnDetails.UnitConversionId = BllUnitConvertion.UnitconversionIdViewByUnitIdAndProductId(infoPurchaseReturnDetails.UnitId, infoPurchaseReturnDetails.ProductId);
                            }
                            else
                            {
                                try
                                {
                                    infoPurchaseReturnDetails.UnitId = Convert.ToDecimal(dgvrow.Cells["dgvcmbUnit"].Value.ToString());
                                }
                                catch
                                {
                                    infoPurchaseReturnDetails.UnitId = bllUnit.UnitIdByUnitName(Convert.ToString(dgvrow.Cells["dgvcmbUnit"].Value.ToString()));
                                }
                            }
                            infoPurchaseReturnDetails.UnitConversionId = Convert.ToDecimal(dgvrow.Cells["dgvtxtUnitConversionId"].Value);
                        }
                        infoPurchaseReturnDetails.Discount = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtdiscount"].Value));
                        if (dgvrow.Cells["dgvcmbTax"].Value != null && Convert.ToString(dgvrow.Cells["dgvcmbTax"].Value) != string.Empty && dgvrow.Cells["dgvcmbTax"].Value as string != "NA")
                        {
                            infoPurchaseReturnDetails.TaxId = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvcmbTax"].Value));
                            if (strTaxComboFill != string.Empty)
                            {
                                infoPurchaseReturnDetails.TaxAmount = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtTaxAmount"].Value));
                            }
                        }
                        else
                        {
                            infoPurchaseReturnDetails.TaxId = 0;
                        }
                        if (dgvrow.Cells["dgvcmbBatch"].Value != null && Convert.ToString(dgvrow.Cells["dgvcmbBatch"].Value) != string.Empty)
                        {
                            infoPurchaseReturnDetails.BatchId = Convert.ToDecimal(dgvrow.Cells["dgvcmbBatch"].Value);
                        }
                        else
                        {
                            infoPurchaseReturnDetails.GodownId = 0;
                        }
                        if (dgvrow.Cells["dgvcmbGodown"].Value != null && Convert.ToString(dgvrow.Cells["dgvcmbGodown"].Value) != string.Empty)
                        {
                            infoPurchaseReturnDetails.GodownId = Convert.ToDecimal(dgvrow.Cells["dgvcmbGodown"].Value);
                        }
                        else
                        {
                            infoPurchaseReturnDetails.RackId = 0;
                        }
                        if (dgvrow.Cells["dgvcmbRack"].Value != null && Convert.ToString(dgvrow.Cells["dgvcmbRack"].Value) != string.Empty)
                        {
                            infoPurchaseReturnDetails.RackId = Convert.ToDecimal(dgvrow.Cells["dgvcmbRack"].Value);
                        }
                        infoPurchaseReturnDetails.GrossAmount = Convert.ToDecimal(dgvrow.Cells["dgvtxtgrossValue"].Value.ToString());
                        infoPurchaseReturnDetails.NetAmount = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtNetAmount"].Value));
                        infoPurchaseReturnDetails.Amount = Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtAmount"].Value));
                        infoPurchaseReturnDetails.SlNo = Convert.ToInt32(Convert.ToString(dgvrow.Cells["dgvtxtSlNo"].Value));
                        infoPurchaseReturnDetails.PurchaseDetailsId = (dgvrow.Cells["dgvtxtPurchaseDetailsId"].Value != null) ? Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtPurchaseDetailsId"].Value)) : 0;
                        if (dgvrow.Cells["dgvtxtPurchaseReturnDetailsId"].Value != null)
                        {
                            if (dgvrow.Cells["dgvtxtPurchaseReturnDetailsId"].Value.ToString() == "0" || dgvrow.Cells["dgvtxtPurchaseReturnDetailsId"].Value.ToString() == string.Empty)
                            {
                                BllPurchaseReturn.PurchaseReturnDetailsAddWithReturnIdentity(infoPurchaseReturnDetails);
                            }
                            else
                            {
                                infoPurchaseReturnDetails.PurchaseReturnDetailsId = Convert.ToDecimal(dgvrow.Cells["dgvtxtPurchaseReturnDetailsId"].Value.ToString());
                                BllPurchaseReturn.PurchaseReturnDetailsEdit(infoPurchaseReturnDetails);
                            }
                        }
                        else
                        {
                            BllPurchaseReturn.PurchaseReturnDetailsAddWithReturnIdentity(infoPurchaseReturnDetails);
                        }

                        if (btnSave.Text == "Save")
                        {
                            infoPurchaseMaster = BllPurchaseInvoice.PurchaseMasterView(infoPurchaseReturnMaster.PurchaseMasterId);
                        }
                        infoStockPosting.Date = infoPurchaseReturnMaster.Date;
                        infoStockPosting.ProductId = infoPurchaseReturnDetails.ProductId;
                        infoStockPosting.BatchId = infoPurchaseReturnDetails.BatchId;
                        infoStockPosting.UnitId = infoPurchaseReturnDetails.UnitId;
                        infoStockPosting.GodownId = infoPurchaseReturnDetails.GodownId;
                        infoStockPosting.RackId = infoPurchaseReturnDetails.RackId;
                        decimal decConversionId = BllUnitConvertion.UnitConversionRateByUnitConversionId(infoPurchaseReturnDetails.UnitConversionId);
                        //infoStockPosting.OutwardQty = infoPurchaseReturnDetails.Qty / (decConversionId == 0 ? 1 : decConversionId);
                        infoStockPosting.OutwardQty = infoPurchaseReturnDetails.Qty;
                        infoStockPosting.InwardQty = 0;
                        infoStockPosting.Rate = infoPurchaseReturnDetails.Rate;
                        infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                        infoStockPosting.Extra1 = string.Empty;
                        infoStockPosting.Extra2 = string.Empty;
                        if (infoPurchaseReturnDetails.PurchaseDetailsId != 0)
                        {
                            infoStockPosting.AgainstVoucherTypeId = infoPurchaseMaster.VoucherTypeId;
                            infoStockPosting.AgainstVoucherNo = infoPurchaseMaster.VoucherNo;
                            infoStockPosting.AgainstInvoiceNo = infoPurchaseMaster.InvoiceNo;
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.InvoiceNo = txtReturnNo.Text.Trim();
                            infoStockPosting.VoucherTypeId = decPurchaseReturnVoucherTypeId;
                            decAgainstVoucherTypeId = infoStockPosting.VoucherTypeId;
                        }
                        else
                        {
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.AgainstInvoiceNo = "NA";
                            infoStockPosting.VoucherNo = infoPurchaseReturnMaster.VoucherNo;
                            infoStockPosting.InvoiceNo = infoPurchaseReturnMaster.InvoiceNo;
                            infoStockPosting.VoucherTypeId = decPurchaseReturnVoucherTypeId;
                            decAgainstVoucherTypeId = 0;
                        }
                        BllStockPosting.StockPostingAdd(infoStockPosting);
                    }
                }
                if (btnSave.Text == "Update")
                {
                    removePurchaseReturnDetails();
                }

                infoAccountLedger = bllAccountLedger.AccountLedgerView(infoPurchaseReturnMaster.LedgerId);
                if (infoAccountLedger.BillByBill == true)
                {
                    infoPartyBalance.Date = infoPurchaseReturnMaster.Date;
                    infoPartyBalance.LedgerId = infoPurchaseReturnMaster.LedgerId;
                    if (decAgainstVoucherTypeId != 0)
                    {
                        infoPartyBalance.VoucherTypeId = infoPurchaseMaster.VoucherTypeId;
                        infoPartyBalance.VoucherNo = infoPurchaseMaster.VoucherNo;
                        infoPartyBalance.InvoiceNo = infoPurchaseMaster.InvoiceNo;
                        infoPartyBalance.AgainstVoucherTypeId = infoPurchaseReturnMaster.VoucherTypeId;
                        infoPartyBalance.AgainstVoucherNo = infoPurchaseReturnMaster.VoucherNo;
                        infoPartyBalance.AgainstInvoiceNo = infoPurchaseReturnMaster.InvoiceNo;
                        infoPartyBalance.ReferenceType = "Against";
                    }
                    else
                    {
                        infoPartyBalance.VoucherTypeId = infoPurchaseReturnMaster.VoucherTypeId;
                        infoPartyBalance.VoucherNo = infoPurchaseReturnMaster.VoucherNo;
                        infoPartyBalance.InvoiceNo = infoPurchaseReturnMaster.InvoiceNo;
                        infoPartyBalance.AgainstVoucherTypeId = 0;
                        infoPartyBalance.AgainstVoucherNo = "NA";
                        infoPartyBalance.AgainstInvoiceNo = "NA";
                        infoPartyBalance.ReferenceType = "New";
                    }
                    infoPartyBalance.Debit = infoPurchaseReturnMaster.TotalAmount;
                    infoPartyBalance.Credit = 0;
                    infoPartyBalance.CreditPeriod = 0;
                    infoPartyBalance.ExchangeRateId = infoPurchaseReturnMaster.ExchangeRateId;
                    infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoPartyBalance.Extra1 = string.Empty;
                    infoPartyBalance.Extra2 = string.Empty;
                    BllPartyBalance.PartyBalanceAdd(infoPartyBalance);
                }

                foreach (DataGridViewRow item in dgvPurchaseReturnTax.Rows)
                {
                    if (item.Cells["dgvtxtTaxId"].Value != null)
                    {
                        if (Convert.ToDecimal(item.Cells["dgvtxtAmounts"].Value.ToString()) > 0)
                        {
                            infoPurchaseReturnBillTax.PurchaseReturnMasterId = (btnSave.Text == "Save") ? decPurchaseReturnMasterIds : decPurchaseReturnMasterIds;
                            infoPurchaseReturnBillTax.TaxId = Convert.ToDecimal(item.Cells["dgvtxtTaxId"].Value.ToString());
                            infoPurchaseReturnBillTax.TaxAmount = (item.Cells["dgvtxtAmounts"].Value == null) ? 0 : Convert.ToDecimal(item.Cells["dgvtxtAmounts"].Value.ToString());
                            infoPurchaseReturnBillTax.Extra1 = string.Empty;
                            infoPurchaseReturnBillTax.Extra2 = string.Empty;
                            BllPurchaseReturn.PurchaseReturnBilltaxAdd(infoPurchaseReturnBillTax);
                        }
                    }
                }
                if (btnSave.Text == "Save")
                {
                    Messages.SavedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decPurchaseReturnMasterIds);
                        }
                        else
                        {
                            Print(decPurchaseReturnMasterIds);
                        }
                    }
                    Clear();
                }
                else
                {
                    decDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                    Messages.UpdatedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decPurchaseReturnMasterId);
                        }
                        else
                        {
                            Print(decPurchaseReturnMasterId);
                        }
                    }
                    if (frmPurchaseReturnRegisterObj != null)
                    {
                        frmPurchaseReturnRegisterObj.GridFill();
                        frmPurchaseReturnRegisterObj.Enabled = true;
                    }

                    if (ObjPurchaseReturnReport != null)
                    {
                        ObjPurchaseReturnReport.PurchaseReturnReportGridFill();
                        ObjPurchaseReturnReport.Enabled = true;
                    }
                    if (frmLedgerDetailsObj != null)
                    {
                        frmLedgerDetailsObj.LedgerDetailsView();
                        frmLedgerDetailsObj.Enabled = true;
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Delete
        /// </summary>
        public void Delete()
        {
            try
            {
                 StockPostingBll BllStockPosting=new StockPostingBll();
               // StockPostingSP spStockPosting = new StockPostingSP();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
                PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                PurchaseMasterInfo infoPurchaseMaster = new PurchaseMasterInfo();
                PurchaseReturnMasterInfo infoPurchaseReturnMaster = new PurchaseReturnMasterInfo();

                infoPurchaseReturnMaster = BllPurchaseReturn.PurchaseReturnMasterView(decPurchaseReturnMasterId);
                if (infoPurchaseReturnMaster.PurchaseMasterId == 0)
                {
                    BllStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(0, "NA", infoPurchaseReturnMaster.VoucherNo, infoPurchaseReturnMaster.VoucherTypeId);
                }
                if (infoPurchaseReturnMaster.PurchaseMasterId != 0)
                {
                    infoPurchaseMaster = BllPurchaseInvoice.PurchaseMasterView(infoPurchaseReturnMaster.PurchaseMasterId);
                    BllStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(infoPurchaseMaster.VoucherTypeId, infoPurchaseMaster.VoucherNo, strVoucherNo, infoPurchaseReturnMaster.VoucherTypeId);
                }
                BllLedgerPosting.LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndLedgerIdAndVoucherNo(decPurchaseReturnVoucherTypeId, strVoucherNo, txtReturnNo.Text);
                BllPurchaseReturn.PurchaseReturnMasterAndDetailsDelete(decPurchaseReturnMasterId);

                Messages.DeletedMessage();
                if (frmPurchaseReturnRegisterObj != null)
                {
                    this.Close();
                    frmPurchaseReturnRegisterObj.GridFill();
                }
                if (ObjPurchaseReturnReport != null)
                {
                    this.Close();
                    ObjPurchaseReturnReport.PurchaseReturnReportGridFill();
                }
                if (frmLedgerDetailsObj != null)
                {
                    this.Close();
                    frmLedgerDetailsObj.LedgerDetailsView();
                }
                if (objVoucherSearch != null)
                {
                    this.Close();
                    objVoucherSearch.GridFill();
                }
                if (frmDayBookObj != null)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:50 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Delete PurchaseReturnDetails on updation
        /// </summary>
        public void removePurchaseReturnDetails()
        {
            try
            {
                PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                foreach (var strId in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strId);
                    BllPurchaseReturn.PurchaseReturnDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:51 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for call from Purchase Return Register
        /// </summary>
        /// <param name="frmPurchaseReturnRegister"></param>
        /// <param name="decPurchaseReturnMasterid"></param>
        /// <param name="isFromRegister"></param>
        public void CallFromPurchaseReturnRegister(frmPurchaseReturnRegister frmPurchaseReturnRegister, decimal decPurchaseReturnMasterid, bool isFromRegister)
        {
            try
            {
                base.Show();
                this.frmPurchaseReturnRegisterObj = frmPurchaseReturnRegister;
                frmPurchaseReturnRegisterObj.Enabled = false;
                isFromPurchaseReturn = isFromRegister;
                decPurchaseReturnMasterId = decPurchaseReturnMasterid;
                isInvoiceFil = true;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for getting InvoiceNo Corresponding to Ledger In Register
        /// </summary>
        public void InvoiceNoComboFillInRegister()
        {
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            try
            {
                isInvoiceFil = true;
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = BllPurchaseInvoice.GetInvoiceNoCorrespondingtoLedgerInRegister();
                cmbInvoiceNo.DataSource = ListObj[0];
                if (cmbInvoiceNo.DataSource != null)
                {
                    cmbInvoiceNo.DisplayMember = "invoiceNo";
                    cmbInvoiceNo.ValueMember = "purchaseMasterId";
                    cmbInvoiceNo.SelectedIndex = -1;
                }
                isInvoiceFil = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function for call from Purchase Return Report
        /// </summary>
        /// <param name="objPurchaseReturnReport"></param>
        /// <param name="decPurchaseReturnMasterID"></param>
        /// <param name="isFromReport"></param>
        public void CallFromPurchaseReturnReport(frmPurchaseReturnReport objPurchaseReturnReport, decimal decPurchaseReturnMasterID, bool isFromReport)
        {
            try
            {
                base.Show();
                this.ObjPurchaseReturnReport = objPurchaseReturnReport;
                decPurchaseReturnMasterId = decPurchaseReturnMasterID;
                isFromPurchaseReturn = isFromReport;
                isInvoiceFil = true;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for fill details in Purchase Return when coming from Register or Report
        /// </summary>
        public void FillRegisterOrReport()
        {
            try
            {
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtReturnNo.ReadOnly = true;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> ListObjPurchaseReturnMaster = new List<DataTable>();
                List<DataTable> ListObjPurchaseMasterViewById = new List<DataTable>();
                UnitConvertionBll BllUnitConvertion = new UnitConvertionBll();               
                PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                BatchBll BllBatch = new BatchBll();
                List<DataTable> ListObj = new List<DataTable>();
                decimal decPurchaseReturnDetailsId = 0;
                decimal decTotalValue = 0;
                decimal decRegisterTotalAmount = 0;
                decimal decInvoiceNo = 0;
                ListObjPurchaseReturnMaster = BllPurchaseReturn.PurchaseReturnViewByPurchaseReturnMasterId(decPurchaseReturnMasterId);
                if (ListObjPurchaseReturnMaster[0].Rows.Count > 0)
                {
                    txtReturnNo.Text = ListObjPurchaseReturnMaster[0].Rows[0]["invoiceNo"].ToString();
                    strReturnNo = ListObjPurchaseReturnMaster[0].Rows[0]["invoiceNo"].ToString();
                    strVoucherNo = ListObjPurchaseReturnMaster[0].Rows[0]["voucherNo"].ToString();
                    decPurchaseReturnSuffixPrefixId = Convert.ToDecimal(ListObjPurchaseReturnMaster[0].Rows[0]["suffixPrefixId"].ToString());
                    decPurchaseReturnVoucherTypeId = Convert.ToDecimal(ListObjPurchaseReturnMaster[0].Rows[0]["voucherTypeId"].ToString());
                    VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                    infoVoucherType = BllVoucherType.VoucherTypeView(decPurchaseReturnVoucherTypeId);
                    this.Text = infoVoucherType.VoucherTypeName;
                    isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decPurchaseReturnVoucherTypeId);
                    txtReturnNo.ReadOnly = (isAutomatic) ? true : false;
                    decPurchaseReturnTypeId = decPurchaseReturnVoucherTypeId;
                    dtpDate.Text = ListObjPurchaseReturnMaster[0].Rows[0]["date"].ToString();
                    cmbCashOrParty.SelectedValue = ListObjPurchaseReturnMaster[0].Rows[0]["ledgerId"].ToString();
                    cmbPurchaseAccount.SelectedValue = ListObjPurchaseReturnMaster[0].Rows[0]["purchaseAccount"].ToString();
                    txtTransportationCompany.Text = ListObjPurchaseReturnMaster[0].Rows[0]["transportationCompany"].ToString();
                    txtNarration.Text = ListObjPurchaseReturnMaster[0].Rows[0]["narration"].ToString();
                    txtLrlNo.Text = ListObjPurchaseReturnMaster[0].Rows[0]["lrNo"].ToString();
                    cmbCurrency.SelectedValue = ListObjPurchaseReturnMaster[0].Rows[0]["exchangeRateId"].ToString();
                    if (ListObjPurchaseReturnMaster[0].Rows[0]["voucherTypeId1"].ToString() != string.Empty)
                    {
                        cmbVoucherType.SelectedValue = ListObjPurchaseReturnMaster[0].Rows[0]["voucherTypeId1"].ToString();
                    }
                    else
                    {
                        cmbVoucherType.SelectedValue = 0;
                    }
                    cmbInvoiceNo.Text = ListObjPurchaseReturnMaster[0].Rows[0]["invoiceNo1"].ToString();
                    if (ListObjPurchaseReturnMaster[0].Rows[0]["totalAmount1"].ToString() != string.Empty)
                    {
                        decRegisterTotalAmount = Convert.ToDecimal(ListObjPurchaseReturnMaster[0].Rows[0]["totalAmount"].ToString());
                    }
                    txtTotalAmount.Text = ListObjPurchaseReturnMaster[0].Rows[0]["totalAmount"].ToString();
                    if (ListObjPurchaseReturnMaster[0].Rows[0]["PurchaseMasterId"].ToString() != string.Empty && Convert.ToInt32(ListObjPurchaseReturnMaster[0].Rows[0]["PurchaseMasterId"]) != 0)
                    {
                        InvoiceNoComboFillInRegister();
                        cmbInvoiceNo.SelectedValue = Convert.ToDecimal(ListObjPurchaseReturnMaster[0].Rows[0]["PurchaseMasterId"].ToString());
                        decInvoiceNo = Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString());
                        ListObjPurchaseMasterViewById = BllPurchaseReturn.PurchaseReturnMasterViewByPurchaseMasterId(Convert.ToDecimal(ListObjPurchaseReturnMaster[0].Rows[0]["PurchaseMasterId"].ToString()));
                    }
                    else
                    {
                        cmbInvoiceNo.SelectedValue = ListObjPurchaseReturnMaster[0].Rows[0]["PurchaseMasterId"];
                    }
                    strInvoiceNo = ListObjPurchaseReturnMaster[0].Rows[0]["invoiceNo1"].ToString();
                    decimal decDiscnt = Math.Round(Convert.ToDecimal(ListObjPurchaseReturnMaster[0].Rows[0]["discount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                    ListObj = BllPurchaseReturn.PurchaseReturnDetailsViewByMasterId(decPurchaseReturnMasterId);
                    dgvPurchaseReturn.Rows.Clear();
                    for (int i = 0; i < ListObj[0].Rows.Count; i++)
                    {
                        isAmountcalc = false;
                        dgvPurchaseReturn.Rows.Add();
                        int ini = dgvPurchaseReturn.Rows.Count;
                        decPurchaseReturnDetailsId = Convert.ToDecimal(ListObj[0].Rows[i]["purchaseReturnDetailsId"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtSlNo"].Value = ListObj[0].Rows[i]["slno"].ToString();
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductCode"].Value = ListObj[0].Rows[i]["productCode"].ToString();
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductName"].Value = ListObj[0].Rows[i]["productName"].ToString();
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductId"].Value = ListObj[0].Rows[i]["productId"].ToString();
                        decimal decProductId = Convert.ToDecimal(dgvPurchaseReturn.Rows[i].Cells["dgvtxtproductId"].Value.ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtConversionRate"].Value = BllUnitConvertion.UnitConversionRateByUnitConversionId(decimal.Parse(ListObj[0].Rows[i]["unitConversionId"].ToString()));
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtUnitConversionId"].Value = decimal.Parse(ListObj[0].Rows[i]["unitConversionId"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtqty"].Value = (ListObj[0].Rows[i]["qty"].ToString() != string.Empty) ? Convert.ToDecimal(ListObj[0].Rows[i]["qty"].ToString()) : 0;
                        if (ListObj[0].Rows[i]["unitName"].ToString() != string.Empty)
                        {
                            UnitComboFill(decProductId, dgvPurchaseReturn.Rows[i].Index, dgvPurchaseReturn.Rows[i].Cells["dgvcmbUnit"].ColumnIndex);
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbUnit"].Value = ListObj[0].Rows[i]["unitName"].ToString();
                        }
                        else
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbUnit"].Value = "NA";
                        }
                        dgvPurchaseReturn.Rows[i].Cells["dgvcmbUnit"].ReadOnly = (ListObjPurchaseReturnMaster[0].Rows[0]["voucherTypeId1"].ToString() != string.Empty) ? true : false;
                        if (ListObj[0].Rows[i]["godownId"].ToString() != string.Empty)
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["godownId"].ToString());
                        }
                        else
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbGodown"].Value = "NA";
                        }
                        if (ListObj[0].Rows[i]["rackId"].ToString() != string.Empty)
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvCmbRack"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["rackId"].ToString());
                        }
                        else
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvCmbRack"].Value = "NA";
                        }
                        if (ListObj[0].Rows[i]["batchId"].ToString() != string.Empty)
                        {
                            BatchComboFill(decProductId, dgvPurchaseReturn.Rows[i].Index, dgvPurchaseReturn.Rows[i].Cells["dgvcmbBatch"].ColumnIndex);
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["batchId"].ToString());
                        }
                        else
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbBatch"].Value = "NA";
                        }
                        if (ListObj[0].Rows[i]["taxId"].ToString() != string.Empty && ListObj[0].Rows[i]["taxId"].ToString() != "NA")
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbTax"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["taxId"].ToString());
                        }
                        else
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbTax"].Value = "NA";
                        }
                        if (ListObjPurchaseReturnMaster[0].Rows[0]["voucherTypeId1"].ToString() != string.Empty)
                        {
                            dgvPurchaseReturn.Rows[i].Cells["dgvcmbBatch"].ReadOnly = true;
                        }
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtPurchaseDetailsId"].Value = ListObj[0].Rows[i]["purchaseDetailsId"].ToString();
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtbarcode"].Value = ListObj[0].Rows[i]["barcode"].ToString();
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtPurchaseReturnDetailsId"].Value = decPurchaseReturnDetailsId;
                        decimal decRate = Convert.ToDecimal(ListObj[0].Rows[i]["rate"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtrate"].Value = Math.Round(decRate, PublicVariables._inNoOfDecimalPlaces);
                        decimal decGross = Convert.ToDecimal(ListObj[0].Rows[i]["grossAmount"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtgrossValue"].Value = Math.Round(decGross, PublicVariables._inNoOfDecimalPlaces);
                        decimal decDis = Convert.ToDecimal(ListObj[0].Rows[i]["discount"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtdiscount"].Value = Math.Round(decDis, PublicVariables._inNoOfDecimalPlaces);
                        decimal decNet = Convert.ToDecimal(ListObj[0].Rows[i]["netAmount"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtNetAmount"].Value = Math.Round(decNet, PublicVariables._inNoOfDecimalPlaces);
                        decimal decTax = Convert.ToDecimal(ListObj[0].Rows[i]["taxAmount"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxttaxAmount"].Value = Math.Round(decTax, PublicVariables._inNoOfDecimalPlaces);
                        decimal decTotal = Convert.ToDecimal(ListObj[0].Rows[i]["amount"].ToString());
                        dgvPurchaseReturn.Rows[i].Cells["dgvtxtAmount"].Value = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                        decTotalValue = decTotalValue + Convert.ToDecimal(ListObj[0].Rows[i]["amount"].ToString());
                        if (cmbInvoiceNo.Visible == true)
                        {
                            dgvPurchaseReturn.Rows[dgvPurchaseReturn.Rows.Count - 1].ReadOnly = true;
                        }
                    }
                    lblTaxAmount.Text = Math.Round(decimal.Parse(ListObjPurchaseReturnMaster[0].Rows[0]["totalTax"].ToString()), 2).ToString(); ;
                    txtTotalAmount.Text = decTotalValue.ToString();
                    txtBillDiscount.Text = decDiscnt.ToString();
                    DGVPurchaseReturnTaxFill();
                    DGVTaxCombofill();
                    Calculate();
                    isAmountcalc = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:55" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for getting Purchase details Id to delete
        /// </summary        
        public void GetPurchaseDetailsIdToDelete()
        {
            try
            {
                foreach (DataGridViewRow drow in dgvPurchaseReturn.Rows)
                {
                    if (drow.Cells["dgvtxtPurchaseReturnDetailsId"].Value != null && drow.Cells["dgvtxtPurchaseReturnDetailsId"].Value.ToString() != string.Empty)
                    {
                        lstArrOfRemove.Add(drow.Cells["dgvtxtPurchaseReturnDetailsId"].Value.ToString());
                    }
                }
                dgvPurchaseReturn.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for print data
        /// </summary>
        /// <param name="decPurchaseReturnMasterId"></param>
        public void Print(decimal decPurchaseReturnMasterId)
        {
            try
            {
                PurchaseReturnMasterInfo infoPurchaseReturnMaster = new PurchaseReturnMasterInfo();
                PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                DataSet dsPurchaseReturn = BllPurchaseReturn.PurchaseReturnPrinting(decPurchaseReturnMasterId, 1, infoPurchaseReturnMaster.PurchaseMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.PurchaseReturnPrinting(dsPurchaseReturn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for DotMatrix print
        /// </summary>
        /// <param name="decPurchaseReturnMasterId"></param>
        public void PrintForDotMatrix(decimal decPurchaseReturnMasterId)
        {
            try
            {
                DataTable dtblOtherDetails = new DataTable();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                dtblOtherDetails = bllCompanyCreation.CompanyViewForDotMatrix();
                //-------------Grid Details-------------------\\
                DataTable dtblGridDetails = new DataTable();
                dtblGridDetails.Columns.Add("SlNo");
                dtblGridDetails.Columns.Add("BarCode");
                dtblGridDetails.Columns.Add("ProductCode");
                dtblGridDetails.Columns.Add("ProductName");
                dtblGridDetails.Columns.Add("Qty");
                dtblGridDetails.Columns.Add("Unit");
                dtblGridDetails.Columns.Add("Godown");
                dtblGridDetails.Columns.Add("Tax");
                dtblGridDetails.Columns.Add("TaxAmount");
                dtblGridDetails.Columns.Add("NetAmount");
                dtblGridDetails.Columns.Add("DiscountAmount");
                dtblGridDetails.Columns.Add("GrossValue");
                dtblGridDetails.Columns.Add("Rack");
                dtblGridDetails.Columns.Add("Batch");
                dtblGridDetails.Columns.Add("Rate");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvPurchaseReturn.Rows)
                {
                    if (!dRow.IsNewRow)
                    {
                        DataRow dr = dtblGridDetails.NewRow();
                        dr["SlNo"] = ++inRowCount;
                        if (dRow.Cells["dgvtxtbarcode"].Value != null)
                        {
                            dr["BarCode"] = dRow.Cells["dgvtxtbarcode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtproductCode"].Value != null)
                        {
                            dr["ProductCode"] = dRow.Cells["dgvtxtproductCode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtproductName"].Value != null)
                        {
                            dr["ProductName"] = dRow.Cells["dgvtxtproductName"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtqty"].Value != null)
                        {
                            dr["Qty"] = dRow.Cells["dgvtxtqty"].Value.ToString();
                        }
                        if (dRow.Cells["dgvcmbUnit"].Value != null)
                        {
                            dr["Unit"] = dRow.Cells["dgvcmbUnit"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbGodown"].Value != null)
                        {
                            dr["Godown"] = dRow.Cells["dgvcmbGodown"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbRack"].Value != null)
                        {
                            dr["Rack"] = dRow.Cells["dgvcmbRack"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbBatch"].Value != null)
                        {
                            dr["Batch"] = dRow.Cells["dgvcmbBatch"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvtxtrate"].Value != null)
                        {
                            dr["Rate"] = dRow.Cells["dgvtxtrate"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtAmount"].Value != null)
                        {
                            dr["Amount"] = dRow.Cells["dgvtxtAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvcmbTax"].Value != null)
                        {
                            dr["Tax"] = dRow.Cells["dgvcmbTax"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvtxttaxAmount"].Value != null)
                        {
                            dr["TaxAmount"] = dRow.Cells["dgvtxttaxAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtNetAmount"].Value != null)
                        {
                            dr["NetAmount"] = dRow.Cells["dgvtxtNetAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtdiscount"].Value != null)
                        {
                            dr["DiscountAmount"] = dRow.Cells["dgvtxtdiscount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtgrossValue"].Value != null)
                        {
                            dr["GrossValue"] = dRow.Cells["dgvtxtgrossValue"].Value.ToString();
                        }
                        dtblGridDetails.Rows.Add(dr);
                    }
                }
                //-------------Other Details-------------------\\
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("PurchaseAccount");
                dtblOtherDetails.Columns.Add("VoucherType");
                dtblOtherDetails.Columns.Add("InvoiceNo");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("BillDiscount");
                dtblOtherDetails.Columns.Add("GrandTotal");
                dtblOtherDetails.Columns.Add("CustomerAddress");
                dtblOtherDetails.Columns.Add("CustomerTIN");
                dtblOtherDetails.Columns.Add("CustomerCST");
                dtblOtherDetails.Columns.Add("AmountInWords");
                dtblOtherDetails.Columns.Add("Declaration");
                dtblOtherDetails.Columns.Add("Heading1");
                dtblOtherDetails.Columns.Add("Heading2");
                dtblOtherDetails.Columns.Add("Heading3");
                dtblOtherDetails.Columns.Add("Heading4");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["voucherNo"] = txtReturnNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["PurchaseAccount"] = cmbPurchaseAccount.Text;
                dRowOther["BillDiscount"] = txtBillDiscount.Text;
                dRowOther["GrandTotal"] = txtGrandTotal.Text;
                dRowOther["InvoiceNo"] = cmbInvoiceNo.Text;
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
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decPurchaseReturnVoucherTypeId);
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
                MessageBox.Show("PR:58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function for Tax Amount calculation applicable for bill
        /// </summary>
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
                foreach (DataGridViewRow dgvRow in dgvPurchaseReturnTax.Rows)
                {
                    if (dgvRow.Cells["dgvtxtTaxId"].Value != null)
                    {
                        if (dgvRow.Cells["dgvtxtTaxApplicableOn"].Value != null && dgvRow.Cells["dgvtxtCalculatingMode"].Value != null)
                        {
                            if (dgvRow.Cells["dgvtxtTaxApplicableOn"].Value.ToString() == "Bill" && dgvRow.Cells["dgvtxtCalculatingMode"].Value.ToString() == "Bill Amount")
                            {
                                decTaxRate = Convert.ToDecimal(dgvRow.Cells["dgvtxtTaxRate"].Value.ToString());
                                decTaxOnBill = (decTotalAmount * decTaxRate / 100);
                                dgvRow.Cells["dgvtxtAmounts"].Value = Math.Round(decTaxOnBill, PublicVariables._inNoOfDecimalPlaces);
                                decTotalTaxOnBill = decTotalTaxOnBill + decTaxOnBill;
                            }
                        }
                    }
                }
                foreach (DataGridViewRow dgvRow1 in dgvPurchaseReturnTax.Rows)
                {
                    if (dgvRow1.Cells["dgvtxtTaxId"].Value != null)
                    {
                        if (dgvRow1.Cells["dgvtxtTaxApplicableOn"].Value != null && dgvRow1.Cells["dgvtxtCalculatingMode"].Value != null &&
                            dgvRow1.Cells["dgvtxtTaxApplicableOn"].Value.ToString() == "Bill" && dgvRow1.Cells["dgvtxtCalculatingMode"].Value.ToString() == "Tax Amount")
                        {
                            decTaxId = Convert.ToDecimal(dgvRow1.Cells["dgvtxtTaxId"].Value.ToString());
                            ListObj = bllTax.TaxDetailsViewallByTaxId(decTaxId);
                            foreach (DataGridViewRow dgvRow2 in dgvPurchaseReturnTax.Rows)
                            {
                                foreach (DataRow drow in ListObj[0].Rows)
                                {
                                    if (dgvRow2.Cells["dgvtxtTaxId"].Value != null && dgvRow2.Cells["dgvtxtTaxId"].Value.ToString() == drow.ItemArray[0].ToString())
                                    {
                                        decTaxRate = Convert.ToDecimal(dgvRow1.Cells["dgvtxtTaxRate"].Value.ToString());
                                        decTotalAmount = Convert.ToDecimal(dgvRow2.Cells["dgvtxtAmounts"].Value.ToString());
                                        decTaxOnTax = (decTotalAmount * decTaxRate / 100);
                                        dgvRow1.Cells["dgvtxtAmounts"].Value = Math.Round(decTaxOnTax, PublicVariables._inNoOfDecimalPlaces);
                                        decTotalTaxOnTax = decTotalTaxOnTax + decTaxOnTax;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            decTotalTax = decTotalTaxOnBill + decTotalTaxOnTax;
            return decTotalTax;
        }
        /// <summary>
        /// Function for Tax Amount calculation of tax type
        /// </summary> 
        public void TaxAmountForTaxType()
        {
            decimal decTaxId = 0;
            decimal decAmount = 0;
            decimal decDefaultAmount = 0;
            decimal decRate = 0;
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            try
            {
                foreach (DataGridViewRow dgvTaxRow in dgvPurchaseReturnTax.Rows)
                {
                    if (dgvTaxRow.Cells["dgvtxtTaxId"].Value != null && dgvTaxRow.Cells["dgvtxtTaxId"].Value.ToString() != string.Empty && dgvTaxRow.Cells["dgvtxtTaxId"].Value.ToString() != "0")
                    {
                        decTaxId = Convert.ToDecimal(dgvTaxRow.Cells["dgvtxtTaxId"].Value.ToString());
                        foreach (DataGridViewRow dgvPurchaseReturnRow in dgvPurchaseReturn.Rows)
                        {
                            if (dgvPurchaseReturnRow.Cells["dgvtxtProductId"].Value != null && dgvPurchaseReturnRow.Cells["dgvtxtProductId"].Value.ToString() != string.Empty &&
                                dgvPurchaseReturnRow.Cells["dgvtxtProductId"].Value.ToString() != "0")
                            {
                                if (dgvPurchaseReturnRow.Cells["dgvcmbTax"].Value != null && dgvPurchaseReturnRow.Cells["dgvcmbTax"].Value as string != "NA" &&
                                    dgvPurchaseReturnRow.Cells["dgvcmbTax"].Value.ToString() != string.Empty && dgvPurchaseReturnRow.Cells["dgvcmbTax"].Value.ToString() != "0")
                                {
                                    if (dgvPurchaseReturnRow.Cells["dgvtxttaxAmount"].Value != null && dgvPurchaseReturnRow.Cells["dgvtxttaxAmount"].Value.ToString() != string.Empty &&
                                         dgvPurchaseReturnRow.Cells["dgvtxttaxAmount"].Value.ToString() != "0")
                                    {
                                        if (Convert.ToDecimal(dgvPurchaseReturnRow.Cells["dgvcmbTax"].Value.ToString()) == decTaxId)
                                        {
                                            decAmount = decAmount + Convert.ToDecimal(dgvPurchaseReturnRow.Cells["dgvtxttaxAmount"].Value.ToString());
                                        }
                                    }
                                }
                            }
                        }
                        if (cmbCurrency.SelectedValue != null)
                        {
                            decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                        }
                        else
                        {
                            decRate = 0;
                        }
                        decDefaultAmount = decAmount * decRate;
                        dgvTaxRow.Cells["dgvtxtAmounts"].Value = Math.Round(decDefaultAmount, PublicVariables._inNoOfDecimalPlaces);
                        decAmount = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function Call From frmVoucherWiseProductSearch
        /// </summary>
        /// <param name="frmVoucherwiseProductSearch"></param>
        /// <param name="decmasterId"></param>
        public void CallFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherwiseProductSearch, decimal decmasterId)
        {
            try
            {
                base.Show();
                frmVoucherwiseProductSearch.Enabled = false;
                frmVoucher = frmVoucherwiseProductSearch;
                decMasterId = decmasterId;
                arrlstMasterId.Add(decMasterId);
                decPurchaseReturnMasterId = decmasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from voucher search to fill selected material receipt
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSerach(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                objVoucherSearch = frm;
                decPurchaseReturnMasterId = decId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for frmDayBook
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void callFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmDayBook.Enabled = false;
                this.frmDayBookObj = frmDayBook;
                decPurchaseReturnMasterId = decMasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for frmLedgerdetails
        /// </summary>
        /// <param name="frmLedgerDetails"></param>
        /// <param name="decMasterId"></param>
        /// <param name="isFromReport"></param>
        public void CallFromLedgerDetails(frmLedgerDetails frmLedgerDetails, decimal decMasterId, bool isFromReport)
        {
            try
            {
                base.Show();
                frmLedgerDetailsObj = frmLedgerDetails;
                decPurchaseReturnMasterId = decMasterId;
                isFromPurchaseReturn = isFromReport;
                isInvoiceFil = true;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Event
        /// <summary>
        /// When form load call the clear function and checking the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PurchaseReturnSettingsCheck();
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                FillProducts(false, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (SaveOrEditCheck())
                    {
                        if (btnSave.Text == "Save")
                        {
                            if (Messages.SaveConfirmation())
                            {
                                SaveOrEdit();
                            }
                        }
                        else if (btnSave.Text == "Update")
                        {
                            if (Messages.UpdateConfirmation())
                            {
                                SaveOrEdit();
                            }
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
                MessageBox.Show("PR:66" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmPurchaseReturnRegisterObj != null)
                {
                    frmPurchaseReturnRegisterObj.Enabled = true;
                    frmPurchaseReturnRegisterObj.GridFill();
                }
                else if (ObjPurchaseReturnReport != null)
                {
                    ObjPurchaseReturnReport.Enabled = true;
                    ObjPurchaseReturnReport.PurchaseReturnReportGridFill();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj = null;
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                }
                if (frmVoucher != null)
                {
                    frmVoucher.Enabled = true;
                    frmVoucher.FillGrid();
                }
                if (frmLedgerDetailsObj != null)
                {
                    frmLedgerDetailsObj.Enabled = true;
                    frmLedgerDetailsObj.LedgerDetailsView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new ledger or cashorParty using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCashorPartyAdd_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = true;
                isFromPurchaseAccountCombo = false;
                AccountLedgerCreation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:68" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new ledger or purchaseaccount using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPurchaseacntAdd_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = false;
                isFromPurchaseAccountCombo = true;
                AccountLedgerCreation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:69" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtDate.Focus();
                CurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:70" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bool isInvalid = obj.DateValidationFunction(txtDate);
                if (!isInvalid)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string date = txtDate.Text;
                dtpDate.Value = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:71" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cash or party changing, Fills the invoiceNo combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isDontExecuteCashorParty && !isDontExecuteVoucherType)
                {
                    if (cmbCashOrParty.SelectedValue != null && cmbVoucherType.Text != "NA" && cmbVoucherType.SelectedValue != null)
                    {
                        if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView")
                        {
                            InvoiceNoComboFill(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:72" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When selecting invoiceNo, it fills the corresponding details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCheck = false;
            try
            {
                GetPurchaseDetailsIdToDelete();
                if (!isInvoiceFil)
                {
                    if (cmbInvoiceNo.SelectedIndex > -1 && cmbInvoiceNo.SelectedValue != null && cmbInvoiceNo.SelectedValue.ToString() != string.Empty)
                    {
                        if (cmbInvoiceNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbInvoiceNo.Text != "System.Data.DataRowView")
                        {
                            InvoiceDetailsFill();
                            if (!isCheck)
                            {
                                Calculate();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:73" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selected index change cmbCashOrParty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCashOrParty = string.Empty;
            try
            {
                GetPurchaseDetailsIdToDelete();
                strCashOrParty = cmbCashOrParty.Text;
                gridClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:74" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Handling data error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturn_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvPurchaseReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvPurchaseReturn.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR :75" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selected index change of combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inIndex = 0;
            try
            {
                inIndex = ((ComboBox)sender).SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR :76" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid EditingControlShowing event To handle the keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                DataGridViewComboBoxEditingControl ComboxControl = e.Control as DataGridViewComboBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvPurchaseReturn.CurrentCell != null && dgvPurchaseReturn.Columns[dgvPurchaseReturn.CurrentCell.ColumnIndex].Name == "dgvtxtproductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    if (dgvPurchaseReturn.CurrentCell != null && dgvPurchaseReturn.Columns[dgvPurchaseReturn.CurrentCell.ColumnIndex].Name == "dgvtxtproductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvPurchaseReturn.CurrentCell != null && dgvPurchaseReturn.Columns[dgvPurchaseReturn.CurrentCell.ColumnIndex].Name != "dgvtxtproductCode" && dgvPurchaseReturn.Columns[dgvPurchaseReturn.CurrentCell.ColumnIndex].Name != "dgvtxtproductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvPurchaseReturn.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }

                    if ((dgvPurchaseReturn.CurrentCell.ColumnIndex == dgvPurchaseReturn.Columns["dgvtxtAmount"].Index) || (dgvPurchaseReturn.CurrentCell.ColumnIndex == dgvPurchaseReturn.Columns["dgvtxtqty"].Index) || (dgvPurchaseReturn.CurrentCell.ColumnIndex == dgvPurchaseReturn.Columns["dgvtxtrate"].Index) || (dgvPurchaseReturn.CurrentCell.ColumnIndex == dgvPurchaseReturn.Columns["dgvtxtDiscount"].Index))
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else
                    {
                        TextBoxControl.KeyPress += keypresseventforOther;
                    }
                    if (e.Control is DataGridViewTextBoxEditingControl)
                    {
                        DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                        tb.KeyDown -= dgvPurchaseReturn_KeyDown;
                        tb.KeyDown += new KeyEventHandler(dgvPurchaseReturn_KeyDown);
                    }
                }
                if (ComboxControl != null)
                {
                    if (dgvPurchaseReturn.CurrentCell != null && dgvPurchaseReturn.Columns[dgvPurchaseReturn.CurrentCell.ColumnIndex].Name == "Tax")
                    {
                        ComboBox comboBox = e.Control as ComboBox;
                        comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:77" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On text change of txtTotalAmount, calculates grand total
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:78" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// make each and every changes of grid has to be commited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturn_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPurchaseReturn.IsCurrentCellDirty)
                {
                    dgvPurchaseReturn.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:79" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid CellEndEdit for product details fill to curresponding row in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strBarcode2 = string.Empty;
                decimal decBatchId2 = 0;
                BatchBll BllBatch = new BatchBll();
                RackBll BllRack = new RackBll();
                PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
                PurchaseReturnBll BllPurchaseReturn = new PurchaseReturnBll();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvtxtproductName")
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductName"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductName"].Value.ToString().Trim() != string.Empty)
                    {
                        ProductInfo infoProduct = BllProductCreation.ProductViewByName(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductName"].Value.ToString());
                        if (infoProduct.ProductCode != null && infoProduct.ProductCode != string.Empty)
                        {
                            FillProductDetails(infoProduct.ProductCode.ToString(), e.RowIndex);
                        }
                        else
                        {
                            StringEmptyDetailsInGrid();
                        }
                    }
                    else
                    {
                        dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductName"].Value = string.Empty;
                    }
                }
                else if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvtxtproductCode")
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductCode"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductCode"].Value.ToString().Trim() != string.Empty)
                    {
                        ProductInfo infoProduct = BllProductCreation.ProductViewByCode(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductCode"].Value.ToString());
                        if (infoProduct.ProductName != null && infoProduct.ProductCode != string.Empty)
                        {
                            FillProductDetails(infoProduct.ProductCode.ToString(), e.RowIndex);
                        }
                        else
                        {
                            StringEmptyDetailsInGrid();
                        }
                    }
                    else
                    {
                        dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductCode"].Value = string.Empty;
                    }
                }
                else if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvtxtbarcode")
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtbarcode"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtbarcode"].Value.ToString().Trim() != string.Empty)
                    {
                        string strBarcode = dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtbarcode"].Value.ToString();
                        decBatchId = BllProductCreation.BatchIdByPartNoOrBarcode(strBarcode, strBarcode);
                        if (decBatchId > 0)
                        {
                            List<DataTable> listObjBatchName = new List<DataTable>();
                            listObjBatchName = BllProductCreation.ProductCodeAndBarcodeByBatchId(decBatchId);
                            dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductCode"].Value = listObjBatchName[0].Rows[0]["productCode"].ToString();
                            if (listObjBatchName[0].Rows[0]["barcode"].ToString() != null && listObjBatchName[0].Rows[0]["barcode"].ToString() != string.Empty)
                            {
                                dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtbarcode"].Value = listObjBatchName[0].Rows[0]["barcode"].ToString();
                            }
                            decimal batchId = BllBatch.BatchViewByBarcode(strBarcode);
                            dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = batchId;
                            FillProductDetails(listObjBatchName[0].Rows[0]["productCode"].ToString(), e.RowIndex);
                        }
                        else
                        {
                            StringEmptyDetailsInGrid();
                        }
                    }
                    else
                    {
                        dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtbarcode"].Value = string.Empty;
                    }
                }
                if (e.ColumnIndex == dgvPurchaseReturn.Columns["dgvcmbUnit"].Index)
                {
                    if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                    {
                        if ((dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value != null) && (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() != string.Empty))
                        {
                            UnitConversionCalc(e.RowIndex);
                            AmountCalculation("dgvtxtqty", e.RowIndex);
                        }
                    }
                }
                if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvtxtqty" && isAmountcalc)
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value.ToString() != string.Empty && Convert.ToDecimal(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value.ToString()) != 0)
                    {
                        if (cmbInvoiceNo.SelectedValue == null || cmbInvoiceNo.SelectedValue.ToString() == string.Empty)
                        {
                            AmountCalculation("dgvtxtqty", e.RowIndex);
                        }
                        else
                        {
                            List<DataTable> ListObj= BllPurchaseInvoice.PurchaseDetailsViewByPurchaseMasterIdWithRemaining(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()), decPurchaseReturnMasterId, decPurchaseReturnVoucherTypeId);
                            if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtPurchaseDetailsId"].Value != null)
                            {
                                if (Convert.ToDecimal(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtPurchaseDetailsId"].Value.ToString()) > 0)
                                {
                                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value != null)
                                    {
                                        if (Convert.ToDecimal(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value.ToString()) > Convert.ToDecimal(ListObj[0].Rows[e.RowIndex]["qty"].ToString()))
                                        {
                                            dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value = Math.Round(Convert.ToDecimal(ListObj[0].Rows[e.RowIndex]["qty"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                        }
                                    }
                                }
                            }
                            AmountCalculation("dgvtxtqty", e.RowIndex);
                        }
                    }
                }
                else if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvtxtrate" && isAmountcalc)
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value.ToString() != string.Empty && Convert.ToDecimal(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value.ToString()) != 0)
                    {
                        AmountCalculation("dgvtxtrate", e.RowIndex);
                    }
                }
                else if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvtxtdiscount")
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtdiscount"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtdiscount"].Value.ToString().Trim() != string.Empty && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtDiscount"].Value.ToString().Trim() != "0")
                    {
                        AmountCalculation("dgvtxtrate", e.RowIndex);
                    }
                }
                else if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvcmbTax" && isAmountcalc)
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvcmbTax"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvcmbTax"].Value.ToString() != string.Empty)
                    {
                        AmountCalculation("dgvtxtrate", e.RowIndex);
                    }
                }
                else if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvcmbBatch")
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                    {
                        decBatchId2 = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvcmbBatch"].Value);
                        strBarcode2 = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId2);
                        dgvPurchaseReturn.CurrentRow.Cells["dgvtxtbarcode"].Value = strBarcode2;
                    }
                }
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:80" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvPurchaseReturn.SelectedCells.Count >= 0 && dgvPurchaseReturn.CurrentRow != null)
                {
                    if (!dgvPurchaseReturn.Rows[dgvPurchaseReturn.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtPurchaseReturnDetailsId"].Value != null && dgvPurchaseReturn.CurrentRow.Cells["dgvtxtPurchaseReturnDetailsId"].Value.ToString() != string.Empty)
                                {
                                    lstArrOfRemove.Add(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtPurchaseReturnDetailsId"].Value.ToString());
                                    RemoveFunction();
                                    Calculate();  
                                }
                                else
                                {
                                    RemoveFunction();
                                    Calculate();
                                }
                            }
                            else
                            {
                                RemoveFunction();
                                Calculate();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:81" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:82" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On close button click
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
                MessageBox.Show("PR:83" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        Delete();
                    }
                }
                else
                {
                    Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:84" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// While leave from txtBillDiscount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBillDiscount.Text == string.Empty)
                {
                    txtBillDiscount.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:85" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// generate serialNo on rows added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturn_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:86" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Generate tax serialNo on rows added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturnTax_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                TaxSerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:87" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On text change of txtBillDiscount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:88" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On entering txtBillDiscount
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
                MessageBox.Show("PR:89" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// While entering into dgvPurchaseReturn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal decPurchseInvc = 0;
                decimal decCurrentRate = 0;
                if (dgvPurchaseReturn.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvPurchaseReturn.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvPurchaseReturn.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtPurchaseReturnDetailsId"].Value != null)
                    {
                        dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductCode"].ReadOnly = true;
                        dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductName"].ReadOnly = true;
                        dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtbarCode"].ReadOnly = true;
                    }
                    if ((dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductId"].Value != null) && (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtproductId"].Value.ToString() != string.Empty))
                    {
                        if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                        {
                            decimal decProductId = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductId"].Value);
                            UnitComboFill(decProductId, e.RowIndex, e.ColumnIndex);
                            if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value != DBNull.Value && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value != string.Empty)
                            {
                                decCurrentRate = Convert.ToDecimal(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value.ToString());
                            }
                        }
                        if (dgvPurchaseReturn.Columns[e.ColumnIndex].Name == "dgvtxtqty")
                        {
                            if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value != DBNull.Value)
                            {
                                decPurchseInvc = Convert.ToDecimal(Convert.ToString(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtqty"].Value));
                            }
                            if (dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value != null && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value != DBNull.Value && dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value != string.Empty)
                            {
                                decCurrentRate = Convert.ToDecimal(dgvPurchaseReturn.Rows[e.RowIndex].Cells["dgvtxtrate"].Value.ToString());
                            }
                        }
                    }
                    if (e.ColumnIndex == dgvPurchaseReturn.Columns["dgvcmbRack"].Index)
                    {
                        if (dgvPurchaseReturn.CurrentRow.Cells["dgvcmbGodown"].Value != null)
                        {
                            if (dgvPurchaseReturn.CurrentRow.Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                            {
                                decimal decGodownId = Convert.ToDecimal(dgvPurchaseReturn.CurrentRow.Cells["dgvcmbGodown"].Value);
                                RackComboFill(decGodownId, e.RowIndex, e.ColumnIndex);
                            }
                            else
                            {
                                DataGridViewComboBoxCell dgvcmbRackCell = (DataGridViewComboBoxCell)dgvPurchaseReturn.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                dgvcmbRackCell.DataSource = null;
                            }
                        }
                        else
                        {
                            DataGridViewComboBoxCell dgvcmbRackCell = (DataGridViewComboBoxCell)dgvPurchaseReturn.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            dgvcmbRackCell.DataSource = null;
                        }
                    }
                }
                AmountCalculation("dgvtxtqty", e.RowIndex);
                //CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:90 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On textchange of lblTaxAmount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTaxAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateGrandTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:91" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selected index change of cmbVoucherType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetPurchaseDetailsIdToDelete();
                if (cmbVoucherType.Text != "NA")
                {
                    if (!isDontExecuteCashorParty && !isDontExecuteVoucherType)
                    {
                        if (cmbCashOrParty.SelectedValue != null && cmbVoucherType.SelectedValue != null)
                        {
                            if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView" && cmbVoucherType.Text != "System.Data.DataRowView" && cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView")
                            {
                                lblInvoiceNo.Visible = true;
                                cmbInvoiceNo.Visible = true;
                                InvoiceNoComboFill(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()));
                                gridClear();
                            }
                        }
                    }
                }
                else
                {
                    lblInvoiceNo.Visible = false;
                    cmbInvoiceNo.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:92" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of txtNarration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        txtBillDiscount.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:93" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For decimal validation
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
                MessageBox.Show("PR:94" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// EnterKey navigation of txtReturnNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReturnNo_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PR:95" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cbxPrintAfterSave
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
                    txtBillDiscount.Focus();
                    txtBillDiscount.SelectionStart = 0;
                    txtBillDiscount.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:96" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtDate
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
                if (e.KeyCode == Keys.Back)
                {

                    if (!txtReturnNo.ReadOnly)
                    {
                        if (txtDate.Text == string.Empty || txtDate.SelectionStart == 0)
                        {
                            txtReturnNo.Focus();
                            txtReturnNo.SelectionLength = 0;
                            txtReturnNo.SelectionStart = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:97" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbCashOrparty
        /// Alt+c for cashorparty creation
        /// Ctrl+f for popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
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
                        cmbPurchaseAccount.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtDate.Focus();
                    txtDate.SelectionStart = 0;
                    txtDate.SelectionLength = 0;
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnCashorPartyAdd_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    cmbCashOrParty.DropDownStyle = (cmbCashOrParty.Focused) ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;

                    if (cmbCashOrParty.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromPurchaseReturn(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryCreditors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:98" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbInvoiceNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPurchaseReturn.RowCount > 0)
                    {
                        dgvPurchaseReturn.Focus();
                        dgvPurchaseReturn.CurrentCell = dgvPurchaseReturn.Rows[0].Cells["dgvtxtSlNo"];
                        dgvPurchaseReturn.Rows[0].Cells["dgvtxtSlNo"].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbVoucherType.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:99" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbPurchaseAccount
        /// Alt+c for purchase account creation
        /// Ctrl+f for popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPurchaseAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }

                else if (e.KeyCode == Keys.Back)
                {
                    if (cmbPurchaseAccount.Text == string.Empty || cmbPurchaseAccount.SelectionStart == 0)
                    {
                        cmbCurrency.Focus();
                    }
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnPurchaseacntAdd_Click(sender, e);
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    cmbCashOrParty.DropDownStyle = (cmbCashOrParty.Focused) ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;

                    if (cmbCashOrParty.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromPurchaseReturn(this, Convert.ToDecimal(cmbPurchaseAccount.SelectedValue.ToString()), "PurchaseAccount");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any purchase account");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:100" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvPurchaseReturn
        /// Ctrl+f for productsearch popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseReturn_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int inDgvProductRowCount = dgvPurchaseReturn.Rows.Count;
                int inDgvPurchaseReturnTax = dgvPurchaseReturnTax.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPurchaseReturn.CurrentCell == dgvPurchaseReturn.Rows[inDgvProductRowCount - 1].Cells["dgvtxtAmount"])
                    {
                        txtTransportationCompany.Focus();
                        txtTransportationCompany.SelectionStart = txtTransportationCompany.TextLength;
                        dgvPurchaseReturn.ClearSelection();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (dgvPurchaseReturn.CurrentCell == dgvPurchaseReturn.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        cmbInvoiceNo.Focus();
                        dgvPurchaseReturn.ClearSelection();
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:101" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For shortcut keys
        /// Esc for close
        /// Ctrl+s for save
        /// Ctrl+D for delete
        /// Alt+c for productcreation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseReturn_KeyDown(object sender, KeyEventArgs e)
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
                        btnClose_Click(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    cmbCashOrParty.DropDownStyle = (cmbCashOrParty.Focused) ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
                    btnSave.Focus();
                    btnSave_Click(sender, e);
                }
                else if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    if (dgvPurchaseReturn.CurrentCell != null)
                    {
                        if (dgvPurchaseReturn.CurrentCell == dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductName"] || dgvPurchaseReturn.CurrentCell == dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductCode"])
                        {
                            if (cmbInvoiceNo.Visible == false)
                            {
                                SendKeys.Send("{F10}");
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                frmProductCreationObj.CallFromPurcahseReturn(this);
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (dgvPurchaseReturn.CurrentCell != null)
                    {
                        if (dgvPurchaseReturn.Columns[dgvPurchaseReturn.CurrentCell.ColumnIndex].Name == "dgvtxtproductName" || dgvPurchaseReturn.Columns[dgvPurchaseReturn.CurrentCell.ColumnIndex].Name == "dgvtxtproductCode")
                        {
                            if (cmbInvoiceNo.Visible == false)
                            {
                                SendKeys.Send("{F10}");
                                frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                                frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                                if (dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductName"].Value != null || dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductCode"].Value != null)
                                {
                                    frmProductSearchPopupObj.CallFromPurchaseReturn(this, dgvPurchaseReturn.CurrentRow.Index, dgvPurchaseReturn.CurrentRow.Cells["dgvtxtproductCode"].Value.ToString());
                                }
                                else
                                {
                                    frmProductSearchPopupObj.CallFromPurchaseReturn(this, dgvPurchaseReturn.CurrentRow.Index, string.Empty);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:102" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtTransportationCompany
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTransportationCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtLrlNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtTransportationCompany.Text == string.Empty || txtTransportationCompany.SelectionStart == 0)
                    {
                        dgvPurchaseReturn.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:103" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// EnterKey and backspace navigation of txtLrlNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLrlNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtLrlNo.Text == string.Empty || txtLrlNo.SelectionStart == 0)
                    {
                        txtTransportationCompany.Focus();
                        txtTransportationCompany.SelectionStart = 0;
                        txtTransportationCompany.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:104" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation of txtNarration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        txtLrlNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:105" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation of btnSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cbxPrintAfterSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:106" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbCurrency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPurchaseAccount.Enabled)
                    {
                        cmbPurchaseAccount.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (txtDate.Enabled)
                    {
                        txtDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:107" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// EnterKey and backspace navigation of txtBillDiscount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Enter) && (cbxPrintAfterSave.Enabled))
                {
                    cbxPrintAfterSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBillDiscount.Text.Trim() == string.Empty && txtBillDiscount.SelectionLength == 0)
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionLength = 0;
                        txtNarration.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:108" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbVoucherType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbVoucherType.Text == "NA")
                    {
                        dgvPurchaseReturn.Focus();
                        dgvPurchaseReturn.CurrentCell = dgvPurchaseReturn.Rows[0].Cells["dgvtxtSlNo"];
                        dgvPurchaseReturn.Rows[0].Cells["dgvtxtSlNo"].Selected = true;
                    }
                    else
                    {
                        cmbInvoiceNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPurchaseAccount.Enabled)
                    {
                        cmbPurchaseAccount.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        cmbCashOrParty.Focus();
                        cmbCashOrParty.SelectionLength = 0;
                        cmbCashOrParty.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PR:109" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
