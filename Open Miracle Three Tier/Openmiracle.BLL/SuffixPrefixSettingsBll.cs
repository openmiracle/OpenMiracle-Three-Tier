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
    public class SuffixPrefixSettingsBll
    {
        SuffixPrefixSP spSuffixPrefix = new SuffixPrefixSP();
        public SuffixPrefixInfo GetSuffixPrefixDetails(decimal vouchertypeId, DateTime date)
        {
            

            SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo(); 
            try
            {
                infoSuffixPrefix = spSuffixPrefix.GetSuffixPrefixDetails(vouchertypeId, date);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoSuffixPrefix;
        }
        public List<DataTable> VoucherTypeViewAllInSuffixPrefix()
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spSuffixPrefix.VoucherTypeViewAllInSuffixPrefix();
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public List<DataTable> VoucherTypeSearchInSuffixPrefix(String strVoucherTypeName)
        {
            List<DataTable> listobj = new List<DataTable>();
            try
            {
                listobj = spSuffixPrefix.VoucherTypeSearchInSuffixPrefix(strVoucherTypeName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BD7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listobj;
        }
        public bool SuffixPrefixCheckExistenceForAdd(String strfromDate, String strtoDate, decimal decvoucherTypeId, decimal decsuffixprefixId)
        {
            bool isEdit = false;
            try
            {

                isEdit = spSuffixPrefix.SuffixPrefixCheckExistenceForAdd(strfromDate, strtoDate, decsuffixprefixId, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        public bool SuffixPrefixAddWithId(SuffixPrefixInfo Infosuffixprefix)
        {
            bool isEdit = false;
            try
            {

                isEdit = spSuffixPrefix.SuffixPrefixAddWithId(Infosuffixprefix);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isEdit;
        }
        public bool SuffixPrefixSettingsEdit(SuffixPrefixInfo Infosuffixprefix)
        {
            bool isEdit = false;
            try
            {

                isEdit = spSuffixPrefix.SuffixPrefixSettingsEdit(Infosuffixprefix);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return isEdit;
        }
        public decimal SuffixPrefixSettingsDeleting(decimal SuffixprefixId)
        {
            decimal decReturnValue = 0;
            try
            {

                decReturnValue = spSuffixPrefix.SuffixPrefixSettingsDeleting(SuffixprefixId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        public SuffixPrefixInfo SuffixPrefixView(decimal suffixprefixId)
        {
            SuffixPrefixInfo infoSuffixPrefix = new SuffixPrefixInfo(); 
            try
            {
                infoSuffixPrefix = spSuffixPrefix.SuffixPrefixView(suffixprefixId);
            }
            catch (Exception ex)
            {

                MessageBox.Show("BD4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoSuffixPrefix;
        }
    }
}
