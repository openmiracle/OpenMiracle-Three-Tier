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
    public partial class frmAdvancePaymentReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmEmployeePopup frmEmployeePopupObj;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmAdvancePaymentReport class
        /// </summary>
        public frmAdvancePaymentReport()
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
                AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                List<DataTable> ListObj = bllAdvancePayment.AdvancePaymentViewAllForAdvancePaymentReport(dtpFrmDate.Value, dtpToDate.Value, cmbEmployeeCode.Text, dtpSalaryMonth.Value);
                dgvAdvancePayment.DataSource = ListObj[0]; 
                TotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:1 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                dtpFrmDate.Value = PublicVariables._dtFromDate;
                dtpFrmDate.MinDate = PublicVariables._dtFromDate;
                dtpFrmDate.MaxDate = PublicVariables._dtToDate;
                dtpFrmDate.CustomFormat = "dd-MMM-yyyy";
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.CustomFormat = "dd-MMM-yyyy";
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                dtpSalaryMonth.MinDate = PublicVariables._dtFromDate;
                dtpSalaryMonth.MaxDate = PublicVariables._dtToDate;
                dtpSalaryMonth.CustomFormat = "MMM-yyyy";
                cmbEmployeeCode.SelectedIndex = 0;
                txtFromDate.Focus();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup to view and select Employee details
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
                MessageBox.Show(" APR:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("APR:4 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the Total Amount Paid 
        /// </summary>
        private void TotalAmount()
        {
            try
            {
                decimal decTotalAmount = 0;
                foreach (DataGridViewRow row in dgvAdvancePayment.Rows)
                {
                    decTotalAmount = decTotalAmount + Convert.ToDecimal(row.Cells["amount"].Value.ToString());
                }
                txtTotalAmount.Text = decTotalAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:5 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvancePaymentReport_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFrmDate.Value = PublicVariables._dtFromDate;
                dtpFrmDate.MinDate = PublicVariables._dtFromDate;
                dtpFrmDate.MaxDate = PublicVariables._dtToDate;
                dtpFrmDate.CustomFormat = "dd-MMM-yyyy";
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.CustomFormat = "dd-MMM-yyyy";
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                dtpSalaryMonth.MinDate = PublicVariables._dtFromDate;
                dtpSalaryMonth.MaxDate = PublicVariables._dtToDate;
                dtpSalaryMonth.CustomFormat = "MMM-yyyy";
                txtFromDate.Focus();
                EmployeeCodeComboFill();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:6" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("APR:7 " + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvAdvancePayment.Rows.Count > 0)
                {
                    DataSet ds = new DataSet();
                    //CompanySP spCompany = new CompanySP();
                    CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                    List<DataTable> listObjCompany = bllCompanyCreation.CompanyViewDataTable(1);
                    ds.Tables.Add(listObjCompany[0]);
                    AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                    List<DataTable> listObj = new List<DataTable>();
                    listObj = bllAdvancePayment.AdvancePaymentViewAllForAdvancePaymentReport(dtpFrmDate.Value, dtpToDate.Value, cmbEmployeeCode.Text, DateTime.Parse(dtpSalaryMonth.Text.ToString()));
                    ds.Tables.Add(listObj[0]);
                    frmReport frmReportObj = new frmReport();
                    frmReportObj.MdiParent = formMDI.MDIObj;
                    frmReportObj.AdvancePaymentReportPrinting(ds);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:8" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvAdvancePayment, "Advance Payment Report", 0, 0, "Excel", txtFromDate.Text, txtToDate.Text, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:21" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strDate = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(strDate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("APR:10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Fills txtFromDate textbox on dtpFrmDate Datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFrmDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFrmDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strDate = txtFromDate.Text;
                dtpFrmDate.Value = Convert.ToDateTime(strDate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtSalaryMonth textbox on dtpSalaryMonth Datetimepicker ValueChanged
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
                MessageBox.Show("APR:13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// DateValidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalaryMonth_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtSalaryMonth);
                if (txtSalaryMonth.Text == string.Empty)
                {
                    txtSalaryMonth.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                //---for change date in Date time picker----//
                string strDate = txtSalaryMonth.Text;
                dtpSalaryMonth.Value = Convert.ToDateTime(strDate.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:14" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Reset' button click resets form
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
                MessageBox.Show("APR:15" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigations
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvancePaymentReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("APR:16" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Form Quick access and Enter,Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSalaryMonth.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                    txtToDate.Focus();
                }
                if (e.Control && e.KeyCode == Keys.F)
                {
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbEmployeeCode.SelectedIndex > 0)
                    {
                        frmEmployeePopupObj.CallFromAdvancePaymentReport(this, Convert.ToDecimal(cmbEmployeeCode.SelectedValue.ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("APR:17" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("APR:18" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbEmployeeCode.Focus();
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
                MessageBox.Show("APR:19" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("APR:20" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

     

       
    }
}
