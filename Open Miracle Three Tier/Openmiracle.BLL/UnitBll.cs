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
    public class UnitBll
    {
        UnitSP spUnit = new UnitSP();
        public List<DataTable> UnitSearch(string strUnitName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spUnit.UnitSearch(strUnitName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return ListObj;
        }
        public bool UnitCheckExistence(string strUnitName, decimal decUnitid)
        {
            bool isEdit = false;
            try
            {
                isEdit = spUnit.UnitCheckExistence(strUnitName,decUnitid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return isEdit;
        }
        public decimal UnitAdd(UnitInfo infoUnit)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spUnit.UnitAdd(infoUnit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return decIdentity;
        }
        public bool UnitEdit(UnitInfo infoUnit)
        {
            bool isCheck = false;
            try
            {
                isCheck = spUnit.UnitEdit(infoUnit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return isCheck;
        }
        public decimal UnitDeleteCheck(decimal UnitId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spUnit.UnitDeleteCheck(UnitId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return decReturnValue;
        }
        public UnitInfo UnitView(decimal unitId)
        {
            UnitInfo infoUnit = new UnitInfo();
            try
            {
                infoUnit = spUnit.UnitView(unitId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return infoUnit;
        }
        public UnitInfo UnitViewForPriceListPopUp(decimal decProductId)
        {
            UnitInfo infoUnit = new UnitInfo();
            try
            {
                infoUnit = spUnit.UnitViewForPriceListPopUp(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoUnit;
        }
        public List<DataTable> UnitViewAllWithoutPerticularId(decimal decUnitId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spUnit.UnitViewAllWithoutPerticularId(decUnitId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public UnitInfo unitVieWForStandardRate(decimal decProductId)
        {
            UnitInfo infoUnit = new UnitInfo();
            try
            {
                infoUnit = spUnit.unitVieWForStandardRate(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoUnit;
        }
        public List<DataTable> UnitViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spUnit.UnitViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return ListObj;
        }
        public List<DataTable> UnitViewAllByProductId(decimal decProductId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spUnit.UnitViewAllByProductId(decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public string UnitName(decimal decUnitId)
        {
            string strReturnValue = "";
            try
            {
                strReturnValue=spUnit.UnitName(decUnitId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strReturnValue;
        }
        public string UnitConversionCheck(decimal decUnitId, decimal decProductId)
        {
            string strQuantities = string.Empty;
            try
            {
                strQuantities = spUnit.UnitConversionCheck( decUnitId,  decProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strQuantities;
        }
        public decimal UnitIdByUnitName(string strUnitName)
        {
            decimal decUnitId = 0;
            try
            {
                decUnitId = spUnit.UnitIdByUnitName(strUnitName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decUnitId;
        }
    }
}
