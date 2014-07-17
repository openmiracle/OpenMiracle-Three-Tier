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

    public partial class frmLedgerPopup : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmMonthlySalaryRegister frmMonthlySalaryRegisterObj;
        frmContraVoucher frmContraVoucherObj;
        frmAdvancePayment frmAdvancePaymentObj;
        frmMonthlySalaryVoucher frmMonthlySalaryVoucherObj;
        frmDailySalaryVoucher frmDailySalaryVoucherObj;
        frmDeliveryNote frmDeliveryNoteObj;
        frmPaymentVoucher frmPaymentVoucherObj;
        frmReceiptVoucher frmReceiptVoucherObj;
        frmPurchaseOrder frmPurchaseOrderObj;
        frmServiceVoucher frmServiceVoucherObj;
        string strComboTypes = string.Empty;
        frmJournalVoucher frmJournalVoucherObj;
        frmDebitNote frmDebitNoteObj = null;
        frmCreditNote frmCreditNoteObj = null;
        frmPdcPayable frmPdcPayableObj = null;
        frmPdcReceivable frmpdReceivableObj = null;
        frmSalesQuotation frmsalesQuotationObj = null;
        frmSalesOrder frmSalesOrderObj = null;
        frmSalesReturn frmSalesReturnObj = null;
        frmPurchaseReturn frmPurchaseReturnObj = null;
        frmPurchaseInvoice frmPurchaseInvoiceObj = null;
        frmRejectionOut frmRejectionOutObj = null;
        frmRejectionIn frmRejectionInObj;
        frmMaterialReceipt frmMaterialReceiptObj = null;
        frmPartyAddressBook frmPartyAddressBookObj = null;
        frmSalesInvoice frmSalesInvoiceObj = null;
        frmPOS frmPOSObj = null;

        #endregion

        #region Functions
        /// <summary>
        /// Creates an instance of frmLedgerPopup class
        /// </summary>
        public frmLedgerPopup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        /// <param name="decId1"></param>
        /// <param name="decId2"></param>
        public void GridFill(decimal decId1, decimal decId2)
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountledger = new AccountLedgerBll();
                if (cmbAccountGroup.Text == "ALL")
                {
                    cmbAccountGroup.Text = "ALL";
                }
                ListObj = bllAccountledger.LedgerPopupSearch(txtLedgerName.Text, cmbAccountGroup.Text, decId1, decId2);
                dgvLedgerPopup.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP1:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview for service account
        /// </summary>
        public void GridFillForServiceAccounts()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                AccountLedgerBll bllAccountledger = new AccountLedgerBll();
                if (cmbAccountGroup.Text == "ALL")
                {
                    cmbAccountGroup.Text = "ALL";
                }
                ListObj = bllAccountledger.LedgerPopupSearchForServiceAccountsUnderIncome();
                dgvLedgerPopup.DataSource = ListObj[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP2:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill AccountGroup combobox
        /// </summary>
        public void AccountGroupComboFill()
        {
            try
            {
                AccountGroupBll bllAccountGroup = new AccountGroupBll();
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = bllAccountGroup.AccountGroupViewAllComboFill();
                DataRow dr = ListObj[0].NewRow();
                dr[1] = "All";
                ListObj[0].Rows.InsertAt(dr, 0);
                cmbAccountGroup.DataSource = ListObj[0];
                cmbAccountGroup.ValueMember = "accountGroupId";
                cmbAccountGroup.DisplayMember = "accountGroupName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP3:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtLedgerName.Clear();
                cmbAccountGroup.SelectedIndex = 0;
                dgvLedgerPopup.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP4:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmMonthlySalaryRegister
        /// </summary>
        /// <param name="frmMonthlySalaryReg"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromMonthlySalaryRegister(frmMonthlySalaryRegister frmMonthlySalaryReg, decimal decId, string strComboType)
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmMonthlySalaryRegisterObj = frmMonthlySalaryReg;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP5:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPurchaseOrder
        /// </summary>
        /// <param name="frmPurchaseOrder"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromPurchaseOrder(frmPurchaseOrder frmPurchaseOrder, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmPurchaseOrderObj = frmPurchaseOrder;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("LP6:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmContraVoucher
        /// </summary>
        /// <param name="frmContraVoucherObj"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromContraVoucher(frmContraVoucher frmContraVoucherObj, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmContraVoucherObj = frmContraVoucherObj;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP7:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from frmPaymentVoucher
        /// </summary>
        /// <param name="frmPaymentVoucher"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromPaymentVoucher(frmPaymentVoucher frmPaymentVoucher, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmPaymentVoucherObj = frmPaymentVoucher;
                frmPaymentVoucherObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP8:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from frmPaymentVoucher
        /// </summary>
        /// <param name="frmAdvancePayment"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromAdvancePayment(frmAdvancePayment frmAdvancePayment, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmAdvancePaymentObj = frmAdvancePayment;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP9:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmReceiptVoucher
        /// </summary>
        /// <param name="frmReceiptVoucher"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromReceiptVoucher(frmReceiptVoucher frmReceiptVoucher, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmReceiptVoucherObj = frmReceiptVoucher;
                frmReceiptVoucherObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP10:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmMonthlySalaryVoucher
        /// </summary>
        /// <param name="frmMonthlySalary"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromMonthlySalaryVoucher(frmMonthlySalaryVoucher frmMonthlySalary, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmMonthlySalaryVoucherObj = frmMonthlySalary;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP11:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDailySalaryVoucher
        /// </summary>
        /// <param name="frmDailySalary"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromDailySalaryVoucher(frmDailySalaryVoucher frmDailySalary, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmDailySalaryVoucherObj = frmDailySalary;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP12:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Function to call this form from frmJournalVoucher
        /// </summary>
        /// <param name="frmJournalVoucher"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromJournalVoucher(frmJournalVoucher frmJournalVoucher, decimal decId, string strComboType) //PopUp
        {
            try
            {
                base.Show();
                strComboTypes = strComboType;

                this.frmJournalVoucherObj = frmJournalVoucher;
                frmJournalVoucherObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP13:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Function to call this form from frmServiceVoucher 
        /// </summary>
        /// <param name="frmServiceVoucher"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromServiceVoucher(frmServiceVoucher frmServiceVoucher, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmServiceVoucherObj = frmServiceVoucher;
                frmServiceVoucherObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP14:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Function to call this form from frmPurchaseInvoice 
        /// </summary>
        /// <param name="frmPurchaseInvoice"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromPurchaseInvoice(frmPurchaseInvoice frmPurchaseInvoice, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmPurchaseInvoiceObj = frmPurchaseInvoice;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP15:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmMaterialReceipt 
        /// </summary>
        /// <param name="frmMaterialReceipt"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromMaterialReceipt(frmMaterialReceipt frmMaterialReceipt, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmMaterialReceiptObj = frmMaterialReceipt;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP16:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPurchaseReturn
        /// </summary>
        /// <param name="frmPurchaseReturn"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromPurchaseReturn(frmPurchaseReturn frmPurchaseReturn, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmPurchaseReturnObj = frmPurchaseReturn;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP17:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Function to call this form from frmSalesInvoice
        /// </summary>
        /// <param name="frmSalesInvoice"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromSalesInvoice(frmSalesInvoice frmSalesInvoice, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmSalesInvoiceObj = frmSalesInvoice;
                frmSalesInvoiceObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP18:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmRejectionIn
        /// </summary>
        /// <param name="frmRejectionIn"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strComboType"></param>
        public void CallFromRejectionIn(frmRejectionIn frmRejectionIn, decimal decLedgerId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmRejectionInObj = frmRejectionIn;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decLedgerId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview 
        /// </summary>
        public void Search()
        {
            try
            {
                if (strComboTypes == "CashOrBank")
                {
                    GridFill(27, 28);
                }
                else if (strComboTypes == "CashOrSundryCreditor")
                {
                    GridFill(27, 22);
                }
                else if (strComboTypes == "CashOrSundryDeptors")
                {
                    GridFill(27, 26);
                }
                else if (strComboTypes == "SalesAccount")
                {
                    GridFill(10, 0);
                }
                else
                {
                    GridFill(0, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP20:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// function to call this form from frmDebitNote
        /// </summary>
        /// <param name="frmDebitNote"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromDebitNoteVoucher(frmDebitNote frmDebitNote, decimal decId, string strComboType) //PopUp
        {
            try
            {
                base.Show();
                strComboTypes = strComboType;
                this.frmDebitNoteObj = frmDebitNote;
                frmDebitNoteObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP21:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// function to call this form from frmCreditNote
        /// </summary>
        /// <param name="frmCreditNoteObj"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromCreditNote(frmCreditNote frmCreditNoteObj, decimal decId, string strComboType) //PopUp
        {
            try
            {
                base.Show();
                strComboTypes = strComboType;
                this.frmCreditNoteObj = frmCreditNoteObj;
                frmCreditNoteObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP22:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Function to call this form from frmPdcPayable
        /// </summary>
        /// <param name="frmPDCPayable"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromPdcpayableVoucher(frmPdcPayable frmPDCPayable, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();

                this.frmPdcPayableObj = frmPDCPayable;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP23:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmPdcReceivable
        /// </summary>
        /// <param name="frmpdcReceivable"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromPdcReceivableVoucher(frmPdcReceivable frmpdcReceivable, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();

                this.frmpdReceivableObj = frmpdcReceivable;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP24:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmRejectionOut
        /// </summary>
        /// <param name="FrmRejectionOut"></param>
        /// <param name="decId"></param>
        /// <param name="strComboTypeSelection"></param>
        public void CallFromRejectionOut(frmRejectionOut FrmRejectionOut, decimal decId, string strComboTypeSelection)
        {
            try
            {
                strComboTypes = strComboTypeSelection;
                base.Show();
                this.frmRejectionOutObj = FrmRejectionOut;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {

                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP25:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// function to call this form from frmSalesQuotation
        /// </summary>
        /// <param name="FrmSalesQuotation"></param>
        /// <param name="decId"></param>
        /// <param name="strComboTypeSelection"></param>
        public void CallFromSalesQuotation(frmSalesQuotation FrmSalesQuotation, decimal decId, string strComboTypeSelection)
        {
            try
            {
                strComboTypes = strComboTypeSelection;
                base.Show();
                this.frmsalesQuotationObj = FrmSalesQuotation;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {

                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP26:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPartyAddressBook
        /// </summary>
        /// <param name="frmPartyAddressBook"></param>
        /// <param name="decId"></param>
        public void CallFromPartyAddressBook(frmPartyAddressBook frmPartyAddressBook, decimal decId)
        {
            try
            {
                // strComboTypes =  strComboTypeSelection;
                base.Show();
                this.frmPartyAddressBookObj = frmPartyAddressBook;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {

                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to call this form from frmSalesOrder
        /// </summary>
        /// <param name="FrmSalesOrder"></param>
        /// <param name="decId"></param>
        /// <param name="strComboTypeSelection"></param>
        public void CallFromSalesOrder(frmSalesOrder FrmSalesOrder, decimal decId, string strComboTypeSelection)
        {
            try
            {
                strComboTypes = strComboTypeSelection;
                base.Show();
                this.frmSalesOrderObj = FrmSalesOrder;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {

                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP28:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmDeliveryNote
        /// </summary>
        /// <param name="frmDeliveryNote"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromDeliveryNote(frmDeliveryNote frmDeliveryNote, decimal decId, string strComboType)
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmDeliveryNoteObj = frmDeliveryNote;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {

                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP29:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmSalesReturn
        /// </summary>
        /// <param name="frmSalesReturn"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromSalesReturn(frmSalesReturn frmSalesReturn, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmSalesReturnObj = frmSalesReturn;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP30:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmPOS
        /// </summary>
        /// <param name="frmPOS"></param>
        /// <param name="decId"></param>
        /// <param name="strComboType"></param>
        public void CallFromPOS(frmPOS frmPOS, decimal decId, string strComboType) //PopUp
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmPOSObj = frmPOS;
                frmPOSObj.Enabled = false;
                int inRowCount = dgvLedgerPopup.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvLedgerPopup.Rows[i].Cells["dgvtxtLedgerId"].Value.ToString()) == decId)
                    {
                        dgvLedgerPopup.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtLedgerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP31:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLedgerPopup_Load(object sender, EventArgs e)
        {
            try
            {
                AccountGroupComboFill();
                if (strComboTypes == "CashOrBank")
                {
                    GridFill(27, 28);
                }
                else if (strComboTypes == "CashOrSundryCreditors")
                {
                    GridFill(27, 22);
                }
                else if (strComboTypes == "CashOrSundryDeptors")
                {
                    GridFill(27, 26);
                }
                else if (strComboTypes == "ServiceAccount")
                {
                    GridFillForServiceAccounts();
                }

                else if (strComboTypes == "PurchaseAccount")
                {
                    GridFill(11, 11);
                }


                else if (strComboTypes == "SalesAccount")
                {
                    GridFill(10, 10);
                }

                else
                {
                    GridFill(0, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP32:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills Datagridview on 'Search' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (strComboTypes == "CashOrBank")
                {
                    GridFill(27, 28);
                }
                else if (strComboTypes == "CashOrSundryCreditor")
                {
                    GridFill(27, 22);
                }
                else if (strComboTypes == "CashOrSundryDeptors")
                {
                    GridFill(27, 26);
                }
                else if (strComboTypes == "SalesAccount")
                {
                    GridFill(10, 0);
                }
                else
                {
                    GridFill(0, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP33:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("LP34:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLedgerPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmMonthlySalaryRegisterObj != null)
                {
                    frmMonthlySalaryRegisterObj = Application.OpenForms["frmMonthlySalaryRegister"] as frmMonthlySalaryRegister;
                    if (frmMonthlySalaryRegisterObj == null)
                    {
                        frmMonthlySalaryRegisterObj = new frmMonthlySalaryRegister();
                        frmMonthlySalaryRegisterObj.MdiParent = formMDI.MDIObj;
                        frmMonthlySalaryRegisterObj.Show();
                    }
                    else
                    {
                        frmMonthlySalaryRegisterObj.Activate();
                    }
                }
                if (frmAdvancePaymentObj != null)
                {
                    frmAdvancePaymentObj = Application.OpenForms["frmAdvancePayment"] as frmAdvancePayment;
                    if (frmAdvancePaymentObj == null)
                    {
                        frmAdvancePaymentObj = new frmAdvancePayment();
                        frmAdvancePaymentObj.MdiParent = formMDI.MDIObj;
                        frmAdvancePaymentObj.Show();
                    }
                    else
                    {
                        frmAdvancePaymentObj.Activate();
                    }
                }
                if (frmMonthlySalaryVoucherObj != null)
                {
                    frmMonthlySalaryVoucherObj = Application.OpenForms["frmMonthlySalaryVoucher"] as frmMonthlySalaryVoucher;
                    if (frmMonthlySalaryVoucherObj == null)
                    {
                        frmMonthlySalaryVoucherObj = new frmMonthlySalaryVoucher();
                        frmMonthlySalaryVoucherObj.MdiParent = formMDI.MDIObj;
                        frmMonthlySalaryVoucherObj.Show();
                    }
                    else
                    {
                        frmMonthlySalaryVoucherObj.Activate();
                    }
                }
                if (frmDailySalaryVoucherObj != null)
                {
                    frmDailySalaryVoucherObj = Application.OpenForms["frmDailySalaryVoucher"] as frmDailySalaryVoucher;
                    if (frmDailySalaryVoucherObj == null)
                    {
                        frmDailySalaryVoucherObj = new frmDailySalaryVoucher();
                        frmDailySalaryVoucherObj.MdiParent = formMDI.MDIObj;
                        frmDailySalaryVoucherObj.Show();
                    }
                    else
                    {
                        frmDailySalaryVoucherObj.Activate();
                    }
                }
                if (frmJournalVoucherObj != null)
                {
                    frmJournalVoucherObj.Enabled = true;
                }
                if (frmReceiptVoucherObj != null)
                {
                    frmReceiptVoucherObj.Enabled = true;
                }
                if (frmContraVoucherObj != null)
                {
                    frmContraVoucherObj = Application.OpenForms["frmContraVoucher"] as frmContraVoucher;
                    if (frmContraVoucherObj == null)
                    {
                        frmContraVoucherObj = new frmContraVoucher();
                        frmContraVoucherObj.MdiParent = formMDI.MDIObj;
                        frmContraVoucherObj.Show();
                    }
                    else
                    {
                        frmContraVoucherObj.Activate();
                    }
                }
                if (frmPaymentVoucherObj != null)
                {
                    frmPaymentVoucherObj.Enabled = true;
                }

                if (frmDebitNoteObj != null)
                {
                    frmDebitNoteObj.Enabled = true;
                }
                if (frmCreditNoteObj != null)
                {
                    frmCreditNoteObj.Enabled = true;
                }
                if (frmPdcPayableObj != null)
                {
                    frmPdcPayableObj.Enabled = true;
                }
                if (frmpdReceivableObj != null)
                {
                    frmpdReceivableObj.Enabled = true;
                }
                if (frmMaterialReceiptObj != null)
                {
                    frmMaterialReceiptObj.Enabled = true;
                }
                if (frmSalesInvoiceObj != null)
                {
                    frmSalesInvoiceObj.Enabled = true;
                }
                if (frmPOSObj != null)
                {
                    frmPOSObj.Enabled = true;
                }

                if (frmMaterialReceiptObj != null)
                {
                    frmMaterialReceiptObj = Application.OpenForms["frmMaterialReceipt"] as frmMaterialReceipt;
                    if (frmMaterialReceiptObj == null)
                    {
                        frmMaterialReceiptObj = new frmMaterialReceipt();
                        frmMaterialReceiptObj.MdiParent = formMDI.MDIObj;
                        frmMaterialReceiptObj.Show();
                    }
                    else
                    {
                        frmMaterialReceiptObj.Activate();
                    }
                }

                if (frmPurchaseInvoiceObj != null)
                {
                    frmPurchaseInvoiceObj = Application.OpenForms["frmPurchaseInvoice"] as frmPurchaseInvoice;
                    if (frmPurchaseInvoiceObj == null)
                    {
                        frmPurchaseInvoiceObj = new frmPurchaseInvoice();
                        frmPurchaseInvoiceObj.MdiParent = formMDI.MDIObj;
                        frmPurchaseInvoiceObj.Show();
                    }
                    else
                    {
                        frmPurchaseInvoiceObj.Activate();
                    }
                }
                if (frmServiceVoucherObj != null)
                {
                    frmServiceVoucherObj.Enabled = true;
                }

                dgvLedgerPopup.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP35:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// clears selection of datagridview on binding complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLedgerPopup_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvLedgerPopup.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP36:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On datagridview cell double click fills the ledger to the corresponding form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLedgerPopup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (frmMonthlySalaryRegisterObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmMonthlySalaryRegisterObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                        }
                    }
                    if (frmAdvancePaymentObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmAdvancePaymentObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                        }
                    }
                    if (frmMonthlySalaryVoucherObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmMonthlySalaryVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                        }
                    }
                    if (frmDailySalaryVoucherObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmDailySalaryVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                        }
                    }
                    if (frmPaymentVoucherObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmPaymentVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                        }
                    }

                    if (frmReceiptVoucherObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmReceiptVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                        }
                    }
                    if (frmServiceVoucherObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmServiceVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);

                        }
                    }
                    if (frmContraVoucherObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmContraVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                        }
                    }
                    if (frmJournalVoucherObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmJournalVoucherObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);

                        }
                    }
                    if (frmPurchaseOrderObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmPurchaseOrderObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                        }
                    }
                    if (frmDebitNoteObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmDebitNoteObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                        }
                    }
                    if (frmCreditNoteObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmCreditNoteObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                        }
                    }
                    if (frmsalesQuotationObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmsalesQuotationObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }
                    if (frmSalesOrderObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmSalesOrderObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }
                    if (frmDeliveryNoteObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmDeliveryNoteObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }


                    if (frmMaterialReceiptObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmMaterialReceiptObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }

                    if (frmRejectionInObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                           
                            this.Close();
                        }
                    }


                    if (frmRejectionOutObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmRejectionOutObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }

                    if (frmPurchaseInvoiceObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmPurchaseInvoiceObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }


                    if (frmPurchaseReturnObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmPurchaseReturnObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }


                    if (frmPdcPayableObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmPdcPayableObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }

                    if (frmpdReceivableObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmpdReceivableObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }


                    if (frmSalesInvoiceObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmSalesInvoiceObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            this.Close();
                        }
                    }

                    if (frmSalesReturnObj != null)
                    {
                        if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                        {
                            frmSalesReturnObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP37:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLedgerPopup_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("LP38:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLedgerName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbAccountGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP39:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAccountGroup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvLedgerPopup.Focus();
                    dgvLedgerPopup.Rows[0].Selected = true;
                }
                if (e.KeyCode == Keys.Back)
                {
                    
                        txtLedgerName.Focus();
                        txtLedgerName.SelectionStart = 0;
                        txtLedgerName.SelectionLength = 0;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP40:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmbAccountGroup.Focus();
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP41:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the ledger to corresponding form on enter key in Datagridview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLedgerPopup_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //if (e.KeyCode == Keys.Enter)
                //{
                //    if (dgvLedgerPopup.CurrentRow != null)
                //    {
                //        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                //        if (frmMonthlySalaryRegisterObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmMonthlySalaryRegisterObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                //            }
                //        }
                //    }
                //    if (dgvLedgerPopup.CurrentRow != null)
                //    {
                //        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                //        if (frmMonthlySalaryVoucherObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmMonthlySalaryVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                //            }
                //        }
                //    }
                //    if (dgvLedgerPopup.CurrentRow != null)
                //    {
                //        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                //        if (frmAdvancePaymentObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmAdvancePaymentObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                //            }
                //        }
                //    }
                //    if (dgvLedgerPopup.CurrentRow != null)
                //    {
                //        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                //        if (frmDailySalaryVoucherObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmDailySalaryVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                //            }
                //        }
                //    }

                //    if (dgvLedgerPopup.CurrentRow != null)
                //    {
                //        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                //        if (frmServiceVoucherObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmServiceVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                //            }
                //        }
                //    }
                //    if (dgvLedgerPopup.CurrentRow != null)
                //    {
                //        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                //        if (frmJournalVoucherObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmJournalVoucherObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                //            }
                //        }
                //        else if (frmDebitNoteObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmDebitNoteObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                //            }
                //        }
                //        else if (frmCreditNoteObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmCreditNoteObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                //            }
                //        }
                //        else if (frmsalesQuotationObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmsalesQuotationObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                //                this.Close();
                //            }
                //        }
                //        else if (frmPaymentVoucherObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmPaymentVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                //            }
                //        }
                //        else if (frmReceiptVoucherObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmReceiptVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                //            }
                //        }
                //        else if (frmContraVoucherObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmContraVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                //            }
                //        }
                //        else if (frmPurchaseOrderObj != null)
                //        {
                //            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                //            {
                //                frmPurchaseOrderObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                //            }
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP42:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLedgerPopup_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvLedgerPopup.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                        if (frmMonthlySalaryRegisterObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmMonthlySalaryRegisterObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                            }
                        }
                    }
                    if (dgvLedgerPopup.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                        if (frmMonthlySalaryVoucherObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmMonthlySalaryVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                            }
                        }
                    }
                    if (dgvLedgerPopup.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                        if (frmAdvancePaymentObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmAdvancePaymentObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                            }
                        }
                    }
                    if (dgvLedgerPopup.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                        if (frmDailySalaryVoucherObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmDailySalaryVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()));
                            }
                        }
                    }

                    if (dgvLedgerPopup.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                        if (frmServiceVoucherObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmServiceVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            }
                        }
                    }
                    if (dgvLedgerPopup.CurrentRow != null)
                    {
                        DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dgvLedgerPopup.CurrentCell.ColumnIndex, dgvLedgerPopup.CurrentCell.RowIndex);
                        if (frmJournalVoucherObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmJournalVoucherObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                            }
                        }
                        else if (frmDebitNoteObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmDebitNoteObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                            }
                        }
                        else if (frmCreditNoteObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmCreditNoteObj.CallFromLedgerPopup(Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), this);
                            }
                        }
                        else if (frmsalesQuotationObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmsalesQuotationObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                                this.Close();
                            }
                        }
                        else if (frmPaymentVoucherObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmPaymentVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            }
                        }
                        else if (frmReceiptVoucherObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmReceiptVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            }
                        }
                        else if (frmContraVoucherObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmContraVoucherObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            }
                        }
                        else if (frmPurchaseOrderObj != null)
                        {
                            if (dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Selected)
                            {
                                frmPurchaseOrderObj.CallFromLedgerPopup(this, Convert.ToDecimal(dgvLedgerPopup.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString()), strComboTypes);
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.Back)
                {

                    cmbAccountGroup.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LP43:" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void btnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvLedgerPopup.Focus();
                    dgvLedgerPopup.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
