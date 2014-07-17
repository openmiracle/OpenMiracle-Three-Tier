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
    public partial class frmCashBankBookReport : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
   
        FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
        #endregion

        #region Functions
        /// <summary>
        /// Create an Instance of a frmCashBankBookReport class
        /// </summary>
        public frmCashBankBookReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                txtFromDate.Text = dtpFromDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK01 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the grid
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> list = new List<DataTable>();
                list = bllFinancialStatement.CashOrBankBookGridFill(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text), "", true);
                dgvCashOrBank.DataSource = list[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK02 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCashBankBookReport_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK03 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On search button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                {
                    MessageBox.Show("todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                }
                else
                {
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK04 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On reset button click
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
                MessageBox.Show("CBBOOK05 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On value change of dtpFromDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = this.dtpFromDate.Value;
                txtFromDate.Text = fromDate.ToString("dd-MM-yyyy");
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK06 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On value change of dtpToDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime toDate = this.dtpToDate.Value;
                txtToDate.Text = toDate.ToString("dd-MM-yyyy");
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK07 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When doubleclicking on the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCashOrBank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (dgvCashOrBank.CurrentRow.Index == e.RowIndex)
                    {
                        decimal decAccountGroupId = Convert.ToDecimal(dgvCashOrBank.Rows[e.RowIndex].Cells["dgvtxtGroupId"].Value.ToString());
                        frmAccountGroupwiseReport frmAccountGroupwiseReportObjt = new frmAccountGroupwiseReport();
                        frmAccountGroupwiseReportObjt.MdiParent = formMDI.MDIObj;
                        frmAccountGroupwiseReportObjt.CallFromCashBankBook(dtpFromDate.Value.ToString(), dtpToDate.Value.ToString(), decAccountGroupId, this);
                        this.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK08 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On print button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCashOrBank.Rows.Count > 0)
                {
                    AccountGroupBll bllAccountGroup = new AccountGroupBll();
                    DataSet dsCashBankBook = bllAccountGroup.CashBankBookPrinting(1, this.dtpFromDate.Value, this.dtpToDate.Value, true);
                    frmReport frmReport = new frmReport();
                    frmReport.MdiParent = formMDI.MDIObj;
                    frmReport.CashBankBookPrinting(dsCashBankBook);
                }
                else
                {
                    Messages.InformationMessage("No data found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK09 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtFromDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtFromDate);
                if (!isInvalid)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK10 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from txtToDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtToDate);
                if (!isInvalid)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK11 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvCashOrBank, "Cash/Bank Book", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK17: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigations
        /// <summary>
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCashBankBookReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("CBBOOK12 :" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtFromDate
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
                else if (e.KeyCode == Keys.Back)
                {
                    txtFromDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of txtToDate
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
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text.Trim() == string.Empty && txtToDate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of btnSearch 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnReset.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation of btnPrint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    btnReset.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBBOOK16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}   
            
           
