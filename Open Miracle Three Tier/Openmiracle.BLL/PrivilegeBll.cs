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
    public class PrivilegeBll
    {

        public List<DataTable> PrivilegeSettingsSearch(decimal decRoleId)
        {
            PrivilegeSP spPrivilege = new PrivilegeSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPrivilege.PrivilegeSettingsSearch(decRoleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRV1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to use the Privilege Action Search
        /// </summary>
        /// <param name="strAction"></param>
        /// <param name="decRoleId"></param>
        /// <returns></returns>
        public List<DataTable> PrivilegeActionSearch(string strAction, decimal decRoleId)
        {
            PrivilegeSP spPrivilege = new PrivilegeSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spPrivilege.PrivilegeActionSearch(strAction, decRoleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRV2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to use the Privilege Delete a Tabel using role
        /// </summary>
        /// <param name="RoleId"></param>
        public void PrivilegeDeleteTabel(decimal RoleId)
        {
            PrivilegeSP spPrivilege = new PrivilegeSP();
            try
            {
                spPrivilege.PrivilegeDeleteTabel(RoleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRV3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to insert values to Privilege Table
        /// </summary>
        /// <param name="privilegeinfo"></param>
        public void PrivilegeAdd(PrivilegeInfo privilegeinfo)
        {
            try
            {
                PrivilegeSP spPrivilege = new PrivilegeSP();
                spPrivilege.PrivilegeAdd(privilegeinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRV4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// function to use the RolePrivilege to add a new item CheckExistence
        /// </summary>
        /// <param name="decRoleId"></param>
        /// <returns></returns>
        public bool RolePrivilegeSaveCheckExistence(decimal decRoleId)
        {
            bool isEdit = false;
            try
            {
                PrivilegeSP spPrivilege = new PrivilegeSP();
                isEdit = spPrivilege.RolePrivilegeSaveCheckExistence(decRoleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRV5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// This function To use the PrivilegeCheck
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="formName"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool PrivilegeCheck(decimal userId, string formName, string action)
        {
            bool isCheck = false;
            try
            {
                PrivilegeSP spPrivilege = new PrivilegeSP();
                isCheck = spPrivilege.PrivilegeCheck(userId, formName, action);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRV6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isCheck;
        }
    }
}
