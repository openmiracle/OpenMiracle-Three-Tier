using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OpenMiracle.BLL
{
    public class ContraVoucherDetailsBll
    {
        public List<DataTable> CashOrBankComboFill()
        {
            ContraDetailsSP spContraDetails = new ContraDetailsSP();
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spContraDetails.CashOrBankComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal ContraDetailsAddReturnWithhIdentity(ContraDetailsInfo infoContraDetails)
        {

            decimal decIdentity = 0;
            try
            {
                ContraDetailsSP spContraDetails = new ContraDetailsSP();
                decIdentity = spContraDetails.ContraDetailsAddReturnWithhIdentity(infoContraDetails);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public void ContraDetailsDelete(decimal ContraDetailsId)
        {
            try
            {
                ContraDetailsSP spContraDetails = new ContraDetailsSP();
                spContraDetails.ContraDetailsDelete(ContraDetailsId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ContraDetailsEdit(ContraDetailsInfo contradetailsinfo)
        {
            try
            {
                ContraDetailsSP spContraDetails = new ContraDetailsSP();
                spContraDetails.ContraDetailsEdit(contradetailsinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ContraVoucherDelete(decimal ContraDetailsId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                ContraDetailsSP spContraDetails = new ContraDetailsSP();
                spContraDetails.ContraVoucherDelete(ContraDetailsId, decVoucherTypeId, strVoucherNo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> ContraDetailsViewWithMasterId(decimal decpurchaseId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                ContraDetailsSP spContraDetails = new ContraDetailsSP();
                listObj = spContraDetails.ContraDetailsViewWithMasterId(decpurchaseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ContraVoucherRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, string strVoucherNo, string strLedgerName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                listObj = spContraMaster.ContraVoucherRegisterSearch(dtdateFrom, dtdateTo, strVoucherNo, strLedgerName, strType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> ContraReport(DateTime dtdateFrom, DateTime dtdateTo, string strVoucherType, string strLedgerName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                listObj = spContraMaster.ContraReport(dtdateFrom, dtdateTo, strVoucherType, strLedgerName, strType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal ContraVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                max = spContraMaster.ContraVoucherMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        public string ContraVoucherMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                max = spContraMaster.ContraVoucherMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        public bool ContraVoucherCheckExistence(string voucherNo, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                trueOrfalse = spContraMaster.ContraVoucherCheckExistence(voucherNo, voucherTypeId, masterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
        public decimal ContraMasterAdd(ContraMasterInfo contramasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                decIdentity = spContraMaster.ContraMasterAdd(contramasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        public void ContraMasterEdit(ContraMasterInfo contramasterinfo)
        {
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                spContraMaster.ContraMasterEdit(contramasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DataSet ContraVoucherPrinting(decimal decContraMasterId, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                dSt = spContraMaster.ContraVoucherPrinting(decContraMasterId, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
        }
        public ContraMasterInfo ContraMasterView(decimal contraMasterId)
        {
            ContraMasterInfo contramasterinfo = new ContraMasterInfo();
            try
            {
                ContraMasterSP spContraMaster = new ContraMasterSP();
                contramasterinfo = spContraMaster.ContraMasterView(contraMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CVBLL:12" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return contramasterinfo;
        }

    }
}
