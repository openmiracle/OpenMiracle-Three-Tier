using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using ENTITY;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{
  public class SettingsBll
    {
      SettingsSP spSettings = new SettingsSP();

      /// <summary>
      /// Function to check settings status based on parameter
      /// </summary>
      /// <param name="strSettingsName"></param>
      /// <returns></returns>
      public string SettingsStatusCheck(string strSettingsName)
      {
          string strStatus = string.Empty;
          try
          {
              strStatus = spSettings.SettingsStatusCheck(strSettingsName);
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return strStatus;
      }
      /// <summary>
      /// Function to check status of Automatic Product Code Generation and return status
      /// </summary>
      /// <returns></returns>
      public bool AutomaticProductCodeGeneration()
      {         
          bool isTrue = false;
          try
          {
              isTrue = spSettings.AutomaticProductCodeGeneration();
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return isTrue;
      }
      /// <summary>
      /// Function to check reference of settings
      /// </summary>
      /// <returns></returns>
      public List<DataTable> SettinsCheckReference()
      {
          List<DataTable> listObj = new List<DataTable>();
          try
          {
              listObj = spSettings.SettinsCheckReference();
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return listObj;
      }
      /// <summary>
      /// Function to check status of  Product Code display status and return status
      /// </summary>
      /// <returns></returns>
      public bool ShowBarcode()
      {        
          bool isTrue = false;
          try
          {
              isTrue = spSettings.ShowBarcode();
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return isTrue;
      }
      /// <summary>
      /// Function to view  settings based on parameter
      /// </summary>
      /// <param name="strsettingsName"></param>
      /// <returns></returns>
      public SettingsInfo SettingsView(string strsettingsName)
      {
          SettingsInfo settingsinfo = new SettingsInfo();
          try
          {
              settingsinfo = spSettings.SettingsView(strsettingsName);
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return settingsinfo;
      }
      /// <summary>
      /// Function to view settings based on parameter to copy
      /// </summary>
      /// <param name="strsettingsName"></param>
      /// <returns></returns>
      public SettingsInfo SettingsToCopyView(string strsettingsName)
      {
          SettingsInfo settingsinfo = new SettingsInfo();
          try
          {
              settingsinfo = spSettings.SettingsToCopyView(strsettingsName);
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return settingsinfo;
      }

        /// <summary>
        /// Function to copy settings
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SettingsToCopyViewAll()
        {          
          List<DataTable> listObj = new List<DataTable>();
          try
          {
              listObj = spSettings.SettingsToCopyViewAll();
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return listObj;
      }

        /// <summary>
        /// Function to get all the values from Settings Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> SettingsViewAll()
        {
          List<DataTable> listObj = new List<DataTable>();
          try
          {
              listObj = spSettings.SettingsViewAll();
          }
          catch (Exception ex)
          {
              MessageBox.Show("ST8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return listObj;
      }
        /// <summary>
        /// Function to check status of  Product Code display status and return status
        /// </summary>
        /// <returns></returns>
        public bool ShowProductCode()
        {          
            bool isTrue = false;
            try
            {
                isTrue = spSettings.ShowProductCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTrue;
        }
        /// <summary>
        /// Function to check status of  Product Code display status and return status
        /// </summary>
        /// <returns></returns>
        public bool ShowCurrencySymbol()
        {           
            bool isTrue = false;
            try
            {
                isTrue = spSettings.ShowCurrencySymbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isTrue;
        }
        /// <summary>
        /// Function to get id of settings based on parameter
        /// </summary>
        /// <param name="strsettingsName"></param>
        /// <returns></returns>
        public decimal SettingsGetId(string strsettingsName)
        {
            decimal decSettingsId = 0;
            try
            {
                decSettingsId = spSettings.SettingsGetId(strsettingsName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decSettingsId;
        }
        /// <summary>
        /// Function to Update values in Settings Table
        /// </summary>
        /// <param name="settingsinfo"></param>
        public void SettingsEdit(SettingsInfo settingsinfo)
        {
            try
            {
                spSettings.SettingsEdit(settingsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ST12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
