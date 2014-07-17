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
    public partial class frmProductDetails : Form
    {
        #region Public Variables
        frmProductSearch frmProductSearchObj = null;
        #endregion
        #region Function
        /// <summary>
        /// Creates an instance of frmProductDetails class
        /// </summary>
        public frmProductDetails()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to view the details of product
        /// </summary>
        /// <param name="decId"></param>
        public void view(decimal decId)
        {
            try
            {
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                List<DataTable> listObj = BllProductCreation.ProductDetailsForProductSearch(decId);
                foreach (DataRow dr in listObj[0].Rows)
                {
                    lblProductCode.Text = dr["productCode"].ToString();
                    lblProductGroup.Text = dr["groupName"].ToString();
                    lblProductName.Text = dr["productName"].ToString();
                    lblBrand.Text = dr["brandName"].ToString();
                    lblCurrentStock.Text = dr["Currentstock"].ToString();
                    lblModelNo.Text = dr["modelNo"].ToString();
                    lblSize.Text = dr["size"].ToString();
                    lbltax.Text = dr["taxName"].ToString();
                    lblUnit.Text = dr["unitName"].ToString();
                    lblTaxApplicable.Text = dr["taxapplicableOn"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD :01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmProductSearch
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="frmProductObj"></param>
        public void callFromProductSearchTo(decimal productId, frmProductSearch frmProductObj)
        {
            try
            {
                frmProductObj.Enabled = false;
                this.frmProductSearchObj = frmProductObj;
                base.Show();
                view(productId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD :02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On Form closing activates the frmProductSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmProductSearchObj != null)
                {
                    frmProductSearchObj.Enabled = true;
                    frmProductSearchObj.ProductSearchGridFill();
                    frmProductSearchObj.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD :03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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
                MessageBox.Show("PD:04" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProductDetails_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("PD :05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
