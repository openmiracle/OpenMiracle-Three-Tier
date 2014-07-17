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
    public class CreditNoteDetailsBll
    {
        CreditNoteDetailsInfo InfoCreditNoteDetails = new CreditNoteDetailsInfo();
        CreditNoteDetailsSP SpCreditNoteDetails = new CreditNoteDetailsSP();
        public decimal CreditNoteDetailsAdd(CreditNoteDetailsInfo creditnotedetailsinfo)
        {
            decimal decId = 0;
            try
            {
                decId = SpCreditNoteDetails.CreditNoteDetailsAdd(creditnotedetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CNDB:1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public void CreditNoteDetailsDelete(decimal CreditNoteMasterId)
        {
            try
            {
                SpCreditNoteDetails.CreditNoteDetailsDelete(CreditNoteMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CNDB:2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal CreditNoteDetailsEdit(CreditNoteDetailsInfo creditnotedetailsinfo)
        {
            decimal decId = 0;
            try
            {
                decId = SpCreditNoteDetails.CreditNoteDetailsEdit(creditnotedetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CNDB:3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public List<DataTable> CreditNoteDetailsViewByMasterId(decimal decMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj[0] = SpCreditNoteDetails.CreditNoteDetailsViewByMasterId(decMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
    }

}
