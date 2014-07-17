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
   public class RouteBll
    {
       RouteSP spRoute = new RouteSP();

       /// <summary>
       /// Function to get all area
       /// </summary>
       /// <returns></returns>
       public List<DataTable> AreafillInRoute()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spRoute.AreafillInRoute();
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT1:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Function to insert values to Route Table
       /// </summary>
       /// <param name="routeinfo"></param>
       public void RouteAdd(RouteInfo routeinfo)
       {
           try
           {
               spRoute.RouteAdd(routeinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT2:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       }
       /// <summary>
       /// Function to get all route
       /// </summary>
       /// <returns></returns>
       public List<DataTable> RouteViewForComboFill()
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spRoute.RouteViewForComboFill();
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT3:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Function to get route based on area
       /// </summary>
       /// <param name="decAreaId"></param>
       /// <returns></returns>
       public List<DataTable> RouteViewByArea(decimal decAreaId)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spRoute.RouteViewByArea(decAreaId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT4:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Function to get details based on parameters
       /// </summary>
       /// <param name="strRouteName"></param>
       /// <param name="strAreaName"></param>
       /// <returns></returns>
       public List<DataTable> RouteSearch(String strRouteName, String strAreaName)
       {
           List<DataTable> ListObj = new List<DataTable>();
           try
           {
               ListObj = spRoute.RouteSearch(strRouteName, strAreaName);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT5:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return ListObj;
       }
       /// <summary>
       /// Function to check existance of route
       /// </summary>
       /// <param name="strRouteName"></param>
       /// <param name="decRouteId"></param>
       /// <param name="decAreaId"></param>
       /// <returns></returns>
       public bool RouteCheckExistence(String strRouteName, decimal decRouteId, decimal decAreaId)
       {
           bool isExist = false;
           try
           {
               isExist = spRoute.RouteCheckExistence(strRouteName, decRouteId, decAreaId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT6:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isExist;
       }
       /// <summary>
       /// Function to Update values in Route Table
       /// </summary>
       /// <param name="routeinfo"></param>
       /// <returns></returns>
       public bool RouteEditing(RouteInfo routeinfo)
       {
           bool isEdit = false;
           try
           {
               isEdit = spRoute.RouteEditing(routeinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT7:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return isEdit;
       }
       /// <summary>
       /// Function to delete particular details based on the parameter
       /// </summary>
       /// <param name="RouteId"></param>
       /// <returns></returns>
       public decimal RouteDeleting(decimal RouteId)
       {
           decimal decId = 0;
           try
           {
               decId = spRoute.RouteDeleting(RouteId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT8:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decId;
       }
       /// <summary>
       /// Function to get particular values from Route table based on the parameter
       /// </summary>
       /// <param name="routeId"></param>
       /// <returns></returns>
       public RouteInfo RouteView(decimal routeId)
       {
           RouteInfo routeinfo = new RouteInfo();
           try
           {
               routeinfo = spRoute.RouteView(routeId);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT9:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return routeinfo;
       }
       /// <summary>
       /// Function to insert values to Route Table
       /// </summary>
       /// <param name="routeinfo"></param>
       /// <returns></returns>
       public decimal RouteAddParticularFields(RouteInfo routeinfo)
       {
           decimal decAreaId = 0;
           try
           {
               decAreaId = spRoute.RouteAddParticularFields(routeinfo);
           }
           catch (Exception ex)
           {
               MessageBox.Show("RT10:" + ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           return decAreaId;
       }
    }
}
