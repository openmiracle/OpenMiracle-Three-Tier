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
//Summary description for SalaryPackageDetailsSP    
//</summary>    
namespace OpenMiracle.DAL    
{
    public class SalaryPackageDetailsSP : DBConnection
    {
        /// <summary>
        /// Function to insert values to SalaryPackageDetails Table
        /// </summary>
        /// <param name="salarypackagedetailsinfo"></param>
        /// <returns></returns>
        public bool SalaryPackageDetailsAdd(SalaryPackageDetailsInfo salarypackagedetailsinfo)
        {
            bool isSave = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
                sprmparam.Value = salarypackagedetailsinfo.SalaryPackageId;
                sprmparam = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
                sprmparam.Value = salarypackagedetailsinfo.PayHeadId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salarypackagedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salarypackagedetailsinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salarypackagedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salarypackagedetailsinfo.Extra2;
                int inValue = sccmd.ExecuteNonQuery();
                if (inValue > 0)
                {
                    isSave = true;
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
        /// Function to Update values in SalaryPackageDetails Table
        /// </summary>
        /// <param name="salarypackagedetailsinfo"></param>
        public void SalaryPackageDetailsEdit(SalaryPackageDetailsInfo salarypackagedetailsinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsEdit", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salarypackagedetailsinfo.SalaryPackageDetailsId;
                sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
                sprmparam.Value = salarypackagedetailsinfo.SalaryPackageId;
                sprmparam = sccmd.Parameters.Add("@payHeadId", SqlDbType.Decimal);
                sprmparam.Value = salarypackagedetailsinfo.PayHeadId;
                sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
                sprmparam.Value = salarypackagedetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
                sprmparam.Value = salarypackagedetailsinfo.Narration;
                sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
                sprmparam.Value = salarypackagedetailsinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
                sprmparam.Value = salarypackagedetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
                sprmparam.Value = salarypackagedetailsinfo.Extra2;
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
        /// Function to get all the values from SalaryPackageDetails Table
        /// </summary>
        /// <returns></returns>
        public DataTable SalaryPackageDetailsViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlDataAdapter sdaadapter = new SqlDataAdapter("SalaryPackageDetailsViewAll", sqlcon);
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
        /// Function to get particular values from SalaryPackageDetails table based on the parameter
        /// </summary>
        /// <param name="salaryPackageDetailsId"></param>
        /// <returns></returns>
        public SalaryPackageDetailsInfo SalaryPackageDetailsView(decimal salaryPackageDetailsId)
        {
            SalaryPackageDetailsInfo salarypackagedetailsinfo = new SalaryPackageDetailsInfo();
            SqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsView", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageDetailsId", SqlDbType.Decimal);
                sprmparam.Value = salaryPackageDetailsId;
                sdrreader = sccmd.ExecuteReader();
                while (sdrreader.Read())
                {
                    salarypackagedetailsinfo.SalaryPackageDetailsId = decimal.Parse(sdrreader[0].ToString());
                    salarypackagedetailsinfo.SalaryPackageId = decimal.Parse(sdrreader[1].ToString());
                    salarypackagedetailsinfo.PayHeadId = decimal.Parse(sdrreader[2].ToString());
                    salarypackagedetailsinfo.Amount = decimal.Parse(sdrreader[3].ToString());
                    salarypackagedetailsinfo.Narration = sdrreader[4].ToString();
                    salarypackagedetailsinfo.ExtraDate = DateTime.Parse(sdrreader[5].ToString());
                    salarypackagedetailsinfo.Extra1 = sdrreader[6].ToString();
                    salarypackagedetailsinfo.Extra2 = sdrreader[7].ToString();
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
            return salarypackagedetailsinfo;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalaryPackageDetailsId"></param>
        public void SalaryPackageDetailsDelete(decimal SalaryPackageDetailsId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsDelete", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sccmd.Parameters.Add("@salaryPackageDetailsId", SqlDbType.Decimal);
                sprmparam.Value = SalaryPackageDetailsId;
                int inWorked = sccmd.ExecuteNonQuery();
                if (inWorked > 0)
                {
                    //Messages.DeletedMessage();
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
        }
        /// <summary>
        /// Function to  get the next id for SalaryPackageDetails table
        /// </summary>
        /// <returns></returns>
        public int SalaryPackageDetailsGetMax()
        {
            int max = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sccmd = new SqlCommand("SalaryPackageDetailsMax", sqlcon);
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
        /// Function to get payhead type
        /// </summary>
        /// <param name="payHeadId"></param>
        /// <returns></returns>
        public string PayHeadTypeView(decimal payHeadId)
        {
            string price = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("PayHeadTypeView", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@payHeadId", SqlDbType.Decimal).Value = payHeadId;
                price = (sqlcmd.ExecuteScalar().ToString());
            }
            catch (Exception )
            {
                //Messages.ErrorMessage(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return price;
        }
        /// <summary>
        /// Function to get particular values from SalaryPackageDetails table based on the parameter
        /// </summary>
        /// <param name="decSalaryPackageId"></param>
        /// <returns></returns>
        public List<DataTable> SalaryPackageDetailsViewWithSalaryPackageId(decimal decSalaryPackageId)
        {
            List<DataTable> listObjSalaryPackageDetails = new List<DataTable>();
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
                SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageDetailsViewWithSalaryPackageId", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@salaryPackageId", SqlDbType.Decimal).Value = decSalaryPackageId;
                sqlda.Fill(dtbl);
                listObjSalaryPackageDetails.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return listObjSalaryPackageDetails;
        }
        /// <summary>
        /// Function to delete particular details based on the parameter
        /// </summary>
        /// <param name="SalaryPackageId"></param>
        public void SalaryPackageDetailsDeleteWithSalaryPackageId(decimal SalaryPackageId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                SqlCommand sqlcmd = new SqlCommand("SalaryPackageDetailsDeleteWithSalaryPackageId", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sprmparam = new SqlParameter();
                sprmparam = sqlcmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
                sprmparam.Value = SalaryPackageId;
                int inWorked = sqlcmd.ExecuteNonQuery();
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
        /// Function to get details for report
        /// </summary>
        /// <param name="strPackageName"></param>
        /// <returns></returns>
        public List<DataTable> SalaryPackageDetailsForSalaryPackageDetailsReport(string strPackageName)//Coded By Swafiyy
        {
            List<DataTable> listObjSalaryPackageDetails = new List<DataTable>();
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SalaryPackageDetailsForSalaryPackageDetailsReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("@packageName", SqlDbType.VarChar).Value = strPackageName;
                sqlda.Fill(dtbl);
                listObjSalaryPackageDetails.Add(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listObjSalaryPackageDetails;
        }
    }
}
