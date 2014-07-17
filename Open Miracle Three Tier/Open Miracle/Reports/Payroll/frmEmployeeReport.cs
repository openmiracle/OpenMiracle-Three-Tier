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
    public partial class frmEmployeeReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmEmployeePopup frmEmployeePopupObj;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmEmployeeReport class
        /// </summary>
        public frmEmployeeReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Employee combobox
        /// </summary>
        public void EmployeeCodeComboFill()
        {
            try
            {
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                List<DataTable> listObj = BllEmployeeCreation.EmployeeViewAll();
                DataRow dr = listObj[0].NewRow();
                dr[3] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbEmployee.DataSource = listObj[0];
                cmbEmployee.ValueMember = "employeeId";
                cmbEmployee.DisplayMember = "employeeCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER1 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Designation combobox
        /// </summary>
        public void DesigantionComboFill()
        {
            try
            {
                //DesignationSP spDesignation = new DesignationSP();
                DesiginationBll bllDesigination = new DesiginationBll();
                List<DataTable> listObj = bllDesigination.DesignationViewAll();
                DataRow dr = listObj[0].NewRow();
                dr[1] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbDesigantion.DataSource = listObj[0];
                cmbDesigantion.ValueMember = "designationId";
                cmbDesigantion.DisplayMember = "designationName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER2 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                List<DataTable> listObj = BllEmployeeCreation.EmployeeViewAllEmployeeReport(cmbDesigantion.Text, cmbEmployee.Text, cmbStatus.Text);
                dgvEmployee.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER3 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                cmbDesigantion.SelectedIndex = 0;
                cmbEmployee.SelectedIndex = 0;
                cmbStatus.SelectedIndex = 0;
                cmbDesigantion.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER4 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup form to view and select Employees
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decEmployeeId"></param>
        public void CallFromEmployeePopUp(frmEmployeePopup frm, decimal decEmployeeId)
        {
            try
            {
                base.Show();
                frmEmployeePopupObj = frm;
                cmbEmployee.SelectedValue = decEmployeeId;
                cmbEmployee.Focus();
                frmEmployeePopupObj.Close();
                frmEmployeePopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeReport_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.SelectedIndex = 0;
                EmployeeCodeComboFill();
                DesigantionComboFill();
                cmbDesigantion.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER6 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("ER7" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("ER8" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvEmployee.RowCount > 0)
                {
                    DataSet ds = new DataSet();
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    ds.Tables.Add(listObjCompany[0]);
                    EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                    List<DataTable> listEmployee = BllEmployeeCreation.EmployeeViewAllEmployeeReport(cmbDesigantion.Text, cmbEmployee.Text, cmbStatus.Text);
                    ds.Tables.Add(listEmployee[0]);
                    frmReport frmReportObj = new frmReport();
                    frmReportObj.MdiParent = formMDI.MDIObj;
                    frmReportObj.EmployeeReportPrinting(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvEmployee, "Employee Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER15" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeeReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("ER10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDesigantion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbEmployee.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation and Form Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbStatus.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbDesigantion.Focus();
                }
                if (e.Control && e.KeyCode == Keys.F)
                {
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbEmployee.SelectedIndex > 0)
                    {
                        frmEmployeePopupObj.CallFromEmployeeReport(this, Convert.ToDecimal(cmbEmployee.SelectedValue.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and Backspace navigation 
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
                    cmbEmployee.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ER13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Backspace navigation 
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
                MessageBox.Show("ER14" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
