using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Windows.Forms;
using System.Data;

namespace OpenMiracle.BLL
{
    public class AdvancePaymentBll
    {
        AdvancePaymentSP spAdvancePayment = new AdvancePaymentSP();
        public bool CheckSalaryAlreadyPaidOrNot(decimal decEmployeeId, DateTime date)
        {
            bool isPaid = false;
            try
            {
                isPaid = spAdvancePayment.CheckSalaryAlreadyPaidOrNot(decEmployeeId, date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isPaid;
        }
        public List<DataTable> AdvancePaymentAddWithIdentity(AdvancePaymentInfo infoAdvancePayment, bool IsAutomatic)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAdvancePayment.AdvancePaymentAddWithIdentity(infoAdvancePayment, IsAutomatic);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public void AdvancePaymentEdit(AdvancePaymentInfo infoAdvancePayment)
        {
            try
            {
                spAdvancePayment.AdvancePaymentEdit(infoAdvancePayment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool AdvancePaymentCheckExistence(string strVoucherNo, decimal decVoucherTypeId, decimal decAdvancePaymentId)
        {
            bool isSave = false;
            try
            {
                isSave = AdvancePaymentCheckExistence(strVoucherNo, decVoucherTypeId, decAdvancePaymentId);
            }
            catch(Exception ex)
            {
                 MessageBox.Show("AP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSave;
        }
        public AdvancePaymentInfo AdvancePaymentView(decimal decAdvancePaymentId)
        {
            AdvancePaymentInfo infoiAdvancePayment = new AdvancePaymentInfo();
            try
            {
                infoiAdvancePayment = spAdvancePayment.AdvancePaymentView(decAdvancePaymentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoiAdvancePayment;
        }
        public List<DataTable> AdvancePaymentEmployeeComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAdvancePayment.AdvancePaymentEmployeeComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal AdvancePaymentGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal Max = 0;
            try
            {
                Max = spAdvancePayment.AdvancePaymentGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Max;
        }
        public string AdvancePaymentGetMax(decimal decVoucherTypeId)
        {
            string Max = "0";
            try
            {
                Max = spAdvancePayment.AdvancePaymentGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Max;
        }
        public void AdvancePaymentDelete(decimal AdvancePaymentId)
        {
            try
            {
                spAdvancePayment.AdvancePaymentDelete(AdvancePaymentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal AdvancePaymentAmountchecking(decimal decEmployeeId)
        {
            decimal decAdvanceAmount = 0;
            try
            {
                decAdvanceAmount = spAdvancePayment.AdvancePaymentAmountchecking(decEmployeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decAdvanceAmount;
        }
        public List<DataTable> AdvanceRegisterSearch(string strAdvanceVoucher, string strEmployeeCode, string strEmployeeName, string dtpDate, string strVouchertypeName)
        {
            //EmployeeInfo infoEmployee = new EmployeeInfo();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAdvancePayment.AdvanceRegisterSearch(strAdvanceVoucher, strEmployeeCode, strEmployeeName, dtpDate, strVouchertypeName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> AdvancePaymentViewAllForAdvancePaymentReport(DateTime dtpFromDate, DateTime dtpToDate, string strEmployeeCode, DateTime dtpSalaryMonth)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAdvancePayment.AdvancePaymentViewAllForAdvancePaymentReport(dtpFromDate, dtpToDate, strEmployeeCode, dtpSalaryMonth);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> VoucherTypeNameComboFillAdvanceRegister()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAdvancePayment.VoucherTypeNameComboFillAdvanceRegister();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AP12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
    }
}
