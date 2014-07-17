using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
    public class PurchaseBillTaxBll
    {
        PurchaseBillTaxSP spPurchaseBillTax = new PurchaseBillTaxSP();
        PurchaseBillTaxInfo infoPurchaseBillTax = new PurchaseBillTaxInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decPurchaseMasterId"></param>
        /// <returns></returns>
        public PurchaseBillTaxInfo PurchaseBillTaxViewAllByPurchaseMasterId(decimal decPurchaseMasterId)
        {
            
            try
            {
               spPurchaseBillTax.PurchaseBillTaxView(decPurchaseMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PB1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return infoPurchaseBillTax;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infoPurchaseBillTax"></param>
        public void PurchaseBillTaxAdd(PurchaseBillTaxInfo infoPurchaseBillTax)
        {
            try
            {
                spPurchaseBillTax.PurchaseBillTaxAdd(infoPurchaseBillTax);
            }

            catch (Exception ex)
            {
                MessageBox.Show("SB2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infoPurchaseBillTax"></param>
        public void PurchaseBillTaxEdit(PurchaseBillTaxInfo infoPurchaseBillTax)
        {
            try
            {
                spPurchaseBillTax.PurchaseBillTaxEdit(infoPurchaseBillTax);
            }

            catch (Exception ex)
            {
                MessageBox.Show("SB3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="decPurchaseBillTaxId"></param>
        public void PurchaseBillTaxDelete(decimal decPurchaseBillTaxId)
        {
            try
            {
                spPurchaseBillTax.PurchaseBillTaxDelete(decPurchaseBillTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SB4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
