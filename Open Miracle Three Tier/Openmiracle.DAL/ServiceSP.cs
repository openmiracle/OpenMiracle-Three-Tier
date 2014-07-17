//This is a source code or part of OpenMiracle project
//Copyright (C) 2013  Cybrosys Technologies Pvt.Ltd
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ENTITY;
//<summary>    
//Summary description for ServiceSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public  class ServiceSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to Service Table
        /// </summary>
        /// <param name="serviceinfo"></param>
        /// <returns></returns>
        public bool ServiceAdd(ServiceInfo serviceinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.ServiceName;
                sprmparam = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
                sprmparam.Value = serviceinfo.ServiceCategoryId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = serviceinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Extra2;
                int inEffectedRow = sccmd.ExecuteNonQuery();
                if (inEffectedRow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to Update values in Service Table
        /// </summary>
        /// <param name="serviceinfo"></param>
        /// <returns></returns>
        public bool ServiceEdit(ServiceInfo serviceinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = serviceinfo.ServiceId;
                sprmparam = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.ServiceName;
                sprmparam = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
                sprmparam.Value = serviceinfo.ServiceCategoryId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = serviceinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Extra2;
                int inEffectedRow = sccmd.ExecuteNonQuery();
                if (inEffectedRow > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to get all the values from Service Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ServiceViewAll()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to get particular values from Service Table based on the parameter
        /// </summary>
        /// <param name="serviceId"></param>
        /// <returns></returns>
        public ServiceInfo ServiceView(decimal serviceId)
        {
            ServiceInfo serviceinfo = new ServiceInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = serviceId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    serviceinfo.ServiceId = decimal.Parse(sdrreader[0].ToString());
                    serviceinfo.ServiceName = sdrreader["serviceName"].ToString();
                    serviceinfo.ServiceCategoryId = decimal.Parse(sdrreader["serviceCategoryId"].ToString());
                    serviceinfo.Rate = decimal.Parse(sdrreader["rate"].ToString());
                    serviceinfo.Narration = sdrreader["narration"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
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
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceViewForRate", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = serviceId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    serviceinfo.ServiceName = sdrreader["serviceName"].ToString();
                    serviceinfo.ServiceCategoryId = decimal.Parse(sdrreader["serviceCategoryId"].ToString());
                    serviceinfo.Rate = decimal.Parse(sdrreader["rate"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
            }
            return serviceinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ServiceId"></param>
        public void ServiceDelete(decimal ServiceId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = ServiceId;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to  get the next id for Service Table
        /// </summary>
        /// <returns></returns>
        public int ServiceGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = int.Parse(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return max;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCheckExistence", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
                sprmparam.Value = strServiceName;
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = decServiceId;
                object obj = sccmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 0)
                    {
                        isEdit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Function to view all details for Gridfill
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ServiceGridFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceGridFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObj;
        }
        /// <summary>
        /// Function to view all details for Search based on parameter
        /// </summary>
        /// <param name="strBrandName"></param>
        /// <param name="strCategoryname"></param>
        /// <returns></returns>
        public List<DataTable> ServiceSearch(string strBrandName, string strCategoryname)
        {
            EmployeeInfo infoEmployee = new EmployeeInfo();
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ServiceSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtbl.Columns.Add("SLNO", typeof(decimal));
                dtbl.Columns["SLNO"].AutoIncrement = true;
                dtbl.Columns["SLNO"].AutoIncrementSeed = 1;
                dtbl.Columns["SLNO"].AutoIncrementStep = 1;
                sqlda.SelectCommand.Parameters.Add("@serviceName", SqlDbType.VarChar).Value = strBrandName;
                sqlda.SelectCommand.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = strCategoryname;
                sqlda.Fill(dtbl);
                listObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDeleteReference", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = ServiceId;
                decReturnValue = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decReturnValue;
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
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceAddWithReturnIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceName", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.ServiceName;
                sprmparam = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
                sprmparam.Value = serviceinfo.ServiceCategoryId;
                sprmparam = sccmd.Parameters.Add("@rate", SqlDbType.Decimal);
                sprmparam.Value = serviceinfo.Rate;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = serviceinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = serviceinfo.Extra2;
                decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decIdentity;
        }
    }
}
