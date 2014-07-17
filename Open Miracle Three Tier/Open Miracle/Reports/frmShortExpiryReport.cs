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
    public partial class frmShortExpiryReport : Form
    {
  
        #region Functions
        /// <summary>
        /// Create an Instance of a frmShortExpiryReport class
        /// </summary>
        public frmShortExpiryReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill the Productgroup combobox
        /// </summary>
        public void ProductGroupComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ProductGroupBll BllProductGroup = new ProductGroupBll();
                listObj = BllProductGroup.ProductGroupViewAll();
                DataRow dr = listObj[0].NewRow();
                dr["groupName"] = "All";
                dr["groupId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbProductGroup.DataSource = listObj[0];
                cmbProductGroup.DisplayMember = "groupName";
                cmbProductGroup.ValueMember = "groupId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the Product combobox
        /// </summary>
        public void ProductNameComboFill()
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                List<DataTable> listObjProductName = new List<DataTable>();
                listObjProductName = BllProductCreation.ProductViewAllForComboBox();
                DataRow dr = listObjProductName[0].NewRow();
                dr["ProductName"] = "All";
                dr["ProductId"] = 0;
                listObjProductName[0].Rows.InsertAt(dr, 0);
                cmbProductName.DataSource = listObjProductName[0];
                cmbProductName.ValueMember = "productId";
                cmbProductName.DisplayMember = "productName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the barnd combobox
        /// </summary>
        public void BrandComboFill()
        {
            try
            {
                List<DataTable> listBrand = new List<DataTable>();
                BrandBll BllBrand = new BrandBll();
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
                MessageBox.Show("SER:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ModelNo combobox
        /// </summary>
        public void ModelNoComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ModelNoBll BllModelNo = new ModelNoBll();
                listObj = BllModelNo.ModelNoViewAll();
                DataRow dr = listObj[0].NewRow();
                dr["modelno"] = "All";
                dr["modelNoId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbModelno.DataSource = listObj[0];
                cmbModelno.DisplayMember = "modelNo";
                cmbModelno.ValueMember = "modelNoId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill size combobox
        /// </summary>
        public void SizeComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                SizeBll BllSize = new SizeBll();
                listObj = BllSize.SizeViewAll();
                DataRow dr = listObj[0].NewRow();
                dr["size"] = "All";
                dr["sizeId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbSize.DataSource = listObj[0];
                cmbSize.DisplayMember = "size";
                cmbSize.ValueMember = "sizeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill godown combobox
        /// </summary>
        public void GodownComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                GodownBll BllGodown = new GodownBll();
                listObj = BllGodown.GodownViewAll();
                DataRow dr = listObj[0].NewRow();
                dr["godownName"] = "All";
                dr["godownId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbGodown.DataSource = listObj[0];
                cmbGodown.DisplayMember = "godownName";
                cmbGodown.ValueMember = "godownId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                listObj = BllRack.RackViewAll();
                DataRow dr = listObj[0].NewRow();
                dr["rackName"] = "All";
                dr["rackId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbRack.DataSource = listObj[0];
                cmbRack.DisplayMember = "rackName";
                cmbRack.ValueMember = "rackId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the short expiry products
        /// </summary>
        public void GridFill()
        {
            RemainderBll bllRemainder = new RemainderBll();
            try
            {
                List<DataTable> list = new List<DataTable>();
                
                decimal decA = Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString());
                decimal decB = Convert.ToDecimal(cmbProductName.SelectedValue.ToString());
                decimal decC = Convert.ToDecimal(cmbBrand.SelectedValue.ToString());
                decimal decD = Convert.ToDecimal(cmbSize.SelectedValue.ToString());
                decimal decE = Convert.ToDecimal(cmbModelno.SelectedValue.ToString());
                decimal decF = Convert.ToDecimal(cmbGodown.SelectedValue.ToString());
                decimal decG = Convert.ToDecimal(cmbRack.SelectedValue.ToString());
                decimal decproExp = 0;
                string strproExp = string.Empty;
                if (txtProductExpire.Text != string.Empty)
                {
                    decproExp = Convert.ToDecimal(txtProductExpire.Text.ToString());
                }
                else
                {
                    decproExp = 0;
                }
                if (cmbProductExpire.Text != string.Empty)
                {
                    strproExp = cmbProductExpire.Text;
                }
                else
                {
                    strproExp = string.Empty;
                }
                list = bllRemainder.ShortExpiryReportGridFill(decA, decB, decC, decD, decE, decF, decG, decproExp, strproExp, PublicVariables._dtCurrentDate);
                dgvShortExpiryReport.DataSource = list[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void clear()
        {
            try
            {
                cmbBrand.SelectedIndex = 0;
                cmbGodown.SelectedIndex = 0;
                cmbProductName.SelectedIndex = 0;
                cmbProductGroup.SelectedIndex = 0;
                cmbRack.SelectedIndex = 0;
                cmbSize.SelectedIndex = 0;
                cmbModelno.SelectedIndex = 0;
                txtProductExpire.Text = String.Empty;
                cmbProductExpire.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the report
        /// </summary>
        public void PrintReport()
        {
            try
            {
               // ReminderSP SPReminder = new ReminderSP();
                RemainderBll bllRemainder = new RemainderBll();
                decimal decA = Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString());
                decimal decB = Convert.ToDecimal(cmbProductName.SelectedValue.ToString());
                decimal decC = Convert.ToDecimal(cmbBrand.SelectedValue.ToString());
                decimal decD = Convert.ToDecimal(cmbSize.SelectedValue.ToString());
                decimal decE = Convert.ToDecimal(cmbModelno.SelectedValue.ToString());
                decimal decF = Convert.ToDecimal(cmbGodown.SelectedValue.ToString());
                decimal decG = Convert.ToDecimal(cmbRack.SelectedValue.ToString());
                decimal decproExp = 0;
                string strproExp = string.Empty;
                if (txtProductExpire.Text != string.Empty)
                {
                    decproExp = Convert.ToDecimal(txtProductExpire.Text.ToString());
                }
                else
                {
                    decproExp = 0;
                }
                if (cmbProductExpire.Text != string.Empty)
                {
                    strproExp = cmbProductExpire.Text;
                }
                else
                {
                    strproExp = string.Empty;
                }
                DataSet dsShortExpiryReport = bllRemainder.ShortExpiryReportPrinting(decA, decB, decC, decD, decE, decF, decG, decproExp, strproExp, PublicVariables._dtCurrentDate, 1);
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                if (dgvShortExpiryReport.Rows.Count > 0)
                {
                    frmReport.ShortExpiryReportPrinting(dsShortExpiryReport);
                }
                else
                {
                    Messages.InformationMessage("No Data Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Short_Expiry_Report_Load(object sender, EventArgs e)
        {
            try
            {
                txtProductExpire.Focus();
                ProductGroupComboFill();
                ProductNameComboFill();
                BrandComboFill();
                ModelNoComboFill();
                SizeComboFill();
                GodownComboFill();
                RackComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtProductExpire.Text == string.Empty)
                {
                    Messages.InformationMessage("Please enter expiry within");
                    txtProductExpire.Focus();
                }
                else if(cmbProductExpire.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Please select expiry within");
                    cmbProductExpire.Focus();
                }
                else if (Convert.ToDecimal(txtProductExpire.Text) > 7999 && cmbProductExpire.SelectedIndex==2)
                {
                    Messages.InformationMessage("Please enter a valid year");
                    txtProductExpire.Focus();
                }
                else
                {
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtProductExpire.Focus();
                txtProductExpire.Text = string.Empty;
                cmbProductExpire.SelectedIndex = -1;
                ProductGroupComboFill();
                ProductNameComboFill();
                BrandComboFill();
                ModelNoComboFill();
                SizeComboFill();
                GodownComboFill();
                RackComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvShortExpiryReport.Rows.Count>0)
                {
                PrintReport();
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// validation for txtProductExpire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductExpire_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.NumberOnly(sender, e);
                txtProductExpire.MaxLength = 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvShortExpiryReport, "Short Expiry Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:28 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
        /// <summary>
        /// Enterkey navigation of txtProductExpire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductExpire_KeyDown(object sender, KeyEventArgs e)
        {
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        cmbProductExpire.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SER:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbProductExpire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductExpire_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductName.Focus();
                }
                
                else if (e.KeyCode == Keys.Back)
                {
                    txtProductExpire.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbProductGroup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbModelno.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbProductName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbProductName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductName_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductGroup.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbProductExpire.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbGodown.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbModelno.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbModelno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModelno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbBrand.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbProductGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbRack.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbGodown.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbSize.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbBrand.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnSearch.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSize.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmShortExpiryReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SER:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of btnSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbRack.Focus();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    btnPrint.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnPrint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SER:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
 
    }
}
