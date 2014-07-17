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
    public class AditionalCostBll
    {
        AdditionalCostSP spAdditionalCost = new AdditionalCostSP();
        public void AdditionalCostAdd(AdditionalCostInfo infoAdditionalCost)
        {
            try
            {
                spAdditionalCost.AdditionalCostAdd(infoAdditionalCost);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ACBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void AdditionalCostDelete(decimal decAdditionalCostId)
        {
            try
            {
                spAdditionalCost.AdditionalCostDelete(decAdditionalCostId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ACBLL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void AdditionalCostEditByVoucherTypeIdAndVoucherNo(AdditionalCostInfo infoAdditionalCost)
        {
            try
            {
                spAdditionalCost.AdditionalCostEditByVoucherTypeIdAndVoucherNo(infoAdditionalCost);
            }
            catch (Exception ex)
            {
               MessageBox.Show("ACBLL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DeleteAdditionalCostForStockJournalEdit(string strVoucherNo, decimal decVoucherTypeId)
        {
            try
            {
                spAdditionalCost.DeleteAdditionalCostForStockJournalEdit(strVoucherNo, decVoucherTypeId);
            }
            catch ( Exception ex)
            {
                 MessageBox.Show("ACBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DataSet StockJournalAdditionalCostForRegisteOrReport(string strVoucherNo, decimal decVoucherTypeId)
        {
            DataSet dsData = new DataSet();
            try
            {
                dsData = spAdditionalCost.StockJournalAdditionalCostForRegisteOrReport(strVoucherNo, decVoucherTypeId);
            }
            catch ( Exception ex)
            {
              MessageBox.Show("ACBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dsData;
        }
        public List<DataTable> AdditionalCostViewAllByVoucherTypeIdAndVoucherNo(decimal decVoucherTypeId, string strVoucherNo)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spAdditionalCost.AdditionalCostViewAllByVoucherTypeIdAndVoucherNo(decVoucherTypeId, strVoucherNo);
            }
            catch ( Exception ex)
            {
                MessageBox.Show("ACBLL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public void AdditionalCostEdit(AdditionalCostInfo infoAdditionalCost)
        {
            try
            {
                spAdditionalCost.AdditionalCostEdit(infoAdditionalCost);
            }
            catch (Exception ex)
            {
              MessageBox.Show("ACBLL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                            
        }
                        
    }
}
