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
    
    public partial class frmSalesQuotation : Form
    {
        #region public variable
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmLedgerPopup frmLedgerPopUpObj = new frmLedgerPopup();
        frmEmployeePopup frmEmployeePopupObj = new frmEmployeePopup();
        frmSalesQuotationRegister frmSalesQuotationRegisterObj = null;
        frmSalesQuotationReport frmSalesQuotationReportObj = null;
        frmProductSearchPopup frmProductSearchPopupObj;
        frmVoucherSearch objVoucherSearch = null;
        frmVoucherWiseProductSearch objfrmVoucherSearch = null;
        DateValidation dateValidationObj = new DateValidation();
        frmDayBook frmDayBookObj = null;//To use in call from frmDayBook
        DataGridViewTextBoxEditingControl TextBoxControl;
        AutoCompleteStringCollection ProductName;
        AutoCompleteStringCollection ProductCode;
        List<DataTable> ListObjUnitViewAll = new List<DataTable>();
       // DataTable dtblUnitViewAll = new DataTable();//used to view all unit
        DataTable dtblbatchViewAll = new DataTable();//used to view all batch
        ArrayList lstArrOfRemove = new ArrayList();//used to remove curresponding  row from salesQuotation details table 
        decimal DefaultRate = 0;
        decimal decsalesQuotationTypeId = 0;         
        decimal decSalesQuotationPreffixSuffixId = 0;
        decimal decSalesQuotationmasterIdentity = 0;
        decimal decSalesquotationMasterId = 0;
        decimal decSalesQuotationVoucherId = 0;
        decimal decBatchIdForPricingRate = 0;
        decimal decCurrentConversionRate = 0;
        decimal decCurrentRate = 0;
        decimal decBatchId = 0;
        int inNarrationCount = 0;// Number of lines in txtNarration
        bool isAutomatic = false;
        bool isAmountcalc = true;
        bool IsValueChanged = false;
        bool IsDoAfterFill = false;
        bool IsCellValue = false;
        String tableName = "SalesQuotationMaster";
        string isEditMaster = string.Empty;
        string isEditDetails = string.Empty;
        string strSalesman;
        string strSalesQuotationNo = string.Empty;
        string strPrefix = string.Empty;
        string strSuffix = string.Empty;
        string strInvoiceNo = string.Empty;
        string strOldLedgerId = string.Empty;
        string strOldSalesManId = string.Empty;
        string strVoucherNo = string.Empty;
        #endregion
        #region Functions
        /// <summary>
        /// Create instance of frmSalesQuotation
        /// </summary>
        public frmSalesQuotation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call form Voucher Search, for  view Sales Quotation
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                base.Show();
                objVoucherSearch = frm;
                decSalesquotationMasterId = decId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objfrmVoucherSearch = frmVoucherwiseProductSearch;
                decSalesquotationMasterId = decmasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// salesman fill
        /// </summary>
        public void ComboSalesManFill()
        {
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
               transactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesman, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// PricingLevel combo fill
        /// </summary>
        public void ComboPricingLevelFill()
        {
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                transactionGeneralFillObj.PricingLevelViewAll(cmbPricinglevel, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Account Ledger combo fill
        /// </summary>
        public void CashOrPartyCombofill()
        {
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                transactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// date setting at the time of loading
        /// </summary>
        public void salesQuotationDatefill()
        {
            try
            {
                dtpSalesQuotationDate.MinDate = PublicVariables._dtFromDate;
                dtpSalesQuotationDate.MaxDate = PublicVariables._dtToDate;
                dtpSalesQuotationDate.Value = PublicVariables._dtCurrentDate;
                dtpSalesQuotationDate.CustomFormat = "dd-MMMM-yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Unit combo fill
        /// </summary>
        public void DGVUnitComboFill()
        {
            try
            {
                UnitBll bllUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllUnit.UnitViewAll();
                dgvcmbUnit.DataSource = ListObj[0];
                DataRow dr = ListObj[0].NewRow();
                dr[2] = "NA";
                ListObj[0].Rows.InsertAt(dr, 0);
                dgvcmbUnit.ValueMember = "unitId";
                dgvcmbUnit.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial number generation
        /// </summary>
        public void serialNo()
        {
            try
            {
                int intRowNo = 1;
                foreach (DataGridViewRow datarow in dgvProduct.Rows)
                {
                    datarow.Cells["dgvtxtSlNo"].Value = intRowNo;
                    intRowNo++;
                    if (datarow.Index == dgvProduct.Rows.Count - 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decaccountledgerid"></param>
        public void ReturnFromAccountLedger(decimal decaccountledgerid)
        {
            try
            {
                CashOrPartyCombofill();
                if (decaccountledgerid.ToString() != "0")
                {
                    cmbCashOrParty.SelectedValue = decaccountledgerid;
                }
                else
                {
                    cmbCashOrParty.SelectedValue = strOldLedgerId;
                }
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the SalesQuatation register
        /// </summary>
        /// <param name="frmSalesQuotationRegister"></param>
        /// <param name="decQuotationMasterid"></param>
        public void CallFRomSalesQuotationRegister(frmSalesQuotationRegister frmSalesQuotationRegister, decimal decQuotationMasterid)
        {
            try
            {
                base.Show();
                this.frmSalesQuotationRegisterObj = frmSalesQuotationRegister;
                decSalesquotationMasterId = decQuotationMasterid;
                frmSalesQuotationRegisterObj.Enabled = false;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to load the voucher to edit or delete while calling from the SalesQuatation report
        /// </summary>
        /// <param name="frmSalesQuotationReport"></param>
        /// <param name="decQuotationMasterid"></param>
        public void CallFRomSalesQuotationReport(frmSalesQuotationReport frmSalesQuotationReport, decimal decQuotationMasterid)
        {
            try
            {
                base.Show();
                this.frmSalesQuotationReportObj = frmSalesQuotationReport;
                decSalesquotationMasterId = decQuotationMasterid;
                frmSalesQuotationReportObj.Enabled = false;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// AutoCompletion of Product name and Product code
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
                ProductName = new AutoCompleteStringCollection();
                ProductCode = new AutoCompleteStringCollection();
                foreach (DataRow dr in listObjProducts[0].Rows)
                {
                    ProductName.Add(dr["productName"].ToString());
                    ProductCode.Add(dr["productCode"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Currency combo fill
        /// </summary>
        public void ComboCurrencyFill()
        {
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                listObj = transactionGeneralFillObj.CurrencyComboByDate(Convert.ToDateTime(txtSalesQuotationDate.Text));
                cmbCurrency.DataSource = listObj[0];
                cmbCurrency.DisplayMember = "currencyName";
                cmbCurrency.ValueMember = "exchangeRateId";
                cmbCurrency.SelectedValue = 1m;
                DataRow dr = listObj[0].NewRow();
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
                MessageBox.Show("SQ:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                decsalesQuotationTypeId = decVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decsalesQuotationTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
               
                SuffixPrefixInfo InfoSuffixPrefix = new SuffixPrefixInfo();
                InfoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decsalesQuotationTypeId, dtpSalesQuotationDate.Value);
                decSalesQuotationPreffixSuffixId = InfoSuffixPrefix.SuffixprefixId;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtSalesQuotationDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                base.Show();
                this.frmLedgerPopUpObj = frmLedgerPopup;
                if (strComboTypes == "CashOrSundryDeptors")
                {
                    transactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashOrParty, false);
                    cmbCashOrParty.SelectedValue = decId;
                }
                frmLedgerPopUpObj.Close();
                frmLedgerPopUpObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ComboSalesManFill();
                cmbSalesman.SelectedValue = decId;
                cmbSalesman.Focus();
                frmEmployeePopupObj.Close();
                frmEmployeePopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesMan combobox while return from SalesMan creation when creating new SalesMan 
        /// </summary>
        /// <param name="decSalesManId"></param>
        public void ReturnFromSalesMan(decimal decSalesManId)
        {
            try
            {
                ComboSalesManFill();
                if (decSalesManId != 0)
                {
                    cmbSalesman.SelectedValue = decSalesManId;
                }
                else
                {
                    cmbSalesman.SelectedValue = strSalesman;
                }
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove SalesQuatation details in edit mode
        /// </summary>
        public void RemoveSalesQuotationDetails()
        {
            SalesQuotationBll bllSalesQuotationDetails = new SalesQuotationBll();
            try
            {
                foreach (var strId in lstArrOfRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strId);
                    bllSalesQuotationDetails.SalesQuotationDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save new added rows while editmode
        /// </summary>
        public void NewRowAddedToSalesQuotationDetails()
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            SalesQuotationDetailsInfo infoSalesQuotationDetails = new SalesQuotationDetailsInfo();
            ProductInfo infoproduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                for (int inI = 0; inI < dgvProduct.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtquotationDetailsId"].Value) == 0)
                    {
                        infoSalesQuotationDetails.QuotationMasterId = decSalesquotationMasterId;
                        infoproduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoSalesQuotationDetails.ProductId = infoproduct.ProductId;
                        infoSalesQuotationDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        infoSalesQuotationDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value);
                        decimal unitConversion = bllSalesQuotation.UnitconversionIdViewByUnitIdAndProductId(infoSalesQuotationDetails.UnitId, infoSalesQuotationDetails.ProductId);
                        infoSalesQuotationDetails.UnitConversionId = unitConversion;
                        infoSalesQuotationDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoSalesQuotationDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoSalesQuotationDetails.Slno = Convert.ToInt32(dgvProduct.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        if (Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value) == 0)
                        {
                            infoSalesQuotationDetails.BatchId = 0;
                        }
                        else
                        {
                            infoSalesQuotationDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString());
                        }
                        infoSalesQuotationDetails.Extra1 = string.Empty;
                        infoSalesQuotationDetails.Extra2 = string.Empty;
                        bllSalesQuotation.SalesQuotationDetailsAdd(infoSalesQuotationDetails);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the grid to edit the details
        /// </summary>
        public void SalesQuotationDetailsEditFill()
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            SalesQuotationDetailsInfo infoSalesQuotationDetails = new SalesQuotationDetailsInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            ProductInfo infoproduct = new ProductInfo();
            try
            {
                for (int inI = 0; inI < dgvProduct.Rows.Count - 1; inI++)
                {
                    infoSalesQuotationDetails.QuotationMasterId = decSalesquotationMasterId;
                    infoSalesQuotationDetails.QuotationDetailsId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQuotationDetailsId"].Value);
                    infoproduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                    infoSalesQuotationDetails.ProductId = infoproduct.ProductId;
                    infoSalesQuotationDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                    if (Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQuotationDetailsId"].Value) == 0)
                    {
                        infoSalesQuotationDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                    }
                    else
                    {
                        DGVUnitComboFill();
                        infoSalesQuotationDetails.UnitId = Convert.ToDecimal((dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString()));
                    }
                    decimal unitConversion = bllSalesQuotation.UnitconversionIdViewByUnitIdAndProductId(infoSalesQuotationDetails.UnitId, infoSalesQuotationDetails.ProductId);
                    infoSalesQuotationDetails.UnitConversionId = unitConversion;
                    infoSalesQuotationDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value);
                    infoSalesQuotationDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value);
                    infoSalesQuotationDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value);
                    infoSalesQuotationDetails.Slno = Convert.ToInt32(dgvProduct.Rows[inI].Cells["dgvtxtSlNo"].Value);
                    infoSalesQuotationDetails.Extra1 = string.Empty;
                    infoSalesQuotationDetails.Extra2 = string.Empty;
                    bllSalesQuotation.SalesQuotationDetailsEdit(infoSalesQuotationDetails);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check ProductCode Status in settings
        /// </summary>
        /// <returns></returns>
        public bool ShowProductCode()
        {
            SettingsBll BllSettings = new SettingsBll();
            bool isShow = false;
            try
            {
                isShow = BllSettings.ShowProductCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// Function to check the BarCode status in settings
        /// </summary>
        /// <returns></returns>
        public bool ShowBarcode()
        {
            bool isShow = false;
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                isShow = BllSettings.ShowBarcode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isShow;
        }
        /// <summary>
        /// Function to check the printaftersave status in settings
        /// </summary>
        /// <returns></returns>
        public bool PrintAfetrSave()
        {
            bool isTick = false;
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            try
            {
                isTick = transactionGeneralFillObj.StatusOfPrintAfterSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        /// <summary>
        /// Function to print the SalesQuatation
        /// </summary>
        /// <param name="decMasterId"></param>
        public void Print(decimal decMasterId)
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            try
            {
                DataSet dsSalesQuotation = bllSalesQuotation.SalesQuotationPrinting(decMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.SalesQuotationPrinting(dsSalesQuotation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the SalesQuatation in dotmatrix
        /// </summary>
        /// <param name="decMasterId"></param>
       
        public void PrintForDotMatrix(decimal decMasterId)
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
                        dr["BarCode"] = dRow.Cells["dgvtxtBarcode"].Value as string;
                        dr["ProductCode"] = dRow.Cells["dgvtxtProductCode"].Value.ToString();
                        dr["ProductName"] = dRow.Cells["dgvtxtProductName"].Value.ToString();
                        if (dRow.Cells["dgvtxtQty"].Value != null)
                        {
                            dr["Qty"] = dRow.Cells["dgvtxtQty"].Value.ToString();
                        }
                        if (dRow.Cells["dgvcmbUnit"].Value != null)
                        {
                            dr["Unit"] = dRow.Cells["dgvcmbUnit"].FormattedValue.ToString();
                        }
                        dr["Batch"] = dRow.Cells["dgvcmbBatch"].FormattedValue as string;
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
                dtblOtherDetails.Columns.Add("QuotationNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("Cash/Party");
                dtblOtherDetails.Columns.Add("SalesMan");
                dtblOtherDetails.Columns.Add("PricingLevel");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
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
                dRowOther["QuotationNo"] = txtQuotationNo.Text;
                dRowOther["date"] = txtSalesQuotationDate.Text;
                dRowOther["Cash/Party"] = cmbCashOrParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["SalesMan"] = cmbSalesman.Text;
                dRowOther["PricingLevel"] = cmbPricinglevel.Text;
                dRowOther["TotalAmount"] = txtTotal.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashOrParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtTotal.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decsalesQuotationTypeId);
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
                MessageBox.Show("SQ:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to calculate Amount to fill the amount column in grid
        /// </summary>
        /// <param name="cloumnName"></param>
        /// <param name="inIndexOfRow"></param>
        public void AmountCalculation(string cloumnName, int inIndexOfRow)
        {
            try
            {
                decimal decRate = 0;
                decimal decQty = 0;
                decimal decGrossValue = 0;
                if (dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value != null)
                {
                    decimal.TryParse(dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value.ToString(), out decQty);
                } if (dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value != null)
                {
                    decimal.TryParse(dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value.ToString(), out decRate);
                }
                decGrossValue = decQty * decRate;
                dgvProduct.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces));
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate total amount
        /// </summary>
        public void TotalAmountCalculation()
        {
            try
            {
                //ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
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
            catch (Exception ex)
            {
                MessageBox.Show("SQ:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To check if same name in any row if row not equal to x
        /// </summary>
        /// <returns></returns>
        public bool ProductSameOccourance()
        {
            bool isSame = false;
            try
            {
                int index = dgvProduct.CurrentRow.Index;
                string strName = dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    string strOther = dgvProduct.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                    if (strName == strOther)
                    {
                        inCurrentIndex = dgvProduct.Rows[inI].Cells["dgvtxtProductName"].RowIndex;
                    }
                }
                dgvProduct.Rows[inCurrentIndex].HeaderCell.Value = string.Empty;
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSame;
        }
        /// <summary>
        /// Function to remove incomplete rows from the grid 
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowFromTheGrid()
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
                serialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to remove rows from the grid
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
                    if (dgvProduct.CurrentRow.HeaderCell.Value.ToString() == string.Empty && dgvProduct.CurrentRow.HeaderCell.Value == null)
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
                    else
                    {
                        dgvProduct.Rows.RemoveAt(index);
                    }
                }
                else
                {
                    dgvProduct.Rows.RemoveAt(index);
                }
                serialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form to create new sales quatation
        /// </summary>
        public void Clear()
        {
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            try
            {
                if (isAutomatic)
                {
                    strSalesQuotationNo = bllSalesQuotation.SalesQuotationMasterGetMax(decsalesQuotationTypeId).ToString();
                    if (strSalesQuotationNo == string.Empty)
                    {
                        strSalesQuotationNo = " 0";
                    }
                    strSalesQuotationNo = transactionGeneralFillObj.VoucherNumberAutomaicGeneration(decsalesQuotationTypeId, Convert.ToDecimal(strSalesQuotationNo), dtpSalesQuotationDate.Value, tableName);
                    if (Convert.ToDecimal(strSalesQuotationNo) != bllSalesQuotation.SalesQuotationMaxGetPlusOne(decsalesQuotationTypeId))
                    {
                        strSalesQuotationNo = Convert.ToString(bllSalesQuotation.SalesQuotationMaxGetPlusOne(decsalesQuotationTypeId));
                        strSalesQuotationNo = transactionGeneralFillObj.VoucherNumberAutomaicGeneration(decsalesQuotationTypeId, Convert.ToDecimal(strSalesQuotationNo), dtpSalesQuotationDate.Value, tableName);
                        if (bllSalesQuotation.SalesQuotationMasterGetMax(decsalesQuotationTypeId) == 0)
                        {
                            strSalesQuotationNo = "0";
                            strSalesQuotationNo = transactionGeneralFillObj.VoucherNumberAutomaicGeneration(decsalesQuotationTypeId, Convert.ToDecimal(strSalesQuotationNo), dtpSalesQuotationDate.Value, tableName);
                        }
                    }
                    if (isAutomatic)
                    {
                        SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                        
                        SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                        infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decsalesQuotationTypeId, dtpSalesQuotationDate.Value);
                        strPrefix = infoSuffixPrefix.Prefix;
                        strSuffix = infoSuffixPrefix.Suffix;
                        decSalesQuotationPreffixSuffixId = infoSuffixPrefix.SuffixprefixId;
                        strInvoiceNo = strPrefix + strSalesQuotationNo + strSuffix;
                        txtQuotationNo.Text = strInvoiceNo;
                        txtQuotationNo.ReadOnly = true;
                    }
                }
                else
                {
                    txtQuotationNo.Text = string.Empty;
                }
                salesQuotationDatefill();
                if (!ShowProductCode())
                {
                    this.dgvProduct.Columns["dgvtxtProductCode"].Visible = false;
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
                dgvProduct.Rows.Clear();
                txtNarration.Text = string.Empty;
                txtTotal.Text = string.Empty;
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                cbxApproved.Checked = false;
                ComboCurrencyFill();
                ComboPricingLevelFill();
                ComboSalesManFill();
                CashOrPartyCombofill();
                FillProducts(false, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save the sales quatation
        /// </summary>
        public void SaveFunction()
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            //SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            SalesQuotationMasterInfo infoSalesQuotationMaster = new SalesQuotationMasterInfo();
            SalesQuotationDetailsInfo infoSalesQuotationDetails = new SalesQuotationDetailsInfo();
            SettingsBll BllSettings = new SettingsBll();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            ProductInfo infoproduct = new ProductInfo();
            try
            {
                infoSalesQuotationMaster.Date = Convert.ToDateTime(txtSalesQuotationDate.Text);
                infoSalesQuotationMaster.PricinglevelId = Convert.ToDecimal(cmbPricinglevel.SelectedValue.ToString());
                infoSalesQuotationMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                infoSalesQuotationMaster.EmployeeId = Convert.ToDecimal(cmbSalesman.SelectedValue.ToString());
                if (isAutomatic)
                {
                    infoSalesQuotationMaster.SuffixPrefixId = decSalesQuotationPreffixSuffixId;
                    infoSalesQuotationMaster.VoucherNo = strSalesQuotationNo;
                }
                else
                {
                    infoSalesQuotationMaster.SuffixPrefixId = 0;
                    infoSalesQuotationMaster.VoucherNo = bllSalesQuotation.VoucherNoMax(decsalesQuotationTypeId);
                }
                infoSalesQuotationMaster.VoucherTypeId = decsalesQuotationTypeId;
                infoSalesQuotationMaster.InvoiceNo = txtQuotationNo.Text;
                infoSalesQuotationMaster.EmployeeId = Convert.ToDecimal(cmbSalesman.SelectedValue.ToString());
                infoSalesQuotationMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoSalesQuotationMaster.userId = PublicVariables._decCurrentUserId;
                infoSalesQuotationMaster.TotalAmount = Convert.ToDecimal(txtTotal.Text);
                infoSalesQuotationMaster.Narration = txtNarration.Text.Trim();
                infoSalesQuotationMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                infoSalesQuotationMaster.Extra1 = string.Empty;
                infoSalesQuotationMaster.Extra2 = string.Empty;
                if (cbxApproved.Checked)
                {
                    infoSalesQuotationMaster.Approved = true;
                }
                else
                {
                    infoSalesQuotationMaster.Approved = false;
                }
                decSalesQuotationmasterIdentity = Convert.ToDecimal(bllSalesQuotation.SalesQuotationMasterAdd(infoSalesQuotationMaster));
                int inRowcount = dgvProduct.Rows.Count;
                for (int inI = 0; inI < inRowcount - 1; inI++)
                {
                    infoSalesQuotationDetails.QuotationMasterId = decSalesQuotationmasterIdentity;
                    if (dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                    {
                        infoproduct = BllProductCreation.ProductViewByCode(dgvProduct.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoSalesQuotationDetails.ProductId = infoproduct.ProductId;
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value != null && dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                    {
                        infoSalesQuotationDetails.Qty = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                    {
                        infoSalesQuotationDetails.UnitId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                        decimal unitConversion = bllSalesQuotation.UnitconversionIdViewByUnitIdAndProductId(infoSalesQuotationDetails.UnitId, infoSalesQuotationDetails.ProductId);
                        infoSalesQuotationDetails.UnitConversionId = unitConversion;
                    }
                    if (dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                    {
                        infoSalesQuotationDetails.BatchId = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvcmbBatch"].Value);
                    }
                    else
                    {
                        infoSalesQuotationDetails.BatchId = 0;
                    }
                    infoSalesQuotationDetails.Rate = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                    infoSalesQuotationDetails.Amount = Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                    infoSalesQuotationDetails.Slno = Convert.ToInt32(dgvProduct.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                    infoSalesQuotationDetails.Extra1 = string.Empty;
                    infoSalesQuotationDetails.Extra2 = string.Empty;
                    bllSalesQuotation.SalesQuotationDetailsAdd(infoSalesQuotationDetails);
                }
                Messages.SavedMessage();
                if (cbxPrintAfterSave.Checked)
                {
                    if (dgvProduct.Rows.Count > 0)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decSalesQuotationmasterIdentity);
                        }
                        else
                        {
                            Print(decSalesQuotationmasterIdentity);
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("No data found");
                    }
                }
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit the SalesQuatation
        /// </summary>
        public void EditFunction()
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            SalesQuotationMasterInfo infoSalesQuotationMaster = new SalesQuotationMasterInfo();
            //SalesQuotationBll bllSalesQuotation = new infoSalesQuotationMaster();
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                for (int inI = 0; inI < dgvProduct.Rows.Count - 1; inI++)
                {
                    if (Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtquotationDetailsId"].Value) != 0)
                    {
                        isEditDetails = Convert.ToString(bllSalesQuotation.SalesQuotationRefererenceCheckForEditDetails(Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtquotationDetailsId"].Value)));
                    }
                }
                isEditMaster = Convert.ToString(bllSalesQuotation.SalesQuotationRefererenceCheckForEditMaster(decSalesquotationMasterId));
                if (isEditMaster == "False" && isEditDetails == "False")
                {
                    infoSalesQuotationMaster.QuotationMasterId = decSalesquotationMasterId;
                    infoSalesQuotationMaster.Date = Convert.ToDateTime(txtSalesQuotationDate.Text);
                    infoSalesQuotationMaster.LedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());
                    infoSalesQuotationMaster.SuffixPrefixId = Convert.ToDecimal(decSalesQuotationPreffixSuffixId);
                    infoSalesQuotationMaster.VoucherNo = strVoucherNo;
                    infoSalesQuotationMaster.VoucherTypeId = decSalesQuotationVoucherId;
                    infoSalesQuotationMaster.InvoiceNo = txtQuotationNo.Text;
                    infoSalesQuotationMaster.userId = PublicVariables._decCurrentUserId;//by default current userid used as current user id
                    infoSalesQuotationMaster.EmployeeId = Convert.ToDecimal(cmbSalesman.SelectedValue.ToString());
                    infoSalesQuotationMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    infoSalesQuotationMaster.Narration = txtNarration.Text.Trim();
                    infoSalesQuotationMaster.TotalAmount = Convert.ToDecimal(txtTotal.Text);
                    infoSalesQuotationMaster.PricinglevelId = Convert.ToDecimal(cmbPricinglevel.SelectedValue.ToString());
                    infoSalesQuotationMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                    if (cbxApproved.Checked)
                    {
                        infoSalesQuotationMaster.Approved = true;
                    }
                    else
                    {
                        infoSalesQuotationMaster.Approved = false;
                    }
                    infoSalesQuotationMaster.Extra1 = string.Empty;
                    infoSalesQuotationMaster.Extra2 = string.Empty;
                    bllSalesQuotation.SalesQuotationMasterEdit(infoSalesQuotationMaster);
                    RemoveSalesQuotationDetails();
                    NewRowAddedToSalesQuotationDetails();
                    SalesQuotationDetailsEditFill();
                    Messages.UpdatedMessage();
                    if (frmSalesQuotationRegisterObj != null)
                    {
                        if (cbxPrintAfterSave.Checked)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesquotationMasterId);
                            }
                            else
                            {
                                Print(decSalesquotationMasterId);
                            }
                        }
                        this.Close();
                        frmSalesQuotationRegisterObj.GridFill();
                    }
                    if (frmSalesQuotationReportObj != null)
                    {
                        if (cbxPrintAfterSave.Checked)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesquotationMasterId);
                            }
                            else
                            {
                                Print(decSalesquotationMasterId);
                            }
                        }
                        this.Close();
                        frmSalesQuotationReportObj.GridFill();
                    }
                    if (frmDayBookObj != null)
                    {
                        if (cbxPrintAfterSave.Checked)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesquotationMasterId);
                            }
                            else
                            {
                                Print(decSalesquotationMasterId);
                            }
                        }
                        this.Close();
                    }
                    if (objfrmVoucherSearch != null)
                    {
                        if (cbxPrintAfterSave.Checked)
                        {
                            if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                            {
                                PrintForDotMatrix(decSalesquotationMasterId);
                            }
                            else
                            {
                                Print(decSalesquotationMasterId);
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
                                PrintForDotMatrix(decSalesquotationMasterId);
                            }
                            else
                            {
                                Print(decSalesquotationMasterId);
                            }
                        }
                        this.Close();
                    }
                    
                }
                else
                {
                    Messages.ReferenceExistsMessageForUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete the salesquatation
        /// </summary>
        public void Delete()
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
           // SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            try
            {
                decimal decResult2 = bllSalesQuotation.SalesQuotationMasterDelete(decSalesquotationMasterId);
                decimal decResult1 = 0;
                if (decResult2 == 1)
                {
                    for (int inI = 0; inI < dgvProduct.Rows.Count - 1; inI++)
                    {
                        if (Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtquotationDetailsId"].Value) != 0)
                        {
                            decResult1 = bllSalesQuotation.SalesQuotationDetailsDelete(Convert.ToDecimal(dgvProduct.Rows[inI].Cells["dgvtxtquotationDetailsId"].Value));
                        }
                    }
                }
                if (decResult1 > 0 && decResult2 > 0)
                {
                    Messages.DeletedMessage();
                    if (frmSalesQuotationRegisterObj != null)
                    {
                        this.Close();
                        frmSalesQuotationRegisterObj.Enabled = true;
                    }
                    if (frmSalesQuotationReportObj != null)
                    {
                        this.Close();
                        frmSalesQuotationReportObj.Enabled = true;
                    }
                    if (objVoucherSearch != null)
                    {
                        this.Close();
                        objVoucherSearch.Enabled = true;
                    }
                    if (frmDayBookObj != null)
                    {
                        this.Close();
                        frmDayBookObj.Enabled = true;
                    }
                }
                else
                {
                    Messages.ReferenceExistsMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" SQ:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call the delete() after user confirmation
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
                MessageBox.Show("SQ:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the column missing in grid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntriesInDataGridProduct(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentCell != null)
                {
                    if (!IsValueChanged)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value.ToString().Trim() == string.Empty)
                        {
                            IsValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == string.Empty)
                        {
                            IsValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduct.CurrentRow.Cells["dgvtxtAmount"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty || (Convert.ToDecimal(dgvProduct.CurrentRow.Cells["dgvtxtAmount"].Value.ToString()) == 0))
                        {
                            IsValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            IsValueChanged = true;
                            dgvProduct.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    IsValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call the save or edit function and also checking invalid entries 
        /// </summary>
        public void SaveOrEdit()
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            try
            {
                int InRow = dgvProduct.RowCount;
                dgvProduct.ClearSelection();
                if (txtQuotationNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Please enter QuotationNo");
                    txtQuotationNo.Focus();
                }
                else if (bllSalesQuotation.CheckSalesQuotationNumberExistance(txtQuotationNo.Text.Trim(), decsalesQuotationTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Quotation number already  exist");
                }
                else if (cmbCashOrParty.SelectedValue == null)
                {
                    Messages.InformationMessage(" please select cash Or Party");
                    cmbCashOrParty.Focus();
                }
                else if (cmbSalesman.SelectedValue == null)
                {
                    Messages.InformationMessage("Please select any salesman ");
                    cmbSalesman.Focus();
                }
                else if (txtSalesQuotationDate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select date between financial year");
                }
                else if (cmbPricinglevel.SelectedValue == null)
                {
                    Messages.InformationMessage("please select pricing level");
                }
                else if (InRow - 1 == 0)
                {
                    Messages.InformationMessage("Can't save SalesQuotation without atleast one product with complete details");
                }
                else
                {
                    if (RemoveIncompleteRowFromTheGrid())
                    {
                        if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null && dgvProduct.Rows[0].Cells["dgvtxtProductCode"].Value == null && dgvProduct.Rows[0].Cells["dgvcmbBatch"].Value == null)
                        {
                            MessageBox.Show("Can't save salesQuotation  without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvProduct.ClearSelection();
                            dgvProduct.Focus();
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null)
                                {
                                    MessageBox.Show("Can't save salesQuotation without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvProduct.ClearSelection();
                                    dgvProduct.Focus();
                                }
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
                                if (dgvProduct.Rows[0].Cells["dgvtxtProductName"].Value == null)
                                {
                                    MessageBox.Show("Can't edit salesQuotation without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show("SQ:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the settings for grid
        /// </summary>
        public void SalesQuotationSettingsCheck()
        {
            try
            {
                ShowBarcode();
                ShowProductCode();
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
                    this.dgvProduct.Columns["dgvtxtProductCode"].Visible = false;
                }
                else
                {
                    this.dgvProduct.Columns["dgvtxtProductCode"].Visible = true;
                }
                if (!ShowBarcode())
                {
                    this.dgvProduct.Columns["dgvtxtBarcode"].Visible = false;
                }
                else
                {
                    this.dgvProduct.Columns["dgvtxtBarcode"].Visible = true; ;
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    this.dgvProduct.Columns["dgvcmbBatch"].Visible = true;
                }
                else
                {
                    this.dgvProduct.Columns["dgvcmbBatch"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    this.dgvProduct.Columns["dgvcmbUnit"].Visible = true;
                }
                else
                {
                    this.dgvProduct.Columns["dgvcmbUnit"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the details for edit or delete
        /// </summary>
        public void FillRegisterOrReport()
        {
            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
            SalesQuotationMasterInfo infoSalesQuotationMaster = new SalesQuotationMasterInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                IsDoAfterFill = false;
                IsCellValue = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                infoSalesQuotationMaster =bllSalesQuotation.SalesQuotationMasterView(decSalesquotationMasterId);
                txtQuotationNo.Text = infoSalesQuotationMaster.InvoiceNo;
                strVoucherNo = infoSalesQuotationMaster.VoucherNo.ToString();
                decSalesQuotationPreffixSuffixId = Convert.ToDecimal(infoSalesQuotationMaster.SuffixPrefixId);
                decSalesQuotationVoucherId = Convert.ToDecimal(infoSalesQuotationMaster.VoucherTypeId);
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decSalesQuotationVoucherId);
                decsalesQuotationTypeId = decSalesQuotationVoucherId;
                txtSalesQuotationDate.Text = infoSalesQuotationMaster.Date.ToString("dd-MMM-yyyy");
                cmbCashOrParty.SelectedValue = infoSalesQuotationMaster.LedgerId;
                ComboSalesManFill();
                cmbSalesman.SelectedValue = infoSalesQuotationMaster.EmployeeId;
                txtNarration.Text = infoSalesQuotationMaster.Narration;
                cmbCurrency.SelectedValue = infoSalesQuotationMaster.ExchangeRateId;
                decimal decsalesregisterTotal = Convert.ToDecimal(infoSalesQuotationMaster.TotalAmount.ToString());
                decsalesregisterTotal = Math.Round(decsalesregisterTotal, PublicVariables._inNoOfDecimalPlaces);
                txtTotal.Text = Convert.ToString(decsalesregisterTotal);
                cmbPricinglevel.SelectedValue = infoSalesQuotationMaster.PricinglevelId;
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllSalesQuotation.SalesQuotationDetailsViewByMasterId(decSalesquotationMasterId);
                if (isAutomatic)
                {
                    txtQuotationNo.ReadOnly = true;
                    txtSalesQuotationDate.Focus();
                }
                else
                {
                    txtQuotationNo.ReadOnly = false;
                    txtQuotationNo.Focus();
                }
                string strApproved = Convert.ToString(infoSalesQuotationMaster.Approved);
                if (strApproved == "False")
                {
                    cbxApproved.Checked = false;
                }
                else
                {
                    cbxApproved.Checked = true;
                }

                decimal decCount = bllSalesQuotation.CheckingStastusForSalesQuotation(decSalesquotationMasterId);
                if (decCount > 0)
                {
                    cbxApproved.Enabled = false;
                }
                else
                {
                    cbxApproved.Enabled = true;
                }
                for (int i = 0; i < ListObj[0].Rows.Count; i++)
                {
                    isAmountcalc = false;

                    dgvProduct.Rows.Add();

                    dgvProduct.Rows[i].HeaderCell.Value = string.Empty;
                    dgvProduct.Rows[i].Cells["dgvtxtQuotationDetailsId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["quotationDetailsId"].ToString());
                    dgvProduct.Rows[i].Cells["ProductId"].Value = ListObj[0].Rows[i]["productId"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtBarcode"].Value = ListObj[0].Rows[i]["Barcode"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtProductCode"].Value = ListObj[0].Rows[i]["productCode"].ToString();
                    transactionGeneralFillObj.UnitViewAllByProductId(dgvProduct, ListObj[0].Rows[i]["productId"].ToString(), i);
                    bllSalesQuotation.SalesQuotationMasterBatchFill(dgvProduct, Convert.ToDecimal(ListObj[0].Rows[i]["productId"].ToString()), i);
                    dgvProduct.Rows[i].Cells["dgvtxtProductName"].Value = ListObj[0].Rows[i]["productName"].ToString();
                    dgvProduct.Rows[i].Cells["dgvtxtQty"].Value = ListObj[0].Rows[i]["qty"].ToString();
                    IsCellValue = true;
                    dgvProduct.Rows[i].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["unitId"].ToString());
                    IsCellValue = false;
                    dgvProduct.Rows[i].Cells["dgvtxtRate"].Value = ListObj[0].Rows[i]["rate"].ToString();
                    IsCellValue = true;
                    dgvProduct.Rows[i].Cells["dgvtxtAmount"].Value = ListObj[0].Rows[i]["amount"].ToString();
                    IsCellValue = false;
                    dgvProduct.Rows[i].Cells["dgvcmbbatch"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["batchId"].ToString());

                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                    List<DataTable> listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[i].Cells["ProductId"].Value.ToString());
                    if (listUnitByProduct[0].Rows.Count > 0)
                    {
                        foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                        {
                            if (dgvProduct.Rows[i].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                            {
                                dgvProduct.Rows[i].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                
                            }
                        }
                    }

                    decimal decStandardRate = BllProductCreation.SalesInvoiceProductRateForSales(Convert.ToDecimal(ListObj[0].Rows[i]["productId"].ToString()), PublicVariables._dtCurrentDate, Convert.ToDecimal(ListObj[0].Rows[i]["batchId"].ToString()), Convert.ToDecimal(cmbPricinglevel.SelectedValue), PublicVariables._inNoOfDecimalPlaces);
                    if (dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                    {
                        if (decStandardRate != 0 && Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value) != 0)
                        {
                            dgvProduct.Rows[i].Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvProduct.Rows[i].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                        }
                    }


                }
                isAmountcalc = true;
                IsCellValue = true;
                IsDoAfterFill = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill product while return from product creation when creating new product 
        /// </summary>
        /// <param name="decProductId"></param>
        public void ReturnFromProductCreation(decimal decProductId)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                this.Enabled = true;
                this.BringToFront();
                if (decProductId != 0)
                {
                    int inCurrentRowIndex = dgvProduct.CurrentRow.Index;
                    dgvProduct.Rows.Add();
                    infoProduct = BllProductCreation.ProductView(decProductId);
                    
                    if (infoProduct.ProductId != 0)
                    {
                        List<DataTable> ListSales = new List<DataTable>();
                        TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
                        List<DataTable> ListObj = new List<DataTable>();
                        SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
                        dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                        dgvProduct.Rows[inCurrentRowIndex].Cells["ProductId"].Value = infoProduct.ProductId;
                        dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                        dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.SalesRate, PublicVariables._inNoOfDecimalPlaces);
                        DefaultRate = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                        ListObj = transactionGeneralFillObj.UnitViewAllByProductId(dgvProduct, infoProduct.ProductId.ToString(), inCurrentRowIndex);
                        ListSales = bllSalesQuotation.SalesQuotationMasterBatchFill(dgvProduct, infoProduct.ProductId, inCurrentRowIndex);
                        BatchBll BllBatch = new BatchBll();
                        decimal decBatchId = BllBatch.BatchIdViewByProductId(infoProduct.ProductId);
                        dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value = decBatchId;
                        dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;

                        if (infoProduct.PartNo != string.Empty)
                        {
                            dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtBarcode"].Value = infoProduct.PartNo;
                        }
                        else
                        {
                            if (dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                            {
                                decBatchId = Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value);
                                dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtBarcode"].Value = BllProductCreation.BarcodeViewByBatchId(decBatchId);
                            }
                        }
                        IsDoAfterFill = true;
                        UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                        List<DataTable> listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[inCurrentRowIndex].Cells["ProductId"].Value.ToString());
                        if (listUnitByProduct[0].Rows.Count > 0)
                        {
                            foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                            {
                                if (dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                {
                                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                    if (IsDoAfterFill)
                                    {
                                        decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                        decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                        dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
                                    }
                                }
                            }
                        }
                        decimal decStandardRate = BllProductCreation.SalesInvoiceProductRateForSales(infoProduct.ProductId, PublicVariables._dtCurrentDate, decBatchId, Convert.ToDecimal(cmbPricinglevel.SelectedValue), PublicVariables._inNoOfDecimalPlaces);
                        if (dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                        {
                            if (decStandardRate != 0 && Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value) != 0)
                            {
                                dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                            }
                        }
                        dgvProduct.Rows[inCurrentRowIndex].HeaderCell.Value = "X";
                        dgvProduct.Rows[inCurrentRowIndex].HeaderCell.Style.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmDayBook.Enabled = false;
                this.frmDayBookObj = frmDayBook;
                decSalesquotationMasterId = decMasterId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmProductSearchPopup form to select and view product
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            ProductInfo infoProduct = new ProductInfo();
            try
            {
                this.Enabled = true;
                this.BringToFront();

                this.frmProductSearchPopupObj = frmProductSearchPopup;
                int inCurrentRowIndex = dgvProduct.CurrentRow.Index;
                dgvProduct.Rows.Add();
                if (decproductId != 0)
                {
                    List<DataTable> ListObj = new List<DataTable>();
                    List<DataTable> ListObjUnitViewAll = new List<DataTable>();
                    infoProduct = BllProductCreation.ProductView(decproductId);
                    TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
                    SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                    dgvProduct.Rows[inCurrentRowIndex].Cells["ProductId"].Value = infoProduct.ProductId;
                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.SalesRate, PublicVariables._inNoOfDecimalPlaces);
                    DefaultRate = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                    ListObjUnitViewAll = transactionGeneralFillObj.UnitViewAllByProductId(dgvProduct, infoProduct.ProductId.ToString(), inCurrentRowIndex);
                    ListObj= bllSalesQuotation.SalesQuotationMasterBatchFill(dgvProduct, infoProduct.ProductId, inCurrentRowIndex);

                    BatchBll BllBatch = new BatchBll();
                    decimal decBatchId = BllBatch.BatchIdViewByProductId(infoProduct.ProductId);
                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value = decBatchId;
                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;

                    if (infoProduct.PartNo != string.Empty)
                    {
                        dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtBarcode"].Value = infoProduct.PartNo;
                    }
                    else
                    {
                        if (dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                        {
                            decBatchId = Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbBatch"].Value);
                            dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtBarcode"].Value = BllProductCreation.BarcodeViewByBatchId(decBatchId);
                        }
                    }
                    IsDoAfterFill = true;
                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                    List<DataTable> listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[inCurrentRowIndex].Cells["ProductId"].Value.ToString());
                    if (listUnitByProduct[0].Rows.Count > 0)
                    {
                        foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                        {
                            if (dgvProduct.Rows[inCurrentRowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                            {
                                dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                if (IsDoAfterFill)
                                {
                                    decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                    decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                    dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
                                }
                            }
                        }
                    }
                    decimal decStandardRate =  BllProductCreation.SalesInvoiceProductRateForSales(infoProduct.ProductId, PublicVariables._dtCurrentDate, decBatchId, Convert.ToDecimal(cmbPricinglevel.SelectedValue), PublicVariables._inNoOfDecimalPlaces);
                    if (dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                    {
                        if (decStandardRate != 0 && Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value) != 0)
                        {
                            dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvProduct.Rows[inCurrentRowIndex].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                    dgvProduct.Rows[inCurrentRowIndex].HeaderCell.Value = "X";
                    dgvProduct.Rows[inCurrentRowIndex].HeaderCell.Style.ForeColor = Color.Red;
                }
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region events
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesQuotation_Load(object sender, EventArgs e)
        {
            try
            {
                SalesQuotationSettingsCheck();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                    frmAccountLedgerObj.CallFromSalesQuotation(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromSalesQuotation(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
       /// On delete button click
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, "Delete"))
            {
                try
                {
                    DeleteFuntion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQ:45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                MessageBox.Show("SQ:46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SaveOrEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On salesman add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSalesman_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSalesman.SelectedValue != null)
                {
                    strSalesman = cmbSalesman.SelectedValue.ToString();
                }
                else
                {
                    strSalesman = string.Empty;
                }
                frmSalesman frmsalesMan = new frmSalesman();
                frmsalesMan.MdiParent = formMDI.MDIObj;
                frmsalesMan.CallFromSalesQuotation(this);
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Amount, rate, quantity column validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentCell != null)
                {
                    if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtAmount" || dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtRate")
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
                MessageBox.Show("SQ:49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On ledger add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewledger_Click(object sender, EventArgs e)
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
                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                    frmAccountLedgerObj.CallFromSalesQuotation(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromSalesQuotation(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// changing date in textbox while changing date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSalesQuotationDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime datetime = this.dtpSalesQuotationDate.Value;
                txtSalesQuotationDate.Text = datetime.ToString("dd-MMM-yyyy");
                ComboCurrencyFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Adding serial no in to the dgvProduct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                serialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (frmSalesQuotationRegisterObj != null)
                {
                    frmSalesQuotationRegisterObj.Close();
                    frmSalesQuotationRegisterObj = null;
                }
                if (frmSalesQuotationReportObj != null)
                {
                    frmSalesQuotationReportObj.Close();
                    frmSalesQuotationReportObj = null;
                }
                if (txtQuotationNo.ReadOnly)
                {
                    txtSalesQuotationDate.Focus();
                }
                else
                {
                    txtQuotationNo.Focus();
                }
                cbxApproved.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SQ:54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// On cellendedit of dgvProduct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            try
            {
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtProductName")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString().Trim() != string.Empty)
                    {
                        string strProductName = Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value);
                        ProductInfo infoProduct = BllProductCreation.ProductViewByName(strProductName);
                        if (infoProduct.ProductCode != null && infoProduct.ProductCode != string.Empty)
                        {
                            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
                            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();

                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = infoProduct.ProductCode;
                            dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value = infoProduct.ProductId;
                            List<DataTable> ListObj = new List<DataTable>();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.SalesRate);
                            DefaultRate = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                            ListObjUnitViewAll = transactionGeneralFillObj.UnitViewAllByProductId(dgvProduct, infoProduct.ProductId.ToString(), e.RowIndex);
                            ListObj = bllSalesQuotation.SalesQuotationMasterBatchFill(dgvProduct, infoProduct.ProductId, e.RowIndex);
                            BatchBll BllBatch = new BatchBll();
                            decimal decBatchId = BllBatch.BatchIdViewByProductId(infoProduct.ProductId);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = decBatchId;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;
                            if (infoProduct.PartNo != string.Empty)
                            {
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = infoProduct.PartNo;
                            }
                            else
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                                {
                                    decBatchId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value);
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = BllProductCreation.BarcodeViewByBatchId(decBatchId);
                                }
                            }
                            IsDoAfterFill = true;
                            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                            List<DataTable> listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                            if (listUnitByProduct[0].Rows.Count > 0)
                            {
                                foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                {
                                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                        if (IsDoAfterFill)
                                        {
                                            decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate,PublicVariables._inNoOfDecimalPlaces);
                                        }
                                    }
                                }
                            }

                            decimal decStandardRate = BllProductCreation.SalesInvoiceProductRateForSales(infoProduct.ProductId, PublicVariables._dtCurrentDate, decBatchId, Convert.ToDecimal(cmbPricinglevel.SelectedValue), PublicVariables._inNoOfDecimalPlaces);
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                            {
                                if (decStandardRate != 0 && Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value) != 0)
                                {
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                                }
                            }

                        }
                        else
                        {
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value = string.Empty;
                        }
                            AmountCalculation("dgvtxtQty", e.RowIndex);
                            TotalAmountCalculation();
                    }
                    else
                    {
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                    }
                }
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtBarcode")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString().Trim() != string.Empty)
                    {
                        List<DataTable> listObjProductdDetails = new List<DataTable>();
                        string strBarcode = (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString());
                        listObjProductdDetails = BllProductCreation.ProductDetailsCoreespondingToBarcode(strBarcode);

                        if (listObjProductdDetails[0].Rows.Count > 0)
                        {
                            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
                            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
                            List<DataTable> ListObj = new List<DataTable>();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = listObjProductdDetails[0].Rows[0]["productCode"].ToString();
                            dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value = listObjProductdDetails[0].Rows[0]["productId"].ToString();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = listObjProductdDetails[0].Rows[0]["productName"].ToString();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(Convert.ToDecimal(listObjProductdDetails[0].Rows[0]["SalesRate"].ToString()));
                            DefaultRate = Math.Round(Convert.ToDecimal(listObjProductdDetails[0].Rows[0]["purchaseRate"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                            ListObjUnitViewAll = transactionGeneralFillObj.UnitViewAllByProductId(dgvProduct, listObjProductdDetails[0].Rows[0]["productId"].ToString(), e.RowIndex);
                            ListObj = bllSalesQuotation.SalesQuotationMasterBatchFill(dgvProduct, Convert.ToDecimal(listObjProductdDetails[0].Rows[0]["productId"].ToString()), e.RowIndex);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(listObjProductdDetails[0].Rows[0]["batchId"].ToString());
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(listObjProductdDetails[0].Rows[0]["unitId"].ToString());


                            IsDoAfterFill = true;
                            UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                            List<DataTable> listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                            if (listUnitByProduct[0].Rows.Count > 0)
                            {
                                foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                {
                                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                        if (IsDoAfterFill)
                                        {
                                            decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
                                        }
                                    }
                                }
                            }
                            decimal decStandardRate = BllProductCreation.SalesInvoiceProductRateForSales(Convert.ToDecimal(listObjProductdDetails[0].Rows[0]["productId"].ToString()), PublicVariables._dtCurrentDate, decBatchId, Convert.ToDecimal(cmbPricinglevel.SelectedValue), PublicVariables._inNoOfDecimalPlaces);
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                            {
                                if (decStandardRate != 0 && Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value) != 0)
                                {
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                                }
                            }

                        }
                        else
                        {
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value = string.Empty;
                        }
                        AmountCalculation("dgvtxtQty", e.RowIndex);
                        TotalAmountCalculation();
                    }
                    else
                    {
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                    }
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtProductCode")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString().Trim() != string.Empty)
                    {
                        ProductInfo infoProduct = new ProductInfo();
                        string strProductCode = dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                        infoProduct = BllProductCreation.ProductViewByCode(strProductCode);
                        if (infoProduct.ProductId != 0)
                        {
                            TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
                            SalesQuotationBll bllSalesQuotation = new SalesQuotationBll();
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = infoProduct.ProductName;
                            dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value = infoProduct.ProductId;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(infoProduct.SalesRate, PublicVariables._inNoOfDecimalPlaces);
                            DefaultRate = Math.Round(infoProduct.PurchaseRate, PublicVariables._inNoOfDecimalPlaces);
                            List<DataTable> LiostObj = new List<DataTable>();
                            ListObjUnitViewAll = transactionGeneralFillObj.UnitViewAllByProductId(dgvProduct, infoProduct.ProductId.ToString(), e.RowIndex);
                            LiostObj = bllSalesQuotation.SalesQuotationMasterBatchFill(dgvProduct, infoProduct.ProductId, e.RowIndex);

                            BatchBll BllBatch = new BatchBll();
                            decimal decBatchId = BllBatch.BatchIdViewByProductId(infoProduct.ProductId);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = decBatchId;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = infoProduct.UnitId;

                            if (infoProduct.PartNo != string.Empty)
                            {
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = infoProduct.PartNo;
                            }
                            else
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                                {
                                    decBatchId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value);
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = BllProductCreation.BarcodeViewByBatchId(decBatchId);
                                }
                            }
                            IsDoAfterFill = true;
                            UnitConvertionBll bllUnitByProduct = new UnitConvertionBll();

                            List<DataTable> listUnitByProduct = bllUnitByProduct.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                            if (listUnitByProduct[0].Rows.Count > 0)
                            {
                                foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                {
                                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                        if (IsDoAfterFill)
                                        {
                                            decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, PublicVariables._inNoOfDecimalPlaces);
                                        }
                                    }
                                }
                            }
                            decimal decStandardRate = BllProductCreation.SalesInvoiceProductRateForSales(infoProduct.ProductId, PublicVariables._dtCurrentDate, decBatchId, Convert.ToDecimal(cmbPricinglevel.SelectedValue), PublicVariables._inNoOfDecimalPlaces);
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                            {
                                if (decStandardRate != 0 && Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value) != 0)
                                {
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                                }
                            }
                        }
                        else
                        {
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = string.Empty;
                            dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value = string.Empty;
                        }
                        AmountCalculation("dgvtxtQty", e.RowIndex);
                        TotalAmountCalculation();
                    }
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtRate")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                    {
                        DefaultRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value);
                    }
                }
                CheckInvalidEntriesInDataGridProduct(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        TextBoxControl.AutoCompleteCustomSource = ProductName;
                    }
                    else if (dgvProduct.CurrentCell != null && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCode;
                    }
                    if (dgvProduct.CurrentCell != null && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name != "dgvtxtProductName" && dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name != "dgvtxtProductCode")
                    {
                        DataGridViewTextBoxEditingControl editcontrol = (DataGridViewTextBoxEditingControl)dgvProduct.EditingControl;
                        editcontrol.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;
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
                MessageBox.Show("SQ:57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Data error event
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
                MessageBox.Show("SQ:58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On remove linkbutton click
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
                                if (dgvProduct.CurrentRow.Cells["dgvtxtQuotationDetailsId"].Value != null && dgvProduct.CurrentRow.Cells["dgvtxtQuotationDetailsId"].Value.ToString() != string.Empty)
                                {
                                    lstArrOfRemove.Add(dgvProduct.CurrentRow.Cells["dgvtxtQuotationDetailsId"].Value.ToString());
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
                MessageBox.Show("SQ:59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtSalesQuotationDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalesQuotationDate_Leave(object sender, EventArgs e)
        {
            try
            {
                dateValidationObj.DateValidationFunction(txtSalesQuotationDate);
                if (txtSalesQuotationDate.Text == string.Empty)
                {
                    txtSalesQuotationDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtSalesQuotationDate.Text;
                dtpSalesQuotationDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When clicking on the cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= -1 && e.RowIndex > -1)
                {
                    if (e.ColumnIndex == dgvProduct.Columns["dgvcmbBatch"].Index)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString() == string.Empty)
                        {
                            DataGridViewComboBoxCell dgvcmbBatch = (DataGridViewComboBoxCell)dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            dgvcmbBatch.DataSource = null;
                        }
                    }
                    if (e.ColumnIndex == dgvProduct.Columns["dgvcmbUnit"].Index)
                    {
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value == null || dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString() == string.Empty)
                        {
                            DataGridViewComboBoxCell dgvcmbUnit = (DataGridViewComboBoxCell)dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            dgvcmbUnit.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesQuotation_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmSalesQuotationRegisterObj != null)
                {
                    frmSalesQuotationRegisterObj.Enabled = true;
                    frmSalesQuotationRegisterObj.GridFill();
                }
                else if (frmSalesQuotationReportObj != null)
                {
                    frmSalesQuotationReportObj.Enabled = true;
                    frmSalesQuotationReportObj.GridFill();
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                }
                if (objfrmVoucherSearch != null)
                {
                    objfrmVoucherSearch.Enabled = true;
                    objfrmVoucherSearch.FillGrid();
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
                MessageBox.Show("SQ:62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On cellenter of dgvProduct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IsCellValue = true;
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
                            decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value);
                            decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selectedindexchange of cmbPricingLevel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPricinglevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                foreach (DataGridViewRow dgvrw in dgvProduct.Rows)
                {
                    if (dgvrw.Cells["ProductId"].Value != null)
                    {
                        DateTime dtcurrentDate = PublicVariables._dtCurrentDate;
                        decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                        decimal decProductId1 = Convert.ToDecimal(dgvrw.Cells["ProductId"].Value.ToString());
                        if (dgvrw.Cells["dgvcmbBatch"].Value != null)
                        {
                            decimal decStandardRate = BllProductCreation.SalesInvoiceProductRateForSales(decProductId1, dtcurrentDate, Convert.ToDecimal(dgvrw.Cells["dgvcmbBatch"].Value), Convert.ToDecimal(cmbPricinglevel.SelectedValue), decNodecplaces);
                            dgvrw.Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvrw.Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvProduct_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtQty")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuotationDetailsId"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuotationDetailsId"].Value.ToString() != string.Empty && Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuotationDetailsId"].Value.ToString()) != 0)
                    {
                        if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                        {
                            SalesQuotationBll spSalesQuation = new SalesQuotationBll();
                            decimal decReferencedQty = Math.Round(spSalesQuation.SalesQuatationReferenceCheck(Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuotationDetailsId"].Value.ToString())), PublicVariables._inNoOfDecimalPlaces);
                            decimal decQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value.ToString());
                            if (decQty < decReferencedQty)
                            {
                                Messages.InformationMessage("Quantity in row " + (e.RowIndex + 1) + " should be greater than " + decReferencedQty);
                                IsCellValue = false;
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQty"].Value = Math.Round(decReferencedQty,PublicVariables._inNoOfDecimalPlaces);
                                IsCellValue = true;
                            }
                        }
                    }
                    AmountCalculation("dgvtxtQty", e.RowIndex);
                    TotalAmountCalculation();
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                    {
                        UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                       List< DataTable >listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                       if (listUnitByProduct[0].Rows.Count > 0)
                        {
                            foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                            {
                                if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                {
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                    if (IsDoAfterFill)
                                    {
                                        decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                        decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces));
                                    }
                                }
                            }
                            AmountCalculation("dgvtxtQty", e.RowIndex);
                            TotalAmountCalculation();
                        }
                    }
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbBatch")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                    {
                        string strProductCode = string.Empty;
                        ProductInfo infoproduct = new ProductInfo();
                        ProductCreationBll BllProductCreation = new ProductCreationBll();
                        decimal decBatchId = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value);
                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = BllProductCreation.BarcodeViewByBatchId(decBatchId);
                        strProductCode = dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                        infoproduct = BllProductCreation.ProductViewByCode(strProductCode);
                        DateTime dtcurrentDate = PublicVariables._dtCurrentDate;
                        decimal decNodecplaces = PublicVariables._inNoOfDecimalPlaces;
                        decimal decStandardRate = BllProductCreation.SalesInvoiceProductRateForSales(infoproduct.ProductId, dtcurrentDate, decBatchId, Convert.ToDecimal(cmbPricinglevel.SelectedValue), decNodecplaces);
                        if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                        {
                            if (decStandardRate != 0 && Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value) != 0)
                            {
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decStandardRate / Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                            }
                            AmountCalculation("dgvtxtQty", e.RowIndex);
                            TotalAmountCalculation();
                        }
                    }
                }
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtExchangeRate" && isAmountcalc)
                {
                    AmountCalculation("dgvtxtExchangeRate", e.RowIndex);
                    TotalAmountCalculation();
                }
                //---------------while changing Rate,corresponding change in amount----
                else if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtRate" && isAmountcalc)
                {
                    AmountCalculation("dgvtxtRate", e.RowIndex);
                    TotalAmountCalculation();
                }
                //----while changing amount ,corresponding chnage in total amount-------
                
                CheckInvalidEntriesInDataGridProduct(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:76" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Enter key and backspace navigation of cmbCuurency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
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
                    if (cmbCurrency.Text == string.Empty || cmbCurrency.SelectionLength == 0)
                    {
                        cmbSalesman.Focus();
                        cmbSalesman.SelectionLength = 0;
                        cmbSalesman.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation of txtNarration
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
                        if (cbxApproved.Enabled)
                        {
                            cbxApproved.Focus();
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
                        dgvProduct.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:66" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvProduct
        /// For shortcut keys
        /// ctrl+f for productsearchpopup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProduct.CurrentCell == dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtAmount"])
                    {
                        txtNarration.Focus();
                        dgvProduct.ClearSelection();
                        e.Handled = true;
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvProduct.CurrentCell == dgvProduct.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        if (cmbCurrency.Enabled)
                        {
                            cmbCurrency.Focus();
                            dgvProduct.ClearSelection();
                        }
                        else
                        {
                            cmbSalesman.Focus();
                            cmbSalesman.SelectionLength = 0;
                            cmbSalesman.SelectionStart = 0;
                        }
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        if (dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value != null || dgvProduct.CurrentRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            frmProductSearchPopupObj.CallFromSalesQuotation(this, dgvProduct.CurrentRow.Index, dgvProduct.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString());
                        }
                        else
                        {
                            frmProductSearchPopupObj.CallFromSalesQuotation(this, dgvProduct.CurrentRow.Index, string.Empty);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For shortcut keys
        /// Esc for form close
        /// ctrl+s for save
        /// ctrl+d for delete
        /// alt+c for product creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalesQuotation_KeyDown(object sender, KeyEventArgs e)
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
                    
                    btnSave_Click(sender, e);
                }
                //.........................................CTRL+D............................//
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)//Delete 
                {
                    
                    if (btnDelete.Enabled == true)
                    {
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
                                frmProductCreationObj.CallFromSalesQuotation(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:68" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of txtQuatationNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQuotationNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSalesQuotationDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:69" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbCashOrParty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbPricinglevel.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Text == string.Empty || cmbCashOrParty.SelectionStart == 0)
                    {
                        txtSalesQuotationDate.Focus();
                        txtSalesQuotationDate.SelectionStart = 0;
                        txtSalesQuotationDate.SelectionLength = 0;
                    }
                }
                /*----new salesman creation -------------------*/
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnNewLedger_Click(sender, e);
                }
                /*----------Showing ledger pop up window---------------*/
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (cmbCashOrParty.Focus())
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
                            frmLedgerPopupObj.CallFromSalesQuotation(this, Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString()), "CashOrSundryDeptors");
                        }
                        else
                        {
                            Messages.InformationMessage("select any ledger");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:70" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbSalesMan
        /// ctrl+f for employee popup
        /// Alt+c for employee creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesman_KeyDown(object sender, KeyEventArgs e)
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
                        dgvProduct.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbSalesman.Text == string.Empty || cmbSalesman.SelectionStart == 0)
                    {
                        cmbPricinglevel.Focus();
                    }
                }
                /*-------------------------------------------------  pop up when Ctrl+F----------------------------------------------------------------------------------------*/
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbSalesman.SelectedIndex > -1)
                    {
                        frmEmployeePopupObj.CallFromSalesQuotation(this, Convert.ToDecimal(cmbSalesman.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select salesman");
                        cmbSalesman.Focus();
                    }
                }
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnAddSalesman_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:71" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtSalesQaotationDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalesQuotationDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrParty.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtSalesQuotationDate.Text == string.Empty || txtSalesQuotationDate.SelectionStart == 0)
                    {
                        if (txtQuotationNo.ReadOnly == false)
                        {
                            txtQuotationNo.Focus();
                            txtQuotationNo.SelectionLength = 0;
                            txtQuotationNo.SelectionStart = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:72" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbPricingLevel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPricinglevel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSalesman.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbPricinglevel.Text == string.Empty || cmbPricinglevel.SelectionStart == 0)
                    {
                        cmbCashOrParty.Focus();
                        cmbCashOrParty.SelectionLength = 0;
                        cmbCashOrParty.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:73" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cbxApproved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxApproved_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SQ:74" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (cbxApproved.Enabled)
                    {
                        cbxApproved.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQ:75" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SQ:76" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        
       
    }
}
