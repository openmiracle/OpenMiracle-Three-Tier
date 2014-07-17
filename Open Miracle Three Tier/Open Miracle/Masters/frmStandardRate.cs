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
 
    public partial class frmStandardRate : Form
    {
        #region Public Variables
        /// <summary>
        /// public variable declaration part
        /// </summary>
        frmStandardRatePopup frmStandardRatePopupObj;

        #endregion

        #region Function
        /// <summary>
        /// create an instance for frmStandardRate Class
        /// </summary>
        public frmStandardRate()
        {
            InitializeComponent();
        }
        /// <summary>
        /// To reset The form here
        /// </summary>
        public void Clear()
        {
            try
            {
                ProductGroupComboFill();
                cmbProductGroup.SelectedIndex = 0;
                txtProductCode.Clear();
                txtProductName.Clear();
                GridFill();
                cmbProductGroup.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Product group combofill Function
        /// </summary>
        public void ProductGroupComboFill()
        {
            try
            {
                ProductGroupBll BllProductGroup = new ProductGroupBll();
                List<DataTable> listObjProductGroup = new List<DataTable>();
                listObjProductGroup = BllProductGroup.ProductGroupViewForComboFill();
                cmbProductGroup.DataSource = listObjProductGroup[0];
                cmbProductGroup.ValueMember = "groupId";
                cmbProductGroup.DisplayMember = "groupName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// GridFill Function
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                ProductGroupBll BllProductGroup = new ProductGroupBll();
                listObj = BllProductGroup.ProductAndUnitViewAllForGridFill(Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString()), txtProductCode.Text.Trim(), txtProductName.Text.Trim());
                dgvStandardRate.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// When form Load call the clear Function 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStandardRate_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Button Search button click
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
                MessageBox.Show("SR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clear button click
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
                MessageBox.Show("SR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Close button Click
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
                MessageBox.Show("SR7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Once complete the grid functions cleare the grid here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStandardRate_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvStandardRate.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To call the Standard Rate popUp Form to create a new Standard rate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStandardRate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvStandardRate.CurrentCell == dgvStandardRate.CurrentRow.Cells["dgvbtnStandardRate"])
                    {
                        frmStandardRatePopupObj = new frmStandardRatePopup();
                        frmStandardRatePopupObj.MdiParent = formMDI.MDIObj;
                        decimal decProductId = Convert.ToDecimal(dgvStandardRate.Rows[e.RowIndex].Cells["dgvtxtProductId"].Value.ToString());
                        dgvStandardRate.Rows[e.RowIndex].Cells["dgvtxtSlNo"].Selected = true;
                        frmStandardRatePopupObj.CallFromStandardRate(decProductId, this);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// form keydown foe form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStandardRate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductCode.Focus();
                    txtProductCode.SelectionLength = 0;
                    txtProductCode.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enterkey and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductName.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Text == string.Empty || txtProductCode.SelectionStart == 0)
                    {
                        cmbProductGroup.Focus();
                        cmbProductGroup.SelectionStart = 0;
                        cmbProductGroup.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enterkey and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductName.Text == string.Empty || txtProductName.SelectionStart == 0)
                    {
                        txtProductCode.Focus();
                        txtProductCode.SelectionStart = 0;
                        txtProductCode.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enterkey and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtProductName.Focus();
                    txtProductName.SelectionStart = 0;
                    txtProductName.SelectionLength = 0;
                }
                if (e.KeyCode == Keys.Enter )
                {
                    btnClear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enterkey and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    btnClose.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For Enterkey and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnClear.Focus();
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        
    }
}


