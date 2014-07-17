//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
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
    /// <summary>
    /// 
    /// </summary> 
   public  class CreditNoteBll
    {
       CreditNoteDetailsInfo infoCreditNoteDetails = new CreditNoteDetailsInfo();
       CreditNoteDetailsSP SpCreditNoteDetails = new CreditNoteDetailsSP();
       CreditNoteMasterInfo infoCreditNoteMaster = new CreditNoteMasterInfo();
       CreditNoteMasterSP SpCreditNoteMaster = new CreditNoteMasterSP();
       /// <summary>
       /// Function to insert values to CreditNoteDetails Table
       /// </summary>
       /// <param name="creditnotedetailsinfo"></param>
       /// <returns></returns>

       public decimal CreditNoteDetailsAdd(CreditNoteDetailsInfo creditnotedetailsinfo)
       {
           decimal decId = 0;
           try
           {
               decId = SpCreditNoteDetails.CreditNoteDetailsAdd(creditnotedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CRNT:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// Function to delete particular details based on the parameter From Table CreditNoteDetail
       /// </summary>
       /// <param name="CreditNoteMasterId"></param>
       public void CreditNoteDetailsDelete(decimal CreditNoteMasterId)
       {
           try
           {
               SpCreditNoteDetails.CreditNoteDetailsDelete(CreditNoteMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CRNT:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       ///  Function to Update values in CreditNoteDetails Table
       /// </summary>
       /// <param name="creditnotedetailsinfo"></param>
       /// <returns></returns>
       public decimal CreditNoteDetailsEdit(CreditNoteDetailsInfo creditnotedetailsinfo)
       {
           decimal decCreditNoteDetails = 0;
           try
           {
               decCreditNoteDetails = SpCreditNoteDetails.CreditNoteDetailsEdit(creditnotedetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CRNT:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decCreditNoteDetails;
       }
       /// <summary>
       /// Function to get the CreditNote Details By MasterId
       /// </summary>
       /// <param name="decMasterId"></param>
       /// <returns></returns>
       public List<DataTable> CreditNoteDetailsViewByMasterId(decimal decMasterId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = SpCreditNoteDetails.CreditNoteDetailsViewByMasterId(decMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CRNT:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// Function to view CreditNote details based on parameters
       /// </summary>
       /// <param name="strVoucherNo"></param>
       /// <param name="strFromDate"></param>
       /// <param name="strToDate"></param>
       /// <returns></returns>
       public List<DataTable> CreditNoteRegisterSearch(string strVoucherNo, string strFromDate, string strToDate)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = SpCreditNoteMaster.CreditNoteRegisterSearch(strVoucherNo, strFromDate, strToDate);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CRNT:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// Function to get particular values from account group table based on the parameter
       /// </summary>
       /// <param name="decVouchertypeid"></param>
       /// <param name="strVoucherNo"></param>
       /// <returns></returns>
       public decimal CreditNoteMasterIdView(decimal decVouchertypeid, string strVoucherNo)
       {
           decimal decid = 0;
           try
           {
               decid = SpCreditNoteMaster.CreditNoteMasterIdView(decVouchertypeid, strVoucherNo);
           }
           catch (Exception ex)
           {

               MessageBox.Show("CRNT:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decid;
       }
       /// <summary>
       /// Function to  get the next id for CreditNoteMaster table
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public decimal CreditNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
       {
           decimal max = 0;
           try
           {
               max = SpCreditNoteMaster.CreditNoteMasterGetMaxPlusOne(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CRNT:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       /// <summary>
       /// Function to  get the next id for CreditNoteMaster table
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
        public string  CreditNoteMasterGetMax(decimal decVoucherTypeId)
    {
        string  max="0";
        try
        {
            max = SpCreditNoteMaster.CreditNoteMasterGetMax(decVoucherTypeId);
        }
        catch (Exception ex)
        {
            MessageBox.Show("CRNT:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return max;
    }
       /// <summary>
        /// Function to check the existance of creditnote
       /// </summary>
       /// <param name="strInvoiceNo"></param>
       /// <param name="voucherTypeId"></param>
       /// <param name="decMasterId"></param>
       /// <returns></returns>
        public bool CreditNoteCheckExistence(string strInvoiceNo, decimal voucherTypeId, decimal decMasterId)
        {
            bool trueOrfalse = false;
            try
            {
                trueOrfalse = SpCreditNoteMaster.CreditNoteCheckExistence(strInvoiceNo, voucherTypeId, decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
       /// <summary>
        /// Function to get the details of creditnote based on the parameters for print
       /// </summary>
       /// <param name="decCreditNoteMasterId"></param>
       /// <param name="decCompanyId"></param>
       /// <returns></returns>
        public DataSet CreditNotePrinting(decimal decCreditNoteMasterId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                dSt = SpCreditNoteMaster.CreditNotePrinting(decCreditNoteMasterId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
        }
       /// <summary>
        /// Function to delete creditnote voucher
       /// </summary>
       /// <param name="decCreditNoteMasterId"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strVoucherNo"></param>
        public void CreditNoteVoucherDelete(decimal decCreditNoteMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                SpCreditNoteMaster.CreditNoteVoucherDelete(decCreditNoteMasterId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /// <summary>
        /// Function to insert values to account group Table
       /// </summary>
       /// <param name="creditnotemasterinfo"></param>
       /// <returns></returns>
        public decimal CreditNoteMasterAdd(CreditNoteMasterInfo creditnotemasterinfo)
        {
            decimal identity = 0;
            try
            {
                identity = SpCreditNoteMaster.CreditNoteMasterAdd(creditnotemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return identity;
        }
       /// <summary>
        /// Function to Update values in account group Table
       /// </summary>
       /// <param name="creditnotemasterinfo"></param>
       /// <returns></returns>
        public decimal  CreditNoteMasterEdit(CreditNoteMasterInfo creditnotemasterinfo)
    {
        decimal decCreditNoteMaster = 0;
        try
        {
            decCreditNoteMaster = SpCreditNoteMaster.CreditNoteMasterEdit(creditnotemasterinfo);
        }
        catch (Exception ex)
        {
            MessageBox.Show("CRNT:13" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return decCreditNoteMaster;
    }
       /// <summary>
        /// Function to get particular values from account CreditNoteMaster based on the parameter
       /// </summary>
       /// <param name="creditNoteMasterId"></param>
       /// <returns></returns>
        public CreditNoteMasterInfo CreditNoteMasterView(decimal creditNoteMasterId)
        {
            CreditNoteMasterInfo creditnotemasterinfo = new CreditNoteMasterInfo();
            try
            {
                creditnotemasterinfo = SpCreditNoteMaster.CreditNoteMasterView(creditNoteMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:14" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return creditnotemasterinfo;
        }
        public List<DataTable> CreditNoteReportSearch(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpCreditNoteMaster.CreditNoteReportSearch(strFromDate, strToDate, decVoucherTypeId, decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CRNT:15" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public DataSet CreditNoteReportPrinting(string strFromDate, string strToDate, decimal decVoucherTypeId, decimal decLedgerId, decimal decCompanyId)
    {
        DataSet dst = new DataSet();
        try
        {
            dst = SpCreditNoteMaster.CreditNoteReportPrinting(strFromDate, strToDate, decVoucherTypeId, decLedgerId, decCompanyId);
        }
        catch (Exception ex)
        {
            MessageBox.Show("CRNT:16" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        return dst;
    }

    }
}
