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
//Summary description for ServiceCategorySP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ServiceCategorySP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ServiceCategory Table
        /// </summary>
        /// <param name="servicecategoryinfo"></param>
        public void ServiceCategoryAdd(ServiceCategoryInfo servicecategoryinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@categoryName", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.CategoryName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = servicecategoryinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra2;
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
        /// Function to Update values in ServiceCategory Table
        /// </summary>
        /// <param name="servicecategoryinfo"></param>
        public void ServiceCategoryEdit(ServiceCategoryInfo servicecategoryinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@servicecategoryId", SqlDbType.Decimal);
                sprmparam.Value = servicecategoryinfo.ServicecategoryId;
                sprmparam = sccmd.Parameters.Add("@categoryName", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.CategoryName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra2;
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
        /// unction to get all the values from ServiceCategory Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ServiceCategoryViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceCategoryViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to get particular values from ServiceCategory Table based on the parameter
        /// </summary>
        /// <param name="servicecategoryId"></param>
        /// <returns></returns>
        public ServiceCategoryInfo ServiceCategoryView(decimal servicecategoryId)
        {
            ServiceCategoryInfo servicecategoryinfo = new ServiceCategoryInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@servicecategoryId", SqlDbType.Decimal);
                sprmparam.Value = servicecategoryId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    servicecategoryinfo.ServicecategoryId = Convert.ToDecimal(sdrreader[0].ToString());
                    servicecategoryinfo.CategoryName = sdrreader[1].ToString();
                    servicecategoryinfo.Narration = sdrreader[2].ToString();
                    servicecategoryinfo.ExtraDate = Convert.ToDateTime(sdrreader[3].ToString());
                    servicecategoryinfo.Extra1 = sdrreader[4].ToString();
                    servicecategoryinfo.Extra2 = sdrreader[5].ToString();
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
            return servicecategoryinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="ServicecategoryId"></param>
        public void ServiceCategoryDelete(decimal ServicecategoryId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@servicecategoryId", SqlDbType.Decimal);
                sprmparam.Value = ServicecategoryId;
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
        /// Function to  get the next id for ServiceCategory Table
        /// </summary>
        /// <returns></returns>
        public int ServiceCategoryGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryMax", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                max = Convert.ToInt32(sccmd.ExecuteScalar().ToString());
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
        /// Function to check existence of service category based on parameter
        /// </summary>
        /// <param name="strCategoryName"></param>
        /// <param name="decServiceCategoryId"></param>
        /// <returns></returns>
        public bool ServiceCategoryCheckIfExist(String strCategoryName, decimal decServiceCategoryId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ServiceCategoryCheckIfExist", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@categoryName", SqlDbType.VarChar);
                sprmparam.Value = strCategoryName;
                sprmparam = sqlcmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
                sprmparam.Value = decServiceCategoryId;
                object obj = sqlcmd.ExecuteScalar();
                decimal decCount = 0;
                if (obj != null)
                {
                    decCount = Convert.ToDecimal(obj.ToString());
                }
                if (decCount > 0)
                {
                    return true;
                }
                else
                {
                    return false; ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return false;
        }
        /// <summary>
        /// Function to check status for Update
        /// </summary>
        /// <param name="servicecategoryinfo"></param>
        /// <returns></returns>
        public bool ServiceCategoryEditParticularFeilds(ServiceCategoryInfo servicecategoryinfo)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryEditParticularFeilds", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
                sprmparam.Value = servicecategoryinfo.ServicecategoryId;
                sprmparam = sccmd.Parameters.Add("@categoryName", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.CategoryName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Narration;
                int inAffectedRows = sccmd.ExecuteNonQuery();
                if (inAffectedRows > 0)
                {
                    isEdit = true;
                }
                else
                {
                    isEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Function to view all details 
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ServiceCategoryParticularFieldsViewAll()
        {
            List<DataTable> ListObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ServiceCategoryParticularFieldsViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                ListObj.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ListObj;
        }
        /// <summary>
        /// Function to add values and return corresponding row's id
        /// </summary>
        /// <param name="servicecategoryinfo"></param>
        /// <returns></returns>
        public bool ServiceCategoryAddSpecificFields(ServiceCategoryInfo servicecategoryinfo)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryAddSpecificFields", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@categoryName", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.CategoryName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra2;
                int inWork = sccmd.ExecuteNonQuery();
                if (inWork > 0)
                {
                    isSave = true;
                }
                else
                {
                    isSave = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return isSave;
        }
        /// <summary>
        /// Function to add values to ServiceCategory Table
        /// </summary>
        /// <param name="servicecategoryinfo"></param>
        /// <returns></returns>
        public decimal ServiceCategoryAddSpecificFields1(ServiceCategoryInfo servicecategoryinfo)
        {
            decimal decId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryAddSpecificFields", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@categoryName", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.CategoryName;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = servicecategoryinfo.Extra2;
                decId = Convert.ToInt32(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decId;
        }
        /// <summary>
        /// Function to view details based on parameter
        /// </summary>
        /// <param name="decServiceCategoryId"></param>
        /// <returns></returns>
        public ServiceCategoryInfo ServiceCategoryWithNarrationView(decimal decServiceCategoryId)
        {
            ServiceCategoryInfo ServiceCategoryinfo = new ServiceCategoryInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ServiceCategoryWithNarrationView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
                sprmparam.Value = decServiceCategoryId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    ServiceCategoryinfo.ServicecategoryId = Convert.ToDecimal(sdrreader[0].ToString());
                    ServiceCategoryinfo.CategoryName = sdrreader[1].ToString();
                    ServiceCategoryinfo.Narration = sdrreader[2].ToString();
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
            return ServiceCategoryinfo;
        }
        /// <summary>
        /// Function to check reference and delete based on parameter
        /// </summary>
        /// <param name="decServiceCategoryId"></param>
        /// <returns></returns>
        public decimal ServiceCategoryCheckReferenceAndDelete(decimal decServiceCategoryId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ServiceCategoryCheckReferenceAndDelete", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@serviceCategoryId", SqlDbType.Decimal);
                sprmparam.Value = decServiceCategoryId;
                decReturnValue = Convert.ToDecimal(sqlcmd.ExecuteNonQuery().ToString());
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
    }
}
