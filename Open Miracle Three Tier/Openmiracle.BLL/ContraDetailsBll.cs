using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
    public class ContraDetailsBll
    {
        ContraDetailsInfo InfoContraDetails = new ContraDetailsInfo();
        ContraDetailsSP SpContraDetails = new ContraDetailsSP();
        public decimal ContraDetailsAdd(ContraDetailsInfo InfoContraDetails)
        {
            decimal decId = 0;
            try
            {
                decId = SpContraDetails.ContraDetailsAdd(InfoContraDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CV:1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public void ContraDetailsEdit(ContraDetailsInfo InfoContraDetails)
        {
            try
            {
                SpContraDetails.ContraDetailsEdit(InfoContraDetails);
            }
            catch (Exception)
            {
            }
        }
        public decimal ContraDetailsAddReturnWithhIdentity(ContraDetailsInfo contradetailsinfo)
        {
            decimal decId = 0;
            try
            {
                decId = SpContraDetails.ContraDetailsAddReturnWithhIdentity(InfoContraDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CV:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
        public void ContraDetailsDelete(decimal ContraDetailsId)
        {
            try
            {
                SpContraDetails.ContraDetailsDelete(ContraDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CV:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ContraVoucherDelete(decimal ContraDetailsId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
                SpContraDetails.ContraVoucherDelete(ContraDetailsId, decVoucherTypeId, strVoucherNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CV:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
