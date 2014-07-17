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
   public class DesiginationBll
    {
       DesignationInfo infoDesignation = new DesignationInfo();
       DesignationSP spDesignation = new DesignationSP();
       public List<DataTable> DesignationViewAll()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDesignation.DesignationViewAll();
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:1" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public bool DesignationDelete(decimal DesignationId)
       {
           bool isResult = false;
           try
           {
               isResult = spDesignation.DesignationDelete(DesignationId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:2" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isResult;
       }
       public List<DataTable> DesignationViewForGridFill()
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDesignation.DesignationViewForGridFill();
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:3" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public List<DataTable> DesignationSearch(string strDesignation)
       {
           List<DataTable> listObj = new List<DataTable>();
           try
           {
               listObj = spDesignation.DesignationSearch(strDesignation);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:4" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return listObj;
       }
       public DesignationInfo DesignationView(decimal designationId)
       {
           DesignationInfo designationinfo = new DesignationInfo();
           try
           {
               designationinfo = spDesignation.DesignationView(designationId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:5" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return designationinfo;
       }
       public bool DesignationCheckExistanceOfName(string strDesignation, decimal decDesignationId)
       {
           bool isResult = false; ;
           try
           {
               isResult = spDesignation.DesignationCheckExistanceOfName(strDesignation, decDesignationId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:6" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isResult;
       }
       public decimal DesignationAddWithReturnIdentity(DesignationInfo designationinfo)
       {
           decimal decIdentity = 0;
           try
           {
               decIdentity = spDesignation.DesignationAddWithReturnIdentity(designationinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:7" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decIdentity;
       }
       public bool DesignationEdit(DesignationInfo designationinfo)
       {
           bool isResult = false;
           try
           {
               isResult = spDesignation.DesignationEdit(designationinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("DBLL:8" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isResult;
       }
    }
}
