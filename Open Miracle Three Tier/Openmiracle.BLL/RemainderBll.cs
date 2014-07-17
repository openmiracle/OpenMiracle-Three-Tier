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
  public  class RemainderBll
    {
      ReminderSP spReminder = new ReminderSP();
      public List<DataTable> OverDuePurchaseOrdersCorrespondingAccountLedger(decimal decLedgerId)
      {
          List<DataTable> listobj = new List<DataTable>();
          try
          {
              listobj = spReminder.OverDuePurchaseOrdersCorrespondingAccountLedger( decLedgerId);
          }
          catch (Exception ex)
          {
              MessageBox.Show("RM1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return listobj;

      }
      public bool ReminderAdd(ReminderInfo reminderinfo)
      {
          bool trueOrfalse = false;
          try
          {
              trueOrfalse = spReminder.ReminderAdd(reminderinfo);
          }
          catch (Exception ex)
          {
              MessageBox.Show("RM2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return trueOrfalse;
      }
      public bool RemainderEdit(ReminderInfo remainderinfo)
      {
          bool trueOrfalse = false;
          try
          {
              trueOrfalse = spReminder.RemainderEdit(remainderinfo);
          }
          catch (Exception ex)
          {
              MessageBox.Show("RM3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return trueOrfalse;
      }
      public bool RemainderDelete(decimal Remainder)
      {
          bool trueOrfalse = false;
          try
          {
              trueOrfalse = spReminder.RemainderDelete(Remainder);
          }
          catch (Exception ex)
          {
              MessageBox.Show("RM4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return trueOrfalse;
      }
      public List<DataTable> ReminderSearch(string strfromDate, string strToDate)
      {
          List<DataTable> list = new List<DataTable>();

          try
          {
              list = spReminder.ReminderSearch(strfromDate, strToDate);
          }
          catch (Exception ex)
          {
              MessageBox.Show("RM5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return list;

      }
      public List<DataTable> OverdueSalesOrderCorrespondingAccountLedger(decimal decLedgerId)
      {
          List<DataTable> list = new List<DataTable>();

          try
          {
              list = spReminder.OverdueSalesOrderCorrespondingAccountLedger( decLedgerId);
          }
          catch (Exception ex)
          {
              MessageBox.Show("RM6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return list;
      }
       public List<DataTable> ShortExpiryReminderGridFill(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId)
       
       {
           List<DataTable> list = new List<DataTable>();

          try
          {
              list = spReminder.ShortExpiryReminderGridFill( groupId,  productId,  brandId,  sizeId,  modelNoId,  taxId,  godownId,  rackId);
          }
          catch (Exception ex)
          {
              MessageBox.Show("RM6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return list;
       }
       public List<DataTable> StockSearch(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId, string strcriteria)
       {

           List<DataTable> list = new List<DataTable>();

           try
           {
               list = spReminder.StockSearch( groupId,  productId,  brandId,  sizeId,  modelNoId,  taxId,  godownId,  rackId,  strcriteria);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RM6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;

       }
       public DataSet ShortExpiryReportPrinting(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal godownId, decimal rackId, decimal tExpiry, string cExpiry, DateTime today, decimal companyId)
       {

           DataSet dst = new DataSet();
           try
           {
               dst = spReminder.ShortExpiryReportPrinting( groupId,  productId,  brandId,  sizeId,  modelNoId,  godownId,  rackId,  tExpiry,  cExpiry,  today,  companyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RO6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dst;
       }
       public ReminderInfo RemainderView(decimal remainder)

  {
      ReminderInfo infoReminder = new ReminderInfo();
      try
      {
          infoReminder = spReminder.RemainderView( remainder);
      }
      catch (Exception ex)
      {
          MessageBox.Show("ROI2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      return infoReminder;
       }
       public List<DataTable> ShortExpiryReminder(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal taxId, decimal godownId, decimal rackId)
       {
           List<DataTable> list = new List<DataTable>();

           try
           {
               list = spReminder.ShortExpiryReminder(groupId, productId, brandId, sizeId, modelNoId, taxId, godownId, rackId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RM6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
       public List<DataTable> ShortExpiryReportGridFill(decimal groupId, decimal productId, decimal brandId, decimal sizeId, decimal modelNoId, decimal godownId, decimal rackId, decimal tExpiry, string cExpiry, DateTime today)

       {
           List<DataTable> list = new List<DataTable>();

           try
           {
               list = spReminder.ShortExpiryReportGridFill( groupId,  productId,  brandId,  sizeId,  modelNoId,  godownId,  rackId,  tExpiry,  cExpiry, today);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RM6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
    }
}
