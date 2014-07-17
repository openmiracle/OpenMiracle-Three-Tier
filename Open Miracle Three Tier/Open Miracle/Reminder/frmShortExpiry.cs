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
    public partial class frmShortExpiry : Form
    {
        #region Variables
        /// <summary>
        /// Public varaible declaration part
        /// </summary>
        frmReminderPopUp frmReminderPopupObj;
        #endregion
        #region FUNCTIONS
        /// <summary>
        /// Creates an instance of frmShortExpiry class
        /// </summary>
        public frmShortExpiry()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void clear()
        {
            try
            {
                cmbBrand.SelectedIndex = 0;
                cmbGodown.SelectedIndex = 0;
                cmbProduct.SelectedIndex = 0;
                cmbProductGroup.SelectedIndex = 0;
                cmbRack.SelectedIndex = 0;
                cmbTax.SelectedIndex = 0;
                cmbSize.SelectedIndex = 0;
                cmbModelno.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void gridfill()
        {
            RemainderBll bllRemainder = new RemainderBll();
            try
            {
                List<DataTable> list = new List<DataTable>();
                list = bllRemainder.ShortExpiryReminderGridFill(Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString()), Convert.ToDecimal(cmbProduct.SelectedValue.ToString()), Convert.ToDecimal(cmbBrand.SelectedValue.ToString()), Convert.ToDecimal(cmbSize.SelectedValue.ToString()), Convert.ToDecimal(cmbModelno.SelectedValue.ToString()), Convert.ToDecimal(cmbTax.SelectedValue.ToString()), Convert.ToDecimal(cmbGodown.SelectedValue.ToString()), Convert.ToDecimal(cmbRack.SelectedValue.ToString()));
                dgvProductExpiry.DataSource = list[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Brand combobox
        /// </summary>
        public void BrandComboFill()
        {
            BrandBll BllBrand = new BrandBll();
            List<DataTable> listBrand = new List<DataTable>();
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
                MessageBox.Show("SE:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Tax combobox
        /// </summary>
        public void TaxComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                TaxBll bllTax = new TaxBll();
                ListObj = bllTax.TaxViewAllForProduct();
                DataRow dr = ListObj[0].NewRow();
                dr["taxname"] = "All";
                dr["taxId"] = 0;
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbTax.DataSource = ListObj[0];
                cmbTax.DisplayMember = "taxName";
                cmbTax.ValueMember = "taxId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SE:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ProductGroup combobox
        /// </summary>
        public void GroupComboFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ProductGroupBll BllProductgroup = new ProductGroupBll();
                listObj = BllProductgroup.ProductGroupViewAll();
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
                MessageBox.Show("SE:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Godown combobox
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
                MessageBox.Show("SE:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Size combobox
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
                MessageBox.Show("SE:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Product combobox
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
                cmbProduct.DataSource = listObjProductName[0];
                cmbProduct.ValueMember = "productId";
                cmbProduct.DisplayMember = "productName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SE:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form frmReminderPopUp form to view details
        /// </summary>
        /// <param name="frmReminder"></param>
        public void CallFromReminder(frmReminderPopUp frmReminder)
        {
            RemainderBll bllRemainder = new RemainderBll();
            try
            {
                base.Show();
                List<DataTable> list = new List<DataTable>();
                list = bllRemainder.ShortExpiryReminder(0, 0, 0, 0, 0, 0, 0, 0);
                dgvProductExpiry.DataSource = list;
                this.frmReminderPopupObj = frmReminder;
                frmReminderPopupObj.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmShortExpiry_Load(object sender, EventArgs e)
        {
            try
            {
                BrandComboFill();
                TaxComboFill();
                ModelNoComboFill();
                ProductNameComboFill();
                GroupComboFill();
                GodownComboFill();
                SizeComboFill();
                RackComboFill();
                cmbProductGroup.Focus();
                gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclose_Click(object sender, EventArgs e)
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
                MessageBox.Show("SE:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Reset' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
                gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enables the objects of other forms on form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmShortExpiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmReminderPopupObj != null)
                {
                    frmReminderPopupObj.Enabled = true;
                    frmReminderPopupObj.Activate();
                    frmReminderPopupObj.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        cmbProduct.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SE:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBrand_KeyDown(object sender, KeyEventArgs e)
        {
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        cmbSize.Focus();
                    }
                    else if (e.KeyCode == Keys.Back)
                    {
                        cmbProduct.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSize_KeyDown(object sender, KeyEventArgs e)
        {
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        cmbModelno.Focus();
                    }
                    else if (e.KeyCode == Keys.Back)
                    {
                        cmbBrand.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbModelno_KeyDown(object sender, KeyEventArgs e)
        {
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
                    MessageBox.Show("SE:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTax_KeyDown(object sender, KeyEventArgs e)
        {
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
                    MessageBox.Show("SE:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGodown_KeyDown(object sender, KeyEventArgs e)
        {
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
                    MessageBox.Show("SE:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbRack_KeyDown(object sender, KeyEventArgs e)
        {
            {
                try
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        cmbGodown.Focus();
                    }
                    else if (e.KeyCode == Keys.Enter)
                    {
                        btnSearch.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SE:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmShortExpiry_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        Messages.CloseMessage(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SE:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
             try
            {
            if (e.KeyCode == Keys.Back)
            {
                cmbRack.Focus();
            }
            }
             catch (Exception ex)
             {
                 MessageBox.Show("SE:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }
    }
}
