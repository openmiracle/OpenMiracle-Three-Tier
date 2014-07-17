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
    public class HolidaySettingsBll
    {
        HolidaySP SPHoliday = new HolidaySP();
        public void HolidayAdd(HolidayInfo holidayinfo)
        {
            try
            {
                SPHoliday.HolidayAdd(holidayinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in Holiday Table
        /// </summary>
        /// <param name="holidayinfo"></param>
        public void HolidayEdit(HolidayInfo holidayinfo)
        {
            try
            {
                SPHoliday.HolidayEdit(holidayinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get all the values from Holiday Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> HolidayViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPHoliday.HolidayViewAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from Holiday table based on the parameter
        /// </summary>
        /// <param name="holidayId"></param>
        /// <returns></returns>
        public HolidayInfo HolidayView(decimal holidayId)
        {
            HolidayInfo holidayinfo = new HolidayInfo();
            try
            {
              holidayinfo=SPHoliday.HolidayView(holidayId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return holidayinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="HolidayId"></param>
        public void HolidayDelete(decimal HolidayId)
        {
            try
            {
                SPHoliday.HolidayDelete(HolidayId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to  get the next id for Holiday table
        /// </summary>
        /// <returns></returns>
        public int HolidayGetMax()
        {
            int max = 0;
            try
            {
                max = SPHoliday.HolidayGetMax();
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to view HoildaySettings based on parameters
        /// </summary>
        /// <param name="strMonth"></param>
        /// <param name="strYear"></param>
        /// <returns></returns>
        public List<DataTable> HoildaySettingsViewAllLimited(string strMonth, string strYear)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPHoliday.HoildaySettingsViewAllLimited(strMonth, strYear);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to insert values to Holiday table and return Id
        /// </summary>
        /// <param name="holidayinfo"></param>
        /// <returns></returns>
        public bool HolidayAddWithIdentity(HolidayInfo holidayinfo)
        {
            bool isSave = true;
            try
            {
                isSave = SPHoliday.HolidayAddWithIdentity(holidayinfo);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSave;
        }
        /// <summary>
        /// Function to delete HolidaySettings by month based on parameters
        /// </summary>
        /// <param name="strMonth"></param>
        /// <param name="strYear"></param>
        public void HolidaySettingsDeleteByMonth(string strMonth, string strYear)
        {
            try
            {
                SPHoliday.HolidaySettingsDeleteByMonth(strMonth, strYear);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to check Holidays based on parameter and return value
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public decimal HolliDayChecking(DateTime date)
        {
            decimal decResult = 0;
            try
            {
                decResult = SPHoliday.HolliDayChecking(date);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HSBll10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decResult;
        }
    }
}
