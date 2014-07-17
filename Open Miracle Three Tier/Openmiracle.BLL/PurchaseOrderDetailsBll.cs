using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
    public class PurchaseOrderDetailsBll
    {
        PurchaseDetailsSP spPurchaseDetails = new PurchaseDetailsSP();
        PurchaseDetailsInfo infoPurchaseDetails = new PurchaseDetailsInfo();
        public void PurchaseOrderDetailsViewWithRemaining(PurchaseDetailsInfo infoPurchaseDetails)
        {
           // decimal decId = 0;
            try
            {
               spPurchaseDetails.PurchaseDetailsAdd(infoPurchaseDetails);
            }

            catch (Exception ex)
            {
                MessageBox.Show("SB1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //return decId;
        }

    }
}
