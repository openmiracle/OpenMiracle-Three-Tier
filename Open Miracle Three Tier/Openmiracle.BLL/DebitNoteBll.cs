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
   public class DebitNoteBll
    {
       DebitNoteDetailsInfo infoDebitNoteDetails = new DebitNoteDetailsInfo();
       DebitNoteDetailsSP spDebitNoteDetails = new DebitNoteDetailsSP();
       DebitNoteMasterInfo infoDebitNoteMaster = new DebitNoteMasterInfo();
       DebitNoteMasterSP spDebitNoteMaster = new DebitNoteMasterSP();
       public decimal DebitNoteDetailsAdd(DebitNoteDetailsInfo debitnotedetailsinfo)
       {
           decimal decDebitNoteDetails = 0;
           try
           {
               decDebitNoteDetails = spDebitNoteDetails.DebitNoteDetailsAdd(debitnotedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decDebitNoteDetails;
       }
       public void DebitNoteDetailsDelete(decimal DebitNoteDetailsId)
       {
           try
           {
               spDebitNoteDetails.DebitNoteDetailsDelete(DebitNoteDetailsId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public void DebitNoteDetailsEdit(DebitNoteDetailsInfo debitnotedetailsinfo)
       {
           try
           {
               spDebitNoteDetails.DebitNoteDetailsEdit(debitnotedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public List<DataTable> DebitNoteDetailsViewByMasterId(decimal decMasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
              listObj= spDebitNoteDetails.DebitNoteDetailsViewByMasterId(decMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> DebitNoteMasterViewAllWithSlNo()
       {
           List<DataTable> listObj = new List<DataTable>();
            try
           {
               listObj = spDebitNoteMaster.DebitNoteMasterViewAllWithSlNo();
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;  
       }
       public List<DataTable> DebitNoteRegisterSearch(string strVoucherNo, string strFromDate, string strToDate)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDebitNoteMaster.DebitNoteRegisterSearch( strVoucherNo,  strFromDate, strToDate);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public decimal DebitNoteMasterIdView(decimal decVouchertypeid, string strVoucherNo)
       {
           decimal decid = 0;
           try
           {
               decid = spDebitNoteMaster.DebitNoteMasterIdView( decVouchertypeid,  strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decid;
       }
       public void DebitNoteVoucherDelete(decimal decDebitNoteMasterId, decimal decVoucherTypeId, string strVoucherNo)
       {
           try
           {
               spDebitNoteMaster.DebitNoteVoucherDelete( decDebitNoteMasterId,  decVoucherTypeId,  strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public DataSet DebitNotePrinting(decimal decDebitNoteMasterId, decimal decCompanyId)
       {
           DataSet dSt = new DataSet();
           try
           {
              dSt= spDebitNoteMaster.DebitNotePrinting(decDebitNoteMasterId,  decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dSt;
       }
       public decimal DebitNoteMasterAdd(DebitNoteMasterInfo debitnotemasterinfo)
       {
           decimal decDebitNoteMasterId = 0;
           try
           {
               decDebitNoteMasterId = spDebitNoteMaster.DebitNoteMasterAdd(debitnotemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decDebitNoteMasterId;
       }
       public decimal DebitNoteMasterEdit(DebitNoteMasterInfo debitnotemasterinfo)
       {
           decimal decEffectRow = 0;
           try
           {
               decEffectRow = spDebitNoteMaster.DebitNoteMasterEdit(debitnotemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decEffectRow;
       }
       public DebitNoteMasterInfo DebitNoteMasterView(decimal debitNoteMasterId)
       {
           DebitNoteMasterInfo debitnotemasterinfo = new DebitNoteMasterInfo();
           try
           {
               debitnotemasterinfo = spDebitNoteMaster.DebitNoteMasterView(debitNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return debitnotemasterinfo;
       }
       public decimal DebitNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
       {
           decimal max = 0;
           try
           {
               max = spDebitNoteMaster.DebitNoteMasterGetMaxPlusOne(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       public int DebitNoteMasterGetMax(decimal decVoucherTypeId)
       {
           int max = 0;
           try
           {
               max = spDebitNoteMaster.DebitNoteMasterGetMax(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       public List<DataTable> DebitNoteReportSearch(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDebitNoteMaster.DebitNoteReportSearch(strFromDate,strToDate,decVoucherTypeId,decLedgerId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public DataSet DebitNoteReportPrinting(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decCompanyId)
       {
           DataSet dst = new DataSet();
           try
           {
               dst = spDebitNoteMaster.DebitNoteReportPrinting(strFromDate, strToDate, decVoucherTypeId, decLedgerId, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dst;
       }
       public bool DebitNoteVoucherCheckExistance(string strInvoiceNo, decimal VoucherTypeId, decimal decMasterId)
       {
           bool trueOrfalse = false;
           try
           {
               trueOrfalse = spDebitNoteMaster.DebitNoteVoucherCheckExistance( strInvoiceNo, VoucherTypeId, decMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DNBLL:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return trueOrfalse;
       }
    }
}
