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
   public class MastersBll
   {
       MasterSP spMaster = new MasterSP();
       public List<DataTable> DotMatrxPrinterFormatComboFillForVoucherType()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spMaster.DotMatrxPrinterFormatComboFillForVoucherType();
           }
           catch (Exception ex)
           {
               MessageBox.Show("CVBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
    }
}
