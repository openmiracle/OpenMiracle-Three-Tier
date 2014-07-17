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
    public class RejectionInBll
    {
        RejectionInDetailsSP spRejectionInDetails = new RejectionInDetailsSP();
        RejectionInMasterSP spRejectionInMaster = new RejectionInMasterSP();
        public void DeleteRejectionInDetailsByRejectionInMasterId(decimal decRejectionInMasterId)
        {
            try
            {
                spRejectionInDetails.DeleteRejectionInDetailsByRejectionInMasterId(decRejectionInMasterId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RI1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public List<DataTable> RejectionInDetailsViewByRejectionInMasterId(decimal decRejectionInMasterId)
        {

            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spRejectionInDetails.RejectionInDetailsViewByRejectionInMasterId(decRejectionInMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public RejectionInMasterInfo RejectionInMasterView(decimal rejectionInMasterId)
        {
            RejectionInMasterInfo infoRejectionInMaster = new RejectionInMasterInfo();
            try
            {
                infoRejectionInMaster = spRejectionInMaster.RejectionInMasterView(rejectionInMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoRejectionInMaster;
        }
        public void RejectionInDetailsAdd(RejectionInDetailsInfo rejectionindetailsinfo)
        {
            try
            {
                spRejectionInDetails.RejectionInDetailsAdd(rejectionindetailsinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RI4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string GetRejectionInVoucherNo(decimal decRejectionInMasterId)
        {
            string strRejectionInVoucherNo = string.Empty;
            try
            {
                strRejectionInVoucherNo = spRejectionInMaster.GetRejectionInVoucherNo(decRejectionInMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strRejectionInVoucherNo;

        }
        public List<DataTable> CurrencyComboByDate(ComboBox cmbCurrency, DateTime date, bool isAll)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spRejectionInMaster.CurrencyComboByDate(cmbCurrency, date, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public decimal RejectionInMasterAdd(RejectionInMasterInfo rejectioninmasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spRejectionInMaster.RejectionInMasterAdd(rejectioninmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public void RejectionInMasterEdit(RejectionInMasterInfo rejectioninmasterinfo)
        {
            try
            {
                spRejectionInMaster.RejectionInMasterEdit(rejectioninmasterinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RI8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void RejectionInMasterAndDetailsDelete(decimal decRejectionInMasterId)
        {
            try
            {
                spRejectionInMaster.RejectionInMasterAndDetailsDelete(decRejectionInMasterId);

            }
            catch (Exception ex)
            {

                MessageBox.Show("RI9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool RejectionInVoucherNoCheckExistence(string strvoucherNo, decimal decVoucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                trueOrfalse = spRejectionInMaster.RejectionInVoucherNoCheckExistence(strvoucherNo, decVoucherTypeId, decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
        public List<DataTable> RejectionInRegisterFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strVoucherNo, decimal decVoucherTypeId)
        {
            List<DataTable> list = new List<DataTable>();
            try
            {
                list = spRejectionInMaster.RejectionInRegisterFill(fromDate, toDate, decLedgerId, strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public List<DataTable> RejectionInReportFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decDeliveryNoteMasterId, decimal decEmployeeId, string strProductCode)
        {
            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spRejectionInMaster.RejectionInReportFill(fromDate, toDate, decVoucherTypeId, strVoucherNo, decLedgerId, decDeliveryNoteMasterId, decEmployeeId, strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public List<DataTable> VoucherTypeSelectionFill(ComboBox cmbVoucherType, string strVoucherType, bool isAll)
        {

            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spRejectionInMaster.VoucherTypeSelectionFill(cmbVoucherType, strVoucherType, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;
        }
        public List<DataTable> DeliveryNoteNoComboFillToLedger(ComboBox cmbDeliveryNoteNo, decimal decLedgerId, bool isAll)
        {

            List<DataTable> list = new List<DataTable>();

            try
            {
                list = spRejectionInMaster.DeliveryNoteNoComboFillToLedger(cmbDeliveryNoteNo, decLedgerId, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return list;

        }
        public DataSet RejectionInReportPrinting(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decDlvryNteMstrId, decimal decEmployeeId, string strProductCode)
        {
            DataSet dst = new DataSet();
            try
            {
                dst = spRejectionInMaster.RejectionInReportPrinting(fromDate, toDate, decVoucherTypeId, strVoucherNo, decLedgerId, decDlvryNteMstrId, decEmployeeId, strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dst;
        }
        public DataSet RejectionInPrinting(decimal decRejectionInMasterId, decimal decCompanyId)
        {
            DataSet dst = new DataSet();
            try
            {
                dst = spRejectionInMaster.RejectionInPrinting(decRejectionInMasterId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RI15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dst;

        }

    }

}
