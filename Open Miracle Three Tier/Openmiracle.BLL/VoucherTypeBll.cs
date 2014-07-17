using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ENTITY;
using OpenMiracle.DAL;

namespace OpenMiracle.BLL
{
   public class VoucherTypeBll
    {
       VoucherTypeSP spVoucherType = new VoucherTypeSP();
       /// <summary>
       /// Function to get Vouchertype for combofill
       /// </summary>
       /// <param name="cmbVoucherType"></param>
       /// <param name="isAll"></param>
       public void voucherTypeComboFill(ComboBox cmbVoucherType, bool isAll)
       {
           try
           {
               spVoucherType.voucherTypeComboFill(cmbVoucherType, isAll);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }           
       }
       /// <summary>
       /// Function to get values for search based on parameters
       /// </summary>
       /// <param name="fromDate"></param>
       /// <param name="toDate"></param>
       /// <param name="decVoucherTypeId"></param>
       /// <param name="strVoucherNo"></param>
       /// <param name="decLedgerId"></param>
       /// <param name="decEmployeeId"></param>
       /// <returns></returns>
       public List<DataTable> VoucherSearchFill(DateTime fromDate, DateTime toDate, decimal decVoucherTypeId, string strVoucherNo, decimal decLedgerId, decimal decEmployeeId)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spVoucherType.VoucherSearchFill(fromDate, toDate, decVoucherTypeId, strVoucherNo, decLedgerId, decEmployeeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// Function to Get Type Of Voucher From VoucherType
       /// </summary>
       /// <param name="strvoucherTypeName"></param>
       /// <returns></returns>
       public string TypeOfVoucherView(string strvoucherTypeName)
       {
           string StrTypeOfVoucher = string.Empty;
           try
           {
               StrTypeOfVoucher = spVoucherType.TypeOfVoucherView(strvoucherTypeName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return StrTypeOfVoucher;
       }
       /// <summary>
       /// Function to get all vouchers based on parameters
       /// </summary>
       /// <param name="strVoucherType"></param>
       /// <returns></returns>
       public List<DataTable> cVoucherTypeSelectionComboFill(string strVoucherType)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spVoucherType.VoucherTypeSelectionComboFill(strVoucherType);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// Function to view type of voucher based on parameter
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public VoucherTypeInfo TypeOfVoucherBasedOnVoucherTypeId(decimal decVoucherTypeId)
       {          
           VoucherTypeInfo infoVoucherType = new VoucherTypeInfo();
           try
           {
               infoVoucherType = spVoucherType.TypeOfVoucherBasedOnVoucherTypeId(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return infoVoucherType;
       }
       /// <summary>
       /// Function to check method fo voucher numbering based on parameter
       /// </summary>
       /// <param name="voucherTypeId"></param>
       /// <returns></returns>
       public bool CheckMethodOfVoucherNumbering(decimal voucherTypeId)
       {          
           bool isAutomatic = false;
           try
           {
               isAutomatic = spVoucherType.CheckMethodOfVoucherNumbering(voucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isAutomatic;
       }
       /// <summary>
       /// Function to view all VoucherTypes based on parameter
       /// </summary>
       /// <param name="voucherTypeId"></param>
       /// <returns></returns>
       public VoucherTypeInfo VoucherTypeView(decimal voucherTypeId)
       {
           VoucherTypeInfo vouchertypeinfo = new VoucherTypeInfo();
           try
           {
               vouchertypeinfo = spVoucherType.VoucherTypeView(voucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return vouchertypeinfo;
       }
       /// <summary>
       /// Function to get Declaration And Heading based on parameter
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public DataTable  DeclarationAndHeadingGetByVoucherTypeId(decimal decVoucherTypeId)
       {
           DataTable dtbl = new DataTable();
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spVoucherType.DeclarationAndHeadingGetByVoucherTypeId(decVoucherTypeId);
               dtbl = listObj[0];
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return dtbl;
       }
       /// <summary>
       /// Function to get id for PrinterSettings based on parameter
       /// </summary>
       /// <param name="inMasterId"></param>
       /// <returns></returns>
       public int FormIdGetForPrinterSettings(int inMasterId)
       {
           int frmId = 0;
           try
           {
               frmId = spVoucherType.FormIdGetForPrinterSettings(inMasterId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return frmId;
       }
       /// <summary>
       /// Function to get VoucherTypename for combofill in Tax And vat report
       /// </summary>
       /// <returns></returns>
       public List<DataTable> VoucherTypeCombofillForTaxAndVat(string strVoucherType)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spVoucherType.VoucherTypeCombofillForTaxAndVat(strVoucherType);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// Function to check existence of Voucher based on parameters
       /// </summary>
       /// <param name="strvoucherTypeName"></param>
       /// <param name="decvoucherTypeId"></param>
       /// <returns></returns>
       public bool VoucherTypeCheckExistence(string strvoucherTypeName, decimal decvoucherTypeId)
       {
           bool isExists = true;
           try
           {
               isExists = spVoucherType.VoucherTypeCheckExistence(strvoucherTypeName, decvoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT11:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExists;
       }
       /// <summary>
       /// Function to get Type of Vouchers for combofill in tax report and vat report
       /// </summary>
       /// <returns></returns>
       public List<DataTable> TypeOfVoucherCombofillForVatAndTaxReport()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spVoucherType.TypeOfVoucherCombofillForVatAndTaxReport();
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT12:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       ///Function to get all the values from VoucherType Table
       /// </summary>
       /// <returns></returns>
       public List<DataTable> VoucherTypeViewAll()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spVoucherType.VoucherTypeViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT13:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       /// <summary>
       /// Function to insert values to table and return id 
       /// </summary>
       /// <param name="vouchertypeinfo"></param>
       /// <returns></returns>
       public decimal VoucherTypeAddWithIdentity(VoucherTypeInfo vouchertypeinfo)
       {
           decimal decVoucherTypeId = 0;
           try
           {
               decVoucherTypeId = spVoucherType.VoucherTypeAddWithIdentity(vouchertypeinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT14:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decVoucherTypeId;
       }
       /// <summary>
       /// Function to check reference based on parameter
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public bool VoucherTypeChechReferences(decimal decVoucherTypeId)
       {
           bool isActive = true;
           try
           {
               isActive = spVoucherType.VoucherTypeChechReferences(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT15:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isActive;
       }
       /// <summary>
       /// Function to  Check For Default VoucherType based on parameter
       /// </summary>
       /// <param name="decVoucherTypeId"></param>
       /// <returns></returns>
       public bool CheckForDefaultVoucherType(decimal decVoucherTypeId)
       {
           bool isDefault = true;
           try
           {
               isDefault = spVoucherType.CheckForDefaultVoucherType(decVoucherTypeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT16:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isDefault;
       }
  
        /// <summary>
        /// Function to Update values in VoucherType Table
        /// </summary>
        /// <param name="vouchertypeinfo"></param>
        public void VoucherTypeEdit(VoucherTypeInfo vouchertypeinfo)
        {
           try
           {
              spVoucherType.VoucherTypeEdit(vouchertypeinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("VT17:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }         
       }
        /// <summary>
        /// Function for update VoucherType For Default Vouchers
        /// </summary>
        /// <param name="vouchertypeinfo"></param>
        public void VoucherTypeEditForDefaultVouchers(VoucherTypeInfo vouchertypeinfo)
        {
            try
            {
                spVoucherType.VoucherTypeEditForDefaultVouchers(vouchertypeinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT18:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get all details based on parameter for Search
        /// </summary>
        /// <param name="strVoucherName"></param>
        /// <param name="strTypeOfvoucher"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypeSearch(string strVoucherName, string strTypeOfvoucher)
        {
            List<DataTable> listObjSearch = new List<DataTable>();
            try
            {
                listObjSearch = spVoucherType.VoucherTypeSearch(strVoucherName, strTypeOfvoucher);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT19:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObjSearch;
        }
        /// <summary>
        /// Function for VoucherType combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> TypeOfVoucherComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.TypeOfVoucherComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT20:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="VoucherTypeId"></param>
        public void VoucherTypeDelete(decimal VoucherTypeId)
        {
            try
            {
                spVoucherType.VoucherTypeDelete(VoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT21:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
        /// <summary>
        /// Function to get tax id for tax selection based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> GetTaxIdForTaxSelection(decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.GetTaxIdForTaxSelection(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT22:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to view VoucherType For AgainstBill Details
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeViewAllForAgainstBillDetails()
        {
            List<DataTable> listObj = new List<DataTable>();          
            try
            {
                listObj = spVoucherType.VoucherTypeViewAllForAgainstBillDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT23:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to view all VoucherTypeName For ComboFill based on parameter
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypeNameViewAllForComboFill(decimal decVoucherTypeId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.VoucherTypeNameViewAllForComboFill(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT24:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function for VoucherTypename combofill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherTypeNameComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.VoucherTypeNameComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT25:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to view VoucherTypes for combobfill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VoucherWiseProductSearchCombofill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.VoucherWiseProductSearchCombofill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT26:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get all vouchers based on parameters
        /// </summary>
        /// <param name="strVoucherType"></param>
        /// <returns></returns>
        public List<DataTable> VoucherTypeSelectionComboFill(string strVoucherType)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.VoucherTypeSelectionComboFill(strVoucherType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT27:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get all details based on parameters for search
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="voucherName"></param>
        /// <param name="format"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        public List<DataTable> VatGridFill(DateTime fromDate, DateTime toDate, string voucherName, decimal decVoucherTypeId, string format, string tax)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.VatGridFill(fromDate, toDate, voucherName, decVoucherTypeId, format, tax);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT28:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to view Taxnames
        /// </summary>
        /// <returns></returns>
        public List<DataTable> VatViewTaxNames()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spVoucherType.VatViewTaxNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT29:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get sum of quantity for vochers based on parameter
        /// </summary>
        /// <param name="dSalesId"></param>
        /// <returns></returns>
        public string VoucherreportsumQty(decimal dSalesId, string strVoucherType)
        {
            string qty = string.Empty;
            try
            {
                qty = spVoucherType.VoucherreportsumQty(dSalesId, strVoucherType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("VT30:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return qty;
        }

    }
}
