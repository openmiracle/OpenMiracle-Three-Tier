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
   public class PaymentDetailsBll
    {
       PaymentDetailsInfo infoPaymentDetails = new PaymentDetailsInfo();
       PaymentDetailsSP spPaymentDetails = new PaymentDetailsSP();
       /// <summary>
       /// 
       /// </summary>
       /// <param name="paymentdetailsinfo"></param>
       /// <returns></returns>
       public decimal PaymentDetailsAdd(PaymentDetailsInfo paymentdetailsinfo)
       {
           decimal decResult = 0;
           try
           {
               decResult = spPaymentDetails.PaymentDetailsAdd(paymentdetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PD1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decResult;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="PaymentDetailsId"></param>
       public void PaymentDetailsDelete(decimal PaymentDetailsId)
       {

           try
           {
               spPaymentDetails.PaymentDetailsDelete(PaymentDetailsId);
           }

           catch (Exception ex)
           {
               MessageBox.Show("PD2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="paymentdetailsinfo"></param>
       /// <returns></returns>
       public decimal PaymentDetailsEdit(PaymentDetailsInfo paymentdetailsinfo)
       {
           decimal decResult = 0;
           try
           {
               decResult = spPaymentDetails.PaymentDetailsEdit(paymentdetailsinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PD3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decResult;
       }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="paymentMastertId"></param>
       /// <returns></returns>
       public List<DataTable> PaymentDetailsViewByMasterId(decimal paymentMastertId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spPaymentDetails.PaymentDetailsViewByMasterId(paymentMastertId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("PD4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
    }
}
