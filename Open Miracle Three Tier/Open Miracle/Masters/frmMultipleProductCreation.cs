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
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmMultipleProductCreation : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string strProductGroupName = string.Empty;
        string strunitName = string.Empty;
        string strGodownName = string.Empty;
        string strRackName = string.Empty;
        string StrBrand = string.Empty;
        string StrSize = string.Empty;
        string strModel = string.Empty;
        decimal decIdentity = 0;
        bool isValueChanged = false;
        TransactionsGeneralFillBll TransactionsGeneralFill = new TransactionsGeneralFillBll();
        List<DataTable> listObjUnit = new List<DataTable>();

        List<DataTable> dtblModelNo = new List<DataTable>();
        List<DataTable> listBrand = new  List<DataTable>();
        List<DataTable> listObjSize = new List<DataTable>();
        #endregion
        #region Functions
        /// <summary>
        /// Creates instance of frmMultipleProductCreation class
        /// </summary>
        public frmMultipleProductCreation()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Unit combobox
        /// </summary>
        public void UnitComboFill()
        {
            try
            {
                listObjUnit = TransactionsGeneralFill.UnitViewAll(cmbUnit, false);
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("ShowUnit") == "Yes")
                {
                    cmbUnit.Enabled = true;
                }
                else
                {
                    cmbUnit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Tax combobox
        /// </summary>
        public void TaxComboFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllForProduct();
                cmbTax.DataSource = ListObj[0];
                cmbTax.DisplayMember = "taxName";
                cmbTax.ValueMember = "taxId";
                if (TaxStatus())
                {
                    cmbTax.Enabled = true;
                }
                else
                {
                    cmbTax.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ProductGroup combobox
        /// </summary>
        public void ProductGroupComboFill()
        {
            try
            {
                TransactionsGeneralFill.ProductGroupViewAll(cmbProductGroup, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check status of Tax
        /// </summary>
        /// <returns></returns>
        public bool TaxStatus()
        {
            bool isTick = false;
            try
            {
                isTick = TransactionsGeneralFill.TaxStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        /// <summary>
        /// Function to check status of Tax
        /// </summary>
        /// <returns></returns>
        public bool GodownStatus()
        {
            bool isTick = false;
            try
            {
                isTick = TransactionsGeneralFill.GodownStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTick;
        }
        /// <summary>
        /// Function to fill Brand combobox
        /// </summary>
        public void BrandComboFill()
        {
            try
            {
                BrandBll BllBrand = new BrandBll();
                listBrand = BllBrand.BrandViewAll();
                dgvcmbBrand.DataSource = listBrand[0];
                dgvcmbBrand.ValueMember = "brandId";
                dgvcmbBrand.DisplayMember = "brandName";
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("ShowBrand") == "Yes")
                {
                    dgvcmbBrand.ReadOnly = false;
                }
                else
                {
                    dgvcmbBrand.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ModelNo combobox
        /// </summary>
        public void ModelComboFill()
        {
            try
            {
                ModelNoBll BllModelNo = new ModelNoBll();
                dtblModelNo = BllModelNo.ModelNoViewAll();
                dgvcmbModel.DataSource = dtblModelNo[0];
                dgvcmbModel.ValueMember = "modelNoId";
                dgvcmbModel.DisplayMember = "modelNo";
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("ShowModelNo") == "Yes")
                {
                    dgvcmbModel.ReadOnly = false;
                }
                else
                {
                    dgvcmbModel.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Size combobox
        /// </summary>
        public void SizeComboFill()
        {
            try
            {
                SizeBll BllSize = new SizeBll();
                listObjSize = BllSize.SizeViewAll();
                dgvcmbSize.DataSource = listObjSize[0];
                dgvcmbSize.ValueMember = "sizeId";
                dgvcmbSize.DisplayMember = "size";
                SettingsBll BllSettings = new SettingsBll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Rack combobox
        /// </summary>
        public void RackComboFill()
        {
            try
            {
                RackBll BllRack = new RackBll();
                List<DataTable> listObjRack = new List<DataTable>();
                listObjRack = BllRack.RackViewAll();
                cmbRack.DataSource = listObjRack[0];
                cmbRack.ValueMember = "rackId";
                cmbRack.DisplayMember = "rackName";
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("AllowRack") == "Yes")
                {
                    cmbRack.Enabled = true;
                }
                else
                {
                    cmbRack.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Rack Combobox corresponding to godown
        /// </summary>
        /// <param name="decGodownId"></param>
        public void RackComboFillByGodown(decimal decGodownId)
        {
            try
            {
                RackBll BllRack = new RackBll();
                List<DataTable> listObjRack = new List<DataTable>();
                listObjRack = BllRack.RackViewAllByGodown(decGodownId);
                cmbRack.DataSource = listObjRack[0];
                cmbRack.ValueMember = "rackId";
                cmbRack.DisplayMember = "rackName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Godown Combobox
        /// </summary>
        public void GoDownComboFill()
        {
            try
            {
                GodownBll BllGodown = new GodownBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllGodown.GodownViewAll();
                cmbGoDown.DataSource = listObj[0];
                cmbGoDown.ValueMember = "godownId";
                cmbGoDown.DisplayMember = "godownName";
                if (GodownStatus())
                {
                    cmbGoDown.Enabled = true;
                    btnGodownAdd.Enabled = true;
                    btnRackAdd.Visible = false;
                    if (listObj[0].Rows.Count == 1)
                    {
                        cmbRack.Enabled = true;
                        btnRackAdd.Visible = true;
                        RackComboFillByGodown(Convert.ToDecimal(cmbGoDown.SelectedValue));
                    }
                }
                else
                {
                    cmbGoDown.Enabled = false;
                    btnGodownAdd.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Clear
        /// </summary>
        public void Clear()
        {
            try
            {
                cmbProductGroup.SelectedIndex = 0;
                cmbRack.SelectedIndex = -1;
                cmbGoDown.SelectedIndex = 0;
                cmbUnit.SelectedIndex = -1;
                cmbTax.SelectedIndex = 0;
                cmbTaxApplication.SelectedIndex = 0;
                cmbTaxApplication.Enabled = false;
                dgvMultipleProductCreation.Rows.Clear();
                cmbProductGroup.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation in Datagridview keypress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (dgvMultipleProductCreation.CurrentCell != null)
                {
                    if (dgvMultipleProductCreation.Columns[dgvMultipleProductCreation.CurrentCell.ColumnIndex].Name == "dgvtxtPurchaseRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                    if (dgvMultipleProductCreation.Columns[dgvMultipleProductCreation.CurrentCell.ColumnIndex].Name == "dgvtxtMRP")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                    if (dgvMultipleProductCreation.Columns[dgvMultipleProductCreation.CurrentCell.ColumnIndex].Name == "dgvtxtsalesRate")
                    {
                        Common.DecimalValidation(sender, e, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                int inRowCount = dgvMultipleProductCreation.RowCount;
                BatchBll BllBatch = new BatchBll();
                BatchInfo infoBatch = new BatchInfo();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                ProductInfo infoProduct = new ProductInfo();
                UnitConvertionBll bllUnitConvertion = new UnitConvertionBll();
                UnitConvertionInfo infoUnitConvertion = new UnitConvertionInfo();
                for (int i = 0; i < inRowCount - 1; i++)
                {
                    infoProduct.GroupId = Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString());
                    infoProduct.UnitId = Convert.ToDecimal(cmbUnit.SelectedValue.ToString());
                    infoProduct.TaxId = Convert.ToDecimal(cmbTax.SelectedValue.ToString());
                    if (cmbGoDown.SelectedIndex != -1)
                    {
                        infoProduct.GodownId = Convert.ToDecimal(cmbGoDown.SelectedValue.ToString());
                    }
                    else
                    {
                        infoProduct.GodownId = 0;
                    }
                    if (cmbRack.SelectedIndex != -1)
                    {
                        infoProduct.RackId = Convert.ToDecimal(cmbRack.SelectedValue.ToString());
                    }
                    else
                    {
                        infoProduct.RackId = 0;
                    }
                    infoProduct.MinimumStock = 0;
                    infoProduct.MaximumStock = 0;
                    infoProduct.ReorderLevel = 0;
                    infoProduct.IsallowBatch = false;
                    infoProduct.Ismultipleunit = false;
                    infoProduct.IsBom = false;
                    infoProduct.Isopeningstock = false;
                    infoProduct.IsActive = true;
                    infoProduct.IsshowRemember = false;
                    infoProduct.Narration = string.Empty;
                    infoProduct.Extra1 = string.Empty;
                    infoProduct.Extra2 = string.Empty;
                    infoProduct.ExtraDate = PublicVariables._dtCurrentDate;
                    infoProduct.PartNo = string.Empty;
                    infoProduct.TaxapplicableOn = cmbTaxApplication.SelectedItem.ToString();
                    infoProduct.ProductCode = dgvMultipleProductCreation.Rows[i].Cells["dgvtxtProductCode"].Value.ToString().Trim();
                    infoProduct.ProductName = dgvMultipleProductCreation.Rows[i].Cells["dgvtxtProductName"].Value.ToString().Trim();
                    if (dgvMultipleProductCreation.Rows[i].Cells["dgvcmbBrand"].Value != null)
                    {
                        infoProduct.BrandId = Convert.ToDecimal(dgvMultipleProductCreation.Rows[i].Cells["dgvcmbBrand"].Value.ToString());
                    }
                    else
                    {
                        infoProduct.BrandId = 1;
                    }
                    if (dgvMultipleProductCreation.Rows[i].Cells["dgvcmbModel"].Value != null)
                    {
                        infoProduct.ModelNoId = Convert.ToDecimal(dgvMultipleProductCreation.Rows[i].Cells["dgvcmbModel"].Value.ToString());
                    }
                    else
                    {
                        infoProduct.ModelNoId = 1;
                    }
                    if (dgvMultipleProductCreation.Rows[i].Cells["dgvcmbSize"].Value != null)
                    {
                        infoProduct.SizeId = Convert.ToDecimal(dgvMultipleProductCreation.Rows[i].Cells["dgvcmbSize"].Value.ToString());
                    }
                    else
                    {
                        infoProduct.SizeId = 1;
                    }
                    infoProduct.PurchaseRate = Convert.ToDecimal(dgvMultipleProductCreation.Rows[i].Cells["dgvtxtPurchaseRate"].Value.ToString());
                    infoProduct.SalesRate = Convert.ToDecimal(dgvMultipleProductCreation.Rows[i].Cells["dgvtxtSalesRate"].Value.ToString());
                    infoProduct.Mrp = Convert.ToDecimal(dgvMultipleProductCreation.Rows[i].Cells["dgvtxtMRP"].Value.ToString());
                    decIdentity = BllProductCreation.ProductAdd(infoProduct);
                    //...................................................................ADD UNIT TO UNIT CONVERSION TABLE...................................................................................//
                    infoUnitConvertion.ProductId = decIdentity;
                    infoUnitConvertion.UnitId = Convert.ToDecimal(cmbUnit.SelectedValue.ToString());
                    infoUnitConvertion.ConversionRate = 1;
                    infoUnitConvertion.ExtraDate = DateTime.Now;
                    infoUnitConvertion.Quantities = string.Empty;
                    infoUnitConvertion.Extra1 = string.Empty;
                    infoUnitConvertion.Extra2 = string.Empty;
                    bllUnitConvertion.UnitConvertionAdd(infoUnitConvertion);
                    //...................................................................ADD BATCH TO BATCH TABLE...................................................................................//
                    Int32 inBarcode = BllBatch.AutomaticBarcodeGeneration();
                    infoBatch.BatchNo = "NA";
                    infoBatch.ExpiryDate = DateTime.Now;
                    infoBatch.ManufacturingDate = DateTime.Now;
                    infoBatch.partNo = string.Empty;
                    infoBatch.ProductId = decIdentity;
                    infoBatch.narration = string.Empty;
                    infoBatch.ExtraDate = DateTime.Now;
                    infoBatch.barcode = Convert.ToString(inBarcode);
                    infoBatch.Extra1 = string.Empty;
                    infoBatch.Extra2 = string.Empty;
                    BllBatch.BatchAddWithBarCode(infoBatch);
                }
                Messages.SavedMessage();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call save
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                dgvMultipleProductCreation.ClearSelection();
                int inRow = dgvMultipleProductCreation.RowCount;
                if (cmbProductGroup.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select productgroup");
                    cmbProductGroup.Focus();
                }
                else if (cmbUnit.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select unit");
                    cmbUnit.Focus();
                }
                else if (cmbTax.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select tax");
                    cmbTax.Focus();
                }
                else if (cmbTaxApplication.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select taxapplication");
                    cmbTaxApplication.Focus();
                }
                else
                {
                    if (RemoveIncompleteRowsFromGrid())
                    {
                        if (dgvMultipleProductCreation.Rows[0].Cells["dgvtxtProductName"].Value == null && dgvMultipleProductCreation.Rows[0].Cells["dgvtxtProductCode"].Value == null)
                        {
                            MessageBox.Show("Can't save ProductCreation without complete entry", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvMultipleProductCreation.ClearSelection();
                            dgvMultipleProductCreation.Focus();
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                if (CheckAlreadyExist())
                                {
                                    if (dgvMultipleProductCreation.Rows[0].Cells["dgvtxtProductName"].Value == null)
                                    {
                                        MessageBox.Show("Can't save without product creation with complete entry", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        dgvMultipleProductCreation.ClearSelection();
                                        dgvMultipleProductCreation.Focus();
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
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check the status of AutomaticProductCode generation
        /// </summary>
        /// <returns></returns>
        public bool AutomaticProductCode()
        {
            bool isAuto = false;
            try
            {
                SettingsBll BllSettings = new SettingsBll();
                isAuto = BllSettings.AutomaticProductCodeGeneration();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isAuto;
        }
        /// <summary>
        /// Function to check whether the Datagrid value are valid 
        /// </summary>
        /// <param name="e"></param>
        public void CheckInvalidEntries(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMultipleProductCreation.CurrentRow != null)
                {
                    if (!isValueChanged)
                    {
                        if (dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtProductCode"].Value == null || dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtProductCode"].Value.ToString().Trim() == "")
                        {
                            isValueChanged = true;
                            dgvMultipleProductCreation.CurrentRow.HeaderCell.Value = "X";
                            dgvMultipleProductCreation.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvMultipleProductCreation["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else if (dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtProductName"].Value == null || dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtProductName"].Value.ToString().Trim() == "")
                        {
                            isValueChanged = true;
                            dgvMultipleProductCreation.CurrentRow.HeaderCell.Value = "X";
                            dgvMultipleProductCreation.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isValueChanged = true;
                            dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtCheck"].Value = "x";
                            dgvMultipleProductCreation["dgvtxtCheck", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvMultipleProductCreation.CurrentRow.HeaderCell.Value = "";
                            isValueChanged = true;
                            dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtCheck"].Value = "";
                        }
                        if (dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value != null)
                        {
                            isValueChanged = true;
                            dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value = dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString().Trim();
                            // To check repeated product Codes in rows
                            foreach (DataGridViewRow rw in dgvMultipleProductCreation.Rows)
                            {
                                if ((rw.Cells["dgvtxtProductCode"].Value != null) && (rw.Index != e.RowIndex))
                                {
                                    if (rw.Cells["dgvtxtProductCode"].Value.ToString() == dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtProductCode"].Value.ToString())
                                    {
                                        isValueChanged = true;
                                        dgvMultipleProductCreation.Rows[e.RowIndex].HeaderCell.Value = "";
                                        isValueChanged = true;
                                        dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtCheck"].Value = "";
                                        isValueChanged = true;
                                        rw.HeaderCell.Value = "X";
                                        rw.HeaderCell.Style.ForeColor = Color.Red;
                                        isValueChanged = true;
                                        rw.Cells["dgvtxtCheck"].Value = "x";
                                        rw.Cells["dgvtxtCheck"].Style.ForeColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to remove incomplete rows from Datagridview
        /// </summary>
        /// <returns></returns>
        public bool RemoveIncompleteRowsFromGrid()
        {
            bool isOk = true;
            try
            {
                string strMessage = "Rows";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvMultipleProductCreation.RowCount;
                int inLastRow = 1;
                foreach (DataGridViewRow dgvrowCur in dgvMultipleProductCreation.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.Cells["dgvtxtCheck"].Value.ToString() == "x" || dgvrowCur.Cells["dgvtxtProductName"].Value == null)
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
                        for (int inK = 0; inK < dgvMultipleProductCreation.Rows.Count; inK++)
                        {
                            if (dgvMultipleProductCreation.Rows[inK].Cells["dgvtxtCheck"].Value != null && dgvMultipleProductCreation.Rows[inK].Cells["dgvtxtCheck"].Value.ToString() == "x")
                            {
                                if (!dgvMultipleProductCreation.Rows[inK].IsNewRow)
                                {
                                    dgvMultipleProductCreation.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvMultipleProductCreation.Rows[inForFirst].Cells["dgvtxtProductName"].Selected = true;
                        dgvMultipleProductCreation.CurrentCell = dgvMultipleProductCreation.Rows[inForFirst].Cells["dgvtxtProductName"];
                        dgvMultipleProductCreation.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to check whether ProductCode exist
        /// </summary>
        /// <returns></returns>
        public bool CheckAlreadyExist()
        {
            bool isOk = true;
            try
            {               
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                int inCompleteRow = 0;
                int inCurrentindex = 0;
                string strMessage = "Row";
                foreach (DataGridViewRow dgvRow in dgvMultipleProductCreation.Rows)
                {
                    if (dgvRow.Cells["dgvtxtProductCode"].Value != null)
                    {
                        string ProductCode = dgvRow.Cells["dgvtxtProductCode"].Value.ToString();
                        if (BllProductCreation.ProductCodeCheckExistence(ProductCode, 0))
                        {
                            isOk = false;
                            if (inCompleteRow == 0)
                            {
                                strMessage = strMessage + Convert.ToString(dgvRow.Index + 1);
                                inCurrentindex = dgvRow.Index;
                                inCompleteRow++;
                            }
                            else
                            {
                                strMessage = strMessage + ", " + Convert.ToString(dgvRow.Index + 1);
                            }
                        }
                    }
                }
                if (!isOk)
                {
                    strMessage = strMessage + " contains already exisitng productcode. Do you want to continue?";
                    if (MessageBox.Show(strMessage, "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvMultipleProductCreation.Rows.Count; inK++)
                        {
                            if (dgvMultipleProductCreation.Rows[inK].Cells["dgvtxtProductCode"].Value != null)
                            {
                                string strProductCode = dgvMultipleProductCreation.Rows[inK].Cells["dgvtxtProductCode"].Value.ToString().Trim();
                                if (BllProductCreation.ProductCodeCheckExistence(strProductCode, 0) == true)
                                {
                                    if (!dgvMultipleProductCreation.Rows[inK].IsNewRow)
                                    {
                                        dgvMultipleProductCreation.Rows.RemoveAt(inK);
                                        inK--;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvMultipleProductCreation.Rows[inCurrentindex].Cells["dgvtxtProductCode"].Selected = true;
                        dgvMultipleProductCreation.CurrentCell = dgvMultipleProductCreation.Rows[inCurrentindex].Cells["dgvtxtProductCode"];
                        dgvMultipleProductCreation.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }
        /// <summary>
        /// Function to check whether the ProductName same
        /// </summary>
        /// <returns></returns>
        public bool ProductSameOccourance()
        {
            bool isSame = false;
            try
            {               
                int index = dgvMultipleProductCreation.CurrentRow.Index;
                string strName = dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                int inCurrentIndex = 0;
                for (int inI = 0; inI < index; inI++)
                {
                    string strOther = dgvMultipleProductCreation.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                    if (strName == strOther)
                    {
                        inCurrentIndex = dgvMultipleProductCreation.Rows[inI].Cells["dgvtxtProductName"].RowIndex;
                    }
                }
                dgvMultipleProductCreation.Rows[inCurrentIndex].Cells["dgvtxtCheck"].Value = string.Empty;
                isSame = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSame;
        }
        /// <summary>
        /// Function to remove rows from Datagridview
        /// </summary>
        public void RemoveFunction()
        {
            try
            {
                int inRowCount = dgvMultipleProductCreation.RowCount;
                int index = dgvMultipleProductCreation.CurrentRow.Index;
                int inC = 0;
                if (inRowCount > 2)
                {
                    if (dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtCheck"].Value.ToString() == string.Empty)
                    {
                        string strName = dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtProductName"].Value.ToString();
                        int inIndex = dgvMultipleProductCreation.CurrentRow.Cells["dgvtxtProductName"].RowIndex;
                        string strOther;
                        for (int inI = 0; inI < inRowCount - 1; inI++)
                        {
                            inC++;
                            strOther = dgvMultipleProductCreation.Rows[inI].Cells["dgvtxtProductName"].Value.ToString();
                            if (inIndex != dgvMultipleProductCreation.Rows[inI].Cells["dgvtxtProductName"].RowIndex)
                            {
                                if (ProductSameOccourance())
                                {
                                    dgvMultipleProductCreation.Rows.RemoveAt(index);
                                    return;
                                }
                                else
                                {
                                    if (inC == inRowCount - 1)
                                    {
                                        dgvMultipleProductCreation.Rows.RemoveAt(index);
                                        inC = 0;
                                    }
                                }
                            }
                            else
                            {
                                dgvMultipleProductCreation.Rows.RemoveAt(index);
                                return;
                            }
                        }
                    }
                    else
                    {
                        dgvMultipleProductCreation.Rows.RemoveAt(index);
                        return;
                    }
                }
                else
                {
                    dgvMultipleProductCreation.Rows.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Unit combobox when return from Unit Form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromUnitForm(decimal decId)
        {
            try
            {
                UnitComboFill();
                if (decId.ToString() != "0")
                {
                    cmbUnit.SelectedValue = decId.ToString();
                }
                else if (strunitName != string.Empty)
                {
                    cmbUnit.SelectedValue = strunitName;
                }
                else
                {
                    cmbUnit.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbUnit.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill productGroup combobox when return from ProductGroup Form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromProductGroupForm(decimal decId)
        {
            try
            {
                ProductGroupComboFill();
                if (decId.ToString() != "0")
                {
                    cmbProductGroup.SelectedValue = decId.ToString();
                }
                else if (strProductGroupName != string.Empty)
                {
                    cmbProductGroup.SelectedValue = strProductGroupName;
                }
                else
                {
                    cmbProductGroup.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbProductGroup.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Godown combobox when return from Godown Form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromGodownForm(decimal decId)
        {
            try
            {
                GoDownComboFill();
                if (decId.ToString() != "0")
                {
                    cmbGoDown.SelectedValue = decId;
                }
                else if (strGodownName != string.Empty)
                {
                    cmbGoDown.SelectedValue = strGodownName;
                }
                else
                {
                    cmbGoDown.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbGoDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill brand combobox when return from Brand Form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromBrandForm(decimal decId)
        {
            try
            {
                BrandComboFill();
                if (decId.ToString() != "0")
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbBrand"].Value = decId;
                }
                else if (StrBrand != string.Empty)
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbBrand"].Value = StrBrand;
                }
                else
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbBrand"].Value = listBrand[0].Rows[0]["brandId"];
                }
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC53:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Size combobox when return from Size Form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromSizeForm(decimal decId)
        {
            try
            {
                SizeComboFill();
                if (decId.ToString() != "0")
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbSize"].Value = decId;
                }
                else if (strModel != string.Empty)
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbSize"].Value = StrSize;
                }
                else
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbSize"].Value = listObjSize[0].Rows[0]["sizeId"];
                }
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC54:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ModelNo combobox when return from ModelNo Form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromModelNoForm(decimal decId)
        {
            try
            {
                SizeComboFill();
                if (decId.ToString() != "0")
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbModel"].Value = decId;
                }
                else if (strModel != string.Empty)
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbModel"].Value = strModel;
                }
                else
                {
                    dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbModel"].Value = dtblModelNo[0].Rows[0]["modelNoId"];
                }
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC55:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Rack combobox when return from Rack Form
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromRackForm(decimal decId)
        {
            try
            {
                RackComboFillByGodown(Convert.ToDecimal(cmbGoDown.SelectedValue));
                if (decId.ToString() != "0")
                {
                    cmbRack.SelectedValue = decId;
                }
                else if (strRackName != string.Empty)
                {
                    cmbRack.SelectedValue = strRackName;
                }
                else
                {
                    cmbRack.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbRack.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC56:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        private void btnFrmClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("MPC14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMultipleProductCreation_Load(object sender, EventArgs e)
        {
            try
            {
                cmbProductGroup.Focus();
                UnitComboFill();
                TaxComboFill();
                cmbTaxApplication.SelectedIndex = 0;
                ProductGroupComboFill();
                BrandComboFill();
                ModelComboFill();
                RackComboFill();
                cmbRack.SelectedIndex = -1;
                SizeComboFill();
                GoDownComboFill();
                cmbUnit.SelectedIndex = -1;
                cmbGoDown.SelectedIndex = 0;
                cmbTaxApplication.Enabled = false;
                this.dgvMultipleProductCreation.Columns["dgvtxtPurchaseRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                this.dgvMultipleProductCreation.Columns["dgvtxtSalesRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                this.dgvMultipleProductCreation.Columns["dgvtxtMRP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC57:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To call ProductGroup Form for creating new productGroup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductGroupAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductGroup.SelectedValue != null)
                {
                    strProductGroupName = cmbProductGroup.SelectedValue.ToString();
                }
                else
                {
                    strProductGroupName = string.Empty;
                }
                frmProductGroup frmProductGroup = new frmProductGroup();
                frmProductGroup.MdiParent = formMDI.MDIObj;
                frmProductGroup open = Application.OpenForms["frmProductGroup"] as frmProductGroup;
                if (open == null)
                {
                    frmProductGroup.WindowState = FormWindowState.Normal;
                    frmProductGroup.MdiParent = formMDI.MDIObj;
                    frmProductGroup.CallFromMultipleProdutCreation(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.CallFromMultipleProdutCreation(this);
                    open.BringToFront();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To call Unit Form for creating new Unit 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUnit.SelectedValue != null)
                {
                    strunitName = cmbUnit.SelectedValue.ToString();
                }
                else
                {
                    strunitName = string.Empty;
                }
                frmUnit frmUnit = new frmUnit();
                frmUnit.MdiParent = formMDI.MDIObj;
                frmUnit open = Application.OpenForms["frmUnit"] as frmUnit;
                if (open == null)
                {
                    frmUnit.WindowState = FormWindowState.Normal;
                    frmUnit.MdiParent = formMDI.MDIObj;
                    frmUnit.CallFromMultipleProductCreation(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.CallFromMultipleProductCreation(this);
                    open.BringToFront();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To populate default values when user enters for new record 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleProductCreation_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                string strProductCode = BllProductCreation.ProductMax();
                foreach (DataGridViewRow row in dgvMultipleProductCreation.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = row.Index + 1;
                    if (AutomaticProductCode())
                    {
                        dgvMultipleProductCreation.Columns["dgvtxtProductCode"].ReadOnly = true;
                        strProductCode = (strProductCode.ToString());
                        row.Cells["dgvtxtProductCode"].Value = strProductCode;
                        strProductCode = (Convert.ToDecimal(strProductCode) + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Privilege check and Saves on 'Save' button click 
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
                MessageBox.Show("MPC19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checking invalid entries on Datagridview cell value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleProductCreation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CheckInvalidEntries(e);
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtPurchaseRate"].Value == null)
                    {
                        dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtPurchaseRate"].Value = 0;
                    }
                    else if (dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtSalesRate"].Value == null)
                    {
                        dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtSalesRate"].Value = 0;
                    }
                    else if (dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtMRP"].Value == null)
                    {
                        dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtMRP"].Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// on 'Close' button click
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
                MessageBox.Show("MPC21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
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
                MessageBox.Show("MPC22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enabling TaxApplication combobox on tax combobox selected valuechangaed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTax_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTax.SelectedIndex == 0)
                {
                    cmbTaxApplication.Enabled = false;
                }
                else
                {
                    cmbTaxApplication.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// call datagridview keypress on editing a cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleProductCreation_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl dgvtxt = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvtxt != null)
                {
                    dgvtxt.KeyPress += dgvtxt_KeyPress;
                }
                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
                    tb.KeyDown -= dgvMultipleProductCreation_KeyDown;
                    tb.KeyDown += new KeyEventHandler(dgvMultipleProductCreation_KeyDown);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To Call Godown Form  to create new godown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGodownAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGoDown.SelectedValue != null)
                {
                    strGodownName = cmbGoDown.SelectedValue.ToString();
                }
                else
                {
                    strGodownName = string.Empty;
                }
                frmGodown frmGodown = new frmGodown();
                frmGodown.MdiParent = formMDI.MDIObj;
                frmGodown open = Application.OpenForms["frmGodown"] as frmGodown;
                if (open == null)
                {
                    frmGodown.WindowState = FormWindowState.Normal;
                    frmGodown.MdiParent = formMDI.MDIObj;
                    frmGodown.CallFromMultipleProdutCreation(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.CallFromMultipleProdutCreation(this);
                    open.BringToFront();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To Call Rack Form  to create new Rack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRackAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRack.SelectedValue != null)
                {
                    strRackName = cmbRack.SelectedValue.ToString();
                }
                else
                {
                    strRackName = string.Empty;
                }
                decimal decGodownId = Convert.ToDecimal(cmbGoDown.SelectedValue);
                frmRack frmRack = new frmRack();
                frmRack.MdiParent = formMDI.MDIObj;
                frmRack open = Application.OpenForms["frmRack"] as frmRack;
                if (open == null)
                {
                    frmRack.WindowState = FormWindowState.Normal;
                    frmRack.MdiParent = formMDI.MDIObj;
                    frmRack.CallFromMultipleProdutCreation(this, decGodownId);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.CallFromMultipleProdutCreation(this, decGodownId);
                    open.BringToFront();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Removes row on Remove Link click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (dgvMultipleProductCreation.SelectedCells.Count > 0 && dgvMultipleProductCreation.CurrentRow != null)
                {
                    if (!dgvMultipleProductCreation.Rows[dgvMultipleProductCreation.CurrentRow.Index].IsNewRow)
                    {
                        if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RemoveFunction();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill rack on Godown combobox selected indexchanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGoDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGoDown.SelectedIndex > 0)
                {
                    cmbRack.Enabled = true;
                    btnRackAdd.Visible = true;
                    RackComboFillByGodown(Convert.ToDecimal(cmbGoDown.SelectedValue));
                }
                else
                {
                    cmbRack.Enabled = false;
                    btnRackAdd.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvMultipleProductCreation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Assigning values when edit mode stops for currently selected cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleProductCreation_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMultipleProductCreation.Columns[e.ColumnIndex].Name == "dgvtxtProductName")
                {
                    if (dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value != null && dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvtxtProductName"].Value.ToString() != string.Empty)
                    {
                        dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvcmbBrand"].Value = listBrand[0].Rows[0]["brandId"];
                        dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvcmbSize"].Value = listObjSize[0].Rows[0]["sizeId"];
                        dgvMultipleProductCreation.Rows[e.RowIndex].Cells["dgvcmbModel"].Value = dtblModelNo[0].Rows[0]["modelNoId"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// enables the enter key navigation for editing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleProductCreation_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMultipleProductCreation.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvMultipleProductCreation.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvMultipleProductCreation.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Form keyDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMultipleProductCreation_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)//ctrl+s
                {
                    if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                    {
                        btnSave.Focus();
                        btnSave_Click(sender, e);
                    }
                    else
                    {
                        Messages.NoPrivillageMessage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTax_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbTaxApplication.Enabled)
                    {
                        cmbTaxApplication.Focus();
                    }
                    else if (cmbGoDown.Enabled)
                    {
                        cmbGoDown.Focus();
                    }
                    else if (cmbRack.Enabled)
                    {
                        cmbRack.Focus();
                    }
                    else
                    {
                        dgvMultipleProductCreation.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbUnit.Enabled)
                    {
                        cmbUnit.Focus();
                        cmbUnit.SelectionStart = 0;
                        cmbUnit.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGoDown_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbRack.Enabled)
                    {
                        cmbRack.Focus();
                    }
                    else
                    {
                        dgvMultipleProductCreation.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbTaxApplication.Enabled)
                    {
                        cmbTaxApplication.Focus();
                        cmbTaxApplication.SelectionStart = 0;
                        cmbTaxApplication.SelectionLength = 0;
                    }
                    else if (cmbTax.Enabled)
                    {
                        cmbTax.Focus();
                        cmbTax.SelectionStart = 0;
                        cmbTax.SelectionLength = 0;
                    }
                    else
                    {
                        cmbUnit.Focus();
                        cmbUnit.SelectionStart = 0;
                        cmbUnit.SelectionLength = 0;
                    }
                }
                //...............................CTRL+C...................................//
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnGodownAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRack_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvMultipleProductCreation.Enabled)
                    {
                        dgvMultipleProductCreation.Focus();
                        dgvMultipleProductCreation.CurrentCell = dgvMultipleProductCreation.Rows[dgvMultipleProductCreation.Rows.Count - 1].Cells["dgvtxtSlNo"];
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbGoDown.Enabled)
                    {
                        cmbGoDown.Focus();
                        cmbGoDown.SelectionStart = 0;
                        cmbGoDown.SelectionLength = 0;
                    }
                }
                //......................CTRL+C..................................//
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnRackAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTaxApplication_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbGoDown.Enabled)
                    {
                        cmbGoDown.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbTax.Enabled)
                    {
                        cmbTax.Focus();
                        cmbTax.SelectionStart = 0;
                        cmbTax.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Right)
                {
                    if (btnClear.Enabled)
                    {
                        btnClear.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dgvMultipleProductCreation.Enabled)
                    {
                        dgvMultipleProductCreation.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUnit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbTax.Enabled)
                    {
                        cmbTax.Focus();
                    }
                    else if (cmbGoDown.Enabled)
                    {
                        cmbGoDown.Focus();
                    }
                    else
                    {
                        dgvMultipleProductCreation.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbProductGroup.Enabled)
                    {
                        cmbProductGroup.Focus();
                        cmbProductGroup.SelectionStart = 0;
                        cmbProductGroup.SelectionLength = 0;
                    }
                }
                //......................CTRL+C..................................//
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnUnitAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbUnit.Enabled)
                    {
                        cmbUnit.Focus();
                    }
                }
                //......................CTRL+C..................................//
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnProductGroupAdd_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMultipleProductCreation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{tab}");
                    dgvMultipleProductCreation.Columns["dgvtxtCheck"].ReadOnly = true;
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    if (dgvMultipleProductCreation.Columns[dgvMultipleProductCreation.CurrentCell.ColumnIndex].Name == "dgvcmbBrand")
                    {
                        if (dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbBrand"].Value != null)
                        {
                            StrBrand = dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbBrand"].FormattedValue.ToString();
                        }
                        else
                        {
                            StrBrand = string.Empty;
                        }
                        frmBrand frm = new frmBrand();
                        frm.MdiParent = formMDI.MDIObj;
                        frm.CallFromMultipleProdutCreation(this);
                        this.Enabled = false;
                    }
                    if (dgvMultipleProductCreation.Columns[dgvMultipleProductCreation.CurrentCell.ColumnIndex].Name == "dgvcmbSize")
                    {
                        if (dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbSize"].Value != null)
                        {
                            StrSize = dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbSize"].FormattedValue.ToString();
                        }
                        else
                        {
                            StrSize = string.Empty;
                        }
                        frmSize frm = new frmSize();
                        frm.MdiParent = formMDI.MDIObj;
                        frm.CallMultipleProductCreation(this);
                        this.Enabled = false;
                    }
                    if (dgvMultipleProductCreation.Columns[dgvMultipleProductCreation.CurrentCell.ColumnIndex].Name == "dgvcmbModel")
                    {
                        if (dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbModel"].Value != null)
                        {
                            strModel = dgvMultipleProductCreation.CurrentRow.Cells["dgvcmbModel"].FormattedValue.ToString();
                        }
                        else
                        {
                            strModel = string.Empty;
                        }
                        frmModalNo frm = new frmModalNo();
                        frm.MdiParent = formMDI.MDIObj;
                        frm.CallMultipleProductCreation(this);
                        this.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MPC48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
