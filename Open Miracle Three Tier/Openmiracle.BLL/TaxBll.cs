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
    public class TaxBll
    {
        TaxDetailsSP spTaxDetails = new TaxDetailsSP();
        TaxSP spTax = new TaxSP();
        public void TaxDetailsAdd(TaxDetailsInfo infoTaxDetails)
        {
            try
            {
                spTaxDetails.TaxDetailsAdd(infoTaxDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in TaxDetails Table
        /// </summary>
        /// <param name="taxdetailsinfo"></param>
        public void TaxDetailsEdit(TaxDetailsInfo infoTaxDetails)
        {
            try
            {
                spTaxDetails.TaxDetailsEdit(infoTaxDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        /// <summary>
        /// Function to get all the values from TaxDetails Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxDetailsViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTaxDetails.TaxDetailsViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from TaxDetails Table based on the parameter
        /// </summary>
        /// <param name="taxdetailsId"></param>
        /// <returns></returns>
        public TaxDetailsInfo TaxDetailsView(decimal decTaxDetailsId)
        {
            TaxDetailsInfo infoTaxDetails = new TaxDetailsInfo();
            
            try
            {
                infoTaxDetails = spTaxDetails.TaxDetailsView(decTaxDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return infoTaxDetails;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="TaxdetailsId"></param>
        public void TaxDetailsDelete(decimal decTaxdetailsId)
        {
            try
            {
                spTaxDetails.TaxDetailsDelete(decTaxdetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        /// <summary>
        /// Function to  get the next id for TaxDetails Table
        /// </summary>
        /// <returns></returns>
        public int TaxDetailsGetMax()
        {
            int inMax = 0;
            try
            {
                inMax = spTaxDetails.TaxDetailsGetMax();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return inMax;
        }
        /// <summary>
        /// Function to insert values without id
        /// </summary>
        /// <param name="taxdetailsinfo"></param>
        public void TaxDetailsAddWithoutId(TaxDetailsInfo infoTaxdetails)
        {
            try
            {
                spTaxDetails.TaxDetailsAddWithoutId(infoTaxdetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        /// <summary>
        /// Function to delete Tax Details based on parameter
        /// </summary>
        /// <param name="TaxdetailsId"></param>
        public void TaxDetailsDeleteWithTaxId(decimal decTaxdetailsId)
        {
            try
            {
                spTaxDetails.TaxDetailsDeleteWithTaxId(decTaxdetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        /// <summary>
        /// Function to view tax Details based on Parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public List<DataTable> TaxDetailsViewallByTaxId(decimal decTaxId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTaxDetails.TaxDetailsViewallByTaxId(decTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to insert values to  Tax Table
        /// </summary>
        /// <param name="taxinfo"></param>
        public void TaxAdd(TaxInfo taxinfo)
        {
            try
            {
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Function to Update values in Tax Table
        /// </summary>
        /// <param name="taxinfo"></param>
        public void TaxEdit(TaxInfo taxinfo)
        {
            try
            {
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Function to get all the values from Tax Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from Tax Table based on the parameter
        /// </summary>
        /// <param name="taxId"></param>
        /// <returns></returns>
        public TaxInfo TaxView(decimal decTaxId)
        {
            TaxInfo infoTax = new TaxInfo();
            try
            {
                infoTax = spTax.TaxView(decTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return infoTax;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="TaxId"></param>
        public void TaxDelete(decimal decTaxId)
        {
            try
            {
                spTax.TaxDelete(decTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        /// <summary>
        /// Function to  get the next id for Tax Table
        /// </summary>
        /// <returns></returns>
        public int TaxGetMax()
        {
            int inMax = 0;
            try
            {
                inMax = spTax.TaxGetMax();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return inMax;
        }
        /// <summary>
        /// Function to check existence of tax based on parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <param name="strTaxName"></param>
        /// <returns></returns>
        public bool TaxCheckExistence(decimal decTaxId, string strTaxName)
        {
            bool isEdit = false;
            try
            {
                isEdit = spTax.TaxCheckExistence(decTaxId, strTaxName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             
            return isEdit;
        }
        /// <summary>
        /// Function for insert values and return id
        /// </summary>
        /// <param name="taxinfo"></param>
        /// <returns></returns>
        public decimal TaxAddWithIdentity(TaxInfo infoTax)
        {
            decimal decTaxId = 0;
            try
            {
                decTaxId = spTax.TaxAddWithIdentity(infoTax);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             
            return decTaxId;
        }
        /// <summary>
        /// Function to view Tax for Selection
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAllForTaxSelection()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAllForTaxSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function for tax search based on parameter
        /// </summary>
        /// <param name="strTaxName"></param>
        /// <param name="strApplicableOn"></param>
        /// <param name="strCalculatingMode"></param>
        /// <param name="strActive"></param>
        /// <returns></returns>
        public List<DataTable> TaxSearch(String strTaxName, String strApplicableOn, String strCalculatingMode, string strActive)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxSearch(strTaxName,strApplicableOn, strCalculatingMode, strActive);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function for Check refernce based on parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public bool TaxReferenceCheck(decimal decTaxId)
        {
            bool isExist = false;
            try
            {
                isExist = spTax.TaxReferenceCheck(decTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return isExist;
        }
        /// <summary>
        /// Function to view tax for voucherType
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAllForVoucherType()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAllForVoucherType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function to view TaxId For Tax Selection Update based on parameter
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public List<DataTable> TaxIdForTaxSelectionUpdate(decimal decTaxId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxIdForTaxSelectionUpdate(decTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function for Check reference and delete
        /// </summary>
        /// <param name="TaxId"></param>
        /// <param name="decLedgerId"></param>
        /// <returns></returns>
        public decimal TaxReferenceDelete(decimal TaxId, decimal decLedgerId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spTax.TaxReferenceDelete(TaxId, decLedgerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return decReturnValue;
        }
        /// <summary>
        /// Function to get Tax Rate By TaxId 
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public decimal TaxRateFindByTaxId(decimal decTaxId)
        {
            decimal dcRate = 0;
            try
            {
                dcRate = spTax.TaxRateFindByTaxId(decTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return dcRate;
        }
        /// <summary>
        /// Function for Tax View All By VoucherTypeId
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeId(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAllByVoucherTypeId(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function for Tax View All By VoucherTypeId For PurchaseInvoice
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeIdForPurchaseInvoice(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAllByVoucherTypeIdForPurchaseInvoice(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function for Tax View All By VoucherTypeId With Cess
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeIdWithCess(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAllByVoucherTypeIdWithCess(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return ListObj;
        }
        /// <summary>
        /// Function for view TaxId Corresponding To Cess TaxId
        /// </summary>
        /// <param name="decTaxId"></param>
        /// <returns></returns>
        public List<DataTable> TaxIdCorrespondingToCessTaxId(decimal decTaxId)
        {
            List<DataTable> Listobj = new List<DataTable>();
            try
            {
                Listobj = spTax.TaxIdCorrespondingToCessTaxId(decTaxId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return Listobj;
        }
        /// <summary>
        /// Function for  Tax ViewAll By VoucherTypeId
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strTaxApplicable"></param>
        /// <returns></returns>
        public List<DataTable>TaxViewAllByVoucherTypeId1(decimal decVoucherTypeId, string strTaxApplicable)
        {
            List<DataTable> Listobj = new List<DataTable>();
            try
            {
                Listobj = spTax.TaxViewAllByVoucherTypeId1(decVoucherTypeId, strTaxApplicable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return Listobj;
        }
        /// <summary>
        /// Function for Tax View By ProductId
        /// </summary>
        /// <param name="strProductCode"></param>
        /// <returns></returns>
        public TaxInfo TaxViewByProductId(string strProductCode)
        {
            TaxInfo infoTax= new TaxInfo();
            
            try
            {
                infoTax = spTax.TaxViewByProductId(strProductCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return infoTax;
        }
        /// <summary>
        /// Function for Tax ViewAll By VoucherTypeId Applicale For Product
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewAllByVoucherTypeIdApplicaleForProduct(decimal decVoucherTypeId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAllByVoucherTypeIdApplicaleForProduct(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return ListObj;
        }
        /// <summary>
        /// Function for Tax View By ProductId Applicable For Product
        /// </summary>
        /// <param name="dcProductId"></param>
        /// <returns></returns>
        public List<DataTable> TaxViewByProductIdApplicableForProduct(decimal dcProductId)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewByProductIdApplicableForProduct(dcProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ListObj;
        }
        /// <summary>
        /// Function for TotalBill Tax Calculation Based on applicable On
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TotalBillTaxCalculationBtapplicableOn()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TotalBillTaxCalculationBtapplicableOn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return ListObj;
        }
        /// <summary>
        /// Function to view tax for Product
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TaxViewAllForProduct()
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxViewAllForProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return ListObj;
        }
        /// <summary>
        /// Function to view all tax details for Tax Report By Productwise based on parameter
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public List<DataTable> TaxReportGridFillByProductwise(DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, string strTypeofVoucher, bool isInput)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxReportGridFillByProductwise(fromdate, todate, dectaxId, decvoucherTypeId, strTypeofVoucher, isInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return ListObj;
        }
        /// <summary>
        /// Function to view all tax details for Tax Report By Productwise based on parameter
        /// </summary>
        /// <param name="deccompanyId"></param>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public DataSet TaxCrystalReportGridFillByProductwise(decimal deccompanyId, DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, bool isInput)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spTax.TaxCrystalReportGridFillByProductwise(deccompanyId, fromdate, todate, dectaxId, decvoucherTypeId, isInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return ds;
        }
        /// <summary>
        /// Function to view all tax details for Report by bill wise based on parameter
        /// </summary>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public List<DataTable> TaxReportGridFillByBillWise(DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, string strTypeofVoucher, bool isInput)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spTax.TaxReportGridFillByBillWise(fromdate, todate, dectaxId, decvoucherTypeId, strTypeofVoucher, isInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            return ListObj;
        }
        /// <summary>
        /// Function for view Tax values for report by bill wise based on parameter
        /// </summary>
        /// <param name="deccompanyId"></param>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <param name="dectaxId"></param>
        /// <param name="decvoucherTypeId"></param>
        /// <param name="isInput"></param>
        /// <returns></returns>
        public DataSet TaxCrystalReportGridFillByBillWise(decimal deccompanyId, DateTime fromdate, DateTime todate, decimal dectaxId, decimal decvoucherTypeId, bool isInput)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = spTax.TaxCrystalReportGridFillByBillWise(deccompanyId, fromdate, todate, dectaxId, decvoucherTypeId, isInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TBLL19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return ds;
        }

    }
}
