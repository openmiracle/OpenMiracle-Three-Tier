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
   public class PurchaseInvoiceBll
    {
        /// <summary>
        /// Function to get all the values from PurchaseBillTax Table by purchasemasterid
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
       public List<DataTable> PurchaseBillTaxViewAllByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            PurchaseBillTaxSP SpPurchaseBillTax = new PurchaseBillTaxSP();
             List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj= SpPurchaseBillTax.PurchaseBillTaxViewAllByPurchaseMasterId(decPurchaseMasterId);
            }
            catch(Exception ex)
            {
                MessageBox.Show("PIBll 1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            return ListObj;
        }
       /// <summary>
       /// Function to insert values to PurchaseBillTax Table
       /// </summary>
       /// <param name="purchasebilltaxinfo"></param>
       public void PurchaseBillTaxAdd(PurchaseBillTaxInfo purchasebilltaxinfo)
        {
            PurchaseBillTaxSP SpPurchaseBillTax = new PurchaseBillTaxSP();
            try
            {
                SpPurchaseBillTax.PurchaseBillTaxAdd(purchasebilltaxinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIBll 2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
       /// <summary>
       /// Function to Update values in PurchaseBillTax Table
       /// </summary>
       /// <param name="purchasebilltaxinfo"></param>
       public void PurchaseBillTaxEdit(PurchaseBillTaxInfo purchasebilltaxinfo)
        {
            PurchaseBillTaxSP SpPurchaseBillTax = new PurchaseBillTaxSP();
            try
            {
                SpPurchaseBillTax.PurchaseBillTaxEdit(purchasebilltaxinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PIBll 3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="PurchaseBillTaxId"></param>
       public void PurchaseBillTaxDelete(decimal PurchaseBillTaxId)
       {
           PurchaseBillTaxSP SpPurchaseBillTax = new PurchaseBillTaxSP();
           
           try
           {
               SpPurchaseBillTax.PurchaseBillTaxDelete(PurchaseBillTaxId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// Function to get details for vouchertype combobox for purchase invoice
       /// </summary>
       /// <returns></returns>
       public List<DataTable> VoucherTypeComboFillForPurchaseInvoice()
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseDetails.VoucherTypeComboFillForPurchaseInvoice();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }


       /// <summary>
       /// Function to get particular values from PurchaseDetails table based on purchasemasterid with pending quantity
       /// </summary>
       /// <param name="decPurchaseMasterId"></param>
       /// <param name="decPurchaseReturnMasterId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public List<DataTable> PurchaseDetailsViewByPurchaseMasterIdWithRemaining(decimal decPurchaseMasterId, decimal decPurchaseReturnMasterId, decimal decVoucherTypeId)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseDetails.PurchaseDetailsViewByPurchaseMasterIdWithRemaining(decPurchaseMasterId, decPurchaseReturnMasterId, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Function to insert values to PurchaseDetails Table
       /// </summary>
       /// <param name="purchasedetailsinfo"></param>
       public void PurchaseDetailsAdd(PurchaseDetailsInfo purchasedetailsinfo)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           try
           {
               SPPurchaseDetails.PurchaseDetailsAdd(purchasedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// Function to get particular values from PurchaseDetails table by productName
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strProductName"></param>
       /// <returns></returns>
       public List<DataTable> PurchaseDetailsViewByProductNameForPI(decimal decVoucherTypeId, string strProductName)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseDetails.PurchaseDetailsViewByProductNameForPI(decVoucherTypeId, strProductName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="PurchaseDetailsId"></param>
       public void PurchaseDetailsDelete(decimal PurchaseDetailsId)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();

           try
           {
               SPPurchaseDetails.PurchaseDetailsDelete(PurchaseDetailsId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// Function to delete from PurchaseDetails table by PurchaseMasterId
       /// </summary>
       /// <param name="decPurchaseMasterId"></param>
       public void PurchaseDetailsDeleteByPurchaseMasterId(decimal decPurchaseMasterId)
       {
           PurchaseDetailsSP SPPurchaseDetails = new DAL.PurchaseDetailsSP();

           try
           {
               SPPurchaseDetails.PurchaseDetailsDeleteByPurchaseMasterId(decPurchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// Function to get particular values from PurchaseDetails table by productName
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strProductName"></param>
       /// <returns></returns>
       public List<DataTable> PurchaseDetailsViewByBarcodeForPI(decimal decVoucherTypeId, string strBarcode)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseDetails.PurchaseDetailsViewByBarcodeForPI(decVoucherTypeId, strBarcode);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Function to get particular values from PurchaseDetails table by purchasemasterid
       /// </summary>
       /// <param name="decPurchaseMasterId"></param>
       /// <returns></returns>

       public List<DataTable> PurchaseDetailsViewByPurchaseMasterId(decimal decPurchaseMasterId)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseDetails.PurchaseDetailsViewByPurchaseMasterId(decPurchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }

       /// <summary>
       /// Function to get the details for PurchaseInvoice Register
       /// </summary>
       /// <param name="strColumn"></param>
       /// <param name="dtFromDate"></param>
       /// <param name="dtToDate"></param>
       /// <param name="decLedgerId"></param>
       /// <param name="strPurchaseMode"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strInvoiceNo"></param>
       /// <returns></returns>

       public List<DataTable> PurchaseInvoiceRegisterFill(string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strPurchaseMode, decimal decVoucherTypeId, string strInvoiceNo)
       {
           PurchaseMasterSP SPPurchaseMaster=new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.PurchaseInvoiceRegisterFill(strColumn,dtFromDate,dtToDate,decLedgerId,strPurchaseMode,decVoucherTypeId,strInvoiceNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Function to fill purchase account combobox
       /// </summary>
       /// <returns></returns>
       public List<DataTable> PurchaseInvoicePurchaseAccountFill()
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.PurchaseInvoicePurchaseAccountFill();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       /// <summary>
       /// Function to get particular values from PurchaseMaster table based on the parameter
       /// </summary>
       /// <param name="purchaseMasterId"></param>
       /// <returns></returns>
       public PurchaseMasterInfo PurchaseMasterView(Decimal purchaseMasterId)
       {
           PurchaseMasterInfo purchasemasterinfo = new PurchaseMasterInfo();
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
          
           try
           {
               purchasemasterinfo = SPPurchaseMaster.PurchaseMasterView(purchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return purchasemasterinfo;
       }


       public List<DataTable> AccountLedgerViewForAdditionalCost()
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.AccountLedgerViewForAdditionalCost();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }


       public decimal PurchaseMasterVoucherMax(decimal decVoucherTypeId)
       {
           PurchaseMasterInfo purchasemasterinfo = new PurchaseMasterInfo();
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           decimal decVoucherNoMax = 0;
           try
           {
               decVoucherNoMax = SPPurchaseMaster.PurchaseMasterVoucherMax(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return decVoucherNoMax;
       }



       public int PurchaseMasterReferenceCheck(decimal decPurchaseMasterId, decimal decPurchaseDetailsId)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           int inQty = 0;
           try
           {
               inQty = SPPurchaseMaster.PurchaseMasterReferenceCheck(decPurchaseMasterId, decPurchaseDetailsId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return inQty;
       }

       public int PurchaseInvoiceVoucherNoCheckExistance(string strInvoiceNo, string strVoucherNo, decimal decVoucherTypeId, decimal decPurchaseMasterId)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           int inRef = 0;
           try
           {
               inRef = SPPurchaseMaster.PurchaseInvoiceVoucherNoCheckExistance(strInvoiceNo, strVoucherNo, decVoucherTypeId, decPurchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return inRef;
       }

       public List<DataTable> GetMaterialReceiptNoCorrespondingtoLedgerByNotInCurrPI(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.GetMaterialReceiptNoCorrespondingtoLedgerByNotInCurrPI(decLedgerId, decPurchaseMasterId, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }

       public List<DataTable> GetOrderNoCorrespondingtoLedgerByNotInCurrPI(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherType)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           
           try
           {
               ListObj = SPPurchaseMaster.GetOrderNoCorrespondingtoLedgerByNotInCurrPI(decLedgerId, decPurchaseMasterId, decVoucherType);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }

       public decimal PurchaseMasterAdd(PurchaseMasterInfo purchasemasterinfo)
       {
           
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           decimal decPurchaseMasterId = 0;
           try
           {
               decPurchaseMasterId = SPPurchaseMaster.PurchaseMasterAdd(purchasemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return decPurchaseMasterId;
       }

       public void PurchaseMasterEdit(PurchaseMasterInfo purchasemasterinfo)
       {

           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();

           try
           {
                SPPurchaseMaster.PurchaseMasterEdit(purchasemasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
       }

       public void PurchaseMasterDelete(decimal PurchaseMasterId)
       {

           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();

           try
           {
               SPPurchaseMaster.PurchaseMasterDelete(PurchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
       }


       public DataSet PurchaseInvoicePrinting(decimal decCompanyId, decimal decPurchaseOrderMasterId, decimal decMaterialReceiptMasterId, decimal decPurchaseMasterId)
       {

           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           DataSet ds = new DataSet();
           try
           {
              ds =SPPurchaseMaster.PurchaseInvoicePrinting(decCompanyId, decPurchaseOrderMasterId, decMaterialReceiptMasterId, decPurchaseMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ds;
       }

       public List<DataTable> GetInvoiceNoCorrespondingtoLedgerInRegister()
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.GetInvoiceNoCorrespondingtoLedgerInRegister();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }

       public List<DataTable> GetInvoiceNoCorrespondingtoLedger(decimal decLedgerId, decimal decPurchaseMasterId, decimal decVoucherTypeId)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.GetInvoiceNoCorrespondingtoLedger(decLedgerId, decPurchaseMasterId, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }

       public DataSet PurchaseInvoiceReportPrinting(decimal decCompanyId, string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strStatus,
                    string strPurchaseMode, decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, decimal decVoucherTypeId, string strVoucherNo,
                   string strProductCode, string strProductName)
          
           
       { 
        DataSet ds = new DataSet();
             PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
       
       try
           {
               ds = SPPurchaseMaster.PurchaseInvoiceReportPrinting(decCompanyId,strColumn, dtFromDate, dtToDate,decLedgerId,strStatus,
                    strPurchaseMode,decAgainstVoucherTypeId,strAgainstVoucherNo,decVoucherTypeId,strVoucherNo,
                   strProductCode,strProductName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ds;
       }

       public List<DataTable> PurchaseInvoiceReportFill(decimal decCompanyId, string strColumn, DateTime dtFromDate, DateTime dtToDate, decimal decLedgerId, string strStatus,
             string strPurchaseMode, decimal decAgainstVoucherTypeId, string strAgainstVoucherNo, decimal decVoucherTypeId, string strVoucherNo,
            string strProductCode, string strProductName)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.PurchaseInvoiceReportFill( decCompanyId,strColumn,dtFromDate,dtToDate,decLedgerId,strStatus,
             strPurchaseMode,decAgainstVoucherTypeId,strAgainstVoucherNo,decVoucherTypeId,strVoucherNo,
            strProductCode,strProductName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       public decimal PurchaseMasterIdViewByvoucherNoAndVoucherType(decimal decVouchertypeid, string strVoucherNo)
       {

           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           decimal decid = 0;
           try
           {
               decid = SPPurchaseMaster.PurchaseMasterIdViewByvoucherNoAndVoucherType(decVouchertypeid,strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return decid;
       }

       public List<DataTable> GetOrderNoCorrespondingtoLedger(decimal decLedgerId, decimal decReceiptMasterId, decimal decVoucherTypeId)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.GetOrderNoCorrespondingtoLedger(decLedgerId, decReceiptMasterId, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }

       public void PurchaseDetailsEdit(PurchaseDetailsInfo purchasedetailsinfo)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           try
           {
               SPPurchaseDetails.PurchaseDetailsEdit(purchasedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       public List<DataTable> PurchaseDetailsViewByProductCodeForPI(decimal decVoucherTypeId, string strProductName)
       {
           PurchaseDetailsSP SPPurchaseDetails = new PurchaseDetailsSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseDetails.PurchaseDetailsViewByProductCodeForPI(decVoucherTypeId, strProductName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 32:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       public List<DataTable> PurchaseInvoiceNoViewAllForBarcodePrinting(ComboBox cmbPurchaseInvoice, bool isAll)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.PurchaseInvoiceNoViewAllForBarcodePrinting(cmbPurchaseInvoice, isAll);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }


       public List<DataTable> PurchaseInvoiceNoViewAllByProductCodeAndBatchNoForBarcodePrinting(decimal decProductId, decimal decBatchId, ComboBox cmbPurchaseInvoice, bool isAll)
       {
           PurchaseMasterSP SPPurchaseMaster = new PurchaseMasterSP();
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = SPPurchaseMaster.PurchaseInvoiceNoViewAllByProductCodeAndBatchNoForBarcodePrinting(decProductId, decBatchId, cmbPurchaseInvoice, isAll);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PIBll 34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }
           return ListObj;
       }
       }
    }

