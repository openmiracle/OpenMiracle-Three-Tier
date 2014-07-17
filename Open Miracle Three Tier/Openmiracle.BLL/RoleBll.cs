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
   public class RoleBll
    {
        RoleSP spRole = new RoleSP();
        /// <summary>
        /// Function to get all the values from Role Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> RoleViewAll()
        {         
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spRole.RoleViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("RL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
        /// <summary>
        /// Function to get all role details
        /// </summary>
        /// <returns></returns>
        public List<DataTable> RoleViewGridFill()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spRole.RoleViewGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
       /// <summary>
        /// Function to check the existance of Role
        /// </summary>
        /// <param name="decRoleId"></param>
        /// <param name="strRole"></param>
        /// <returns></returns>
        public bool RoleCheckExistence(decimal decRoleId, string strRole)
        {
            bool isEdit = false;
      
            try
            {
                isEdit = spRole.RoleCheckExistence(decRoleId, strRole);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        /// <summary>
        /// Function to Update values in Role Table
        /// </summary>
        /// <param name="infoRole"></param>
        public void RoleEdit(RoleInfo infoRole)
        {           
            try
            {
                spRole.RoleEdit(infoRole);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }
        /// <summary>
        /// Function to get particular values from Role table based on the parameter
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public RoleInfo RoleView(decimal roleId)
        {
            RoleInfo infoRole = new RoleInfo();

            try
            {
                infoRole = spRole.RoleView(roleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoRole;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public decimal RoleReferenceDelete(decimal RoleId)
        {
            decimal decRole = 0;
            try
            {
                decRole = spRole.RoleReferenceDelete(RoleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decRole;
        }
        /// <summary>
        /// Function to insert values to Role Table
        /// </summary>
        /// <param name="infoRole"></param>
        /// <returns></returns>
        public decimal RoleAdd(RoleInfo infoRole)
        {
            decimal decRoleIdentity = 0;
            try
            {
                decRoleIdentity = spRole.RoleAdd(infoRole);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decRoleIdentity;
        }
    }
}
