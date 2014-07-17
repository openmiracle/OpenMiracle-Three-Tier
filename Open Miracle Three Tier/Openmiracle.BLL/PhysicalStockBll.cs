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
   public class PhysicalStockBll
    {
       PhysicalStockDetailsSP spPhysicalStockDetails = new PhysicalStockDetailsSP();   
       PhysicalStockMasterSP spPhysicalStockMaster = new PhysicalStockMasterSP();
       
       
       
       public void PhysicalStockDetailsDeleteWhenUpdate(decimal decMasterId)
       {
           try
           {
               spPhysicalStockDetails.PhysicalStockDetailsDeleteWhenUpdate(decMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       /// Function to insert values to PhysicalStockDetails Table
       /// </summary>
       /// <param name="physicalstockdetailsinfo"></param>
       public void PhysicalStockDetailsAdd(PhysicalStockDetailsInfo physicalstockdetailsinfo)
       {
           try
           {
               spPhysicalStockDetails.PhysicalStockDetailsAdd(physicalstockdetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       /// Function to insert values to PhysicalStockMaster Table
       /// </summary>
       /// <param name="physicalstockmasterinfo"></param>
       /// <returns></returns>
       public decimal PhysicalStockMasterAdd(PhysicalStockMasterInfo physicalstockmasterinfo)
       {
           decimal decIdentity = 0;
           try
           {
               decIdentity = spPhysicalStockMaster.PhysicalStockMasterAdd(physicalstockmasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decIdentity;
       }
       public DataSet PhysicalStockPrinting(decimal decPhysicalStockMasterId, decimal decCompanyId)
       {
           DataSet dSt = new DataSet();
           try
           {
               dSt = spPhysicalStockMaster.PhysicalStockPrinting(decPhysicalStockMasterId, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dSt;
       }
       public void PhysicalStockDelete(decimal decPhysicalStockMasterId, decimal decVoucherTypeId, string strVoucherNo)
       {
           try
           {
               spPhysicalStockMaster.PhysicalStockDelete(decPhysicalStockMasterId, decVoucherTypeId, strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public PhysicalStockMasterInfo PhysicalStockMasterView(decimal physicalStockMasterId)
       {
           PhysicalStockMasterInfo infoPhysicalStockMaster = new PhysicalStockMasterInfo();
           try
           {
               infoPhysicalStockMaster = spPhysicalStockMaster.PhysicalStockMasterView(physicalStockMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infoPhysicalStockMaster;
       }
       public List<DataTable> PhysicalStockViewbyMasterId(decimal decPhysicalStockMasterId)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPhysicalStockMaster.PhysicalStockViewbyMasterId(decPhysicalStockMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       public decimal PhysicalStockMasterVoucherMax(decimal decVoucherTypeId)
       {
           decimal decVoucherNoMax = 0;
           try
           {
               decVoucherNoMax = spPhysicalStockMaster.PhysicalStockMasterVoucherMax(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decVoucherNoMax;
       }
       public void PhysicalStockMasterEdit(PhysicalStockMasterInfo physicalstockmasterinfo)
       {
           try
           {
               spPhysicalStockMaster.PhysicalStockMasterEdit(physicalstockmasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public List<DataTable> PhysicalStockRegisterGridFill(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherNo)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPhysicalStockMaster.PhysicalStockRegisterGridFill(dtDateFrom, dtDateTo, strVoucherNo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       public List<DataTable> PhysicalStockReportFill(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherNo, string strProductName, decimal decProductCode, decimal decVoucherTypeId)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spPhysicalStockMaster.PhysicalStockReportFill(dtDateFrom, dtDateTo, strVoucherNo, strProductName, decProductCode, decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PS11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       } 
   }
}
