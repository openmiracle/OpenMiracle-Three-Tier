using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;
namespace Openmiracle.BLL
{
   public class SalaryVoucherDetailsBll
    {
       SalaryVoucherDetailsSP SPSalaryVoucherDetails = new SalaryVoucherDetailsSP();
       SalaryVoucherDetailsInfo InfoSalaryVoucherDetails = new SalaryVoucherDetailsInfo();
       
       
       public List<DataTable> MonthlySalaryVoucherDetailsViewAll(string strMonth, string Month, string monthYear, bool isEditMode, string strVoucherNoforEdit)
       {
           List<DataTable> list = new List<DataTable>();
           try
           {
               list = SPSalaryVoucherDetails.MonthlySalaryVoucherDetailsViewAll(strMonth, Month, monthYear, isEditMode, strVoucherNoforEdit);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
       public string CheckWhetherSalaryAlreadyPaid(decimal decEmployeeId, DateTime Month)
       {
           string strName = string.Empty;
           try
           {
               strName = SPSalaryVoucherDetails.CheckWhetherSalaryAlreadyPaid(decEmployeeId, Month);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return strName;
       }
       public void MonthlySalaryVoucherDetailsAdd(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
       {
          
           try
           {
               SPSalaryVoucherDetails.MonthlySalaryVoucherDetailsAdd(salaryvoucherdetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
          
       }
       public void SalaryVoucherDetailsEdit(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
       {

           try
           {
               SPSalaryVoucherDetails.SalaryVoucherDetailsEdit(salaryvoucherdetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       public void SalaryVoucherDetailsDelete(decimal SalaryVoucherDetailsId)
       {

           try
           {
               SPSalaryVoucherDetails.SalaryVoucherDetailsDelete(SalaryVoucherDetailsId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       
       public int SalaryVoucherDetailsCount(decimal decMasterId)
       {
           int decResult = 0;
           try
           {
              decResult= SPSalaryVoucherDetails.SalaryVoucherDetailsCount(decMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decResult;
       }
      
       
       public void SalaryVoucherDetailsDeleteUsingMasterId(decimal SalaryVoucherDetailsMasterId)
       {
           try
           {
               SPSalaryVoucherDetails.SalaryVoucherDetailsDeleteUsingMasterId(SalaryVoucherDetailsMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       
       }
       
    }
}
