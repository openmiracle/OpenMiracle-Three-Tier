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
    public partial class frmTaxReport : Form
    {
        #region PUBLIC VARIABLES
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        bool isInput = true;
        bool isBillwise = true;
        #endregion
        #region FUNCTIONS
        /// <summary>
        /// Create an Instance of a frmTaxReport class
        /// </summary>
        public frmTaxReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// To fill the vouchertype combobox
        /// </summary>
        public void VoucherTypeComboFill(string strVoucherName)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                listObj = BllVoucherType.VoucherTypeCombofillForTaxAndVat(strVoucherName);
                DataRow dr = listObj[0].NewRow();
                dr["voucherTypeName"] = "All";
                dr["voucherTypeId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.DataSource = listObj[0];
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.ValueMember = "voucherTypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill the tax combobox
        /// </summary>
        public void TaxComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                TaxBll bllTax = new TaxBll();
                ListObj = bllTax.TaxViewAll();
                DataRow dr = ListObj[0].NewRow();
                dr["taxName"] = "All";
                dr["taxId"] = 0;
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbTax.DataSource = ListObj[0];
                cmbTax.DisplayMember = "taxName";
                cmbTax.ValueMember = "taxId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill the grid
        /// </summary>
        public void GridFill()
        {
            try
            {
                if (cmbTax.SelectedValue != null && cmbVoucherType.SelectedItem != null)
                {
                    TaxBll bllTax = new TaxBll();
                    List<DataTable> ListObj = new List<DataTable>();
                    DateTime dtFromDate = DateTime.Parse(txtFromDate.Text);
                    DateTime dtToDate = DateTime.Parse(txtToDate.Text);
                    decimal dectaxId = Convert.ToDecimal(cmbTax.SelectedValue.ToString());
                    decimal decvoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                    string strTypeofVoucher = Convert.ToString(cmbTypeOfVoucher.Text);
                    if (isBillwise)
                    {
                        ListObj = bllTax.TaxReportGridFillByBillWise(dtFromDate, dtToDate, dectaxId, decvoucherTypeId, strTypeofVoucher, isInput);
                        if (ListObj[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ListObj[0].Rows.Count; i++)
                            {
                                dgvTaxReport.Rows.Add();
                                dgvTaxReport.Rows[i].Cells["dgvtxtSlNo"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["SlNo"]);
                                dgvTaxReport.Rows[i].Cells["dgvtxtDate"].Value = ListObj[0].Rows[i]["Date"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtVoucherType"].Value = ListObj[0].Rows[i]["TypeofVoucher"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtVoucherNo"].Value = ListObj[0].Rows[i]["Voucher No"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtCashParty"].Value = ListObj[0].Rows[i]["Cash/Party"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtTIN"].Value = ListObj[0].Rows[i]["TIN"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtCST"].Value = ListObj[0].Rows[i]["CST"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtBillAmount"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["Bill Amount"]);
                                dgvTaxReport.Rows[i].Cells["dgvtxtCessAmount"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["Cess Amount"]);
                                dgvTaxReport.Rows[i].Cells["dgvtxtTaxAmount"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["Tax Amount"]);
                            }
                        }
                    }
                    else
                    {
                        ListObj = bllTax.TaxReportGridFillByProductwise(dtFromDate, dtToDate, dectaxId, decvoucherTypeId, strTypeofVoucher, isInput);
                        if (ListObj[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ListObj[0].Rows.Count; i++)
                            {
                                dgvTaxReport.Rows.Add();
                                dgvTaxReport.Rows[i].Cells["dgvtxtSlNo"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["SlNo"]);
                                dgvTaxReport.Rows[i].Cells["dgvtxtDate"].Value = ListObj[0].Rows[i]["Date"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtVoucherType"].Value = ListObj[0].Rows[i]["Voucher Type"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtBillNo"].Value = ListObj[0].Rows[i]["Bill No"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtItem"].Value = ListObj[0].Rows[i]["Item"].ToString();
                                dgvTaxReport.Rows[i].Cells["dgvtxtBillAmount"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["Bill Amount"]);
                                dgvTaxReport.Rows[i].Cells["dgvtxtTax"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["Tax %"]);
                                dgvTaxReport.Rows[i].Cells["dgvtxtTaxAmount"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["Tax Amount"]);
                                dgvTaxReport.Rows[i].Cells["dgvtxtTotalAmount"].Value = Convert.ToDecimal(ListObj[0].Rows[i]["Total Amount"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to date initially
        /// </summary>
        public void InitialDateSettings()
        {
            try
            {
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill TypeOfVoucher combobox
        /// </summary>
        public void TypeOfVoucherCombofill()
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                listObj = BllVoucherType.TypeOfVoucherCombofillForVatAndTaxReport();
                DataRow dr = listObj[0].NewRow();
                dr["typeOfVoucher"] = "All";
                dr["voucherTypeId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbTypeOfVoucher.DataSource = listObj[0];
                cmbTypeOfVoucher.DisplayMember = "typeOfVoucher";
                cmbTypeOfVoucher.ValueMember = "voucherTypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region EVENTS
        /// <summary>
        /// On value change of dtpFromDate
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
                MessageBox.Show("TR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateTime date = this.dtpToDate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation obj = new DateValidation();
                obj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaxReport_Load(object sender, EventArgs e)
        {
            try
            {
                rbtnInput.Checked = true;
                rbtnBillwise.Checked = true;
                VoucherTypeComboFill(cmbTypeOfVoucher.SelectedText);
                TypeOfVoucherCombofill();
                cmbVoucherType.Enabled = false;
                TaxComboFill();
                InitialDateSettings();
                GridFill();
                dgvTaxReport.Columns["dgvtxtBillNo"].Visible = false;
                dgvTaxReport.Columns["dgvtxtItem"].Visible = false;
                dgvTaxReport.Columns["dgvtxtTax"].Visible = false;
                dgvTaxReport.Columns["dgvtxtTotalAmount"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtFromDate.Text != string.Empty && txtToDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) < Convert.ToDateTime(txtFromDate.Text))
                    {
                        MessageBox.Show("Todate should be greater than fromdate", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                        DateTime dt;
                        DateTime.TryParse(txtToDate.Text, out dt);
                        dtpToDate.Value = dt;
                        dtpFromDate.Value = dt;
                    }
                }
                else if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString();
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString();
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                    dtpFromDate.Value = dt;
                }
                dgvTaxReport.Rows.Clear();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of rbtnInput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnInput_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnInput.Checked)
                {
                    isInput = true;
                    dgvTaxReport.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of rbtnOutput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnOutput_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnOutput.Checked)
                {
                    isInput = false;
                    dgvTaxReport.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of rbtnBillwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnBillwise_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnBillwise.Checked)
                {
                    isBillwise = true;
                    dgvTaxReport.Rows.Clear();
                    dgvTaxReport.Columns["dgvtxtVoucherNo"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtBillNo"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtItem"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtCashParty"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtTIN"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtCST"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtTax"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtCessAmount"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtTotalAmount"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of rbtnProductwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnProductwise_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnProductwise.Checked)
                {
                    isBillwise = false;
                    dgvTaxReport.Rows.Clear();
                    dgvTaxReport.Columns["dgvtxtVoucherNo"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtBillNo"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtItem"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtCashParty"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtTIN"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtCST"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtTax"].Visible = true;
                    dgvTaxReport.Columns["dgvtxtCessAmount"].Visible = false;
                    dgvTaxReport.Columns["dgvtxtTotalAmount"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dgvTaxReport.Rows.Clear();
                rbtnInput.Checked = true;
                rbtnBillwise.Checked = true;
                
                TypeOfVoucherCombofill();
                cmbVoucherType.Enabled = false;
                TaxComboFill();
                InitialDateSettings();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (rbtnInput.Checked)
                {
                    isInput = true;
                }
                else
                {
                    isInput = false;
                }
                if (rbtnBillwise.Checked)
                {
                    isBillwise = true;
                }
                else
                {
                    isBillwise = false;
                }
                TaxBll bllTax = new TaxBll();
                DataSet dsTaxReport = new DataSet();
                DateTime dtFromDate = DateTime.Parse(txtFromDate.Text);
                DateTime dtToDate = DateTime.Parse(txtToDate.Text);
                decimal dectaxId = Convert.ToDecimal(cmbTax.SelectedValue.ToString());
                decimal decvoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                if (isBillwise)
                {
                    dsTaxReport = bllTax.TaxCrystalReportGridFillByBillWise(1, dtFromDate, dtToDate, dectaxId, decvoucherTypeId, isInput);
                }
                else
                {
                    dsTaxReport = bllTax.TaxCrystalReportGridFillByProductwise(1, dtFromDate, dtToDate, dectaxId, decvoucherTypeId, isInput);
                }
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                if (dgvTaxReport.Rows.Count > 0)
                {
                    frmReport.TaxCrystalReportPrint(dsTaxReport, isBillwise);
                }
                else
                {
                    Messages.InformationMessage("No Data Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbTypeOfVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbVoucherType.Enabled = true;
                string strVoucherName = Convert.ToString(cmbTypeOfVoucher.Text);
                VoucherTypeComboFill(strVoucherName);
                if (cmbTypeOfVoucher.SelectedIndex == 0)
                {
                    cmbVoucherType.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvTaxReport, "Tax Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:29 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region NAVIGATIONS
        /// <summary>
        /// Enterkey navigation of txtFromDate
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
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text == string.Empty)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionLength = 0;
                        txtFromDate.SelectionStart = 0;
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    cmbTypeOfVoucher.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbTax
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTax_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rbtnInput.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbVoucherType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbVoucherType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbTax.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbTypeOfVoucher.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of rbtnInput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnInput_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rbtnOutput.Enabled)
                    {
                        rbtnOutput.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbTax.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of rbtnOutput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnOutput_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rbtnBillwise.Enabled)
                    {
                        rbtnBillwise.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnInput.Enabled)
                    {
                        rbtnInput.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of rbtnBillwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnBillwise_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (rbtnProductwise.Enabled)
                    {
                        rbtnProductwise.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnOutput.Enabled)
                    {
                        rbtnOutput.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of rbtnProductwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnProductwise_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnBillwise.Enabled)
                    {
                        rbtnBillwise.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Esc of formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTaxReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("TR:26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    btnPrint.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (rbtnProductwise.Enabled)
                    {
                        rbtnProductwise.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of btnSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("TR:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// backspace navigation of cmbTypeOfVoucher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTypeOfVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionLength = 0;
                    txtToDate.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion



    }
}
