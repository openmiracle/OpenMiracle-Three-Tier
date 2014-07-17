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
   public class RejectionOutBll
    {
        RejectionOutDetailsSP spRejectionOutDetails = new RejectionOutDetailsSP();
        RejectionOutMasterSP spRejectionOutMaster = new RejectionOutMasterSP();

       /// <summary>
       /// 
       /// </summary>
       /// <param name="decRejectionOutMasterId"></param>
        public void RejectionOutDetailsDeleteByRejectionOutMasterId(decimal decRejectionOutMasterId)
        {
            try
            {
                spRejectionOutDetails.RejectionOutDetailsDeleteByRejectionOutMasterId(decRejectionOutMasterId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RO1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="rejectionoutdetailsinfo"></param>
       /// <returns></returns>
        public decimal RejectionOutDetailsAddWithReturnIdentity(RejectionOutDetailsInfo rejectionoutdetailsinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spRejectionOutDetails.RejectionOutDetailsAddWithReturnIdentity( rejectionoutdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="RejectionOutDetailsId"></param>
        public void RejectionOutDetailsDelete(decimal RejectionOutDetailsId)
        {
            try
            {
                spRejectionOutDetails.RejectionOutDetailsDelete( RejectionOutDetailsId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RO3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decRejectionOutMasterId"></param>
       /// <returns></returns>
        public List<DataTable> RejectionOutDetailsViewByRejectionOutMasterId(decimal decRejectionOutMasterId)
        {
            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spRejectionOutDetails.RejectionOutDetailsViewByRejectionOutMasterId( decRejectionOutMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public decimal RejectionOutMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spRejectionOutMaster.RejectionOutMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;

        }
        public DataSet RejectionOutPrinting(decimal decRejectionOutMasterId, decimal decCompanyId)
        {

            DataSet dst = new DataSet();
            try
            {
                dst = spRejectionOutMaster.RejectionOutPrinting( decRejectionOutMasterId,decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dst;
        }
        public decimal RejectionOutMasterAddWithReturnIdentity(RejectionOutMasterInfo rejectionoutmasterinfo)
        {

            decimal decIdentity = 0;
            try
            {
                decIdentity = spRejectionOutMaster.RejectionOutMasterAddWithReturnIdentity(rejectionoutmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public void RejectionOutMasterEdit(RejectionOutMasterInfo rejectionoutmasterinfo)
        
        {
            try
            {
                spRejectionOutMaster.RejectionOutMasterEdit(rejectionoutmasterinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RO8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool RejectionOutNumberCheckExistence(string strinvoiceNo, decimal decRejectionOutMasterId, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spRejectionOutMaster.RejectionOutNumberCheckExistence(strinvoiceNo, decRejectionOutMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public List<DataTable> RejectionOutMasterViewAll()
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spRejectionOutMaster.RejectionOutMasterViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public void RejectionOutMasterAndDetailsDelete(decimal decRejectionOutMasterId)
        {
            try
            {
                spRejectionOutMaster.RejectionOutMasterAndDetailsDelete(decRejectionOutMasterId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RO8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        public string GetRejectionOutVoucherNo(decimal decRejectionOutMasterId)
        {
            string strRejectionOutVoucherNo=string.Empty;
            try
            {
                strRejectionOutVoucherNo = spRejectionOutMaster.GetRejectionOutVoucherNo( decRejectionOutMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strRejectionOutVoucherNo;

        }
        public RejectionOutMasterInfo RejectionOutMasterView(decimal rejectionOutMasterId)
        {
            RejectionOutMasterInfo infoRejectionOutMaster = new RejectionOutMasterInfo();
            try
            {
                infoRejectionOutMaster = spRejectionOutMaster.RejectionOutMasterView(rejectionOutMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ROI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoRejectionOutMaster;
        }
        public string RejectionOutMasterGetMax(decimal decVoucherTypeId)
        {
            string max =string.Empty;
            try
            {
                max = spRejectionOutMaster.RejectionOutMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        public List<DataTable> RejectionOutMasterSearch(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spRejectionOutMaster.RejectionOutMasterSearch( strInvoiceNo,  decLedgerId,  FromDate,  ToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
 
        }
        public DataSet RejectionOutReportPrinting(decimal decmaterialReceiptMasterId, decimal decCompanyId, DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, string strProductCode, string strProductName)
        {
            DataSet dst = new DataSet();
            try
            {
                dst = spRejectionOutMaster.RejectionOutReportPrinting( decmaterialReceiptMasterId,  decCompanyId,  fromDate,  toDate,  decVoucherTypeId,  strVoucherNo,  decLedgerId,  strProductCode,  strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dst;
        }
        public List<DataTable> RejectionOutReportFill(string strinvoiceNo, string strProductCode, string strProductName, decimal decLedgerId, DateTime FromDate, DateTime ToDate, decimal decReceiptMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spRejectionOutMaster.RejectionOutReportFill( strinvoiceNo,  strProductCode,  strProductName,  decLedgerId,  FromDate,  ToDate,  decReceiptMasterId,  decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public List<DataTable> VoucherTypeComboFillForRejectionOutReport()
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spRejectionOutDetails.VoucherTypeComboFillForRejectionOutReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RO14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
    }
}
