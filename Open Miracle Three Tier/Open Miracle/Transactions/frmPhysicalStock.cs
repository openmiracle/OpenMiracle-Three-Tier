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
using System.IO;
using System.Collections;
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmPhysicalStock : Form
    {
        #region Public variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        SettingsBll BllSettings = new SettingsBll();
        TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
        PhysicalStockMasterInfo infoPhysicalStockMaster = new PhysicalStockMasterInfo();
        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
        frmDayBook frmDayBookObj = null;//To use in call from frmDayBook
        frmPhysicalStockRegister frmPhysicalStockRegisterObj = null;
        frmPhysicalStockReport frmPhysicalStockReportObj = null;
        frmVoucherSearch objfrmVoucherSearch = null;
        frmVoucherWiseProductSearch objfrmVoucherProduct = null;
        ArrayList arrlstMasterId = new ArrayList();
        ArrayList lstArrOfRemove = new ArrayList();
        ArrayList arrlstOfRemove = new ArrayList();//to get the removed rows physicalStockDetailsId
        int inArrOfRemove = 0;//number of rows removed by clicking remove button
        int inNarrationCount = 0;
        decimal decPhysicalStockVoucherTypeId = 0;//to get the selected voucher type id from frmVoucherTypeSelection
        decimal decConversionId = 0;
        decimal decBatchId = 0;
        decimal decPhysicalStockMasterIdentity = 0;//Id of Physicalstock master
        decimal decPhysicalStockSuffixPrefixId = 0;
        decimal decDailySuffixPrefixId = 0;//to store the selected voucher type's suffixpreffixid from frmVoucherTypeSelection
        decimal decMasterId = 0;//to get physical stock master id when viewing from register
        string strTableName = "PhysicalStockMaster";
        string strVoucherNo = string.Empty;
        string strPrefix = string.Empty;//to get the prefix string from frmvouchertypeselection
        string strSuffix = string.Empty;//to get the suffix string from frmvouchertypeselection
        string strProductCode = string.Empty;
        bool isAutomatic = false;//to check whether the voucher number is automatically generated or not
        bool isAmountcalc = true;
        bool isValueChanged = false;
        bool isGridValueChanged = true;
        bool isFromEditMode = false;
        DataTable dtblunitconversionViewAll = new DataTable();
        DataGridViewTextBoxEditingControl TextBoxControl;
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        PhysicalStockDetailsInfo infoPhysicalStockDetails = new PhysicalStockDetailsInfo();
        string strProductCodetoFill = string.Empty;
        #endregion
        #region Functions
        /// <summary>
        /// Function to call this form from frmPhysicalStockRegister to view details and for updation
        /// </summary>
        /// <param name="frmPhysicalStockRegister"></param>
        /// <param name="decId"></param>
        public void View(frmPhysicalStockRegister frmPhysicalStockRegister, decimal decId)
        {
            try
            {
                base.Show();
                this.frmPhysicalStockRegisterObj = frmPhysicalStockRegister;
                frmPhysicalStockRegisterObj.Enabled = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtVoucherNo.ReadOnly = true;
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Print function for crystel report
        /// </summary>
        /// <param name="decPhysicalStockMasterId"></param>
        public void Print(decimal decPhysicalStockMasterId)
        {
            try
            {
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                DataSet dsPhysicalStock = BllPhysicalStock.PhysicalStockPrinting(decPhysicalStockMasterId, 1);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.PhysicalStockPrinting(dsPhysicalStock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// print function for dotmatrix printer
        /// </summary>
        /// <param name="decPhysicalStockMasterId"></param>
        public void PrintForDotMatrix(decimal decPhysicalStockMasterId)
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
                foreach (DataGridViewRow dRow in dgvPhysicalStock.Rows)
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
                dtblOtherDetails.Columns.Add("voucherNo");
                dtblOtherDetails.Columns.Add("date");
                dtblOtherDetails.Columns.Add("Narration");
                dtblOtherDetails.Columns.Add("TotalAmount");
                dtblOtherDetails.Columns.Add("AmountInWords");
                dtblOtherDetails.Columns.Add("Declaration");
                dtblOtherDetails.Columns.Add("Heading1");
                dtblOtherDetails.Columns.Add("Heading2");
                dtblOtherDetails.Columns.Add("Heading3");
                dtblOtherDetails.Columns.Add("Heading4");
                DataRow dRowOther = dtblOtherDetails.Rows[0];
                dRowOther["voucherNo"] = txtVoucherNo.Text;
                dRowOther["date"] = txtDate.Text;
                dRowOther["Narration"] = txtNarration.Text;
                dRowOther["TotalAmount"] = txtTotalAmount.Text;
                dRowOther["address"] = (dtblOtherDetails.Rows[0]["address"].ToString().Replace("\n", ", ")).Replace("\r", "");
                dRowOther["AmountInWords"] = new NumToText().AmountWords(Convert.ToDecimal(txtTotalAmount.Text), PublicVariables._decCurrencyId);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                DataTable dtblDeclaration = BllVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decPhysicalStockVoucherTypeId);
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
                MessageBox.Show("PS:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// Delete function
        /// </summary>
        /// <param name="decPhysicalStockId"></param>
        public void DeleteFunction(decimal decPhysicalStockId)
        {
            try
            {
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                BllPhysicalStock.PhysicalStockDelete(decPhysicalStockId, decPhysicalStockVoucherTypeId, strVoucherNo);
                Messages.DeletedMessage();
                if (objfrmVoucherSearch != null)
                {
                    this.Close();
                    objfrmVoucherSearch.GridFill();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPhysicalStockReport to view details and for updation
        /// </summary>
        /// <param name="frmPhysicalStockReportObj"></param>
        /// <param name="decId"></param>
        public void CallFromPhysicalStockReport(frmPhysicalStockReport frmPhysicalStockReportObj, decimal decId)
        {
            try
            {
                base.Show();
                this.frmPhysicalStockReportObj = frmPhysicalStockReportObj;
                frmPhysicalStockReportObj.Enabled = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtVoucherNo.Enabled = false;
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///   Function to call this form from frmVoucherWiseProductSearch to view details and for updation
        /// </summary>
        /// <param name="frmVoucherwiseProductSearch"></param>
        /// <param name="decmasterId"></param>
        public void CallFromVoucherWiseProductSearch(frmVoucherWiseProductSearch frmVoucherwiseProductSearch, decimal decmasterId)
        {
            try
            {
                base.Show();
                frmVoucherwiseProductSearch.Enabled = false;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtVoucherNo.Enabled = false;
                objfrmVoucherProduct = frmVoucherwiseProductSearch;
                decMasterId = decmasterId;
                arrlstMasterId.Add(decMasterId);
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.objfrmVoucherSearch = frm;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill function for updation
        /// </summary>
        public void FillFunction()
        {
            try
            {
                PhysicalStockMasterInfo infoPhysicalStockMaster = new PhysicalStockMasterInfo();
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                infoPhysicalStockMaster = BllPhysicalStock.PhysicalStockMasterView(decMasterId);
                txtVoucherNo.Text = infoPhysicalStockMaster.InvoiceNo;
                strVoucherNo = infoPhysicalStockMaster.VoucherNo.ToString();
                decPhysicalStockSuffixPrefixId = Convert.ToDecimal(infoPhysicalStockMaster.SuffixPrefixId);
                decPhysicalStockVoucherTypeId = Convert.ToDecimal(infoPhysicalStockMaster.VoucherTypeId);
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decPhysicalStockVoucherTypeId);
                txtDate.Text = infoPhysicalStockMaster.Date.ToString("dd-MMM-yyyy");
                txtNarration.Text = infoPhysicalStockMaster.Narration;
                txtTotalAmount.Text = infoPhysicalStockMaster.TotalAmount.ToString();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = BllPhysicalStock.PhysicalStockViewbyMasterId(decMasterId);
                isFromEditMode = true;
                for (int i = 0; i < ListObj[0].Rows.Count; i++)
                {

                    dgvPhysicalStock.Rows.Add();
                    dgvPhysicalStock.Rows[i].HeaderCell.Value = string.Empty;
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtPhysicalStockDetailId"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["physicalStockDetailsId"].ToString());
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtSlNo"].Value = ListObj[0].Rows[i]["slno"].ToString();
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtProductCode"].Value = ListObj[0].Rows[i]["productCode"].ToString();
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtProductName"].Value = ListObj[0].Rows[i]["productName"].ToString();
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtQty"].Value = ListObj[0].Rows[i]["qty"].ToString();
                    BatchComboFill(Convert.ToDecimal(ListObj[0].Rows[i]["productId"].ToString()), i, dgvPhysicalStock.Rows[i].Cells["dgvcmbBatch"].ColumnIndex);
                    dgvPhysicalStock.Rows[i].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["batchId"].ToString());
                    dgvPhysicalStock.Rows[i].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["unitId"].ToString());
                    dgvPhysicalStock.Rows[i].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["godownId"].ToString());
                    dgvPhysicalStock.Rows[i].Cells["dgvcmbRack"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["rackId"].ToString());
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtRate"].Value = ListObj[0].Rows[i]["rate"].ToString();
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtAmount"].Value = ListObj[0].Rows[i]["amount"].ToString();
                    dgvPhysicalStock.Rows[i].Cells["dgvtxtBarcode"].Value = ListObj[0].Rows[i]["barcode"].ToString();
                    if (dgvPhysicalStock.Columns.Count > 0)
                    {
                        dgvPhysicalStock.Columns["dgvtxtRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvPhysicalStock.Columns["dgvtxtAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
                isFromEditMode = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="DecPhysicalStockVoucherType"></param>
        /// <param name="strPhysicalStockVouchertypeName"></param>
        public void CallFromVoucherTypeSelection(decimal DecPhysicalStockVoucherType, string strPhysicalStockVouchertypeName)
        {
            try
            {
                decPhysicalStockVoucherTypeId = DecPhysicalStockVoucherType;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decPhysicalStockVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPhysicalStockVoucherTypeId, dtpDate.Value);
                decDailySuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                this.Text = strPhysicalStockVouchertypeName;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form dettings check based on the settings
        /// </summary>
        public void SettingsCheck()
        {
            try
            {
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    dgvPhysicalStock.Columns["dgvtxtProductCode"].Visible = true;
                }
                else
                {
                    dgvPhysicalStock.Columns["dgvtxtProductCode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    dgvPhysicalStock.Columns["dgvcmbGodown"].Visible = true;
                }
                else
                {
                    dgvPhysicalStock.Columns["dgvcmbGodown"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    dgvPhysicalStock.Columns["dgvcmbRack"].Visible = true;
                }
                else
                {
                    dgvPhysicalStock.Columns["dgvcmbRack"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    dgvPhysicalStock.Columns["dgvcmbBatch"].Visible = true;
                }
                else
                {
                    dgvPhysicalStock.Columns["dgvcmbBatch"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("Barcode") == "Yes")
                {
                    dgvPhysicalStock.Columns["dgvtxtBarcode"].Visible = true;
                }
                else
                {
                    dgvPhysicalStock.Columns["dgvtxtBarcode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    dgvPhysicalStock.Columns["dgvcmbUnit"].Visible = true;
                }
                else
                {
                    dgvPhysicalStock.Columns["dgvcmbUnit"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("TickPrintAfterSave") == "Yes")
                {
                    cbxPrint.Checked = true;
                }
                else
                {
                    cbxPrint.Checked = false;
                }
                if (isAutomatic)
                {
                    VoucherNumberGeneration();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Create an instance for frmPhysicalStock class
        /// </summary>
        public frmPhysicalStock()
        {
            InitializeComponent();
        }
        /// <summary>
        /// To fill godown field of grid
        /// </summary>
        public void GodownComboFill()
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
                MessageBox.Show("PS:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill unit field of grid
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
                MessageBox.Show("PS:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill rack field of grid
        /// </summary>
        public void RackAllComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RackBll BllRack = new RackBll();
                listObj = BllRack.RackViewAll();
                dgvcmbRack.DataSource = listObj[0];
                dgvcmbRack.ValueMember = "rackId";
                dgvcmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Setting the product code and name for grid quick access
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
                MessageBox.Show("PS:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// CHeck the settings status for print after save checkbox
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
                MessageBox.Show("PS:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        /// <summary>
        /// Serial no generation for gridview
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inRowSlNo = 1;
                foreach (DataGridViewRow dr in dgvPhysicalStock.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowSlNo;
                    inRowSlNo++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Amount calculation for grid
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="inIndexOfRow"></param>
        public void NewAmountCalculation(int inIndexOfRow)
        {
            try
            {
                decimal decRate = 0;
                decimal decQty = 0;
                decimal decGrossValue = 0;
                if (dgvPhysicalStock.Rows[inIndexOfRow].Cells["dgvtxtProductName"].Value != null && dgvPhysicalStock.Rows[inIndexOfRow].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                {
                    if (dgvPhysicalStock.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value != null)
                    {
                        decimal.TryParse(Convert.ToString(dgvPhysicalStock.Rows[inIndexOfRow].Cells["dgvtxtQty"].Value), out decQty);
                    }
                    if (dgvPhysicalStock.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value != null)
                    {
                        decimal.TryParse(Convert.ToString(dgvPhysicalStock.Rows[inIndexOfRow].Cells["dgvtxtRate"].Value), out decRate);
                    }
                    decGrossValue = decQty * decRate;
                    dgvPhysicalStock.Rows[inIndexOfRow].Cells["dgvtxtAmount"].Value = Math.Round(decGrossValue, PublicVariables._inNoOfDecimalPlaces);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Voucher no generation function based on settings
        /// </summary>
        public void VoucherNumberGeneration()
        {
            try
            {
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                if (strVoucherNo == string.Empty)
                {
                    strVoucherNo = "0";
                }
                strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPhysicalStockVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                if (Convert.ToDecimal(strVoucherNo) != (BllPhysicalStock.PhysicalStockMasterVoucherMax(decPhysicalStockVoucherTypeId)))
                {
                    strVoucherNo = BllPhysicalStock.PhysicalStockMasterVoucherMax(decPhysicalStockVoucherTypeId).ToString();
                    strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPhysicalStockVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                    if (BllPhysicalStock.PhysicalStockMasterVoucherMax(decPhysicalStockVoucherTypeId) == 0)
                    {
                        strVoucherNo = "0";
                        strVoucherNo = TransactionGeneralFillObj.VoucherNumberAutomaicGeneration(decPhysicalStockVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, strTableName);
                    }
                }
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPhysicalStockVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    decPhysicalStockSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                    txtVoucherNo.Text = strPrefix + strVoucherNo + strSuffix;
                    txtVoucherNo.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// The form will be reset here
        /// </summary>
        public void clear()
        {
            try
            {
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                txtNarration.Clear();
                txtTotalAmount.Clear();
                txtTotalAmount.Text = "0";
                dgvPhysicalStock.Rows.Clear();
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                if (isAutomatic)
                {
                    VoucherNumberGeneration();
                }
                if (!txtVoucherNo.ReadOnly)
                {
                    txtVoucherNo.Clear();
                    txtVoucherNo.Focus();
                }
                else
                {
                    txtDate.Select();
                }
                SettingsCheck();
                GodownComboFill();
                UnitComboFill();
                RackAllComboFill();
                dtpDate.Value = PublicVariables._dtCurrentDate;
                FillProducts(false, null);
                txtTotalAmount.Text = "0";
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Edit function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                //PhysicalStockDetailsSP spPhysicalStockDetails = new PhysicalStockDetailsSP();
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                infoPhysicalStockMaster.PhysicalStockMasterId = decMasterId;
                infoPhysicalStockMaster.VoucherNo = txtVoucherNo.Text.Trim();
                infoPhysicalStockMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoPhysicalStockMaster.Narration = txtNarration.Text.Trim();
                infoPhysicalStockMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                if (!isAutomatic)
                {
                    infoPhysicalStockMaster.SuffixPrefixId = decPhysicalStockSuffixPrefixId;
                    infoPhysicalStockMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoPhysicalStockMaster.SuffixPrefixId = 0;
                    infoPhysicalStockMaster.VoucherNo = txtVoucherNo.Text;
                }
                infoPhysicalStockMaster.VoucherTypeId = decPhysicalStockVoucherTypeId;
                infoPhysicalStockMaster.InvoiceNo = txtVoucherNo.Text;
                infoPhysicalStockMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPhysicalStockMaster.Extra1 = string.Empty;
                infoPhysicalStockMaster.Extra2 = string.Empty;
                infoPhysicalStockMaster.ExtraDate = DateTime.Now;
                BllPhysicalStock.PhysicalStockMasterEdit(infoPhysicalStockMaster);
                BllPhysicalStock.PhysicalStockDetailsDeleteWhenUpdate(decMasterId);
                EditPhysicalStockDetails();
                Messages.UpdatedMessage();
                if (frmPhysicalStockRegisterObj != null)
                {
                    if (cbxPrint.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decMasterId);
                        }
                        else
                        {
                            Print(decMasterId);
                        }
                    }
                    this.Close();
                    frmPhysicalStockRegisterObj.gridfill();
                }
                if (frmPhysicalStockReportObj != null)
                {
                    if (cbxPrint.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decMasterId);
                        }
                        else
                        {
                            Print(decMasterId);
                        }
                    }
                    this.Close();
                    frmPhysicalStockReportObj.gridfill();
                }
                if (frmDayBookObj != null)
                {
                    if (cbxPrint.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decMasterId);
                        }
                        else
                        {
                            Print(decMasterId);
                        }
                    }
                    this.Close();
                    frmDayBookObj.dayBookGridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Stock posting add function
        /// </summary>
        /// <param name="decProductId"></param>
        /// <param name="strMaster"></param>
        public void AddtoStockPosting(decimal decProductId, string strMaster)
        {
            try
            {
                // StockPostingSP spStockPosting = new StockPostingSP();
                StockPostingBll BllStockPosting = new StockPostingBll();
                StockPostingInfo infoStockPosting = new StockPostingInfo();
                decimal decCurrentQty = infoPhysicalStockDetails.Qty;
                decimal decGId = infoPhysicalStockDetails.GodownId;
                decimal decBId = infoPhysicalStockDetails.BatchId;
                decimal decRId = infoPhysicalStockDetails.RackId;
                decimal decOldStock = BllStockPosting.ProductGetCurrentStock(decProductId, decGId, decBId, decRId);
                if (decCurrentQty >= 0)
                {
                    if (decOldStock >= 0)
                    {
                        decimal decBalance = decCurrentQty - decOldStock;
                        if (decBalance >= 0)
                        {
                            infoStockPosting.InwardQty = decBalance;
                            infoStockPosting.OutwardQty = 0;
                        }
                        else
                        {
                            infoStockPosting.InwardQty = 0;
                            infoStockPosting.OutwardQty = -decBalance;
                        }
                    }
                    else
                    {
                        infoStockPosting.InwardQty = -decOldStock + decCurrentQty;
                        infoStockPosting.OutwardQty = 0;
                    }
                }
                else
                {
                    if (decOldStock >= 0)
                    {
                        infoStockPosting.InwardQty = 0;
                        infoStockPosting.OutwardQty = -decCurrentQty + decOldStock;
                    }
                    else
                    {
                        decimal decBalance = -decCurrentQty + decOldStock;
                        if (decBalance >= 0)
                        {
                            infoStockPosting.InwardQty = 0;
                            infoStockPosting.OutwardQty = decBalance;
                        }
                        else
                        {
                            infoStockPosting.InwardQty = -decBalance;
                            infoStockPosting.OutwardQty = 0;
                        }
                    }
                }
                infoStockPosting.VoucherNo = strMaster;
                infoStockPosting.BatchId = infoPhysicalStockDetails.BatchId;
                infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                infoStockPosting.Extra1 = string.Empty;
                infoStockPosting.Extra2 = string.Empty;
                infoStockPosting.GodownId = infoPhysicalStockDetails.GodownId;
                infoStockPosting.ProductId = decProductId;
                infoStockPosting.Rate = infoPhysicalStockDetails.Rate;
                infoStockPosting.UnitId = infoPhysicalStockDetails.UnitId;
                infoStockPosting.RackId = infoPhysicalStockDetails.RackId;
                infoStockPosting.AgainstVoucherTypeId = 0;
                infoStockPosting.AgainstVoucherNo = "NA";
                infoStockPosting.AgainstInvoiceNo = "NA";
                infoStockPosting.VoucherTypeId = decPhysicalStockVoucherTypeId;
                infoStockPosting.InvoiceNo = strMaster;
                BllStockPosting.StockPostingAdd(infoStockPosting);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Batch combofillBased on product
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
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvPhysicalStock.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Adding PhysicalStockDetails when updating
        /// </summary>
        public void EditPhysicalStockDetails()
        {
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                PhysicalStockDetailsInfo infoPhysicalStockDetails = new PhysicalStockDetailsInfo();              
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                int inRowcount = dgvPhysicalStock.Rows.Count;
                for (int inI = 0; inI < inRowcount - 1; inI++)
                {
                    infoPhysicalStockDetails.PhysicalStockMasterId = decMasterId;
                    infoPhysicalStockDetails.PhysicalStockDetailsId = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvtxtPhysicalStockDetailId"].Value);
                    if (dgvPhysicalStock.Rows[inI].Cells["dgvtxtProductCode"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                    {
                        infoProduct = BllProductCreation.ProductViewByCode(dgvPhysicalStock.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                        infoPhysicalStockDetails.ProductId = infoProduct.ProductId;
                    }
                    if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbGodown"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                    {
                        infoPhysicalStockDetails.GodownId = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                    }
                    else
                    {
                        infoPhysicalStockDetails.GodownId = 0;
                    }
                    if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbRack"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbRack"].Value.ToString() != string.Empty)
                    {
                        infoPhysicalStockDetails.RackId = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvcmbRack"].Value.ToString());
                    }
                    else
                    {
                        infoPhysicalStockDetails.RackId = 0;
                    }
                    if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbBatch"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                    {
                        infoPhysicalStockDetails.BatchId = Convert.ToDecimal(Convert.ToString(dgvPhysicalStock.Rows[inI].Cells["dgvcmbBatch"].Value));
                    }
                    else
                    {
                        infoPhysicalStockDetails.BatchId = 0;
                    }
                    if (dgvPhysicalStock.Rows[0].Cells["dgvcmbBatch"].Value == null && dgvPhysicalStock.Rows[0].Cells["dgvcmbBatch"].Value == null)
                    {
                        MessageBox.Show("Can't update physical stock without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPhysicalStock.ClearSelection();
                        dgvPhysicalStock.Focus();
                    }
                    if (dgvPhysicalStock.Rows[inI].Cells["dgvtxtQty"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                    {
                        infoPhysicalStockDetails.Qty = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                    }
                    if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbUnit"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                    {
                        infoPhysicalStockDetails.UnitId = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                    }
                    infoPhysicalStockDetails.Rate = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                    infoPhysicalStockDetails.Amount = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                    infoPhysicalStockDetails.Slno = Convert.ToInt32(dgvPhysicalStock.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                    infoPhysicalStockDetails.Extra1 = string.Empty;
                    infoPhysicalStockDetails.Extra2 = string.Empty;
                    BllPhysicalStock.PhysicalStockDetailsAdd(infoPhysicalStockDetails);
                    decimal decPId = infoPhysicalStockDetails.ProductId;
                    string strVoucher = infoPhysicalStockMaster.VoucherNo;
                    AddtoStockPosting(decPId, strVoucher);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Calculating the Grand total amount
        /// </summary>
        private void CalculateTotalAmount()
        {
            try
            {
                {
                    decimal decTotalAmount = 0;
                    decimal decSelectedCurrencyRate = 0;
                    ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                    foreach (DataGridViewRow dr in dgvPhysicalStock.Rows)
                    {
                        if (dr.Cells["dgvtxtAmount"].Value != null && dr.Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            if (dr.Cells["dgvcmbCurrency"].Value != null)
                            {
                                decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(dr.Cells["dgvcmbCurrency"].Value.ToString()));//Exchange rate of grid's row
                                decTotalAmount = decTotalAmount + (Convert.ToDecimal(dr.Cells["dgvtxtAmount"].Value.ToString()) * decSelectedCurrencyRate);
                            }
                            else
                            {
                                decTotalAmount = decTotalAmount + Convert.ToDecimal(dr.Cells["dgvtxtAmount"].Value.ToString());
                            }
                        }
                    }
                    txtTotalAmount.Text = Math.Round(decTotalAmount, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save or edit function, checking the invalid entries here
        /// </summary>
        public void SaveorEdit()
        {
            try
            {
                int inIfGridColumnMissing = 0;
                ArrayList arrLst = new ArrayList();
                string output = string.Empty;
                int inRow = dgvPhysicalStock.RowCount;
                if (inRow == 1)
                {
                    Messages.InformationMessage("Can't save without atleast one complete details");
                    dgvPhysicalStock.Focus();
                    inIfGridColumnMissing = 1;
                }
                else
                {
                    int inJ = 0;
                    for (int inI = 0; inI < inRow - 1; inI++)
                    {
                        if (dgvPhysicalStock.Rows[inI].HeaderCell.Value.ToString() == "X")
                        {
                            arrLst.Add(Convert.ToString(inI + 1));
                            inIfGridColumnMissing = 1;
                            inJ++;
                        }
                    }
                    if (inJ != 0)
                    {
                        if (inJ == inRow - 1)
                        {
                            Messages.InformationMessage("Can't save without atleat one complete details");
                            inIfGridColumnMissing = 1;
                        }
                        else
                        {
                            foreach (object obj in arrLst)
                            {
                                string str = Convert.ToString(obj);
                                if (str != null)
                                {
                                    output += str + ",";
                                }
                                else
                                {
                                    break;
                                }
                            }
                            bool isOk = Messages.UpdateMessageCustom("Row No " + output + " not completed.Do you want to continue?");
                            if (isOk)
                            {
                                inIfGridColumnMissing = 0;
                            }
                            else
                            {
                                inIfGridColumnMissing = 1;
                            }
                        }
                    }
                    if (inIfGridColumnMissing == 0)
                    {
                        if (btnSave.Text == "Save")
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
                        if (btnSave.Text == "Update")
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
            catch (Exception ex)
            {
                MessageBox.Show("PS:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking the column's value missing in grid , search and replace the header cell based on it
        /// </summary>
        public void CheckColumnMissing()
        {
            try
            {
                if (dgvPhysicalStock.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductName"].Value == null || dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductName"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvPhysicalStock.CurrentRow.HeaderCell.Value = "X";
                            dgvPhysicalStock.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvPhysicalStock.CurrentRow.Cells["dgvtxtQty"].Value == null || dgvPhysicalStock.CurrentRow.Cells["dgvtxtQty"].Value.ToString().Trim() == string.Empty || Convert.ToDecimal(dgvPhysicalStock.CurrentRow.Cells["dgvtxtQty"].Value) == 0)
                        {

                            isValueChanged = true;
                            dgvPhysicalStock.CurrentRow.HeaderCell.Value = "X";
                            dgvPhysicalStock.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvPhysicalStock.CurrentRow.Cells["dgvtxtRate"].Value == null || dgvPhysicalStock.CurrentRow.Cells["dgvtxtRate"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvPhysicalStock.CurrentRow.HeaderCell.Value = "X";
                            dgvPhysicalStock.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvPhysicalStock.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Save Function
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                PhysicalStockMasterInfo infoPhysicalStockMaster = new PhysicalStockMasterInfo();
                //PhysicalStockDetailsSP spPhysicalStockDetails = new PhysicalStockDetailsSP();               
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                infoPhysicalStockMaster.VoucherNo = txtVoucherNo.Text.Trim();
                infoPhysicalStockMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoPhysicalStockMaster.Narration = txtNarration.Text.Trim();
                string s = txtTotalAmount.Text;
                infoPhysicalStockMaster.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                if (isAutomatic)
                {
                    infoPhysicalStockMaster.SuffixPrefixId = decPhysicalStockSuffixPrefixId;
                    infoPhysicalStockMaster.VoucherNo = strVoucherNo;
                    infoPhysicalStockMaster.InvoiceNo = txtVoucherNo.Text;
                }
                else
                {
                    infoPhysicalStockMaster.SuffixPrefixId = 0;
                    infoPhysicalStockMaster.VoucherNo = txtVoucherNo.Text;
                    infoPhysicalStockMaster.InvoiceNo = txtVoucherNo.Text;
                }
                infoPhysicalStockMaster.VoucherTypeId = decPhysicalStockVoucherTypeId;
                infoPhysicalStockMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoPhysicalStockMaster.Extra1 = string.Empty;
                infoPhysicalStockMaster.Extra2 = string.Empty;
                decPhysicalStockMasterIdentity = Convert.ToDecimal(BllPhysicalStock.PhysicalStockMasterAdd(infoPhysicalStockMaster));
                int inRowcount = dgvPhysicalStock.Rows.Count;
                for (int inI = 0; inI < inRowcount - 1; inI++)
                {
                    if (dgvPhysicalStock.Rows[inI].HeaderCell.Value.ToString() != "X")
                    {
                        infoPhysicalStockDetails.PhysicalStockMasterId = decPhysicalStockMasterIdentity;
                        if (dgvPhysicalStock.Rows[inI].Cells["dgvtxtProductCode"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                        {
                            infoProduct = BllProductCreation.ProductViewByCode(dgvPhysicalStock.Rows[inI].Cells["dgvtxtProductCode"].Value.ToString());
                            infoPhysicalStockDetails.ProductId = infoProduct.ProductId;
                        }
                        if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbGodown"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                        {
                            infoPhysicalStockDetails.GodownId = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvcmbGodown"].Value.ToString());
                        }
                        else
                        {
                            infoPhysicalStockDetails.GodownId = 0;
                        }
                        if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbRack"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbRack"].Value.ToString() != string.Empty)
                        {
                            infoPhysicalStockDetails.RackId = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvcmbRack"].Value.ToString());
                        }
                        else
                        {
                            infoPhysicalStockDetails.RackId = 0;
                        }
                        if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbBatch"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbBatch"].Value.ToString() != string.Empty)
                        {
                            infoPhysicalStockDetails.BatchId = Convert.ToDecimal(Convert.ToString(dgvPhysicalStock.Rows[inI].Cells["dgvcmbBatch"].Value));
                        }
                        else
                        {
                            infoPhysicalStockDetails.BatchId = 0;
                        }
                        if (dgvPhysicalStock.Rows[inI].Cells["dgvtxtQty"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvtxtQty"].Value.ToString() != string.Empty)
                        {
                            infoPhysicalStockDetails.Qty = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvtxtQty"].Value.ToString());
                        }
                        if (dgvPhysicalStock.Rows[inI].Cells["dgvcmbUnit"].Value != null && dgvPhysicalStock.Rows[inI].Cells["dgvcmbUnit"].Value.ToString() != string.Empty)
                        {
                            infoPhysicalStockDetails.UnitId = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvcmbUnit"].Value.ToString());
                            infoPhysicalStockDetails.UnitConversionId = decConversionId;
                        }
                        infoPhysicalStockDetails.Rate = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvtxtRate"].Value.ToString());
                        infoPhysicalStockDetails.Amount = Convert.ToDecimal(dgvPhysicalStock.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        infoPhysicalStockDetails.Slno = Convert.ToInt32(dgvPhysicalStock.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString());
                        infoPhysicalStockDetails.Extra1 = string.Empty;
                        infoPhysicalStockDetails.Extra2 = string.Empty;
                        BllPhysicalStock.PhysicalStockDetailsAdd(infoPhysicalStockDetails);
                        decimal decPId = infoPhysicalStockDetails.ProductId;
                        string strVoucher = infoPhysicalStockMaster.VoucherNo;
                        AddtoStockPosting(decPId, strVoucher);
                    }
                }
                Messages.SavedMessage();
                if (dgvPhysicalStock.RowCount > 1)
                {
                    if (cbxPrint.Checked)
                    {
                        if (BllSettings.SettingsStatusCheck("Printer") == "Dot Matrix")
                        {
                            PrintForDotMatrix(decPhysicalStockMasterIdentity);
                        }
                        else
                        {
                            Print(decPhysicalStockMasterIdentity);
                        }
                    }
                }
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDayBook to view details and for updation
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decId"></param>
        public void callFromDayBook(frmDayBook frmDayBook, decimal decId)
        {
            try
            {
                base.Show();
                frmDayBook.Enabled = false;
                this.frmDayBookObj = frmDayBook;
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
                txtVoucherNo.Enabled = false;
                decMasterId = decId;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                infoProduct = BllProductCreation.ProductView(decproductId);
                int inRowcount = dgvPhysicalStock.Rows.Count;
                for (int i = 0; i < inRowcount; i++)
                {
                    if (i == decCurrentRowIndex)
                    {
                        strProductCode = infoProduct.ProductCode;
                        productDetailsFill(strProductCode, i, "ProductCode");
                    }
                }
                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 59" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion
        #region Events
        /// <summary>
        /// Form loads , call the clear function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhysicalStock_Load(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form closing , checking the other form status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhysicalStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmPhysicalStockRegisterObj != null)
                {
                    frmPhysicalStockRegisterObj.Enabled = true;
                    frmPhysicalStockRegisterObj.gridfill();
                }
                if (frmPhysicalStockReportObj != null)
                {
                    frmPhysicalStockReportObj.Enabled = true;
                    frmPhysicalStockReportObj.gridfill();
                }
                if (objfrmVoucherSearch != null)
                {
                    objfrmVoucherSearch.Enabled = true;
                    objfrmVoucherSearch.GridFill();
                }
                if (objfrmVoucherProduct != null)
                {
                    objfrmVoucherProduct.Enabled = true;
                    objfrmVoucherProduct.FillGrid();
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
                MessageBox.Show("PS:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  delete button click, checking the user privilage and call the delete function
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
                            DeleteFunction(decMasterId);
                        }
                    }
                    else
                    {
                        DeleteFunction(decMasterId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation for amount column in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvPhysicalStock.CurrentCell != null)
                {
                    if (dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtAmount")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation for Rate column in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvPhysicalStock.CurrentCell != null)
                {
                    if (dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calling the corresponding events and set the column SuggestAppend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStock_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
                if (TextBoxControl != null)
                {
                    if (dgvPhysicalStock.CurrentCell != null && dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;
                    }
                    if (dgvPhysicalStock.CurrentCell != null && dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;
                    }
                    if (dgvPhysicalStock.CurrentCell != null && dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name != "dgvtxtProductCode" && dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name != "dgvtxtProductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvPhysicalStock.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;
                    if (dgvPhysicalStock.CurrentCell.ColumnIndex == dgvPhysicalStock.Columns["dgvtxtAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the decimal validation for event
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
                MessageBox.Show("PS:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call the DecimalValidation for Qty and rate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvPhysicalStock.CurrentCell != null)
                {
                    if (dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtQty" || dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// set the txtDate value based on the dtp's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtDate.Text = dtpDate.Value.ToString("dd-MMM-yyyy");
                txtDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// validate the date format and set the date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtDate);
                if (txtDate.Text == string.Empty)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// get the narration line count for navigation
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
                        txtTotalAmount.Focus();
                        txtNarration.SelectionStart = 0;
                        txtNarration.SelectionLength = 0;
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvPhysicalStock_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
        /// set tye columns as based on settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStock_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            decimal decGodownId = 0;
            try
            {
                if (dgvPhysicalStock.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvPhysicalStock.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvPhysicalStock.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
                if (e.ColumnIndex == dgvPhysicalStock.Columns["dgvcmbRack"].Index)
                {
                    if (dgvPhysicalStock.CurrentRow.Cells["dgvcmbGodown"].Value != null && dgvPhysicalStock.CurrentRow.Cells["dgvcmbGodown"].Value.ToString() != string.Empty)
                    {

                        decGodownId = Convert.ToDecimal(dgvPhysicalStock.CurrentRow.Cells["dgvcmbGodown"].Value);
                        RackComboFillCorrespondingGodown(decGodownId, e.RowIndex, dgvPhysicalStock.CurrentRow.Cells["dgvcmbRack"].ColumnIndex);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cleare button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("PS:42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// save button click, checking the user privilage and call save function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    SaveorEdit();
                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// ClearSelection in gridview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvPhysicalStock.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void productDetailsFill(string strProduct, int inRowIndex, string strFillMode)
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                List<DataTable> listObj = new List<DataTable>();
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
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value = listObj[0].Rows[0]["productCode"].ToString();
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtProductName"].Value = listObj[0].Rows[0]["productName"].ToString();
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbUnit"].Value = Convert.ToDecimal(listObj[0].Rows[0]["unitId"].ToString());
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(listObj[0].Rows[0]["unitId"].ToString());
                    decimal decproductId = Convert.ToDecimal(listObj[0].Rows[0]["productId"].ToString());
                    BatchComboFill(decproductId, inRowIndex, Convert.ToInt32(dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbBatch"].ColumnIndex));
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbBatch"].Value = Convert.ToDecimal(listObj[0].Rows[0]["batchId"].ToString());
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtRate"].Value = listObj[0].Rows[0]["purchaseRate"].ToString();
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbGodown"].Value = Convert.ToDecimal(listObj[0].Rows[0]["godownId"].ToString());
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbRack"].Value = Convert.ToDecimal(listObj[0].Rows[0]["rackId"].ToString());
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtQty"].Value = string.Empty;
                }
                else
                {
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtProductName"].Value = string.Empty;
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtRate"].Value = string.Empty;
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtProductCode"].Value = string.Empty;
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbUnit"].Value = string.Empty;
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvtxtBarcode"].Value = string.Empty;
                    dgvPhysicalStock.Rows[inRowIndex].Cells["dgvcmbBatch"].Value = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Doing basic calculations in cell value change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                BatchBll BllBatch = new BatchBll();
                //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    string strBarcode = string.Empty;
                    string strProductCode = string.Empty;
                    if (dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvtxtBarcode")
                    {
                        string strBCode = string.Empty;
                        DataTable dtbl = new DataTable();
                        if (dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value != null && dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString() != string.Empty)
                        {
                            strBCode = dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtBarcode"].Value.ToString();
                            productDetailsFill(strBCode, dgvPhysicalStock.CurrentRow.Index, "Barcode");
                            CheckColumnMissing();
                        }
                    }
                    else if (dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        UnitInfo infoUnit = new UnitInfo();
                        string strPrdCode = string.Empty;
                        if (dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null && dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString() != string.Empty)
                        {
                            strPrdCode = dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString();
                            productDetailsFill(strPrdCode, dgvPhysicalStock.CurrentRow.Index, "ProductCode");
                            CheckColumnMissing();
                        }
                    }
                    else if (dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvtxtProductName")
                    {
                        string strProductName = string.Empty;
                        DataTable dtbl = new DataTable();
                        if (dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value != null && dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                        {
                            strProductName = dgvPhysicalStock.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString();
                            productDetailsFill(strProductName, dgvPhysicalStock.CurrentRow.Index, "ProductName");
                            CheckColumnMissing();
                        }
                    }
                    if (dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvtxtQty" && isAmountcalc || dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvtxtRate" && isAmountcalc)
                    {
                        NewAmountCalculation(e.RowIndex);
                        CheckColumnMissing();
                    }
                    if (dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvtxtQty" && isAmountcalc || dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvtxtRate" && isAmountcalc)
                    {
                        CalculateTotalAmount();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Link button click to remove one row from grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int inRowCount = dgvPhysicalStock.RowCount;
                if (inRowCount > 1 && !dgvPhysicalStock.CurrentRow.IsNewRow)
                {
                    if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (dgvPhysicalStock.CurrentRow.Cells["dgvtxtPhysicalStockDetailId"].Value != null && dgvPhysicalStock.CurrentRow.Cells["dgvtxtPhysicalStockDetailId"].Value.ToString() != "")
                        {
                            arrlstOfRemove.Add(dgvPhysicalStock.CurrentRow.Cells["dgvtxtPhysicalStockDetailId"].Value.ToString());
                            inArrOfRemove++;
                        }
                        dgvPhysicalStock.Rows.RemoveAt(dgvPhysicalStock.CurrentRow.Index);
                        SerialNo();
                        CalculateTotalAmount();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvPhysicalStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvPhysicalStock_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!isFromEditMode)
            {
                try
                {
                    string strBarcode = string.Empty;
                    string strProductCode = string.Empty;
                    ProductInfo infoProduct = new ProductInfo();
                    ProductCreationBll BllProductCreation = new ProductCreationBll();
                    BatchBll BllBatch = new BatchBll();
                    //PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
                    PhysicalStockBll BllPhysicalStock = new PhysicalStockBll();
                    if (e.RowIndex != -1 && e.ColumnIndex != -1)
                    {
                        if (dgvPhysicalStock.Columns[e.ColumnIndex].Name == "dgvcmbBatch")
                        {
                            if (dgvPhysicalStock.CurrentRow.Cells["dgvcmbBatch"].Value != null)
                            {
                                if (Convert.ToString(dgvPhysicalStock.CurrentRow.Cells["dgvcmbBatch"].Value) != string.Empty &&
                                   Convert.ToDecimal(dgvPhysicalStock.CurrentRow.Cells["dgvcmbBatch"].Value) != 0)
                                {
                                    if (isGridValueChanged)
                                    {
                                        decBatchId = Convert.ToDecimal(dgvPhysicalStock.CurrentRow.Cells["dgvcmbBatch"].Value);
                                        strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                                        isGridValueChanged = false;
                                        dgvPhysicalStock.CurrentRow.Cells["dgvtxtBarcode"].Value = strBarcode;
                                        isGridValueChanged = true;
                                    }
                                }
                            }
                        }
                        CheckColumnMissing();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PS:45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvPhysicalStock.Focus();
                    dgvPhysicalStock.Rows[dgvPhysicalStock.RowCount - 1].Cells["dgvtxtBarcode"].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text.Trim() == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        dgvPhysicalStock.Focus();
                        dgvPhysicalStock.Rows[dgvPhysicalStock.RowCount - 1].Cells["dgvtxtProductCode"].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void RackComboFillCorrespondingGodown(decimal decGodownId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RackBll BllRack = new RackBll();
                listObj = BllRack.RackNamesCorrespondingToGodownId(decGodownId);
                DataRow drow = listObj[0].NewRow();
                DataGridViewComboBoxCell dgvcmbRackCellConsumption = (DataGridViewComboBoxCell)dgvPhysicalStock.Rows[inRow].Cells[inColumn];
                dgvcmbRackCellConsumption.DataSource = listObj[0];
                dgvcmbRackCellConsumption.ValueMember = "rackId";
                dgvcmbRackCellConsumption.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPhysicalStock_KeyDown(object sender, KeyEventArgs e)
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
                    if (dgvPhysicalStock.CurrentCell != null)
                    {
                        if (dgvPhysicalStock.CurrentCell == dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductName"] || dgvPhysicalStock.CurrentCell == dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductCode"])
                        {
                            if (dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                            {
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                frmProductCreationObj.CallFromPhysicalStock(this);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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
                    strProductCodetoFill = infoProduct.ProductCode;
                    productDetailsFill(strProductCodetoFill, dgvPhysicalStock.CurrentRow.Index, "ProductCode");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PI: Jas1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtTotalAmount.Text == string.Empty || txtTotalAmount.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionStart = 0;
                        txtNarration.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSave.Focus();
                }
                if (e.KeyCode == Keys.Enter)
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
                MessageBox.Show("PS:50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and Backspace navigation
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
                MessageBox.Show("PS:51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnClear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtTotalAmount.Focus();
                    txtTotalAmount.SelectionStart = 0;
                    txtTotalAmount.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  For Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhysicalStock_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPhysicalStock.CurrentCell == dgvPhysicalStock.Rows[dgvPhysicalStock.Rows.Count - 1].Cells["dgvtxtAmount"])
                    {
                        txtNarration.Focus();
                        txtNarration.SelectionStart = 0;
                        txtNarration.SelectionLength = 0;
                        dgvPhysicalStock.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvPhysicalStock.CurrentCell == dgvPhysicalStock.Rows[0].Cells["dgvtxtSlNo"])
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                        dgvPhysicalStock.ClearSelection();
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                    {
                        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                        frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                        if (dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductCode"].Value != null || dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductName"].Value != null)
                        {
                            frmProductSearchPopupObj.CallFromPhysicalStock(this, dgvPhysicalStock.CurrentRow.Index, dgvPhysicalStock.CurrentRow.Cells["dgvSitxtProductCode"].Value.ToString());
                        }
                        else
                        {
                            frmProductSearchPopupObj.CallFromPhysicalStock(this, dgvPhysicalStock.CurrentRow.Index, string.Empty);
                        }
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    if (dgvPhysicalStock.CurrentCell != null)
                    {
                        if (dgvPhysicalStock.CurrentCell == dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductName"] || dgvPhysicalStock.CurrentCell == dgvPhysicalStock.CurrentRow.Cells["dgvtxtProductCode"])
                        {
                            SendKeys.Send("{F10}");
                            if (dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductName" || dgvPhysicalStock.Columns[dgvPhysicalStock.CurrentCell.ColumnIndex].Name == "dgvtxtProductCode")
                            {
                                frmProductCreation frmProductCreationObj = new frmProductCreation();
                                frmProductCreationObj.MdiParent = formMDI.MDIObj;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PS:54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
