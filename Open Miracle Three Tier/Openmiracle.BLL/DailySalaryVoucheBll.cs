using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;
using System.Data;

namespace Openmiracle.BLL
{
   public class DailySalaryVoucheBll
    {
       DailySalaryVoucherDetailsSP spDetails = new DailySalaryVoucherDetailsSP();
       DailySalaryVoucherMasterSP SpMaster = new DailySalaryVoucherMasterSP();
       public List<DataTable> DailySalaryVoucherDetailsGridViewAll(string strSalaryDate, bool isEditMode, string strVoucherNumber)
       {
           DailyAttendanceDetailsSP spDailyAttendanceDetails = new DailyAttendanceDetailsSP();
           try
           {
               return spDetails.DailySalaryVoucherDetailsGridViewAll(strSalaryDate, isEditMode, strVoucherNumber);
           }
           catch (Exception)
           {
               throw;
           }
       }
        public string CheckWhetherDailySalaryAlreadyPaid(decimal decEmployeeId, DateTime SalaryDate)
        {

            string strName = null;
            try
            {
                strName = spDetails.CheckWhetherDailySalaryAlreadyPaid(decEmployeeId, SalaryDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return strName;
        }
        public DailySalaryVoucherMasterInfo DailySalaryVoucherViewFromRegister(decimal decDailySalaryVoucehrMasterId)
        {
           
            try
            {
                return SpMaster.DailySalaryVoucherViewFromRegister(decDailySalaryVoucehrMasterId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<DataTable> DailySalaryVoucherMasterAddWithIdentity(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo, bool IsAutomatic)
         
       {
           DailyAttendanceDetailsSP spDailyAttendanceDetails = new DailyAttendanceDetailsSP();
           try
           {
               return SpMaster.DailySalaryVoucherMasterAddWithIdentity(dailysalaryvouchermasterinfo, IsAutomatic);
           }
           catch (Exception)
           {
               throw;
           }
       }
       public void DailySalaryVoucherDetailsAdd(DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo)
        {
          
            try
            {
                spDetails.DailySalaryVoucherDetailsAdd(dailysalaryvoucherdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
       public void DailySalaryVoucherMasterEdit(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo)
       {
           
            try
            {
                SpMaster.DailySalaryVoucherMasterEdit(dailysalaryvouchermasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
       public void DailySalaryVoucherDetailsDelete(decimal DailySalaryVoucherDetailsId)
        {
           try
            {
                spDetails.DailySalaryVoucherDetailsDelete(DailySalaryVoucherDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
       public int DailySalaryVoucherDetailsCount(decimal decMasterId)
       {
 
            int decResult = 0;
            try
            {
                decResult=spDetails.DailySalaryVoucherDetailsCount(decMasterId);
            }
            catch (Exception)
            {

                throw;
            }
            return decResult;
        
       }
       public void DailySalaryVoucherDetailsDeleteUsingMasterId(decimal DailySalaryVoucherDetailsMasterId)
       {
           try
           {
               spDetails.DailySalaryVoucherDetailsDeleteUsingMasterId(DailySalaryVoucherDetailsMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       public List<DataTable> DailySalaryVoucherCashOrBankLedgersComboFill()
        {
            DailyAttendanceDetailsSP spDailyAttendanceDetails = new DailyAttendanceDetailsSP();
            try
            {
                return SpMaster.DailySalaryVoucherCashOrBankLedgersComboFill();
            }
            catch (Exception)
            {
                throw;
            }
        }
       public bool DailySalaryVoucherCheckExistence(string voucherNumber,decimal voucherTypeId , decimal masterId)
          
        {
            bool isResult = false;
            try
            {
                isResult = SpMaster.DailySalaryVoucherCheckExistence(voucherNumber, voucherTypeId, 0);
            }
            catch (Exception)
            {
                throw;
            }
            return isResult;
        }
       public string DailySalaryVoucherMasterGetMax(decimal voucherTypeId)
       {
           string max = "0";
      
            try
            {
                max = SpMaster.DailySalaryVoucherMasterGetMax(voucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        
          
       }
        public void DailySalaryVoucherMasterDelete(decimal DailySalaryVoucehrMasterId)
        {
            try
            {
                SpMaster.DailySalaryVoucherMasterDelete(DailySalaryVoucehrMasterId); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       public decimal SalaryVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                max = SpMaster.SalaryVoucherMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception)
            {

                throw;
            }
            return max;
        }
       public List<DataTable> DailySalaryRegisterSearch(DateTime dtVoucherDateFrom, DateTime dtVoucherDateTo, DateTime dtSalaryDateFrom, DateTime dtSalaryDateTo, string strInvoiceNo)
        {
           
          
           try
           {
               return SpMaster.DailySalaryRegisterSearch(dtVoucherDateFrom, dtVoucherDateTo, dtSalaryDateFrom, dtSalaryDateTo, strInvoiceNo);
           }
           catch (Exception)
           {
               throw;
           }
       }
        
    }
}
