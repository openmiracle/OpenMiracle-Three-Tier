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
    public class RecieptVoucherBll
    {
        //ReceiptDetailsSP spReceiptDetails = new ReceiptDetailsSP();
        //ReceiptDetailsInfo infoReceiptDetails = new ReceiptDetailsInfo();
        //ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
        //ReceiptMasterInfo infoReceiptMaster = new ReceiptMasterInfo();

        public decimal ReceiptDetailsAdd(ReceiptDetailsInfo receiptdetailsinfo)
        {
            decimal decReceiptDetailsId = 0;
            try
            {
                ReceiptDetailsSP spReceiptDetails = new ReceiptDetailsSP();
                decReceiptDetailsId = spReceiptDetails.ReceiptDetailsAdd(receiptdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReceiptDetailsId;
        }

        public void ReceiptDetailsDelete(decimal ReceiptDetailsId)
        {

            try
            {
                ReceiptDetailsSP spReceiptDetails = new ReceiptDetailsSP();
                spReceiptDetails.ReceiptDetailsDelete(ReceiptDetailsId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("RD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public decimal ReceiptDetailsEdit(ReceiptDetailsInfo receiptdetailsinfo)
        {
            decimal decReceiptDetailsId = 0;
            try
            {
                ReceiptDetailsSP spReceiptDetails = new ReceiptDetailsSP();
                decReceiptDetailsId = spReceiptDetails.ReceiptDetailsAdd(receiptdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReceiptDetailsId;
        }

        public List<DataTable> ReceiptDetailsViewByMasterId(decimal decreceiptMastertId)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                ReceiptDetailsSP spReceiptDetails = new ReceiptDetailsSP();
                listobj = spReceiptDetails.ReceiptDetailsViewByMasterId(decreceiptMastertId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public void ReceiptVoucherDelete(decimal decReceiptMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                spReceiptMaster.ReceiptVoucherDelete(decReceiptMasterId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public decimal ReceiptMasterGetMax(decimal decVoucherTypeId)
        {
            decimal decMax = 0;
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                decMax = spReceiptMaster.ReceiptMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decMax;
        }
        public decimal ReceiptMasterAdd(ReceiptMasterInfo receiptmasterinfo)
        {
            decimal decRecieptMasterId = 0;
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                decRecieptMasterId = spReceiptMaster.ReceiptMasterAdd(receiptmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decRecieptMasterId;
        }
        public decimal ReceiptMasterEdit(ReceiptMasterInfo receiptmasterinfo)
        {
            decimal decRecieptMasterId = 0;
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                decRecieptMasterId = spReceiptMaster.ReceiptMasterEdit(receiptmasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decRecieptMasterId;
        }
        public DataSet ReceiptVoucherPrinting(decimal decPaymentMasterId)
        {
            DataSet dst = new DataSet();
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                dst = spReceiptMaster.ReceiptVoucherPrinting(decPaymentMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dst;
        }
        public bool ReceiptVoucherCheckExistence(string strvoucherNo, decimal decvoucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                trueOrfalse = spReceiptMaster.ReceiptVoucherCheckExistence(strvoucherNo, decvoucherTypeId, decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
        public ReceiptMasterInfo ReceiptMasterViewByMasterId(decimal decReceiptMastertId)
        {
            ReceiptMasterInfo infoReceiptMaster = new ReceiptMasterInfo();
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                infoReceiptMaster = spReceiptMaster.ReceiptMasterViewByMasterId(decReceiptMastertId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoReceiptMaster;
        }
        public DataSet ReceiptReportPrinting(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId, decimal decCompanyId)
        {
            DataSet dSreportPrinting = new DataSet();

            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                dSreportPrinting = spReceiptMaster.ReceiptReportPrinting(dtpFromDate, dtpToDate, decLedgerId, decVoucherTypeId, decCashOrBankId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSreportPrinting;
        }
        public List<DataTable> ReceiptReportSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decCashOrBankId)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                listobj = spReceiptMaster.ReceiptReportSearch(dtpFromDate, dtpToDate, decLedgerId, decVoucherTypeId, decCashOrBankId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;

        }
        public decimal ReceiptMasterIdView(decimal decVouchertypeid, string strVoucherNo)
        {
            decimal decid = 0;
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                decid = spReceiptMaster.ReceiptMasterIdView(decVouchertypeid, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decid;

        }
        public List<DataTable> ReceiptMasterSearch(DateTime dtpFromDate, DateTime dtpToDate, decimal decledgerId, string strvoucherNo)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
                listobj = spReceiptMaster.ReceiptMasterSearch(dtpFromDate, dtpToDate, decledgerId, strvoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RD15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;


        }



    }
}
