using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;
using System.Data;

namespace Openmiracle.BLL
{
    public class CreditNoteMasterBll
    {
        CreditNoteMasterInfo InfoCreditNoteMaster = new CreditNoteMasterInfo();
        CreditNoteMasterSP SpCreditNoteMaster = new CreditNoteMasterSP();
        public decimal CreditNoteMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal decMId = 0;
            try
            {
                decMId = SpCreditNoteMaster.CreditNoteMasterGetMaxPlusOne(decVoucherTypeId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CNB:1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decMId;
        }
        public string CreditNoteMasterGetMax(decimal decVoucherTypeId)
        {
            string strgetmax = "0";
            try
            {
                strgetmax = SpCreditNoteMaster.CreditNoteMasterGetMax(decVoucherTypeId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CNB:2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strgetmax;
        }
        public bool CreditNoteCheckExistence(string strInvoiceNo, decimal voucherTypeId, decimal decMasterId)
        {
            bool isResult = false;
            try
            {
                isResult = SpCreditNoteMaster.CreditNoteCheckExistence(strInvoiceNo, voucherTypeId, decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CNB:3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        internal DataSet CreditNotePrinting(decimal decCreditNoteMasterId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SpCreditNoteMaster.CreditNotePrinting(decCreditNoteMasterId, decCompanyId);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }
        public void CreditNoteVoucherDelete(decimal decCreditNoteMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                SpCreditNoteMaster.CreditNoteVoucherDelete(decCreditNoteMasterId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception)
            {
            }
        }
        public decimal CreditNoteMasterAdd(CreditNoteMasterInfo creditnotemasterinfo)
        {
            decimal decId = 0;
            try
            {
                decId = SpCreditNoteMaster.CreditNoteMasterAdd(creditnotemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CNB:4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public decimal CreditNoteMasterEdit(CreditNoteMasterInfo creditnotemasterinfo)
        {
            decimal decResult = 0;
            try
            {
                decResult = SpCreditNoteMaster.CreditNoteMasterEdit(creditnotemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CNB:5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public CreditNoteMasterInfo CreditNoteMasterView(decimal creditNoteMasterId)
        {
            CreditNoteMasterInfo InfoCreditNoteMaster = new CreditNoteMasterInfo();
            try
            {
                InfoCreditNoteMaster = SpCreditNoteMaster.CreditNoteMasterView(creditNoteMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoCreditNoteMaster;
        }
    }
}
