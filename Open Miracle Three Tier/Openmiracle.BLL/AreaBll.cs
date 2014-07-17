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
    public class AreaBll
    {
        AreaSP SpArea = new AreaSP();
        AreaInfo InfoArea = new AreaInfo();
        public List<DataTable> AreaOnlyViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpArea.AreaOnlyViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public bool AreaNameCheckExistence(String strAreaName, decimal strAreaId)
        {
            bool isEdit = false;
            try
            {
                isEdit = SpArea.AreaNameCheckExistence(strAreaName, strAreaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isEdit;
        }
        public decimal AreaAddWithIdentity(AreaInfo areainfo)
        {
            decimal decAreaId = 0;
            try
            {
                decAreaId = SpArea.AreaAddWithIdentity(areainfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decAreaId;

        }
        public bool AreaUpdate(AreaInfo areainfo)
        {
            bool isEdit = false;
            try
            {
                isEdit = SpArea.AreaUpdate(areainfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isEdit;
        }
        public decimal AreaDeleteReference(decimal AreaId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = SpArea.AreaDeleteReference(AreaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public AreaInfo AreaFill(decimal decAreaId)
        {
            AreaInfo infoArea = new AreaInfo();
            try
            {
                infoArea = SpArea.AreaFill(decAreaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return infoArea;

        }
        public List<DataTable> AreaViewFOrCombofill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpArea.AreaViewFOrCombofill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> AreaViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpArea.AreaViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AR8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }
}

