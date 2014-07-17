using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENTITY;
using OpenMiracle.DAL;
using System.Data;
using System.Windows.Forms; 
using OpenMiracle.BLL; 

namespace OpenMiracle.BLL
{
  public  class AttendanceBll
    {
      DailyAttendanceDetailsInfo infoDailyAttendanceDetails = new DailyAttendanceDetailsInfo();
      DailyAttendanceDetailsSP SpDailyAttendanceDetails = new DailyAttendanceDetailsSP();
      DailyAttendanceMasterInfo infoDailyAttendanceMaster = new DailyAttendanceMasterInfo();
      DailyAttendanceMasterSP SpDailyAttendanceMaster = new DailyAttendanceMasterSP();

      public List<DataTable> DailyAttendanceDetailsSearchGridFill(string strDate)
      {
          List<DataTable> listObj = new List<DataTable>();
          try
          {
              listObj = SpDailyAttendanceDetails.DailyAttendanceDetailsSearchGridFill(strDate);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return listObj;
      }
      public void DailyAttendanceDetailsAddUsingMasterId(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
      {
          try
          {
              SpDailyAttendanceDetails.DailyAttendanceDetailsAddUsingMasterId(dailyattendancedetailsinfo);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
      }
      public void DailyAttendanceDetailsEditUsingMasterId(DailyAttendanceDetailsInfo dailyattendancedetailsinfo)
      {
          try
          {
              SpDailyAttendanceDetails.DailyAttendanceDetailsEditUsingMasterId(dailyattendancedetailsinfo);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
      }
      public void DailyAttendanceDetailsDeleteAll(decimal decdailyAttendanceMasterId)
      {
          try
          {
              SpDailyAttendanceDetails.DailyAttendanceDetailsDeleteAll(decdailyAttendanceMasterId);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
      }
      public bool DailyAttendanceMasterMasterIdSearch(string strDate)
      {


          bool isEdit = false;
          try
          {
              isEdit = SpDailyAttendanceMaster.DailyAttendanceMasterMasterIdSearch(strDate);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return isEdit;
      }
      public List<DataTable> MonthlyAttendanceReportFill(DateTime dtMonth, decimal decEmployeeId)
      {
          List<DataTable> listObj = new List<DataTable>();
          try
          {
              listObj = SpDailyAttendanceMaster.MonthlyAttendanceReportFill(dtMonth, decEmployeeId);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return listObj;
      }
      public List<DataTable> DailyAttendanceViewForDailyAttendanceReport(string strDate, string strStatus, string strEmployeeCode, string strDesignation)
      {
          List<DataTable> listObj = new List<DataTable>();
          try
          {
              listObj = SpDailyAttendanceMaster.DailyAttendanceViewForDailyAttendanceReport(strDate, strStatus, strEmployeeCode, strDesignation);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

          }
          return listObj;
      }
      public decimal DailyAttendanceAddToMaster(DailyAttendanceMasterInfo dailyattendancemasterinfo)
      {
          decimal incount = 0;
          try
          {
              incount = SpDailyAttendanceMaster.DailyAttendanceAddToMaster(dailyattendancemasterinfo);
          }
          catch (Exception ex)
          {
              MessageBox.Show("A8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          return incount;
      }
      public void DailyAttendanceEditMaster(DailyAttendanceMasterInfo dailyattendancemasterinfo)
      {
            try
            {
                SpDailyAttendanceMaster.DailyAttendanceEditMaster(dailyattendancemasterinfo);
            }
            catch(Exception ex)
                {
                     MessageBox.Show("A9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
         }
               
    }
}
