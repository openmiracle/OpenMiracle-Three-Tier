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
    public partial class frmDailySalaryReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
        frmEmployeePopup frmEmployeePopupObj;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmDailySalaryReport class
        /// </summary>
        public frmDailySalaryReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call frmEmployeePopup to view and select the Employee
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
                MessageBox.Show("DSR1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("DSR2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Designation combobox
        /// </summary>
        public void DesignationComboFill()
        {
            try
            {
                //DesignationSP spDesigantion = new DesignationSP();
                DesiginationBll bllDesigination = new DesiginationBll();
                List<DataTable> listObj = bllDesigination.DesignationViewAll();
                DataRow dr = listObj[0].NewRow();
                dr[1] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
                cmbDesignation.DataSource = listObj[0];
                cmbDesignation.ValueMember = "designationId";
                cmbDesignation.DisplayMember = "designationName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> listEmployee = BllEmployeeCreation.EmployeeViewAllForDailySalaryReport(cmbEmployeeCode.Text, cmbDesignation.Text, Convert.ToDateTime(dtpFromDate.Text.ToString()), Convert.ToDateTime(dtpToDate.Text.ToString()), cmbStatus.Text);
                dgvDailySalary.DataSource = listEmployee[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                cmbEmployeeCode.SelectedIndex = 0;
                cmbDesignation.SelectedIndex = 0;
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.CustomFormat = "dd-MMM-yyyy";
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.CustomFormat = "dd-MMM-yyyy";
                cmbStatus.SelectedIndex = 0;
                txtFromDate.Focus();
                cmbEmployeeCode.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDailySalaryReport_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.CustomFormat = "dd-MMM-yyyy";
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.CustomFormat = "dd-MMM-yyyy";
                EmployeeCodeComboFill();
                DesignationComboFill();
                cmbStatus.SelectedIndex = 0;
                txtFromDate.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR6" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("DSR7" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Search' button click fills Datagridview
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
                MessageBox.Show("DSR8" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button click to print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDailySalary.RowCount > 0)
                {
                    DataSet ds = new DataSet();
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
                    List<DataTable> listEmployee = BllEmployeeCreation.EmployeeViewAllForDailySalaryReport(cmbEmployeeCode.Text, cmbDesignation.Text, Convert.ToDateTime(dtpFromDate.Text.ToString()), Convert.ToDateTime(dtpToDate.Text.ToString()), cmbStatus.Text);
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    ds.Tables.Add(listObjCompany[0]);
                    ds.Tables.Add(listEmployee[0]);
                    frmReport frmReportObj = new frmReport();
                    frmReportObj.MdiParent = formMDI.MDIObj;
                    frmReportObj.DailySalaryReport(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR9 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtFromDate.Text;
                dtpFromDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpFromDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtToDate textbox on dtpToDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpToDate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvDailySalary, "Daily Salary Report", 0, 0, "Excel", txtFromDate.Text, txtToDate.Text, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDailySalaryReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("DSR14" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtFromDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbEmployeeCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR15" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtToDate.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbDesignation.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR16" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtFromDate.SelectionLength = 0;
                    txtFromDate.SelectionStart = 0;
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR17" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key and backspace navigation
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
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = 0;
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR18" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Enter key navigation and Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbDesignation.Focus();
                }
                if (e.Control && e.KeyCode == Keys.F)
                {
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbEmployeeCode.SelectedIndex > 0)
                    {
                        frmEmployeePopupObj.CallFromDailySlaryReport(this, Convert.ToDecimal(cmbEmployeeCode.SelectedValue.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSR19" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("DSR20" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
