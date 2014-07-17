using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenMiracle.DAL;
using System.Windows.Forms;
using System.Data;
using ENTITY;

namespace OpenMiracle.BLL
{
   public  class UserBll
    {
        
        public void UserAdd(UserInfo infoUser)
        {
            UserSP spUser = new UserSP();
            try
            {
                spUser.UserAdd(infoUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Function to Update values in account group Table
        /// </summary>
        /// <param name="userinfo"></param>
        public void UserEdit(UserInfo infoUser)
        {
            UserSP spUser = new UserSP();
            try
            {
                spUser.UserEdit(infoUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        /// <summary>
        /// Function to get all the values from account group Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> UserViewAll()
        {
            UserSP spUser = new UserSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spUser.UserViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from account group table based on the parameter
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserInfo UserView(decimal userId)
        {
            UserInfo infoUser = new UserInfo();
            UserSP spUser = new UserSP();
            try
            {
                infoUser=spUser.UserView( userId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return infoUser;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="UserId"></param>
        public void UserDelete(decimal UserId)
        {
            UserSP spUser = new UserSP();
            try
            {
                spUser.UserDelete( UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Function to  get the next id for AdditionalCost table
        /// </summary>
        /// <returns></returns>
        public int UserGetMax()
        {
            UserSP spUser = new UserSP();
            int inMax = 0;
            try
            {
                inMax = spUser.UserGetMax();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return inMax;
        }
        /// <summary>
        /// Function to view all from User table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> UserCreationViewAll()
        {
            UserSP spUser = new UserSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spUser.UserCreationViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function to check existence of User based on parameter
        /// </summary>
        /// <param name="decUserId"></param>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public bool UserCreationCheckExistence(decimal decUserId, string strUserName)
        {
            UserSP spUser = new UserSP();
            bool isEdit = false;
            try
            {
                isEdit=spUser.UserCreationCheckExistence( decUserId,  strUserName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return isEdit;
        }
        /// <summary>
        /// Function to view all details from user Table based on parameter
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strRole"></param>
        /// <returns></returns>
        public List<DataTable> UserCreationViewForGridFill(string strUserName, string strRole)
        {
            UserSP spUser = new UserSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
               ListObj=spUser.UserCreationViewForGridFill( strUserName,  strRole);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function for check refernce and delete based on parameter
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public decimal UserCreationReferenceDelete(decimal userId)
        {
            UserSP spUser = new UserSP();
            decimal decUser = 0;
            try
            {
                decUser=spUser.UserCreationReferenceDelete( userId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
            return decUser;
        }
        /// <summary>
        /// Function to check Password on Login 
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public string LoginCheck(string strUserName)
        {
            UserSP spUser = new UserSP();
            string strPsw = string.Empty;
            try
            {
                strPsw = spUser.LoginCheck(strUserName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return strPsw;
        }
        /// <summary>
        /// Function to Get UserId After Login based on parameter
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public int GetUserIdAfterLogin(string strUserName, string strPassword)
        {
            UserSP spUser = new UserSP();
            int inUserId = 0;
            try
            {
                inUserId = spUser.GetUserIdAfterLogin(strUserName, strPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return inUserId;
        }
        /// <summary>
        /// Function to Update password
        /// </summary>
        /// <param name="userinfo"></param>
        public void ChangePasswordEdit(UserInfo infoUser)
        {
            UserSP spUser = new UserSP();
            try
            {
                spUser.ChangePasswordEdit(infoUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("UBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
