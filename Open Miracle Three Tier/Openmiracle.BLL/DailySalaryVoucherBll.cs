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
   public class DailySalaryVoucherBll
    {
       DailySalaryVoucherDetailsInfo infoDailySalaryVoucherDetails = new DailySalaryVoucherDetailsInfo();
       DailySalaryVoucherDetailsSP SpDailySalaryVoucherDetails = new DailySalaryVoucherDetailsSP();
       DailySalaryVoucherMasterInfo infoDailySalaryVoucherMaster = new DailySalaryVoucherMasterInfo();
       DailySalaryVoucherMasterSP SpDailySalaryVoucherMaster = new DailySalaryVoucherMasterSP();

       public string CheckWhetherDailySalaryAlreadyPaid(decimal decEmployeeId, DateTime SalaryDate)
       {
           string strName = string.Empty;
           try
           {
               strName = SpDailySalaryVoucherDetails.CheckWhetherDailySalaryAlreadyPaid(decEmployeeId, SalaryDate);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DSV1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return strName;
       }
        public void DailySalaryVoucherDetailsAdd(DailySalaryVoucherDetailsInfo dailysalaryvoucherdetailsinfo)
        {
            try
            {
                SpDailySalaryVoucherDetails.DailySalaryVoucherDetailsAdd(dailysalaryvoucherdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
         public void DailySalaryVoucherDetailsDelete(decimal DailySalaryVoucherDetailsId)
        {
            try
            {
                SpDailySalaryVoucherDetails.DailySalaryVoucherDetailsDelete(DailySalaryVoucherDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public int DailySalaryVoucherDetailsCount(decimal decMasterId)
        {
            int max = 0;
            try
            {

                max = SpDailySalaryVoucherDetails.DailySalaryVoucherDetailsCount(decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
       public void DailySalaryVoucherDetailsDeleteUsingMasterId(decimal DailySalaryVoucherDetailsMasterId)
        {
            try
            {
                SpDailySalaryVoucherDetails.DailySalaryVoucherDetailsDeleteUsingMasterId(DailySalaryVoucherDetailsMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        public List<DataTable> DailySalaryVoucherDetailsGridViewAll(string strSalaryDate, bool isEditMode, string strVoucherNumber)
        {
         
            List<DataTable> listDailySalaryVoucherDetailsGridViewAll = new List<DataTable>();
            try
            {

                listDailySalaryVoucherDetailsGridViewAll = SpDailySalaryVoucherDetails.DailySalaryVoucherDetailsGridViewAll(strSalaryDate, isEditMode, strVoucherNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listDailySalaryVoucherDetailsGridViewAll;
        }
        public List<DataTable> DailySalaryRegisterSearch(DateTime dtVoucherDateFrom, DateTime dtVoucherDateTo, DateTime dtSalaryDateFrom, DateTime dtSalaryDateTo, string strInvoiceNo)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpDailySalaryVoucherMaster.DailySalaryRegisterSearch(dtVoucherDateFrom, dtVoucherDateTo, dtSalaryDateFrom, dtSalaryDateTo, strInvoiceNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
       public List<DataTable> DailySalaryVoucherCashOrBankLedgersComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();

            try
            {
                listObj = SpDailySalaryVoucherMaster.DailySalaryVoucherCashOrBankLedgersComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public DailySalaryVoucherMasterInfo DailySalaryVoucherViewFromRegister(decimal decDailySalaryVoucehrMasterId)
        {
            DailySalaryVoucherMasterInfo infoDailySalaryVoucherMaster = new DailySalaryVoucherMasterInfo();
            try
            {
                infoDailySalaryVoucherMaster = SpDailySalaryVoucherMaster.DailySalaryVoucherViewFromRegister(decDailySalaryVoucehrMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoDailySalaryVoucherMaster;
        }
        public bool DailySalaryVoucherCheckExistence(string voucherNumber, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;
            try
            {
                trueOrfalse = SpDailySalaryVoucherMaster.DailySalaryVoucherCheckExistence(voucherNumber, voucherTypeId, masterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
       public List<DataTable> DailySalaryVoucherMasterAddWithIdentity(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo, bool IsAutomatic)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SpDailySalaryVoucherMaster.DailySalaryVoucherMasterAddWithIdentity(dailysalaryvouchermasterinfo, IsAutomatic);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public string DailySalaryVoucherMasterGetMax(decimal voucherTypeId)
        {
            string max = "0";
            try
            {
                max = SpDailySalaryVoucherMaster.DailySalaryVoucherMasterGetMax(voucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        public void DailySalaryVoucherMasterEdit(DailySalaryVoucherMasterInfo dailysalaryvouchermasterinfo)
        {

            try
            {
                SpDailySalaryVoucherMaster.DailySalaryVoucherMasterEdit(dailysalaryvouchermasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DailySalaryVoucherMasterDelete(decimal DailySalaryVoucehrMasterId)
        {
            try
            {
                SpDailySalaryVoucherMaster.DailySalaryVoucherMasterDelete(DailySalaryVoucehrMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal SalaryVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            try
            {
                max = SpDailySalaryVoucherMaster.SalaryVoucherMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DSV15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }

       

    }
}
