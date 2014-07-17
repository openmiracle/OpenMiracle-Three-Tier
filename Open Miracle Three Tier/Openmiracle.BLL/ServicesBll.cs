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
    public class ServicesBll
    {
        ServiceDetailsSP spServiceDetails = new ServiceDetailsSP();
        ServiceMasterSP spServiceMaster = new ServiceMasterSP();
        ServiceSP spService = new ServiceSP();
        /// <summary>
        /// Function to insert values to ServiceDetails Table and return corresponding row's id
        /// </summary>
        /// <param name="servicedetailsinfo"></param>
        /// <returns></returns>
        public decimal ServiceDetailsAddReturnWithIdentity(ServiceDetailsInfo servicedetailsinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spServiceDetails.ServiceDetailsAddReturnWithIdentity(servicedetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        ///  Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ServiceDetailsId"></param>
        public void ServiceDetailsDelete(decimal ServiceDetailsId)
        {
            try
            {
                spServiceDetails.ServiceDetailsDelete(ServiceDetailsId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to Update values in ServiceDetails Table
        /// </summary>
        /// <param name="servicedetailsinfo"></param>
        public void ServiceDetailsEdit(ServiceDetailsInfo servicedetailsinfo)
        {
            try
            {
                spServiceDetails.ServiceDetailsEdit(servicedetailsinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL34:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to get particular values from ServiceDetails Table based on the parameter
        /// </summary>
        /// <param name="decServiceMasterId"></param>
        /// <returns></returns>
        public List<DataTable> ServiceDetailsViewWithMasterId(decimal decServiceMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spServiceDetails.ServiceDetailsViewWithMasterId(decServiceMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to view details for search based on parameter
        /// </summary>
        /// <param name="dtdateFrom"></param>
        /// <param name="dtdateTo"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="strLedgerName"></param>
        /// <returns></returns>
        public List<DataTable> ServiceVoucherRegisterSearch(DateTime dtdateFrom, DateTime dtdateTo, string strVoucherNo, string strLedgerName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spServiceMaster.ServiceVoucherRegisterSearch(dtdateFrom, dtdateTo, strVoucherNo, strLedgerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to  get the next id for ServiceMaster Table
        /// </summary>
        /// <param name="decVoucherTypeId"></param>
        /// <returns></returns>
        public int ServiceMasterGetMax(decimal decVoucherTypeId)
        {
            int max = 0;
            try
            {
                max = spServiceMaster.ServiceMasterGetMax(decVoucherTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return max;
        }
        /// <summary>
        /// Function to view details for search in report based on parameter
        /// </summary>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <param name="strVoucherTypeName"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="strEmployeeName"></param>
        /// <returns></returns>
        public List<DataTable> ServiceReportSearch(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherTypeName, string strLedgerName, string strEmployeeName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spServiceMaster.ServiceReportSearch(dtDateFrom, dtDateTo, strVoucherTypeName, strLedgerName, strEmployeeName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to insert values to ServiceMaster Table and return corresponding row's id
        /// </summary>
        /// <param name="servicemasterinfo"></param>
        /// <returns></returns>
        public decimal ServiceMasterAddReturnWithIdentity(ServiceMasterInfo servicemasterinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spServiceMaster.ServiceMasterAddReturnWithIdentity(servicemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to get values for report based on parameter
        /// </summary>
        /// <param name="dtDateFrom"></param>
        /// <param name="dtDateTo"></param>
        /// <param name="strVoucherTypeName"></param>
        /// <param name="strLedgerName"></param>
        /// <param name="strEmployeeName"></param>
        /// <returns></returns>
        public List<DataTable> ServiceReport(DateTime dtDateFrom, DateTime dtDateTo, string strVoucherTypeName, string strLedgerName, string strEmployeeName)
        {
            List<DataTable> ListObj = new List<DataTable>();
            try
            {
                ListObj = spServiceMaster.ServiceReport(dtDateFrom, dtDateTo, strVoucherTypeName, strLedgerName, strEmployeeName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ListObj;
        }
        /// <summary>
        /// Function to check existence of service and return status based on parameter
        /// </summary>
        /// <param name="strInvoiceNo"></param>
        /// <param name="voucherTypeId"></param>
        /// <param name="masterId"></param>
        /// <returns></returns>
        public bool ServiceVoucherCheckExistence(string strInvoiceNo, decimal voucherTypeId, decimal masterId)
        {
            bool trueOrfalse = false;
            try
            {
                trueOrfalse = spServiceMaster.ServiceVoucherCheckExistence(strInvoiceNo, voucherTypeId, masterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return trueOrfalse;
        }
  /// <summary>
        /// Function to delete service based on parameter
        /// </summary>
        /// <param name="decPartyBalanceId"></param>
        /// <param name="decVoucherTypeId"></param>
        /// <param name="strVoucherNo"></param>
        /// <param name="decServiceMasterId"></param>
        public void ServiceVoucherDelete(decimal decPartyBalanceId, decimal decVoucherTypeId, string strVoucherNo, decimal decServiceMasterId)
        {
            try
            {
                spServiceMaster.ServiceVoucherDelete(decPartyBalanceId, decVoucherTypeId, strVoucherNo, decServiceMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }
        /// <summary>
        /// Function to get LedgerPosting id based on parameter
        /// </summary>
        /// <param name="decServiceMasterId"></param>
        /// <returns></returns>
        public List<DataTable> LedgerPostingIdByServiceMaasterId(decimal decServiceMasterId)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spServiceMaster.LedgerPostingIdByServiceMaasterId(decServiceMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }

        /// <summary>
        /// Function to Update values in ServiceMaster Table
        /// </summary>
        /// <param name="servicemasterinfo"></param>
        public void ServiceMasterEdit(ServiceMasterInfo servicemasterinfo)
        {
            try
            {
                spServiceMaster.ServiceMasterEdit(servicemasterinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Function to view details for Print based on parameter
        /// </summary>
        /// <param name="decserviceMasterId"></param>
        /// <param name="decCompanyId"></param>
        /// <param name="decExchangeRateId"></param>
        /// <returns></returns>
        public DataSet ServiceVoucherPrinting(decimal decserviceMasterId, decimal decCompanyId, decimal decExchangeRateId)
        {
            DataSet dSt = new DataSet();
            try
            {
                dSt = spServiceMaster.ServiceVoucherPrinting(decserviceMasterId,decCompanyId,decExchangeRateId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dSt;
        }
        /// <summary>
        ///  Function to get particular values from ServiceMaster Table based on the parameter
        /// </summary>
        /// <param name="serviceMasterId"></param>
        /// <returns></returns>
        public ServiceMasterInfo ServiceMasterView(decimal serviceMasterId)
        {
            ServiceMasterInfo servicemasterinfo = new ServiceMasterInfo();
            try
            {
                servicemasterinfo = spServiceMaster.ServiceMasterView(serviceMasterId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return servicemasterinfo;
        }
        /// <summary>
        /// Function to view all details for Gridfill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ServiceGridFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spService.ServiceGridFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to get all the values from Service Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ServiceViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spService.ServiceViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL33:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to check reference for delete
        /// </summary>
        /// <param name="ServiceId"></param>
        /// <returns></returns>
        public decimal ServiceDeleteReferenceCheck(decimal ServiceId)
        {
            decimal decReturnValue = 0;
            try
            {
                decReturnValue = spService.ServiceDeleteReferenceCheck(ServiceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decReturnValue;
        }
        /// <summary>
        /// Function to view all details for Search based on parameter
        /// </summary>
        /// <param name="strBrandName"></param>
        /// <param name="strCategoryname"></param>
        /// <returns></returns>
        public List<DataTable> ServiceSearch(string strBrandName, string strCategoryname)
        {
            List<DataTable> listObj = new List<DataTable>();
            try
            {
                listObj = spService.ServiceSearch(strBrandName, strCategoryname);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return listObj;
        }
        /// <summary>
        /// Function to check existence of Service based on parameters
        /// </summary>
        /// <param name="strServiceName"></param>
        /// <param name="decServiceId"></param>
        /// <returns></returns>
        public bool ServiceCheckExistence(string strServiceName, decimal decServiceId)
        {
            bool isEdit = false;
            try
            {
                isEdit = spService.ServiceCheckExistence(strServiceName, decServiceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Function to insert values to Service Table and return the Curresponding row's Id
        /// </summary>
        /// <param name="serviceinfo"></param>
        /// <returns></returns>
        public decimal ServiceAddWithReturnIdentity(ServiceInfo serviceinfo)
        {
            decimal decIdentity = 0;
            try
            {
                decIdentity = spService.ServiceAddWithReturnIdentity(serviceinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decIdentity;
        }
        /// <summary>
        /// Function to Update values in Service Table
        /// </summary>
        /// <param name="serviceinfo"></param>
        /// <returns></returns>
        public bool ServiceEdit(ServiceInfo serviceinfo)
        {
            bool isEdit = false;
            try
            {
                isEdit = spService.ServiceEdit(serviceinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isEdit;
        }
        /// <summary>
        /// Function to get particular values from Service Table based on the parameter
        /// </summary>
        /// <param name="serviceId"></param>
        /// <returns></returns>
        public ServiceInfo ServiceView(decimal serviceId)
        {
            ServiceInfo serviceinfo = new ServiceInfo();
            try
            {
                serviceinfo = spService.ServiceView(serviceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return serviceinfo;
        }
        /// <summary>
        /// Function to get particular values from Service Table based on the parameter
        /// </summary>
        /// <param name="serviceId"></param>
        /// <returns></returns>
        public ServiceInfo ServiceViewForRate(decimal serviceId)
        {
            ServiceInfo serviceinfo = new ServiceInfo();
            try
            {
                serviceinfo = spService.ServiceViewForRate(serviceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("AL35:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return serviceinfo;
        }




    }
}
