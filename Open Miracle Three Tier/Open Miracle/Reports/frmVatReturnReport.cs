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
    public partial class frmVatReturnReport : Form
    {
        #region PublicVariable
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        DataTable dtblFill = new DataTable();
        string strformat, strVoucherName = "All";
        decimal dcSalesId;
        #endregion
        #region Function
        /// <summary>
        /// Create an Instance of a frmVatReturnReport class
        /// </summary>
        public frmVatReturnReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to generate serialNo
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvVatreturn.Rows)
                {
                    row.Cells["dgvtxtSlno"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Calaculate total tax amount
        /// </summary>
        public void CalculateTotal()
        {
            decimal dcTaxableTotal = 0, dcTaxTotal = 0;
            try
            {
                if (dgvVatreturn.Rows.Count > 1)
                {
                    for (int i = 0; i <= dgvVatreturn.Rows.Count - 1; i++)
                    {
                        if (dgvVatreturn.Rows[i].Cells["dgvtxtTaxableAmount"].Value != null)
                        {
                            dcTaxableTotal = dcTaxableTotal + Convert.ToDecimal(dgvVatreturn.Rows[i].Cells["dgvtxtTaxableAmount"].Value.ToString());
                        }
                        if (dgvVatreturn.Rows[i].Cells["dgvtxttax"].Value != null)
                        {
                            dcTaxTotal = dcTaxTotal + Convert.ToDecimal(dgvVatreturn.Rows[i].Cells["dgvtxttax"].Value.ToString());
                        }
                    }
                    dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTaxName"].Value = "Total";
                    dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTaxName"].Style.ForeColor = Color.Red;
                    dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTaxableAmount"].Value = dcTaxableTotal.ToString();
                    dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxttax"].Value = dcTaxTotal.ToString();
                    dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTaxableAmount"].Style.ForeColor = Color.Red;
                    dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxttax"].Style.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                rbtnFormat1.Checked = true;
                TypeOfVoucherCombofill();
                cmbVouchertype.Enabled = false;
                TaxFill();
                GridFill();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        ///// <summary>
        ///// Function to fill the vouchertypes
        ///// </summary>
        //public void VoucherFill()
        //{
        //    try
        //    {
        //        VoucherTypeSP spVoucher = new VoucherTypeSP();
        //        DataTable dt = new DataTable();
        //        dt = spVoucher.VatComboFill();
        //        DataRow dr = dt.NewRow();
        //        dr[1] = "All";
        //        dt.Rows.InsertAt(dr, 0);
        //        cmbVouchertype.ValueMember = "voucherTypeId";
        //        cmbVouchertype.DisplayMember = "voucherTypeName";
        //        cmbVouchertype.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("VRR:04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
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
                cmbTypeofVoucher.DataSource = listObj[0];
                cmbTypeofVoucher.DisplayMember = "typeOfVoucher";
                cmbTypeofVoucher.ValueMember = "voucherTypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the tax combobox
        /// </summary>
        public void TaxFill()
        {
            try
            {
                TaxBll bllTax = new TaxBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllTax.TaxViewAll();
                DataRow dr = ListObj[0].NewRow();
                dr[1] = "All";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbTax.ValueMember = "taxId";
                cmbTax.DisplayMember = "taxName";
                cmbTax.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the grid
        /// </summary>
        public void GridFill()
        {
            try
            {
                dgvVatreturn.Rows.Clear();
                List<DataTable> list = new List<DataTable>();
                string strVoucherTypeName=string.Empty;
                decimal decVoucherTypeId;
                if (rbtnFormat1.Checked)
                {
                    strformat = "type1";
                }
                else
                {
                    strformat = "type2";
                }
                if (cmbVouchertype.Enabled)
                {
                    decVoucherTypeId = Convert.ToDecimal(cmbVouchertype.SelectedValue.ToString());
                }
                else
                {
                    decVoucherTypeId = 0;
                }
                strVoucherTypeName = Convert.ToString(cmbTypeofVoucher.Text);
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                list = BllVoucherType.VatGridFill(Convert.ToDateTime(dtpFrmDate.Text), Convert.ToDateTime(dtpToDate.Text), strVoucherTypeName, decVoucherTypeId, strformat, cmbTax.Text);
                dtblFill = list[0];
                List<DataTable> listObjTaxName = new List<DataTable>();
                listObjTaxName = BllVoucherType.VatViewTaxNames();
                if (rbtnFormat1.Checked)
                {
                    dgvVatreturn.Columns["dgvtxtTaxName"].Visible = false;
                    dgvVatreturn.Columns["dgvtxtTaxableAmount"].Visible = false;
                    dgvVatreturn.Columns["dgvtxttax"].Visible = false;
                    dgvVatreturn.Columns["dgvtxtQty"].Visible = true;
                    dgvVatreturn.Columns["dgvtxtSalesAmount"].Visible = true;
                    dgvVatreturn.Columns["dgvtxtTaxAmount"].Visible = true;
                    dgvVatreturn.Columns["dgvtxtNetAmount"].Visible = true;
                    dgvVatreturn.Columns["dgvtxtbillDiscount"].Visible = true;
                    foreach (DataRow drowDetails in list[0].Rows)
                    {
                        dgvVatreturn.Rows.Add();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtInvoiceNo"].Value = drowDetails["Invoice No"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtDate"].Value = drowDetails["Date"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtPartyName"].Value = drowDetails["Party Name"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtMailingName"].Value = drowDetails["Mailing Name"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtsalesmasterid"].Value = drowDetails["SalesMasterId"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtvoucherName"].Value = drowDetails["voucherName"].ToString();

                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtVoucherType"].Value = drowDetails["voucherType"].ToString();

                        decimal dSaleId = Convert.ToDecimal(dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtsalesmasterid"].Value.ToString());
                        string strVoucherType = Convert.ToString(dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtVoucherType"].Value);
                        string qt = BllVoucherType.VoucherreportsumQty(dSaleId, strVoucherType);

                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTinNo"].Value = drowDetails["Tin No"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtQty"].Value = qt;
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtSalesAmount"].Value = drowDetails["Sales Amound"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTaxAmount"].Value =Math.Round(Convert.ToDecimal(drowDetails["Tax Amount"].ToString()),PublicVariables._inNoOfDecimalPlaces).ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtCess"].Value = drowDetails["Cess"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtNetAmount"].Value = Math.Round(Convert.ToDecimal(drowDetails["Net Amount"].ToString()),PublicVariables._inNoOfDecimalPlaces).ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtbillDiscount"].Value =Math.Round(Convert.ToDecimal(drowDetails["billDiscount"].ToString()),PublicVariables._inNoOfDecimalPlaces).ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtGrandTotal"].Value = Math.Round(Convert.ToDecimal(drowDetails["grandtotal"].ToString()), PublicVariables._inNoOfDecimalPlaces).ToString(); ;
                       
                    }
                    if (dgvVatreturn.Rows.Count > 0)
                    {
                        SerialNo();
                    }
                }
                else
                {
                    dgvVatreturn.Rows.Clear();
                    dgvVatreturn.Columns["dgvtxtTaxName"].Visible = true;
                    dgvVatreturn.Columns["dgvtxtTaxableAmount"].Visible = true;
                    dgvVatreturn.Columns["dgvtxttax"].Visible = true;
                    dgvVatreturn.Columns["dgvtxtQty"].Visible = false;
                    dgvVatreturn.Columns["dgvtxtSalesAmount"].Visible = false;
                    dgvVatreturn.Columns["dgvtxtTaxAmount"].Visible = false;
                    dgvVatreturn.Columns["dgvtxtNetAmount"].Visible = false;
                    dgvVatreturn.Columns["dgvtxtbillDiscount"].Visible = false;
                    foreach (DataRow drowDetails in list[0].Rows)
                    {
                        dgvVatreturn.Rows.Add();
                        
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtInvoiceNo"].Value = drowDetails["Invoice No"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtDate"].Value = drowDetails["Date"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtPartyName"].Value = drowDetails["Party Name"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtMailingName"].Value = drowDetails["Mailing Name"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtsalesmasterid"].Value = drowDetails["SalesMasterId"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTinNo"].Value = drowDetails["Tin No"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtGrandTotal"].Value = drowDetails["grandtotal"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTaxName"].Value = drowDetails["taxName"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtTaxableAmount"].Value = drowDetails["rate"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxttax"].Value = drowDetails["taxamount"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtvoucherName"].Value = drowDetails["voucherName"].ToString();
                        dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 1].Cells["dgvtxtVoucherType"].Value = drowDetails["voucherType"].ToString();
                    }
                    if (dgvVatreturn.Rows.Count > 0)
                    {
                        SerialNo();
                        dgvVatreturn.Rows.Add();
                        CalculateTotal();
                    }
                    dtblFill.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void VoucherTypeComboFill(string strVoucherName)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                listObj = BllVoucherType.VoucherTypeCombofillForTaxAndVat(strVoucherName);
                DataRow dr = listObj[0].NewRow();
                dr["voucherTypeName"] = " ";
                dr["voucherTypeId"] = 0;
                listObj[0].Rows.InsertAt(dr, 0);
                cmbVouchertype.DataSource = listObj[0];
                cmbVouchertype.DisplayMember = "voucherTypeName";
                cmbVouchertype.ValueMember = "voucherTypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("TR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        #region Events
       /// <summary>
       /// On formload
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void frmVatReturnReport_Load(object sender, EventArgs e)
        {
            try
            {
                rbtnFormat1.Checked = true;
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On value change of dtpFrmDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFrmDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFrmDate.Value;
                txtFromDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation dv = new DateValidation();
                dv.DateValidationFunction(txtFromDate);
                if (txtFromDate.Text == string.Empty)
                {
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }
                string d = txtFromDate.Text;
                dtpFrmDate.Value = DateTime.Parse(d.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtToDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation dv = new DateValidation();
                dv.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                string d = txtToDate.Text;
                dtpToDate.Value = Convert.ToDateTime(d.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dgvVatreturn.Rows.Clear();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtFromDate.Focus();
                cmbVouchertype.SelectedIndex = 0;
                dgvVatreturn.Rows.Clear();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                frmReport crptReport = new frmReport();
                DataSet ds = new DataSet();
                List<DataTable> listObjFormat2 = new List<DataTable>();
                DataTable dtblTotal = new DataTable();
                //CompanySP spCompany = new CompanySP();
                CompanyCreationBll bllCompanyCreation = new CompanyCreationBll();
                List<DataTable> listObjCompany = new List<DataTable>();
                listObjCompany = bllCompanyCreation.CompanyViewAll();
                if (dgvVatreturn.Rows.Count > 0)
                {
                    if (dtblFill.Rows.Count > 0)
                    {
                        DataTable dtblReportFill = new DataTable();
                        dtblReportFill.Columns.Add("SlNO");
                        dtblReportFill.Columns.Add("Invoice No");
                        dtblReportFill.Columns.Add("Date");
                        dtblReportFill.Columns.Add("Party Name");
                        dtblReportFill.Columns.Add("Mailing Name");
                        dtblReportFill.Columns.Add("Tin No");
                        dtblReportFill.Columns.Add("qt");
                        dtblReportFill.Columns.Add("Sales Amound");
                        dtblReportFill.Columns.Add("Tax Amount");
                        dtblReportFill.Columns.Add("Cess");
                        dtblReportFill.Columns.Add("Net Amount");
                        dtblReportFill.Columns.Add("billDiscount");
                        dtblReportFill.Columns.Add("grandtotal");
                        for (int i = 0; i < dgvVatreturn.Rows.Count; i++)
                        {
                            DataRow drow = dtblReportFill.NewRow();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtSlno"].Value != null)
                                drow["SlNO"] = dgvVatreturn.Rows[i].Cells["dgvtxtSlno"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtInvoiceNo"].Value != null)
                                drow["Invoice No"] = dgvVatreturn.Rows[i].Cells["dgvtxtInvoiceNo"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtDate"].Value != null)
                                drow["Date"] = dgvVatreturn.Rows[i].Cells["dgvtxtDate"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtPartyName"].Value != null)
                                drow["Party Name"] = dgvVatreturn.Rows[i].Cells["dgvtxtPartyName"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtMailingName"].Value.ToString() != string.Empty)
                                drow["Mailing Name"] = dgvVatreturn.Rows[i].Cells["dgvtxtMailingName"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtTinNo"].Value != null)
                                drow["Tin No"] = dgvVatreturn.Rows[i].Cells["dgvtxtTinNo"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtQty"].Value != null)
                                drow["qt"] = dgvVatreturn.Rows[i].Cells["dgvtxtQty"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtSalesAmount"].Value != null)
                                drow["Sales Amound"] = dgvVatreturn.Rows[i].Cells["dgvtxtSalesAmount"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtTaxAmount"].Value != null)
                                drow["Tax Amount"] = dgvVatreturn.Rows[i].Cells["dgvtxtTaxAmount"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtCess"].Value != null)
                                drow["Cess"] = dgvVatreturn.Rows[i].Cells["dgvtxtCess"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtNetAmount"].Value != null)
                                drow["Net Amount"] = dgvVatreturn.Rows[i].Cells["dgvtxtNetAmount"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtbillDiscount"].Value != null)
                                drow["billDiscount"] = dgvVatreturn.Rows[i].Cells["dgvtxtbillDiscount"].Value.ToString();
                            if (dgvVatreturn.Rows[i].Cells["dgvtxtGrandTotal"].Value != null)
                                drow["grandtotal"] = dgvVatreturn.Rows[i].Cells["dgvtxtGrandTotal"].Value.ToString();
                            dtblReportFill.Rows.Add(drow);
                        }
                        ds.Tables.Add(dtblReportFill);
                        ds.Tables.Add(listObjCompany[0]);
                        crptReport.vatreturnReport(ds);
                    }
                    else
                    {
                        VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                        listObjFormat2 = BllVoucherType.VatGridFill(DateTime.Parse(dtpFrmDate.Text), DateTime.Parse(dtpToDate.Text), cmbTypeofVoucher.Text, Convert.ToDecimal(cmbVouchertype.SelectedValue.ToString()), strformat, cmbTax.Text);
                        if (dgvVatreturn.Rows.Count > 1)
                        {
                            dtblTotal.Columns.Add("taxableamt");
                            dtblTotal.Columns.Add("taxAmount");
                            DataRow dr1 = dtblTotal.NewRow();
                            dr1["taxableamt"] = dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 2].Cells["dgvtxtTaxableAmount"].Value.ToString();
                            dr1["taxAmount"] = dgvVatreturn.Rows[dgvVatreturn.Rows.Count - 2].Cells["dgvtxttax"].Value.ToString();
                            dtblTotal.Rows.Add(dr1);
                            ds.Tables.Add(listObjCompany[0]);
                            ds.Tables.Add(listObjFormat2[0]);
                            ds.Tables.Add(dtblTotal);
                            crptReport.vatreturnReportFormat(ds);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data found", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When doubleclicking on the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVatreturn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvVatreturn.Rows.Count > 1)
                {
                    if (dgvVatreturn.CurrentRow.Cells["dgvtxtsalesmasterid"].Value != null)
                    {
                        //SalesMasterSP spSale = new SalesMasterSP();
                        SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                        strVoucherName = dgvVatreturn.CurrentRow.Cells["dgvtxtvoucherName"].Value.ToString();
                        dcSalesId = Convert.ToDecimal(dgvVatreturn.CurrentRow.Cells["dgvtxtsalesmasterid"].Value.ToString());
                        if (dgvVatreturn.CurrentRow.Cells["dgvtxtvoucherName"].Value != null)
                        {
                            string strpos = BllSalesInvoice.SaleMasterGetPos(dcSalesId, strVoucherName);
                            if (strpos == "0")
                            {
                                frmSalesInvoice objfrmsaleInvoice;
                                objfrmsaleInvoice = Application.OpenForms["frmSalesInvoice"] as frmSalesInvoice;
                                if (objfrmsaleInvoice == null)
                                {
                                    objfrmsaleInvoice = new frmSalesInvoice();
                                    objfrmsaleInvoice.MdiParent = formMDI.MDIObj;
                                    objfrmsaleInvoice.callFromVatReturnReport(this, dcSalesId);
                                }
                                else
                                {
                                    objfrmsaleInvoice.callFromVatReturnReport(this, dcSalesId);
                                }
                            }
                            if (strpos == "1")
                            {
                                frmPOS objfrmpos;
                                objfrmpos = Application.OpenForms["frmPOS"] as frmPOS;
                                if (objfrmpos == null)
                                {
                                    objfrmpos = new frmPOS();
                                    objfrmpos.MdiParent = formMDI.MDIObj;
                                    objfrmpos.callFromVatReturnReport(this, dcSalesId);
                                }
                                else
                                {
                                    objfrmpos.callFromVatReturnReport(this, dcSalesId);
                                }
                            }
                            if (strpos == "a")
                            {
                                frmPurchaseInvoice objfrmPurchaseInvoice;
                                objfrmPurchaseInvoice = Application.OpenForms["frmPurchaseInvoice"] as frmPurchaseInvoice;
                                if (objfrmPurchaseInvoice == null)
                                {
                                    objfrmPurchaseInvoice = new frmPurchaseInvoice();
                                    objfrmPurchaseInvoice.MdiParent = formMDI.MDIObj;
                                    objfrmPurchaseInvoice.CallFromVatReturnReport(this, dcSalesId);
                                }
                                else
                                {
                                    objfrmPurchaseInvoice.CallFromVatReturnReport(this, dcSalesId);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbTypeofVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbVouchertype.Enabled = true;
                string strVoucherName = Convert.ToString(cmbTypeofVoucher.Text);
                VoucherTypeComboFill(strVoucherName);
                //cmbVouchertype.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvVatreturn, "VAT Return Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:26 " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Navigation
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
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmbVouchertype.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text.Trim()==string.Empty || txtToDate.SelectionLength==0)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionLength = 0;
                        txtFromDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbVouchertype
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVouchertype_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbTax.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                        txtToDate.SelectionLength = 0;
                        txtToDate.SelectionStart = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    rbtnFormat1.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbVouchertype.Focus();
                    cmbVouchertype.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of rbtnFormat1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnFormat1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    cmbTax.Focus();
                    cmbTax.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of rbtnFormat2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnFormat2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    rbtnFormat1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    rbtnFormat2.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VRR:22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of btnReset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("VRR:23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVatReturnReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("VRR:24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
