using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTITY;
using Openmiracle.BLL;
using Openmiracle.DAL;

namespace Openmiracle.BLL
{
   public class ReceiptMasterBll
    {
       ReceiptMasterInfo infoReceiptMaster = new ReceiptMasterInfo();
       ReceiptMasterSP spReceiptMaster = new ReceiptMasterSP();
       public void ReceiptVoucherDelete(decimal decReceiptMasterId, decimal decVoucherTypeId, string strVoucherNo)
        {
            try
            {
               spReceiptMaster.ReceiptVoucherDelete(decReceiptMasterId,decVoucherTypeId,strVoucherNo);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
      public decimal ReceiptMasterGetMax(decimal decVoucherTypeId)
      {
          decimal decResult = 0;
        try
        {
            decResult = spReceiptMaster.ReceiptMasterGetMax(decVoucherTypeId);
        }
        catch (Exception)
        {

            throw;
        }
        return decResult;
       }
      public decimal ReceiptMasterAdd(ReceiptMasterInfo receiptmasterinfo)
      {
          decimal decResult = 0;
        try
        {
            decResult = spReceiptMaster.ReceiptMasterAdd(receiptmasterinfo);
        }
        catch (Exception)
        {

            throw;
        }
        return decResult;
       }
      public decimal ReceiptMasterEdit(ReceiptMasterInfo receiptmasterinfo)
      {
          decimal decResult = 0;
        try
        {
            decResult = spReceiptMaster.ReceiptMasterEdit(receiptmasterinfo);
        }
        catch (Exception)
        {

            throw;
        }
        return decResult;
       }
      
    }
}
