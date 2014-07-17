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
//Summary description for MonthlySalaryDetailsSP    
//</summary>    
namespace OpenMiracle.DAL   
{    
public class MonthlySalaryDetailsSP:DBConnection    
{    
    /// <summary>
    /// Function to insert values to MonthlySalaryDetails Table
    /// </summary>
    /// <param name="monthlysalarydetailsinfo"></param>
    public void MonthlySalaryDetailsAdd(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsAdd", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.EmployeeId;
            sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.SalaryPackageId;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra2;      
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
    /// Function to Update values in MonthlySalaryDetails Table
    /// </summary>
    /// <param name="monthlysalarydetailsinfo"></param>
    public void MonthlySalaryDetailsEdit(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.MonthlySalaryDetailsId;
            sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.EmployeeId;
            sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.ExtraDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra2;
            sccmd.ExecuteNonQuery();        }
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
    /// Function to get all the values from MonthlySalaryDetails Table
    /// </summary>
    /// <returns></returns>
    public DataTable MonthlySalaryDetailsViewAll()
    {
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("MonthlySalaryDetailsViewAll", sqlcon);
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
    /// Function to get particular values from MonthlySalaryDetails table based on the parameter
    /// </summary>
    /// <param name="monthlySalaryDetailsId"></param>
    /// <returns></returns>
    public MonthlySalaryDetailsInfo MonthlySalaryDetailsView(decimal monthlySalaryDetailsId )
    {
        MonthlySalaryDetailsInfo monthlysalarydetailsinfo =new MonthlySalaryDetailsInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
            sprmparam.Value = monthlySalaryDetailsId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                monthlysalarydetailsinfo.MonthlySalaryDetailsId=Convert.ToDecimal(sdrreader[0].ToString());
                monthlysalarydetailsinfo.EmployeeId=Convert.ToDecimal(sdrreader[1].ToString());
                monthlysalarydetailsinfo.SalaryPackageId=Convert.ToDecimal(sdrreader[2].ToString());
                monthlysalarydetailsinfo.ExtraDate=Convert.ToDateTime(sdrreader[3].ToString());
                monthlysalarydetailsinfo.Extra1= sdrreader[4].ToString();
                monthlysalarydetailsinfo.Extra2= sdrreader[5].ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {           sdrreader.Close(); 
            sqlcon.Close();
        }
        return monthlysalarydetailsinfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter
    /// </summary>
    /// <param name="MonthlySalaryDetailsId"></param>
    public void MonthlySalaryDetailsDelete(decimal MonthlySalaryDetailsId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
            sprmparam.Value = MonthlySalaryDetailsId;
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
    /// Function to  get the next id for MonthlySalaryDetails table
    /// </summary>
    /// <returns></returns>
    public int MonthlySalaryDetailsGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsMax", sqlcon);
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
    /// Function to insert values to MonthlySalaryDetails Table with monthlySalaryId
    /// </summary>
    /// <param name="monthlysalarydetailsinfo"></param>
    public void MonthlySalaryDetailsAddWithMonthlySalaryId(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsAddWithMonthlySalaryId", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.EmployeeId;
            sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.SalaryPackageId;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra2;
            sprmparam = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.MonthlySalaryId;
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
    /// Function to Update values in MonthlySalaryDetails Table using masterId and detailsId
    /// </summary>
    /// <param name="monthlysalarydetailsinfo"></param>
    public void MonthlySalaryDetailsEditUsingMasterIdAndDetailsId(MonthlySalaryDetailsInfo monthlysalarydetailsinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalaryDetailsEditUsingMasterIdAndDetailsId", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.MonthlySalaryDetailsId;
            sprmparam = sccmd.Parameters.Add("@monthlySalaryId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.MonthlySalaryId;
            sprmparam = sccmd.Parameters.Add("@employeeId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.EmployeeId;
            sprmparam = sccmd.Parameters.Add("@salaryPackageId", SqlDbType.Decimal);
            sprmparam.Value = monthlysalarydetailsinfo.SalaryPackageId;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = monthlysalarydetailsinfo.Extra2;
            int ina = sccmd.ExecuteNonQuery();
            
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
    /// Function to delete MonthlySalary settings
    /// </summary>
    /// <param name="MonthlySalaryDetailsId"></param>
    public void MonthlySalarySettingsDetailsIdDelete(decimal MonthlySalaryDetailsId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("MonthlySalarySettingsDetailsIdDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@monthlySalaryDetailsId", SqlDbType.Decimal);
            sprmparam.Value = MonthlySalaryDetailsId;
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
}
}
