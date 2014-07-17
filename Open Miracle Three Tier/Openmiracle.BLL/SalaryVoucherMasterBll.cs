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
   public class SalaryVoucherMasterBll
    {
       SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();
       public void SalaryVoucherMasterEdit(SalaryVoucherMasterInfo salaryvouchermasterinfo)
       {

           try
           {
               SPSalaryVoucherMaster.SalaryVoucherMasterEdit(salaryvouchermasterinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       public void SalaryVoucherMasterDelete(decimal SalaryVoucherMasterId)
       {

           try
           {
               SPSalaryVoucherMaster.SalaryVoucherMasterDelete(SalaryVoucherMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       public SalaryVoucherMasterInfo SalaryVoucherMasterView(decimal salaryVoucherMasterId)
       {
           SalaryVoucherMasterInfo InfoSalaryVoucherMaster = new SalaryVoucherMasterInfo();
           try
           {
               InfoSalaryVoucherMaster = SPSalaryVoucherMaster.SalaryVoucherMasterView(salaryVoucherMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return InfoSalaryVoucherMaster;
       }
       public decimal SalaryVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
       {
           decimal max = 0;
           try
           {
               max = SPSalaryVoucherMaster.SalaryVoucherMasterGetMaxPlusOne(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       public string SalaryVoucherMasterGetMax(decimal decVoucherTypeId)
       {
           string max = "0";
           try
           {
               max = SPSalaryVoucherMaster.SalaryVoucherMasterGetMax(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("CN01:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return max;
       }
       public bool MonthlySalaryVoucherCheckExistence(string voucherNo, decimal voucherTypeId, decimal masterId)
       {
           bool isResult = false;
           try
           {
               isResult = SPSalaryVoucherMaster.MonthlySalaryVoucherCheckExistence(voucherNo, voucherTypeId, masterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BR2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isResult;
       }
       public List<DataTable> MonthlySalaryVoucherMasterAddWithIdentity(SalaryVoucherMasterInfo salaryvouchermasterinfo, bool IsAutomatic)
       {
           List<DataTable> list = new List<DataTable>();
           try
           {
               SPSalaryVoucherMaster.MonthlySalaryVoucherMasterAddWithIdentity(salaryvouchermasterinfo, IsAutomatic);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
       public List<DataTable> MonthlySalaryRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, DateTime dtMonth, string strVoucherNo, string strLedgerName, string strVoucherTypeName)
       {
           List<DataTable> list = new List<DataTable>();
           try
           {
               SPSalaryVoucherMaster.MonthlySalaryRegisterSearch(dtdateFrom, dtdateTo, dtMonth, strVoucherNo, strLedgerName, strVoucherTypeName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
       public List<DataSet> PaySlipPrinting(decimal decEmployeeId, DateTime dsSalaryMonth, decimal decCompanyId)
       {
           List<DataSet> list = new List<DataSet>();
           try
           {
               list = SPSalaryVoucherMaster.PaySlipPrinting(decEmployeeId, dsSalaryMonth, decCompanyId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("BR6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return list;
       }
    }
}
