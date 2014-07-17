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

    public partial class frmMonthlySalaryVoucher : Form
    {
        #region Public Variables
        /// <summary>
        /// Public varaible declaration part
        /// </summary>
        decimal decMonthlyVoucherTypeId = 0;
        decimal decMonthlySuffixPrefixId = 0;
        decimal decMasterId = 0;
        decimal decIsEditModeMasterId = 0;

        string strUpdatedVoucherNo = string.Empty;
        string strUpdatedInvoiceNo = string.Empty;
        string tableName = "SalaryVoucherMaster";
        string strVoucherNo = string.Empty;
        string strInvoiceNo = string.Empty;
        string strPrefix = string.Empty;
        string strSuffix = string.Empty;
        string strEployeeNames = string.Empty;
        string strledgerId;
        string strVoucherNoforEdit = "0";

        int q = 0;
        int inNarrationCount = 0;

        bool isAutomatic = false;
        bool @isEditMode = false;


        frmMonthlySalaryRegister frmMonthlySalaryRegisterObj;
        frmLedgerPopup frmLedgerPopupObj;
        frmVoucherSearch objVoucherSearch = null;
        frmDayBook frmDayBookObj = null;
        frmLedgerDetails frmLedgerDetailsObj;
        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmMonthlySalaryVoucher class
        /// </summary>
        public frmMonthlySalaryVoucher()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        /// <param name="isEditMode"></param>
        public void GridFill(bool @isEditMode)
        {
            try
            {
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll();
                List<DataTable> listObj = new List<DataTable>();
                string strMonth = dtpMonth.Value.ToString("MMMMyyyy");
                string Month = strMonth.Substring(0, 3);
                string strmonthYear = Convert.ToDateTime(strMonth.ToString()).Year.ToString();
                string monthYear = Month + " " + strmonthYear;
                listObj = BllSalaryVoucher.MonthlySalaryVoucherDetailsViewAll(strMonth, Month, monthYear, isEditMode, strVoucherNoforEdit);
                dgvMonthlySalary.DataSource = listObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to call this form from frmVoucherSearch form to view voucher details
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decId"></param>
        public void CallFromVoucherSerach(frmVoucherSearch frm, decimal decId)
        {
            try
            {

                isEditMode = true;
                decIsEditModeMasterId = decId;
                base.Show();
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll();
                     
                SalaryVoucherMasterInfo InfoMaster = new SalaryVoucherMasterInfo();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                btnDelete.Enabled = true;
                btnSave.Text = "Update";
                InfoMaster = BllSalaryVoucher.SalaryVoucherMasterView(decIsEditModeMasterId);
                strVoucherNoforEdit = InfoMaster.VoucherNo;
                strVoucherNo = InfoMaster.VoucherNo;
                txtVoucherNo.Text = InfoMaster.InvoiceNo;
                strInvoiceNo = InfoMaster.InvoiceNo;
                txtVoucherDate.Text = InfoMaster.Date.ToString("dd-MMMM-yyyy");
                string stra = Convert.ToDateTime(InfoMaster.Month.ToString()).ToString("MMM yyyy");
                dtpMonth.Value = Convert.ToDateTime(InfoMaster.Month.ToString("MMM yyyy"));
                txtNarration.Text = InfoMaster.Narration;
                lblTotalAmount.Text = InfoMaster.TotalAmount.ToString();
                decMonthlySuffixPrefixId = InfoMaster.SuffixPrefixId;
                decMonthlyVoucherTypeId = InfoMaster.VoucherTypeId;
                this.objVoucherSearch = frm;
                cmbCashOrBankAcc.SelectedValue = InfoMaster.LedgerId;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decMonthlyVoucherTypeId);
                if (isAutomatic)
                {
                    txtVoucherNo.Enabled = false;
                }
                else
                {
                    txtVoucherNo.Enabled = true;
                }
                dtpMonth.Enabled = false;
                GridFill(isEditMode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV2: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmVoucherTypeSelection form 
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherTypeName"></param>
        public void CallFromVoucherTypeSelection(decimal decVoucherTypeId, string strVoucherTypeName)
        {
            try
            {
                decMonthlyVoucherTypeId = decVoucherTypeId;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decMonthlyVoucherTypeId);
                SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
               // SuffixPrefixSP spSuffisprefix = new SuffixPrefixSP();
                SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();
                infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decMonthlyVoucherTypeId, dtpVoucherDate.Value);
                decMonthlySuffixPrefixId = infoSuffixPrefix.SuffixprefixId;
                this.Text = strVoucherTypeName;
                base.Show();
                if (isAutomatic)
                {
                    txtVoucherDate.Focus();
                }
                else
                {
                    txtVoucherNo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to save ledgerposting table
        /// </summary>
        /// <param name="decid"></param>
        public void LedgerPosting(decimal decid)
        {
            try
            {
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                infoLedgerPosting.Debit = 0;
                infoLedgerPosting.Credit = Convert.ToDecimal(lblTotalAmount.Text.ToString());
                infoLedgerPosting.VoucherTypeId = decMonthlyVoucherTypeId;
                if (isAutomatic)
                {
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoLedgerPosting.VoucherNo = txtVoucherNo.Text;
                }
                infoLedgerPosting.Date = Convert.ToDateTime(dtpVoucherDate.Value.ToString());
                infoLedgerPosting.LedgerId = decid;
                infoLedgerPosting.DetailsId = 0;
                if (isAutomatic)
                {
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text;
                }
                infoLedgerPosting.ChequeNo = string.Empty;
                infoLedgerPosting.ChequeDate = DateTime.Now;
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);

                infoLedgerPosting.Debit = Convert.ToDecimal(lblTotalAmount.Text.ToString());
                infoLedgerPosting.Credit = 0;
                infoLedgerPosting.VoucherTypeId = decMonthlyVoucherTypeId;
                if (isAutomatic)
                {
                    infoLedgerPosting.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoLedgerPosting.VoucherNo = txtVoucherNo.Text;
                }
                infoLedgerPosting.Date = PublicVariables._dtCurrentDate;
                infoLedgerPosting.LedgerId = 4; //ledgerId of salarys
                infoLedgerPosting.DetailsId = 0;
                if (isAutomatic)
                {
                    infoLedgerPosting.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoLedgerPosting.InvoiceNo = txtVoucherNo.Text;
                }
                infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                infoLedgerPosting.Extra1 = string.Empty;
                infoLedgerPosting.Extra2 = string.Empty;
                BllLedgerPosting.LedgerPostingAdd(infoLedgerPosting);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to update ledger posting table
        /// </summary>
        public void LedgerUpdate()
        {
            try
            {
                decimal decLedgerPostingId = 0;
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();
                List<DataTable> listObj = new List<DataTable>();
                listObj = BllLedgerPosting.GetLedgerPostingIds(strVoucherNo, decMonthlyVoucherTypeId);
                int ini = 0;
                foreach (DataRow dr in listObj[0].Rows)
                {
                    ini++;

                    if (ini == 2)
                    {
                        decLedgerPostingId = Convert.ToDecimal(dr.ItemArray[0].ToString());
                        infoLedgerPosting.LedgerPostingId = decLedgerPostingId;
                        infoLedgerPosting.Date = Convert.ToDateTime(dtpVoucherDate.Value.ToString());
                        if (isAutomatic)
                        {
                            infoLedgerPosting.VoucherNo = strVoucherNo;
                        }
                        else
                        {
                            infoLedgerPosting.VoucherNo = txtVoucherNo.Text;
                        }
                        infoLedgerPosting.Debit = Convert.ToDecimal(lblTotalAmount.Text.ToString());
                        infoLedgerPosting.Credit = 0;
                        infoLedgerPosting.VoucherTypeId = decMonthlyVoucherTypeId;
                        infoLedgerPosting.LedgerId = 4;
                        infoLedgerPosting.DetailsId = 0;
                        if (isAutomatic)
                        {
                            infoLedgerPosting.InvoiceNo = strInvoiceNo;
                        }
                        else
                        {
                            infoLedgerPosting.InvoiceNo = txtVoucherNo.Text;
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
                            infoLedgerPosting.VoucherNo = txtVoucherNo.Text;
                        }
                        infoLedgerPosting.Debit = 0;
                        infoLedgerPosting.Credit = Convert.ToDecimal(lblTotalAmount.Text.ToString());
                        infoLedgerPosting.VoucherTypeId = decMonthlyVoucherTypeId;
                        infoLedgerPosting.LedgerId = Convert.ToDecimal(cmbCashOrBankAcc.SelectedValue.ToString());
                        infoLedgerPosting.DetailsId = 0;
                        if (isAutomatic)
                        {
                            infoLedgerPosting.InvoiceNo = strInvoiceNo;
                        }
                        else
                        {
                            infoLedgerPosting.InvoiceNo = txtVoucherNo.Text;
                        }
                        infoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                        infoLedgerPosting.Extra1 = string.Empty;
                        infoLedgerPosting.Extra2 = string.Empty;
                        infoLedgerPosting.ChequeNo = string.Empty;
                        infoLedgerPosting.ChequeDate = DateTime.Now;
                        BllLedgerPosting.LedgerPostingEdit(infoLedgerPosting);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call Save or Edit
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll();
                cmbCashOrBankAcc.DropDownStyle = ComboBoxStyle.DropDownList;
                if (txtVoucherNo.Text == string.Empty)
                {

                    Messages.InformationMessage("Enter voucher number");

                    lblVoucherNoIndicator.Visible = true;
                    txtVoucherNo.Focus();

                }
                else if (dtpVoucherDate.Value.ToString() == string.Empty)
                {
                    Messages.InformationMessage("Select voucher date");
                    lblVoucherDateIndicator.Visible = true;
                    dtpVoucherDate.Focus();
                }
                else if (cmbCashOrBankAcc.SelectedIndex == -1)
                {

                    Messages.InformationMessage("Select cash or bank account");
                    lblCashOrBankIndicator.Visible = true;
                    cmbCashOrBankAcc.Focus();
                }
                else
                {

                    if (isEditMode == false)
                    {
                        if (PublicVariables.isMessageAdd)
                        {
                            if (Messages.SaveMessage())
                            {
                                if (!isAutomatic)
                                {
                                    if (BllSalaryVoucher.MonthlySalaryVoucherCheckExistence(txtVoucherNo.Text.Trim(), decMonthlyVoucherTypeId, 0) == false)
                                    {
                                        SaveFunction();
                                    }
                                    else
                                    {
                                        Messages.InformationMessage("Voucher number already exist");
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
                                if (BllSalaryVoucher.MonthlySalaryVoucherCheckExistence(txtVoucherNo.Text.Trim(), decMonthlyVoucherTypeId, 0) == false)
                                {
                                    SaveFunction();
                                }
                                else
                                {
                                    Messages.InformationMessage("Voucher number already exist");
                                }
                            }
                            else
                            {
                                SaveFunction();
                            }
                        }

                    }
                    //------ Update-------------//
                    else if (isEditMode)
                    {
                        if (PublicVariables.isMessageEdit)
                        {
                            if (Messages.UpdateMessage())
                            {
                                if (!isAutomatic)
                                {
                                    if (BllSalaryVoucher.MonthlySalaryVoucherCheckExistence(txtVoucherNo.Text.Trim(), decMonthlyVoucherTypeId, decIsEditModeMasterId) == false)
                                    {
                                        EditFunction();
                                    }
                                    else
                                    {
                                        Messages.InformationMessage("Voucher number already exist");
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
                                if (BllSalaryVoucher.MonthlySalaryVoucherCheckExistence(txtVoucherNo.Text.Trim(), decMonthlyVoucherTypeId, decIsEditModeMasterId) == false)
                                {
                                    EditFunction();
                                }
                                else
                                {
                                    Messages.InformationMessage("Voucher number already exist");
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
            catch (Exception ex)
            {
                MessageBox.Show("MSV6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function for Save
        /// </summary>
        public void SaveFunction()
        {
            try
            {
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll();
                SalaryVoucherMasterInfo infoMaster = new SalaryVoucherMasterInfo();
               
                SalaryVoucherDetailsInfo infoDetails = new SalaryVoucherDetailsInfo();

                //------------------------------- In the case of multi user check whether salary is paying for the sam person ----------------//
                int inCounts = dgvMonthlySalary.RowCount;
                int incont = 0;
                decimal decVal = 0;
                for (int i = 0; i < inCounts; i++)
                {
                    decVal = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtEmployeeId"].Value.ToString());
                    if (BllSalaryVoucher.CheckWhetherSalaryAlreadyPaid(decVal, dtpMonth.Value) != "0")
                    {
                        strEployeeNames = strEployeeNames + BllSalaryVoucher.CheckWhetherSalaryAlreadyPaid(decVal, dtpMonth.Value) + ",";
                        foreach (char ch in strEployeeNames)
                        {
                            if (ch == ',')
                            {
                                incont++;
                            }
                        }
                        if (incont == 15)
                        {
                            incont = 0;
                            strEployeeNames = strEployeeNames + Environment.NewLine;
                        }

                    }
                }
                if (BllSalaryVoucher.CheckWhetherSalaryAlreadyPaid(decVal, dtpMonth.Value) != "0")
                {

                    Messages.InformationMessage("Salary already paid for - " + " " + strEployeeNames);
                    GridFill(isEditMode);
                }
                infoMaster.LedgerId = Convert.ToDecimal(cmbCashOrBankAcc.SelectedValue.ToString());
                if (isAutomatic)
                {
                    infoMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoMaster.VoucherNo = txtVoucherNo.Text;
                }
                infoMaster.Month = Convert.ToDateTime(dtpMonth.Text.ToString());
                infoMaster.Date = Convert.ToDateTime(dtpVoucherDate.Value.ToString());
                infoMaster.Narration = txtNarration.Text.Trim();
                if (isAutomatic)
                {
                    infoMaster.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoMaster.InvoiceNo = txtVoucherNo.Text;
                }
                if (lblTotalAmount.Text.ToString() != string.Empty)
                {
                    infoMaster.TotalAmount = Math.Round(Convert.ToDecimal(lblTotalAmount.Text.ToString()), PublicVariables._inNoOfDecimalPlaces);
                }
                infoMaster.Extra1 = string.Empty; // Fields not in design//
                infoMaster.Extra2 = string.Empty; // Fields not in design//
                infoMaster.SuffixPrefixId = decMonthlySuffixPrefixId;
                infoMaster.VoucherTypeId = decMonthlyVoucherTypeId;
                infoMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;

                int inCount = dgvMonthlySalary.RowCount;
                int inValue = 0;
                for (int i = 0; i < inCount; i++)
                {
                    if (dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString() == "Paid")
                    {
                        inValue++;
                    }
                }
                if (inValue > 0)
                {
                    //-------------------------In the case of Multi-User Check the VoucherNo. again (Max of VoucherNumber )---------------------//
                    List<DataTable> ListObj = new List<DataTable>();
                    ListObj = BllSalaryVoucher.MonthlySalaryVoucherMasterAddWithIdentity(infoMaster, isAutomatic);
                    foreach (DataRow dr in ListObj[0].Rows)
                    {
                        decMasterId = Convert.ToDecimal(dr.ItemArray[0].ToString());
                        strUpdatedVoucherNo = dr.ItemArray[1].ToString();
                        strUpdatedInvoiceNo = dr.ItemArray[2].ToString();
                    }
                    if (!isAutomatic)
                    {
                        strVoucherNo = txtVoucherNo.Text;
                    }
                    if (isAutomatic)
                    {
                        if (strUpdatedVoucherNo != "" && Convert.ToDecimal(strUpdatedVoucherNo) != Convert.ToDecimal(strVoucherNo))
                        {
                            Messages.InformationMessage("Voucher number changed from  " + strInvoiceNo + "  to  " + strUpdatedInvoiceNo);
                            strVoucherNo = strUpdatedVoucherNo.ToString();
                            strInvoiceNo = strUpdatedInvoiceNo;
          

                        }
                    }
                    LedgerPosting(Convert.ToDecimal(cmbCashOrBankAcc.SelectedValue.ToString()));
                    infoDetails.Extra1 = string.Empty;
                    infoDetails.Extra2 = string.Empty;
                    infoDetails.SalaryVoucherMasterId = decMasterId;

                    int inRowCount = dgvMonthlySalary.RowCount;
                    for (int i = 0; i < inRowCount; i++)
                    {

                        if (dgvMonthlySalary.Rows[i].Cells["txtEmployeeId"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtEmployeeId"].Value.ToString() != string.Empty)
                        {
                            infoDetails.EmployeeId = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtEmployeeId"].Value.ToString());
                        }
                        if (dgvMonthlySalary.Rows[i].Cells["txtBonus"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtBonus"].Value.ToString() != string.Empty)
                        {
                            infoDetails.Bonus = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtBonus"].Value.ToString());
                        }
                        if (dgvMonthlySalary.Rows[i].Cells["txtDeduction"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtDeduction"].Value.ToString() != string.Empty)
                        {
                            infoDetails.Deduction = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtDeduction"].Value.ToString());
                        }
                        if (dgvMonthlySalary.Rows[i].Cells["txtAdvance"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtAdvance"].Value.ToString() != string.Empty)
                        {
                            infoDetails.Advance = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtAdvance"].Value.ToString());
                        }
                        if (dgvMonthlySalary.Rows[i].Cells["txtLop"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtLop"].Value.ToString() != string.Empty)
                        {
                            infoDetails.Lop = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtLop"].Value.ToString());
                        }
                        if (dgvMonthlySalary.Rows[i].Cells["txtSalary"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtSalary"].Value.ToString() != string.Empty)
                        {
                            infoDetails.Salary = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtSalary"].Value.ToString());
                        }
                        if (dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value != null && dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString() != string.Empty)
                        {
                            infoDetails.Status = dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString();
                        }
                        if (dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString() == "Paid" && dgvMonthlySalary.Rows[i].Cells["txtMasterId"].Value.ToString() == "0")
                        {
                            infoDetails.SalaryVoucherMasterId = decMasterId;
                            BllSalaryVoucher.MonthlySalaryVoucherDetailsAdd(infoDetails);
                        }
                    }

                    Messages.SavedMessage();
                    GridFill(isEditMode);
                    Clear();
                }
                else
                {
                    Messages.InformationMessage("Can't save without atleast one employee");
                    strVoucherNo = BllSalaryVoucher.SalaryVoucherMasterGetMax(decMonthlyVoucherTypeId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for edit
        /// </summary>
        public void EditFunction()
        {
            try
            {
               
                SalaryVoucherMasterInfo infoMaster = new SalaryVoucherMasterInfo();
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll();
                SalaryVoucherDetailsInfo infoDetails = new SalaryVoucherDetailsInfo();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();

                infoMaster.SalaryVoucherMasterId = decIsEditModeMasterId;
                infoMaster.Date = Convert.ToDateTime(dtpVoucherDate.Value.ToString());
                infoMaster.LedgerId = Convert.ToDecimal(cmbCashOrBankAcc.SelectedValue.ToString());
                infoMaster.Narration = txtNarration.Text.Trim();
                infoMaster.TotalAmount = Convert.ToDecimal(lblTotalAmount.Text.ToString());
                if (isAutomatic)
                {
                    infoMaster.VoucherNo = strVoucherNo;
                }
                else
                {
                    infoMaster.VoucherNo = txtVoucherNo.Text;
                }

                if (isAutomatic)
                {
                    infoMaster.InvoiceNo = strInvoiceNo;
                }
                else
                {
                    infoMaster.InvoiceNo = txtVoucherNo.Text;
                }
                infoMaster.Extra1 = string.Empty;
                infoMaster.Extra2 = string.Empty;
                infoMaster.SuffixPrefixId = decMonthlySuffixPrefixId;
                infoMaster.VoucherTypeId = decMonthlyVoucherTypeId;
                infoMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                infoMaster.Month = Convert.ToDateTime(dtpMonth.Text.ToString());

                infoDetails.Extra1 = string.Empty;
                infoDetails.Extra2 = string.Empty;

                int inRowCount = dgvMonthlySalary.RowCount;
                for (int i = 0; i < inRowCount; i++)
                {


                    if (dgvMonthlySalary.Rows[i].Cells["txtEmployeeId"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtEmployeeId"].Value.ToString() != string.Empty)
                    {
                        infoDetails.EmployeeId = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtEmployeeId"].Value.ToString());
                    }
                    if (dgvMonthlySalary.Rows[i].Cells["txtBonus"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtBonus"].Value.ToString() != string.Empty)
                    {
                        infoDetails.Bonus = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtBonus"].Value.ToString());
                    }
                    if (dgvMonthlySalary.Rows[i].Cells["txtDeduction"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtDeduction"].Value.ToString() != string.Empty)
                    {
                        infoDetails.Deduction = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtDeduction"].Value.ToString());
                    }
                    if (dgvMonthlySalary.Rows[i].Cells["txtAdvance"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtAdvance"].Value.ToString() != string.Empty)
                    {
                        infoDetails.Advance = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtAdvance"].Value.ToString());
                    }
                    if (dgvMonthlySalary.Rows[i].Cells["txtLop"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtLop"].Value.ToString() != string.Empty)
                    {
                        infoDetails.Lop = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtLop"].Value.ToString());
                    }
                    if (dgvMonthlySalary.Rows[i].Cells["txtSalary"].Value != null && dgvMonthlySalary.Rows[i].Cells["txtSalary"].Value.ToString() != string.Empty)
                    {
                        infoDetails.Salary = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtSalary"].Value.ToString());
                    }
                    if (dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value != null && dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString() != string.Empty)
                    {
                        infoDetails.Status = dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString();
                    }


                    if (dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString() == string.Empty && dgvMonthlySalary.Rows[i].Cells["txtMasterId"].Value.ToString() != "0")
                    {
                        decimal SalaryVoucherDetailsId = Convert.ToDecimal(dgvMonthlySalary.Rows[i].Cells["txtDetailsId"].Value.ToString());
                        BllSalaryVoucher.SalaryVoucherDetailsDelete(SalaryVoucherDetailsId);
                        BllSalaryVoucher.SalaryVoucherMasterEdit(infoMaster);

                        LedgerUpdate();

                    }

                    if (dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString() == "Paid" && dgvMonthlySalary.Rows[i].Cells["txtMasterId"].Value.ToString() == "0")
                    {
                        infoDetails.SalaryVoucherMasterId = decIsEditModeMasterId;
                        BllSalaryVoucher.MonthlySalaryVoucherDetailsAdd(infoDetails);
                        BllSalaryVoucher.SalaryVoucherMasterEdit(infoMaster);

                        LedgerUpdate();
                    }
                    if (dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value.ToString() == string.Empty && dgvMonthlySalary.Rows[i].Cells["txtMasterId"].Value.ToString() == "0")
                    {
                        BllSalaryVoucher.SalaryVoucherMasterEdit(infoMaster);
                        LedgerUpdate();
                    }
                }
                if (BllSalaryVoucher.SalaryVoucherDetailsCount(decIsEditModeMasterId) == 0)
                {
                    BllSalaryVoucher.SalaryVoucherMasterDelete(decIsEditModeMasterId);
                }
                Messages.UpdatedMessage();
                GridFill(isEditMode);

                if (frmMonthlySalaryRegisterObj != null)
                {
                    this.Close();
                }
                if (frmLedgerDetailsObj != null)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                isEditMode = true;
                frmDayBook.Enabled = false;
                decIsEditModeMasterId = decMasterId;
                base.Show();
                btnDelete.Enabled = true;
                btnSave.Text = "Update";
                frmDayBookObj = frmDayBook;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill controls for updation
        /// </summary>
        public void FillFunction()
        {
            try
            {
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll(); 

                SalaryVoucherMasterInfo InfoMaster = new SalaryVoucherMasterInfo();
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();

                InfoMaster = BllSalaryVoucher.SalaryVoucherMasterView(decIsEditModeMasterId);

                strVoucherNoforEdit = InfoMaster.VoucherNo;
                strVoucherNo = InfoMaster.VoucherNo;
                txtVoucherNo.Text = InfoMaster.InvoiceNo;
                strInvoiceNo = InfoMaster.InvoiceNo;
              
                txtVoucherDate.Text = InfoMaster.Date.ToString("dd-MMMM-yyyy");
                string stra = Convert.ToDateTime(InfoMaster.Month.ToString()).ToString("MMM yyyy");
                dtpMonth.Value = Convert.ToDateTime(InfoMaster.Month.ToString("MMM yyyy"));
                txtNarration.Text = InfoMaster.Narration;

                decimal decTotalAmont = Math.Round(Convert.ToDecimal(InfoMaster.TotalAmount.ToString()), PublicVariables._inNoOfDecimalPlaces);
                lblTotalAmount.Text = decTotalAmont.ToString();
                decMonthlySuffixPrefixId = InfoMaster.SuffixPrefixId;
                decMonthlyVoucherTypeId = InfoMaster.VoucherTypeId;

                cmbCashOrBankAcc.SelectedValue = InfoMaster.LedgerId;
                isAutomatic = BllVoucherType.CheckMethodOfVoucherNumbering(decMonthlyVoucherTypeId);
                if (isAutomatic)
                {
                    txtVoucherNo.Enabled = false;
                }
                else
                {
                    txtVoucherNo.Enabled = true;
                }
                dtpMonth.Enabled = false;

                GridFill(isEditMode);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmMonthlySalaryRegister to view details for updation
        /// </summary>
        /// <param name="decMasterId"></param>
        /// <param name="frmMonthlySalaryRegister"></param>
        public void CallFromMonthlySalaryRegister(decimal decMasterId, frmMonthlySalaryRegister frmMonthlySalaryRegister)
        {
            try
            {
                isEditMode = true;
                decIsEditModeMasterId = decMasterId;
                base.Show();
                btnDelete.Enabled = true;
                btnSave.Text = "Update";
                this.frmMonthlySalaryRegisterObj = frmMonthlySalaryRegister;
                FillFunction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmLedgerPopup to view details
        /// </summary>
        /// <param name="frmLedgerPopup"></param>
        /// <param name="decId"></param>
        public void CallFromLedgerPopup(frmLedgerPopup frmLedgerPopup, decimal decId) //PopUp
        {
            try
            {
                base.Show();
                this.frmLedgerPopupObj = frmLedgerPopup;
                TransactionsGeneralFillBll Obj = new TransactionsGeneralFillBll();
                Obj.CashOrBankComboFill(cmbCashOrBankAcc, false);
                cmbCashOrBankAcc.SelectedValue = decId;
                cmbCashOrBankAcc.Focus();
                frmLedgerPopupObj.Close();
                frmLedgerPopupObj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the forms
        /// </summary>
        public void Clear()
        {
            try
            {

                if (isEditMode == false)
                {
                    if (isAutomatic)
                    {
                        voucherNumberGeneration();
                        txtVoucherDate.Focus();
                    }
                    else
                    {
                        txtVoucherNo.Text = string.Empty;
                        txtVoucherNo.ReadOnly = false;
                        txtVoucherNo.Focus();
                    }

                }

                dtpVoucherDate.Value = PublicVariables._dtCurrentDate;
                dtpVoucherDate.MinDate = PublicVariables._dtFromDate;
                dtpVoucherDate.MaxDate = PublicVariables._dtToDate;
                dtpMonth.Value = PublicVariables._dtCurrentDate;
                dtpMonth.MinDate = PublicVariables._dtFromDate;
                dtpMonth.MaxDate = PublicVariables._dtToDate;
                cmbCashOrBankAcc.SelectedIndex = -1;            
                txtNarration.Text = string.Empty;
                lblTotalAmount.Text = string.Empty;
                int inCount = dgvMonthlySalary.RowCount;
                for (int i = 0; i < inCount; i++)
                {
                    dgvMonthlySalary.Rows[i].Cells["cmbStatus"].Value = null;
                }
                dgvMonthlySalary.ClearSelection();
                if (frmMonthlySalaryRegisterObj != null)
                {
                    frmMonthlySalaryRegisterObj.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate the voucher number as per settings
        /// </summary>
        public void voucherNumberGeneration()
        {
            try
            {
                TransactionsGeneralFillBll obj = new TransactionsGeneralFillBll();
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll();
                //-----------------------------------------Voucher number Automatic generation ------------------------------------------------//
                if (strVoucherNo == string.Empty)
                {

                   strVoucherNo = "0"; 
                }
                strVoucherNo = obj.VoucherNumberAutomaicGeneration(decMonthlyVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, tableName);
                if (Convert.ToDecimal(strVoucherNo) != BllSalaryVoucher.SalaryVoucherMasterGetMaxPlusOne(decMonthlyVoucherTypeId))
                {
                    strVoucherNo = BllSalaryVoucher.SalaryVoucherMasterGetMax(decMonthlyVoucherTypeId).ToString();
                    strVoucherNo = obj.VoucherNumberAutomaicGeneration(decMonthlyVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, tableName);
                    if (BllSalaryVoucher.SalaryVoucherMasterGetMax(decMonthlyVoucherTypeId) == "0")
                    {
                        strVoucherNo = "0";
                        strVoucherNo = obj.VoucherNumberAutomaicGeneration(decMonthlyVoucherTypeId, Convert.ToDecimal(strVoucherNo), dtpVoucherDate.Value, tableName);
                    }
                }
                if (isAutomatic)
                {
                    SuffixPrefixSettingsBll BllSuffixPrefixSettings = new SuffixPrefixSettingsBll();
                    SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo();

                    infoSuffixPrefix = BllSuffixPrefixSettings.GetSuffixPrefixDetails(decMonthlyVoucherTypeId, dtpVoucherDate.Value);
                    strPrefix = infoSuffixPrefix.Prefix;
                    strSuffix = infoSuffixPrefix.Suffix;
                    strInvoiceNo = strPrefix + strVoucherNo + strSuffix;
                    txtVoucherNo.Text = strInvoiceNo;
                    txtVoucherNo.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to calculate the totalamount
        /// </summary>
        public void GetTotalAmount()
        {
            try
            {
                decimal decTotal = 0;

                if (dgvMonthlySalary.RowCount > 0)
                {
                    foreach (DataGridViewRow dgvRow in dgvMonthlySalary.Rows)
                    {
                        if (dgvRow.Cells["txtSalary"].Value != null && dgvRow.Cells["txtSalary"].Value.ToString() != string.Empty)
                        {

                            if (dgvRow.Cells["cmbStatus"].Value != null)
                            {
                                if (dgvRow.Cells["cmbStatus"].Value.ToString() == "Paid")
                                {
                                    decTotal += Convert.ToDecimal(dgvRow.Cells["txtSalary"].Value.ToString());
                                }
                            }
                        }

                    }
                }
               
                if (decTotal == 0)
                {
                    lblTotalAmount.Text = "0.00";
                }
                else
                {
                    lblTotalAmount.Text = Math.Round(Convert.ToDecimal(decTotal.ToString()), PublicVariables._inNoOfDecimalPlaces).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function for delete
        /// </summary>
        public void DeleteFunction()
        {
            try
            {
                
                SalaryVoucherBll BllSalaryVoucher = new SalaryVoucherBll();
                LedgerPostingBll BllLedgerPosting = new LedgerPostingBll();
                BllSalaryVoucher.SalaryVoucherMasterDelete(decIsEditModeMasterId);
                BllSalaryVoucher.SalaryVoucherDetailsDeleteUsingMasterId(decIsEditModeMasterId);
                BllLedgerPosting.LedgerPostDelete(txtVoucherNo.Text, decMonthlyVoucherTypeId);

                Messages.DeletedMessage();
                Clear();
                GridFill(isEditMode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill cash/Bank combobox while return from AccountLedger when creating new ledger 
        /// </summary>
        /// <param name="decId"></param>
        public void ReturnFromAccountLedgerForm(decimal decId)
        {
            try
            {
                TransactionsGeneralFillBll Obj = new TransactionsGeneralFillBll();
                Obj.CashOrBankComboFill(cmbCashOrBankAcc, false);
                cmbCashOrBankAcc.SelectedValue = decId.ToString();
                this.Enabled = true;
                cmbCashOrBankAcc.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        /// <summary>
        /// Function to call this form from frmLedgerDetails to view and update
        /// </summary>
        /// <param name="frmLedgerDetails"></param>
        /// <param name="decMasterId"></param>
        public void CallFromLedgerDetails(frmLedgerDetails frmLedgerDetails, decimal decMasterId)
        {
            try
            {
                isEditMode = true;
                decIsEditModeMasterId = decMasterId;
                base.Show();
                btnDelete.Enabled = true;
                btnSave.Text = "Update";
                frmLedgerDetailsObj = frmLedgerDetails;
                frmLedgerDetailsObj.Enabled = false;
                FillFunction();

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Events
       /// <summary>
       /// Load
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void frmMonthlySalaryVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                lblCashOrBankIndicator.Visible = true;
                lblVoucherDateIndicator.Visible = true;
                lblVoucherNoIndicator.Visible = true;
                TransactionsGeneralFillBll Obj = new TransactionsGeneralFillBll();
                Obj.CashOrBankComboFill(cmbCashOrBankAcc, false);
                dtpMonth.Value = PublicVariables._dtCurrentDate;
                dtpMonth.MinDate = PublicVariables._dtFromDate;
                dtpMonth.MaxDate = PublicVariables._dtToDate;
                dtpVoucherDate.Value = PublicVariables._dtCurrentDate;
                dtpVoucherDate.MinDate = PublicVariables._dtFromDate;
                dtpVoucherDate.MaxDate = PublicVariables._dtToDate;             
                dtpVoucherDate.CustomFormat = "dd-MMMM-yyyy";
             
                if (isEditMode == false)
                {
                    Clear();
                }
                GridFill(isEditMode);

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Save'button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnSave.Text))
                {
                    SaveOrEdit();

                }
                else
                {
                    Messages.NoPrivillageMessage();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMonthlySalary_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvMonthlySalary.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("MSV22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Close' button click
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
                MessageBox.Show("MSV23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Commits Edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMonthlySalary_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMonthlySalary.IsCurrentCellDirty)
                {
                    dgvMonthlySalary.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on dtpMonth datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                GridFill(isEditMode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Calculates the TotalAmount on CellValueChanged whether selecting status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMonthlySalary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    GetTotalAmount();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtVoucherDate);
                if (!isInvalid)
                {
                    txtVoucherDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
               
                dtpVoucherDate.Value = Convert.ToDateTime(txtVoucherDate.Text);
                //-------------Re fill ---------------------------//
                if (!isEditMode)
                {

                    voucherNumberGeneration();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills txtVoucherDate textbox on dtpVoucherDate datetimepicker ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpVoucherDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpVoucherDate.Value;
                this.txtVoucherDate.Text = date.ToString("dd-MMM-yyyy");
                txtVoucherDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //To create a new Account Ledger using btnAccountLedgerAdd
        private void btnAccountLedgerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCashOrBankAcc.SelectedValue != null)
                {
                    strledgerId = cmbCashOrBankAcc.SelectedValue.ToString();
                }
                else
                {
                    strledgerId = string.Empty;
                }
                frmAccountLedger frmAccountledger = new frmAccountLedger();
                frmAccountledger.MdiParent = formMDI.MDIObj;

                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frmAccountledger.WindowState = FormWindowState.Normal;
                    frmAccountledger.MdiParent = formMDI.MDIObj;
                    frmAccountledger.CallFromMonthlySalaryVoucher(this);
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    open.BringToFront();
                    open.CallFromMonthlySalaryVoucher(this);
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enables the object of other forms on form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonthlySalaryVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmMonthlySalaryRegisterObj != null)
                {
                    frmMonthlySalaryRegisterObj.Enabled = true;
                    frmMonthlySalaryRegisterObj.BringToFront();
                    frmMonthlySalaryRegisterObj.Clear();
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
                    frmLedgerDetailsObj.Activate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Delete' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckUserPrivilege.PrivilegeCheck(PublicVariables._decCurrentUserId, this.Name, btnDelete.Text))
                {
                    if (PublicVariables.isMessageDelete)
                    {
                        if (Messages.DeleteMessage())
                        {
                            DeleteFunction();
                        }
                    }
                    else
                    {
                        DeleteFunction();
                    }
                }
                else
                {
                    Messages.NoPrivillageMessage();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Quick acess on form keydown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMonthlySalaryVoucher_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    btnSave_Click(sender, e);
                }
                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(sender, e);
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }   
        #endregion

        #region Navigation
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtVoucherDate.Focus();
                    txtVoucherDate.SelectionStart = 0;
                    txtVoucherDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMonthlySalary_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvMonthlySalary.CurrentRow == dgvMonthlySalary.Rows[dgvMonthlySalary.Rows.Count - 1])
                    {
                        if (q == 1)
                        {
                            q = 0;
                            txtNarration.Focus();
                            dgvMonthlySalary.ClearSelection();
                            e.Handled = true;
                        }
                        else
                        {
                            q++;
                        }
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {
                    if (dgvMonthlySalary.Rows.Count > 0)
                    {
                        if (dgvMonthlySalary.CurrentCell == dgvMonthlySalary.Rows[0].Cells["cmbStatus"])
                        {
                            cmbCashOrBankAcc.Focus();
                        }
                        else
                        {
                            if (dgvMonthlySalary.CurrentCell.RowIndex > 0)
                            {
                                dgvMonthlySalary.CurrentCell = dgvMonthlySalary.Rows[dgvMonthlySalary.CurrentCell.RowIndex - 1].Cells["cmbStatus"];
                            }
                            else
                            {
                                cmbCashOrBankAcc.Focus();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherDate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dtpMonth.Enabled != false)
                    {
                        dtpMonth.Focus();
                    }
                    else
                    {
                        cmbCashOrBankAcc.Focus();
                    }
                }
                if (txtVoucherDate.Text == string.Empty || txtVoucherDate.SelectionStart == 0)
                {
                    if (e.KeyCode == Keys.Back)
                    {
                        if (!txtVoucherNo.ReadOnly)
                        {
                            txtVoucherNo.Focus();
                            txtVoucherNo.SelectionStart = 0;
                            txtVoucherNo.SelectionLength = 0;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpMonth_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    cmbCashOrBankAcc.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    txtVoucherDate.Focus();
                    txtVoucherDate.SelectionStart = 0;
                    txtVoucherDate.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV36:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Enter key and Backspace navigation and quick access
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrBankAcc_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvMonthlySalary.RowCount > 0)
                    {
                        dgvMonthlySalary.Focus();
                        dgvMonthlySalary.Rows[0].Cells["cmbStatus"].Selected = true;
                        dgvMonthlySalary.CurrentCell = dgvMonthlySalary.Rows[0].Cells["cmbStatus"];
                    }
                    else
                    {
                        txtNarration.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (dtpMonth.Enabled != false)
                    {
                        dtpMonth.Focus();
                    }
                    else
                    {
                        txtVoucherDate.Focus();
                    }
                }
                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                {
                    if (cmbCashOrBankAcc.SelectedIndex != -1)
                    {
                        frmLedgerPopupObj = new frmLedgerPopup();
                        frmLedgerPopupObj.MdiParent = formMDI.MDIObj;
                        frmLedgerPopupObj.CallFromMonthlySalaryVoucher(this, Convert.ToDecimal(cmbCashOrBankAcc.SelectedValue.ToString()), "CashOrBank");
                    }
                    else
                    {
                        Messages.InformationMessage("Select any cash or bank account ");
                    }
                }
                if (e.KeyCode == Keys.C && Control.ModifierKeys == Keys.Alt)
                {
                    SendKeys.Send("{F10}");
                    btnAccountLedgerAdd_Click(sender, e);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV37:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (e.KeyCode == Keys.Back)
                {

                    if (txtNarration.Text.Trim() == string.Empty || txtNarration.SelectionStart == 0)
                    {
                        if (dgvMonthlySalary.RowCount > 0)
                        {
                            dgvMonthlySalary.Focus();
                            dgvMonthlySalary.Rows[dgvMonthlySalary.RowCount - 1].Cells["cmbStatus"].Selected = true;
                        }
                        else
                        {
                            cmbCashOrBankAcc.Focus();
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        btnSave.Focus();
                    }
                }
                else
                {
                    inNarrationCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV39:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// navigation
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
                    txtNarration.SelectionStart = txtNarration.Text.Trim().Length;
                    txtNarration.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV40:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
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
                MessageBox.Show("MSV41:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
     
        #endregion

    }

}
