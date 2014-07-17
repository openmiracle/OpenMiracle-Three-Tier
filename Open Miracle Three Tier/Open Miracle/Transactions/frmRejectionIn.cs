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
using System.Diagnostics;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmRejectionIn : Form
    {
        #region PublicVariables and Instance
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        bool isOrderFill = false;
        bool isDoCellValueChange = false;
        bool isAutomatic = false;
        bool isFromRejectionInRegister = false;
        bool isDoAfterGridFill = false;
        bool isDontExecuteCashorParty = false;
        decimal decRejectionInVoucherTypeId = 0;
        decimal decRejectionInSuffixPrefixId = 0;
        decimal decRejectionInIdToEdit = 0;
        decimal decCurrentConversionRate = 0;
        decimal decCurrentRate = 0;
        frmRejectionInRegister frmRejectionInRegisterObj = null;
        frmRejectionInReport frmRejectionInReportObj = null;
        frmDayBook frmDayBookObj = null;
        frmVoucherSearch objVoucherSearch = null;
        frmVoucherWiseProductSearch objVoucherProduct = null;
        frmLedgerPopup frmLedgerPopupObj = null;
        string strVoucherNo = string.Empty;
        string strSalesman = string.Empty;
        string strCashorParty = string.Empty;
        frmVoucherSearch frmVoucherSearchObj = null;
        string strRejectionInVoucherNo = string.Empty;
        TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
        RejectionInBll bllRejectionInBll = new RejectionInBll();


        /// <summary>
        /// Create am instance for frmRejectionIn class
        /// </summary>
        public frmRejectionIn()
        {
            InitializeComponent();
        }
        #endregion

        #region Function

        /// <summary>
        /// function to add new ledger
        /// </summary>
        public void OpenCashorPartyPopup()
        {
            try
            {
                if (cmbCashorParty.SelectedValue != null)
                {
                    strCashorParty = cmbCashorParty.SelectedValue.ToString();

                }
                else
                {
                    strCashorParty = string.Empty;
                }

                frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
                frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                frmAccountLedger openAccountLedger = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (openAccountLedger == null)
                {
                    frmAccountLedgerObj.WindowState = FormWindowState.Normal;
                    frmAccountLedgerObj.MdiParent = formMDI.MDIObj;
                    frmAccountLedgerObj.CallFromRejectionIn(this);
                }
                else
                {
                    openAccountLedger.MdiParent = formMDI.MDIObj;
                    openAccountLedger.BringToFront();
                    openAccountLedger.CallFromRejectionIn(this);
                    if (openAccountLedger.WindowState == FormWindowState.Minimized)
                    {
                        openAccountLedger.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("RI:01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// function to add new SalesMan
        /// </summary>
        public void OpenSalesManPopup()
        {
            try
            {
                if (cmbSalesMan.SelectedValue != null)
                {
                    strSalesman = cmbSalesMan.SelectedValue.ToString();
                }
                else
                {
                    strSalesman = string.Empty;
                }
                frmSalesman frmSalesmanObj = new frmSalesman();
                frmSalesmanObj.MdiParent = formMDI.MDIObj;
                frmSalesman openSalesMan = Application.OpenForms["frmSalesman"] as frmSalesman;
                if (openSalesMan == null)
                {
                    frmSalesmanObj.WindowState = FormWindowState.Normal;
                    frmSalesmanObj.MdiParent = formMDI.MDIObj;
                    frmSalesmanObj.CallFromRejectionIn(this);
                }
                else
                {
                    openSalesMan.MdiParent = formMDI.MDIObj;
                    openSalesMan.BringToFront();
                    openSalesMan.CallFromRejectionIn(this);
                    if (openSalesMan.WindowState == FormWindowState.Minimized)
                    {
                        openSalesMan.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("RI:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate Voucher number as per settings
        /// </summary>
        public void VoucherNoGeneration()
        {
            string strRejectionIn = "RejectionInMaster";
            string strSuffix = string.Empty;
            string strPrefix = string.Empty;
            string strInvoiceNo = string.Empty;
            try
            {
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = transactionGeneralFillObj.VoucherNumberAutomaicGeneration(decRejectionInVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strRejectionIn);
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    // SuffixPrefixSP spSuffixPrefix = new SuffixPrefixSP();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decRejectionInVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                    txtRejectionInNo.Text = strInvoiceNo;
                    txtRejectionInNo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Checking the grid columns based on the settings
        /// </summary>
        public void SettingStatusCheck()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    dgvProduct.Columns["dgvtxtProductCode"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvtxtProductCode"].Visible = false;
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
                if (BllSettings.SettingsStatusCheck("ShowSalesRate") == "Yes")
                {
                    dgvProduct.Columns["dgvtxtRate"].Visible = true;
                }
                else
                {
                    dgvProduct.Columns["dgvtxtRate"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("TickPrintAfterSave") == "Yes")
                {
                    cbxPrintAfterSave.Checked = true;
                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
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
                MessageBox.Show("RI:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Cash or Party Combobox Fill
        /// </summary>
        public void CashorPartyComboFill()
        {
            try
            {
                transactionGeneralFillObj.CashOrPartyUnderSundryDrComboFill(cmbCashorParty, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use VoucherType ComboFill
        /// </summary>
        public void VoucherTypeComboFill()
        {
            try
            {
                transactionGeneralFillObj.VoucherTypeComboFill(cmbVoucherType, "Delivery Note", false);
                cmbVoucherType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the deliverynote no combofill
        /// </summary>
        /// <param name="decledgerid"></param>
        /// <param name="decVoucherTypeId"></param>
        public void DeliveryNoteNoCombofill()
        {
            try
            {
                isOrderFill = true;
                List<DataTable> listObj = new List<DataTable>();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                decimal decledgerid = Convert.ToDecimal(cmbCashorParty.SelectedValue.ToString());
                decimal decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                listObj = bllDeliveryNote.DeliveryNoteNoCorrespondingToLedger(decledgerid, decRejectionInIdToEdit, decVoucherTypeId);
                cmbDeliveryNoteNo.DataSource = listObj[0];
                cmbDeliveryNoteNo.DisplayMember = "invoiceNo";
                cmbDeliveryNoteNo.ValueMember = "deliveryNoteMasterId";
                cmbDeliveryNoteNo.SelectedIndex = -1;
                isOrderFill = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to use pricing level combofill
        /// </summary>
        public void pricinglevelcombofill()
        {
            try
            {
                transactionGeneralFillObj.PricingLevelViewAll(cmbPricingLevel, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use salesman combofill
        /// </summary>
        public void salesmancombofill()
        {
            try
            {
                transactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        ///  Function to use the Currency Combo Fill
        /// </summary>
        /// <param name="dtSelectedDate"></param>
        public void CurrencyComboFill(DateTime dtSelectedDate)
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                listObj = bllRejectionInBll.CurrencyComboByDate(cmbCurrency, dtSelectedDate, false);
                cmbCurrency.DataSource = listObj[0];
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
                MessageBox.Show("RI:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to generate the serial no automatically in grid
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to use the Fill the Grid Corresponding To DeliveryNote No
        /// </summary>
        public void FillGridCorrespondingToDeliveryNoteNo()
        {
            try
            {
                dgvProduct.Rows.Clear();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                List<DataTable> listObjdeliverynotedetails = bllDeliveryNote.DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending(Convert.ToDecimal(cmbDeliveryNoteNo.SelectedValue), decRejectionInIdToEdit);
                foreach (DataRow drdeliverynotedetails in listObjdeliverynotedetails[0].Rows)
                {
                    isDoCellValueChange = false;
                    isDoAfterGridFill = false;
                    DGVGodownComboFill();
                    dgvProduct.Rows.Add();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtBarcode"].Value = drdeliverynotedetails["barcode"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtProductId"].Value = drdeliverynotedetails["productId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxDeliveryNoteDetailsId"].Value = drdeliverynotedetails.ItemArray[0].ToString();
                    AssignProductDefaultValues(dgvProduct.Rows.Count - 1, Convert.ToDecimal(drdeliverynotedetails.ItemArray[2].ToString()));
                    DGVBatchComboFill(dgvProduct.Rows.Count - 1, Convert.ToDecimal(drdeliverynotedetails.ItemArray[2].ToString()));
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtQuantity"].Value = drdeliverynotedetails["qty"].ToString();
                    isDoCellValueChange = true;
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drdeliverynotedetails["unitId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(drdeliverynotedetails["godownId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbRack"].Value = Convert.ToDecimal(drdeliverynotedetails["rackId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(drdeliverynotedetails["batchId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtRate"].Value = drdeliverynotedetails["rate"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtAmount"].Value = drdeliverynotedetails["amount"].ToString();
                    dgvProduct.CurrentCell = null;


                }
                SerialNo();
                CalcTotalAmt();
                isDoCellValueChange = true;
                isDoAfterGridFill = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI :12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to fill Account ledger combobox while return from Account ledger creation when creating new ledger 
        /// </summary>
        /// <param name="decAccountledgerid"></param>
        public void ReturnFromAccountLedger(decimal decAccountledgerid)
        {
            try
            {
                this.Enabled = true;
                CashorPartyComboFill();
                if (decAccountledgerid != 0)
                {
                    cmbCashorParty.SelectedValue = decAccountledgerid;

                }
                else if (strCashorParty != string.Empty)
                {
                    cmbCashorParty.SelectedValue = strCashorParty;
                }
                else
                {
                    cmbCashorParty.SelectedValue = -1;

                }

                cmbCashorParty.Focus();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill SalesMan combobox while return from SalesMan creation when creating new SalesMan 
        /// </summary>
        /// <param name="decEmployeeId"></param>
        public void ReturnFromSalesMan(decimal decEmployeeId)
        {
            try
            {
                this.Enabled = true;
                salesmancombofill();
                if (decEmployeeId != 0)
                {
                    cmbSalesMan.SelectedValue = decEmployeeId;

                }
                else if (strSalesman != string.Empty)
                {
                    cmbSalesMan.SelectedValue = strSalesman;
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
                MessageBox.Show("RI:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Function to use the setting the product default values
        /// </summary>
        /// <param name="index"></param>
        /// <param name="decProductId"></param>
        public void AssignProductDefaultValues(int index, decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                ProductInfo infoproduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                infoproduct = BllProductCreation.productViewByProductId(decProductId);
                dgvProduct.Rows[index].Cells["dgvtxtProductName"].Value = infoproduct.ProductName;
                dgvProduct.Rows[index].Cells["dgvtxtProductCode"].Value = infoproduct.ProductCode;
                listObj = transactionGeneralFillObj.UnitViewAllByProductId(dgvProduct, decProductId.ToString(), index);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to use the Godown ComboFill
        /// </summary>
        public void DGVGodownComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                GodownBll BllGodown = new GodownBll();
                listObj = BllGodown.GodownViewAll();
                dgvcmbGodown.DataSource = listObj[0];
                dgvcmbGodown.ValueMember = "godownId";
                dgvcmbGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Rack ComboFill based on the godown
        /// </summary>
        /// <param name="decGodownId"></param>
        /// <param name="dgvCurProduct"></param>
        /// <param name="inRowIndex"></param>
        public void DGVRackComboFill(decimal decGodownId, DataGridView dgvCurProduct, int inRowIndex)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RackBll BllRack = new RackBll();
                DataGridViewComboBoxCell dgvcmbCurRack = (DataGridViewComboBoxCell)dgvProduct[dgvProduct.Columns["dgvcmbRack"].Index, inRowIndex];
                listObj = BllRack.RackViewAllByGodownForCombo(decGodownId);
                dgvcmbCurRack.DataSource = listObj[0];
                dgvcmbCurRack.ValueMember = "rackId";
                dgvcmbCurRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Batch ComboFill
        /// </summary>
        /// <param name="inRowIndex"></param>
        /// <param name="decProductId"></param>
        public void DGVBatchComboFill(int inRowIndex, decimal decProductId)
        {
            try
            {
                BatchBll BllBatch = new BatchBll();
                BllBatch.BatchViewbyProductIdForComboFillInGrid(decProductId, dgvProduct, inRowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// FUnction to use calculate the total amount
        /// </summary>
        public void CalcTotalAmt()
        {
            string strCurrencySymbol = string.Empty;
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            CurrencyBll BllCurrency = new CurrencyBll();
            try
            {
                decimal decTotal = 0;
                if (dgvProduct.Rows.Count > 0)
                {
                    foreach (DataGridViewRow dgvrow in dgvProduct.Rows)
                    {
                        if (dgvrow.Cells["dgvtxtAmount"].Value != null && dgvrow.Cells["dgvtxtAmount"].Value.ToString() != "")
                        {
                            decTotal = decTotal + decimal.Parse(dgvrow.Cells["dgvtxtAmount"].Value.ToString());
                        }
                    }
                    txtTotalAmount.Text = decTotal.ToString();

                }
                else
                {
                    txtTotalAmount.Text = "0.00";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to use the Date Validation
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="dtp"></param>
        public void DateValidation(TextBox txt, DateTimePicker dtp)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txt);
                if (txt.Text == String.Empty)
                {
                    txt.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtp.Value = DateTime.Parse(txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the invalid entries for saving
        /// </summary>
        /// <returns></returns>
        public bool CheckErrorForSaving()
        {
            SettingsBll BllSettings = new SettingsBll();
            bool isOk = true;
            try
            {
                if (!isAutomatic)
                {
                    if (txtRejectionInNo.Text == String.Empty)
                    {
                        isOk = false;
                        MessageBox.Show("Enter Rejection In Number", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRejectionInNo.Focus();
                    }
                }

                if (txtRejectionInNo.Text != String.Empty)
                {
                    if (txtDate.Text == string.Empty)
                    {
                        isOk = false;
                        MessageBox.Show("Select a date in between financial year", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDate.Focus();
                    }
                    else if (cmbCashorParty.SelectedValue == null)
                    {
                        isOk = false;
                        MessageBox.Show("Select cash/party", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbCashorParty.Focus();

                    }
                    else if (cmbVoucherType.SelectedValue == null)
                    {
                        isOk = false;
                        MessageBox.Show("Select voucher type", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbVoucherType.Focus();

                    }
                    else if (cmbDeliveryNoteNo.SelectedValue == null)
                    {
                        isOk = false;
                        MessageBox.Show("Select delivery note number", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbDeliveryNoteNo.Focus();
                    }
                    else if (dgvProduct.Rows[0].Cells["dgvtxtRate"].Value.ToString() == "0")
                    {
                        if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") != "Yes")
                        {
                            isOk = false;
                            dgvProduct.CurrentRow.HeaderCell.Value = "X";
                            dgvProduct.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                    }

                    else if (dgvProduct.RowCount < 1)
                    {
                        isOk = false;
                        if (decRejectionInIdToEdit == 0)
                        {
                            MessageBox.Show("Can't save rejection in without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Can't update rejection in without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                isOk = false;
                MessageBox.Show("RI:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// function to clear the form controls
        /// </summary>
        public void ClearRejectionIn()
        {
            try
            {
                dgvProduct.Rows.Clear();
                txtNarration.Clear();
                txtTransportationCompany.Text = string.Empty;
                txtLRNo.Text = string.Empty;
                txtTotalAmount.Text = "0.00";
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                lblDeliverNoteNo.Visible = false;
                cmbDeliveryNoteNo.Visible = false;
                cmbVoucherType.SelectedIndex = -1;
                cmbSalesMan.SelectedIndex = 0;
                cmbCashorParty.SelectedIndex = 0;
                txtDate.Focus();
                txtDate.SelectionStart = txtDate.Text.Length;
                decRejectionInIdToEdit = 0;
                if (!isAutomatic)
                {
                    txtRejectionInNo.Clear();
                    txtRejectionInNo.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save or edit function
        /// </summary>
        public void SaveOrEdit()
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                decimal decIdentity = 0;
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                DeliveryNoteMasterInfo InfoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
                InfoDeliveryNoteMaster = bllDeliveryNote.DeliveryNoteMasterView(Convert.ToDecimal(cmbDeliveryNoteNo.SelectedValue));
                RejectionInMasterInfo InfoRejectionInMaster = new RejectionInMasterInfo();
                RejectionInDetailsInfo InfoRejectionInDetails = new RejectionInDetailsInfo();
                RejectionInBll bllRejectionIn = new RejectionInBll();
                StockPostingInfo InfoStockPosting = new StockPostingInfo();
                StockPostingBll BllStockPosting = new StockPostingBll();
                if (isAutomatic)
                {
                    InfoRejectionInMaster.VoucherNo = strVoucherNo;
                    InfoRejectionInMaster.InvoiceNo = txtRejectionInNo.Text;
                }
                else
                {
                    InfoRejectionInMaster.VoucherNo = txtRejectionInNo.Text;
                    InfoRejectionInMaster.InvoiceNo = txtRejectionInNo.Text;
                }
                InfoRejectionInMaster.VoucherTypeId = decRejectionInVoucherTypeId;
                InfoRejectionInMaster.SuffixPrefixId = decRejectionInSuffixPrefixId;
                InfoRejectionInMaster.Date = DateTime.Parse(txtDate.Text);
                InfoRejectionInMaster.LedgerId = Convert.ToDecimal(cmbCashorParty.SelectedValue.ToString());
                InfoRejectionInMaster.PricinglevelId = cmbPricingLevel.SelectedValue == null ? 0 : Convert.ToDecimal(cmbPricingLevel.SelectedValue.ToString());
                InfoRejectionInMaster.EmployeeId = cmbSalesMan.SelectedValue == null ? 1 : Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                InfoRejectionInMaster.Narration = txtNarration.Text.Trim();
                InfoRejectionInMaster.ExchangeRateId = cmbCurrency.SelectedValue == null ? 0 : Convert.ToDecimal(cmbCurrency.SelectedValue.ToString());
                InfoRejectionInMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                InfoRejectionInMaster.UserId = PublicVariables._decCurrentUserId;
                InfoRejectionInMaster.LrNo = txtLRNo.Text.Trim();
                InfoRejectionInMaster.TransportationCompany = txtTransportationCompany.Text.Trim();
                InfoRejectionInMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoRejectionInMaster.Extra1 = string.Empty;
                InfoRejectionInMaster.Extra2 = string.Empty;
                InfoRejectionInMaster.DeliveryNoteMasterId = Convert.ToDecimal(cmbDeliveryNoteNo.SelectedValue == null ? "" : cmbDeliveryNoteNo.SelectedValue.ToString());

                if (decRejectionInIdToEdit == 0)
                {
                    decIdentity = bllRejectionIn.RejectionInMasterAdd(InfoRejectionInMaster);
                }
                else
                {
                    InfoRejectionInMaster.RejectionInMasterId = decRejectionInIdToEdit;
                    bllRejectionIn.RejectionInMasterEdit(InfoRejectionInMaster);
                }
                if (decRejectionInIdToEdit == 0)
                {
                    InfoRejectionInDetails.RejectionInMasterId = decIdentity;
                }
                else
                {
                    bllRejectionIn.DeleteRejectionInDetailsByRejectionInMasterId(decRejectionInIdToEdit);
                    BllStockPosting.DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo(decRejectionInVoucherTypeId, strVoucherNo);
                    InfoRejectionInDetails.RejectionInMasterId = decRejectionInIdToEdit;
                }
                foreach (DataGridViewRow dgvrow in dgvProduct.Rows)
                {
                    InfoRejectionInDetails.DeliveryNoteDetailsId = Convert.ToDecimal(dgvrow.Cells["dgvtxDeliveryNoteDetailsId"].Value.ToString());
                    InfoRejectionInDetails.ProductId = Convert.ToDecimal(dgvrow.Cells["dgvtxtProductId"].Value.ToString());
                    InfoRejectionInDetails.Qty = Convert.ToDecimal(dgvrow.Cells["dgvtxtQuantity"].Value.ToString());
                    InfoRejectionInDetails.Rate = Convert.ToDecimal(dgvrow.Cells["dgvtxtRate"].Value.ToString());
                    InfoRejectionInDetails.UnitId = Convert.ToDecimal(dgvrow.Cells["dgvcmbUnit"].Value.ToString());
                    InfoRejectionInDetails.UnitConversionId = Convert.ToDecimal(dgvrow.Cells["dgvtxtUnitConversionId"].Value.ToString());//0;//check
                    InfoRejectionInDetails.BatchId = Convert.ToDecimal(dgvrow.Cells["dgvcmbBatch"].Value.ToString());
                    InfoRejectionInDetails.GodownId = Convert.ToDecimal(dgvrow.Cells["dgvcmbGodown"].Value.ToString());
                    InfoRejectionInDetails.RackId = Convert.ToDecimal(dgvrow.Cells["dgvcmbRack"].Value.ToString());
                    InfoRejectionInDetails.Amount = Convert.ToDecimal(dgvrow.Cells["dgvtxtAmount"].Value.ToString());
                    InfoRejectionInDetails.SlNo = Convert.ToInt32(dgvrow.Cells["dgvtxtSlNo"].Value.ToString());
                    InfoRejectionInDetails.Extra1 = string.Empty;
                    InfoRejectionInDetails.Extra2 = string.Empty;
                    bllRejectionInBll.RejectionInDetailsAdd(InfoRejectionInDetails);
                    InfoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                    InfoStockPosting.VoucherTypeId = InfoDeliveryNoteMaster.VoucherTypeId;
                    InfoStockPosting.VoucherNo = InfoDeliveryNoteMaster.VoucherNo;
                    InfoStockPosting.InvoiceNo = InfoDeliveryNoteMaster.InvoiceNo;
                    InfoStockPosting.ProductId = Convert.ToDecimal(dgvrow.Cells["dgvtxtProductId"].Value.ToString());
                    InfoStockPosting.BatchId = Convert.ToDecimal(dgvrow.Cells["dgvcmbBatch"].Value.ToString());
                    InfoStockPosting.UnitId = Convert.ToDecimal(dgvrow.Cells["dgvcmbUnit"].Value.ToString());
                    InfoStockPosting.GodownId = Convert.ToDecimal(dgvrow.Cells["dgvcmbGodown"].Value.ToString());
                    InfoStockPosting.RackId = Convert.ToDecimal(dgvrow.Cells["dgvcmbRack"].Value.ToString());
                    InfoStockPosting.AgainstVoucherTypeId = decRejectionInVoucherTypeId;
                    if (isAutomatic)
                    {
                        InfoStockPosting.AgainstInvoiceNo = txtRejectionInNo.Text;
                        InfoStockPosting.AgainstVoucherNo = strVoucherNo;
                    }
                    else
                    {
                        InfoStockPosting.AgainstInvoiceNo = txtRejectionInNo.Text;
                        InfoStockPosting.AgainstVoucherNo = txtRejectionInNo.Text;
                    }
                    InfoStockPosting.InwardQty = Convert.ToDecimal(dgvrow.Cells["dgvtxtQuantity"].Value.ToString());
                    InfoStockPosting.OutwardQty = 0;
                    InfoStockPosting.Rate = Convert.ToDecimal(dgvrow.Cells["dgvtxtRate"].Value.ToString());
                    InfoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                    InfoStockPosting.Extra1 = string.Empty;
                    InfoStockPosting.Extra2 = string.Empty;
                    BllStockPosting.StockPostingAdd(InfoStockPosting);

                }
                if (decRejectionInIdToEdit == 0)
                {
                    Messages.SavedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decIdentity);
                        }
                        else
                        {
                            Print(decIdentity);
                        }
                    }

                }
                else
                {
                    Messages.UpdatedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decRejectionInIdToEdit);
                        }
                        else
                        {
                            Print(decRejectionInIdToEdit);
                        }
                    }
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the details
        /// </summary>
        /// <param name="decRejectionInMasterId"></param>
        public void Print(decimal decRejectionInMasterId)
        {
            try
            {
                DataSet dsRejectionIn = bllRejectionInBll.RejectionInPrinting(decRejectionInMasterId, 1);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.RejectionInPrinting(dsRejectionIn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the details in Dotmatrix
        /// </summary>
        /// <param name="decRejectionInMasterId"></param>
        
        public void PrintForDotMatrix(decimal decRejectionInMasterId)
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
                        if (dRow.Cells["dgvtxtQuantity"].Value != null)
                        {
                            dr["Qty"] = dRow.Cells["dgvtxtQuantity"].Value.ToString();
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

                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("ledgerName");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("Currency");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("PricingLevel");
                dtblOtherDetails.Columns.Add("Type");
                dtblOtherDetails.Columns.Add("SalesMan");
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
                dRowOther["voucherNo"] = txtRejectionInNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["ledgerName"] = cmbCashorParty.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["Currency"] = cmbCurrency.Text;
                dRowOther["TotalAmount"] = txtTotalAmount.Text;
                dRowOther["PricingLevel"] = cmbPricingLevel.Text;
                dRowOther["Type"] = cmbVoucherType.Text;
                dRowOther["SalesMan"] = cmbSalesMan.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                AccountLedgerInfo infoAccountLedger = new AccountLedgerInfo();
                infoAccountLedger = bllAccountLedger.AccountLedgerView(Convert.ToDecimal(cmbCashorParty.SelectedValue));
                dRowOther["CustomerAddress"] = (infoAccountLedger.Address.ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["CustomerTIN"] = infoAccountLedger.Tin;
                dRowOther["CustomerCST"] = infoAccountLedger.Cst;
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtTotalAmount.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decRejectionInVoucherTypeId);
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
                MessageBox.Show("RI:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Delete function
        /// </summary>
        public void Delete()
        {
            try
            {
                bllRejectionInBll.RejectionInMasterAndDetailsDelete(decRejectionInIdToEdit);
                // StockPostingSP SpStockposting = new StockPostingSP();
                StockPostingBll BllStockPosting = new StockPostingBll();
                BllStockPosting.DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo(decRejectionInVoucherTypeId, strRejectionInVoucherNo);
                Messages.DeletedMessage();
                if (objVoucherSearch != null)
                {
                    this.Close();
                    objVoucherSearch.GridFill();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove a row from grid
        /// </summary>
        public void RemoveRow()
        {
            try
            {
                if (dgvProduct.CurrentCell != null)
                {
                    if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvProduct.Rows.RemoveAt(dgvProduct.CurrentRow.Index);
                    }
                }
                dgvProduct.CurrentCell = null;
                CalcTotalAmt();

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Remove incompleted rows from grid
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
                foreach (DataGridViewRow dgvRow in dgvProduct.Rows)
                {
                    try
                    {
                        if (Convert.ToDecimal(dgvRow.Cells["dgvtxtQuantity"].Value.ToString()) <= 0 || dgvRow.Cells["dgvtxtQuantity"].Value == null)
                        {
                            isOk = false;
                            if (inC == 0)
                            {
                                strMessage = strMessage + Convert.ToString(dgvRow.Index + 1);
                                inForFirst = dgvRow.Index;
                                inC++;
                            }
                            else
                            {
                                strMessage = strMessage + ", " + Convert.ToString(dgvRow.Index + 1);
                            }
                        }
                    }
                    catch
                    {
                        isOk = false;
                        if (inC == 0)
                        {
                            strMessage = strMessage + Convert.ToString(dgvRow.Index + 1);
                            inForFirst = dgvRow.Index;
                            inC++;
                        }
                        else
                        {
                            strMessage = strMessage + ", " + Convert.ToString(dgvRow.Index + 1);
                        }
                    }

                }
                if (!isOk)
                {
                    strMessage = strMessage + " contains invalid entries. Do you want to continue?";
                    if (MessageBox.Show(strMessage, "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvProduct.Rows.Count; inK++)
                        {
                            try
                            {
                                if (Convert.ToDecimal(dgvProduct.Rows[inK].Cells["dgvtxtQuantity"].Value.ToString()) <= 0 || dgvProduct.Rows[inK].Cells["dgvtxtQuantity"].Value == null)
                                {
                                    dgvProduct.Rows.RemoveAt(inK);
                                    inK--;
                                    CalcTotalAmt();
                                }
                            }
                            catch
                            {
                                dgvProduct.Rows.RemoveAt(inK);
                                inK--;
                                CalcTotalAmt();
                            }
                        }
                        if (dgvProduct.RowCount < 1)
                        {
                            isOk = false;
                            if (decRejectionInIdToEdit == 0)
                            {
                                MessageBox.Show("Can't save rejection in without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Can't update rejection in without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("RI:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
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
                decRejectionInIdToEdit = decId;
                RejectionInview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            string strSuffix = string.Empty;
            string strPrefix = string.Empty;
            try
            {
                decRejectionInVoucherTypeId = decVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decRejectionInVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo InfoSuffixPrefix = new SuffixPrefixInfo();
                InfoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decRejectionInVoucherTypeId, dtpDate.Value);
                decRejectionInSuffixPrefixId = InfoSuffixPrefix.SuffixprefixId;
                strSuffix = InfoSuffixPrefix.Suffix;
                strPrefix = InfoSuffixPrefix.Prefix;
                this.Text = strVoucherTypeName;
                base.Show();

                if (isAutomatic)
                {
                    ClearRejectionIn();
                    VoucherNoGeneration();
                    txtDate.Focus();
                    txtRejectionInNo.ReadOnly = true;
                }
                else
                {
                    txtRejectionInNo.Focus();
                    txtRejectionInNo.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmRejectionInRegister to view details and for updation 
        /// </summary>
        /// <param name="RIRgstrObj"></param>
        /// <param name="decRejectionInMasterId"></param>
        public void CallFromRejectionInRegister(frmRejectionInRegister RIRgstrObj, decimal decRejectionInMasterId, bool isFromRegister)
        {
            try
            {
                base.Show();
                decRejectionInIdToEdit = decRejectionInMasterId;
                this.frmRejectionInRegisterObj = RIRgstrObj;
                frmRejectionInRegisterObj.Enabled = false;
                RejectionInview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmRejectionInReport to view details and for updation 
        /// </summary>
        /// <param name="RIReportObj"></param>
        /// <param name="decRejectionInMasterId"></param>
        public void CallFromRejectionInReport(frmRejectionInReport RIReportObj, decimal decRejectionInMasterId)
        {
            try
            {
                decRejectionInIdToEdit = decRejectionInMasterId;
                frmRejectionInReportObj = RIReportObj;
                frmRejectionInReportObj.Enabled = false;
                base.Show();
                RejectionInview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDayBook to view details and for updation 
        /// </summary>
        /// <param name="frmDaybookObj"></param>
        /// <param name="decMasterId"></param>
        public void callFromDayBook(frmDayBook frmDaybookObj, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmDaybookObj.Enabled = false;
                this.frmDayBookObj = frmDaybookObj;
                decRejectionInIdToEdit = decMasterId;
                RejectionInview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                decRejectionInIdToEdit = decmasterId;
                RejectionInview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI :34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// function to Rejection In updation
        /// </summary>
        public void RejectionInview()
        {
            decimal decRejectioInMasterId = 0;
            try
            {
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                isFromRejectionInRegister = true;
                // RejectionInMasterSP SpRejectionInMaster = new RejectionInMasterSP();
                RejectionInBll bllRejectionIn = new RejectionInBll();
                RejectionInMasterInfo InfoRejectionInMaster = new RejectionInMasterInfo();
                InfoRejectionInMaster = bllRejectionIn.RejectionInMasterView(decRejectionInIdToEdit);
                //DeliveryNoteMasterSP SpDeliveryNoteMaster = new DeliveryNoteMasterSP();
                DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                DeliveryNoteMasterInfo InfoDeliveryNoteMaster = new DeliveryNoteMasterInfo();
                InfoDeliveryNoteMaster = bllDeliveryNote.DeliveryNoteMasterView(InfoRejectionInMaster.DeliveryNoteMasterId);
                strRejectionInVoucherNo = bllRejectionIn.GetRejectionInVoucherNo(InfoRejectionInMaster.RejectionInMasterId);
                decRejectionInVoucherTypeId = InfoRejectionInMaster.VoucherTypeId;
                decRejectionInSuffixPrefixId = InfoRejectionInMaster.SuffixPrefixId;
                strVoucherNo = InfoRejectionInMaster.VoucherNo;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decRejectionInVoucherTypeId);

                if (!isAutomatic)
                {
                    txtRejectionInNo.ReadOnly = false;
                    txtRejectionInNo.Focus();
                }
                else
                {
                    txtRejectionInNo.ReadOnly = true;
                    txtDate.Focus();
                }
                txtRejectionInNo.Text = InfoRejectionInMaster.InvoiceNo;
                txtDate.Text = InfoRejectionInMaster.Date.ToString("dd-MMM-yyyy");
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                cmbCashorParty.SelectedValue = InfoRejectionInMaster.LedgerId;
                cmbVoucherType.SelectedValue = InfoDeliveryNoteMaster.VoucherTypeId;
                cmbPricingLevel.SelectedValue = InfoRejectionInMaster.PricinglevelId;
                cmbDeliveryNoteNo.SelectedValue = InfoRejectionInMaster.DeliveryNoteMasterId;
                cmbSalesMan.SelectedValue = InfoRejectionInMaster.EmployeeId;
                cmbCurrency.SelectedValue = InfoRejectionInMaster.ExchangeRateId;
                txtTransportationCompany.Text = InfoRejectionInMaster.TransportationCompany;
                txtNarration.Text = InfoRejectionInMaster.Narration;
                txtLRNo.Text = InfoRejectionInMaster.LrNo;
                txtTotalAmount.Text = Convert.ToString(InfoRejectionInMaster.TotalAmount);
                RejectionInBll bllRejectionInBll = new RejectionInBll();
                List<DataTable> listRejectionInDetails = bllRejectionInBll.RejectionInDetailsViewByRejectionInMasterId(decRejectionInIdToEdit);
                decRejectioInMasterId = Convert.ToDecimal(listRejectionInDetails[0].Rows[0]["voucherTypeId"].ToString());
                VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                infoVoucherType = BllVoucherType.VoucherTypeView(decRejectioInMasterId);
                this.Text = infoVoucherType.VoucherTypeName;
                foreach (DataRow drRejectionInDetails in listRejectionInDetails[0].Rows)
                {
                    isDoCellValueChange = false;
                    DGVGodownComboFill();
                    dgvProduct.Rows.Add();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtProductId"].Value = drRejectionInDetails["productId"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxDeliveryNoteDetailsId"].Value = drRejectionInDetails.ItemArray[2].ToString();
                    AssignProductDefaultValues(dgvProduct.Rows.Count - 1, Convert.ToDecimal(drRejectionInDetails.ItemArray[3].ToString()));
                    DGVBatchComboFill(dgvProduct.Rows.Count - 1, Convert.ToDecimal(drRejectionInDetails.ItemArray[3].ToString()));
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtQuantity"].Value = drRejectionInDetails["qty"].ToString();
                    isDoCellValueChange = true;
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(drRejectionInDetails["unitId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drRejectionInDetails["unitconversionId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(drRejectionInDetails["godownId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbRack"].Value = Convert.ToDecimal(drRejectionInDetails["rackId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(drRejectionInDetails["batchId"].ToString());
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtRate"].Value = drRejectionInDetails["rate"].ToString();
                    dgvProduct.Rows[dgvProduct.Rows.Count - 1].Cells["dgvtxtAmount"].Value = drRejectionInDetails["amount"].ToString();
                    dgvProduct.CurrentCell = null;
                }
                SerialNo();
                CalcTotalAmt();
                isDoCellValueChange = true;
                isDoAfterGridFill = true;
                isFromRejectionInRegister = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRejectionIn_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpDate.Value = PublicVariables._dtCurrentDate;
                CashorPartyComboFill();
                salesmancombofill();
                CurrencyComboFill(PublicVariables._dtCurrentDate);
                pricinglevelcombofill();
                cmbDeliveryNoteNo.Visible = false;
                lblDeliverNoteNo.Visible = false;
                SettingStatusCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To assign date time picker value to textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                txtDate.Text = dtpDate.Value.ToString("dd-MMM-yyyy");
                txtDate.Focus();
                txtDate.SelectionStart = 0;
                txtDate.SelectionLength = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// event to check Date Validation  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation(txtDate, dtpDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI :38 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Event to add new cash or party frmAccountLedger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCashorPartyPopup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCashorParty.SelectedValue != null)
                {
                    strCashorParty = cmbCashorParty.SelectedValue.ToString();
                }
                else
                {
                    strCashorParty = string.Empty;
                }
                OpenCashorPartyPopup();

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To add a new sales man from frmSalesMan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalesManPopup_Click(object sender, EventArgs e)
        {
            try
            {
                OpenSalesManPopup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Doing the basic calculations in grid cell value change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (isDoCellValueChange)
                {
                    decimal decOldQty = 0;
                    decimal decCurQty = 0;
                    decimal decNewAmount = 0;
                    if (e.RowIndex != -1 && e.ColumnIndex != -1)
                    {
                        if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbGodown")
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value != null)
                            {

                                DGVRackComboFill(Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbGodown"].Value.ToString()), dgvProduct, e.RowIndex);
                            }
                        }
                        if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbBatch")
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value != null)
                            {
                                ProductCreationBll BllProductCreation = new ProductCreationBll();
                                decimal decRate = BllProductCreation.SalesInvoiceProductRateForSales(Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value), dtpDate.Value, Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value), Convert.ToDecimal(cmbPricingLevel.SelectedValue), PublicVariables._inNoOfDecimalPlaces);
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decRate / Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value), PublicVariables._inNoOfDecimalPlaces);
                                BatchBll BllBatch = new BatchBll();
                                dgvProduct.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value = BllBatch.ProductBatchBarcodeViewByBatchId(Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvcmbBatch"].Value));
                            }
                        }
                        //------------Hided when asked Rejection In not to need unit conversion process -------------------

                        //if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                        //{
                        //    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtproductId"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtproductId"].Value.ToString() != string.Empty)
                        //    {
                        //        if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString() != string.Empty)
                        //        {
                        //            if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString() != string.Empty)
                        //            {
                        //                decCurrentConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                        //                decCurrentRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                        //            }
                        //        }
                        //    }

                        //}

                        if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtQuantity")
                        {
                            DeliveryNoteDetailsInfo infodeliverynotedetails = new DeliveryNoteDetailsInfo();
                            //DeliveryNoteDetailsSP spdeliverynotedetails = new DeliveryNoteDetailsSP();
                            DeliveryNoteBll bllDeliveryNote = new DeliveryNoteBll();
                            List<DataTable> listObj = bllDeliveryNote.DeliveryNoteDetailsViewByDeliveryNoteMasterIdWithPending(Convert.ToDecimal(cmbDeliveryNoteNo.SelectedValue.ToString()), decRejectionInIdToEdit);
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuantity"].Value != null)
                            {
                                List<DataTable> listUnitByProduct = new List<DataTable>();
                                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                                listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                                foreach (DataRow drdtbl in listObj[0].Rows)
                                {
                                    foreach (DataRow drUnitviewall in listUnitByProduct[0].Rows)
                                    {

                                        if (drdtbl["unitConversionId"].ToString() == drUnitviewall["unitConversionId"].ToString())
                                        {
                                            decimal decCurrentQty = Convert.ToDecimal(drdtbl.ItemArray[3].ToString());
                                            decimal decConRateToDlryNteDtls = Convert.ToDecimal(drUnitviewall.ItemArray[3].ToString());
                                            decimal decCurConRateInGrid = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                            decOldQty = (decCurrentQty / decConRateToDlryNteDtls) * decCurConRateInGrid;
                                            decOldQty = Math.Round(decOldQty, PublicVariables._inNoOfDecimalPlaces);
                                            decCurQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuantity"].Value.ToString());

                                        }
                                    }
                                }
                                if (decCurQty > decOldQty)
                                {
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuantity"].Value = decOldQty;

                                }
                                else if (decCurQty <= decOldQty)
                                {
                                    decimal decrate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                                    dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = Math.Round(decrate * decCurQty, PublicVariables._inNoOfDecimalPlaces);
                                    CalcTotalAmt();
                                }
                            }
                        }

                        if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvcmbUnit")
                        {
                            if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value != null)
                            {
                                List<DataTable> listUnitByProduct = new List<DataTable>();
                                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                                listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                                foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                {
                                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvcmbUnit"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                    {
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtUnitConversionId"].Value = Convert.ToDecimal(drUnitByProduct[2].ToString());
                                        dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                        if (isDoAfterGridFill)
                                        {
                                            decimal decNewConversionRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtConversionRate"].Value.ToString());
                                            decCurQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuantity"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value = Math.Round(decNewRate);
                                            decNewAmount = (decCurrentRate * decCurQty * decCurrentConversionRate) / decNewConversionRate;
                                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = Math.Round(decNewAmount);
                                            txtTotalAmount.Text = Math.Round(decNewRate, 2).ToString();
                                            CalcTotalAmt();
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
                MessageBox.Show("RI:41 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Data error event to unhandle exceptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvProduct.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Event to clear  row selection after Binding GridView
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
                MessageBox.Show("RI:43 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Event to prevent  firing event multiple times
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl txt = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvProduct.CurrentCell.ColumnIndex == dgvProduct.Columns["dgvtxtQuantity"].Index)
                {
                    txt.KeyPress += dgvtxtAmount_KeyPress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:44 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// event to Commit the each and every changes in grid cells
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
                MessageBox.Show("RI:45 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// event to validate decimal entry in Quantity Column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvProduct.CurrentCell != null)
                {
                    if (dgvProduct.Columns[dgvProduct.CurrentCell.ColumnIndex].Name == "dgvtxtQuantity")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// event to remove row in GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                RemoveRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:47 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// event to save function in btnSave click and Ctrl+s Key Press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (CheckErrorForSaving())
                    {
                        if (RemoveIncompleteRowsFromGrid())
                        {
                            if (decRejectionInIdToEdit == 0)
                            {
                                if (PublicVariables.isMessageAdd)
                                {
                                    if (Messages.SaveMessage())
                                    {

                                        if (!bllRejectionInBll.RejectionInVoucherNoCheckExistence(txtRejectionInNo.Text, decRejectionInVoucherTypeId, decRejectionInIdToEdit))
                                        {
                                            SaveOrEdit();
                                            ClearRejectionIn();
                                            VoucherNoGeneration();
                                        }
                                        else
                                        {
                                            Messages.InformationMessage("Voucher number already exist");
                                            txtRejectionInNo.Focus();
                                        }

                                    }
                                }
                                else
                                {
                                    if (!bllRejectionInBll.RejectionInVoucherNoCheckExistence(txtRejectionInNo.Text, decRejectionInVoucherTypeId, decRejectionInIdToEdit))
                                    {
                                        SaveOrEdit();
                                        ClearRejectionIn();
                                        VoucherNoGeneration();
                                    }
                                    else
                                    {
                                        Messages.InformationMessage("Voucher number already exist");
                                        txtRejectionInNo.Focus();
                                    }
                                }
                            }

                            else
                            {
                                if (PublicVariables.isMessageEdit)
                                {
                                    if (Messages.UpdateMessage())
                                    {
                                        if (!bllRejectionInBll.RejectionInVoucherNoCheckExistence(txtRejectionInNo.Text, decRejectionInVoucherTypeId, decRejectionInIdToEdit))
                                        {
                                            SaveOrEdit();
                                            ClearRejectionIn();
                                        }
                                        else
                                        {
                                            Messages.InformationMessage("Voucher number already exist");
                                            txtRejectionInNo.Focus();
                                        }

                                    }
                                }
                                else
                                {
                                    if (!bllRejectionInBll.RejectionInVoucherNoCheckExistence(txtRejectionInNo.Text, decRejectionInVoucherTypeId, decRejectionInIdToEdit))
                                    {
                                        SaveOrEdit();
                                        ClearRejectionIn();
                                    }
                                    else
                                    {
                                        Messages.InformationMessage("Voucher number already exist");
                                        txtRejectionInNo.Focus();
                                    }
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
                MessageBox.Show("RI:48 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Event to clear RejectionIn Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRejectionIn();

                if (frmRejectionInRegisterObj != null)
                {
                    frmRejectionInRegisterObj.Close();
                    frmRejectionInRegisterObj = null;
                }

                if (frmRejectionInReportObj != null)
                {
                    frmRejectionInReportObj.Close();
                    frmRejectionInReportObj = null;
                }
                if (frmVoucherSearchObj != null)
                {
                    frmVoucherSearchObj.Close();
                    frmVoucherSearchObj = null;
                }
                cmbDeliveryNoteNo.Visible = false;
                lblDeliverNoteNo.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// event to delete Data
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
                MessageBox.Show("RI:50 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing, checking the other opend form status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRejectionIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmRejectionInRegisterObj != null)
                {
                    frmRejectionInRegisterObj.Enabled = true;
                    frmRejectionInRegisterObj.RegisterGridFill();
                }
                if (frmRejectionInReportObj != null)
                {
                    frmRejectionInReportObj.Enabled = true;
                    frmRejectionInReportObj.RejectionInReportFill();
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
                if (objVoucherProduct != null)
                {
                    objVoucherProduct.Enabled = true;
                    objVoucherProduct.FillGrid();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:51 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Close button click event
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
                MessageBox.Show("RI:52 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Event to Fill voucher Type comboBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashorParty_SelectedValueChanged(object sender, EventArgs e)
        {
            VoucherTypeComboFill();
            lblDeliverNoteNo.Visible = false;
            cmbDeliveryNoteNo.Visible = false;
            try
            {
                if (cmbCashorParty.SelectedValue != null && cmbVoucherType.SelectedValue != null)
                {
                    if (cmbCashorParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashorParty.Text != "System.Data.DataRowView" && cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView" && cmbVoucherType.Text != "System.Data.DataRowView")
                    {
                        dgvProduct.Rows.Clear();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Fill the Grid Corresponding To DeliveryNote Selected No
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDeliveryNoteNo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isFromRejectionInRegister)
                {
                    if (!isOrderFill)
                    {
                        if (cmbDeliveryNoteNo.SelectedValue.ToString() != "System.Data.DataRowView" && cmbDeliveryNoteNo.Text != "System.Data.DataRowView")
                        {
                            FillGridCorrespondingToDeliveryNoteNo();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// event to fill DeliveryNote ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!isDontExecuteCashorParty)
                {

                    if (cmbCashorParty.SelectedValue != null && cmbVoucherType.SelectedValue != null)
                    {
                        if (cmbCashorParty.SelectedValue.ToString() != "System.Data.DataRowView" && cmbCashorParty.Text != "System.Data.DataRowView" && cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView" && cmbVoucherType.Text != "System.Data.DataRowView")
                        {
                            lblDeliverNoteNo.Visible = true;
                            cmbDeliveryNoteNo.Visible = true;
                            DeliveryNoteNoCombofill();
                        }
                    }
                }
                dgvProduct.Rows.Clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show("RI:55" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// event to change the total amount as per the quantity and rate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProduct.Columns[e.ColumnIndex].Name == "dgvtxtRate")
                {
                    if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtproductId"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtproductId"].Value.ToString() != string.Empty)
                    {
                        if (dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuantity"].Value != null && dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuantity"].Value.ToString() != string.Empty)
                        {
                            decimal decRate = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtRate"].Value.ToString());
                            decimal decQty = Convert.ToDecimal(dgvProduct.Rows[e.RowIndex].Cells["dgvtxtQuantity"].Value.ToString());
                            decimal decNewRate = (decQty * decRate);
                            dgvProduct.Rows[e.RowIndex].Cells["dgvtxtAmount"].Value = Math.Round(decNewRate);
                            CalcTotalAmt();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("RI:56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// event to navigate from  RejectionIn invoice No
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRejectionInNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDate.Focus();
                    txtDate.SelectionStart = txtDate.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// event to enter and backspace key navigation in Date textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashorParty.Focus();
                }
                if (!isAutomatic)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (txtDate.SelectionStart == 0)
                        {
                            txtRejectionInNo.Focus();
                            txtRejectionInNo.SelectionStart = txtRejectionInNo.Text.Length;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cash or Party ComboBox Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashorParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();

                }
                if (!isDoAfterGridFill)
                {
                    dgvProduct.Rows.Clear();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashorParty.SelectionStart == 0)
                    {
                        txtDate.SelectionStart = txtDate.Text.Length;
                        txtDate.Focus();
                    }

                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnCashorPartyPopup_Click(sender, e);
                }
                if (e.Control && e.KeyCode == Keys.F)
                {
                    if (cmbCashorParty.SelectedIndex != -1)
                    {

                        frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromRejectionIn(this, Convert.ToDecimal(cmbCashorParty.SelectedValue.ToString()), "CashOrParty"/*CashOrSundryDeptors*/);
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or bank account ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        ///  Voucher Type ComboBox Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbDeliveryNoteNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbCashorParty.Focus();
                }
                if (!isDoAfterGridFill)
                {
                    dgvProduct.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Delivery Note No ComboBox Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDeliveryNoteNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbPricingLevel.Focus();
                }

                if (e.KeyCode == Keys.Back)
                {
                    cmbVoucherType.Focus();
                }
                if (!isDoAfterGridFill)
                {
                    dgvProduct.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Pricing Level ComboBox Enter and backSpace Key Navigation
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
                if (e.KeyCode == Keys.Back)
                {
                    cmbDeliveryNoteNo.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Sales Man ComboBox Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
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
                        if (dgvProduct.Rows.Count > 0)
                        {
                            dgvProduct.Focus();
                            dgvProduct.CurrentCell = dgvProduct.Rows[0].Cells["dgvtxtSlNo"];
                        }
                        else
                        {
                            txtTransportationCompany.Focus();
                        }
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbPricingLevel.Focus();
                }
                if (e.Alt && e.KeyCode == Keys.C)
                {
                    SendKeys.Send("{F10}");
                    btnSalesManPopup_Click(sender, e);
                }
                if (e.Control && e.KeyCode == Keys.F)
                {
                    if (cmbCashorParty.SelectedIndex != -1)
                    {
                        frmEmployeePopup frmEmployeePopUp = new frmEmployeePopup();
                        frmEmployeePopUp.MdiParent = formMDI.MDIObj;
                        frmEmployeePopUp.callFromRejectionIn(this, Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString()), "SalesMan");
                    }

                    else
                    {
                        Messages.InformationMessage("Select Salesman");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Currency ComboBox Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvProduct.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbCashorParty.Focus();
                }
                if (!isDoAfterGridFill)
                {
                    dgvProduct.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Transportation textBox Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTransportationCompany_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtLRNo.Focus();
                    txtLRNo.SelectionStart = txtLRNo.Text.Length;
                }

                if (e.KeyCode == Keys.Back)
                {
                    if (txtTransportationCompany.SelectionStart == 0)
                    {
                        if (dgvProduct.Rows.Count > 0)
                        {
                            dgvProduct.Focus();
                        }
                    }
                    else if (txtTransportationCompany.Text == string.Empty || txtTransportationCompany.SelectionStart == 0)
                    {
                        if (cmbCurrency.Enabled)
                        {
                            cmbCurrency.Focus();
                        }
                        else
                        {
                            cmbSalesMan.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Narration textBox Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxPrintAfterSave.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.SelectionStart == 0)
                    {
                        txtLRNo.Focus();
                        txtLRNo.SelectionStart = txtLRNo.Text.Length;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("RI:66" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// GridView Enter and backSpace Key Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int inDgvProductRowCount = dgvProduct.Rows.Count;
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProduct.CurrentCell == dgvProduct.Rows[inDgvProductRowCount - 1].Cells["dgvtxtAmount"])
                    {
                        txtTransportationCompany.Focus();
                        txtTransportationCompany.SelectionStart = txtTransportationCompany.TextLength;
                        dgvProduct.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvProduct.CurrentCell == dgvProduct.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        cmbCurrency.Focus();
                        dgvProduct.ClearSelection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Narration TextBox keypress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            int inKeyPressCount = 0;
            try
            {
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
                MessageBox.Show("RI:68" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// LRNo textBox Enter and backSpace Key Navigation
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
                    txtNarration.SelectionStart = txtNarration.Text.Length;
                }

                if (e.KeyCode == Keys.Back)
                {
                    if (txtLRNo.SelectionStart == 0)
                    {
                        txtTransportationCompany.Focus();
                        txtTransportationCompany.SelectionStart = txtTransportationCompany.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:69" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    txtNarration.SelectionLength = txtNarration.SelectionStart;
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:70" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// event to focus Print After Save CheckBox from btnSave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyUp_1(object sender, KeyEventArgs e)
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
                MessageBox.Show("RI:74" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// event to fire Save function in Ctrl+S key press  and Delete Function in Ctrl+D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRejectionIn_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.S)
                {
                    btnSave.PerformClick();
                }
                if (e.Control && e.KeyCode == Keys.D)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI:75" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }

}
