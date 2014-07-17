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
   public class CounterBll
    {
       CounterInfo infoCounter = new CounterInfo();
       CounterSP spCounter = new CounterSP();
        public List<DataTable> CounterOnlyViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spCounter.CounterOnlyViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public bool CounterCheckIfExist(String strCounterName, decimal strCounterId)
        {
            bool isStatus = false;
            try
            {
               isStatus= spCounter.CounterCheckIfExist( strCounterName, strCounterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isStatus;
        }
        public decimal CounterAddWithIdentity(CounterInfo CounterInfo)
        {
            decimal decLedgerId = 0;
            try
            {
                decLedgerId = spCounter.CounterAddWithIdentity(CounterInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decLedgerId;
        }
        public bool CounterEditParticularField(CounterInfo counterinfo)
        {
            bool isEdit = false;
            try
            {
                isEdit = spCounter.CounterEditParticularField(counterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public decimal CounterCheckReferenceAndDelete(decimal decCounterId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spCounter.CounterCheckReferenceAndDelete(decCounterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decCounterId;
        }
        public void CounterDelete(decimal CounterId)
        {
            try
            {
                spCounter.CounterDelete(CounterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBLL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public CounterInfo CounterWithNarrationView(decimal decCounterId)
        {
            CounterInfo counterinfo = new CounterInfo();
            try
            {
                counterinfo = spCounter.CounterWithNarrationView(decCounterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return counterinfo;
        }

    }
}
