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

    public partial class frmMaterialReceipt : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strOldLedgerId = string.Empty;
        string strCashOrParty = string.Empty;
        string strPrefix = string.Empty;
        string strSuffix = string.Empty;
        string strVoucherNo = string.Empty;
        string strproductId = string.Empty;
        string strProductCode = string.Empty;
        string tableName = "MaterialReceiptMaster";
        string strReceiptNo = string.Empty;
        string strAgainstVoucherNo = string.Empty;
        bool isOrderFil = false;
        bool isValueChanged = false;
        bool isAmountcalc = true;
        bool isDontExecuteCashorParty = false;
        bool isDontExecuteVoucherType = false;
        bool isValueChange = false;
        bool isAutomatic = false;
        bool isEditFill = false;
        bool isEdit = false;
        bool isDoAfterGridFill = false;
        int inNarrationCount = 0;
        int inMaxCount = 0;
        decimal decGodownId = 0;
        decimal decBatchId = 0;
        decimal decMaterialReceiptId = 0;
        decimal decMaterialReceiptMasterId = 0;
        decimal decMaterialReceiptDetailId = 0;
        decimal decMaterialReceiptTypeId = 0;
        decimal decMaterialReceiptVoucherTypeId = 0;
        decimal decMaterialReceiptSuffixPrefixId = 0;
        decimal decMaterialReceiptMasterIdentity = 0;
        decimal decPurchaseOrderVoucherTypeId = 0;
        decimal decEdit = 0;
        decimal decAgainstVoucherTypeId = 0;
        decimal decCurrentConversionRate = 0;
        decimal decCurrentRate = 0;
        decimal decOrderNoWhileEditMode = 0;
        ArrayList lstArrOfRemove = new ArrayList();
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        DataGridViewTextBoxEditingControl TextBoxControl;
        List<DataTable> ListObj = new List<DataTable>();
        DataTable dtblUnitViewAll = new DataTable();
        DataTable dtblunitconversionViewAll = new DataTable();
        frmMaterialReceiptRegister frmMaterialReceiptRegisterObj;
        frmMaterialReceiptReport frmMaterialReceiptReportObj = null;
        frmProductSearchPopup frmProductSearchPopupObj;
        frmVoucherSearch objVoucherSearch = null;
        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
        frmDayBook frmDayBookObj = null;//To use in call from frmDaybook
        frmVoucherWiseProductSearch objVoucherProduct = null;
        string[] strArrOfRemove = new string[100];
        #endregion
        #region Functions
        /// <summary>
        /// Create instance of frmMaterialReceipt
        /// </summary>
        public frmMaterialReceipt()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to generate voucherNo
        /// </summary>
        public void VoucherNumberGeneration()
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = obj.VoucherNumberAutomaicGeneration(decMaterialReceiptVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                if (Convert.ToDecimal(strVoucherNo) != bllMaterialReceiptMaster.MaterialReceiptMasterGetMaxPlusOne(decMaterialReceiptVoucherTypeId))
                {
                    strVoucherNo = bllMaterialReceiptMaster.MaterialReceiptMasterGetMax(decMaterialReceiptVoucherTypeId).ToString();
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(decMaterialReceiptVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    if (bllMaterialReceiptMaster.MaterialReceiptMasterGetMax(decMaterialReceiptVoucherTypeId) == "0")
                    {
                        strVoucherNo = "0";
                        strVoucherNo = obj.VoucherNumberAutomaicGeneration(decMaterialReceiptVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    }
                }
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decMaterialReceiptVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decMaterialReceiptSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    strReceiptNo = strPrefix + strVoucherNo + strSuffix;
                    txtReceiptNo.Text = strReceiptNo;
                    txtReceiptNo.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Funtion to load the form while calling from voucherwiseproductsearch 
        /// </summary>
        /// <param name="frmVoucherwiseProductSearch"></param>
        /// <param name="decmasterId"></param>
        public void CallFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherwiseProductSearch, decimal decmasterId)
        {
            try
            {
                base.Show();
                frmVoucherwiseProductSearch.Enabled = true;
                objVoucherProduct = frmVoucherwiseProductSearch;
                decMaterialReceiptMasterId = decmasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// It is a function for vouchertypeselection form to select perticular voucher and open the form under the vouchertype
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            try
            {
                decMaterialReceiptVoucherTypeId = decVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decMaterialReceiptVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decMaterialReceiptVoucherTypeId, dtpDate.Value);
                decMaterialReceiptSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtReceiptNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To select the product from ProductSearchPopup
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
            BatchBll BllBatch = new BatchBll();
            try
            {
                base.Show();
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                infoProduct = BllProductCreation.ProductView(decproductId);
                int inRowcount = dgvProduct.Rows.Count;
              
                for (int i = 0; i < inRowcount; i++)
                {
                    if (i == inRowcount - 1)
                    {
                        dgvProduct.Rows.Add();
                    }
                    if (i == decCurrentRowIndex)
                    {
                        SerialNo();
                        dgvProduct.Rows[i].Cells["dgvtxtproductCode"].Value = infoProduct.ProductCode;
                        dgvProduct.Rows[i].Cells["productId"].Value = decproductId.ToString();
                        dgvProduct.Rows[i].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                        dgvProduct.Rows[i].Cells["dgvcmbGodown"].Value = infoProduct.GodownId;
                        dgvProduct.Rows[i].Cells["dgvCmbRack"].Value = infoProduct.RackId;
                        UnitComboFill(decproductId, i, dgvProduct.Rows[i].Cells["dgvcmbUnit"].ColumnIndex);
                        dgvProduct.Rows[i].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;

                       
                        List<DataTable> list = new List<DataTable>();
                        list = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[i].Cells["productId"].Value.ToString());

                        dgvProduct.Rows[i].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                        dgvProduct.Rows[i].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(new UnitConvertionBll().UnitconversionIdViewByUnitIdAndProductId(infoProduct.UnitId, infoProduct.ProductId));
                        dgvProduct.CurrentRow.Cells["dgvtxtConversionRate"].Value = bllUnitConvertion.UnitConversionRateByUnitConversionId(Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtUnitConversionId"].Value.ToString()));
                        BatchComboFill(decproductId, i, dgvProduct.Rows[i].Cells["dgvcmbBatch"].ColumnIndex);
                        dgvProduct.Rows[i].Cells["dgvcmbBatch"].Value = BllBatch.BatchIdViewByProductId(decproductId);
                        RackComboFill(infoProduct.GodownId, i, dgvProduct.Rows[i].Cells["dgvCmbRack"].ColumnIndex);
                        dgvProduct.Rows[i].Cells["dgvtxtBarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvcmbBatch"].Value.ToString()));
                        list= bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoProduct.UnitId, infoProduct.ProductName);
                        dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value = list[0].Rows[0]["conversionRate"].ToString();
                        decCurrentConversionRate = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtConversionRate"].Value.ToString());
                        NewAmountCalculation("dgvtxtQty", i);
                        CalculateTotalAmount();
                       
                    }
                }
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Funtion to load the form while calling from voucherSearch
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSerach(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                objVoucherSearch = frm;
                decMaterialReceiptMasterId = decId; ;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the created product from ProductCreation form 
        /// </summary>
        /// <param name="decProductId"></param>
        public void ReturnFromProductCreation(decimal decProductId)
        {
            frmProductCreation productcreation = new frmProductCreation();
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                int inI = dgvProduct.CurrentRow.Index;
                this.Enabled = true;
                this.Activate();
                if (decProductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decProductId);
                    strProductCode = infoProduct.ProductCode;
                    productDetailsFillFromProductCreation(productcreation, decProductId, inI);
                }

                dgvProduct.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to fill the product details in dataGridView from productCreationPopup
        /// </summary>
        /// <param name="productcreation"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void productDetailsFillFromProductCreation(frmProductCreation productcreation, decimal decproductId, decimal decCurrentRowIndex)
        {
            try
            {
                decimal decCurrentConversionRate = 0;
                DataTable dtbl = new DataTable();
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                BatchBll BllBatch = new BatchBll();
                ProductInfo infoProductFill = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                ProductInfo infoProduct = new ProductInfo();
                int inI = dgvProduct.CurrentRow.Index;
                if (inI == dgvProduct.Rows.Count - 1)
                {
                    dgvProduct.Rows.Add();
                }
                  if (decproductId != 0)
                    {
                        infoProduct = BllProductCreation.ProductView(decproductId);
                        SerialNo();
                        dgvProduct.Rows[inI].Cells["dgvtxtproductCode"].Value = infoProduct.ProductCode;
                        dgvProduct.Rows[inI].Cells["productId"].Value = decproductId.ToString();
                        dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                        dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value = infoProduct.GodownId;
                        dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value = infoProduct.RackId;
                        UnitComboFill(decproductId, inI, dgvProduct.Rows[inI].Cells["dgvcmbUnit"].ColumnIndex);
                        dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;

                      
                        List<DataTable> list = new  List<DataTable>();
                        list = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[inI].Cells["productId"].Value.ToString());
                        //UnitComboFill(infoProduct.ProductId, dgvProduct.CurrentRow.Index, dgvProduct.CurrentRow.Cells["dgvcmbUnit"].ColumnIndex);
                        //dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                        dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                        dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(new UnitConvertionBll().UnitconversionIdViewByUnitIdAndProductId(infoProduct.UnitId, infoProduct.ProductId));
                        dgvProduct.CurrentRow.Cells["dgvtxtConversionRate"].Value = bllUnitConvertion.UnitConversionRateByUnitConversionId(Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString()));
                        BatchComboFill(decproductId, inI, dgvProduct.Rows[inI].Cells["dgvcmbBatch"].ColumnIndex);
                        dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value = BllBatch.BatchIdViewByProductId(decproductId);
                        RackComboFill(infoProduct.GodownId, inI, dgvProduct.Rows[inI].Cells["dgvCmbRack"].ColumnIndex);
                        dgvProduct.Rows[inI].Cells["dgvtxtBarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString()));
                        list = bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoProduct.UnitId, infoProduct.ProductName);
                        dgvProduct.Rows[inI].Cells["dgvtxtConversionRate"].Value = dtbl.Rows[0]["conversionRate"].ToString();
                        decCurrentConversionRate = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtConversionRate"].Value.ToString());

                        NewAmountCalculation("dgvtxtQty", inI);
                        CalculateTotalAmount();
                    }
                   
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR6:new" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// To select the ledger from ledger popup
        /// </summary>
        /// <param name="frmLedgerPopup"></param>
        /// <param name="decId"></param>
        /// <param name="strComboTypes"></param>
        public void CallFromLedgerPopup(frmLedgerPopup frmLedgerPopup, decimal decId, string strComboTypes) //PopUp
        {
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                base.Show();
                this.frmLedgerPopupObj = frmLedgerPopup;
                if (strComboTypes == "CashOrSundryCreditors")
                {
                    transactionGeneralFillObj.CashOrPartyComboFill(cmbCashOrParty, false);
                    cmbCashOrParty.SelectedValue = decId;

                }
                frmLedgerPopupObj.Close();
                frmLedgerPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to customize the form by checking the settings
        /// </summary>
        public void MaterialreceiptSettingsCheck()
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    dgvProduct.Columns["dgvcmbGodown"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvcmbGodown"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    dgvProduct.Columns["dgvCmbRack"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvCmbRack"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    dgvProduct.Columns["dgvcmbBatch"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvcmbBatch"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("Barcode") == "Yes")
                {
                    dgvProduct.Columns["dgvtxtBarcode"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvtxtBarcode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    dgvProduct.Columns["dgvcmbUnit"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvcmbUnit"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    dgvProduct.Columns["dgvtxtProductCode"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvtxtProductCode"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                txtDate.Clear();
                txtLRNo.Clear();
                txtNarration.Clear();
                txtReceiptNo.Clear();
                txtTotal.Clear();
                txtTransportation.Clear();
                dgvProduct.Rows.Clear();
                cmbOrderNo.DataSource = null;
                dtpDate.Value = PublicVariables._dtCurrentDate;
                txtDate.Text = dtpDate.Value.ToString("dd-MMM-yyyy");
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                DGVGodownComboFill();
                VoucherTypeCombofill();
                CashOrPartyComboFill();
                CurrencyComboFill();
                txtTotal.Text = "0.00";
                FillProducts(false, null);
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                if (isAutomatic)
                {
                    VoucherNumberGeneration();
                }
                if (!ShowBarcode())
                {
                    this.dgvProduct.Columns["dgvtxtBarcode"].Visible = false;
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
                MessageBox.Show("MR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentCell != null)
                {
                    if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                    if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtQty")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Funtion to check remaining  quantity with refernce to purchaseinvoice and rejectionout
        /// </summary>
        /// <returns></returns>
        public int QuantityCheckWithReference()
        {
            decimal decQtyRejectionOutAndPurchaseInvoice = 0;
            decimal decQtyMaterialReceipt = 0;
            decimal inRef = 0;
            int inF1 = 1;
            decimal decMaterialReceiptDetailsId = 0;
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            RejectionOutBll bllRejectionOut = new RejectionOutBll();
            try
            {
                foreach (DataGridViewRow dgvrow in dgvProduct.Rows)
                {
                    if (dgvrow.Cells["dgvtxtmaterialReceiptDetailsId"].Value != null)
                    {
                        if (dgvrow.Cells["dgvtxtmaterialReceiptDetailsId"].Value.ToString() != "0" || dgvrow.Cells["dgvtxtmaterialReceiptDetailsId"].Value.ToString() != string.Empty)
                        {
                            decMaterialReceiptDetailsId = Convert.ToDecimal(dgvrow.Cells["dgvtxtmaterialReceiptDetailsId"].Value.ToString());
                            inRef = bllMaterialReceiptMaster.MaterialReceiptDetailsReferenceCheck(decMaterialReceiptDetailsId);
                            if (inRef == 1)
                            {
                                if (inF1 == 1)
                                {
                                    if (dgvrow.Cells["dgvtxtQty"].Value != null)
                                    {
                                        if (dgvrow.Cells["dgvtxtQty"].Value.ToString() != "0" || dgvrow.Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                                        {
                                            decQtyMaterialReceipt = Convert.ToDecimal(dgvrow.Cells["dgvtxtQty"].Value.ToString());
                                            decQtyRejectionOutAndPurchaseInvoice = Math.Round(bllMaterialReceiptMaster.MaterialReceiptQuantityDetailsAgainstPurcahseInvoiceAndRejectionOut(decMaterialReceiptDetailsId), PublicVariables._inNoOfDecimalPlaces);
                                            if (decQtyMaterialReceipt >= decQtyRejectionOutAndPurchaseInvoice)
                                            {
                                                inF1 = 1;
                                            }
                                            else
                                            {
                                                inF1 = 0;
                                                Messages.InformationMessage("Quantity in row " + (dgvrow.Index + 1) + " should be greater than " + decQtyRejectionOutAndPurchaseInvoice);
                                            }
                                        }
                                        else
                                        {
                                            inF1 = 0;
                                            Messages.InformationMessage("Quantity in row " + (dgvrow.Index + 1) + " should be greater than " + decQtyRejectionOutAndPurchaseInvoice);
                                        }
                                    }
                                    else
                                    {
                                        inF1 = 0;
                                        Messages.InformationMessage("Quantity in row " + (dgvrow.Index + 1) + " should be greater than " + decQtyRejectionOutAndPurchaseInvoice);
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
                MessageBox.Show("MR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inF1;
        }
        /// <summary>
        /// Function to remove material receipt details of removed row
        /// </summary>
        public void removeMaterialReceiptDetails()
        {
            MaterialReceiptBll bllMaterialReceiptMasterDetails = new MaterialReceiptBll();
            try
            {
                foreach (var strId in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strId);
                    bllMaterialReceiptMasterDetails.MaterialReceiptDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR12: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the occurances of same product
        /// </summary>
        /// <returns></returns>
        public bool ProductSameOccourance()
        {
            bool isSame = false;
            string strName = string.Empty;
            try
            {
                //to check if same name in any row if row not equal to x
                int index = dgvProduct.CurrentRow.Index;
                if (dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value != null && dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                {
                    strName = dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                }
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    if (dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                    {
                        string strOther = dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                        if (strName == strOther)
                        {
                            inCurrentIndex = dgvProduct.Rows[inI].Cells["dgvtxtProductName"].RowIndex;
                        }
                    }
                }
                dgvProduct.Rows[inCurrentIndex].HeaderCell.Value = string.Empty;
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSame;
        }
        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the MaterialReceipt register
        /// </summary>
        /// <param name="frmMaterialReceiptRegister"></param>
        /// <param name="decMaterialReceiptMasterid"></param>
        /// <param name="decPOVoucherTypeId"></param>
        public void CallFromMaterialReceiptRegister(frmMaterialReceiptRegister frmMaterialReceiptRegister, decimal decMaterialReceiptMasterid, decimal decPOVoucherTypeId)
        {
            try
            {
                base.Show();
                this.frmMaterialReceiptRegisterObj = frmMaterialReceiptRegister;
                frmMaterialReceiptRegister.Enabled = false;
                decMaterialReceiptMasterId = decMaterialReceiptMasterid;
                decPurchaseOrderVoucherTypeId = decPOVoucherTypeId;
                FillRegisterOrReport();
                if (txtReceiptNo.ReadOnly)
                {
                    txtDate.Select();
                }
                else
                    txtReceiptNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the MaterialReceipt report
        /// </summary>
        /// <param name="frmMaterialReceiptReport"></param>
        /// <param name="decMaterialReceiptMasterid"></param>
        /// <param name="decPOVoucherTypeId"></param>
        public void CallFromMaterialReceiptReport(frmMaterialReceiptReport frmMaterialReceiptReport, decimal decMaterialReceiptMasterid, decimal decPOVoucherTypeId)
        {
            try
            {
                base.Show();
                this.frmMaterialReceiptReportObj = frmMaterialReceiptReport;
                frmMaterialReceiptReport.Enabled = false;
                decMaterialReceiptMasterId = decMaterialReceiptMasterid;
                decPurchaseOrderVoucherTypeId = decPOVoucherTypeId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the fields for edit or delete
        /// </summary>
        public void FillRegisterOrReport()
        {
            MaterialReceiptMasterInfo infoMaterialReceiptMaster = new MaterialReceiptMasterInfo();
            MaterialReceiptDetailsInfo infoMaterialReceiptDetails = new MaterialReceiptDetailsInfo();
            VoucherTypeBll BllVoucherType = new VoucherTypeBll();
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            MaterialReceiptBll bllMaterialReceiptDetails = new MaterialReceiptBll();
            PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
            try
            {
                
                PurchaseOrderMasterInfo infoPurchaseOrder = new PurchaseOrderMasterInfo();
                decimal decTotal = 0;
                decimal decStatus = bllMaterialReceiptMaster.MaterialReceiptMasterReferenceCheck(decMaterialReceiptMasterId);
                if (decStatus == 0)
                {
                    cmbCashOrParty.Enabled = false;
                    cmbOrderNo.Enabled = false;
                    cmbcurrency.Enabled = false;
                    txtDate.Enabled = false;
                    cmbVoucherType.Enabled = false;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtReceiptNo.ReadOnly = true;
                infoMaterialReceiptMaster = bllMaterialReceiptMaster.MaterialReceiptMasterView(decMaterialReceiptMasterId);
                txtReceiptNo.Text = infoMaterialReceiptMaster.InvoiceNo;
                strVoucherNo = infoMaterialReceiptMaster.VoucherNo.ToString();
                decMaterialReceiptSuffixPrefixId = Convert.ToDecimal(infoMaterialReceiptMaster.SuffixPrefixId);
                decMaterialReceiptVoucherTypeId = Convert.ToDecimal(infoMaterialReceiptMaster.VoucherTypeId);
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decMaterialReceiptVoucherTypeId);
                decMaterialReceiptTypeId = decMaterialReceiptVoucherTypeId;
                txtDate.Text = infoMaterialReceiptMaster.Date.ToString("dd-MMM-yyyy");
                cmbCashOrParty.SelectedValue = infoMaterialReceiptMaster.LedgerId;
                if (infoMaterialReceiptMaster.OrderMasterId != 0)
                {
                    infoPurchaseOrder = BllPurchaseOrder.PurchaseOrderMasterView(Convert.ToDecimal(infoMaterialReceiptMaster.OrderMasterId.ToString()));
                    decPurchaseOrderVoucherTypeId = infoPurchaseOrder.VoucherTypeId;
                    cmbVoucherType.SelectedValue = decPurchaseOrderVoucherTypeId;
                    cmbOrderNo.SelectedValue = infoMaterialReceiptMaster.OrderMasterId.ToString();
                    decOrderNoWhileEditMode = infoMaterialReceiptMaster.OrderMasterId;
                }
                else
                {
                    cmbVoucherType.SelectedValue = 0;
                }
                txtTransportation.Text = infoMaterialReceiptMaster.TransportationCompany;
                txtNarration.Text = infoMaterialReceiptMaster.Narration;
                txtLRNo.Text = infoMaterialReceiptMaster.LrNo;
                CurrencyComboFill();
                cmbcurrency.SelectedValue = infoMaterialReceiptMaster.exchangeRateId;
                decTotal = Convert.ToDecimal(infoMaterialReceiptMaster.TotalAmount.ToString());
                decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                txtTotal.Text = Convert.ToString(decTotal);
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllMaterialReceiptDetails.MaterialReceiptDetailsViewByMasterId(decMaterialReceiptMasterId);
                dgvProduct.Rows.Clear();
                for (int i = 0; i < ListObj[0].Rows.Count; i++)
                {
                    isAmountcalc = false;
                    isValueChange = false;
                    dgvProduct.Rows.Add();
                    dgvProduct.Rows[i].Cells["dgvtxtMaterialReceiptdetailsId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["materialReceiptDetailsId"].ToString());
                    decMaterialReceiptDetailId = Convert.ToDecimal(ListObj[0].Rows[i]["materialReceiptDetailsId"].ToString());
                    dgvProduct.Rows[i].Cells["dgvtxtSlNo"].Value = ListObj[0].Rows[i]["slno"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtProductCode"].Value = ListObj[0].Rows[i]["productCode"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtProductName"].Value = ListObj[0].Rows[i]["productName"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtQty"].Value = ListObj[0].Rows[i]["qty"].ToString();
                    dgvProduct.Rows[i].Cells["productId"].Value = ListObj[0].Rows[i]["productId"].ToString();
                    decimal decProductId = Convert.ToDecimal(ListObj[0].Rows[i]["productId"].ToString());
                    UnitComboFill(decProductId, i, dgvProduct.Rows[i].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvProduct.Rows[i].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["unitId"].ToString());
                    DGVGodownComboFill();
                    dgvProduct.Rows[i].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["godownId"].ToString());
                    decGodownId = Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvcmbGodown"].Value);
                    RackComboFill(decGodownId, i, dgvProduct.Rows[i].Cells["dgvCmbRack"].ColumnIndex);
                    if (Convert.ToDecimal(ListObj[0].Rows[i]["orderDetailsId"].ToString()) == 0)
                    {
                        dgvProduct.Rows[i].Cells["dgvtxtPurchaseOrderDetailsId"].Value = 0;
                    }
                    else
                    {
                        dgvProduct.Rows[i].Cells["dgvtxtPurchaseOrderDetailsId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["orderDetailsId"].ToString());

                    }
                    dgvProduct.Rows[i].Cells["dgvCmbRack"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["rackId"].ToString());
                    BatchComboFill(decProductId, i, Convert.ToInt32(dgvProduct.Rows[i].Cells["dgvcmbBatch"].ColumnIndex));
                    dgvProduct.Rows[i].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["batchId"].ToString());
                    dgvProduct.Rows[i].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["unitConversionId"].ToString());
                    dgvProduct.Rows[i].Cells["dgvtxtBarcode"].Value = ListObj[0].Rows[i]["barcode"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtRate"].Value = ListObj[0].Rows[i]["rate"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtAmount"].Value = ListObj[0].Rows[i]["amount"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtvouchertypeId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["voucherTypeId"].ToString());
                    dgvProduct.Rows[i].Cells["dgvtxtvoucherNo"].Value = ListObj[0].Rows[i]["voucherNo"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtinvoiceNo"].Value = ListObj[0].Rows[i]["invoiceNo"].ToString();
                    decAgainstVoucherTypeId = Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtvouchertypeId"].Value.ToString());
                    strAgainstVoucherNo = dgvProduct.Rows[i].Cells["dgvtxtvoucherNo"].Value.ToString();
                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                    List<DataTable> listObjUnitByProduct = new List<DataTable>();
                    listObjUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(decProductId.ToString());
                    foreach (DataRow drUnitByProduct in listObjUnitByProduct[0].Rows)
                    {
                        if (dgvProduct.Rows[i].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                        {
                            dgvProduct.Rows[i].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                            dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                        }
                    }
                    decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtRate"].Value.ToString());
                    decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value.ToString());
                    decimal decReference = bllMaterialReceiptMaster.MaterialReceiptDetailsReferenceCheck(decMaterialReceiptDetailId);
                    if (decReference == 1 || Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString())!=0)
                    {
                        dgvProduct.Rows[i].Cells["dgvtxtProductCode"].ReadOnly = true;
                        dgvProduct.Rows[i].Cells["dgvtxtProductName"].ReadOnly = true;
                        dgvProduct.Rows[i].Cells["dgvcmbUnit"].ReadOnly = true;
                        dgvProduct.Rows[i].Cells["dgvtxtBarcode"].ReadOnly = true;
                        dgvProduct.Rows[i].Cells["dgvCmbRack"].ReadOnly = true;
                        dgvProduct.Rows[i].Cells["dgvcmbGodown"].ReadOnly = true;
                        dgvProduct.Rows[i].Cells["dgvtxtRate"].ReadOnly = true;
                        dgvProduct.Rows[i].Cells["dgvcmbBatch"].ReadOnly = true;
                    }
                    if (cmbVoucherType.Text != "NA")
                    {
                        dgvProduct.Rows[i].Cells["dgvcmbUnit"].ReadOnly = true;
                    }

                    
                }
                isAmountcalc = true;
                isValueChange = true;
                isDoAfterGridFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove rows from grid
        /// </summary>
        public void RemoveFunction()
        {
            try
            {
                int inRowCount = dgvProduct.RowCount;
                int index = dgvProduct.CurrentRow.Index;
                int inC = 0;
                if (inRowCount > 2)
                {
                    if (dgvProduct.CurrentRow.HeaderCell.Value == null)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            string strName = dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                            int inIndex = dgvProduct.CurrentRow.Cells["dgvtxtProductName"].RowIndex;
                            string strOther;
                            for (int inI = 0; inI < inRowCount - 1; inI++)
                            {
                                inC++;
                                strOther = dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                                if (inIndex != dgvProduct.Rows[inI].Cells["dgvtxtProductName"].RowIndex)
                                {
                                    if (ProductSameOccourance())
                                    {
                                        dgvProduct.Rows.RemoveAt(index);
                                        return;
                                    }
                                    else
                                    {
                                        if (inC == inRowCount - 1)
                                        {
                                            dgvProduct.Rows.RemoveAt(index);
                                            inC = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    dgvProduct.Rows.RemoveAt(index);
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvProduct.Rows.RemoveAt(index);
                    }
                }
                else
                {
                    dgvProduct.Rows.RemoveAt(index);
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Function to check Printaftersave checkbox status
        /// </summary>
        /// <returns></returns>
        public bool PrintAfetrSave()
        {
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            bool isTick = false;
            try
            {
                isTick = transactionGeneralFillObj.StatusOfPrintAfterSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }

        /// <summary>
        /// Function to check the barcode status
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
                MessageBox.Show("MR19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// Function to check the invalid entries
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)// To check whether the values of grid is valid
        {
            try
            {
                if (dgvProduct.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == string.Empty || Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value.ToString()) <= 0)
                        {
                            isValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtAmount"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtAmount"].Value.ToString() == string.Empty)// || Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtAmount"].Value.ToString()) == 0)
                        {
                            isValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// AutoCompletion of Product,productCode
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
                MessageBox.Show("MR21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the godown combobox
        /// </summary>
        public void DGVGodownComboFill()
        {
            try
            {
                GodownBll bllGodown = new GodownBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllGodown.GodownViewAll();
                dgvcmbGodown.DataSource = ListObj[0];
                dgvcmbGodown.ValueMember = "godownId";
                dgvcmbGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Vouchertype combobox
        /// </summary>
        public void VoucherTypeCombofill()
        {

            PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
            try
            {
                isDontExecuteVoucherType = true;
                ListObj= BllPurchaseOrder.VoucherTypeCombofillforPurchaseOrderReport();
                cmbVoucherType.DataSource = ListObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = 0;
                isDontExecuteVoucherType = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Rack combobox
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
                DataGridViewComboBoxCell dgvcmbRackCell = (DataGridViewComboBoxCell)dgvProduct.Rows[inRow].Cells[inColumn];
                dgvcmbRackCell.DataSource = listObj[0];
                dgvcmbRackCell.ValueMember = "rackId";
                dgvcmbRackCell.DisplayMember = "rackName";
                dgvProduct.Rows[inRow].Cells["dgvCmbRack"].Value = Convert.ToDecimal(listObj[0].Rows[0]["rackId"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the batch combobox
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="inRow"></param>
        /// <param name="inColumn"></param>
        public void BatchComboFill(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> listObJ = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                listObJ = BllBatch.BatchNamesCorrespondingToProduct(decProductId);
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvProduct.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = listObJ[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the currency combobox
        /// </summary>
        public void CurrencyComboFill()
        {
            try
            {
                isValueChanged = true;
                List<DataTable> listObjCurrency = new List<DataTable>();
                SettingsBll BllSettings = new SettingsBll();
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                listObjCurrency = TransactionGeneralFillObj.CurrencyComboByDate(Convert.ToDateTime(txtDate.Text));
                cmbcurrency.DataSource = listObjCurrency[0];
                cmbcurrency.DisplayMember = "currencyName";
                cmbcurrency.ValueMember = "exchangeRateId";
                cmbcurrency.SelectedValue = 1m;
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    cmbcurrency.Enabled = true;
                }
                else
                {
                    cmbcurrency.Enabled = false;
                }
                isValueChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate total amount
        /// </summary>
        private void CalculateTotalAmount()
        {
            try
            {
                {
                    decimal decTotal = 0;
                    foreach (DataGridViewRow dgvrow in dgvProduct.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtAmount"].Value != null)
                            if (Convert.ToString(dgvrow.Cells["dgvtxtAmount"].Value) != string.Empty)
                            {
                                decTotal = decTotal + Convert.ToDecimal(Convert.ToString(dgvrow.Cells["dgvtxtAmount"].Value));
                            }
                    }
                    decTotal = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces);
                    txtTotal.Text = Convert.ToString(decTotal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keypressevent(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentCell != null)
                {
                    if (dgvProduct.CurrentCell.ColumnIndex == dgvProduct.Columns["dgvtxtAmount"].Index)
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                    if (dgvProduct.CurrentCell.ColumnIndex == dgvProduct.Columns["dgvtxtQty"].Index)
                    {
                        //Common.NumberOnlyAndFloatingPoint(sender, e);
                    }
                    if (dgvProduct.CurrentCell.ColumnIndex == dgvProduct.Columns["dgvtxtRate"].Index)
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the order number combo box
        /// </summary>
        /// <param name="decLedger"></param>
        /// <param name="decvoucherTypeId"></param>
        public void OrderNoComboFill(decimal decLedger, decimal decvoucherTypeId)
        {
            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
            try
            {
                isOrderFil = true;
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = BllPurchaseInvoice.GetOrderNoCorrespondingtoLedger(decLedger, decMaterialReceiptMasterId, decvoucherTypeId);
                cmbOrderNo.DataSource = ListObj[0];
                if (cmbOrderNo.DataSource != null)
                {
                    cmbOrderNo.DisplayMember = "invoiceNo";
                    cmbOrderNo.ValueMember = "purchaseOrderMasterId";
                    cmbOrderNo.SelectedIndex = -1;
                }
                isOrderFil = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove incomplete row from grid
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvProduct.RowCount;
                int inLastRow = 1;//To eliminate last row from checking
                foreach (DataGridViewRow dgvrowCur in dgvProduct.Rows)
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
                        for (int inK = 0; inK < dgvProduct.Rows.Count; inK++)
                        {
                            if (dgvProduct.Rows[inK].HeaderCell.Value != null && dgvProduct.Rows[inK].HeaderCell.Value.ToString() == "X")
                            {
                                if (!dgvProduct.Rows[inK].IsNewRow)
                                {
                                    dgvProduct.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvProduct.Rows[inForFirst].Cells["dgvtxtProductName"].Selected = true;
                        dgvProduct.CurrentCell = dgvProduct.Rows[inForFirst].Cells["dgvtxtProductName"];
                        dgvProduct.Focus();
                    }
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to check the total amount while save
        /// </summary>
        /// <param name="isMessageShown"></param>
        /// <returns></returns>
        public bool CheckTotalAmount(bool isMessageShown)
        {
            try
            {
                bool isMessage = isMessageShown;
                if (txtTotal.Text.Split('.')[0].Length > 13)
                {
                    if (isMessageShown)
                    {
                        MessageBox.Show("Amount exeed than limit");
                    }
                    isMessageShown = false;
                    dgvProduct.Rows.RemoveAt(dgvProduct.Rows.Count - 2);
                    CalculateTotalAmount();
                    CheckTotalAmount(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dgvProduct.Rows.Count > 0 ? true : false;
        }
        /// <summary>
        /// Function to call the savefunction or editfunction after checking invalid entries
        /// </summary>
        public void SaveOrEdit()
        {
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            try
            {
                dgvProduct.ClearSelection();
                int inRow = dgvProduct.RowCount;
                String strInvoiceNo = txtReceiptNo.Text.Trim();
                if (txtReceiptNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number");
                    txtReceiptNo.Focus();
                }
                else if (bllMaterialReceiptMaster.MaterialReceiptNumberCheckExistence(txtReceiptNo.Text.Trim(), decMaterialReceiptVoucherTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Receipt number already exist");
                    txtReceiptNo.Focus();
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
                else if (cmbcurrency.SelectedValue == null)
                {
                    Messages.InformationMessage("Select Currency");
                    cmbcurrency.Focus();
                }
                else if (inRow - 1 == 0)
                {
                    Messages.InformationMessage("Can't save material receipt without atleast one product with complete details");
                }
                else
                {
                    if (RemoveIncompleteRowsFromGrid())
                    {
                        if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null && dgvProduct.Rows[0].Cells["dgvtxtProductCode"].Value == null)
                        {
                            MessageBox.Show("Can't save material receipt without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvProduct.ClearSelection();
                            dgvProduct.Focus();
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null)
                                {
                                    MessageBox.Show("Can't save material receipt without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvProduct.ClearSelection();
                                    dgvProduct.Focus();
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
                                if (QuantityCheckWithReference() == 1)
                                {
                                    if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null)
                                    {
                                        MessageBox.Show("Can't Edit MateraialReceipt without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvProduct.ClearSelection();
                                        dgvProduct.Focus();
                                    }
                                    else if (decEdit == 1)
                                    {
                                        MessageBox.Show("Can't Edit MateraialReceipt with Invalid Quantity", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvProduct.ClearSelection();
                                        dgvProduct.Focus();
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
                MessageBox.Show("MR32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the voucher
        /// </summary>
        /// <param name="decReceiptMasterId"></param>
        public void Print(decimal decReceiptMasterId, decimal decOrderMasterId1)
        {
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            try
            {
                DataSet dsMaterialReceipt = bllMaterialReceiptMaster.MaterialReceiptPrinting(decReceiptMasterId, 1, decOrderMasterId1);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.MaterialReceiptPrinting(dsMaterialReceipt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the voucher in dotmatrix
        /// </summary>
        /// <param name="decReceiptMasterId"></param>
        public void PrintForDotMatrix(decimal decReceiptMasterId)
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
                dtblGridDetails.Columns.Add("Rack");
                dtblGridDetails.Columns.Add("Batch");
                dtblGridDetails.Columns.Add("Rate");
                dtblGridDetails.Columns.Add("Amount");
                int inRowCount = 0;
                foreach (DataGridViewRow dRow in dgvProduct.Rows)
                {
                    if (!dRow.IsNewRow)
                    {
                        DataRow dr = dtblGridDetails.NewRow();
                        dr["SlNo"] = ++inRowCount;
                        if (dRow.Cells["dgvtxtBarcode"].Value != null)
                        {
                            dr["BarCode"] = dRow.Cells["dgvtxtBarcode"].Value.ToString();
                        }
                        dr["ProductCode"] = dRow.Cells["dgvtxtProductCode"].Value.ToString();
                        dr["ProductName"] = dRow.Cells["dgvtxtProductName"].Value.ToString();
                        dr["Qty"] = dRow.Cells["dgvtxtQty"].Value.ToString();
                        if (dRow.Cells["dgvcmbUnit"].Value != null)
                        {
                            dr["Unit"] = dRow.Cells["dgvcmbUnit"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbGodown"].Value != null)
                        {
                            dr["Godown"] = dRow.Cells["dgvcmbGodown"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvCmbRack"].Value != null)
                        {
                            dr["Rack"] = dRow.Cells["dgvCmbRack"].FormattedValue.ToString();
                        }
                        if (dRow.Cells["dgvcmbBatch"].Value != null)
                        {
                            dr["Batch"] = dRow.Cells["dgvcmbBatch"].FormattedValue.ToString();
                        }
                        dr["Rate"] = dRow.Cells["dgvtxtRate"].Value.ToString();
                        dr["Amount"] = dRow.Cells["dgvtxtAmount"].Value.ToString();
                        dtblGridDetails.Rows.Add(dr);
                    }
                }
                //-------------Other Details-------------------\\
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("Type");
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
                dRowOther["voucherNo"] = txtReceiptNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbcurrency.Text;
                dRowOther["TotalAmount"] = txtTotal.Text;
                dRowOther["Type"] = cmbVoucherType.SelectedText;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtTotal.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decMaterialReceiptVoucherTypeId);
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
                MessageBox.Show("MR34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save the voucher
        /// </summary>
        public void SaveFunction()
        {
            MaterialReceiptDetailsInfo infoMaterialReceiptDetails = new MaterialReceiptDetailsInfo();
            ProductInfo infoProduct = new ProductInfo();
            MaterialReceiptMasterInfo infoMaterialReceiptMaster = new MaterialReceiptMasterInfo();
            StockPostingBll BllStockPosting = new StockPostingBll();
            //StockPostingSP spstockposting = new StockPostingSP();
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                infoMaterialReceiptMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoMaterialReceiptMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                if (isAutomatic)
                {
                    infoMaterialReceiptMaster.SuffixPrefixId = decMaterialReceiptSuffixPrefixId;
                    infoMaterialReceiptMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoMaterialReceiptMaster.SuffixPrefixId = 0;
                    infoMaterialReceiptMaster.VoucherNo = txtReceiptNo.Text;
                }
                infoMaterialReceiptMaster.VoucherTypeId = decMaterialReceiptVoucherTypeId;
                infoMaterialReceiptMaster.InvoiceNo = txtReceiptNo.Text;
                infoMaterialReceiptMaster.UserId = PublicVariables._decCurrentUserId;
                infoMaterialReceiptMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoMaterialReceiptMaster.TransportationCompany = txtTransportation.Text.Trim();
                infoMaterialReceiptMaster.LrNo = txtLRNo.Text.Trim();
                infoMaterialReceiptMaster.Narration = txtNarration.Text.Trim();
                if (cmbOrderNo.SelectedValue == null || cmbOrderNo.SelectedValue.ToString() == string.Empty)
                {
                    infoMaterialReceiptMaster.OrderMasterId = 0;
                }
                else
                {
                    infoMaterialReceiptMaster.OrderMasterId = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                }
                infoMaterialReceiptMaster.exchangeRateId = Convert.ToDecimal(cmbcurrency.SelectedValue.ToString());//saving corresponding exchangeRateId as currencyId
                infoMaterialReceiptMaster.TotalAmount = Convert.ToDecimal(txtTotal.Text);
                infoMaterialReceiptMaster.Extra1 = string.Empty;
                infoMaterialReceiptMaster.Extra2 = string.Empty;
                infoMaterialReceiptMaster.ExtraDate = Convert.ToDateTime(DateTime.Now);
                decMaterialReceiptMasterIdentity = Convert.ToDecimal(bllMaterialReceiptMaster.MaterialReceiptMasterAdd(infoMaterialReceiptMaster));
                int inRowcount = dgvProduct.Rows.Count;
                for (int inI = 0; inI < inRowcount - 1; inI++)
                {
                    infoMaterialReceiptDetails.MaterialReceiptMasterId = decMaterialReceiptMasterIdentity;
                    if (dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                    {
                        infoProduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoMaterialReceiptDetails.ProductId = infoProduct.ProductId;
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value != null)
                    {
                        infoMaterialReceiptDetails.OrderDetailsId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString());
                    }
                    else
                        infoMaterialReceiptDetails.OrderDetailsId = 0;
                    if (dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                    {
                        infoMaterialReceiptDetails.GodownId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                    }
                    else
                    {
                        infoMaterialReceiptDetails.GodownId = 1;
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value != null && dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value.ToString() != string.Empty)
                    {
                        infoMaterialReceiptDetails.RackId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value.ToString());
                    }
                    else
                    {
                        infoMaterialReceiptDetails.RackId = 1;
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                    {
                        infoMaterialReceiptDetails.BatchId = Convert.ToDecimal(Convert.ToString(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value));
                    }
                    else
                    {
                        infoMaterialReceiptDetails.BatchId = 1;
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                    {
                        infoMaterialReceiptDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                    {
                        infoMaterialReceiptDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        infoMaterialReceiptDetails.UnitConversionId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                    }
                    infoMaterialReceiptDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                    infoMaterialReceiptDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                    infoMaterialReceiptDetails.Slno = Convert.ToInt32(dgvProduct.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                    infoMaterialReceiptDetails.Extra1 = string.Empty;
                    infoMaterialReceiptDetails.Exta2 = string.Empty;
                    infoMaterialReceiptDetails.ExtraDate = Convert.ToDateTime(DateTime.Now);
                    bllMaterialReceiptMaster.MaterialReceiptDetailsAdd(infoMaterialReceiptDetails);
                    //-----------------Stockposting---------------------------//
                    StockPostingInfo infoStockPosting = new StockPostingInfo();
                    infoStockPosting.Date = infoMaterialReceiptMaster.Date;
                    infoStockPosting.ProductId = infoMaterialReceiptDetails.ProductId;
                    infoStockPosting.BatchId = infoMaterialReceiptDetails.BatchId;
                    infoStockPosting.UnitId = infoMaterialReceiptDetails.UnitId;
                    infoStockPosting.GodownId = infoMaterialReceiptDetails.GodownId;
                    infoStockPosting.RackId = infoMaterialReceiptDetails.RackId;
                    if (cmbOrderNo.SelectedValue != null)
                    {
                        if (dgvProduct.Rows[inI].Cells["dgvtxtvoucherNo"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtvoucherNo"].Value.ToString() != string.Empty)
                        {
                            infoStockPosting.VoucherNo = Convert.ToString(dgvProduct.Rows[inI].Cells["dgvtxtvoucherNo"].Value.ToString());
                            infoStockPosting.AgainstVoucherNo = strVoucherNo;
                        }
                        else
                        {
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.AgainstVoucherNo = "NA";
                        }
                        if (dgvProduct.Rows[inI].Cells["dgvtxtinvoiceNo"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtinvoiceNo"].Value.ToString() != string.Empty)
                        {
                            infoStockPosting.InvoiceNo = Convert.ToString(dgvProduct.Rows[inI].Cells["dgvtxtinvoiceNo"].Value.ToString());
                            infoStockPosting.AgainstInvoiceNo = txtReceiptNo.Text;
                        }
                        else
                        {
                            infoStockPosting.InvoiceNo = txtReceiptNo.Text;
                            infoStockPosting.AgainstInvoiceNo = "NA";
                        }
                        if (dgvProduct.Rows[inI].Cells["dgvtxtvouchertypeId"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtvouchertypeId"].Value.ToString() != string.Empty)
                        {
                            infoStockPosting.VoucherTypeId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtvouchertypeId"].Value.ToString());
                            infoStockPosting.AgainstVoucherTypeId = decMaterialReceiptVoucherTypeId;
                        }
                        else
                        {
                            infoStockPosting.VoucherTypeId = decMaterialReceiptVoucherTypeId;
                            infoStockPosting.AgainstVoucherTypeId = 0;
                        }
                    }
                    else
                    {
                        infoStockPosting.InvoiceNo = txtReceiptNo.Text;
                        infoStockPosting.VoucherNo = strVoucherNo;
                        infoStockPosting.VoucherTypeId = decMaterialReceiptVoucherTypeId;
                        infoStockPosting.AgainstVoucherTypeId = 0;
                        infoStockPosting.AgainstVoucherNo = "NA";
                        infoStockPosting.AgainstInvoiceNo = "NA";
                    }
                    infoStockPosting.InwardQty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString()) / Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtConversionRate"].Value.ToString());
                    infoStockPosting.OutwardQty = 0;
                    infoStockPosting.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                    infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoStockPosting.Extra1 = string.Empty;
                    infoStockPosting.Extra2 = string.Empty;
                    BllStockPosting.StockPostingAdd(infoStockPosting);
                }
                Messages.SavedMessage();
                if (cbxPrintAfterSave.Checked)
                {
                    SettingsBll BllSettings = new SettingsBll();
                    if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                    {
                        PrintForDotMatrix(decMaterialReceiptMasterIdentity);
                    }
                    else
                    {
                        Print(decMaterialReceiptMasterIdentity, infoMaterialReceiptMaster.OrderMasterId);
                    }
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit the voucher
        /// </summary>
        public void EditFunction()
        {
            MaterialReceiptMasterInfo infoMaterialReceiptMaster = new MaterialReceiptMasterInfo();
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                infoMaterialReceiptMaster.MaterialReceiptMasterId = decMaterialReceiptMasterId;
                infoMaterialReceiptMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoMaterialReceiptMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoMaterialReceiptMaster.SuffixPrefixId = Convert.ToDecimal(decMaterialReceiptSuffixPrefixId);
                infoMaterialReceiptMaster.VoucherNo = strVoucherNo;
                infoMaterialReceiptMaster.VoucherTypeId = decMaterialReceiptVoucherTypeId;
                infoMaterialReceiptMaster.InvoiceNo = txtReceiptNo.Text;
                infoMaterialReceiptMaster.UserId = PublicVariables._decCurrentUserId;
                infoMaterialReceiptMaster.TransportationCompany = txtTransportation.Text.Trim();
                infoMaterialReceiptMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoMaterialReceiptMaster.Narration = txtNarration.Text.Trim();
                infoMaterialReceiptMaster.LrNo = txtLRNo.Text.Trim();
                infoMaterialReceiptMaster.exchangeRateId = Convert.ToDecimal(cmbcurrency.SelectedValue.ToString());
                infoMaterialReceiptMaster.TotalAmount = Convert.ToDecimal(txtTotal.Text);
                infoMaterialReceiptMaster.Extra1 = string.Empty;
                infoMaterialReceiptMaster.Extra2 = string.Empty;
                infoMaterialReceiptMaster.ExtraDate = Convert.ToDateTime(DateTime.Now);
                if (cmbOrderNo.Text == string.Empty || cmbOrderNo.SelectedValue.ToString() == string.Empty)
                {
                    infoMaterialReceiptMaster.OrderMasterId = 0;
                }
                else
                {
                    infoMaterialReceiptMaster.OrderMasterId = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                }
                bllMaterialReceiptMaster.MaterialReceiptMasterEdit(infoMaterialReceiptMaster);
                removeMaterialReceiptDetails();
                MaterialReceiptDetailsEditFill();
                if (isEdit)
                {
                    Messages.UpdatedMessage();
                    if (frmMaterialReceiptRegisterObj != null)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decMaterialReceiptMasterId);
                        }
                        else
                        {
                            Print(decMaterialReceiptMasterId, infoMaterialReceiptMaster.OrderMasterId);
                        }
                        frmMaterialReceiptRegisterObj.GridFill();
                        frmMaterialReceiptRegisterObj.Enabled = true;
                    }
                    if (frmMaterialReceiptReportObj != null)
                    {
                        if (cbxPrintAfterSave.Checked)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decMaterialReceiptMasterId);
                            }
                            else
                            {
                                Print(decMaterialReceiptMasterId, infoMaterialReceiptMaster.OrderMasterId);
                            }
                        }
                        frmMaterialReceiptReportObj.GridFill();
                        frmMaterialReceiptReportObj.Enabled = true;
                    }
                    if (frmDayBookObj != null)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decMaterialReceiptMasterId);
                        }
                        else
                        {
                            Print(decMaterialReceiptMasterId, infoMaterialReceiptMaster.OrderMasterId);
                        }
                    }
                    this.Close();
                    isEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the voucher details for edit
        /// </summary>
        public void MaterialReceiptDetailsEditFill()
        {
            ProductInfo infoProduct = new ProductInfo();
            MaterialReceiptDetailsInfo infoMaterialReceiptDetails = new MaterialReceiptDetailsInfo();
            StockPostingBll BllStockPosting = new StockPostingBll();
            MaterialReceiptBll bllMaterialReceipt = new MaterialReceiptBll();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                for (int inI = 0; inI < dgvProduct.Rows.Count - 1; inI++)
                {
                    decimal decStatus = bllMaterialReceipt.MaterialReceiptDetailsReferenceCheck(decMaterialReceiptDetailId);
                    if (decStatus == 1)
                    {
                        dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].ReadOnly = true;
                        dgvProduct.Rows[inI].Cells["dgvtxtProductName"].ReadOnly = true;
                        dgvProduct.Rows[inI].Cells["dgvcmbUnit"].ReadOnly = true;
                        dgvProduct.Rows[inI].Cells["dgvtxtBarcode"].ReadOnly = true;
                        dgvProduct.Rows[inI].Cells["dgvCmbRack"].ReadOnly = true;
                        dgvProduct.Rows[inI].Cells["dgvcmbGodown"].ReadOnly = true;
                        dgvProduct.Rows[inI].Cells["dgvtxtRate"].ReadOnly = true;
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value != null)
                    {
                        if (dgvProduct.Rows[inI].Cells["dgvtxtMaterialReceiptdetailsId"].Value == null || dgvProduct.Rows[inI].Cells["dgvtxtMaterialReceiptdetailsId"].Value.ToString() == string.Empty)
                        {
                            infoMaterialReceiptDetails.MaterialReceiptMasterId = decMaterialReceiptMasterId;
                            infoProduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                            infoMaterialReceiptDetails.ProductId = infoProduct.ProductId;
                            if (dgvProduct.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value != null)
                            {
                                infoMaterialReceiptDetails.OrderDetailsId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString());
                            }
                            else
                                infoMaterialReceiptDetails.OrderDetailsId = 0;
                            infoMaterialReceiptDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                            infoMaterialReceiptDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                            infoMaterialReceiptDetails.UnitConversionId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value);
                            if (dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                            {
                                infoMaterialReceiptDetails.GodownId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                            }
                            else
                            {
                                infoMaterialReceiptDetails.GodownId = 1;
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value != null && dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value.ToString() != string.Empty)
                            {
                                infoMaterialReceiptDetails.RackId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value.ToString());
                            }
                            else
                            {
                                infoMaterialReceiptDetails.RackId = 1;
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                            {
                                infoMaterialReceiptDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                            }
                            else
                            {
                                infoMaterialReceiptDetails.BatchId = 1;
                            }
                            infoMaterialReceiptDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                            infoMaterialReceiptDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                            infoMaterialReceiptDetails.Slno = Convert.ToInt32(dgvProduct.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                            infoMaterialReceiptDetails.Extra1 = string.Empty;
                            infoMaterialReceiptDetails.Exta2 = string.Empty;
                            infoMaterialReceiptDetails.ExtraDate = Convert.ToDateTime(DateTime.Now);
                            bllMaterialReceipt.MaterialReceiptDetailsAdd(infoMaterialReceiptDetails);
                        }
                        else
                        {
                            infoMaterialReceiptDetails.MaterialReceiptMasterId = decMaterialReceiptMasterId;
                            infoMaterialReceiptDetails.MaterialReceiptDetailsId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtMaterialReceiptdetailsId"].Value);
                            infoProduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                            infoMaterialReceiptDetails.ProductId = infoProduct.ProductId;
                            if (dgvProduct.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value != null)
                            {
                                infoMaterialReceiptDetails.OrderDetailsId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtPurchaseOrderDetailsId"].Value.ToString());
                            }
                            else
                                infoMaterialReceiptDetails.OrderDetailsId = 0;
                            infoMaterialReceiptDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                            infoMaterialReceiptDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                            infoMaterialReceiptDetails.UnitConversionId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value);
                            infoMaterialReceiptDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                            if (dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                            {
                                infoMaterialReceiptDetails.GodownId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                            }
                            else
                            {
                                infoMaterialReceiptDetails.GodownId = 1;
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value != null && dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value.ToString() != string.Empty)
                            {
                                infoMaterialReceiptDetails.RackId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvCmbRack"].Value.ToString());
                            }
                            else
                            {
                                infoMaterialReceiptDetails.RackId = 1;
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                            {
                                infoMaterialReceiptDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                            }
                            else
                            {
                                infoMaterialReceiptDetails.BatchId = 1;
                            }
                            infoMaterialReceiptDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                            infoMaterialReceiptDetails.Slno = Convert.ToInt32(dgvProduct.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                            infoMaterialReceiptDetails.Extra1 = string.Empty;
                            infoMaterialReceiptDetails.Exta2 = string.Empty;
                            infoMaterialReceiptDetails.ExtraDate = Convert.ToDateTime(DateTime.Now);
                            bllMaterialReceipt.MaterialReceiptDetailsEdit(infoMaterialReceiptDetails);
                        }
                        StockPostingInfo infoStockPosting = new StockPostingInfo();
                        infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                        infoStockPosting.ProductId = infoMaterialReceiptDetails.ProductId;
                        infoStockPosting.BatchId = infoMaterialReceiptDetails.BatchId;
                        infoStockPosting.UnitId = infoMaterialReceiptDetails.UnitId;
                        infoStockPosting.GodownId = infoMaterialReceiptDetails.GodownId;
                        infoStockPosting.RackId = infoMaterialReceiptDetails.RackId;
                        if (cmbOrderNo.SelectedValue != null)
                        {
                            if (dgvProduct.Rows[inI].Cells["dgvtxtvoucherNo"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtvoucherNo"].Value.ToString() != string.Empty && dgvProduct.Rows[inI].Cells["dgvtxtvoucherNo"].Value.ToString() != "NA")
                            {
                                infoStockPosting.VoucherNo = Convert.ToString(dgvProduct.Rows[inI].Cells["dgvtxtvoucherNo"].Value.ToString());
                                infoStockPosting.AgainstVoucherNo = strVoucherNo;
                            }
                            else
                            {
                                infoStockPosting.VoucherNo = strVoucherNo;
                                infoStockPosting.AgainstVoucherNo = "NA";
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvtxtinvoiceNo"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtinvoiceNo"].Value.ToString() != string.Empty && dgvProduct.Rows[inI].Cells["dgvtxtinvoiceNo"].Value.ToString() != "NA")
                            {
                                infoStockPosting.InvoiceNo = Convert.ToString(dgvProduct.Rows[inI].Cells["dgvtxtinvoiceNo"].Value.ToString());
                                infoStockPosting.AgainstInvoiceNo = txtReceiptNo.Text;
                            }
                            else
                            {
                                infoStockPosting.InvoiceNo = txtReceiptNo.Text;
                                infoStockPosting.AgainstInvoiceNo = "NA";
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvtxtvouchertypeId"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtvouchertypeId"].Value.ToString() != string.Empty && Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtvouchertypeId"].Value.ToString()) != 0)
                            {
                                infoStockPosting.VoucherTypeId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtvouchertypeId"].Value.ToString());
                                infoStockPosting.AgainstVoucherTypeId = decMaterialReceiptVoucherTypeId;
                            }
                            else
                            {
                                infoStockPosting.VoucherTypeId = decMaterialReceiptVoucherTypeId;
                                infoStockPosting.AgainstVoucherTypeId = 0;
                            }
                        }
                        else
                        {
                            infoStockPosting.InvoiceNo = txtReceiptNo.Text;
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.VoucherTypeId = decMaterialReceiptVoucherTypeId;
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.AgainstInvoiceNo = "NA";
                        }
                        BllStockPosting.StockPostingDeleteByVoucherTypeAndVoucherNo(strVoucherNo, decMaterialReceiptVoucherTypeId);
                        infoStockPosting.InwardQty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        infoStockPosting.OutwardQty = 0;
                        infoStockPosting.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                        infoStockPosting.Extra1 = string.Empty;
                        infoStockPosting.Extra2 = string.Empty;
                        BllStockPosting.StockPostingAdd(infoStockPosting);
                        isEdit = true;
                    }
                }
                if (isEdit)
                {
                    cmbCashOrParty.Enabled = true;
                    cmbOrderNo.Enabled = true;
                    cmbcurrency.Enabled = true;
                    txtDate.Enabled = true;
                    cmbVoucherType.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the next row index
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
                MessageBox.Show("MR38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inMaxCount;
        }
        /// <summary>
        /// Function to fill the details against purchase order
        /// </summary>
        public void FillOrderDetails()
        {
            BatchBll BllBatch = new BatchBll();
            PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
            //StockPostingSP spStockPosting = new StockPostingSP();
            StockPostingBll BllStockPosting = new StockPostingBll();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                if (!isEditFill)
                {
                    isValueChange = false;
                    if (dgvProduct.RowCount > 1)
                    {
                        for (int i = 0; i < dgvProduct.RowCount - 1; i++)
                        {
                            if (dgvProduct.Rows[i].Cells["dgvtxtMaterialReceiptdetailsId"].Value != null && dgvProduct.Rows[i].Cells["dgvtxtMaterialReceiptdetailsId"].Value.ToString() != string.Empty)
                            {
                                lstArrOfRemove.Add(dgvProduct.Rows[i].Cells["dgvtxtMaterialReceiptdetailsId"].Value.ToString());
                            }
                        }
                    }
                    dgvProduct.Rows.Clear();
                    isValueChange = true;
                    isDoAfterGridFill = false;
                    List<DataTable> ListObjDetails = new List<DataTable>();
                    if (Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()) == decOrderNoWhileEditMode && btnSave.Text == "Update")
                    {
                        ListObjDetails = BllPurchaseOrder.PurchaseOrderDetailsViewByOrderMasterIdWithRemainingForEdit(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()), decMaterialReceiptId);
                    }
                    else
                    {
                        ListObjDetails = BllPurchaseOrder.PurchaseOrderDetailsViewByOrderMasterIdWithRemaining(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()), decMaterialReceiptId);
                    }
                    int inRowIndex = 0;
                    foreach (DataRow drowDetails in ListObjDetails[0].Rows)
                    {
                        dgvProduct.Rows.Add();
                        isValueChange = false;
                        isDoAfterGridFill = false;
                        dgvProduct.CurrentCell = dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductName"];
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtPurchaseOrderDetailsId"].Value = Convert.ToString(drowDetails.ItemArray[0]);
                        strproductId = drowDetails.ItemArray[2].ToString();
                        ProductInfo infoproduct = new ProductInfo();
                        infoproduct = BllProductCreation.ProductView(Convert.ToDecimal(strproductId));
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["productId"].Value = Convert.ToDecimal(strproductId);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductCode"].Value = infoproduct.ProductCode;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductName"].Value = infoproduct.ProductName;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtvouchertypeId"].Value = Convert.ToString(drowDetails.ItemArray[11]);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtvoucherNo"].Value = Convert.ToString(drowDetails.ItemArray[12]);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtinvoiceNo"].Value = Convert.ToString(drowDetails.ItemArray[13]);
                        UnitComboFill(Convert.ToDecimal(strproductId), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ColumnIndex);
                        isValueChange = true;
                        isDoAfterGridFill = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                        UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                       List< DataTable >listUnitByProduct = new List<DataTable>();
                       listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(strproductId);
                       foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                        {
                            if (dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                            {
                                dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                            }
                        }
                        isValueChange = false;
                        isDoAfterGridFill = false;
                        BatchComboFill(Convert.ToDecimal(strproductId), dgvProduct.Rows.Count - 2, Convert.ToInt32(dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].ColumnIndex));
                        decimal decBatch = BllStockPosting.BatchViewByProductId(Convert.ToDecimal(strproductId));
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].Value = decBatch;
                        string strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatch);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtBarcode"].Value = strBarcode;
                        DGVGodownComboFill();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(1);
                        RackComboFill(1, dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvCmbRack"].ColumnIndex);
                        List<DataTable> listObj = new List<DataTable>();
                        RackBll BllRack = new RackBll();
                        listObj = BllRack.RackNamesCorrespondingToGodownId(1);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvCmbRack"].Value = Convert.ToDecimal(listObj[0].Rows[0]["rackId"].ToString());
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtQty"].Value = Convert.ToString(drowDetails.ItemArray[3]);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtRate"].Value = Convert.ToString(drowDetails.ItemArray[4]);
                        decCurrentRate = Convert.ToDecimal(drowDetails.ItemArray[4].ToString());
                        decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value.ToString());
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtAmount"].Value = Convert.ToString(drowDetails.ItemArray[6]);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductCode"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductName"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtBarcode"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtAmount"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["inRowIndex"].Value = Convert.ToString(drowDetails["extra1"]);
                        if (cmbVoucherType.Text != "NA")
                        {
                            dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                        }
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].HeaderCell.Value = string.Empty;
                        int intIndex = 0;
                        int.TryParse(Convert.ToString(drowDetails["extra1"]), out intIndex);
                        if (inMaxCount < intIndex)
                            inMaxCount = intIndex;
                        inRowIndex++;
                        NewAmountCalculation(string.Empty, dgvProduct.Rows.Count - 2);
                        isValueChange = true;
                        isDoAfterGridFill = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                    }
                    for (int i = inRowIndex; i < dgvProduct.Rows.Count; ++i)
                        dgvProduct["inRowIndex", i].Value = Convert.ToString(GetNextinRowIndex());
                    SerialNo();
                    CalculateTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the amount for each row
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
                if (dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtProductName"].Value != null && dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                {
                    if (dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value != null && dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                    {
                        if (dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value != null && dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                        {
                            decimal decQuantity = Convert.ToDecimal(dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value);
                            decimal.TryParse(Convert.ToString(dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value), out decQty);
                            decimal.TryParse(Convert.ToString(dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value), out decRate);
                            decGrossValue = decQty * decRate;
                            dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                }
                else
                {
                    dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, PublicVariables._inNoOfDecimalPlaces);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the printaftersave checkbox
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
                MessageBox.Show("MR41: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Fill the CashOrParty Combobox
        /// </summary>
        public void CashOrPartyComboFill()
        {
            try
            {
                isDontExecuteCashorParty = true;
                TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionGeneralFillObj.CashOrPartyComboFill(cmbCashOrParty, false);
                cmbCashOrParty.SelectedValue = 1;
                isDontExecuteCashorParty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate serialNo
        /// </summary>
        public void SerialNo()
        {
            try
            {
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = row.Index + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the cashorparty combo while returning from AccountLedger Form
        /// </summary>
        /// <param name="decaccountledgerid"></param>
        public void ReturnFromAccountLedger(decimal decaccountledgerid)
        {
            try
            {
                this.Enabled = true;
                this.BringToFront();
                CashOrPartyComboFill();
                if (decaccountledgerid.ToString() != "0")
                {
                    cmbCashOrParty.SelectedValue = decaccountledgerid;
                }
                if (cmbCashOrParty.Text == string.Empty)
                {
                    cmbCashOrParty.SelectedValue = Convert.ToDecimal(strOldLedgerId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the batch combobox
        /// </summary>
        public void BatchAllComboFill()
        {
            try
            {
                List<DataTable> list = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                list = BllBatch.BatchViewAll();
                dgvcmbBatch.DataSource = list[0];
                dgvcmbBatch.ValueMember = "batchId";
                dgvcmbBatch.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the orderdetails while changing the orderno in EditMode
        /// </summary>
        public void OrderClear()
        {
            try
            {
                if (dgvProduct.RowCount > 1)
                {
                    for (int i = 0; i < dgvProduct.RowCount - 1; i++)
                    {
                        if (dgvProduct.Rows[i].Cells["dgvtxtMaterialReceiptdetailsId"].Value != null && dgvProduct.Rows[i].Cells["dgvtxtMaterialReceiptdetailsId"].Value.ToString() != string.Empty)
                        {
                            lstArrOfRemove.Add(dgvProduct.Rows[i].Cells["dgvtxtMaterialReceiptdetailsId"].Value.ToString());
                        }
                    }
                }
                cmbOrderNo.DataSource = null;
                dgvProduct.Rows.Clear();
                txtTotal.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to load the form while calling from DayBook
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void callFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                base.Show();
                this.frmDayBookObj = frmDayBook;
                frmDayBook.Enabled = false;
                decMaterialReceiptMasterId = decMasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Unit comboBox
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
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvProduct.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete button
        /// </summary>
        public void DeleteFuntion()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        if (dgvProduct.RowCount > 1)
                        {
                            Delete();
                        }
                    }
                }
                else
                {
                    if (dgvProduct.RowCount > 1)
                    {
                        Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete material receipt
        /// </summary>
        public void Delete()
        {
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            //StockPostingSP spstockposting = new StockPostingSP();
            StockPostingBll BllStockPosting = new StockPostingBll();
            try
            {
                decimal decResult1 = 0;
                decimal decReference = bllMaterialReceiptMaster.MaterialReceiptMasterReferenceCheck(decMaterialReceiptMasterId);
                if (decReference == 1)
                {
                    decResult1 = bllMaterialReceiptMaster.MaterialReceiptDelete(decMaterialReceiptMasterId);
                    if (decResult1 > 0)
                    {
                        if (Convert.ToDecimal(dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtvouchertypeId"].Value) == 0)
                        {
                            decimal decResult3 = BllStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(0, "NA", strVoucherNo, decMaterialReceiptVoucherTypeId);
                        }
                        else
                        {
                            decimal decResult3 = BllStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(decMaterialReceiptVoucherTypeId, strVoucherNo, strAgainstVoucherNo, decAgainstVoucherTypeId);
                        }
                        Messages.DeletedMessage();
                        if (frmMaterialReceiptRegisterObj != null)
                        {
                            this.Close();
                            frmMaterialReceiptRegisterObj.GridFill();
                        }
                        if (frmMaterialReceiptReportObj != null)
                        {
                            this.Close();
                            frmMaterialReceiptReportObj.GridFill();
                        }
                        if (objVoucherSearch != null)
                        {
                            this.Close();
                            objVoucherSearch.GridFill();
                        }
                        if (frmDayBookObj != null)
                        {
                            this.Close();
                            frmDayBookObj.dayBookGridFill();
                        }
                    }
                }
                else
                {
                    Messages.ReferenceExistsMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On selected value change of Currency combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbcurrency_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isValueChanged)
                {
                    CalculateTotalAmount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (frmMaterialReceiptReportObj != null)
                {
                    frmMaterialReceiptReportObj.Close();
                    frmMaterialReceiptReportObj = null;
                }
                if (frmMaterialReceiptRegisterObj != null)
                {
                    frmMaterialReceiptRegisterObj.Close();
                    frmMaterialReceiptRegisterObj = null;
                }
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
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Close();
                    objVoucherSearch = null;
                }
                if (objVoucherProduct != null)
                {
                    objVoucherProduct.Close();
                    objVoucherProduct = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR52:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To add new ledger 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewLedger_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCashOrParty.SelectedValue != null)
                {
                    strOldLedgerId = cmbCashOrParty.SelectedValue.ToString();
                }
                else
                {
                    strOldLedgerId = string.Empty;
                }
                frmAccountLedger frmAccountLedger = new frmAccountLedger();
                frmAccountLedger.MdiParent = formMDI.MDIObj;
                frmAccountLedger.callFromMaterialReceipt(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR53:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("MR54:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaterialReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = "0.00";
                MaterialreceiptSettingsCheck();
                PrintCheck();
                DGVGodownComboFill();
                CashOrPartyComboFill();
                VoucherTypeCombofill();
                Clear();
                if (isAutomatic)
                {
                    VoucherNumberGeneration();
                }
                FillProducts(false, null);
                isOrderFil = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR55:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid databinding event for clear selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvProduct.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR56:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (CheckTotalAmount(true))
                    {
                        SaveOrEdit();
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR57:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
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
                MessageBox.Show("MR58:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selected value change of CashOrParty combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                OrderClear();
                if (!isDontExecuteCashorParty && !isDontExecuteVoucherType)
                {
                    if (cmbCashOrParty.SelectedValue != null && cmbVoucherType.Text != "NA")
                    {
                        if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView")
                        {
                            OrderNoComboFill(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR59:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
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
                MessageBox.Show("MR60:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// On leave from txtDate
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
                MessageBox.Show("MR61:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selected value change of cmbOrderNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOrderNo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isOrderFil)
                {
                    if ((cmbOrderNo.SelectedValue == null ? string.Empty : cmbOrderNo.SelectedValue.ToString()) != string.Empty)
                    {
                        if (cmbOrderNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbOrderNo.Text != "System.Data.DataRowView")
                        {
                            FillOrderDetails();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR62:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To commit the edit in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.IsCurrentCellDirty)
                {
                    dgvProduct.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR63:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Handling dataerror event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR64:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On remove link button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvProduct.SelectedCells.Count > 0 && dgvProduct.CurrentRow != null)
                {
                    if (!dgvProduct.Rows[dgvProduct.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvProduct.CurrentRow.Cells["dgvtxtMaterialReceiptdetailsId"].Value != null && dgvProduct.CurrentRow.Cells["dgvtxtMaterialReceiptdetailsId"].Value.ToString() != string.Empty)
                                {
                                    lstArrOfRemove.Add(dgvProduct.CurrentRow.Cells["dgvtxtMaterialReceiptdetailsId"].Value.ToString());
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
                MessageBox.Show("MR65:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls keypress event and autocompletion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvProduct.CurrentCell != null && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    if (dgvProduct.CurrentCell != null && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvProduct.CurrentCell != null && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name != "dgvtxtProductCode" && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name != "dgvtxtProductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvProduct.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;
                    TextBoxControl.KeyPress += keypressevent;
                }
                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                    tb.KeyDown -= dgvProduct_KeyDown;
                    tb.KeyDown += new KeyEventHandler(dgvProduct_KeyDown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR66:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On row added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR67:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cellEndEdit of grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProductInfo infoProduct = new ProductInfo();
            BatchBll BllBatch = new BatchBll();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            StockPostingBll BllStockPosting = new StockPostingBll();
            //StockPostingSP spStockPosting = new StockPostingSP();
            try
            {
                isDoAfterGridFill = false;
                isValueChange = false;
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtProductName")
                {
                    string strProductName = string.Empty;
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                    {
                        strProductName = dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString();
                    }
                    infoProduct = BllProductCreation.ProductViewByName(strProductName);
                    if (infoProduct.ProductCode != null && infoProduct.ProductCode != string.Empty)
                    {
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                        decimal decproductId = infoProduct.ProductId;
                        dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = infoProduct.ProductId;
                        BatchComboFill(decproductId, e.RowIndex, Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                        decimal decBatchId = BllStockPosting.BatchViewByProductId(decproductId);
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = decBatchId;
                        decBatchId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value);
                        string strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = strBarcode;
                        ListObj = BllProductCreation.ProductDetailsCoreespondingToBarcode(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString());
                        if (ListObj[0].Rows.Count > 0)
                        {
                            foreach (DataRow RowDetails in ListObj[0].Rows)
                            {
                                isValueChange = false;
                                dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = RowDetails["productId"].ToString();
                                decimal decProductId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["productId"].Value);
                                BatchComboFill(decProductId, e.RowIndex, Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                                dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(RowDetails["batchId"].ToString());
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = RowDetails["productCode"].ToString();
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = RowDetails["productName"].ToString();
                                dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(RowDetails["godownId"].ToString());
                                decGodownId = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value);
                                RackComboFill(decGodownId, e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].ColumnIndex);

                                dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].Value = Convert.ToDecimal(RowDetails["rackId"].ToString());
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(Convert.ToDecimal(RowDetails["purchaseRate"].ToString()), PublicVariables._inNoOfDecimalPlaces).ToString();
                                UnitComboFill(decProductId, e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                                dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(RowDetails["unitId"].ToString());

                                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                               List< DataTable> listUnitByProduct = new List<DataTable>();
                               listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["productId"].Value.ToString());
                               foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                {
                                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                    }
                                }
                                decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                                decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                NewAmountCalculation("dgvtxtQty", e.RowIndex);
                                CalculateTotalAmount();
                            }
                        }
                    }
                    else
                    {
                        isValueChange = false;
                        dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                        isValueChange = true;
                    }
                }
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtProductCode")
                {
                    string strPrdCode = string.Empty;
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                    {
                        strPrdCode = dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                    }
                    isDoAfterGridFill = false;
                    infoProduct = BllProductCreation.ProductViewByCode(strPrdCode);
                    if (infoProduct.ProductId != 0)
                    {
                        decimal decproductId = infoProduct.ProductId;
                        dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = infoProduct.ProductId;
                        BatchComboFill(decproductId, e.RowIndex, Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                        decimal decBatchId = BllStockPosting.BatchViewByProductId(decproductId);
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = decBatchId;
                        decBatchId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value);
                        string strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = strBarcode;
                        ListObj = BllProductCreation.ProductDetailsCoreespondingToBarcode(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString());
                        if (ListObj[0].Rows.Count > 0)
                        {
                            foreach (DataRow RowDetails in ListObj[0].Rows)
                            {
                                isValueChange = false;
                                dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = RowDetails["productId"].ToString();
                                decimal decProductId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["productId"].Value);
                                BatchComboFill(decProductId, e.RowIndex, Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                                dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(RowDetails["batchId"].ToString());
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = RowDetails["productCode"].ToString();
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = RowDetails["productName"].ToString();
                                dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(RowDetails["godownId"].ToString());
                                decGodownId = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value);
                                RackComboFill(decGodownId, e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].ColumnIndex);
                                dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].Value = Convert.ToDecimal(RowDetails["rackId"].ToString());
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(Convert.ToDecimal(RowDetails["purchaseRate"].ToString()), PublicVariables._inNoOfDecimalPlaces).ToString();
                                UnitComboFill(decProductId, e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                                dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(RowDetails["unitId"].ToString());
                                UnitConvertionBll bllUnitByProduct = new UnitConvertionBll();
                               List< DataTable >listUnitByProduct = new List<DataTable>();
                               listUnitByProduct = bllUnitByProduct.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["productId"].Value.ToString());
                               foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                {
                                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                    }
                                }
                                decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                                decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                NewAmountCalculation("dgvtxtQty", e.RowIndex);
                                CalculateTotalAmount();
                            }
                        }
                    }
                    else
                    {
                        isValueChange = false;
                        dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                        isValueChange = true;
                    }
                }
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtBarcode")
                {
                    string strBCode = string.Empty;
                   // DataTable dtbl = new DataTable();
                    if (!dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].ReadOnly && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString() != string.Empty)
                    {
                        strBCode = dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString();
                    }
                    isDoAfterGridFill = false;
                    ListObj = BllProductCreation.ProductDetailsCoreespondingToBarcode(strBCode);
                    if (ListObj[0].Rows.Count > 0)
                    {
                        foreach (DataRow RowDetails in ListObj[0].Rows)
                        {
                            isValueChange = false;
                            dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = RowDetails["productId"].ToString();
                            decimal decProductId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["productId"].Value);
                            BatchComboFill(decProductId, e.RowIndex, Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(RowDetails["batchId"].ToString());
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = RowDetails["productCode"].ToString();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = RowDetails["productName"].ToString();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(RowDetails["godownId"].ToString());
                            decGodownId = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value);
                            RackComboFill(decGodownId, e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].ColumnIndex);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].Value = Convert.ToDecimal(RowDetails["rackId"].ToString());
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(Convert.ToDecimal(RowDetails["purchaseRate"].ToString()), PublicVariables._inNoOfDecimalPlaces).ToString();
                            UnitComboFill(decProductId, e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(RowDetails["unitId"].ToString());
                            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                            List<DataTable> listUnitByProduct = new List<DataTable>();
                            listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["productId"].Value.ToString());
                            foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                {
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                }
                            }
                            decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                            decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                            NewAmountCalculation("dgvtxtQty", e.RowIndex);
                            CalculateTotalAmount();
                        }
                    }
                    else
                    {
                        isValueChange = false;
                        dgvProduct.Rows[e.RowIndex].Cells["productId"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                        isValueChange = true;
                    }
                }
                CheckInvalidEntries(e);
                isDoAfterGridFill = true;
                isValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR68:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from CashOrParty combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbCashOrParty.Text == string.Empty)
                {
                    OrderClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR69:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaterialReceipt_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmMaterialReceiptRegisterObj != null)
                {
                    frmMaterialReceiptRegisterObj.Enabled = true;
                    frmMaterialReceiptRegisterObj.GridFill();
                }
                else if (frmMaterialReceiptReportObj != null)
                {
                    frmMaterialReceiptReportObj.Enabled = true;
                    frmMaterialReceiptReportObj.GridFill();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR70:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// cellenter event of grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvProduct.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvProduct.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["productId"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["productId"].Value.ToString() != string.Empty)
                    {
                        if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                                {
                                    decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                    decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR71: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cellLeave of dgvProduct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            BatchBll BllBatch = new BatchBll();
            PurchaseOrderBll BllPurchaseOrder = new PurchaseOrderBll();
           
            try
            {
                if (isValueChange)
                {
                    string strBarcode = string.Empty;
                    string strProductCode = string.Empty;
                    if (e.RowIndex > -1 && e.ColumnIndex > -1)
                    {
                        CheckInvalidEntries(e);
                        if (e.ColumnIndex == dgvProduct.Columns["dgvcmbBatch"].Index)
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["productId"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["productId"].Value.ToString() != string.Empty)
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                                {
                                    if (Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value) != string.Empty &&
                                       Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value) != "0")
                                    {
                                        decBatchId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value);
                                        strProductCode = dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                                        strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = strBarcode;
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = strProductCode;
                                    }
                                }
                            }
                        }
                        else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                            {
                                UnitConvertionBll bllUnitByProduct = new UnitConvertionBll();
                                List<DataTable> listUnitByProduct = new List<DataTable>();
                                listUnitByProduct = bllUnitByProduct.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["productId"].Value.ToString());
                                foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                {
                                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                        if (isDoAfterGridFill)
                                        {
                                            decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, 2);
                                            NewAmountCalculation("dgvtxtQty", e.RowIndex);
                                            CalculateTotalAmount();
                                        }
                                    }
                                }
                                CheckInvalidEntries(e);
                            }
                        }
                        else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbGodown")
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                            {
                                decGodownId = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value);
                                RackComboFill(decGodownId, e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].ColumnIndex);
                                List<DataTable> listObj = new List<DataTable>();
                                RackBll BllRack = new RackBll();
                                listObj = BllRack.RackNamesCorrespondingToGodownId(decGodownId);
                                dgvProduct.Rows[e.RowIndex].Cells["dgvCmbRack"].Value = Convert.ToDecimal(listObj[0].Rows[0]["rackId"].ToString());
                            }
                            CheckInvalidEntries(e);
                        }
                        else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvCmbCurrency" && isAmountcalc)
                        {
                            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvCmbCurrency"].Value != null && Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells["dgvCmbCurrency"].Value) != string.Empty)
                            {
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtExchangeRate"].Value = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells["dgvCmbCurrency"].Value)));
                            }
                            else
                            {
                                dgvProduct.Rows[e.RowIndex].Cells["dgvCmbCurrency"].Value = BllPurchaseOrder.ExchangeRateIdByCurrencyId(PublicVariables._decCurrencyId);
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtExchangeRate"].Value = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells["dgvCmbCurrency"].Value)));
                            }
                            CheckInvalidEntries(e);
                        }
                        //----------while changing Qty,corresponding change in amount--------
                        else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtQty" && isAmountcalc)
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value != null)
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                                {
                                    NewAmountCalculation("dgvtxtQty", e.RowIndex);
                                    CalculateTotalAmount();
                                }
                            }
                            CheckInvalidEntries(e);
                        }
                        //---------------while changing Qty,corresponding change in amount----
                        else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtRate" && isAmountcalc)
                        {
                            NewAmountCalculation("dgvtxtRate", e.RowIndex);
                            CalculateTotalAmount();
                            CheckInvalidEntries(e);
                        }
                        //----while changing amount ,corresponding chnage in total amount-------
                        else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtAmount" && isAmountcalc)
                        {
                            if (cmbcurrency.Text != string.Empty)
                            {
                                CalculateTotalAmount();
                            }
                        }
                        //}
                    }
                }
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR72:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selected valuechange of cmbVoucherType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                OrderClear();
                if (cmbVoucherType.Text != "NA")
                {
                    if (!isDontExecuteCashorParty && !isDontExecuteVoucherType)
                    {
                        if (cmbCashOrParty.SelectedValue != null && cmbVoucherType.SelectedValue != null)
                        {
                            if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView" && cmbVoucherType.Text != "System.Data.DataRowView" && cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView")
                            {
                                OrderNoComboFill(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR73:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Events
        # region Navigation
        /// <summary>
        /// For shortcut keys 
        /// Esc for formclose
        /// ctrl+s for Save
        /// ctrl+d for delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMaterialReceipt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnSave.Focus();
                    dgvProduct.Focus();
                    btnClose_Click(sender, e);
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    btnSave.Focus();
                    dgvProduct.Focus();
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                {
                    if (btnDelete.Enabled)
                    {
                        btnSave.Focus();
                        dgvProduct.Focus();
                        btnDelete_Click(sender, e);
                    }
                }

                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt) //Product Creation
                {
                    if (dgvProduct.CurrentCell != null)
                    {
                        if (dgvProduct.CurrentCell == dgvProduct.CurrentRow.Cells["dgvtxtProductName"] || dgvProduct.CurrentCell == dgvProduct.CurrentRow.Cells["dgvtxtProductCode"])
                        {
                            if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                            {
                                SendKeys.Send("{F10}");
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                frmProductCreationObj.CallFromMaterialReceipt(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR74:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation 
        /// Alt+c for new ledger creation
        /// ctrl+f for ledger popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                dgvProduct.ClearSelection();
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbcurrency.Enabled)
                    {
                        cmbcurrency.Focus();
                    }
                    else
                    {
                        cmbVoucherType.Focus();
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
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewLedger_Click(sender, e);
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
                        frmLedgerPopupObj.CallFromMaterialReceipt(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryCreditors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR75:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtDate 
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
                    if (!txtReceiptNo.ReadOnly)
                    {
                        if (txtDate.Text == string.Empty || txtDate.SelectionStart == 0)
                        {
                            txtReceiptNo.Focus();
                            txtReceiptNo.SelectionLength = 0;
                            txtReceiptNo.SelectionStart = 0;
                            txtReceiptNo.SelectionStart = txtReceiptNo.TextLength;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR76:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of cmbOrderNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProduct.Enabled)
                    {
                        dgvProduct.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbVoucherType.Text == string.Empty || cmbVoucherType.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();
                        cmbVoucherType.SelectionStart = 0;
                        cmbVoucherType.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR77:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtNarration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTransportation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtLRNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtTransportation.Text == string.Empty || txtTransportation.SelectionStart == 0)
                    {
                        dgvProduct.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR78:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of txtLRNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLRNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtLRNo.Text == string.Empty || txtLRNo.SelectionStart == 0)
                    {
                        txtTransportation.Focus();
                        txtTransportation.SelectionStart = 0;
                        txtTransportation.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR79:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation of dgvProduct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProduct.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvProduct.CurrentCell.ColumnIndex, dgvProduct.CurrentCell.RowIndex);
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbOrderNo.Focus();
                    cmbOrderNo.SelectionLength = 0;
                    cmbOrderNo.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR80:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation dgvProduct
        /// shortcut keys
        /// ctrl+f for ProductSearchPopUp
        /// Alt+c for ProductCreation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvProduct.CurrentCell == dgvProduct.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        if (cmbcurrency.Enabled)
                        {
                            cmbcurrency.Focus();
                            dgvProduct.ClearSelection();
                        }
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Product Search Pop Up
                {
                    if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value != null || dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            frmProductSearchPopupObj.CallFromMaterialReceipt(this, dgvProduct.CurrentRow.Index, dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString());
                        }
                        else
                        {
                            frmProductSearchPopupObj.CallFromMaterialReceipt(this, dgvProduct.CurrentRow.Index, string.Empty);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("MR81:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cbxPrintAfterSave.Enabled)
                    {
                        cbxPrintAfterSave.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("MR82:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of btnClear
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
                MessageBox.Show("MR83:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnClose
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
                MessageBox.Show("MR84:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnDelete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Back)
                {
                    if (btnClear.Enabled)
                    {
                        btnClear.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR85:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// enterkey and backspace navigation of cmbCurrency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbcurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                    cmbCashOrParty.SelectionLength = 0;
                    cmbCashOrParty.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR86:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// enterkey and backspace navigation of txtNarration
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
                        txtLRNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR87:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (btnSave.Enabled)
                    {
                        btnSave.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Enabled)
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionStart = 0;
                        txtNarration.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR88:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation of txtReceiptNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtReceiptNo_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("MR89:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbOrderNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbcurrency.Enabled)
                    {
                        cmbcurrency.Focus();
                    }
                    else
                    {
                        cmbCashOrParty.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR90:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of cbxPrintAfterSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
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
                MessageBox.Show("MR91:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation of btnClear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MR92:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation of btnDelete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyUp(object sender, KeyEventArgs e)
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
                MessageBox.Show("MR93:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnClose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
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
                MessageBox.Show("MR94:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
