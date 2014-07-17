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
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmStockJournal : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>       
        ProductCreationBll BllProductCreation = new ProductCreationBll();
        frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
        frmProductCreation frmProductCreationObj = new frmProductCreation();
        frmAccountLedger frmAccountLedgerObj = new frmAccountLedger();
        StockPostingInfo infoStockPosting = new StockPostingInfo();
        //StockPostingSP spStockPosting = new StockPostingSP();
        StockPostingBll BllStockPosting = new StockPostingBll();
        ArrayList ArrlstOfConsumtionRemove = new ArrayList();
        ArrayList ArrlstOfProductionRemove = new ArrayList();
        ArrayList ArrlstOfAdditionalCostRemove = new ArrayList();
        AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ProductCodes = new AutoCompleteStringCollection();
        DataGridViewTextBoxEditingControl TextBoxControl;
        frmStockJournalRegister frmStockJournalRegisterObj = null;
        frmStockJournelReport frmStockJournelReportObj = null;
        frmDayBook frmDayBookObj = null;
        frmVoucherSearch objVoucherSearch = null;
        decimal decStockJournalMasterIdForEdit = 0;
        decimal decVoucherTypeId = 0;
        decimal decSuffixPrefixId = 0;
        bool isAutomatic = false;
        bool isFillMode = false;
        string strProductCode = string.Empty;
        bool isValueChanged = false;
        string strVoucherNo = string.Empty;
        string TableName = "StockJournalMaster";
        string strPrefix = string.Empty;
        string strSuffix = string.Empty;
        string strInvoiceNo = string.Empty;
        decimal decCurrentConversionRate = 0;
        decimal decCurrentRate = 0;
        bool IsSetGridValueChange = true;
        bool IsdgvConsuption = false;
        int inNarrationCount = 0;
        decimal StockJournalVoucherTypeId = 0;
        decimal decStockMasterId = 0;
        #endregion
        #region Functions
        /// <summary>
        /// Create an instance for frmStockJournal Class
        /// </summary>
        public frmStockJournal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to Remove Row from StockJournalConsumptionDetails
        /// </summary>
        public void RemoveRowStockJournalConsumptionDetails()
        {
            StockJournalBll BllStockJournal = new StockJournalBll();
            try
            {
                foreach (var strDetailsId in ArrlstOfConsumtionRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strDetailsId);
                    BllStockJournal.StockJournalDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Remove Row from StockJournalProductionDetails
        /// </summary>
        public void RemoveRowStockJournalProductionDetails()
        {
            StockJournalBll BllStockJournal = new StockJournalBll();
            try
            {
                foreach (var strDetailsId in ArrlstOfProductionRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strDetailsId);
                    BllStockJournal.StockJournalDetailsDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Remove Row from StockJournalAdditionalCostDetails
        /// </summary>
        public void RemoveRowStockJournalAdditionalCostDetails()
        {
            AditionalCostBll bllAdditionalCost = new AditionalCostBll();
            try
            {
                foreach (var strDetailsId in ArrlstOfAdditionalCostRemove)
                {
                    decimal decDeleteId = Convert.ToDecimal(strDetailsId);
                    bllAdditionalCost.AdditionalCostDelete(decDeleteId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check settings for stock journal
        /// </summary>
        public void StockJournalSettingsCheck()
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("AllowGodown") == "Yes")
                {
                    rbtnTransfer.Enabled = true;
                    dgvConsumption.Columns["dgvcmbConsumptionGodown"].Visible = true;
                    dgvProduction.Columns["dgvcmbProductionGodown"].Visible = true;
                }
                else
                {
                    rbtnTransfer.Enabled = false;
                    dgvConsumption.Columns["dgvcmbConsumptionGodown"].Visible = false;
                    dgvProduction.Columns["dgvcmbProductionGodown"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    dgvConsumption.Columns["dgvcmbConsumptionRack"].Visible = true;
                    dgvProduction.Columns["dgvcmbProductionRack"].Visible = true;
                }
                else
                {
                    dgvConsumption.Columns["dgvcmbConsumptionRack"].Visible = false;
                    dgvProduction.Columns["dgvcmbProductionRack"].Visible = false;
                }

                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    dgvConsumption.Columns["dgvcmbConsumptionunitId"].Visible = true;
                    dgvProduction.Columns["dgvcmbProductionunitId"].Visible = true;
                }
                else
                {
                    dgvConsumption.Columns["dgvcmbConsumptionunitId"].Visible = false;
                    dgvProduction.Columns["dgvcmbProductionunitId"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("ShowProductCode") == "Yes")
                {
                    dgvConsumption.Columns["dgvtxtConsumptionProductCode"].Visible = true;
                    dgvProduction.Columns["dgvtxtProductionProductCode"].Visible = true;
                }
                else
                {
                    dgvConsumption.Columns["dgvtxtConsumptionProductCode"].Visible = false;
                    dgvProduction.Columns["dgvtxtProductionProductCode"].Visible = false;
                }

                if (BllSettings.SettingsStatusCheck("Barcode") == "Yes")
                {
                    dgvConsumption.Columns["dgvtxtConsumptionBarcode"].Visible = true;
                    dgvProduction.Columns["dgvtxtProductionBarcode"].Visible = true;
                }
                else
                {
                    dgvConsumption.Columns["dgvtxtConsumptionBarcode"].Visible = false;
                    dgvProduction.Columns["dgvtxtProductionBarcode"].Visible = false;
                }
                if (BllSettings.SettingsStatusCheck("AllowBatch") == "Yes")
                {
                    dgvConsumption.Columns["dgvcmbConsumptionBatch"].Visible = true;
                    dgvProduction.Columns["dgvcmbProductionBatch"].Visible = true;
                }
                else
                {
                    dgvConsumption.Columns["dgvcmbConsumptionBatch"].Visible = false;
                    dgvProduction.Columns["dgvcmbProductionBatch"].Visible = false;

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
                MessageBox.Show("SJ:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for total amount calculation of consumption grid
        /// </summary>
        public void TotalAmountCalculationConsumption(string columnName, int inIndexOfRow)
        {
            try
            {
                decimal dcRate = 0;
                decimal dcQty = 0;
                decimal dcGrossValue = 0;

                if (dgvConsumption.Rows[inIndexOfRow].Cells["dgvtxtConsumptionQty"].Value != null && dgvConsumption.Rows[inIndexOfRow].Cells["dgvtxtConsumptionQty"].Value.ToString() != string.Empty)
                {

                    if (dgvConsumption.Rows[inIndexOfRow].Cells["dgvtxtConsumptionQty"].Value != null)
                    {
                        dcQty = Convert.ToDecimal(dgvConsumption.Rows[inIndexOfRow].Cells["dgvtxtConsumptionQty"].Value.ToString());
                    }

                    if (dgvConsumption.Rows[inIndexOfRow].Cells["dgvtxtConsumptionRate"].Value != null)
                    {
                        dcRate = Convert.ToDecimal(dgvConsumption.Rows[inIndexOfRow].Cells["dgvtxtConsumptionRate"].Value.ToString());
                    }
                    dcGrossValue = dcQty * dcRate;
                    dgvConsumption.Rows[inIndexOfRow].Cells["dgvtxtConsumptionAmount"].Value = Math.Round(dcGrossValue, PublicVariables._inNoOfDecimalPlaces);
                    grandTotalAmountCalculationConsumption();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill unit combobox for consumption
        /// </summary>
        public void UnitComboFillConsumption(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                UnitBll bllUnit = new UnitBll();
                ListObj = bllUnit.UnitViewAllByProductId(decProductId);
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvConsumption.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill unit combobox for Production
        /// </summary>
        public void UnitComboFillProduction(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                UnitBll bllUnit = new UnitBll();
                ListObj = bllUnit.UnitViewAllByProductId(decProductId);
                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvProduction.Rows[inRow].Cells[inColumn];
                dgvcmbUnitCell.DataSource = ListObj[0];
                dgvcmbUnitCell.DisplayMember = "unitName";
                dgvcmbUnitCell.ValueMember = "unitId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Total amount calculation for production
        /// </summary>
        public void TotalAmountCalculationProduction(string columnName, int inIndexOfRow)
        {
            try
            {
                decimal dcRate = 0;
                decimal dcQty = 0;
                decimal dcGrossValue = 0;
                if (dgvProduction.Rows[inIndexOfRow].Cells["dgvtxtProductionQty"].Value != null && dgvProduction.Rows[inIndexOfRow].Cells["dgvtxtProductionQty"].Value.ToString() != string.Empty)
                {
                    if (dgvProduction.Rows[inIndexOfRow].Cells["dgvtxtProductionQty"].Value != null)
                    {
                        dcQty = Convert.ToDecimal(dgvProduction.Rows[inIndexOfRow].Cells["dgvtxtProductionQty"].Value.ToString());
                    }
                    if (dgvProduction.Rows[inIndexOfRow].Cells["dgvtxtProductionRate"].Value != null)
                    {
                        dcRate = Convert.ToDecimal(dgvProduction.Rows[inIndexOfRow].Cells["dgvtxtProductionRate"].Value.ToString());
                    }
                    dcGrossValue = dcQty * dcRate;
                    dgvProduction.Rows[inIndexOfRow].Cells["dgvtxtProductionAmount"].Value = Math.Round(dcGrossValue, PublicVariables._inNoOfDecimalPlaces);
                    grandTotalAmountCalculationProduction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill batch combobox
        /// </summary>
        public void BatchComboFillConsumption(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> list = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                list = BllBatch.BatchNamesCorrespondingToProduct(decProductId);
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvConsumption.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill batch combobox for production
        /// </summary>
        public void BatchComboFillProduction(decimal decProductId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> list = new List<DataTable>();
                BatchBll BllBatch = new BatchBll();
                list = BllBatch.BatchNamesCorrespondingToProduct(decProductId);
                DataGridViewComboBoxCell dgvcmbBatchCell = (DataGridViewComboBoxCell)dgvProduction.Rows[inRow].Cells[inColumn];
                dgvcmbBatchCell.DataSource = list[0];
                dgvcmbBatchCell.ValueMember = "batchId";
                dgvcmbBatchCell.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grandTotal Amount Calculation for Consumption
        /// </summary>
        public void grandTotalAmountCalculationConsumption()
        {
            try
            {
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                int inRowCount = dgvConsumption.RowCount;
                decimal decTotalAmount = 0;
                decimal decGridTotalAmount = 0;
                foreach (DataGridViewRow dgrow in dgvConsumption.Rows)
                {
                    if (dgrow.Cells["dgvtxtConsumptionAmount"].Value != null)
                    {
                        if (dgrow.Cells["dgvtxtConsumptionAmount"].Value.ToString() != string.Empty && dgrow.Cells["dgvtxtConsumptionAmount"].Value.ToString() != "0")
                        {
                            decTotalAmount = Convert.ToDecimal(dgrow.Cells["dgvtxtConsumptionAmount"].Value.ToString());
                            decGridTotalAmount = decGridTotalAmount + decTotalAmount;
                        }
                    }
                }
                lblConsumptionAmount.Text = Math.Round(decGridTotalAmount, PublicVariables._inNoOfDecimalPlaces).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherSearch to view details and for updation 
        /// </summary>
        public void CallFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {
            try
            {
                base.Show();
                objVoucherSearch = frm;
                decStockJournalMasterIdForEdit = decId;
                FillRegisterOrReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove function for additional cost
        /// </summary>
        public void RemoveFunctionForAdditionalCost()
        {
            int inAddRowCount = dgvAdditionalCost.RowCount;
            int inAddIndex = dgvAdditionalCost.CurrentRow.Index;
            try
            {
                if (inAddRowCount > 2)
                {
                    dgvAdditionalCost.Rows.RemoveAt(inAddIndex);
                }
                else
                {
                    dgvAdditionalCost.Rows.RemoveAt(inAddIndex);
                }
                AdditionalCostSerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Remove function for consumption
        /// </summary>
        public void RemoveFunctionForConsumption()
        {
            int inAddRowCount = dgvConsumption.RowCount;
            int inAddIndex = dgvConsumption.CurrentRow.Index;
            try
            {
                if (inAddRowCount > 2)
                {
                    dgvConsumption.Rows.RemoveAt(inAddIndex);
                }
                else
                {
                    dgvConsumption.Rows.RemoveAt(inAddIndex);
                }
                ConsumptionSerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// remove function for production
        /// </summary>
        public void RemoveFunctionForProduction()
        {
            int inAddRowCount = dgvProduction.RowCount;
            int inAddIndex = dgvProduction.CurrentRow.Index;
            try
            {
                if (inAddRowCount > 2)
                {
                    dgvProduction.Rows.RemoveAt(inAddIndex);
                }
                else
                {
                    dgvProduction.Rows.RemoveAt(inAddIndex);
                }
                ProductionSerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grand total amount calculation for production
        /// </summary>
        public void grandTotalAmountCalculationProduction()
        {
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            int inRowCount = dgvConsumption.RowCount;
            try
            {
                decimal decTotalAmount = 0;
                decimal decGridTotalAmount = 0;
                foreach (DataGridViewRow dgrow in dgvProduction.Rows)
                {

                    if (dgrow.Cells["dgvtxtProductionAmount"].Value != null)
                    {
                        if (dgrow.Cells["dgvtxtProductionAmount"].Value.ToString() != string.Empty && dgrow.Cells["dgvtxtProductionAmount"].Value.ToString() != "0")
                        {
                            decTotalAmount = Convert.ToDecimal(dgrow.Cells["dgvtxtProductionAmount"].Value.ToString());
                            decGridTotalAmount = decGridTotalAmount + decTotalAmount;
                        }
                    }
                }
                lblProductionAmount.Text = Math.Round(decGridTotalAmount, PublicVariables._inNoOfDecimalPlaces).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill productdetails for consumption
        /// </summary>
        public void ProductDetailsFillConsumption(string strProduct, int inRowIndex, string strFillMode)
        {
            decimal decProductId = 0;
            decimal decGodownId = 0;
            try
            {
                StockJournalBll BllStockJournal = new StockJournalBll();
                ProductInfo infoProductFill = new ProductInfo();
                List<DataTable> listObj = new List<DataTable>();
                BatchComboFill();
                RackComboFill();
                GodownComboFill();
                UnitComboFill();
                if (strFillMode == "ProductCode")
                {
                    listObj = BllStockJournal.StockJournalDetailsByProductCode(decVoucherTypeId, strProduct);
                }
                else if (strFillMode == "ProductName")
                {
                    listObj = BllStockJournal.StockJournalDetailsByProductName(decVoucherTypeId, strProduct);
                }
                else if (strFillMode == "Barcode")
                {
                    listObj = BllStockJournal.StockJournalDetailsViewByBarcode(decVoucherTypeId, strProduct);
                }
                if (listObj[0].Rows.Count != 0)
                {
                    decProductId = Convert.ToDecimal(listObj[0].Rows[0]["productId"]);
                    decGodownId = Convert.ToDecimal(listObj[0].Rows[0]["godownId"]);
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionProductId"].Value = listObj[0].Rows[0]["productId"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionBarcode"].Value = listObj[0].Rows[0]["barcode"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionProductCode"].Value = listObj[0].Rows[0]["productCode"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionProductName"].Value = listObj[0].Rows[0]["productName"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionunitConversionId"].Value = listObj[0].Rows[0]["unitConversionId"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionunitId"].Value = Convert.ToDecimal(listObj[0].Rows[0]["unitId"].ToString());
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionRate"].Value = listObj[0].Rows[0]["salesRate"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionGodown"].Value = listObj[0].Rows[0]["godownId"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionRack"].Value = listObj[0].Rows[0]["rackId"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionConversionRate"].Value = listObj[0].Rows[0]["conversionRate"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionBatch"].Value = listObj[0].Rows[0]["batchId"];
                    dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionQty"].Value = string.Empty;
                    if (strFillMode == "Barcode")
                    {
                        dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionBatch"].Value = listObj[0].Rows[0]["batchId"];
                    }
                    dgvConsumption.Rows[inRowIndex].HeaderCell.Value = "X";
                    dgvConsumption.Rows[inRowIndex].HeaderCell.Style.ForeColor = Color.Red;
                }
                else
                {
                    if (dgvConsumption.CurrentRow.Index < dgvConsumption.RowCount - 1)
                    {
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionBarcode"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionProductCode"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionProductId"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionProductName"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionQty"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionunitId"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionConversionRate"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionunitConversionId"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionGodown"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionRack"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvcmbConsumptionBatch"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionRate"].Value = string.Empty;
                        dgvConsumption.Rows[inRowIndex].Cells["dgvtxtConsumptionAmount"].Value = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill product details for production
        /// </summary>
        public void ProductDetailsFillProduction(string strProduct, int inRowIndex, string strFillMode)
        {
            try
            {
                StockJournalBll BllStockJournal = new StockJournalBll();
                List<DataTable> listObj = new List<DataTable>();
                BatchComboFill();
                GodownComboFill();
                RackComboFill();

                UnitComboFill();
                if (strFillMode == "ProductCode")
                {
                    listObj = BllStockJournal.StockJournalDetailsByProductCode(decVoucherTypeId, strProduct);
                }
                else if (strFillMode == "ProductName")
                {
                    listObj = BllStockJournal.StockJournalDetailsByProductName(decVoucherTypeId, strProduct);
                }
                else if (strFillMode == "Barcode")
                {
                    listObj = BllStockJournal.StockJournalDetailsViewByBarcode(decVoucherTypeId, strProduct);
                }
                if (listObj[0].Rows.Count != 0)
                {
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionProductId"].Value = listObj[0].Rows[0]["productId"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionBarcode"].Value = listObj[0].Rows[0]["barcode"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionProductCode"].Value = listObj[0].Rows[0]["productCode"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionProductName"].Value = listObj[0].Rows[0]["productName"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionunitConversionId"].Value = listObj[0].Rows[0]["unitConversionId"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionunitId"].Value = Convert.ToDecimal(listObj[0].Rows[0]["unitId"].ToString());
                    dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionGodown"].Value = listObj[0].Rows[0]["godownId"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionRack"].Value = listObj[0].Rows[0]["rackId"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionRate"].Value = listObj[0].Rows[0]["salesRate"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionConversionRate"].Value = listObj[0].Rows[0]["conversionRate"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionBatch"].Value = listObj[0].Rows[0]["batchId"];
                    dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionQty"].Value = string.Empty;
                    if (strFillMode == "Barcode")
                    {
                        dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionBatch"].Value = listObj[0].Rows[0]["batchId"];
                    }
                    dgvProduction.Rows[inRowIndex].HeaderCell.Value = "X";
                    dgvProduction.Rows[inRowIndex].HeaderCell.Style.ForeColor = Color.Red;
                }
                else
                {
                    if (dgvProduction.CurrentRow.Index < dgvProduction.RowCount - 1)
                    {
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionBarcode"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionStockJournalDetailsId"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionProductCode"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionProductId"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionProductName"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionConversionRate"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionQty"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionunitId"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionunitConversionId"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionGodown"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionRack"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvcmbProductionBatch"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionRate"].Value = string.Empty;
                        dgvProduction.Rows[inRowIndex].Cells["dgvtxtProductionAmount"].Value = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill finished goods combobox
        /// </summary>
        public void FinishedGoodsComboFill()
        {
            try
            {
                List<DataTable> listObjFinishedGoods = BllProductCreation.ProductFinishedGoodsComboFill();
                DataRow dr = listObjFinishedGoods[0].NewRow();
                dr[0] = "";
                dr[1] = 0;
                listObjFinishedGoods[0].Rows.InsertAt(dr, 0);
                cmbFinishedGoods.DataSource = listObjFinishedGoods[0];
                cmbFinishedGoods.ValueMember = "productId";
                cmbFinishedGoods.DisplayMember = "productName";
                cmbFinishedGoods.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill godown combobox
        /// </summary>
        public void GodownComboFill()
        {
            try
            {
                GodownBll BllGodown = new GodownBll();
                List<DataTable> listGodown = new List<DataTable>();
                listGodown = BllGodown.GodownViewAll();
                dgvcmbConsumptionGodown.DataSource = listGodown[0];
                dgvcmbConsumptionGodown.ValueMember = "godownId";
                dgvcmbConsumptionGodown.DisplayMember = "godownName";
                dgvcmbProductionGodown.DataSource = listGodown[0];
                dgvcmbProductionGodown.ValueMember = "godownId";
                dgvcmbProductionGodown.DisplayMember = "godownName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill unit combobox
        /// </summary>
        public void UnitComboFill()
        {
            try
            {
                UnitBll spUnit = new UnitBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = spUnit.UnitViewAll();
                dgvcmbConsumptionunitId.DataSource = ListObj[0];
                dgvcmbConsumptionunitId.ValueMember = "unitId";
                dgvcmbConsumptionunitId.DisplayMember = "unitName";
                dgvcmbProductionunitId.DataSource = ListObj[0];
                dgvcmbProductionunitId.ValueMember = "unitId";
                dgvcmbProductionunitId.DisplayMember = "unitName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:21" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill rack combobox
        /// </summary>
        public void RackComboFill()
        {
            try
            {
                RackBll BllRack = new RackBll();
                List<DataTable> listObjRack = new List<DataTable>();
                listObjRack = BllRack.RejectionOutRackViewFromGodownId();
                dgvcmbConsumptionRack.DataSource = listObjRack[0];
                dgvcmbConsumptionRack.ValueMember = "rackId";
                dgvcmbConsumptionRack.DisplayMember = "rackName";
                dgvcmbProductionRack.DataSource = listObjRack[0];
                dgvcmbProductionRack.ValueMember = "rackId";
                dgvcmbProductionRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill batch combobox
        /// </summary>
        public void BatchComboFill()
        {
            try
            {
                BatchBll BllBatch = new BatchBll();
                List<DataTable> listBatch = new List<DataTable>();
                listBatch = BllBatch.BatchViewAll();
                dgvcmbConsumptionBatch.DataSource = listBatch[0];
                dgvcmbConsumptionBatch.ValueMember = "batchId";
                dgvcmbConsumptionBatch.DisplayMember = "batchNo";
                dgvcmbProductionBatch.DataSource = listBatch[0];
                dgvcmbProductionBatch.ValueMember = "batchId";
                dgvcmbProductionBatch.DisplayMember = "batchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        public void CallFromVoucherTypeSelection(decimal decStockJournalVoucherTypeId, string strSockJournalVocherTypeName)//used for vouchertype selection while open the form
        {
            try
            {
                decVoucherTypeId = decStockJournalVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decStockJournalVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decStockJournalVoucherTypeId, dtpDate.Value);
                decSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                this.Text = strSockJournalVocherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:24" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill additional cost
        /// </summary>
        public void AdditionalCostComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                ListObj = bllAccountLedger.AdditionalCostGet();
                dgvcmbAdditionalCostLedger.DataSource = ListObj[0];
                dgvcmbAdditionalCostLedger.ValueMember = "ledgerId";
                dgvcmbAdditionalCostLedger.DisplayMember = "ledgerName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill rack combobox for consumption
        /// </summary>
        public void RackComboFillConsumption(decimal decGodownId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RackBll BllRack = new RackBll();
                listObj = BllRack.RackNamesCorrespondingToGodownId(decGodownId);
                DataRow drow = listObj[0].NewRow();
                DataGridViewComboBoxCell dgvcmbRackCellConsumption = (DataGridViewComboBoxCell)dgvConsumption.Rows[inRow].Cells[inColumn];
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
        /// Function to fill rack combobox for Production
        /// </summary>
        public void RackComboFillProduction(decimal decGodownId, int inRow, int inColumn)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                RackBll BllRack = new RackBll();
                listObj = BllRack.RackNamesCorrespondingToGodownId(decGodownId);
                DataRow drow = listObj[0].NewRow();
                DataGridViewComboBoxCell dgvcmbRackCellProduction = (DataGridViewComboBoxCell)dgvProduction.Rows[inRow].Cells[inColumn];
                dgvcmbRackCellProduction.DataSource = listObj[0];
                dgvcmbRackCellProduction.ValueMember = "rackId";
                dgvcmbRackCellProduction.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill cashorbank combobox
        /// </summary>
        public void CashOrBankComboFill()
        {
            try
            {
                TransactionsGeneralFillBll TransactionsGeneralFillObj = new TransactionsGeneralFillBll();
                TransactionsGeneralFillObj.CashOrBankComboFill(cmbCashOrBank, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                StockJournalBll BllStockJournal = new StockJournalBll();
                if (isAutomatic)
                {
                    if (strVoucherNo == string.Empty)
                    {

                        strVoucherNo = "0";
                    }
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(decVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, TableName);

                    if (Convert.ToDecimal(strVoucherNo) != BllStockJournal.StockJournalMasterMaxPlusOne(decVoucherTypeId))
                    {
                        strVoucherNo = BllStockJournal.StockJournalMasterMax(decVoucherTypeId).ToString();
                        strVoucherNo = obj.VoucherNumberAutomaicGeneration(decVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, TableName);
                        if (BllStockJournal.StockJournalMasterMax(decVoucherTypeId).ToString() == "0")
                        {
                            strVoucherNo = "0";
                            strVoucherNo = obj.VoucherNumberAutomaicGeneration(decVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpDate.Value, TableName);
                        }
                    }
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decVoucherTypeId, dtpDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                    txtVoucherNo.Text = strInvoiceNo;
                    txtVoucherNo.ReadOnly = true;
                }
                else
                {
                    txtVoucherNo.ReadOnly = false;
                    txtVoucherNo.Text = string.Empty;
                    strInvoiceNo = txtVoucherNo.Text.Trim();
                }
                if (PrintAfetrSave())
                {
                    cbxPrintAfterSave.Checked = true;

                }
                else
                {
                    cbxPrintAfterSave.Checked = false;
                }
                btnDelete.Enabled = false;
                btnSave.Text = "Save";
                gbxTransactionType.Enabled = true;
                cmbFinishedGoods.Enabled = true;
                txtQty.Enabled = true;
                btnAdd.Enabled = true;
                VoucherDate();
                dgvConsumption.Rows.Clear();
                dgvProduction.Rows.Clear();
                dgvAdditionalCost.Rows.Clear();
                cmbFinishedGoods.Text = string.Empty;
                txtQty.Text = String.Empty;
                txtNarration.Text = string.Empty;
                lblAdditionalCostAmount.Text = "0.00";
                lblConsumptionAmount.Text = "0.00";
                lblProductionAmount.Text = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:29" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for form default settings
        /// </summary>
        public void FormDefaultSettings()
        {
            try
            {
                FinishedGoodsComboFill();
                BatchComboFill();
                RackComboFill();
                GodownComboFill();
                CurrencyComboFill();
                UnitComboFill();
                AdditionalCostComboFill();
                CashOrBankComboFill();
                rbtnManufacturing.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:30" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for consumption serialNo
        /// </summary>
        public void ConsumptionSerialNo()
        {
            int inCount = 1;
            try
            {
                foreach (DataGridViewRow row in dgvConsumption.Rows)
                {
                    row.Cells["dgvtxtConsumptionSlNO"].Value = inCount.ToString();
                    inCount++;
                    if (row.Index == dgvConsumption.Rows.Count - 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:31" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for product serialNo
        /// </summary>
        public void ProductionSerialNo()
        {
            int inCount = 1;
            try
            {
                foreach (DataGridViewRow row in dgvProduction.Rows)
                {
                    row.Cells["dgvtxtProductionSlNO"].Value = inCount.ToString();
                    inCount++;
                    if (row.Index == dgvProduction.Rows.Count - 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:32" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for additional cost serialNo
        /// </summary>
        public void AdditionalCostSerialNo()
        {
            int inCount = 1;
            try
            {
                foreach (DataGridViewRow row in dgvAdditionalCost.Rows)
                {
                    row.Cells["dgvtxtAdditionalCostSlNo"].Value = inCount.ToString();
                    inCount++;
                    if (row.Index == dgvAdditionalCost.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:33" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Get the Product details from the Product creation form
        /// </summary>
        /// <param name="decproductId"></param>
        public void ReturnFromProductCreation(decimal decproductId)
        {
            try
            {
                ProductInfo infoProduct = new ProductInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                BatchBll BllBatch = new BatchBll();
                DataTable dtbl = new DataTable();
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();

                this.Enabled = true;
                this.BringToFront();
                if (decproductId != 0)
                {
                    infoProduct = BllProductCreation.ProductView(decproductId);
                    strProductCode = infoProduct.ProductCode;

                    if (IsdgvConsuption)
                    {
                        int inCurrentRowIndex = dgvConsumption.CurrentRow.Index;
                        dgvConsumption.Rows.Add();
                        ProductDetailsFillConsumption(strProductCode, inCurrentRowIndex, "ProductCode");
                    }

                    else
                    {
                        int inProductionRowIndex = dgvProduction.CurrentRow.Index;
                        dgvProduction.Rows.Add();
                        ProductDetailsFillProduction(strProductCode, inProductionRowIndex, "ProductCode");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:34" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete stock journal
        /// </summary>
        public void DeleteFunction()
        {
            StockJournalBll BllStockJournal = new StockJournalBll();
            try
            {
                BllStockJournal.StockJournalDeleteAllTables(decStockJournalMasterIdForEdit, decVoucherTypeId, strVoucherNo);
                Messages.DeletedMessage();
                if (frmStockJournalRegisterObj != null)
                {
                    this.Close();
                    frmStockJournalRegisterObj.Enabled = true;
                }
                else if (frmStockJournelReportObj != null)
                {
                    this.Close();
                    frmStockJournelReportObj.Enabled = true;
                }
                else if (objVoucherSearch != null)
                {
                    this.Close();
                    objVoucherSearch.GridFill();
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
                MessageBox.Show("SJ:35" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save stockjournal
        /// </summary>
        public void Save()
        {
            try
            {
                StockJournalMasterInfo infoStockJournalMaster = new StockJournalMasterInfo();
                StockJournalDetailsInfo infoStockJournalDetails = new StockJournalDetailsInfo();
                StockJournalBll BllStockJournal = new StockJournalBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                AdditionalCostInfo infoAdditionalCost = new AdditionalCostInfo();
                AditionalCostBll bllAdditionalCost = new AditionalCostBll();
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                if (isAutomatic == true)
                {
                    infoStockJournalMaster.SuffixPrefixId = decSuffixPrefixId;
                    infoStockJournalMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoStockJournalMaster.SuffixPrefixId = 0;
                    infoStockJournalMaster.VoucherNo = strVoucherNo;
                }
                infoStockJournalMaster.ExtraDate = DateTime.Now;
                infoStockJournalMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                infoStockJournalMaster.Date = Convert.ToDateTime(txtDate.Text);
                infoStockJournalMaster.AdditionalCost = Convert.ToDecimal(lblAdditionalCostAmount.Text);
                infoStockJournalMaster.VoucherNo = strVoucherNo;
                infoStockJournalMaster.VoucherTypeId = decVoucherTypeId;
                infoStockJournalMaster.Narration = txtNarration.Text.Trim();
                infoStockJournalMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoStockJournalMaster.ExchangeRateId = Convert.ToDecimal(cmbCurrency.SelectedValue);
                if (rbtnManufacturing.Checked)
                {
                    infoStockJournalMaster.Extra1 = "Manufacturing";
                }
                if (rbtnTransfer.Checked)
                {
                    infoStockJournalMaster.Extra1 = "Transfer";
                }
                if (rbtnStockOut.Checked)
                {
                    infoStockJournalMaster.Extra1 = "Stock Out";
                }
                infoStockJournalMaster.Extra2 = string.Empty;
                if (btnSave.Text == "Save")
                {
                    decStockMasterId = BllStockJournal.StockJournalMasterAdd(infoStockJournalMaster);
                }
                else
                {
                    infoStockJournalMaster.StockJournalMasterId = decStockJournalMasterIdForEdit;
                    BllStockJournal.StockJournalMasterEdit(infoStockJournalMaster);
                    RemoveRowStockJournalConsumptionDetails();
                    RemoveRowStockJournalProductionDetails();
                    RemoveRowStockJournalAdditionalCostDetails();
                    BllStockPosting.DeleteStockPostingForStockJournalEdit(strVoucherNo, decVoucherTypeId);
                }

                if (dgvConsumption.Rows.Count > 0)
                {
                    int inCount = dgvConsumption.Rows.Count;

                    for (int i = 0; i < inCount - 1; i++)
                    {
                        if (btnSave.Text == "Save")
                        {
                            infoStockJournalDetails.StockJournalMasterId = decStockMasterId;
                        }
                        else
                        {
                            infoStockJournalMaster.StockJournalMasterId = decStockJournalMasterIdForEdit;
                        }
                        infoStockJournalDetails.Extra1 = string.Empty;
                        infoStockJournalDetails.Extra2 = string.Empty;
                        infoStockJournalDetails.ExtraDate = DateTime.Now;
                        infoStockJournalDetails.ProductId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value);
                        infoStockJournalDetails.Qty = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value);
                        infoStockJournalDetails.Rate = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionRate"].Value);
                        infoStockJournalDetails.UnitId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionunitId"].Value);
                        infoStockJournalDetails.UnitConversionId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionunitConversionId"].Value);
                        if (btnSave.Text == "Update")
                        {
                            infoStockJournalDetails.StockJournalMasterId = decStockJournalMasterIdForEdit;
                            if (dgvConsumption.Rows[i].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value == null || dgvConsumption.Rows[i].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value.ToString() == string.Empty)
                            {

                                if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value != null && dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.BatchId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.BatchId = 0;
                                }
                                if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value != null && dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.GodownId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.GodownId = 0;
                                }
                                if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value != null && dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.RackId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.RackId = 0;
                                }
                                infoStockJournalDetails.Amount = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionAmount"].Value);
                                infoStockJournalDetails.ConsumptionOrProduction = "Consumption";
                                infoStockJournalDetails.Slno = Convert.ToInt32(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionSlNo"].Value);
                                BllStockJournal.StockJournalDetailsAdd(infoStockJournalDetails);
                            }
                            else
                            {
                                infoStockJournalDetails.StockJournalDetailsId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value);
                                if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value != null && dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.BatchId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.BatchId = 0;
                                }
                                if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value != null && dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.GodownId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.GodownId = 0;
                                }
                                if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value != null && dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.RackId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.RackId = 0;
                                }
                                infoStockJournalDetails.Amount = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionAmount"].Value);
                                infoStockJournalDetails.ConsumptionOrProduction = "Consumption";
                                infoStockJournalDetails.Slno = Convert.ToInt32(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionSlNo"].Value);
                                BllStockJournal.StockJournalDetailsEdit(infoStockJournalDetails);
                            }
                        }
                        else
                        {
                            infoStockJournalDetails.BatchId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value);
                            infoStockJournalDetails.GodownId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value);
                            infoStockJournalDetails.RackId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value);
                            infoStockJournalDetails.Amount = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionAmount"].Value);
                            infoStockJournalDetails.ConsumptionOrProduction = "Consumption";
                            infoStockJournalDetails.Slno = Convert.ToInt32(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionSlNo"].Value);
                            BllStockJournal.StockJournalDetailsAdd(infoStockJournalDetails);
                        }
                        //Stock Posting Add
                        if (btnSave.Text == "Update")
                        {
                            infoStockPosting.BatchId = infoStockJournalDetails.BatchId;
                            infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                            infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                            infoStockPosting.GodownId = infoStockJournalDetails.GodownId;
                            infoStockPosting.InwardQty = 0;
                            infoStockPosting.OutwardQty = infoStockJournalDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(infoStockJournalDetails.UnitConversionId);
                            infoStockPosting.ProductId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value);
                            infoStockPosting.RackId = infoStockJournalDetails.RackId;
                            infoStockPosting.Rate = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionRate"].Value);
                            infoStockPosting.UnitId = infoStockJournalDetails.UnitId;
                            infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.VoucherTypeId = decVoucherTypeId;
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstInvoiceNo = "NA";
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                            BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                        else
                        {
                            infoStockPosting.BatchId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value);
                            infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                            infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                            infoStockPosting.GodownId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value);
                            infoStockPosting.InwardQty = 0;
                            infoStockPosting.OutwardQty = infoStockJournalDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(infoStockJournalDetails.UnitConversionId);
                            infoStockPosting.ProductId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value);
                            infoStockPosting.RackId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value);
                            infoStockPosting.Rate = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionRate"].Value);
                            infoStockPosting.UnitId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionunitId"].Value);
                            infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.VoucherTypeId = decVoucherTypeId;
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstInvoiceNo = "NA";
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                            BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                    }

                }
                if (dgvProduction.Rows.Count > 0)
                {
                    int inCount = dgvProduction.Rows.Count;

                    for (int i = 0; i < inCount - 1; i++)
                    {

                        if (btnSave.Text == "Update")
                        {
                            infoStockJournalMaster.StockJournalMasterId = decStockJournalMasterIdForEdit;
                        }
                        else
                        {
                            infoStockJournalDetails.StockJournalMasterId = decStockMasterId;
                        }
                        infoStockJournalDetails.Extra1 = string.Empty;
                        infoStockJournalDetails.Extra2 = string.Empty;
                        infoStockJournalDetails.ExtraDate = DateTime.Now;
                        infoStockJournalDetails.ProductId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionProductId"].Value);
                        infoStockJournalDetails.Qty = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionQty"].Value);
                        infoStockJournalDetails.Rate = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionRate"].Value);
                        infoStockJournalDetails.UnitId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionunitId"].Value);
                        infoStockJournalDetails.UnitConversionId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionunitConversionId"].Value);
                        if (btnSave.Text == "Update")
                        {
                            infoStockJournalDetails.StockJournalMasterId = decStockJournalMasterIdForEdit;
                            if (dgvProduction.Rows[i].Cells["dgvtxtProductionStockJournalDetailsId"].Value == null || dgvProduction.Rows[i].Cells["dgvtxtProductionStockJournalDetailsId"].Value.ToString() == string.Empty)
                            {

                                if (dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value != null && dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.BatchId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.BatchId = 0;
                                }
                                if (dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value != null && dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.GodownId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.GodownId = 0;
                                }
                                if (dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value != null && dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.RackId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.RackId = 0;
                                }
                                infoStockJournalDetails.Amount = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionAmount"].Value);
                                infoStockJournalDetails.ConsumptionOrProduction = "Production";
                                infoStockJournalDetails.Slno = Convert.ToInt32(dgvProduction.Rows[i].Cells["dgvtxtProductionSlNo"].Value);
                                BllStockJournal.StockJournalDetailsAdd(infoStockJournalDetails);
                            }
                            else
                            {
                                infoStockJournalDetails.StockJournalDetailsId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionStockJournalDetailsId"].Value);
                                if (dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value != null && dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.BatchId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.BatchId = 0;
                                }
                                if (dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value != null && dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.GodownId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.GodownId = 0;
                                }
                                if (dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value != null && dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value.ToString() != string.Empty)
                                {
                                    infoStockJournalDetails.RackId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value);
                                }
                                else
                                {
                                    infoStockJournalDetails.RackId = 0;
                                }
                                infoStockJournalDetails.Amount = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionAmount"].Value);
                                infoStockJournalDetails.ConsumptionOrProduction = "Production";
                                infoStockJournalDetails.Slno = Convert.ToInt32(dgvProduction.Rows[i].Cells["dgvtxtProductionSlNo"].Value);
                                BllStockJournal.StockJournalDetailsEdit(infoStockJournalDetails);
                            }
                        }
                        else
                        {
                            infoStockJournalDetails.BatchId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value);
                            infoStockJournalDetails.GodownId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value);
                            infoStockJournalDetails.RackId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value);
                            infoStockJournalDetails.Amount = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionAmount"].Value);
                            infoStockJournalDetails.ConsumptionOrProduction = "Production";
                            infoStockJournalDetails.Slno = Convert.ToInt32(dgvProduction.Rows[i].Cells["dgvtxtProductionSlNo"].Value);
                            BllStockJournal.StockJournalDetailsAdd(infoStockJournalDetails);
                        }
                        //Stock Posting Add
                        if (btnSave.Text == "Save")
                        {
                            infoStockPosting.BatchId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value);
                            infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                            infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                            infoStockPosting.GodownId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value);
                            infoStockPosting.InwardQty = infoStockJournalDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(infoStockJournalDetails.UnitConversionId);
                            infoStockPosting.OutwardQty = 0;
                            infoStockPosting.ProductId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionProductId"].Value);
                            infoStockPosting.RackId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value);
                            infoStockPosting.Rate = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionRate"].Value);
                            infoStockPosting.UnitId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvcmbProductionunitId"].Value);
                            infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.VoucherTypeId = decVoucherTypeId;
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstInvoiceNo = "NA";
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                            BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                        else
                        {
                            infoStockPosting.BatchId = infoStockJournalDetails.BatchId;
                            infoStockPosting.Date = Convert.ToDateTime(txtDate.Text);
                            infoStockPosting.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                            infoStockPosting.GodownId = infoStockJournalDetails.GodownId;
                            infoStockPosting.InwardQty = infoStockJournalDetails.Qty / bllUnitConvertion.UnitConversionRateByUnitConversionId(infoStockJournalDetails.UnitConversionId);
                            infoStockPosting.OutwardQty = 0;
                            infoStockPosting.ProductId = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionProductId"].Value);
                            infoStockPosting.RackId = infoStockJournalDetails.RackId;
                            infoStockPosting.Rate = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionRate"].Value);
                            infoStockPosting.UnitId = infoStockJournalDetails.UnitId;
                            infoStockPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                            infoStockPosting.VoucherNo = strVoucherNo;
                            infoStockPosting.VoucherTypeId = decVoucherTypeId;
                            infoStockPosting.AgainstVoucherTypeId = 0;
                            infoStockPosting.AgainstInvoiceNo = "NA";
                            infoStockPosting.AgainstVoucherNo = "NA";
                            infoStockPosting.Extra1 = string.Empty;
                            infoStockPosting.Extra2 = string.Empty;
                            BllStockPosting.StockPostingAdd(infoStockPosting);
                        }
                    }
                }
                //....Additional Cost Add...////
                if (btnSave.Text == "Update")
                {
                    BllLedgerPosting.DeleteLedgerPostingForStockJournalEdit(strVoucherNo, decVoucherTypeId);//Delete
                    bllAdditionalCost.DeleteAdditionalCostForStockJournalEdit(strVoucherNo, decVoucherTypeId);//Delete
                }
                decimal decGrandTotal = 0;
                decimal decRate = 0;
                ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                if (dgvAdditionalCost.Rows.Count > 1)
                {
                    infoAdditionalCost.Credit = Convert.ToDecimal(lblAdditionalCostAmount.Text);
                    infoAdditionalCost.Debit = 0;
                    infoAdditionalCost.LedgerId = Convert.ToDecimal(cmbCashOrBank.SelectedValue);
                    infoAdditionalCost.VoucherNo = strVoucherNo;
                    infoAdditionalCost.VoucherTypeId = decVoucherTypeId;
                    infoAdditionalCost.Extra1 = string.Empty;
                    infoAdditionalCost.Extra2 = string.Empty;
                    infoAdditionalCost.ExtraDate = DateTime.Now;
                    bllAdditionalCost.AdditionalCostAdd(infoAdditionalCost);
                    //....Ledger Posting Add...///
                    //-------------------  Currency Conversion-----------------------------
                    decGrandTotal = Convert.ToDecimal(lblAdditionalCostAmount.Text.Trim());
                    decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                    decGrandTotal = decGrandTotal * decRate;
                    //---------------------------------------------------------------
                    infoLedgerPosting.Credit = decGrandTotal;
                    infoLedgerPosting.Debit = 0;
                    infoLedgerPosting.Date = Convert.ToDateTime(PublicVariables._dtCurrentDate);
                    infoLedgerPosting.DetailsId = 0;
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                    infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrBank.SelectedValue);
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                    infoLedgerPosting.VoucherTypeId = decVoucherTypeId;
                    infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    infoLedgerPosting.ChequeDate = DateTime.Now;
                    infoLedgerPosting.ChequeNo = string.Empty;
                    infoLedgerPosting.Extra1 = string.Empty;
                    infoLedgerPosting.Extra2 = string.Empty;
                    if (btnSave.Text == "Save")
                    {
                        infoLedgerPosting.ExtraDate = DateTime.Now;
                    }
                    BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                    foreach (DataGridViewRow dgvrow in dgvAdditionalCost.Rows)
                    {
                        if (dgvrow.Cells["dgvcmbAdditionalCostLedger"].Value != null)
                        {
                            if (dgvrow.Cells["dgvcmbAdditionalCostLedger"].Value.ToString() != string.Empty)
                            {
                                /*-----------------------------------------Additional Cost Add----------------------------------------------------*/
                                infoAdditionalCost.Credit = 0;
                                infoAdditionalCost.Debit = Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCostAmount"].Value.ToString());
                                infoAdditionalCost.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvcmbAdditionalCostLedger"].Value.ToString());
                                infoAdditionalCost.VoucherNo = strVoucherNo;
                                infoAdditionalCost.VoucherTypeId = decVoucherTypeId;
                                infoAdditionalCost.Extra1 = string.Empty;
                                infoAdditionalCost.Extra2 = string.Empty;
                                infoAdditionalCost.ExtraDate = DateTime.Now;
                                bllAdditionalCost.AdditionalCostAdd(infoAdditionalCost);
                                /*-----------------------------------------Additional Cost Ledger Posting----------------------------------------------------*/
                                decimal decTotal = 0;
                                //-------------------  Currency Conversion------------------------
                                decTotal = Convert.ToDecimal(infoAdditionalCost.Debit);
                                decRate = BllExchangeRate.ExchangeRateViewByExchangeRateId(Convert.ToDecimal(cmbCurrency.SelectedValue.ToString()));
                                decTotal = decTotal * decRate;
                                //---------------------------------------------------------------
                                infoLedgerPosting.Credit = 0;
                                infoLedgerPosting.Debit = decTotal;
                                infoLedgerPosting.Date = Convert.ToDateTime(PublicVariables._dtCurrentDate);
                                infoLedgerPosting.DetailsId = 0;
                                infoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                                infoLedgerPosting.LedgerId = Convert.ToDecimal(dgvrow.Cells["dgvcmbAdditionalCostLedger"].Value.ToString());
                                infoLedgerPosting.VoucherNo = strVoucherNo;
                                infoLedgerPosting.VoucherTypeId = decVoucherTypeId;
                                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                                infoLedgerPosting.ChequeDate = DateTime.Now;
                                infoLedgerPosting.ChequeNo = string.Empty;
                                infoLedgerPosting.Extra1 = string.Empty;
                                infoLedgerPosting.Extra2 = string.Empty;
                                infoLedgerPosting.ExtraDate = DateTime.Now;
                                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                            }
                        }
                    }
                }
                if (btnSave.Text == "Save")
                {
                    Messages.SavedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        Print(decStockMasterId);
                    }
                    Clear();
                }
                else
                {
                    Messages.UpdatedMessage();
                    if (cbxPrintAfterSave.Checked)
                    {
                        Print(decStockJournalMasterIdForEdit);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:36" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// Function to remove incomplete rows from counsumption grid
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromConsumptionGrid()
        {
            SettingsBll BllSettings = new SettingsBll();
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvConsumption.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvConsumption.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.HeaderCell.Value != null)
                        {
                            if (dgvrowCur.HeaderCell.Value.ToString() == "X" || dgvrowCur.Cells["dgvtxtConsumptionProductName"].Value == null)
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
                        for (int inK = 0; inK < dgvConsumption.Rows.Count; inK++)
                        {
                            if (dgvConsumption.Rows[inK].HeaderCell.Value != null && dgvConsumption.Rows[inK].HeaderCell.Value.ToString() == "X")
                            {
                                if (!dgvConsumption.Rows[inK].IsNewRow)
                                {
                                    dgvConsumption.Rows.RemoveAt(inK);
                                    inK--;
                                    ConsumptionSerialNo();
                                }
                            }
                        }
                        for (int inK = 0; inK < dgvProduction.Rows.Count; inK++)
                        {
                            if (dgvProduction.Rows[inK].HeaderCell.Value != null && dgvProduction.Rows[inK].HeaderCell.Value.ToString() == "X")
                            {
                                if (!dgvProduction.Rows[inK].IsNewRow)
                                {
                                    dgvProduction.Rows.RemoveAt(inK);
                                    inK--;
                                    ProductionSerialNo();
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvConsumption.Rows[inForFirst].Cells["dgvtxtConsumptionProductName"].Selected = true;
                        dgvConsumption.CurrentCell = dgvConsumption.Rows[inForFirst].Cells["dgvtxtConsumptionProductName"];
                        dgvConsumption.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:37" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to remove incomplete rows from production grid
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromProductionGrid()
        {
            SettingsBll BllSettings = new SettingsBll();
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvConsumption.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvProduction.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.HeaderCell.Value != null)
                        {
                            if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvrowCur.Cells["dgvtxtProductionAmount"].Value) == 0)
                            {
                                dgvProduction.CurrentRow.HeaderCell.Value = "X";
                                dgvProduction.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;

                            }
                            if (dgvrowCur.HeaderCell.Value.ToString() == "X" || dgvrowCur.Cells["dgvtxtProductionProductName"].Value == null)
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
                        for (int inK = 0; inK < dgvProduction.Rows.Count; inK++)
                        {
                            if (dgvProduction.Rows[inK].HeaderCell.Value != null && dgvProduction.Rows[inK].HeaderCell.Value.ToString() == "X")
                            {
                                if (!dgvProduction.Rows[inK].IsNewRow)
                                {
                                    dgvProduction.Rows.RemoveAt(inK);
                                    inK--;
                                    ProductionSerialNo();
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvProduction.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:38" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// To check the status of the product
        /// </summary>
        public void QuantityStatusCheck()
        {
            try
            {

                int inRowConsumption = dgvConsumption.RowCount;
                int inRowProduction = dgvProduction.RowCount;
                if (rbtnTransfer.Checked == true)
                {
                    if (inRowConsumption - 1 == 0)
                    {
                        Messages.InformationMessage("Can't save Stock Journal without atleast one product with complete details");
                        dgvConsumption.Focus();
                        goto Exit;
                    }
                    if (inRowProduction - 1 == 0)
                    {
                        Messages.InformationMessage("Can't save Stock Journal without atleast one product with complete details");
                        dgvProduction.Focus();
                        goto Exit;
                    }
                }
                decimal decProductId = 0;
                decimal decBatchId = 0;
                decimal decCalcQty = 0;
                StockPostingBll BllStockPosting = new StockPostingBll();
                //StockPostingSP spStockPosting = new StockPostingSP();
                SettingsBll BllSettings = new SettingsBll();
                string strStatus = BllSettings.SettingsStatusCheck("NegativeStockStatus");
                bool isNegativeLedger = false;
                int inRowCount = dgvConsumption.RowCount;
                for (int i = 0; i < inRowCount - 1; i++)
                {
                    if (dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value != null && dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value.ToString() != string.Empty)
                    {
                        decProductId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value.ToString());
                        if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value != null && dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value.ToString() != string.Empty)
                        {
                            decBatchId = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value.ToString());
                        }
                        decimal decCurrentStock = BllStockPosting.StockCheckForProductSale(decProductId, decBatchId);
                        if (dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value != null && dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value.ToString() != string.Empty)
                        {
                            decCalcQty = decCurrentStock - Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value.ToString());
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
            Exit: ;
            }

            catch (Exception ex)
            {
                MessageBox.Show("SJ:39" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call save or edit function
        /// </summary>
        public void SaveOrEdit()
        {
            bool Isexit = false;
            StockJournalBll BllStockJournal = new StockJournalBll();
            try
            {
                dgvConsumption.ClearSelection();
                dgvProduction.ClearSelection();
                dgvAdditionalCost.ClearSelection();
                int inRowConsumption = dgvConsumption.RowCount;
                int inRowProduction = dgvProduction.RowCount;

                if (txtVoucherNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number");
                    txtVoucherNo.Focus();
                }
                else if (BllStockJournal.StockJournalInvoiceNumberCheckExistence(txtVoucherNo.Text.Trim(), 0, decVoucherTypeId) == true && btnSave.Text == "Save")
                {
                    Messages.InformationMessage("Invoice number already exist");
                    txtVoucherNo.Focus();
                }
                else if (txtDate.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Select a date in between financial year");
                    txtDate.Focus();
                }
                else if (cmbCurrency.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select any currency");
                    cmbCurrency.Focus();
                }
                else
                {
                    if (rbtnManufacturing.Checked)
                    {
                        if (inRowConsumption - 1 == 0)
                        {
                            Messages.InformationMessage("Can't save Stock Journal without atleast one product with complete details");
                            dgvConsumption.Focus();
                            goto Exit;
                        }
                        if (inRowProduction - 1 == 0)
                        {
                            Messages.InformationMessage("Can't save Stock Journal without atleast one product with complete details");
                            dgvProduction.Focus();
                            goto Exit;
                        }

                    }
                    if (rbtnTransfer.Checked)
                    {
                        int indgvRowsConsumption = dgvConsumption.Rows.Count;
                        int indgvRowsProduction = dgvProduction.Rows.Count;

                        if (inRowConsumption - 1 == 0)
                        {
                            Messages.InformationMessage("Can't save Stock Journal without atleast one product with complete details");
                            dgvConsumption.Focus();
                            goto Exit;
                        }
                        if (inRowProduction - 1 == 0)
                        {
                            Messages.InformationMessage("Can't save Stock Journal without atleast one product with complete details");
                            dgvProduction.Focus();
                            goto Exit;
                        }
                        if (indgvRowsConsumption != indgvRowsProduction)
                        {
                            Messages.InformationMessage("Please Tranfer the details");
                            goto Exit;
                        }
                        for (int i = 0; i < dgvProduction.Rows.Count - 1; i++)
                        {
                            decimal dcConsumption = 0;
                            decimal dcProduction = 0;
                            dcConsumption = Convert.ToDecimal(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value);
                            dcProduction = Convert.ToDecimal(dgvProduction.Rows[i].Cells["dgvtxtProductionQty"].Value);
                            if (dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value == null || dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value.ToString() == "1")
                            {

                                Messages.InformationMessage("Rows Contains Invalid entries please fill the Godown Details");
                                goto Exit;
                            }
                            if (dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value.ToString() == dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value.ToString())
                            {
                                Messages.InformationMessage(" The Godown should be different");
                                dgvProduction.Focus();
                                Isexit = true;
                                break;
                            }
                            if (dcConsumption != dcProduction)
                            {

                                Messages.InformationMessage("The Quantity Should be Same");
                                goto Exit;
                            }

                        }
                    }
                    if (rbtnStockOut.Checked)
                    {
                        if (inRowConsumption - 1 == 0)
                        {
                            Messages.InformationMessage("Can't save Stock Journal without atleast one product with complete details");
                            dgvConsumption.Focus();

                            goto Exit;
                        }
                    }
                    if (!Isexit)
                    {
                        if (RemoveIncompleteRowsFromConsumptionGrid())
                        {
                            if (!rbtnStockOut.Checked)
                            {
                                if (RemoveIncompleteRowsFromProductionGrid())
                                {
                                    if (dgvConsumption.Rows[0].Cells["dgvtxtConsumptionProductName"].Value == null && dgvConsumption.Rows[0].Cells["dgvtxtConsumptionQty"].Value == null || dgvProduction.Rows[0].Cells["dgvtxtProductionProductName"].Value == null && dgvProduction.Rows[0].Cells["dgvtxtProductionQty"].Value == null)
                                    {
                                        MessageBox.Show("Can't save Stock Journal without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvConsumption.ClearSelection();
                                        dgvConsumption.Focus();
                                        goto Exit;
                                    }
                                    else
                                    {
                                        if (btnSave.Text == "Save")
                                        {

                                            if (Messages.SaveConfirmation())
                                            {
                                                grandTotalAmountCalculationConsumption();
                                                grandTotalAmountCalculationProduction();
                                                Save();
                                            }

                                        }
                                        if (btnSave.Text == "Update")
                                        {
                                            if (Messages.UpdateConfirmation())
                                            {
                                                grandTotalAmountCalculationConsumption();
                                                grandTotalAmountCalculationProduction();
                                                Save();
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (dgvConsumption.Rows[0].Cells["dgvtxtConsumptionProductName"].Value == null || dgvConsumption.Rows[0].Cells["dgvtxtConsumptionProductName"].Value.ToString() == string.Empty && dgvConsumption.Rows[0].Cells["dgvtxtConsumptionQty"].Value == null)
                                {
                                    MessageBox.Show("Can't save Stock Journals without atleast one product with complete details", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dgvConsumption.ClearSelection();
                                    dgvConsumption.Focus();
                                    goto Exit;
                                }
                                if (btnSave.Text == "Save")
                                {
                                    if (Messages.SaveConfirmation())
                                    {
                                        grandTotalAmountCalculationConsumption();
                                        Save();
                                    }
                                }
                                if (btnSave.Text == "Update")
                                {
                                    if (Messages.UpdateConfirmation())
                                    {
                                        grandTotalAmountCalculationConsumption();
                                        Save();

                                    }
                                }

                            }
                        }
                    }
                }

            Exit: ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:40" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check invalid entries in consumption grid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntriesConsumption(DataGridViewCellEventArgs e)
        {
            SettingsBll BllSettings = new SettingsBll();
            try
            {
                if (dgvConsumption.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductName"].Value == null || dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductName"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvConsumption.CurrentRow.HeaderCell.Value = "X";
                            dgvConsumption.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionQty"].Value == null || dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionQty"].Value.ToString().Trim() == string.Empty || Convert.ToDecimal(dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionQty"].Value) == 0)
                        {
                            isValueChanged = true;
                            dgvConsumption.CurrentRow.HeaderCell.Value = "X";
                            dgvConsumption.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionRate"].Value) == 0)
                        {

                            dgvConsumption.CurrentRow.HeaderCell.Value = "X";
                            dgvConsumption.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;

                        }
                        else
                        {
                            isValueChanged = true;
                            dgvConsumption.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:41" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check invalid entries in production grid
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntriesProduction(DataGridViewCellEventArgs e)
        {
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                if (dgvProduction.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvProduction.CurrentRow.Cells["dgvtxtProductionProductName"].Value == null || dgvProduction.CurrentRow.Cells["dgvtxtProductionProductName"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvProduction.CurrentRow.HeaderCell.Value = "X";
                            dgvProduction.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvProduction.CurrentRow.Cells["dgvtxtProductionQty"].Value == null || dgvProduction.CurrentRow.Cells["dgvtxtProductionQty"].Value.ToString().Trim() == string.Empty || Convert.ToDecimal(dgvProduction.CurrentRow.Cells["dgvtxtProductionQty"].Value) == 0)
                        {
                            isValueChanged = true;
                            dgvProduction.CurrentRow.HeaderCell.Value = "X";
                            dgvProduction.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }

                        else if (BllSettings.SettingsStatusCheck("AllowZeroValueEntry") == "No" && Convert.ToDecimal(dgvProduction.CurrentRow.Cells["dgvtxtProductionRate"].Value) == 0)
                        {

                            dgvProduction.CurrentRow.HeaderCell.Value = "X";
                            dgvProduction.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvProduction.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:42" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmStockJournelReport to view details and for updation 
        /// </summary>
        /// <param name="frmStockJournelReportObj"></param>
        /// <param name="decStockJournalMasterId"></param>
        public void CallFromStockJournalReport(frmStockJournelReport frmStockJournelReportObj, decimal decStockJournalMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                this.frmStockJournelReportObj = frmStockJournelReportObj;
                decStockJournalMasterIdForEdit = decStockJournalMasterId;
                frmStockJournelReportObj.Enabled = false;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:43" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for auto completion of products
        /// </summary>
        public void AutoCompleteProducts()
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
                MessageBox.Show("SJ:44" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate total consumption amount
        /// </summary>
        public void TotalConsumptionAmount()
        {
            decimal decTotal = 0;
            try
            {
                foreach (DataGridViewRow dgvrow in dgvConsumption.Rows)
                {
                    decTotal += Convert.ToDecimal(dgvrow.Cells["dgvtxtConsumptionAmount"].Value);
                    lblConsumptionAmount.Text = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:45" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for total production amount
        /// </summary>
        public void TotalProductionAmount()
        {
            decimal decTotal = 0;
            try
            {
                foreach (DataGridViewRow dgvrow in dgvProduction.Rows)
                {
                    decTotal += Convert.ToDecimal(dgvrow.Cells["dgvtxtProductionAmount"].Value);
                    lblProductionAmount.Text = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:46" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for total additional cost amount
        /// </summary>
        public void TotalAdditionalCostAmount()
        {
            decimal decTotal = 0.00m;
            try
            {
                foreach (DataGridViewRow dgvrow in dgvAdditionalCost.Rows)
                {
                    decTotal += Convert.ToDecimal(dgvrow.Cells["dgvtxtAdditionalCostAmount"].Value);
                    lblAdditionalCostAmount.Text = Math.Round(decTotal, PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:47" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for voucher date
        /// </summary>
        public void VoucherDate()
        {
            try
            {
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
                CompanyInfo infoComapany = new CompanyInfo();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                infoComapany = bllCompanyCreation.CompanyView(1);
                DateTime dtVoucherDate = infoComapany.CurrentDate;
                dtpDate.Value = dtVoucherDate;
                txtDate.Text = dtVoucherDate.ToString("dd-MMM-yyyy");
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                txtDate.Focus();
                txtDate.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:48" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmStockJournalRegister to view details and for updation 
        /// </summary>
        /// <param name="frmStockJournalRegisterObj"></param>
        /// <param name="decStockJournalMasterId"></param>
        public void CallFromStockJournalRegister(frmStockJournalRegister frmStockJournalRegisterObj, decimal decStockJournalMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                this.frmStockJournalRegisterObj = frmStockJournalRegisterObj;
                decStockJournalMasterIdForEdit = decStockJournalMasterId;
                frmStockJournalRegisterObj.Enabled = false;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:49" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the details while calling from register or report 
        /// </summary>
        public void FillRegisterOrReport()
        {

            StockJournalBll BllStockJournal = new StockJournalBll();
            StockJournalMasterInfo infoStockJournalMaster = new StockJournalMasterInfo();
            StockJournalDetailsInfo infoStockJournalDetails = new StockJournalDetailsInfo();
            AditionalCostBll bllAdditionalCost = new AditionalCostBll();
            VoucherTypeBll BllVoucherType = new VoucherTypeBll();
            try
            {

                isFillMode = true;
                btnSave.Text = "Update";
                cmbFinishedGoods.Enabled = false;
                txtQty.Enabled = false;
                btnAdd.Enabled = false;
                dgvConsumption.Rows.Clear();
                dgvProduction.Rows.Clear();
                dgvAdditionalCost.Rows.Clear();
                List<DataTable> listObjMaster = BllStockJournal.StockJournalMasterFillForRegisterOrReport(decStockJournalMasterIdForEdit);
                StockJournalVoucherTypeId = Convert.ToDecimal(listObjMaster[0].Rows[0]["voucherTypeId"].ToString());
                VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
                infoVoucherType = BllVoucherType.VoucherTypeView(StockJournalVoucherTypeId);
                this.Text = infoVoucherType.VoucherTypeName;
                txtDate.Text = listObjMaster[0].Rows[0]["date"].ToString();
                strVoucherNo = listObjMaster[0].Rows[0]["voucherNo"].ToString();
                decSuffixPrefixId = Convert.ToDecimal(listObjMaster[0].Rows[0]["suffixPrefixId"].ToString());
                decVoucherTypeId = Convert.ToDecimal(listObjMaster[0].Rows[0]["voucherTypeId"].ToString());
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(StockJournalVoucherTypeId);
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                txtNarration.Text = listObjMaster[0].Rows[0]["narration"].ToString();
                cmbCurrency.SelectedValue = Convert.ToDecimal(listObjMaster[0].Rows[0]["exchangeRateId"].ToString());

                if (listObjMaster[0].Rows[0]["extra1"].ToString() == "Manufacturing")
                {
                    rbtnManufacturing.Checked = true;
                }
                if (listObjMaster[0].Rows[0]["extra1"].ToString() == "Transfer")
                {
                    rbtnTransfer.Checked = true;
                }
                if (listObjMaster[0].Rows[0]["extra1"].ToString() == "Stock Out")
                {
                    rbtnStockOut.Checked = true;
                }
                txtVoucherNo.Text = listObjMaster[0].Rows[0]["invoiceNo"].ToString();

                DataSet dsDetails = BllStockJournal.StockJournalDetailsForRegisterOrReport(decStockJournalMasterIdForEdit);

                DataTable dtblConsumption = dsDetails.Tables[0];
                if (dsDetails.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dtblConsumption.Rows.Count; i++)
                    {
                        dgvConsumption.Rows.Add();
                        dgvConsumption.Rows[i].HeaderCell.Value = string.Empty;
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value = Convert.ToDecimal(dtblConsumption.Rows[i]["stockJournalDetailsId"].ToString());
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionSlNo"].Value = dtblConsumption.Rows[i]["slno"].ToString();
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionBarcode"].Value = dtblConsumption.Rows[i]["barcode"].ToString();
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].Value = dtblConsumption.Rows[i]["productCode"].ToString();
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductName"].Value = dtblConsumption.Rows[i]["productName"].ToString();
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value = dtblConsumption.Rows[i]["productId"].ToString();
                        IsSetGridValueChange = true;
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value = dtblConsumption.Rows[i]["qty"].ToString();
                        IsSetGridValueChange = false;
                        dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value = Convert.ToDecimal(dtblConsumption.Rows[i]["godownId"].ToString());
                        dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value = Convert.ToDecimal(dtblConsumption.Rows[i]["rackId"].ToString());
                        if (dtblConsumption.Rows[i]["batchId"] != null && dtblConsumption.Rows[i]["batchId"].ToString() != "0")
                        {
                            dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value = Convert.ToDecimal(dtblConsumption.Rows[i]["batchId"].ToString());
                        }
                        else
                        {
                            dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value = string.Empty;
                        }
                        IsSetGridValueChange = true;
                        dgvConsumption.Rows[i].Cells["dgvcmbConsumptionunitId"].Value = Convert.ToDecimal(dtblConsumption.Rows[i]["unitId"].ToString());
                        IsSetGridValueChange = false;
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionUnitConversionId"].Value = dtblConsumption.Rows[i]["unitConversionId"].ToString();
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionBarcode"].ReadOnly = true;
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].ReadOnly = true;
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductName"].ReadOnly = true;
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionRate"].Value = dtblConsumption.Rows[i]["rate"].ToString();
                        dgvConsumption.Rows[i].Cells["dgvtxtConsumptionAmount"].Value = dtblConsumption.Rows[i]["amount"].ToString();
                        dgvConsumption.Rows[i].HeaderCell.Value = "";
                    }
                }
                DataTable dtblProduction = dsDetails.Tables[1];
                for (int i = 0; i < dtblProduction.Rows.Count; i++)
                {
                    dgvProduction.Rows.Add();
                    dgvProduction.Rows[i].HeaderCell.Value = string.Empty;
                    dgvProduction.Rows[i].Cells["dgvtxtProductionStockJournalDetailsId"].Value = Convert.ToDecimal(dtblProduction.Rows[i]["stockJournalDetailsId"].ToString());
                    dgvProduction.Rows[i].Cells["dgvtxtProductionSlNo"].Value = dtblProduction.Rows[i]["slno"].ToString();
                    dgvProduction.Rows[i].Cells["dgvtxtProductionBarcode"].Value = dtblProduction.Rows[i]["barcode"].ToString();
                    dgvProduction.Rows[i].Cells["dgvtxtProductionProductCode"].Value = dtblProduction.Rows[i]["productCode"].ToString();
                    dgvProduction.Rows[i].Cells["dgvtxtProductionProductName"].Value = dtblProduction.Rows[i]["productName"].ToString();
                    dgvProduction.Rows[i].Cells["dgvtxtProductionProductId"].Value = dtblProduction.Rows[i]["productId"].ToString();
                    IsSetGridValueChange = true;
                    dgvProduction.Rows[i].Cells["dgvtxtProductionQty"].Value = dtblProduction.Rows[i]["qty"].ToString();
                    IsSetGridValueChange = false;
                    if (rbtnManufacturing.Checked)
                    {
                        cmbFinishedGoods.SelectedValue = dgvProduction.Rows[i].Cells["dgvtxtProductionProductId"].Value;
                        if (cmbFinishedGoods.SelectedValue != null)
                        {
                            cmbFinishedGoods.Enabled = true;
                            txtQty.Enabled = true;
                            btnAdd.Enabled = true;
                            txtQty.Text = dtblProduction.Rows[i]["qty"].ToString();
                        }

                    }
                    dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value = Convert.ToDecimal(dtblProduction.Rows[i]["godownId"].ToString());
                    dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value = Convert.ToDecimal(dtblProduction.Rows[i]["rackId"].ToString());
                    if (dtblProduction.Rows[i]["batchId"] != null && dtblProduction.Rows[i]["batchId"].ToString() != string.Empty)
                    {
                        dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value = Convert.ToDecimal(dtblProduction.Rows[i]["batchId"].ToString());
                    }
                    else
                    {
                        dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value = string.Empty;
                    }
                    IsSetGridValueChange = true;
                    dgvProduction.Rows[i].Cells["dgvcmbProductionunitId"].Value = Convert.ToDecimal(dtblProduction.Rows[i]["unitId"].ToString());
                    IsSetGridValueChange = false;
                    dgvProduction.Rows[i].Cells["dgvtxtProductionUnitConversionId"].Value = dtblProduction.Rows[i]["unitConversionId"].ToString();
                    dgvProduction.Rows[i].Cells["dgvtxtProductionBarcode"].ReadOnly = true;
                    dgvProduction.Rows[i].Cells["dgvtxtProductionProductCode"].ReadOnly = true;
                    dgvProduction.Rows[i].Cells["dgvtxtProductionProductName"].ReadOnly = true;
                    dgvProduction.Rows[i].Cells["dgvtxtProductionRate"].Value = dtblProduction.Rows[i]["rate"].ToString();
                    dgvProduction.Rows[i].Cells["dgvtxtProductionAmount"].Value = dtblProduction.Rows[i]["amount"].ToString();

                }
                DataSet dsAdditionalCost = bllAdditionalCost.StockJournalAdditionalCostForRegisteOrReport(strVoucherNo, decVoucherTypeId);
                if (dsAdditionalCost.Tables[0].Rows.Count > 0)
                {
                    DataTable dtblCashOrBank = dsAdditionalCost.Tables[0];
                    cmbCashOrBank.SelectedValue = Convert.ToDecimal(dtblCashOrBank.Rows[0]["ledgerId"]);
                }
                if (dsAdditionalCost.Tables[1].Rows.Count > 0)
                {
                    DataTable dtblIndirectExpenses = dsAdditionalCost.Tables[1];

                    int inRowIndexAdditional = 0;
                    for (int i = 0; i < dtblIndirectExpenses.Rows.Count; i++)
                    {
                        dgvAdditionalCost.Rows.Add();
                        dgvAdditionalCost.Rows[i].HeaderCell.Value = string.Empty;
                        dgvAdditionalCost.Rows[i].Cells["dgvtxtAdditionalCostSlNo"].Value = ++inRowIndexAdditional;

                        dgvAdditionalCost.Rows[i].Cells["dgvcmbAdditionalCostLedger"].Value = Convert.ToDecimal(dtblIndirectExpenses.Rows[i]["ledgerId"].ToString());
                        dgvAdditionalCost.Rows[i].Cells["dgvtxtAdditionalCostAmount"].Value = dtblIndirectExpenses.Rows[i]["debit"].ToString();
                    }
                }
                grandTotalAmountCalculationConsumption();
                grandTotalAmountCalculationProduction();
                TotalAdditionalCostAmount();
                btnDelete.Enabled = true;
                if (isAutomatic)
                {
                    txtVoucherNo.ReadOnly = true;
                }
                else
                {
                    txtVoucherNo.ReadOnly = false;
                }
                gbxTransactionType.Enabled = false;
                isFillMode = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:50" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill currency combobox
        /// </summary>
        public void CurrencyComboFill()
        {
            SettingsBll BllSettings = new SettingsBll();
            TransactionsGeneralFillBll TransactionGeneralFillObj = new TransactionsGeneralFillBll();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = TransactionGeneralFillObj.CurrencyComboByDate(dtpDate.Value);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:51" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDayBook to view details and for updation 
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void CallFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                IsSetGridValueChange = false;
                base.Show();
                frmDayBook.Enabled = false;
                this.frmDayBookObj = frmDayBook;
                decStockJournalMasterIdForEdit = decMasterId;
                frmDayBook.Enabled = false;
                FillRegisterOrReport();
                IsSetGridValueChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:52" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print stock journal
        /// </summary>
        /// <param name="decMasterId"></param>
        public void Print(decimal decMasterId)
        {
            StockJournalBll BllStockJournal = new StockJournalBll();
            try
            {
                DataSet dsStockJournal = BllStockJournal.StockJournalPrinting(decMasterId);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.StockJournalPrinting(dsStockJournal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ: 53" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the print after save settings status
        /// </summary>
        /// <returns></returns>
        public bool PrintAfetrSave()
        {
            TransactionsGeneralFillBll TransactionsGeneralFillObj = new TransactionsGeneralFillBll();
            bool isTick = false;
            try
            {
                isTick = TransactionsGeneralFillObj.StatusOfPrintAfterSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:54" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        #endregion
        #region Events
        /// <summary>
        /// On checked changed of rbtnManufacturing clears the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnManufacturing_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnManufacturing.Checked)
                {
                    Clear();
                    //cmbCurrency.SelectedIndex = 0;
                    cmbCashOrBank.SelectedIndex = 0;
                    cmbFinishedGoods.SelectedIndex = 0;
                    gbxManufacturing.Enabled = true;
                    dgvProduction.Enabled = true;
                    btnTransfer.Visible = false;
                    ConsumptionReadOnlyfunction();
                    dgvConsumption.Enabled = true;
                    dgvProduction.Enabled = true;
                    cmbCashOrBank.Enabled = true;
                    dgvAdditionalCost.Enabled = true;
                    lblProduction.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:55" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of rbtnTransfer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnTransfer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnTransfer.Checked)
                {
                    //   Clear();
                    //cmbCurrency.SelectedIndex = 0;
                    cmbCashOrBank.SelectedIndex = 0;
                    cmbFinishedGoods.SelectedIndex = 0;
                    gbxManufacturing.Enabled = false;
                    dgvConsumption.Enabled = true;
                    dgvProduction.Enabled = false;
                    btnTransfer.Visible = true;
                    cmbCashOrBank.Enabled = true;
                    dgvAdditionalCost.Enabled = true;
                    lblProduction.Enabled = true;
                    dgvProduction.Rows.Clear();
                    lblProductionAmount.Text = string.Empty;
                    dgvConsumption.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:56" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of rbtnStockOut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnStockOut_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnStockOut.Checked)
                {
                    //cmbCurrency.SelectedIndex = 0;
                    cmbCashOrBank.SelectedIndex = 0;
                    cmbFinishedGoods.SelectedIndex = 0;
                    gbxManufacturing.Enabled = false;
                    dgvConsumption.Enabled = true;
                    dgvProduction.Enabled = false;
                    cmbCashOrBank.Enabled = false;
                    btnTransfer.Visible = false;
                    dgvAdditionalCost.Enabled = false;
                    lblProduction.Enabled = false;
                    dgvProduction.Rows.Clear();
                    dgvConsumption.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:57" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStockJournal_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                FormDefaultSettings();
                AutoCompleteProducts();
                StockJournalSettingsCheck();
                cmbCashOrBank.SelectedIndex = 0;
                if (txtVoucherNo.Enabled == true)
                {
                    txtVoucherNo.Focus();
                }
                else
                {
                    txtDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:58" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbFinishedGoods.SelectedIndex > 0)
                {
                    if (txtQty.Text != string.Empty)
                    {
                        if (Convert.ToDecimal(txtQty.Text.ToString()) != 0)
                        {
                            isFillMode = true;
                            if (btnSave.Text == "Update")
                            {
                                for (int i = 0; i < dgvConsumption.Rows.Count - 1; i++)
                                {
                                    if (dgvConsumption.Rows[i].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value != null && dgvConsumption.Rows[i].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value.ToString() != string.Empty)
                                    {
                                        ArrlstOfConsumtionRemove.Add(dgvConsumption.Rows[i].Cells["dgvtxtConsumptionStockJournalDetailsId"].Value.ToString());
                                    }
                                }
                                for (int j = 0; j < dgvProduction.Rows.Count - 1; j++)
                                {
                                    if (dgvProduction.Rows[j].Cells["dgvtxtProductionStockJournalDetailsId"].Value != null && dgvProduction.Rows[j].Cells["dgvtxtProductionStockJournalDetailsId"].Value.ToString() != string.Empty)
                                    {
                                        ArrlstOfProductionRemove.Add(dgvProduction.Rows[j].Cells["dgvtxtProductionStockJournalDetailsId"].Value.ToString());
                                    }
                                }
                            }

                            dgvConsumption.Rows.Clear();
                            dgvProduction.Rows.Clear();
                            List<DataTable> listObjRawMaterials = BllProductCreation.RawMaterialsFillForStockJournal(Convert.ToDecimal(cmbFinishedGoods.SelectedValue), Convert.ToDecimal(txtQty.Text));
                            for (int i = 0; i < listObjRawMaterials[0].Rows.Count; i++)
                            {
                                dgvConsumption.Rows.Add();
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionBarcode"].Value = listObjRawMaterials[0].Rows[i]["barcode"].ToString();
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].Value = listObjRawMaterials[0].Rows[i]["productCode"].ToString();
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value = listObjRawMaterials[0].Rows[i]["productId"].ToString();
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductName"].Value = listObjRawMaterials[0].Rows[i]["productName"].ToString();
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value = listObjRawMaterials[0].Rows[i]["Qty"].ToString();
                                dgvConsumption.Rows[i].Cells["dgvcmbConsumptionRack"].Value = Convert.ToDecimal(listObjRawMaterials[0].Rows[i]["rackId"]);
                                dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value = Convert.ToDecimal(listObjRawMaterials[0].Rows[i]["godownId"].ToString());
                                dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value = Convert.ToDecimal(listObjRawMaterials[0].Rows[i]["batchId"].ToString());
                                dgvConsumption.Rows[i].Cells["dgvcmbConsumptionunitId"].Value = Convert.ToDecimal(listObjRawMaterials[0].Rows[i]["unitId"].ToString());
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionunitConversionId"].Value = Convert.ToDecimal(listObjRawMaterials[0].Rows[i]["unitConversionId"].ToString());
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionAmount"].Value = Math.Round((Convert.ToDecimal(listObjRawMaterials[0].Rows[i]["Qty"].ToString())) * (Convert.ToDecimal(listObjRawMaterials[0].Rows[i]["salesRate"].ToString())), PublicVariables._inNoOfDecimalPlaces);
                                dgvConsumption.Rows[i].Cells["dgvtxtConsumptionRate"].Value = listObjRawMaterials[0].Rows[i]["salesRate"].ToString();
                            }

                            List<DataTable> listObjFinishedGoods = BllProductCreation.FinishedGoodsFillForStockJournal(Convert.ToDecimal(cmbFinishedGoods.SelectedValue), Convert.ToDecimal(txtQty.Text));
                            for (int i = 0; i < listObjFinishedGoods[0].Rows.Count; i++)
                            {
                                dgvProduction.Rows.Add();
                                dgvProduction.Rows[i].Cells["dgvtxtProductionBarcode"].Value = listObjFinishedGoods[0].Rows[i]["barcode"].ToString();
                                dgvProduction.Rows[i].Cells["dgvtxtProductionProductCode"].Value = listObjFinishedGoods[0].Rows[i]["productCode"].ToString();
                                dgvProduction.Rows[i].Cells["dgvtxtProductionProductId"].Value = listObjFinishedGoods[0].Rows[i]["productId"].ToString();
                                dgvProduction.Rows[i].Cells["dgvtxtProductionProductName"].Value = listObjFinishedGoods[0].Rows[i]["productName"].ToString();
                                dgvProduction.Rows[i].Cells["dgvtxtProductionQty"].Value = listObjFinishedGoods[0].Rows[i]["Qty"].ToString();
                                dgvProduction.Rows[i].Cells["dgvcmbProductionRack"].Value = Convert.ToDecimal(listObjFinishedGoods[0].Rows[i]["rackId"]);
                                dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value = Convert.ToDecimal(listObjFinishedGoods[0].Rows[i]["godownId"].ToString());
                                dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value = Convert.ToDecimal(listObjFinishedGoods[0].Rows[i]["batchId"].ToString());
                                dgvProduction.Rows[i].Cells["dgvcmbProductionunitId"].Value = Convert.ToDecimal(listObjFinishedGoods[0].Rows[i]["unitId"].ToString());
                                dgvProduction.Rows[i].Cells["dgvtxtProductionunitConversionId"].Value = Convert.ToDecimal(listObjFinishedGoods[0].Rows[i]["unitConversionId"].ToString());
                                dgvProduction.Rows[i].Cells["dgvtxtProductionAmount"].Value = Math.Round((Convert.ToDecimal(listObjFinishedGoods[0].Rows[i]["Qty"].ToString())) * (Convert.ToDecimal(listObjFinishedGoods[0].Rows[i]["salesRate"].ToString())), PublicVariables._inNoOfDecimalPlaces);
                                dgvProduction.Rows[i].Cells["dgvtxtProductionRate"].Value = listObjFinishedGoods[0].Rows[i]["salesRate"].ToString();
                            }
                            ConsumptionSerialNo();
                            ProductionSerialNo();
                            grandTotalAmountCalculationConsumption();
                            grandTotalAmountCalculationProduction();
                            isFillMode = false;
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Enter the quantity");
                        txtQty.Focus();
                    }
                }
                else
                {
                    Messages.InformationMessage("Select any product");
                    cmbFinishedGoods.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("SJ:59" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// On save button click, calls save or edit function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    if (rbtnStockOut.Checked == true || rbtnTransfer.Checked == true)
                    {
                        QuantityStatusCheck();
                    }
                    else
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
                MessageBox.Show("SJ:60" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// generate serialNo while rows added of dgvAdditionalCost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdditionalCost_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (!isFillMode)
                {
                    AdditionalCostSerialNo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:61" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// generate serialNo while rows added of dgvConsumption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (!isFillMode)
                {
                    ConsumptionSerialNo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:62" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// generate serialNo while rows added of dgvProduction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (!isFillMode)
                {
                    ProductionSerialNo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:63" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtDate, validates date
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
                MessageBox.Show("SJ:64" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SJ:65" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCellEditControlKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvConsumption.CurrentCell != null)
                {
                    if (dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionQty" || dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionRate" || dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionAmount")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
                if (dgvProduction.CurrentCell != null)
                {
                    if (dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionQty" || dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionRate" || dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionAmount")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SI: 66" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For decimal validation
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
                MessageBox.Show("SI: 67" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On keypress event
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
                MessageBox.Show("SI: 68" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid EditingControlShowing event To handle the keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
            try
            {
                if (TextBoxControl != null)
                {

                    if (dgvConsumption.CurrentCell != null && dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;

                    }
                    if (dgvConsumption.CurrentCell != null && dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;

                    }
                    if (dgvConsumption.CurrentCell != null && dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name != "dgvtxtConsumptionProductCode" && dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name != "dgvtxtConsumptionProductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvConsumption.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }

                    TextBoxControl.KeyPress += TextBoxCellEditControlKeyPress;

                    if (dgvConsumption.CurrentCell.ColumnIndex == dgvConsumption.Columns["dgvtxtConsumptionQty"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvConsumption.CurrentCell.ColumnIndex == dgvConsumption.Columns["dgvtxtConsumptionRate"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvConsumption.CurrentCell.ColumnIndex == dgvConsumption.Columns["dgvtxtConsumptionAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else
                    {
                        TextBoxControl.KeyPress += keypresseventforOther;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:69" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// grid EditingControlShowing event To handle the keypress event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
            try
            {
                if (TextBoxControl != null)
                {

                    if (dgvProduction.CurrentCell != null && dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionProductName")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductNames;

                    }
                    if (dgvProduction.CurrentCell != null && dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionProductCode")
                    {
                        TextBoxControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        TextBoxControl.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        TextBoxControl.AutoCompleteCustomSource = ProductCodes;

                    }
                    if (dgvProduction.CurrentCell != null && dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name != "dgvtxtProductionProductCode" && dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name != "dgvtxtProductionProductName")
                    {
                        DataGridViewTextBoxEditingControl editControl = (DataGridViewTextBoxEditingControl)dgvProduction.EditingControl;
                        editControl.AutoCompleteMode = AutoCompleteMode.None;
                    }
                    if (dgvProduction.CurrentCell.ColumnIndex == dgvProduction.Columns["dgvtxtProductionQty"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvProduction.CurrentCell.ColumnIndex == dgvProduction.Columns["dgvtxtProductionRate"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else if (dgvProduction.CurrentCell.ColumnIndex == dgvProduction.Columns["dgvtxtProductionAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else
                    {
                        TextBoxControl.KeyPress += keypresseventforOther;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:70" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Handling dataerror
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvConsumption.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvConsumption.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("SJ:71" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Handling data error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvProduction.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvProduction.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("SJ:72" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Handling data error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdditionalCost_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvAdditionalCost.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvAdditionalCost.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("SJ:73" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// make each and every changes of grid has to be commited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsumption.IsCurrentCellDirty)
                {
                    dgvConsumption.CommitEdit(DataGridViewDataErrorContexts.Commit);

                }

                grandTotalAmountCalculationConsumption();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:74" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// make each and every changes of grid has to be commited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgvProduction.IsCurrentCellDirty)
                {
                    dgvProduction.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }

                grandTotalAmountCalculationProduction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:75" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// make each and every changes of grid has to be commited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdditionalCost_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdditionalCost.IsCurrentCellDirty)
                {
                    dgvAdditionalCost.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
                TotalAdditionalCostAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:76" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// dgvAdditionalCost grid cellbeginedit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdditionalCost_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
                if (dgvAdditionalCost.CurrentCell.ColumnIndex == dgvAdditionalCost.Columns["dgvcmbAdditionalCostLedger"].Index)
                {
                    ListObj = bllAccountLedger.AdditionalCostGet();
                    if (ListObj[0].Rows.Count > 0)
                    {
                        if (dgvAdditionalCost.RowCount > 1)
                        {
                            int inGridRowCount = dgvAdditionalCost.RowCount;
                            for (int inI = 0; inI < inGridRowCount - 1; inI++)
                            {
                                if (inI != e.RowIndex)
                                {
                                    int inTableRowcount = ListObj[0].Rows.Count;
                                    for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                    {
                                        if (dgvAdditionalCost.Rows[inI].Cells["dgvcmbAdditionalCostLedger"].Value != null && dgvAdditionalCost.Rows[inI].Cells["dgvcmbAdditionalCostLedger"].Value.ToString() != string.Empty)
                                        {
                                            if (ListObj[0].Rows[inJ]["ledgerId"].ToString() == dgvAdditionalCost.Rows[inI].Cells["dgvcmbAdditionalCostLedger"].Value.ToString())
                                            {
                                                ListObj[0].Rows.RemoveAt(inJ);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        DataGridViewComboBoxCell dgvcmbLedger = (DataGridViewComboBoxCell)dgvAdditionalCost[dgvAdditionalCost.Columns["dgvcmbAdditionalCostLedger"].Index, e.RowIndex];
                        dgvcmbLedger.DataSource = ListObj[0];
                        dgvcmbLedger.ValueMember = "ledgerId";
                        dgvcmbLedger.DisplayMember = "ledgerName";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:77" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// on clear button click, clears the field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();

                cmbCashOrBank.SelectedIndex = 0;
                cmbFinishedGoods.SelectedIndex = 0;
                btnTransfer.Enabled = false;
                if (decStockJournalMasterIdForEdit != 0)
                {
                    if (frmStockJournalRegisterObj != null)
                    {

                        frmStockJournalRegisterObj.Close();
                        frmStockJournalRegisterObj = null;
                    }
                    if (frmStockJournelReportObj != null)
                    {

                        frmStockJournelReportObj.Close();
                        frmStockJournelReportObj = null;
                    }
                    if (objVoucherSearch != null)
                    {
                        objVoucherSearch.Close();
                        objVoucherSearch = null;
                    }
                    if (frmDayBookObj != null)
                    {
                        frmDayBookObj.Close();
                        frmDayBookObj = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:78" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Esc for escape
        /// ctrl+s for save
        /// ctrl+d for delete
        /// /// alt+c for product creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStockJournal_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
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
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)     //Product Creation
                {
                    if (IsdgvConsuption)
                    {
                        if (dgvConsumption.CurrentCell != null)
                        {
                            if (dgvConsumption.CurrentCell == dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductName"] || dgvConsumption.CurrentCell == dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductCode"])
                            {

                                SendKeys.Send("{F10}");
                                if (dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionProductName" || dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionProductCode")
                                {
                                    frmProductCreation frmProductCreationObj = new frmProductCreation();
                                    frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                    frmProductCreationObj.CallFromStockJournal(this);

                                }
                            }
                        }
                    }
                    else
                    {

                        if (dgvProduction.CurrentCell != null)
                        {
                            if (dgvProduction.CurrentCell == dgvProduction.CurrentRow.Cells["dgvtxtProductionProductName"] || dgvProduction.CurrentCell == dgvProduction.CurrentRow.Cells["dgvtxtProductionProductCode"])
                            {

                                SendKeys.Send("{F10}");
                                if (dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionProductName" || dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionProductCode")
                                {
                                    frmProductCreation frmProductCreationObj = new frmProductCreation();
                                    frmProductCreationObj.MdiParent = formMDI.MDIObj;
                                    frmProductCreationObj.CallFromStockJournal(this);

                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:79" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// dgvConsumption grid cell valuechange event to calculate the basic functions and calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (IsSetGridValueChange)
                {
                    if (e.RowIndex != -1 && e.ColumnIndex != -1)
                    {
                        if (dgvConsumption.RowCount > 1)
                        {
                            //        /*****************unit conversion calculation *********************/
                            if (dgvConsumption.Columns[e.ColumnIndex].Name == "dgvcmbConsumptionunitId")
                            {
                                if (dgvConsumption.Rows[e.RowIndex].Cells["dgvcmbConsumptionunitId"].Value != null && dgvConsumption.Rows[e.RowIndex].Cells["dgvcmbConsumptionunitId"].Value.ToString() != string.Empty)
                                {
                                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                                    List<DataTable> listUnitByProduct = new List<DataTable>();
                                    listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value.ToString());
                                    foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                    {
                                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvcmbConsumptionunitId"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                        {
                                            dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionunitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                            dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());
                                            decimal decNewConversionRate = Convert.ToDecimal(dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionConversionRate"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionRate"].Value = Math.Round(decNewRate, 2);

                                        }
                                    }
                                    TotalAmountCalculationConsumption("", e.RowIndex);
                                }
                            }
                            if (e.ColumnIndex == dgvConsumption.Columns["dgvcmbConsumptionBatch"].Index)
                            {
                                BatchBll BllBatch = new BatchBll();
                                decimal decBatchId = 0;
                                string strBarcode = string.Empty;
                                if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value != null)
                                {
                                    if (dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionBatch"].Value != null)
                                    {
                                        if (dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionBatch"].Value.ToString() != string.Empty &&
                                            dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionBatch"].Value.ToString() != "0")
                                        {
                                            decBatchId = Convert.ToDecimal(dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionBatch"].Value);
                                            strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                                            dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionBarcode"].Value = strBarcode;
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
                MessageBox.Show("SJ:80" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// dgvProduction grid cell valuechange event to calculate the basic functions and calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (IsSetGridValueChange)
                {
                    if (e.RowIndex != -1 && e.ColumnIndex != -1)
                    {
                        if (dgvProduction.RowCount > 1)
                        {
                            if (dgvProduction.Columns[e.ColumnIndex].Name == "dgvcmbProductionunitId")
                            {
                                if (dgvProduction.Rows[e.RowIndex].Cells["dgvcmbProductionunitId"].Value != null && dgvProduction.Rows[e.RowIndex].Cells["dgvcmbProductionunitId"].Value.ToString() != string.Empty)
                                {
                                    UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                                    List<DataTable> listUnitByProduct = new List<DataTable>();
                                    listUnitByProduct = bllUnitConvertion.UnitConversionIdAndConRateViewallByProductId(dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value.ToString());
                                    foreach (DataRow drUnitByProduct in listUnitByProduct[0].Rows)
                                    {
                                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvcmbProductionunitId"].Value.ToString() == drUnitByProduct.ItemArray[0].ToString())
                                        {
                                            dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionunitConversionId"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[2].ToString());
                                            dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionConversionRate"].Value = Convert.ToDecimal(drUnitByProduct.ItemArray[3].ToString());

                                            decimal decNewConversionRate = Convert.ToDecimal(dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionConversionRate"].Value.ToString());
                                            decimal decNewRate = (decCurrentRate * decCurrentConversionRate) / decNewConversionRate;
                                            dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionRate"].Value = Math.Round(decNewRate, 2);
                                        }
                                    }
                                    TotalAmountCalculationProduction("", e.RowIndex);
                                }
                            }

                            if (e.ColumnIndex == dgvProduction.Columns["dgvcmbProductionBatch"].Index)
                            {
                                BatchBll BllBatch = new BatchBll();
                                decimal decBatchId = 0;
                                string strBarcode = string.Empty;
                                if (dgvProduction.CurrentRow.Cells["dgvtxtProductionProductId"].Value != null)
                                {
                                    if (dgvProduction.CurrentRow.Cells["dgvcmbProductionBatch"].Value != null)
                                    {
                                        if (dgvProduction.CurrentRow.Cells["dgvcmbProductionBatch"].Value.ToString() != string.Empty &&
                                            dgvProduction.CurrentRow.Cells["dgvcmbProductionBatch"].Value.ToString() != "0")
                                        {
                                            decBatchId = Convert.ToDecimal(dgvProduction.CurrentRow.Cells["dgvcmbProductionBatch"].Value);
                                            strBarcode = BllBatch.ProductBatchBarcodeViewByBatchId(decBatchId);
                                            dgvProduction.CurrentRow.Cells["dgvtxtProductionBarcode"].Value = strBarcode;
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
                MessageBox.Show("SJ:81" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// dgvConsumption grid cell enter event to calculate the basic functions and calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvConsumption.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
            {
                dgvConsumption.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            else
            {
                dgvConsumption.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            }
            decimal decGodownId = 0;
            decimal decProductId = 0;
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value != null && dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value.ToString() != string.Empty)
                    {
                        if (dgvConsumption.Columns[e.ColumnIndex].Name == "dgvcmbConsumptionunitId")
                        {
                            decCurrentConversionRate = Convert.ToDecimal(dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionConversionRate"].Value.ToString());
                            decCurrentRate = Convert.ToDecimal(dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionRate"].Value.ToString());
                        }

                    }
                    if (e.ColumnIndex == dgvConsumption.Columns["dgvcmbConsumptionBatch"].Index)
                    {
                        if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value != null)
                        {
                            if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value);

                                BatchComboFillConsumption(decProductId, e.RowIndex, e.ColumnIndex);
                            }
                        }
                    }
                    if (rbtnTransfer.Checked)
                    {
                        if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value != null && dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value.ToString() != string.Empty)
                        {
                            btnTransfer.Enabled = true;
                        }
                        else
                        {
                            btnTransfer.Enabled = false;
                        }
                    }

                    if (e.ColumnIndex == dgvConsumption.Columns["dgvcmbConsumptionRack"].Index)
                    {
                        if (dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionGodown"].Value != null && dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionGodown"].Value.ToString() != string.Empty)
                        {

                            decGodownId = Convert.ToDecimal(dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionGodown"].Value);
                            RackComboFillConsumption(decGodownId, e.RowIndex, dgvConsumption.CurrentRow.Cells["dgvcmbConsumptionRack"].ColumnIndex);
                        }

                    }

                    if (e.ColumnIndex == dgvConsumption.Columns["dgvcmbConsumptionunitId"].Index)
                    {
                        if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value != null)
                        {
                            if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductId"].Value);
                                UnitComboFillConsumption(decProductId, e.RowIndex, e.ColumnIndex);
                            }
                            else
                            {
                                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvConsumption.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                dgvcmbUnitCell.DataSource = null;
                            }
                        }
                        else
                        {
                            DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvConsumption.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            dgvcmbUnitCell.DataSource = null;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:82" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// dgvProduction grid cell enter event to calculate the basic functions and calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduction.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
            {
                dgvProduction.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            else
            {
                dgvProduction.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            }

            decimal decGodownId = 0;
            decimal decProductId = 0;
            try
            {

                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {

                    if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value != null && dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value.ToString() != string.Empty)
                    {
                        if (dgvProduction.Columns[e.ColumnIndex].Name == "dgvcmbProductionunitId")
                        {
                            decCurrentConversionRate = Convert.ToDecimal(dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionConversionRate"].Value.ToString());
                            decCurrentRate = Convert.ToDecimal(dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionRate"].Value.ToString());
                        }

                    }
                    if (e.ColumnIndex == dgvProduction.Columns["dgvcmbProductionBatch"].Index)
                    {
                        if (dgvProduction.CurrentRow.Cells["dgvtxtProductionProductId"].Value != null)
                        {
                            if (dgvProduction.CurrentRow.Cells["dgvtxtProductionProductId"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvProduction.CurrentRow.Cells["dgvtxtProductionProductId"].Value);
                                BatchComboFillProduction(decProductId, e.RowIndex, e.ColumnIndex);
                            }
                        }
                    }

                    if (e.ColumnIndex == dgvProduction.Columns["dgvcmbProductionRack"].Index)
                    {
                        if (dgvProduction.CurrentRow.Cells["dgvcmbProductionGodown"].Value != null && dgvProduction.CurrentRow.Cells["dgvcmbProductionGodown"].Value.ToString() != string.Empty)
                        {

                            decGodownId = Convert.ToDecimal(dgvProduction.CurrentRow.Cells["dgvcmbProductionGodown"].Value);
                            RackComboFillProduction(decGodownId, e.RowIndex, dgvProduction.CurrentRow.Cells["dgvcmbProductionRack"].ColumnIndex);
                        }

                    }

                    if (e.ColumnIndex == dgvProduction.Columns["dgvcmbProductionunitId"].Index)
                    {
                        if (dgvProduction.CurrentRow.Cells["dgvtxtProductionProductId"].Value != null)
                        {
                            if (dgvProduction.CurrentRow.Cells["dgvtxtProductionProductId"].Value.ToString() != string.Empty)
                            {
                                decProductId = Convert.ToDecimal(dgvProduction.CurrentRow.Cells["dgvtxtProductionProductId"].Value);
                                UnitComboFillProduction(decProductId, e.RowIndex, e.ColumnIndex);
                            }
                            else
                            {
                                DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvProduction.Rows[e.RowIndex].Cells[e.ColumnIndex];
                                dgvcmbUnitCell.DataSource = null;
                            }
                        }
                        else
                        {
                            DataGridViewComboBoxCell dgvcmbUnitCell = (DataGridViewComboBoxCell)dgvProduction.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            dgvcmbUnitCell.DataSource = null;
                        }
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("SJ:83" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// dgvConsumption grid CellEndEdit event to calculate the basic functions and calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string strProductCode = string.Empty;
            string strProductName = string.Empty;
            string strBarcode = string.Empty;
            try
            {

                if (e.ColumnIndex == dgvConsumption.Columns["dgvtxtConsumptionProductCode"].Index)
                {
                    if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value == null)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value.ToString();
                                ProductDetailsFillConsumption(strProductCode, e.RowIndex, "ProductCode");
                            }
                        }
                    }
                    else if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value.ToString() == string.Empty)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value.ToString();
                                ProductDetailsFillConsumption(strProductCode, e.RowIndex, "ProductCode");
                            }
                        }
                    }
                    else
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductCode"].Value.ToString();
                                ProductDetailsFillConsumption(strProductCode, e.RowIndex, "ProductCode");
                            }
                        }
                    }
                }
                if (e.ColumnIndex == dgvConsumption.Columns["dgvtxtConsumptionProductName"].Index)
                {
                    if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value == null)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value.ToString();
                                ProductDetailsFillConsumption(strProductName, e.RowIndex, "ProductName");
                            }
                        }
                    }
                    else if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value.ToString() == string.Empty)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value.ToString();
                                ProductDetailsFillConsumption(strProductName, e.RowIndex, "ProductName");
                            }
                        }
                    }
                    else
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductName"].Value.ToString();
                                ProductDetailsFillConsumption(strProductName, e.RowIndex, "ProductName");
                            }
                        }
                    }
                }
                if (e.ColumnIndex == dgvConsumption.Columns["dgvtxtConsumptionBarcode"].Index)
                {
                    if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value == null)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value.ToString();
                                ProductDetailsFillConsumption(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                    else if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionProductId"].Value.ToString() == string.Empty)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value.ToString();
                                ProductDetailsFillConsumption(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                    else
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value != null)
                        {
                            if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionBarcode"].Value.ToString();
                                ProductDetailsFillConsumption(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                }

                if (dgvConsumption.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtConsumptionQty")
                {
                    if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionQty"].Value != null && dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionQty"].Value.ToString() != string.Empty)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionRate"].Value != null && dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionRate"].Value.ToString() != string.Empty)
                        {
                            {
                                TotalAmountCalculationConsumption("", e.RowIndex);
                            }
                        }

                        else
                        {
                            dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionAmount"].Value = string.Empty;
                        }

                    }
                    else
                    {
                        dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionAmount"].Value = string.Empty;
                    }

                }

                if (dgvConsumption.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtConsumptionRate")
                {
                    if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionQty"].Value != null && dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionQty"].Value.ToString() != string.Empty)
                    {
                        if (dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionRate"].Value != null && dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionRate"].Value.ToString() != string.Empty)
                        {
                            {
                                TotalAmountCalculationConsumption("", e.RowIndex);
                            }
                        }

                        else
                        {
                            dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionAmount"].Value = string.Empty;
                        }

                    }
                    else
                    {
                        dgvConsumption.Rows[e.RowIndex].Cells["dgvtxtConsumptionAmount"].Value = string.Empty;
                    }

                }
                CheckInvalidEntriesConsumption(e);
            }

            catch (Exception ex)
            {
                MessageBox.Show("SJ:84" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// dgvProduction grid CellEndEdit event to calculate the basic functions and calculation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string strProductCode = string.Empty;
            string strProductName = string.Empty;
            string strBarcode = string.Empty;
            try
            {

                if (e.ColumnIndex == dgvProduction.Columns["dgvtxtProductionProductCode"].Index)
                {
                    if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value == null)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value.ToString();
                                ProductDetailsFillProduction(strProductCode, e.RowIndex, "ProductCode");
                            }
                        }
                    }
                    else if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value.ToString() == string.Empty)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value.ToString();
                                ProductDetailsFillProduction(strProductCode, e.RowIndex, "ProductCode");
                            }
                        }
                    }
                    else
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value.ToString() != string.Empty)
                            {
                                strProductCode = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductCode"].Value.ToString();
                                ProductDetailsFillProduction(strProductCode, e.RowIndex, "ProductCode");
                            }
                        }
                    }
                }
                if (e.ColumnIndex == dgvProduction.Columns["dgvtxtProductionProductName"].Index)
                {
                    if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value == null)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value.ToString();
                                ProductDetailsFillProduction(strProductName, e.RowIndex, "ProductName");
                            }
                        }
                    }
                    else if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value.ToString() == string.Empty)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value.ToString();
                                ProductDetailsFillProduction(strProductName, e.RowIndex, "ProductName");
                            }
                        }
                    }
                    else
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value.ToString() != string.Empty)
                            {
                                strProductName = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductName"].Value.ToString();
                                ProductDetailsFillProduction(strProductName, e.RowIndex, "ProductName");
                            }
                        }
                    }
                }

                if (e.ColumnIndex == dgvProduction.Columns["dgvtxtProductionBarcode"].Index)
                {
                    if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value == null)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value.ToString();
                                ProductDetailsFillProduction(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                    else if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionProductId"].Value.ToString() == string.Empty)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value.ToString();
                                ProductDetailsFillProduction(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                    else
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value != null)
                        {
                            if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value.ToString() != string.Empty)
                            {
                                strBarcode = dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionBarcode"].Value.ToString();
                                ProductDetailsFillProduction(strBarcode, e.RowIndex, "Barcode");
                            }
                        }
                    }
                }
                if (dgvProduction.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtProductionQty")
                {
                    if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionQty"].Value != null && dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionQty"].Value.ToString() != string.Empty)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionRate"].Value != null && dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionRate"].Value.ToString() != string.Empty)
                        {
                            {
                                TotalAmountCalculationProduction("", e.RowIndex);
                            }
                        }
                        else
                        {
                            dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionAmount"].Value = string.Empty;
                        }
                    }
                    else
                    {
                        dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionAmount"].Value = string.Empty;
                    }
                }
                if (dgvProduction.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtProductionRate")
                {
                    if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionQty"].Value != null && dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionQty"].Value.ToString() != string.Empty)
                    {
                        if (dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionRate"].Value != null && dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionRate"].Value.ToString() != string.Empty)
                        {
                            {
                                TotalAmountCalculationProduction("", e.RowIndex);

                            }
                        }
                        else
                        {
                            dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionAmount"].Value = string.Empty;
                        }
                    }
                    else
                    {
                        dgvProduction.Rows[e.RowIndex].Cells["dgvtxtProductionAmount"].Value = string.Empty;
                    }
                }
                CheckInvalidEntriesProduction(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:85" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On remove link button click of AdditionalCost grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblAdditionalCostRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvAdditionalCost.SelectedCells.Count > 0 && dgvAdditionalCost.CurrentRow != null)
                {
                    if (!dgvAdditionalCost.Rows[dgvAdditionalCost.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvAdditionalCost.CurrentRow.Cells["dgvcmbAdditionalCostLedger"].Value != null && dgvAdditionalCost.CurrentRow.Cells["dgvcmbAdditionalCostLedger"].Value.ToString() != string.Empty)
                                {
                                    if (dgvAdditionalCost.CurrentRow.Cells["dgvtxtAdditionalCostAdditionalCostId"].Value != null && dgvAdditionalCost.CurrentRow.Cells["dgvtxtAdditionalCostAdditionalCostId"].Value.ToString() != string.Empty)
                                    {
                                        ArrlstOfAdditionalCostRemove.Add(dgvAdditionalCost.CurrentRow.Cells["dgvtxtAdditionalCostAdditionalCostId"].Value.ToString());
                                    }
                                    RemoveFunctionForAdditionalCost();
                                    TotalAdditionalCostAmount();
                                }
                                else
                                {
                                    RemoveFunctionForAdditionalCost();
                                    TotalAdditionalCostAmount();
                                }
                            }
                            else
                            {
                                RemoveFunctionForAdditionalCost();
                                TotalAdditionalCostAmount();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:86" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On remove link button click of Consumption grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblConsumptionRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvConsumption.SelectedCells.Count > 0 && dgvConsumption.CurrentRow != null)
                {
                    if (!dgvConsumption.Rows[dgvConsumption.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionStockJournalDetailsId"].Value != null && dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionStockJournalDetailsId"].Value.ToString() != "")
                                {
                                    ArrlstOfConsumtionRemove.Add(dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionStockJournalDetailsId"].Value.ToString());
                                    RemoveFunctionForConsumption();
                                    grandTotalAmountCalculationConsumption();
                                }
                                else
                                {
                                    RemoveFunctionForConsumption();
                                    grandTotalAmountCalculationConsumption();
                                }
                            }
                            else
                            {
                                RemoveFunctionForConsumption();
                                grandTotalAmountCalculationConsumption();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:87" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On remove link button click of Production grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblProductionRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvProduction.SelectedCells.Count > 0 && dgvProduction.CurrentRow != null)
                {
                    if (!dgvProduction.Rows[dgvProduction.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (btnSave.Text == "Update")
                            {
                                if (dgvProduction.CurrentRow.Cells["dgvtxtProductionStockJournalDetailsId"].Value != null && dgvProduction.CurrentRow.Cells["dgvtxtProductionStockJournalDetailsId"].Value.ToString() != "")
                                {
                                    ArrlstOfProductionRemove.Add(dgvProduction.CurrentRow.Cells["dgvtxtProductionStockJournalDetailsId"].Value.ToString());
                                    RemoveFunctionForProduction();
                                    grandTotalAmountCalculationProduction();
                                }
                                else
                                {
                                    RemoveFunctionForProduction();
                                    grandTotalAmountCalculationProduction();
                                }
                            }
                            else
                            {
                                RemoveFunctionForProduction();
                                grandTotalAmountCalculationProduction();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:88" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SJ:89" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStockJournal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmStockJournalRegisterObj != null)
                {
                    frmStockJournalRegisterObj.Enabled = true;
                    frmStockJournalRegisterObj.StockJournalRegisterGrideFill();
                }
                if (frmStockJournelReportObj != null)
                {
                    frmStockJournelReportObj.Enabled = true;
                    frmStockJournelReportObj.StockJournalReportGrideFill();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:90" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On delete button click, calls deleteFunction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    if (Messages.DeleteConfirmation())
                    {
                        DeleteFunction();
                        dgvConsumption.Focus();
                    }

                }
                else
                {
                    Messages.NoPrivillageMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:91" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BatchComboFill(decimal decProductId, int p, int p_2)
        {
            throw new NotImplementedException();
        }

        private void UnitComboFill(decimal decProductId, int p, int p_2)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get the Product details from the Product Search form
        /// </summary>
        /// <param name="frmProductSearchPopup"></param>
        /// <param name="decproductId"></param>
        /// <param name="decCurrentRowIndex"></param>
        public void CallFromProductSearchPopup(frmProductSearchPopup frmProductSearchPopup, decimal decproductId, decimal decCurrentRowIndex)
        {
            ProductInfo infoProduct = new ProductInfo();
            ProductCreationBll BllProductCreation = new ProductCreationBll();
            BatchBll BllBatch = new BatchBll();
            DataTable dtbl = new DataTable();
            UnitConvertionBll bllUnitConversion = new UnitConvertionBll();
            try
            {
                base.Show();
                this.frmProductSearchPopupObj = frmProductSearchPopup;
                infoProduct = BllProductCreation.ProductView(decproductId);
                if (IsdgvConsuption)
                {
                    int inRowcount = dgvConsumption.Rows.Count;
                    dgvConsumption.Rows.Add();
                    for (int i = 0; i < inRowcount; i++)
                    {
                        if (i == decCurrentRowIndex)
                        {
                            dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].Value = infoProduct.ProductCode;
                            strProductCode = infoProduct.ProductCode;
                            ProductDetailsFillConsumption(strProductCode, i, "ProductCode");
                        }
                    }
                }
                else
                {
                    int inRowcount = dgvProduction.Rows.Count;
                    dgvProduction.Rows.Add();
                    for (int i = 0; i < inRowcount; i++)
                    {
                        if (i == decCurrentRowIndex)
                        {
                            dgvProduction.Rows[i].Cells["dgvtxtProductionProductCode"].Value = infoProduct.ProductCode;
                            strProductCode = infoProduct.ProductCode;
                            ProductDetailsFillProduction(strProductCode, i, "ProductCode");
                        }
                    }
                }

                frmProductSearchPopupObj.Close();
                frmProductSearchPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:92" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For number only validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.NumberOnly(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:93" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calling the keypress event here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdditionalCost_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBoxControl = e.Control as DataGridViewTextBoxEditingControl;
            try
            {
                if (TextBoxControl != null)
                {
                    if (dgvAdditionalCost.CurrentCell.ColumnIndex == dgvAdditionalCost.Columns["dgvtxtAdditionalCostAmount"].Index)
                    {
                        TextBoxControl.KeyPress += keypressevent;
                    }
                    else
                    {
                        TextBoxControl.KeyPress += keypresseventforOther;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:94" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvAdditionalCost_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAdditionalCost.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvAdditionalCost.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvAdditionalCost.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:95" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
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
                    if (cmbCurrency.Enabled == true)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        cmbFinishedGoods.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (!txtVoucherNo.ReadOnly)
                    {
                        txtVoucherNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:96" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvProduction
        /// Alt+c for product creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {

                    if (dgvProduction.CurrentCell == dgvProduction.Rows[dgvProduction.RowCount - 1].Cells["dgvtxtProductionAmount"])
                    {
                        cmbCashOrBank.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvProduction.CurrentCell == dgvProduction.Rows[0].Cells["dgvtxtProductionSlNo"])
                    {
                        dgvConsumption.Focus();
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (IsdgvConsuption == false)
                    {
                        if (dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionProductCode" || dgvProduction.Columns[dgvProduction.CurrentCell.ColumnIndex].Name == "dgvtxtProductionProductName")
                        {
                            frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                            frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                            if (dgvProduction.CurrentRow.Cells["dgvtxtProductionProductCode"].Value != null || dgvProduction.CurrentRow.Cells["dgvtxtProductionProductName"].Value != null)
                            {
                                frmProductSearchPopupObj.CallFromStockJournal(this, dgvProduction.CurrentRow.Index, dgvProduction.CurrentRow.Cells["dgvtxtProductionProductCode"].Value.ToString());
                            }
                            else
                            {
                                frmProductSearchPopupObj.CallFromStockJournal(this, dgvProduction.CurrentRow.Index, string.Empty);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:97" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvConsumption
        /// Alt+c for dgvConsumption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvConsumption.CurrentCell == dgvConsumption.Rows[dgvConsumption.RowCount - 1].Cells["dgvtxtConsumptionAmount"])
                    {
                        if (rbtnManufacturing.Checked)
                        {
                            dgvProduction.Focus();

                        }
                        else if (rbtnTransfer.Checked)
                        {
                            btnTransfer.Enabled = true;
                            btnTransfer.Focus();
                        }
                        else
                        {
                            txtNarration.Focus();
                        }

                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvConsumption.CurrentCell == dgvConsumption.Rows[0].Cells["dgvtxtConsumptionSlNo"])
                    {
                        if (rbtnManufacturing.Checked)
                        {
                            btnAdd.Focus();
                        }
                        else
                        {
                            cmbCurrency.Focus();
                        }
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control)
                {
                    if (IsdgvConsuption)
                    {
                        if (dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionProductCode" || dgvConsumption.Columns[dgvConsumption.CurrentCell.ColumnIndex].Name == "dgvtxtConsumptionProductName")
                        {
                            frmProductSearchPopup frmProductSearchPopupObj = new frmProductSearchPopup();
                            frmProductSearchPopupObj.MdiParent = formMDI.MDIObj;
                            if (dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductCode"].Value != null || dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductName"].Value != null)
                            {
                                frmProductSearchPopupObj.CallFromStockJournal(this, dgvConsumption.CurrentRow.Index, dgvConsumption.CurrentRow.Cells["dgvtxtConsumptionProductCode"].Value.ToString());
                            }
                            else
                            {
                                frmProductSearchPopupObj.CallFromStockJournal(this, dgvConsumption.CurrentRow.Index, string.Empty);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:98" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of txtVoucherNo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDate.Focus();
                    txtDate.SelectionLength = 0;
                    txtDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:99" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbFinishedGoods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFinishedGoods_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtQty.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCurrency.Enabled == true)
                    {
                        cmbCurrency.Focus();
                    }
                    else
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:100" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtQty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtQty.Text == string.Empty || txtQty.SelectionStart == 0)
                    {
                        cmbFinishedGoods.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:101" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbCashOrBank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrBank_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvAdditionalCost.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    dgvProduction.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:102" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of dgvAdditionalCost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdditionalCost_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvAdditionalCost.CurrentCell == dgvAdditionalCost.Rows[dgvAdditionalCost.RowCount - 1].Cells["dgvtxtAdditionalCostAmount"])
                    {
                        txtNarration.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvAdditionalCost.CurrentCell == dgvAdditionalCost.Rows[0].Cells["dgvtxtAdditionalCostSlNo"])
                    {
                        cmbCashOrBank.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:103" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtNarration
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
                if (e.KeyCode == Keys.Back)
                {
                    if (txtNarration.Text == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        dgvAdditionalCost.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:104" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:105" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (rbtnManufacturing.Checked)
                    {
                        cmbFinishedGoods.Focus();
                    }
                    else
                    {
                        dgvConsumption.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtDate.Focus();
                    txtDate.SelectionStart = 0;
                    txtDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:106" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of btnAdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvConsumption.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtQty.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:107" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// For the Enter and Back Space in btnTransfer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransfer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvProduction.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    dgvConsumption.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:108" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For the Transfer the product details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransfer_Click(object sender, EventArgs e)
        {

            bool isTransferOk = true;
            try
            {
                int inRowConsumption = dgvConsumption.RowCount;
                int inRowProduction = dgvProduction.RowCount;

                if (RemoveIncompleteRowsFromConsumptionGrid())
                {
                    for (int inI = 0; inI < dgvConsumption.Rows.Count - 1; inI++)
                    {
                        if (dgvConsumption.Rows[inI].Cells["dgvtxtConsumptionQty"].Value == null || dgvConsumption.Rows[inI].Cells["dgvcmbConsumptionGodown"].Value.ToString() == "1" || dgvConsumption.Rows[inI].Cells["dgvtxtConsumptionQty"].Value.ToString() == string.Empty)
                        {
                            isTransferOk = false;
                            Messages.InformationMessage("Rows Contains Invalid entries please fill the godown Details");
                            break;

                        }
                        else if (Convert.ToDecimal(dgvConsumption.Rows[inI].Cells["dgvtxtConsumptionQty"].Value) == 0)
                        {
                            isTransferOk = false;
                            Messages.InformationMessage("The Quantity Should be greater than Zero");
                            break;
                        }
                    }
                    if (isTransferOk)
                    {
                        if (dgvConsumption.Rows[0].Cells["dgvtxtConsumptionQty"].Value == null || dgvConsumption.Rows[0].Cells["dgvcmbConsumptionGodown"].Value.ToString() == "1" || dgvConsumption.Rows[0].Cells["dgvtxtConsumptionQty"].Value.ToString() == string.Empty)
                        {
                            Messages.InformationMessage("Can't Transfer the details with complete details");
                            goto Exit;
                        }
                        dgvProduction.Enabled = true;
                        for (int i = 0; i < dgvConsumption.Rows.Count; i++)
                        {
                            if (dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].Value != null)
                            {
                                string strProductionProductCode = (dgvProduction.Rows[i].Cells["dgvtxtProductionProductCode"].Value == null ? string.Empty : dgvProduction.Rows[i].Cells["dgvtxtProductionProductCode"].Value).ToString();
                                string strConsumptionProductCode = (dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].Value == null ? string.Empty : dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].Value).ToString();
                                if (strProductionProductCode != strConsumptionProductCode && dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Value != dgvConsumption.Rows[i].Cells["dgvcmbConsumptionGodown"].Value)
                                {
                                    dgvProduction.Rows.Add();
                                    ProductionSerialNo();

                                }
                                TransferReadonlyfunction();
                                dgvProduction.Rows[i].Cells["dgvtxtProductionProductCode"].Value = dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductCode"].Value;
                                dgvProduction.Rows[i].Cells["dgvtxtProductionBarcode"].Value = dgvConsumption.Rows[i].Cells["dgvtxtConsumptionBarcode"].Value;
                                dgvProduction.Rows[i].Cells["dgvtxtProductionProductName"].Value = dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductName"].Value;
                                dgvProduction.Rows[i].Cells["dgvtxtProductionProductId"].Value = dgvConsumption.Rows[i].Cells["dgvtxtConsumptionProductId"].Value;
                                dgvProduction.Rows[i].Cells["dgvtxtProductionQty"].Value = dgvConsumption.Rows[i].Cells["dgvtxtConsumptionQty"].Value;
                                dgvProduction.Rows[i].Cells["dgvcmbProductionunitId"].Value = dgvConsumption.Rows[i].Cells["dgvcmbConsumptionunitId"].Value;
                                dgvProduction.Rows[i].Cells["dgvcmbProductionBatch"].Value = dgvConsumption.Rows[i].Cells["dgvcmbConsumptionBatch"].Value;
                                dgvProduction.Rows[i].Cells["dgvtxtProductionRate"].Value = dgvConsumption.Rows[i].Cells["dgvtxtConsumptionRate"].Value;
                                dgvProduction.Rows[i].Cells["dgvtxtProductionAmount"].Value = dgvConsumption.Rows[i].Cells["dgvtxtConsumptionAmount"].Value;
                                dgvProduction.Rows[i].Cells["dgvcmbProductionGodown"].Selected = true;
                            }
                            grandTotalAmountCalculationConsumption();
                            lblProductionAmount.Text = lblConsumptionAmount.Text;
                            btnTransfer.Enabled = false;
                        }
                    }
                }
            Exit: ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:109" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For the dgvProduction grid read only is true
        /// </summary>
        public void TransferReadonlyfunction()
        {
            try
            {
                dgvProduction.Columns["dgvtxtProductionBarcode"].ReadOnly = true;
                dgvProduction.Columns["dgvtxtProductionProductCode"].ReadOnly = true;
                dgvProduction.Columns["dgvtxtProductionProductName"].ReadOnly = true;
                dgvProduction.Columns["dgvtxtProductionProductId"].ReadOnly = true;
                dgvProduction.Columns["dgvtxtProductionQty"].ReadOnly = true;
                dgvProduction.Columns["dgvcmbProductionunitId"].ReadOnly = true;
                dgvProduction.Columns["dgvtxtProductionRate"].ReadOnly = true;
                dgvProduction.Columns["dgvtxtProductionAmount"].ReadOnly = true;
                dgvProduction.Columns["dgvcmbProductionBatch"].ReadOnly = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("SJ:110" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For the dgvProduction grid read only is false
        /// </summary>
        public void ConsumptionReadOnlyfunction()
        {
            try
            {
                dgvProduction.Columns["dgvtxtProductionBarcode"].ReadOnly = false;
                dgvProduction.Columns["dgvtxtProductionProductCode"].ReadOnly = false;
                dgvProduction.Columns["dgvtxtProductionProductName"].ReadOnly = false;
                dgvProduction.Columns["dgvtxtProductionProductId"].ReadOnly = false;
                dgvProduction.Columns["dgvtxtProductionQty"].ReadOnly = false;
                dgvProduction.Columns["dgvcmbProductionunitId"].ReadOnly = false;
                dgvProduction.Columns["dgvtxtProductionRate"].ReadOnly = false;
                //dgvProduction.Columns["dgvtxtProductionAmount"].ReadOnly = false;
                dgvProduction.Columns["dgvcmbProductionBatch"].ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SJ:111" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvConsumption_Enter(object sender, EventArgs e)
        {
            dgvProduction.ClearSelection();
        }
        /// <summary>
        /// For the alt+c and ctrl+f
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvConsumption_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsdgvConsuption = true;
        }
        /// <summary>
        /// For the alt+c and ctrl+f
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsdgvConsuption = false;
        }

        private void dgvProduction_Enter(object sender, EventArgs e)
        {
            dgvConsumption.ClearSelection();
        }
        #endregion



    }
}
