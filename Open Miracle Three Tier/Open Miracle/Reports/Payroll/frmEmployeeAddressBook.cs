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
    public partial class frmEmployeeAddressBook : Form
    {
        #region Public Variables
        /// <summary>
        /// public variable declaration part
        /// </summary>
        EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
        frmEmployeePopup frmEmployeePopupObj;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmEmployeeAddressBook class
        /// </summary>
        public frmEmployeeAddressBook()
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
                List<DataTable> listEmp = BllEmployeeCreation.EmployeeViewAllForEmployeeAddressBook(cmbEmployeeCode.Text, txtMobile.Text, txtPhone.Text, txtEmail.Text);
                dgvEmployeeAddressBook.DataSource = listEmp[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP1 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill EmployeeCode combobox
        /// </summary>
        public void EmployeeCodeComboFill()
        {
            try
            {
                List<DataTable> listEmployee = BllEmployeeCreation.EmployeeViewAll();
                DataRow dr = listEmployee[0].NewRow();
                dr[3] = "All";
                listEmployee[0].Rows.InsertAt(dr, 0);
                cmbEmployeeCode.DataSource = listEmployee[0];
                cmbEmployeeCode.ValueMember = "employeeId";
                cmbEmployeeCode.DisplayMember = "employeeCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP2 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup to select and view details of Employees
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decEmployeeId"></param>
        public void CallFromEmployeePopUp(frmEmployeePopup frm, decimal decEmployeeId)
        {
            try
            {
                base.Show();
                frmEmployeePopupObj = frm;
                cmbEmployeeCode.SelectedValue = decEmployeeId;
                cmbEmployeeCode.Focus();
                frmEmployeePopupObj.Close();
                frmEmployeePopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP3 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                cmbEmployeeCode.SelectedIndex = 0;
                txtEmail.Text = "";
                txtMobile.Text = "";
                txtPhone.Text = "";
                cmbEmployeeCode.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP4 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeAddressBook_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeCodeComboFill();
                GridFill();
                cmbEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP5 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP6 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP7 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button click to take print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployeeAddressBook.Rows.Count > 0)
                {
                    DataSet ds = new DataSet();
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    ds.Tables.Add(listObjCompany[0]);
                    EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                    List<DataTable> listEmployee = BllEmployeeCreation.EmployeeViewAllForEmployeeAddressBook(cmbEmployeeCode.Text, txtMobile.Text, txtPhone.Text, txtEmail.Text);
                    ds.Tables.Add(listEmployee[0]);
                    frmReport frmReportObj = new frmReport();
                    frmReportObj.MdiParent = formMDI.MDIObj;
                    frmReportObj.EmployeeAddressBookPrinting(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP8 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvEmployeeAddressBook, "Employee Address Book", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeAddressBook_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("EMP9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation and Form Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPhone.Focus();
                }
                if (e.Control && e.KeyCode == Keys.F)
                {
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbEmployeeCode.SelectedIndex > 0)
                    {
                        frmEmployeePopupObj.CallFromEmployeeAddressBook(this, Convert.ToDecimal(cmbEmployeeCode.SelectedValue.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP10 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMobile.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtPhone.Text == string.Empty || txtPhone.SelectionStart == 0)
                    {
                        cmbEmployeeCode.SelectionLength = 0;
                        cmbEmployeeCode.SelectionStart = 0;
                        cmbEmployeeCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP11 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmail.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtMobile.Text == string.Empty || txtMobile.SelectionStart == 0)
                    {
                        txtPhone.SelectionLength = 0;
                        txtPhone.SelectionStart = 0;
                        txtPhone.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP12 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmail.Text == string.Empty || txtEmail.SelectionStart == 0)
                    {
                        txtMobile.SelectionLength = 0;
                        txtMobile.SelectionStart = 0;
                        txtMobile.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP13 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMP14 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
