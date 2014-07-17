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
    public class ContraMasterBll
    {
        ContraMasterInfo InfoContraMaster = new ContraMasterInfo();
        ContraMasterSP SpContraMaster = new ContraMasterSP();
        public decimal ContraMasterAdd(ContraMasterInfo InfoContraMaster)
        {
            decimal decId = 0;
            try
            {
                decId = SpContraMaster.ContraMasterAdd(InfoContraMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CV:1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public void ContraMasterEdit(ContraMasterInfo InfoContraMaster)
        {
            try
            {
                SpContraMaster.ContraMasterEdit(InfoContraMaster);
            }
            catch (Exception)
            {
            }
        }
        public decimal ContraVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal decMId = 0;
            try
            {
                decMId = SpContraMaster.ContraVoucherMasterGetMaxPlusOne(decVoucherTypeId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CV:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decMId;
        }
        public string ContraVoucherMasterGetMax(decimal decVoucherTypeId)
        {
            string strgetmax = "0";
            try
            {
                strgetmax = SpContraMaster.ContraVoucherMasterGetMax(decVoucherTypeId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CV:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strgetmax;
        }
        public bool ContraVoucherCheckExistence(string voucherNo, decimal voucherTypeId, decimal masterId)
        {
            bool isResult = false;
            try
            {
                isResult = SpContraMaster.ContraVoucherCheckExistence(voucherNo, voucherTypeId, masterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CV:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public DataSet ContraVoucherPrinting(decimal decContraMasterId, decimal decCompanyId)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SpContraMaster.ContraVoucherPrinting(decContraMasterId, decCompanyId);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }
        public ContraMasterInfo ContraMasterView(decimal contraMasterId)
        {
            ContraMasterInfo InfoContraMaster = new ContraMasterInfo(); 
            try
            {
                InfoContraMaster = SpContraMaster.ContraMasterView(contraMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CV:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoContraMaster;
        }
    }
}
