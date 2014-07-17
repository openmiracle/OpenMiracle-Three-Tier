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
using ENTITY;
using OpenMiracle.BLL;
namespace Open_Miracle
{
    public partial class frmPriceListReport : Form
    {

        #region public variable
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll TransactionGenericFillObj = new TransactionsGeneralFillBll();//used to fill product combofill       
        ProductCreationBll BllProductCreation = new ProductCreationBll();
        decimal decGroupId = 0;
        decimal decModelId = 0;
        decimal decSizeId = 0;
        string strProductName = string.Empty;
        decimal decPricingLevelId = 0;
        PriceListBll BllPriceList = new PriceListBll();
        DateValidation dateValidationObj = new DateValidation();//to check date valid or not       
        List<DataTable> listObjPriceListReport = new List<DataTable>();
        int maxSerialNo = 0;
        #endregion
        #region functions
        /// <summary>
        /// Create an Instance of a frmPriceListReport class
        /// </summary>
        public frmPriceListReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void clear()
        {
            try
            {
                cbxPurchaseRate.Checked = true;
                cbxSalesRate.Checked = true;
                cbxlastSalesRate.Checked = true;
                CbxStandardRate.Checked = true;
                cbxMrp.Checked = true;
                ProductGroupComboFill();
                ProductComboFill();
                SizeComboFill();
                PricingLevelComboFill();
                ModelNoComboFill();
                PriceListGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill pricelist gridfill
        /// </summary>
        public void PriceListGridFill()
        {
            try
            {
                if (cmbProductGroup.SelectedIndex == 0)
                {
                    decGroupId = 0;
                }
                else
                {
                    decGroupId = Convert.ToDecimal(cmbProductGroup.SelectedValue);
                }
                if (cmbModel.SelectedIndex == 0)
                {
                    decModelId = 0;
                }
                else
                {
                    decModelId = Convert.ToDecimal(cmbModel.SelectedValue);
                }
                if (cmbProduct.SelectedIndex == 0)
                {
                    strProductName = string.Empty;
                }
                else
                {
                    strProductName = cmbProduct.Text;
                }
                if (cmbSize.SelectedIndex == 0)
                {
                    decSizeId = 0;
                }
                else
                {
                    decSizeId = Convert.ToDecimal(cmbSize.SelectedValue);
                }
                if (cmbPricingLevel.SelectedIndex == 0)
                {
                    decPricingLevelId = 0;
                }
                else
                {
                    decPricingLevelId = Convert.ToDecimal(cmbPricingLevel.SelectedValue);
                }
                listObjPriceListReport = BllPriceList.PriceListGridFill(decGroupId, strProductName, decSizeId, decModelId, decPricingLevelId);
                dgvPriceList.DataSource = listObjPriceListReport[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the productgroup combobox
        /// </summary>
        public void ProductGroupComboFill()
        {
            try
            {
                TransactionGenericFillObj.ProductGroupViewAll(cmbProductGroup, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the product combobox
        /// </summary>
        public void ProductComboFill()
        {
            try
            {
                List<DataTable> listObj = BllProductCreation.ProductViewAll();
                DataRow dr = listObj[0].NewRow();
                dr["productId"] = 0;
                dr["productName"] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbProduct.DataSource = listObj[0];
                cmbProduct.DisplayMember = "productName";
                cmbProduct.ValueMember = "productId";
                cmbProduct.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Size combobox
        /// </summary>
        public void SizeComboFill()
        {
            try
            {
               TransactionGenericFillObj.SizeViewAll(cmbSize, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the pricinglevel combobox
        /// </summary>
        public void PricingLevelComboFill()
        {
            try
            {
                TransactionGenericFillObj.PricingLevelViewAll(cmbPricingLevel, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill modelno combobox
        /// </summary>
        public void ModelNoComboFill()
        {
            try
            {
                TransactionGenericFillObj.ModelNoViewAll(cmbModel, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate serialno
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvPriceList.Rows)
                {
                    row.Cells["dgvtxtSerialNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events

        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPriceListReport_Load(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of cbxPurchaseRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPurchaseRate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxPurchaseRate.Checked)
                {
                    dgvPriceList.Columns["PurchaseRate"].Visible = true;
                }
                else
                {
                    dgvPriceList.Columns["PurchaseRate"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of cbxlastSalesRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxlastSalesRate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxlastSalesRate.Checked)
                {
                    dgvPriceList.Columns["LastSalesRate"].Visible = true;
                }
                else
                {
                    dgvPriceList.Columns["LastSalesRate"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of cbxMrp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxMrp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxMrp.Checked)
                {
                    dgvPriceList.Columns["MRP"].Visible = true;
                }
                else
                {
                    dgvPriceList.Columns["MRP"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of cbxSalesRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSalesRate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxSalesRate.Checked)
                {
                    dgvPriceList.Columns["SalesRate"].Visible = true;
                }
                else
                {
                    dgvPriceList.Columns["SalesRate"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of CbxStandardRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxStandardRate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbxStandardRate.Checked)
                {
                    dgvPriceList.Columns["StandardRate"].Visible = true;
                }
                else
                {
                    dgvPriceList.Columns["StandardRate"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                PriceListGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On print button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPriceList.Rows.Count > 0)
                {
                    frmReport frmReport = new frmReport();
                    frmReport.MdiParent = formMDI.MDIObj;
                    DataTable dtblOption = new DataTable();
                    dtblOption.Columns.Add("PurchaseRate", typeof(String));
                    dtblOption.Columns.Add("SalesRate", typeof(String));
                    dtblOption.Columns.Add("LastSalesRate", typeof(String));
                    dtblOption.Columns.Add("StandardRate", typeof(String));
                    dtblOption.Columns.Add("MRP", typeof(String));
                    dtblOption.Columns.Add("Price", typeof(String));
                    DataRow dr = dtblOption.NewRow();
                    dr["PurchaseRate"] = cbxPurchaseRate.Checked ? "True" : "False";
                    dr["SalesRate"] = cbxSalesRate.Checked ? "True" : "False";
                    dr["LastSalesRate"] = cbxlastSalesRate.Checked ? "True" : "False";
                    dr["StandardRate"] = CbxStandardRate.Checked ? "True" : "False";
                    dr["MRP"] = cbxMrp.Checked ? "True" : "False";
                    dr["Price"] = "True";
                    dtblOption.Rows.Add(dr);
                    DataSet ds = new DataSet();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    List<DataTable> listObjPriceList = BllPriceList.PriceListReportPrint(decGroupId, strProductName, decSizeId, decModelId, decPricingLevelId);
                    List<DataTable> listObjCompanyReport = bllCompanyCreation.CompanyViewDataTable(1);
                    DataTable dtblPriceListGridFill = listObjPriceListReport[0].Copy();
                    ds.Tables.Add(listObjCompanyReport[0]);
                    ds.Tables.Add(listObjPriceList[0]);
                    ds.Tables.Add(dtblOption);
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.PriceListReportPrinting(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Generate serialno on rows added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPriceList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
                maxSerialNo++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On 'Export' button click to export the report to Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExportNew ex = new ExportNew();
                ex.ExportExcel(dgvPriceList, "Price List Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("RPL31: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation

        /// <summary>
        /// Enterkey and backspace navigation of cmbProductGroup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbModel.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbProduct.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of cmbProduct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbSize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSize_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbPricingLevel.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbModel.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbModel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbSize.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbProductGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbPricingLevel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPricingLevel_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxPurchaseRate.Enabled)
                    {
                        cbxPurchaseRate.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbSize.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cbxPurchaseRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cbxlastSalesRate.Checked)
                    {
                        cbxlastSalesRate.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbPricingLevel.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of btnSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cbxlastSalesRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxlastSalesRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxMrp.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cbxPurchaseRate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cbxMrp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxMrp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cbxSalesRate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cbxlastSalesRate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cbxSalesRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSalesRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    CbxStandardRate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cbxMrp.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of CbxStandardRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxStandardRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cbxSalesRate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPriceListReport_KeyDown(object sender, KeyEventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(" RPL30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
