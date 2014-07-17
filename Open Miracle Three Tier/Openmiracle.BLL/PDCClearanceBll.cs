using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{

    public class PDCClearanceBll
    {
        PDCClearanceMasterSP spPdcClearanceMaster = new PDCClearanceMasterSP();
        /// <summary>
        /// Function to fill the combobox under vouchertype
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VouchertypeComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spPdcClearanceMaster.VouchertypeComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        /// <summary>
        /// Function to fill the InvoiceNumber Combobox Under the VoucherType
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <param name="MasterId"></param>
        /// <returns></returns>
        public List<DataTable> InvoiceNumberCombofillUnderVoucherType(string strVoucherType, decimal MasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcClearanceMaster.InvoiceNumberCombofillUnderVoucherType(strVoucherType, MasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to fill the product details based on the search
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <param name="decmasterId"></param>
        /// <returns></returns>
        public List<DataTable> pdcclearancedetailsFill(string strVoucherType, decimal decmasterId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcClearanceMaster.pdcclearancedetailsFill(strVoucherType, decmasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to fill PDCClearanceMax UnderVoucherType PlusOne
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public decimal PDCClearanceMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                max = spPdcClearanceMaster.PDCClearanceMaxUnderVoucherTypePlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to fill PDCClearanceMax UnderVoucherType PlusOne
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public string PDCClearanceMaxUnderVoucherType(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                max = spPdcClearanceMaster.PDCClearanceMaxUnderVoucherType(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to check the references of pdc clearence
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
                isSave = spPdcClearanceMaster.PDCclearanceCheckExistence(voucherNo, voucherTypeId, PDCClearanceMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSave;
        }
        /// <summary>
        /// Function to insert values to PDCClearanceMaster Table
        /// </summary>
        /// <param name="pdcclearancemasterinfo"></param>
        /// <returns></returns>
        public decimal PDCClearanceMasterAdd(PDCClearanceMasterInfo pdcclearancemasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spPdcClearanceMaster.PDCClearanceMasterAdd(pdcclearancemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to Update values in PDCClearanceMaster Table
        /// </summary>
        /// <param name="pdcclearancemasterinfo"></param>
        public void PDCClearanceMasterEdit(PDCClearanceMasterInfo pdcclearancemasterinfo)
        {
            try
            {
                spPdcClearanceMaster.PDCClearanceMasterEdit(pdcclearancemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get the TypeOf Voucher Return Under the Voucher
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <returns></returns>
        public string TypeOfVoucherReturnUnderVoucherName(string strVoucherType)
        {
            string VoucherType = string.Empty;
            try
            {
                VoucherType = spPdcClearanceMaster.TypeOfVoucherReturnUnderVoucherName(strVoucherType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return VoucherType;
        }
        /// <summary>
        /// Function to get particular values from PDCClearanceMaster Table based on the parameter
        /// </summary>
        /// <param name="PDCClearanceMasterId"></param>
        /// <returns></returns>
        public PDCClearanceMasterInfo PDCClearanceMasterView(decimal PDCClearanceMasterId)
        {
            PDCClearanceMasterInfo pdcclearancemasterinfo = new PDCClearanceMasterInfo();
            try
            {
                pdcclearancemasterinfo = spPdcClearanceMaster.PDCClearanceMasterView(PDCClearanceMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return pdcclearancemasterinfo;
        }
        /// <summary>
        /// Function to get PDC clearence against the ledger 
        /// </summary>
        /// <param name="decclearanceId"></param>
        /// <returns></returns>
        public decimal PDCClearanceAgainstIdUnderClearanceId(decimal decclearanceId)
        {
            decimal decAgainstId = 0;
            try
            {
                decAgainstId = spPdcClearanceMaster.PDCClearanceAgainstIdUnderClearanceId(decclearanceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decAgainstId;
        }
        /// <summary>
        /// Function to print the details of PDC in print forms
        /// </summary>
        /// <param name="decPDCClearanceId"></param>
        /// <param name="decCompanyId"></param>
        /// <returns></returns>
        public DataSet PDCClearanceVoucherPrinting(decimal decPDCClearanceId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                dSt = spPdcClearanceMaster.PDCClearanceVoucherPrinting(decPDCClearanceId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
        }
        /// <summary>
        /// Function to delete the items from table used on the parameter
        /// </summary>
        /// <param name="PdcClearanceId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        public void PDCClearanceDelete(decimal PdcClearanceId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                spPdcClearanceMaster.PDCClearanceDelete(PdcClearanceId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcClearanceMaster.PDCClearanceReportSearch(dtFromdate, dtTodate, strLedgerName, voucherTypeName, voucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
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
            DataSet dSt = new DataSet();
            try
            {
                dSt = spPdcClearanceMaster.PDCClearanceReportPrinting(dtFromdate, dtTodate, strLedgerName, voucherTypeName, voucherNo, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
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
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPdcClearanceMaster.PDCClearanceRegisterSearch(dtFromdate, dtTodate, strLedgerName, voucherTypeName, strchequeNo, decBankId, strstatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDCC16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
    }
}