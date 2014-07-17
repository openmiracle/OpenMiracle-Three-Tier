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
   public class HolydaySettingsBll
   {
       HolidaySP spHoliday = new HolidaySP();
 public List<DataTable> HoildaySettingsViewAllLimited(string strMonth, string strYear)
        {
            
           
            try
            {
                return spHoliday.HoildaySettingsViewAllLimited(strMonth, strYear);
            }
            catch (Exception)
            {

                throw;
            }
        }
       public void HolidaySettingsDeleteByMonth(string strMonth, string strYear)
        {
           
           
            try
            {
                spHoliday.HolidaySettingsDeleteByMonth(strMonth, strYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
       public bool HolidayAddWithIdentity(HolidayInfo holidayinfo)
        {
            bool isStatus = false;
            try
            {
                isStatus = spHoliday.HolidayAddWithIdentity(holidayinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isStatus;
        }
       public decimal HolliDayChecking(DateTime date)
        {
      
            decimal decResult = 0;
            try
            {
                decResult = spHoliday.HolliDayChecking(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
    }
}
