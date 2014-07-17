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
using System.Collections;
using OpenMiracle.BLL;
using ENTITY;
namespace Open_Miracle
{
    public partial class frmPartyBalance : Form
    {
        #region Public variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmPaymentVoucher frmPaymentVoucherObj = null;
        frmReceiptVoucher frmReceiptVoucherObj = null;
        frmJournalVoucher frmJournalVoucherObj;
        frmCreditNote frmCreditNoteVoucherObj;
        frmDebitNote frmDebitNoteObj = null;
        frmPdcPayable frmPdcpayableObj;
        frmPdcReceivable frmPdcReceivableObj;
        frmAgainstBillDetails frmAgainstBillDetailsObj = new frmAgainstBillDetails();
        DataTable dtblPartyBalance = new DataTable();
        ArrayList arrlstOfDeletedPartyBalanceRow = new ArrayList();
        DateTime dtmVoucherDate = PublicVariables._dtCurrentDate;
        string strDebitOrCredit = string.Empty;
        string strVoucherNo = string.Empty;
        bool isValueChanged = false;
        bool IsSaveOrEsc = false;
        int inRowRemove = 0;
        decimal decLedgerId = 0;
        decimal decVoucherTypeId = 0;
        #endregion
        #region Function
        /// <summary>
        /// Create instance of frmJournalVoucher
        /// </summary>
        public frmPartyBalance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call frmPaymentVoucher form to set amount for sundry creditors or sundry debtors
        /// </summary>
        /// <param name="frmPaymentVoucher"></param>
        /// <param name="decId"></param>
        /// <param name="dtblPartyBalance"></param>
        /// <param name="decPaymentVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="date"></param>
        /// <param name="arrlstOfDeletedPartyBalanceRow"></param>
        public void CallFromPaymentVoucher(frmPaymentVoucher frmPaymentVoucher, decimal decId, DataTable dtblPartyBalance, decimal decPaymentVoucherTypeId, string strVoucherNo, DateTime date, ArrayList arrlstOfDeletedPartyBalanceRow)
        {
            try
            {
                frmPaymentVoucher.Enabled = false;
                decVoucherTypeId = decPaymentVoucherTypeId;
                this.strVoucherNo = strVoucherNo;
                strDebitOrCredit = "Dr";
                decLedgerId = decId;
                this.dtblPartyBalance = dtblPartyBalance;
                dtmVoucherDate = date;
                base.Show();
                this.frmPaymentVoucherObj = frmPaymentVoucher;
                frmPaymentVoucherObj.Enabled = false;
                this.arrlstOfDeletedPartyBalanceRow = arrlstOfDeletedPartyBalanceRow;
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();
                //at the time of updation and at the time of loading frmPartyBalance when already entries are entered
                List<DataTable> listObj = new List<DataTable>();
                if (inTableRowCount > 0)
                {
                    int inK = 0;
                    for (int inI = 0; inI < inTableRowCount; inI++)
                    {
                        if (decLedgerId == Convert.ToDecimal(dtblPartyBalance.Rows[inI]["LedgerId"].ToString()))
                        {
                            if (strDebitOrCredit == dtblPartyBalance.Rows[inI]["DebitOrCredit"].ToString())
                            {
                                dgvPartyBalance.Rows.Add();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value = dtblPartyBalance.Rows[inI]["ReferenceType"].ToString();
                                if (dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].ReadOnly = false;
                                    listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, dgvPartyBalance.CurrentRow.Index - 1];
                                    dgvccVoucherType.DataSource = listObj[0];
                                    dgvccVoucherType.ValueMember = "value";
                                    dgvccVoucherType.DisplayMember = "display";
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherTypeId"].ToString() + "_" + dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtVoucherNo"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtInvoiceNo"].Value = dtblPartyBalance.Rows[inI]["AgainstInvoiceNo"].ToString();
                                    if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                    {
                                        for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                                        {
                                            if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                            {
                                                dgvPartyBalance.Rows[inK].Cells["dgvtxtpending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                                break;
                                            }
                                        }
                                    }
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].ReadOnly = true;
                                }
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtAmount"].Value = Math.Round(Convert.ToDecimal(dtblPartyBalance.Rows[inI]["Amount"].ToString()), Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces)).ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(dtblPartyBalance.Rows[inI]["CurrencyId"].ToString());
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtPartyBalanceId"].Value = dtblPartyBalance.Rows[inI]["partyBalanceId"].ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtOldExchangeRateId"].Value = dtblPartyBalance.Rows[inI]["OldExchangeRate"].ToString();
                                inK++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:1" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmReceiptVoucher form to set amount for sundry creditors or sundry debtors
        /// </summary>
        /// <param name="frmReceiptVoucher"></param>
        /// <param name="decId"></param>
        /// <param name="dtblPartyBalance"></param>
        /// <param name="decReceiptVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="date"></param>
        /// <param name="arrlstOfDeletedPartyBalanceRow"></param>
        public void CallFromReceiptVoucher(frmReceiptVoucher frmReceiptVoucher, decimal decId, DataTable dtblPartyBalance, decimal decReceiptVoucherTypeId, string strVoucherNo, DateTime date, ArrayList arrlstOfDeletedPartyBalanceRow)
        {
            try
            {
                frmReceiptVoucher.Enabled = false;
                decVoucherTypeId = decReceiptVoucherTypeId;
                this.strVoucherNo = strVoucherNo;
                strDebitOrCredit = "Cr";
                decLedgerId = decId;
                this.dtblPartyBalance = dtblPartyBalance;
                dtmVoucherDate = date;
                base.Show();
                this.frmReceiptVoucherObj = frmReceiptVoucher;
                frmReceiptVoucherObj.Enabled = false;
                this.arrlstOfDeletedPartyBalanceRow = arrlstOfDeletedPartyBalanceRow;
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();
                //at the time of updation and at the time of loading frmPartyBalance when already entries are entered
                List<DataTable> listObj = new List<DataTable>();
                if (inTableRowCount > 0)
                {
                    int inK = 0;
                    for (int inI = 0; inI < inTableRowCount; inI++)
                    {
                        if (decLedgerId == Convert.ToDecimal(dtblPartyBalance.Rows[inI]["LedgerId"].ToString()))
                        {
                            if (strDebitOrCredit == dtblPartyBalance.Rows[inI]["DebitOrCredit"].ToString())
                            {
                                dgvPartyBalance.Rows.Add();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value = dtblPartyBalance.Rows[inI]["ReferenceType"].ToString();
                                if (dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].ReadOnly = false;
                                    listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, dgvPartyBalance.CurrentRow.Index - 1];
                                    dgvccVoucherType.DataSource = listObj[0];
                                    dgvccVoucherType.ValueMember = "value";
                                    dgvccVoucherType.DisplayMember = "display";
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherTypeId"].ToString() + "_" + dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtVoucherNo"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtInvoiceNo"].Value = dtblPartyBalance.Rows[inI]["AgainstInvoiceNo"].ToString();
                                    if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                    {
                                        for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                                        {
                                            if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                            {
                                                dgvPartyBalance.Rows[inK].Cells["dgvtxtpending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                                break;
                                            }
                                        }
                                    }
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].ReadOnly = true;
                                }
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtAmount"].Value = Math.Round(Convert.ToDecimal(dtblPartyBalance.Rows[inI]["Amount"].ToString()), Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces)).ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(dtblPartyBalance.Rows[inI]["CurrencyId"].ToString());
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtPartyBalanceId"].Value = dtblPartyBalance.Rows[inI]["partyBalanceId"].ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtOldExchangeRateId"].Value = dtblPartyBalance.Rows[inI]["OldExchangeRate"].ToString();
                                inK++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:2" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmJournalVoucher form to set amount for sundry creditors or sundry debtors
        /// </summary>
        /// <param name="frmJournalVoucherObj1"></param>
        /// <param name="decId"></param>
        /// <param name="dtblPartyBalance"></param>
        /// <param name="strDebitOrCredit1"></param>
        /// <param name="decJournalVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="date"></param>
        /// <param name="arrlstOfDeletedPartyBalanceRow"></param>
        public void CallFromJournalVoucher(frmJournalVoucher frmJournalVoucherObj1, decimal decId, DataTable dtblPartyBalance, string strDebitOrCredit1, decimal decJournalVoucherTypeId, string strVoucherNo, DateTime date, ArrayList arrlstOfDeletedPartyBalanceRow)
        {
            try
            {
                decVoucherTypeId = decJournalVoucherTypeId;
                this.strVoucherNo = strVoucherNo;
                dtmVoucherDate = date;
                decLedgerId = decId;
                this.dtblPartyBalance = dtblPartyBalance;
                strDebitOrCredit = strDebitOrCredit1;
                base.Show();
                this.frmJournalVoucherObj = frmJournalVoucherObj1;
                frmJournalVoucherObj.Enabled = false;
                this.arrlstOfDeletedPartyBalanceRow = arrlstOfDeletedPartyBalanceRow;
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();
                List<DataTable> listObj = new List<DataTable>();
                if (inTableRowCount > 0)
                {
                    int inK = 0;
                    for (int inI = 0; inI < inTableRowCount; inI++)
                    {
                        if (decLedgerId == Convert.ToDecimal(dtblPartyBalance.Rows[inI]["LedgerId"].ToString()))
                        {
                            if (strDebitOrCredit == dtblPartyBalance.Rows[inI]["DebitOrCredit"].ToString())
                            {
                                dgvPartyBalance.Rows.Add();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value = dtblPartyBalance.Rows[inI]["ReferenceType"].ToString();
                                if (dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    //----------------------------------------------------------------------------//
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].ReadOnly = false;
                                    listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, dgvPartyBalance.CurrentRow.Index - 1];
                                    dgvccVoucherType.DataSource = listObj[0];
                                    dgvccVoucherType.ValueMember = "value";
                                    dgvccVoucherType.DisplayMember = "display";
                                    //============================================================================//
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherTypeId"].ToString() + "_" + dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtVoucherNo"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtInvoiceNo"].Value = dtblPartyBalance.Rows[inI]["AgainstInvoiceNo"].ToString();
                                    if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                    {
                                        for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                                        {
                                            if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                            {
                                                dgvPartyBalance.Rows[inK].Cells["dgvtxtpending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                                break;
                                            }
                                        }
                                    }
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].ReadOnly = true;
                                }
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtAmount"].Value = Math.Round(Convert.ToDecimal(dtblPartyBalance.Rows[inI]["Amount"].ToString()), Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces)).ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(dtblPartyBalance.Rows[inI]["CurrencyId"].ToString());
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtPartyBalanceId"].Value = dtblPartyBalance.Rows[inI]["partyBalanceId"].ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtOldExchangeRateId"].Value = dtblPartyBalance.Rows[inI]["OldExchangeRate"].ToString();
                                inK++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:3" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmCreditNote form to set amount for sundry creditors or sundry debtors
        /// </summary>
        /// <param name="frmCreditNoteVoucherObj1"></param>
        /// <param name="decId"></param>
        /// <param name="dtblPartyBalance"></param>
        /// <param name="strDebitOrCredit1"></param>
        /// <param name="decCreditNoteVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="date"></param>
        /// <param name="arrlstOfDeletedPartyBalanceRow"></param>
        public void CallFromCreditNote(frmCreditNote frmCreditNoteVoucherObj1, decimal decId, DataTable dtblPartyBalance, string strDebitOrCredit1, decimal decCreditNoteVoucherTypeId, string strVoucherNo, DateTime date, ArrayList arrlstOfDeletedPartyBalanceRow)
        {
            try
            {
                decVoucherTypeId = decCreditNoteVoucherTypeId;
                this.strVoucherNo = strVoucherNo;
                dtmVoucherDate = date;
                decLedgerId = decId;
                this.dtblPartyBalance = dtblPartyBalance;
                strDebitOrCredit = strDebitOrCredit1;
                base.Show();
                this.frmCreditNoteVoucherObj = frmCreditNoteVoucherObj1;
                frmCreditNoteVoucherObj.Enabled = false;
                this.arrlstOfDeletedPartyBalanceRow = arrlstOfDeletedPartyBalanceRow;
                //---------------------------------------------------------//
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();
                List<DataTable> listObj = new List<DataTable>();
                if (inTableRowCount > 0)
                {
                    int inK = 0;
                    for (int inI = 0; inI < inTableRowCount; inI++)
                    {
                        if (decLedgerId == Convert.ToDecimal(dtblPartyBalance.Rows[inI]["LedgerId"].ToString()))
                        {
                            if (strDebitOrCredit == dtblPartyBalance.Rows[inI]["DebitOrCredit"].ToString())
                            {
                                dgvPartyBalance.Rows.Add();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value = dtblPartyBalance.Rows[inI]["ReferenceType"].ToString();
                                if (dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].ReadOnly = false;
                                    listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, dgvPartyBalance.CurrentRow.Index - 1];
                                    dgvccVoucherType.DataSource = listObj[0];
                                    dgvccVoucherType.ValueMember = "value";
                                    dgvccVoucherType.DisplayMember = "display";
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherTypeId"].ToString() + "_" + dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtVoucherNo"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtInvoiceNo"].Value = dtblPartyBalance.Rows[inI]["AgainstInvoiceNo"].ToString();
                                    if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                    {
                                        for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                                        {
                                            if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                            {
                                                dgvPartyBalance.Rows[inK].Cells["dgvtxtpending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                                break;
                                            }
                                        }
                                    }
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].ReadOnly = true;
                                }
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtAmount"].Value = Math.Round(Convert.ToDecimal(dtblPartyBalance.Rows[inI]["Amount"].ToString()), Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces)).ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(dtblPartyBalance.Rows[inI]["CurrencyId"].ToString());
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtPartyBalanceId"].Value = dtblPartyBalance.Rows[inI]["partyBalanceId"].ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtOldExchangeRateId"].Value = dtblPartyBalance.Rows[inI]["OldExchangeRate"].ToString();
                                inK++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:4" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmDebitNote form to set amount for sundry creditors or sundry debtors
        /// </summary>
        /// <param name="frmDebitNote"></param>
        /// <param name="decId"></param>
        /// <param name="dtblPartyBalance"></param>
        /// <param name="strDebitOrCredit1"></param>
        /// <param name="decDebitNoteTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="date"></param>
        /// <param name="arrlstOfDeletedPartyBalanceRow"></param>
        public void CallFromDebitNote(frmDebitNote frmDebitNote, decimal decId, DataTable dtblPartyBalance, string strDebitOrCredit1, decimal decDebitNoteTypeId, string strVoucherNo, DateTime date, ArrayList arrlstOfDeletedPartyBalanceRow)
        {
            try
            {
                this.strVoucherNo = strVoucherNo;
                decVoucherTypeId = decDebitNoteTypeId;
                decLedgerId = decId;
                this.dtblPartyBalance = dtblPartyBalance;
                strDebitOrCredit = strDebitOrCredit1;
                base.Show();
                this.frmDebitNoteObj = frmDebitNote;
                frmDebitNoteObj.Enabled = false;
                this.arrlstOfDeletedPartyBalanceRow = arrlstOfDeletedPartyBalanceRow;
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();
                List<DataTable> listObj = new List<DataTable>();
                if (inTableRowCount > 0)
                {
                    int inK = 0;
                    for (int inI = 0; inI < inTableRowCount; inI++)
                    {
                        if (decLedgerId == Convert.ToDecimal(dtblPartyBalance.Rows[inI]["LedgerId"].ToString()))
                        {
                            if (strDebitOrCredit == dtblPartyBalance.Rows[inI]["DebitOrCredit"].ToString())
                            {
                                dgvPartyBalance.Rows.Add();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value = dtblPartyBalance.Rows[inI]["ReferenceType"].ToString();
                                if (dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].ReadOnly = false;
                                    listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, dgvPartyBalance.CurrentRow.Index - 1];
                                    dgvccVoucherType.DataSource = listObj[0];
                                    dgvccVoucherType.ValueMember = "value";
                                    dgvccVoucherType.DisplayMember = "display";
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherTypeId"].ToString() + "_" + dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtVoucherNo"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtInvoiceNo"].Value = dtblPartyBalance.Rows[inI]["AgainstInvoiceNo"].ToString();
                                    if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                    {
                                        for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                                        {
                                            if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                            {
                                                dgvPartyBalance.Rows[inK].Cells["dgvtxtpending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                                break;
                                            }
                                        }
                                    }
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].ReadOnly = true;
                                }
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtAmount"].Value = Math.Round(Convert.ToDecimal(dtblPartyBalance.Rows[inI]["Amount"].ToString()), Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces)).ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(dtblPartyBalance.Rows[inI]["CurrencyId"].ToString());
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtPartyBalanceId"].Value = dtblPartyBalance.Rows[inI]["partyBalanceId"].ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtOldExchangeRateId"].Value = dtblPartyBalance.Rows[inI]["OldExchangeRate"].ToString();
                                inK++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to calculate total amount
        /// </summary>
        public void TotalAmount()
        {
            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
            try
            {
                decimal decTotalAmount = 0;
                int inRowCount = dgvPartyBalance.RowCount;
                if (inRowCount > 1)
                {
                    decimal decSelectedCurrencyRate = 0;
                    foreach (DataGridViewRow dr in dgvPartyBalance.Rows)
                    {
                        if (dr.Cells["dgvtxtAmount"].Value != null && dr.Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            if (dr.Cells["dgvtxtAmount"].Value.ToString() != ".")
                            {
                                if (dr.Cells["dgvcmbCurrency"].Value != null && dr.Cells["dgvcmbCurrency"].Value.ToString() != string.Empty && Convert.ToDecimal(dr.Cells["dgvcmbCurrency"].Value.ToString())!=0)
                                {
                                    decSelectedCurrencyRate = BllExchangeRate.GetExchangeRateByExchangeRateId(Convert.ToDecimal(dr.Cells["dgvcmbCurrency"].Value.ToString()));//Exchange rate of grid's row
                                    decTotalAmount = decTotalAmount + (Convert.ToDecimal(dr.Cells["dgvtxtAmount"].Value.ToString()) * decSelectedCurrencyRate);
                                }
                                else
                                {
                                    decTotalAmount = decTotalAmount + Convert.ToDecimal(dr.Cells["dgvtxtAmount"].Value.ToString());
                                }
                            }
                        }
                    }
                    txtTotalAmount.Text = Math.Round(decTotalAmount, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces.ToString())).ToString();
                }
                else
                {
                    decTotalAmount = 0;
                    txtTotalAmount.Text = Math.Round(decTotalAmount, Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces.ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:6" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to generate serial number
        /// </summary>
        public void SerialNumberGeneration()
        {
            try
            {
                int inRowSlNo = 1;
                foreach (DataGridViewRow dr in dgvPartyBalance.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowSlNo;
                    inRowSlNo++;
                    if (dr.Index == dgvPartyBalance.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:7" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to save
        /// </summary>
        public void Save()
        {
            try
            {
                if (txtTotalAmount.Text == "0.00")
                {
                    Messages.InformationMessage("Can't save total amount as zero");
                }
                else
                {
                    ArrayList arrlstOfRowToRemove = new ArrayList();
                    int inReadyForSave = 0;
                    int inIsRowToRemove = 0;
                    int inIfGridColumnMissing = 0;
                    int inGridRowCount = dgvPartyBalance.RowCount;
                    int inTableCount = dtblPartyBalance.Rows.Count;
                    if (inGridRowCount != 1)
                    {
                        for (int inJ = 0; inJ < inGridRowCount - 1; inJ++)
                        {
                            if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value.ToString() == "Against")
                            {
                                if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value.ToString().Trim() == string.Empty)
                                {
                                    arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                    inIfGridColumnMissing = 1;
                                    continue;
                                }
                                else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value.ToString() == "New")
                                {
                                    if (dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                    else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value.ToString() == string.Empty || Convert.ToDecimal(dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value.ToString()) == 0)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                }
                                else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbVoucherType"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbVoucherType"].Value.ToString() == string.Empty)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                    else if (dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value.ToString() == string.Empty)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                    else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value.ToString() == string.Empty || Convert.ToDecimal(dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value.ToString()) == 0)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value.ToString().Trim() == string.Empty)
                                {
                                    arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                    inIfGridColumnMissing = 1;
                                    continue;
                                }
                                else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value.ToString() == "New")
                                {
                                    if (dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                    else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value.ToString() == string.Empty || Convert.ToDecimal(dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value.ToString()) == 0)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                }
                                else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbVoucherType"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbVoucherType"].Value.ToString() == string.Empty)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                    else if (dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvtxtAmount"].Value.ToString() == string.Empty)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                    else if (dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value == null || dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value.ToString() == string.Empty || Convert.ToDecimal(dgvPartyBalance.Rows[inJ].Cells["dgvcmbCurrency"].Value.ToString()) == 0)
                                    {
                                        arrlstOfRowToRemove.Add(dgvPartyBalance.Rows[inJ].Cells["dgvtxtSlNo"].Value.ToString());
                                        inIfGridColumnMissing = 1;
                                        continue;
                                    }
                                }
                            }
                        }
                        if (inIfGridColumnMissing == 0)
                        {
                            inReadyForSave = 1;
                            inIsRowToRemove = 0;
                        }
                        else
                        {
                            string strMsg = string.Empty;
                            int inK = 0;
                            foreach (object obj in arrlstOfRowToRemove)
                            {
                                if (inK != 0)
                                {
                                    strMsg = strMsg + ", ";
                                }
                                string str = Convert.ToString(obj);
                                strMsg = strMsg + str;
                                inK++;
                            }
                            if (MessageBox.Show("Row " + strMsg + " Contains invalid entries.\n Do you want to continue ? ", "Open Miracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                inReadyForSave = 1;
                                inIsRowToRemove = 1;
                            }
                            else
                                return;
                        }
                        if (inReadyForSave == 1)
                        {
                            //-----------------If there are rows to remove---------------//
                            if (inIsRowToRemove == 1)
                            {
                                int inDgvPartyBalanceRowCount = dgvPartyBalance.RowCount;
                                int inK = 0;
                                for (int inI = 0; inI < inDgvPartyBalanceRowCount; inI++)
                                {
                                    if (inK == arrlstOfRowToRemove.Count)
                                    {
                                        break;
                                    }
                                    if (inDgvPartyBalanceRowCount > 0)
                                    {
                                        if (Convert.ToInt32(dgvPartyBalance.Rows[inI].Cells["dgvtxtSlNo"].Value.ToString()) == Convert.ToInt32(arrlstOfRowToRemove[inK]))
                                        {
                                            inK++;
                                            if (dgvPartyBalance.Rows[inI].Cells["dgvtxtPartyBalanceId"].Value != null && dgvPartyBalance.Rows[inI].Cells["dgvtxtPartyBalanceId"].Value.ToString() != string.Empty)
                                            {
                                                int inTableRowCount = dtblPartyBalance.Rows.Count;
                                                for (int inJ = 0; inJ < inTableRowCount; inJ++)
                                                {
                                                    if (Convert.ToDecimal(dgvPartyBalance.Rows[inI].Cells["dgvtxtPartyBalanceId"].Value.ToString()) == Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["PartyBalanceId"].ToString()))
                                                    {
                                                        arrlstOfDeletedPartyBalanceRow.Add(dgvPartyBalance.Rows[inI].Cells["dgvtxtPartyBalanceId"].Value);
                                                        dtblPartyBalance.Rows.Remove(dtblPartyBalance.Rows[inJ]);
                                                        inTableRowCount = dtblPartyBalance.Rows.Count;
                                                        inJ--;
                                                    }
                                                }
                                            }
                                            dgvPartyBalance.Rows.Remove(dgvPartyBalance.Rows[inI]);
                                            inDgvPartyBalanceRowCount = dgvPartyBalance.RowCount;
                                            inI--;
                                        }
                                    }
                                }
                                SerialNumberGeneration();
                            }
                            TotalAmount();
                            inGridRowCount = dgvPartyBalance.RowCount;
                            if (inGridRowCount > 1)
                            {
                                inTableCount = dtblPartyBalance.Rows.Count;
                                for (int inJ = 0; inJ < inTableCount; inJ++)
                                {
                                    if (Convert.ToDecimal(dtblPartyBalance.Rows[inJ]["ledgerId"]) == decLedgerId)
                                    {
                                        dtblPartyBalance.Rows.Remove(dtblPartyBalance.Rows[inJ]);
                                        inTableCount = dtblPartyBalance.Rows.Count;
                                        inJ--;
                                    }
                                }
                                inTableCount = dtblPartyBalance.Rows.Count;
                                //========================================================================================//
                                for (int inI = 0; inI < inGridRowCount - 1; inI++)
                                {
                                    dtblPartyBalance.Rows.Add();
                                    dtblPartyBalance.Rows[inTableCount]["LedgerId"] = decLedgerId;
                                    if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value.ToString() == "New")
                                    {
                                        dtblPartyBalance.Rows[inTableCount]["AgainstVoucherTypeId"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["AgainstVoucherNo"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["AgainstInvoiceNo"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["PendingAmount"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["VoucherTypeId"] = decVoucherTypeId;
                                        dtblPartyBalance.Rows[inTableCount]["VoucherNo"] = strVoucherNo;
                                        dtblPartyBalance.Rows[inTableCount]["AgainstInvoiceNo"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["ReferenceType"] = "New";
                                        dtblPartyBalance.Rows[inTableCount]["OldExchangeRate"] = 1;
                                    }
                                    else if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value.ToString() == "OnAccount")
                                    {
                                        dtblPartyBalance.Rows[inTableCount]["AgainstVoucherTypeId"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["AgainstVoucherNo"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["AgainstInvoiceNo"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["PendingAmount"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["VoucherTypeId"] = decVoucherTypeId;
                                        dtblPartyBalance.Rows[inTableCount]["VoucherNo"] = strVoucherNo;
                                        dtblPartyBalance.Rows[inTableCount]["InvoiceNo"] = 0;
                                        dtblPartyBalance.Rows[inTableCount]["ReferenceType"] = "OnAccount";
                                        dtblPartyBalance.Rows[inTableCount]["OldExchangeRate"] = 1;
                                    }
                                    else if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                    {
                                        string str = dgvPartyBalance.Rows[inI].Cells["dgvcmbVoucherType"].Value.ToString();
                                        string[] words;
                                        words = str.Split('_');
                                        dtblPartyBalance.Rows[inTableCount]["AgainstVoucherTypeId"] = words[0];
                                        dtblPartyBalance.Rows[inTableCount]["AgainstVoucherNo"] = dgvPartyBalance.Rows[inI].Cells["dgvtxtVoucherNo"].Value;
                                        dtblPartyBalance.Rows[inTableCount]["AgainstInvoiceNo"] = dgvPartyBalance.Rows[inI].Cells["dgvtxtInvoiceNo"].Value;
                                        dtblPartyBalance.Rows[inTableCount]["VoucherTypeId"] = decVoucherTypeId;
                                        dtblPartyBalance.Rows[inTableCount]["VoucherNo"] = strVoucherNo;
                                        dtblPartyBalance.Rows[inTableCount]["InvoiceNo"] = dgvPartyBalance.Rows[inI].Cells["dgvtxtInvoiceNo"].Value;
                                        dtblPartyBalance.Rows[inTableCount]["PendingAmount"] = dgvPartyBalance.Rows[inI].Cells["dgvtxtPending"].Value;
                                        dtblPartyBalance.Rows[inTableCount]["ReferenceType"] = "Against";
                                        dtblPartyBalance.Rows[inTableCount]["OldExchangeRate"] = dgvPartyBalance.Rows[inI].Cells["dgvtxtOldExchangeRateId"].Value;
                                    }
                                    dtblPartyBalance.Rows[inTableCount]["CurrencyId"] = dgvPartyBalance.Rows[inI].Cells["dgvcmbCurrency"].Value;
                                    if (dgvPartyBalance.Rows[inI].Cells["dgvtxtAmount"].Value != null)
                                    {
                                        dtblPartyBalance.Rows[inTableCount]["Amount"] = dgvPartyBalance.Rows[inI].Cells["dgvtxtAmount"].Value;
                                    }
                                    else
                                        dtblPartyBalance.Rows[inTableCount]["Amount"] = 0;
                                    dtblPartyBalance.Rows[inTableCount]["DebitOrCredit"] = strDebitOrCredit.ToString();
                                    if (dgvPartyBalance.Rows[inI].Cells["dgvtxtPartyBalanceId"].Value != null && dgvPartyBalance.Rows[inI].Cells["dgvtxtPartyBalanceId"].Value.ToString() != string.Empty)
                                    {
                                        dtblPartyBalance.Rows[inTableCount]["PartyBalanceId"] = dgvPartyBalance.Rows[inI].Cells["dgvtxtPartyBalanceId"].Value;
                                    }
                                    else
                                    {
                                        dtblPartyBalance.Rows[inTableCount]["PartyBalanceId"] = "0";
                                    }
                                    inTableCount++;
                                }
                                if (frmPaymentVoucherObj != null)
                                {
                                    frmPaymentVoucherObj.CallFromPartyBalance(this, Convert.ToDecimal(txtTotalAmount.Text.ToString()), dtblPartyBalance, arrlstOfDeletedPartyBalanceRow);
                                }
                                else if (frmJournalVoucherObj != null)
                                {
                                    frmJournalVoucherObj.CallFromPartyBalance(this, Convert.ToDecimal(txtTotalAmount.Text.ToString()), dtblPartyBalance, arrlstOfDeletedPartyBalanceRow);
                                }
                                else if (frmCreditNoteVoucherObj != null)
                                {
                                    frmCreditNoteVoucherObj.CallFromPartyBalance(this, Convert.ToDecimal(txtTotalAmount.Text.ToString()), dtblPartyBalance, arrlstOfDeletedPartyBalanceRow);
                                }
                                else if (frmDebitNoteObj != null)
                                {
                                    frmDebitNoteObj.CallFromPartyBalance(this, Convert.ToDecimal(txtTotalAmount.Text.ToString()), dtblPartyBalance, arrlstOfDeletedPartyBalanceRow);
                                }
                                else if (frmReceiptVoucherObj != null)
                                {
                                    frmReceiptVoucherObj.CallFromPartyBalance(this, Convert.ToDecimal(txtTotalAmount.Text.ToString()), dtblPartyBalance, arrlstOfDeletedPartyBalanceRow);
                                }
                                else if (frmPdcpayableObj != null)
                                {
                                    frmPdcpayableObj.CallFromPartyBalance(this, Convert.ToDecimal(txtTotalAmount.Text.ToString()), dtblPartyBalance, arrlstOfDeletedPartyBalanceRow);
                                }
                                else if (frmPdcReceivableObj != null)
                                {
                                    frmPdcReceivableObj.CallFromPartyBalance(this, Convert.ToDecimal(txtTotalAmount.Text.ToString()), dtblPartyBalance, arrlstOfDeletedPartyBalanceRow);
                                }
                            }
                            else
                            {
                                Messages.InformationMessage("No row to save");
                                dgvPartyBalance.Focus();
                            }
                        }
                        else
                        {
                            dgvPartyBalance.Focus();
                        }
                    }
                    else
                    {
                        Messages.InformationMessage("Can't save without atleat one complete details");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:8" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill currency combo box
        /// </summary>
        public void CurrencyComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                TransactionsGeneralFillBll Obj = new TransactionsGeneralFillBll();
                ListObj = Obj.CurrencyComboByDate(dtmVoucherDate);
                dgvcmbCurrency.DataSource = ListObj[0];
                dgvcmbCurrency.DisplayMember = "currencyName";
                dgvcmbCurrency.ValueMember = "exchangeRateId";
                SettingsBll BllSettings = new SettingsBll();
                if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                {
                    dgvcmbCurrency.ReadOnly = false;
                }
                else
                {
                    dgvcmbCurrency.ReadOnly = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:9" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to check invalid entries
        /// </summary>
        /// <param name="e"></param>
        public void CheckColumnMissing(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPartyBalance.CurrentRow != null && !dgvPartyBalance.CurrentRow.IsNewRow)
                {
                    if (!isValueChanged)
                    {
                        if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString().Trim() == string.Empty)
                        {
                            isValueChanged = true;
                            dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                            dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                        }
                        else if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() == "Against")
                        {
                            if (dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvtxtVoucherNo"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvtxtVoucherNo"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value.ToString().Trim() == string.Empty || Convert.ToDecimal(dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value.ToString())==0)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = string.Empty;
                            }
                        }
                        else if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() == "New")
                        {
                            if (dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value == null || dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value.ToString().Trim() == string.Empty)
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = "X";
                                dgvPartyBalance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                isValueChanged = true;
                                dgvPartyBalance.CurrentRow.HeaderCell.Value = string.Empty;
                            }
                        }
                        else
                        {
                            isValueChanged = true;
                            dgvPartyBalance.CurrentRow.HeaderCell.Value = string.Empty;
                        }
                    }
                    isValueChanged = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:10" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Return from frmAgainstBillDetails form to select voucher type and pending amount
        /// </summary>
        /// <param name="frmAgainstBillDetails"></param>
        /// <param name="strVoucherTypeId"></param>
        public void CallFromAgainstBillDetails(frmAgainstBillDetails frmAgainstBillDetails, string strVoucherTypeId) //PopUp
        {
            try
            {
                base.Show();
                this.frmAgainstBillDetailsObj = frmAgainstBillDetails;
                dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value = strVoucherTypeId;
                frmAgainstBillDetailsObj.Close();
                frmAgainstBillDetailsObj = null;
                CurrencyComboFill();
                dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:11" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmPdcPayable form to set amount for sundry creditors or sundry debtors
        /// </summary>
        /// <param name="frmPDC"></param>
        /// <param name="decId"></param>
        /// <param name="dtblPartyBalance"></param>
        /// <param name="decPdcPayableVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="date"></param>
        public void CallThisFormFromPDCPayable(frmPdcPayable frmPDC, decimal decId, DataTable dtblPartyBalance, decimal decPdcPayableVoucherTypeId, string strVoucherNo, DateTime date)
        {
            try
            {
                decVoucherTypeId = decPdcPayableVoucherTypeId;
                this.strVoucherNo = strVoucherNo;
                decLedgerId = decId;
                this.dtblPartyBalance = dtblPartyBalance;
                strDebitOrCredit = "Dr";
                base.Show();
                this.frmPdcpayableObj = frmPDC;
                frmPdcpayableObj.Enabled = false;
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();
                List<DataTable> listObj = new List<DataTable>();
                if (inTableRowCount > 0)
                {
                    int inK = 0;
                    for (int inI = 0; inI < inTableRowCount; inI++)
                    {
                        if (decLedgerId == Convert.ToDecimal(dtblPartyBalance.Rows[inI]["LedgerId"].ToString()))
                        {
                            if (strDebitOrCredit == dtblPartyBalance.Rows[inI]["DebitOrCredit"].ToString())
                            {
                                dgvPartyBalance.Rows.Add();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value = dtblPartyBalance.Rows[inI]["ReferenceType"].ToString();
                                if (dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    //----------------------------------------------------------------------------//
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].ReadOnly = false;
                                    listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, dgvPartyBalance.CurrentRow.Index - 1];
                                    dgvccVoucherType.DataSource = listObj[0];
                                    dgvccVoucherType.ValueMember = "value";
                                    dgvccVoucherType.DisplayMember = "display";
                                    //============================================================================//
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherTypeId"].ToString() + "_" + dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtVoucherNo"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtInvoiceNo"].Value = dtblPartyBalance.Rows[inI]["AgainstInvoiceNo"].ToString();
                                    if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                    {
                                        for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                                        {
                                            if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                            {
                                                dgvPartyBalance.Rows[inK].Cells["dgvtxtpending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                                break;
                                            }
                                        }
                                    }
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].ReadOnly = true;
                                }
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtAmount"].Value = Math.Round(Convert.ToDecimal(dtblPartyBalance.Rows[inI]["Amount"].ToString()), Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces)).ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(dtblPartyBalance.Rows[inI]["CurrencyId"].ToString());
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtPartyBalanceId"].Value = dtblPartyBalance.Rows[inI]["partyBalanceId"].ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtOldExchangeRateId"].Value = dtblPartyBalance.Rows[inI]["OldExchangeRate"].ToString();
                                inK++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:12" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call frmPdcReceivable form to set amount for sundry creditors or sundry debtors
        /// </summary>
        /// <param name="frmPDCreceivable"></param>
        /// <param name="decId"></param>
        /// <param name="dtblPartyBalance"></param>
        /// <param name="decPdcReceivableVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="date"></param>
        public void CallThisFormFromPDCReceivable(frmPdcReceivable frmPDCreceivable, decimal decId, DataTable dtblPartyBalance, decimal decPdcReceivableVoucherTypeId, string strVoucherNo, DateTime date)
        {
            try
            {
                decVoucherTypeId = decPdcReceivableVoucherTypeId;
                this.strVoucherNo = strVoucherNo;
                decLedgerId = decId;
                // inRowIndex = inIndex;
                this.dtblPartyBalance = dtblPartyBalance;
                strDebitOrCredit = "Cr";
                base.Show();
                this.frmPdcReceivableObj = frmPDCreceivable;
                frmPdcReceivableObj.Enabled = false;
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                PartyBalanceInfo InfoPartyBalance = new PartyBalanceInfo();
                List<DataTable> listObj = new List<DataTable>();
                if (inTableRowCount > 0)
                {
                    int inK = 0;
                    for (int inI = 0; inI < inTableRowCount; inI++)
                    {
                        if (decLedgerId == Convert.ToDecimal(dtblPartyBalance.Rows[inI]["LedgerId"].ToString()))
                        {
                            if (strDebitOrCredit == dtblPartyBalance.Rows[inI]["DebitOrCredit"].ToString())
                            {
                                dgvPartyBalance.Rows.Add();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value = dtblPartyBalance.Rows[inI]["ReferenceType"].ToString();
                                if (dgvPartyBalance.Rows[inK].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    //----------------------------------------------------------------------------//
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].ReadOnly = false;
                                    listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                    DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, dgvPartyBalance.CurrentRow.Index - 1];
                                    dgvccVoucherType.DataSource = listObj[0];
                                    dgvccVoucherType.ValueMember = "value";
                                    dgvccVoucherType.DisplayMember = "display";
                                    //============================================================================//
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherTypeId"].ToString() + "_" + dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtVoucherNo"].Value = dtblPartyBalance.Rows[inI]["AgainstVoucherNo"].ToString();
                                    dgvPartyBalance.Rows[inK].Cells["dgvtxtInvoiceNo"].Value = dtblPartyBalance.Rows[inI]["AgainstInvoiceNo"].ToString();
                                    if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                    {
                                        for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                                        {
                                            if (dgvPartyBalance.Rows[inK].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                            {
                                                dgvPartyBalance.Rows[inK].Cells["dgvtxtpending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);
                                                break;
                                            }
                                        }
                                    }
                                    dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].ReadOnly = true;
                                }
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtAmount"].Value = Math.Round(Convert.ToDecimal(dtblPartyBalance.Rows[inI]["Amount"].ToString()), Convert.ToInt32(PublicVariables._inNoOfDecimalPlaces)).ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(dtblPartyBalance.Rows[inI]["CurrencyId"].ToString());
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtPartyBalanceId"].Value = dtblPartyBalance.Rows[inI]["partyBalanceId"].ToString();
                                dgvPartyBalance.Rows[inK].Cells["dgvtxtOldExchangeRateId"].Value = dtblPartyBalance.Rows[inI]["OldExchangeRate"].ToString();
                                inK++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:13" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to decimal validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void keypressevent(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.DecimalValidation(sender, e, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:14" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
        /// <summary>
        /// On 'Save' button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:15" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fill the corresponding details of party and calculations on cell value changed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (dgvPartyBalance.Rows[e.RowIndex].Cells["dgvcmbCurrency"].Value == null || dgvPartyBalance.Rows[e.RowIndex].Cells["dgvcmbCurrency"].Value.ToString() == string.Empty)
                    {
                        dgvPartyBalance.Rows[e.RowIndex].Cells["dgvcmbCurrency"].Value = Convert.ToDecimal(1);//decExchangeRateId;
                        
                    }
                    if (dgvPartyBalance.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvtxtAmount" || dgvPartyBalance.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbCurrency")
                    {
                        TotalAmount();
                    }
                    //---------------------check column missing---------------------------------//
                    CheckColumnMissing(e);
                    //==========================================================================//
                    if (dgvPartyBalance.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbReference")
                    {
                        if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value != null)//&& dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() != string.Empty)
                        {
                            //to fill combo without filling the already selected value
                            if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() == "Against")
                            {
                                dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].ReadOnly = false;
                                if (frmJournalVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                }
                                else if (frmPaymentVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Dr";
                                }
                                else if (frmReceiptVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Cr";
                                }
                                else if (frmPdcpayableObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Dr";
                                }
                                else if (frmPdcReceivableObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Cr";
                                }
                            }
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() == "New")
                            {
                                dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].ReadOnly = true;
                                dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value = string.Empty;
                                dgvPartyBalance.CurrentRow.Cells["dgvtxtVoucherNo"].Value = null;
                                dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value = null;
                                dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].ReadOnly = false;
                                if (frmJournalVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                }
                                else if (frmPaymentVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Dr";
                                }
                                else if (frmReceiptVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Cr";
                                }
                                else if (frmPdcpayableObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Dr";
                                }
                                else if (frmPdcReceivableObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Cr";
                                }
                            }
                            //
                            else if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() == "OnAccount")
                            {
                                dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].ReadOnly = true;
                                dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value = string.Empty;
                                dgvPartyBalance.CurrentRow.Cells["dgvtxtVoucherNo"].Value = null;
                                dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value = null;
                                dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].ReadOnly = false;
                                if (frmJournalVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = strDebitOrCredit;
                                }
                                else if (frmPaymentVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Dr";
                                }
                                else if (frmReceiptVoucherObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Cr";
                                }
                                else if (frmPdcpayableObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Dr";
                                }
                                else if (frmPdcReceivableObj != null)
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtCrDr"].Value = "Cr";
                                }
                            }
                        }
                    }
                    else if (dgvPartyBalance.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "dgvcmbVoucherType")
                    {
                        if (dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value.ToString().Trim() != string.Empty)
                        {
                            ExchangeRateBll BllExchangeRate = new ExchangeRateBll();
                            ExchangeRateInfo infoExchangeRate = new ExchangeRateInfo();
                            string str = dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value.ToString();
                            string[] words;
                            words = str.Split('_');
                            List<DataTable> listObj = new List<DataTable>();
                            listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                            for (int inD = 0; inD < listObj[0].Rows.Count; inD++)
                            {
                                if (dgvPartyBalance.Rows[e.RowIndex].Cells["dgvcmbVoucherType"].Value.ToString() == listObj[0].Rows[inD]["value"].ToString())
                                {
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtVoucherNo"].Value = listObj[0].Rows[inD]["voucherNo"].ToString();
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value = Math.Round(Convert.ToDecimal(listObj[0].Rows[inD]["balance"].ToString()), PublicVariables._inNoOfDecimalPlaces);

                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtOldExchangeRateId"].Value = listObj[0].Rows[inD]["exchangeRateId"].ToString();
                                    if (Convert.ToDecimal(listObj[0].Rows[inD]["exchangeRateId"].ToString()) != 1m)
                                    {
                                        infoExchangeRate = BllExchangeRate.ExchangeRateView(Convert.ToDecimal(listObj[0].Rows[inD]["exchangeRateId"].ToString()));
                                        decimal decCurrentExchangeRateId = BllExchangeRate.GetExchangeRateId(infoExchangeRate.CurrencyId, dtmVoucherDate);
                                        if (decCurrentExchangeRateId == 0)
                                        {
                                            CurrencyBll BllCurrency = new CurrencyBll();
                                            CurrencyInfo infoCurrency = new CurrencyInfo();
                                            infoCurrency = BllCurrency.CurrencyView(infoExchangeRate.CurrencyId);
                                            dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value = decCurrentExchangeRateId;
                                            
                                            Messages.InformationMessage("Set ExchangeRate for "+infoCurrency.CurrencyName);
                                            
                                        }
                                        else
                                        {
                                            dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value = decCurrentExchangeRateId;
                                        }
                                    }
                                    else
                                    {
                                        dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value = 1m;
                                    }
                                    dgvPartyBalance.CurrentRow.Cells["dgvtxtInvoiceNo"].Value = listObj[0].Rows[inD]["invoiceNo"].ToString();
                                }
                            }
                            dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value = null;
                            dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].ReadOnly = true;
                        }
                        //to make voucherno,pendingamount,invoiceno,currency as null when vouchertype is selected as empty
                        else
                        {
                            dgvPartyBalance.CurrentRow.Cells["dgvtxtVoucherNo"].Value = null;
                            dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value = null;
                            dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value = null;
                            dgvPartyBalance.CurrentRow.Cells["dgvtxtInvoiceNo"].Value = null;
                            dgvPartyBalance.CurrentRow.Cells["dgvcmbCurrency"].Value = null;
                            SettingsBll BllSettings = new SettingsBll();
                            if (BllSettings.SettingsStatusCheck("MultiCurrency") == "Yes")
                            {
                                dgvcmbCurrency.ReadOnly = false;
                            }
                            else
                            {
                                dgvcmbCurrency.ReadOnly = true;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:16" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Serial no automatically generated while adding rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (dgvPartyBalance.Rows.Count != 1)
                {
                    SerialNumberGeneration();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:17" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On 'Remove' link button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to remove current row ?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvPartyBalance.CurrentRow.Cells["dgvtxtSlNo"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvtxtSlNo"].Value.ToString() != string.Empty)
                    {
                        if (Convert.ToInt32(dgvPartyBalance.CurrentRow.Cells["dgvtxtSlNo"].Value.ToString()) < dgvPartyBalance.RowCount)
                        {
                            if (dgvPartyBalance.CurrentRow.Cells["dgvtxtPartyBalanceId"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvtxtPartyBalanceId"].Value.ToString() != string.Empty)
                            {
                                if (dgvPartyBalance.CurrentRow.Cells["dgvtxtPartyBalanceId"].Value.ToString() != "0")
                                {
                                    inRowRemove = arrlstOfDeletedPartyBalanceRow.Count;
                                    arrlstOfDeletedPartyBalanceRow.Add(dgvPartyBalance.CurrentRow.Cells["dgvtxtPartyBalanceId"].Value.ToString());
                                }
                            }
                            dgvPartyBalance.Rows.RemoveAt(dgvPartyBalance.CurrentRow.Index);
                            SerialNumberGeneration();
                            TotalAmount();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:18" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// To restrict the control to accept the particular characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl txt = e.Control as DataGridViewTextBoxEditingControl;
                if (dgvPartyBalance.CurrentCell.ColumnIndex == dgvPartyBalance.Columns["dgvtxtAmount"].Index)
                {
                    txt.KeyPress += keypressevent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:19" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On frmPartyBalance form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPartyBalance_Load(object sender, EventArgs e)
        {
            try
            {
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                CurrencyComboFill();
                dgvcmbReference.Items.AddRange("Against", "New", "OnAccount");
                dgvPartyBalance.Columns["dgvtxtVoucherNo"].ReadOnly = true;
                dgvPartyBalance.Columns["dgvtxtPending"].ReadOnly = true;
                dgvPartyBalance.Columns["dgvtxtCrDr"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:20" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// On handling errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvPartyBalance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvPartyBalance.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:21" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (Messages.CloseConfirmation())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:22" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When the state of a Gridview cell changes in relation to a change in its contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPartyBalance.IsCurrentCellDirty)
                {
                    dgvPartyBalance.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:23" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datagridview cell enter event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPartyBalance.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
                {
                    dgvPartyBalance.EditMode = DataGridViewEditMode.EditOnEnter;
                }
                else
                {
                    dgvPartyBalance.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:24" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Datagridview cell begin edit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                List<DataTable> listObj = new List<DataTable>();
                //DataTable dtbl1 = new DataTable();
                PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                if (dgvPartyBalance.CurrentRow != null)
                {
                    if (dgvPartyBalance.CurrentCell.ColumnIndex == dgvPartyBalance.Columns["dgvcmbVoucherType"].Index)
                    {
                        if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value != null)//|| dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() != string.Empty)
                        {
                            if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() == "Against")
                            {
                                listObj = BllPartyBalance.PartyBalanceComboViewByLedgerId(decLedgerId, strDebitOrCredit, decVoucherTypeId, strVoucherNo);
                                DataRow dr = listObj[0].NewRow();
                                dr[0] = string.Empty;
                                dr[1] = 0;
                                dr[2] = string.Empty;
                                dr[3] = 0;
                                listObj[0].Rows.InsertAt(dr, 0);
                                if (dgvPartyBalance.RowCount > 2)
                                {
                                    int inGridRowCount = dgvPartyBalance.RowCount;
                                    for (int inI = 0; inI < inGridRowCount - 1; inI++)
                                    {
                                        if (inI != e.RowIndex)
                                        {
                                            if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value != null)
                                            {
                                                if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value.ToString() == "Against")
                                                {
                                                    int inTableRowcount = listObj[0].Rows.Count;
                                                    for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                                    {
                                                        if (dgvPartyBalance.Rows[inI].Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.Rows[inI].Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                                                        {
                                                            if (listObj[0].Rows[inJ]["Value"].ToString() == dgvPartyBalance.Rows[inI].Cells["dgvcmbVoucherType"].Value.ToString())
                                                            {
                                                                listObj[0].Rows.RemoveAt(inJ);
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                DataGridViewComboBoxCell dgvccVoucherType = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbVoucherType"].Index, e.RowIndex];
                                dgvccVoucherType.DataSource = listObj[0];
                                dgvccVoucherType.ValueMember = "Value";
                                dgvccVoucherType.DisplayMember = "Display";
                            }
                        }
                    }
                    //To remove new or OnAccount from the reference combo when a new is selected
                    else if (dgvPartyBalance.CurrentCell.ColumnIndex == dgvPartyBalance.Columns["dgvcmbReference"].Index)//to remove new from combobox when new is already selected
                    {
                        if (dgvPartyBalance.RowCount > 1)
                        {
                            int inGridRowCount = dgvPartyBalance.RowCount;
                            for (int inI = 0; inI < inGridRowCount - 1; inI++)
                            {
                                //
                                if (inI != e.RowIndex)
                                {
                                    if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value != null)
                                    {
                                        if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value.ToString() == "New")
                                        {
                                            DataGridViewComboBoxCell dgvccReference = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbReference"].Index, e.RowIndex];
                                            dgvccReference.Items.Remove("New");
                                            break;
                                        }
                                        else
                                        {
                                            DataGridViewComboBoxCell dgvccReference = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbReference"].Index, e.RowIndex];
                                            if (!dgvccReference.Items.Contains("New"))
                                            {
                                                dgvccReference.Items.Add("New");
                                            }
                                        }
                                    }
                                }
                            }
                            //
                            for (int inI = 0; inI < inGridRowCount - 1; inI++)
                            {
                                if (inI != e.RowIndex)
                                {
                                    if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value != null)
                                    {
                                        if (dgvPartyBalance.Rows[inI].Cells["dgvcmbReference"].Value.ToString() == "OnAccount")
                                        {
                                            DataGridViewComboBoxCell dgvccReference = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbReference"].Index, e.RowIndex];
                                            dgvccReference.Items.Remove("OnAccount");
                                            break;
                                        }
                                        else
                                        {
                                            DataGridViewComboBoxCell dgvccReference = (DataGridViewComboBoxCell)dgvPartyBalance[dgvPartyBalance.Columns["dgvcmbReference"].Index, e.RowIndex];
                                            if (!dgvccReference.Items.Contains("OnAccount"))
                                            {
                                                dgvccReference.Items.Add("OnAccount");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:25" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// datagridview cell leave event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!IsSaveOrEsc)
                {
                    PartyBalanceBll BllPartyBalance = new PartyBalanceBll();
                    if (dgvPartyBalance.CurrentCell.ColumnIndex == dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].ColumnIndex)
                    {
                        if (dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value.ToString() != string.Empty)
                        {
                            if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() != string.Empty)
                            {
                                if (dgvPartyBalance.CurrentRow.Cells["dgvcmbReference"].Value.ToString() == "Against")
                                {
                                    if (dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value.ToString() != string.Empty)
                                    {
                                        if (dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value.ToString() != string.Empty)
                                        {
                                            if (Convert.ToDecimal(dgvPartyBalance.CurrentRow.Cells["dgvtxtPending"].Value.ToString()) < Convert.ToDecimal(dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value.ToString()))
                                            {
                                                Messages.InformationMessage("Amount should be less than pending amount");
                                                dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value = null;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    decimal decAmountToCheck = Math.Round(BllPartyBalance.PartyBalanceAmountCheckForEdit(decLedgerId, decVoucherTypeId, strVoucherNo, strDebitOrCredit), PublicVariables._inNoOfDecimalPlaces);
                                    if (decAmountToCheck > Convert.ToDecimal(dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value.ToString()))
                                    {
                                        Messages.InformationMessage("Reference Exist. You cannot enter less than " + decAmountToCheck.ToString());
                                        dgvPartyBalance.CurrentRow.Cells["dgvtxtAmount"].Value = null;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:26" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region navigation
        /// <summary>
        /// key navigation for datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPartyBalance_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvPartyBalance.CurrentCell == dgvPartyBalance.Rows[dgvPartyBalance.Rows.Count - 1].Cells["dgvtxtCrDr"])
                    {
                        btnSave.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:27" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// key navigation for 'Save' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    dgvPartyBalance.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:28" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// key navigation for frmPartyBalance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPartyBalance_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgvPartyBalance.CurrentRow != null)
                {
                    if (dgvPartyBalance.CurrentCell.ColumnIndex == dgvPartyBalance.Columns["dgvcmbVoucherType"].Index)
                    {
                        if (dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value != null && dgvPartyBalance.CurrentRow.Cells["dgvcmbVoucherType"].Value.ToString() != string.Empty)
                        {
                            if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Control) //Pop Up
                            {
                                frmAgainstBillDetails frmAgainstBillDetailsObj = new frmAgainstBillDetails();
                                frmAgainstBillDetailsObj.MdiParent = formMDI.MDIObj;
                                frmAgainstBillDetailsObj.CallFromPartyBalance(this, decLedgerId, strDebitOrCredit);
                            }
                        }
                    }
                }
                if (e.KeyCode == Keys.Escape)
                {
                    if (PublicVariables.isMessageClose)
                    {
                        IsSaveOrEsc = true;
                        Messages.CloseMessage(this);
                        IsSaveOrEsc = false;
                    }
                    else
                    {
                        IsSaveOrEsc = true;
                        Messages.CloseMessage(this);
                        IsSaveOrEsc = false;
                    }
                }
                if (e.KeyCode == Keys.S && Control.ModifierKeys == Keys.Control)
                {
                    btnSave.Focus();
                    dgvPartyBalance.Focus();
                    Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:29" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enables the object of other forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPartyBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmPaymentVoucherObj != null)
                {
                    frmPaymentVoucherObj.Enabled = true;
                    frmPaymentVoucherObj.BringToFront();
                }
                else if (frmReceiptVoucherObj != null)
                {
                    frmReceiptVoucherObj.Enabled = true;
                    frmReceiptVoucherObj.BringToFront();
                }
                else if (frmJournalVoucherObj != null)
                {
                    frmJournalVoucherObj.Enabled = true;
                    frmJournalVoucherObj.BringToFront();
                }
                else if (frmCreditNoteVoucherObj != null)
                {
                    frmCreditNoteVoucherObj.Enabled = true;
                    frmCreditNoteVoucherObj.BringToFront();
                }
                else if (frmDebitNoteObj != null)
                {
                    frmDebitNoteObj.Enabled = true;
                    frmDebitNoteObj.BringToFront();
                }
                else if (frmPdcpayableObj != null)
                {
                    frmPdcpayableObj.Enabled = true;
                    frmPdcpayableObj.BringToFront();
                }
                else if (frmPdcReceivableObj != null)
                {
                    frmPdcReceivableObj.Enabled = true;
                    frmPdcReceivableObj.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB:30" + ex.Message, "Open Miracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
