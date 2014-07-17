using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms;
namespace OpenMiracle.BLL
{
   public  class BankReconciliationBll
    {
        BankReconciliationInfo infoBankReconciliation = new BankReconciliationInfo();
        BankReconciliationSP SpBankReconciliation = new BankReconciliationSP();

        public List<DataTable> BankReconciliationFillReconcile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
        {
            List<DataTable> listBank = new List<DataTable>();
            try
            {
                listBank = SpBankReconciliation.BankReconciliationFillReconcile(decLedgerId, dtFromDate, dtToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listBank;
        }
        public List<DataTable> BankReconciliationUnrecocile(decimal decLedgerId, DateTime dtFromDate, DateTime dtToDate)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpBankReconciliation.BankReconciliationUnrecocile(decLedgerId, dtFromDate, dtToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal BankReconciliationLedgerPostingId(decimal decLedgerId)
        {
            decimal decReconcileId = 0;
            try
            {
                decReconcileId = SpBankReconciliation.BankReconciliationLedgerPostingId(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReconcileId;
        }
        public void BankReconciliationEdit(BankReconciliationInfo bankreconciliationinfo)
        {
            try
            {
                SpBankReconciliation.BankReconciliationEdit(bankreconciliationinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void BankReconciliationAdd(BankReconciliationInfo bankreconciliationinfo)
        {
            try
            {
                SpBankReconciliation.BankReconciliationAdd(bankreconciliationinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void BankReconciliationDelete(decimal ReconcileId)
        {
            try
            {
                SpBankReconciliation.BankReconciliationDelete(ReconcileId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
          
    }
}
