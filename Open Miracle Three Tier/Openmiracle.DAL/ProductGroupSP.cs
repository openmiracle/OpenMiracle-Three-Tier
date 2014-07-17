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
//Summary description for ProductGroupSP    
//</summary>    
namespace OpenMiracle.DAL
{
    public class ProductGroupSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to ProductGroup Table
        /// </summary>
        /// <param name="productgroupinfo"></param>
        /// <returns></returns>
        public decimal ProductGroupAdd(ProductGroupInfo productgroupinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductGroupAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@groupName", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.GroupName;
                sprmparam = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
                sprmparam.Value = productgroupinfo.GroupUnder;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.Extra2;
                decimal decIdForOtherForms = Convert.ToDecimal(sccmd.ExecuteScalar());
                if (decIdForOtherForms > 0)
                {
                    return decIdForOtherForms;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        /// <summary>
        /// Function to Update values in ProductGroup Table
        /// </summary>
        /// <param name="productgroupinfo"></param>
        public void ProductGroupEdit(ProductGroupInfo productgroupinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductGroupEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = productgroupinfo.GroupId;
                sprmparam = sccmd.Parameters.Add("@groupName", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.GroupName;
                sprmparam = sccmd.Parameters.Add("@groupUnder", SqlDbType.Decimal);
                sprmparam.Value = productgroupinfo.GroupUnder;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = productgroupinfo.Extra2;
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
        /// Function to get all the values from ProductGroup Table
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductGroupViewAll()
        {
            List<DataTable> listObjProductGroup = new List<DataTable>();
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
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductGroupViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.Fill(dtbl);
                listObjProductGroup.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjProductGroup;
        }
        /// <summary>
        /// Function to get productgroup details for gridfill
        /// </summary>
        /// <param name="strGroupName"></param>
        /// <param name="strGroupUnder"></param>
        /// <returns></returns>
        public List<DataTable> ProductGroupViewForGridFill(string strGroupName, string strGroupUnder)
        {
            List<DataTable> listObjProductGroup = new List<DataTable>();
            DataTable dtblProductGrp = new DataTable();
            dtblProductGrp.Columns.Add("SL.NO", typeof(decimal));
            dtblProductGrp.Columns["SL.NO"].AutoIncrement = true;
            dtblProductGrp.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtblProductGrp.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("ProductGroupViewForGridFill", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand.Parameters.Add("@groupName", SqlDbType.VarChar).Value = strGroupName;
                sdaadapter.SelectCommand.Parameters.Add("@groupUnder", SqlDbType.VarChar).Value = strGroupUnder;
                sdaadapter.Fill(dtblProductGrp);
                listObjProductGroup.Add(dtblProductGrp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjProductGroup;
        }
        /// <summary>
        /// Function to get particular values from ProductGroup table based on the parameter
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public ProductGroupInfo ProductGroupView(decimal groupId)
        {
            ProductGroupInfo productgroupinfo = new ProductGroupInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductGroupView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = groupId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    productgroupinfo.GroupId = decimal.Parse(sdrreader[0].ToString());
                    productgroupinfo.GroupName = sdrreader[1].ToString();
                    productgroupinfo.GroupUnder = decimal.Parse(sdrreader[2].ToString());
                    productgroupinfo.Narration = sdrreader[3].ToString();
                    productgroupinfo.Extra1 = sdrreader[4].ToString();
                    productgroupinfo.Extra2 = sdrreader[5].ToString();
                    productgroupinfo.ExtraDate = DateTime.Parse(sdrreader[6].ToString());
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
            return productgroupinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="GroupId"></param>
        public void ProductGroupDelete(decimal GroupId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductGroupDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = GroupId;
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
        /// Function to  get the next id for ProductGroup table
        /// </summary>
        /// <returns></returns>
        public int ProductGroupGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductGroupMax", sqlcon);
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
        /// Function to get the details for productgroup combobox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductGroupViewForComboFill()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("ProductGroupViewForComboFill", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
                sdaadapter.Fill(dtbl);
                listObj.Add(dtbl);
                DataRow dr = listObj[0].NewRow();
                dr["groupId"] = 0;
                dr["groupName"] = "All";
                listObj[0].Rows.InsertAt(dr, 0);
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
        /// Function to get the details for productgroup combobox
        /// </summary>
        /// <returns></returns>
        public List<DataTable> ProductGroupViewForComboFillForProductGroup()
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter();
                SqlCommand sqlcmd = new SqlCommand("ProductGroupViewForComboFill", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sdaadapter.SelectCommand = sqlcmd;
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
        /// Function to get product and unit details 
        /// </summary>
        /// <param name="decgroupId"></param>
        /// <param name="strProductCode"></param>
        /// <param name="strProductName"></param>
        /// <returns></returns>
        public List<DataTable> ProductAndUnitViewAllForGridFill(decimal decgroupId, string strProductCode, string strProductName)
        {
            List<DataTable> listObj = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("ProductAndUnitViewAllForGridFill", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decgroupId;
                sqlda.SelectCommand.Parameters.Add("@productCode", SqlDbType.VarChar).Value = strProductCode;
                sqlda.SelectCommand.Parameters.Add("@productName", SqlDbType.VarChar).Value = strProductName;
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
        /// Function to check the reference for productgroup
        /// </summary>
        /// <param name="strProductGroupName"></param>
        /// <param name="decProductGroupId"></param>
        /// <returns></returns>
        public bool ProductGroupCheckExistence(string strProductGroupName, decimal decProductGroupId)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ProductGroupCheckExistence", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = decProductGroupId;
                sprmparam = sqlcmd.Parameters.Add("@groupName", SqlDbType.VarChar);
                sprmparam.Value = strProductGroupName;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isEdit = true;
                    }
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
        /// Function to delete particular details based on the parameter after checking reference
        /// </summary>
        /// <param name="ProductGroupId"></param>
        /// <returns></returns>
        public decimal ProductGroupReferenceDelete(decimal ProductGroupId)
        {
            decimal decReturnValue = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("ProductGroupReferenceDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@groupId", SqlDbType.Decimal);
                sprmparam.Value = ProductGroupId;
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
        /// Function to check the reference for productgroup under a group
        /// </summary>
        /// <param name="decProductGroupId"></param>
        /// <returns></returns>
        public bool ProductGroupCheckExistenceOfUnderGroup(decimal decProductGroupId)
        {
            bool isExist = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("ProductGroupCheckExistenceOfUnderGroup", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@groupId", SqlDbType.Decimal).Value = decProductGroupId;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isExist = true;
                    }
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
            return isExist;
        }
    }
}
    
    
