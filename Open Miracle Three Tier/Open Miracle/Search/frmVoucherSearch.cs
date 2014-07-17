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
    public partial class frmVoucherSearch : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration Part
        /// </summary>
        TransactionsGeneralFillBll transactionGeneralFillObj = new TransactionsGeneralFillBll();
        string strVoucherTypeText = string.Empty;
        string strInvoiceNo = string.Empty;
        decimal decLedgerId = 0;
        decimal decEmployeeId = 0;
        decimal decVoucherTypeId = 0;
        int inCurrenRowIndex = 0;
        VoucherTypeBll BllVoucherType = new VoucherTypeBll();   
        #endregion
        #region Functions
        /// <summary>
        /// Crerate an Instance for frmVoucherSearch
        /// </summary>
        public frmVoucherSearch()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Function to fill AccountLedger Combobox
        /// </summary>
        public void AccountLedgerComboFill()
        {
            try
            {
                List<DataTable> ListObj = new List<DataTable>();
                ListObj = transactionGeneralFillObj.AccountLedgerComboFill();
                cmbAccountLedger.DataSource = ListObj[0];
                cmbAccountLedger.ValueMember = "ledgerId";
                cmbAccountLedger.DisplayMember = "ledgerName";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill voucherType Combobox
        /// </summary>
        public void voucherTypeComboFill()
        {
            try
            {
                BllVoucherType.voucherTypeComboFill(cmbVoucherType, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoPurchaseOrder()
        {
            try
            {
                frmPurchaseOrder objfrmPurchaseOrder = new frmPurchaseOrder();
                frmPurchaseOrder open = Application.OpenForms["frmPurchaseOrder"] as frmPurchaseOrder;
                if (open == null)
                {
                    objfrmPurchaseOrder.WindowState = FormWindowState.Normal;
                    objfrmPurchaseOrder.MdiParent = formMDI.MDIObj;
                    objfrmPurchaseOrder.Show();
                    objfrmPurchaseOrder.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoStockJournal()
        {
            try
            {
               
                frmStockJournal objfrmstockJournal = new frmStockJournal();
                frmStockJournal open = Application.OpenForms["frmStockJournal"] as frmStockJournal;
               
                if (open == null)
                {
                    objfrmstockJournal.WindowState = FormWindowState.Normal;
                    objfrmstockJournal.MdiParent = formMDI.MDIObj;
                    objfrmstockJournal.Show();
                    objfrmstockJournal.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoSalesQuotation()
        {
            try
            {
                frmSalesQuotation objfrmSalesQuotation = new frmSalesQuotation();
                frmSalesQuotation open = Application.OpenForms["frmSalesQuotation"] as frmSalesQuotation;
                if (open == null)
                {
                    objfrmSalesQuotation.WindowState = FormWindowState.Normal;
                    objfrmSalesQuotation.MdiParent = formMDI.MDIObj;
                    objfrmSalesQuotation.Show();
                    objfrmSalesQuotation.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoSalesOrder()
        {
            try
            {
                frmSalesOrder objfrmSalesOrder = new frmSalesOrder();
                frmSalesOrder open = Application.OpenForms["frmSalesOrder"] as frmSalesOrder;
                if (open == null)
                {
                    objfrmSalesOrder.WindowState = FormWindowState.Normal;
                    objfrmSalesOrder.MdiParent = formMDI.MDIObj;
                    objfrmSalesOrder.Show();
                    objfrmSalesOrder.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoMaterialReceipt()
        {
            try
            {
                frmMaterialReceipt objfrmMaterialReceipt = new frmMaterialReceipt();
                frmMaterialReceipt open = Application.OpenForms["frmMaterialReceipt"] as frmMaterialReceipt;
                if (open == null)
                {
                    objfrmMaterialReceipt.WindowState = FormWindowState.Normal;
                    objfrmMaterialReceipt.MdiParent = formMDI.MDIObj;
                    objfrmMaterialReceipt.Show();
                    objfrmMaterialReceipt.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoContraVoucher()
        {
            try
            {
                frmContraVoucher frmContra = new frmContraVoucher();
                frmContraVoucher _isOpen = Application.OpenForms["frmContraVoucher"] as frmContraVoucher;
                if (_isOpen == null)
                {
                    frmContra.WindowState = FormWindowState.Normal;
                    frmContra.MdiParent = formMDI.MDIObj;
                    frmContra.Show();
                    frmContra.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoJournalVoucher()
        {
            try
            {
                frmJournalVoucher frmobj = new frmJournalVoucher();
                frmJournalVoucher _isOpen = Application.OpenForms["frmJournalVoucher"] as frmJournalVoucher;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                    frmobj.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoCrditNote()
        {
            try
            {
                frmCreditNote frmobj = new frmCreditNote();
                frmCreditNote _isOpen = Application.OpenForms["frmCreditNote"] as frmCreditNote;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                    frmobj.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj; 
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoDebitNote()
        {
            try
            {
                frmDebitNote frmobj = new frmDebitNote();
                frmDebitNote _isOpen = Application.OpenForms["frmDebitNote"] as frmDebitNote;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                    frmobj.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoAdvancePayment()
        {
            try
            {
                frmAdvancePayment frmobj = new frmAdvancePayment();
                frmAdvancePayment _isOpen = Application.OpenForms["frmAdvancepayment"] as frmAdvancePayment;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                    frmobj.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoDailySalaryVoucher()
        {
            try
            {
                frmDailySalaryVoucher frmobj = new frmDailySalaryVoucher();
                frmDailySalaryVoucher _isOpen = Application.OpenForms["frmDebitNote"] as frmDailySalaryVoucher;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                    frmobj.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
       /// </summary>
        public void GotoPaymentVoucher()
        {
            try
            {
                frmPaymentVoucher frmpayment = new frmPaymentVoucher();
                frmPaymentVoucher _isOpen = Application.OpenForms["frmPayment"] as frmPaymentVoucher;
                if (_isOpen == null)
                {
                    frmpayment.WindowState = FormWindowState.Normal;
                    frmpayment.MdiParent = formMDI.MDIObj;
                    frmpayment.Show();
                    frmpayment.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoReceiptVoucher()
        {
            try
            {
                frmReceiptVoucher frmreceipt = new frmReceiptVoucher();
                frmReceiptVoucher _isOpen = Application.OpenForms["frmReceipt"] as frmReceiptVoucher;
                if (_isOpen == null)
                {
                    frmreceipt.WindowState = FormWindowState.Normal;
                    frmreceipt.MdiParent = formMDI.MDIObj;
                    frmreceipt.Show();
                    frmreceipt.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoPDCPayable()
        {
            try
            {
                frmPdcPayable frmobj = new frmPdcPayable();
                frmPdcPayable _isOpen = Application.OpenForms["frmPDCPayable"] as frmPdcPayable;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                    frmobj.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.ClearFunction();
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoPDCReceivable()
        {
            try
            {
                frmPdcReceivable frmobj = new frmPdcReceivable();
                frmPdcReceivable _isOpen = Application.OpenForms["frmPDCReceivable"] as frmPdcReceivable;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                    frmobj.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.ClearFunction();
                    _isOpen.CallThisFormFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoPDCClearance()
        {
            try
            {
                frmPdcClearance frmobj = new frmPdcClearance();
                frmPdcClearance _isOpen = Application.OpenForms["frmPDClearance"] as frmPdcClearance;
                if (_isOpen == null)
                {
                    frmobj.WindowState = FormWindowState.Normal;
                    frmobj.MdiParent = formMDI.MDIObj;
                    frmobj.Show();
                     frmobj.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    _isOpen.MdiParent = formMDI.MDIObj;
                    if (_isOpen.WindowState == FormWindowState.Minimized)
                    {
                        _isOpen.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        _isOpen.Activate();
                    }
                    _isOpen.ClearFunction();
                    _isOpen.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    _isOpen.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoPhysicalStock()
        {
            try
            {
                frmPhysicalStock objForm = new frmPhysicalStock();
                frmPhysicalStock open = Application.OpenForms["frmPhysicalStock"] as frmPhysicalStock;
                if (open == null)
                {
                    objForm.WindowState = FormWindowState.Normal;
                    objForm.MdiParent = formMDI.MDIObj;
                    objForm.Show();
                    objForm.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoDeliveryNote()
        {
            try
            {
                frmDeliveryNote objfrmDeliveryNote = new frmDeliveryNote();
                frmDeliveryNote open = Application.OpenForms["frmDeliveryNote"] as frmDeliveryNote;
                if (open == null)
                {
                    objfrmDeliveryNote.WindowState = FormWindowState.Normal;
                    objfrmDeliveryNote.MdiParent = formMDI.MDIObj;
                    objfrmDeliveryNote.Show();
                    objfrmDeliveryNote.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoRejectionIn()
        {
            try
            {
                frmRejectionIn objfrmfrmRejectionIn = new frmRejectionIn();
                frmRejectionIn open = Application.OpenForms["frmRejectionIn"] as frmRejectionIn;
                if (open == null)
                {
                    objfrmfrmRejectionIn.WindowState = FormWindowState.Normal;
                    objfrmfrmRejectionIn.MdiParent = formMDI.MDIObj;
                    objfrmfrmRejectionIn.Show();
                    objfrmfrmRejectionIn.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.ClearRejectionIn();
                    open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoRejectionOut()
        {
            try
            {
                frmRejectionOut objfrmfrmRejectionOut = new frmRejectionOut();
                frmRejectionOut open = Application.OpenForms["frmRejectionOut"] as frmRejectionOut;
                if (open == null)
                {
                    objfrmfrmRejectionOut.WindowState = FormWindowState.Normal;
                    objfrmfrmRejectionOut.MdiParent = formMDI.MDIObj;
                    objfrmfrmRejectionOut.Show();
                    objfrmfrmRejectionOut.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoPurchaseInvoice()
        {
            try
            {
                PurchaseInvoiceBll BllPurchaseInvoice = new PurchaseInvoiceBll();
                PurchaseMasterInfo purchasemasterinfo = new PurchaseMasterInfo();
                purchasemasterinfo = BllPurchaseInvoice.PurchaseMasterView(Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                if (purchasemasterinfo.PurchaseMasterId != 0)
                {
                    frmPurchaseInvoice objfrmPurchaseInvoice = new frmPurchaseInvoice();
                    frmPurchaseInvoice open = Application.OpenForms["frmPurchaseInvoice"] as frmPurchaseInvoice;
                    if (open == null)
                    {
                        objfrmPurchaseInvoice.WindowState = FormWindowState.Normal;
                        objfrmPurchaseInvoice.MdiParent = formMDI.MDIObj;
                        objfrmPurchaseInvoice.Show();
                        objfrmPurchaseInvoice.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                        else
                        {
                            open.Activate();
                        }
                      
                        open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                        open.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoSalesInvoice()
        {
            try
            {
                //SalesMasterSP SpMaster = new SalesMasterSP();
                SalesInvoiceBll BllSalesInvoice = new SalesInvoiceBll();
                SalesMasterInfo InfoMaster = new SalesMasterInfo();
                InfoMaster = BllSalesInvoice.SalesMasterView(Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                if (InfoMaster.POS == true)
                {
                    frmPOS objfrm = new frmPOS();
                    
                    objfrm.WindowState = FormWindowState.Normal;
                    objfrm.MdiParent = formMDI.MDIObj;
                    objfrm.Show();
                    objfrm.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    frmSalesInvoice objfrmSalesInvoice = new frmSalesInvoice();
                    frmSalesInvoice open = Application.OpenForms["frmSalesInvoice"] as frmSalesInvoice;
                    if (open == null)
                    {
                        objfrmSalesInvoice.WindowState = FormWindowState.Normal;
                        objfrmSalesInvoice.MdiParent = formMDI.MDIObj;
                        objfrmSalesInvoice.Show();
                        objfrmSalesInvoice.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    }
                    else
                    {
                        open.MdiParent = formMDI.MDIObj;
                        if (open.WindowState == FormWindowState.Minimized)
                        {
                            open.WindowState = FormWindowState.Normal;
                        }
                        else
                        {
                            open.Activate();
                        }
                        open.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                        open.BringToFront();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoSalesReturn()
        {
            try
            {
                frmSalesReturn objfrmSalesReturn = new frmSalesReturn();
                frmSalesReturn open = Application.OpenForms["frmSalesReturn"] as frmSalesReturn;
                if (open == null)
                {
                    objfrmSalesReturn.WindowState = FormWindowState.Normal;
                    objfrmSalesReturn.MdiParent = formMDI.MDIObj;
                    objfrmSalesReturn.Show();
                    objfrmSalesReturn.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSearch(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoPurchaseReturn()
        {
            try
            {
                frmPurchaseReturn objfrmPurchaseReturn = new frmPurchaseReturn();
                frmPurchaseReturn open = Application.OpenForms["frmPurchaseReturn"] as frmPurchaseReturn;
                if (open == null)
                {
                    objfrmPurchaseReturn.WindowState = FormWindowState.Normal;
                    objfrmPurchaseReturn.MdiParent = formMDI.MDIObj;
                    objfrmPurchaseReturn.Show();
                    objfrmPurchaseReturn.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoServiceVoucher()
        {
            try
            {
                frmServiceVoucher objForm = new frmServiceVoucher();
                frmServiceVoucher open = Application.OpenForms["frmServiceVoucher"] as frmServiceVoucher;
                if (open == null)
                {
                    objForm.WindowState = FormWindowState.Normal;
                    objForm.MdiParent = formMDI.MDIObj;
                    objForm.Show();
                    objForm.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call Corresponding Voucher to View details for updation in edit mode
        /// </summary>
        public void GotoMonthlySalaryVoucher()
        {
            try
            {
              
                frmMonthlySalaryVoucher objForm = new frmMonthlySalaryVoucher();
                frmMonthlySalaryVoucher open = Application.OpenForms["frmMonthlySalaryVoucher"] as frmMonthlySalaryVoucher;
                if (open == null)
                {
                    objForm.WindowState = FormWindowState.Normal;
                    objForm.MdiParent = formMDI.MDIObj;
                    objForm.Show();
                    objForm.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                }
                else
                {
                    open.MdiParent = formMDI.MDIObj;
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                    open.CallFromVoucherSerach(this, Convert.ToDecimal(dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString()));
                    open.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to fill the Grid based on the search mode
        /// </summary>
        public void GridFill()
        {
            List<DataTable> listObjVoucher = new List<DataTable>();
            MaterialReceiptBll bllMaterialReceiptMaster = new MaterialReceiptBll();
            try
            {
               
                if (dtpFromDate.Value <= dtpToDate.Value)
                {
                    
                    if (txtVoucherNo.Text.Trim() == string.Empty)
                    {
                        strInvoiceNo = string.Empty;
                    }
                    else
                    {
                        strInvoiceNo = txtVoucherNo.Text;
                    }
                    if (cmbAccountLedger.SelectedIndex == 0 || cmbAccountLedger.SelectedIndex == -1)
                    {
                        decLedgerId = -1;
                    }
                    else
                    {
                        decLedgerId = Convert.ToDecimal(cmbAccountLedger.SelectedValue.ToString());
                    }
                    if (cmbVoucherType.SelectedIndex == 0 || cmbVoucherType.SelectedIndex == -1)
                    {
                        decVoucherTypeId = -1;
                    }
                    else
                    {
                        decVoucherTypeId = Convert.ToDecimal(cmbVoucherType.SelectedValue.ToString());
                    }
                    if (cmbSalesMan.SelectedIndex == 0 || cmbSalesMan.SelectedIndex == -1)
                    {
                        decEmployeeId = -1;
                    }
                    else
                    {
                        decEmployeeId = Convert.ToDecimal(cmbSalesMan.SelectedValue.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("From date should be less than to date", "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    DateTime FromDate = this.dtpFromDate.Value;
                    DateTime ToDate = this.dtpToDate.Value;
                    listObjVoucher = BllVoucherType.VoucherSearchFill(FromDate, ToDate, decVoucherTypeId, strInvoiceNo, decLedgerId, decEmployeeId);
                    dgvVoucherSearch.DataSource = listObjVoucher[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to clear the controls
        /// </summary>
        public void Clear()
        {
            try
            {
               
                txtFromDate.Focus();
                dtpFromDate.Value = PublicVariables._dtCurrentDate;
                dtpFromDate.MinDate = PublicVariables._dtFromDate;
                dtpFromDate.MaxDate = PublicVariables._dtToDate;
                dtpToDate.Value = PublicVariables._dtCurrentDate;
                dtpToDate.MinDate = PublicVariables._dtFromDate;
                dtpToDate.MaxDate = PublicVariables._dtToDate;
                txtVoucherNo.Text = string.Empty;
                AccountLedgerComboFill();
                ComboSalesManFill();
                voucherTypeComboFill();
                GridFill();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill  Salesman combobox
        /// </summary>
        public void ComboSalesManFill()
        {
            try
            {
                transactionGeneralFillObj.SalesmanViewAllForComboFill(cmbSalesMan, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Events
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
                MessageBox.Show("VS43:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Date validation and set the Fromdate as dtp's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtFromDate);
                if (!isInvalid)
                {
                    txtFromDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpFromDate.Value = Convert.ToDateTime(txtFromDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS44:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Date validation and set the Todate as dtp's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_Leave(object sender, EventArgs e)
        {
            try
            {
                DateValidation objVal = new DateValidation();
                bool isInvalid = objVal.DateValidationFunction(txtToDate);
                if (!isInvalid)
                {
                    txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                }
                dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS45:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Set the text box value as to date dtp's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpFromDate.Value;
                this.txtFromDate.Text = date.ToString("dd-MMM-yyyy");
                txtFromDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS46:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Set the text box value as From date dtp's value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtpToDate.Value;
                this.txtToDate.Text = date.ToString("dd-MMM-yyyy");
                txtToDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS47:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// When form load clear the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVoucherSearch_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS48:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Call the clear function in reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS49:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// txtToDate text changed, set the text box value and validating the date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtToDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtToDate.Text == string.Empty && !txtToDate.Focused)
                {
                    DateValidation objVal = new DateValidation();
                    bool isInvalid = objVal.DateValidationFunction(txtToDate);
                    if (!isInvalid)
                    {
                        txtToDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                    }
                    dtpToDate.Value = Convert.ToDateTime(txtToDate.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS50:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Search button click, call the gridfill function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS51:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Grid Cell double click to view thw purticular details in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVoucherSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    btnViewDetails_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS52:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Butten view details click to view thw purticular details in the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVoucherSearch.Rows.Count > 0)
                {
                    if (dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString() != null && dgvVoucherSearch.CurrentRow.Cells["Id"].Value.ToString() != string.Empty)
                    {
                        if (dgvVoucherSearch.CurrentRow != null)
                        {
                            inCurrenRowIndex = dgvVoucherSearch.CurrentRow.Index;
                            bool isNotDo = false;
                            string strTypeofVoucher = BllVoucherType.TypeOfVoucherView(dgvVoucherSearch.CurrentRow.Cells["VoucherType"].Value.ToString());
                            switch (strTypeofVoucher)
                            {
                                case "Physical Stock": GotoPhysicalStock();
                                    break;
                                case "Credit Note": GotoCrditNote();
                                    break;
                                case "Debit Note": GotoDebitNote();
                                    break;
                                case "Advance Payment": GotoAdvancePayment();
                                    break;
                                case "Daily Salary Voucher": GotoDailySalaryVoucher();
                                    break;
                                case "Monthly Salary Voucher": GotoMonthlySalaryVoucher();
                                    break;
                                case "Stock Journal": GotoStockJournal();
                                    break;
                                case "Contra Voucher": GotoContraVoucher();
                                    break;
                                case "Payment Voucher": GotoPaymentVoucher();
                                    break;
                                case "Receipt Voucher": GotoReceiptVoucher();
                                    break;
                                case "Journal Voucher": GotoJournalVoucher();
                                    break;
                                case "PDC Payable": GotoPDCPayable();
                                    break;
                                case "PDC Receivable": GotoPDCReceivable();
                                    break;
                                case "PDC Clearance": GotoPDCClearance();
                                    break;
                                case "Purchase Order": GotoPurchaseOrder();
                                    break;
                                case "Material Receipt": GotoMaterialReceipt();
                                    break;
                                case "Rejection Out": GotoRejectionOut();
                                    break;
                                case "Purchase Return": GotoPurchaseReturn();
                                    break;
                                case "Sales Quotation": GotoSalesQuotation();
                                    break;
                                case "Sales Order": GotoSalesOrder();
                                    break;
                                case "Delivery Note": GotoDeliveryNote();
                                    break;
                                case "Rejection In": GotoRejectionIn();
                                    break;
                                case "Sales Return": GotoSalesReturn();
                                    break;
                                case "Purchase Invoice": GotoPurchaseInvoice();
                                    break;
                                case "Sales Invoice": GotoSalesInvoice();
                                    break;
                                case "Service Voucher": GotoServiceVoucher();
                                    break;
                                default:
                                    isNotDo = true;
                                    break;
                            }
                            if (!isNotDo)
                                this.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS53:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion Events
        #region Navigation
        /// <summary>
        /// For enter key and backspace navigation
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
                    txtToDate.SelectionStart = txtToDate.TextLength;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS54:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
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
                else if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.SelectionStart == 0 || txtToDate.Text == string.Empty)
                    {
                        txtFromDate.Focus();
                        txtFromDate.SelectionStart = 0;
                        txtFromDate.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS55:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbVoucherType_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtToDate.Enabled)
                    {
                        txtToDate.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS56:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVoucherNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbAccountLedger.Enabled)
                    {
                        cmbAccountLedger.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbVoucherType. Enabled)
                    {
                        if(txtVoucherNo.SelectionStart==0)
                        {
                        cmbVoucherType.Focus();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS57:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCashOrParty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtVoucherNo.Enabled)
                    {
                        txtVoucherNo.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS58:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSalesMan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnSearch.Enabled)
                    {
                        btnSearch.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (cmbAccountLedger.Enabled)
                    {
                        cmbAccountLedger.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS59:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
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
                    if (cmbSalesMan.Enabled)
                    {
                        cmbSalesMan.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS60:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvVoucherSearch.Enabled)
                    {
                        dgvVoucherSearch.Focus();
                    }
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (btnSearch.Enabled)
                    {
                        btnSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS61:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvVoucherSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    
                    btnViewDetails_Click(sender, e);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    cmbSalesMan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS62:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        /// <summary>
        /// For enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVoucherSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    btnClose_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("VS63:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        
      
        
    }
}
