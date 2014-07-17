using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OpenMiracle.DAL;
using ENTITY;
using System.Windows.Forms;

namespace OpenMiracle.BLL
{
   public class QuickLaunchItemsBll
    {
        /// <summary>
        /// Function to get all the Non Selected  values from tbl_QuickLaunchItems Table
        /// </summary>
        /// <param name="isSelected"></param>
        /// <returns></returns>
        public List<DataTable> QuickLaunchNonSelectedViewAll(bool isSelected)
       {
           QuickLaunchItemsSP SPQuickLaunchItems = new QuickLaunchItemsSP();
        
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPQuickLaunchItems.QuickLaunchNonSelectedViewAll(isSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("QLIBll 1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to Update values in tbl_QuickLaunchItems Table
        /// </summary>
        /// <param name="infoQuickLaunchItems"></param>
        public void QuickLaunchItemsEdit(QuickLaunchItemsInfo infoQuickLaunchItems)
        {
            QuickLaunchItemsSP SPQuickLaunchItems = new QuickLaunchItemsSP();
            try
            {
                SPQuickLaunchItems.QuickLaunchItemsEdit(infoQuickLaunchItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show("QLIBll 2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
