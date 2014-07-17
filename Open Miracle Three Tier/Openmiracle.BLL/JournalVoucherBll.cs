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
    public class JournalVoucherBll
    {
        JournalDetailsSP spJournalDetails = new JournalDetailsSP();
        JournalMasterSP spJournalMaster = new JournalMasterSP();
        public void JournalDetailsDelete(decimal decJournalDetailsId)
        {
            try
            {
                spJournalDetails.JournalDetailsDelete(decJournalDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void JournalDetailsEdit(JournalDetailsInfo infoJournalDetails)
        {
            try
            {
                spJournalDetails.JournalDetailsEdit(infoJournalDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal JournalDetailsAdd(JournalDetailsInfo infoJournalDetails)
        {
            decimal decDecid = 0;
            try
            {
                decDecid=spJournalDetails.JournalDetailsAdd(infoJournalDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decDecid;
        }
        public List<DataTable> JournalDetailsViewByMasterId(decimal decMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spJournalDetails.JournalDetailsViewByMasterId(decMasterId);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("JVBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal JournalMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal decId = 0;
            try
            {
                decId = spJournalMaster.JournalMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public int JournalMasterGetMax(decimal decVoucherTypeId)
        {
            int inId = 0;
            try
            {
                inId = spJournalMaster.JournalMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inId;
        }
        public decimal JournalMasterAdd(JournalMasterInfo infoJournalmaster)
        {
            decimal decId = 0;
            try
            {
                decId = spJournalMaster.JournalMasterAdd(infoJournalmaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public decimal JournalMasterEdit(JournalMasterInfo infoJournalmaster)
        {
            decimal decEffectRow = 0;
            try
            {
                decEffectRow = spJournalMaster.JournalMasterEdit(infoJournalmaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decEffectRow;
        }
        public bool JournalVoucherCheckExistance(string strInvoiceNo, decimal voucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                trueOrfalse = spJournalMaster.JournalVoucherCheckExistance(strInvoiceNo, voucherTypeId, decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
        public void JournalVoucherDelete(decimal decJournalMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                spJournalMaster.JournalVoucherDelete(decJournalMasterId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DataSet JournalVoucherPrinting(decimal decJournalMasterId, decimal decCompanyId)
        {
            DataSet dSJournalVoucher = new DataSet();
            try
            {
                dSJournalVoucher = spJournalMaster.JournalVoucherPrinting(decJournalMasterId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSJournalVoucher;
        }
        public JournalMasterInfo JournalMasterView(decimal decJournalMasterId)
        {
            JournalMasterInfo infoJournalmaster = new JournalMasterInfo();
            try
            {
                infoJournalmaster = spJournalMaster.JournalMasterView(decJournalMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoJournalmaster;
        }
        public List<DataTable> JournalRegisterSearch(string strVoucherNo, string strFromDate, string strToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spJournalMaster.JournalRegisterSearch(strVoucherNo, strFromDate, strToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal JournalMasterIdView(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decid = 0;
            try
            {
                decid = spJournalMaster.JournalMasterIdView(decVouchertypeid, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decid;
        }
        public List<DataTable> JournalReportSearch(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spJournalMaster.JournalReportSearch(strFromDate, strToDate, decVoucherTypeId, decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public DataSet JournalReportPrinting(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decCompanyId)
        {
            DataSet dsJournalReportPrint = new DataSet();
            try
            {
                dsJournalReportPrint = spJournalMaster.JournalReportPrinting(strFromDate, strToDate, decVoucherTypeId, decLedgerId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JVBLL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsJournalReportPrint;
        }
    }
}
