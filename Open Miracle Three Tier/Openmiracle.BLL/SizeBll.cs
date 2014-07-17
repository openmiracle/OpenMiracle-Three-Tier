using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{
    public class SizeBll
    {
        SizeSP spSize = new SizeSP();
        /// <summary>
        /// Function to get all values from Size Table 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SizeViewAlling()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSize.SizeViewAlling();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check existence of size based on parameter
        /// </summary>
        /// <param name="strSizeName"></param>
        /// <param name="decSizeId"></param>
        /// <returns></returns>
        public bool SizeNameCheckExistence(String strSizeName, decimal decSizeId)
        {           
            try
            {
                spSize.SizeNameCheckExistence(strSizeName, decSizeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        /// <summary>
        /// Function to insert values to Size Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="infoSize"></param>
        /// <returns></returns>
        public decimal SizeAdding(SizeInfo infoSize)
        {
            decimal decSizeId = 0;
            try
            {
                decSizeId = spSize.SizeAdding(infoSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decSizeId;
        }
        /// <summary>
        /// Function to Update values in Size Table and return the status
        /// </summary>
        /// <param name="infoSize"></param>
        /// <returns></returns>
        public bool SizeEditing(SizeInfo infoSize)
        {
            bool isEdit = false;
            try
            {
               isEdit= spSize.SizeEditing(infoSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Function to delete size based on parameter and return corresponding id
        /// </summary>
        /// <param name="SizeId"></param>
        /// <returns></returns>
        public decimal SizeDeleting(decimal SizeId)
        {
            decimal decId = 0;
            try
            {
                decId = spSize.SizeDeleting(SizeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        /// <summary>
        /// Function to get  values from Size Table based on the parameter
        /// </summary>
        /// <param name="decSizeId"></param>
        /// <returns></returns>
        public SizeInfo SizeViewing(decimal decSizeId)
        {
            SizeInfo infoSize = new SizeInfo();
            try
            {
                infoSize = spSize.SizeViewing(decSizeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoSize;
        }
        /// <summary>
        /// Function to get all the values from Size Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SizeViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spSize.SizeViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SZ7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }

    }
}
