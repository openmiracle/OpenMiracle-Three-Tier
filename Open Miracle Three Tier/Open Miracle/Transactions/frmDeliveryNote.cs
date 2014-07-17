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

    public partial class frmDeliveryNote : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration Part
        /// </summary>
        #region Object of other forms
        frmLedgerPopup frmLedgerPopUpObj = new frmLedgerPopup();
        frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
        frmSalesman frmSalesManObj = new frmSalesman();
        frmPricingLevel frmPricingLevelObj = new frmPricingLevel();
        frmDeliveryNoteRegister frmDeliveryNoteRegisterObj;
        frmDeliveryNoteReport frmDeliveryNoteReportObj;
        frmEmployeePopup frmEmployeePopUpObj = new frmEmployeePopup();
        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
        #endregion
        ArrayList lstArrOfRemove = new ArrayList();
        ArrayList arrlstMasterId = new ArrayList();
        decimal decDeliveryNoteVoucherTypeId = 0;//To store selected voucher type Id from frmVoucherTypeSelection
        decimal decDeliveryNoteSuffixPrefixId = 0;//To store the SuffixPrefix Id of the selected voucher type
        decimal decDeliveryNoteMasterId = 0;
        decimal decDelivryNoteIdToEdit = 0;//To take the deliveryNoteMasterId coming from frmDeliveryNoteRegister and frmDeliveryNoteReport
        decimal decCurrentConversionRate = 0;
        decimal decCurrentRate = 0;
        decimal decDeliveryNoteTypeId = 0;
        bool isAutomatic = false;//To check whether the voucher number is automatically generated or not
        string strVoucherNo = string.Empty;//To save the automatically generated voucher number
        string strDeliveryNoteNo = string.Empty;//To get DeliveryNoteNo when SuffixPreffix Settings Change
        int inMaxCount = 0;//To count the row index of grid
        int inNarrationCount = 0;
        bool isRegisterReportFill = false;
        bool isValueChange = false;
        bool isDoAfterGridFill = false;
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        frmVoucherWiseProductSearch objVoucherProduct = null;
        frmVoucherSearch objVoucherSearch = null;
        frmDayBook frmDayBookObj = null;//To use in call from frmDayBook
        #endregion
        #region Function
        /// <summary>
        /// Create an Instance for frmDeliveryNote Class
        /// </summary>
        public frmDeliveryNote()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill cash or party combo box while return from frmAccountLedger form in case of creating new ledger
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedger(decimal decId)//From AccountLedger form
        {
            try
            {
                string strCashOrParty = string.Empty;
                if (decId.ToString() != "0")
                {
                    CashOrPartyComboFill();
                    cmbCashOrParty.SelectedValue = decId.ToString();
                }
                else if (strCashOrParty != string.Empty)
                {
                    cmbCashOrParty.SelectedValue = strCashOrParty;
                }
                else
                {
                    cmbCashOrParty.SelectedText = "Cash";
                }
                this.Enabled = true;
                cmbCashOrParty.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN01: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesMan combo box while return from frmSalesMan form in case of creating new SalesMan
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromSalesManForm(decimal decId)//From SalesMan form
        {
            try
            {
                string strSalesMan = string.Empty;
                if (decId.ToString() != "0")
                {
                    SalesManComboFill();
                    cmbSalesMan.SelectedValue = decId.ToString();
                }
                else if (strSalesMan != string.Empty)
                {
                    cmbSalesMan.SelectedValue = strSalesMan;
                }
                else
                {
                    cmbSalesMan.SelectedText = "NA";
                }
                this.Enabled = true;
                cmbSalesMan.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN02: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Pricing Level combo box while return from frmPricingLevel form in case of creating new PricingLevel
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromPricingLevelForm(decimal decId)//From pricing level form
        {
            try
            {
                string strPricingLevel = string.Empty;
                if (decId.ToString() != "0")
                {
                    PricingLevelComboFill();
                    cmbPricingLevel.SelectedValue = decId.ToString();
                }
                else if (strPricingLevel != string.Empty)
                {
                    cmbPricingLevel.SelectedValue = strPricingLevel;
                }
                else
                {
                    cmbPricingLevel.SelectedText = "NA";
                }
                this.Enabled = true;
                cmbPricingLevel.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN03: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cash Or Party Combo fill function
        /// </summary>
        public void CashOrPartyComboFill()
        {
            TransactionsGeneralFillBll TransactionGenerateFillObj = new TransactionsGeneralFillBll();
            try
            {
                TransactionGenerateFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN04: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// SalesMan Combofill Function
        /// </summary>
        public void SalesManComboFill()
        {
            TransactionsGeneralFillBll TransactionGenerateFillObj = new TransactionsGeneralFillBll();
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                listObj = TransactionGenerateFillObj.SalesmanViewAllForComboFill(cmbSalesMan, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN05: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Pricing Level Combo Fill
        /// </summary>
        public void PricingLevelComboFill()
        {
            TransactionsGeneralFillBll TransactionGenerateFillObj = new TransactionsGeneralFillBll();
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                listObj = TransactionGenerateFillObj.PricingLevelViewAll(cmbPricingLevel, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN06: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call These form from vouchertype Selection form
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                decDeliveryNoteVoucherTypeId = decVoucherTypeId;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decDeliveryNoteVoucherTypeId);
                infoSuffixPrefix = new SuffixPrefixSettingsBll().GetSuffixPrefixDetails(decDeliveryNoteVoucherTypeId, dtpDate.Value);
                decDeliveryNoteSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtDeliveryNoteNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN07:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the Settings of TickPrintAfterSave checkBox
        /// </summary>
        public void PrintCheck()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                cbxPrint.Checked = new SettingsBll().SettingsStatusCheck("TickPrintAfterSave") == "Yes" ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN08: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate Voucher number as per settings
        /// </summary>
        public void VoucherNumberGeneration()
        {
            SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
            TransactionsGeneralFillBll TransactionGenerateFillObj = new TransactionsGeneralFillBll();
            DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
            string tableName = "DeliveryNoteMaster";
            string strPrefix = string.Empty;
            string strSuffix = string.Empty;
            try
            {
                strVoucherNo = "0";
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = TransactionGenerateFillObj.VoucherNumberAutomaicGeneration(decDeliveryNoteVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                if (Convert.ToDecimal(strVoucherNo) != bllDeliveryNote.DeliveryNoteMasterGetMaxPlusOne(decDeliveryNoteVoucherTypeId))
                {
                    strVoucherNo = bllDeliveryNote.DeliveryNoteMasterMax1(decDeliveryNoteVoucherTypeId).ToString();
                    strVoucherNo = TransactionGenerateFillObj.VoucherNumberAutomaicGeneration(decDeliveryNoteVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    if (bllDeliveryNote.DeliveryNoteMasterMax1(decDeliveryNoteVoucherTypeId) == "0")
                    {
                        strVoucherNo = "0";
                        strVoucherNo = TransactionGenerateFillObj.VoucherNumberAutomaicGeneration(decDeliveryNoteVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, tableName);
                    }
                }
                if (isAutomatic)
                {
                    infoSuffixPrefix = new SuffixPrefixSettingsBll().GetSuffixPrefixDetails(decDeliveryNoteVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decDeliveryNoteSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    strDeliveryNoteNo = strPrefix + strVoucherNo + strSuffix;
                    txtDeliveryNoteNo.Text = strDeliveryNoteNo;
                    txtDeliveryNoteNo.ReadOnly = true;
                }
                else
                {
                    txtDeliveryNoteNo.Text = string.Empty;
                    strDeliveryNoteNo = txtDeliveryNoteNo.Text.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN09:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherSearch to view details and for updation 
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSerach(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                base.Show();
                objVoucherSearch = frm;
                decDelivryNoteIdToEdit = decId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopUp form to select and view Employee created 
        /// </summary>
        /// <param name="frmEmployeePopup"></param>
        /// <param name="decId"></param>
        public void CallFromEmployeePopup(frmEmployeePopup frmEmployeePopup, decimal decId) //  Employee pop up
        {
            try
            {
                base.Show();
                this.frmEmployeePopUpObj = frmEmployeePopup;
                SalesManComboFill();
                cmbSalesMan.SelectedValue = decId;
                cmbSalesMan.Focus();
                frmEmployeePopUpObj.Close();
                frmEmployeePopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN11:  " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmProductSearchPopup form to select and view Product created 
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            try
            {
                base.Show();
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                List<DataTable> list = new List<DataTable>();
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                ProductInfo infoProduct = new ProductInfo();
                BatchBll BllBatch = new BatchBll();
                infoProduct = new ProductCreationBll().ProductView(decproductId);
                dgvProduct.Rows.Add();
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtProductId"].Value = decproductId.ToString();
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                UnitComboFill1(decproductId, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Index, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbUnit"].ColumnIndex);
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                GridGodownComboFill(decproductId, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Index, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbGodown"].ColumnIndex);
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbGodown"].Value = infoProduct.GodownId;
                RackComboFill1(infoProduct.GodownId, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Index, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbRack"].ColumnIndex);
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbRack"].Value = infoProduct.RackId;
                BatchComboFill(decproductId, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Index, dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbBatch"].ColumnIndex);
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbBatch"].Value = BllBatch.BatchIdViewByProductId(decproductId);
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtBarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvcmbBatch"].Value.ToString()));
                list = bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoProduct.UnitId, infoProduct.ProductName);
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtUnitConversionId"].Value = list[0].Rows[0]["unitconversionId"].ToString();
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtConversionRate"].Value = list[0].Rows[0]["conversionRate"].ToString();
                decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtConversionRate"].Value.ToString());
                AmountCalculation("dgvtxtQty", dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Index);
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].Cells["dgvtxtRate"].Value = infoProduct.SalesRate.ToString();
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].HeaderCell.Value = "X";
                dgvProduct.Rows[Convert.ToInt32(decCurrentRowIndex.ToString())].HeaderCell.Style.ForeColor = Color.Red;
                TotalAmountCalculation();
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// To fill the Order combo box based on the sales quotation numbers
        /// </summary>
        public void AgainstQuotationComboFill()
        {
            try
            {
                if (cmbType.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    SalesQuotationBll bllQuotation = new SalesQuotationBll();
                    List<DataTable> ListObj = new List<DataTable>();
                    ListObj = bllQuotation.GetSalesQuotationNumberCorrespondingToLedgerForDN(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbType.SelectedValue.ToString()), decDelivryNoteIdToEdit);
                    DataRow dr = ListObj[0].NewRow();
                    dr[0] = 0;
                    dr[1] = string.Empty;
                    ListObj[0].Rows.InsertAt(dr, 0);
                    cmbOrderNo.DataSource = ListObj[0];
                    if (ListObj[0].Rows.Count > 0)
                    {
                        cmbOrderNo.DisplayMember = "invoiceNo";
                        cmbOrderNo.ValueMember = "quotationMasterId";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN13: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill the Order combo box based on the sales order numbers
        /// </summary>
        public void AgainstOrderComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                if (cmbType.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    ListObj = new SalesOrderBll().GetSalesOrderNoIncludePendingCorrespondingtoLedgerforDN(Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), Convert.ToDecimal(cmbType.SelectedValue.ToString()), decDelivryNoteIdToEdit);
                    DataRow dr = ListObj[0].NewRow();
                    dr[0] = "0";
                    dr[1] = string.Empty;
                    ListObj[0].Rows.InsertAt(dr, 0);
                    cmbOrderNo.DataSource = ListObj[0];
                    if (ListObj[0].Rows.Count > 0)
                    {
                        cmbOrderNo.ValueMember = "salesOrderMasterId";
                        cmbOrderNo.DisplayMember = "invoiceNo";
                        cmbOrderNo.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN14: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// AutoCompletion of Product name and Product code
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
                MessageBox.Show("DN15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// The form Will be reset here
        /// </summary>
        public void Clear()
        {
            try
            {
                SalesManComboFill();
                PricingLevelComboFill();
                CashOrPartyComboFill();
                PrintCheck();
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                dtpDate.Value = PublicVariables._dtCurrentDate;
                txtDate.Text = dtpDate.Value.ToString("dd-MMM-yyyy");
                dgvProduct.Rows.Clear();
                cmbDeliveryMode.Text = "NA";
                txtTotalAmnt.Text = "0.00";
                txtNarration.Text = string.Empty;
                txtTraspotationCompany.Text = string.Empty;
                txtLRNo.Text = string.Empty;
                VoucherNumberGeneration();
                if (isAutomatic)
                {
                    txtDate.Focus();
                }
                CurrencyComboFill();
                if (!isAutomatic)
                {
                    txtDeliveryNoteNo.Focus();
                    txtDeliveryNoteNo.Text = string.Empty;
                    txtDeliveryNoteNo.ReadOnly = false;
                }
                decDelivryNoteIdToEdit = 0;
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                cmbPricingLevel.Enabled = true;
                cmbDeliveryMode.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Generating Serial No
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    row.Cells["Col"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.frmLedgerPopUpObj = frmLedgerPopup;
                if (strComboTypes == "CashOrSundryDeptors")
                {
                    CashOrPartyComboFill();
                    cmbCashOrParty.SelectedValue = decId;
                }
                frmLedgerPopUpObj.Close();
                frmLedgerPopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill the details according to the DeliveryNote master Id from frmDeliveryNoteRegister and frmDeliveryNoteReport
        /// </summary>
        public void FillRegisterOrReport()
        {
            try
            {
                DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
                VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                //DeliveryNoteDetailsSP spDeliveryNoteDetails = new DeliveryNoteDetailsSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                SalesQuotationMasterInfo infoSalesQuotationMaster = new SalesQuotationMasterInfo();
                SalesQuotationBll bllSalesQuotatin = new SalesQuotationBll();
                dgvProduct.Rows.Clear();
                isRegisterReportFill = true;
                btnSave.Text = "Update";
                int inRowIndex = 0;
                btnDelete.Enabled = true;
                txtDeliveryNoteNo.ReadOnly = true;
                if (txtDeliveryNoteNo.ReadOnly == true)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtDeliveryNoteNo.Focus();
                }

                infoDeliveryNoteMaster = bllDeliveryNote.DeliveryNoteMasterViewAllByMasterId(decDelivryNoteIdToEdit);
                txtDeliveryNoteNo.Text = infoDeliveryNoteMaster.InvoiceNo;
                strVoucherNo = infoDeliveryNoteMaster.VoucherNo.ToString();
                decDeliveryNoteSuffixPrefixId = Convert.ToDecimal(infoDeliveryNoteMaster.SuffixPrefixId);
                decDeliveryNoteVoucherTypeId = Convert.ToDecimal(infoDeliveryNoteMaster.VoucherTypeId);
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decDeliveryNoteVoucherTypeId);
                decDeliveryNoteTypeId = decDeliveryNoteVoucherTypeId;
                cmbCashOrParty.SelectedValue = infoDeliveryNoteMaster.LedgerId;
                txtDate.Text = infoDeliveryNoteMaster.Date.ToString("dd-MMM-yyyy");
                cmbPricingLevel.SelectedValue = infoDeliveryNoteMaster.PricinglevelId;
                infoVoucherType = BllVoucherType.VoucherTypeView(decDeliveryNoteVoucherTypeId);
                this.Text = infoVoucherType.VoucherTypeName;
                if (infoDeliveryNoteMaster.OrderMasterId != 0)
                {
                    cmbDeliveryMode.Text = "Against Order";
                    infoSalesOrderMaster = bllSalesOrder.SalesOrderMasterView(infoDeliveryNoteMaster.OrderMasterId);
                    cmbType.SelectedValue = infoSalesOrderMaster.VoucherTypeId;
                    AgainstOrderComboFill();
                    cmbOrderNo.SelectedValue = infoDeliveryNoteMaster.OrderMasterId;
                }
                else if (infoDeliveryNoteMaster.QuotationMasterId != 0)
                {
                    cmbDeliveryMode.Text = "Against Quotation";
                    infoSalesQuotationMaster = bllSalesQuotatin.SalesQuotationMasterView(infoDeliveryNoteMaster.QuotationMasterId);
                    cmbType.SelectedValue = infoSalesQuotationMaster.VoucherTypeId;
                    AgainstQuotationComboFill();
                    cmbOrderNo.SelectedValue = infoDeliveryNoteMaster.QuotationMasterId;
                }
                CurrencyComboFill();
                cmbSalesMan.SelectedValue = infoDeliveryNoteMaster.EmployeeId;
                cmbCurrency.SelectedValue = infoDeliveryNoteMaster.ExchangeRateId;
                txtTraspotationCompany.Text = infoDeliveryNoteMaster.TransportationCompany;
                txtNarration.Text = infoDeliveryNoteMaster.Narration;
                txtLRNo.Text = infoDeliveryNoteMaster.LrNo;
                txtTotalAmnt.Text = infoDeliveryNoteMaster.TotalAmount.ToString("00.00");
                List<DataTable> listObjDetails = bllDeliveryNote.DeliveryNoteDetailsViewByDeliveryNoteMasterId(decDelivryNoteIdToEdit);
                foreach (DataRow drowDetails in listObjDetails[0].Rows)
                {
                    dgvProduct.Rows.Add();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtBarcode"].ReadOnly = true;
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtBarcode"].Value = drowDetails["barcode"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtDetailsId"].Value = drowDetails["deliveryNoteDetailsId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtVoucherNo"].Value = drowDetails["VoucherNo"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtInvoiceNo"].Value = drowDetails["OrderNoOrQuotationNo"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtVoucherTypeId"].Value = drowDetails["VoucherTypeId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductId"].Value = drowDetails["productId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductCode"].Value = drowDetails["productCode"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductName"].Value = drowDetails["productName"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["Col"].Value = drowDetails["slNo"].ToString();
                    if (Convert.ToDecimal(drowDetails["orderDetails1Id"].ToString()) == 0)
                    {
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtOrderDetailsId"].Value = 0;
                    }
                    else
                    {
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtOrderDetailsId"].Value = Convert.ToDecimal(drowDetails["orderDetails1Id"].ToString());
                    }
                    if (Convert.ToDecimal(drowDetails["quotationDetails1Id"].ToString()) != 0)
                    {
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtOrderDetailsId"].Value = Convert.ToDecimal(drowDetails["quotationDetails1Id"].ToString());
                    }
                    BatchComboFill(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                    UnitComboFill1(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                    GridGodownComboFill(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(drowDetails["godownId"].ToString());
                    RackComboFill1(Convert.ToDecimal(drowDetails["godownId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbRack"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbRack"].Value = Convert.ToDecimal(drowDetails["rackId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtQty"].Value = drowDetails["qty"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtRate"].Value = drowDetails["rate"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtUnitConversionId"].Value = drowDetails["unitConversionId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value = drowDetails["conversionRate"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtAmount"].Value = drowDetails["amount"].ToString();
                    if (cmbOrderNo.Visible == true)
                    {
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                    }
                    if (bllDeliveryNote.DeliveryNoteMasterReferenceCheckRejectionIn(decDelivryNoteIdToEdit))
                    {
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtBarcode"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductCode"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductName"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbRack"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtRate"].ReadOnly = true;
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                    }
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].HeaderCell.Value = "";
                    AmountCalculation("dgvtxtQty", inRowIndex);
                    TotalAmountCalculation();
                }
                if (!isAutomatic)
                {
                    txtDeliveryNoteNo.ReadOnly = false;
                    txtDeliveryNoteNo.Focus();
                }
                isRegisterReportFill = false;
                isDoAfterGridFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN19: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the details based on the deliveryNote masterId from frmDeliveryNoteRegister
        /// </summary>
        /// <param name="frmDeliveryNoteRegister"></param>
        /// <param name="decDeliveryNoteMasterid"></param>
        public void CallFromDeliveryNoteRegister(frmDeliveryNoteRegister frmDeliveryNoteRegister, decimal decDeliveryNoteMasterid)
        {
            try
            {
                base.Show();
                this.frmDeliveryNoteRegisterObj = frmDeliveryNoteRegister;
                decDelivryNoteIdToEdit = decDeliveryNoteMasterid;
                frmDeliveryNoteRegisterObj.Enabled = false;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN20: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the details based on the deliveryNote masterId from frmDeliveryNoteReport
        /// </summary>
        /// <param name="frmDeliveryNoteReport"></param>
        /// <param name="decDeliveryNoteMasterid"></param>
        public void CallFromDeliveryNoteReport(frmDeliveryNoteReport frmDeliveryNoteReport, decimal decDeliveryNoteMasterid)
        {
            try
            {
                base.Show();
                this.frmDeliveryNoteReportObj = frmDeliveryNoteReport;
                decDelivryNoteIdToEdit = decDeliveryNoteMasterid;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN21: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Amount Calculation
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
                if (dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value != null && dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                {
                    if (dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value != null && dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                    {
                        decimal.TryParse(dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString(), out decQty);
                        decimal.TryParse((dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString()), out decRate);
                        decGrossValue = decQty * decRate;
                        dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, PublicVariables._inNoOfDecimalPlaces);
                        TotalAmountCalculation();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN22: " + ex.Message, "OPenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// TotalAmountCalculation
        /// </summary>
        public void TotalAmountCalculation()
        {
            try
            {

                decimal DecTotalAmount = 0;
                foreach (DataGridViewRow dr in dgvProduct.Rows)
                {
                    if (dr.Cells["dgvtxtProductId"].Value != null && dr.Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                    {
                        if (dr.Cells["dgvtxtAmount"].Value != null && dr.Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            decimal decAmt = Convert.ToDecimal(dr.Cells["dgvtxtAmount"].Value.ToString());
                            DecTotalAmount = DecTotalAmount + decAmt;
                        }
                    }
                }
                DecTotalAmount = Math.Round(DecTotalAmount, PublicVariables._inNoOfDecimalPlaces);
                txtTotalAmnt.Text = DecTotalAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check whether the values of grid is valid or not
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (dgvProduct.CurrentRow != null)
                {
                    if (!isValueChange)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString().Trim() == "")
                        {
                            isValueChange = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == "")
                        {
                            isValueChange = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtAmount"].Value) == 0)
                        {
                            isValueChange = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == "" || Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value) == 0)
                        {
                            isValueChange = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value.ToString().Trim() == "")
                        {
                            isValueChange = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value == null || dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChange = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChange = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "";
                        }
                    }
                    isValueChange = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN24: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///Function for ReturnFromProductCreationPopup
        /// </summary>
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
                int inI = dgvProduct.CurrentRow.Index;
                if (inI == dgvProduct.Rows.Count - 1)
                {
                    dgvProduct.Rows.Add();
                }
                if (decProductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decProductId);
                    dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode.ToString();
                    dgvProduct.Rows[inI].Cells["dgvtxtProductId"].Value = decProductId.ToString();
                    dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                    dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value = infoProduct.SalesRate.ToString();
                    UnitComboFill1(decProductId, inI, dgvProduct.Rows[inI].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                    BatchComboFill(decProductId, inI, dgvProduct.Rows[inI].Cells["dgvcmbBatch"].ColumnIndex);
                    dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value = BllBatch.BatchIdViewByProductId(decProductId);
                    dgvProduct.Rows[inI].Cells["dgvtxtBarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString()));
                    GridGodownComboFill(decProductId, dgvProduct.CurrentRow.Index, dgvProduct.Rows[inI].Cells["dgvcmbGodown"].ColumnIndex);
                    dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value = infoProduct.GodownId;
                    RackComboFill1(infoProduct.GodownId, inI, dgvProduct.Rows[inI].Cells["dgvcmbRack"].ColumnIndex);
                    dgvProduct.Rows[inI].Cells["dgvcmbRack"].Value = infoProduct.RackId;
                    list = bllUnitConvertion.DGVUnitConvertionRateByUnitId(infoProduct.UnitId, infoProduct.ProductName);
                    dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value = list[0].Rows[0]["unitconversionId"].ToString();
                    dgvProduct.Rows[inI].Cells["dgvtxtConversionRate"].Value = list[0].Rows[0]["conversionRate"].ToString();
                    decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtConversionRate"].Value.ToString());
                    decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                    AmountCalculation("dgvtxtQty", dgvProduct.CurrentRow.Index);
                    dgvProduct.Rows[inI].HeaderCell.Value = "X";
                    dgvProduct.Rows[inI].HeaderCell.Style.ForeColor = Color.Red;
                    TotalAmountCalculation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to take the next row index of Grid
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
                MessageBox.Show("DN26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inMaxCount;
        }
        /// <summary>
        /// To fill the grid according to the pending Sales order Invoice number
        /// </summary>
        public void FillOrderDetails()
        {
            decimal decOrderNo = 0;
            try
            {
                DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                decOrderNo = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                inMaxCount = 0;
                string strSalesManId;
                decimal DefaultRate = 0;
                dgvProduct.Rows.Clear();
                List<DataTable> ListObj = new SalesOrderBll().SalesOrderMasterViewBySalesOrderMasterId(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()));
                cmbPricingLevel.SelectedValue = ListObj[0].Rows[0]["pricingLevelId"].ToString();
                if (ListObj[0].Rows[0]["employeeId"].ToString() != string.Empty)
                {
                    strSalesManId = ListObj[0].Rows[0]["employeeId"].ToString();
                    cmbSalesMan.SelectedValue = strSalesManId;
                    SalesManComboFill();
                    cmbSalesMan.SelectedValue = ListObj[0].Rows[0]["employeeId"].ToString();
                }
                CurrencyComboFill();
                cmbCurrency.SelectedValue = ListObj[0].Rows[0]["exchangeRateId"].ToString();
                ListObj = new SalesOrderBll().SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining(decOrderNo, 0);
                int inRowIndex = 0;
                isValueChange = false;
                isDoAfterGridFill = false;
                infoDeliveryNoteMaster = bllDeliveryNote.DeliveryNoteMasterViewAllByMasterId(decDelivryNoteIdToEdit);
                foreach (DataRow drowDetails in ListObj[0].Rows)
                {
                    dgvProduct.Rows.Add();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtBarcode"].Value = drowDetails["barcode"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductCode"].Value = drowDetails["productCode"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductId"].Value = drowDetails["productId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductName"].Value = drowDetails["productName"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtQty"].Value = drowDetails["qty"].ToString();
                    string ProductId = drowDetails.ItemArray[2].ToString();
                    UnitComboFill1(Convert.ToDecimal(ProductId), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                    BatchComboFill(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtRate"].Value = drowDetails["rate"].ToString();
                    DefaultRate = Convert.ToDecimal(dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtRate"].Value.ToString());
                    GridGodownComboFill(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(drowDetails["godownId"].ToString());
                    RackComboFill1(Convert.ToDecimal(drowDetails["godownId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbRack"].ColumnIndex);
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbRack"].Value = Convert.ToDecimal(drowDetails["rackId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtOrderDetailsId"].Value = drowDetails["salesOrderDetailsId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtVoucherTypeId"].Value = drowDetails["voucherTypeId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtVoucherNo"].Value = drowDetails["voucherNo"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtInvoiceNo"].Value = drowDetails["invoiceNo"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtUnitConversionId"].Value = drowDetails["unitConversionId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value = drowDetails["conversionRate"].ToString();
                    if (cmbOrderNo.Visible == true)
                    {
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                    }
                    dgvProduct.Rows[dgvProduct.Rows.Count - 2].HeaderCell.Value = "";
                    AmountCalculation("dgvtxtQty", inRowIndex);
                    int inIndex = 0;
                    int.TryParse(drowDetails["extra1"].ToString(), out inIndex);
                    if (inMaxCount < inIndex)
                        inMaxCount = inIndex;
                    inRowIndex++;
                    isValueChange = true;
                }
                for (int i = inRowIndex; i < dgvProduct.Rows.Count; ++i)
                    dgvProduct["inRowIndex", i].Value = GetNextinRowIndex().ToString();
                SerialNo();
                TotalAmountCalculation();
                isDoAfterGridFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN27 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill the grid according to the pending Sales Quotation Invoice number
        /// </summary>
        public void FillQuotationDetails()
        {
            SerialNo();
            try
            {
                SalesQuotationBll bllQuotation = new SalesQuotationBll();
                DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                decimal decOrderNo = 0;
                decimal DefaultRate = 0;
                string strSalesManId;
                inMaxCount = 0;
                decOrderNo = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                dgvProduct.Rows.Clear();
                List<DataTable> ListObj = bllQuotation.SalesQuotationMasterViewByQuotationMasterId(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()));
                if (ListObj[0].Rows.Count > 0)
                {
                    cmbPricingLevel.SelectedValue = ListObj[0].Rows[0]["pricingLevelId"].ToString();
                    if (ListObj[0].Rows[0]["employeeId"].ToString() != string.Empty)
                    {
                        strSalesManId = ListObj[0].Rows[0]["employeeId"].ToString();
                        cmbSalesMan.SelectedValue = strSalesManId;
                        SalesManComboFill();
                        cmbSalesMan.SelectedValue = ListObj[0].Rows[0]["employeeId"].ToString();
                    }
                    CurrencyComboFill();
                    cmbCurrency.SelectedValue = ListObj[0].Rows[0]["exchangeRateId"].ToString();
                    List<DataTable> ListObjDelivery = bllQuotation.SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()), decDeliveryNoteMasterId);
                    int inRowIndex = 0;
                    isValueChange = false;
                    isDoAfterGridFill = false;
                    foreach (DataRow drowDetails in ListObjDelivery[0].Rows)
                    {
                        dgvProduct.Rows.Add();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtBarcode"].Value = drowDetails["barcode"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductId"].Value = drowDetails["productId"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductCode"].Value = drowDetails["productCode"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtProductName"].Value = drowDetails["productName"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtQty"].Value = drowDetails["Qty"].ToString();
                        UnitComboFill1(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ColumnIndex);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drowDetails["unitId"].ToString());
                        BatchComboFill(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].ColumnIndex);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(drowDetails["batchId"].ToString());
                        GridGodownComboFill(Convert.ToDecimal(drowDetails["productId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].ColumnIndex);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(drowDetails["godownId"].ToString());
                        RackComboFill1(Convert.ToDecimal(drowDetails["godownId"].ToString()), dgvProduct.Rows.Count - 2, dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbRack"].ColumnIndex);
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbRack"].Value = Convert.ToDecimal(drowDetails["rackId"].ToString());
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtRate"].Value = drowDetails["Rate"].ToString();
                        DefaultRate = Convert.ToDecimal(dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtRate"].Value.ToString());
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtOrderDetailsId"].Value = drowDetails["quotationDetailsId"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtVoucherTypeId"].Value = drowDetails["voucherTypeId"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtVoucherNo"].Value = drowDetails["voucherNo"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtInvoiceNo"].Value = drowDetails["invoiceNo"].ToString();
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drowDetails["unitConversionId"].ToString());
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtConversionRate"].Value = drowDetails["conversionRate"].ToString();
                        if (cmbOrderNo.Visible == true)
                        {
                            dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvcmbUnit"].ReadOnly = true;
                        }
                        dgvProduct.Rows[dgvProduct.Rows.Count - 2].HeaderCell.Value = "";
                        AmountCalculation("dgvtxtQty", inRowIndex);
                        int inIndex = 0;
                        int.TryParse(drowDetails["extra1"].ToString(), out inIndex);
                        if (inMaxCount < inIndex)
                            inMaxCount = inIndex;
                        inRowIndex++;
                        isValueChange = true;
                    }
                    for (int i = inRowIndex; i < dgvProduct.Rows.Count; ++i)
                        dgvProduct["inRowIndex", i].Value = GetNextinRowIndex().ToString();
                    SerialNo();
                    TotalAmountCalculation();
                    isDoAfterGridFill = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN28 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Rack Combofill
        /// </summary>
        /// <param name="decGodownId"></param>
        /// <param name="inRow"></param>
        /// <param name="inCol"></param>
        public void RackComboFill1(decimal decGodownId, int inRow, int inCol)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RackBll BllRack = new RackBll();
                listObj = BllRack.RackNamesCorrespondingToGodownId(decGodownId);
                DataGridViewComboBoxCell dgvcmbRackCell = (DataGridViewComboBoxCell)dgvProduct.Rows[inRow].Cells[inCol];
                dgvcmbRackCell.DataSource = listObj[0];
                dgvcmbRackCell.ValueMember = "rackId";
                dgvcmbRackCell.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN29 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// BatchComboFill
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="inRow"></param>
        /// <param name="inCol"></param>
        public void BatchComboFill(decimal decProductId, int inRow, int inCol)
        {
            try
            {
                List<DataTable> list = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                list = BllBatch.BatchNamesCorrespondingToProduct(decProductId);
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvProduct.Rows[inRow].Cells[inCol];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN30: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// GridGodownComboFill
        /// </summary>
        public void GridGodownComboFill(decimal decProductId, int inRow, int inCol)
        {
            try
            {
                GodownBll BllGodown = new GodownBll();
                List<DataTable> listGodown = new List<DataTable>();
                listGodown = BllGodown.GodownViewAll();
                dgvcmbGodown.DataSource = listGodown[0];
                DataGridViewComboBoxCell dgvcmbGodownCell = (DataGridViewComboBoxCell)dgvProduct.Rows[inRow].Cells[inCol];
                dgvcmbGodownCell.DataSource = listGodown[0];
                dgvcmbGodown.ValueMember = "godownId";
                dgvcmbGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN31: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// CurrencyComboFill
        /// </summary>
        public void CurrencyComboFill()
        {
            bool IsTrue = false;
            TransactionsGeneralFillBll TransactionGenerateFillObj = new TransactionsGeneralFillBll();
            try
            {
                IsTrue = true;
                List<DataTable> listObj = new List<DataTable>();
                CurrencyBll BllCurrency = new CurrencyBll();
                SettingsBll BllSettings = new SettingsBll();
                listObj = TransactionGenerateFillObj.CurrencyComboByDate(dtpDate.Value);
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
                IsTrue = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// UnitComboFill
        /// </summary>
        public void UnitComboFill1(decimal decproductId, int inRow, int inColumn)
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAllByProductId(decproductId);
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvProduct.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// VoucherTypeComboFill
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                string typeOfVoucher = string.Empty;
                if (cmbDeliveryMode.Text == "Against Order")
                {
                    typeOfVoucher = "Sales Order";
                }
                else
                {
                    typeOfVoucher = "Sales Quotation";
                }
                List<DataTable> listObj = new List<DataTable>();
                listObj = bllDeliveryNote.VoucherTypesBasedOnTypeOfVouchers(typeOfVoucher);
                cmbType.ValueMember = "voucherTypeId";
                cmbType.DisplayMember = "voucherTypeName";
                cmbType.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
                DeliveryNoteDetailsInfo infoDeliveryNoteDetails = new DeliveryNoteDetailsInfo();
                StockPostingInfo infoStockPosting = new StockPostingInfo();
                StockPostingBll BllStockPosting = new StockPostingBll();
                // StockPostingSP spStockPosting = new StockPostingSP();
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                //DeliveryNoteDetailsSP spDeliveryNoteDetails = new DeliveryNoteDetailsSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                SalesOrderMasterInfo infoSalesOrderMaster = new SalesOrderMasterInfo();
                SalesOrderBll bllSalesOrder = new SalesOrderBll();
                SalesQuotationMasterInfo infoSalesQuotationMaster = new SalesQuotationMasterInfo();
                SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
                infoDeliveryNoteMaster.InvoiceNo = txtDeliveryNoteNo.Text;
                infoDeliveryNoteMaster.VoucherTypeId = decDeliveryNoteVoucherTypeId;
                infoDeliveryNoteMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoDeliveryNoteMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoDeliveryNoteMaster.VoucherNo = strVoucherNo;
                infoDeliveryNoteMaster.SuffixPrefixId = decDeliveryNoteSuffixPrefixId;
                if (btnSave.Text == "Save")
                {
                    if (cmbOrderNo.SelectedValue != null)
                    {
                        if (cmbDeliveryMode.Text == "Against Order")
                        {
                            infoDeliveryNoteMaster.OrderMasterId = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                            infoSalesOrderMaster = bllSalesOrder.SalesOrderMasterView(infoDeliveryNoteMaster.OrderMasterId);
                        }
                        else if (cmbDeliveryMode.Text == "Against Quotation")
                        {
                            infoDeliveryNoteMaster.QuotationMasterId = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                            infoSalesQuotationMaster = bllSalesQuotation.SalesQuotationMasterView(infoDeliveryNoteMaster.QuotationMasterId);
                        }
                        else if (cmbDeliveryMode.Text == "NA")
                        {
                            infoDeliveryNoteMaster.OrderMasterId = 0; infoDeliveryNoteMaster.QuotationMasterId = 0;
                        }
                    }
                    else
                    {
                        infoDeliveryNoteMaster.OrderMasterId = 0;
                        infoDeliveryNoteMaster.QuotationMasterId = 0;
                    }
                    infoDeliveryNoteMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                    if (cmbSalesMan.SelectedIndex != -1)
                    {
                        infoDeliveryNoteMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                    }
                    else
                    {
                        infoDeliveryNoteMaster.EmployeeId = 0;
                    }
                    infoDeliveryNoteMaster.Narration = txtNarration.Text;
                    infoDeliveryNoteMaster.TotalAmount = Convert.ToDecimal(txtTotalAmnt.Text);
                    infoDeliveryNoteMaster.UserId = PublicVariables._decCurrentUserId;
                    infoDeliveryNoteMaster.LrNo = txtLRNo.Text;
                    infoDeliveryNoteMaster.TransportationCompany = txtTraspotationCompany.Text;
                    infoDeliveryNoteMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoDeliveryNoteMaster.Extra1 = string.Empty;
                    infoDeliveryNoteMaster.Extra2 = string.Empty;
                    infoDeliveryNoteMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                    if (decDelivryNoteIdToEdit == 0)
                    {
                        decDeliveryNoteMasterId = Convert.ToDecimal(bllDeliveryNote.DeliveryNoteMasterAdd(infoDeliveryNoteMaster));
                    }
                    int inRowcount = dgvProduct.Rows.Count;
                    for (int inI = 0; inI < inRowcount - 1; inI++)
                    {
                        if (dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value == null)
                        {
                            if (cmbDeliveryMode.Text == "Against Order")
                            {
                                if (dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value != null)
                                {
                                    infoDeliveryNoteDetails.OrderDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value == null ? string.Empty : dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                                }
                                else
                                {
                                    infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                    infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                                }
                            }
                            else if (cmbDeliveryMode.Text == "Against Quotation")
                            {
                                if (dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value != null)
                                {
                                    infoDeliveryNoteDetails.QuotationDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value == null ? string.Empty : dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                                }
                                else
                                {
                                    infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                    infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                                }
                            }
                            else if (cmbDeliveryMode.Text == "NA")
                            {
                                infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                            }
                        }
                        else
                        {
                            if (cmbOrderNo.SelectedText != string.Empty)
                            {
                                if (cmbDeliveryMode.Text == "Against Order")
                                {
                                    infoDeliveryNoteDetails.OrderDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                                }
                                else if (cmbDeliveryMode.Text == "Against Quotation")
                                {
                                    infoDeliveryNoteDetails.QuotationDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                                }
                                else if (cmbDeliveryMode.Text == "NA")
                                {
                                    infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                    infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                                }
                            }
                            else
                            {
                                infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                            }
                        }
                        infoDeliveryNoteDetails.ProductId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtProductId"].Value.ToString());
                        infoDeliveryNoteDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        infoDeliveryNoteDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoDeliveryNoteDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        infoDeliveryNoteDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoDeliveryNoteDetails.UnitConversionId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                        infoDeliveryNoteDetails.RackId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbRack"].Value.ToString());
                        infoDeliveryNoteDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                        infoDeliveryNoteDetails.GodownId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                        infoDeliveryNoteDetails.SlNo = Convert.ToInt32(dgvProduct.Rows[inI].Cells["Col"].Value.ToString());
                        infoDeliveryNoteDetails.Extra1 = string.Empty;
                        infoDeliveryNoteDetails.Extra2 = string.Empty;
                        if (decDelivryNoteIdToEdit == 0)
                        {
                            infoDeliveryNoteDetails.DeliveryNoteMasterId = decDeliveryNoteMasterId;
                            bllDeliveryNote.DeliveryNoteDetailsAdd(infoDeliveryNoteDetails);
                        }
                        else
                        {
                            infoDeliveryNoteDetails.DeliveryNoteMasterId = decDelivryNoteIdToEdit;
                            bllDeliveryNote.DeliveryNoteDetailsEdit(infoDeliveryNoteDetails);
                        }
                        infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                        if (dgvProduct.Rows[inI].Cells["dgvtxtVoucherTypeId"].Value != null)
                        {
                            if (cmbDeliveryMode.SelectedItem.ToString() != "NA")
                            {
                                if (dgvProduct.Rows[inI].Cells["dgvtxtVoucherTypeId"].Value != null)
                                {
                                    infoStockPosting.VoucherTypeId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtVoucherTypeId"].Value);
                                }
                                else
                                {
                                    infoStockPosting.VoucherTypeId = 0;
                                }
                                if (dgvProduct.Rows[inI].Cells["dgvtxtVoucherNo"].Value != null)
                                {
                                    infoStockPosting.VoucherNo = dgvProduct.Rows[inI].Cells["dgvtxtVoucherNo"].Value.ToString();
                                }
                                else
                                {
                                    infoStockPosting.VoucherNo = string.Empty;
                                }
                                if (dgvProduct.Rows[inI].Cells["dgvtxtInvoiceNo"].Value != null)
                                {
                                    infoStockPosting.InvoiceNo = dgvProduct.Rows[inI].Cells["dgvtxtInvoiceNo"].Value.ToString();
                                }
                                else
                                {
                                    infoStockPosting.InvoiceNo = string.Empty;
                                }
                                if (decDeliveryNoteVoucherTypeId != 0)
                                {
                                    infoStockPosting.AgainstVoucherTypeId = decDeliveryNoteVoucherTypeId;
                                }
                                else
                                {
                                    infoStockPosting.AgainstVoucherTypeId = 0;
                                }
                                if (strVoucherNo != string.Empty)
                                {
                                    infoStockPosting.AgainstVoucherNo = strVoucherNo;
                                }
                                else
                                {
                                    infoStockPosting.AgainstVoucherNo = string.Empty;
                                }
                                if (txtDeliveryNoteNo.Text != string.Empty)
                                {
                                    infoStockPosting.AgainstInvoiceNo = txtDeliveryNoteNo.Text;
                                }
                                else
                                {
                                    infoStockPosting.AgainstInvoiceNo = string.Empty;
                                }
                            }
                        }
                        else
                        {
                            infoStockPosting.InvoiceNo = txtDeliveryNoteNo.Text;
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.VoucherTypeId = decDeliveryNoteVoucherTypeId;
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.AgainstInvoiceNo = "NA";
                        }
                        infoStockPosting.ProductId = infoDeliveryNoteDetails.ProductId;
                        infoStockPosting.BatchId = infoDeliveryNoteDetails.BatchId;
                        infoStockPosting.UnitId = infoDeliveryNoteDetails.UnitId;
                        infoStockPosting.GodownId = infoDeliveryNoteDetails.GodownId;
                        infoStockPosting.RackId = infoDeliveryNoteDetails.RackId;
                        infoStockPosting.OutwardQty = infoDeliveryNoteDetails.Qty;
                        infoStockPosting.Rate = infoDeliveryNoteDetails.Rate;
                        infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                        infoStockPosting.Extra1 = string.Empty;
                        infoStockPosting.Extra2 = string.Empty;
                        BllStockPosting.StockPostingAdd(infoStockPosting);
                    }
                    Messages.SavedMessage();
                    if (cbxPrint.Checked)
                    {
                        SettingsBll BllSettings = new SettingsBll();
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decDeliveryNoteMasterId);
                        }
                        else
                        {
                            Print(decDeliveryNoteMasterId);
                        }
                    }
                }
                if (btnSave.Text == "Update")
                {
                    SettingsBll BllSettings = new SettingsBll();
                    infoDeliveryNoteMaster.DeliveryNoteMasterId = decDelivryNoteIdToEdit;
                    infoDeliveryNoteMaster.SuffixPrefixId = Convert.ToDecimal(decDeliveryNoteSuffixPrefixId);
                    infoDeliveryNoteMaster.VoucherNo = strVoucherNo;
                    infoDeliveryNoteMaster.UserId = PublicVariables._decCurrentUserId;//by default current userid used as current employeeid
                    infoDeliveryNoteMaster.PricinglevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                    if (cmbSalesMan.SelectedIndex != -1)
                    {
                        infoDeliveryNoteMaster.EmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                    }
                    else
                    {
                        infoDeliveryNoteMaster.EmployeeId = 0;
                    }
                    infoDeliveryNoteMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;

                    if (cmbOrderNo.SelectedValue != null)
                    {
                        if (cmbDeliveryMode.Text == "Against Order")
                        {
                            infoDeliveryNoteMaster.OrderMasterId = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                            infoSalesOrderMaster = bllSalesOrder.SalesOrderMasterView(infoDeliveryNoteMaster.OrderMasterId);
                        }
                        else if (cmbDeliveryMode.Text == "Against Quotation")
                        {
                            infoDeliveryNoteMaster.QuotationMasterId = Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString());
                            infoSalesQuotationMaster = bllSalesQuotation.SalesQuotationMasterView(infoDeliveryNoteMaster.QuotationMasterId);
                        }
                        else if (cmbDeliveryMode.Text == "NA")
                        {
                            infoDeliveryNoteMaster.OrderMasterId = 0; infoDeliveryNoteMaster.QuotationMasterId = 0;
                        }
                    }
                    else
                    {
                        infoDeliveryNoteMaster.OrderMasterId = 0;
                        infoDeliveryNoteMaster.QuotationMasterId = 0;
                    }
                    infoDeliveryNoteMaster.Narration = txtNarration.Text.Trim();
                    infoDeliveryNoteMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                    infoDeliveryNoteMaster.TotalAmount = Convert.ToDecimal(txtTotalAmnt.Text);
                    infoDeliveryNoteMaster.TransportationCompany = txtTraspotationCompany.Text;
                    infoDeliveryNoteMaster.LrNo = txtLRNo.Text;
                    infoDeliveryNoteMaster.Extra1 = string.Empty;
                    infoDeliveryNoteMaster.Extra2 = string.Empty;
                    bllDeliveryNote.DeliveryNoteMasterEdit(infoDeliveryNoteMaster);
                    RemoveDeliveryNoteDetails();
                    infoDeliveryNoteMaster.VoucherTypeId = decDeliveryNoteVoucherTypeId;
                    bllDeliveryNote.StockPostDeletingForDeliveryNote(decDeliveryNoteVoucherTypeId, strVoucherNo, txtDeliveryNoteNo.Text);
                    DeliveryNoteDetails();
                    Messages.UpdatedMessage();
                    if (frmDeliveryNoteRegisterObj != null)
                    {
                        if (cbxPrint.Checked)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decDelivryNoteIdToEdit);
                            }
                            else
                            {
                                Print(decDelivryNoteIdToEdit);
                            }
                        }
                        frmDeliveryNoteRegisterObj.GridFill();
                    }
                    if (frmDeliveryNoteReportObj != null)
                    {
                        if (cbxPrint.Checked)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decDelivryNoteIdToEdit);
                            }
                            else
                            {
                                Print(decDelivryNoteIdToEdit);
                            }
                        }
                        frmDeliveryNoteReportObj.GridFill();
                    }
                    this.Close();
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the Details
        /// </summary>
        public void DeliveryNoteDetails()
        {
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                DeliveryNoteDetailsInfo infoDeliveryNoteDetails = new DeliveryNoteDetailsInfo();
                StockPostingInfo infoStockPosting = new StockPostingInfo();
                StockPostingBll BllStockPosting = new StockPostingBll();
                // StockPostingSP spStockPosting = new StockPostingSP();
                //DeliveryNoteDetailsSP spDeliveryNoteDetails = new DeliveryNoteDetailsSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                UnitBll bllUnit = new UnitBll();

                for (int inI = 0; inI < dgvProduct.Rows.Count - 1; inI++)
                {
                    if (dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value == null)
                    {
                        if (cmbDeliveryMode.Text == "Against Order")
                        {
                            if (dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value != null)
                            {
                                infoDeliveryNoteDetails.OrderDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value == null ? string.Empty : dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                            }
                            else
                            {
                                infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                            }
                        }
                        else if (cmbDeliveryMode.Text == "Against Quotation")
                        {
                            if (dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value != null)
                            {
                                infoDeliveryNoteDetails.QuotationDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value == null ? string.Empty : dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                            }
                            else
                            {
                                infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                            }
                        }
                        else if (cmbDeliveryMode.Text == "NA")
                        {
                            infoDeliveryNoteDetails.OrderDetails1Id = 0;
                            infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                        }
                    }
                    else
                    {
                        if (dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value != null)
                        {
                            if (cmbDeliveryMode.Text == "Against Order")
                            {
                                infoDeliveryNoteDetails.OrderDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                            }
                            else if (cmbDeliveryMode.Text == "Against Quotation")
                            {
                                infoDeliveryNoteDetails.QuotationDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtOrderDetailsId"].Value.ToString());
                            }
                            else if (cmbDeliveryMode.Text == "NA")
                            {
                                infoDeliveryNoteDetails.OrderDetails1Id = 0;
                                infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                            }
                        }
                        else
                        {
                            infoDeliveryNoteDetails.OrderDetails1Id = 0;
                            infoDeliveryNoteDetails.QuotationDetails1Id = 0;
                        }
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value == null || dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value.ToString() == string.Empty || Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value) == 0)
                    {
                        infoDeliveryNoteDetails.DeliveryNoteMasterId = decDelivryNoteIdToEdit;
                        infoProduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoDeliveryNoteDetails.ProductId = infoProduct.ProductId;
                        infoDeliveryNoteDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        infoDeliveryNoteDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value);
                        infoDeliveryNoteDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                        infoDeliveryNoteDetails.GodownId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                        infoDeliveryNoteDetails.RackId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbRack"].Value.ToString());
                        infoDeliveryNoteDetails.UnitConversionId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                        infoDeliveryNoteDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoDeliveryNoteDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoDeliveryNoteDetails.SlNo = Convert.ToInt32(dgvProduct.Rows[inI].Cells["Col"].Value.ToString());
                        infoDeliveryNoteDetails.Extra1 = string.Empty;
                        infoDeliveryNoteDetails.Extra2 = string.Empty;
                        bllDeliveryNote.DeliveryNoteDetailsAdd(infoDeliveryNoteDetails);
                    }
                    else
                    {
                        infoDeliveryNoteDetails.DeliveryNoteMasterId = decDelivryNoteIdToEdit;
                        infoDeliveryNoteDetails.DeliveryNoteDetails1Id = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value);
                        infoProduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoDeliveryNoteDetails.ProductId = infoProduct.ProductId;
                        infoDeliveryNoteDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());

                        if (Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value) == 0)
                        {
                            infoDeliveryNoteDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        }
                        else
                        {
                            infoDeliveryNoteDetails.UnitId = Convert.ToDecimal(bllUnit.UnitIdByUnitName(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].FormattedValue.ToString()));
                        }
                        infoDeliveryNoteDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                        infoDeliveryNoteDetails.GodownId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                        infoDeliveryNoteDetails.RackId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbRack"].Value.ToString());
                        infoDeliveryNoteDetails.UnitConversionId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtUnitConversionId"].Value.ToString());
                        infoDeliveryNoteDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoDeliveryNoteDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoDeliveryNoteDetails.SlNo = Convert.ToInt32(dgvProduct.Rows[inI].Cells["Col"].Value.ToString());
                        bllDeliveryNote.DeliveryNoteDetailsEdit(infoDeliveryNoteDetails);
                    }
                    infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                    if (Convert.ToInt32(dgvProduct.Rows[inI].Cells["dgvtxtVoucherTypeId"].Value) != 0)
                    {
                        if (cmbDeliveryMode.SelectedItem.ToString() != "NA")
                        {
                            if (dgvProduct.Rows[inI].Cells["dgvtxtVoucherTypeId"].Value != null)
                            {
                                infoStockPosting.VoucherTypeId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtVoucherTypeId"].Value);
                            }
                            else
                            {
                                infoStockPosting.VoucherTypeId = 0;
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvtxtVoucherNo"].Value != null)
                            {
                                infoStockPosting.VoucherNo = dgvProduct.Rows[inI].Cells["dgvtxtVoucherNo"].Value.ToString();
                            }
                            else
                            {
                                infoStockPosting.VoucherNo = string.Empty;
                            }
                            if (dgvProduct.Rows[inI].Cells["dgvtxtInvoiceNo"].Value != null)
                            {
                                infoStockPosting.InvoiceNo = dgvProduct.Rows[inI].Cells["dgvtxtInvoiceNo"].Value.ToString();
                            }
                            else
                            {
                                infoStockPosting.InvoiceNo = string.Empty;
                            }
                            if (decDeliveryNoteVoucherTypeId != 0)
                            {
                                infoStockPosting.AgainstVoucherTypeId = decDeliveryNoteVoucherTypeId;
                            }
                            else
                            {
                                infoStockPosting.AgainstVoucherTypeId = 0;
                            }
                            if (strVoucherNo != string.Empty)
                            {
                                infoStockPosting.AgainstVoucherNo = strVoucherNo;
                            }
                            else
                            {
                                infoStockPosting.AgainstVoucherNo = string.Empty;
                            }
                            if (txtDeliveryNoteNo.Text != string.Empty)
                            {
                                infoStockPosting.AgainstInvoiceNo = txtDeliveryNoteNo.Text;
                            }
                            else
                            {
                                infoStockPosting.AgainstInvoiceNo = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        infoStockPosting.InvoiceNo = txtDeliveryNoteNo.Text;
                        infoStockPosting.VoucherNo = strVoucherNo;
                        infoStockPosting.VoucherTypeId = decDeliveryNoteVoucherTypeId;
                        infoStockPosting.AgainstVoucherTypeId = 0;
                        infoStockPosting.AgainstVoucherNo = "NA";
                        infoStockPosting.AgainstInvoiceNo = "NA";
                    }
                    infoStockPosting.ProductId = infoDeliveryNoteDetails.ProductId;
                    infoStockPosting.BatchId = infoDeliveryNoteDetails.BatchId;
                    infoStockPosting.UnitId = infoDeliveryNoteDetails.UnitId;
                    infoStockPosting.GodownId = infoDeliveryNoteDetails.GodownId;
                    infoStockPosting.RackId = infoDeliveryNoteDetails.RackId;
                    infoStockPosting.OutwardQty = infoDeliveryNoteDetails.Qty;
                    infoStockPosting.Rate = infoDeliveryNoteDetails.Rate;
                    infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoStockPosting.Extra1 = string.Empty;
                    infoStockPosting.Extra2 = string.Empty;
                    BllStockPosting.StockPostingAdd(infoStockPosting);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// RemoveDeliveryNoteDetails If any row was removed at the time of update
        /// </summary>
        public void RemoveDeliveryNoteDetails()
        {
            try
            {
                //DeliveryNoteDetailsSP spDeliveryNoteDetails = new DeliveryNoteDetailsSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                foreach (string str in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(str);
                    bllDeliveryNote.DeliveryNoteDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove incomplete rows
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
                int inLastRow = 1;      //  To eliminate last row from checking
                foreach (DataGridViewRow dgvRowCur in dgvProduct.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvRowCur.HeaderCell.Value != null)
                        {
                            if (dgvRowCur.HeaderCell.Value.ToString() == "X" || dgvRowCur.Cells["dgvtxtProductName"].Value == null)
                            {
                                isOk = false;
                                if (inC == 0)
                                {
                                    strMessage = strMessage + Convert.ToString(dgvRowCur.Index + 1);
                                    inForFirst = dgvRowCur.Index;
                                    inC++;
                                }
                                else
                                {
                                    strMessage = strMessage + ", " + Convert.ToString(dgvRowCur.Index + 1);
                                }
                            }
                        }
                    }
                    inLastRow++;
                }
                inLastRow = 1;
                if (!isOk)
                {
                    strMessage = strMessage + " Contains invalid entries. Do you want to continue?";
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
                MessageBox.Show("DN38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Save or Edit Function checking invalid entries here
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                string strDeliveryModeText = string.Empty;
                cmbDeliveryMode.Text = strDeliveryModeText;
                dgvProduct.ClearSelection();
                int inRow = dgvProduct.RowCount;

                if (txtDeliveryNoteNo.Text.Trim() == string.Empty && decDeliveryNoteMasterId == 0)
                {
                    Messages.InformationMessage("Enter Delivery Note Number");
                    txtDeliveryNoteNo.Focus();
                }
                else if (bllDeliveryNote.DeliveryNotNumberCheckExistence(txtDeliveryNoteNo.Text.Trim(), 0, decDeliveryNoteVoucherTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Number already exist");
                    txtDeliveryNoteNo.Focus();
                }
                else if (txtDate.Text.Trim() == string.Empty && decDeliveryNoteMasterId == 0)
                {
                    Messages.InformationMessage("Select a date in between financial year");
                    txtDate.Focus();
                }
                else if (cmbCashOrParty.SelectedValue == null && decDeliveryNoteMasterId == 0)
                {
                    Messages.InformationMessage("Select Cash/Party");
                    cmbCashOrParty.Focus();
                }
                else if (cmbPricingLevel.SelectedValue == null && decDeliveryNoteMasterId == 0)
                {
                    Messages.InformationMessage("Select PricingLevel");
                    cmbPricingLevel.Focus();
                }
                else if (cmbDeliveryMode.Text == null && decDeliveryNoteMasterId == 0)
                {
                    Messages.InformationMessage("Select DeliveryMode");
                    cmbDeliveryMode.Focus();
                }
                else if (cmbDeliveryMode.SelectedIndex != 0 && cmbOrderNo.Text == string.Empty)
                {
                    Messages.InformationMessage("Select OrderNo");
                    cmbOrderNo.Focus();
                }
                else if (cmbSalesMan.SelectedValue == null && decDeliveryNoteMasterId == 0)
                {
                    Messages.InformationMessage("Select Salesman");
                    cmbSalesMan.Focus();
                }
                else if (cmbCurrency.SelectedValue == null && decDeliveryNoteMasterId == 0)
                {
                    Messages.InformationMessage("Select Currency");
                    cmbCurrency.Focus();
                }
                else if (RemoveIncompleteRowsFromGrid())
                {
                    if (dgvProduct.Rows[0].Cells["dgvcmbUnit"].Value == null || dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null && dgvProduct.Rows[0].Cells["dgvtxtProductCode"].Value == null)
                    {
                        MessageBox.Show("Can't save Delivery note details without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProduct.ClearSelection();
                        dgvProduct.Focus();
                        goto Exit;
                    }
                    else
                    {
                        if (btnSave.Text == "Save")
                        {

                            if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null || dgvProduct.Rows[0].Cells["dgvtxtQty"].Value == null || dgvProduct.Rows[0].Cells["dgvcmbRack"].Value == null
                                || dgvProduct.Rows[0].Cells["dgvcmbRack"].Value == null || dgvProduct.Rows[0].Cells["dgvtxtAmount"].Value == null ||
                                dgvProduct.Rows[0].Cells["dgvtxtRate"].Value == null || dgvProduct.Rows[0].Cells["dgvcmbGodown"].Value == null)
                            {
                                MessageBox.Show("Can't save Delivery note details without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvProduct.ClearSelection();
                                dgvProduct.Focus();
                                goto Exit;
                            }

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
                        else if (btnSave.Text == "Update")
                        {
                            if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null || dgvProduct.Rows[0].Cells["dgvtxtQty"].Value == null || dgvProduct.Rows[0].Cells["dgvcmbRack"].Value == null
                               || dgvProduct.Rows[0].Cells["dgvcmbUnit"].Value == null || dgvProduct.Rows[0].Cells["dgvcmbRack"].Value == null || dgvProduct.Rows[0].Cells["dgvtxtAmount"].Value == null ||
                               dgvProduct.Rows[0].Cells["dgvtxtRate"].Value == null)
                            {
                                MessageBox.Show("Can't save Delivery note details without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvProduct.ClearSelection();
                                dgvProduct.Focus();
                                goto Exit;
                            }
                            if (PublicVariables.isMessageEdit)
                            {
                                if (Messages.UpdateMessage())
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
                }
            Exit: ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Print
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        public void Print(decimal decDeliveryNoteMasterId)
        {
            try
            {
                DeliveryNoteMasterInfo infoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                DataSet dsDeliveryNote = bllDeliveryNote.DeliveryNotePrinting(decDeliveryNoteMasterId, 1, infoDeliveryNoteMaster.OrderMasterId, infoDeliveryNoteMaster.QuotationMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.DeliveryNotePrinting(dsDeliveryNote);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Adding columns to print
        /// </summary>
        /// <param name="decDeliveryNoteMasterId"></param>
        public void PrintForDotMatrix(decimal decDeliveryNoteMasterId)
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
                //-------------Other Details-------------------\\
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("DeliveryMode");
                dtblOtherDetails.Columns.Add("PricingLevel");
                dtblOtherDetails.Columns.Add("Type");
                dtblOtherDetails.Columns.Add("SalesMan");
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
                dRowOther["voucherNo"] = txtDeliveryNoteNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["TotalAmount"] = txtTotalAmnt.Text;
                dRowOther["DeliveryMode"] = cmbDeliveryMode.Text;
                dRowOther["PricingLevel"] = cmbPricingLevel.Text;
                dRowOther["Type"] = cmbType.Text;
                dRowOther["SalesMan"] = cmbSalesMan.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtTotalAmnt.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decDeliveryNoteVoucherTypeId);
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
                MessageBox.Show("DN41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete Function
        /// </summary>
        public void Delete()
        {
            try
            {
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                //DeliveryNoteDetailsSP spDeliveryNoteDetails = new DeliveryNoteDetailsSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                StockPostingBll BllStockPosting = new StockPostingBll();
                //StockPostingSP spStockPosting = new StockPostingSP();
                if (!bllDeliveryNote.DeliveryNoteCheckReferenceInSalesInvoice(decDelivryNoteIdToEdit))
                {
                    decimal decResult1 = 0;
                    decimal decResult2 = bllDeliveryNote.DeliveryNoteMasterDelete(decDelivryNoteIdToEdit);
                    for (int inI = 0; inI < dgvProduct.Rows.Count - 1; inI++)
                    {
                        if (Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtDetailsId"].Value) != 0)
                        {
                            decResult1 = bllDeliveryNote.DeliveryNoteDetailsDelete(Convert.ToDecimal(dgvProduct.Rows[0].Cells["dgvtxtDetailsId"].Value.ToString()));
                        }
                    }
                    BllStockPosting.StockPostingDeleteByVoucherTypeAndVoucherNo(strVoucherNo, decDeliveryNoteVoucherTypeId);
                    if (decResult2 > 0)
                    {
                        Messages.DeletedMessage();
                    }
                    else
                    {
                        Messages.ReferenceExistsMessage();
                    }
                    if (frmDeliveryNoteRegisterObj != null)
                    {
                        this.Close();
                        frmDeliveryNoteRegisterObj.GridFill();
                    }
                    if (frmDeliveryNoteReportObj != null)
                    {
                        this.Close();
                        frmDeliveryNoteReportObj.GridFill();
                    }
                    if (frmDayBookObj != null)
                    {
                        this.Close();
                    }
                    if (objVoucherSearch != null)
                    {
                        this.Close();
                    }
                    if (objVoucherProduct != null)
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
                MessageBox.Show("DN42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking confirmation and calling delete function
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
                MessageBox.Show("DN43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                decDelivryNoteIdToEdit = decMasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objVoucherProduct = frmVoucherwiseProductSearch;
                decDelivryNoteIdToEdit = decmasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///Function for Save Or Edit while changing NegativeStockStatus in Settings
        /// </summary>
        public void SaveOrEditFunction()
        {
            try
            {
                decimal decProductId = 0;
                decimal decBatchId = 0;
                decimal decCalcQty = 0;
                SettingsBll BllSettings = new SettingsBll();
                string strStatus = BllSettings.SettingsStatusCheck("NegativeStockStatus");
                bool isNegativeLedger = false;
                StockPostingBll BllStockPosting = new StockPostingBll();
                //StockPostingSP spStockPosting = new StockPostingSP();
                int inRowCount = dgvProduct.RowCount;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvProduct.Rows[i].Cells["dgvtxtproductId"].Value != null && dgvProduct.Rows[i].Cells["dgvtxtproductId"].Value.ToString() != string.Empty)
                    {
                        decProductId = Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtproductId"].Value.ToString());

                        if (dgvProduct.Rows[i].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[i].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                        {
                            decBatchId = Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvcmbBatch"].Value.ToString());
                        }
                        decimal decCurrentStock = BllStockPosting.StockCheckForProductSale(decProductId, decBatchId);
                        if (dgvProduct.Rows[i].Cells["dgvtxtQty"].Value != null && dgvProduct.Rows[i].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                        {
                            decCalcQty = decCurrentStock - Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtQty"].Value.ToString());
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
                        // Clear();
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
                MessageBox.Show("DN46 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ProductDetailsFill(int inRowIndex, string strFillMode)
        {
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                BatchBll BllBatch = new BatchBll();
                StockPostingBll BllStockPosting = new StockPostingBll();
                //StockPostingSP spStockPosting = new StockPostingSP();
                string strPrdCode = string.Empty;
                string strProductName = string.Empty;
                if (strFillMode == "ProductCode")
                {
                    if (dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value != null && dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value as string != string.Empty)
                    {
                        strPrdCode = dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                    }
                    infoProduct = new ProductCreationBll().ProductViewByCode(strPrdCode);
                }
                if (strFillMode == "ProductName")
                {
                    if (dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductName"].Value != null && dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                    {
                        strProductName = dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductName"].Value.ToString();
                    }
                    infoProduct = new ProductCreationBll().ProductViewByName(strProductName);
                }
                if (infoProduct.ProductId != 0)
                {
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                    string strproductId = Convert.ToString(infoProduct.ProductId);
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductId"].Value = infoProduct.ProductId;
                    UnitComboFill1(Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtProductId"].Value), inRowIndex, dgvProduct.Rows[inRowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                    BatchComboFill(Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtProductId"].Value), inRowIndex, dgvProduct.Rows[inRowIndex].Cells["dgvcmbBatch"].ColumnIndex);
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbBatch"].Value = BllStockPosting.BatchViewByProductId(Convert.ToDecimal(dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductId"].Value));
                    string strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvProduct.Rows[inRowIndex].Cells["dgvcmbBatch"].Value.ToString()));
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtBarcode"].Value = strBarcode;
                    GridGodownComboFill(Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtProductId"].Value), inRowIndex, dgvProduct.Rows[inRowIndex].Cells["dgvcmbGodown"].ColumnIndex);
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbGodown"].Value = infoProduct.GodownId;
                    RackComboFill1(Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value), inRowIndex, dgvProduct.Rows[inRowIndex].Cells["dgvcmbRack"].ColumnIndex);
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbRack"].Value = infoProduct.RackId;
                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                    List<DataTable> ListObj = new List<DataTable>();
                    ListObj = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(strproductId);
                    foreach (DataRow drUnitByProduct in ListObj[0].Rows)
                    {
                        if (dgvProduct.Rows[inRowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                        {
                            dgvProduct.Rows[inRowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                            dgvProduct.Rows[inRowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                        }
                    }
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.SalesRate, PublicVariables._inNoOfDecimalPlaces);
                    decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[inRowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                    decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[inRowIndex].Cells["dgvtxtRate"].Value.ToString());
                    decimal decProductId = Convert.ToDecimal(dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductId"].Value.ToString());
                    decimal decBatchId = Convert.ToDecimal(dgvProduct.Rows[inRowIndex].Cells["dgvcmbBatch"].Value.ToString());
                    getProductRate(inRowIndex, decProductId, decBatchId);
                }
                else
                {
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbGodown"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbRack"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtProductId"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtUnitConversionId"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtConversionRate"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                    dgvProduct.Rows[inRowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
                dgvProduct.Rows[index].Cells["dgvtxtRate"].Value = decRate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN48: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Grid view Cell Enter for set editmode and set basics of unit conversion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            decimal decGodownId = 0;
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
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
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
                    if (dgvProduct.CurrentRow.Cells["dgvtxtProductId"].Value != null)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductId"].Value.ToString() != string.Empty)
                        {
                            BatchBll BllBatch = new BatchBll();
                            decimal decBatchId = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvcmbBatch"].Value);
                            string strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = strBarcode;
                        }
                    }
                    if (e.ColumnIndex == dgvProduct.Columns["dgvcmbRack"].Index)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value != null)
                        {
                            if (dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                            {
                                if (dgvProduct.CurrentRow.Cells["dgvcmbRack"].Value == null || dgvProduct.CurrentRow.Cells["dgvcmbRack"].Value.ToString() == string.Empty)
                                {
                                    decGodownId = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvcmbGodown"].Value);
                                    RackComboFill1(decGodownId, e.RowIndex, e.ColumnIndex);
                                }
                            }
                        }
                    }
                }
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill the cash or party
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VoucherTypeComboFill();
                if (cmbCashOrParty.SelectedValue != null && cmbType.SelectedValue != null)
                {
                    if (cmbCashOrParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashOrParty.Text != "System.Data.DataRowView" && cmbType.SelectedValue.ToString() != "System.Data.DataRowView" && cmbType.Text != "System.Data.DataRowView")
                    {
                        dgvProduct.Rows.Clear();
                        txtTotalAmnt.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When Form Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDeliveryNote_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                PrintCheck();
                FillProducts(false, null);
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    dgvProduct.Columns["dgvtxtProductCode"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvtxtProductCode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("barcode") == "Yes")
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
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    dgvProduct.Columns["dgvcmbGodown"].Visible = true;
                    dgvProduct.Columns["dgvcmbRack"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvcmbGodown"].Visible = false;
                    dgvProduct.Columns["dgvcmbRack"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                        dgvProduct.Columns["dgvcmbRack"].Visible = true;
                    else
                        dgvProduct.Columns["dgvcmbRack"].Visible = false;
                }
                else
                {
                    dgvProduct.Columns["dgvcmbRack"].Visible = false;
                }

                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    dgvProduct.Columns["dgvcmbBatch"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvcmbBatch"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new cash or party using btnCashOrParty click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCashOrParty_Click(object sender, EventArgs e)
        {
            try
            {
                string strCashOrParty;
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
                    frmAccountLedgerObj.CallFromDeliveryNote(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromDeliveryNote(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN52:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new Salesman using btnSalesMan click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalesMan_Click(object sender, EventArgs e)
        {
            string strSalesMan;
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
                    frmSalesmanObj.CallFromDeliveryNote(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromDeliveryNote(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN53:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To create a new Pricing level using btnPricingLevel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPricingLevel_Click(object sender, EventArgs e)
        {
            try
            {
                string strPricingLevel;
                if (cmbSalesMan.SelectedValue != null)
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
                    frmPricingLevelObj.CallFromDeliveryNote(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromDeliveryNote(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN54:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Deliverymode combo box Index change , here fill the Vouchertypes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDeliveryMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strDeliveryModeText = string.Empty;
            strDeliveryModeText = cmbDeliveryMode.Text;
            try
            {
                if (cmbDeliveryMode.Text == "NA")
                {
                    lblOrderOrQuotation.Visible = false;
                    lblType.Visible = false;
                    cmbType.Visible = false;
                    cmbOrderNo.Visible = false;
                    Clear();
                }
                else
                {
                    lblOrderOrQuotation.Visible = true;
                    lblType.Visible = true;
                    cmbType.Visible = true;
                    cmbOrderNo.Visible = true;
                    VoucherTypeComboFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN55: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Combobox Order no Index Change here call the gridfill function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOrderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvProduct.RowCount - 1; i++)
                {
                    if (dgvProduct.Rows[i].Cells["dgvtxtDetailsId"].Value != null && dgvProduct.Rows[i].Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                    {
                        lstArrOfRemove.Add(dgvProduct.Rows[i].Cells["dgvtxtDetailsId"].Value.ToString());
                    }
                }
                dgvProduct.Rows.Clear();
                if (!isRegisterReportFill)
                {
                    if (cmbOrderNo.SelectedValue != null)
                    {

                        if (cmbOrderNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbOrderNo.Text != "System.Data.DataRowView")
                        {
                            if (cmbOrderNo.SelectedText.Trim() != string.Empty || Convert.ToInt32(cmbOrderNo.SelectedValue.ToString()) != 0)
                            {
                                if (cmbDeliveryMode.Text == "Against Order")
                                {
                                    FillOrderDetails();
                                }
                                else if (cmbDeliveryMode.Text == "Against Quotation")
                                {
                                    FillQuotationDetails();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN56: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SaveOrEditFunction();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN57:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN58:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                                if (dgvProduct.CurrentRow.Cells["dgvtxtDetailsId"].Value != null && dgvProduct.CurrentRow.Cells["dgvtxtDetailsId"].Value.ToString() != "")
                                {
                                    lstArrOfRemove.Add(dgvProduct.CurrentRow.Cells["dgvtxtDetailsId"].Value.ToString());
                                    dgvProduct.Rows.Remove(dgvProduct.CurrentRow);
                                    TotalAmountCalculation();
                                }
                                else
                                {
                                    dgvProduct.Rows.Remove(dgvProduct.CurrentRow);
                                    TotalAmountCalculation();
                                }

                            }
                            else
                            {
                                dgvProduct.Rows.Remove(dgvProduct.CurrentRow);
                                TotalAmountCalculation();
                            }
                        }
                    }
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN59:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Button close click
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
                MessageBox.Show("DN60:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (frmDeliveryNoteRegisterObj != null)
                {
                    frmDeliveryNoteRegisterObj.Close();
                    frmDeliveryNoteRegisterObj = null;
                }

                if (frmDeliveryNoteReportObj != null)
                {
                    frmDeliveryNoteReportObj.Close();
                    frmDeliveryNoteReportObj = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN61:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the gridview's keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvProduct.CurrentCell != null && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    else if (dgvProduct.CurrentCell != null && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    else
                    {
                        TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN62:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Delete button click, Checking the User privilege Also
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
                MessageBox.Show("DN63:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For DecimalValidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentCell != null)
                {
                    if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtQty" || dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN64:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Closing. checking the other form is active or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDeliveryNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
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
                    objVoucherSearch = null;
                }
                if (objVoucherProduct != null)
                {
                    objVoucherProduct.Enabled = true;
                    objVoucherProduct.FillGrid();
                }
                if (frmDeliveryNoteRegisterObj != null)
                {
                    frmDeliveryNoteRegisterObj.Enabled = true;
                    frmDeliveryNoteRegisterObj.GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN65:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Vouchertype combo box selected index changed. here call the gridfill function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbOrderNo.SelectedText = string.Empty;
                for (int i = 0; i < dgvProduct.RowCount - 1; i++)
                {
                    if (dgvProduct.Rows[i].Cells["dgvtxtDetailsId"].Value != null && dgvProduct.Rows[i].Cells["dgvtxtDetailsId"].Value.ToString() != string.Empty)
                    {
                        lstArrOfRemove.Add(dgvProduct.Rows[i].Cells["dgvtxtDetailsId"].Value.ToString());
                    }
                }
                dgvProduct.Rows.Clear();
                if (cmbDeliveryMode.Text == "Against Order")
                {
                    AgainstOrderComboFill();
                }
                else if (cmbDeliveryMode.Text == "Against Quotation")
                {
                    AgainstQuotationComboFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN66:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calling the serial no generation function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN67:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill Product Details Curresponding Product code or Barcode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BatchBll BllBatch = new BatchBll();
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                List<DataTable> listObj = new List<DataTable>();
                isValueChange = false;
                isDoAfterGridFill = false;
                decimal DefaultRate = 0;
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtBarcode")
                {
                    string strBCode = string.Empty;
                    if (!dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].ReadOnly && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString() != string.Empty)
                    {
                        strBCode = dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString();
                    }
                    listObj = new ProductCreationBll().ProductDetailsCoreespondingToBarcode(strBCode);
                    if (listObj[0].Rows.Count > 0)
                    {
                        foreach (DataRow RowDetails in listObj[0].Rows)
                        {
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value = RowDetails["productId"].ToString();
                            decimal decProductId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = RowDetails["productCode"].ToString();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = RowDetails["productName"].ToString();
                            UnitComboFill1(Convert.ToDecimal(RowDetails["productId"].ToString()), e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].ColumnIndex);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(RowDetails["unitId"].ToString());
                            BatchComboFill(Convert.ToDecimal(RowDetails["productId"].ToString()), e.RowIndex, Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(RowDetails["batchId"].ToString());
                            GridGodownComboFill(Convert.ToDecimal(RowDetails["productId"].ToString()), e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].ColumnIndex);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(RowDetails["godownId"].ToString());
                            RackComboFill1(Convert.ToDecimal(RowDetails["godownId"].ToString()), e.RowIndex, dgvProduct.Rows[e.RowIndex].Cells["dgvcmbRack"].ColumnIndex);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbRack"].Value = Convert.ToDecimal(RowDetails["rackId"].ToString());
                            decimal decBatchId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value.ToString());
                            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                            List<DataTable> ListObj = new List<DataTable>();
                            ListObj = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                            foreach (DataRow drUnitByProduct in ListObj[0].Rows)
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                {
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                }
                            }
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(Convert.ToDecimal(RowDetails["salesRate"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                            decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                            decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                            getProductRate(e.RowIndex, decProductId, decBatchId);
                        }
                    }
                    else
                    {
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbRack"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                    }
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtProductCode")
                {
                    isValueChange = false;
                    isDoAfterGridFill = false;
                    ProductDetailsFill(dgvProduct.CurrentRow.Index, "ProductCode");
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtProductName")
                {
                    isValueChange = false;
                    isDoAfterGridFill = false;
                    ProductDetailsFill(dgvProduct.CurrentRow.Index, "ProductName");
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtRate")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value != null)
                    {
                        if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                        {
                            DefaultRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value);
                        }
                    }
                }
                AmountCalculation("dgvtxtQty", e.RowIndex);
                TotalAmountCalculation();
                isValueChange = true;
                isDoAfterGridFill = true;
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN68:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///to get result while we entering or selecting the values
        /// </summary>
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
                MessageBox.Show("DN69:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///to change the corresponding values in grid when cells changed 
        /// </summary>
        private void dgvProduct_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SalesQuotationBll bllQuotation = new SalesQuotationBll();
                //DeliveryNoteMasterSP spDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtQty")
                {
                    decimal decCurrentQty = 0;
                    decimal decOldQty = 0;
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                    {
                        if (decDelivryNoteIdToEdit != 0)
                        {
                            if (cmbOrderNo.SelectedIndex != 0)
                            {
                                if (cmbDeliveryMode.Text == "Against Order")
                                {
                                    List<DataTable> ListObj = new SalesOrderBll().SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()), decDelivryNoteIdToEdit);
                                    decCurrentQty = Convert.ToDecimal(dgvProduct.Rows[0].Cells["dgvtxtQty"].Value.ToString());
                                    decOldQty = Convert.ToDecimal(ListObj[0].Rows[0]["qty"].ToString());
                                }
                                else if (cmbDeliveryMode.Text == "Against Quotation")
                                {
                                    List<DataTable> ListQuotationDetails = bllQuotation.SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()), decDelivryNoteIdToEdit);
                                    if (ListQuotationDetails[0].Rows.Count >= 1)
                                    {
                                        decCurrentQty = Convert.ToDecimal(dgvProduct.Rows[0].Cells["dgvtxtQty"].Value.ToString());
                                        decOldQty = Convert.ToDecimal(ListQuotationDetails[0].Rows[0]["qty"].ToString());
                                    }
                                }
                                if (bllDeliveryNote.DeliveryNoteMasterReferenceCheckRejectionIn(decDelivryNoteIdToEdit))
                                {
                                    List<DataTable> listObjRejectionInQty = new List<DataTable>();
                                    listObjRejectionInQty = bllDeliveryNote.DeliveryNoteMasterReferenceCheckRejectionInQty(decDelivryNoteIdToEdit);
                                    decimal decRejectionInQty = decimal.Parse(listObjRejectionInQty[0].Rows[e.RowIndex]["qty"].ToString());
                                    if (decimal.Parse(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString()) > decimal.Parse(listObjRejectionInQty[0].Rows[e.RowIndex]["qty"].ToString()))
                                    {
                                        decCurrentQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString());
                                    }
                                    else
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = Convert.ToDecimal(decRejectionInQty);
                                    }
                                }
                                if (bllDeliveryNote.DeliveryNoteCheckReferenceInSalesInvoice(decDelivryNoteIdToEdit))
                                {
                                    List<DataTable> listObjSalesInvoiceQty = new List<DataTable>();
                                    listObjSalesInvoiceQty = bllDeliveryNote.DeliveryNoteMasterReferenceCheckSalesInvoiceQty(decDelivryNoteIdToEdit);
                                    decimal decSalesInvoiceQty = decimal.Parse(listObjSalesInvoiceQty[0].Rows[e.RowIndex]["qty"].ToString());
                                    if (decimal.Parse(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString()) > decimal.Parse(listObjSalesInvoiceQty[0].Rows[e.RowIndex]["qty"].ToString()))
                                    {
                                        decCurrentQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString());
                                    }
                                    else
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = Convert.ToDecimal(decSalesInvoiceQty);
                                    }
                                }
                            }
                            else
                            {
                                Messages.InformationMessage("Select OrderNo");
                                cmbOrderNo.Focus();
                            }
                        }
                        if (decDelivryNoteIdToEdit == 0)
                        {
                            if (Convert.ToInt32(dgvProduct.Rows[dgvProduct.Rows.Count - 2].Cells["dgvtxtOrderDetailsId"].Value) != 0)
                            {
                                if (cmbDeliveryMode.Text == "Against Quotation")
                                {
                                    List<DataTable> ListObj = bllQuotation.SalesQuotationDetailsViewByquotationMasterIdWithRemainingByNotInCurrDN(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()), decDelivryNoteIdToEdit);
                                    decCurrentQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString());
                                    decOldQty = Convert.ToDecimal(ListObj[0].Rows[e.RowIndex]["qty"].ToString());
                                }
                                else if (cmbDeliveryMode.Text == "Against Order")
                                {
                                    List<DataTable> ListObj = new SalesOrderBll().SalesOrderDetailsViewBySalesOrderMasterIdWithRemaining(Convert.ToDecimal(cmbOrderNo.SelectedValue.ToString()), decDelivryNoteIdToEdit);
                                    decCurrentQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString());
                                    decOldQty = Convert.ToDecimal(ListObj[0].Rows[e.RowIndex]["qty"].ToString());
                                }
                            }
                        }
                    }
                }
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                    {
                        if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                        {
                            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                            List<DataTable> ListObj = new List<DataTable>();
                            ListObj = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                            foreach (DataRow drUnitByProduct in ListObj[0].Rows)
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
                                    }
                                }
                            }
                        }
                    }
                }
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtQty")
                {
                    AmountCalculation("dgvtxtQty", e.RowIndex);
                }
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtRate")
                {
                    AmountCalculation("dgvtxtRate", e.RowIndex);
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtAmount")
                {
                    TotalAmountCalculation();
                }
                CheckInvalidEntries(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN70:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbCashOrParty_Enter(object sender, EventArgs e)
        {
            try
            {
                string strCashOrPartyText = string.Empty;
                cmbCashOrParty.Text = strCashOrPartyText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN71: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbPricingLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal decBatchId = 0;
                decimal decProductId = 0;
                int inRowIndex = 0;
                if (dgvProduct.Rows.Count > 1)
                {
                    foreach (DataGridViewRow dgvRow in dgvProduct.Rows)
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
                MessageBox.Show("DN72:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// For enter key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDeliveryNoteNo_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("DN73:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbCashOrParty.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDate.Text == string.Empty || txtDate.SelectionStart == 0)
                    {
                        if (!isAutomatic)
                        {
                            txtDeliveryNoteNo.Focus();
                            txtDeliveryNoteNo.SelectionStart = 0;
                            txtDeliveryNoteNo.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN74:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Navigation , Search Ledger and also create a new ledger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbDeliveryMode.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Text == string.Empty || cmbCashOrParty.SelectionStart == 0)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                }
                // Cash or Party POP UP when Ctrl+F
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbCashOrParty.SelectedIndex != -1)
                    {
                        frmLedgerPopup frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromDeliveryNote(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryDeptors");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or party");
                    }
                    if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                    {
                        SendKeys.Send("{F10}");
                        btnCashOrParty_Click(sender, e);
                    }
                }
                // Cash or Party New Creation when Alt+C
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    btnCashOrParty_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN75:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDeliveryMode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbDeliveryMode.Text == "NA")
                    {
                        if (cmbPricingLevel.Enabled == true)
                        {
                            cmbPricingLevel.Focus();
                        }
                        else
                        {
                            cmbCurrency.Focus();
                        }
                    }
                    else
                    {
                        cmbType.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbCashOrParty.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN76:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbOrderNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbDeliveryMode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN77:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOrderNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        cmbSalesMan.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN78:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cmbCurrency.Enabled == true)
                    {
                        cmbCurrency.Focus();
                        cmbCurrency.SelectionLength = 0;
                        cmbCurrency.SelectionStart = 0;
                    }
                    else
                    {
                        cmbSalesMan.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbDeliveryMode.Text != "NA")
                    {
                        cmbOrderNo.Focus();
                    }
                    else
                    {
                        cmbDeliveryMode.Focus();
                    }
                }
                //Pricing Level Pop Up when  Ctrl+F
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbPricingLevel.SelectedIndex != -1)
                    {

                        frmPriceListPopup frmPriceListPopUpObj = new frmPriceListPopup();
                        frmPriceListPopUpObj.MdiParent = formMDI.MDIObj;
                        frmPriceListPopUpObj.CallFromDeliveryNoteForPricingfLevelPopUp(this, Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString()), "PricingLevel");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any pricing level");
                    }
                    /*------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                    if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                    {
                        SendKeys.Send("{F10}");
                        btnPricingLevel_Click(sender, e);
                    }
                }
                //CTRL+F for new Ledger creation
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    btnPricingLevel_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN79:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProduct.Rows.Count > 0)
                    {
                        dgvProduct.Focus();
                        dgvProduct.CurrentCell = dgvProduct.Rows[0].Cells["Col"];
                    }
                    else
                    {
                        txtTraspotationCompany.Focus();
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                    else if (cmbPricingLevel.Enabled)
                    {
                        cmbPricingLevel.Focus();
                    }
                    else if (cmbDeliveryMode.SelectedIndex == 0)
                    {
                        cmbDeliveryMode.Focus();
                    }
                    else
                    {
                        cmbOrderNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {

                    frmEmployeePopup frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbSalesMan.SelectedIndex > -1)
                    {
                        frmEmployeePopupObj.CallFromDeliveryNote(this, Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select salesman");
                        cmbSalesMan.Focus();
                    }
                    if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                    {
                        SendKeys.Send("{F10}");
                        btnSalesMan_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    btnSalesMan_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN80:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesMan.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbPricingLevel.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN81:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Get narration row count For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int inKeyPressCount = 0;
                if (e.KeyChar == 13)
                {
                    inKeyPressCount++;
                    if (inKeyPressCount == 2)
                    {
                        inKeyPressCount = 0;
                        txtLRNo.Focus();
                    }
                }
                else
                {
                    inKeyPressCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:82" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTraspotationCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtTraspotationCompany.SelectionStart == 0)
                    {
                        dgvProduct.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:83" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (inNarrationCount >= 2)
                    {
                        inNarrationCount = 0;
                        txtLRNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.TextLength == 0)
                    {
                        txtTraspotationCompany.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:84" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cbxPrint.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtLRNo.TextLength == 0)
                    {
                        txtNarration.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:85" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPrint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtLRNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:86" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnDelete.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:87" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enterkey and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClose.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:88" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cbxPrint.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN89: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int indgvProductRowCount = dgvProduct.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProduct.CurrentCell == dgvProduct.Rows[indgvProductRowCount - 1].Cells["dgvtxtAmount"])
                    {
                        txtTraspotationCompany.Focus();
                        txtTraspotationCompany.SelectionStart = 0;
                        dgvProduct.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvProduct.CurrentCell == dgvProduct.Rows[0].Cells["Col"])
                    {
                        if (cmbSalesMan.Enabled)
                        {
                            cmbSalesMan.Focus();
                        }
                        else if (cmbCurrency.Enabled)
                        {
                            cmbCurrency.Focus();
                        }
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    if (dgvProduct.CurrentCell != null)
                    {
                        if (dgvProduct.CurrentCell == dgvProduct.CurrentRow.Cells["dgvtxtProductName"] || dgvProduct.CurrentCell == dgvProduct.CurrentRow.Cells["dgvtxtProductCode"])
                        {
                            SendKeys.Send("{F10}");
                            if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                            {
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                frmProductCreationObj.CallFromDeliveryNote(this);
                            }
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
                            frmProductSearchPopupObj.CallFromDeliveryNote(this, dgvProduct.CurrentRow.Index, dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString());
                        }
                        else
                        {
                            frmProductSearchPopupObj.CallFromDeliveryNote(this, dgvProduct.CurrentRow.Index, string.Empty);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:90" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cbxPrint.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:91" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Keydown for Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDeliveryNote_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control) //Save
                {
                    btnSave.Focus();
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control) //Delete
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:92" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// to set textbox date as based on dtp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpDate.Value;
                txtDate.Text = date.ToString("dd-MMM-yyyy");
                txtDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:93" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To set dtp value based on Textbox changed
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
                CurrencyComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:94" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  SalesMan button Keydown for navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentCell == dgvProduct.Rows[0].Cells["Col"])
                {
                    if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                    else if (cmbCurrency.Enabled)
                    {
                        cmbCurrency.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DN:95" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}




































































