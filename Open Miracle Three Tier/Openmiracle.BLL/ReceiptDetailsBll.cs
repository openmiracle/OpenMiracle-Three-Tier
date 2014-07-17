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
   public class ReceiptDetailsBll
    {
       ReceiptDetailsInfo infoReceiptDetails = new ReceiptDetailsInfo();
       ReceiptDetailsSP spReceiptDetails = new ReceiptDetailsSP();
      public decimal ReceiptDetailsAdd(ReceiptDetailsInfo receiptdetailsinfo)
      {
          decimal decResult = 0;
        try
        {
            decResult = spReceiptDetails.ReceiptDetailsAdd(receiptdetailsinfo);
        }
        catch (Exception)
        {

            throw;
        }
        return decResult;
       }
      public void ReceiptDetailsDelete(decimal ReceiptDetailsId)
      {
        try
        {
         spReceiptDetails.ReceiptDetailsDelete(ReceiptDetailsId);
        }
        catch (Exception)
        {

            throw;
        }
       }
       
    }
}
