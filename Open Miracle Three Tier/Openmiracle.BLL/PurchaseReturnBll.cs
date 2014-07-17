using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms;

namespace OpenMiracle.BLL
{
   public class PurchaseReturnBll
    {
        /// <summary>
        /// Function to insert values to PurchaseReturnBilltax Table
        /// </summary>
        /// <param name="purchasereturnbilltaxinfo"></param>
       public void PurchaseReturnBilltaxAdd(PurchaseReturnBilltaxInfo purchasereturnbilltaxinfo)
       {
           PurchaseReturnBilltaxSP SPPurchaseReturnBilltax = new PurchaseReturnBilltaxSP();
           try
           {
               SPPurchaseReturnBilltax.PurchaseReturnBilltaxAdd(purchasereturnbilltaxinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// FUnction to use the Vouchertype combofill for purchase return
       /// </summary>
       /// <returns></returns>
       public List<DataTable> VoucherTypeComboFillForPurchaseReturn()
       {
           PurchaseReturnDetailsSP SPPurchaseReturnDetails = new PurchaseReturnDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseReturnDetails.VoucherTypeComboFillForPurchaseReturn();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Get InvoiceNo Corresponding to Ledger For PurchaseReturn Register
       /// </summary>
       /// <param name="decLedgerId"></param>
       /// <returns></returns>
       public List<DataTable> GetInvoiceNoCorrespondingtoLedgerForPurchaseReturnReport(decimal decLedgerId, decimal decVoucherId)
       {
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseReturnMaster.GetInvoiceNoCorrespondingtoLedgerForPurchaseReturnReport(decLedgerId, decVoucherId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;

       }
       /// <summary>
       /// Function to get the details of PurchaseReturn Report
       /// </summary>
       /// <param name="fromDate"></param>
       /// <param name="toDate"></param>
       /// <param name="decLedgerId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="decInvoiceNo"></param>
       /// <param name="strProductCode"></param>
       /// <param name="strVoucherNo"></param>
       /// <returns></returns>
       public List<DataTable> PurchaseReturnReportGridFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, decimal decVoucherTypeId, decimal decInvoiceNo, string strProductCode, string strVoucherNo)
       {
           
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseReturnMaster.PurchaseReturnReportGridFill(fromDate, toDate, decLedgerId, decVoucherTypeId, decInvoiceNo, strProductCode, strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;

       }
       /// <summary>
       /// Function to insert values to accountgroup Table and return the Curresponding row's Id
       /// </summary>
       /// <param name="purchasereturndetailsinfo"></param>
       /// <returns></returns>
       public decimal PurchaseReturnDetailsAddWithReturnIdentity(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
       {
           PurchaseReturnDetailsSP SPPurchaseReturnDetails = new PurchaseReturnDetailsSP();
           decimal decIdentity = 0;
           try
           {
               decIdentity = SPPurchaseReturnDetails.PurchaseReturnDetailsAddWithReturnIdentity(purchasereturndetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decIdentity;

       }
       /// <summary>
       /// Function to Update values in accountgroup Table
       /// </summary>
       /// <param name="purchasereturndetailsinfo"></param>
       public void PurchaseReturnDetailsEdit(PurchaseReturnDetailsInfo purchasereturndetailsinfo)
       {
           PurchaseReturnDetailsSP SPPurchaseReturnDetails = new PurchaseReturnDetailsSP();
           
           try
           {
               SPPurchaseReturnDetails.PurchaseReturnDetailsEdit(purchasereturndetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           

       }
       /// <summary>
       /// Function to insert values to PurchaseReturnMaster Table
       /// </summary>
       /// <param name="purchasereturnmasterinfo"></param>
       /// <returns></returns>
       public decimal PurchaseReturnMasterAddWithReturnIdentity(PurchaseReturnMasterInfo purchasereturnmasterinfo)
       {
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           decimal decIdentity = 0; 
           try
           {
               decIdentity = SPPurchaseReturnMaster.PurchaseReturnMasterAddWithReturnIdentity(purchasereturnmasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decIdentity;

       }
       /// <summary>
       /// Function to insert values to PurchaseReturnMaster Table
       /// </summary>
       /// <param name="purchasereturnmasterinfo"></param>
       /// <returns></returns>
       public void PurchaseReturnMasterEdit(PurchaseReturnMasterInfo purchasereturnmasterinfo)
       {
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
          
           try
           {
               SPPurchaseReturnMaster.PurchaseReturnMasterEdit(purchasereturnmasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           

       }
       /// <summary>
       /// Function to get particular values from PurchaseReturnMaster table based on the parameter
       /// </summary>
       /// <param name="purchaseReturnMasterId"></param>
       /// <returns></returns>
       public PurchaseReturnMasterInfo PurchaseReturnMasterView(decimal purchaseReturnMasterId)
       {
         
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           PurchaseReturnMasterInfo infopurchasereturnmaster = new PurchaseReturnMasterInfo();
           try
           {
               infopurchasereturnmaster = SPPurchaseReturnMaster.PurchaseReturnMasterView(purchaseReturnMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infopurchasereturnmaster;

       }
       /// <summary>
       /// Function to delete particular details based on the parameter From Table BankReconciliation
       /// </summary>
       /// <param name="PurchaseReturnDetailsId"></param>
       public void PurchaseReturnDetailsDelete(decimal PurchaseReturnDetailsId)
       {

          
           PurchaseReturnDetailsSP SPPurchaseReturnDetails = new PurchaseReturnDetailsSP();
           try
           {
               SPPurchaseReturnDetails.PurchaseReturnDetailsDelete(PurchaseReturnDetailsId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           

       }
       /// <summary>
       /// Function to get particular values from PurchaseReturnMaster table based on the parameter
       /// </summary>
       /// <param name="decPurchaseReturnMasterId"></param>
       /// <returns></returns>
       public List<DataTable> PurchaseReturnViewByPurchaseReturnMasterId(decimal decPurchaseReturnMasterId)
       {
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseReturnMaster.PurchaseReturnViewByPurchaseReturnMasterId(decPurchaseReturnMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Function to get details for printing purchase return 
       /// </summary>
       /// <param name="decPurchaseReturnMasterId"></param>
       /// <param name="decCompanyId"></param>
       /// <param name="decPurchaseMasterId"></param>
       /// <returns></returns>
       public DataSet PurchaseReturnPrinting(decimal decPurchaseReturnMasterId, decimal decCompanyId, decimal decPurchaseMasterId)
       {
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           DataSet ds = new DataSet();
           try
           {
               ds = SPPurchaseReturnMaster.PurchaseReturnPrinting( decPurchaseReturnMasterId,  decCompanyId,  decPurchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ds;
       }
       /// <summary>
       /// Function to get particular values from PurchaseReturnMaster table based on the parameter
       /// </summary>
       /// <param name="decPurchaseMasterId"></param>
       /// <returns></returns>
       public List<DataTable> PurchaseReturnMasterViewByPurchaseMasterId(decimal decPurchaseMasterId)
       {
           PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseReturnMaster.PurchaseReturnMasterViewByPurchaseMasterId(decPurchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }

       /// <summary>
       /// Function to get the PurchaseReturn Details  By Purchase return MasterId
       /// </summary>
       /// <param name="decPurchaseReturnMasterId"></param>
       /// <returns></returns>
       public List<DataTable> PurchaseReturnDetailsViewByMasterId(decimal decPurchaseReturnMasterId)
       {
           PurchaseReturnDetailsSP SPPurchaseReturnDetails = new PurchaseReturnDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseReturnDetails.PurchaseReturnDetailsViewByMasterId(decPurchaseReturnMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PrBll 14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Function to  get the next id for PurchaseReturnMaster table
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
         public decimal PurchaseReturnMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
            decimal max = 0;
            try
            {
                max = SPPurchaseReturnMaster.PurchaseReturnMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PrBll 15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return max;
        }
         /// <summary>
         /// Function to  get the next id for PurchaseReturnMaster table
         /// </summary>
         /// <param name="decVoucherTypeId"></param>
         /// <returns></returns>
        public string PurchaseReturnMasterGetMax(decimal decVoucherTypeId)
        {
            PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
            string max = "0";
            try
            {
                max = SPPurchaseReturnMaster.PurchaseReturnMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PrBll 16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return max;
        }
        /// <summary>
        /// Function to get tax rate from purchase details
        /// </summary>
        /// <param name="taxId"></param>
        /// <returns></returns>
         public string TaxRateFromPurchaseDetails(decimal taxId)
        {
            PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
            string max = "0";
            try
            {
                max = SPPurchaseReturnMaster.TaxRateFromPurchaseDetails(taxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PrBll 17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return max;
        }
         /// <summary>
         /// Function to check existance of purchase return number 
         /// </summary>
         /// <param name="strinvoiceNo"></param>
         /// <param name="decVoucherTypeId"></param>
         /// <returns></returns>
        public bool PurchaseReturnNumberCheckExistence(string strinvoiceNo, decimal decVoucherTypeId)
        {
            bool isEdit = false;
            PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
           
            try
            {
                isEdit = SPPurchaseReturnMaster.PurchaseReturnNumberCheckExistence(strinvoiceNo, decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PrBll 18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return isEdit;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="decPurchaseReturnMasterId"></param>
        public void PurchaseReturnMasterAndDetailsDelete(decimal decPurchaseReturnMasterId)
        {
            PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();

            try
            {
                SPPurchaseReturnMaster.PurchaseReturnMasterAndDetailsDelete(decPurchaseReturnMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PrBll 19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }
        /// <summary>
        /// Function to get details for PurchaseReturn Register
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="decLedgerId"></param>
        /// <param name="strInvoiceNo"></param>
        /// <param name="decAgainstInvoiceNo"></param>
        /// <returns></returns>
        public List<DataTable> PurchaseReturnRegisterFill(DateTime fromDate, DateTime toDate, decimal decLedgerId, string strInvoiceNo, decimal decAgainstInvoiceNo, decimal decVoucherType)
        {
            PurchaseReturnMasterSP SPPurchaseReturnMaster = new PurchaseReturnMasterSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPPurchaseReturnMaster.PurchaseReturnRegisterFill(fromDate, toDate, decLedgerId, strInvoiceNo, decAgainstInvoiceNo, decVoucherType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PrBll 20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return ListObj;
        }
        /// <summary>
        /// Function to use the PurchaseReturn Details Qty View By PurchaseDetailsId for Purchase Invoice
        /// </summary>
        /// <param name="decPurchaseDetailsId"></param>
        /// <returns></returns>
        public decimal PurchaseReturnDetailsQtyViewByPurchaseDetailsId(decimal decPurchaseDetailsId)
    {
        decimal decQty = 0;

        PurchaseReturnDetailsSP SPPurchaseReturnDetails = new PurchaseReturnDetailsSP();

            try
            {
                decQty = SPPurchaseReturnDetails.PurchaseReturnDetailsQtyViewByPurchaseDetailsId(decPurchaseDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PrBll 21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return decQty;
            
        }
    }
}
