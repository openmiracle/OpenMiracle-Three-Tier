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
   public class PriceListBll
    {
       PriceListSP spPriceList = new PriceListSP();

       /// <summary>
       /// Function to use the pricelist gridfill
       /// </summary>
       /// <param name="decgroupId"></param>
       /// <param name="strproductName"></param>
       /// <param name="decsizeId"></param>
       /// <param name="decModelNoId"></param>
       /// <param name="decpricinglevelId"></param>
       /// <returns></returns>
       public List<DataTable> PriceListGridFill(decimal decgroupId, string strproductName, decimal decsizeId, decimal decModelNoId, decimal decpricinglevelId)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPriceList.PriceListGridFill(decgroupId, strproductName, decsizeId, decModelNoId, decpricinglevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Function to use print the report of pricelist details based on search
       /// </summary>
       /// <param name="decgroupId"></param>
       /// <param name="strproductName"></param>
       /// <param name="decsizeId"></param>
       /// <param name="decModelNoId"></param>
       /// <param name="decpricinglevelId"></param>
       /// <returns></returns>
       public List<DataTable> PriceListReportPrint(decimal decgroupId, string strproductName, decimal decsizeId, decimal decModelNoId, decimal decpricinglevelId)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPriceList.PriceListGridFill(decgroupId, strproductName, decsizeId, decModelNoId, decpricinglevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       public List<DataTable> PricelistProductGroupViewAllForComboBox()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPriceList.PricelistProductGroupViewAllForComboBox();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       public List<DataTable> PricelistPricingLevelViewAllForComboBox()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPriceList.PricelistPricingLevelViewAllForComboBox();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       public List<DataTable> ProductDetailsViewGridfill(decimal decgroupId, string strProductCode, string strProductName, string strPricingLevelName)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPriceList.ProductDetailsViewGridfill(decgroupId, strProductCode, strProductName, strPricingLevelName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       public PriceListInfo PriceListViewByBatchIdORProduct(decimal dcBatchId)
       {
           PriceListInfo infoPriceList = new PriceListInfo();
           try
           {
               infoPriceList = spPriceList.PriceListViewByBatchIdORProduct(dcBatchId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infoPriceList;
       }
       /// <summary>
       /// Function to PriceList CheckExistence
       /// </summary>
       /// <param name="decpricelistId"></param>
       /// <param name="decpricinglevelId"></param>
       /// <param name="decbatchId"></param>
       /// <param name="decProductId"></param>
       /// <returns></returns>
       public bool PriceListCheckExistence(decimal decpricelistId, decimal decpricinglevelId, decimal decbatchId, decimal decProductId)
       {
           bool isExist = false;
           try
           {
               isExist = spPriceList.PriceListCheckExistence(decpricelistId,decpricinglevelId,decbatchId,decProductId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExist;
       }
       /// <summary>
       /// Function to insert values to PriceList Table
       /// </summary>
       /// <param name="pricelistinfo"></param>
       public void PriceListAdd(PriceListInfo pricelistinfo)
       {
          
           try
           {
               spPriceList.PriceListAdd(pricelistinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }        
       }
       /// <summary>
       /// Function to delete particular details based on the parameter From Table PriceList
       /// </summary>
       /// <param name="PricelistId"></param>
       public void PriceListDelete(decimal PricelistId)
       {

           try
           {
               spPriceList.PriceListDelete(PricelistId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       /// Function to Update values in PriceList Table
       /// </summary>
       /// <param name="pricelistinfo"></param>
       public void PriceListEdit(PriceListInfo pricelistinfo)
       {
           try
           {
               spPriceList.PriceListEdit(pricelistinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }

       public List<DataTable> PriceListGridFill()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPriceList.PriceListGridFill();
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Pricelist check reference for delete
       /// </summary>
       /// <param name="decpricinglevelId"></param>
       /// <returns></returns>
       public decimal PriceListCheckReferenceAndDelete(decimal decpricinglevelId)
       {
           decimal decReturnValue = 0;
           try
           {
               decReturnValue = spPriceList.PriceListCheckReferenceAndDelete(decpricinglevelId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decReturnValue;
       }
       /// <summary>
       /// Function to get particular values from PriceList Table based on the parameter
       /// </summary>
       /// <param name="pricelistId"></param>
       /// <returns></returns>
       public PriceListInfo PriceListView(decimal pricelistId)
       {
           PriceListInfo pricelistinfo = new PriceListInfo();
           try
           {
               pricelistinfo = spPriceList.PriceListView(pricelistId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return pricelistinfo;
       }
       /// <summary>
       /// Function to use fill the grid pricelist popup grid
       /// </summary>
       /// <param name="decPriceLevelId"></param>
       /// <param name="decProductId"></param>
       /// <returns></returns>
       public List<DataTable> PriceListPopupGridFill(decimal decPriceLevelId, decimal decProductId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spPriceList.PriceListPopupGridFill(decPriceLevelId, decProductId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
   }
}
