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
    public partial class frmAgeingReport : Form
    {

        #region Public variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        public string strVoucherType;
        public string strVoucherNo;
        public decimal decMasterId;
        public decimal decledgerId;
        public decimal decVoucherTypeId;
        int inCurrenRowIndex = 0;
        string fillby = string.Empty;
        string ledgerId = string.Empty;
        bool isFormLoad = false;

        #endregion

        #region Functions
        /// <summary>
        /// Create an Instance of a frmAgeingReport class
        /// </summary>
        public frmAgeingReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set the grid based on the selection of radiobutton ledgerwise and voucherwise
        /// </summary>
        public void GridColumn()
        {
            try
            {
                if (rbtnLedgerWise.Checked)
                {
                    dgvReport.Columns["ledgerId"].Visible = false;
                    dgvReport.Columns["masterId"].Visible = false;
                    dgvReport.Columns["voucherTypeId"].Visible = false;
                    dgvReport.Columns["typeOfVoucher"].Visible = false;
                }
                else if (rbtnVoucher.Checked)
                {
                    dgvReport.Columns["ledgerId"].Visible = false;
                    dgvReport.Columns["masterId"].Visible = false;
                    dgvReport.Columns["voucherTypeId"].Visible = false;
                    dgvReport.Columns["typeOfVoucher"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To fill combo with all ledgers to whome interest enabled is true
        /// </summary>
        public void FillInterestEnabledLedgersCombo()
        {
            try
            {
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                List<DataTable> listCashOrParty = BllPartyBalance.AccountLedgerGetByDebtorAndCreditorWithBalance();
                DataRow dr1 = listCashOrParty[0].NewRow();
                dr1["ledgerName"] = "All";
                dr1["ledgerId"] = 0;
                listCashOrParty[0].Rows.InsertAt(dr1, 0);
                cmbLedger.DataSource = listCashOrParty[0];
                cmbLedger.DisplayMember = "ledgerName";
                cmbLedger.ValueMember = "ledgerId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// To fill grid
        /// </summary>
        public void FillGrid()
        {

            try
            {
                if (!isFormLoad)
                {
                    PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                    List<DataTable> listObj = new List<DataTable>();
                    cmbLedger.Enabled = true;
                    string p = string.Empty;
                    if (cmbLedger.SelectedValue != null)
                        p = cmbLedger.SelectedValue.ToString().ToString();
                    if (cmbLedger.SelectedValue != null)
                    {
                        if (rbtnVoucher.Checked)
                        {

                            fillby = "Voucher";
                        }
                        else if (rbtnLedgerWise.Checked)
                        {
                            fillby = "Ledger";
                        }
                        if (rbtnReceivable.Checked && rbtnLedgerWise.Checked)
                            listObj = BllPartyBalance.AgeingReportLedgerReceivable(DateTime.Parse(dtpAgeingDate.Text), Convert.ToDecimal(cmbLedger.SelectedValue.ToString()));
                        else if (rbtnReceivable.Checked && rbtnVoucher.Checked)
                            listObj = BllPartyBalance.AgeingReportVoucherReceivable(DateTime.Parse(dtpAgeingDate.Text), Convert.ToDecimal(cmbLedger.SelectedValue.ToString()));
                        else if (rbtnPayable.Checked && rbtnLedgerWise.Checked)
                            listObj = BllPartyBalance.AgeingReportLedgerPayable(DateTime.Parse(dtpAgeingDate.Text), Convert.ToDecimal(cmbLedger.SelectedValue.ToString()));
                        else if (rbtnPayable.Checked && rbtnVoucher.Checked)
                            listObj = BllPartyBalance.AgeingReportVoucherPayable(DateTime.Parse(dtpAgeingDate.Text), Convert.ToDecimal(cmbLedger.SelectedValue.ToString()));
                    }
                    decimal dcTotOne = 0m;
                    decimal dcTotTwo = 0m;
                    decimal dcTotThree = 0m;
                    decimal dcTotFour = 0m;
                    if (listObj[0].Rows.Count > 0)
                    {
                        dcTotOne = decimal.Parse(listObj[0].Compute("Sum([1 to 30])", string.Empty).ToString());
                        dcTotTwo = decimal.Parse(listObj[0].Compute("Sum([31 to 60])", string.Empty).ToString());
                        dcTotThree = decimal.Parse(listObj[0].Compute("Sum([61 to 90])", string.Empty).ToString());
                        dcTotFour = decimal.Parse(listObj[0].Compute("Sum([90 above])", string.Empty).ToString());
                    }
                    listObj[0].Rows.Add();
                    listObj[0].Rows[listObj[0].Rows.Count - 1]["Account Ledger"] = "Total :";
                    listObj[0].Rows[listObj[0].Rows.Count - 1]["1 to 30"] = dcTotOne;
                    listObj[0].Rows[listObj[0].Rows.Count - 1]["31 to 60"] = dcTotTwo;
                    listObj[0].Rows[listObj[0].Rows.Count - 1]["61 to 90"] = dcTotThree;
                    listObj[0].Rows[listObj[0].Rows.Count - 1]["90 above"] = dcTotFour;
                    dgvReport.DataSource = listObj[0];
                    if (dgvReport.Columns.Count > 0)
                    {
                        if (rbtnLedgerWise.Checked == true)
                        {
                            dgvReport.Columns["ledgerId"].Visible = false;
                            dgvReport.Columns["masterId"].Visible = false;
                            dgvReport.Columns["voucherTypeId"].Visible = false;
                            dgvReport.Columns["VoucherType"].Visible = false;
                            dgvReport.Columns["VoucherNo"].Visible = false;
                            dgvReport.Columns["Date"].Visible = true;
                            dgvReport.Columns["Account Ledger"].Visible = true;
                        }
                        else
                        {
                            dgvReport.Columns["masterId"].Visible = false;
                            dgvReport.Columns["ledgerId"].Visible = false;
                            dgvReport.Columns["voucherTypeId"].Visible = false;
                            dgvReport.Columns["VoucherType"].Visible = true;
                            dgvReport.Columns["VoucherNo"].Visible = true;
                            dgvReport.Columns["Date"].Visible = true;
                            dgvReport.Columns["Account Ledger"].Visible = false;
                        }
                    }
                    dgvReport.Columns["1 to 30"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvReport.Columns["31 to 60"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvReport.Columns["61 to 90"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvReport.Columns["90 above"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    lblTotOne.Text = "1 to 30: " + dcTotOne.ToString();
                    lblTotTwo.Text = "31 to 60: " + dcTotTwo.ToString();
                    lblTotThree.Text = "61 to 90: " + dcTotThree.ToString();
                    lblTotFour.Text = "90 above: " + dcTotFour.ToString();
                    ledgerId = string.Empty;
                    if (inCurrenRowIndex >= 0 && dgvReport.Rows.Count > 0 && inCurrenRowIndex < dgvReport.Rows.Count)
                    {
                        dgvReport.CurrentCell = dgvReport.Rows[inCurrenRowIndex].Cells["1 to 30"];
                        dgvReport.CurrentCell.Selected = true;
                    }
                    inCurrenRowIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Creation of Ageing table
        /// </summary>
        /// <returns></returns>
        public DataTable dtblageing()
        {
            DataTable dtLocalC = new DataTable();
            try
            {

                dtLocalC.Columns.Add("Account Ledger");
                dtLocalC.Columns.Add("Date");
                dtLocalC.Columns.Add("1 to 30");
                dtLocalC.Columns.Add("31 to 60");
                dtLocalC.Columns.Add("61 to 90");
                dtLocalC.Columns.Add("90 above");
                dtLocalC.Columns.Add("SlNo");
                DataRow drLocal = null;
                foreach (DataGridViewRow dr in dgvReport.Rows)
                {
                    drLocal = dtLocalC.NewRow();
                    drLocal["Account Ledger"] = dr.Cells["Account Ledger"].Value;
                    drLocal["Date"] = dr.Cells["Date"].Value;
                    drLocal["1 to 30"] = dr.Cells["1 to 30"].Value;
                    drLocal["31 to 60"] = dr.Cells["31 to 60"].Value;
                    drLocal["61 to 90"] = dr.Cells["61 to 90"].Value;
                    drLocal["90 above"] = dr.Cells["90 above"].Value;
                    drLocal["SlNo"] = dr.Cells["Sl No"].Value;
                    dtLocalC.Rows.Add(drLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtLocalC;
        }
        /// <summary>
        /// Creation of Ageingtable1
        /// </summary>
        /// <returns></returns>
        public DataTable dtblageing1()
        {
            DataTable dtLocalC = new DataTable();
            try
            {
                dtLocalC.Columns.Add("1 to 30");
                dtLocalC.Columns.Add("31 to 60");
                dtLocalC.Columns.Add("61 to 90");
                dtLocalC.Columns.Add("90 above");
                dtLocalC.Columns.Add("Date");
                dtLocalC.Columns.Add("Voucher No");
                dtLocalC.Columns.Add("Voucher Type");
                dtLocalC.Columns.Add("SlNo");
                DataRow drLocal = null;
                foreach (DataGridViewRow dr in dgvReport.Rows)
                {
                    drLocal = dtLocalC.NewRow();
                    drLocal["Voucher Type"] = dr.Cells["VoucherType"].Value;
                    drLocal["Voucher No"] = dr.Cells["VoucherNo"].Value;
                    drLocal["Date"] = dr.Cells["Date"].Value;
                    drLocal["1 to 30"] = dr.Cells["1 to 30"].Value;
                    drLocal["31 to 60"] = dr.Cells["31 to 60"].Value;
                    drLocal["61 to 90"] = dr.Cells["61 to 90"].Value;
                    drLocal["90 above"] = dr.Cells["90 above"].Value;
                    drLocal["SlNo"] = dr.Cells["Sl No"].Value;
                    dtLocalC.Rows.Add(drLocal);
                    strVoucherType = dr.Cells["VoucherType"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return dtLocalC;
        }
        /// <summary>
        /// Function to get dataset for printing the report
        /// </summary>
        /// <returns></returns>
        public DataSet getdataset()
        {
            DataSet dsFundFlow = new DataSet();
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                DataTable dtblFund = dtblageing();
               List< DataTable >listcompany = new List<DataTable>();
               listcompany = bllFinancialStatement.FundFlowReportPrintCompany(1);//(PublicVariables._decCurrentCompanyId);
                dsFundFlow.Tables.Add(dtblFund);
                dsFundFlow.Tables.Add(listcompany[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsFundFlow;
        }
        /// <summary>
        /// Function to get dataset for printing the report
        /// </summary>
        /// <returns></returns>
        public DataSet getdataset1()
        {
            DataSet dsFundFlow = new DataSet();
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();

                DataTable dtblFund = dtblageing1();
                List<DataTable> listCompany = new List<DataTable>();
                listCompany = bllFinancialStatement.FundFlowReportPrintCompany(1);//(PublicVariables._decCurrentCompanyId);
                dsFundFlow.Tables.Add(dtblFund);
                dsFundFlow.Tables.Add(listCompany[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return dsFundFlow;
        }
        /// <summary>
        /// Function to print the report
        /// </summary>
        /// <param name="toDate"></param>
        public void Print(DateTime toDate)
        {
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                DataSet destBalance = getdataset();
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.AgeingReportPrint(destBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to print the report
        /// </summary>
        /// <param name="toDate"></param>
        public void Print1(DateTime toDate)
        {
            try
            {
                FinancialStatementBll bllFinancialStatement = new FinancialStatementBll();
                DataSet destBalance = getdataset1();
                frmReport frmReport = new frmReport();
                frmReport.MdiParent = formMDI.MDIObj;
                frmReport.AgeingReportPrint1(destBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for initial date settings
        /// </summary>
        public void InitialDateSettings()
        {
            try
            {
                dtpAgeingDate.Value = PublicVariables._dtToDate;
                dtpAgeingDate.MinDate = PublicVariables._dtFromDate;
                dtpAgeingDate.MaxDate = PublicVariables._dtToDate;

                DateValidation objValidation = new DateValidation();
                objValidation.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("AR10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for making grid not sortable
        /// </summary>
        public void NotSortable()
        {
            try
            {
                dgvReport.Columns["1 to 30"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["31 to 60"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["61 to 90"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["90 above"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["Date"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["Voucher Type"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["Voucher No"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["Account Ledger"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns["Narration"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvReport.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region events

        /// <summary>
        /// On load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgeingReport_Load(object sender, EventArgs e)
        {
            try
            {

                InitialDateSettings();
                FillInterestEnabledLedgersCombo();
                rbtnPayable.Checked = true;
                rbtnVoucher.Checked = true;
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                isFormLoad = true;
                InitialDateSettings();
                rbtnReceivable.Checked = true;
                rbtnLedgerWise.Checked = true;
                isFormLoad = false;
                FillGrid();
                FillInterestEnabledLedgersCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On checked changed of rbtnAll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnVoucher.Checked)
                    fillby = "Voucher";
                else
                {
                    fillby = "Ledger";
                }
                RadioButton rbtn = (RadioButton)sender;
                if (rbtn.Checked)
                    FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (dgvReport.Rows.Count - 1 <= 0)
                {
                    MessageBox.Show("No data found", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rbtnLedgerWise.Checked)
                    {
                        Print(PublicVariables._dtToDate);
                    }
                    else if (rbtnVoucher.Checked)
                    {
                        Print1(PublicVariables._dtToDate);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// When doubleclicking on the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal decVouchertypeId = 0;
            string strVoucherNo = string.Empty;
            try
            {
                if (dgvReport.CurrentRow.Index == e.RowIndex)
                {
                    if ((dgvReport.CurrentRow.Cells["voucherTypeId"].Value != null && dgvReport.CurrentRow.Cells["voucherTypeId"].Value.ToString() != string.Empty))
                    {
                        int inI = dgvReport.CurrentCell.RowIndex;
                        foreach (DataGridViewRow dgv in dgvReport.Rows)
                        {
                            if (dgv.Cells["VoucherNo"].Value != null && dgv.Cells["VoucherNo"].Value.ToString() != string.Empty &&
                                   dgv.Cells["voucherTypeId"].Value != null && dgv.Cells["voucherTypeId"].Value.ToString() != string.Empty)
                            {
                                strVoucherType = dgv.Cells["VoucherType"].Value.ToString();
                                decVouchertypeId = Convert.ToDecimal(dgv.Cells["voucherTypeId"].Value.ToString());
                                strVoucherNo = dgv.Cells["VoucherNo"].Value.ToString();
                            }
                            else
                            {
                                if (dgv.Cells["ledgerId"].Value.ToString() != string.Empty)
                                {
                                    decledgerId = decimal.Parse(dgv.Cells["ledgerId"].Value.ToString());
                                    strVoucherType = dgv.Cells["Account Ledger"].Value.ToString();
                                    frmLedgerDetails frmLedger = new frmLedgerDetails();
                                    frmLedger = Application.OpenForms["frmLedgerDetails"] as frmLedgerDetails;
                                    if (frmLedger == null)
                                    {
                                        frmLedger = new frmLedgerDetails();
                                        frmLedger.MdiParent = formMDI.MDIObj;
                                        frmLedger.callFromAgeing(this, decledgerId);
                                        this.Enabled = false;
                                    }
                                }


                            }
                            if (dgv.Index == inI)
                            {
                                break;
                            }
                        }
                        if (strVoucherType == "Payment Voucher")
                        {
                            PaymentVoucherBll BllPaymentVoucher = new PaymentVoucherBll();
                            decMasterId = BllPaymentVoucher.paymentMasterIdView(decVouchertypeId, strVoucherNo);
                            frmPaymentVoucher frmPaymentVoucher = new frmPaymentVoucher();
                            frmPaymentVoucher = Application.OpenForms["frmPaymentVoucher"] as frmPaymentVoucher;
                            if (frmPaymentVoucher == null)
                            {
                                frmPaymentVoucher = new frmPaymentVoucher();
                                frmPaymentVoucher.MdiParent = formMDI.MDIObj;
                                frmPaymentVoucher.callFromAgeing(this, decMasterId);
                                this.Enabled = false;
                            }
                        }
                        else if (strVoucherType == "Receipt Voucher")
                        {
                            RecieptVoucherBll bllRecieptVoucher = new RecieptVoucherBll();
                            //ReceiptMasterSP spRecieptMaster = new ReceiptMasterSP();
                            decMasterId = bllRecieptVoucher.ReceiptMasterIdView(decVouchertypeId, strVoucherNo);
                            frmReceiptVoucher frmReceiptVoucher = new frmReceiptVoucher();
                            frmReceiptVoucher = Application.OpenForms["frmReceiptVoucher"] as frmReceiptVoucher;
                            if (frmReceiptVoucher == null)
                            {
                                frmReceiptVoucher = new frmReceiptVoucher();
                                frmReceiptVoucher.MdiParent = formMDI.MDIObj;
                                frmReceiptVoucher.callFromAgeing(this, decMasterId);
                                this.Enabled = false;
                            }
                        }
                        else if (strVoucherType == "Journal Voucher")
                        {
                            JournalVoucherBll bllJournalMaster = new JournalVoucherBll();
                            decMasterId = bllJournalMaster.JournalMasterIdView(decVouchertypeId, strVoucherNo);
                            frmJournalVoucher frmJournalVoucher = new frmJournalVoucher();
                            frmJournalVoucher = Application.OpenForms["frmJournalVoucher"] as frmJournalVoucher;
                            if (frmJournalVoucher == null)
                            {
                                frmJournalVoucher = new frmJournalVoucher();
                                frmJournalVoucher.MdiParent = formMDI.MDIObj;
                                frmJournalVoucher.callFromAgeing(this, decMasterId);
                                this.Enabled = false;
                            }
                        }
                        else if (strVoucherType == "PDC Receivable")
                        {
                            PDCRecivebleBll BllPDCReciveble = new PDCRecivebleBll();
                            decMasterId = BllPDCReciveble.PdcReceivableMasterIdView(decVouchertypeId, strVoucherNo);
                            frmPdcReceivable frmPdcReceivable = new frmPdcReceivable();
                            frmPdcReceivable = Application.OpenForms["frmPdcReceivable"] as frmPdcReceivable;
                            if (frmPdcReceivable == null)
                            {
                                frmPdcReceivable = new frmPdcReceivable();
                                frmPdcReceivable.MdiParent = formMDI.MDIObj;
                                frmPdcReceivable.callFromAgeing(this, decMasterId);
                                this.Enabled = false;
                            }
                        }
                        else if (strVoucherType == "PDC Payable")
                        {
                            PDCPayableBll BllPDCPayable = new PDCPayableBll();
                            decMasterId = BllPDCPayable.PdcPayableMasterIdView(decVouchertypeId, strVoucherNo);
                            frmPdcPayable frmPdcPayable = new frmPdcPayable();
                            frmPdcPayable = Application.OpenForms["frmPdcPayable"] as frmPdcPayable;
                            if (frmPdcPayable == null)
                            {
                                frmPdcPayable = new frmPdcPayable();
                                frmPdcPayable.MdiParent = formMDI.MDIObj;
                                frmPdcPayable.callFromAgeing(this, decMasterId);
                                this.Enabled = false;
                            }
                        }
                        else if (strVoucherType == "Sales Invoice")
                        {
                            //SalesMasterSP spMaster = new SalesMasterSP();
                            SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                            decMasterId = BllSalesInvoice.SalesMasterIdViewByvoucherNoAndVoucherType(decVouchertypeId, strVoucherNo);
                            //SalesMasterSP spSalesMaster = new SalesMasterSP();
                            bool blPOS = BllSalesInvoice.DayBookSalesInvoiceOrPOS(decMasterId, decVouchertypeId);
                            frmSalesInvoice frmSalesInvoice = new frmSalesInvoice();
                            frmPOS frmPOS = new frmPOS();
                            if (blPOS == true)
                            {
                                frmPOS = Application.OpenForms["frmPOS"] as frmPOS;
                                if (frmPOS == null)
                                {
                                    frmPOS = new frmPOS();
                                    frmPOS.MdiParent = formMDI.MDIObj;
                                    frmPOS.callFromAgeing(this, decMasterId);
                                    this.Enabled = false;
                                }
                            }
                            else
                            {
                                frmSalesInvoice = Application.OpenForms["frmSalesInvoice"] as frmSalesInvoice;
                                if (frmSalesInvoice == null)
                                {
                                    frmSalesInvoice = new frmSalesInvoice();
                                    frmSalesInvoice.MdiParent = formMDI.MDIObj;
                                    frmSalesInvoice.callFromAgeing(this, decMasterId);
                                    this.Enabled = false;
                                }
                            }
                        }
                        else if (strVoucherType == "Purchase Invoice")
                        {
                            PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
                            decMasterId = BllPurchaseInvoice.PurchaseMasterIdViewByvoucherNoAndVoucherType(decVouchertypeId, strVoucherNo);
                            frmPurchaseInvoice objpurchase = new frmPurchaseInvoice();
                            objpurchase.WindowState = FormWindowState.Normal;
                            objpurchase.MdiParent = formMDI.MDIObj;
                            objpurchase.callFromAgeing(this, decMasterId);
                            this.Enabled = false;
                        }
                        else if (strVoucherType == "Credit Note")
                        {
                            CreditNoteBll BllCreditNoteMaster = new CreditNoteBll();
                            decMasterId = BllCreditNoteMaster.CreditNoteMasterIdView(decVouchertypeId, strVoucherNo);
                            frmCreditNote objpurchase = new frmCreditNote();
                            objpurchase.WindowState = FormWindowState.Normal;
                            objpurchase.MdiParent = formMDI.MDIObj;
                            objpurchase.callFromAgeing(this, decMasterId);
                            this.Enabled = false;
                        }
                        else if (strVoucherType == "Debit Note")
                        {
                            //DebitNoteMasterSP spDebitNote = new DebitNoteMasterSP();
                            DebitNoteBll bllDebitNote = new DebitNoteBll();
                            decMasterId = bllDebitNote.DebitNoteMasterIdView(decVouchertypeId, strVoucherNo);
                            frmDebitNote objpurchase = new frmDebitNote();
                            objpurchase.WindowState = FormWindowState.Normal;
                            objpurchase.MdiParent = formMDI.MDIObj;
                            objpurchase.callFromAgeing(this, decMasterId);
                            this.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On leave from dtpAgeingDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpAgeingDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objValidation = new DateValidation();
                objValidation.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                DateTime dt;
                DateTime.TryParse(txtToDate.Text, out dt);
                dtpAgeingDate.Value = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On closeup of dtpAgeingDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpAgeingDate_CloseUp(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = dtpAgeingDate.Value.ToString("dd-MMM-yyyy");
                txtToDate.SelectAll();
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DateValidation DateValidationObj = new DateValidation();
                DateValidationObj.DateValidationFunction(txtToDate);
                if (txtToDate.Text == string.Empty)
                {
                    txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ex.ExportExcel(dgvReport, "Ageing Report", 0, 0, "Excel", null, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigations
        /// <summary>
        /// Esc for formclose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAgeingReport_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("AR21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Enterkey navigation of txtToDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbLedger.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enterkey and backspace navigation of cmbLedger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLedger_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rbtnPayable.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbLedger.Enabled)
                    {
                        txtToDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation of rbtnPayable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnPayable_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rbtnReceivable.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation of rbtnReceivable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnReceivable_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    rbtnVoucher.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation of rbtnLedgerWise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnLedgerWise_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void dtpAgeingDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToDate.Text = PublicVariables._dtToDate.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
