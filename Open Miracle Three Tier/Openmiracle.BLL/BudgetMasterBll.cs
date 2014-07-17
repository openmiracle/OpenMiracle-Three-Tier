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
    public class BudgetMasterBll
    {
        BudgetMasterInfo InfoBudgetMaster = new BudgetMasterInfo();
        BudgetMasterSP SpBudgetMaster = new BudgetMasterSP();

        public decimal BudgetMasterAdd(BudgetMasterInfo InfoBudgetMaster)
        {
            decimal decId = 0;
            try
            {
                decId = SpBudgetMaster.BudgetMasterAdd(InfoBudgetMaster);
            }

            catch (Exception ex)
            {
                MessageBox.Show("SB1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }

        public void BudgetMasterEdit(BudgetMasterInfo InfoBudgetMaster)
        {
            try
            {
                SpBudgetMaster.BudgetMasterEdit(InfoBudgetMaster);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<DataTable> BudgetSearchGridFill(string strBudgetName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpBudgetMaster.BudgetSearchGridFill(strBudgetName, strType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        public BudgetMasterInfo BudgetMasterView(decimal DecMasterId)
        {
            BudgetMasterInfo InfoBudgetMaster = new BudgetMasterInfo();
            try
            {
                InfoBudgetMaster = SpBudgetMaster.BudgetMasterView(DecMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoBudgetMaster;
        }

        public bool BudgetCheckExistanceOfName(string strSize, decimal decId)
        {
            bool isResult = false;
            try
            {
                isResult = SpBudgetMaster.BudgetCheckExistanceOfName(strSize, decId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }

        public decimal BudgetMasterDelete(decimal decSizeId)
        {
            decimal decResult = 0;
            try
            {
                decResult = SpBudgetMaster.BudgetMasterDelete(decSizeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
    }
}
