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
   public class PricingLevelBll
    {
       PricingLevelSP spPricingLevel = new PricingLevelSP();
       public bool PricingLevelCheckIfExist(String strPricingLevelName, decimal decPricingLevelId)
       {
           try
           {
               spPricingLevel.PricingLevelCheckIfExist(strPricingLevelName, decPricingLevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return false;
       }
       public decimal PricingLevelAddWithoutSamePricingLevel(PricingLevelInfo pricinglevelinfo)
       {
           decimal decPricingLevelId = 0;
           try
           {
               decPricingLevelId = spPricingLevel.PricingLevelAddWithoutSamePricingLevel(pricinglevelinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decPricingLevelId;
       }
       public bool PricingLevelEditParticularFields(PricingLevelInfo pricinglevelinfo)
       {
           bool isEdit = false;
           try
           {
               isEdit = spPricingLevel.PricingLevelEditParticularFields(pricinglevelinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isEdit;
       }
       public List<DataTable> PricingLevelOnlyViewAll()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPricingLevel.PricingLevelOnlyViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       public decimal PricingLevelCheckReferenceAndDelete(decimal decPricingLevelId)
       {
           decimal decReturnValue = 0;
           try
           {
               decReturnValue = spPricingLevel.PricingLevelCheckReferenceAndDelete(decPricingLevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decReturnValue;
       }
       public void PricingLevelDelete(decimal PricinglevelId)
       {
           try
           {
               spPricingLevel.PricingLevelDelete(PricinglevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public PricingLevelInfo PricingLevelWithNarrationView(decimal decPricinglevelId)
       {
           PricingLevelInfo pricinglevelinfo = new PricingLevelInfo();
           try
           {
               pricinglevelinfo = spPricingLevel.PricingLevelWithNarrationView(decPricinglevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return pricinglevelinfo;
       }
       /// <summary>
       /// Function to view all pricinglevel
       /// </summary>
       /// <returns></returns>
       public List<DataTable> PricelistPricingLevelViewAllForComboBox()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPricingLevel.PricingLevelOnlyViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// PricingLevel Name View For PriceList PopUp
       /// </summary>
       /// <param name="decPricingLevel"></param>
       /// <param name="decProductId"></param>
       /// <param name="decUnitId"></param>
       /// <returns></returns>
       public PricingLevelInfo PricingLevelNameViewForPriceListPopUp(decimal decPricingLevel, decimal decProductId, decimal decUnitId)
       {
           PricingLevelInfo infoPricingLevel = new PricingLevelInfo();
           try
           {
               infoPricingLevel = spPricingLevel.PricingLevelNameViewForPriceListPopUp(decPricingLevel, decProductId, decUnitId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infoPricingLevel;
       }
       /// <summary>
       /// Function to get particular values from PricingLevel table based on the parameter
       /// </summary>
       /// <param name="pricinglevelId"></param>
       /// <returns></returns>
       public PricingLevelInfo PricingLevelView(decimal pricinglevelId)
       {
           PricingLevelInfo pricinglevelinfo = new PricingLevelInfo();
           try
           {
               pricinglevelinfo = spPricingLevel.PricingLevelView(pricinglevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PRL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return pricinglevelinfo;
       }

    }
}
