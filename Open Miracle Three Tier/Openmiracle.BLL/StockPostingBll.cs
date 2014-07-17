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
   public class StockPostingBll
    {
        StockPostingSP spStockPosting = new StockPostingSP();
        public void DeleteStockPostingForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
        {
          
           
            try
            {
                spStockPosting.DeleteStockPostingForStockJournalEdit(strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        public decimal StockPostingAdd(StockPostingInfo stockpostinginfo)
        {
            decimal decId = 0;
            try
            {
                decId=spStockPosting.StockPostingAdd(stockpostinginfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
           
        }
        public decimal StockCheckForProductSale(decimal decProductId, decimal decBatchId)
        {
            decimal decId = 0;
            try
            {
                decId = spStockPosting.StockCheckForProductSale(decProductId, decBatchId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public List<DataTable> StockReportGridFill1(String strProductName, decimal decBrandid, decimal decmodelNoId, string strproductCode, decimal decgodownId, decimal decrackId, decimal decsizeId, decimal dectaxId, decimal decgrpId, string strBatchName)
        {
           
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spStockPosting.StockReportGridFill1(strProductName, decBrandid, decmodelNoId, strproductCode, decgodownId, decrackId, decsizeId, dectaxId, decgrpId, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public void DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo(decimal decAgnstVouTypeId, string strAgnstVouNo)
        {
            try
            {
                spStockPosting.DeleteStockPostingByAgnstVouTypeIdAndAgnstVouNo(decAgnstVouTypeId, strAgnstVouNo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public decimal StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decId = 0;
            try
            {
                decId = spStockPosting.StockPostingDeleteByagainstVoucherTypeIdAndagainstVoucherNoAndVoucherNoAndVoucherType(decAgainstVoucherTypeId, strAgainstVoucherNo, strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public DataSet StockReportPrint(string strProductName, decimal decBrandid, decimal decmodelNoId, string strproductCode, decimal decgodownId, decimal decrackId, decimal decsizeId, decimal dectaxId, decimal decgrpId, string strBatchName)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spStockPosting.StockReportPrint(strProductName, decBrandid, decmodelNoId, strproductCode, decgodownId, decrackId, decsizeId, decsizeId, decgrpId, strBatchName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;

        }
        public void StpDeleteForProductUpdation(decimal decProductId)
        {
            try
            {
                spStockPosting.StpDeleteForProductUpdation(decProductId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void StockPostingDeleteByVoucherTypeAndVoucherNo(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                spStockPosting.StockPostingDeleteByVoucherTypeAndVoucherNo(strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal BatchViewByProductId(decimal decProductId)
        {
            decimal decId = 0;
            try
            {
                decId = spStockPosting.BatchViewByProductId(decProductId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public decimal ProductGetCurrentStock(decimal decProductId, decimal decGodownId, decimal decBatchId, decimal decRackId)
        {
            decimal decId = 0;
            try
            {
                decId = spStockPosting.ProductGetCurrentStock(decProductId, decGodownId, decBatchId, decRackId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public decimal StockPostingDeleteForSalesInvoiceAgainstDeliveryNote(decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, string strVoucherNo, decimal decVoucherTypeId)
        {
            decimal decId = 0;
            try
            {
                decId = spStockPosting.StockPostingDeleteForSalesInvoiceAgainstDeliveryNote
                        (decAgainstVoucherTypeId, strAgainstVoucherNo,
                        strVoucherNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public int ReturnBatchIdFromStockPosting(decimal decProductId)
        {
            int inId = 0;
            try
            {
                inId = spStockPosting.ReturnBatchIdFromStockPosting(decProductId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inId;

        }
        public bool StockPostingEdit(StockPostingInfo stockpostinginfo)
        {
           
            bool isEdit = false;
            try
            {

                isEdit = spStockPosting.StockPostingEdit(stockpostinginfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isEdit;
        }
        public bool StpDeleteForRowRemove(decimal decStpId)
        {
            bool isEdit = false;
            try
            {

                isEdit = spStockPosting.StpDeleteForRowRemove(decStpId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }

    }
}
