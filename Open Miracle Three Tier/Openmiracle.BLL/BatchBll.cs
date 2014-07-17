using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using OpenMiracle.BLL;
using System.Windows.Forms;
using System.Data;
namespace OpenMiracle.BLL
{
    public class BatchBll
    {
        BatchSP SPBatch = new BatchSP();
        public int AutomaticBarcodeGeneration()
        {
            int inBarcode = 0;

            try
            {

               inBarcode= SPBatch.AutomaticBarcodeGeneration();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inBarcode;

        }
        public bool BatchNameAndProductNameCheckExistence(String strBatchName, decimal decProductId, decimal decBatchId)
        {
            bool isResult = false;
            try
            {

                isResult=SPBatch.BatchNameAndProductNameCheckExistence(strBatchName, decProductId, decBatchId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public void BatchAddParticularFields(BatchInfo batchinfo)
        {
            try
            {

                SPBatch.BatchAddParticularFields(batchinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void BatchEdit(BatchInfo batchinfo)
        {
            try
            {

                SPBatch.BatchEdit(batchinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal BatchCheckReferences(decimal decBatchId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue=SPBatch.BatchCheckReferences(decBatchId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public List<DataTable> BatchSearch(String strBatchNo, String strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BatchSearch(strBatchNo, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public BatchInfo BatchView(decimal batchId)
        {
            BatchInfo batchinfo = new BatchInfo();
            try
            {
                batchinfo=SPBatch.BatchView(batchId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return batchinfo;
        }
        public List<DataTable> BarcodePrintingGrideFill(decimal decProductId, decimal decBatchId, decimal decPurchaseMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BarcodePrintingGrideFill(decProductId, decBatchId, decPurchaseMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
         public List<DataTable> BatchNamesCorrespondingToProduct(decimal decproductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BatchNamesCorrespondingToProduct(decproductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> BatchViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BatchViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal BatchIdViewByProductId(decimal decProductId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue=SPBatch.BatchIdViewByProductId(decProductId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public string ProductBatchBarcodeViewByBatchId(decimal decBathId)
        {
            string barCode = string.Empty;
            try
            {
               barCode= SPBatch.ProductBatchBarcodeViewByBatchId(decBathId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return barCode;
        
        }
        public List<DataTable> BatchViewAllByProductCodeForBarcodePrinting(decimal decProductId, ComboBox cmbBatch, bool isAll)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BatchViewAllByProductCodeForBarcodePrinting(decProductId, cmbBatch, isAll);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> BatchViewbyProductIdForComboFill(decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BatchViewbyProductIdForComboFill(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal BatchAddReturnIdentity(BatchInfo batchinfo)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue=SPBatch.BatchAddReturnIdentity(batchinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public BatchInfo BatchAndProductViewByBarcode(string strBarcode)
        {
            BatchInfo batchinfo = new BatchInfo();
            try
            {
                batchinfo=SPBatch.BatchAndProductViewByBarcode(strBarcode);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return batchinfo;
        }
        public decimal BatchViewByBarcode(string strBarcode)
        {
            decimal decReturnValue = 0;
            try
            {
               decReturnValue= SPBatch.BatchViewByBarcode(strBarcode);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
       public List<DataTable> BatchViewbyProductIdForComboFillInGrid(decimal decProductId, DataGridView dgvCurrent, int inRowIndex)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BatchViewbyProductIdForComboFillInGrid(decProductId, dgvCurrent, inRowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
       public int BatchAddWithBarCode(BatchInfo batchinfo)
       {
           int inReturnValue = 0;
           try
           {
               inReturnValue=SPBatch.BatchAddWithBarCode(batchinfo);
           }
           catch (Exception ex)
           {

               MessageBox.Show("BBll18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return inReturnValue;
       }
       public void DeleteBatchForProductUpdate(decimal decProductId)
       {
           try
           {
               SPBatch.DeleteBatchForProductUpdate(decProductId);
           }
           catch (Exception ex)
           {

               MessageBox.Show("BBll19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public List<DataTable> BatchNoViewByProductId(decimal decProductId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = SPBatch.BatchNoViewByProductId(decProductId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BBll20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public bool BatchEditForProductEdit(BatchInfo batchinfo)
       {
           bool isResult = false;
           try
           {

              isResult= SPBatch.BatchEditForProductEdit(batchinfo);
           }
           catch (Exception ex)
           {

               MessageBox.Show("BBll21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isResult;
       }
       public int BatchIdForStockPosting(decimal decProductId)
       {
           int inReturnValue = 0;
           try
           {
              inReturnValue= SPBatch.BatchIdForStockPosting(decProductId);
           }
           catch (Exception ex)
           {

               MessageBox.Show("BBll22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return inReturnValue;
       }
        public List<DataTable> BatchViewByName(string strBatch, decimal decProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBatch.BatchViewByName(strBatch, decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public AutoCompleteStringCollection BatchViewAllWithoutNA()
        {
            AutoCompleteStringCollection strCollection = new AutoCompleteStringCollection();
            try
            {
                strCollection= strCollection = SPBatch.BatchViewAllWithoutNA();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strCollection;
        }
        public void BatchDelete(decimal BatchId)
        {
            try
            {
                SPBatch.BatchDelete(BatchId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BBll25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
         public string PartNoReturn(decimal decProductId)
        {
            string strPartNo = string.Empty;
            try
            {
               strPartNo= SPBatch.PartNoReturn(decProductId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strPartNo;

        }
         public void PartNoUpdate(decimal decProductId, string strPartNo)
         {
             try
             {
                 SPBatch.PartNoUpdate(decProductId, strPartNo);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("BBll27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

         }
        public bool BatchNameExistenceChecking(string strBatchNo, decimal decBatchId)
        {
            bool isResult = false;
            try
            {

               isResult= SPBatch.BatchNameExistenceChecking(strBatchNo, decBatchId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public decimal BatchAddAndDelete(BatchInfo batchinfo, decimal decProductIdForEdit)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue=SPBatch.BatchAddAndDelete(batchinfo, decProductIdForEdit);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BBll29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
    }
}
