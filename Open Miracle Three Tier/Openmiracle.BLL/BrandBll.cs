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
    public class BrandBll
    {
        BrandSP SPBrand = new BrandSP();
        public decimal BrandAdd(BrandInfo brandinfo)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue=SPBrand.BrandAdd(brandinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to Update values in brand Table
        /// </summary>
        /// <param name="brandinfo"></param>
        /// <returns></returns>
        public bool BrandEdit(BrandInfo brandinfo)
        {
            bool isEdit = false;
            try
            {

                isEdit = SPBrand.BrandEdit(brandinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isEdit;
        }
        /// <summary>
        /// Function to get all the values from Brand Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> BrandViewAll()
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = SPBrand.BrandViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        /// <summary>
        /// Function to get particular values from brand table based on the parameter
        /// </summary>
        /// <param name="brandId"></param>
        /// <returns></returns>
        public BrandInfo BrandView(decimal brandId)
        {
            BrandInfo brandinfo = new BrandInfo();
            try
            {
               brandinfo= SPBrand.BrandView(brandId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return brandinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="BrandId"></param>
        public void BrandDelete(decimal BrandId)
        {
           
            try
            {
               SPBrand.BrandDelete(BrandId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        /// <summary>
        /// Function to  get the next id for brand table
        /// </summary>
        /// <returns></returns>
        public int BrandGetMax()
        {
            int max = 0;
            
            try
            {
                max = SPBrand.BrandGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return max;
        }
        /// <summary>
        /// Function to search a brand
        /// </summary>
        /// <param name="strBrandName"></param>
        /// <returns></returns>
        public List<DataTable> BrandSearch(string strBrandName)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = SPBrand.BrandSearch(strBrandName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }

        /// <summary>
        /// Function to check existance of a brand
        /// </summary>
        /// <param name="strBrandName"></param>
        /// <param name="decBrandId"></param>
        /// <returns></returns>
        public bool BrandCheckIfExist(string strBrandName, decimal decBrandId)
        {
            bool isEdit = false;
            try
            {

                isEdit = SPBrand.BrandCheckIfExist(strBrandName, decBrandId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Function to delete a brand by checking existance
        /// </summary>
        /// <param name="BrandId"></param>
        /// <returns></returns>
        public decimal BrandDeleteCheckExistence(decimal BrandId)
        {
            decimal decReturnValue = 0;
            try
            {

                decReturnValue = SPBrand.BrandDeleteCheckExistence(BrandId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }

    }
}
