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
    public partial class frmEmployeeRegister : Form
    {
       
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        int inCurrenRowIndex = 0;
    
        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmEmployeeRegister class
        /// </summary>
        public frmEmployeeRegister()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void Gridfill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                EmployeeInfo infoEmployee = new EmployeeInfo();
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                infoEmployee.EmployeeCode = txtEmployeeCode.Text.Trim();
                infoEmployee.EmployeeName = txtEmployeeName.Text.Trim();
                infoEmployee.DesignationId = decimal.Parse(cmbDesignation.SelectedValue.ToString());
                infoEmployee.SalaryType = cmbsalaryType.SelectedItem.ToString();
                infoEmployee.BankAccountNumber = txtBankAccountNumber.Text.Trim();
                infoEmployee.PassportNo = txtPassportNumber.Text.Trim();
                infoEmployee.LabourCardNumber = txtLabourCardNumber.Text.Trim();
                infoEmployee.VisaNumber = txtVisaNumber.Text.Trim();
                listObj= BllEmployeeCreation.EmployeeSearch(infoEmployee);
                dgvEmployee.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Designation combobox
        /// </summary>
        public void DesignationComboFill()
        {
            try
            {
                //DesignationSP SpDesignation = new DesignationSP();
                DesiginationBll bllDesigination = new DesiginationBll();
                List<DataTable> listObjDesignation = new List<DataTable>();
                listObjDesignation = bllDesigination.DesignationViewAll();
                cmbDesignation.DataSource = listObjDesignation[0];
                if (listObjDesignation[0].Rows.Count > 0)
                {
                    cmbDesignation.ValueMember = "designationId";
                    cmbDesignation.DisplayMember = "designationName";
                    DataRow drRow = listObjDesignation[0].NewRow();
                    drRow["designationId"] = "0";
                    drRow["designationName"] = "All";
                    listObjDesignation[0].Rows.InsertAt(drRow, 0);
                    cmbDesignation.SelectedValue = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtEmployeeCode.Focus();
                txtEmployeeCode.Clear();
                txtEmployeeName.Clear();
                cmbDesignation.SelectedValue = "0";
                cmbsalaryType.SelectedIndex = 0;
                txtBankAccountNumber.Clear();
                txtLabourCardNumber.Clear();
                txtPassportNumber.Clear();
                txtVisaNumber.Clear();
                cmbsalaryType.Text = "All";
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to select the currentcell
        /// </summary>
        public void GridSelection()
        {
            try
            {
                if (inCurrenRowIndex >= 0 && dgvEmployee.Rows.Count > 0 && inCurrenRowIndex < dgvEmployee.Rows.Count)
                {
                    dgvEmployee.CurrentCell = dgvEmployee.Rows[inCurrenRowIndex].Cells[0];
                    dgvEmployee.CurrentCell.Selected = true;
                }
                else
                {
                    inCurrenRowIndex = 0;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// On 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeRegister_Load(object sender, EventArgs e)
        {
            try
            {
                DesignationComboFill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 27)
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
                MessageBox.Show("ER7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Gridfill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls EmployeeCreation form for update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvEmployee.CurrentRow != null && dgvEmployee.CurrentRow.Index != 0 || dgvEmployee.CurrentRow != null && dgvEmployee.CurrentRow.Index == 0)
                    {
                        if (dgvEmployee.CurrentCell != null && dgvEmployee.CurrentCell.Value != null)
                        {
                            if (Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value) != 1)
                            {
                                frmEmployeeCreation objEmployeeCreation = new frmEmployeeCreation();
                                objEmployeeCreation.MdiParent = formMDI.MDIObj;
                                frmEmployeeCreation open = Application.OpenForms["frmEmployeeCreation"] as frmEmployeeCreation;
                                if (open == null)
                                {
                                    objEmployeeCreation.WindowState = FormWindowState.Normal;
                                    objEmployeeCreation.MdiParent = formMDI.MDIObj;
                                    objEmployeeCreation.CallFromEmployeeRegister(decimal.Parse(dgvEmployee.Rows[e.RowIndex].Cells["dgvtxtEmployeeId"].Value.ToString()), this);
                                }
                                else
                                {
                                    open.MdiParent = formMDI.MDIObj;
                                    open.BringToFront();
                                    open.CallFromEmployeeRegister(decimal.Parse(dgvEmployee.Rows[e.RowIndex].Cells["dgvtxtEmployeeId"].Value.ToString()), this);
                                    if (open.WindowState == FormWindowState.Minimized)
                                    {
                                        open.WindowState = FormWindowState.Normal;
                                    }
                                }
                                inCurrenRowIndex = dgvEmployee.CurrentRow.Index;
                                this.Enabled = false;
                            }
                            else
                            {
                                Messages.InformationMessage("Default Employee cannot update or delete");
                                Clear();
                            }
                           
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvEmployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvEmployee.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation

        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvEmployee.CurrentRow != null)
                    {

                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvEmployee.CurrentCell.ColumnIndex, dgvEmployee.CurrentCell.RowIndex);
                        dgvEmployee_CellDoubleClick(sender, ex);
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtVisaNumber.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbDesignation.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmployeeName.Text == string.Empty || txtEmployeeName.SelectionStart == 0)
                    {
                        txtEmployeeCode.SelectionLength = 0;
                        txtEmployeeCode.SelectionStart = 0;
                        txtEmployeeCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbsalaryType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbDesignation.Text == string.Empty || cmbDesignation.SelectionStart == 0)
                    {
                        txtEmployeeName.SelectionLength = 0;
                        txtEmployeeName.SelectionStart = 0;
                        txtEmployeeName.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbsalaryType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBankAccountNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbsalaryType.Text == string.Empty || cmbsalaryType.SelectionStart == 0)
                    {
                        cmbDesignation.SelectionLength = 0;
                        cmbDesignation.SelectionStart = 0;
                        cmbDesignation.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBankAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassportNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtBankAccountNumber.Text == string.Empty || txtBankAccountNumber.SelectionStart == 0)
                    {
                        cmbsalaryType.SelectionLength = 0;
                        cmbsalaryType.SelectionStart = 0;
                        cmbsalaryType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassportNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtLabourCardNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPassportNumber.Text == string.Empty || txtPassportNumber.SelectionStart == 0)
                    {
                        txtBankAccountNumber.SelectionLength = 0;
                        txtBankAccountNumber.SelectionStart = 0;
                        txtBankAccountNumber.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLabourCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVisaNumber.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtLabourCardNumber.Text == string.Empty || txtLabourCardNumber.SelectionStart == 0)
                    {
                        txtPassportNumber.SelectionLength = 0;
                        txtPassportNumber.SelectionStart = 0;
                        txtPassportNumber.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVisaNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVisaNumber.Text == string.Empty || txtVisaNumber.SelectionStart == 0)
                    {
                        txtLabourCardNumber.SelectionLength = 0;
                        txtLabourCardNumber.SelectionStart = 0;
                        txtLabourCardNumber.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtVisaNumber.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        #endregion

        
    }
}
