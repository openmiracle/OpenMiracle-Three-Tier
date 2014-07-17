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
    public partial class frmCashFlow : Form
    {
        #region Public Variables
        bool isFormLoad = false;
        int inCurrenRowIndex = 0;// To keep row index while returning from voucher
        int inCurentcolIndex = 0;// To keep column index while returning from voucher 
        string calculationMethod = string.Empty;
        decimal dcTotInflow = 0;
        decimal dcTotOutflow = 0;
        #endregion
        #region Functions
        /// <summary>
        /// Creates an instance of frmCashFlow class
        /// </summary>
        public frmCashFlow()
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
                if (!isFormLoad)
                {
                    DateValidation objValidation = new DateValidation();
                    objValidation.DateValidationFunction(txtFromDate);
                    if (txtFromDate.Text == string.Empty)
                        txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                    objValidation.DateValidationFunction(txttoDate);
                    if (txttoDate.Text == string.Empty)
                        txttoDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                    DateTime strFromDate = DateTime.Parse(txtFromDate.Text.ToString());
                    DateTime strTodate = DateTime.Parse(txttoDate.Text.ToString());
                    FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                    DataSet dsetFinancial = new DataSet();
                    SettingsInfo InfoSettings = new SettingsInfo();
                    SettingsBll BllSettings = new SettingsBll();
                    dsetFinancial = bllFinancialStatement.CashFlow(strFromDate, strTodate);
                    DataTable dtbl = new DataTable();
                    Font newFont = new Font(dgvCashflow.Font, FontStyle.Bold);
                    CurrencyInfo InfoCurrency = new CurrencyInfo();
                    CurrencyBll BllCurrency = new CurrencyBll();
                    InfoCurrency = BllCurrency.CurrencyView(1);
                    int inDecimalPlaces = InfoCurrency.NoOfDecimalPlaces;
                    dgvCashflow.Rows.Clear();
                  
                    for (int i = 0; i < 8; i++)
                    {
                        dtbl = dsetFinancial.Tables[i];
                        foreach (DataRow rw in dtbl.Rows)
                        {
                            dgvCashflow.Rows.Add();
                            dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtParticulars"].Value = rw["accountGroupName"].ToString();
                            dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtinflow"].Value = rw["Balance"].ToString();
                            dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtID1"].Value = rw["accountGroupId"].ToString();
                        }
                    }
                    //-------------------------------Calculating TotalInflow-----------------------------------------
                    decimal dcTotalInflow = 0m;
                    if (dtbl.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgvCashflow.Rows.Count; i++)
                        {
                            decimal dcTotalIn = decimal.Parse(dgvCashflow.Rows[i].Cells["dgvtxtinflow"].Value.ToString());
                            dcTotalInflow += dcTotalIn;
                        }
                        dcTotInflow = dcTotalInflow;
                    }
                    //-----------------Outflow------------------------------
                    int index = 0;
                    for (int i = 8; i < 15; i++)
                    {
                        dtbl = new DataTable();
                        dtbl = dsetFinancial.Tables[i];
                        foreach (DataRow rw in dtbl.Rows)
                        {
                            if (index < dgvCashflow.Rows.Count)
                            {
                                dgvCashflow.Rows[index].Cells["dgvtxtParticulars1"].Value = rw["accountGroupName1"].ToString();
                                dgvCashflow.Rows[index].Cells["dgvtxtoutflow"].Value = rw["Balance1"].ToString();
                                dgvCashflow.Rows[index].Cells["dgvtxtID2"].Value = rw["accountGroupId"].ToString();
                            }
                            else
                            {
                                dgvCashflow.Rows.Add();
                                dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtParticulars1"].Value = rw["accountGroupName1"].ToString();
                                dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtoutflow"].Value = rw["Balance1"].ToString();
                                dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtID2"].Value = rw["accountGroupId"].ToString();
                            }
                            index++;
                        }
                    }
                    //-------------------------------Calculating TotalOutflow-----------------------------------------
                    decimal dcTotalOutflow = 0m;
                    if (dtbl.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgvCashflow.Rows.Count - 1; i++)
                        {
                            decimal dcTotalIn = decimal.Parse(dgvCashflow.Rows[i].Cells["dgvtxtoutflow"].Value.ToString());
                            dcTotalOutflow += dcTotalIn;
                        }
                        dcTotOutflow = dcTotalOutflow;
                    }
                    dgvCashflow.Rows.Add();
                    dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtinflow"].Value = "_______________________";
                    dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtoutflow"].Value = "_______________________";
                    dgvCashflow.Rows.Add();
                    dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].DefaultCellStyle.Font = newFont;
                    dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtParticulars"].Value = "Total";
                    dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtParticulars1"].Value = "Total";
                    dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtinflow"].Value = Math.Round((dcTotalInflow), inDecimalPlaces);
                    dgvCashflow.Rows[dgvCashflow.Rows.Count - 1].Cells["dgvtxtoutflow"].Value = Math.Round((dcTotalOutflow), inDecimalPlaces);
                    if (dgvCashflow.Columns.Count > 0)
                    {
                        dgvCashflow.Columns["dgvtxtinflow"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvCashflow.Columns["dgvtxtoutflow"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    if (inCurrenRowIndex >= 0 && dgvCashflow.Rows.Count > 0 && inCurrenRowIndex < dgvCashflow.Rows.Count)
                    {
                        if (dgvCashflow.Rows[inCurrenRowIndex].Cells[inCurentcolIndex].Visible)
                        {
                            dgvCashflow.CurrentCell = dgvCashflow.Rows[inCurrenRowIndex].Cells[inCurentcolIndex];
                        }
                        if (dgvCashflow.CurrentCell != null && dgvCashflow.CurrentCell.Visible)
                            dgvCashflow.CurrentCell.Selected = true;
                    }
                    inCurrenRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtFromDate.Text = PublicVariables._dtFromDate.ToString();
                txttoDate.Text = PublicVariables._dtToDate.ToString();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to convert Datagridview data to Datatables
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable()
        {
            DataTable dtblCashflow = new DataTable();
            try
            {
                dtblCashflow.Columns.Add("dgvtxtParticulars");
                dtblCashflow.Columns.Add("dgvtxtinflow");
                dtblCashflow.Columns.Add("dgvtxtParticulars1");
                dtblCashflow.Columns.Add("dgvtxtoutflow");
                DataRow drow = null;
                foreach (DataGridViewRow dr in dgvCashflow.Rows)
                {
                    drow = dtblCashflow.NewRow();
                    drow["dgvtxtParticulars"] = dr.Cells["dgvtxtParticulars"].Value;
                    drow["dgvtxtinflow"] = dr.Cells["dgvtxtinflow"].Value;
                    drow["dgvtxtParticulars1"] = dr.Cells["dgvtxtParticulars1"].Value;
                    drow["dgvtxtoutflow"] = dr.Cells["dgvtxtoutflow"].Value;
                    dtblCashflow.Rows.Add(drow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtblCashflow;
        }
        /// <summary>
        /// Function to Add Dataset 
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            DataSet dsCashflow = new DataSet();
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                
                DataTable dtblCashflow = GetDataTable();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllFinancialStatement.CashflowReportPrintCompany(1);
                dsCashflow.Tables.Add(dtblCashflow);
                dsCashflow.Tables.Add(ListObj[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsCashflow;
        }
        /// <summary>
        /// Function for Print
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void Print(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataSet dsCashflow = GetDataSet();
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.CashflowReportPrinting(dsCashflow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCashFlow_Load(object sender, EventArgs e)
        {
            try
            {
                isFormLoad = true;
                txtFromDate.Text = PublicVariables._dtFromDate.ToString();
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.Text = dtpFromDate.Value.ToString("dd-MMM-yyyy");
                txttoDate.Text = PublicVariables._dtToDate.ToString();
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtToDate;
                dtpToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                isFormLoad = false;
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Date Validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation ObjValidation = new DateValidation();
                ObjValidation.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }
                DateTime dt;
                DateTime.TryParse(txtFromDate.Text, out dt);
                dtpFromDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txttoDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation ObjValidation = new DateValidation();
                ObjValidation.DateValidationFunction(txttoDate);
                if (txttoDate.Text == string.Empty)
                {
                    txttoDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                }
                DateTime dt;
                DateTime.TryParse(txttoDate.Text, out dt);
                dtpToDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtFromDate.Text != string.Empty && txttoDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txttoDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txttoDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                        DateTime dt;
                        DateTime.TryParse(txttoDate.Text, out dt);
                        dtpToDate.Value = dt;
                    }
                    GridFill();
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString();
                    txttoDate.Text = PublicVariables._dtToDate.ToString();
                    GridFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("CF:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// On 'Print' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dcTotInflow == 0 && dcTotOutflow == 0)
                {
                    MessageBox.Show("No data found", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFromDate.Focus();
                }
                else
                {
                    Print(PublicVariables._dtFromDate, PublicVariables._dtToDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls AccountGroupwiseReport to view details on cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCashflow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCashflow.CurrentRow.Index == e.RowIndex)
                {
                    if (dgvCashflow.CurrentRow.Index != -1 && dgvCashflow.CurrentCell.ColumnIndex != 0)
                    {
                        if (dgvCashflow.CurrentCell != null)
                        {
                            if (dgvCashflow.CurrentCell.Value != null && dgvCashflow.CurrentCell.Value.ToString().Trim() != string.Empty)
                            {
                                int inRowIndex = dgvCashflow.CurrentCell.RowIndex;
                                int inColIndex = dgvCashflow.CurrentCell.ColumnIndex;
                                string strGroupId = string.Empty;
                                if (dgvCashflow.Columns[inColIndex].Name == "dgvtxtParticulars" || dgvCashflow.Columns[inColIndex].Name == "dgvtxtinflow")
                                {
                                    if (Convert.ToString(dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtinflow"].Value) != "_______________________")
                                    {
                                        if (Convert.ToDecimal(dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtinflow"].Value.ToString()) != 0)
                                        {
                                            try
                                            {
                                                if (dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtID1"].Value != null && dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtID1"].Value.ToString() != string.Empty)
                                                {
                                                    strGroupId = dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtID1"].Value.ToString();
                                                }
                                            }
                                            catch
                                            {
                                                strGroupId = string.Empty;
                                            }
                                        }
                                    }
                                }
                                else if (dgvCashflow.Columns[inColIndex].Name == "dgvtxtParticulars1" || dgvCashflow.Columns[inColIndex].Name == "dgvtxtoutflow")
                                {
                                    if (Convert.ToString(dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtoutflow"].Value) != "_______________________")
                                    {
                                        if (Convert.ToDecimal(dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtoutflow"].Value.ToString()) != 0)
                                        {
                                            try
                                            {
                                                if (dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtID2"].Value != null && dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtID2"].Value.ToString() != string.Empty)
                                                {
                                                    strGroupId = dgvCashflow.Rows[e.RowIndex].Cells["dgvtxtID2"].Value.ToString();
                                                }
                                            }
                                            catch
                                            {
                                                strGroupId = string.Empty;
                                            }
                                        }
                                    }
                                }
                                if (strGroupId != string.Empty)
                                {
                                    inCurrenRowIndex = inRowIndex;
                                    inCurentcolIndex = inColIndex;
                                    frmAccountGroupwiseReport objForm = new frmAccountGroupwiseReport();
                                    objForm.WindowState = FormWindowState.Normal;
                                    objForm.MdiParent = formMDI.MDIObj;
                                    objForm.CallFromCashFlow(txtFromDate.Text, txttoDate.Text, strGroupId, this, inRowIndex, inColIndex);
                                    this.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.Enabled = true;
                MessageBox.Show("CF:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmCashFlow_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                isFormLoad = true;
            }
            catch (Exception ex)
            {
                this.Enabled = true;
                MessageBox.Show("CF:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpToDate.Value;
                this.txttoDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
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
                    txttoDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txttoDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txttoDate.SelectionLength != 11)
                    {
                        if (txttoDate.Text == string.Empty)
                        {
                            if (txtFromDate.SelectionStart == 0)
                            {
                                txtFromDate.Focus();
                                txtFromDate.SelectionStart = 0;
                                txtFromDate.SelectionLength = 0;
                            }
                        }
                        if (txtFromDate.SelectionStart == 0)
                        {
                            txtFromDate.Focus();
                            txtFromDate.SelectionStart = 0;
                            txtFromDate.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (txttoDate.SelectionStart == 0)
                    {
                        txttoDate.Focus();
                        txttoDate.SelectionStart = 0;
                        txttoDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CF:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCashFlow_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("CF:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}