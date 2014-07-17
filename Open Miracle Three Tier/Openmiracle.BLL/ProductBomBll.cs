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
    public class ProductBomBll
    {
        BomSP SPBom = new BomSP();
        public void BomAdd(BomInfo bominfo)
        {
            try
            {
                SPBom.BomAdd(bominfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to insert values to Bom Table
        /// </summary>
        /// <param name="bominfo"></param>
        /// <param name="decId"></param>
        public void BomFromDatatable(BomInfo bominfo, decimal decId)
        {
            try
            {
                SPBom.BomFromDatatable(bominfo, decId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in Bom Table
        /// </summary>
        /// <param name="bominfo"></param>
        public void BomEdit(BomInfo bominfo)
        {
            try
            {
                SPBom.BomEdit(bominfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get all the values from Bom Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BomViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj=SPBom.BomViewAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from Bom Table based on the parameter
        /// </summary>
        /// <param name="bomId"></param>
        /// <returns></returns>
        public BomInfo BomView(decimal bomId)
        {
            BomInfo bominfo = new BomInfo();
            try
            {
                bominfo = SPBom.BomView(bomId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return bominfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BomId"></param>
        public void BomDelete(decimal BomId)
        {
            try
            {
                SPBom.BomDelete(BomId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to  get the next id for Bom Table
        /// </summary>
        /// <returns></returns>
        public int BomGetMax()
        {
            int max = 0;
            try
            {
               max = SPBom.BomGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to view all details for Update based on parameter
        /// </summary>
        /// <param name="deProductId"></param>
        /// <returns></returns>
        public List<DataTable> ProduBomForEdit(decimal deProductId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPBom.ProduBomForEdit(deProductId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to delete a particular value and retun corresponding id for updation
        /// </summary>
        /// <param name="decProduciId"></param>
        /// <returns></returns>
        public decimal BomDeleteForUpdation(decimal decProduciId)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPBom.BomDeleteForUpdation(decProduciId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        /// <summary>
        /// Function to remove values and return corresponding id
        /// </summary>
        /// <param name="decBomId"></param>
        /// <returns></returns>
        public decimal BomRemoveRow(decimal decBomId)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPBom.BomRemoveRow(decBomId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        /// <summary>
        /// Function to remove values and return corresponding id
        /// </summary>
        /// <param name="decBomId"></param>
        /// <returns></returns>
        public decimal BomRemoveRows(decimal decBomId)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPBom.BomRemoveRows(decBomId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        /// <summary>
        /// Function to Update values in Bom table
        /// </summary>
        /// <param name="bominfo"></param>
        public void UpdateBom(BomInfo bominfo)
        {
            try
            {
               SPBom.UpdateBom(bominfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BOMBll12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
