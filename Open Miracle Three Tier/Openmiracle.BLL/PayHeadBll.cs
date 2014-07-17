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
    public class PayHeadBll
    {
        PayHeadInfo InfoPayHead = new PayHeadInfo();
        PayHeadSP SPPayHead = new PayHeadSP();

        public List<DataTable> PayHeadViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPayHead.PayHeadViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public List<DataTable> PayHeadViewAllForPayHeadReport(string strPayHeadName, string strType)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPayHead.PayHeadViewAllForPayHeadReport(strPayHeadName, strType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public bool PayheadCheckExistence(string PaheadName, decimal PayHeadId)
        {
            bool isResult = false;
            try
            {
                isResult = SPPayHead.PayheadCheckExistence(PaheadName, PayHeadId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public void PayHeadAdd(PayHeadInfo payheadinfo)
        {
            try
            {
                SPPayHead.PayHeadAdd(payheadinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PayHeadEdit(PayHeadInfo payheadinfo)
        {
            try
            {
                SPPayHead.PayHeadEdit(payheadinfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<DataTable> PayHeadSearch(string a) 
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = SPPayHead.PayHeadSearch(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PBBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        public bool PayHeadDeleteVoucherTypeCheckReference(decimal PayHeadId)
        {
            bool isResult = false;
            try
            {
                isResult = SPPayHead.PayHeadDeleteVoucherTypeCheckReference(PayHeadId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
        public PayHeadInfo PayHeadView(decimal payHeadId)
        {
            try
            {
                InfoPayHead = SPPayHead.PayHeadView(payHeadId);
            }

            catch (Exception ex)
            {
                MessageBox.Show("CB:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return InfoPayHead;
        }
        public bool payheadTypeCheckeferences(decimal PayHeadId, string PayHeadName, string Type, string Narration) 
        {
            bool isResult = false;
            try
            {
                isResult = SPPayHead.payheadTypeCheckeferences(PayHeadId, PayHeadName, Type, Narration);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CB:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isResult;
        }
    }
}
