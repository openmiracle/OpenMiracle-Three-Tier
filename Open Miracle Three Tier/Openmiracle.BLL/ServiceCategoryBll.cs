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
   public class ServiceCategoryBll
    {
       ServiceCategorySP spServiceCatogory = new ServiceCategorySP();
       /// <summary>
       /// Function to view all details 
       /// </summary>
       /// <returns></returns>
       public List<DataTable> ServiceCategoryParticularFieldsViewAll()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spServiceCatogory.ServiceCategoryParticularFieldsViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Function to check existence of service category based on parameter
       /// </summary>
       /// <param name="strCategoryName"></param>
       /// <param name="decServiceCategoryId"></param>
       /// <returns></returns>
       public bool ServiceCategoryCheckIfExist(String strCategoryName, decimal decServiceCategoryId)
       {
           bool inChek = false;
           try
           {
               inChek = spServiceCatogory.ServiceCategoryCheckIfExist(strCategoryName, decServiceCategoryId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return inChek;
       }
       /// <summary>
       /// Function to add values to ServiceCategory Table
       /// </summary>
       /// <param name="servicecategoryinfo"></param>
       /// <returns></returns>
       public decimal ServiceCategoryAddSpecificFields1(ServiceCategoryInfo servicecategoryinfo)
       {
           decimal decId = 0;
           try
           {
               decId = spServiceCatogory.ServiceCategoryAddSpecificFields1(servicecategoryinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// Function to check status for Update
       /// </summary>
       /// <param name="servicecategoryinfo"></param>
       /// <returns></returns>
       public bool ServiceCategoryEditParticularFeilds(ServiceCategoryInfo servicecategoryinfo)
       {
           bool isEdit = false;
           try
           {
               isEdit = spServiceCatogory.ServiceCategoryEditParticularFeilds(servicecategoryinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isEdit;
       }
       /// <summary>
       /// Function to check reference and delete based on parameter
       /// </summary>
       /// <param name="decServiceCategoryId"></param>
       /// <returns></returns>
       public decimal ServiceCategoryCheckReferenceAndDelete(decimal decServiceCategoryId)
       {
           decimal decReturnValue = 0;
           try
           {
               decReturnValue = spServiceCatogory.ServiceCategoryCheckReferenceAndDelete(decServiceCategoryId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decReturnValue;
       }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="ServicecategoryId"></param>
       public void ServiceCategoryDelete(decimal ServicecategoryId)
       {
           try
           {
              spServiceCatogory.ServiceCategoryDelete(ServicecategoryId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
     
       }
       /// <summary>
       /// Function to view details based on parameter
       /// </summary>
       /// <param name="decServiceCategoryId"></param>
       /// <returns></returns>
       public ServiceCategoryInfo ServiceCategoryWithNarrationView(decimal decServiceCategoryId)
       {
           ServiceCategoryInfo ServiceCategoryinfo = new ServiceCategoryInfo();
           try
           {
               ServiceCategoryinfo = spServiceCatogory.ServiceCategoryWithNarrationView(decServiceCategoryId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ServiceCategoryinfo;
       }
       /// <summary>
       /// unction to get all the values from ServiceCategory Table
       /// </summary>
       /// <returns></returns>
       public List<DataTable> ServiceCategoryViewAll()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spServiceCatogory.ServiceCategoryViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("SC8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }

    }
}
