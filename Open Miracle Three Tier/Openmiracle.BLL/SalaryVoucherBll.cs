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
   public class SalaryVoucherBll
    {
        public List<DataTable> MonthlySalaryVoucherDetailsViewAll(string strMonth, string Month, string monthYear, bool isEditMode, string strVoucherNoforEdit)
        {
            SalaryVoucherDetailsSP SPSalaryVoucherDetails = new SalaryVoucherDetailsSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPSalaryVoucherDetails.MonthlySalaryVoucherDetailsViewAll(strMonth, Month, monthYear, isEditMode, strVoucherNoforEdit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;

        }

        public string CheckWhetherSalaryAlreadyPaid(decimal decEmployeeId, DateTime Month)
        {
            string strName = string.Empty;
            SalaryVoucherDetailsSP SPSalaryVoucherDetails = new SalaryVoucherDetailsSP();
            
            try
            {
                strName = SPSalaryVoucherDetails.CheckWhetherSalaryAlreadyPaid(decEmployeeId, Month);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return strName;
        }

        public void MonthlySalaryVoucherDetailsAdd(SalaryVoucherDetailsInfo salaryvoucherdetailsinfo)
        {
            SalaryVoucherDetailsSP SPSalaryVoucherDetails = new SalaryVoucherDetailsSP();
            
            try
            {
                SPSalaryVoucherDetails.MonthlySalaryVoucherDetailsAdd(salaryvoucherdetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        public int SalaryVoucherDetailsCount(decimal decMasterId)
        {
            int max = 0;
            SalaryVoucherDetailsSP SPSalaryVoucherDetails = new SalaryVoucherDetailsSP();
            
            try
            {
                max = SPSalaryVoucherDetails.SalaryVoucherDetailsCount(decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return max;
        }

        public void SalaryVoucherDetailsDeleteUsingMasterId(decimal SalaryVoucherDetailsMasterId)
        {
            SalaryVoucherDetailsSP SPSalaryVoucherDetails = new SalaryVoucherDetailsSP();

            try
            {
                SPSalaryVoucherDetails.SalaryVoucherDetailsDeleteUsingMasterId(SalaryVoucherDetailsMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void SalaryVoucherDetailsDelete(decimal SalaryVoucherDetailsId)
        {
            SalaryVoucherDetailsSP SPSalaryVoucherDetails = new SalaryVoucherDetailsSP();

            try
            {
                SPSalaryVoucherDetails.SalaryVoucherDetailsDelete(SalaryVoucherDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public List<DataTable> MonthlySalaryRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, DateTime dtMonth, string strVoucherNo, string strLedgerName, string strVoucherTypeName)
        {
            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPSalaryVoucherMaster.MonthlySalaryRegisterSearch(dtdateFrom, dtdateTo, dtMonth, strVoucherNo, strLedgerName, strVoucherTypeName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;

        }

        public DataSet PaySlipPrinting(decimal decEmployeeId, DateTime dsSalaryMonth, decimal decCompanyId)
        {
            DataSet dSt = new DataSet();
            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();

            try
            {
                dSt = SPSalaryVoucherMaster.PaySlipPrinting(decEmployeeId, dsSalaryMonth, decCompanyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return dSt;

        }

        public SalaryVoucherMasterInfo SalaryVoucherMasterView(decimal salaryVoucherMasterId)
        {
            SalaryVoucherMasterInfo salaryvouchermasterinfo = new SalaryVoucherMasterInfo();
       
            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();

            try
            {
                salaryvouchermasterinfo = SPSalaryVoucherMaster.SalaryVoucherMasterView(salaryVoucherMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return salaryvouchermasterinfo;

        }

        public bool MonthlySalaryVoucherCheckExistence(string voucherNo, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;

            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();

            try
            {
                trueOrfalse = SPSalaryVoucherMaster.MonthlySalaryVoucherCheckExistence(voucherNo, voucherTypeId, masterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return trueOrfalse;

        }

        public List<DataTable> MonthlySalaryVoucherMasterAddWithIdentity(SalaryVoucherMasterInfo salaryvouchermasterinfo, bool IsAutomatic)
        {
           
            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = SPSalaryVoucherMaster.MonthlySalaryVoucherMasterAddWithIdentity(salaryvouchermasterinfo, IsAutomatic);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;

        }
        public string SalaryVoucherMasterGetMax(decimal decVoucherTypeId)
        {
            string max = "0";

            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();

            try
            {
                max = SPSalaryVoucherMaster.SalaryVoucherMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }

        public void SalaryVoucherMasterEdit(SalaryVoucherMasterInfo salaryvouchermasterinfo)
        {
            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();

            try
            {
                SPSalaryVoucherMaster.SalaryVoucherMasterEdit(salaryvouchermasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void SalaryVoucherMasterDelete(decimal SalaryVoucherMasterId)
        {
            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();

            try
            {
                SPSalaryVoucherMaster.SalaryVoucherMasterDelete(SalaryVoucherMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public decimal SalaryVoucherMasterGetMaxPlusOne(decimal decVoucherTypeId)
        {
            decimal max = 0;
            SalaryVoucherMasterSP SPSalaryVoucherMaster = new SalaryVoucherMasterSP();

            try
            {
                max = SPSalaryVoucherMaster.SalaryVoucherMasterGetMaxPlusOne(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SvBll 15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return max;

        }



    }
    }

