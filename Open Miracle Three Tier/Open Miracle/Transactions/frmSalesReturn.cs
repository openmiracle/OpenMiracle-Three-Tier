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
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmSalesReturn : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decinvoiceno = 0;
        decimal decSalesReturnVoucherTypeId = 0;
        decimal decSalesReturnSuffixPrefixId = 0;
        bool isSalesReturnFormActive = false;
        bool isAutomatic = false;
        static bool isEnterIntoComboSelectn = false;
        string strVoucherNo = string.Empty;
        string strCashOrPartyAccount = string.Empty;
        string strPricinglevel;
        string strSalesMan;
        string strSalesAccount;
        string strSalesReturnIdToEdit = string.Empty;
        string strProductCode = string.Empty;
        decimal salesReturnMasterId = 0;
        decimal decQty = 0;
        decimal decRate = 0;
        bool isFromSalesReturnRegister = false;
        bool isFromSalesReturnReport = false;
        decimal decTotalAmounForSaveCheck = 0;
        decimal decTotal = 0;
        decimal decProductId = 0;
        decimal decExchangeRate = 0;
        decimal decAgainstVoucherTypeId = 0;
        decimal decTotalBillTaxAmount = 0;
        decimal decTotalCessTaxamount = 0;
        string strAgainstVoucherNo = string.Empty;
        string strAgainstInvoiceNo = string.Empty;
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        VoucherTypeBll BllVoucherType = new VoucherTypeBll();
        SettingsBll BllSettings = new SettingsBll();
        ArrayList lstArrOfRemove = new ArrayList();
        string strTaxRate = string.Empty;       
        ProductCreationBll BllProductCreation = new ProductCreationBll();
        CheckUserPrivilege checkuserprivilege = new CheckUserPrivilege();
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        ProductInfo infoProduct = new ProductInfo();
        SalesMasterInfo infoSalesMaster = new SalesMasterInfo();
        //SalesDetailsSP spSalesDetails = new SalesDetailsSP();
        SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
        frmSalesReturnRegister objFromSalesReturnRegister = null;
        //SalesMasterSP spSalesMaster = new SalesMasterSP();
        SalesReturnMasterInfo infoSalesReturnMaster = new SalesReturnMasterInfo();
        frmSalesReturnReport objFromSalesReturnReport = null;
        SalesReturnBll bllSalesReturnBill = new SalesReturnBll();
        TransactionsGeneralFillBll Obj = new TransactionsGeneralFillBll();
        frmVoucherWiseProductSearch objVoucherProduct = null;
        frmEmployeePopup frmEmployeePopUpObj = null;
        frmPriceListPopup frmPriceListPopUpObj = null;
        List<DataTable> ListObj = new List<DataTable>();
        int inIndex = 0;
        decimal decSalesReturnMasterId = 0;
        decimal decSalesReturnDetailId = 0;
        bool isInvoiceFill = false;
        bool isFromOther = false;
        bool isFromSalesAccountCombo = false;
        bool isFromCashOrPartyCombo = false;
        bool isCheckForVoucherTypeFill = false;
        bool isFiilCheck = false;
        string[] strArrOfRemove = new string[100];
        DataTable dtblUnitViewAll = new DataTable();
        TransactionsGeneralFillBll objTransactionGenerationFill = new TransactionsGeneralFillBll();
        DataTable dtblRackViewAll = new DataTable();
        DataTable dtblTaxGride = new DataTable();
        decimal decTotalAmountForEditCheck = 0;
        decimal decTotalNetAmount = 0;
        List<DataTable> dtblSalesReturnMasterViewBySMID = new List<DataTable>();
        DateValidation objDateValidation = new DateValidation();
        frmDayBook frmDayBookObj = null;
        frmAgeingReport frmAgeingObj = null;
        frmLedgerDetails frmLedgerDetailsObj = null;
        frmVoucherSearch objVoucherSearch = null;
        frmVoucherWiseProductSearch objVoucherWiseSearch = null;
        ArrayList arrlstMasterId = new ArrayList();
        int inNarrationCount = 0;
        frmProductSearchPopup frmProductSearchPopupObj;
        frmLedgerPopup frmLedgerPopUpObj = null;
        DataTable dtblSalesInvoice = new DataTable();
        public decimal decCurrentConversionRate = 0;
        public decimal decCurrentRate = 0;
        decimal DecSalesReturnVoucherTypeId = 0;
        string ManualReturnNo = string.Empty;
        #endregion
        #region Functions
        /// <summary>
        /// FunctionTofill grid in invalid enter
        /// </summary>
        public void StringEmptyDetailsInGrid()
        {
            try
            {
                dgvSalesReturn.CurrentRow.Cells["dgvTextProductCode"].Value = string.Empty;
                dgvSalesReturn.CurrentRow.Cells["dgvTextProductName"].Value = string.Empty;
                dgvSalesReturn.CurrentRow.Cells["dgvTextBarcode"].Value = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionTo delete salesDetailes
        /// </summary>
        public void GetSalesDetailsIdToDelete()
        {
            try
            {
                foreach (DataGridViewRow drow in dgvSalesReturn.Rows)
                {
                    if (drow.Cells["salesReturnDetailsId"].Value != null)
                    {
                        if (drow.Cells["salesReturnDetailsId"].Value.ToString() != string.Empty)
                        {
                            lstArrOfRemove.Add(drow.Cells["salesReturnDetailsId"].Value.ToString());
                        }
                    }
                }
                dgvSalesReturn.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /// <summary>
        /// FunctionForUnitConversionCalculation
        /// </summary>
        /// <param name="inIndexOfRow"></param>
        public void UnitConversionCalc(int inIndexOfRow)
        {
            try
            {
               
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                List<DataTable> listUnitByProduct = new List<DataTable>();
                if (dgvSalesReturn.Rows[inIndexOfRow].Cells["productId"].Value != null)
                {
                    listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvSalesReturn.Rows[inIndexOfRow].Cells["productId"].Value.ToString()
                        == string.Empty ? "0" : dgvSalesReturn.Rows[inIndexOfRow].Cells["productId"].Value.ToString());
                    foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows) 
                    {
                        if (dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvCmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                        {
                            dgvSalesReturn.Rows[inIndexOfRow].Cells["unitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                            dgvSalesReturn.Rows[inIndexOfRow].Cells["conversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                            decimal decNewConversionRate = Convert.ToDecimal(dgvSalesReturn.Rows[inIndexOfRow].Cells["conversionRate"].Value.ToString());
                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                            dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionToRemoveIncmpletedRow
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            SalesReturnBll bllSalesReturn = new SalesReturnBll();
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvSalesReturn.RowCount;
                int inLastRow = 1;
                if (inRowcount <= 2)
                {
                    if (dgvSalesReturn.Rows[0].Cells["dgvTextProductName"].Value == null || dgvSalesReturn.Rows[0].Cells["dgvTextProductName"].Value.ToString() == string.Empty ||
                        dgvSalesReturn.Rows[0].Cells["dgvTextProductCode"].Value == null || dgvSalesReturn.Rows[0].Cells["dgvTextProductCode"].Value.ToString() == string.Empty ||
                         dgvSalesReturn.Rows[0].Cells["dgvTextQty"].Value == null || dgvSalesReturn.Rows[0].Cells["dgvTextQty"].Value.ToString().Trim() == string.Empty ||
                          Convert.ToDecimal(dgvSalesReturn.Rows[0].Cells["dgvTextQty"].Value.ToString()) == 0 || dgvSalesReturn.Rows[0].Cells["dgvTextRate"].Value == null || dgvSalesReturn.Rows[0].Cells["dgvTextRate"].Value.ToString().Trim() == string.Empty ||

                        (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvSalesReturn.CurrentRow.Cells["dgvTextRate"].Value) == 0))
                    {
                        MessageBox.Show("Can't save purchase return without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSalesReturn.ClearSelection();
                        dgvSalesReturn.Focus();
                        isOk = false;
                    }
                }
                else
                {
                    foreach (DataGridViewRow dgvrowCur in dgvSalesReturn.Rows)
                    {
                        if (inLastRow < inRowcount)
                        {
                            if (dgvrowCur.HeaderCell.Value != null)
                            {
                                if (dgvrowCur.HeaderCell.Value.ToString() == "X" || dgvrowCur.Cells["dgvTextProductName"].Value == null)
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
                            for (int inK = 0; inK < dgvSalesReturn.Rows.Count; inK++)
                            {
                                if (dgvSalesReturn.Rows[inK].HeaderCell.Value != null && dgvSalesReturn.Rows[inK].HeaderCell.Value.ToString() == "X")
                                {
                                    if (!dgvSalesReturn.Rows[inK].IsNewRow)
                                    {
                                        dgvSalesReturn.Rows.RemoveAt(inK);
                                        inK--;

                                    }
                                }
                            }
                        }
                        else
                        {
                            isOk = false;
                            dgvSalesReturn.Rows[inForFirst].Cells["dgvTextProductName"].Selected = true;
                            dgvSalesReturn.CurrentCell = dgvSalesReturn.Rows[inForFirst].Cells["dgvTextProductName"];
                            dgvSalesReturn.Focus();
                        }
                    }
                }
                //SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Create an instance for frmSalesReturn class
        /// </summary>
        public frmSalesReturn()
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
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                decSalesReturnVoucherTypeId = decVoucherTypeId;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decSalesReturnVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decSalesReturnVoucherTypeId, dtpDate.Value);
                decSalesReturnSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
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
                MessageBox.Show("SR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use calculate the net amount in grid
        /// </summary>
        /// <returns></returns>
        public decimal TotalNetAmountFromSRGride()
        {
            try
            {
                decTotalNetAmount = 0;
                foreach (DataGridViewRow drowDetails in dgvSalesReturn.Rows)
                {
                    if (drowDetails.Cells["dgvTextNetValue"].Value != null)
                    {
                        decTotalNetAmount = decTotalNetAmount + Convert.ToDecimal(drowDetails.Cells["dgvTextNetValue"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decTotalNetAmount;
        }
        /// <summary>
        /// function to get the product rate based on the batch
        /// </summary>
        /// <param name="index"></param>
        /// <param name="decProductId"></param>
        /// <param name="decBatchId"></param>
        public void getProductRate(int index, decimal decProductId, decimal decBatchId)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            decimal decPricingLevelId = 0;
            decimal decRateForPricingLevel = 0;
            try
            {
                DateTime dtcurrentDate = PublicVariables._dtCurrentDate;
                decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                decPricingLevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                decRateForPricingLevel = BllProductCreation.SalesInvoiceProductRateForSales(decProductId, dtcurrentDate, decBatchId, decPricingLevelId, decNodecplaces);
                infoProduct = BllProductCreation.ProductView(decProductId);
                dgvSalesReturn.Rows[index].Cells["dgvCmbUnit"].Value = infoProduct.UnitId;
                dgvSalesReturn.Rows[index].Cells["dgvTextRate"].Value = decRateForPricingLevel;
                decRate = decRateForPricingLevel;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR7: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill product Details while return from Product creation when creating new Product 
        /// </summary>
        /// <param name="decProductId"></param>
        public void ReturnFromProductCreation(decimal decProductId)
        {
            frmProductCreation productcreation = new frmProductCreation();
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                int inI = dgvSalesReturn.CurrentRow.Index;
                this.Enabled = true;

                if (decProductId != 0)
                {

                    infoProduct = BllProductCreation.ProductView(decProductId);
                    strProductCode = infoProduct.ProductCode;
                    ProductDetailsFill(strProductCode, inI, "dgvTextProductCode");
                }
                dgvSalesReturn.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("SR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherWiseProductSearch to view details and for updation
        /// </summary>
        /// <param name="frmVoucherwiseProductSearch"></param>
        /// <param name="decmasterId"></param>
        /// <param name="isFromRegister"></param>
        public void CallFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherwiseProductSearch, decimal decmasterId, bool isFromRegister)
        {
            try
            {
                base.Show();
                frmVoucherwiseProductSearch.Enabled = true;
                objVoucherProduct = frmVoucherwiseProductSearch;
                salesReturnMasterId = decmasterId;
                isFromSalesReturnRegister = isFromRegister;
                isInvoiceFill = true;
                decTotalAmountForEditCheck = 0;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to add LedegrPosting For Tax
        /// </summary>
        public void LedegrPostingForTax()
        {
            try
            {
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                infoLedgerPosting.Date = infoSalesReturnMaster.Date;
                infoLedgerPosting.ChequeDate = infoSalesReturnMaster.Date;
                infoLedgerPosting.ChequeNo = String.Empty;
                infoLedgerPosting.VoucherTypeId = infoSalesReturnMaster.VoucherTypeId;
                infoLedgerPosting.VoucherNo = infoSalesReturnMaster.VoucherNo;
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.InvoiceNo = infoSalesReturnMaster.InvoiceNo;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                foreach (DataGridViewRow drowDetails in dgvSalesReturn2.Rows)
                {
                    if (drowDetails.Cells["dgvTextTaxId"].Value != null)
                    {
                        infoLedgerPosting.LedgerId = Convert.ToDecimal(drowDetails.Cells["dgvTextTaxId"].Value.ToString());
                        infoLedgerPosting.Debit = Convert.ToDecimal(drowDetails.Cells["dgvTextAmount"].Value.ToString()) * decExchangeRate;
                        infoLedgerPosting.Credit = 0;
                        if (infoLedgerPosting.Debit != 0)
                        {
                            BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                this.Enabled = true;
                this.frmLedgerPopUpObj = frmLedgerPopup;
                if (strComboTypes == "CashOrSundryCreditors")
                {
                    CashOrPartyUnderSundryDebitorComboFill(cmbCashOrParty);
                    cmbCashOrParty.SelectedValue = decId;
                }
                else if (strComboTypes == "SalesAccountLedger")
                {
                    SalesAccountComboFill(cmbSalesAccount);
                    cmbSalesAccount.SelectedValue = decId;
                }
                frmLedgerPopUpObj.Close();
                frmLedgerPopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the combobox invoice no
        /// </summary>
        public void cmbInvoiceComboFill()
        {
            try
            {
                if (cmbVoucherType.SelectedIndex != -1)
                {
                    if (cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView" && isFiilCheck)
                    {
                        cmbInvoiceNo.Text = string.Empty;
                        cmbSalesAccount.SelectedIndex = -1;
                        cmbSalesMan.SelectedIndex = 1;
                        cmbPricingLevel.Enabled = true;
                        cmbSalesAccount.Enabled = true;
                        cmbSalesMan.Enabled = true;
                        isEnterIntoComboSelectn = false;
                        SalesReturnInvoiceNoComboFill(Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()), salesReturnMasterId, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the combobox under the vouchertype
        /// </summary>
        public void cmbVoucherTypeComboFill()
        {
            try
            {
                if (isCheckForVoucherTypeFill)
                {
                    if (cmbCashOrParty.SelectedIndex != -1)
                    {
                        if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView" && isFiilCheck)
                        {
                            cmbInvoiceNo.Text = string.Empty;
                            isEnterIntoComboSelectn = false;
                            cmbPricingLevel.Enabled = true;
                            cmbSalesAccount.Enabled = true;
                            cmbSalesMan.Enabled = true;
                            SalesReturnVoucherTypeComboFill(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// AutoCompletion of ProductName And productCode
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionTocheckNegativebalance
        /// </summary>
        /// <returns></returns>
        public bool CheckNegativeBalance()
        {
            bool isOk = false;
            try
            {
                
                decimal decProductId = 0;
                decimal decBatchId = 0;
                decimal decCalcQty = 0;
                StockPostingBll BllStockPosting = new StockPostingBll();               
                SettingsBll BllSettings = new SettingsBll();
                string strStatus = BllSettings.SettingsStatusCheck("NegativeStockStatus");
                bool isNegativeLedger = false;
                int inRowCount = dgvSalesReturn.RowCount;
                if (inRowCount > 1)
                {
                    for (int i = 0; i < inRowCount - 1; i++)
                    {
                        if (dgvSalesReturn.Rows[i].Cells["productId"].Value != null && dgvSalesReturn.Rows[i].Cells["productId"].Value.ToString() != string.Empty)
                        {
                            decProductId = Convert.ToDecimal(dgvSalesReturn.Rows[i].Cells["productId"].Value.ToString());
                            if (dgvSalesReturn.Rows[i].Cells["dgvCmbBatch"].Value != null && dgvSalesReturn.Rows[i].Cells["dgvCmbBatch"].Value.ToString() != string.Empty)
                            {
                                decBatchId = Convert.ToDecimal(dgvSalesReturn.Rows[i].Cells["dgvCmbBatch"].Value.ToString());
                            }
                            decimal decCurrentStock = BllStockPosting.StockCheckForProductSale(decProductId, decBatchId);
                            if (dgvSalesReturn.Rows[i].Cells["dgvTextQty"].Value != null && dgvSalesReturn.Rows[i].Cells["dgvTextQty"].Value.ToString() != string.Empty)
                            {
                                decCalcQty = decCurrentStock - Convert.ToDecimal(dgvSalesReturn.Rows[i].Cells["dgvTextQty"].Value.ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show("SR15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
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
                SalesManComboFill(cmbSalesMan);
                cmbSalesMan.SelectedValue = decId;
                cmbSalesMan.Focus();
                frmEmployeePopUpObj.Close();
                frmEmployeePopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmPriceListPopup form to select and view Pricelist
        /// </summary>
        /// <param name="frmPriceListPopup"></param>
        /// <param name="decId"></param>
        public void CallPriceListPopUp(frmPriceListPopup frmPriceListPopup, decimal decId)
        {
            try
            {
                base.Show();
                this.frmPriceListPopUpObj = frmPriceListPopup;
                PrlicingLevelComboFill(cmbPricingLevel);
                cmbPricingLevel.SelectedValue = decId;
                cmbPricingLevel.Focus();
                frmPriceListPopup.Close();
                frmPriceListPopup = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Save or edit and checking the invalid entries
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, "frmSalesReturn", (strSalesReturnIdToEdit == "" ? "Save" : "Edit")) == true)
                {
                    if (RemoveIncompleteRowsFromGrid())
                    {
                        if (CheckNegativeBalance())
                        {
                            if (btnSave.Text == "Save")
                            {
                                if (Messages.SaveConfirmation())
                                {
                                    Save();
                                }
                            }
                            else
                            {
                                if (Messages.UpdateConfirmation())
                                {
                                    Save();
                                }
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
                MessageBox.Show("SR18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Total amount calculation
        /// </summary>
        public void TotalBillTaxCalculation()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TotalBillTaxCalculationBtapplicableOn();
                foreach (DataRow drowItem in ListObj[0].Rows)
                {
                    if (drowItem != null)
                    {
                        foreach (DataGridViewRow dgvrItem in dgvSalesReturn2.Rows)
                        {
                            if (dgvrItem.Cells["dgvTextTaxId"].Value != null)
                            {
                                if (dgvrItem.Cells["dgvTextTaxId"].Value.ToString() == drowItem["taxId"].ToString())
                                {
                                    if (txtTotalAmount.Text != string.Empty)
                                    {
                                        dgvrItem.Cells["dgvTextAmount"].Value = Math.Round((Convert.ToDecimal(drowItem["rate"].ToString()) * Convert.ToDecimal(txtTotalAmount.Text)) / 100, PublicVariables._inNoOfDecimalPlaces);
                                        decTotalBillTaxAmount = Math.Round(Convert.ToDecimal(dgvrItem.Cells["dgvTextAmount"].Value.ToString()), PublicVariables._inNoOfDecimalPlaces);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionTOcheckInvalidEntries
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                if (dgvSalesReturn.CurrentRow != null)
                {
                    if (dgvSalesReturn.CurrentRow.Cells["dgvTextProductName"].Value == null || dgvSalesReturn.CurrentRow.Cells["dgvTextProductName"].Value.ToString().Trim() == string.Empty)
                    {
                        dgvSalesReturn.CurrentRow.HeaderCell.Value = "X";
                        dgvSalesReturn.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                    }
                    else if (dgvSalesReturn.CurrentRow.Cells["dgvTextQty"].Value == null || dgvSalesReturn.CurrentRow.Cells["dgvTextQty"].Value.ToString().Trim() == string.Empty || Convert.ToDecimal(dgvSalesReturn.CurrentRow.Cells["dgvTextQty"].Value) == 0)
                    {
                        dgvSalesReturn.CurrentRow.HeaderCell.Value = "X";
                        dgvSalesReturn.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                    }
                    else if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvSalesReturn.CurrentRow.Cells["dgvTextRate"].Value) == 0)
                    {
                        dgvSalesReturn.CurrentRow.HeaderCell.Value = "X";
                        dgvSalesReturn.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgvSalesReturn.CurrentRow.HeaderCell.Value = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the print after save checkbox status
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
                MessageBox.Show("SI21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        /// <summary>
        /// The form controls will be reset here
        /// </summary>

        public void clear()
        {
            try
            {
                if (isAutomatic || !isAutomatic)
                {
                    VoucherNumberGeneration();
                    txtDate.Focus();
                }
                else
                {
                    txtReturnNo.Text = string.Empty;
                    txtReturnNo.ReadOnly = false;
                }
                isCheckForVoucherTypeFill = false;
                CashOrPartyUnderSundryDebitorComboFill(cmbCashOrParty);
                VoucherTypeCombofill();
                PrlicingLevelComboFill(cmbPricingLevel);
                SalesManComboFill(cmbSalesMan);
                SalesAccountComboFill(cmbSalesAccount);
                TaxGridFill();
                if (objFromSalesReturnRegister == null && objFromSalesReturnReport == null)
                {
                    DGVSalesReturn2Fill();
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.Value = PublicVariables._dtCurrentDate;
                txtDate.Text = dtpDate.Value.ToString("dd-MMM-yyyy");
                cmbCashOrParty.SelectedIndex = 0;
                cmbSalesAccount.SelectedIndex = 0;
                cmbPricingLevel.SelectedIndex = 0;
                cmbSalesMan.SelectedIndex = 1;
                cmbVoucherType.SelectedIndex = 0;
                txtBillDiscount.Clear();
                txtGrandTotal.Clear();
                txtNarration.Clear();
                txtTotalAmount.Clear();
                txtTransportationComp.Clear();
                DGVCurrencyComboFill();
                //cmbCurrency.SelectedIndex = 0;
                dgvSalesReturn.Rows.Clear();
                txtLRNo.Clear();
                txtDate.Focus();
                btnDelete.Enabled = false;
                lblTaxAmount.Text = "0.00";
                txtBillDiscount.Text = "0";
                txtTotalAmount.Text = "0";
                txtGrandTotal.Text = "0";
                decTotalAmounForSaveCheck = 0;
                decTotalAmountForEditCheck = 0;
                decRate = 0;
                cmbSalesAccount.Enabled = true;
                cmbSalesMan.Enabled = true;
                cmbPricingLevel.Enabled = true;
                cmbInvoiceNo.Text = string.Empty;
                btnSave.Text = "Save";
                dtblSalesInvoice.Rows.Clear();
                label6.Visible = false;
                cmbInvoiceNo.Visible = false;
                salesReturnMasterId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.objVoucherSearch = frm;
                salesReturnMasterId = decId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmProductSearchPopup form to select and view Products
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                ProductInfo infoProduct = new ProductInfo();
                base.Show();
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                infoProduct = BllProductCreation.ProductView(decproductId);
                int inRowcount = dgvSalesReturn.Rows.Count;
                if (dgvSalesReturn.CurrentRow.Index == dgvSalesReturn.Rows.Count - 1)
                {
                    dgvSalesReturn.Rows.Add();
                }
                for (int i = 0; i < inRowcount; i++)
                {
                    if (i == decCurrentRowIndex)
                    {
                        dgvSalesReturn.Rows[i].Cells["dgvTextProductCode"].Value = infoProduct.ProductCode;
                        strProductCode = infoProduct.ProductCode;
                        ProductDetailsFill(strProductCode, i, "dgvTextProductCode");
                    }
                }
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesReturnRegister to view details and for updation
        /// </summary>
        /// <param name="objSalesReturnRegister"></param>
        /// <param name="decSalesReturnMasterId"></param>
        /// <param name="isFromRegister"></param>
        /// <param name="isSalesReturnActive"></param>
        public void CallFromSalesReturnRegister(frmSalesReturnRegister objSalesReturnRegister, decimal decSalesReturnMasterId, bool isFromRegister, bool isSalesReturnActive)
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isSalesReturnFormActive = isSalesReturnActive;
                objFromSalesReturnRegister = objSalesReturnRegister;
                objFromSalesReturnReport = null;
                salesReturnMasterId = decSalesReturnMasterId;
                isFromSalesReturnRegister = isFromRegister;
                isInvoiceFill = true;
                decTotalAmountForEditCheck = 0;
                FillRegisterOrReport();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decSalesReturnVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesReturnReport to view details and for updation
        /// </summary>
        /// <param name="objSalesReturnReport"></param>
        /// <param name="decSalesReturnMasterId"></param>
        /// <param name="isFromReport"></param>
        /// <param name="isSalesReturnActive"></param>
        public void CallFromSalesReturnReport(frmSalesReturnReport objSalesReturnReport, decimal decSalesReturnMasterId, bool isFromReport, bool isSalesReturnActive)
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isSalesReturnFormActive = isSalesReturnActive;
                objFromSalesReturnReport = objSalesReturnReport;
                objFromSalesReturnRegister = null;
                salesReturnMasterId = decSalesReturnMasterId;
                isFromSalesReturnReport = isFromReport;
                isInvoiceFill = true;
                decTotalAmountForEditCheck = 0;
                FillRegisterOrReport();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decSalesReturnVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to view the all values in the controls for updations
        /// </summary>
        /// 
        public void UnitComboFill(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAllByProductId(decProductId);
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvSalesReturn.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionToreturn fromregisterclick
        /// </summary>
        public void FillRegisterOrReport()
        {
            SalesReturnBll bllSalesReturn = new SalesReturnBll();
            try
            {
                isFromOther = true;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                CashOrPartyUnderSundryDebitorComboFill(cmbCashOrParty);
                DataTable dtblSalesMaster = new DataTable();
                List<DataTable> ListObjMaster = new List<DataTable>();
                ListObjMaster = bllSalesReturn.SalesReturnMasterViewBySalesReturnMasterId(salesReturnMasterId);
                decSalesReturnMasterId = salesReturnMasterId;
                DecSalesReturnVoucherTypeId = Convert.ToDecimal(ListObjMaster[0].Rows[0]["voucherTypeId"].ToString());
                VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                infoVoucherType = BllVoucherType.VoucherTypeView(DecSalesReturnVoucherTypeId);
                this.Text = infoVoucherType.VoucherTypeName;
                if (infoVoucherType.MethodOfVoucherNumbering == "Manual")
                {
                    txtReturnNo.Text = ListObjMaster[0].Rows[0]["invoiceNo"].ToString();
                    ManualReturnNo = ListObjMaster[0].Rows[0]["invoiceNo"].ToString();
                    txtReturnNo.Enabled = true;
                }
                else
                {
                    txtReturnNo.Text = ListObjMaster[0].Rows[0]["invoiceNo"].ToString();
                    txtReturnNo.Enabled = false;
                }
                if (ListObjMaster[0].Rows.Count > 0)
                {
                    txtDate.Text = ListObjMaster[0].Rows[0]["date"].ToString();
                    dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                    if (ListObjMaster[0].Rows[0]["grandTotal"].ToString() != string.Empty)
                    {
                        txtGrandTotal.Text = ListObjMaster[0].Rows[0]["grandTotal"].ToString();
                    }
                    strVoucherNo = ListObjMaster[0].Rows[0]["voucherNo"].ToString();
                    if (ListObjMaster[0].Rows[0]["ledgerId"].ToString() != string.Empty)
                    {
                        cmbCashOrParty.SelectedValue = ListObjMaster[0].Rows[0]["ledgerId"].ToString();
                    }
                    cmbVoucherTypeComboFill();
                    if (ListObjMaster[0].Rows[0]["SMVoucherTypeId"].ToString() != string.Empty)
                    {
                        cmbVoucherType.SelectedValue = ListObjMaster[0].Rows[0]["SMVoucherTypeId"].ToString();
                    }
                    else
                    {
                        cmbVoucherType.SelectedValue = 0;
                    }
                    cmbInvoiceComboFill();
                    if (ListObjMaster[0].Rows[0]["pricingLevelId"].ToString() != string.Empty)
                    {
                        cmbPricingLevel.SelectedValue = ListObjMaster[0].Rows[0]["pricingLevelId"].ToString();
                    }
                    if (ListObjMaster[0].Rows[0]["salesAccount"].ToString() != string.Empty)
                    {
                        cmbSalesAccount.SelectedValue = ListObjMaster[0].Rows[0]["salesAccount"].ToString();
                    }
                    if (ListObjMaster[0].Rows[0]["employeeId"].ToString() != string.Empty)
                    {
                        cmbSalesMan.SelectedValue = ListObjMaster[0].Rows[0]["employeeId"].ToString();
                    }
                    if (ListObjMaster[0].Rows[0]["exchangeRateId"].ToString() != string.Empty)
                    {
                        cmbCurrency.SelectedValue = ListObjMaster[0].Rows[0]["exchangeRateId"].ToString();
                    }
                    txtNarration.Text = ListObjMaster[0].Rows[0]["narration"].ToString();
                    txtLRNo.Text = ListObjMaster[0].Rows[0]["lrNo"].ToString();
                    txtTransportationComp.Text = ListObjMaster[0].Rows[0]["transportationCompany"].ToString();
                    if (ListObjMaster[0].Rows[0]["salesMasterId"].ToString() != string.Empty && Convert.ToDecimal(ListObjMaster[0].Rows[0]["salesMasterId"].ToString()) != 0)
                    {
                        cmbInvoiceNo.SelectedValue = ListObjMaster[0].Rows[0]["salesMasterId"].ToString();
                        decinvoiceno = Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString());
                        dtblSalesReturnMasterViewBySMID = bllSalesReturn.SalesReturnMasterViewBySalesMasterId(Convert.ToDecimal(ListObjMaster[0].Rows[0]["salesMasterId"].ToString()));
                    }
                    isInvoiceFill = false;
                    if (ListObjMaster[0].Rows[0]["voucherTypeId"].ToString() != string.Empty)
                    {
                        decSalesReturnVoucherTypeId = Convert.ToDecimal(ListObjMaster[0].Rows[0]["voucherTypeId"].ToString());
                    }
                    TaxGridFill();
                    if (cmbInvoiceNo.SelectedValue != null)
                    {
                        infoSalesMaster = BllSalesInvoice.SalesMasterViewBySalesMasterId(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()));
                    }
                    List<DataTable> ListObj1 = new List<DataTable>();
                    ListObj1 = bllSalesReturn.SalesReturnDetailsViewBySalesReturnMasterId(salesReturnMasterId);
                    dtblSalesInvoice = ListObj1[0];
                    foreach (DataRow drowDetails in ListObj1[0].Rows)
                    {
                        dgvSalesReturn.Rows.Add();
                        if (drowDetails["salesReturnDetailsId"].ToString() != string.Empty)
                        {
                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["salesReturnDetailsId"].Value = Convert.ToDecimal(drowDetails["salesReturnDetailsId"].ToString());
                        }
                        if (drowDetails["salesDetailsId"].ToString() != string.Empty)
                        {
                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["salesDetailsId"].Value = drowDetails["salesDetailsId"].ToString();
                        }
                        else
                        {
                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["salesDetailsId"].Value = 0;
                        }
                        if (drowDetails["productId"].ToString() != string.Empty)
                        {
                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["productId"].Value = drowDetails["productId"].ToString();
                            List<DataTable> listObj = BllSalesInvoice.SalesReturnGrideFillNewByProductId(Convert.ToDecimal(drowDetails["productId"].ToString()));
                            foreach (DataRow drowDetails1 in listObj[0].Rows)
                            {
                                if (drowDetails1["barcode"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextBarcode"].Value = drowDetails1["barcode"].ToString();
                                }
                                if (drowDetails1["productCode"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextProductCode"].Value = drowDetails1["productCode"].ToString();
                                }
                                if (drowDetails1["productName"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextProductName"].Value = drowDetails1["productName"].ToString();
                                }
                                if (cmbInvoiceNo.Visible == true)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].ReadOnly = true;
                                }
                                if (drowDetails["unitId"].ToString() != string.Empty)
                                {
                                    decProductId = decimal.Parse(dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["productId"].Value.ToString());
                                    UnitComboFill(decProductId, dgvSalesReturn.Rows.Count - 2, dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].ColumnIndex);
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].Value = 1;
                                }
                                if (drowDetails["goDownId"].ToString() != string.Empty)
                                {
                                    DGVGodownComboFill();
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].Value = Convert.ToDecimal(drowDetails["goDownId"].ToString());
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].Value = 1;
                                }
                                if (drowDetails["rackId"].ToString() != string.Empty)
                                {
                                    RackComboFill(Convert.ToDecimal(dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].Value.ToString()), dgvSalesReturn.Rows.Count - 2, dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbRack"].ColumnIndex);
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbRack"].Value = Convert.ToDecimal(drowDetails["rackId"].ToString());
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbRack"].Value = 1;
                                }
                                if (drowDetails["batchId"].ToString() != string.Empty)
                                {
                                    BatchComboFill(decProductId, dgvSalesReturn.Rows.Count - 2, dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbBatch"].ColumnIndex);
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                                }
                                if (drowDetails["unitConversionId"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["unitConversionId"].Value = drowDetails["unitConversionId"].ToString();
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["unitConversionId"].Value = 0;
                                }
                                if (ListObjMaster[0].Rows[0]["SMVoucherTypeId"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbBatch"].ReadOnly = true;
                                }
                                if (drowDetails["taxId"].ToString() != string.Empty)
                                {
                                    if (Convert.ToDecimal(drowDetails["taxId"].ToString()) != 0)
                                    {
                                        dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTaxId"].Value = Convert.ToDecimal(drowDetails["taxId"].ToString());
                                        dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value = Convert.ToDecimal(drowDetails["taxId"].ToString());
                                        strTaxRate = bllSalesReturn.TaxRateFindForTaxAmmountCalByTaxId(Convert.ToDecimal(drowDetails["taxId"].ToString()));
                                    }
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value = 1;
                                }
                                if (drowDetails["qty"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextQty"].Value = Math.Round(Convert.ToDecimal(drowDetails["qty"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                    decQty = Math.Round(Convert.ToDecimal(drowDetails["qty"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextQty"].Value = 0.00;
                                    decQty = 0;
                                }
                                if (drowDetails["rate"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextRate"].Value = Math.Round(Convert.ToDecimal(drowDetails["rate"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                    decRate = Convert.ToDecimal(drowDetails["rate"].ToString());
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextRate"].Value = 0.00;
                                    decRate = 0;
                                }
                                if (drowDetails["grossAmount"].ToString() != string.Empty)
                                {
                                    //dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = false;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].Value = Math.Round(Convert.ToDecimal(drowDetails["grossAmount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                    // dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = true;
                                }
                                else
                                {
                                    //dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = false;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].Value = 0.00;
                                    //dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = true;
                                }
                                if (drowDetails["discount"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextDiscountPercentage"].Value = 0.00;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextDiscountAmount"].Value = Math.Round(Convert.ToDecimal(drowDetails["discount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextDiscountAmount"].Value = 0.00;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextDiscountPercentage"].Value = 0.00;
                                }
                                if (drowDetails["netAmount"].ToString() != string.Empty)
                                {
                                    // dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = false;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].Value = Math.Round(Convert.ToDecimal(drowDetails["netAmount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                    //  dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = true;
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = false;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].Value = 0.00;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = true;
                                }
                                if (drowDetails["taxAmount"].ToString() != string.Empty)
                                {
                                    //dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].ReadOnly = false;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].Value = Math.Round(Convert.ToDecimal(drowDetails["taxAmount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                    //dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].ReadOnly = true;
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].Value = 0.00;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].ReadOnly = true;
                                }
                                if (drowDetails["amount"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].Value = Math.Round(Convert.ToDecimal(drowDetails["amount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].ReadOnly = true;
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].Value = 0.00;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].ReadOnly = true;
                                }
                                if (cmbInvoiceNo.Visible == true)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextBarcode"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextProductCode"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextProductName"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextQty"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbUnit"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbGodown"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbRack"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbBatch"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextRate"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextDiscountPercentage"].ReadOnly = true;
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbTax"].ReadOnly = true;
                                }
                                dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["conversionRate"].Value = drowDetails["conversionRate"].ToString();
                                foreach (DataGridViewRow item1 in dgvSalesReturn2.Rows)
                                {
                                    if (item1.Cells["dgvTextTaxId"].Value != null)
                                    {
                                        if (dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value.ToString() == item1.Cells["dgvTextTaxId"].Value.ToString())
                                        {
                                            item1.Cells["dgvTextAmount"].Value = dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].Value;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["productId"].Value = 0;
                        }
                        TotalAmountCalculation();
                    }
                    if (!isSalesReturnFormActive)
                    {
                        ListObj = bllSalesReturnBill.TaxDetailsViewBySalesReturnMasterId(salesReturnMasterId);
                        foreach (DataRow item1 in ListObj[0].Rows)
                        {
                            dgvSalesReturn2.Rows.Add();
                            dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvTextTaxName"].Value = item1["taxName"].ToString();
                            dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvTextAmount"].Value = Math.Round(Convert.ToDecimal(item1["taxAmount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                            dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvRate"].Value = item1["rate"].ToString();
                            dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvTextTaxId"].Value = item1["taxId"].ToString();
                        }
                    }
                    txtBillDiscount.Text = Convert.ToString(Math.Round(Convert.ToDecimal(ListObjMaster[0].Rows[0]["discount"].ToString()), PublicVariables._inNoOfDecimalPlaces));
                    SerialNo2();

                    TotalBillTaxCalculation();
                    CessTaxamountCalculation();
                    TotalTaxAmtCalculation();
                    if (txtBillDiscount.Text != string.Empty)
                    {
                        decimal decDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                        decimal decTotalAmt = Convert.ToDecimal(txtTotalAmount.Text);
                        if (decTotalAmt > decDiscount)
                        {
                            decimal decGrandTotal = decTotalAmt + decTotalBillTaxAmount + decTotalCessTaxamount - decDiscount;
                            decGrandTotal = Math.Round(decGrandTotal, PublicVariables._inNoOfDecimalPlaces);
                            txtGrandTotal.Text = decGrandTotal.ToString();
                        }
                    }
                    // SerialNo();
                }
                else
                {
                    MessageBox.Show("No record exists", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the controls while updating
        /// </summary>
        public void ClearToCallFromSaesReturnRegister()
        {
            try
            {
                CashOrPartyUnderSundryDebitorComboFill(cmbCashOrParty);
                PrlicingLevelComboFill(cmbPricingLevel);
                SalesManComboFill(cmbSalesMan);
                SalesAccountComboFill(cmbSalesAccount);
                TaxGridFill();
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.Value = PublicVariables._dtCurrentDate;
                cmbCashOrParty.SelectedIndex = -1;
                cmbSalesAccount.SelectedIndex = -1;
                cmbPricingLevel.SelectedIndex = -1;
                cmbSalesMan.SelectedIndex = -1;
                txtBillDiscount.Clear();
                txtGrandTotal.Clear();
                txtNarration.Clear();
                txtTotalAmount.Clear();
                txtTransportationComp.Clear();
                dgvSalesReturn.Rows.Clear();
                txtLRNo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete an item from database
        /// </summary>
        public void Delete()
        {
            try
            {
                SalesReturnBll bllSalesReturn = new SalesReturnBll();
                bllSalesReturn.SalesReturnDelete(salesReturnMasterId, decSalesReturnVoucherTypeId, strVoucherNo);
                Messages.DeletedMessage();
                if (objFromSalesReturnRegister != null)
                {
                    if (isFromOther)
                    {
                        this.Close();
                        objFromSalesReturnRegister.Enabled = true;
                        objFromSalesReturnRegister.SalesReturnGrideFill();
                    }
                }
                else if (objFromSalesReturnReport != null)
                {
                    if (isFromOther)
                    {
                        this.Close();
                        objFromSalesReturnReport.Enabled = true;
                        objFromSalesReturnReport.SalesReturnReportGrideFill();
                    }
                }
                else if (objVoucherSearch != null)
                {

                    objVoucherSearch.GridFill();
                    this.Close();
                }
                else if (frmDayBookObj != null)
                {
                    this.Close();
                }
                else
                {
                    clear();
                }
                if (frmLedgerDetailsObj != null)
                {
                    this.Close();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// print function
        /// </summary>
        /// <param name="decSalesReturnMasterId"></param>
        public void Print(decimal decSalesReturnMasterId)
        {
            try
            {
                SalesReturnBll bllSalesReturn = new SalesReturnBll();
                DataSet dsSalesReturn = bllSalesReturn.SalesReturnPrinting(decSalesReturnMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.SalesReturnPrinting(dsSalesReturn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the items in dotmatrix
        /// </summary>
        /// <param name="decSalesReturnMasterId"></param>
        public void PrintForDotMatrix(decimal decSalesReturnMasterId)
        {
            try
            {
                DataTable dtblOtherDetails = new DataTable();
                CompanyCreationBll bllCompanyCreatio = new CompanyCreationBll();
                dtblOtherDetails = bllCompanyCreatio.CompanyViewForDotMatrix();
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
                dtblGridDetails.Columns.Add("DiscountPercentage");
                dtblGridDetails.Columns.Add("GrossValue");
                dtblGridDetails.Columns.Add("Rack");
                dtblGridDetails.Columns.Add("Batch");
                dtblGridDetails.Columns.Add("Rate");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvSalesReturn.Rows)
                {
                    if (!dRow.IsNewRow)
                    {
                        DataRow dr = dtblGridDetails.NewRow();
                        dr["SlNo"] = ++inRowCount;
                        if (dRow.Cells["dgvTextBarcode"].Value != null)
                        {
                            dr["BarCode"] = dRow.Cells["dgvTextBarcode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextProductCode"].Value != null)
                        {
                            dr["ProductCode"] = dRow.Cells["dgvTextProductCode"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextProductName"].Value != null)
                        {
                            dr["ProductName"] = dRow.Cells["dgvTextProductName"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextQty"].Value != null)
                        {
                            dr["Qty"] = dRow.Cells["dgvTextQty"].Value.ToString();
                        }
                        if (dRow.Cells["dgvCmbUnit"].Value != null)
                        {
                            dr["Unit"] = dRow.Cells["dgvCmbUnit"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvCmbGodown"].Value != null)
                        {
                            dr["Godown"] = dRow.Cells["dgvCmbGodown"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvCmbRack"].Value != null)
                        {
                            dr["Rack"] = dRow.Cells["dgvCmbRack"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvCmbBatch"].Value != null)
                        {
                            dr["Batch"] = dRow.Cells["dgvCmbBatch"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvTextRate"].Value != null)
                        {
                            dr["Rate"] = dRow.Cells["dgvTextRate"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextAmount1"].Value != null)
                        {
                            dr["Amount"] = dRow.Cells["dgvTextAmount1"].Value.ToString();
                        }
                        if (dRow.Cells["dgvCmbTax"].Value != null)
                        {
                            dr["Tax"] = dRow.Cells["dgvCmbTax"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvTextTaxAmount"].Value != null)
                        {
                            dr["TaxAmount"] = dRow.Cells["dgvTextTaxAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextNetValue"].Value != null)
                        {
                            dr["NetAmount"] = dRow.Cells["dgvTextNetValue"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextDiscountAmount"].Value != null)
                        {
                            dr["DiscountAmount"] = dRow.Cells["dgvTextDiscountAmount"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextDiscountPercentage"].Value != null)
                        {
                            dr["DiscountPercentage"] = dRow.Cells["dgvTextDiscountPercentage"].Value.ToString();
                        }
                        if (dRow.Cells["dgvTextGrossValue"].Value != null)
                        {
                            dr["GrossValue"] = dRow.Cells["dgvTextGrossValue"].Value.ToString();
                        }
                        dtblGridDetails.Rows.Add(dr);
                    }
                }
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("SalesAccount");
                dtblOtherDetails.Columns.Add("SalesMan");
                dtblOtherDetails.Columns.Add("VoucherType");
                dtblOtherDetails.Columns.Add("PricingLevel");
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
                dRowOther["voucherNo"] = txtReturnNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["SalesAccount"] = cmbSalesAccount.Text;
                dRowOther["SalesMan"] = cmbSalesMan.Text;
                dRowOther["PricingLevel"] = cmbPricingLevel.Text;
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
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decSalesReturnVoucherTypeId);
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
                MessageBox.Show("SR32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to remove an item from grid
        /// </summary>
        public void RemoveFunction()
        {
            try
            {
                dgvSalesReturn.Rows.RemoveAt(dgvSalesReturn.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int index = dgvSalesReturn.CurrentRow.Index;
                string strName = dgvSalesReturn.CurrentRow.Cells["dgvTextProductName"].Value.ToString();
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    string strOther = dgvSalesReturn.Rows[inI].Cells["dgvTextProductName"].Value.ToString();
                    if (strName == strOther)
                    {
                        inCurrentIndex = dgvSalesReturn.Rows[inI].Cells["dgvTextProductName"].RowIndex;
                    }
                }
                dgvSalesReturn.Rows[inCurrentIndex].HeaderCell.Value = "";
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSame;
        }
        /// <summary>
        /// Function to calculate total amount
        /// </summary>
        public void CalculateTAmt()
        {
            try
            {
                foreach (DataGridViewRow dgvrow in dgvSalesReturn.Rows)
                {
                    if (dgvrow.Cells["dgvTextAmount1"].Value != null)
                    {
                        if (dgvrow.Cells["dgvTextAmount1"].Value.ToString() != "")
                        {
                            decTotal = decTotal + decimal.Parse(dgvrow.Cells["dgvTextAmount1"].Value.ToString());
                            txtTotalAmount.Text = decTotal.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save an item into table
        /// </summary>
        public void Save()
        {
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
          
            SalesReturnBll bllSalesReturn = new SalesReturnBll();
          
            StockPostingBll BllStockPosting = new StockPostingBll();
            StockPostingBll BllStockPostingf = new StockPostingBll();
            LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
            PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
            UnitBll bllUnit = new UnitBll();
            try
            {
                if (txtReturnNo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter return no", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReturnNo.Focus();
                }
                else if (bllSalesReturn.SalesReturnNumberCheckExistence(txtReturnNo.Text.Trim(), 0, decSalesReturnVoucherTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Return  number already exist");
                    txtReturnNo.Focus();
                }
                else if (txtDate.Text == "")
                {
                    MessageBox.Show("Select a date in between financial year", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDate.Focus();
                }
                else if (cmbCashOrParty.SelectedValue == null)
                {
                    MessageBox.Show("Select cash/party", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCashOrParty.Focus();
                }
                else if (cmbSalesAccount.SelectedValue == null)
                {
                    MessageBox.Show("Select sales account", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSalesAccount.Focus();
                }
                else if (cmbCurrency.SelectedValue == null)
                {
                    MessageBox.Show("Select currency", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCurrency.Focus();
                }
                else
                {
                    if (isAutomatic)
                    {
                        if (strVoucherNo != string.Empty)
                        {
                            infoSalesReturnMaster.VoucherNo = strVoucherNo;
                        }
                        if (txtReturnNo.Text != string.Empty)
                        {
                            infoSalesReturnMaster.InvoiceNo = txtReturnNo.Text;
                        }
                    }
                    else
                    {
                        infoSalesReturnMaster.VoucherNo = txtReturnNo.Text;
                        infoSalesReturnMaster.InvoiceNo = txtReturnNo.Text;
                    }
                    if (decSalesReturnVoucherTypeId != 0)
                    {
                        infoSalesReturnMaster.VoucherTypeId = decSalesReturnVoucherTypeId;
                    }
                    if (decSalesReturnSuffixPrefixId != 0)
                    {
                        infoSalesReturnMaster.SuffixPrefixId = decSalesReturnSuffixPrefixId;
                    }
                    if (cmbCashOrParty.SelectedValue != null)
                    {
                        infoSalesReturnMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                    }
                    if (cmbInvoiceNo.SelectedValue != null)
                    {
                        infoSalesReturnMaster.SalesMasterId = Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString());
                    }
                    else
                    {
                        infoSalesReturnMaster.SalesMasterId = 0;
                    }
                    if (cmbSalesAccount.SelectedValue != null)
                    {
                        infoSalesReturnMaster.SalesAccount = Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString());
                    }
                    if (cmbPricingLevel.SelectedValue != null)
                    {
                        infoSalesReturnMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                    }
                    else
                    {
                        infoSalesReturnMaster.PricinglevelId = 0;
                    }
                    if (cmbSalesMan.SelectedValue != null)
                    {
                        infoSalesReturnMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                    }
                    else
                    {
                        infoSalesReturnMaster.EmployeeId = 0;
                    }
                    if (cmbCurrency.SelectedValue != null)
                    {
                        infoSalesReturnMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                        decExchangeRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(infoSalesReturnMaster.ExchangeRateId);
                    }
                    infoSalesReturnMaster.Narration = txtNarration.Text.Trim();
                    infoSalesReturnMaster.UserId = PublicVariables._decCurrentUserId;
                    infoSalesReturnMaster.LrNo = txtLRNo.Text.Trim();
                    infoSalesReturnMaster.TransportationCompany = txtTransportationComp.Text.Trim();
                    infoSalesReturnMaster.Date = Convert.ToDateTime(txtDate.Text);
                    if (txtTotalAmount.Text != string.Empty)
                    {
                        infoSalesReturnMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                    }
                    if (txtGrandTotal.Text != string.Empty)
                    {
                        infoSalesReturnMaster.grandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                    }
                    if (lblTaxAmount.Text != string.Empty)
                    {
                        infoSalesReturnMaster.TaxAmount = Convert.ToDecimal(lblTaxAmount.Text);
                    }
                    infoSalesReturnMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoSalesReturnMaster.Extra1 = string.Empty;
                    infoSalesReturnMaster.Extra2 = string.Empty;
                    if (txtBillDiscount.Text != string.Empty)
                    {
                        infoSalesReturnMaster.Discount = Convert.ToDecimal(txtBillDiscount.Text);
                    }
                    else
                    {
                        infoSalesReturnMaster.Discount = 0;
                    }
                    decimal decNetTotal = 0;
                    decimal decGrandTotal = 0;
                    string strQuantities = string.Empty;
                    if (btnSave.Text == "Update")
                    {
                        infoSalesReturnMaster.SalesReturnMasterId = decSalesReturnMasterId;
                        bllSalesReturn.SalesReturnMasterEdit(infoSalesReturnMaster);
                        BllLedgerPosting.LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndLedgerIdAndVoucherNo(decSalesReturnVoucherTypeId, strVoucherNo, txtReturnNo.Text);
                        BllLedgerPosting.LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndLedgerIdAndVoucherNo(decSalesReturnVoucherTypeId, strVoucherNo, txtReturnNo.Text);
                        BllStockPosting.StockPostingDeleteByVoucherTypeAndVoucherNo(strVoucherNo, decSalesReturnVoucherTypeId);
                        bllSalesReturnBill.SalesReturnBillTaxDeleteBySalesReturnMasterId(decSalesReturnMasterId);
                    }
                    else
                    {
                        decSalesReturnMasterId = bllSalesReturn.SalesReturnMasterAdd(infoSalesReturnMaster);
                    }
                    SalesReturnDetailsInfo infoSalesReturnDetailsInfo = new SalesReturnDetailsInfo();
                    infoSalesReturnDetailsInfo.Extra1 = string.Empty;
                    infoSalesReturnDetailsInfo.Extra2 = string.Empty;
                    if (btnSave.Text == "Update")
                    {
                        foreach (var strId in lstArrOfRemove)
                        {
                            decimal decDeleteId = Convert.ToDecimal(strId);
                            bllSalesReturn.SalesReturnDetailsDelete(decDeleteId);
                        }
                    }
                    foreach (DataGridViewRow DGVSalesReturn in dgvSalesReturn.Rows)
                    {
                        if (DGVSalesReturn.Cells["productId"].Value != null && DGVSalesReturn.Cells["productId"].Value.ToString() != string.Empty)
                        {
                            infoSalesReturnDetailsInfo.SalesReturnMasterId = decSalesReturnMasterId;
                            infoSalesReturnDetailsInfo.ProductId = Convert.ToDecimal(DGVSalesReturn.Cells["productId"].Value.ToString());
                            if (DGVSalesReturn.Cells["dgvTextQty"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.Qty = Convert.ToDecimal(DGVSalesReturn.Cells["dgvTextQty"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvTextRate"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.Rate = Convert.ToDecimal(DGVSalesReturn.Cells["dgvTextRate"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvCmbUnit"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.UnitId = Convert.ToDecimal(DGVSalesReturn.Cells["dgvCmbUnit"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["unitConversionId"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.UnitConversionId = Convert.ToDecimal(DGVSalesReturn.Cells["unitConversionId"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvTextDiscountAmount"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.Discount = Convert.ToDecimal(DGVSalesReturn.Cells["dgvTextDiscountAmount"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvCmbTax"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.TaxId = Convert.ToDecimal(DGVSalesReturn.Cells["dgvCmbTax"].Value.ToString());
                            }
                            else
                            {
                                infoSalesReturnDetailsInfo.TaxId = 0;
                            }
                            if (DGVSalesReturn.Cells["dgvCmbBatch"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.BatchId = Convert.ToDecimal(DGVSalesReturn.Cells["dgvCmbBatch"].Value.ToString());
                            }
                            else
                            {
                                infoSalesReturnDetailsInfo.BatchId = 0;
                            }
                            if (DGVSalesReturn.Cells["dgvCmbBatch"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.BatchId = Convert.ToDecimal(DGVSalesReturn.Cells["dgvCmbBatch"].Value.ToString());
                            }
                            else
                            {
                                infoSalesReturnDetailsInfo.BatchId = 0;
                            }
                            if (DGVSalesReturn.Cells["dgvCmbGodown"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.GodownId = Convert.ToDecimal(DGVSalesReturn.Cells["dgvCmbGodown"].Value.ToString());
                            }
                            else
                            {
                                infoSalesReturnDetailsInfo.GodownId = 0;
                            }
                            if (DGVSalesReturn.Cells["dgvCmbRack"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.RackId = Convert.ToDecimal(DGVSalesReturn.Cells["dgvCmbRack"].Value.ToString());
                            }
                            else
                            {
                                infoSalesReturnDetailsInfo.RackId = 0;
                            }
                            if (DGVSalesReturn.Cells["dgvTextTaxAmount"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.TaxAmount = Convert.ToDecimal(DGVSalesReturn.Cells["dgvTextTaxAmount"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvTextGrossValue"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.GrossAmount = Convert.ToDecimal(DGVSalesReturn.Cells["dgvTextGrossValue"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvTextNetValue"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.NetAmount = Convert.ToDecimal(DGVSalesReturn.Cells["dgvTextNetValue"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvTextAmount1"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.Amount = Convert.ToDecimal(DGVSalesReturn.Cells["dgvTextAmount1"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["dgvSNo"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.SlNo = Convert.ToInt32(DGVSalesReturn.Cells["dgvSNo"].Value.ToString());
                            }
                            if (DGVSalesReturn.Cells["salesDetailsId"].Value != null && cmbInvoiceNo.SelectedValue != null)
                            {
                                infoSalesReturnDetailsInfo.SalesDetailsId = Convert.ToDecimal(DGVSalesReturn.Cells["salesDetailsId"].Value.ToString());
                            }
                            else
                            {
                                infoSalesReturnDetailsInfo.SalesDetailsId = 0;
                            }
                            if (DGVSalesReturn.Cells["salesReturnDetailsId"].Value != null)
                            {
                                infoSalesReturnDetailsInfo.SalesReturnDetailsId = Convert.ToDecimal(DGVSalesReturn.Cells["salesReturnDetailsId"].Value.ToString());
                                bllSalesReturn.SalesReturnDetailsEdit(infoSalesReturnDetailsInfo);
                            }
                            else
                            {
                                decSalesReturnDetailId = bllSalesReturn.SalesReturnDetailsAdd(infoSalesReturnDetailsInfo);
                            }
                            StockPostingInfo infoStockPosting = new StockPostingInfo();
                            infoStockPosting.Date = infoSalesReturnMaster.Date;
                            if (DGVSalesReturn.Cells["voucherTypeId"].Value != null)
                            {
                                infoStockPosting.VoucherTypeId = Convert.ToDecimal(DGVSalesReturn.Cells["voucherTypeId"].Value.ToString());
                                decAgainstVoucherTypeId = infoStockPosting.VoucherTypeId;
                                infoStockPosting.AgainstVoucherTypeId = decSalesReturnVoucherTypeId;
                            }
                            else
                            {
                                infoStockPosting.VoucherTypeId = decSalesReturnVoucherTypeId;
                                infoStockPosting.AgainstVoucherTypeId = 0;
                            }
                            if (DGVSalesReturn.Cells["voucherNo"].Value != null)
                            {
                                infoStockPosting.VoucherNo = DGVSalesReturn.Cells["voucherNo"].Value.ToString();
                                strAgainstVoucherNo = infoStockPosting.VoucherNo;
                                infoStockPosting.AgainstVoucherNo = strVoucherNo;
                            }
                            else
                            {
                                infoStockPosting.VoucherNo = strVoucherNo;
                                infoStockPosting.AgainstVoucherNo = "NA";
                            }
                            if (DGVSalesReturn.Cells["invoiceNo"].Value != null)
                            {
                                infoStockPosting.InvoiceNo = DGVSalesReturn.Cells["invoiceNo"].Value.ToString();
                                strAgainstInvoiceNo = infoStockPosting.InvoiceNo;
                                infoStockPosting.AgainstInvoiceNo = txtReturnNo.Text.Trim();
                            }
                            else
                            {
                                infoStockPosting.InvoiceNo = txtReturnNo.Text;
                                infoStockPosting.AgainstInvoiceNo = "NA";
                            }
                            infoStockPosting.ProductId = infoSalesReturnDetailsInfo.ProductId;
                            infoStockPosting.BatchId = infoSalesReturnDetailsInfo.BatchId;
                            infoStockPosting.UnitId = infoSalesReturnDetailsInfo.UnitId;
                            infoStockPosting.GodownId = infoSalesReturnDetailsInfo.GodownId;
                            infoStockPosting.RackId = infoSalesReturnDetailsInfo.RackId;
                            if (infoSalesReturnDetailsInfo.ProductId != 0 && infoSalesReturnDetailsInfo.UnitId != 0)
                            {
                                decimal decUnitConvertionRate = 0;
                                infoProduct = BllProductCreation.ProductView(infoSalesReturnDetailsInfo.ProductId);
                               List< DataTable> list = bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoSalesReturnDetailsInfo.UnitId, infoProduct.ProductName);
                                foreach (DataRow drowDetails in list[0].Rows)
                                {
                                    decUnitConvertionRate = Convert.ToDecimal(drowDetails["conversionRate"].ToString());
                                }
                                strQuantities = bllUnit.UnitConversionCheck(infoSalesReturnDetailsInfo.UnitId, infoSalesReturnDetailsInfo.ProductId);
                                if (strQuantities != string.Empty)
                                {
                                    infoStockPosting.InwardQty = infoSalesReturnDetailsInfo.Qty / decUnitConvertionRate;
                                }
                                else
                                {
                                    infoStockPosting.InwardQty = infoSalesReturnDetailsInfo.Qty;
                                }
                            }
                            infoStockPosting.OutwardQty = 0;
                            infoStockPosting.Rate = infoSalesReturnDetailsInfo.Rate;
                            infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                           BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                    }
                    decGrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
                    decNetTotal = TotalNetAmountForLedgerPosting();
                    LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                    infoLedgerPosting.Date = infoSalesReturnMaster.Date;
                    infoLedgerPosting.ChequeDate = infoSalesReturnMaster.Date;
                    infoLedgerPosting.ChequeNo = String.Empty;
                    infoLedgerPosting.VoucherTypeId = infoSalesReturnMaster.VoucherTypeId;
                    infoLedgerPosting.VoucherNo = infoSalesReturnMaster.VoucherNo;
                    infoLedgerPosting.LedgerId = infoSalesReturnMaster.LedgerId;
                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Credit = (decGrandTotal * decExchangeRate);
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.InvoiceNo = infoSalesReturnMaster.InvoiceNo;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    infoLedgerPosting.LedgerId = infoSalesReturnMaster.SalesAccount;
                    infoLedgerPosting.Debit = (decNetTotal * decExchangeRate);
                    infoLedgerPosting.Credit = 0;
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    if (Convert.ToDecimal(txtBillDiscount.Text == string.Empty ? "0" : txtBillDiscount.Text) > 0)
                    {
                        infoLedgerPosting.LedgerId = 8;
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = (Convert.ToDecimal(txtBillDiscount.Text) * decExchangeRate);
                        BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    }
                    LedegrPostingForTax();
                    PartyBalanceInfo infoPartyBalance = new PartyBalanceInfo();
                    infoPartyBalance.Date = infoSalesReturnMaster.Date;
                    infoPartyBalance.LedgerId = infoSalesReturnMaster.LedgerId;
                    if (decAgainstVoucherTypeId != 0)
                    {
                        infoPartyBalance.VoucherTypeId = decAgainstVoucherTypeId;
                        infoPartyBalance.VoucherNo = strAgainstVoucherNo;
                        infoPartyBalance.InvoiceNo = strAgainstInvoiceNo;
                        infoPartyBalance.AgainstVoucherTypeId = infoSalesReturnMaster.VoucherTypeId;
                        infoPartyBalance.AgainstVoucherNo = infoSalesReturnMaster.VoucherNo;
                        infoPartyBalance.AgainstInvoiceNo = infoSalesReturnMaster.InvoiceNo;
                        infoPartyBalance.ReferenceType = "Against";
                    }
                    else
                    {
                        infoPartyBalance.VoucherTypeId = infoSalesReturnMaster.VoucherTypeId;
                        infoPartyBalance.VoucherNo = infoSalesReturnMaster.VoucherNo;
                        infoPartyBalance.InvoiceNo = infoSalesReturnMaster.InvoiceNo;
                        infoPartyBalance.AgainstVoucherTypeId = 0;
                        infoPartyBalance.AgainstVoucherNo = "NA";
                        infoPartyBalance.AgainstInvoiceNo = "NA";
                        infoPartyBalance.ReferenceType = "New";
                    }

                    infoPartyBalance.Credit = infoSalesReturnMaster.TotalAmount;
                    infoPartyBalance.Debit = 0;
                    infoPartyBalance.CreditPeriod = 0;
                    infoPartyBalance.ExchangeRateId = infoSalesReturnMaster.ExchangeRateId;
                    infoPartyBalance.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoPartyBalance.Extra1 = string.Empty;
                    infoPartyBalance.Extra2 = string.Empty;
                    BllPartyBalance.PartyBalanceAdd(infoPartyBalance);
                    SalesReturnBillTaxInfo infoSalesReturnBillTax = new SalesReturnBillTaxInfo();
                    foreach (DataGridViewRow item in dgvSalesReturn2.Rows)
                    {
                        if (item.Cells["dgvTextTaxId"].Value != null)
                        {
                            infoSalesReturnBillTax.SalesReturnMasterId = decSalesReturnMasterId;
                            infoSalesReturnBillTax.TaxId = Convert.ToDecimal(item.Cells["dgvTextTaxId"].Value.ToString());
                            infoSalesReturnBillTax.TaxAmount = Convert.ToDecimal(item.Cells["dgvTextAmount"].Value.ToString());
                            infoSalesReturnBillTax.Extra1 = string.Empty;
                            infoSalesReturnBillTax.Extra2 = string.Empty;
                            bllSalesReturnBill.SalesReturnBillTaxAdd(infoSalesReturnBillTax);
                        }
                    }
                    if (btnSave.Text == "Save")
                    {
                        Messages.SavedMessage();
                        if (cbxPrintAfterSave.Checked == true)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesReturnMasterId);
                            }
                            else
                            {
                                Print(decSalesReturnMasterId);
                            }
                        }
                        clear();
                    }
                    else
                    {
                        Messages.UpdatedMessage();
                        if (cbxPrintAfterSave.Checked == true)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesReturnMasterId);
                            }
                            else
                            {
                                Print(decSalesReturnMasterId);
                            }
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the grand total
        /// </summary>
        public void GrandTotalCalculation()
        {
            try
            {
                if (txtBillDiscount.Text != string.Empty)
                {
                    if (txtTotalAmount.Text != string.Empty)
                    {
                        decimal decDiscount = Convert.ToDecimal(txtBillDiscount.Text);
                        decimal decTotalAmt = Convert.ToDecimal(txtTotalAmount.Text);
                        if (decTotalAmt >= decDiscount)
                        {
                            decimal decGrandTotal = decTotalAmt + decTotalBillTaxAmount + decTotalCessTaxamount - decDiscount;
                            decGrandTotal = Math.Round(decGrandTotal, PublicVariables._inNoOfDecimalPlaces);
                            txtGrandTotal.Text = decGrandTotal.ToString();
                        }
                        else
                        {
                            txtBillDiscount.Text = "0";
                        }
                    }
                }
                else
                {
                    if (txtTotalAmount.Text != string.Empty)
                    {
                        decimal decDiscount = 0;
                        decimal decTotalAmt = Convert.ToDecimal(txtTotalAmount.Text);
                        if (decTotalAmt > decDiscount)
                        {
                            decimal decGrandTotal = decTotalAmt + decTotalBillTaxAmount + decTotalCessTaxamount - decDiscount;
                            decGrandTotal = Math.Round(decGrandTotal, PublicVariables._inNoOfDecimalPlaces);
                            txtGrandTotal.Text = decGrandTotal.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the total net amount for LedgerPosting
        /// </summary>
        /// <returns></returns>
        public decimal TotalNetAmountForLedgerPosting()
        {
            decimal decNetAmount = 0;
            try
            {
                foreach (DataGridViewRow dgvrow in dgvSalesReturn.Rows)
                {
                    if (dgvrow.Cells["dgvTextNetValue"].Value != null)
                    {
                        if (dgvrow.Cells["dgvTextNetValue"].Value.ToString() != string.Empty)
                        {
                            decNetAmount = decNetAmount + Convert.ToDecimal(dgvrow.Cells["dgvTextNetValue"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decNetAmount;
        }
        /// <summary>
        /// Function to SerialNo genaration
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvSalesReturn.Rows)
                {
                    row.Cells["dgvSNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the total tax amount
        /// </summary>
        public void TotalTaxAmtCalculation()
        {
            try
            {
                decTotal = 0;
                foreach (DataGridViewRow dgvrow in dgvSalesReturn2.Rows)
                {
                    if (dgvrow.Cells["dgvTextAmount"].Value != null)
                    {
                        if (dgvrow.Cells["dgvTextAmount"].Value.ToString() != string.Empty)
                        {
                            decTotal = decTotal + Convert.ToDecimal(dgvrow.Cells["dgvTextAmount"].Value.ToString());
                            decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                            lblTaxAmount.Text = decTotal.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the total amount calculation
        /// </summary>
        public void TotalAmtCalculation()
        {
            try
            {
                decTotal = 0;
                foreach (DataGridViewRow dgvrow in dgvSalesReturn.Rows)
                {
                    if (decTotalAmounForSaveCheck != 0)
                    {
                        if (dgvrow.Cells["dgvTextAmount1"].Value != null)
                        {
                            if (dgvrow.Cells["dgvTextAmount1"].Value.ToString() != "")
                            {
                                decTotal = decTotal + decimal.Parse(dgvrow.Cells["dgvTextAmount1"].Value.ToString());
                                decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                                if (decTotal <= decTotalAmounForSaveCheck)
                                {
                                    txtTotalAmount.Text = decTotal.ToString();
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                    else if (decTotalAmountForEditCheck != 0)
                    {
                        if (dgvrow.Cells["dgvTextAmount1"].Value != null)
                        {
                            if (dgvrow.Cells["dgvTextAmount1"].Value.ToString() != "")
                            {
                                decTotal = decTotal + decimal.Parse(dgvrow.Cells["dgvTextAmount1"].Value.ToString());
                                decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                                if (decTotal <= decTotalAmountForEditCheck)
                                {
                                    txtTotalAmount.Text = decTotal.ToString();
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                    else
                    {
                        if (dgvrow.Cells["dgvTextAmount1"].Value != null)
                        {
                            if (dgvrow.Cells["dgvTextAmount1"].Value.ToString() != "")
                            {
                                decTotal = decTotal + decimal.Parse(dgvrow.Cells["dgvTextAmount1"].Value.ToString());
                                decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                                txtTotalAmount.Text = decTotal.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the final total calculation
        /// </summary>
        public void TotalAmountCalculationForSaveOrEdit()
        {
            try
            {
                decTotal = 0;
                foreach (DataGridViewRow dgvrow in dgvSalesReturn.Rows)
                {
                    if (dgvrow.Cells["productId"].Value != null && dgvrow.Cells["productId"].Value.ToString() != string.Empty)
                    {
                        if (dgvrow.Cells["dgvTextAmount1"].Value != null)
                        {
                            if (dgvrow.Cells["dgvTextAmount1"].Value.ToString() != "")
                            {
                                decTotal = decTotal + decimal.Parse(dgvrow.Cells["dgvTextAmount1"].Value.ToString());
                                decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                                txtTotalAmount.Text = decTotal.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no generation for Tax grid
        /// </summary>
        public void SerialNo2()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvSalesReturn2.Rows)
                {
                    row.Cells["SNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                CashOrPartyUnderSundryDebitorComboFill(cmbCashOrParty);
                if (decAccountLedgerId != 0)
                {
                    cmbCashOrParty.SelectedValue = decAccountLedgerId;
                }
                else if (strCashOrPartyAccount != string.Empty)
                {
                    cmbCashOrParty.SelectedValue = strCashOrPartyAccount;
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
                MessageBox.Show("SR44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Sales accont combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decAccountLedgerId"></param>
        public void ReturnFromAccountLedgerOfSalesAccount(decimal decAccountLedgerId)
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
                MessageBox.Show("SR45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Combo Selection By using InvoiceNo
        /// </summary>
        public void ComboSelectionByInvoiceNo()
        {
            //DataTable dtblComboSelection = new DataTable();
            List<DataTable> listComboSelection = new List<DataTable>();
            SalesReturnBll bllSalesReturn = new SalesReturnBll();
            try
            {
                if (!isEnterIntoComboSelectn == false)
                {
                    if (cmbInvoiceNo.SelectedIndex != -1)
                    {
                        if (cmbInvoiceNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbInvoiceNo.Text != "System.Data.DataRowView")
                        {
                            DGVGodownComboFill();
                            DGVUnitComboFill();
                            decTotalAmounForSaveCheck = 0;
                            //SalesMasterSP spSaleMaster = new SalesMasterSP();
                            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                            dgvSalesReturn.Rows.Clear();
                            listComboSelection = BllSalesInvoice.SalesMasterViewByInvoiceNoForComboSelection(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()));
                            if (listComboSelection[0] != null)
                            {
                                cmbPricingLevel.SelectedValue = listComboSelection[0].Rows[0]["pricingLevelId"];
                                cmbSalesAccount.SelectedValue = listComboSelection[0].Rows[0]["salesAccount"];
                                cmbSalesAccount.Enabled = true;
                                txtTransportationComp.Text = listComboSelection[0].Rows[0]["transportationCompany"].ToString();
                                txtLRNo.Text = listComboSelection[0].Rows[0]["lrNo"].ToString();
                            }
                            List<DataTable> listSalesReturnGrideFill = BllSalesInvoice.SalesDetailsViewForSalesReturnGrideFill(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()), salesReturnMasterId);
                            dtblSalesInvoice = listSalesReturnGrideFill[0];
                            foreach (DataRow drowDetails in listSalesReturnGrideFill[0].Rows)
                            {
                                decimal decproductId = Convert.ToDecimal(drowDetails["productId"].ToString());
                                TaxGridFill();
                                dgvSalesReturn.Rows.Add();
                                if (drowDetails["S.No"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvSNo"].Value = drowDetails["S.No"].ToString();
                                }
                                if (drowDetails["salesDetailsId"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["salesDetailsId"].Value = drowDetails["salesDetailsId"].ToString();
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["salesDetailsId"].Value = 0;
                                }
                                if (drowDetails["productId"].ToString() != string.Empty)
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["productId"].Value = drowDetails["productId"].ToString();
                                    List<DataTable> listObj = BllSalesInvoice.SalesDetailsViewForSalesReturnGrideFill1(Convert.ToDecimal(drowDetails["productId"].ToString()));
                                    foreach (DataRow drowDetails1 in listObj[0].Rows)
                                    {
                                        if (listComboSelection[0].Rows[0]["voucherTypeId"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["voucherTypeId"].Value = Convert.ToDecimal(listComboSelection[0].Rows[0]["voucherTypeId"].ToString());
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["voucherTypeId"].Value = 0;
                                        }
                                        if (listComboSelection[0].Rows[0]["voucherNo"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["voucherNo"].Value = listComboSelection[0].Rows[0]["voucherNo"].ToString();
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["voucherNo"].Value = 0;
                                        }
                                        if (listComboSelection[0].Rows[0]["invoiceNo"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["invoiceNo"].Value = listComboSelection[0].Rows[0]["invoiceNo"].ToString();
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["invoiceNo"].Value = 0;
                                        }
                                        if (drowDetails1["barcode"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextBarcode"].Value = drowDetails1["barcode"].ToString();
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextBarcode"].ReadOnly = true;
                                        }
                                        if (drowDetails1["productCode"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextProductCode"].Value = drowDetails1["productCode"].ToString();
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextProductCode"].ReadOnly = true;
                                        }
                                        if (drowDetails1["productName"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextProductName"].Value = drowDetails1["productName"].ToString();
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextProductName"].ReadOnly = true;
                                        }
                                        if (drowDetails["unitId"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].ReadOnly = true;
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbUnit"].Value = 1;
                                        }
                                        if (drowDetails["goDownId"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].Value = Convert.ToDecimal(drowDetails["goDownId"].ToString());
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].ReadOnly = false;
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].ReadOnly = false;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].Value = 1;
                                        }
                                        RackComboFill(Convert.ToDecimal(dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbGodown"].Value), dgvSalesReturn.Rows.Count - 2, dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbRack"].ColumnIndex);
                                        if (drowDetails["rackId"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbRack"].Value = Convert.ToDecimal(drowDetails["rackId"].ToString());
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbRack"].Value = 1;
                                        }
                                        BatchComboFill(Convert.ToDecimal(dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["productId"].Value), dgvSalesReturn.Rows.Count - 2, dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbBatch"].ColumnIndex);
                                        if (drowDetails["batchId"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbBatch"].ReadOnly = true;
                                        }
                                        if (drowDetails["unitConversionId"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["unitConversionId"].Value = drowDetails["unitConversionId"].ToString();
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["unitConversionId"].Value = 0;
                                        }
                                        dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["conversionRate"].Value = drowDetails["conversionRate"].ToString();
                                        if (drowDetails["taxId"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTaxId"].Value = 0;
                                            if (Convert.ToDecimal(drowDetails["taxId"].ToString()) != 0)
                                            {
                                                dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTaxId"].Value = Convert.ToDecimal(drowDetails["taxId"].ToString());
                                                dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value = Convert.ToDecimal(drowDetails["taxId"].ToString());
                                                strTaxRate = bllSalesReturn.TaxRateFindForTaxAmmountCalByTaxId(Convert.ToDecimal(drowDetails["taxId"].ToString()));
                                            }
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value = 1;
                                        }
                                        if (drowDetails["qty"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextQty"].Value = Math.Round(Convert.ToDecimal(drowDetails["qty"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                            decQty = Math.Round(Convert.ToDecimal(drowDetails["qty"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextQty"].Value = 0;
                                            decQty = 0;
                                        }
                                        if (drowDetails["rate"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextRate"].Value = Convert.ToDecimal(drowDetails["rate"].ToString());
                                            decRate = Convert.ToDecimal(drowDetails["rate"].ToString());
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextRate"].Value = 0.00;
                                            decRate = 0;
                                        }
                                        if (drowDetails["grossAmount"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = false;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].Value = Math.Round(Convert.ToDecimal(drowDetails["grossAmount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = true;
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = false;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].Value = 0.00;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextGrossValue"].ReadOnly = true;
                                        }
                                        if (drowDetails["discount"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextDiscountPercentage"].Value = 0.00;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextDiscountAmount"].Value = Math.Round(Convert.ToDecimal(drowDetails["discount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextDiscountAmount"].Value = 0.00;
                                        }
                                        if (drowDetails["netAmount"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = false;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].Value = Math.Round(Convert.ToDecimal(drowDetails["netAmount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = true;
                                            txtBillDiscount.Text = "0.00";
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = false;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].Value = 0.00;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextNetValue"].ReadOnly = true;
                                        }
                                        if (drowDetails["taxAmount"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].ReadOnly = false;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].Value = Math.Round(Convert.ToDecimal(drowDetails["taxAmount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].ReadOnly = false;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].Value = 0.00;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].ReadOnly = true;
                                        }
                                        if (drowDetails["amount"].ToString() != string.Empty)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].Value = Math.Round(Convert.ToDecimal(drowDetails["amount"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].ReadOnly = true;
                                        }
                                        else
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].Value = 0.00;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextAmount1"].ReadOnly = true;
                                        }
                                        if (cmbInvoiceNo.Visible == true)
                                        {
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextBarcode"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextProductCode"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextProductName"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextQty"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbUnit"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbGodown"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbRack"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbBatch"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextRate"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextDiscountPercentage"].ReadOnly = true;
                                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvCmbTax"].ReadOnly = true;
                                        }
                                        foreach (DataGridViewRow item1 in dgvSalesReturn2.Rows)
                                        {
                                            if (item1.Cells["dgvTextTaxId"].Value != null)
                                            {
                                                if (dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value != null && dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value.ToString() != string.Empty)
                                                {
                                                    if (dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvCmbTax"].Value.ToString() == item1.Cells["dgvTextTaxId"].Value.ToString())
                                                    {
                                                        item1.Cells["dgvTextAmount"].Value = dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 2].Cells["dgvTextTaxAmount"].Value;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["productId"].Value = 0;
                                }
                            }
                            txtNarration.Text = listComboSelection[0].Rows[0]["narration"].ToString();
                            GrossValueCalculation(dgvSalesReturn.Rows.Count - 2);
                            DiscountCalculationfordiscountpercentage(dgvSalesReturn.Rows.Count - 2, 12);
                            DiscountCalculation(dgvSalesReturn.Rows.Count - 2, 13);
                            TaxAmountCalculation(dgvSalesReturn.Rows.Count - 2);
                            TotalAmtCalculation();
                            TotalBillTaxCalculation();
                            GrandTotalCalculation();
                            taxamountfill();
                            taxAndGridTotalAmountCalculation(dgvSalesReturn.Rows.Count - 2);
                            CessTaxamountCalculation();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionToCalculateDiscount
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
                if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextGrossValue"].Value != null)
                {
                    if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextGrossValue"].Value.ToString() != string.Empty)
                    {
                        decGrossAmount = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextGrossValue"].Value.ToString());
                        if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value != null)
                        {
                            if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value.ToString() != string.Empty)
                            {
                                decDiscountAmount = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value.ToString());
                            }
                        }
                        if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value != null)
                        {
                            if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value.ToString() != string.Empty)
                            {
                                decDiscountPercent = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value.ToString());
                            }
                        }
                        if (inColumnIndex == dgvSalesReturn.Columns["dgvTextDiscountPercentage"].Index)
                        {
                            if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value != null && dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value.ToString() != string.Empty)
                            {

                                decDiscountPercent = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value.ToString());
                            }
                            else
                            {
                                decDiscountPercent = 0;
                            }
                            if (decGrossAmount > 0)
                            {
                                decDiscountAmount = decGrossAmount * decDiscountPercent / 100;
                            }
                            if (decDiscountAmount >= 0)
                            {
                                dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value = Math.Round(decDiscountAmount, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                        else if (inColumnIndex == dgvSalesReturn.Columns["dgvTextDiscountAmount"].Index)
                        {
                            if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value != null && dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value.ToString() != string.Empty)
                            {
                                decDiscountAmount = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value.ToString());
                            }
                            else
                            {
                                decDiscountAmount = 0;
                            }
                            if (decGrossAmount > 0)
                            {
                                decDiscountPercent = decDiscountAmount * 100 / decGrossAmount;
                            }
                            if (decDiscountPercent > 0)
                            {
                                dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value = Math.Round(decDiscountPercent, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                    }
                }
                if (decGrossAmount >= decDiscountAmount)
                {
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextNetValue"].Value = (decGrossAmount - decDiscountAmount).ToString();
                }
                else
                {
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value = "0.00";
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value = "100";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR47: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionToCalculateDiscountcalculation
        /// </summary>
        /// <param name="inRowIndex"></param>
        /// <param name="inColumnIndex"></param>
        public void DiscountCalculationfordiscountpercentage(int inRowIndex, int inColumnIndex)
        {
            try
            {
                decimal decDiscountAmount = 0;
                decimal decDiscountPercent = 0;
                decimal decGrossAmount = 0;
                if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextGrossValue"].Value != null)
                {
                    if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextGrossValue"].Value.ToString() != string.Empty)
                    {
                        decGrossAmount = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextGrossValue"].Value.ToString());
                        if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value != null)
                        {
                            if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value.ToString() != string.Empty)
                            {
                                decDiscountAmount = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value.ToString());
                            }
                        }
                        if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value != null)
                        {
                            if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value.ToString() != string.Empty)
                            {
                                decDiscountPercent = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value.ToString());
                            }
                        }
                        if (inColumnIndex == dgvSalesReturn.Columns["dgvTextDiscountPercentage"].Index)
                        {
                            decDiscountPercent = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value.ToString());
                            if (decGrossAmount > 0)
                            {
                                decDiscountAmount = decGrossAmount * decDiscountPercent / 100;
                            }
                            if (decDiscountAmount > 0)
                            {
                                dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value = Math.Round(decDiscountAmount, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                        else if (inColumnIndex == dgvSalesReturn.Columns["dgvTextDiscountAmount"].Index)
                        {
                            decDiscountAmount = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value.ToString());
                            if (decGrossAmount > 0)
                            {
                                decDiscountPercent = decDiscountAmount * 100 / decGrossAmount;
                            }
                            if (decDiscountPercent > 0)
                            {
                                dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value = Math.Round(decDiscountPercent, PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                    }
                }
                if (decGrossAmount >= decDiscountAmount)
                {
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextNetValue"].Value = (decGrossAmount - decDiscountAmount).ToString();
                }
                else
                {
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value = "0.00";
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// TaxAmountCalculation
        /// </summary>
        /// <param name="inRowIndex"></param>
        public void TaxAmountCalculation(int inRowIndex)
        {
            decimal dcTotal = 0;
            decimal dcVatAmount = 0;
            decimal dcNetAmount = 0;
            dcNetAmount = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextNetValue"].Value.ToString());
            TaxBll bllTax = new TaxBll();
            try
            {
                if (dcNetAmount != 0 && dgvCmbTax.Visible && dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbTax"].Value != null)
                {
                    TaxInfo InfoTaxMaster = bllTax.TaxView(Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbTax"].Value.ToString()));
                    dcVatAmount = Math.Round(((dcNetAmount * InfoTaxMaster.Rate) / (100)), PublicVariables._inNoOfDecimalPlaces);
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextTaxAmount"].Value = dcVatAmount;
                }
                else
                {
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextTaxAmount"].Value = "0";
                }
                dcTotal = dcVatAmount + dcNetAmount;
                dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextAmount1"].Value = dcTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// GrossvalueCalculation
        /// </summary>
        /// <param name="inRowIndex"></param>
        public void GrossValueCalculation(int inRowIndex)
        {
            decimal decrate = 0;
            decimal decQty = 0;
            decimal dcGrossValue = 0;
            try
            {
                if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextQty"].Value.ToString() != string.Empty && dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextQty"].Value.ToString() != null)
                {
                    decQty = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextQty"].Value.ToString());
                    if (dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextRate"].Value != null || dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextRate"].Value.ToString() != string.Empty)
                    {
                        decrate = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextRate"].Value.ToString());
                        if (decrate >= 0)
                        {
                            dcGrossValue = decQty * decrate;
                            dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextGrossValue"].Value = Math.Round((dcGrossValue), PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Pricinglevel combobox while return from pricing level creation when creating new pricing level 
        /// </summary>
        /// <param name="decPricingLevelId"></param>
        public void ReturnFromPricingLevel(decimal decPricingLevelId)
        {
            try
            {
                this.Enabled = true;
                PrlicingLevelComboFill(cmbPricingLevel);
                if (decPricingLevelId != 0)
                {
                    cmbPricingLevel.SelectedValue = decPricingLevelId;
                }
                else if (strPricinglevel != string.Empty)
                {
                    cmbPricingLevel.SelectedValue = strPricinglevel;
                }
                else
                {
                    cmbPricingLevel.SelectedValue = -1;
                }
                cmbPricingLevel.Focus();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Salesman combobox while return from Salesman creation when creating new Salesman 
        /// </summary>
        /// <param name="decSalesManId"></param>
        public void ReturnFromSalesMan(decimal decSalesManId)
        {
            try
            {
                this.Enabled = true;
                SalesManComboFill(cmbSalesMan);
                if (decSalesManId != 0)
                {
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
                cmbSalesMan.Focus();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR52:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Cash Or Party Under SundryDebitor ComboFill
        /// </summary>
        /// <param name="cmbCashOrParty"></param>
        public void CashOrPartyUnderSundryDebitorComboFill(ComboBox cmbCashOrParty)
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
                isCheckForVoucherTypeFill = true;
                cmbCashOrParty.SelectedIndex = -1;
                isFiilCheck = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR53:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the SalesAccount ComboFill
        /// </summary>
        /// <param name="cmbSalesAccount"></param>
        public void SalesAccountComboFill(ComboBox cmbSalesAccount)
        {
            try
            {
                TransactionGeneralFillObj.SalesAccountComboFill(cmbSalesAccount, false);
                cmbSalesAccount.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR54:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the SalesReturn InvoiceNo ComboFill
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="salesReturnMasterId"></param>
        /// <param name="decledgerId"></param>
        public void SalesReturnInvoiceNoComboFill(decimal decVoucherTypeId, decimal salesReturnMasterId, decimal decledgerId)
        {
            try
            {
                SalesReturnBll bllSalesReturn = new SalesReturnBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllSalesReturn.SalesReturnInvoiceNoComboFill(decVoucherTypeId, salesReturnMasterId, decledgerId);
                cmbInvoiceNo.DataSource = ListObj[0];
                if (cmbInvoiceNo.DataSource != null)
                {
                    cmbInvoiceNo.ValueMember = "salesMasterId";
                    cmbInvoiceNo.DisplayMember = "invoiceNo";
                    cmbInvoiceNo.SelectedIndex = -1;
                }
                isEnterIntoComboSelectn = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR55:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the SalesReturn VoucherType ComboFill
        /// </summary>
        /// <param name="ledgerIdFromCashOrPartyCombo"></param>
        public void SalesReturnVoucherTypeComboFill(decimal ledgerIdFromCashOrPartyCombo)
        {
            try
            {
                SalesReturnBll bllSalesReturn = new SalesReturnBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllSalesReturn.SalesReturnVoucherTypeComboFill(ledgerIdFromCashOrPartyCombo);
                cmbVoucherType.DataSource = ListObj[0];
                if (cmbVoucherType.DataSource != null)
                {
                    DataRow dr = ListObj[0].NewRow();
                    dr["voucherTypeId"] = 0;
                    dr["voucherTypeName"] = "NA";
                    ListObj[0].Rows.InsertAt(dr, 0);
                    cmbVoucherType.ValueMember = "voucherTypeId";
                    cmbVoucherType.DisplayMember = "voucherTypeName";
                    cmbVoucherType.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR56:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the PrlicingLevel ComboFill
        /// </summary>
        /// <param name="cmbPricingLevel"></param>
        public void PrlicingLevelComboFill(ComboBox cmbPricingLevel)
        {
            try
            {
                TransactionGeneralFillObj.PricingLevelViewAll(cmbPricingLevel, true);
                cmbPricingLevel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR57:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the unit combofill
        /// </summary>
        public void DGVUnitComboFill()
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAll();
                dgvCmbUnit.DataSource = ListObj[0];
                dgvCmbUnit.ValueMember = "unitId";
                dgvCmbUnit.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR58:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the GodownComboFill
        /// </summary>
        public void DGVGodownComboFill()
        {
            try
            {
                GodownBll BllGodown = new GodownBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllGodown.GodownViewAll();
                dgvCmbGodown.DataSource = listObj[0];
                dgvCmbGodown.ValueMember = "godownId";
                dgvCmbGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR59:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the CurrencyCombo
        /// </summary>
        public void DGVCurrencyComboFill()
        {
            try
            {
                CurrencyBll BllCurrency = new CurrencyBll();
                List<DataTable> listobj = new List<DataTable>();
                SettingsBll BllSettings = new SettingsBll();
                listobj = TransactionGeneralFillObj.CurrencyComboByDate(dtpDate.Value);
                cmbCurrency.DataSource = listobj[0];
                cmbCurrency.DisplayMember = "currencyName";
                cmbCurrency.ValueMember = "exchangeRateId";
                cmbCurrency.SelectedIndex = 0;
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
                MessageBox.Show("SR60:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Rack combo fill
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
                DataGridViewComboBoxCell dgvcmbRackCell = (DataGridViewComboBoxCell)dgvSalesReturn.Rows[inRow].Cells[inColumn];
                dgvcmbRackCell.DataSource = listObj[0];
                dgvcmbRackCell.ValueMember = "rackId";
                dgvcmbRackCell.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the BatchCombo Fill
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
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvSalesReturn.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the TaxComboFill
        /// </summary>
        public void DGVTaxComboFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAll();
                dgvCmbTax.DataSource = ListObj;
                dgvCmbTax.ValueMember = "taxId";
                dgvCmbTax.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR63:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Tax gridfill
        /// </summary>
        public void TaxGridFill()
        {
            string strTaxName = string.Empty;
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                TaxBll bllTax = new TaxBll();
                string strTaxApplicableOn = "Product";
                ListObj = bllTax.TaxViewAllByVoucherTypeId1(decSalesReturnVoucherTypeId, strTaxApplicableOn);
                dgvCmbTax.DataSource = ListObj[0];
                foreach (DataRow item in ListObj[0].Rows)
                {
                    strTaxName = item["taxName"].ToString();
                    if (strTaxName != "NA")
                    {
                        DataRow dr = ListObj[0].NewRow();
                        dr["taxName"] = "NA";
                        dr["taxId"] = 1;
                        ListObj[0].Rows.InsertAt(dr, 0);
                    }
                    break;
                }
                dgvCmbTax.ValueMember = "taxId";
                dgvCmbTax.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR64:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the tax gridfill
        /// </summary>
        public void DGVSalesReturn2Fill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                TaxBll bllTax = new TaxBll();
                ListObj = bllTax.TaxViewAllByVoucherTypeIdWithCess(decSalesReturnVoucherTypeId);
                dgvSalesReturn2.Rows.Clear();
                foreach (DataRow drowDetails in ListObj[0].Rows)
                {
                    dgvSalesReturn2.Rows.Add();
                    dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvTextTaxName"].Value = drowDetails["taxName"].ToString();
                    dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvTextTaxId"].Value = drowDetails["taxId"].ToString();
                    dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvTextAmount"].Value = 0.00;
                    dgvSalesReturn2.Rows[dgvSalesReturn2.Rows.Count - 2].Cells["dgvRate"].Value = drowDetails["rate"].ToString();
                }
                SerialNo2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR65:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the cess and tax amount calculation
        /// </summary>
        public void CessTaxamountCalculation()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                TaxBll bllTax = new TaxBll();
                decTotalCessTaxamount = 0;
                decimal decCessamount = 0;
                foreach (DataGridViewRow drowDetails in dgvSalesReturn2.Rows)
                {
                    if (drowDetails.Cells["dgvTextTaxId"].Value != null)
                    {
                        ListObj = bllTax.TaxIdCorrespondingToCessTaxId(Convert.ToDecimal(drowDetails.Cells["dgvTextTaxId"].Value.ToString()));
                        foreach (DataRow item in ListObj[0].Rows)
                        {
                            if (item["selectedTaxId"].ToString() != String.Empty)
                            {
                                foreach (DataGridViewRow drowDetails1 in dgvSalesReturn2.Rows)
                                {
                                    if (drowDetails1.Cells["dgvTextTaxId"].Value != null)
                                    {
                                        if (drowDetails1.Cells["dgvTextTaxId"].Value.ToString() == item["selectedTaxId"].ToString())
                                        {
                                            drowDetails.Cells["dgvTextAmount"].Value = Math.Round((Convert.ToDecimal(drowDetails1.Cells["dgvTextAmount"].Value.ToString()) * Convert.ToDecimal(drowDetails.Cells["dgvRate"].Value.ToString())) / 100, PublicVariables._inNoOfDecimalPlaces);
                                            decCessamount = Convert.ToDecimal(drowDetails.Cells["dgvTextAmount"].Value.ToString());
                                            decTotalCessTaxamount = Math.Round(decTotalCessTaxamount + decCessamount, PublicVariables._inNoOfDecimalPlaces);
                                            drowDetails.Cells["dgvTextAmount"].Value = decTotalCessTaxamount;
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
                MessageBox.Show("SR66:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionforVouchertypecombofill
        /// </summary>
        public void VoucherTypeCombofill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                SalesReturnBll bllSalesReturn = new SalesReturnBll();
                ListObj = bllSalesReturn.vouchertypecompofill();
                cmbVoucherType.DataSource = ListObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR:67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Salesman combofill
        /// </summary>
        /// <param name="cmbSalesMan"></param>
        public void SalesManComboFill(ComboBox cmbSalesMan)
        {
            try
            {
                TransactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
                cmbPricingLevel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR68:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate Voucher number as per settings
        /// </summary>
        public void VoucherNumberGeneration()
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                SalesReturnBll bllSalesReturn = new SalesReturnBll();
                string strPrefix = string.Empty;
                string strSuffix = string.Empty;
                string strReturnNo = string.Empty;
                string tableName = "SalesReturnMaster";
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = obj.VoucherNumberAutomaicGeneration(decSalesReturnVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                if (Convert.ToDecimal(strVoucherNo) != bllSalesReturn.SalesReturnMasterGetMaxPlusOne(decSalesReturnVoucherTypeId))
                {
                    strVoucherNo = bllSalesReturn.SalesReturnMasterGetMax(decSalesReturnVoucherTypeId).ToString();
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(decSalesReturnVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    if (bllSalesReturn.SalesReturnMasterGetMax(decSalesReturnVoucherTypeId) == "0")
                    {
                        strVoucherNo = "0";
                        strVoucherNo = obj.VoucherNumberAutomaicGeneration(decSalesReturnVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    }
                }
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decSalesReturnVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decSalesReturnSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    strReturnNo = strPrefix + strVoucherNo + strSuffix;
                    txtReturnNo.Text = strReturnNo;
                    txtReturnNo.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR69:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmAgeing.Enabled = false;
                this.frmAgeingObj = frmAgeing;
                salesReturnMasterId = decMasterId;
                isInvoiceFill = true;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR70:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from frmLedgerDetails to view details and for updation
        /// </summary>
        /// <param name="frmLedgerDetails"></param>
        /// <param name="decMasterId"></param>
        public void CallFromLedgerDetails(frmLedgerDetails frmLedgerDetails, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmLedgerDetailsObj = frmLedgerDetails;
                frmLedgerDetailsObj.Enabled = false;
                salesReturnMasterId = decMasterId;
                isFromSalesReturnReport = true;
                isInvoiceFill = true;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR71:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmDayBook.Enabled = false;
                this.frmDayBookObj = frmDayBook;
                salesReturnMasterId = decMasterId;
                isInvoiceFill = true;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR72:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Rackcombofill
        /// </summary>
        /// <param name="decrackId"></param>
        public void rackcombofill1(decimal decrackId)
        {
            try
            {
                RackBll BllRack = new RackBll();
                List<DataTable> listObjc = new List<DataTable>(); ;
                listObjc = BllRack.RackNamesCorrespondingToGodownId(decrackId);
                dgvCmbRack.DataSource = listObjc;
                dgvCmbRack.ValueMember = "rackId";
                dgvCmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR73:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///FunctionToFill ProductDetales
        /// </summary>
        /// <param name="strProduct"></param>
        /// <param name="inRowIndex"></param>
        /// <param name="strFillMode"></param>
        public void ProductDetailsFill(string strProduct, int inRowIndex, string strFillMode)
        {
            try
            {
                string barcode = string.Empty;
                decimal decCurrentConversionRate = 0;
                List<DataTable> listObj = new List<DataTable>();
                UnitConvertionBll bllUnitConversion = new UnitConvertionBll();
                SalesReturnBll bllSalesReturn = new SalesReturnBll();
                BatchBll BllBatch = new BatchBll();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                if (strFillMode == "dgvTextBarcode")
                {
                    listObj = bllSalesReturn.productviewbybarcodeforSR(strProduct, decSalesReturnVoucherTypeId);
                }
                if (strFillMode == "dgvTextProductName")
                {
                    listObj = BllProductCreation.ProductCodeViewByProductName(strProduct, decSalesReturnVoucherTypeId);
                }
                if (strFillMode == "dgvTextProductCode")
                {
                    listObj = BllProductCreation.ProductNameViewByProductCode(strProduct, decSalesReturnVoucherTypeId);
                }
                if (listObj[0].Rows.Count != 0)
                {
                    DGVGodownComboFill();

                    //  SerialNo();
                    dgvSalesReturn.Rows[inRowIndex].Cells["productId"].Value = listObj[0].Rows[0]["productId"];
                    decimal decProductId = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["productId"].Value.ToString());
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextBarcode"].Value = listObj[0].Rows[0]["barcode"];
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextProductCode"].Value = listObj[0].Rows[0]["productCode"];
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextProductName"].Value = listObj[0].Rows[0]["productName"];
                    // dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextQty"].Value = dtbl.Rows[0]["qty"];
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextQty"].Value = string.Empty;
                    UnitComboFill(decProductId, inRowIndex, dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbUnit"].ColumnIndex);
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbUnit"].Value = Convert.ToDecimal(listObj[0].Rows[0]["unitId"].ToString());
                    dgvSalesReturn.Rows[inRowIndex].Cells["unitConversionId"].Value = listObj[0].Rows[0]["unitConversionId"];
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbGodown"].Value = Convert.ToDecimal(listObj[0].Rows[0]["godownId"].ToString());
                    RackComboFill(Convert.ToDecimal(listObj[0].Rows[0]["godownId"].ToString()), inRowIndex, dgvSalesReturn.CurrentRow.Cells["dgvCmbRack"].ColumnIndex);
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbRack"].Value = Convert.ToDecimal(listObj[0].Rows[0]["rackId"].ToString());
                    BatchComboFill(decProductId, inRowIndex, dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbBatch"].ColumnIndex);
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbBatch"].Value = Convert.ToDecimal(listObj[0].Rows[0]["batchId"].ToString());
                    decimal decBatchId = Convert.ToDecimal(dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbBatch"].Value.ToString());
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextRate"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[0]["salesRate"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                    getProductRate(inRowIndex, decProductId, decBatchId);
                    TaxGridFill();
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbTax"].Value = Convert.ToDecimal(listObj[0].Rows[0]["taxId"].ToString());
                    dgvSalesReturn.Rows[inRowIndex].Cells["conversionRate"].Value = listObj[0].Rows[0]["conversionRate"];
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value = listObj[0].Rows[0]["discountPercent"].ToString();
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[0]["discount"]), PublicVariables._inNoOfDecimalPlaces);
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].ReadOnly = true;
                    dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextNetValue"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[0]["netvalue"]), PublicVariables._inNoOfDecimalPlaces);
                    GrossValueCalculation(inRowIndex);
                    DiscountCalculationfordiscountpercentage(inRowIndex, 12);
                    DiscountCalculation(inRowIndex, 13);
                    TotalAmountCalculation();
                    TaxAmountCalculation(inRowIndex);
                    taxamountfill();
                    CessTaxamountCalculation();
                    TotalBillTaxCalculation();
                    TotalTaxAmtCalculation();
                    GrandTotalCalculation();
                    taxAndGridTotalAmountCalculation(inRowIndex);
                    decCurrentConversionRate = Convert.ToDecimal(listObj[0].Rows[0]["conversionRate"].ToString());
                    dgvSalesReturn.Rows[inRowIndex].HeaderCell.Value = "X";
                    dgvSalesReturn.Rows[inRowIndex].HeaderCell.Style.ForeColor = Color.Red;
                }
                else
                {
                    if (dgvSalesReturn.CurrentRow.Index < dgvSalesReturn.RowCount - 1)
                    {
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextBarcode"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextProductCode"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextProductName"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextQty"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbUnit"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbGodown"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbBatch"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbRack"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextRate"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvCmbTax"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountPercentage"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextDiscountAmount"].Value = string.Empty;
                        dgvSalesReturn.Rows[inRowIndex].Cells["dgvTextNetValue"].Value = string.Empty;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SR74" + ex.Message, "openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionToCalulateTax
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
                if (dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextQty"].Value != null && dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextQty"].Value.ToString() != string.Empty)
                {
                    dcNetValue = Convert.ToDecimal(dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextNetValue"].Value.ToString());
                    if (dcNetValue != 0 && dgvSalesReturn.Columns["dgvCmbTax"].Visible && (dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvCmbTax"].Value == null ? "" : dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvCmbTax"].Value.ToString()) != "")
                    {
                        TaxInfo InfoTaxMaster = bllTax.TaxView(Convert.ToDecimal(dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvCmbTax"].Value.ToString()));
                        dTaxAmt = Math.Round(((dcNetValue * InfoTaxMaster.Rate) / (100)), PublicVariables._inNoOfDecimalPlaces);
                        dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextTaxAmount"].Value = dTaxAmt.ToString();
                    }
                    else
                    {
                        dTaxAmt = 0;
                        dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextTaxAmount"].Value = "0.00";
                    }
                }
                else
                {
                    dTaxAmt = 0;
                    dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextTaxAmount"].Value = "0.00";
                }
                dcTotal = dcNetValue + dTaxAmt;
                dgvSalesReturn.Rows[inIndexOfRow].Cells["dgvTextAmount1"].Value = dcTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR75: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionToCalculate Tax and FillGrid
        /// </summary>
        public void taxamountfill()
        {
            decimal decTaxId = 0;
            decimal decAmount = 0;
            try
            {
                foreach (DataGridViewRow dgvTaxRow in dgvSalesReturn2.Rows)
                {
                    if (dgvTaxRow.Cells["dgvTextTaxId"].Value != null)
                    {
                        if (dgvTaxRow.Cells["dgvTextTaxId"].Value.ToString() != string.Empty &&
                            dgvTaxRow.Cells["dgvTextTaxId"].Value.ToString() != "0")
                        {
                            decTaxId = Convert.ToDecimal(dgvTaxRow.Cells["dgvTextTaxId"].Value.ToString());
                            foreach (DataGridViewRow dgvSiRow in dgvSalesReturn.Rows)
                            {
                                if (dgvSiRow.Cells["productId"].Value != null)
                                {
                                    if (dgvSiRow.Cells["productId"].Value.ToString() != string.Empty &&
                                        dgvSiRow.Cells["productId"].Value.ToString() != "0")
                                    {
                                        if (dgvSiRow.Cells["dgvCmbTax"].Value != null)
                                        {
                                            if (dgvSiRow.Cells["dgvCmbTax"].Value.ToString() != string.Empty &&
                                                dgvSiRow.Cells["dgvCmbTax"].Value.ToString() != "0")
                                            {
                                                if (dgvSiRow.Cells["dgvTextTaxAmount"].Value != null)
                                                {
                                                    if (dgvSiRow.Cells["dgvTextTaxAmount"].Value.ToString() != string.Empty &&
                                                        dgvSiRow.Cells["dgvTextTaxAmount"].Value.ToString() != "0")
                                                    {
                                                        if (Convert.ToDecimal(dgvSiRow.Cells["dgvCmbTax"].Value.ToString()) == decTaxId)
                                                        {
                                                            decAmount = decAmount + Convert.ToDecimal(dgvSiRow.Cells["dgvTextTaxAmount"].Value.ToString());
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            dgvTaxRow.Cells["dgvTextAmount"].Value = decAmount;
                            decAmount = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR76:" + ex.Message, "openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// FunctionToCalculateTotalAmount
        /// </summary>
        public void TotalAmountCalculation()
        {
            try
            {
                decimal DecTotalAmount = 0;
                foreach (DataGridViewRow dr in dgvSalesReturn.Rows)
                {
                    if (dr.Cells["productId"].Value != null && dr.Cells["productId"].Value.ToString() != string.Empty)
                    {
                        if (dr.Cells["dgvTextAmount1"].Value != null && dr.Cells["dgvTextAmount1"].Value.ToString() != string.Empty)
                        {
                            //CurrencySP currencysp = new CurrencySP();
                            decimal decAmt = Convert.ToDecimal(dr.Cells["dgvTextAmount1"].Value);
                            DecTotalAmount = DecTotalAmount + decAmt;
                            DecTotalAmount = Math.Round(DecTotalAmount, PublicVariables._inNoOfDecimalPlaces);
                            //txtTotalAmount.Text = Convert.ToString(DecTotalAmount);
                            //lblCurrency.Text = new CurrencySP().GetCurrencySymbolByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            txtTotalAmount.Text = DecTotalAmount.ToString();
                        }
                        else if (dgvSalesReturn.Rows.Count == 1 && dr.Cells["dgvTextAmount1"].Value == null)
                        {
                            txtTotalAmount.Text = "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR77:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Date validation and set the dtp's value as text box value
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
                cmbCurrency.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR78:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form load call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            try
            {
                if (isAutomatic)
                {
                    clear();
                }
                else
                {
                    clear();
                    txtReturnNo.Focus();
                }
                FillProducts(false, null);
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("barcode") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvTextBarcode"].Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvTextBarcode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvCmbUnit"].Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvCmbUnit"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvCmbGodown"].Visible = true;
                    dgvSalesReturn.Columns["dgvCmbRack"].Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvCmbGodown"].Visible = false;
                    dgvSalesReturn.Columns["dgvCmbRack"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                        dgvSalesReturn.Columns["dgvCmbRack"].Visible = true;
                    else
                        dgvSalesReturn.Columns["dgvCmbRack"].Visible = false;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvCmbRack"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvCmbBatch"].Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvCmbBatch"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("Tax") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvCmbTax"].Visible = true;
                    dgvSalesReturn.Columns["dgvTextTaxAmount"].Visible = true;
                    dgvSalesReturn2.Visible = true;
                    lblTaxAmount.Visible = true;
                    lblTotalTax.Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvCmbTax"].Visible = false;
                    dgvSalesReturn.Columns["dgvTextTaxAmount"].Visible = false;
                    dgvSalesReturn2.Visible = false;
                    lblTaxAmount.Visible = false;
                    lblTotalTax.Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvTextProductCode"].Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvTextProductCode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowDiscountPercentage") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvTextDiscountPercentage"].Visible = true;
                    dgvSalesReturn.Columns["dgvTextDiscountAmount"].Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvTextDiscountPercentage"].Visible = false;
                    dgvSalesReturn.Columns["dgvTextDiscountAmount"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowDiscountAmount") == "Yes")
                {
                    dgvSalesReturn.Columns["dgvTextDiscountAmount"].Visible = true;
                    dgvSalesReturn.Columns["dgvTextDiscountPercentage"].Visible = true;
                }
                else
                {
                    dgvSalesReturn.Columns["dgvTextDiscountAmount"].Visible = false;
                    dgvSalesReturn.Columns["dgvTextDiscountPercentage"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR79:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing event, checking the other opend form status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (objFromSalesReturnRegister != null)
                {
                    objFromSalesReturnRegister.SalesReturnGrideFill();
                    objFromSalesReturnRegister.Enabled = true;
                }
                if (objFromSalesReturnReport != null)
                {
                    objFromSalesReturnReport.SalesReturnReportGrideFill();
                    objFromSalesReturnReport.Enabled = true;
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj = null;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj.FillGrid();
                    frmAgeingObj = null;
                }
                if (frmLedgerDetailsObj != null)
                {
                    frmLedgerDetailsObj.Enabled = true;
                    frmLedgerDetailsObj.LedgerDetailsView();
                    frmLedgerDetailsObj = null;
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                    objVoucherSearch = null;
                }
                if (objVoucherProduct != null)
                {
                    objVoucherProduct.Enabled = true;
                    objVoucherProduct.FillGrid();
                    objVoucherProduct = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR80:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// InvoiceNo index change arrrange the settings based on it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetSalesDetailsIdToDelete();
                dgvSalesReturn.Rows.Clear();
                txtTotalAmount.Text = string.Empty;
                txtGrandTotal.Text = string.Empty;
                txtBillDiscount.Text = string.Empty;
                string strInvoiceNoText = string.Empty;
                strInvoiceNoText = cmbInvoiceNo.Text;
                if (!isInvoiceFill)
                {
                    ComboSelectionByInvoiceNo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR81:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Get the qty and validating the product rate here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string strProductcode = string.Empty;
            string strbarcode = string.Empty;
            string strproductname = string.Empty;
            try
            {
                if (dgvSalesReturn.Columns[e.ColumnIndex].Name == "dgvTextProductCode")
                {
                    if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextProductCode"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextProductCode"].Value.ToString().Trim() != string.Empty)
                    {
                        strProductcode = dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextProductCode"].Value.ToString();
                        ProductDetailsFill(strProductcode, e.RowIndex, "dgvTextProductCode");
                    }
                    else
                    {
                        StringEmptyDetailsInGrid();
                    }
                }
                else if (dgvSalesReturn.Columns[e.ColumnIndex].Name == "dgvTextBarcode")
                {
                    if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextBarcode"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextBarcode"].Value.ToString().Trim() != string.Empty)
                    {
                        strbarcode = dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextBarcode"].Value.ToString();
                        ProductDetailsFill(strbarcode, e.RowIndex, "dgvTextBarcode");
                    }
                    else
                    {
                        StringEmptyDetailsInGrid();
                    }
                }
                else if (dgvSalesReturn.Columns[e.ColumnIndex].Name == "dgvTextProductName")
                {
                    if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextProductName"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextProductName"].Value.ToString().Trim() != string.Empty)
                    {
                        strproductname = dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextProductName"].Value.ToString();
                        ProductDetailsFill(strproductname, e.RowIndex, "dgvTextProductName");
                    }
                    else
                    {
                        StringEmptyDetailsInGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR82:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// set the dtp value as textbox value, and call the currency on date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtDate.Text = dtpDate.Value.ToString("dd-MMM-yyyy");
                DGVCurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR83:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the keypress event for validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }
        /// <summary>
        /// Send the combobox status here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                inIndex = ((ComboBox)sender).SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR84:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in total amount feild
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR85:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in bill discount
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
                MessageBox.Show("SR86:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Set the discount as 0 if its empty
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
                MessageBox.Show("SR87:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the invoice no combofill here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVoucherType.Text == "NA")
                {
                    dgvSalesReturn.Rows.Clear();
                    txtTotalAmount.Text = string.Empty;
                    txtGrandTotal.Text = string.Empty;
                    txtBillDiscount.Text = string.Empty;
                    label6.Visible = false;
                    cmbInvoiceNo.Visible = false;
                }
                else
                {
                    label6.Visible = true;
                    cmbInvoiceNo.Visible = true;
                    cmbInvoiceComboFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR88:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// geting the product rate and set the cells for editmode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            decimal decsalesinvoiceQty = 0;
            try
            {
                if (dgvSalesReturn.Rows[e.RowIndex].Cells["productId"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["productId"].Value.ToString() != string.Empty)
                {
                    if (dgvSalesReturn.Columns[e.ColumnIndex].Name == "dgvCmbUnit")
                    {
                        decCurrentConversionRate = Convert.ToDecimal(dgvSalesReturn.Rows[e.RowIndex].Cells["conversionRate"].Value.ToString());
                        if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value.ToString() != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value.ToString() != string.Empty)
                        {
                            decCurrentRate = Convert.ToDecimal(dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value.ToString());
                        }
                    }
                    decCurrentConversionRate = Convert.ToDecimal(dgvSalesReturn.Rows[e.RowIndex].Cells["conversionRate"].Value.ToString());
                    if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value.ToString() != string.Empty)
                    {
                        decCurrentRate = Convert.ToDecimal(dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value.ToString());
                    }
                }
                if (e.ColumnIndex == dgvSalesReturn.Columns["dgvCmbRack"].Index)
                {
                    if (dgvSalesReturn.CurrentRow.Cells["dgvCmbGodown"].Value != null && dgvSalesReturn.CurrentRow.Cells["dgvCmbGodown"].Value.ToString() != string.Empty)
                    {
                        decimal decGodownId = Convert.ToDecimal(dgvSalesReturn.CurrentRow.Cells["dgvCmbGodown"].Value);
                        RackComboFill(decGodownId, e.RowIndex, dgvSalesReturn.CurrentRow.Cells["dgvCmbRack"].ColumnIndex);
                    }
                }
                if (dgvSalesReturn.Rows[e.RowIndex].Cells["salesDetailsId"].Value != null)
                {
                    if (dgvSalesReturn.Rows[e.RowIndex].Cells["salesDetailsId"].Value.ToString() != string.Empty)
                    {
                        if (decimal.Parse(dgvSalesReturn.Rows[e.RowIndex].Cells["salesDetailsId"].Value.ToString()) > 0)
                        {
                            if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value.ToString() != string.Empty)
                            {
                                decsalesinvoiceQty = decimal.Parse(dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR89:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// get the product rate based on the pricing level selected
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
                if (cmbPricingLevel.SelectedValue != null)
                {
                    if (dgvSalesReturn.Rows.Count > 1)
                    {
                        foreach (DataGridViewRow dgvRow in dgvSalesReturn.Rows)
                        {
                            inRowIndex = dgvRow.Index;
                            if (dgvRow.Cells["productId"].Value != null)
                            {
                                if (dgvRow.Cells["dgvcmbBatch"].Value != null)
                                {
                                    decProductId = Convert.ToDecimal(dgvRow.Cells["productId"].Value.ToString());
                                    decBatchId = Convert.ToDecimal(dgvRow.Cells["dgvcmbBatch"].Value.ToString());
                                    getProductRate(inRowIndex, decProductId, decBatchId);
                                }
                                else
                                {
                                    dgvSalesReturn.Focus();
                                    dgvSalesReturn.CurrentCell = dgvRow.Cells["dgvCmbBatch"];
                                    dgvRow.Cells["dgvCmbBatch"].Selected = true;
                                }
                            }
                            else
                            {
                                dgvSalesReturn.Focus();
                                dgvSalesReturn.CurrentCell = dgvRow.Cells["dgvTextBarcode"];
                                dgvRow.Cells["dgvTextBarcode"].Selected = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR90:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalesReturnClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("SR91:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in QTY And Amount feild
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TextBoxControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvSalesReturn.CurrentCell != null)
                {
                    if (dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextTaxAmount" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextAmount1" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextNetValue" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextRate" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextDiscountPercentage" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextGrossValue" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextDiscountAmount")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                    if (dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextQty")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR92:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Data error event to handleunhandle exceptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturn_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvSalesReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvSalesReturn.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR93" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR94:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the grand total amount calculation here, if the text changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GrandTotalCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR95:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to add a new cash or party using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCashOrParty_Click(object sender, EventArgs e)
        {
            try
            {
                isFromCashOrPartyCombo = true;
                isFromSalesAccountCombo = false;
                if (cmbCashOrParty.SelectedValue != null)
                {
                    strCashOrPartyAccount = cmbCashOrParty.SelectedValue.ToString();
                }
                else
                {
                    strCashOrPartyAccount = string.Empty;
                }
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedgerObj.CallFromSalesReturn(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR96:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to add a new Pricing level using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPricingLevel_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPricingLevel.SelectedValue != null)
                {
                    strPricinglevel = cmbPricingLevel.SelectedValue.ToString();
                }
                else
                {
                    strPricinglevel = string.Empty;
                }
                frmPricingLevel frmPricingLevelObj = new frmPricingLevel();
                frmPricingLevelObj.MdiParent = formMDI.MDIObj;
                frmPricingLevel open = Application.OpenForms["frmPricingLevel"] as frmPricingLevel;
                if (open == null)
                {
                    frmPricingLevelObj.WindowState = FormWindowState.Normal;
                    frmPricingLevelObj.MdiParent = formMDI.MDIObj;
                    frmPricingLevelObj.CallFromSalesReturn(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromSalesReturn(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR97:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to add a new SalesMan using this button click
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
                    frmSalesmanObj.MdiParent = formMDI.MDIObj;
                    frmSalesmanObj.CallFromSalesReturn(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromSalesReturn(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR98:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to add a new Sales Account using this button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalesAcct_Click(object sender, EventArgs e)
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
                    frmAccountLedgerObj.CallFromSalesReturn(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromSalesReturn(this, isFromCashOrPartyCombo, isFromSalesAccountCombo);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR99:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save button click, call the function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveOrEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR100:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove button click, vall the remave function here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvSalesReturn.SelectedCells.Count > 0 && dgvSalesReturn.CurrentRow != null)
                {
                    if (!dgvSalesReturn.Rows[dgvSalesReturn.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvSalesReturn.CurrentRow.Cells["salesReturnDetailsId"].Value != null && dgvSalesReturn.CurrentRow.Cells["salesReturnDetailsId"].Value.ToString() != "")
                                {
                                    lstArrOfRemove.Add(dgvSalesReturn.CurrentRow.Cells["salesReturnDetailsId"].Value.ToString());
                                    RemoveFunction();
                                    TotalAmountCalculation();
                                    // TotalAmtCalculation();
                                    TotalBillTaxCalculation();
                                    //  SerialNo();
                                    CessTaxamountCalculation();
                                    GrandTotalCalculation();
                                    TotalTaxAmtCalculation();
                                }
                                else
                                {
                                    RemoveFunction();
                                    TotalAmountCalculation();
                                    // TotalAmtCalculation();
                                    TotalBillTaxCalculation();
                                    //  SerialNo();
                                    CessTaxamountCalculation();
                                    GrandTotalCalculation();
                                    TotalTaxAmtCalculation();
                                }
                            }
                            else
                            {
                                RemoveFunction();
                                //TotalAmtCalculation();
                                TotalBillTaxCalculation();
                                //SerialNo();
                                CessTaxamountCalculation();
                                GrandTotalCalculation();
                                TotalTaxAmtCalculation();
                            }
                            if (dgvSalesReturn.Rows.Count == 1)
                            {
                                dgvSalesReturn2.Rows.Clear();
                                DGVSalesReturn2Fill();
                                lblTaxAmount.Text = "0.00";
                                txtGrandTotal.Text = "0";
                                txtTotalAmount.Text = "0";
                            }
                            SerialNo();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SR101:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear button click, clear the controlls and checking the other opend form status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
                if (objFromSalesReturnRegister != null)
                {
                    objFromSalesReturnRegister.Close();
                    objFromSalesReturnRegister = null;
                }
                if (objFromSalesReturnReport != null)
                {
                    objFromSalesReturnReport.Close();
                    objFromSalesReturnReport = null;
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
                MessageBox.Show("SR102:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvSalesReturn_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewComboBoxEditingControl ComboxControl = e.Control as DataGridViewComboBoxEditingControl;
                DataGridViewTextBoxEditingControl TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvSalesReturn.CurrentCell != null && dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    if (dgvSalesReturn.CurrentCell != null && dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvSalesReturn.CurrentCell != null && dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name != "dgvTextProductCode" && dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name != "dgvTextProductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvSalesReturn.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    TextBoxControl.KeyPress += new KeyPressEventHandler(TextBoxControl_KeyPress);
                }
                if (ComboxControl != null)
                {
                    if (dgvSalesReturn.CurrentCell != null && dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "Tax")
                    {
                        ComboBox comboBox = e.Control as ComboBox;
                        comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR121:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbCashOrParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCashOrParty.Text != string.Empty)
            {
                cmbInvoiceComboFill();
            }
        }
        private void dgvSalesReturn_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR120" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtBillDiscount_Enter(object sender, EventArgs e)
        {
            try
            {
                txtBillDiscount.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR120" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (!txtDate.ReadOnly)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                    else if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (cmbInvoiceNo.Enabled)
                    {
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbSalesAccount.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        dgvSalesReturn.Focus();
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    SendKeys.Send("{F10}");
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
                        frmLedgerPopupObj.CallFromSalesReturn(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryCreditors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }

                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnCashOrParty_Click(sender, e);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR103:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesAccount.Enabled)
                    {
                        cmbSalesAccount.Focus();
                    }
                    else if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbInvoiceNo.Enabled)
                    {
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (!txtDate.ReadOnly)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                    else if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    dgvSalesReturn.Focus();
                    dgvSalesReturn.CurrentCell = dgvSalesReturn.Rows[0].Cells["dgvTextBarcode"];
                    dgvSalesReturn.Rows[0].Cells["dgvTextBarcode"].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR104:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTransportationComp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtLRNo.Enabled)
                    {
                        txtLRNo.Focus();
                    }
                    else
                    {
                        if (txtNarration.Enabled)
                        {
                            txtNarration.Focus();
                        }
                        else
                        {
                            if (txtBillDiscount.Enabled)
                            {
                                txtBillDiscount.Focus();
                            }
                            else
                            {
                                btnSave.Focus();
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvSalesReturn.Enabled)
                    {
                        if (txtTransportationComp.Text.Trim() == string.Empty || txtTransportationComp.SelectionStart == 0)
                        {
                            dgvSalesReturn.Focus();
                            dgvSalesReturn.CurrentCell = dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextAmount1"];
                            dgvSalesReturn.Rows[dgvSalesReturn.Rows.Count - 1].Cells["dgvTextAmount1"].Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR105:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReturnNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtReturnNo.Enabled)
                    {
                        if (txtDate.Enabled)
                        {
                            txtDate.Focus();
                        }
                        else if (cmbCashOrParty.Enabled)
                        {
                            cmbCashOrParty.Focus();
                        }
                        else if (cmbInvoiceNo.Enabled)
                        {
                            cmbInvoiceNo.Focus();
                        }
                        else if (cmbPricingLevel.Enabled)
                        {
                            cmbPricingLevel.Focus();
                        }
                        else if (cmbSalesAccount.Enabled)
                        {
                            cmbSalesAccount.Focus();
                        }
                        else if (cmbSalesMan.Enabled)
                        {
                            cmbSalesMan.Focus();
                        }
                        else if (cmbCurrency.Enabled)
                        {
                            cmbCurrency.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR106:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLRNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtNarration.Enabled)
                    {
                        txtNarration.Focus();
                    }
                    else
                    {
                        if (txtBillDiscount.Enabled)
                        {
                            txtBillDiscount.Focus();
                        }
                        else
                        {
                            btnSave.Focus();
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtTransportationComp.Enabled)
                    {
                        if (txtLRNo.Text.Trim() == string.Empty || txtLRNo.SelectionStart == 0)
                        {
                            txtTransportationComp.Focus();
                            txtTransportationComp.SelectionLength = 0;
                            txtTransportationComp.SelectionStart = 0;
                        }
                    }
                    else
                    {
                        dgvSalesReturn.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR107:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
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
                        if (txtBillDiscount.Enabled)
                        {
                            txtBillDiscount.Focus();
                            if (txtBillDiscount.Text == "0")
                            {
                                txtBillDiscount.Clear();
                            }
                        }
                        else
                        {
                            btnSave.Focus();
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtLRNo.Enabled)
                    {
                        if (txtNarration.Text.Trim() == string.Empty || txtNarration.SelectionStart == 0)
                        {
                            txtLRNo.Focus();
                            txtLRNo.SelectionStart = 0;
                            txtLRNo.SelectionLength = 0;
                        }
                    }
                    else
                    {
                        if (txtTransportationComp.Enabled)
                        {
                            txtTransportationComp.Focus();
                            txtTransportationComp.SelectionStart = 0;
                            txtTransportationComp.SelectionLength = 0;
                        }
                        else
                        {
                            dgvSalesReturn.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR108:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBillDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBillDiscount.Text.Trim() == string.Empty && txtBillDiscount.SelectionLength == 0)
                    {
                        if (txtNarration.Enabled)
                        {
                            txtNarration.Focus();
                            txtNarration.SelectionLength = 0;
                            txtNarration.SelectionStart = 0;
                        }
                        else
                        {
                            if (txtLRNo.Enabled)
                            {
                                txtLRNo.Focus();
                                txtLRNo.SelectionLength = 0;
                                txtLRNo.SelectionStart = 0;
                            }
                            else
                            {
                                if (txtTransportationComp.Enabled)
                                {
                                    txtTransportationComp.Focus();
                                    txtTransportationComp.SelectionLength = 0;
                                    txtTransportationComp.SelectionStart = 0;
                                }
                                else
                                {
                                    dgvSalesReturn.Focus();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR109:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (!txtDate.ReadOnly)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                    else if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbSalesAccount.Enabled)
                    {
                        cmbSalesAccount.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        dgvSalesReturn.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR110:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPricingLevel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbSalesAccount.Enabled)
                    {
                        cmbSalesAccount.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        dgvSalesReturn.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbInvoiceNo.Enabled)
                    {
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (!txtDate.ReadOnly)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                    else if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
                //Cntrl+F pop up 
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    SendKeys.Send("{F10}");
                    if (cmbPricingLevel.Focused)
                    {
                        cmbPricingLevel.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbPricingLevel.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbPricingLevel.SelectedIndex != -1)
                    {
                        frmPriceListPopup frmPriceListPopUpObj = new frmPriceListPopup();
                        frmPriceListPopUpObj.MdiParent = formMDI.MDIObj;
                        frmPriceListPopUpObj.CallFromSalesReturnForPricingLevel(this, Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString()), "PricingLevel");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any pricing level");
                    }
                }

                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");

                    btnPricingLevel_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR111:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        dgvSalesReturn.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbInvoiceNo.Enabled)
                    {
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (!txtDate.ReadOnly)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                    else if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    SendKeys.Send("{F10}");
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
                        frmLedgerPopupObj.CallFromSalesReturn(this, Convert.ToDecimal(cmbSalesAccount.SelectedValue.ToString()), "SalesAccountLedger");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any sales account");
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");

                    btnSalesAcct_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR112:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    if (cmbPricingLevel.Focused)
                    {
                        cmbPricingLevel.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbPricingLevel.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    btnSalesMan_Click(sender, e);
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    SendKeys.Send("{F10}");
                    if (cmbSalesMan.Focused)
                    {
                        cmbSalesMan.DropDownStyle = ComboBoxStyle.DropDown;
                    }
                    else
                    {
                        cmbSalesMan.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    if (cmbSalesMan.SelectedIndex != -1)
                    {
                        frmEmployeePopup frmEmployeePopUpObj = new frmEmployeePopup();
                        frmEmployeePopUpObj.MdiParent = formMDI.MDIObj;
                        frmEmployeePopUpObj.callFromSalesReturn(this, Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select any pricing level");
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbVoucherType.Enabled)
                    {
                        cmbVoucherType.Focus();
                    }
                    else if (cmbInvoiceNo.Enabled)
                    {
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbSalesAccount.Enabled)
                    {
                        cmbSalesAccount.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        dgvSalesReturn.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (!txtDate.ReadOnly)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                    else if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR113:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (cmbInvoiceNo.Enabled)
                    {
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbSalesAccount.Enabled)
                    {
                        cmbSalesAccount.Focus();
                    }
                    else if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR114:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturn_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int inDgvSalesRowCount = dgvSalesReturn.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalesReturn.CurrentCell == dgvSalesReturn.Rows[inDgvSalesRowCount - 1].Cells["dgvTextAmount1"])
                    {
                        txtTransportationComp.Focus();
                        dgvSalesReturn.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvSalesReturn.CurrentCell == dgvSalesReturn[dgvSalesReturn.Columns["dgvSNo"].Index, 0])
                    {
                        if (cmbCurrency.Enabled)
                        {
                            cmbCurrency.Focus();
                        }
                        else if (cmbSalesMan.Enabled)
                        {
                            cmbSalesAccount.Focus();
                        }
                        else
                        {
                            if (cmbPricingLevel.Enabled == true)
                            {
                                cmbPricingLevel.Focus();
                            }
                            else
                            {
                                if (cmbInvoiceNo.Enabled)
                                {
                                    cmbInvoiceNo.Focus();
                                }
                                else
                                {
                                    if (cmbVoucherType.Enabled)
                                    {
                                        cmbVoucherType.Focus();
                                    }
                                    else
                                    {
                                        if (cmbVoucherType.Enabled)
                                        {
                                            cmbVoucherType.Focus();
                                        }
                                        else if (cmbSalesMan.Enabled)
                                        {
                                            cmbSalesMan.Focus();
                                        }
                                        else if (cmbCashOrParty.Enabled)
                                        {
                                            cmbCashOrParty.Focus();
                                        }
                                        else if (!txtDate.ReadOnly)
                                        {
                                            txtDate.Focus();
                                            txtDate.SelectionStart = 0;
                                            txtDate.SelectionLength = 0;
                                        }
                                        else if (txtReturnNo.Enabled)
                                        {
                                            txtReturnNo.Focus();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (dgvSalesReturn.CurrentRow.Index > 0)
                        {
                            if (dgvSalesReturn.CurrentCell != dgvSalesReturn[dgvSalesReturn.Columns["dgvTextBarcode"].Index, dgvSalesReturn.CurrentRow.Index])
                            {
                                dgvSalesReturn.CurrentCell = dgvSalesReturn[dgvSalesReturn.CurrentCell.ColumnIndex - 1, dgvSalesReturn.CurrentRow.Index];
                            }
                            else
                            {
                                dgvSalesReturn.CurrentCell = dgvSalesReturn[dgvSalesReturn.Columns["dgvTextBarcode"].Index, dgvSalesReturn.CurrentRow.Index - 1];
                            }
                        }
                        else
                        {
                            dgvSalesReturn.CurrentCell = dgvSalesReturn[dgvSalesReturn.CurrentCell.ColumnIndex - 1, dgvSalesReturn.CurrentRow.Index];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR115:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesReturn_KeyDown(object sender, KeyEventArgs e)
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

                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbCashOrParty.Focused)
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    else
                    {
                        cmbCashOrParty.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    btnSave_Click(sender, e);
                }

                if (btnDelete.Enabled == true)
                {
                    if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
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

                if (dgvSalesReturn.RowCount > 0)
                {
                    if (dgvSalesReturn.CurrentCell != null)
                    {
                        if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                        {
                            if (dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductName" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductCode")
                            {
                                if (cmbInvoiceNo.Visible == false)
                                {
                                    SendKeys.Send("{F10}");
                                    if (dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductName" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductCode")
                                    {
                                        frmProductCreation frmProductCreationObj = new frmProductCreation();
                                        frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                        frmProductCreationObj.CallFromSalesReturn(this);
                                    }
                                }
                            }
                        }
                    }
                }

                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (dgvSalesReturn.CurrentCell != null)
                    {
                        if (dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductName" || dgvSalesReturn.Columns[dgvSalesReturn.CurrentCell.ColumnIndex].Name == "dgvTextProductCode")
                        {
                            if (cmbInvoiceNo.Visible == false)
                            {
                                SendKeys.Send("{F10}");
                                frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                                frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                                if (dgvSalesReturn.CurrentRow.Cells["dgvTextProductName"].Value != null || dgvSalesReturn.CurrentRow.Cells["dgvTextProductCode"].Value != null)
                                {
                                    frmProductSearchPopupObj.CallFromSalesReturn(this, dgvSalesReturn.CurrentRow.Index, dgvSalesReturn.CurrentRow.Cells["dgvTextProductCode"].Value.ToString());
                                }
                                else
                                {
                                    frmProductSearchPopupObj.CallFromSalesReturn(this, dgvSalesReturn.CurrentRow.Index, string.Empty);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR116:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
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
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbVoucherType.Text != "NA")
                    {
                        cmbInvoiceNo.Focus();
                    }
                    else if (cmbInvoiceNo.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbSalesAccount.Enabled)
                    {
                        cmbSalesAccount.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        dgvSalesReturn.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else if (!txtDate.ReadOnly)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                    else if (!txtReturnNo.ReadOnly)
                    {
                        txtReturnNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR117:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBillDiscount.Enabled)
                    {
                        txtBillDiscount.Focus();
                    }
                    else if (txtNarration.Enabled)
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionLength = 0;
                        txtNarration.SelectionStart = 0;
                    }
                    else
                    {
                        if (txtLRNo.Enabled)
                        {
                            txtLRNo.Focus();
                            txtLRNo.SelectionLength = 0;
                            txtLRNo.SelectionStart = 0;
                        }
                        else
                        {
                            if (txtTransportationComp.Enabled)
                            {
                                txtTransportationComp.Focus();
                                txtTransportationComp.SelectionLength = 0;
                                txtTransportationComp.SelectionStart = 0;
                            }
                            else
                            {
                                dgvSalesReturn.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR118:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// EventToPerformCalculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturn_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSalesReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvTextQty")
                {
                    if (dgvSalesReturn.Rows[e.RowIndex].Cells["salesDetailsId"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["salesDetailsId"].Value.ToString() != string.Empty)
                    {
                        if (decimal.Parse(dgvSalesReturn.Rows[e.RowIndex].Cells["salesDetailsId"].Value.ToString()) > 0)
                        {
                            if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value.ToString() != string.Empty)
                            {
                                decimal deccurrentQuantity = Convert.ToDecimal(dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value.ToString());
                                //DataTable dtblSalesReturnGrideFill = new DataTable();
                                List<DataTable> listSalesReturnGrideFill = new List<DataTable>();
                                listSalesReturnGrideFill = BllSalesInvoice.SalesDetailsViewForSalesReturnGrideFill(Convert.ToDecimal(cmbInvoiceNo.SelectedValue.ToString()), salesReturnMasterId);
                                if (decimal.Parse(dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value.ToString()) > decimal.Parse(listSalesReturnGrideFill[0].Rows[e.RowIndex]["qty"].ToString()))
                                {
                                    dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value = Math.Round(Convert.ToDecimal(listSalesReturnGrideFill[0].Rows[e.RowIndex]["qty"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                }
                            }
                        }
                    }
                }
                string strBarcode = string.Empty;
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvSalesReturn.RowCount > 1)
                    {
                        if (dgvSalesReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvTextRate" || dgvSalesReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvTextQty" || dgvSalesReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvTextDiscountPercentage" || dgvSalesReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvCmbTax")
                        {
                            if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value != null)
                            {
                                if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value.ToString() != string.Empty && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value.ToString() != string.Empty)
                                {
                                    {
                                        GrossValueCalculation(e.RowIndex);
                                        DiscountCalculation(e.RowIndex, e.ColumnIndex);
                                        TaxAmountCalculation(e.RowIndex);
                                        TotalAmountCalculation();
                                        //TotalAmtCalculation();
                                        taxamountfill();
                                        TotalAmountCalculationForSaveOrEdit();
                                        TotalBillTaxCalculation();
                                        GrandTotalCalculation();
                                        CessTaxamountCalculation();
                                        TotalTaxAmtCalculation();
                                    }
                                }
                            }
                        }
                    }
                }
                if (dgvSalesReturn.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvCmbUnit")
                {
                    if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value != null && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value != null)
                    {
                        if (dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextQty"].Value.ToString() != string.Empty && dgvSalesReturn.Rows[e.RowIndex].Cells["dgvTextRate"].Value.ToString() != string.Empty)
                        {
                            UnitConversionCalc(e.RowIndex);
                            GrossValueCalculation(e.RowIndex);
                            DiscountCalculation(e.RowIndex, e.ColumnIndex);
                            TaxAmountCalculation(e.RowIndex);
                            //TotalAmtCalculation();
                            TotalBillTaxCalculation();
                            GrandTotalCalculation();
                            CessTaxamountCalculation();
                        }
                    }
                }

                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR119" + ex.Message, "openmiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// EventToPerformCommitEdit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalesReturn_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalesReturn.IsCurrentCellDirty)
                {
                    dgvSalesReturn.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR120" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
