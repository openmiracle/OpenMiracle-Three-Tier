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
   public  class BarcodeSettingsBll
    {
       BarcodeSettingsInfo infoBarcodeSettings = new BarcodeSettingsInfo();
       BarcodeSettingsSP SpBarcodeSettings = new BarcodeSettingsSP();

       public BarcodeSettingsInfo BarcodeSettingsViewForBarCodePrinting()
       {
           BarcodeSettingsInfo barcodesettingsinfo = new BarcodeSettingsInfo();
           try
           {
               barcodesettingsinfo = SpBarcodeSettings.BarcodeSettingsViewForBarCodePrinting();

           }
           catch (Exception ex)
           {
               MessageBox.Show("BCP1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return barcodesettingsinfo;
       }
          public BarcodeSettingsInfo BarcodeSettingsView(decimal barcodeSettingsId)
        {
            BarcodeSettingsInfo barcodesettingsinfo = new BarcodeSettingsInfo();
            try
            {
                barcodesettingsinfo = SpBarcodeSettings.BarcodeSettingsView(barcodeSettingsId);

            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return barcodesettingsinfo;
        }
          public void BarcodeSettingsAdd(BarcodeSettingsInfo barcodesettingsinfo)
        {
            try
            {
                SpBarcodeSettings.BarcodeSettingsAdd(barcodesettingsinfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("BCP3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
          public List<DataTable> BarcodeSettingsViewAll()
          {
              List<DataTable> listObj = new List<DataTable>();
              try
              {
                  listObj = SpBarcodeSettings.BarcodeSettingsViewAll();

              }
              catch (Exception ex)
              {
                  MessageBox.Show("BCP4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              return listObj;
          }
    }
}
