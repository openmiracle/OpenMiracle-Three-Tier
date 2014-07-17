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
    public class ProductGroupBll
    {
        ProductGroupSP spProductGroup = new ProductGroupSP();
        public List<DataTable> ProductGroupViewForComboFillForProductGroup()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProductGroup.ProductGroupViewForComboFillForProductGroup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public List<DataTable> ProductGroupViewForComboFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProductGroup.ProductGroupViewForComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public bool ProductGroupCheckExistence(string strProductGroupName, decimal decProductGroupId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spProductGroup.ProductGroupCheckExistence(strProductGroupName,decProductGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public decimal ProductGroupAdd(ProductGroupInfo productgroupinfo)
        {
            decimal decIdForOtherForms = 0;
            try
            {
                decIdForOtherForms = spProductGroup.ProductGroupAdd(productgroupinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdForOtherForms;
        }
        public void ProductGroupEdit(ProductGroupInfo productgroupinfo)
        {
            try
            {
                spProductGroup.ProductGroupEdit(productgroupinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal ProductGroupReferenceDelete(decimal ProductGroupId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spProductGroup.ProductGroupReferenceDelete(ProductGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public List<DataTable> ProductGroupViewForGridFill(string strGroupName, string strGroupUnder)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spProductGroup.ProductGroupViewForGridFill(strGroupName, strGroupUnder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        public ProductGroupInfo ProductGroupView(decimal groupId)
        {
            ProductGroupInfo productgroupinfo = new ProductGroupInfo();
            try
            {
                productgroupinfo = spProductGroup.ProductGroupView(groupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL38:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return productgroupinfo;
        }
        public bool ProductGroupCheckExistenceOfUnderGroup(decimal decProductGroupId)
        {
            bool isExist = false;
            try
            {
                isExist = spProductGroup.ProductGroupCheckExistenceOfUnderGroup(decProductGroupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL31:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isExist;
        }
        public List<DataTable> ProductGroupViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProductGroup.ProductGroupViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get product and unit details 
        /// </summary>
        /// <param name="decgroupId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> ProductAndUnitViewAllForGridFill(decimal decgroupId, string strProductCode, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spProductGroup.ProductAndUnitViewAllForGridFill(decgroupId, strProductCode, strProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    
    
    
    
    }
}
