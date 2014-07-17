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
    public partial class frmVoucherTypeSelection : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        public string VoucherType = string.Empty;

        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmVoucherTypeSelection class
        /// </summary>
        public frmVoucherTypeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to check the voucher type and fill the corresponding vouchertype in VoucherType combobox
        /// </summary>
        /// <param name="strVoucherType"></param>
        public void CallFromVoucherMenu(string strVoucherType)
        {
            try
            {
                if (formMDI.strVouchertype == "POS")
                {
                    VoucherType = "POS";
                }
                else
                    VoucherType = strVoucherType;
                VoucherTypeBll BllVoucherType = new VoucherTypeBll();
                List<DataTable> listObjVouchetType = new List<DataTable>();
                listObjVouchetType = BllVoucherType.VoucherTypeSelectionComboFill(strVoucherType);
                int inCount = listObjVouchetType[0].Rows.Count;
                cmbVoucherType.DataSource = listObjVouchetType[0];
                cmbVoucherType.ValueMember = "voucherTypeId";
                cmbVoucherType.DisplayMember = "voucherTypeName";
                cmbVoucherType.SelectedIndex = -1;
                if (inCount == 1)
                {
                    cmbVoucherType.SelectedValue = listObjVouchetType[0].Rows[0].ItemArray[0].ToString();
                    btnGo_Click(btnGo, EventArgs.Empty);
                }
                else
                {
                    base.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VTS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Opens the corresponding Vouchers based on voucher type on Go button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVoucherType.SelectedIndex != -1)
                {
                    switch (VoucherType)
                    {
                        case "Monthly Salary Voucher":
                            decimal decVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strVoucherTypeName = cmbVoucherType.Text;
                            frmMonthlySalaryVoucher frm = new frmMonthlySalaryVoucher();
                            frmMonthlySalaryVoucher open = Application.OpenForms["frmMonthlySalaryVoucher"] as frmMonthlySalaryVoucher;
                            if (open == null)
                            {
                                frm.MdiParent = this.MdiParent;
                                frm.CallFromVoucherTypeSelection(decVoucherTypeId, strVoucherTypeName);
                            }
                            else
                            {
                                open.CallFromVoucherTypeSelection(decVoucherTypeId, strVoucherTypeName);
                            }

                            this.Close();
                            break;
                        case "Advance Payment":
                            decimal decVoucherTypeNo = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strVoucherTypeNames = cmbVoucherType.Text;

                            frmAdvancePayment abc = new frmAdvancePayment();
                            frmAdvancePayment opens = Application.OpenForms["frmAdvancePayment"] as frmAdvancePayment;
                            if (opens == null)
                            {
                                abc.MdiParent = this.MdiParent;
                                abc.CallFromVoucherTypeSelection(decVoucherTypeNo, strVoucherTypeNames);
                            }
                            else
                            {
                                opens.CallFromVoucherTypeSelection(decVoucherTypeNo, strVoucherTypeNames);
                            }



                            this.Close();
                            break;
                        case "Daily Salary Voucher":
                            decimal decDailyVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strDailySalaryVoucherTypeName = cmbVoucherType.Text.ToString();
                            frmDailySalaryVoucher frmobj = new frmDailySalaryVoucher();
                            frmDailySalaryVoucher DailyOpen = Application.OpenForms["frmDailySalaryVoucher"] as frmDailySalaryVoucher;
                            if (DailyOpen == null)
                            {
                                frmobj.MdiParent = this.MdiParent;
                                frmobj.CallFromVoucherTypeSelection(decDailyVoucherTypeId, strDailySalaryVoucherTypeName);
                            }
                            else
                            {
                                DailyOpen.CallFromVoucherTypeSelection(decDailyVoucherTypeId, strDailySalaryVoucherTypeName);
                            }

                            this.Close();
                            break;
                        case "Payment Voucher":
                            decimal decPaymentVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                            string strVoucherTypeNames2 = cmbVoucherType.Text.ToString();
                            frmPaymentVoucher frmPaymentObj = new frmPaymentVoucher();
                            frmPaymentVoucher PaymentOpen = Application.OpenForms["frmPaymentVoucher"] as frmPaymentVoucher;
                            if (PaymentOpen == null)
                            {
                                frmPaymentObj.MdiParent = this.MdiParent;
                                frmPaymentObj.CallFromVoucherTypeSelection(decPaymentVoucherTypeId, strVoucherTypeNames2);
                            }
                            else
                            {
                                PaymentOpen.CallFromVoucherTypeSelection(decPaymentVoucherTypeId, strVoucherTypeNames2);
                            }

                            this.Close();
                            break;
                        case "Contra Voucher":
                            decimal decContraVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strVoucherTypeNames3 = cmbVoucherType.Text.ToString();
                            frmContraVoucher frmcontraObj = new frmContraVoucher();
                            frmContraVoucher ContraOpen = Application.OpenForms["frmContraVoucher"] as frmContraVoucher;
                            if (ContraOpen == null)
                            {
                                frmcontraObj.MdiParent = this.MdiParent;
                                frmcontraObj.CallFromVoucherTypeSelection(decContraVoucherTypeId, strVoucherTypeNames3);
                            }
                            else
                            {
                                ContraOpen.CallFromVoucherTypeSelection(decContraVoucherTypeId, strVoucherTypeNames3);
                            }

                            this.Close();
                            break;
                        case "Journal Voucher":
                            decimal decJournalVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strVoucherTypeNames4 = cmbVoucherType.Text.ToString();
                            frmJournalVoucher frmJournalObj = new frmJournalVoucher();
                            frmJournalVoucher JournalOpen = Application.OpenForms["frmJournalVoucher"] as frmJournalVoucher;
                            if (JournalOpen == null)
                            {
                                frmJournalObj.MdiParent = this.MdiParent;
                                frmJournalObj.CallFromVoucherTypeSelection(decJournalVoucherTypeId, strVoucherTypeNames4);
                            }
                            else
                            {
                                JournalOpen.CallFromVoucherTypeSelection(decJournalVoucherTypeId, strVoucherTypeNames4);
                            }

                            this.Close();
                            break;

                        case "Credit Note":

                            decimal decCreditNoteVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strCreditNoteVoucherTypeName = cmbVoucherType.Text.ToString();
                            frmCreditNote frmCreditNoteObj = new frmCreditNote();
                            frmCreditNote CreditNoteOpen = Application.OpenForms["frmCreditNote"] as frmCreditNote;
                            if (CreditNoteOpen == null)
                            {
                                frmCreditNoteObj.MdiParent = this.MdiParent;
                                frmCreditNoteObj.CallFromVoucherTypeSelection(decCreditNoteVoucherTypeId, strCreditNoteVoucherTypeName);
                            }
                            else
                            {
                                CreditNoteOpen.CallFromVoucherTypeSelection(decCreditNoteVoucherTypeId, strCreditNoteVoucherTypeName);
                            }

                            this.Close();
                            break;

                        case "Receipt Voucher":
                            decimal decReceiptVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strReceiptVoucherTypeName = cmbVoucherType.Text.ToString();
                            frmReceiptVoucher frmReceiptObj = new frmReceiptVoucher();
                            frmReceiptVoucher ReceiptOpen = Application.OpenForms["frmReceiptVoucher"] as frmReceiptVoucher;
                            if (ReceiptOpen == null)
                            {
                                frmReceiptObj.MdiParent = this.MdiParent;
                                frmReceiptObj.CallFromVoucherTypeSelection(decReceiptVoucherTypeId, strReceiptVoucherTypeName);
                            }
                            else
                            {
                                ReceiptOpen.CallFromVoucherTypeSelection(decReceiptVoucherTypeId, strReceiptVoucherTypeName);
                            }

                            this.Close();
                            break;

                        case "Service Voucher":
                            decimal decServiceVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strServiceVoucherTypeName = cmbVoucherType.Text.ToString();
                            frmServiceVoucher frmServiceVoucherObj = new frmServiceVoucher();
                            frmServiceVoucher ServiceVoucherOpen = Application.OpenForms["frmServiceVoucher"] as frmServiceVoucher;
                            if (ServiceVoucherOpen == null)
                            {
                                frmServiceVoucherObj.MdiParent = this.MdiParent;
                                frmServiceVoucherObj.CallFromVoucherTypeSelection(decServiceVoucherTypeId, strServiceVoucherTypeName);
                            }
                            else
                            {
                                ServiceVoucherOpen.CallFromVoucherTypeSelection(decServiceVoucherTypeId, strServiceVoucherTypeName);
                            }

                            this.Close();
                            break;
                        case "Purchase Order":
                            decimal decPurchaseOrderTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strPurchaseOrderTypeName = cmbVoucherType.Text.ToString();
                            frmPurchaseOrder frmPurchaseOrderObj = new frmPurchaseOrder();
                            frmPurchaseOrder OpenPurchaseOrder = Application.OpenForms["frmPurchaseOrder"] as frmPurchaseOrder;
                            if (OpenPurchaseOrder == null)
                            {
                                frmPurchaseOrderObj.MdiParent = this.MdiParent;
                                frmPurchaseOrderObj.CallFromVoucherTypeSelection(decPurchaseOrderTypeId, strPurchaseOrderTypeName);
                            }
                            else
                            {
                                OpenPurchaseOrder.CallFromVoucherTypeSelection(decPurchaseOrderTypeId, strPurchaseOrderTypeName);
                            }
                            this.Close();
                            break;
                        case "Debit Note":
                            decimal decDebitNoteVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strDebitNoteVoucherTypeName = cmbVoucherType.Text.ToString();
                            frmDebitNote frmDebitNoteObj = new frmDebitNote();
                            frmDebitNote DebitNoteOpen = Application.OpenForms["frmDebitNote"] as frmDebitNote;
                            if (DebitNoteOpen == null)
                            {
                                frmDebitNoteObj.MdiParent = this.MdiParent;
                                frmDebitNoteObj.CallFromVoucherTypeSelection(decDebitNoteVoucherTypeId, strDebitNoteVoucherTypeName);
                            }
                            else
                            {
                                DebitNoteOpen.CallFromVoucherTypeSelection(decDebitNoteVoucherTypeId, strDebitNoteVoucherTypeName);
                            }

                            this.Close();
                            break;

                        case "Sales Return":
                            decimal decSalesReturnVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strSalesReturnVoucheTypeName = cmbVoucherType.Text;
                            frmSalesReturn frmSalesReturnObj = new frmSalesReturn();
                            frmSalesReturn SalesReturnOpen = Application.OpenForms["frmSalesReturn"] as frmSalesReturn;
                            if (SalesReturnOpen == null)
                            {
                                frmSalesReturnObj.MdiParent = this.MdiParent;
                                frmSalesReturnObj.CallFromVoucherTypeSelection(decSalesReturnVoucherTypeId, strSalesReturnVoucheTypeName);
                            }
                            else
                            {
                                SalesReturnOpen.CallFromVoucherTypeSelection(decSalesReturnVoucherTypeId, strSalesReturnVoucheTypeName);
                            }

                            this.Close();
                            break;

                        case "Material Receipt":
                            decimal decMaterialReceiptVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strMaterialReceiptVoucheTypeName = cmbVoucherType.Text;

                            frmMaterialReceipt frmMaterialReceiptObj = new frmMaterialReceipt();
                            frmMaterialReceipt MaterialReceiptOpen = Application.OpenForms["frmMaterialReceipt"] as frmMaterialReceipt;
                            if (MaterialReceiptOpen == null)
                            {
                                frmMaterialReceiptObj.MdiParent = this.MdiParent;
                                frmMaterialReceiptObj.CallFromVoucherTypeSelection(decMaterialReceiptVoucherTypeId, strMaterialReceiptVoucheTypeName);
                            }
                            else
                            {
                                MaterialReceiptOpen.CallFromVoucherTypeSelection(decMaterialReceiptVoucherTypeId, strMaterialReceiptVoucheTypeName);
                            }



                            this.Close();
                            break;

                        case "Sales Order":
                            decimal decSalesOrderTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strSalesOrderVoucherTypeName = cmbVoucherType.Text;

                            frmSalesOrder frmSalesOrderObj = new frmSalesOrder();
                            frmSalesOrder SalesOrderOpen = Application.OpenForms["frmSalesOrder"] as frmSalesOrder;
                            if (SalesOrderOpen == null)
                            {
                                frmSalesOrderObj.MdiParent = this.MdiParent;
                                frmSalesOrderObj.CallFromVoucherTypeSelection(decSalesOrderTypeId, strSalesOrderVoucherTypeName);
                            }
                            else
                            {
                                SalesOrderOpen.CallFromVoucherTypeSelection(decSalesOrderTypeId, strSalesOrderVoucherTypeName);
                            }



                            this.Close();
                            break;

                        case "Rejection Out":
                            decimal decRejectionOutVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strRejectionOutVoucherTypeName = cmbVoucherType.Text.ToString();
                            frmRejectionOut frmRejectionOutObj = new frmRejectionOut();
                            frmRejectionOut RejectionOutOpen = Application.OpenForms["frmRejectionOut"] as frmRejectionOut;
                            if (RejectionOutOpen == null)
                            {
                                frmRejectionOutObj.MdiParent = this.MdiParent;
                                frmRejectionOutObj.CallFromVoucherTypeSelection(decRejectionOutVoucherTypeId, strRejectionOutVoucherTypeName);
                            }
                            else
                            {
                                RejectionOutOpen.CallFromVoucherTypeSelection(decRejectionOutVoucherTypeId, strRejectionOutVoucherTypeName);
                            }

                            this.Close();
                            break;

                        case "Rejection In":
                            decimal decRejectionInVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strRejectionInVoucherTypeName = cmbVoucherType.Text.ToString();
                            frmRejectionIn frmRejectionInObj = new frmRejectionIn();
                            frmRejectionIn RejectionInOpen = Application.OpenForms["frmRejectionIn"] as frmRejectionIn;
                            if (RejectionInOpen == null)
                            {
                                frmRejectionInObj.MdiParent = this.MdiParent;
                                frmRejectionInObj.CallFromVoucherTypeSelection(decRejectionInVoucherTypeId, strRejectionInVoucherTypeName);
                            }
                            else
                            {
                                RejectionInOpen.CallFromVoucherTypeSelection(decRejectionInVoucherTypeId, strRejectionInVoucherTypeName);
                            }

                            this.Close();
                            break;

                        case "Sales Quotation":
                            decimal decsalesQuotationTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strSalesQuotationName = cmbVoucherType.Text.ToString();
                            frmSalesQuotation frmsalesQuotationObj = new frmSalesQuotation();
                            frmSalesQuotation frmsalesQuotationOpen = Application.OpenForms["frmSalesQuotation"] as frmSalesQuotation;
                            if (frmsalesQuotationOpen == null)
                            {
                                frmsalesQuotationObj.MdiParent = this.MdiParent;
                                frmsalesQuotationObj.CallFromVoucherTypeSelection(decsalesQuotationTypeId, strSalesQuotationName);
                            }
                            else
                            {
                                frmsalesQuotationOpen.CallFromVoucherTypeSelection(decsalesQuotationTypeId, strSalesQuotationName);

                            }
                            this.Close();
                            break;

                        case "PDC Payable":
                            decimal decPDCpayableVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strPDCpayableVoucheTypeName = cmbVoucherType.Text.ToString();
                            frmPdcPayable frmPDCPayableOBj = new frmPdcPayable();
                            frmPdcPayable frmPDCPayableOpen = Application.OpenForms["frmPdcPayable"] as frmPdcPayable;

                            if (frmPDCPayableOpen == null)
                            {

                                frmPDCPayableOBj.MdiParent = this.MdiParent;
                                frmPDCPayableOBj.CallFromVoucherTypeSelection(decPDCpayableVoucherTypeId, strPDCpayableVoucheTypeName);
                            }
                            else
                            {
                                frmPDCPayableOpen.CallFromVoucherTypeSelection(decPDCpayableVoucherTypeId, strPDCpayableVoucheTypeName);
                            }

                            this.Close();
                            break;


                        case "Sales Invoice":
                            decimal decSalesInvoiceVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strSalesInvoiceVoucheTypeName = cmbVoucherType.Text.ToString();
                            frmSalesInvoice frmSalesInvoiceOBj = new frmSalesInvoice();
                            frmSalesInvoice frmSalesInvoiceOpen = Application.OpenForms["frmSalesInvoice"] as frmSalesInvoice;

                            if (frmSalesInvoiceOpen == null)
                            {

                                frmSalesInvoiceOBj.MdiParent = this.MdiParent;
                                frmSalesInvoiceOBj.CallFromVoucherTypeSelection(decSalesInvoiceVoucherTypeId, strSalesInvoiceVoucheTypeName);
                            }
                            else
                            {
                                frmSalesInvoiceOpen.CallFromVoucherTypeSelection(decSalesInvoiceVoucherTypeId, strSalesInvoiceVoucheTypeName);
                            }

                            this.Close();
                            break;


                        case "Purchase Invoice":
                            decimal decPurchaseInvoiceVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strPurchaseInvoiceVoucheTypeName = cmbVoucherType.Text.ToString();
                            frmPurchaseInvoice frmPurchaseInvoiceOBj = new frmPurchaseInvoice();
                            frmPurchaseInvoice frmPurchaseInvoiceOpen = Application.OpenForms["frmPurchaseInvoice"] as frmPurchaseInvoice;

                            if (frmPurchaseInvoiceOpen == null)
                            {

                                frmPurchaseInvoiceOBj.MdiParent = this.MdiParent;
                                frmPurchaseInvoiceOBj.CallFromVoucherTypeSelection(decPurchaseInvoiceVoucherTypeId, strPurchaseInvoiceVoucheTypeName);
                            }
                            else
                            {
                                frmPurchaseInvoiceOpen.CallFromVoucherTypeSelection(decPurchaseInvoiceVoucherTypeId, strPurchaseInvoiceVoucheTypeName);
                            }

                            this.Close();
                            break;

                        case "Delivery Note":
                            decimal decDeliveryVoucherTypeNo = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strDeliveryVoucherTypeNames = cmbVoucherType.Text;

                            frmDeliveryNote DeliveryNote = new frmDeliveryNote();
                            frmDeliveryNote openDeliveryNote = Application.OpenForms["frmDeliveryNote"] as frmDeliveryNote;
                            if (openDeliveryNote == null)
                            {
                                DeliveryNote.MdiParent = this.MdiParent;
                                DeliveryNote.CallFromVoucherTypeSelection(decDeliveryVoucherTypeNo, strDeliveryVoucherTypeNames);
                            }
                            else
                            {
                                openDeliveryNote.CallFromVoucherTypeSelection(decDeliveryVoucherTypeNo, strDeliveryVoucherTypeNames);
                            }



                            this.Close();
                            break;

                        case "Purchase Return":
                            decimal decPurchaseReturnVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strPurchaseReturnVoucherTypeNames = cmbVoucherType.Text.ToString();

                            frmPurchaseReturn frmPurchase = new frmPurchaseReturn();
                            frmPurchaseReturn FrmPurchaseOpens = Application.OpenForms["frmPurchaseReturn"] as frmPurchaseReturn;
                            if (FrmPurchaseOpens == null)
                            {
                                frmPurchase.MdiParent = this.MdiParent;
                                frmPurchase.CallFromVoucherTypeSelection(decPurchaseReturnVoucherTypeId, strPurchaseReturnVoucherTypeNames);
                            }
                            else
                            {
                                FrmPurchaseOpens.CallFromVoucherTypeSelection(decPurchaseReturnVoucherTypeId, strPurchaseReturnVoucherTypeNames);
                            }
                            this.Close();
                            break;

                        case "POS":
                            decimal decPOSVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());

                            string strPOSVoucheTypeName = "POS";
                            frmPOS frmPOSOBj = new frmPOS();
                            frmPOS frmPOSOpen = Application.OpenForms["frmPOS"] as frmPOS;

                            if (frmPOSOpen == null)
                            {

                                frmPOSOBj.MdiParent = this.MdiParent;
                                frmPOSOBj.CallFromVoucherTypeSelection(decPOSVoucherTypeId, strPOSVoucheTypeName);
                            }
                            else
                            {
                                frmPOSOpen.CallFromVoucherTypeSelection(decPOSVoucherTypeId, strPOSVoucheTypeName);
                            }

                            this.Close();

                            break;

                        case "Physical Stock":
                            decimal DecPhysicalStockVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strPhysicalStockVocherTypeNames = cmbVoucherType.Text;
                            frmPhysicalStock frmPhysicalStock = new frmPhysicalStock();
                            frmPhysicalStock frmPhysicalStockOpen = Application.OpenForms["frmPhysicalStock"] as frmPhysicalStock;
                            if (frmPhysicalStockOpen == null)
                            {
                                frmPhysicalStock.MdiParent = this.MdiParent;
                                frmPhysicalStock.CallFromVoucherTypeSelection(DecPhysicalStockVoucherTypeId, strPhysicalStockVocherTypeNames);
                            }
                            else
                            {
                                frmPhysicalStockOpen.CallFromVoucherTypeSelection(DecPhysicalStockVoucherTypeId, strPhysicalStockVocherTypeNames);
                            }
                            this.Close();
                            break;

                        case "PDC Receivable":
                            decimal decPDCReceivableVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strPDCReceivableVoucheTypeName = cmbVoucherType.Text.ToString();
                            frmPdcReceivable frmpdreceivableObj = new frmPdcReceivable();

                            frmPdcReceivable frmPDCReceivableOpen = Application.OpenForms["frmPdcReceivable"] as frmPdcReceivable;

                            if (frmPDCReceivableOpen == null)
                            {

                                frmpdreceivableObj.MdiParent = this.MdiParent;
                                frmpdreceivableObj.CallFromVoucherTypeSelection(decPDCReceivableVoucherTypeId, strPDCReceivableVoucheTypeName);
                            }
                            else
                            {
                                frmPDCReceivableOpen.CallFromVoucherTypeSelection(decPDCReceivableVoucherTypeId, strPDCReceivableVoucheTypeName);
                            }

                            this.Close();
                            break;

                        case "Stock Journal":
                            decimal decStockJournalVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strSockJournalVocherTypeName = cmbVoucherType.Text;
                            frmStockJournal frmStockJournalObj = new frmStockJournal();
                            frmStockJournal frmStockJournalOpen = Application.OpenForms["frmStockJournal"] as frmStockJournal;
                            if (frmStockJournalOpen == null)
                            {
                                frmStockJournalObj.MdiParent = this.MdiParent;
                                frmStockJournalObj.CallFromVoucherTypeSelection(decStockJournalVoucherTypeId, strSockJournalVocherTypeName);
                            }
                            else
                            {
                                frmStockJournalOpen.CallFromVoucherTypeSelection(decStockJournalVoucherTypeId, strSockJournalVocherTypeName);
                            }
                            this.Close();
                            break;

                        case "PDC Clearance":
                            decimal decPDCClearanceVoucherTypeId = decimal.Parse(cmbVoucherType.SelectedValue.ToString());
                            string strPDCClearanceVoucheTypeName = cmbVoucherType.Text.ToString();
                            frmPdcClearance frmpdcClearanceObj = new frmPdcClearance();
                            frmPdcClearance frmpdcclearanceOpen = Application.OpenForms["frmPdcClearance"] as frmPdcClearance;

                            if (frmpdcclearanceOpen == null)
                            {

                                frmpdcClearanceObj.MdiParent = this.MdiParent;
                                frmpdcClearanceObj.CallFromVoucherTypeSelection(decPDCClearanceVoucherTypeId, strPDCClearanceVoucheTypeName);
                            }
                            else
                            {
                                frmpdcclearanceOpen.CallFromVoucherTypeSelection(decPDCClearanceVoucherTypeId, strPDCClearanceVoucheTypeName);
                            }

                            this.Close();
                            break;
                    }
                }
                else
                {
                    Messages.InformationMessage("Select voucher type");
                    cmbVoucherType.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("VTS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Closes form on Cancel button  click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VTS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVoucherTypeSelection_Load(object sender, EventArgs e)
        {
            try
            {
                cmbVoucherType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VTS4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbVoucherType.SelectedIndex != -1)
                    {
                        btnGo.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("VTS5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// back space navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbVoucherType.SelectedIndex != -1)
                    {
                        cmbVoucherType.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("VTS6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVoucherTypeSelection_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("VTS7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


    }
}
