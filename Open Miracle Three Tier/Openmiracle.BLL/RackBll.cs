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
    public class RackBll
    {
        RackSP SPRack = new RackSP();
        public List<DataTable> RackSearch(string strRackName, string strGodownname)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPRack.RackSearch(strRackName, strGodownname);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        public bool RackCheckExistence(string strRackName, decimal decRackId, decimal decGodownId)
        {           
            bool isEdit = false;
            try
            {
                isEdit = SPRack.RackCheckExistence(strRackName, decRackId, decGodownId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }

        public decimal RackAdd(RackInfo rackinfo)
        {           
            decimal decEffectedRow = 0;
            try
            {
                decEffectedRow = SPRack.RackAdd(rackinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decEffectedRow;
        }

        public bool RackEdit(RackInfo rackinfo)
        {           
            bool isEdit = false;
            try
            {
                isEdit = SPRack.RackEdit(rackinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public decimal RackDeleteReference(decimal RackId)
        {
            decimal decReturnValue = 0;    

            try
            {
                decReturnValue = SPRack.RackDeleteReference(RackId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }

        public RackInfo RackView(decimal rackId)
        {
            RackInfo rackinfo = new RackInfo();          

            try
            {
                rackinfo = SPRack.RackView(rackId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rackinfo;
        }
        public List<DataTable> RackNamesCorrespondingToGodownId(decimal decgodownId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPRack.RackNamesCorrespondingToGodownId(decgodownId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        public List<DataTable> RackViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPRack.RackViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> RackViewAllByGodownForCombo(decimal godownId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPRack.RackViewAllByGodownForCombo(godownId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> RackFillForStock(decimal decGodown)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPRack.RackFillForStock(decGodown);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        public List<DataTable> RackViewAllByGodown(decimal decGodown)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPRack.RackViewAllByGodown(decGodown);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Rack view for rejection out
        /// </summary>
        /// <returns></returns>
        public List<DataTable> RejectionOutRackViewFromGodownId()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPRack.RejectionOutRackViewFromGodownId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RackBll 1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }
}