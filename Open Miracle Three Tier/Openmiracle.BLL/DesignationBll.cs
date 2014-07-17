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
   public class DesignationBll
    {
       DesignationSP spDesignation = new DesignationSP();
       public List<DataTable> DesignationViewAll()
        {
           
            try
            {
                return spDesignation.DesignationViewAll();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
       public bool DesignationDelete(decimal DesignationId)
        {
           
            bool isResult = false;
            try
            {
                isResult = spDesignation.DesignationDelete(DesignationId); 
            }
            catch (Exception)
            {
                throw;
            }
            return isResult;
        }
       public List<DataTable> DesignationViewForGridFill()
        {
           
            try
            {
                return spDesignation.DesignationViewForGridFill();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable DesignationSearch(string strDesignation)
        {
            try
            {
                return spDesignation.DesignationSearch(strDesignation);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public DesignationInfo DesignationView(decimal designationId)
        {
          
            try
            {
                return spDesignation.DesignationView(designationId);
            }
            catch (Exception)
            {

                throw;
            }
        }
       public bool DesignationCheckExistanceOfName(string strDesignation, decimal decDesignationId)
        {
          
            bool isResult = false;
            try
            {
                isResult = spDesignation.DesignationCheckExistanceOfName(strDesignation, decDesignationId);
            }
            catch (Exception)
            {
                throw;
            }
            return isResult;
        }
       public decimal DesignationAddWithReturnIdentity(DesignationInfo designationinfo)
        {
            
            decimal decId = 0;
            try
            {
                decId = spDesignation.DesignationAddWithReturnIdentity(designationinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BR1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return decId;
        }
       public bool DesignationEdit(DesignationInfo designationinfo)
       {
           bool isStatus = false;
           try
           {
               isStatus = spDesignation.DesignationEdit(designationinfo);
           }
           catch (Exception)
           {
           }
           return isStatus;
       }
    }
}
