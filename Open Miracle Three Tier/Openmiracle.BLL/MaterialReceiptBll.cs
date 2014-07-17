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
    public class MaterialReceiptBll
    {
        MaterialReceiptDetailsSP spMaterialReceiptDetails = new MaterialReceiptDetailsSP();
        MaterialReceiptMasterSP spMaterialReceiptMaster = new MaterialReceiptMasterSP();
        public List<DataTable> ShowMaterialReceiptDetailsViewbyMaterialReceiptDetailsIdWithPending(decimal decmaterialReceiptMasterId, decimal decrejectionOutMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptDetails.ShowMaterialReceiptDetailsViewbyMaterialReceiptDetailsIdWithPending(decmaterialReceiptMasterId, decrejectionOutMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public MaterialReceiptMasterInfo MaterialReceiptMasterView(decimal decMaterialReceiptMaster)
        {
            MaterialReceiptMasterInfo infoMaterialReceiptMaster = new MaterialReceiptMasterInfo();
            try
            {
                infoMaterialReceiptMaster = spMaterialReceiptMaster.MaterialReceiptMasterView(decMaterialReceiptMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoMaterialReceiptMaster;
        }
        public List<DataTable> ShowMaterialReceiptNoForRejectionOut(decimal decLedgerId, decimal decRejectionOutMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptMaster.ShowMaterialReceiptNoForRejectionOut(decLedgerId, decRejectionOutMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> MaterialReceiptMasterViewAll(string strInvoiceNo, decimal decLedgerId, DateTime FromDate, DateTime ToDate)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptMaster.MaterialReceiptMasterViewAll(strInvoiceNo, decLedgerId, FromDate, ToDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal MaterialReceiptMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal decMax = 0;
            try
            {
                decMax = spMaterialReceiptMaster.MaterialReceiptMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decMax;
        }
        public string MaterialReceiptMasterGetMax(decimal decVoucherTypeId)
        {
            string strMax = "0";
            try
            {
                strMax = spMaterialReceiptMaster.MaterialReceiptMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strMax;
        }
        public List<DataTable> GetOrderNoCorrespondingtoLedgerForMaterialReceiptRpt(decimal decLedgerId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptMaster.GetOrderNoCorrespondingtoLedgerForMaterialReceiptRpt(decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> MaterialReceiptNoCorrespondingToLedgerForReport(decimal decledgerid)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptMaster.MaterialReceiptNoCorrespondingToLedgerForReport(decledgerid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> MaterialReceiptMasterViewByReceiptMasterId(decimal decMaterialReceiptMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptMaster.MaterialReceiptMasterViewByReceiptMasterId(decMaterialReceiptMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> MaterialReceiptDetailsViewByMaterialReceiptMasterIdWithRemainingByNotInCurrPI(decimal decMaterialReceiptMasterId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptDetails.MaterialReceiptDetailsViewByMaterialReceiptMasterIdWithRemainingByNotInCurrPI(decMaterialReceiptMasterId, decVoucherTypeId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public decimal MaterialReceiptMasterReferenceCheck(decimal decMaterialReceiptMasterId)
        {
            decimal decStatus = 0;
            try
            {
                decStatus = spMaterialReceiptMaster.MaterialReceiptMasterReferenceCheck(decMaterialReceiptMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decStatus;
        }
        public decimal MaterialReceiptDelete(decimal decMaterialReceiptMasterId)
        {
            decimal decResult = 0;
            try
            {
                decResult = spMaterialReceiptMaster.MaterialReceiptDelete(decMaterialReceiptMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public decimal MaterialReceiptDetailsReferenceCheck(decimal decMaterialReceiptDetailsId)
        {
            decimal decStatus = 0;
            try
            {
                decStatus = spMaterialReceiptMaster.MaterialReceiptDetailsReferenceCheck(decMaterialReceiptDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decStatus;
        }
        public void MaterialReceiptDetailsDelete(decimal MaterialReceiptDetailsId)
        {
            try
            {
                spMaterialReceiptDetails.MaterialReceiptDetailsDelete(MaterialReceiptDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> MaterialReceiptDetailsViewByMasterId(decimal decMaterialReceiptMasterId)
        {
            List<DataTable> ListObl = new List<DataTable>();
            try
            {
                ListObl = spMaterialReceiptDetails.MaterialReceiptDetailsViewByMasterId(decMaterialReceiptMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObl;
        }
        public void MaterialReceiptDetailsEdit(MaterialReceiptDetailsInfo infoMaterialreceiptdetails)
        {
            try
            {
                spMaterialReceiptDetails.MaterialReceiptDetailsEdit(infoMaterialreceiptdetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MaterialReceiptDetailsAdd(MaterialReceiptDetailsInfo infoMaterialreceiptdetails)
        {
            try
            {
                spMaterialReceiptDetails.MaterialReceiptDetailsAdd(infoMaterialreceiptdetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal MaterialReceiptQuantityDetailsAgainstPurcahseInvoiceAndRejectionOut(decimal decMaterialReceiptDetailsId)
        {
            decimal decQty = 0;
            try
            {
                decQty = spMaterialReceiptMaster.MaterialReceiptQuantityDetailsAgainstPurcahseInvoiceAndRejectionOut(decMaterialReceiptDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decQty;
        }
        public void MaterialReceiptMasterEdit(MaterialReceiptMasterInfo infoMaterialreceiptmaster)
        {
            try
            {
                spMaterialReceiptMaster.MaterialReceiptMasterEdit(infoMaterialreceiptmaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DataSet MaterialReceiptPrinting(decimal decmaterialReceiptMasterId, decimal decCompanyId, decimal decOrderMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spMaterialReceiptMaster.MaterialReceiptPrinting(decmaterialReceiptMasterId, decCompanyId, decOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public bool MaterialReceiptNumberCheckExistence(string strinvoiceNo, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spMaterialReceiptMaster.MaterialReceiptNumberCheckExistence(strinvoiceNo, decVoucherTypeId);

            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public decimal MaterialReceiptMasterAdd(MaterialReceiptMasterInfo infoMaterialreceiptmaster)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spMaterialReceiptMaster.MaterialReceiptMasterAdd(infoMaterialreceiptmaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public List<DataTable> MaterialReceiptReportViewAll(decimal decOrderId, string strInvoiceNo, decimal decLedgerId, decimal decVouchertypeId, string strProductCode, DateTime FromDate, DateTime ToDate, string strStatus)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptMaster.MaterialReceiptReportViewAll(decOrderId, strInvoiceNo, decLedgerId, decVouchertypeId, strProductCode, FromDate, ToDate, strStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public DataSet MaterialReceiptReportPrinting(decimal decCompanyId, string strInvoiceNo, string strStatus, decimal decLedgerId, string strProductCode, decimal decVouchertypeId, DateTime FromDate, DateTime ToDate, decimal decOrderMasterId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spMaterialReceiptMaster.MaterialReceiptReportPrinting(decCompanyId, strInvoiceNo, strStatus, decLedgerId, strProductCode, decVouchertypeId, FromDate, ToDate, decOrderMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }
        public List<DataTable> VoucherTypeCombofillforMaterialReceipt()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spMaterialReceiptDetails.VoucherTypeCombofillforMaterialReceipt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MRBLL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
          
    }
}
