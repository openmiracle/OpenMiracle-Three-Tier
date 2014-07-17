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
    public partial class frmMonthlySalaryReport : Form
    {
        #region Functions
        /// <summary>
        /// Creates an instance of frmMonthlySalaryReport class
        /// </summary>
        public frmMonthlySalaryReport()
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
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                List<DataTable> listObj = BllMonthlySalary.MonthlySalryViewAllForMonthlySalaryReports(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), cmbDesignation.Text, cmbEmployeeCode.Text, Convert.ToDateTime(dtpSalaryMonth.Value.ToString()));
                dgvMonthlySalary.DataSource = listObj[0];
                txtTotalAmount.Text = TotalAmount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill EmployeeCode combobox
        /// </summary>
        public void EmployeeCodeComboFill()
        {
            try
            {
                EmployeeCreationBll BllEmployeeCreation = new EmployeeCreationBll();
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
                MessageBox.Show("MSR:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("MSR:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
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
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                dtpSalaryMonth.MinDate = PublicVariables._dtFromDate;
                dtpSalaryMonth.MaxDate = PublicVariables._dtToDate;
                dtpSalaryMonth.CustomFormat = "MMM-yyyy";
                cmbDesignation.SelectedIndex = 0;
                cmbEmployeeCode.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate TotalAmount
        /// </summary>
        /// <returns></returns>
        public decimal TotalAmount()
        {
            decimal decTotalAmount = 0m;
            try
            {
                if (dgvMonthlySalary.Rows.Count != 0)
                {
                    foreach (DataGridViewRow dgvrw in dgvMonthlySalary.Rows)
                    {
                        decTotalAmount += Convert.ToDecimal(dgvrw.Cells["dgvtxtTotalAmount"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:5" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decTotalAmount;
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonthlySalaryReport_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeCodeComboFill();
                DesignationComboFill();
                Clear();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:6" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("MSR:7" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:8" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Print' button click for print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMonthlySalary.Rows.Count > 0)
                {
                    DataSet ds = new DataSet();
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    ds.Tables.Add(listObjCompany[0]);
                    MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                    List<DataTable> ListMonthlySalary = BllMonthlySalary.MonthlySalryViewAllForMonthlySalaryReports(Convert.ToDateTime(dtpFromDate.Value.ToString()), Convert.ToDateTime(dtpToDate.Value.ToString()), cmbDesignation.Text, cmbEmployeeCode.Text, Convert.ToDateTime(dtpSalaryMonth.Value.ToString()));
                    ds.Tables.Add(ListMonthlySalary[0]);
                    frmReport frmReportObj = new frmReport();
                    frmReportObj.MdiParent = formMDI.MDIObj;
                    frmReportObj.MonthlySalaryReportPrinting(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
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
                MessageBox.Show("MSR:10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtFromDate textbox on dtpFromDate datetimepicker ValueChanged
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
                MessageBox.Show("MSR:11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datevalidation
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
                MessageBox.Show("MSR:12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Fills txtToDate textbox on dtpToDate datetimepicker ValueChanged
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
                MessageBox.Show("MSR:13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datevalidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalaryMonth_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtSalaryMonth);
                if (txtSalaryMonth.Text == string.Empty)
                {
                    txtSalaryMonth.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strdate = txtSalaryMonth.Text;
                dtpSalaryMonth.Value = Convert.ToDateTime(strdate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:14" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtSalaryMonth textbox on dtpSalaryMonth datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSalaryMonth_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpSalaryMonth.Value;
                this.txtSalaryMonth.Text = date.ToString("MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:15" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvMonthlySalary, "Monthly Salary Report", 0, 0, "Excel", txtFromDate.Text, txtToDate.Text, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonthlySalaryReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("MSR:16" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:17" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbDesignation.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:18" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbEmployeeCode.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:19" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dtpSalaryMonth.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbEmployeeCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:20" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalaryMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbEmployeeCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:21" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtSalaryMonth.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSR:22" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


       
    }
}
