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
    public class MonthlySalaryVoucherBll
    {
        MonthlySalaryDetailsInfo infoMonthlySalaryDetails = new MonthlySalaryDetailsInfo();
        MonthlySalaryDetailsSP SpMonthlySalaryDetails = new MonthlySalaryDetailsSP();
        MonthlySalaryInfo infoMonthlySalary = new MonthlySalaryInfo();
        MonthlySalarySP SpMonthlySalary = new MonthlySalarySP();
        public void MonthlySalaryDetailsAddWithMonthlySalaryId(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
        {
            try
            {
                SpMonthlySalaryDetails.MonthlySalaryDetailsAddWithMonthlySalaryId(monthlysalarydetailsinfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        public void MonthlySalaryDetailsEditUsingMasterIdAndDetailsId(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
        {

            try
            {
                SpMonthlySalaryDetails.MonthlySalaryDetailsEditUsingMasterIdAndDetailsId(monthlysalarydetailsinfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void MonthlySalarySettingsDetailsIdDelete(decimal MonthlySalaryDetailsId)
        {
            try
            {
                SpMonthlySalaryDetails.MonthlySalarySettingsDetailsIdDelete(MonthlySalaryDetailsId);

            }
            catch (Exception ex)
            {
                MessageBox.Show("MSV:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public List<DataTable> MonthlySalryViewAllForMonthlySalaryReports(DateTime dtpFromDate, DateTime dtpToDate, string strDesignation, string strEmployeeCode, DateTime dtpSalaryMonth)//Coded By Swafiyy
        {
            List<DataTable> listMonthlySalry = new List<DataTable>();
            try
            {

                listMonthlySalry = SpMonthlySalary.MonthlySalryViewAllForMonthlySalaryReports(dtpFromDate, dtpToDate, strDesignation, strEmployeeCode, dtpSalaryMonth);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listMonthlySalry;
        }
         public bool CheckSalaryAlreadyPaidOrNotForAdvancePayment(decimal decEmployeeId, DateTime date)
        {
            bool isPaid = false;
            try
            {
                isPaid = SpMonthlySalary.CheckSalaryAlreadyPaidOrNotForAdvancePayment(decEmployeeId, date);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isPaid;
        }
         public bool CheckSalaryStatusForAdvancePayment(decimal decEmployeeId, DateTime date)
        {
            bool isStatus = false;
            try
            {
                isStatus = SpMonthlySalary.CheckSalaryStatusForAdvancePayment(decEmployeeId, date);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isStatus;
        }
        public decimal MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(DateTime dtSalaryMonth)
        {
            decimal i = 0;
            try
            {

                i = SpMonthlySalary.MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(dtSalaryMonth);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return i;
        }
         public List<DataTable> MonthlySalarySettingsEmployeeViewAll(DateTime dtSalaryMonth)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {

                listObj = SpMonthlySalary.MonthlySalarySettingsEmployeeViewAll(dtSalaryMonth);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
            public void MonthlySalaryDeleteAll(decimal decMonthlySalaryId)
        {
            try
            {

                SpMonthlySalary.MonthlySalaryDeleteAll(decMonthlySalaryId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:9" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
         public decimal MonthlySalaryAddWithIdentity(MonthlySalaryInfo monthlysalaryinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = SpMonthlySalary.MonthlySalaryAddWithIdentity(monthlysalaryinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:10" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
         public void MonthlySalarySettingsEdit(MonthlySalaryInfo monthlysalaryinfo)
        {
            try
            {
                SpMonthlySalary.MonthlySalarySettingsEdit(monthlysalaryinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("MSV:11" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
