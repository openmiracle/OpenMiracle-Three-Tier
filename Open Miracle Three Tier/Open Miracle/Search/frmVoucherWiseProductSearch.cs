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
    public partial class frmVoucherWiseProductSearch : Form
    {

        #region PUBLIC VARIABLES
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        TransactionsGeneralFillBll objtransactiongeneralfill = new TransactionsGeneralFillBll();
        int inCurrenRowIndex = 0;
        bool isFormLoad = false;
        string strVoucherType = string.Empty;
        string strCashOrParty = string.Empty;
        string strGroupText = string.Empty;
        public decimal decMasterId;
        public decimal decVoucherTypeId;
        #endregion

        #region Functions
        /// <summary>
        /// Function to fill ProductGroup Combobox
        /// </summary>
        public void FillProductGroup()
        {
            try
            {

                ProductGroupBll BllProductGroup = new ProductGroupBll();
                List<DataTable> listObjProductGroup = new List<DataTable>();
                listObjProductGroup = BllProductGroup.ProductGroupViewAll();
                DataRow dr = listObjProductGroup[0].NewRow();
                dr["groupId"] = 0;
                dr["groupName"] = "All";
                listObjProductGroup[0].Rows.InsertAt(dr, 0);
                cmbProductGroup.DataSource = listObjProductGroup[0];
                cmbProductGroup.ValueMember = "groupId";
                cmbProductGroup.DisplayMember = "groupName";
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :01" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill VoucherType Combobox
        /// </summary>
        public void VoucherTypeFill()
        {
            try
            {

                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> listObjVoucher = new List<DataTable>();
                listObjVoucher = BllVoucherType.VoucherWiseProductSearchCombofill();
                DataRow dr = listObjVoucher[0].NewRow();
                dr["voucherTypeId"] = 0;
                dr["voucherTypeName"] = "All";
                listObjVoucher[0].Rows.InsertAt(dr, 0);
                cmbVoucherType.DataSource = listObjVoucher[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :02" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to generat Serial no for Grid
        /// </summary>
        public void SerialNo()
        {
            try
            {

                int inCount = 1;

                foreach (DataGridViewRow row in dgvVoucherwiseProductSearch.Rows)
                {

                    row.Cells["SlNo"].Value = inCount.ToString();

                    inCount++;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :03" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill the grid based on the search conditions
        /// </summary>
        public void FillGrid()
        {
            try
            {
              

                decimal decProdGroup = 0;
                decimal decLedgerId = 0;
                decimal decVoucherTypeId = 0;
                string strProductName = string.Empty;
                string strProductCode = string.Empty;
                string strVoucherNo = string.Empty;
                if (cmbCashOrParty.SelectedIndex > -1)
                {
                    if (cmbCashOrParty.SelectedIndex == 0 || cmbCashOrParty.SelectedIndex == -1)
                    {
                        decLedgerId = 0;
                    }
                    else
                    {
                        decLedgerId = Convert.ToDecimal(cmbCashOrParty.SelectedValue.ToString());

                    }
                }
                if (cmbProductGroup.SelectedIndex > -1)
                {
                    if (cmbProductGroup.SelectedIndex == 0 || cmbProductGroup.SelectedIndex == -1)
                    {
                        decProdGroup = 0;
                    }
                    else
                    {
                        decProdGroup = Convert.ToDecimal(cmbProductGroup.SelectedValue.ToString());

                    }
                }

                if (cmbVoucherType.SelectedIndex > -1)
                {
                    if (cmbVoucherType.SelectedValue.ToString() != "System.Data.DataRowView" && cmbVoucherType.Text != "System.Data.DataRowView")
                    {

                        if (cmbVoucherType.SelectedIndex == 0 || cmbVoucherType.SelectedIndex == -1)
                        {

                            decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                        }
                        else
                        {
                            decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());

                        }
                    }
                }

                if (txtVoucherNo.Text == string.Empty)
                {
                    strVoucherNo = string.Empty;
                }
                else
                {
                    strVoucherNo = txtVoucherNo.Text;
                }
                if (txtProductCode.Text == string.Empty)
                {
                    strProductCode = string.Empty;
                }
                else
                {
                    strProductCode = txtProductCode.Text;
                }
                if (txtProductName.Text == string.Empty)
                {
                    strProductName = string.Empty;
                }
                else
                {
                    strProductName = txtProductName.Text;
                }
                List<DataTable> listobj = new List<DataTable>();
                ProductCreationBll BllProductCreation = new ProductCreationBll();
                listobj = BllProductCreation.VoucherWiseProductSearch(decVoucherTypeId, strVoucherNo, Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text), decProdGroup, strProductCode, decLedgerId, strProductName);
                dgvVoucherwiseProductSearch.DataSource = listobj[0];
                decimal dcTotalInward = 0;
                decimal dcTotalOutward = 0;
                try
                {

                    dcTotalInward = Math.Round((Convert.ToDecimal(listobj[0].Compute("Sum([InwardQty])", string.Empty).ToString())), 2);

                }
                catch { }
                try
                {
                    dcTotalOutward = Math.Round((Convert.ToDecimal(listobj[0].Compute("Sum([OutwardQty])", string.Empty).ToString())), 2);


                }
                catch { }
                decimal dcBalance = Math.Round((dcTotalInward - dcTotalOutward), 2);

                lblTotalInqty.Text = "Total Inward : " + dcTotalInward.ToString();

                lblTotalOutQty.Text = "Total Outward : " + dcTotalOutward.ToString();

                lblBalanceQty.Text = "Balance : " + dcBalance.ToString();


                if (inCurrenRowIndex >= 0 && dgvVoucherwiseProductSearch.Rows.Count > 0 && inCurrenRowIndex < dgvVoucherwiseProductSearch.Rows.Count)
                {
                    if (dgvVoucherwiseProductSearch.Columns.Contains("outwardQty"))
                    {
                        dgvVoucherwiseProductSearch.CurrentCell = dgvVoucherwiseProductSearch.Rows[inCurrenRowIndex].Cells["dgvtxtOutwardQty"];
                    }
                    else
                    {


                    }

                }
                inCurrenRowIndex = 0;
                dgvVoucherwiseProductSearch.Columns["dgvtxtrate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :04" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void clear()
        {
            try
            {
                txtVoucherNo.Clear();
                txtProductCode.Clear();
                txtProductName.Clear();
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpFromDate.Value = PublicVariables._dtFromDate;
                dtpFromDate.Text = dtpFromDate.Value.ToString("dd-MMM-yyyy");
                dtpToDate.Value = PublicVariables._dtToDate;
                dtpToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
                objtransactiongeneralfill.CashOrPartyComboFill(cmbCashOrParty, true);
                FillProductGroup();
                VoucherTypeFill();
                txtFromDate.Focus();
                FillGrid();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("VPS :05" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Create an instance for frmVoucherWiseProductSearch
        /// </summary>
        public frmVoucherWiseProductSearch()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When form  load  call the functions and clear the form controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVoucherWiseProductSearch_Load(object sender, EventArgs e)
        {

            try
            {
                isFormLoad = true;
                clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :06" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search button click cakll the grid fill function 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :07" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        /// <summary>
        /// Make enabled the cash or party combobox based on the criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbVoucherType.Text == "Material Receipt" || cmbVoucherType.Text == "Rejection Out" || cmbVoucherType.Text == "Purchase Invoice" || cmbVoucherType.Text == "Purchase Return" || cmbVoucherType.Text == "Delivery Note" || cmbVoucherType.Text == "Rejection In" || cmbVoucherType.Text == "Sales Invoice" || cmbVoucherType.Text == "Sales Return")
                {
                    cmbCashOrParty.Enabled = true;
                }
                else
                {
                    cmbCashOrParty.Enabled = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :08" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To set the textbox from date value based on the dtpfrom value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                txtFromDate.Text = dtpFromDate.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :09" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To set the textbox To date value based on the dtpTo value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = dtpToDate.Value.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Cell double click in grid to view the curresponding item in that form and open the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVoucherwiseProductSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex!=-1)
                {
                    int inI = dgvVoucherwiseProductSearch.CurrentCell.RowIndex;
                    foreach (DataGridViewRow dgv in dgvVoucherwiseProductSearch.Rows)
                    {
                        decMasterId = decimal.Parse(dgv.Cells["dgvtxtmasterId"].Value.ToString());
                        strVoucherType = dgv.Cells["dgvtxtTypeOfVoucher"].Value.ToString();
                        decVoucherTypeId = Convert.ToDecimal(dgv.Cells["dgvtxtvoucherTypeId"].Value.ToString());
                        if (dgv.Index == inI)
                        {
                            break;
                        }

                    }

                    if (decMasterId != 0 && strVoucherType == "Material Receipt")
                    {
                        frmMaterialReceipt objReceipt = new frmMaterialReceipt();
                        objReceipt.WindowState = FormWindowState.Normal;
                        objReceipt.MdiParent = formMDI.MDIObj;
                        objReceipt.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;

                    }

                    else if (decMasterId != 0 && strVoucherType == "Physical Stock")
                    {
                        frmPhysicalStock objPhysical = new frmPhysicalStock();
                        objPhysical.WindowState = FormWindowState.Normal;
                        objPhysical.MdiParent = formMDI.MDIObj;
                        objPhysical.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;
                    }

                    else if (decMasterId != 0 && strVoucherType == "Purchase Invoice")
                    {
                        frmPurchaseInvoice objpurchase = new frmPurchaseInvoice();
                        objpurchase.WindowState = FormWindowState.Normal;
                        objpurchase.MdiParent = formMDI.MDIObj;
                        objpurchase.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;
                    }

                    else if (decMasterId != 0 && strVoucherType == "Rejection Out")
                    {
                        frmRejectionOut objRejection = new frmRejectionOut();
                        objRejection.WindowState = FormWindowState.Normal;
                        objRejection.MdiParent = formMDI.MDIObj;
                        objRejection.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;
                    }


                    else if (decMasterId != 0 && strVoucherType == "Rejection In")
                    {
                        frmRejectionIn objRejection = new frmRejectionIn();
                        objRejection.WindowState = FormWindowState.Normal;
                        objRejection.MdiParent = formMDI.MDIObj;
                        objRejection.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;
                    }
                    else if (decMasterId != 0 && strVoucherType == "Purchase Return")
                    {
                        frmPurchaseReturn objPurchase = new frmPurchaseReturn();
                        objPurchase.WindowState = FormWindowState.Normal;
                        objPurchase.MdiParent = formMDI.MDIObj;
                        objPurchase.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;
                    }
                    else if (decMasterId != 0 && strVoucherType == "Sales Return")
                    {
                        frmSalesReturn frmObj = new frmSalesReturn();
                        frmObj.WindowState = FormWindowState.Normal;
                        frmObj.MdiParent = formMDI.MDIObj;
                        frmObj.CallFromVoucherWiseProductSearch(this, decMasterId, true);
                        this.Enabled = false;
                    }

                    else if (decMasterId != 0 && strVoucherType == "Delivery Note")
                    {
                        frmDeliveryNote objDeliveryReport = new frmDeliveryNote();
                        objDeliveryReport.WindowState = FormWindowState.Normal;
                        objDeliveryReport.MdiParent = formMDI.MDIObj;
                        objDeliveryReport.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;
                    }

                    else if (decMasterId != 0 && strVoucherType == "Sales Order")
                    {
                        frmSalesOrder dbjfrmSalesorder = new frmSalesOrder();
                        dbjfrmSalesorder.WindowState = FormWindowState.Normal;
                        dbjfrmSalesorder.MdiParent = formMDI.MDIObj;
                        dbjfrmSalesorder.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;

                    }

                    else if (decMasterId != 0 && strVoucherType == "Purchase Order")
                    {

                        frmPurchaseOrder objfrmPurchaseorder = new frmPurchaseOrder();

                        objfrmPurchaseorder.WindowState = FormWindowState.Normal;
                        objfrmPurchaseorder.MdiParent = formMDI.MDIObj;
                        objfrmPurchaseorder.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;

                    }

                    else if (decMasterId != 0 && strVoucherType == "Sales Quotation")
                    {
                        frmSalesQuotation objfrmSalesquotation = new frmSalesQuotation();

                        objfrmSalesquotation.WindowState = FormWindowState.Normal;
                        objfrmSalesquotation.MdiParent = formMDI.MDIObj;
                        objfrmSalesquotation.CallFromVoucherWiseProductSearch(this, decMasterId);
                        this.Enabled = false;

                    }

                    else if (decMasterId != 0 && strVoucherType == "Sales Invoice")
                    {
                        frmSalesInvoice objSalesReport = new frmSalesInvoice();
                        //SalesMasterSP spSalesMaster = new SalesMasterSP();
                        SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                        objSalesReport.WindowState = FormWindowState.Normal;
                        objSalesReport.MdiParent = formMDI.MDIObj;
                        bool blPOS = BllSalesInvoice.DayBookSalesInvoiceOrPOS(decMasterId, decVoucherTypeId);
                        frmSalesInvoice frmSalesInvoice = new frmSalesInvoice();
                        frmPOS frmPOS = new frmPOS();
                        if (blPOS == true)
                        {
                            frmPOS = Application.OpenForms["frmPOS"] as frmPOS;
                            if (frmPOS == null)
                            {
                                frmPOS = new frmPOS();
                                frmPOS.MdiParent = formMDI.MDIObj;

                                frmPOS.callFromVoucherWiseProductSearch(this, decMasterId);

                            }
                        }
                        else
                        {
                            frmSalesInvoice = Application.OpenForms["frmSalesInvoice"] as frmSalesInvoice;
                            if (frmSalesInvoice == null)
                            {
                                frmSalesInvoice = new frmSalesInvoice();
                                frmSalesInvoice.MdiParent = formMDI.MDIObj;
                                objSalesReport.CallFromVoucherWiseProductSearch(this, decMasterId);
                            }
                        }

                        this.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Button view details click, here call the grid cell double click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVoucherwiseProductSearch.CurrentRow != null)
                {
                    DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvVoucherwiseProductSearch.CurrentCell.ColumnIndex, dgvVoucherwiseProductSearch.CurrentCell.RowIndex);
                    dgvVoucherwiseProductSearch_CellDoubleClick(sender, ex);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the serial no function to generate the serial no 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVoucherwiseProductSearch_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                SerialNo();
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Reset the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {

                clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show("VPS :15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation and fill dtp value into the fromDate textbox
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
                    txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Date validation and fill dtp value into the todate textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {

                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtToDate);
                if (txtToDate.Text != string.Empty && txtFromDate.Text != string.Empty)
                {
                    if (Convert.ToDateTime(txtToDate.Text) <= Convert.ToDateTime(txtFromDate.Text))
                    {
                        txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                        txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");

                        DateTime dt;
                        DateTime.TryParse(txtToDate.Text, out dt);
                        dtpToDate.Value = dt;
                    }
                    else
                    {
                        txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                        DateTime dt;
                        DateTime.TryParse(txtToDate.Text, out dt);
                        dtpToDate.Value = dt;
                    }
                    
                }
                else
                {
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                    DateTime dt;
                    DateTime.TryParse(txtToDate.Text, out dt);
                    dtpToDate.Value = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :17" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        #endregion

        #region NAVIGATION
        /// <summary>
        /// For enter key and BackSpace Navigation
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

                MessageBox.Show("VPS :18" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        /// <summary>
        /// For enter key and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbVoucherType.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Text == string.Empty || txtToDate.SelectionStart == 0)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionStart = 0;
                        txtFromDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :19" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherNo.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtToDate.Focus();
                    txtToDate.SelectionStart = 0;
                    txtToDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :20" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For enter key and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else
                    {
                        cmbProductGroup.Focus();
                    }

                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Text == string.Empty || txtVoucherNo.SelectionStart == 0)
                    {
                        cmbVoucherType.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :21" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For enter key and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbProductGroup.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtVoucherNo.Focus();
                    txtVoucherNo.SelectionStart = 0;
                    txtVoucherNo.SelectionLength = 0;
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("VPS :22" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For enter key and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductCode.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbCashOrParty.Enabled)
                    {
                        cmbCashOrParty.Focus();
                    }
                    else
                    {
                        txtVoucherNo.Focus();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :23" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For enter key and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtProductName.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductCode.Text == string.Empty || txtProductCode.SelectionStart == 0)
                    {
                        cmbProductGroup.Focus();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :24" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For enter key and BackSpace Navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtProductName.Text == string.Empty || txtProductName.SelectionStart == 0)
                    {
                        txtProductCode.Focus();
                        txtProductCode.SelectionLength = 0;
                        txtProductCode.SelectionStart = 0;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :25" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// For enter key and BackSpace Navigation
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
                    txtProductName.Focus();
                    txtProductName.SelectionStart = 0;
                    txtProductName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("VPS :26" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// For enter key and BackSpace Navigation
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

                MessageBox.Show("VPS :27" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Form key down for Quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVoucherWiseProductSearch_KeyDown(object sender, KeyEventArgs e)
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

                MessageBox.Show("VPS :28" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion


    }
}
