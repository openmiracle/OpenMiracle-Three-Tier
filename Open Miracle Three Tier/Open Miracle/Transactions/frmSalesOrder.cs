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
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmSalesOrder : Form
    {
        #region Public Variable
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decSalesOrderId = 0;
        decimal decSalesOrderMasterIdentity = 0;
        decimal decSalesOrderTypeId = 0;
        decimal decSalesOrderMasterId = 0;
        decimal decCurrentConversionRate = 0;
        decimal decCurrentRate = 0;
        string isEditMaster = string.Empty;
        string isEditDetails = string.Empty;
        string strVoucherNo = string.Empty;
        string strOrderNo = string.Empty;
        string strCashOrPartyText = string.Empty;
        string strSalesMan;
        string strCashOrParty;
        string[] strArrOfRemove = new string[100];
        decimal decConversionId = 0;
        decimal decSalesSuffixPrefixId = 0;
        int inMaxCount = 0;
        int inArrOfRemoveIndex = 0;
        decimal decSalesVoucherId = 0;
        decimal decSalesOrderVoucherTypeId = 0;
        bool isCheck = false;
        bool isEditFill = false;
        bool isValueChange = true;
        bool isValueChanged = false;
        bool isAmountcalc = true;
        bool isAcctLedgr = true;
        int inNarrationCount = 0;// Number of lines in txtNarration
        bool isAutomatic = false;//To checking vocher no generation auto or not
        ArrayList lstArrOfRemove = new ArrayList();
        frmSalesOrderRegister frmSalesOrderRegisterObj = null;
        frmSalesOrderReport frmSalesOrderReportObj = null;
        frmProductSearchPopup frmProductSearchPopupObj;
        frmLedgerPopup frmLedgerPopUpObj = new frmLedgerPopup();
        frmEmployeePopup frmEmployeePopupObj = new frmEmployeePopup();
        frmDayBook frmDayBookObj = null;//To use in call from frmDayBook
        frmVoucherWiseProductSearch frmvoucherProductobj = null;
        ProductInfo infoProduct = new ProductInfo();
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        DataGridViewTextBoxEditingControl TextBoxControl;
        frmVoucherSearch objVoucherSearch = null;
        bool isQuotationFil = false;
        bool isDoAfterGridFill = false;
        #endregion
        #region Function
        /// <summary>
        /// Create an instance for frmSalesOrder class
        /// </summary>
        public frmSalesOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            try
            {
                decimal decSalesOrderSuffixPrefixId = 0;
                string strSuffix = string.Empty;
                string strPrefix = string.Empty;
                decSalesOrderTypeId = decVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decSalesOrderTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                // SuffixPrefixSP spSuffisprefix = new SuffixPrefixSP();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decSalesOrderTypeId, dtpDate.Value);
                decSalesOrderSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtOrderNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void GetSalesOrderDetailsIdToDelete()
        {
            foreach (DataGridViewRow drow in dgvSalesOrder.Rows)
            {
                if (drow.Cells["dgvtxtSalesOrderDetailsId"].Value != null)
                {
                    if (drow.Cells["dgvtxtSalesOrderDetailsId"].Value.ToString() != string.Empty)
                    {
                        lstArrOfRemove.Add(drow.Cells["dgvtxtSalesOrderDetailsId"].Value.ToString());
                    }
                }
            }
            dgvSalesOrder.Rows.Clear();
        }
        /// <summary>
        /// Function to call frmLedgerPopup form to select and view Ledger
        /// </summary>
        /// <param name="frmLedgerPopup"></param>
        /// <param name="decId"></param>
        /// <param name="strComboTypes"></param>
        public void CallFromLedgerPopup(frmLedgerPopup frmLedgerPopup, decimal decId, string strComboTypes) //PopUp
        {
            try
            {
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                base.Show();
                this.frmLedgerPopUpObj = frmLedgerPopup;
                if (strComboTypes == "CashOrSundryDeptors")
                {
                    TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
                    cmbCashOrParty.SelectedValue = decId;
                }
                frmLedgerPopUpObj.Close();
                frmLedgerPopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objVoucherSearch = frm;
                decSalesOrderMasterId = decId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                base.Show();
                frmVoucherwiseProductSearch.Enabled = true;
                frmvoucherProductobj = frmVoucherwiseProductSearch;
                decSalesOrderMasterId = decmasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup form to select and view Employee
        /// </summary>
        /// <param name="frmEmployeePopup"></param>
        /// <param name="decId"></param>
        public void CallFromEmployeePopup(frmEmployeePopup frmEmployeePopup, decimal decId) //  Employee pop up
        {
            try
            {
                base.Show();
                this.frmEmployeePopupObj = frmEmployeePopup;
                SalesManComboFill();
                cmbSalesMan.SelectedValue = decId;
                cmbSalesMan.Focus();
                frmEmployeePopupObj.Close();
                frmEmployeePopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO5 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Order combo box based on the sales quotation numbers
        /// </summary>
        public void AgainstQuotationComboFill()
        {
            try
            {
                if (cmbType.Items.Count > 0)
                {
                    if (cmbType.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        List<DataTable> ListObj = new List<DataTable>();
                        ListObj = new SalesQuotationBll().GetSalesQuotationNumberCorrespondingToLedgerForSO(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbType.SelectedValue.ToString()), decSalesOrderMasterId);
                        DataRow dr = ListObj[0].NewRow();
                        dr[0] = "0";
                        dr[1] = string.Empty;
                        ListObj[0].Rows.InsertAt(dr, 0);
                        cmbQuotationNo.DataSource = ListObj[0];
                        cmbQuotationNo.DisplayMember = "invoiceNo";
                        cmbQuotationNo.ValueMember = "quotationMasterId";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO6: " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the VoucherTypeCombobox
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                string typeOfVoucher = string.Empty;
                typeOfVoucher = "Sales Quotation";
                List<DataTable> ListObj = new List<DataTable>();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                ListObj = bllSalesOrder.VoucherTypesBasedOnTypeOfVouchers(typeOfVoucher);
                DataRow dr = ListObj[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "NA";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbType.DataSource = ListObj[0];
                cmbType.ValueMember = "voucherTypeId";
                cmbType.DisplayMember = "voucherTypeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO7" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Batch combofill
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void BatchComboFill(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                BatchBll BllBatch = new BatchBll();
                List<DataTable> list = new List<DataTable>();
                list = BllBatch.BatchNamesCorrespondingToProduct(decProductId);
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvSalesOrder.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the quotation no combofill
        /// </summary>
        /// <param name="decLedger"></param>
        public void QuotationNoComboFill(decimal decLedger)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = new SalesQuotationBll().GetQuotationNoCorrespondingtoLedgerForSalesOrderRpt(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()));
                if (ListObj != null)
                {
                    DataRow dr = ListObj[0].NewRow();
                    dr[0] = "0";
                    dr[1] = string.Empty;
                    ListObj[0].Rows.InsertAt(dr, 0);
                    cmbQuotationNo.DataSource = ListObj[0];
                    if (ListObj[0].Rows.Count > 0)
                    {
                        cmbQuotationNo.ValueMember = "quotationMasterId";
                        cmbQuotationNo.DisplayMember = "invoiceNo";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmProductSearchPopup form to select and view Product
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            UnitConvertionBll bllUnitConversion = new UnitConvertionBll();
            try
            {
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                List<DataTable> list = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                if (decproductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decproductId);
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode.ToString();
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtProductId"].Value = decproductId.ToString();
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtRate"].Value = infoProduct.SalesRate.ToString();
                    UnitComboFill(decproductId, dgvSalesOrder.CurrentRow.Index, dgvSalesOrder.CurrentRow.Cells["dgvcmbUnit"].ColumnIndex);
                    dgvSalesOrder.CurrentRow.Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                    BatchComboFill(decproductId, dgvSalesOrder.CurrentRow.Index, dgvSalesOrder.CurrentRow.Cells["dgvcmbBatch"].ColumnIndex);
                    dgvSalesOrder.CurrentRow.Cells["dgvcmbBatch"].Value = BllBatch.BatchIdViewByProductId(decproductId);
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtBarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvcmbBatch"].Value.ToString()));
                    list = bllUnitConversion.DGVUnitConvertionRateByUnitId(infoProduct.UnitId, infoProduct.ProductName);
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtUnitConversionId"].Value = list[0].Rows[0]["unitconversionId"].ToString();
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtConversionRate"].Value = list[0].Rows[0]["conversionRate"].ToString();
                    decCurrentConversionRate = Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvtxtConversionRate"].Value.ToString());
                    decCurrentRate = Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvtxtRate"].Value.ToString());
                    AmountCalculation("dgvtxtQty", dgvSalesOrder.CurrentRow.Index);
                    TotalAmountCalculation();
                }
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
                this.Enabled = true;
                this.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("S10:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// AutoCompletion of Product,productCode
        /// </summary>
        /// <param name="isProductName"></param>
        /// <param name="editControl"></param>
        public void FillProducts(bool isProductName, DataGridViewTextBoxEditingControl editControl)
        {
            try
            {
                List<DataTable> listObjProducts = new List<DataTable>();
                listObjProducts = new ProductCreationBll().ProductViewAll();
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
                MessageBox.Show("SO11:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void getProductRate(int index, decimal decProductId, decimal decBatchId)
        {
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            decimal decPricingLevelId = 0;
            DateTime dtcurrentDate = PublicVariables._dtCurrentDate;
            decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
            decPricingLevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
            decimal decRate = BllProductCreation.SalesInvoiceProductRateForSales(decProductId, dtcurrentDate, decBatchId, decPricingLevelId, decNodecplaces);
            dgvSalesOrder.Rows[index].Cells["dgvtxtRate"].Value = decRate;
        }
        /// <summary>
        /// Function to fill the pricing level combobox
        /// </summary>
        public void PricingLevelComboFill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionGeneralFillObj.PricingLevelViewAll(cmbPricingLevel, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("S012:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// date setting at the time of loading
        /// </summary>
        public void SalesOrderDateFill()
        {
            try
            {
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.CustomFormat = "dd-MMMM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("S013:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Due date setting at the time of loading
        /// </summary>
        public void SalesOrderDueDateFill()
        {
            try
            {
                dtpDueDate.MinDate = PublicVariables._dtFromDate;
                dtpDueDate.MaxDate = PublicVariables._dtToDate;
                dtpDueDate.Value = PublicVariables._dtCurrentDate;
                dtpDueDate.CustomFormat = "dd-MMMM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("S014:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Function to use the salesMan combofill
        /// </summary>
        public void SalesManComboFill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the product code status
        /// </summary>
        /// <returns></returns>
        public bool ShowProductCode()
        {
            bool isShow = false;
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                isShow = BllSettings.ShowProductCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// Function to use the Barcode Status
        /// </summary>
        /// <returns></returns>
        public bool ShowBarcode()
        {
            bool isShow = false;
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                isShow = BllSettings.ShowBarcode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// Function to use the CurrenySymbol Status
        /// </summary>
        /// <returns></returns>
        public bool ShowCurrencySymbol()
        {
            bool isShow = false;
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                isShow = BllSettings.ShowCurrencySymbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// Function to use PrintAfetrSave Status
        /// </summary>
        /// <returns></returns>
        public bool PrintAfetrSave()
        {
            bool isTick = false;
            try
            {
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                isTick = TransactionGeneralFillObj.StatusOfPrintAfterSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        /// <summary>
        /// Function to use CashOrParty Combofill
        /// </summary>
        public void DueDays()
        {
            try
            {
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                txtDueDays.Text = bllSalesOrder.DueDays(dtpDate.Value, dtpDueDate.Value).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use fill the combobox CashorParty
        /// </summary>
        public void CashorPartyUnderSundryDebitorComboFill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedgerForm(decimal decId)
        {
            try
            {
                if (decId != 0)
                {
                    DataTable dtbl = new DataTable();
                    decimal decReturnLegderId = 0;
                    isAcctLedgr = false;
                    decReturnLegderId = decId;
                    CashorPartyUnderSundryDebitorComboFill();
                    if (decId.ToString() != "0")
                    {
                        cmbCashOrParty.SelectedValue = decId.ToString();
                    }
                    else if (strCashOrParty != string.Empty)
                    {
                        cmbCashOrParty.SelectedValue = strCashOrParty;
                    }
                    else
                    {
                        cmbCashOrParty.SelectedIndex = -1;
                    }
                }
                this.Enabled = true;
                cmbCashOrParty.Focus();
                isAcctLedgr = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesMan combobox while return from SalesMan creation when creating new SalesMan 
        /// </summary>
        /// <param name="decEmployeeId"></param>
        public void ReturnFromSalesManForm(decimal decEmployeeId)
        {
            try
            {
                SalesManComboFill();
                if (decEmployeeId.ToString() != "0")
                {
                    cmbSalesMan.SelectedValue = decEmployeeId;
                }
                else if (strSalesMan != string.Empty)
                {
                    cmbSalesMan.SelectedValue = strSalesMan;
                }
                else
                {
                    cmbSalesMan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill details while return from Product creation when creating new Product 
        /// </summary>
        /// <param name="decProductId"></param>
        public void ReturnFromProductCreation(decimal decProductId)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            BatchBll BllBatch = new BatchBll();
            List<DataTable> list = new List<DataTable>();
            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
            try
            {
                this.Enabled = true;
                this.BringToFront();
                if (decProductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decProductId);
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode.ToString();
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtProductId"].Value = decProductId.ToString();
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtRate"].Value = infoProduct.SalesRate.ToString();
                    UnitComboFill(decProductId, dgvSalesOrder.CurrentRow.Index, dgvSalesOrder.CurrentRow.Cells["dgvcmbUnit"].ColumnIndex);
                    dgvSalesOrder.CurrentRow.Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                    BatchComboFill(decProductId, dgvSalesOrder.CurrentRow.Index, dgvSalesOrder.CurrentRow.Cells["dgvcmbBatch"].ColumnIndex);
                    dgvSalesOrder.CurrentRow.Cells["dgvcmbBatch"].Value = BllBatch.BatchIdViewByProductId(decProductId);
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtBarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvcmbBatch"].Value.ToString()));
                    list = bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoProduct.UnitId, infoProduct.ProductName);
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtUnitConversionId"].Value = list[0].Rows[0]["unitconversionId"].ToString();
                    dgvSalesOrder.CurrentRow.Cells["dgvtxtConversionRate"].Value = list[0].Rows[0]["conversionRate"].ToString();
                    decCurrentConversionRate = Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvtxtConversionRate"].Value.ToString());
                    decCurrentRate = Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvtxtRate"].Value.ToString());
                    AmountCalculation("dgvtxtQty", dgvSalesOrder.CurrentRow.Index);
                    TotalAmountCalculation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the print check
        /// </summary>
        public void PrintCheck()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("TickPrintAfterSave") == "Yes")
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO25 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the AmountCalculation
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="inIndexOfRow"></param>
        public void AmountCalculation(string columnName, int inIndexOfRow)
        {
            try
            {
                decimal decRate = 0;
                decimal decQty = 0;
                decimal decGrossValue = 0;
                if (dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value != null && dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                {
                    if (dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value != null && dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                    {
                        decimal.TryParse(dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString(), out decQty);
                        decimal.TryParse(dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString(), out decRate);
                        decGrossValue = decQty * decRate;
                        dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, (PublicVariables._inNoOfDecimalPlaces));
                    }
                }
                else
                {
                    dgvSalesOrder.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, (PublicVariables._inNoOfDecimalPlaces));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO26:" + ex.Message, "OPen Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Total Amount Calculation
        /// </summary>
        public void TotalAmountCalculation()
        {
            try
            {
                decimal DecTotalAmount = 0;
                foreach (DataGridViewRow dr in dgvSalesOrder.Rows)
                {
                    if (dr.Cells["dgvtxtProductId"].Value != null && dr.Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                    {
                        if (dr.Cells["dgvtxtAmount"].Value != null && dr.Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            CurrencyBll Bllcurrency = new CurrencyBll();
                            decimal decAmt = Convert.ToDecimal(dr.Cells["dgvtxtAmount"].Value);
                            DecTotalAmount = DecTotalAmount + decAmt;
                            DecTotalAmount = Math.Round(DecTotalAmount, PublicVariables._inNoOfDecimalPlaces);
                            txtTotalAmount.Text = Convert.ToString(DecTotalAmount);
                            // lblCurrencysymbol.Text = new CurrencySP().GetCurrencySymbolByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                        }
                    }
                    else if (dgvSalesOrder.Rows.Count == 1 && dr.Cells["dgvtxtAmount"].Value == null)
                    {
                        txtTotalAmount.Text = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO27:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// GetNextinRowIndex in grid rows
        /// </summary>
        /// <returns></returns>
        public int GetNextinRowIndex()
        {
            try
            {
                inMaxCount++;
                return inMaxCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO28:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inMaxCount;
        }
        /// <summary>
        /// Function to use Assign Product Default Values
        /// </summary>
        /// <param name="index"></param>
        /// <param name="productCode"></param>
        public void AssignProductDefaultValues(int index, string productCode)
        {
            try
            {
                isValueChange = false;
                dgvSalesOrder.Rows[index].Cells["prdCodeToKeep"].Value = productCode;
                infoProduct = new ProductCreationBll().ProductView(Convert.ToDecimal(productCode));
                dgvSalesOrder.Rows[index].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO29:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use to fill details to updation when comes register or report
        /// </summary>
        public void FillRegisterOrReport()
        {
            try
            {
                SalesQuotationMasterInfo infoSalesQuotationMaster = new SalesQuotationMasterInfo();
                SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                isValueChange = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtOrderNo.ReadOnly = true;
                infoSalesOrderMaster = bllSalesOrder.SalesOrderMasterView(decSalesOrderMasterId);
                txtOrderNo.Text = infoSalesOrderMaster.InvoiceNo;
                strVoucherNo = infoSalesOrderMaster.VoucherNo.ToString();
                decSalesSuffixPrefixId = Convert.ToDecimal(infoSalesOrderMaster.SuffixPrefixId);
                decSalesVoucherId = Convert.ToDecimal(infoSalesOrderMaster.VoucherTypeId);
                isAutomatic = new VoucherTypeBll().CheckMethodOfVoucherNumbering(decSalesVoucherId);
                decSalesOrderTypeId = decSalesVoucherId;
                txtDate.Text = infoSalesOrderMaster.Date.ToString("dd-MMM-yyyy");
                cmbCashOrParty.SelectedValue = infoSalesOrderMaster.LedgerId;
                decSalesOrderVoucherTypeId = infoSalesOrderMaster.VoucherTypeId;
                VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                infoVoucherType = BllVoucherType.VoucherTypeView(decSalesOrderVoucherTypeId);
                string strVoucherTypeName = infoVoucherType.VoucherTypeName;
                this.Text = strVoucherTypeName;
                if (infoSalesOrderMaster.QuotationMasterId == 0)
                {
                    cmbType.SelectedItem = "NA";
                }
                else if (infoSalesOrderMaster.QuotationMasterId != 0)
                {
                    infoSalesQuotationMaster = new SalesQuotationBll().SalesQuotationMasterView(infoSalesOrderMaster.QuotationMasterId);
                    cmbType.SelectedValue = infoSalesQuotationMaster.VoucherTypeId;
                    AgainstQuotationComboFill();
                    cmbQuotationNo.SelectedValue = infoSalesOrderMaster.QuotationMasterId;
                }
                txtDueDate.Text = infoSalesOrderMaster.DueDate.ToString("dd-MMM-yyyy");
                TimeSpan objTs = Convert.ToDateTime(txtDueDate.Text).Subtract(Convert.ToDateTime(txtDate.Text));
                txtDueDays.Text = objTs.Days.ToString();
                txtNarration.Text = infoSalesOrderMaster.Narration;
                cmbCurrency.SelectedValue = infoSalesOrderMaster.ExchangeRateId;
                cmbPricingLevel.SelectedValue = infoSalesOrderMaster.PricinglevelId;
                SalesManComboFill();
                cmbSalesMan.SelectedValue = infoSalesOrderMaster.EmployeeId;
                txtTotalAmount.Text = infoSalesOrderMaster.TotalAmount.ToString();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllSalesOrder.SalesOrderDetailsViewByMasterId(decSalesOrderMasterId);
                if (CheckCancelStatus(decSalesOrderMasterId))
                {
                    isCheck = true;
                    cbxCancelled.Checked = true;
                    cbxCancelled.Enabled = false;
                    btnSave.Enabled = false;
                    isCheck = false;
                }
                else
                {
                    isCheck = true;
                    cbxCancelled.Enabled = true;
                    cbxCancelled.Checked = false;
                    isCheck = false;
                }
                if (isAutomatic)
                {
                    txtOrderNo.ReadOnly = true;
                    txtDate.Focus();
                }
                else
                {
                    txtOrderNo.ReadOnly = false;
                    txtOrderNo.Focus();
                }
                for (int i = 0; i < ListObj[0].Rows.Count; i++)
                {
                    isAmountcalc = false;
                    isValueChange = false;
                    dgvSalesOrder.Rows.Add();
                    dgvSalesOrder.Rows[i].HeaderCell.Value = string.Empty;
                    dgvSalesOrder.Rows[i].Cells["dgvtxtSalesOrderDetailsId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["salesOrderDetailsId"].ToString());
                    dgvSalesOrder.Rows[i].Cells["dgvtxtProductId"].Value = ListObj[0].Rows[i]["productId"].ToString();
                    dgvSalesOrder.Rows[i].Cells["dgvtxtProductCode"].Value = ListObj[0].Rows[i]["productCode"].ToString();
                    dgvSalesOrder.Rows[i].Cells["dgvtxtProductName"].Value = ListObj[0].Rows[i]["productName"].ToString();
                    dgvSalesOrder.Rows[i].Cells["dgvtxtQty"].Value = ListObj[0].Rows[i]["qty"].ToString();
                    UnitComboFill(Convert.ToDecimal(dgvSalesOrder.Rows[i].Cells["dgvtxtProductId"].Value.ToString()), i, dgvSalesOrder.Rows[i].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvSalesOrder.Rows[i].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["unitId"].ToString());
                    dgvSalesOrder.Rows[i].Cells["dgvtxtRate"].Value = ListObj[0].Rows[i]["rate"].ToString();
                    BatchComboFill(Convert.ToDecimal(dgvSalesOrder.Rows[i].Cells["dgvtxtProductId"].Value.ToString()), i, dgvSalesOrder.Rows[i].Cells["dgvcmbBatch"].ColumnIndex);
                    dgvSalesOrder.Rows[i].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["batchId"].ToString());
                    dgvSalesOrder.Rows[i].Cells["dgvtxtBarcode"].Value = ListObj[0].Rows[i]["barcode"].ToString();
                    dgvSalesOrder.Rows[i].Cells["dgvtxtAmount"].Value = ListObj[0].Rows[i]["amount"].ToString();
                    dgvSalesOrder.Rows[i].Cells["dgvtxtUnitConversionId"].Value = ListObj[0].Rows[i]["unitConversionId"].ToString();
                    dgvSalesOrder.Rows[i].Cells["dgvtxtConversionRate"].Value = ListObj[0].Rows[i]["conversionRate"].ToString();
                    dgvSalesOrder.Rows[i].Cells["dgvtxtSalesQuotationDetailsId"].Value = ListObj[0].Rows[i]["quotationDetailsId"].ToString();
                    if (Convert.ToDecimal(ListObj[0].Rows[i]["quotationDetailsId"].ToString()) != 0)
                    {
                        dgvSalesOrder.Rows[i].Cells["dgvtxtProductCode"].ReadOnly = true;
                        dgvSalesOrder.Rows[i].Cells["dgvtxtProductName"].ReadOnly = true;
                        dgvSalesOrder.Rows[i].Cells["dgvtxtBarcode"].ReadOnly = true;
                    }
                    if (cmbQuotationNo.Visible == true)
                    {
                        dgvSalesOrder.Rows[i].Cells["dgvcmbUnit"].ReadOnly = true;
                    }
                }
                isAmountcalc = true;
                isEditFill = false;
                isValueChange = true;
                isDoAfterGridFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesOrderRegister to view details and for updation
        /// </summary>
        /// <param name="frmSalesOrderRegister"></param>
        /// <param name="decSalesOrderMasterid"></param>
        public void CallFromSalesOrderRegister(frmSalesOrderRegister frmSalesOrderRegister, decimal decSalesOrderMasterid)
        {
            try
            {
                base.Show();
                isEditFill = true;
                this.frmSalesOrderRegisterObj = frmSalesOrderRegister;
                frmSalesOrderRegister.Enabled = false;
                decSalesOrderMasterId = decSalesOrderMasterid;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesOrderReport to view details and for updation
        /// </summary>
        /// <param name="frmSalesOrderReport"></param>
        /// <param name="decSalesOrderMasterid"></param>
        public void CallFromSalesOrderReport(frmSalesOrderReport frmSalesOrderReport, decimal decSalesOrderMasterid)
        {
            try
            {
                base.Show();
                isEditFill = true;
                this.frmSalesOrderReportObj = frmSalesOrderReport;
                frmSalesOrderReport.Enabled = false;
                decSalesOrderMasterId = decSalesOrderMasterid;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Clear the form Controls
        /// </summary>
        public void Clear()
        {
            try
            {
                CashorPartyUnderSundryDebitorComboFill();
                SalesManComboFill();
                SalesOrderDateFill();
                PricingLevelComboFill();
                DGVCurrencyComboFill();
                SalesOrderDueDateFill();
                decSalesOrderMasterIdentity = 0;
                cmbQuotationNo.DataSource = null;
                AgainstQuotationComboFill();
                VoucherTypeComboFill();
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDueDate.Value = PublicVariables._dtCurrentDate;
                dtpDueDate.MinDate = Convert.ToDateTime(txtDate.Text);
                dtpDueDate.MaxDate = PublicVariables._dtToDate;
                txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtDueDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtDueDays.Text = "0";
                if (!isAutomatic)
                {
                    txtOrderNo.Clear();
                    txtOrderNo.Focus();
                }
                if (!ShowProductCode())
                {
                    this.dgvSalesOrder.Columns["dgvtxtProductCode"].Visible = false;
                }
                if (!ShowBarcode())
                {
                    this.dgvSalesOrder.Columns["dgvtxtBarcode"].Visible = false;
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
                txtNarration.Text = string.Empty;
                txtTotalAmount.Text = string.Empty;
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                cbxCancelled.Enabled = false;
                dgvSalesOrder.Rows.Clear();
                VoucherNumberGeneration();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Seriel no filling in dgvSalesOrder
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvSalesOrder.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DGVBatchComboFill()
        {
            try
            {
                BatchBll BllBatch = new BatchBll();
                List<DataTable> listBatch = new List<DataTable>();
                listBatch = BllBatch.BatchViewAll();
                dgvcmbBatch.DataSource = listBatch;
                DataRow dr = listBatch[0].NewRow();
                dr[0] = 0;
                dr[1] = "NA";
                listBatch[0].Rows.InsertAt(dr, 0);
                dgvcmbBatch.ValueMember = "batchId";
                dgvcmbBatch.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DGVUnitComboFill()
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAll();
                dgvcmbUnit.DataSource = ListObj;
                DataRow dr = ListObj[0].NewRow();
                dr[2] = "NA";
                ListObj[0].Rows.InsertAt(dr, 0);
                dgvcmbUnit.ValueMember = "unitId";
                dgvcmbUnit.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Currency combofill function
        /// </summary>
        public void DGVCurrencyComboFill()
        {
            try
            {
                List<DataTable> listObjCurrency = new List<DataTable>();
                SettingsBll BllSettings = new SettingsBll();
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                listObjCurrency = TransactionGeneralFillObj.CurrencyComboByDate(Convert.ToDateTime(txtDate.Text));
                cmbCurrency.DataSource = listObjCurrency[0];
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
                MessageBox.Show("SO35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use print
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        public void Print(decimal decSalesOrderMasterId)
        {
            try
            {
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                DataSet dsSalesOrder = bllSalesOrder.SalesOrderPrinting(decSalesOrderMasterId, 1);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.SalesOrderPrinting(dsSalesOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Print For DotMatrix
        /// </summary>
        /// <param name="decSalesOrderMasterId"></param>
        public void PrintForDotMatrix(decimal decSalesOrderMasterId)
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
                dtblGridDetails.Columns.Add("Batch");
                dtblGridDetails.Columns.Add("Rate");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvSalesOrder.Rows)
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
                        if (dRow.Cells["dgvtxtQty"].Value != null)
                        {
                            dr["Qty"] = dRow.Cells["dgvtxtQty"].Value.ToString();
                        }
                        if (dRow.Cells["dgvcmbUnit"].Value != null)
                        {
                            dr["Unit"] = dRow.Cells["dgvcmbUnit"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbBatch"].Value != null)
                        {
                            dr["Batch"] = dRow.Cells["dgvcmbBatch"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvtxtRate"].Value != null)
                        {
                            dr["Rate"] = dRow.Cells["dgvtxtRate"].Value.ToString();
                        }
                        if (dRow.Cells["dgvtxtAmount"].Value != null)
                        {
                            dr["Amount"] = dRow.Cells["dgvtxtAmount"].Value.ToString();
                        }
                        dtblGridDetails.Rows.Add(dr);
                    }
                }
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("DueDate");
                dtblOtherDetails.Columns.Add("SalesMan");
                dtblOtherDetails.Columns.Add("VoucherType");
                dtblOtherDetails.Columns.Add("PricingLevel");
                dtblOtherDetails.Columns.Add("QuotationNO");
                dtblOtherDetails.Columns.Add("DueDays");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("Narration");
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
                dRowOther["voucherNo"] = txtOrderNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["DueDays"] = txtDueDays.Text;
                dRowOther["SalesMan"] = cmbSalesMan.Text;
                dRowOther["PricingLevel"] = cmbPricingLevel.Text;
                dRowOther["DueDate"] = txtDueDate.Text;
                dRowOther["QuotationNO"] = cmbQuotationNo.Text;
                dRowOther["TotalAmount"] = txtTotalAmount.Text;
                dRowOther["VoucherType"] = cmbType.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtTotalAmount.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decSalesOrderTypeId);
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
                MessageBox.Show("SO37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Fill Details Corresponding Quotation No
        /// </summary>
        public void FillQuotationDetails()
        {
            SerialNo();
            try
            {
                BatchBll BllBatch = new BatchBll();
                SalesOrderDetailsInfo infoSalesOrderDetails = new SalesOrderDetailsInfo();
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                decimal decOrderNo = 0;
                if (!isEditFill)
                {
                    inMaxCount = 0;
                    decOrderNo = Convert.ToDecimal(cmbQuotationNo.SelectedValue.ToString());
                    dgvSalesOrder.Rows.Clear();
                    List<DataTable> ListObj = new SalesQuotationBll().QuotationMasterViewByQuotationMasterId(Convert.ToDecimal(cmbQuotationNo.SelectedValue.ToString()));
                    if (ListObj[0].Rows.Count > 0)
                    {
                        cmbPricingLevel.SelectedValue = ListObj[0].Rows[0]["pricingLevelId"].ToString();
                        if (ListObj[0].Rows[0]["employeeId"].ToString() != "")
                        {
                            strSalesMan = ListObj[0].Rows[0]["employeeId"].ToString();
                            cmbSalesMan.SelectedValue = strSalesMan;
                            if (cmbSalesMan.SelectedValue == null)
                            {
                                SalesManComboFill();
                                cmbSalesMan.SelectedValue = ListObj[0].Rows[0]["employeeId"].ToString();
                            }
                        }
                        DGVCurrencyComboFill();
                        cmbCurrency.SelectedValue = ListObj[0].Rows[0]["exchangeRateId"].ToString();
                        List<DataTable> ListObj1 = new SalesQuotationBll().SalesQuotationDetailsViewByquotationMasterIdWithRemainingBySO(Convert.ToDecimal(cmbQuotationNo.SelectedValue.ToString()), decSalesOrderMasterId);
                        int inRowIndex = 0;
                        foreach (DataRow drowDetails in ListObj1[0].Rows)
                        {
                            dgvSalesOrder.Rows.Add();
                            isValueChange = false;
                            isDoAfterGridFill = false;
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtSalesOrderDetailsId"].Value = drowDetails.ItemArray[0].ToString();
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtSalesQuotationDetailsId"].Value = drowDetails.ItemArray[0].ToString();
                            String ProductId = drowDetails.ItemArray[2].ToString();
                            infoProduct = new ProductCreationBll().ProductView(Convert.ToDecimal(ProductId));
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtBarcode"].Value = drowDetails["barcode"].ToString();
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtProductId"].Value = drowDetails["productId"];
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtProductName"].Value = drowDetails["productName"].ToString();
                            AssignProductDefaultValues(dgvSalesOrder.Rows.Count - 2, drowDetails["productId"].ToString());
                            TransactionGeneralFillObj.UnitViewAllByProductId(dgvSalesOrder, infoProduct.ProductId.ToString(), dgvSalesOrder.Rows.Count - 2);
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtQty"].Value = drowDetails["qty"].ToString();
                            UnitComboFill(Convert.ToDecimal(ProductId), dgvSalesOrder.Rows.Count - 2, dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbUnit"].ColumnIndex);
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtRate"].Value = drowDetails["rate"].ToString();
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtAmount"].Value = drowDetails["amount"].ToString();
                            BatchComboFill(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvSalesOrder.Rows.Count - 2, dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbBatch"].ColumnIndex);
                            if (Convert.ToDecimal(drowDetails["batchId"].ToString()) != 0)
                            {
                                dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                            }
                            else
                            {
                                StockPostingBll BllStockPosting = new StockPostingBll();
                                decimal decBatchId = BllStockPosting.BatchViewByProductId(Convert.ToDecimal(ProductId));
                                dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbBatch"].Value = decBatchId;
                            }
                            string strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbBatch"].Value.ToString()));
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtBarcode"].Value = strBarcode.ToString();
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtProductCode"].ReadOnly = true;
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtProductName"].ReadOnly = true;
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtBarcode"].ReadOnly = true;
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["inRowIndex"].Value = drowDetails["extra1"].ToString();
                            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                            List<DataTable> list = new List<DataTable>();
                            list = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtProductId"].Value.ToString());
                            foreach (DataRow drUnitByProduct in list[0].Rows)
                            {
                                if (dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                {
                                    dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                    dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                }
                            }
                            decCurrentConversionRate = Convert.ToDecimal(dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value.ToString());
                            decCurrentRate = Convert.ToDecimal(dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvtxtRate"].Value.ToString());
                            if (cmbQuotationNo.Visible == true)
                            {
                                dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                            }
                            dgvSalesOrder.Rows[dgvSalesOrder.Rows.Count - 2].HeaderCell.Value = "";
                            int intIndex = 0;
                            int.TryParse(drowDetails["extra1"].ToString(), out intIndex);
                            if (inMaxCount < intIndex)
                                inMaxCount = intIndex;
                            inRowIndex++;
                            isValueChange = true;
                        }
                        for (int i = inRowIndex; i < dgvSalesOrder.Rows.Count; ++i)
                            dgvSalesOrder["inRowIndex", i].Value = GetNextinRowIndex().ToString();
                        SerialNo();
                        TotalAmountCalculation();
                        isDoAfterGridFill = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO38: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to the decimal validation in grid decimal fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvSalesOrder.CurrentCell != null)
                {
                    if (dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtQty" || dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the voucherno Automatic generation
        /// </summary>
        public void VoucherNumberGeneration()
        {
            string strTableName = "SalesOrderMaster";
            string strPrefix = string.Empty;
            string strSuffix = string.Empty;
            string strInvoiceNo = string.Empty;
            try
            {
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                if (isAutomatic)
                {
                    strVoucherNo = "0";
                    if (strVoucherNo == string.Empty)
                    {
                        strVoucherNo = "0"; //strMax;
                    }
                    strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decSalesOrderTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                    if (Convert.ToDecimal(strVoucherNo) != bllSalesOrder.SalesOrderVoucherMasterMaxPlusOne(decSalesOrderTypeId))
                    {
                        strVoucherNo = bllSalesOrder.SalesOrderVoucherMasterMax(decSalesOrderTypeId).ToString();
                        strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decSalesOrderTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                        if (bllSalesOrder.SalesOrderVoucherMasterMax(decSalesOrderTypeId).ToString() == "0")
                        {
                            strVoucherNo = "0";
                            strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decSalesOrderTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                        }
                    }
                    if (isAutomatic)
                    {
                        SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                        SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                        infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decSalesOrderTypeId, dtpDate.Value);
                        strPrefix = infoSuffixPrefix.Prefix;
                        strSuffix = infoSuffixPrefix.Suffix;
                        strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                        txtOrderNo.Text = strInvoiceNo;
                        txtOrderNo.ReadOnly = true;
                    }
                    else
                    {
                        txtOrderNo.ReadOnly = false;
                        txtOrderNo.Text = string.Empty;
                        strInvoiceNo = txtOrderNo.Text.Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove Product and details in editing mode
        /// </summary>
        public void RemoveSalesOrderDetails()
        {
            try
            {
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                foreach (var strId in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strId);
                    bllSalesOrder.SalesOrderDetailsDeletee(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the New Row Added To SalesOrder Details
        /// </summary>
        public void NewRowAddedToSalesOrderDetails()
        {
            try
            {
                SalesOrderDetailsInfo infoSalesOrderDetails = new SalesOrderDetailsInfo();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                decimal decQuotationId = 0;
                for (int inI = 0; inI < dgvSalesOrder.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value) != null)
                    {
                        infoSalesOrderDetails.SalesOrderMasterId = decSalesOrderMasterId;
                        infoProduct = new ProductCreationBll().ProductViewByCode(dgvSalesOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoSalesOrderDetails.ProductId = infoProduct.ProductId;
                        infoSalesOrderDetails.Qty = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        infoSalesOrderDetails.UnitId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbUnit"].Value);
                        infoSalesOrderDetails.UnitConversionId = decConversionId;
                        infoSalesOrderDetails.Rate = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoSalesOrderDetails.Amount = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoSalesOrderDetails.QuotationDetailsId = decQuotationId;
                        infoSalesOrderDetails.SlNo = Convert.ToInt32(dgvSalesOrder.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        infoSalesOrderDetails.BatchId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                        infoSalesOrderDetails.Extra1 = string.Empty;
                        infoSalesOrderDetails.Extra2 = string.Empty;
                        bllSalesOrder.SalesOrderDetailsAdd(infoSalesOrderDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Editthe sales order details 
        /// </summary>
        public void SalesOrderDetailsEditFill()
        {
            try
            {
                SalesOrderDetailsInfo infoSalesOrderDetails = new SalesOrderDetailsInfo();
                SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                //SalesOrderBll spSalesOrdermaster = new SalesOrderMasterSP();
                for (int inI = 0; inI < dgvSalesOrder.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value) == 0 || dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value == null)
                    {
                        infoSalesOrderDetails.SalesOrderMasterId = decSalesOrderMasterId;
                        infoSalesOrderDetails.SalesOrderDetailsId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value);
                        infoProduct = new ProductCreationBll().ProductViewByCode(dgvSalesOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoSalesOrderDetails.ProductId = infoProduct.ProductId;
                        infoSalesOrderDetails.Qty = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtQty"].Value);
                        infoSalesOrderDetails.UnitId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        infoSalesOrderDetails.UnitConversionId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                        infoSalesOrderDetails.BatchId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                        infoSalesOrderDetails.Rate = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoSalesOrderDetails.Amount = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoSalesOrderDetails.SlNo = Convert.ToInt32(dgvSalesOrder.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        if (dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value != null && dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value.ToString() != string.Empty)
                        {
                            infoSalesOrderDetails.QuotationDetailsId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value.ToString());
                        }
                        else
                        {
                            infoSalesOrderMaster.QuotationMasterId = 0;
                        }
                        infoSalesOrderDetails.Extra1 = string.Empty;
                        infoSalesOrderDetails.Extra2 = string.Empty;
                        bllSalesOrder.SalesOrderDetailsAdd(infoSalesOrderDetails);
                    }
                    else
                    {
                        infoSalesOrderDetails.SalesOrderMasterId = decSalesOrderMasterId;
                        infoSalesOrderDetails.SalesOrderDetailsId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value);
                        infoProduct = new ProductCreationBll().ProductViewByCode(dgvSalesOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoSalesOrderDetails.ProductId = infoProduct.ProductId;
                        infoSalesOrderDetails.Qty = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtQty"].Value);
                        infoSalesOrderDetails.UnitId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        infoSalesOrderDetails.UnitConversionId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                        infoSalesOrderDetails.BatchId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                        infoSalesOrderDetails.Rate = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoSalesOrderDetails.Amount = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoSalesOrderDetails.SlNo = Convert.ToInt32(dgvSalesOrder.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        if (dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value != null && dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value.ToString() != string.Empty)
                        {
                            infoSalesOrderDetails.QuotationDetailsId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value.ToString());
                        }
                        else
                        {
                            infoSalesOrderMaster.QuotationMasterId = 0;
                        }
                        infoSalesOrderDetails.Extra1 = string.Empty;
                        infoSalesOrderDetails.Extra2 = string.Empty;
                        bllSalesOrder.SalesOrderDetailsEdit(infoSalesOrderDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to check if same name in any row if row not equal to x
        /// </summary>
        /// <returns></returns>
        public bool ProductSameOccourance()
        {
            bool isSame = false;
            try
            {
                int index = dgvSalesOrder.CurrentRow.Index;
                string strName = dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    string strOther = dgvSalesOrder.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                    if (strName == strOther)
                    {
                        inCurrentIndex = dgvSalesOrder.Rows[inI].Cells["dgvtxtProductName"].RowIndex;
                    }
                }
                dgvSalesOrder.Rows[inCurrentIndex].HeaderCell.Value = "";
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSame;
        }
        /// <summary>
        /// To remove rows from grid
        /// </summary>
        public void RemoveFunction()
        {
            try
            {
                int inRowCount = dgvSalesOrder.RowCount;
                int index = dgvSalesOrder.CurrentRow.Index;
                int inC = 0;
                if (inRowCount > 2)
                {
                    if (dgvSalesOrder.CurrentRow.HeaderCell.Value.ToString() == "" && dgvSalesOrder.CurrentRow.HeaderCell.Value == null)
                    {
                        string strName = dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                        int inIndex = dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].RowIndex;
                        string strOther;
                        for (int inI = 0; inI < inRowCount - 1; inI++)
                        {
                            inC++;
                            strOther = dgvSalesOrder.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                            if (inIndex != dgvSalesOrder.Rows[inI].Cells["dgvtxtProductName"].RowIndex)
                            {
                                if (ProductSameOccourance())
                                {
                                    dgvSalesOrder.Rows.RemoveAt(index);
                                    return;
                                }
                                else
                                {
                                    if (inC == inRowCount - 1)
                                    {
                                        dgvSalesOrder.Rows.RemoveAt(index);
                                        inC = 0;
                                    }
                                }
                            }
                            else
                            {
                                dgvSalesOrder.Rows.RemoveAt(index);
                            }
                        }
                    }
                    else
                    {
                        dgvSalesOrder.Rows.RemoveAt(index);
                    }
                }
                else
                {
                    dgvSalesOrder.Rows.RemoveAt(index);
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the SaveItems to table
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                decimal decSalesOrderSuffixPrefixId = 0;
                SalesOrderDetailsInfo infoSalesOrderDetails = new SalesOrderDetailsInfo();
                SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                SalesOrderBll bllSalesOrderMaster = new SalesOrderBll();
                infoSalesOrderMaster.Cancelled = false;
                infoSalesOrderMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoSalesOrderMaster.DueDate = Convert.ToDateTime(txtDueDate.Text);
                infoSalesOrderMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                if (isAutomatic)
                {
                    infoSalesOrderMaster.SuffixPrefixId = decSalesOrderSuffixPrefixId;
                    infoSalesOrderMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoSalesOrderMaster.SuffixPrefixId = 0;
                    infoSalesOrderMaster.VoucherNo = bllSalesOrderMaster.VoucherNoMax(decSalesOrderTypeId);
                }
                infoSalesOrderMaster.VoucherTypeId = decSalesOrderTypeId;
                infoSalesOrderMaster.InvoiceNo = txtOrderNo.Text;
                infoSalesOrderMaster.UserId = PublicVariables._decCurrentUserId;
                if (cmbSalesMan.SelectedIndex == -1)
                {
                    infoSalesOrderMaster.SalesOrderMasterId = 0;
                }
                else
                {
                    infoSalesOrderMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                }
                infoSalesOrderMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                if (cmbPricingLevel.SelectedIndex == -1)
                {
                    infoSalesOrderMaster.PricinglevelId = 0;
                }
                else
                {
                    infoSalesOrderMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                }
                infoSalesOrderMaster.Narration = txtNarration.Text.Trim();
                if (cmbQuotationNo.SelectedIndex == -1)
                {
                    infoSalesOrderMaster.QuotationMasterId = 0;
                }
                else
                {
                    infoSalesOrderMaster.QuotationMasterId = Convert.ToDecimal(cmbQuotationNo.SelectedValue.ToString());
                }
                infoSalesOrderMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                infoSalesOrderMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                infoSalesOrderMaster.Extra1 = string.Empty;
                infoSalesOrderMaster.Extra2 = string.Empty;
                decSalesOrderMasterIdentity = Convert.ToDecimal(bllSalesOrderMaster.SalesOrderMasterAdd(infoSalesOrderMaster));
                int inRowcount = dgvSalesOrder.Rows.Count;
                for (int inI = 0; inI < inRowcount - 1; inI++)
                {
                    infoSalesOrderDetails.SalesOrderMasterId = decSalesOrderMasterIdentity;
                    if (dgvSalesOrder.Rows[inI].Cells["dgvtxtProductCode"].Value != null && dgvSalesOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString() != "")
                    {
                        infoProduct = new ProductCreationBll().ProductViewByCode(dgvSalesOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoSalesOrderDetails.ProductId = infoProduct.ProductId;
                    }
                    if (dgvSalesOrder.Rows[inI].Cells["dgvtxtQty"].Value != null && dgvSalesOrder.Rows[inI].Cells["dgvtxtQty"].Value.ToString() != "")
                    {
                        infoSalesOrderDetails.Qty = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                    }
                    if (dgvSalesOrder.Rows[inI].Cells["dgvcmbUnit"].Value != null && dgvSalesOrder.Rows[inI].Cells["dgvcmbUnit"].Value.ToString() != "")
                    {
                        infoSalesOrderDetails.UnitId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        infoSalesOrderDetails.UnitConversionId = decConversionId;
                    }
                    if (dgvSalesOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value != null && dgvSalesOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString() != "")
                    {
                        infoSalesOrderDetails.UnitConversionId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                    }
                    if (dgvSalesOrder.Rows[inI].Cells["dgvcmbBatch"].Value != null && dgvSalesOrder.Rows[inI].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                    {
                        infoSalesOrderDetails.BatchId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                    }
                    if (dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value == null || dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value.ToString() == "")
                    {
                        infoSalesOrderDetails.QuotationDetailsId = Convert.ToDecimal(0);
                    }
                    else
                    {
                        infoSalesOrderDetails.QuotationDetailsId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesQuotationDetailsId"].Value);
                    }
                    infoSalesOrderDetails.Rate = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                    infoSalesOrderDetails.Amount = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                    infoSalesOrderDetails.SlNo = Convert.ToInt32(dgvSalesOrder.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                    infoSalesOrderDetails.UnitConversionId = Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                    infoSalesOrderDetails.Extra1 = string.Empty;
                    infoSalesOrderDetails.Extra2 = string.Empty;
                    bllSalesOrder.SalesOrderDetailsAdd(infoSalesOrderDetails);
                }
                Messages.SavedMessage();
                if (cbxPrintAfterSave.Checked == true)
                {
                    if (new SettingsBll().SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(decSalesOrderMasterIdentity);
                    }
                    else
                    {
                        Print(decSalesOrderMasterIdentity);
                    }
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Edit Function When update datas in Register or Report
        /// </summary>
        public void EditFunction()
        {
            try
            {
                decimal decSalesOrderSuffixPrefixId = 0;
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
                SalesOrderDetailsInfo infoSalesOrderDetails = new SalesOrderDetailsInfo();
                infoSalesOrderMaster.VoucherTypeId = decSalesVoucherId;
                for (int inI = 0; inI < dgvSalesOrder.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value) != null && Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value) != 0)
                    {
                        //for (int i = 0; i < dgvSalesOrder.Rows.Count - 1; i++)
                        //{
                        isEditDetails = Convert.ToString(bllSalesOrder.SalesOrderRefererenceCheckForEditDetails(Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value)));
                        //}
                    }
                }
                isEditMaster = Convert.ToString(bllSalesOrder.SalesOrderRefererenceCheckForEditMaster(decSalesOrderMasterId));
                if (isEditMaster == "False" && isEditDetails == "False")
                {
                    infoSalesOrderMaster.SalesOrderMasterId = decSalesOrderMasterId;
                    infoSalesOrderMaster.Cancelled = cbxCancelled.Checked;
                    infoSalesOrderMaster.Date = Convert.ToDateTime(txtDate.Text);
                    infoSalesOrderMaster.DueDate = Convert.ToDateTime(txtDueDate.Text);
                    infoSalesOrderMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                    infoSalesOrderMaster.SuffixPrefixId = Convert.ToDecimal(decSalesOrderSuffixPrefixId);
                    infoSalesOrderMaster.VoucherNo = strVoucherNo;
                    infoSalesOrderMaster.InvoiceNo = txtOrderNo.Text;
                    infoSalesOrderMaster.UserId = PublicVariables._decCurrentUserId;
                    infoSalesOrderMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                    infoSalesOrderMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                    if (cmbQuotationNo.SelectedIndex == -1)
                    {
                        infoSalesOrderMaster.QuotationMasterId = 0;
                    }
                    else
                    {
                        infoSalesOrderMaster.QuotationMasterId = Convert.ToDecimal(cmbQuotationNo.SelectedValue.ToString());
                    }
                    infoSalesOrderMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoSalesOrderMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                    infoSalesOrderMaster.Narration = txtNarration.Text.Trim();
                    infoSalesOrderMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                    infoSalesOrderMaster.Extra1 = string.Empty;
                    infoSalesOrderMaster.Extra2 = string.Empty;
                    RemoveSalesOrderDetails();
                    bllSalesOrder.SalesOrderMasterEdit(infoSalesOrderMaster);
                    SalesOrderDetailsEditFill();
                    Messages.UpdatedMessage();
                    if (frmSalesOrderRegisterObj != null)
                    {
                        if (cbxPrintAfterSave.Checked == true)
                        {
                            if (new SettingsBll().SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesOrderMasterId);
                            }
                            else
                            {
                                Print(decSalesOrderMasterId);
                            }
                        }
                        this.Close();
                        frmSalesOrderRegisterObj.GridFill();
                    }
                    if (frmSalesOrderReportObj != null)
                    {
                        if (cbxPrintAfterSave.Checked == true)
                        {
                            if (new SettingsBll().SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesOrderMasterId);
                            }
                            else
                            {
                                Print(decSalesOrderMasterId);
                            }
                        }
                        this.Close();
                        frmSalesOrderReportObj.GridFill();
                    }
                    if (frmDayBookObj != null)
                    {
                        if (cbxPrintAfterSave.Checked == true)
                        {
                            if (new SettingsBll().SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesOrderMasterId);
                            }
                            else
                            {
                                Print(decSalesOrderMasterId);
                            }
                        }
                        this.Close();
                    }
                    if (objVoucherSearch != null)
                    {
                        if (cbxPrintAfterSave.Checked == true)
                        {
                            if (new SettingsBll().SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesOrderMasterId);
                            }
                            else
                            {
                                Print(decSalesOrderMasterId);
                            }
                        }
                        this.Close();
                        objVoucherSearch.GridFill();
                    }
                }
                else
                {
                    Messages.ReferenceExistsMessageForUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check whether the values of grid is valid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                if (dgvSalesOrder.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvtxtRate"].Value) == 0)
                        {
                            isValueChange = true;
                            dgvSalesOrder.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesOrder.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].Value == null || dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvSalesOrder.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesOrder.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvSalesOrder.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvSalesOrder.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == string.Empty || Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvtxtQty"].Value) == 0)
                        {
                            isValueChange = true;
                            dgvSalesOrder.CurrentRow.HeaderCell.Value = "X";
                            dgvSalesOrder.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvSalesOrder.CurrentRow.HeaderCell.Value = "";
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to RemoveIncomplete Rows FromGrid
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvSalesOrder.RowCount;
                int inLastRow = 1;//To eliminate last row from checking
                foreach (DataGridViewRow dgvrowCur in dgvSalesOrder.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.HeaderCell.Value != null)
                        {
                            if (dgvrowCur.HeaderCell.Value.ToString() == "X" || dgvrowCur.Cells["dgvtxtProductName"].Value == null)
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
                        for (int inK = 0; inK < dgvSalesOrder.Rows.Count; inK++)
                        {
                            if (dgvSalesOrder.Rows[inK].HeaderCell.Value != null && dgvSalesOrder.Rows[inK].HeaderCell.Value.ToString() == "X")
                            {
                                if (!dgvSalesOrder.Rows[inK].IsNewRow)
                                {
                                    dgvSalesOrder.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvSalesOrder.Rows[inForFirst].Cells["dgvtxtProductName"].Selected = true;
                        dgvSalesOrder.CurrentCell = dgvSalesOrder.Rows[inForFirst].Cells["dgvtxtProductName"];
                        dgvSalesOrder.Focus();
                    }
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO049:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to use the invalid entries checking for Save 
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                dgvSalesOrder.ClearSelection();
                int inRow = dgvSalesOrder.RowCount;
                if (txtOrderNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number");
                    txtOrderNo.Focus();
                }
                else if (bllSalesOrder.SalesOrderNumberCheckExistence(txtOrderNo.Text.Trim(), 0, decSalesOrderTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Order number already exist");
                    txtOrderNo.Focus();
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
                else if (cmbPricingLevel.SelectedValue == null)
                {
                    Messages.InformationMessage("Select Pricing Level");
                    cmbPricingLevel.Focus();
                }
                else if (cmbSalesMan.SelectedValue == null)
                {
                    Messages.InformationMessage("Select SalesMan");
                    cmbSalesMan.Focus();
                }
                else if (txtDueDate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select due date");
                    txtDueDate.Focus();
                }
                else if (txtDueDays.Text.Contains("-") && txtDueDays.Text != string.Empty)
                {
                    Messages.InformationMessage("Due date should not be greater than order date");
                    txtDueDate.Focus();
                }
                else if (inRow - 1 == 0)
                {
                    Messages.InformationMessage("Can't save sales order without atleast one product with complete details");
                }
                else if (RemoveIncompleteRowsFromGrid())
                {
                    if (dgvSalesOrder.Rows[0].Cells["dgvtxtProductName"].Value == null && dgvSalesOrder.Rows[0].Cells["dgvtxtProductCode"].Value == null)
                    {
                        MessageBox.Show("Can't save sales order without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSalesOrder.ClearSelection();
                        dgvSalesOrder.Focus();
                    }
                    else
                    {
                        if (btnSave.Text == "Save")
                        {
                            if (dgvSalesOrder.Rows[0].Cells["dgvtxtProductName"].Value == null
                             || dgvSalesOrder.Rows[0].Cells["dgvtxtQty"].Value == null
                             || dgvSalesOrder.Rows[0].Cells["dgvtxtAmount"].Value == null
                             || dgvSalesOrder.Rows[0].Cells["dgvtxtRate"].Value == null)
                            {
                                MessageBox.Show("Can't save sales order without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvSalesOrder.ClearSelection();
                                dgvSalesOrder.Focus();
                            }
                            else
                            {
                                if (PublicVariables.isMessageAdd)
                                {
                                    if (Messages.SaveMessage())
                                    {
                                        SaveFunction();
                                    }
                                }
                                else
                                {
                                    SaveFunction();
                                }
                            }
                        }
                        if (btnSave.Text == "Update")
                        {
                            if (dgvSalesOrder.Rows[0].Cells["dgvtxtProductName"].Value == null
                             || dgvSalesOrder.Rows[0].Cells["dgvtxtQty"].Value == null
                             || dgvSalesOrder.Rows[0].Cells["dgvtxtAmount"].Value == null
                             || dgvSalesOrder.Rows[0].Cells["dgvtxtRate"].Value == null)
                            {
                                MessageBox.Show("Can't edit sales order without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvSalesOrder.ClearSelection();
                                dgvSalesOrder.Focus();
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
                MessageBox.Show("SO50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the cancel the salesOrder
        /// </summary>
        public void SalesOrderCancel()
        {
            try
            {
                SalesOrderBll bllSalesOrderMaster = new SalesOrderBll();
                bllSalesOrderMaster.SalesOrderCancel(decSalesOrderMasterId);
                Messages.InformationMessage("Cancelled successfully");
                if (frmSalesOrderRegisterObj != null)
                {
                    this.Close();
                    frmSalesOrderRegisterObj.GridFill();
                }
                if (frmSalesOrderReportObj != null)
                {
                    this.Close();
                    frmSalesOrderReportObj.GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to use Check Cancel Status
        /// </summary>
        /// <param name="decId"></param>
        /// <returns></returns>
        public bool CheckCancelStatus(decimal decId)
        {
            bool isCancelled = false;
            try
            {
                SalesOrderBll spSalesOrder = new SalesOrderBll();
                isCancelled = spSalesOrder.SalesOrderCancelCheckStatus(decId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO52:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isCancelled;
        }
        /// <summary>
        /// Function to delete 
        /// </summary>
        public void Delete()
        {
            try
            {
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                decimal decResult1 = 0;
                for (int inI = 0; inI < dgvSalesOrder.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value) != 0)
                    {
                        decResult1 = bllSalesOrder.SalesOrderDetailsDeletee(Convert.ToDecimal(dgvSalesOrder.Rows[inI].Cells["dgvtxtSalesOrderDetailsId"].Value));
                    }
                }
                decimal decResult2 = bllSalesOrder.SalesOrderMasterDelete(decSalesOrderMasterId);
                if (decResult1 > 0 && decResult2 > 0)
                {
                    Messages.DeletedMessage();
                    if (frmSalesOrderRegisterObj != null)
                    {
                        this.Close();
                        frmSalesOrderRegisterObj.Enabled = true;
                    }
                    if (frmSalesOrderReportObj != null)
                    {
                        this.Close();
                        frmSalesOrderReportObj.Enabled = true;
                    }
                    if (objVoucherSearch != null)
                    {
                        this.Close();
                        objVoucherSearch.Enabled = true;
                    }
                    if (frmDayBookObj != null)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Messages.ReferenceExistsMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO53:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete function calling and reference checking
        /// </summary>
        public void DeleteFuntion()
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
                MessageBox.Show("SO54:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Clear the Order
        /// </summary>
        public void OrderClear()
        {
            try
            {
                cmbQuotationNo.DataSource = null;
                dgvSalesOrder.Rows.Clear();
                txtTotalAmount.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR55:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDayBook to view details and for updation
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void callfromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                base.Show();
                isEditFill = true;
                frmDayBook.Enabled = false;
                this.frmDayBookObj = frmDayBook;
                decSalesOrderMasterId = decMasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR56:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to fill the unit combobox
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void UnitComboFill(decimal decproductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                UnitBll bllUnit = new UnitBll();
                ListObj = bllUnit.UnitViewAllByProductId(decproductId);
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvSalesOrder.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form load, call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                txtTotalAmount.Text = "0.00";
                FillProducts(false, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO58:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Button sales man Click, to create a new salesman from this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalesMan_Click(object sender, EventArgs e)
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
                    frmSalesmanObj.MdiParent = formMDI.MDIObj;//Edited by Najma
                    frmSalesmanObj.CallFromSalesOrder(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromSalesOrder(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO59:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button click, clos the form
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
                MessageBox.Show("SO60:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Vouchertype index change call the quotation no combo fill function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OrderClear();
                if (cmbType.Text == "NA")
                {
                    lblQuotationNo.Visible = false;
                    cmbQuotationNo.Visible = false;
                    dgvSalesOrder.Rows.Clear();
                    cmbQuotationNo.DataSource = null;
                }
                else if (cmbType.Text != "NA")
                {
                    lblQuotationNo.Visible = true;
                    cmbQuotationNo.Visible = true;
                    AgainstQuotationComboFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO61" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the Quotation no combofill 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strCashOrPartyText = string.Empty;
                if (btnSave.Text == "Save")
                {
                    strCashOrPartyText = cmbCashOrParty.Text;
                }
                if (btnSave.Text == "Update" && cmbType.Text == "NA")
                {
                    GetSalesOrderDetailsIdToDelete();
                    dgvSalesOrder.Rows.Clear();
                    strCashOrPartyText = cmbCashOrParty.Text;
                }
                else if (btnSave.Text == "Update" && cmbType.Text != "NA")
                {
                    strCashOrPartyText = cmbCashOrParty.Text;
                    AgainstQuotationComboFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO62:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Doing the basic calculations in grid cell leave 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// To add a new Cashor party using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCashOrParty_Click(object sender, EventArgs e)
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
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;//Edited by Najma
                    frmAccountLedgerObj.CallFromSalesOrder(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromSalesOrder(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO64:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// changing date in textbox while changing date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime datetime = this.dtpDate.Value;
                txtDate.Text = datetime.ToString("dd-MMM-yyyy");
                //  dtpDueDate.MinDate = datetime;
                // txtDueDate.Text = datetime.ToString("dd-MMM-yyyy");
                DGVCurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO65:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
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
                DueDays();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO66:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for change date in Date time picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDueDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtDueDate);
                if (!isInvalid)
                {
                    txtDueDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                if (Convert.ToDateTime(txtDueDate.Text) < Convert.ToDateTime(txtDate.Text))
                {
                    txtDueDate.Text = txtDate.Text;
                    dtpDueDate.Value = Convert.ToDateTime(txtDueDate.Text);
                }
                else
                {
                    dtpDueDate.Value = Convert.ToDateTime(txtDueDate.Text);
                }
                DueDays();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO69:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// for change date in Date time picker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpDueDate.Value;
                this.txtDueDate.Text = date.ToString("dd-MMM-yyyy");
                txtDueDate.Focus();
                DueDays();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO70:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the serial no function when a row added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO71" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Clear();
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Close();
                    frmDayBookObj = null;
                }
                if (frmSalesOrderRegisterObj != null)
                {
                    frmSalesOrderRegisterObj.Close();
                    frmSalesOrderRegisterObj = null;
                }
                if (frmSalesOrderReportObj != null)
                {
                    frmSalesOrderReportObj.Close();
                    frmSalesOrderReportObj = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO72:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Data gridview DataBindingComplete, here clear the selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvSalesOrder.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO73:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the keypress events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvSalesOrder.CurrentCell != null && dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    if (dgvSalesOrder.CurrentCell != null && dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvSalesOrder.CurrentCell != null && dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name != "dgvtxtProductCode" && dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name != "dgvtxtProductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvSalesOrder.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;
                }
                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                    tb.KeyDown -= dgvSalesOrder_KeyDown;
                    tb.KeyDown += new KeyEventHandler(dgvSalesOrder_KeyDown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO74:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// doing the unit conversion in cell enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
            SalesOrderBll bllSalesOrder = new SalesOrderBll();
            // decimal decQty =0;
            try
            {
                if (dgvSalesOrder.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvSalesOrder.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvSalesOrder.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                    {
                        if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                        {
                            if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                            {
                                if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                                {
                                    decCurrentConversionRate = Convert.ToDecimal(dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                    decCurrentRate = Convert.ToDecimal(dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                                }
                            }
                        }
                    }
                    if (dgvSalesOrder.CurrentRow.Cells["dgvtxtProductId"].Value != null)
                    {
                        if (dgvSalesOrder.CurrentRow.Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                        {
                            BatchBll BllBatch = new BatchBll();
                            decimal decBatchId = Convert.ToDecimal(dgvSalesOrder.CurrentRow.Cells["dgvcmbBatch"].Value);
                            string strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                            dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = strBarcode;
                        }
                    }
                }
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO75" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void productDetailsFill(string strProduct, int inRowIndex, string strFillMode)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                if (strFillMode == "Barcode")
                {
                    listObj = BllProductCreation.ProductDetailsCoreespondingToBarcode(strProduct);
                }
                else if (strFillMode == "ProductCode")
                {
                    listObj = BllProductCreation.ProductDetailsCoreespondingToProductCode(strProduct);
                }
                else if (strFillMode == "ProductName")
                {
                    listObj = BllProductCreation.ProductDetailsCoreespondingToProductName(strProduct);
                }
                if (listObj[0].Rows.Count != 0)
                {
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductId"].Value = listObj[0].Rows[0]["productId"].ToString();
                    decimal decProductId = Convert.ToDecimal(dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductId"].Value.ToString());
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value = listObj[0].Rows[0]["productCode"].ToString();
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductName"].Value = listObj[0].Rows[0]["productName"].ToString();
                    UnitComboFill(Convert.ToDecimal(listObj[0].Rows[0]["productId"].ToString()), inRowIndex, dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(listObj[0].Rows[0]["unitId"].ToString());
                    BatchComboFill(Convert.ToDecimal(listObj[0].Rows[0]["productId"].ToString()), inRowIndex, Convert.ToInt32(dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(listObj[0].Rows[0]["batchId"].ToString());
                    decimal decBatchId = Convert.ToDecimal(dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbBatch"].Value.ToString());
                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                    List<DataTable> listUnitByProduct = new List<DataTable>();
                    listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value.ToString());
                    foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                    {
                        if (dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                        {
                            dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                            dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                        }
                    }
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtRate"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[0]["salesRate"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                    decCurrentConversionRate = Convert.ToDecimal(dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                    decCurrentRate = Convert.ToDecimal(dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtRate"].Value.ToString());
                    getProductRate(inRowIndex, decProductId, decBatchId);
                }
                else
                {
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductId"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtUnitConversionId"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtConversionRate"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                    dgvSalesOrder.Rows[inRowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO : 100 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill the grid based on the condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            StockPostingBll BllStockPosting = new StockPostingBll();
            //StockPostingSP spStockPosting = new StockPostingSP();
            BatchBll BllBatch = new BatchBll();
            DataTable dtbl = new DataTable();
            try
            {
                decimal DefaultRate = 0;
                isValueChange = false;
                isDoAfterGridFill = false;
                if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "dgvtxtBarcode")
                {
                    string strBCode = string.Empty;
                    if (!dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].ReadOnly && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString() != string.Empty)
                    {
                        strBCode = dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString();
                        productDetailsFill(strBCode, dgvSalesOrder.CurrentRow.Index, "Barcode");
                    }
                }
                else if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "dgvtxtProductCode")
                {
                    isValueChange = false;
                    isDoAfterGridFill = false;
                    string strPrdCode = string.Empty;
                    if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value as string != string.Empty)
                    {
                        strPrdCode = dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                        productDetailsFill(strPrdCode, dgvSalesOrder.CurrentRow.Index, "ProductCode");
                    }
                }
                else if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "dgvtxtProductName")
                {
                    isValueChange = false;
                    string strProductName = string.Empty;
                    if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                    {
                        strProductName = dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString();
                        productDetailsFill(strProductName, dgvSalesOrder.CurrentRow.Index, "ProductName");
                    }
                }
                else if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "dgvtxtRate")
                {
                    if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value != null)
                    {
                        if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                        {
                            DefaultRate = Convert.ToDecimal(dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value);
                        }
                    }
                }
                AmountCalculation("dgvtxtQty", e.RowIndex);
                TotalAmountCalculation();
                isValueChange = true;
                isDoAfterGridFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO76" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Handling data error 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO77:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Commiting every changes of the grid cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (!dgvSalesOrder.IsCurrentCellDirty)
                {
                    dgvSalesOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO78:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the quotaion details and fill this in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbQuotationNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalesOrderDetailsIdToDelete();
            try
            {
                if ((cmbQuotationNo.SelectedValue == null ? "" : cmbQuotationNo.SelectedValue.ToString()) != string.Empty)
                {
                    if (cmbQuotationNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbQuotationNo.Text != "System.Data.DataRowView")
                    {
                        if (cmbType.Text == "NA")
                        {
                        }
                        else
                        {
                            if (cmbType.Text == "Sales Quotation")
                            {
                                FillQuotationDetails();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO79: " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SaveOrEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO80:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, "Delete"))
                {
                    DeleteFuntion();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO81:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove link button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvSalesOrder.SelectedCells.Count > 0 && dgvSalesOrder.CurrentRow != null)
                {
                    if (!dgvSalesOrder.Rows[dgvSalesOrder.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvSalesOrder.CurrentRow.Cells["dgvtxtSalesOrderDetailsId"].Value != null && dgvSalesOrder.CurrentRow.Cells["dgvtxtSalesOrderDetailsId"].Value.ToString() != "")
                                {
                                    lstArrOfRemove.Add(dgvSalesOrder.CurrentRow.Cells["dgvtxtSalesOrderDetailsId"].Value.ToString());
                                    RemoveFunction();
                                    TotalAmountCalculation();
                                }
                                else
                                {
                                    RemoveFunction();
                                    TotalAmountCalculation();
                                }
                            }
                            else
                            {
                                RemoveFunction();
                                TotalAmountCalculation();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO82:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cancel checkbox checked change, cancelling the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCancelled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCancelled.Checked && !isCheck)
                {
                    if (MessageBox.Show("Are you sure you want to cancel ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SalesOrderCancel();
                    }
                    else
                    {
                        cbxCancelled.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO83:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to activate the form controls based on settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrder_Activated(object sender, EventArgs e)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    cmbCurrency.Enabled = true;
                }
                else
                {
                    cmbCurrency.Enabled = false;
                }
                if (!ShowProductCode())
                {
                    this.dgvSalesOrder.Columns["dgvtxtProductCode"].Visible = false;
                }
                else
                {
                    this.dgvSalesOrder.Columns["dgvtxtProductCode"].Visible = true;
                }
                if (!ShowBarcode())
                {
                    this.dgvSalesOrder.Columns["dgvtxtBarcode"].Visible = false;
                }
                else
                {
                    this.dgvSalesOrder.Columns["dgvtxtBarcode"].Visible = true; ;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    dgvSalesOrder.Columns["dgvcmbBatch"].Visible = true;
                }
                else
                {
                    dgvSalesOrder.Columns["dgvcmbBatch"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    dgvSalesOrder.Columns["dgvcmbUnit"].Visible = true;
                }
                else
                {
                    dgvSalesOrder.Columns["dgvcmbUnit"].Visible = false;
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO84:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing event, checking the other opend forms status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmSalesOrderRegisterObj != null)
                {
                    frmSalesOrderRegisterObj.Enabled = true;
                    frmSalesOrderRegisterObj.GridFill();
                }
                if (frmSalesOrderReportObj != null)
                {
                    frmSalesOrderReportObj.Enabled = true;
                    frmSalesOrderReportObj.GridFill();
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                }
                if (frmvoucherProductobj != null)
                {
                    frmvoucherProductobj.Enabled = true;
                    frmvoucherProductobj.FillGrid();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO85:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbPricingLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal decBatchId = 0;
                decimal decProductId = 0;
                int inRowIndex = 0;
                if (dgvSalesOrder.Rows.Count > 1)
                {
                    foreach (DataGridViewRow dgvRow in dgvSalesOrder.Rows)
                    {
                        inRowIndex = dgvRow.Index;
                        if (dgvRow.Cells["dgvtxtProductId"].Value != null && dgvRow.Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                        {
                            if (dgvRow.Cells["dgvcmbBatch"].Value != null && dgvRow.Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvRow.Cells["dgvtxtProductId"].Value.ToString());
                                decBatchId = Convert.ToDecimal(dgvRow.Cells["dgvcmbBatch"].Value.ToString());
                                getProductRate(inRowIndex, decProductId, decBatchId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO102:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvSalesOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    CheckInvalidEntries(e);
                    if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                    {
                        if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                        {
                            if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value != null && dgvSalesOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                            {
                                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                                List<DataTable> list = new List<DataTable>();
                                list = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                                foreach (DataRow drUnitByProduct in list[0].Rows)
                                {
                                    if (dgvSalesOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                        dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                        if (isDoAfterGridFill)
                                        {
                                            decimal decNewConversionRate = Convert.ToDecimal(dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvSalesOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
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
                MessageBox.Show("SO105" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion
        #region Navigation
        /// <summary>
        /// Form keydown for Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesOrder_KeyDown(object sender, KeyEventArgs e)
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
                //.........................................CTRL+S............................//
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)//save or edit 
                {
                    cmbCashOrParty.Focus();
                    if (cmbCashOrParty.Focused)
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    btnSave_Click(sender, e);
                }
                //.........................................CTRL+D............................//
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)//Delete 
                {
                    if (btnDelete.Enabled)
                    {
                        if (cmbCashOrParty.Focused)
                        {
                            cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDown;
                        }
                        else
                        {
                            cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDownList;
                        }
                        btnDelete_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt) //Product Creation
                {
                    if (dgvSalesOrder.CurrentCell != null)
                    {
                        if (dgvSalesOrder.CurrentCell == dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"] || dgvSalesOrder.CurrentCell == dgvSalesOrder.CurrentRow.Cells["dgvtxtProductCode"])
                        {
                            SendKeys.Send("{F10}");
                            if (dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                            {
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                frmProductCreationObj.CallFromSalesOrder(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO86:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtDate.Enabled == true)
                    {
                        txtDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO87:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCashOrParty.Enabled == true)
                    {
                        cmbCashOrParty.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDate.Text == string.Empty || txtDate.SelectionStart == 0)
                    {
                        if (txtOrderNo.ReadOnly == false)
                        {
                            txtOrderNo.Focus();
                            txtOrderNo.SelectionLength = 0;
                            txtOrderNo.SelectionStart = 0;
                        }
                        else
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO88:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmLedgerPopup frmLedgerPopUpObj = new frmLedgerPopup();
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtDueDate.Enabled == true)
                    {
                        txtDueDate.Focus();
                    }
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
                    btnCashOrParty_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
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
                        frmLedgerPopupObj.CallFromSalesOrder(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryDeptors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO89:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDueDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbSalesMan.Enabled == true)
                    {
                        cmbSalesMan.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled == true)
                    {
                        if (txtDueDate.Text == string.Empty || txtDueDate.SelectionStart == 0)
                        {
                            cmbCashOrParty.Focus();
                            cmbCashOrParty.SelectionLength = 0;
                            cmbCashOrParty.SelectionStart = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO90:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbCurrency.Enabled == true)
                    {
                        cmbCurrency.Focus();
                        cmbCurrency.SelectionLength = 0;
                        cmbCurrency.SelectionStart = 0;
                    }
                    else
                    {
                        if (dgvSalesOrder.Enabled == true)
                        {
                            dgvSalesOrder.Focus();
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbQuotationNo.Visible == false)
                    {
                        cmbType.Focus();
                    }
                    else
                    {
                        cmbQuotationNo.Focus();
                        cmbQuotationNo.SelectionLength = 0;
                        cmbQuotationNo.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO91:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbType.Enabled)
                    {
                        cmbType.Focus();
                        cmbType.SelectionLength = 0;
                        cmbType.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesMan.Text == string.Empty || cmbSalesMan.SelectionStart == 0)
                    {
                        if (txtDueDate.Enabled == true)
                        {
                            txtDueDate.Focus();
                            txtDueDate.SelectionLength = 0;
                            txtDueDate.SelectionStart = 0;
                        }
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
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
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbSalesMan.SelectedIndex > -1)
                    {
                        frmEmployeePopupObj.CallFromSalesOrder(this, Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select salesman");
                        cmbSalesMan.Focus();
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnSalesMan_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO92:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbType.Text == "NA")
                    {
                        cmbPricingLevel.Focus();
                    }
                    if (cmbQuotationNo.Enabled)
                    {
                        cmbQuotationNo.Focus();
                        cmbQuotationNo.SelectionLength = 0;
                        cmbQuotationNo.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                        cmbSalesMan.SelectionLength = 0;
                        cmbSalesMan.SelectionStart = 0;
                    }
                    else
                    {
                        cmbPricingLevel.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO93:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbQuotationNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPricingLevel.Enabled == true)
                    {
                        cmbPricingLevel.Focus();
                        cmbPricingLevel.SelectionLength = 0;
                        cmbPricingLevel.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbType.Enabled == true)
                    {
                        cmbType.Focus();
                        cmbType.SelectionLength = 0;
                        cmbType.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO94:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int indgvSalesOrderRowCount = dgvSalesOrder.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesOrder.CurrentCell == dgvSalesOrder.Rows[indgvSalesOrderRowCount - 1].Cells["dgvtxtAmount"])
                    {
                        e.Handled = true;
                        SendKeys.Send("{tab}");
                        dgvSalesOrder.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvSalesOrder.CurrentCell == dgvSalesOrder.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        if (cmbCurrency.Enabled)
                        {
                            cmbCurrency.Focus();
                        }
                        else if (cmbPricingLevel.Enabled)
                        {
                            cmbPricingLevel.Focus();
                        }
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvSalesOrder.Columns[dgvSalesOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        if (dgvSalesOrder.CurrentRow.Cells["dgvtxtProductCode"].Value != null || dgvSalesOrder.CurrentRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            frmProductSearchPopupObj.CallFromSalesOrder(this, dgvSalesOrder.CurrentRow.Index, dgvSalesOrder.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString());
                        }
                        else
                        {
                            frmProductSearchPopupObj.CallFromSalesOrder(this, dgvSalesOrder.CurrentRow.Index, string.Empty);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO95:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCancelled_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxPrintAfterSave.Enabled)
                    {
                        cbxPrintAfterSave.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO96:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cbxCancelled.Enabled)
                    {
                        cbxCancelled.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO97:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnClear.Enabled == true)
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
                MessageBox.Show("SO98:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnDelete.Enabled == true)
                    {
                        btnDelete.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnSave.Enabled == true)
                    {
                        btnSave.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO99:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnClose.Enabled == true)
                    {
                        btnClose.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnClear.Enabled == true)
                    {
                        btnClear.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO100:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (btnDelete.Enabled == true)
                    {
                        btnDelete.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO101:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (cbxCancelled.Enabled)
                        {
                            cbxCancelled.Focus();
                        }
                        else
                        {
                            cbxPrintAfterSave.Focus();
                        }
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
                        dgvSalesOrder.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO102:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesOrder.Enabled == true)
                    {
                        dgvSalesOrder.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPricingLevel.Enabled == true)
                    {
                        if (txtDueDays.Text == string.Empty || txtDueDays.SelectionStart == 0)
                        {
                            cmbPricingLevel.Focus();
                            cmbPricingLevel.SelectionLength = 0;
                            cmbPricingLevel.SelectionStart = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SO103:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
