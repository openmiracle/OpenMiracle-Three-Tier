using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;
using System.Data;

namespace Openmiracle.BLL
{
    public class MonthlySalaryBll
    {
        MonthlySalaryInfo InfoMonthlySalary = new MonthlySalaryInfo();
        MonthlySalarySP SPMonthlySalary = new MonthlySalarySP();
        public List<DataTable> MonthlySalarySettingsEmployeeViewAll(DateTime dtSalaryMonth)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                SPMonthlySalary.MonthlySalarySettingsEmployeeViewAll(dtSalaryMonth);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public decimal MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(DateTime dtSalaryMonth)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPMonthlySalary.MonthlySalarySettingsMonthlySalaryIdSearchUsingSalaryMonth(dtSalaryMonth);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ms2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public void MonthlySalaryDeleteAll(decimal decMonthlySalaryId)
        {
           
            try
            {
                 SPMonthlySalary.MonthlySalaryDeleteAll(decMonthlySalaryId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public decimal MonthlySalaryAddWithIdentity(MonthlySalaryInfo monthlysalaryinfo)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPMonthlySalary.MonthlySalaryAddWithIdentity(monthlysalaryinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
        public void MonthlySalarySettingsEdit(MonthlySalaryInfo monthlysalaryinfo)
        {

            try
            {
                SPMonthlySalary.MonthlySalarySettingsEdit(InfoMonthlySalary);
            }

            catch (Exception ex)
            {
                MessageBox.Show("MS5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool CheckSalaryAlreadyPaidOrNotForAdvancePayment(decimal decEmployeeId, DateTime date)
        {
            bool isPaid = false;
            try
            {
                isPaid = SPMonthlySalary.CheckSalaryAlreadyPaidOrNotForAdvancePayment(decEmployeeId, date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isPaid;
        }
        public bool CheckSalaryStatusForAdvancePayment(decimal decEmployeeId, DateTime date)
        {
            bool isStatus = false;
            try
            {
                isStatus = SPMonthlySalary.CheckSalaryStatusForAdvancePayment(decEmployeeId, date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MS7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isStatus;
        }

       
    }
}
