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
    public partial class frmPurchaseOrder : Form
    {
        #region PublicVariables
        int inNarrationCount = 0;
        string strCashOrParty = string.Empty;
        string strPrefix = string.Empty;
        string strSuffix = string.Empty;
        string strVoucherNo = string.Empty;
        string strOrderNo = string.Empty;
        string strBarcode = string.Empty;
        string strStatus = string.Empty;
        ArrayList lstArrOfRemove = new ArrayList();
        string tableName = "PurchaseOrderMaster";
        string strProductCode = string.Empty;
        public static bool isEdit = false;
        decimal decPurchaseOrderMasterId = 0;
        decimal decPurchaseOrderDetailId = 0;
        decimal decPurchaseOrderMasterIdentity = 0;
        decimal decPurchaseSuffixPrefixId = 0;
        decimal decPurchaseOrderTypeId = 0;
        decimal decPurchaseVoucherId = 0;
        decimal decCurrentRate = 0;
        decimal decCurrentConversionRate = 0;
        bool isValueChange = true;
        bool isAutomatic = false;
        bool isValueChanged = false;
        bool isDoAfterGridFill = true;
        bool isAmountcalc = true;
        bool isCheck = false;
        frmLedgerPopup frmLedgerPopupObj;
        frmProductSearchPopup frmProductSearchPopupObj;
        DataGridViewTextBoxEditingControl TextBoxControl;
        frmPurchaseOrderRegister frmPurchaseOrderRegisterObj;
        frmPurchaseOrderReport frmPurchaseOrderReportObj;
        frmVoucherSearch objVoucherSearch = null;
        frmDayBook frmDayBookObj = null;
        frmVoucherWiseProductSearch objfrmVoucherproduct = null;
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        List<DataTable> listunitconversionViewAll = new List<DataTable>();
       // 
        #endregion
        #region Functions
        /// <summary>
        /// Create an Instance for frmPurchaseOrder class
        /// </summary>
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Currency Combofill Function
        /// </summary>
        public void CurrencyComboFill()
        {
            try
            {
                List<DataTable> listObjCurrency = new List<DataTable>();
                SettingsBll BllSettings = new SettingsBll(); ;
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
                MessageBox.Show("PO1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check the product code status based on settings
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
                MessageBox.Show("PO2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// GridView Unit combobox fill
        /// </summary>
        public void UnitComboFill()
        {
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
                MessageBox.Show("PO:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check the Barcode status based on settings
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
                MessageBox.Show("PO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// CurrenySymbol Status based on settings
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
                MessageBox.Show("PO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// To check the Checkbox status based on settings
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
                MessageBox.Show("PO6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
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
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                List<DataTable> listObjProducts = new List<DataTable>();
                ProductNames = BllProductCreation.ProudctNameViewAllForAutoComplete();
                ProductCodes = BllProductCreation.ProudctCodesViewAllForAutoComplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Keypress event for Decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvPurchaseOrder.CurrentCell != null)
                {
                    if (dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtQty")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                    if (dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove Product and details in editing mode
        /// </summary>
        public void RemovePurchaseOrderDetails()
        {
            try
            {
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                foreach (var strId in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strId);
                    BllPurchaseOrder.PurchaseOrderDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call from voucher search to fill selected Purchase order
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                base.Show();
                objVoucherSearch = frm;
                decPurchaseOrderMasterId = decId;
                FillRegisterOrReport(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherSearch to view details and for updation 
        /// </summary>
        /// <param name="frmVoucherwiseProductSearch"></param>
        /// <param name="decmasterId"></param>
        public void CallFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherwiseProductSearch, decimal decmasterId)
        {
            try
            {
                base.Show();
                frmVoucherwiseProductSearch.Enabled = true;
                objfrmVoucherproduct = frmVoucherwiseProductSearch;
                decPurchaseOrderMasterId = decmasterId;
                FillRegisterOrReport(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To checking the cancelled status and checking to other forms opend or not
        /// </summary>
        public void PurchaseOrderCancel()
        {
            try
            {
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                BllPurchaseOrder.PurchaseOrderCancel(decPurchaseOrderMasterId);
                Messages.InformationMessage("Cancelled successfully");
                if (frmPurchaseOrderRegisterObj != null)
                {
                    this.Close();
                    frmPurchaseOrderRegisterObj.GridFill();
                }
                if (frmPurchaseOrderReportObj != null)
                {
                    this.Close();
                    frmPurchaseOrderReportObj.GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Check CancelStatus
        /// </summary>
        /// <param name="decId"></param>
        /// <returns></returns>
        public bool CheckCancelStatus(decimal decId)
        {
            bool isCancelled = false;
            try
            {
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                isCancelled = BllPurchaseOrder.PurchaseOrderCancelCheckStatus(decId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isCancelled;
        }
        /// <summary>
        /// Print function
        /// </summary>
        /// <param name="decMasterId"></param>
        public void Print(decimal decMasterId)
        {
            try
            {
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                DataSet dsPurchaseOrder = BllPurchaseOrder.PurchaseOrderPrinting(decMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.PurchaseOrderPrinting(dsPurchaseOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Print function for dotmatrix printer
        /// </summary>
        /// <param name="decMasterId"></param>
        public void PrintForDotMatrix(decimal decMasterId)
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
                dtblGridDetails.Columns.Add("Rate");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvPurchaseOrder.Rows)
                {
                    if (!dRow.IsNewRow)
                    {
                        DataRow dr = dtblGridDetails.NewRow();
                        dr["SlNo"] = ++inRowCount;
                        if (dRow.Cells["dgvtxtBarcode"].Value != null)
                        {
                            dr["BarCode"] = Convert.ToString(dRow.Cells["dgvtxtBarcode"].Value);
                        }
                        if (dRow.Cells["dgvtxtProductCode"].Value != null)
                        {
                            dr["ProductCode"] = Convert.ToString(dRow.Cells["dgvtxtProductCode"].Value);
                        }
                        if (dRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            dr["ProductName"] = Convert.ToString(dRow.Cells["dgvtxtProductName"].Value);
                        }
                        if (dRow.Cells["dgvtxtQty"].Value != null)
                        {
                            dr["Qty"] = Convert.ToString(dRow.Cells["dgvtxtQty"].Value);
                        }
                        if (dRow.Cells["dgvcmbUnit"].Value != null)
                        {
                            dr["Unit"] = Convert.ToString(dRow.Cells["dgvcmbUnit"].FormattedValue);
                        }
                        if (dRow.Cells["dgvtxtRate"].Value != null)
                        {
                            dr["Rate"] = Convert.ToString(dRow.Cells["dgvtxtRate"].Value);
                        }
                        if (dRow.Cells["dgvtxtAmount"].Value != null)
                        {
                            dr["Amount"] = Convert.ToString(dRow.Cells["dgvtxtAmount"].Value);
                        }
                        dtblGridDetails.Rows.Add(dr);
                    }
                }
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("DueDays");
                dtblOtherDetails.Columns.Add("DueDate");
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
                dRowOther["TotalAmount"] = txtTotalAmount.Text;
                dRowOther["DueDays"] = txtDueDays.Text;
                dRowOther["DueDate"] = txtDueDate.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtTotalAmount.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decPurchaseOrderTypeId);
                dRowOther["Declaration"] = Convert.ToString(dtblDeclaration.Rows[0]["Declaration"]);
                dRowOther["Heading1"] = Convert.ToString(dtblDeclaration.Rows[0]["Heading1"]);
                dRowOther["Heading2"] = Convert.ToString(dtblDeclaration.Rows[0]["Heading2"]);
                dRowOther["Heading3"] = Convert.ToString(dtblDeclaration.Rows[0]["Heading3"]);
                dRowOther["Heading4"] = Convert.ToString(dtblDeclaration.Rows[0]["Heading4"]);
                int inFormId = BllVoucherType.FormIdGetForPrinterSettings(Convert.ToInt32(dtblDeclaration.Rows[0]["masterId"].ToString()));
                PrintWorks.DotMatrixPrint.PrintDesign(inFormId, dtblOtherDetails, dtblGridDetails, dtblOtherDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Delete function
        /// </summary>
        public void Delete()
        {
           
            PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
            
            try
            {
                decimal decResult1 = 0;
                for (int inI = 0; inI < dgvPurchaseOrder.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value) != 0)
                    {
                        decResult1 = BllPurchaseOrder.PurchaseOrderDetailsDelete(Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value));
                    }
                }
                decimal decResult2 = BllPurchaseOrder.PurchaseOrderMasterDelete(decPurchaseOrderMasterId);
                if (decResult1 > 0 && decResult2 > 0)
                {
                    Messages.DeletedMessage();
                    if (frmPurchaseOrderRegisterObj != null)
                    {
                        this.Close();
                        frmPurchaseOrderRegisterObj.GridFill();
                    }
                    if (frmPurchaseOrderReportObj != null)
                    {
                        this.Close();
                        frmPurchaseOrderReportObj.GridFill();
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
                else
                {
                    Messages.ReferenceExistsMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cash or party combo box fill
        /// </summary>
        public void CashOrPartyComboFill()
        {
            try
            {
                TransactionGeneralFillObj.CashOrPartyComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// TO get the Due days 
        /// </summary>
        public void DueDays()
        {
            try
            {
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                txtDueDays.Text = BllPurchaseOrder.DueDays(dtpDate.Value, dtpDueDate.Value).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("PO18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no Generation function for grid
        /// </summary>
        private void SerialNo()
        {
            int inRowslno = 1;
            try
            {
                foreach (DataGridViewRow rwcurrent in dgvPurchaseOrder.Rows)
                {
                    rwcurrent.Cells["dgvtxtslNo"].Value = inRowslno;
                    inRowslno++;
                    if (rwcurrent.Index == dgvPurchaseOrder.Rows.Count - 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove function , to remove a row from grid
        /// </summary>
        public void RemoveFunction()
        {
            try
            {
                int inRowCount = dgvPurchaseOrder.RowCount;
                int index = dgvPurchaseOrder.CurrentRow.Index;
                int inC = 0;
                if (inRowCount > 2)
                {
                    if (dgvPurchaseOrder.CurrentRow.HeaderCell.Value.ToString() == string.Empty && dgvPurchaseOrder.CurrentRow.HeaderCell.Value == null)
                    {
                        string strName = dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                        int inIndex = dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].RowIndex;
                        string strOther;
                        for (int inI = 0; inI < inRowCount - 1; inI++)
                        {
                            inC++;
                            strOther = dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                            if (inIndex != dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductName"].RowIndex)
                            {
                                if (ProductSameOccourance())
                                {
                                    dgvPurchaseOrder.Rows.RemoveAt(index);
                                    return;
                                }
                                else
                                {
                                    if (inC == inRowCount - 1)
                                    {
                                        dgvPurchaseOrder.Rows.RemoveAt(index);
                                        inC = 0;
                                    }
                                }
                            }
                            else
                            {
                                dgvPurchaseOrder.Rows.RemoveAt(index);
                            }
                        }
                    }
                    else
                    {
                        dgvPurchaseOrder.Rows.RemoveAt(index);
                    }
                }
                else
                {
                    dgvPurchaseOrder.Rows.RemoveAt(index);
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Amount calculations of grid
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="inIndexOfRow"></param>
        public void NewAmountCalculation(string columnName, int inIndexOfRow)
        {
            try
            {
                decimal decRate = 0;
                decimal decQty = 0;
                decimal decGrossValue = 0;
                if (dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtProductName"].Value != null && dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                {
                    if (dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value != null && dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                    {
                        if (dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value != null && dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                        {
                            decQty = Convert.ToDecimal(dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString());
                            decRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString());
                            decGrossValue = decQty * decRate;
                            dgvPurchaseOrder.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calculating the grand total amount calculation
        /// </summary>
        private void CalculateTotalAmount()
        {
           ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            try
            {
                decimal decTotal = 0;
                if (dgvPurchaseOrder.RowCount > 1)
                {
                    foreach (DataGridViewRow dgvrow in dgvPurchaseOrder.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtAmount"].Value != null && dgvrow.Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            decimal decAmt = Convert.ToDecimal(dgvrow.Cells["dgvtxtAmount"].Value.ToString());
                            decimal decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                            decimal decRowTotal = decAmt;
                            decTotal = decTotal + decRowTotal;
                            decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                            txtTotalAmount.Text = decTotal.ToString();
                        }
                    }
                }
                else
                {
                    decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                    txtTotalAmount.Text = decTotal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                base.Show();
                this.frmLedgerPopupObj = frmLedgerPopup;
                TransactionGeneralFillObj.CashOrPartyComboFill(cmbCashOrParty, false);
                cmbCashOrParty.SelectedValue = decId;
                frmLedgerPopupObj.Close();
                frmLedgerPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                infoProduct = BllProductCreation.ProductView(decproductId);
                dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                dgvPurchaseOrder.CurrentRow.Cells["dgvtxtRate"].Value = infoProduct.PurchaseRate;
                UnitComboFill(decproductId, dgvPurchaseOrder.CurrentRow.Index, dgvPurchaseOrder.CurrentRow.Cells["dgvcmbUnit"].ColumnIndex);
                dgvPurchaseOrder.CurrentRow.Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                List<DataTable> list = new List<DataTable>();
                list = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(infoProduct.ProductCode);
                foreach (DataRow drUnitByProduct in list[0].Rows)
                {
                    if (dgvPurchaseOrder.CurrentRow.Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                    {
                        dgvPurchaseOrder.CurrentRow.Cells["dgvtxtUnitConversionId"].Value = drUnitByProduct.ItemArray[2].ToString();
                        dgvPurchaseOrder.CurrentRow.Cells["dgvtxtUnitConversionRate"].Value = drUnitByProduct.ItemArray[3].ToString();
                    }
                }
                decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseOrder.CurrentRow.Cells["dgvtxtUnitConversionRate"].Value.ToString());
                decCurrentRate = Convert.ToDecimal(dgvPurchaseOrder.CurrentRow.Cells["dgvtxtRate"].Value.ToString());
                NewAmountCalculation("dgvtxtQty", dgvPurchaseOrder.CurrentRow.Index);
                CalculateTotalAmount();
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
                this.Enabled = true;
                this.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill function to updation
        /// </summary>
        /// <param name="isPending"></param>
        public void FillRegisterOrReport(bool isPending)
        {
            try
            {
                PurchaseOrderMasterInfo infoPurchaseOrderMaster = new PurchaseOrderMasterInfo();

                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtOrderNo.ReadOnly = true;
                infoPurchaseOrderMaster = BllPurchaseOrder.PurchaseOrderMasterView(decPurchaseOrderMasterId);
                txtOrderNo.Text = infoPurchaseOrderMaster.InvoiceNo;
                strVoucherNo = infoPurchaseOrderMaster.VoucherNo.ToString();
                decPurchaseSuffixPrefixId = Convert.ToDecimal(infoPurchaseOrderMaster.SuffixPrefixId);
                decPurchaseVoucherId = Convert.ToDecimal(infoPurchaseOrderMaster.VoucherTypeId);
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decPurchaseVoucherId);
                decPurchaseOrderTypeId = decPurchaseVoucherId;
                txtDate.Text = infoPurchaseOrderMaster.Date.ToString("dd-MMM-yyyy");
                cmbCashOrParty.SelectedValue = infoPurchaseOrderMaster.LedgerId;
                txtDueDate.Text = infoPurchaseOrderMaster.DueDate.ToString("dd-MMM-yyyy");
                TimeSpan objTs = Convert.ToDateTime(txtDueDate.Text).Subtract(Convert.ToDateTime(txtDate.Text));
                txtDueDays.Text = objTs.Days.ToString();
                txtNarration.Text = infoPurchaseOrderMaster.Narration;
                cmbCurrency.SelectedValue = infoPurchaseOrderMaster.exchangeRateId;
                txtTotalAmount.Text = infoPurchaseOrderMaster.TotalAmount.ToString();
                List<DataTable> ListObj = new List<DataTable>();
                if (isPending)
                {
                    ListObj = BllPurchaseOrder.PurchaseOrderDetailsViewWithRemaining(decPurchaseOrderMasterId);
                }
                else
                {
                    ListObj = BllPurchaseOrder.PurchaseOrderDetailsViewByMasterId(decPurchaseOrderMasterId);
                }
                if (CheckCancelStatus(decPurchaseOrderMasterId))
                {
                    isCheck = true;
                    cbxCancel.Checked = true;
                    cbxCancel.Enabled = false;
                    isCheck = false;
                }
                else
                {
                    isCheck = true;
                    cbxCancel.Enabled = true;
                    //  cbxCancel.Checked = false;
                    isCheck = false;
                }
                dgvPurchaseOrder.Rows.Clear();
                for (int i = 0; i < ListObj[0].Rows.Count; i++)
                {
                    isAmountcalc = false;
                    dgvPurchaseOrder.Rows.Add();
                    dgvPurchaseOrder.Rows[i].HeaderCell.Value = string.Empty;
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtPurchaseOrderDetailsId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["purchaseOrderDetailsId"].ToString());
                    decPurchaseOrderDetailId = Convert.ToDecimal(ListObj[0].Rows[i]["purchaseOrderDetailsId"].ToString());
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtProductId"].Value = ListObj[0].Rows[i]["productId"].ToString();
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtProductCode"].Value = ListObj[0].Rows[i]["productCode"].ToString();
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtProductName"].Value = ListObj[0].Rows[i]["productName"].ToString();
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtQty"].Value = ListObj[0].Rows[i]["qty"].ToString();
                    UnitComboFill(Convert.ToDecimal(ListObj[0].Rows[i]["productId"].ToString()), i, dgvPurchaseOrder.Rows[i].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvPurchaseOrder.Rows[i].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["unitId"].ToString());
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtUnitConversionId"].Value = ListObj[0].Rows[i]["unitConversionId"].ToString();
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtUnitConversionRate"].Value = ListObj[0].Rows[i]["conversionRate"].ToString();
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtRate"].Value = ListObj[0].Rows[i]["rate"].ToString();
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtAmount"].Value = ListObj[0].Rows[i]["amount"].ToString();
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtProductName"].ReadOnly = true;
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtProductCode"].ReadOnly = true;
                    dgvPurchaseOrder.Rows[i].Cells["dgvtxtBarcode"].ReadOnly = true;
                }
                SerialNo();
                isAmountcalc = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPurchaseOrderRegister to view details and for updation
        /// </summary>
        /// <param name="frmPurchaseOrderRegister"></param>
        /// <param name="decPurchaseOrderMasterid"></param>
        /// <param name="isPendingOrder"></param>
        public void CallFromPurchaseOrderRegister(frmPurchaseOrderRegister frmPurchaseOrderRegister, decimal decPurchaseOrderMasterid, bool isPendingOrder)
        {
            try
            {
                base.Show();
                this.BringToFront();
                this.frmPurchaseOrderRegisterObj = frmPurchaseOrderRegister;
                decPurchaseOrderMasterId = decPurchaseOrderMasterid;
                FillRegisterOrReport(isPendingOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPurchaseOrderReport to view details and for updation
        /// </summary>
        /// <param name="frmPurchaseOrderReport"></param>
        /// <param name="decPurchaseOrderMasterid"></param>
        /// <param name="isPendingOrder"></param>
        public void CallFromPurchaseOrderReport(frmPurchaseOrderReport frmPurchaseOrderReport, decimal decPurchaseOrderMasterid, bool isPendingOrder)
        {
            try
            {
                base.Show();
                this.frmPurchaseOrderReportObj = frmPurchaseOrderReport;
                decPurchaseOrderMasterId = decPurchaseOrderMasterid;
                FillRegisterOrReport(isPendingOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear function and voucherno generation based on settings
        /// </summary>
        public void Clear()
        {
            try
            {
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();

                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                SettingsBll BllSettings = new SettingsBll();
                if (isAutomatic)
                {
                    strVoucherNo = BllPurchaseOrder.PurchaseOrderVoucherMasterMax(decPurchaseOrderTypeId).ToString();
                    if (strVoucherNo == string.Empty)
                    {
                        strVoucherNo = "0";
                    }
                    strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPurchaseOrderTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    if (strVoucherNo != BllPurchaseOrder.PurchaseOrderVoucherMasterMax(decPurchaseOrderTypeId).ToString())
                    {
                        strVoucherNo = BllPurchaseOrder.PurchaseOrderVoucherMasterMax(decPurchaseOrderTypeId).ToString();
                        strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPurchaseOrderTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                        if (BllPurchaseOrder.PurchaseOrderVoucherMasterMax(decPurchaseOrderTypeId) == "0")
                        {
                            strVoucherNo = "0";
                            strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPurchaseOrderTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                        }
                    }
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPurchaseOrderTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decPurchaseSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    strOrderNo = strPrefix + strVoucherNo + strSuffix;
                    txtOrderNo.Text = strOrderNo;
                    txtOrderNo.ReadOnly = true;
                    txtDate.Focus();
                }
                else
                {
                    txtOrderNo.Text = string.Empty;
                    txtOrderNo.ReadOnly = false;
                    txtOrderNo.Focus();
                }
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDueDate.Value = PublicVariables._dtCurrentDate;
                this.txtDueDate.Text = this.dtpDueDate.Value.ToString("dd-MMM-yyyy");
                dtpDueDate.MinDate = PublicVariables._dtFromDate;
                dtpDueDate.MaxDate = PublicVariables._dtToDate;
                txtDueDays.Text = "0";
                CashOrPartyComboFill();
                if (!ShowProductCode())
                {
                    this.dgvPurchaseOrder.Columns["dgvtxtProductCode"].Visible = false;
                }
                if (!ShowBarcode())
                {
                    this.dgvPurchaseOrder.Columns["dgvtxtBarcode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    dgvPurchaseOrder.Columns["dgvcmbUnit"].Visible = true;
                }
                else
                {
                    dgvPurchaseOrder.Columns["dgvcmbUnit"].Visible = false;
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

                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                cbxCancel.Enabled = true;
                cbxCancel.Checked = false;
                dgvPurchaseOrder.Rows.Clear();
                txtTotalAmount.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="decPurchaseTypeId"></param>
        /// <param name="strPurchaseOrderTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decPurchaseTypeId, string strPurchaseOrderTypeName)
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();

                decPurchaseOrderTypeId = decPurchaseTypeId;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decPurchaseOrderTypeId);
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPurchaseOrderTypeId, dtpDate.Value);
                decPurchaseSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                this.Text = strPurchaseOrderTypeName;
                base.Show();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check whether the values of grid is valid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPurchaseOrder.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductCode"].Value == null || dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString().Trim() == "")
                        {
                            isValueChanged = true;
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Value = "X";
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvPurchaseOrder.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvPurchaseOrder.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == "")
                        {
                            isValueChanged = true;
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Value = "X";
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].Value == null || dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].Value.ToString().Trim() == "")
                        {
                            isValueChanged = true;
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Value = "X";
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvPurchaseOrder.CurrentRow.Cells["dgvtxtAmount"].Value == null || dgvPurchaseOrder.CurrentRow.Cells["dgvtxtAmount"].Value.ToString().Trim() == "0")
                        {
                            isValueChanged = true;
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Value = "X";
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvPurchaseOrder.CurrentRow.HeaderCell.Value = "";
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// RemoveIncompleteRowsFrom dataGrid view  
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvPurchaseOrder.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvPurchaseOrder.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.HeaderCell.Value != null)
                        {
                            if (dgvrowCur.HeaderCell.Value.ToString() == "X")
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
                        for (int inK = 0; inK < dgvPurchaseOrder.Rows.Count; inK++)
                        {
                            if (dgvPurchaseOrder.Rows[inK].HeaderCell.Value != null && dgvPurchaseOrder.Rows[inK].HeaderCell.Value.ToString() == "X")
                            {
                                if (!dgvPurchaseOrder.Rows[inK].IsNewRow)
                                {
                                    dgvPurchaseOrder.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvPurchaseOrder.Rows[inForFirst].Cells["dgvtxtProductName"].Selected = true;
                        dgvPurchaseOrder.CurrentCell = dgvPurchaseOrder.Rows[inForFirst].Cells["dgvtxtProductName"];
                        dgvPurchaseOrder.Focus();
                    }
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Save or edit function , to check invalid entries
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                dgvPurchaseOrder.ClearSelection();
                int inRow = dgvPurchaseOrder.RowCount;
                if (txtOrderNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number");
                    txtOrderNo.Focus();
                }
                else if (BllPurchaseOrder.PurchaseOrderNumberCheckExistence(txtOrderNo.Text.Trim(), 0, decPurchaseOrderTypeId) == true && btnSave.Text == "Save")
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
                    Messages.InformationMessage("Can't save purchase order without atleast one product with complete details");
                }
                else
                {
                    if (RemoveIncompleteRowsFromGrid())
                    {
                        if (dgvPurchaseOrder.Rows[0].Cells["dgvtxtProductName"].Value == null && dgvPurchaseOrder.Rows[0].Cells["dgvtxtProductCode"].Value == null)
                        {
                            MessageBox.Show("Can't save purchase order without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvPurchaseOrder.ClearSelection();
                            dgvPurchaseOrder.Focus();
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                if (dgvPurchaseOrder.Rows[0].Cells["dgvtxtProductName"].Value == null)
                                {
                                    MessageBox.Show("Can't save purchase order without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvPurchaseOrder.ClearSelection();
                                    dgvPurchaseOrder.Focus();
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
                                if (dgvPurchaseOrder.Rows[0].Cells["dgvtxtProductName"].Value == null)
                                {
                                    MessageBox.Show("Can't Edit purchase order without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvPurchaseOrder.ClearSelection();
                                    dgvPurchaseOrder.Focus();
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
            catch (Exception ex)
            {
                MessageBox.Show("PO32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// edit function for PurchaseOrderDetails
        /// </summary>
        public void EditPurchaseOrderDetails()
        {
            PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
            PurchaseOrderDetailsInfo infoPurchaseOrderDetails = new PurchaseOrderDetailsInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                ProductInfo infoProduct = new ProductInfo();
               
                
                
                for (int inI = 0; inI < dgvPurchaseOrder.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value) == 0 || dgvPurchaseOrder.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString() == null || dgvPurchaseOrder.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString() == string.Empty)
                    {
                        infoPurchaseOrderDetails.PurchaseOrderMasterId = decPurchaseOrderMasterId;
                        infoProduct = BllProductCreation.ProductViewByCode(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoPurchaseOrderDetails.ProductId = infoProduct.ProductId;
                        infoPurchaseOrderDetails.Qty = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        infoPurchaseOrderDetails.UnitId = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvcmbUnit"].Value);
                        infoPurchaseOrderDetails.UnitConversionId = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value);
                        infoPurchaseOrderDetails.Rate = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoPurchaseOrderDetails.Amount = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoPurchaseOrderDetails.SlNo = Convert.ToInt32(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        infoPurchaseOrderDetails.Extra1 = string.Empty;
                        infoPurchaseOrderDetails.Extra2 = string.Empty;
                        BllPurchaseOrder.PurchaseOrderDetailsAdd(infoPurchaseOrderDetails);
                    }
                    else
                    {
                        infoPurchaseOrderDetails.PurchaseOrderMasterId = decPurchaseOrderMasterId;
                        infoPurchaseOrderDetails.PurchaseOrderDetailsId = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value);
                        infoProduct = BllProductCreation.ProductViewByCode(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoPurchaseOrderDetails.ProductId = infoProduct.ProductId;
                        infoPurchaseOrderDetails.Qty = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        infoPurchaseOrderDetails.UnitId = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        infoPurchaseOrderDetails.UnitConversionId = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value);
                        infoPurchaseOrderDetails.Rate = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoPurchaseOrderDetails.Amount = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoPurchaseOrderDetails.SlNo = Convert.ToInt32(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        infoPurchaseOrderDetails.Extra1 = string.Empty;
                        infoPurchaseOrderDetails.Extra2 = string.Empty;
                        BllPurchaseOrder.PurchaseOrderDetailsEdit(infoPurchaseOrderDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Edit function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                PurchaseOrderMasterInfo infoPurchaseOrderMaster = new PurchaseOrderMasterInfo();
                PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
                SettingsBll BllSettings = new SettingsBll();
                infoPurchaseOrderMaster.PurchaseOrderMasterId = decPurchaseOrderMasterId;
                if (CheckCancelStatus(decPurchaseOrderMasterId))
                {
                    infoPurchaseOrderMaster.Cancelled = true;
                }
                else
                {
                    infoPurchaseOrderMaster.Cancelled = false;
                }
                infoPurchaseOrderMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoPurchaseOrderMaster.DueDate = Convert.ToDateTime(txtDueDate.Text);
                infoPurchaseOrderMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoPurchaseOrderMaster.SuffixPrefixId = Convert.ToDecimal(decPurchaseSuffixPrefixId);
                infoPurchaseOrderMaster.VoucherNo = strVoucherNo;
                infoPurchaseOrderMaster.VoucherTypeId = decPurchaseVoucherId;
                infoPurchaseOrderMaster.InvoiceNo = txtOrderNo.Text;
                infoPurchaseOrderMaster.UserId = PublicVariables._decCurrentUserId;
                infoPurchaseOrderMaster.EmployeeId = PublicVariables._decCurrentUserId;//by default current userid used as current employeeid
                infoPurchaseOrderMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPurchaseOrderMaster.Narration = txtNarration.Text.Trim();
                infoPurchaseOrderMaster.exchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                infoPurchaseOrderMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                infoPurchaseOrderMaster.Extra1 = string.Empty;
                infoPurchaseOrderMaster.Extra2 = string.Empty;
                BllPurchaseOrder.PurchaseOrderMasterEdit(infoPurchaseOrderMaster);
                RemovePurchaseOrderDetails();
                EditPurchaseOrderDetails();
                Messages.UpdatedMessage();
                if (frmPurchaseOrderRegisterObj != null)
                {
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decPurchaseOrderMasterId);
                        }
                        else
                        {
                            Print(decPurchaseOrderMasterId);
                        }
                    }
                    this.Close();
                    frmPurchaseOrderRegisterObj.GridFill();
                }
                if (frmPurchaseOrderReportObj != null)
                {
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decPurchaseOrderMasterId);
                        }
                        else
                        {
                            Print(decPurchaseOrderMasterId);
                        }
                    }
                    this.Close();
                    frmPurchaseOrderReportObj.GridFill();
                }
                if (frmDayBookObj != null)
                {
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decPurchaseOrderMasterId);
                        }
                        else
                        {
                            Print(decPurchaseOrderMasterId);
                        }
                    }
                    this.Close();
                }
                if (objVoucherSearch != null)
                {
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decPurchaseOrderMasterId);
                        }
                        else
                        {
                            Print(decPurchaseOrderMasterId);
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                PurchaseOrderMasterInfo infoPurchaseOrderMaster = new PurchaseOrderMasterInfo();
                PurchaseOrderBll BllPurchaseOrder = new  PurchaseOrderBll();
                PurchaseOrderDetailsInfo infoPurchaseOrderDetails = new PurchaseOrderDetailsInfo();
               
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                SettingsBll BllSettings = new SettingsBll();
                if (cbxCancel.Checked)
                {
                    infoPurchaseOrderMaster.Cancelled = true;
                }
                else
                {
                    infoPurchaseOrderMaster.Cancelled = false;
                }
                infoPurchaseOrderMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoPurchaseOrderMaster.DueDate = Convert.ToDateTime(txtDueDate.Text);
                infoPurchaseOrderMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                if (isAutomatic == true)
                {
                    infoPurchaseOrderMaster.SuffixPrefixId = decPurchaseSuffixPrefixId;
                    infoPurchaseOrderMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoPurchaseOrderMaster.SuffixPrefixId = 0;
                    infoPurchaseOrderMaster.VoucherNo = BllPurchaseOrder.VoucherNoMax(decPurchaseOrderTypeId);
                }
                infoPurchaseOrderMaster.VoucherTypeId = decPurchaseOrderTypeId;
                infoPurchaseOrderMaster.InvoiceNo = txtOrderNo.Text;
                infoPurchaseOrderMaster.UserId = PublicVariables._decCurrentUserId;
                infoPurchaseOrderMaster.EmployeeId = PublicVariables._decCurrentUserId;//by default current userid used as current employeeid
                infoPurchaseOrderMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPurchaseOrderMaster.Narration = txtNarration.Text.Trim();
                infoPurchaseOrderMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                infoPurchaseOrderMaster.exchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                infoPurchaseOrderMaster.Extra1 = string.Empty;
                infoPurchaseOrderMaster.Extra2 = string.Empty;
                decPurchaseOrderMasterIdentity = Convert.ToDecimal(BllPurchaseOrder.PurchaseOrderMasterAdd(infoPurchaseOrderMaster));
                int inRowcount = dgvPurchaseOrder.Rows.Count;
                for (int inI = 0; inI < inRowcount - 1; inI++)
                {
                    infoPurchaseOrderDetails.PurchaseOrderMasterId = decPurchaseOrderMasterIdentity;
                    if (dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductCode"].Value != null && dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString() != "")
                    {
                        infoProduct = BllProductCreation.ProductViewByCode(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoPurchaseOrderDetails.ProductId = infoProduct.ProductId;
                    }
                    if (dgvPurchaseOrder.Rows[inI].Cells["dgvtxtQty"].Value != null && dgvPurchaseOrder.Rows[inI].Cells["dgvtxtQty"].Value.ToString() != "")
                    {
                        infoPurchaseOrderDetails.Qty = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                    }
                    if (dgvPurchaseOrder.Rows[inI].Cells["dgvcmbUnit"].Value != null && dgvPurchaseOrder.Rows[inI].Cells["dgvcmbUnit"].Value.ToString() != "")
                    {
                        infoPurchaseOrderDetails.UnitId = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvcmbUnit"].Value);
                        infoPurchaseOrderDetails.UnitConversionId = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                    }
                    infoPurchaseOrderDetails.Rate = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                    infoPurchaseOrderDetails.Amount = Convert.ToDecimal(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                    infoPurchaseOrderDetails.SlNo = Convert.ToInt32(dgvPurchaseOrder.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                    infoPurchaseOrderDetails.Extra1 = string.Empty;
                    infoPurchaseOrderDetails.Extra2 = string.Empty;
                    BllPurchaseOrder.PurchaseOrderDetailsAdd(infoPurchaseOrderDetails);
                }
                Messages.SavedMessage();
                if (cbxPrintAfterSave.Checked)
                {
                    if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(decPurchaseOrderMasterIdentity);
                    }
                    else
                    {
                        Print(decPurchaseOrderMasterIdentity);
                    }
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check the repetation of same product
        /// </summary>
        /// <returns></returns>
        public bool ProductSameOccourance()
        {
            bool isSame = false;
            try
            {
                int index = dgvPurchaseOrder.CurrentRow.Index;
                string strName = dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    string strOther = dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                    if (strName == strOther)
                    {
                        inCurrentIndex = dgvPurchaseOrder.Rows[inI].Cells["dgvtxtProductName"].RowIndex;
                    }
                }
                dgvPurchaseOrder.Rows[inCurrentIndex].HeaderCell.Value = "";
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSame;
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedgerForm(decimal decId)
        {
            try
            {
                CashOrPartyComboFill();
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
                this.Enabled = true;
                cmbCashOrParty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                decPurchaseOrderMasterId = decMasterId;
                FillRegisterOrReport(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Unit combofill function
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
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvPurchaseOrder.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                FillProducts(false, null);
                CashOrPartyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// TO add a new ledger using these button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCashOrPartyAdd_Click(object sender, EventArgs e)
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
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                    frmAccountLedgerObj.CallFromPurchaseOrder(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromPurchaseOrder(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to set the date textbox value as dtp's selected value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtDate.Text = this.dtpDate.Value.ToString("dd-MMM-yyyy");
                txtDate.Focus();
                CurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to set the dtpDueDate textbox value as dtp's selected value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtDueDate.Text = this.dtpDueDate.Value.ToString("dd-MMM-yyyy");
                txtDueDate.Focus();
                if (Convert.ToDateTime(txtDate.Text) == Convert.ToDateTime(txtDueDate.Text))
                {
                    txtDueDays.Text = "0";
                }
                else
                {
                    DueDays();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation and setting the current value of date textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {

                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtDate);
                if (!isInvalid)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the due days function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DueDays();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation and setting the current value of DueDate textbox
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
                dtpDueDate.Value = Convert.ToDateTime(txtDueDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to call the validation and for calling keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvPurchaseOrder.CurrentCell != null && dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    if (dgvPurchaseOrder.CurrentCell != null && dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvPurchaseOrder.CurrentCell != null && dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name != "dgvtxtProductCode" && dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name != "dgvtxtProductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvPurchaseOrder.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Doing the grid calculations other functions in grid CellEndEdit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            ProductInfo infoProduct = new ProductInfo();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                isValueChange = false;
                isDoAfterGridFill = false;
                if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "dgvtxtProductName")
                {
                    string strProductName = string.Empty;
                    if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value != null && dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString().Trim() != string.Empty)
                    {
                        strProductName = dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString();
                    }
                    infoProduct = BllProductCreation.ProductViewByName(strProductName);
                    if (infoProduct.ProductCode != null && infoProduct.ProductCode != string.Empty)
                    {
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value = infoProduct.ProductId;
                        UnitComboFill(infoProduct.ProductId, e.RowIndex, dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces).ToString();
                        UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                        listunitconversionViewAll = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                        foreach (DataRow drUnitByProduct in listunitconversionViewAll[0].Rows)
                        {
                            if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                            {
                                dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = drUnitByProduct.ItemArray[2].ToString();
                                dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value = drUnitByProduct.ItemArray[3].ToString();
                            }
                        }
                        decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value.ToString());
                        decCurrentRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                        NewAmountCalculation("dgvtxtQty", e.RowIndex);
                        CalculateTotalAmount();
                    }
                    else
                    {
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value = string.Empty;
                    }
                }
                else if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "dgvtxtProductCode")
                {
                    string strPrdCode = string.Empty;
                    if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                    {
                        strPrdCode = dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                    }
                    infoProduct = BllProductCreation.ProductViewByCode(strPrdCode);
                    if (infoProduct.ProductId != 0)
                    {
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value = infoProduct.ProductId;
                        decimal decproductId = infoProduct.ProductId;
                        UnitComboFill(infoProduct.ProductId, e.RowIndex, dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                        UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                        listunitconversionViewAll = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                        foreach (DataRow drUnitByProduct in listunitconversionViewAll[0].Rows)
                        {
                            if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                            {
                                dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = drUnitByProduct.ItemArray[2].ToString();
                                dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value = drUnitByProduct.ItemArray[3].ToString();
                            }
                        }
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                        if (infoProduct.PartNo != string.Empty)
                        {
                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = infoProduct.PartNo;
                        }
                        decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value.ToString());
                        decCurrentRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                        NewAmountCalculation("dgvtxtQty", e.RowIndex);
                        CalculateTotalAmount();
                    }
                    else
                    {
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value = string.Empty;
                    }
                }
                else if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "dgvtxtBarcode")
                {
                    string strBCode = string.Empty;
                    if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value != null && dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString().Trim() != string.Empty)
                    {
                        strBCode = dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString();
                    }
                    listObj = BllProductCreation.ProductDetailsCoreespondingToBarcode(strBCode);
                    if (listObj[0].Rows.Count > 0)
                    {
                        foreach (DataRow RowDetails in listObj[0].Rows)
                        {
                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value = RowDetails["productId"].ToString();
                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = RowDetails["productCode"].ToString();
                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = RowDetails["productName"].ToString();
                            UnitComboFill(Convert.ToDecimal(RowDetails["productId"].ToString()), e.RowIndex, dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(RowDetails["unitId"].ToString());
                            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                            listunitconversionViewAll = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                            foreach (DataRow drUnitByProduct in listunitconversionViewAll[0].Rows)
                            {
                                if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                {
                                    dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = drUnitByProduct.ItemArray[2].ToString();
                                    dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value = drUnitByProduct.ItemArray[3].ToString();
                                }
                            }
                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(Convert.ToDecimal(RowDetails["purchaseRate"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                            decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value.ToString());
                            decCurrentRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                            NewAmountCalculation("dgvtxtQty", e.RowIndex);
                            CalculateTotalAmount();
                        }
                    }
                    else
                    {
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = string.Empty;
                        dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value = string.Empty;
                    }
                }
                CheckInvalidEntries(e);
                isAmountcalc = true;
                isValueChange = true;
                isDoAfterGridFill = true;
                if (txtTotalAmount.Text.ToString().Split('.')[0].Length > 13)
                {
                    MessageBox.Show("Amount exxed than limit");
                    dgvPurchaseOrder.Rows.RemoveAt(dgvPurchaseOrder.Rows.Count - 2);
                    CalculateTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PO49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (frmLedgerPopupObj != null)
                {
                    frmLedgerPopupObj.Close();
                    frmLedgerPopupObj = null;
                }
                if (frmProductSearchPopupObj != null)
                {
                    frmProductSearchPopupObj.Close();
                    frmProductSearchPopupObj = null;
                }
                if (frmPurchaseOrderRegisterObj != null)
                {
                    frmPurchaseOrderRegisterObj.Close();
                    frmPurchaseOrderRegisterObj = null;
                }
                if (frmPurchaseOrderReportObj != null)
                {
                    frmPurchaseOrderReportObj.Close();
                    frmPurchaseOrderReportObj = null;
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Close();
                    objVoucherSearch = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove button click, to remove a row from grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvPurchaseOrder.SelectedCells.Count > 0 && dgvPurchaseOrder.CurrentRow != null)
                {
                    if (!dgvPurchaseOrder.Rows[dgvPurchaseOrder.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvPurchaseOrder.CurrentRow.Cells["dgvtxtPurchaseOrderDetailsId"].Value != null && dgvPurchaseOrder.CurrentRow.Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString() != "")
                                {
                                    lstArrOfRemove.Add(dgvPurchaseOrder.CurrentRow.Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString());
                                    RemoveFunction();
                                    CalculateTotalAmount();
                                }
                                else
                                {
                                    RemoveFunction();
                                    CalculateTotalAmount();
                                }
                            }
                            else
                            {
                                RemoveFunction();
                                CalculateTotalAmount();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PO52:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid data error event to avoid data errors in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO53:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Commit the each and every changes of grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPurchaseOrder.IsCurrentCellDirty)
                {
                    dgvPurchaseOrder.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO54:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cancel cahange status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCancel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCancel.Checked && !isCheck)
                {
                    if (MessageBox.Show("Are you sure you want to cancel ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PurchaseOrderCancel();
                    }
                    else
                    {
                        cbxCancel.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO55:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// cell enter event for unit conversion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPurchaseOrder.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvPurchaseOrder.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvPurchaseOrder.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                    {
                        if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value != null && dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value.ToString() != string.Empty)
                        {

                            if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value != null && dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                            {
                                decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value.ToString());
                                decCurrentRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO56:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To unit conversion and grid calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isValueChange)
                {
                    ProductCreationBll BllProductCreation = new ProductCreationBll();
                    if (e.RowIndex > -1 && e.ColumnIndex > -1)
                    {
                        CheckInvalidEntries(e);
                        if (e.ColumnIndex == dgvPurchaseOrder.Columns["dgvcmbUnit"].Index)
                        {
                            if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value != null && dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                            {
                                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                                List<DataTable> ListObj = new List<DataTable>();
                                ListObj = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                                foreach (DataRow drUnitByProduct in ListObj[0].Rows)
                                {
                                    if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value != null)
                                    {
                                        if (dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                        {
                                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                            dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                            if (isDoAfterGridFill)
                                            {
                                                decimal decNewConversionRate = Convert.ToDecimal(dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtUnitConversionRate"].Value.ToString());
                                                decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                                dgvPurchaseOrder.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
                                                NewAmountCalculation("dgvtxtQty", e.RowIndex);
                                                CalculateTotalAmount();
                                            }
                                        }
                                    }
                                }
                            }
                            CheckInvalidEntries(e);
                        }
                        else if (e.ColumnIndex == dgvPurchaseOrder.Columns["dgvtxtQty"].Index && isAmountcalc)
                        {
                            NewAmountCalculation("dgvtxtQty", e.RowIndex);
                            CalculateTotalAmount();
                            CheckInvalidEntries(e);
                        }
                        else if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "dgvtxtExchangeRate" && isAmountcalc)
                        {
                            NewAmountCalculation("dgvtxtExchangeRate", e.RowIndex);
                            CheckInvalidEntries(e);
                        }
                        else if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "dgvtxtRate" && isAmountcalc)
                        {
                            NewAmountCalculation("dgvtxtRate", e.RowIndex);
                            CalculateTotalAmount();
                            CheckInvalidEntries(e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO57:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  to generate serial no automatically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO58:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (decProductId != 0)
                {
                    this.Enabled = true;
                    ProductInfo infoProduct = new ProductInfo();
                    ProductCreationBll BllProductCreation = new ProductCreationBll();
                    infoProduct = BllProductCreation.productViewByProductId(decProductId);
                    isValueChange = true;
                    dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                    dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                    dgvPurchaseOrder.CurrentRow.Cells["dgvtxtRate"].Value = infoProduct.PurchaseRate;
                    UnitComboFill(decProductId, dgvPurchaseOrder.CurrentRow.Index, dgvPurchaseOrder.CurrentRow.Cells["dgvcmbUnit"].ColumnIndex);
                    dgvPurchaseOrder.CurrentRow.Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                    listunitconversionViewAll = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(infoProduct.ProductCode);
                    foreach (DataRow drUnitByProduct in listunitconversionViewAll[0].Rows)
                    {
                        if (dgvPurchaseOrder.CurrentRow.Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                        {
                            dgvPurchaseOrder.CurrentRow.Cells["dgvtxtUnitConversionId"].Value = drUnitByProduct.ItemArray[2].ToString();
                            dgvPurchaseOrder.CurrentRow.Cells["dgvtxtUnitConversionRate"].Value = drUnitByProduct.ItemArray[3].ToString();
                        }
                    }
                    decCurrentConversionRate = Convert.ToDecimal(dgvPurchaseOrder.CurrentRow.Cells["dgvtxtUnitConversionRate"].Value.ToString());
                    decCurrentRate = Convert.ToDecimal(dgvPurchaseOrder.CurrentRow.Cells["dgvtxtRate"].Value.ToString());
                    NewAmountCalculation("dgvtxtQty", dgvPurchaseOrder.CurrentRow.Index);
                    CalculateTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO59:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
        /// <summary>
        /// For Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtDate.Enabled)
                    {
                        txtDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO60:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button click
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
                MessageBox.Show("PO61:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
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
                    btnSave.Focus();
                    btnSave_Click(sender, e);
                }
                if (btnDelete.Enabled == true)
                {
                    if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                    {

                        btnDelete_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    if (dgvPurchaseOrder.CurrentCell != null)
                    {
                        if (dgvPurchaseOrder.CurrentCell == dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"] || dgvPurchaseOrder.CurrentCell == dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductCode"])
                        {
                            SendKeys.Send("{F10}");
                            if (dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                            {
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                frmProductCreationObj.CallFromPurchaseOrder(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO62:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDate.Text == string.Empty && txtDate.SelectionStart == 0)
                    {
                        if (txtOrderNo.Enabled == true)
                        {
                            txtOrderNo.Focus();
                            txtOrderNo.SelectionLength = 0;
                            txtOrderNo.SelectionStart = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO63:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key, backspace navigation and create new ledger from here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtDueDate.Enabled)
                    {
                        txtDueDate.Focus();
                        txtDueDate.SelectionStart = 0;
                        txtDueDate.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDate.Enabled)
                    {
                        txtDate.Focus();
                        txtDate.SelectionLength = 0;
                        txtDate.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbCashOrParty.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromPurchaseOrder(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryCreditors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)//new ledger add
                {
                    btnCashOrPartyAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO64:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        txtDueDays.Focus();
                        txtDueDays.SelectionLength = 0;
                        txtDueDays.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled)
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
                MessageBox.Show("PO65:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtDueDays.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDueDate.Enabled)
                    {
                        txtDueDate.Focus();
                        txtDueDate.SelectionLength = 0;
                        txtDueDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO66:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDueDays_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPurchaseOrder.Enabled)
                    {
                        dgvPurchaseOrder.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        txtDueDate.Focus();
                        txtDueDate.SelectionLength = 0;
                        txtDueDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO67:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key, backspace navigation and Find and search a new product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int indgvdgvPurchaseOrderRowCount = dgvPurchaseOrder.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPurchaseOrder.CurrentCell == dgvPurchaseOrder.Rows[indgvdgvPurchaseOrderRowCount - 1].Cells["dgvtxtAmount"])
                    {
                        dgvPurchaseOrder.ClearSelection();
                        txtNarration.Focus();
                        txtNarration.SelectionStart = 0;
                        txtNarration.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvPurchaseOrder.Columns[dgvPurchaseOrder.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        if (dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductCode"].Value != null || dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            frmProductSearchPopupObj.CallFromPurchaseOrder(this, dgvPurchaseOrder.CurrentRow.Index, dgvPurchaseOrder.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString());
                        }
                        else
                        {
                            frmProductSearchPopupObj.CallFromPurchaseOrder(this, dgvPurchaseOrder.CurrentRow.Index, string.Empty);
                        }
                    }
                }
                if (dgvPurchaseOrder.RowCount > 0)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO68:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        dgvPurchaseOrder.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO69:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cbxPrintAfterSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO70:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnDelete.Enabled)
                    {
                        btnDelete.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnSave.Enabled)
                    {
                        btnSave.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO71:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnClose.Enabled)
                    {
                        btnClose.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO72:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnDelete.Enabled)
                    {
                        btnDelete.Focus();
                    }
                    else
                    {
                        btnClear.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO73:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                isEdit = false;
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                }
                if (objfrmVoucherproduct != null)
                {
                    objfrmVoucherproduct.Enabled = true;
                    objfrmVoucherproduct.FillGrid();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO74:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
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
                        if (cbxCancel.Enabled == true)
                        {
                            cbxCancel.Focus();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO75:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCancel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxPrintAfterSave.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO76:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if (e.KeyCode == Keys.Back)
                {
                    if (cbxCancel.Enabled == true)
                    {
                        cbxCancel.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PO77:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void dtpDueDate_Leave(object sender, EventArgs e)
        {
            DateValidation ObjValidation = new DateValidation();
            ObjValidation.DateValidationFunction(txtDueDate);
            if (Convert.ToDateTime(txtDate.Text) > Convert.ToDateTime(txtDueDate.Text))
            {
                MessageBox.Show("DueDate should be greater than Date", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDueDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtDueDate.Text, out dt);
                dtpDate.Value = dt;

            }
            txtDueDays.Text = string.Empty;
        }
    }
}
