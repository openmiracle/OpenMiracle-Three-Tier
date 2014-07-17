using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
   public  class PDCClearanceMasterBll
    {
       PDCClearanceMasterSP spPDCClearanceMaster = new PDCClearanceMasterSP();
       PDCClearanceMasterInfo infoPDCClearanceMaster = new PDCClearanceMasterInfo();
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public List<DataTable> VouchertypeComboFill()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spPDCClearanceMaster.VouchertypeComboFill();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtFromdate"></param>
       /// <param name="dtTodate"></param>
       /// <param name="strLedgerName"></param>
       /// <param name="voucherTypeName"></param>
       /// <param name="strchequeNo"></param>
       /// <param name="decBankId"></param>
       /// <param name="strstatus"></param>
       /// <returns></returns>
       public List<DataTable> PDCClearanceRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string strchequeNo, decimal decBankId, string strstatus)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spPDCClearanceMaster.PDCClearanceRegisterSearch(dtFromdate, dtTodate, strLedgerName, voucherTypeName, strchequeNo, decBankId, strstatus);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="strVoucherType"></param>
       /// <param name="MasterId"></param>
       /// <returns></returns>
       public List<DataTable> InvoiceNumberCombofillUnderVoucherType(string strVoucherType, decimal MasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj[0] = spPDCClearanceMaster.InvoiceNumberCombofillUnderVoucherType(strVoucherType, MasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="strVoucherType"></param>
       /// <param name="decmasterId"></param>
       /// <returns></returns>
       public List<DataTable> pdcclearancedetailsFill(string strVoucherType, decimal decmasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spPDCClearanceMaster.pdcclearancedetailsFill(strVoucherType, decmasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public decimal PDCClearanceMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
       {
           decimal decId = 0;
           try
           {
               decId = spPDCClearanceMaster.PDCClearanceMaxUnderVoucherTypePlusOne(decVoucherTypeId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PCRE5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public string PDCClearanceMaxUnderVoucherType(decimal decVoucherTypeId)
       {
           string decId="";
           try
           {
               decId = spPDCClearanceMaster.PDCClearanceMaxUnderVoucherType(decVoucherTypeId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PCRE6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="voucherNo"></param>
       /// <param name="voucherTypeId"></param>
       /// <param name="PDCClearanceMasterId"></param>
       /// <returns></returns>
       public bool PDCclearanceCheckExistence(string voucherNo, decimal voucherTypeId, decimal PDCClearanceMasterId)
       {
           bool isSave = false;
           try
           {
               isSave = spPDCClearanceMaster.PDCclearanceCheckExistence(voucherNo, voucherTypeId, PDCClearanceMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isSave;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="pdcclearancemasterinfo"></param>
       /// <returns></returns>
       public decimal PDCClearanceMasterAdd(PDCClearanceMasterInfo pdcclearancemasterinfo)
       {
           decimal decId = 0;
           try
           {
               decId = spPDCClearanceMaster.PDCClearanceMasterAdd(pdcclearancemasterinfo);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PCRE8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="pdcclearancemasterinfo"></param>
       public void PDCClearanceMasterEdit(PDCClearanceMasterInfo pdcclearancemasterinfo)
       {

           try
           {
               spPDCClearanceMaster.PDCClearanceMasterEdit(pdcclearancemasterinfo);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PCRE9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="strVoucherType"></param>
       /// <returns></returns>
       public string TypeOfVoucherReturnUnderVoucherName(string strVoucherType)
       {
           string decId = "";
           try
           {
               decId = spPDCClearanceMaster.TypeOfVoucherReturnUnderVoucherName(strVoucherType);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PCRE10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="PDCClearanceMasterId"></param>
       /// <returns></returns>
       public PDCClearanceMasterInfo PDCClearanceMasterView(decimal PDCClearanceMasterId)
       {
           PDCClearanceMasterInfo infoPDCClearanceMaster= new PDCClearanceMasterInfo();
           try
           {
               infoPDCClearanceMaster = spPDCClearanceMaster.PDCClearanceMasterView(PDCClearanceMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infoPDCClearanceMaster;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decclearanceId"></param>
       /// <returns></returns>
       public decimal PDCClearanceAgainstIdUnderClearanceId(decimal decclearanceId)
       {
           decimal decId = 0;
           try
           {
               decId = spPDCClearanceMaster.PDCClearanceAgainstIdUnderClearanceId(decclearanceId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PCRE12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="decPDCClearanceId"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
       internal DataSet PDCClearanceVoucherPrinting(decimal decPDCClearanceId, decimal decCompanyId)
       {

           DataSet ds = new DataSet();
           try
           {
               ds = PDCClearanceVoucherPrinting(decPDCClearanceId, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ds;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="PdcClearanceId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strVoucherNo"></param>
       public void PDCClearanceDelete(decimal PdcClearanceId, decimal decVoucherTypeId, string strVoucherNo)
       {

           try
           {
               spPDCClearanceMaster.PDCClearanceDelete(PdcClearanceId, decVoucherTypeId, strVoucherNo);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PCRE14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtFromdate"></param>
       /// <param name="dtTodate"></param>
       /// <param name="strLedgerName"></param>
       /// <param name="voucherTypeName"></param>
       /// <param name="voucherNo"></param>
       /// <returns></returns>
       public List<DataTable> PDCClearanceReportSearch(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string voucherNo)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spPDCClearanceMaster.PDCClearanceReportSearch(dtFromdate, dtTodate, strLedgerName, voucherTypeName, voucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="dtFromdate"></param>
       /// <param name="dtTodate"></param>
       /// <param name="strLedgerName"></param>
       /// <param name="voucherTypeName"></param>
       /// <param name="voucherNo"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
       public DataSet PDCClearanceReportPrinting(DateTime dtFromdate, DateTime dtTodate, string strLedgerName, string voucherTypeName, string voucherNo, decimal decCompanyId)
       {

           DataSet ds = new DataSet();
           try
           {
               ds = spPDCClearanceMaster.PDCClearanceReportPrinting(dtFromdate, dtTodate, strLedgerName, voucherTypeName, voucherNo, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PCRE16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ds;
       }
    }
}
