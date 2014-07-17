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
  public  class LedgerPostingBll
    {
      LedgerPostingSP SpLedgerPosting = new LedgerPostingSP();
      LedgerPostingInfo infoLedgerPosting = new LedgerPostingInfo();

      public void LedgerPostingAdd(LedgerPostingInfo ledgerpostinginfo)
      {
          try
          {
              SpLedgerPosting.LedgerPostingAdd(ledgerpostinginfo);
          }
          catch (Exception ex)
          {
              MessageBox.Show("LPBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
      }
      public void LedgerPostDelete(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                SpLedgerPosting.LedgerPostDelete(strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       public List<DataTable> GetLedgerPostingIds(string voucherNo, decimal voucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpLedgerPosting.GetLedgerPostingIds(voucherNo, voucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
       public void LedgerPostDeleteByDetailsId(decimal decDetailsId, string strVoucherNo, decimal decVoucherTypeId)
       {
           try
           {
               SpLedgerPosting.LedgerPostDeleteByDetailsId(decDetailsId, strVoucherNo, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("LPBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public void LedgerPostingEdit(LedgerPostingInfo ledgerpostinginfo)
        {
            try
            {
                SpLedgerPosting.LedgerPostingEdit(ledgerpostinginfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LedgerPostingDeleteByVoucherNoVoucherTypeIdAndLedgerId(string strVoucherNo, decimal decVoucherTypeId, decimal decLedgerId)
        {
            try
            {
                SpLedgerPosting.LedgerPostingDeleteByVoucherNoVoucherTypeIdAndLedgerId(strVoucherNo, decVoucherTypeId, decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       public decimal LedgerPostingIdForTotalAmount(string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decLedgerPostingId = 0;
            try
            {
                decLedgerPostingId = SpLedgerPosting.LedgerPostingIdForTotalAmount(strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decLedgerPostingId;
        }
      public decimal LedgerPostingIdFromDetailsId(decimal decDetailsId, string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decLedgerPostingId = 0;

            try
            {
                decLedgerPostingId = SpLedgerPosting.LedgerPostingIdFromDetailsId(decDetailsId, strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decLedgerPostingId;
        }
        public void LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndLedgerIdAndVoucherNo(decimal voucherTypeId, string voucherNo, string invoiceNo)
        {
            try
            {
                SpLedgerPosting.LedgerPostingAndPartyBalanceDeleteByVoucherTypeIdAndLedgerIdAndVoucherNo(voucherTypeId, voucherNo, invoiceNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
        }
        public void LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(LedgerPostingInfo infoLedgerPosting)
        {
            try
            {
                SpLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNoAndLedgerId(infoLedgerPosting);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LedgerPostingDeleteByVoucherTypeIdAndLedgerIdAndVoucherNoAndExtra(decimal voucherTypeId, decimal decLedgerId, string strVoucherNo, string strAddCash)
        {
            try
            {
                SpLedgerPosting.LedgerPostingDeleteByVoucherTypeIdAndLedgerIdAndVoucherNoAndExtra(voucherTypeId, decLedgerId, strVoucherNo, strAddCash);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       public void DeleteLedgerPostingForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                SpLedgerPosting.DeleteLedgerPostingForStockJournalEdit(strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LPBLL:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       public void LedgerPostingEditByVoucherTypeAndVoucherNo(LedgerPostingInfo ledgerpostinginfo)
       {
           try
           {
               SpLedgerPosting.LedgerPostingEditByVoucherTypeAndVoucherNo(ledgerpostinginfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("LPBLL:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
    }
}
