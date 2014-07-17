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

    public partial class frmEmployeePopup : Form
    {
        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        frmBonusDeductionRegister frmBonusDeductionObj;
        frmServiceVoucher frmServiceVoucherObj;
        frmEmployeeAddressBook frmEmployeeAddressBookObj;
        frmEmployeeReport frmEmployeeReportObj;
        frmDailySalaryReport frmDailySalaryReportObj;
        frmDailyAttendanceReport frmDailyAttendanceReportObj;
        frmAdvancePaymentReport frmAdvancePaymentReportObj;
        frmRejectionIn frmRejectionInObj;
        frmSalesQuotation frmSalesQuotationObj;
        frmSalesOrder frmSalesOrderObj;
        frmDeliveryNote frmDeliveryNoteObj;
        frmSalesInvoice frmSalesInvoiceObj;
        frmSalesReturn frmSalesReturnObj;
        frmPOS frmPOSObj;
        frmAdvancePayment frmAdvancePaymentObj;
        string strComboTypes = string.Empty;
        #endregion

        #region Function
        /// <summary>
        /// Creates an instance of frmEmployeePopup classs
        /// </summary>
        public frmEmployeePopup()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Function to call this form from frmDailySalaryReport to view employee list
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decEmployeeId"></param>
        public void CallFromDailySlaryReport(frmDailySalaryReport frm, decimal decEmployeeId)
        {
            try
            {

                base.Show();
                frmDailySalaryReportObj = frm;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decEmployeeId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmEmployeeReport to view employee list
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decEmployeeId"></param>
        public void CallFromEmployeeReport(frmEmployeeReport frm, decimal decEmployeeId)
        {
            try
            {
                base.Show();
                frmEmployeeReportObj = frm;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decEmployeeId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        ///  Function to call this form from frmAdvancePaymentReport to view employee list
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decEmployeeId"></param>
        public void CallFromAdvancePaymentReport(frmAdvancePaymentReport frm, decimal decEmployeeId)
        {
            try
            {
                base.Show();
                frmAdvancePaymentReportObj = frm;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decEmployeeId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmEmployeeAddressBook to view employee list
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="decEmployeeId"></param>
        public void CallFromEmployeeAddressBook(frmEmployeeAddressBook frm, decimal decEmployeeId)
        {
            try
            {
                base.Show();
                frmEmployeeAddressBookObj = frm;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decEmployeeId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// Function to call this form from frmBonusDeductionRegister to view employee list
        /// </summary>
        /// <param name="frmBonusDeduction"></param>
        /// <param name="decId"></param>
        public void CallFromBonusDeductionregister(frmBonusDeductionRegister frmBonusDeduction, decimal decId)
        {
            try
            {
                base.Show();
                this.frmBonusDeductionObj = frmBonusDeduction;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  Function to call this form from frmRejectionIn to view employee list
        /// </summary>
        /// <param name="frmSalesReturn"></param>
        /// <param name="decId"></param>
        public void callFromRejectionIn(frmRejectionIn frmRejectionIn, decimal employeeId, string strComboType)
        {
            try
            {
                strComboTypes = strComboType;
                base.Show();
                this.frmRejectionInObj = frmRejectionIn;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int i = 0; i < inRowCount; i++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[i].Cells["dgvtxtEmployeeId"].Value.ToString()) == employeeId)
                    {
                        dgvEmployee.Rows[i].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Function to call this form from frmServiceVoucher to view employee list
        /// </summary>
        /// <param name="frmServiceVoucher"></param>
        /// <param name="decId"></param>
        public void CallFromServiceVoucher(frmServiceVoucher frmServiceVoucher, decimal decId)
        {
            try
            {
                base.Show();
                this.frmServiceVoucherObj = frmServiceVoucher;
                frmServiceVoucherObj.Enabled = false;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmDailyAttendanceReport to view employee list
        /// </summary>
        /// <param name="frmDailyAttendanceReport"></param>
        /// <param name="decId"></param>
        public void CallFromDailyAttendanceReport(frmDailyAttendanceReport frmDailyAttendanceReport, decimal decId)
        {
            try
            {
                base.Show();
                this.frmDailyAttendanceReportObj = frmDailyAttendanceReport;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesQuotation to view employee list
        /// </summary>
        /// <param name="frmSalesQuotation"></param>
        /// <param name="decId"></param>
        public void CallFromSalesQuotation(frmSalesQuotation frmSalesQuotation, decimal decId)
        {
            try
            {
                base.Show();
                this.frmSalesQuotationObj = frmSalesQuotation;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmSalesOrder to view employee list
        /// </summary>
        /// <param name="frmSalesOrder"></param>
        /// <param name="decId"></param>
        public void CallFromSalesOrder(frmSalesOrder frmSalesOrder, decimal decId)
        {
            try
            {
                base.Show();
                this.frmSalesOrderObj = frmSalesOrder;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmDeliveryNote to view employee list
        /// </summary>
        /// <param name="frmDeliveryNote"></param>
        /// <param name="decId"></param>
        public void CallFromDeliveryNote(frmDeliveryNote frmDeliveryNote, decimal decId)
        {
            try
            {
                base.Show();
                this.frmDeliveryNoteObj = frmDeliveryNote;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to call this form from frmSalesInvoice to view employee list
        /// </summary>
        /// <param name="frmSalesInvoice"></param>
        /// <param name="decId"></param>
        public void callFromSalesInvoice(frmSalesInvoice frmSalesInvoice, decimal decId)
        {
            try
            {
                base.Show();

                this.frmSalesInvoiceObj = frmSalesInvoice;
                frmSalesInvoiceObj.Enabled = false;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///  Function to call this form from frmSalesReturn to view employee list
        /// </summary>
        /// <param name="frmSalesReturn"></param>
        /// <param name="decId"></param>

        public void callFromSalesReturn(frmSalesReturn frmSalesReturn, decimal decId)
        {
            try
            {
                base.Show();

                this.frmSalesReturnObj = frmSalesReturn;
                frmSalesReturnObj.Enabled = false;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to fill Datagridview
        /// </summary>
        public void GridFill()
        {
            try
            {
                List<DataTable> listBonusDeduction = new List<DataTable>();
                BonusDeductionBll BllBonusDeduction = new BonusDeductionBll();
                listBonusDeduction = BllBonusDeduction.BonusDeductionSearchForPopUp(txtEmployeeCode.Text, txtEmployeeName.Text);
                dgvEmployee.DataSource = listBonusDeduction[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to reset the form
        /// </summary>
        public void Clear()
        {
            try
            {
                txtEmployeeCode.Clear();
                txtEmployeeName.Clear();
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmPOS to view employee list
        /// </summary>
        /// <param name="frmPOS"></param>
        /// <param name="decId"></param>
        public void callFromPOS(frmPOS frmPOS, decimal decId) 
        {
            try
            {
                base.Show();
                this.frmPOSObj = frmPOS;
                frmPOSObj.Enabled = false;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to call this form from frmAdvancePayment to view employee list
        /// </summary>
        /// <param name="frmAdvancePayment"></param>
        /// <param name="decId"></param>
        public void CallFromAdvancePayment(frmAdvancePayment frmAdvancePayment, decimal decId) //POP UP
        {
            try
            {
                base.Show();
                this.frmAdvancePaymentObj = frmAdvancePayment;
                int inRowCount = dgvEmployee.Rows.Count;
                for (int ini = 0; ini < inRowCount; ini++)
                {
                    if (Convert.ToDecimal(dgvEmployee.Rows[ini].Cells["dgvtxtEmployeeId"].Value.ToString()) == decId)
                    {
                        dgvEmployee.Rows[ini].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                    }
                }
                txtEmployeeCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeePopup_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                GridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("EMPP19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Clears selection in Datagridview on binding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvEmployee.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Fills the employee name on Cell double click in Datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (frmBonusDeductionObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmBonusDeductionObj.CallFromEmployee(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));
                            frmBonusDeductionObj.GridFill();
                        }
                    }

                    if (frmServiceVoucherObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmServiceVoucherObj.CallEmployeePopup(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));

                        }
                    }
                    if (frmEmployeeAddressBookObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmEmployeeAddressBookObj.CallFromEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));
                        }
                    }
                    if (frmEmployeeReportObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmEmployeeReportObj.CallFromEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));
                        }
                    }
                    if (frmDailySalaryReportObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmDailySalaryReportObj.CallFromEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));
                        }
                    }
                    if (frmDailyAttendanceReportObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmDailyAttendanceReportObj.CallFromEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));
                        }
                    }
                    if (frmAdvancePaymentReportObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmAdvancePaymentReportObj.CallFromEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));
                        }
                    }
                    if (frmSalesQuotationObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmSalesQuotationObj.CallFromEmployeePopup(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));

                        }
                    }
                    if (frmSalesOrderObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmSalesOrderObj.CallFromEmployeePopup(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));

                        }
                    }
                    if (frmDeliveryNoteObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmDeliveryNoteObj.CallFromEmployeePopup(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));

                        }
                    }

                    if (frmSalesInvoiceObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmSalesInvoiceObj.CallEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));

                        }
                    }
                    if (frmSalesReturnObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmSalesReturnObj.CallEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));
                        }
                    }
                    if (frmAdvancePaymentObj != null)
                    {
                        if (dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Selected)
                        {
                            frmAdvancePaymentObj.CallEmployeePopUp(this, Convert.ToDecimal(dgvEmployee.CurrentRow.Cells["dgvtxtEmployeeId"].Value.ToString()));

                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP21: " + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enable the object of form on form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeePopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
                if (frmSalesQuotationObj != null)
                {
                    frmSalesQuotationObj.Enabled = true;
                }               
                if (frmSalesInvoiceObj != null)
                {
                    frmSalesInvoiceObj.Enabled = true;
                }
                if (frmPOSObj != null)
                {
                    frmPOSObj.Enabled = true;
                }
                if (frmSalesReturnObj != null)
                {
                    frmSalesReturnObj.Enabled = true;
                }
                if (frmServiceVoucherObj != null)
                {
                    frmServiceVoucherObj.Enabled = true;
                }
                dgvEmployee.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Navigation
        /// <summary>
        /// Escape key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEmployeePopup_KeyDown(object sender, KeyEventArgs e)
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
                MessageBox.Show("EMPP23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmployeeCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmployeeName.Focus();
                    txtEmployeeName.SelectionLength = 0;
                    txtEmployeeName.SelectionStart = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Enter key and backspace navigation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.Focus();
                }
                if (e.KeyCode == Keys.Back)
                {
                    if (txtEmployeeName.Text == string.Empty || txtEmployeeName.SelectionStart == 0)
                    {
                        txtEmployeeCode.Focus();
                        txtEmployeeCode.SelectionStart = 0;
                        txtEmployeeCode.SelectionLength = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtEmployeeName.Focus();
                    txtEmployeeName.SelectionStart = 0;
                    txtEmployeeName.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EMPP26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        #endregion
    }
}
