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
//Summary description for ServiceDetailsSP    
//</summary>    
namespace OpenMiracle.DAL
{
   public  class ServiceDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ServiceDetails Table
        /// </summary>
        /// <param name="servicedetailsinfo"></param>
        public void ServiceDetailsAdd(ServiceDetailsInfo servicedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceDetailsId;
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceMasterId;
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceId;
                sprmparam = sccmd.Parameters.Add("@measure", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Measure;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = servicedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Extra2;
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
        /// Function to insert values to ServiceDetails Table and return corresponding row's id
        /// </summary>
        /// <param name="servicedetailsinfo"></param>
        /// <returns></returns>
        public decimal ServiceDetailsAddReturnWithIdentity(ServiceDetailsInfo servicedetailsinfo)
        {
            decimal decIdentity = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDetailsAddReturnWithIdentity", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceMasterId;
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceId;
                sprmparam = sccmd.Parameters.Add("@measure", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Measure;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = servicedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Extra2;
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
        /// <summary>
        /// Function to Update values in ServiceDetails Table
        /// </summary>
        /// <param name="servicedetailsinfo"></param>
        public void ServiceDetailsEdit(ServiceDetailsInfo servicedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceDetailsId;
                sprmparam = sccmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceMasterId;
                sprmparam = sccmd.Parameters.Add("@serviceId", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.ServiceId;
                sprmparam = sccmd.Parameters.Add("@measure", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Measure;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = servicedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = servicedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicedetailsinfo.Extra2;
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
        /// Function to get all the values from ServiceDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable ServiceDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceDetailsViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }
        /// <summary>
        /// Function to get particular values from ServiceDetails Table based on the parameter
        /// </summary>
        /// <param name="serviceDetailsId"></param>
        /// <returns></returns>
        public ServiceDetailsInfo ServiceDetailsView(decimal serviceDetailsId)
        {
            ServiceDetailsInfo servicedetailsinfo = new ServiceDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = serviceDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    servicedetailsinfo.ServiceDetailsId = decimal.Parse(sdrreader[0].ToString());
                    servicedetailsinfo.ServiceMasterId = decimal.Parse(sdrreader[1].ToString());
                    servicedetailsinfo.ServiceId = decimal.Parse(sdrreader[2].ToString());
                    servicedetailsinfo.Measure = sdrreader[3].ToString();
                    servicedetailsinfo.Amount = decimal.Parse(sdrreader[4].ToString());
                    servicedetailsinfo.ExtraDate = DateTime.Parse(sdrreader[5].ToString());
                    servicedetailsinfo.Extra1 = sdrreader[6].ToString();
                    servicedetailsinfo.Extra2 = sdrreader[7].ToString();
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
            return servicedetailsinfo;
        }
        /// <summary>
        ///  Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ServiceDetailsId"></param>
        public void ServiceDetailsDelete(decimal ServiceDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceDetailsId", SqlDbType.Decimal);
                sprmparam.Value = ServiceDetailsId;
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
        /// Function to  get the next id for ServiceDetails Table
        /// </summary>
        /// <returns></returns>
        public int ServiceDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceDetailsMax", sqlcon);
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
        /// Function to get particular values from ServiceDetails Table based on the parameter
        /// </summary>
        /// <param name="decServiceMasterId"></param>
        /// <returns></returns>
        public List<DataTable> ServiceDetailsViewWithMasterId(decimal decServiceMasterId)
        {
            List<DataTable> listObjServiceDetails = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Slno", typeof(decimal));
            dtbl.Columns["Slno"].AutoIncrement = true;
            dtbl.Columns["Slno"].AutoIncrementSeed = 1;
            dtbl.Columns["Slno"].AutoIncrementStep = 1;
            SqlDataAdapter sqlda = new SqlDataAdapter();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ServiceDetailsViewWithMasterId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@serviceMasterId", SqlDbType.Decimal).Value = decServiceMasterId;
                sqlda.SelectCommand = sqlcmd;
                sqlda.Fill(dtbl);
                listObjServiceDetails.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjServiceDetails;
        }
    }
}
