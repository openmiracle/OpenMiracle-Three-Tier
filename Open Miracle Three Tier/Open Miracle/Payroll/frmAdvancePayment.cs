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

    public partial class frmAdvancePayment : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decAdvancePaymentEditId = 0;
        string strLedgerId;
        string str = string.Empty;
        decimal decUserId = PublicVariables._decCurrentUserId;
        string strFormName = "frmAdvancePayment";
        static string strPaymentVoucherTypeId = string.Empty;
        decimal decPaymentSuffixPrefixId = 0;
        decimal decAdvancePaymentsId;
        decimal decAdvancePaymentId;
        string strUpdatedVoucherNumber = string.Empty;
        decimal decPaymentVoucherTypeId = 0;
        string strSuffix = string.Empty;
        string strPrefix = string.Empty;
        string strUpdatedInvoiceNumber = string.Empty;
        string strVoucherNo = string.Empty;
        string strInvoiceNo = string.Empty;
        bool isLoad = false;
        string strEmployeeId;
        string strAdvancePayment = "AdvancePayment";
        bool isAutomatic = false;
        int inNarrationCount = 0;
        frmAdvanceRegister frmAdvanceRegisterObj;
        frmLedgerPopup frmLedgerPopupObj;
        frmEmployeePopup frmEmployeePopupObj;
        frmVoucherSearch objVoucherSearch = null;
        frmDayBook frmDayBookObj = null;
        frmLedgerDetails frmLedgerDetailsObj;
        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmAdvancePayment class
        /// </summary>
        public frmAdvancePayment()
        {
            InitializeComponent();
        }
        public void SaveFunction()
        {
            try
            {
                AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                AdvancePaymentInfo infoAdvancepayment = new AdvancePaymentInfo();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                if (CheckAdvanceAmount())
                {
                    if (!BllMonthlySalary.CheckSalaryAlreadyPaidOrNotForAdvancePayment(Convert.ToDecimal(cmbEmployee.SelectedValue.ToString()), dtpSalaryMonth.Value))
                    {
                        if (!bllAdvancePayment.CheckSalaryAlreadyPaidOrNot(Convert.ToDecimal(cmbEmployee.SelectedValue.ToString()), dtpSalaryMonth.Value))
                        {
                            if (isAutomatic == true)
                            {
                                infoAdvancepayment.VoucherNo = strVoucherNo;
                            }
                            else
                            {
                                infoAdvancepayment.VoucherNo = txtAdvanceVoucherNo.Text.Trim();
                            }
                            infoAdvancepayment.EmployeeId = Convert.ToDecimal(cmbEmployee.SelectedValue.ToString());
                            infoAdvancepayment.SalaryMonth = Convert.ToDateTime(dtpSalaryMonth.Text.ToString());
                            infoAdvancepayment.Chequenumber = txtCheckNo.Text.ToString();
                            infoAdvancepayment.Date = Convert.ToDateTime(txtDate.Text.ToString());
                            infoAdvancepayment.Amount = Convert.ToDecimal(txtAmount.Text.ToString());
                            if (isAutomatic)
                            {
                                infoAdvancepayment.InvoiceNo = strInvoiceNo;
                            }
                            else
                            {
                                infoAdvancepayment.InvoiceNo = txtAdvanceVoucherNo.Text.Trim();
                            }
                            infoAdvancepayment.LedgerId = Convert.ToDecimal(cmbCashOrBank.SelectedValue.ToString());
                            infoAdvancepayment.ChequeDate = Convert.ToDateTime(txtChequeDate.Text.ToString());
                            infoAdvancepayment.Narration = txtNarration.Text.Trim();
                            infoAdvancepayment.ExtraDate = Convert.ToDateTime(DateTime.Now.ToString());
                            infoAdvancepayment.Extra1 = string.Empty;
                            infoAdvancepayment.Extra2 = string.Empty;
                            infoAdvancepayment.VoucherTypeId = decPaymentVoucherTypeId;
                            infoAdvancepayment.SuffixPrefixId = decPaymentSuffixPrefixId;
                            infoAdvancepayment.FinancialYearId = PublicVariables._decCurrentFinancialYearId;

                            if (btnAdvancePaymentSave.Text == "Save")
                            {
                                if (decAdvancePaymentsId != -1)
                                {
                                    List<DataTable> ListObj = new List<DataTable>();
                                    ListObj = bllAdvancePayment.AdvancePaymentAddWithIdentity(infoAdvancepayment, isAutomatic);
                                    foreach (DataRow dr in ListObj[0].Rows)
                                    {
                                        decAdvancePaymentId = Convert.ToDecimal(dr.ItemArray[0].ToString());
                                        strUpdatedVoucherNumber = dr.ItemArray[1].ToString();
                                        strUpdatedInvoiceNumber = dr.ItemArray[2].ToString();
                                    }
                                    if (!isAutomatic)
                                    {
                                        strVoucherNo = txtAdvanceVoucherNo.Text.Trim();
                                    }
                                    if (isAutomatic)
                                    {
                                        if (Convert.ToDecimal(strUpdatedVoucherNumber) != Convert.ToDecimal(strVoucherNo))
                                        {
                                            Messages.InformationMessage("Voucher number changed from  " + strInvoiceNo + "  to  " + strUpdatedInvoiceNumber);
                                            strVoucherNo = strUpdatedVoucherNumber.ToString();
                                            strInvoiceNo = strUpdatedInvoiceNumber;
                                        }
                                    }
                                    txtAdvanceVoucherNo.Focus();
                                }
                                LedgerPosting(Convert.ToDecimal(cmbCashOrBank.SelectedValue.ToString()), decAdvancePaymentId);
                                Messages.SavedMessage();
                                Clear();
                            }
                        }
                        else
                        {
                            Messages.InformationMessage(" Advance already paid for this month");
                            dtpSalaryMonth.Focus();
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Cant pay advance for this month,Salary already paid");
                        dtpSalaryMonth.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("AP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form voucher Search 
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallThisFormFromVoucherSearch(frmVoucherSearch frm, decimal decId)
        {

            try
            {
                this.objVoucherSearch = frm;
                decAdvancePaymentEditId = decId;

                fillFunction();


            }
            catch (Exception ex)
            {
                MessageBox.Show("AP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                if (!BllMonthlySalary.CheckSalaryStatusForAdvancePayment(Convert.ToDecimal(cmbEmployee.SelectedValue.ToString()), dtpSalaryMonth.Value))
                {


                    AdvancePaymentBll bllAdvancepayment = new AdvancePaymentBll();
                    AdvancePaymentInfo infoAdvancepayment = new AdvancePaymentInfo();
                    LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();

                    if (bllAdvancepayment.CheckSalaryAlreadyPaidOrNot(Convert.ToDecimal(cmbEmployee.SelectedValue.ToString()), dtpSalaryMonth.Value))
                    {
                        txtAmount.ReadOnly = true;
                    }


                    infoAdvancepayment.AdvancePaymentId = (Convert.ToDecimal(decAdvancePaymentEditId.ToString()));
                    infoAdvancepayment.EmployeeId = Convert.ToDecimal(cmbEmployee.SelectedValue.ToString());
                    infoAdvancepayment.SalaryMonth = Convert.ToDateTime(dtpSalaryMonth.Text.ToString());
                    infoAdvancepayment.Chequenumber = txtCheckNo.Text.ToString();
                    infoAdvancepayment.Date = Convert.ToDateTime(txtDate.Text.ToString());
                    infoAdvancepayment.Amount = Convert.ToDecimal(txtAmount.Text.ToString());
                    if (CheckAdvanceAmount())
                    {
                        if (isAutomatic)
                        {
                            infoAdvancepayment.VoucherNo = strVoucherNo;
                        }
                        else
                        {
                            infoAdvancepayment.VoucherNo = txtAdvanceVoucherNo.Text.Trim();
                        }
                        if (isAutomatic)
                        {
                            infoAdvancepayment.InvoiceNo = strInvoiceNo;
                        }
                        else
                        {
                            infoAdvancepayment.InvoiceNo = txtAdvanceVoucherNo.Text.Trim();
                        }
                        infoAdvancepayment.LedgerId = Convert.ToDecimal(cmbCashOrBank.SelectedValue.ToString());
                        infoAdvancepayment.ChequeDate = Convert.ToDateTime(txtChequeDate.Text.ToString());
                        infoAdvancepayment.Narration = txtNarration.Text.Trim();
                        infoAdvancepayment.ExtraDate = Convert.ToDateTime(DateTime.Now.ToString());
                        infoAdvancepayment.Extra1 = string.Empty;
                        infoAdvancepayment.Extra2 = string.Empty;
                        infoAdvancepayment.VoucherTypeId = decPaymentVoucherTypeId;
                        infoAdvancepayment.SuffixPrefixId = decPaymentSuffixPrefixId;
                        infoAdvancepayment.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                        bllAdvancepayment.AdvancePaymentEdit(infoAdvancepayment);
                        LedgerUpdate();
                        Messages.UpdatedMessage();
                        txtAdvanceVoucherNo.Focus();
                        this.Close();
                    }
                }
                else
                {
                    Messages.ReferenceExistsMessageForUpdate();
                    dtpSalaryMonth.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call save or edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                if (txtAdvanceVoucherNo.Text.Trim() == string.Empty)
                {
                    Messages.InformationMessage("Enter advance voucher no");
                    txtAdvanceVoucherNo.Focus();
                }
                else if (txtDate.Text == string.Empty)
                {
                    Messages.InformationMessage("Select date");
                }
                else if (cmbEmployee.Text == string.Empty)
                {
                    Messages.InformationMessage("Select employee");
                    cmbEmployee.Focus();
                }
                else if (txtAmount.Text.TrimEnd() == string.Empty)
                {
                    Messages.InformationMessage("Select amount");
                    txtAmount.Focus();
                }
                else if (cmbCashOrBank.Text == string.Empty)
                {
                    Messages.InformationMessage("Select Cash/Bank/ac");
                    cmbCashOrBank.Focus();
                }
                else
                {
                    if (btnAdvancePaymentSave.Text == "Save")
                    {
                        if (PublicVariables.isMessageAdd)
                        {
                            if (Messages.SaveMessage())
                            {
                                if (!isAutomatic)
                                {
                                    if (!bllAdvancePayment.AdvancePaymentCheckExistence(txtAdvanceVoucherNo.Text.Trim(), decPaymentVoucherTypeId, 0))
                                    {
                                        SaveFunction();
                                    }
                                    else
                                    {
                                        Messages.InformationMessage("Advance voucher number already exist");
                                        txtAdvanceVoucherNo.Focus();
                                    }
                                }
                                else
                                {
                                    SaveFunction();
                                }
                            }
                        }
                        else
                        {
                            if (!isAutomatic)
                            {
                                if (!bllAdvancePayment.AdvancePaymentCheckExistence(txtAdvanceVoucherNo.Text.Trim(), decPaymentVoucherTypeId, 0))
                                {
                                    SaveFunction();
                                }
                                else
                                {
                                    Messages.InformationMessage("Advance voucher number already exist");
                                    txtAdvanceVoucherNo.Focus();
                                }
                            }
                            else
                            {
                                SaveFunction();
                            }
                        }
                    }

                    else
                    {
                        if (btnAdvancePaymentSave.Text == "Update")
                        {
                            if (PublicVariables.isMessageEdit)
                            {
                                bool EditMessage = Messages.UpdateMessage();
                                if (EditMessage)
                                {
                                    if (!isAutomatic)
                                    {
                                        if (!bllAdvancePayment.AdvancePaymentCheckExistence(txtAdvanceVoucherNo.Text.Trim(), decPaymentVoucherTypeId, decAdvancePaymentEditId))
                                        {
                                            EditFunction();
                                        }
                                        else
                                        {
                                            Messages.InformationMessage("Advance voucher number already exist");
                                            txtAdvanceVoucherNo.Focus();
                                        }
                                    }
                                    else
                                    {
                                        EditFunction();
                                    }
                                }
                            }
                            else
                            {
                                if (!isAutomatic)
                                {
                                    if (!bllAdvancePayment.AdvancePaymentCheckExistence(txtAdvanceVoucherNo.Text.Trim(), decPaymentVoucherTypeId, decAdvancePaymentEditId))
                                    {
                                        EditFunction();
                                    }
                                    else
                                    {
                                        Messages.InformationMessage("Advance voucher number already exist");
                                        txtAdvanceVoucherNo.Focus();
                                    }
                                }
                                else
                                {
                                    EditFunction();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to fill Employee combobox while return from Employee creation when creating new ledger
        /// </summary>
        /// <param name="decemployeeId"></param>
        public void ReturnFromEmployeeCreation(decimal decemployeeId)
        {
            try
            {
                EmployeeComboFill();
                cmbEmployee.SelectedValue = decemployeeId;

                if (decemployeeId.ToString() != "0")
                {
                    cmbEmployee.SelectedValue = decemployeeId;
                }
                else if (strEmployeeId != string.Empty)
                {
                    cmbEmployee.SelectedValue = strEmployeeId;
                }
                else
                {
                    cmbEmployee.SelectedIndex = -1;
                }
                cmbEmployee.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for Ledger Posting
        /// </summary>
        /// <param name="decLedgerPostingId"></param>
        /// <param name="decAdvancePaymentId"></param>
        public void LedgerPosting(decimal decLedgerPostingId, decimal decAdvancePaymentId)
        {
            try
            {
                AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                AdvancePaymentInfo infoAdvancePayment = new AdvancePaymentInfo();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                infoLedgerPosting.VoucherTypeId = decPaymentVoucherTypeId;
                if (isAutomatic)
                {
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoLedgerPosting.VoucherNo = txtAdvanceVoucherNo.Text.Trim();
                }
                infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrBank.SelectedValue.ToString());
                infoLedgerPosting.DetailsId = decAdvancePaymentId;
                if (isAutomatic)
                {
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoLedgerPosting.InvoiceNo = txtAdvanceVoucherNo.Text.Trim();
                }
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.Debit = 0;
                infoLedgerPosting.Credit = Convert.ToDecimal(txtAmount.Text.ToString());

                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;

                infoLedgerPosting.ExtraDate = PublicVariables._dtCurrentDate;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
                infoLedgerPosting.VoucherTypeId = decPaymentVoucherTypeId;
                if (isAutomatic)
                {
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoLedgerPosting.VoucherNo = txtAdvanceVoucherNo.Text.Trim();
                }
                infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                infoLedgerPosting.LedgerId = 3;
                infoLedgerPosting.DetailsId = decAdvancePaymentId;
                if (isAutomatic)
                {
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoLedgerPosting.InvoiceNo = txtAdvanceVoucherNo.Text.Trim();
                }
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.Debit = Convert.ToDecimal(txtAmount.Text.ToString());
                infoLedgerPosting.Credit = 0;

                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;

                infoLedgerPosting.ExtraDate = PublicVariables._dtCurrentDate;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to update LedgerPosting Table
        /// </summary>
        public void LedgerUpdate()
        {
            try
            {
                decimal decLedgerPostingId = 0;
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllLedgerPosting.GetLedgerPostingIds(strVoucherNo, decAdvancePaymentId);
                int ini = 0;
                foreach (DataRow dr in listObj[0].Rows)
                {
                    ini++;
                    if (ini == 2)
                    {
                        decLedgerPostingId = Convert.ToDecimal(dr.ItemArray[0].ToString());
                        infoLedgerPosting.LedgerPostingId = decLedgerPostingId;
                        infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                        if (isAutomatic)
                        {
                            infoLedgerPosting.VoucherNo = strVoucherNo;
                        }
                        else
                        {
                            infoLedgerPosting.VoucherNo = txtAdvanceVoucherNo.Text.Trim();
                        }
                        infoLedgerPosting.Debit = Convert.ToDecimal(txtAmount.Text.ToString());
                        infoLedgerPosting.Credit = 0;
                        infoLedgerPosting.VoucherTypeId = decPaymentVoucherTypeId;
                        infoLedgerPosting.LedgerId = 3;
                        infoLedgerPosting.DetailsId = decAdvancePaymentId;
                        if (isAutomatic)
                        {
                            infoLedgerPosting.InvoiceNo = strInvoiceNo;
                        }
                        else
                        {
                            infoLedgerPosting.InvoiceNo = txtAdvanceVoucherNo.Text.Trim();
                        }

                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;

                        infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                        infoLedgerPosting.Extra1 = string.Empty;
                        infoLedgerPosting.Extra2 = string.Empty;

                        BllLedgerPosting.LedgerPostingEdit(infoLedgerPosting);
                    }
                    if (ini == 1)
                    {
                        decLedgerPostingId = Convert.ToDecimal(dr.ItemArray[0].ToString());
                        infoLedgerPosting.LedgerPostingId = decLedgerPostingId;
                        infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                        if (isAutomatic)
                        {
                            infoLedgerPosting.VoucherNo = strVoucherNo;
                        }
                        else
                        {
                            infoLedgerPosting.VoucherNo = txtAdvanceVoucherNo.Text.Trim();
                        }
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = Convert.ToDecimal(txtAmount.Text.ToString());
                        infoLedgerPosting.VoucherTypeId = decPaymentVoucherTypeId;
                        infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrBank.SelectedValue.ToString());
                        infoLedgerPosting.DetailsId = decAdvancePaymentId;
                        if (isAutomatic)
                        {
                            infoLedgerPosting.InvoiceNo = strInvoiceNo;
                        }
                        else
                        {
                            infoLedgerPosting.InvoiceNo = txtAdvanceVoucherNo.Text.Trim();
                        }

                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;

                        infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                        infoLedgerPosting.Extra1 = string.Empty;
                        infoLedgerPosting.Extra2 = string.Empty;
                        BllLedgerPosting.LedgerPostingEdit(infoLedgerPosting);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill controls for update
        /// </summary>
        public void fillFunction()
        {
            try
            {
                AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                AdvancePaymentInfo infoadvance = new AdvancePaymentInfo();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                infoadvance = bllAdvancePayment.AdvancePaymentView(decAdvancePaymentEditId);
                strVoucherNo = infoadvance.VoucherNo;
                txtAdvanceVoucherNo.Text = infoadvance.InvoiceNo;
                strInvoiceNo = infoadvance.InvoiceNo;
                cmbEmployee.SelectedValue = infoadvance.EmployeeId.ToString();
                dtpSalaryMonth.Value = Convert.ToDateTime(infoadvance.SalaryMonth.ToString());
                txtDate.Text = infoadvance.Date.ToString("dd-MMM-yyyy");
                txtChequeDate.Text = infoadvance.Date.ToString("dd-MMM-yyyy");
                cmbCashOrBank.SelectedValue = infoadvance.LedgerId.ToString();
                txtCheckNo.Text = infoadvance.Chequenumber;
                txtAmount.Text = infoadvance.Amount.ToString();
                txtNarration.Text = infoadvance.Narration;
                btnAdvancePaymentSave.Text = "Update";
                btnAdvancePaymentDelete.Enabled = true;
                decAdvancePaymentsId = decAdvancePaymentId;
                decPaymentVoucherTypeId = infoadvance.VoucherTypeId;
                decPaymentSuffixPrefixId = infoadvance.SuffixPrefixId;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decPaymentVoucherTypeId);
                if (isAutomatic)
                {
                    txtAdvanceVoucherNo.Enabled = false;
                }
                else
                {
                    txtAdvanceVoucherNo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmAdvanceRegister 
        /// </summary>
        /// <param name="decAdvancePaymentId"></param>
        /// <param name="frm"></param>
        public void CallFromAdvanceRegister(decimal decAdvancePaymentId, frmAdvanceRegister frm)
        {
            try
            {
                base.Show();
                decAdvancePaymentEditId = decAdvancePaymentId;
                frmAdvanceRegisterObj = frm;
                frm.Enabled = false;
                fillFunction();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDayBook
        /// </summary>
        /// <param name="frmDayBook"></param>
        /// <param name="decMasterId"></param>
        public void CallFromDayBook(frmDayBook frmDayBook, decimal decMasterId)
        {
            try
            {
                base.Show();
                frmDayBook.Enabled = false;
                decAdvancePaymentEditId = decMasterId;
                frmDayBookObj = frmDayBook;

                fillFunction();
            }
            catch (Exception ex)
            {

                MessageBox.Show("AP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from VoucherType Selection form
        /// </summary>
        /// <param name="strVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal strVoucherTypeId, string strVoucherTypeName)
        {
            try
            {
                strPaymentVoucherTypeId = strVoucherTypeId.ToString();
                decPaymentVoucherTypeId = strVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(Convert.ToDecimal(strVoucherTypeId.ToString()));
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(Convert.ToDecimal(strPaymentVoucherTypeId), dtpDate.Value);
                decPaymentSuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtDate.Focus();
                }
                else
                {
                    txtAdvanceVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Employee combobox
        /// </summary>
        public void EmployeeComboFill()
        {
            try
            {
                AdvancePaymentBll spAdvancePayment = new AdvancePaymentBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = spAdvancePayment.AdvancePaymentEmployeeComboFill();
                cmbEmployee.DataSource = ListObj[0];
                cmbEmployee.ValueMember = "EmployeeId";
                cmbEmployee.DisplayMember = "EmployeeName";
                cmbEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate Voucher number as per settings
        /// </summary>
        public void VoucherNoGeneration()
        {
            TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
            AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
            if (strVoucherNo == string.Empty)
            {
                strVoucherNo = "0";
            }
            strVoucherNo = obj.VoucherNumberAutomaicGeneration(decPaymentVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpSalaryMonth.Value, strAdvancePayment);
            if (Convert.ToDecimal(strVoucherNo) != bllAdvancePayment.AdvancePaymentGetMaxPlusOne(decPaymentVoucherTypeId))
            {
                strVoucherNo = bllAdvancePayment.AdvancePaymentGetMax(decPaymentVoucherTypeId).ToString();
                strVoucherNo = obj.VoucherNumberAutomaicGeneration(decPaymentVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpSalaryMonth.Value, strAdvancePayment);
                if (bllAdvancePayment.AdvancePaymentGetMax(decPaymentVoucherTypeId) == "0")
                {
                    strVoucherNo = "0";
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(decPaymentVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpSalaryMonth.Value, strAdvancePayment);
                }
            }
            if (isAutomatic)
            {
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
               
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decPaymentVoucherTypeId, dtpDate.Value);
                strPrefix = infoSuffixPrefix.Prefix;
                strSuffix = infoSuffixPrefix.Suffix;
                strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                txtAdvanceVoucherNo.Text = strInvoiceNo;
                txtAdvanceVoucherNo.Enabled = false;
            }
        }
        /// <summary>
        /// Function to clear the fields
        /// </summary>
        public void Clear()
        {
            try
            {
                if (isAutomatic)
                {
                    VoucherNoGeneration();
                    txtDate.Focus();
                }
                else
                {
                    txtAdvanceVoucherNo.Text = string.Empty;
                    txtAdvanceVoucherNo.Enabled = true;
                    txtAdvanceVoucherNo.Focus();
                }
                cmbEmployee.SelectedIndex = -1;
                txtCheckNo.Clear();
                txtNarration.Clear();
                dtpDate.Value = PublicVariables._dtCurrentDate;
                dtpSalaryMonth.Value = PublicVariables._dtCurrentDate;
                txtAmount.Clear();
                cmbCashOrBank.SelectedIndex = -1;
                dtpCheckDate.Value = PublicVariables._dtCurrentDate;
                btnAdvancePaymentSave.Text = "Save";
                btnAdvancePaymentDelete.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("AP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to delete
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                MonthlySalaryVoucherBll BllMonthlySalary = new MonthlySalaryVoucherBll();
                if (!BllMonthlySalary.CheckSalaryStatusForAdvancePayment(Convert.ToDecimal(cmbEmployee.SelectedValue.ToString()), dtpSalaryMonth.Value))
                {
                    AdvancePaymentInfo infoAdvancepayment = new AdvancePaymentInfo();
                    AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                    LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                    bllAdvancePayment.AdvancePaymentDelete(Convert.ToDecimal(decAdvancePaymentEditId.ToString()));
                    BllLedgerPosting.LedgerPostDelete(txtAdvanceVoucherNo.Text.Trim(), decAdvancePaymentEditId);
                    Messages.DeletedMessage();
                    txtAdvanceVoucherNo.Focus();
                    Clear();
                    this.Close();
                }
                else
                {
                    Messages.ReferenceExistsMessage();
                    dtpSalaryMonth.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to call delete function
        /// </summary>
        public void Delete()
        {
            try
            {
                if (PublicVariables.isMessageDelete)
                {
                    bool isa = Messages.DeleteMessage();
                    if (isa)
                    {
                        DeleteFunction();
                    }
                }
                else
                {
                    DeleteFunction();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to check wheteher the advance amount given exceeds the limit for  that employee or not
        /// </summary>
        /// <returns></returns>
        public bool CheckAdvanceAmount()
        {
            bool Cancel = true;
            try
            {
                decimal decEmployeeId = 0;
                AdvancePaymentBll bllAdvancePayment = new AdvancePaymentBll();
                decimal decEmployeesalary = 0;
                if (cmbEmployee.SelectedValue != null)
                {
                    decEmployeeId = Convert.ToDecimal(cmbEmployee.SelectedValue.ToString());
                }
                decEmployeesalary = bllAdvancePayment.AdvancePaymentAmountchecking(decEmployeeId);

                decimal txtamountvalue = 0;
                if (txtAmount.Text != string.Empty)
                {
                    txtamountvalue = Convert.ToDecimal(txtAmount.Text.ToString());
                }
                if (txtamountvalue > decEmployeesalary)
                {
                    MessageBox.Show("Advance of this month exceeds than amount set  for  the employee", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                    Cancel = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Cancel;
        }
        /// <summary>
        /// Function to check wheteher cash or bank is selected
        /// </summary>
        public void CheckWhetherBankOrCash()
        {
            try
            {
                //----- To make readonly txtChequeNo and txtChequeDate if selected ledger group is cash-----//
                if (cmbCashOrBank.SelectedValue != null && cmbCashOrBank.SelectedValue.ToString() != string.Empty)
                {
                    decimal decLedger = Convert.ToDecimal(cmbCashOrBank.SelectedValue.ToString());
                    bool isBankAcocunt = false;
                    AccountGroupBll bllAccountGroup = new AccountGroupBll();
                    List<DataTable> ListObj = new List<DataTable>();
                    ListObj = bllAccountGroup.CheckWheatherLedgerUnderCash();
                    //-------- Checking whether the selected legder is under bank----------//
                    foreach (DataRow dr in ListObj[0].Rows)
                    {
                        string str = dr.ItemArray[0].ToString();
                        if (decLedger == Convert.ToDecimal(dr.ItemArray[0].ToString()))
                        {
                            isBankAcocunt = true;
                        }
                    }
                    if (isBankAcocunt)
                    {
                        txtCheckNo.Enabled = false;
                        txtChequeDate.Enabled = false;
                        dtpCheckDate.Enabled = false;
                        txtCheckNo.Clear();
                    }
                    else
                    {
                        txtCheckNo.Enabled = true;
                        txtChequeDate.Enabled = true;
                        dtpCheckDate.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmEmployeePopup form to select and view Employee
        /// </summary>
        /// <param name="frmEmployeePopup"></param>
        /// <param name="decId"></param>
        public void CallEmployeePopUp(frmEmployeePopup frmEmployeePopup, decimal decId) //PopUp
        {
            try
            {
                base.Show();
                this.frmEmployeePopupObj = frmEmployeePopup;
                EmployeeComboFill();
                cmbEmployee.SelectedValue = decId;
                cmbEmployee.Focus();
                frmEmployeePopupObj.Close();
                frmEmployeePopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Cash/Bank combobox while return from frmAccountLedger in case of creating new ledger
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedgerForm(decimal decId)
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                obj.CashOrBankComboFill(cmbCashOrBank, false);
                cmbCashOrBank.SelectedValue = decId.ToString();
                if (decId.ToString() != "0")
                {
                    cmbCashOrBank.SelectedValue = decId;
                }
                else if (strLedgerId != string.Empty)
                {
                    cmbCashOrBank.SelectedValue = strLedgerId;
                }
                else
                {
                    cmbCashOrBank.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbCashOrBank.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmLedgerPopup form to select and view Ledgers
        /// </summary>
        /// <param name="frmLedgerPopup"></param>
        /// <param name="decId"></param>
        public void CallFromLedgerPopup(frmLedgerPopup frmLedgerPopup, decimal decId) //PopUp
        {
            try
            {
                base.Show();
                this.frmLedgerPopupObj = frmLedgerPopup;
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                obj.CashOrBankComboFill(cmbCashOrBank, false);
                cmbCashOrBank.SelectedValue = decId;
                cmbCashOrBank.Focus();
                frmLedgerPopupObj.Close();
                frmLedgerPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmLedgerDetails to view details for updation
        /// </summary>
        /// <param name="frmLedgerDetails"></param>
        /// <param name="decMasterId"></param>
        public void CallFromLedgerDetails(frmLedgerDetails frmLedgerDetails, decimal decMasterId)
        {
            try
            {
                base.Show();
                decAdvancePaymentEditId = decMasterId;
                frmLedgerDetailsObj = frmLedgerDetails;
                frmLedgerDetailsObj.Enabled = false;
                fillFunction();

            }
            catch (Exception ex)
            {
                MessageBox.Show("AP21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvancePayment_Load(object sender, EventArgs e)
        {
            try
            {
                dtpSalaryMonth.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                dtpCheckDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                obj.CashOrBankComboFill(cmbCashOrBank, false);
                EmployeeComboFill();
                btnAdvancePaymentDelete.Enabled = false;
                Clear();
                isLoad = true;
                dtpDate.MinDate = PublicVariables._dtFromDate;
                dtpDate.MaxDate = PublicVariables._dtToDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Clear' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancePaymetClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// on 'btnAdvancePaymentEmployee' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancePaymentEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployee.SelectedValue != null)
                {
                    strEmployeeId = cmbEmployee.SelectedValue.ToString();
                }
                else
                {
                    strEmployeeId = string.Empty;
                }

                frmEmployeeCreation frmEmployee = new frmEmployeeCreation();
                frmEmployee.MdiParent = formMDI.MDIObj;
                frmEmployeeCreation open = Application.OpenForms["frmEmployeeCreation"] as frmEmployeeCreation;
                if (open == null)
                {
                    frmEmployee.WindowState = FormWindowState.Normal;
                    frmEmployee.MdiParent = formMDI.MDIObj;
                    frmEmployee.CallFromAdvancePayment(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromAdvancePayment(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("AP24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancePaymentClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("AP25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enables the object of other forms on Form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvancePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmAdvanceRegisterObj != null)
                {
                    frmAdvanceRegisterObj.Enabled = true;

                    frmAdvanceRegisterObj.Clear();
                }
                if (objVoucherSearch != null)
                {
                    objVoucherSearch.Enabled = true;
                    objVoucherSearch.GridFill();
                    objVoucherSearch.Activate();
                }
                if (frmDayBookObj != null)
                {
                    frmDayBookObj.Enabled = true;
                    frmDayBookObj.dayBookGridFill();
                    frmDayBookObj.Activate();
                    frmDayBookObj = null;
                }
                if (frmLedgerDetailsObj != null)
                {
                    frmLedgerDetailsObj.Enabled = true;
                    frmLedgerDetailsObj.LedgerDetailsView();
                    frmLedgerDetailsObj.Activate();
                    frmLedgerDetailsObj = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Save' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancePaymentSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal decAmount = 0;
                if (Convert.ToDateTime(dtpSalaryMonth.Text) >= Convert.ToDateTime(PublicVariables._dtCurrentDate.ToString("MMM-yyyy")))
                {
                    if (CheckUserPrivilege.PrivilegeCheck(decUserId, strFormName, btnAdvancePaymentSave.Text))
                    {
                        if (txtAmount.Text.Trim() != "")
                        {
                            decAmount = Convert.ToDecimal(txtAmount.Text.Trim());
                        }

                        if (decAmount > 0)
                        {
                            SaveOrEdit();
                        }
                        else
                        {
                            Messages.InformationMessage("Please enter valid amount");
                            txtAmount.Focus();
                        }
                    }
                    else
                    {
                        Messages.NoPrivillageMessage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Delete' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancePaymentDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(decUserId, strFormName, btnAdvancePaymentDelete.Text))
                {
                    Delete();
                }
                else
                {
                    Messages.NoPrivillageMessage();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the Date textbox on dtpDate datetimepicker value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpDate.Value;
                this.txtDate.Text = date.ToString("dd-MMM-yyyy");
                txtDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the ChequeDate textbox on dtpCheckDate datetimepicker value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpCheckDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpCheckDate.Value;
                this.txtChequeDate.Text = date.ToString("dd-MMM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calls the frmAccountLedger form on btnCashOrBank click to create a new ledger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCashOrBank_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCashOrBank.SelectedValue != null)
                {
                    strLedgerId = cmbCashOrBank.SelectedValue.ToString();
                }
                else
                {
                    strLedgerId = string.Empty;
                }

                frmAccountLedger frmaccountledger = new frmAccountLedger();
                frmaccountledger.MdiParent = formMDI.MDIObj;

                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmaccountledger.WindowState = FormWindowState.Normal;
                    frmaccountledger.MdiParent = formMDI.MDIObj;
                    frmaccountledger.CallFromAdvancePayment(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromAdvancePayment(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }

                this.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("AP31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Checks whetehr cash or bank is selected on cmbCashOrBank combobox SelectedValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrBank_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (isLoad)
                {
                    CheckWhetherBankOrCash();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion

        # region Navigation
        /// <summary>
        /// Escape key navigation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvancePayment_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("AP33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                Common.DecimalValidation(sender, e, false);

            }

            catch (Exception ex)
            {
                MessageBox.Show("AP34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Date validation on txtDate Leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objDateValidation = new DateValidation();
                objDateValidation.DateValidationFunction(txtDate);
                if (txtDate.Text == string.Empty)
                {
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpDate.Value = Convert.ToDateTime(txtDate.Text);
                if (btnAdvancePaymentSave.Text != "Update")
                {
                    VoucherNoGeneration();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation on txtChequeDate Leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtChequeDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation obj = new DateValidation();

                bool isInvalid = obj.DateValidationFunction(txtChequeDate);
                if (!isInvalid)
                {
                    txtChequeDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdvanceVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbEmployee.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtDate.Text == string.Empty || txtDate.SelectionStart == 0)
                    {
                        if (!txtAdvanceVoucherNo.ReadOnly)
                        {
                            txtAdvanceVoucherNo.Focus();
                            txtAdvanceVoucherNo.SelectionStart = 0;
                            txtAdvanceVoucherNo.SelectionLength = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Enter key and backspace  navigation and calls frmEmployeePopup to create new Employee 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtAmount.Focus();
                }
                if (cmbEmployee.Text == string.Empty || cmbEmployee.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        txtDate.Focus();
                        txtDate.SelectionStart = 0;
                        txtDate.SelectionLength = 0;
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnAdvancePaymentEmployee_Click(sender, e);
                }

                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                   
                    frmEmployeePopupObj = new frmEmployeePopup();
                    frmEmployeePopupObj.MdiParent = formMDI.MDIObj;
                    if (cmbEmployee.SelectedIndex > -1)
                    {
                        frmEmployeePopupObj.CallFromAdvancePayment(this, Convert.ToDecimal(cmbEmployee.SelectedValue.ToString()));
                    }
                    else
                    {
                        Messages.InformationMessage("Select employee");
                        cmbEmployee.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("AP39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dtpSalaryMonth.Enabled != false)
                    {
                        dtpSalaryMonth.Focus();
                    }
                    else
                    {
                        cmbCashOrBank.Focus();
                    }
                }
                if (txtAmount.Text == string.Empty || txtAmount.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        cmbEmployee.Focus();
                        cmbEmployee.SelectionStart = 0;
                        cmbEmployee.SelectionLength = 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpSalaryMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrBank.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtAmount.Focus();
                    txtAmount.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace  navigation and calls frmLedgerPopup to create new Ledger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrBank_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (txtCheckNo.Enabled == true)
                    {
                        txtCheckNo.Focus();
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    dtpSalaryMonth.Focus();
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbCashOrBank.SelectedIndex != -1)
                    {
                        frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromAdvancePayment(this, Convert.ToDecimal(cmbCashOrBank.SelectedValue.ToString()), "CashOrBank");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or bank account");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP42:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCheckNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtChequeDate.Focus();
                }
                if (txtCheckNo.Text == string.Empty || txtCheckNo.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        cmbCashOrBank.Focus();
                        cmbCashOrBank.SelectionStart = 0;
                        cmbCashOrBank.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtChequeDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNarration.Focus();
                }
                if (txtChequeDate.Text == string.Empty || txtChequeDate.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        txtCheckNo.Focus();
                        txtCheckNo.SelectionStart = 0;
                        txtCheckNo.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtNarration.Text.Trim() == string.Empty || txtNarration.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (txtChequeDate.Enabled == true)
                        {
                            txtChequeDate.Focus();
                            txtChequeDate.SelectionStart = 0;
                            txtChequeDate.SelectionLength = 0;
                        }
                        else
                        {
                            cmbCashOrBank.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    inNarrationCount++;
                    if (inNarrationCount == 2)
                    {
                        inNarrationCount = 0;
                        btnAdvancePaymentSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNarration_Enter(object sender, EventArgs e)
        {
            try
            {
                inNarrationCount = 0;
                txtNarration.Text = txtNarration.Text.Trim();
                if (txtNarration.Text.Trim() == string.Empty)
                {
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                    txtNarration.Focus();
                }
                else
                {
                    txtNarration.SelectionStart = txtNarration.Text.Length;
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdvancePaymentSave_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    txtNarration.Focus();
                    txtNarration.SelectionStart = 0;
                    txtNarration.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Form keydown for quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdvancePayment_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.S && e.Control)
                {
                    
                    btnAdvancePaymentSave_Click(sender, e);
                }
                if (btnAdvancePaymentDelete.Enabled == true)
                {
                    if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                    {
                        btnAdvancePaymentDelete_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{ESC}");
                    if (cmbEmployee.Focused)
                    {
                        btnAdvancePaymentEmployee_Click(sender, e);

                    }
                    if (cmbCashOrBank.Focused)
                    {
                        btnCashOrBank_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
