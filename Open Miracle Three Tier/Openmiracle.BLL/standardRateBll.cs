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
   public class standardRateBll
    {
       StandardRateSP spStandaredRate = new StandardRateSP();
       /// <summary>
       /// Function to get all details for Gridfill based on parameter
       /// </summary>
       /// <param name="decProductId"></param>
       /// <returns></returns>
       public List<DataTable> StandardRateGridFill(decimal decProductId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spStandaredRate.StandardRateGridFill(decProductId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// Function to check existence of StandardRate based on the parameter
       /// </summary>
       /// <param name="decstandardRateId"></param>
       /// <param name="dtapplicableFrom"></param>
       /// <param name="dtapplicableTo"></param>
       /// <param name="decProductId"></param>
       /// <param name="decBatchId"></param>
       /// <returns></returns>
       public bool StandardrateCheckExistence(decimal decstandardRateId, DateTime dtapplicableFrom, DateTime dtapplicableTo, decimal decProductId, decimal decBatchId)
       {
           bool isExist = false;
           try
           {
               isExist = spStandaredRate.StandardrateCheckExistence(decstandardRateId, dtapplicableFrom, dtapplicableTo, decProductId, decBatchId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExist;
       }
       /// <summary>
       /// Function to insert values to StandardRate Table and return the Curresponding row's Id
       /// </summary>
       /// <param name="standardrateinfo"></param>
       /// <returns></returns>
       public decimal StandardRateAddParticularfields(StandardRateInfo standardrateinfo)
       {
           decimal decStandardRateId = 0;
           try
           {
               decStandardRateId = spStandaredRate.StandardRateAddParticularfields(standardrateinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decStandardRateId;
       }
       /// <summary>
       /// Function to get particular values from StandardRate table based on the parameter
       /// </summary>
       /// <param name="standardRateId"></param>
       /// <returns></returns>
       public StandardRateInfo StandardRateView(decimal standardRateId)
       {
           StandardRateInfo standardrateinfo = new StandardRateInfo();
           try
           {
               standardrateinfo = spStandaredRate.StandardRateView(standardRateId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return standardrateinfo;
       }
       /// <summary>
       /// Function to Update values in StandardRate Table
       /// </summary>
       /// <param name="standardrateinfo"></param>
       public void StandardRateEdit(StandardRateInfo standardrateinfo)
       {          
           try
           {
               spStandaredRate.StandardRateEdit(standardrateinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }          
       }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="StandardRateId"></param>
       public void StandardRateDelete(decimal StandardRateId)
       {
           try
           {
               spStandaredRate.StandardRateDelete(StandardRateId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
    }
}
