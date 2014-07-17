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
    public partial class frmAdvanceRegister : Form
    {
      
        #region Public Variables
        /// <summary>
        /// public variable declaration part
        /// </summary>
        decimal decGrid = 0;
        int inCurrenRowIndex = 0;

        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmAdvanceRegister class 
        /// </summary>
        public frmAdvanceRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AdvancePaymentBll bllAdvanceRegister = new AdvancePaymentBll();
                ListObj = bllAdvanceRegister.AdvanceRegisterSearch(txtAdvanceVoucher.Text, txtEmployeeCode.Text, txtEmployeeName.Text, dtpSalaryMonth.Text, cmbVoucherType.Text);
                dgvAdvanceRegister.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill cmbVoucherType combobox
        /// </summary>
        public void VoucherTypeNameComboFill()
        {
            try
            {
                AdvancePaymentBll bllAdvancePaymentSP = new AdvancePaymentBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAdvancePaymentSP.VoucherTypeNameComboFillAdvanceRegister();
                DataRow dr = ListObj[0].NewRow();
                dr[1] = "All";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.DataSource = ListObj[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";

            }
            catch (Exception ex)
            {
                MessageBox.Show("AR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear controls
        /// </summary>
        public void Clear()
        {
            try
            {
                txtAdvanceVoucher.Clear();
                txtEmployeeCode.Clear();
                txtEmployeeName.Clear();
                VoucherTypeNameComboFill();
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                GridFill();
                txtAdvanceVoucher.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events

       /// <summary>
       /// Load
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void frmAdvanceRegister_Load(object sender, EventArgs e)
        {
            try
            {
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                this.dgvAdvanceRegister.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                txtAdvanceVoucher.Text = string.Empty;
                VoucherTypeNameComboFill();
                GridFill();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AR4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GridFill();
                txtAdvanceVoucher.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvanceRegister_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("AR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("AR7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill Datagridview and Selects the Curent row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvanceRegister_Activated(object sender, EventArgs e)
        {
            try
            {
                GridFill();
                if (inCurrenRowIndex > 0 && dgvAdvanceRegister.Rows.Count > 0 && inCurrenRowIndex < dgvAdvanceRegister.Rows.Count)
                {
                    dgvAdvanceRegister.CurrentCell = dgvAdvanceRegister.Rows[inCurrenRowIndex].Cells["dgvtxtEmployee"];
                    dgvAdvanceRegister.CurrentCell.Selected = true;
                }
                inCurrenRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvAdvanceRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                if (e.RowIndex != -1)
                {

                    frmAdvancePayment frmAdvancePaymentObj = new frmAdvancePayment();
                    frmAdvancePaymentObj.MdiParent = formMDI.MDIObj;

                    frmAdvancePayment open = Application.OpenForms["frmAdvancePayment"] as frmAdvancePayment;
                   
                    if (open == null)
                    {
                        frmAdvancePaymentObj.WindowState = FormWindowState.Normal;
                        frmAdvancePaymentObj.MdiParent = formMDI.MDIObj;
                       
                        decGrid = Convert.ToDecimal(dgvAdvanceRegister.Rows[e.RowIndex].Cells["advancePaymentId"].Value.ToString());
                        frmAdvancePaymentObj.CallFromAdvanceRegister(decGrid, this);
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        open.BringToFront();
                        decGrid = Convert.ToDecimal(dgvAdvanceRegister.Rows[e.RowIndex].Cells["advancePaymentId"].Value.ToString());
                        open.CallFromAdvanceRegister(decGrid, this);
                      
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                    }
                    inCurrenRowIndex = dgvAdvanceRegister.CurrentRow.Index;
                    this.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// Clears selection on databind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdvanceRegister_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvAdvanceRegister.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdvanceVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmployeeCode.Focus();
                    txtEmployeeCode.SelectionStart = 0;
                    txtEmployeeCode.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmployeeName.Focus();
                    txtEmployeeName.SelectionStart = txtEmployeeCode.Text.Length;
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmployeeCode.Text == string.Empty)
                    {
                        txtAdvanceVoucher.Focus();
                        txtAdvanceVoucher.SelectionStart = txtAdvanceVoucher.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpSalaryMonth.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmployeeName.Text == string.Empty)
                    {
                        txtEmployeeCode.Focus();
                        txtEmployeeCode.SelectionStart = txtEmployeeCode.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSalaryMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {

                    txtEmployeeName.Focus();
                    txtEmployeeName.SelectionStart = 0;
                    txtEmployeeName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClear.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAdvanceRegister_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    cmbVoucherType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enetr key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    dtpSalaryMonth.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

    }
}
