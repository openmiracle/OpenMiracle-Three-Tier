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
    public partial class frmLedgerDetails : Form
    {

        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmAccountGroupwiseReport frmAccountGroupwiseReportObj = null;
        frmAccountLedgerReport frmAccountLedgerReportObj = null;
        AccountLedgerBll bllAccountLedger = new AccountLedgerBll();
        decimal decLedgerIdForGridFill;
        frmAgeingReport frmAgeingObj = null;//to use in call from Ageing Report
        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmLedgerDetails class
        /// </summary>
        public frmLedgerDetails()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call this form from frmAccountLedgerReport to view ledger details
        /// </summary>
        /// <param name="AccountLedgerReportObj"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void CallFromAccountLedgerReport(frmAccountLedgerReport AccountLedgerReportObj, decimal decLedgerId, DateTime fromDate, DateTime toDate)
        {
            try
            {
                frmAccountLedgerReportObj = AccountLedgerReportObj;
                frmAccountLedgerReportObj.Enabled = false;
                decLedgerIdForGridFill = decLedgerId;
                txtFromDate.Text = fromDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = toDate.ToString("dd-MMM-yyyy");
                txtFromDate.Enabled = false;
                txtToDate.Enabled = false;
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
                base.Show();
                LedgerDetailsView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill ledger details corresponding to ledger
        /// </summary>
        public void LedgerDetailsView()
        {
            try
            {
                dgvLedgerDetails.Rows.Clear();
                DataSet dsLedgerDetails = bllAccountLedger.LedgerDetailsFillCorrespondingToledgerId(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txtToDate.Text), decLedgerIdForGridFill);
                foreach (DataTable dtblOpening in dsLedgerDetails.Tables)
                {
                    if (dtblOpening.TableName == "Table")
                    {
                        foreach (DataRow drOpening in dtblOpening.Rows)
                        {
                            dgvLedgerDetails.Rows.Add();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtVoucherType"].Value = "Opening";
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtDate"].Value = txtFromDate.Text;
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtCredit"].Value = drOpening.ItemArray[2].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtDebit"].Value = drOpening.ItemArray[3].ToString();
                        }
                    }
                    if (dtblOpening.TableName == "Table1")
                    {
                        foreach (DataRow drLedgerDetails in dtblOpening.Rows)
                        {
                            dgvLedgerDetails.Rows.Add();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtLedgerId"].Value = drLedgerDetails.ItemArray[0].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtVoucherTypeId"].Value = drLedgerDetails.ItemArray[2].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxttypeofVoucher"].Value = drLedgerDetails.ItemArray[3].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtMasterId"].Value = drLedgerDetails.ItemArray[4].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtVoucherType"].Value = drLedgerDetails.ItemArray[5].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtDate"].Value = drLedgerDetails.ItemArray[6].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtDebit"].Value = drLedgerDetails.ItemArray[7].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtCredit"].Value = drLedgerDetails.ItemArray[8].ToString();
                            dgvLedgerDetails.Rows[dgvLedgerDetails.Rows.Count - 1].Cells["dgvtxtpos"].Value = drLedgerDetails.ItemArray[9].ToString();
                        }
                    }
                }
                string strBalance = string.Empty;
                if (dgvLedgerDetails.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvLedgerDetails.Rows.Count; i++)
                    {
                        strBalance = CalculateBalance(i, decimal.Parse(dgvLedgerDetails.Rows[i].Cells["dgvtxtDebit"].Value.ToString()), decimal.Parse(dgvLedgerDetails.Rows[i].Cells["dgvtxtCredit"].Value.ToString()), strBalance);
                        dgvLedgerDetails.Rows[i].Cells["dgvtxtBalance"].Value = strBalance;
                    }
                }
                SerialNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate serial number in datagridview
        /// </summary>
        public void SerialNo()
        {
            try
            {
                int inCount = 1;
                foreach (DataGridViewRow row in dgvLedgerDetails.Rows)
                {
                    row.Cells["dgvtxtSlNo"].Value = inCount.ToString();
                    inCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate the balance of ledgers
        /// </summary>
        /// <param name="index"></param>
        /// <param name="decDebit"></param>
        /// <param name="decCredit"></param>
        /// <param name="strPreviousBalance"></param>
        /// <returns></returns>
        public string CalculateBalance(int index, decimal decDebit, decimal decCredit, string strPreviousBalance)
        {
            string strCurrentBalance = string.Empty;
            string strCrOrDr = string.Empty;
            decimal decRowBalance = 0;
            try
            {
                if (index > 0)
                {
                    string[] strLastBalance = strPreviousBalance.Split(' ');
                    if (strLastBalance.Length >= 2)
                    {
                        if ((strLastBalance[1] == null ? "" : strLastBalance[1]) != string.Empty)
                        {
                            if (strLastBalance[1] == "Dr")
                            {
                                decDebit = decimal.Parse(strLastBalance[0]) + decDebit;
                            }
                            if (strLastBalance[1] == "Cr")
                            {
                                decCredit = decimal.Parse(strLastBalance[0]) + decCredit;
                            }
                        }
                    }
                }
                decRowBalance = decDebit - decCredit;
                if (decRowBalance > 0)
                    strCrOrDr = " Dr";
                else if (decRowBalance < 0)
                {
                    decRowBalance = decRowBalance * (-1);
                    strCrOrDr = " Cr";
                }
                else
                    strCrOrDr = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strCurrentBalance = Convert.ToString(decRowBalance) + strCrOrDr;
        }
        /// <summary>
        /// Function to call corresponding form from ledger
        /// </summary>
        /// <param name="strTypeofVoucher"></param>
        /// <param name="decMasterId"></param>
        public void CallToCorrespondingForm(string strTypeofVoucher, decimal decMasterId)
        {
            try
            {
                switch (strTypeofVoucher)
                {
                    case "Contra Voucher":
                        frmContraVoucher frmContraVoucherObj = new frmContraVoucher();
                        frmContraVoucher frmContraVoucherOpen = Application.OpenForms["frmContraVoucher"] as frmContraVoucher;
                        if (frmContraVoucherOpen == null)
                        {
                            frmContraVoucherObj.MdiParent = this.MdiParent;
                            frmContraVoucherObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmContraVoucherOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmContraVoucherOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmContraVoucherOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Payment Voucher":
                        frmPaymentVoucher frmPaymentVoucherObj = new frmPaymentVoucher();
                        frmPaymentVoucher frmPaymentVoucherOpen = Application.OpenForms["frmPaymentVoucher"] as frmPaymentVoucher;
                        if (frmPaymentVoucherOpen == null)
                        {

                            frmPaymentVoucherObj.MdiParent = this.MdiParent;
                            frmPaymentVoucherObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmPaymentVoucherOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmPaymentVoucherOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmPaymentVoucherOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Receipt Voucher":
                        frmReceiptVoucher frmReceiptVoucherObj = new frmReceiptVoucher();
                        frmReceiptVoucher frmReceiptVoucherOpen = Application.OpenForms["frmReceiptVoucher"] as frmReceiptVoucher;
                        if (frmReceiptVoucherOpen == null)
                        {
                            frmReceiptVoucherObj.MdiParent = this.MdiParent;
                            frmReceiptVoucherObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmReceiptVoucherOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmReceiptVoucherOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmReceiptVoucherOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Journal Voucher":
                        frmJournalVoucher frmJournalVoucherObj = new frmJournalVoucher();
                        frmJournalVoucher frmJournalVoucherOpen = Application.OpenForms["frmJournalVoucher"] as frmJournalVoucher;
                        if (frmJournalVoucherOpen == null)
                        {
                            frmJournalVoucherObj.MdiParent = this.MdiParent;
                            frmJournalVoucherObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmJournalVoucherOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmJournalVoucherOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmJournalVoucherOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "PDC Clearance":
                        frmPdcClearance frmPdcClearanceObj = new frmPdcClearance();
                        frmPdcClearance frmPdcClearanceOpen = Application.OpenForms["frmPdcClearance"] as frmPdcClearance;
                        if (frmPdcClearanceOpen == null)
                        {

                            frmPdcClearanceObj.MdiParent = this.MdiParent;
                            frmPdcClearanceObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmPdcClearanceOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmPdcClearanceOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmPdcClearanceOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "PDC Payable":
                        frmPdcPayable frmPDCPayableObj = new frmPdcPayable();
                        frmPdcPayable frmPDCPayableOpen = Application.OpenForms["frmPdcPayable"] as frmPdcPayable;
                        if (frmPDCPayableOpen == null)
                        {

                            frmPDCPayableObj.MdiParent = this.MdiParent;
                            frmPDCPayableObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmPDCPayableOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmPDCPayableOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmPDCPayableOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;

                    case "PDC Receivable":
                        frmPdcReceivable frmPdcReceivableObj = new frmPdcReceivable();
                        frmPdcReceivable frmPdcReceivableOpen = Application.OpenForms["frmPdcReceivable"] as frmPdcReceivable;
                        if (frmPdcReceivableOpen == null)
                        {
                            frmPdcReceivableObj.MdiParent = this.MdiParent;
                            frmPdcReceivableObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmPdcReceivableOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmPdcReceivableOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmPdcReceivableOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Purchase Invoice":
                        frmPurchaseInvoice frmPurchaseInvoiceObj = new frmPurchaseInvoice();
                        frmPurchaseInvoice frmPurchaseInvoiveOpen = Application.OpenForms["frmPurchaseInvoice"] as frmPurchaseInvoice;
                        if (frmPurchaseInvoiveOpen == null)
                        {
                            frmPurchaseInvoiceObj.MdiParent = this.MdiParent;
                            frmPurchaseInvoiceObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmPurchaseInvoiveOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmPurchaseInvoiveOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmPurchaseInvoiveOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Purchase Return":
                        frmPurchaseReturn frmPurchaseReturnObj = new frmPurchaseReturn();
                        frmPurchaseReturn frmPurchaseReturnOpen = Application.OpenForms["frmPurchaseReturn"] as frmPurchaseReturn;
                        if (frmPurchaseReturnOpen == null)
                        {
                            frmPurchaseReturnObj.MdiParent = this.MdiParent;
                            frmPurchaseReturnObj.CallFromLedgerDetails(this, decMasterId, true);
                        }
                        else
                        {
                            frmPurchaseReturnOpen.CallFromLedgerDetails(this, decMasterId, true);
                            if (frmPurchaseReturnOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmPurchaseReturnOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;

                    case "Sales Invoice":
                        if (dgvLedgerDetails.CurrentRow.Cells["dgvtxtpos"].Value.ToString() == "False")
                        {

                            frmSalesInvoice frmSalesInvoiceObj = new frmSalesInvoice();
                            frmSalesInvoice frmSalesInvoiveOpen = Application.OpenForms["frmSalesInvoice"] as frmSalesInvoice;
                            if (frmSalesInvoiveOpen == null)
                            {
                                frmSalesInvoiceObj.MdiParent = this.MdiParent;
                                frmSalesInvoiceObj.CallFromLedgerDetails(this, decMasterId);
                            }
                            else
                            {
                                frmSalesInvoiveOpen.CallFromLedgerDetails(this, decMasterId);
                                if (frmSalesInvoiveOpen.WindowState == FormWindowState.Minimized)
                                {
                                    frmSalesInvoiveOpen.WindowState = FormWindowState.Normal;
                                }
                            }
                        }
                        else
                        {
                            frmPOS frmposObj = new frmPOS();
                            frmPOS frmposOpen = Application.OpenForms["frmPOS"] as frmPOS;
                            if (frmposOpen == null)
                            {
                                frmposObj.MdiParent = this.MdiParent;
                                frmposObj.CallFromLedgerDetails(this, decMasterId);
                            }
                            else
                            {
                                frmposOpen.CallFromLedgerDetails(this, decMasterId);
                                if (frmposOpen.WindowState == FormWindowState.Minimized)
                                {
                                    frmposOpen.WindowState = FormWindowState.Normal;
                                }
                            }
                        }
                        break;

                    case "Sales Return":
                        frmSalesReturn frmSalesReturnObj = new frmSalesReturn();
                        frmSalesReturn frmSalesReturnOpen = Application.OpenForms["frmSalesReturn"] as frmSalesReturn;
                        if (frmSalesReturnOpen == null)
                        {
                            frmSalesReturnObj.MdiParent = this.MdiParent;
                            frmSalesReturnObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmSalesReturnOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmSalesReturnOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmSalesReturnOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;

                    case "Service Voucher":
                        frmServiceVoucher frmServiceVoucherObj = new frmServiceVoucher();
                        frmServiceVoucher frmServiceVoucherOpen = Application.OpenForms["frmServiceVoucher"] as frmServiceVoucher;
                        if (frmServiceVoucherOpen == null)
                        {
                            frmServiceVoucherObj.MdiParent = this.MdiParent;
                            frmServiceVoucherObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmServiceVoucherOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmServiceVoucherOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmServiceVoucherOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Credit Note":
                        frmCreditNote frmCreditNoteobj = new frmCreditNote();
                        frmCreditNote frmCreditNoteOpen = Application.OpenForms["frmCreditNote"] as frmCreditNote;
                        if (frmCreditNoteOpen == null)
                        {
                            frmCreditNoteobj.MdiParent = this.MdiParent;
                            frmCreditNoteobj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmCreditNoteOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmCreditNoteOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmCreditNoteOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Debit Note":
                        frmDebitNote frmDebitNoteObj = new frmDebitNote();
                        frmDebitNote frmDebitNoteOpen = Application.OpenForms["frmDebitNote"] as frmDebitNote;
                        if (frmDebitNoteOpen == null)
                        {
                            frmDebitNoteObj.MdiParent = this.MdiParent;
                            frmDebitNoteObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmDebitNoteOpen.CallFromLedgerDetails(this, decMasterId);
                            if (frmDebitNoteOpen.WindowState == FormWindowState.Minimized)
                            {
                                frmDebitNoteOpen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Advance Payment":
                        frmAdvancePayment frmAdvancePaymentObj = new frmAdvancePayment();
                        frmAdvancePayment frmAdvancePaymentopen = Application.OpenForms["frmAdvancePayment"] as frmAdvancePayment;
                        if (frmAdvancePaymentopen == null)
                        {
                            frmAdvancePaymentObj.MdiParent = this.MdiParent;
                            frmAdvancePaymentObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmAdvancePaymentopen.CallFromLedgerDetails(this, decMasterId);
                            if (frmAdvancePaymentopen.WindowState == FormWindowState.Minimized)
                            {
                                frmAdvancePaymentopen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                    case "Monthly Salary Voucher":
                        frmMonthlySalaryVoucher frmMonthlySalaryVoucherObj = new frmMonthlySalaryVoucher();
                        frmMonthlySalaryVoucher frmMonthlySalaryVoucheropen = Application.OpenForms["frmMonthlySalaryVoucher"] as frmMonthlySalaryVoucher;
                        if (frmMonthlySalaryVoucheropen == null)
                        {
                            frmMonthlySalaryVoucherObj.MdiParent = this.MdiParent;
                            frmMonthlySalaryVoucherObj.CallFromLedgerDetails(this, decMasterId);
                        }
                        else
                        {
                            frmMonthlySalaryVoucheropen.CallFromLedgerDetails(this, decMasterId);
                            if (frmMonthlySalaryVoucheropen.WindowState == FormWindowState.Minimized)
                            {
                                frmMonthlySalaryVoucheropen.WindowState = FormWindowState.Normal;
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmAccountGroupwiseReport
        /// </summary>
        /// <param name="AccountGroupWise"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        public void CallFromAccountGroupWiseReport(frmAccountGroupwiseReport AccountGroupWise, decimal decLedgerId, DateTime fromDate, DateTime toDate)
        {
            try
            {
                frmAccountGroupwiseReportObj = AccountGroupWise;
                frmAccountGroupwiseReportObj.Enabled = false;
                decLedgerIdForGridFill = decLedgerId;
                txtFromDate.Text = fromDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = toDate.ToString("dd-MMM-yyyy");
                base.Show();
                LedgerDetailsView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmAgeingReport
        /// </summary>
        /// <param name="frmAgeing"></param>
        /// <param name="decLedgerDetailId"></param>
        public void callFromAgeing(frmAgeingReport frmAgeing, decimal decLedgerDetailId)
        {
            try
            {
                frmAgeing.Enabled = false;
                base.Show();
                frmAgeingObj = frmAgeing;
                decLedgerIdForGridFill = decLedgerDetailId;
                txtFromDate.Text = PublicVariables._dtFromDate.ToString("dd-MMM-yyyy");
                txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                LedgerDetailsView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Calls corresponding ledger form on Cell doubleclick in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLedgerDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvLedgerDetails.Rows[e.RowIndex].Cells["dgvtxtMasterId"].Value != null && Convert.ToDecimal(dgvLedgerDetails.Rows[e.RowIndex].Cells["dgvtxtMasterId"].Value) != 0)
                    {
                        decimal decMasterId = Convert.ToDecimal(dgvLedgerDetails.Rows[e.RowIndex].Cells["dgvtxtMasterId"].Value);
                        string strTypeofVoucher = Convert.ToString(dgvLedgerDetails.Rows[e.RowIndex].Cells["dgvtxtTypeOfVoucher"].Value);
                        CallToCorrespondingForm(strTypeofVoucher, decMasterId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enabling objects of other forms on form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLedgerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmAccountGroupwiseReportObj != null)
                {
                    frmAccountGroupwiseReportObj.Enabled = true;
                    frmAccountGroupwiseReportObj.Activate();
                }
                if (frmAccountLedgerReportObj != null)
                {
                    frmAccountLedgerReportObj.Enabled = true;
                }
                if (frmAgeingObj != null)
                {
                    frmAgeingObj.Enabled = true;
                    frmAgeingObj.FillGrid();
                    frmAgeingObj.Activate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("LEDDET9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLedgerDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == 27)
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

                MessageBox.Show("LEDDET:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
