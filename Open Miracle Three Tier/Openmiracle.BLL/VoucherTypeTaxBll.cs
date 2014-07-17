using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.DAL;
namespace OpenMiracle.BLL
{
   public class VoucherTypeTaxBll
    {
       VoucherTypeTaxSP spVoucherTypeTax = new VoucherTypeTaxSP();
       /// <summary>
       /// Function to insert values to VoucherTypeTax Table
       /// </summary>
       /// <param name="vouchertypetaxinfo"></param>
       public void VoucherTypeTaxAdd(VoucherTypeTaxInfo vouchertypetaxinfo)
       {
           try
           {
               spVoucherTypeTax.VoucherTypeTaxAdd(vouchertypetaxinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
          
       }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="VoucherTypeId"></param>
       public void DeleteVoucherTypeTaxUsingVoucherTypeId(decimal VoucherTypeId)
       {
           try
           {
               spVoucherTypeTax.DeleteVoucherTypeTaxUsingVoucherTypeId(VoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("AL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
    }
}
