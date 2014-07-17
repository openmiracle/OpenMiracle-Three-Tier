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
    public partial class frmSalaryPackageRegister : Form
    {
      
        #region  Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        int inCurrenRowIndex = 0;
        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmSalaryPackageRegister class
        /// </summary>
        public frmSalaryPackageRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            string strCmbName = string.Empty;
            try
            {
                SalaryPackageCreationBll bllSalaryPackage = new SalaryPackageCreationBll();
                List<DataTable> ListObj = new List<DataTable>();
                if (cmbStatus.Text == "Yes")
                {
                    strCmbName = "True";
                }
                else if (cmbStatus.Text == "No")
                {
                    strCmbName = "False";
                }
                else
                {
                    strCmbName = "All";
                }

                ListObj = bllSalaryPackage.SalaryPackageregisterSearch(txtPackageName.Text.Trim(), strCmbName);
                dgvSalaryPackageRegister.DataSource = ListObj[0];
                int inRowCount = dgvSalaryPackageRegister.RowCount;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (dgvSalaryPackageRegister.Rows[i].Cells["dgvtxtActive"].Value.ToString() == "1")
                    {
                        dgvSalaryPackageRegister.Rows[i].Cells["dgvtxtActive"].Value = "Yes";

                    }

                    if (dgvSalaryPackageRegister.Rows[i].Cells["dgvtxtActive"].Value.ToString() == "0")
                    {
                        dgvSalaryPackageRegister.Rows[i].Cells["dgvtxtActive"].Value = "No";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtPackageName.Clear();
                cmbStatus.SelectedIndex = 0;              
                GridFill();              
                dgvSalaryPackageRegister.ClearSelection();
                txtPackageName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        #endregion

        #region Events     
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalaryPackageRegister_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvSalaryPackageRegister.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection on data bind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackageRegister_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvSalaryPackageRegister.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("SPR5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridFill();
                txtPackageName.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls Salarypackage Creation form for updation on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackageRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.RowIndex != -1)
                {
                    frmSalaryPackageCreation frmSalaryPackageCreation = new frmSalaryPackageCreation();
                    frmSalaryPackageCreation.MdiParent = formMDI.MDIObj;
                    frmSalaryPackageCreation open = Application.OpenForms["frmSalaryPackageCreation"] as frmSalaryPackageCreation;
                    
                    if (open == null)
                    {
                        frmSalaryPackageCreation.WindowState = FormWindowState.Normal;
                        frmSalaryPackageCreation.MdiParent = formMDI.MDIObj;
                        frmSalaryPackageCreation.CallFromSalaryPackageRegister(Convert.ToDecimal(dgvSalaryPackageRegister.Rows[e.RowIndex].Cells["dgvTxtsalaryPackageId"].Value.ToString()), this);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        open.CallFromSalaryPackageRegister(Convert.ToDecimal(dgvSalaryPackageRegister.Rows[e.RowIndex].Cells["dgvTxtsalaryPackageId"].Value.ToString()), this);
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    inCurrenRowIndex = dgvSalaryPackageRegister.CurrentRow.Index;
                    this.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the Datagridview when activated the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalaryPackageRegister_Activated(object sender, EventArgs e)
        {
            try
            {
                GridFill();
               
                if (inCurrenRowIndex > 0 && dgvSalaryPackageRegister.Rows.Count > 0 && inCurrenRowIndex < dgvSalaryPackageRegister.Rows.Count)
                {
                    dgvSalaryPackageRegister.CurrentCell = dgvSalaryPackageRegister.Rows[inCurrenRowIndex].Cells["dgvTxtPackagename"];
                    dgvSalaryPackageRegister.CurrentCell.Selected = true;
                }
                inCurrenRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls SalaryPackageCreation form for updation on Enter key in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackageRegister_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvSalaryPackageRegister.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvSalaryPackageRegister.CurrentCell.ColumnIndex, dgvSalaryPackageRegister.CurrentCell.RowIndex);
                        dgvSalaryPackageRegister_CellDoubleClick(sender, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSalaryPackageRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SPR10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPackageName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbStatus.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtPackageName.Focus();
                    txtPackageName.SelectionStart = 0;
                    txtPackageName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    
                    cmbStatus.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvSalaryPackageRegister.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SPR14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackageRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("SPR15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
