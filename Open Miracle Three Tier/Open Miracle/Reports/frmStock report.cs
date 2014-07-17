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
    public partial class frmStockReport : Form
    {

        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll TransactionGenericFillObj = new TransactionsGeneralFillBll();//used to fill product combofill      
        ProductCreationBll BllProductCreation = new ProductCreationBll();
        StockPostingBll BllStockPosting = new StockPostingBll();
        //StockPostingSP spStock = new StockPostingSP();
        bool isFormLoad = false;
        #endregion

        #region functions
        /// <summary>
        /// Create an Instance of a frmShortExpiryReport class
        /// </summary>
        public frmStockReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// To fill productgroup combobox
        /// </summary>
        public void ProductGroupComboFill()
        {
            try
            {
                 TransactionGenericFillObj.ProductGroupViewAll(cmbProductgroup, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill modelNo combobox
        /// </summary>
        public void ModelNoComboFill()
        {
            try
            {
                TransactionGenericFillObj.ModelNoViewAll(cmbModel, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill size combobox
        /// </summary>
        public void SizeComboFill()
        {
            try
            {
               TransactionGenericFillObj.SizeViewAll(cmbSize, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill brand combobox
        /// </summary>
        public void BrandComboFill()
        {
            List<DataTable> listBrand = new List<DataTable>();
            BrandBll BllBrand = new BrandBll();
            try
            {


                listBrand = BllBrand.BrandViewAll();
                DataRow dr = listBrand[0].NewRow();
                dr["brandName"] = "All";
                dr["brandId"] = 0;
                listBrand[0].Rows.InsertAt(dr, 0);
                cmbBrand.DataSource = listBrand[0];
                cmbBrand.DisplayMember = "brandName";
                cmbBrand.ValueMember = "brandId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill godown combobox
        /// </summary>
        public void GodownComboFill()
        {
            try
            {
                GodownBll BllGodown = new GodownBll();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllGodown.GodownViewAll();
                DataRow drowSelect = listObj[0].NewRow();
                drowSelect[0] = 0;
                drowSelect[1] = "All";
                listObj[0].Rows.InsertAt(drowSelect, 0);
                cmbGodown.DataSource = listObj[0];
                cmbGodown.DisplayMember = "godownName";
                cmbGodown.ValueMember = "godownId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill rack combobox
        /// </summary>
        public void RackComboFill()
        {
            try
            {

                RackBll BllRack = new RackBll();
                List<DataTable> listObj = new List<DataTable>();
                if (cmbGodown.SelectedValue.ToString() != "System.Data.DataRowView")
                {


                    listObj = BllRack.RackViewAllByGodown(Convert.ToDecimal(cmbGodown.SelectedValue.ToString()));

                    DataRow drowSelect = listObj[0].NewRow();
                    drowSelect[0] = 0;
                    drowSelect["rackName"] = "All";
                    cmbRack.DataSource = listObj;
                    cmbRack.DisplayMember = "rackName";
                    cmbRack.ValueMember = "rackId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill tax combobox
        /// </summary>
        public void TaxComboFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAllForProduct();
                DataRow drowSelect = ListObj[0].NewRow();
                drowSelect[0] = 0;
                drowSelect["taxName"] = "All";
                ListObj[0].Rows.InsertAt(drowSelect, 0);
                cmbTax.DataSource = ListObj[0];
                cmbTax.ValueMember = "taxId";
                cmbTax.DisplayMember = "taxName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the grid
        /// </summary>
        public void GridFill()
        {
            try
            {

                CurrencyInfo InfoCurrency = new CurrencyInfo();
                CurrencyBll BllCurrency = new CurrencyBll();
                InfoCurrency = BllCurrency.CurrencyView(1);
                int inDecimalPlaces = InfoCurrency.NoOfDecimalPlaces;
                string calculationMethod = string.Empty;
                SettingsInfo InfoSettings = new SettingsInfo();
                SettingsBll BllSettings = new SettingsBll();
                //--------------- Selection Of Calculation Method According To Settings ------------------// 

                if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "FIFO")
                {
                    calculationMethod = "FIFO";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Average Cost")
                {
                    calculationMethod = "Average Cost";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "High Cost")
                {
                    calculationMethod = "High Cost";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Low Cost")
                {
                    calculationMethod = "Low Cost";
                }
                else if (BllSettings.SettingsStatusCheck("StockValueCalculationMethod") == "Last Purchase Rate")
                {
                    calculationMethod = "Last Purchase Rate";
                }

                // StockPostingSP spstock = new StockPostingSP();
                StockPostingBll BllStockPosting = new StockPostingBll();
                decimal decrackId = 0;
                DataSet dsstock = new DataSet();
                List<DataTable> list = new List<DataTable>();

                if (cmbRack.SelectedValue != null)
                {
                    decrackId = Convert.ToDecimal(cmbRack.SelectedValue.ToString());
                }

                list = BllStockPosting.StockReportGridFill1(txtproductName.Text, Convert.ToDecimal(cmbBrand.SelectedValue.ToString()), Convert.ToDecimal(cmbModel.SelectedValue.ToString()), (txtProductCode.Text), Convert.ToDecimal(cmbGodown.SelectedValue.ToString()), decrackId, Convert.ToDecimal(cmbSize.SelectedValue.ToString()), Convert.ToDecimal(cmbTax.SelectedValue.ToString()), Convert.ToDecimal(cmbProductgroup.SelectedValue.ToString()), txtBatchName.Text);

                if (list[0].Rows.Count > 0)
                {
                    decimal decTotal = 0;
                    for (int i = 0; i < list[0].Rows.Count; i++)
                    {
                        if (list[0].Rows[i]["stockvalue"].ToString() != string.Empty)
                        {
                            decTotal = decTotal + Convert.ToDecimal(list[0].Rows[i]["stockvalue"].ToString());
                        }

                    }

                    decTotal = Math.Round(decTotal, 2);
                    txtTotal.Text = decTotal.ToString();
                }
                else
                {
                    txtTotal.Text = "0.00";
                }


                dgvStockReport.DataSource = list[0];
                //if (dtbl.Columns.Count > 0)
                //{
                //    dgvStockReport.Columns["stockvalue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                BrandComboFill();
                ProductGroupComboFill();
                ModelNoComboFill();
                SizeComboFill();
                GodownComboFill();
                TaxComboFill();
                txtproductName.Text = string.Empty;
                txtProductCode.Text = string.Empty;
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStockReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On selected index change of cmbGodown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGodown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbGodown.SelectedIndex > 0)
                {
                    RackComboFill();
                    decimal decGodownId = Convert.ToDecimal(cmbGodown.SelectedValue.ToString());
                }
                else
                {
                    RackComboFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnreset_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvStockReport.Rows.Count > 0)
                {
                    decimal decrackId = 0;
                    DataSet dsStockReport = BllStockPosting.StockReportPrint(txtproductName.Text, Convert.ToDecimal(cmbBrand.SelectedValue.ToString()), Convert.ToDecimal(cmbModel.SelectedValue.ToString()), txtProductCode.Text, Convert.ToDecimal(cmbGodown.SelectedValue.ToString()), decrackId, Convert.ToDecimal(cmbSize.SelectedValue.ToString()), Convert.ToDecimal(cmbTax.SelectedValue.ToString()), Convert.ToDecimal(cmbProductgroup.SelectedValue.ToString()), txtBatchName.Text);

                    frmReport frmReport = new frmReport();
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.StockReportPrinting(dsStockReport, txtTotal.Text);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvStockReport, "Stock Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region navigation
        /// <summary>
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStockReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("STKR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey navigation of cmbProductgroup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductgroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    cmbSize.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    cmbBrand.Focus();

                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbProductgroup.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbBrand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbTax.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSize.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbTax
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTax_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    cmbModel.Focus();

                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbBrand.Focus();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    cmbRack.Focus();

                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbTax.Focus();

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbRack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRack_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    cmbGodown.Focus();

                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbModel.Focus();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbGodown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGodown_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    txtproductName.Focus();
                    txtproductName.SelectionStart = txtproductName.Text.Length;

                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbRack.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtproductName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtproductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductCode.SelectionStart = txtProductCode.Text.Length;
                    txtProductCode.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtproductName.SelectionStart == 0 || txtproductName.Text == string.Empty)
                    {
                        cmbGodown.Focus();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtProductCode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    txtBatchName.Focus();
                    txtBatchName.SelectionStart = 0;

                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.SelectionStart == 0 || txtProductCode.Text == string.Empty)
                    {

                        txtproductName.Focus();
                        txtproductName.SelectionStart = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtBatchName.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("STKR:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtBatchName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    txtproductName.Focus();
                    txtproductName.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("STKR:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}






