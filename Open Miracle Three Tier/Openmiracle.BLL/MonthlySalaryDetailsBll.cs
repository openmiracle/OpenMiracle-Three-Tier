using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.DAL;


namespace Openmiracle.BLL
{
    public class MonthlySalaryDetailsBll
    {
        MonthlySalaryDetailsInfo InfoMonthlySalaryDetails = new MonthlySalaryDetailsInfo();
        MonthlySalaryDetailsSP SpMonthlySalaryDetails = new MonthlySalaryDetailsSP();
        public void MonthlySalaryDetailsAddWithMonthlySalaryId(MonthlySalaryDetailsInfo InfoMonthlySalaryDetails)
        {
            try
            {
                SpMonthlySalaryDetails.MonthlySalaryDetailsAddWithMonthlySalaryId(InfoMonthlySalaryDetails);
            }

            catch (Exception ex)
            {
                MessageBox.Show("MSS1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("MSS2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("MSS3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
    }
}
