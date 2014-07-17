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
    public class GodownBll
    {
        GodownSP SPGodown = new GodownSP();
        public void GodownAdd(GodownInfo godowninfo)
        {
            try
            {
                SPGodown.GodownAdd(godowninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in Godown Table
        /// </summary>
        /// <param name="godowninfo"></param>
        public void GodownEdit(GodownInfo godowninfo)
        {
            try
            {
                SPGodown.GodownEdit(godowninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to get all the values from Godown Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> GodownViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPGodown.GodownViewAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from Godown table based on the parameter
        /// </summary>
        /// <param name="godownId"></param>
        /// <returns></returns>

        public GodownInfo GodownView(decimal godownId)
        {
            GodownInfo godowninfo = new GodownInfo();
            try
            {
                godowninfo = SPGodown.GodownView(godownId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return godowninfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="GodownId"></param>
        public void GodownDelete(decimal GodownId)
        {
            try
            {
               SPGodown.GodownDelete(GodownId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to  get the next id for Godown table
        /// </summary>
        /// <returns></returns>
        public int GodownGetMax()
        {
            int max = 0;
            try
            {
                max = SPGodown.GodownGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to get all the values from Godown Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> GodownOnlyViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPGodown.GodownOnlyViewAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to insert values to Godown Table with same name
        /// </summary>
        /// <param name="godowninfo"></param>
        /// <returns></returns>
        public decimal GodownAddWithoutSameName(GodownInfo godowninfo)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = SPGodown.GodownAddWithoutSameName(godowninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
            
        }
        /// <summary>
        /// Function to get particular values from Godown table based on the parameter with narration
        /// </summary>
        /// <param name="decGodownId"></param>
        /// <returns></returns>
        public GodownInfo GodownWithNarrationView(decimal decGodownId)
        {
            GodownInfo godowninfo = new GodownInfo();
            try
            {
                godowninfo = SPGodown.GodownWithNarrationView(decGodownId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return godowninfo;
        }
        /// <summary>
        /// Function to check the existance of godown
        /// </summary>
        /// <param name="strGodownName"></param>
        /// <param name="strGodownId"></param>
        /// <returns></returns>
        public bool GodownCheckIfExist(String strGodownName, decimal strGodownId)
        {

            bool isCheck = false;
            try
            {
                isCheck = SPGodown.GodownCheckIfExist(strGodownName, strGodownId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isCheck;
        }
        /// <summary>
        /// Function to Update values in Godown Table
        /// </summary>
        /// <param name="godowninfo"></param>
        /// <returns></returns>
        public bool GodownEditParticularField(GodownInfo godowninfo)
        {
            bool isEdit = false;
            try
            {
                isEdit = SPGodown.GodownEditParticularField(godowninfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter by checking reference
        /// </summary>
        /// <param name="decGodownId"></param>
        /// <returns></returns>
        public decimal GodownCheckReferenceAndDelete(decimal decGodownId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = SPGodown.GodownCheckReferenceAndDelete(decGodownId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to get the godownId by godownname
        /// </summary>
        /// <param name="strGodown"></param>
        /// <returns></returns>
        public GodownInfo GodownIdByGodownName(string strGodown)
        {
            GodownInfo godowninfo = new GodownInfo();
            try
            {
                godowninfo = SPGodown.GodownIdByGodownName(strGodown);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return godowninfo;
        }
        /// <summary>
        /// Function to get default godownId by productName
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public decimal DefaultGodownIDViewByProductName(string productName)
        {
            decimal godownId = 0;
            try
            {
                godownId = SPGodown.DefaultGodownIDViewByProductName(productName);
            }
            catch (Exception ex)
            {

                MessageBox.Show("GBll14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return godownId;
        }
    }
}
