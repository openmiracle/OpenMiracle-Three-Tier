using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
    public class PurchaseDetailsBll
    {
        PurchaseDetailsSP spPurchaseDetails = new PurchaseDetailsSP();
        PurchaseDetailsInfo purchasedetailsinfo = new PurchaseDetailsInfo();
        public void PurchaseDetailsAdd(PurchaseDetailsInfo infoPurchaseDetails)
        {
            try
            {
                spPurchaseDetails.PurchaseDetailsAdd(infoPurchaseDetails);
            }

            catch (Exception ex)
            {
                MessageBox.Show("PD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PurchaseDetailsEdit(PurchaseDetailsInfo infoPurchaseDetails)
        {
            try
            {
                spPurchaseDetails.PurchaseDetailsEdit(infoPurchaseDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PurchaseDetailsDelete(decimal decPurchaseDetailsId)
        {
            try
            {
                spPurchaseDetails.PurchaseDetailsDelete(decPurchaseDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PurchaseDetailsDeleteByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            try
            {
                spPurchaseDetails.PurchaseDetailsDelete(decPurchaseMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> PurchaseDetailsViewByProductCodeForPI(decimal decVoucherTypeId, string strProductCode)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spPurchaseDetails.PurchaseDetailsViewByProductCodeForPI(decVoucherTypeId, strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> PurchaseDetailsViewByProductNameForPI(decimal decVoucherTypeId, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spPurchaseDetails.PurchaseDetailsViewByProductNameForPI(decVoucherTypeId, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> PurchaseDetailsViewByBarcodeForPI(decimal decVoucherTypeId, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spPurchaseDetails.PurchaseDetailsViewByBarcodeForPI(decVoucherTypeId, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> VoucherTypeComboFillForPurchaseInvoice()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                spPurchaseDetails.VoucherTypeComboFillForPurchaseInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> PurchaseDetailsViewByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj=spPurchaseDetails.PurchaseDetailsViewByPurchaseMasterId(decPurchaseMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> PurchaseDetailsViewByPurchaseMasterIdWithRemaining(decimal decPurchaseMasterId, decimal decPurchaseReturnMasterId, decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                spPurchaseDetails.PurchaseDetailsViewByPurchaseMasterIdWithRemaining(decPurchaseMasterId, decPurchaseReturnMasterId, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PD9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }
}
