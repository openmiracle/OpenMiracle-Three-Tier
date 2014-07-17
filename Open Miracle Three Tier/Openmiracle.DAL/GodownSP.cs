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
//Summary description for GodownSP    
//</summary>    
namespace OpenMiracle.DAL   
{    
public class GodownSP:DBConnection    
{    
    /// <summary>
    /// Function to insert values to Godown Table
    /// </summary>
    /// <param name="godowninfo"></param>
    public void GodownAdd(GodownInfo godowninfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownAdd", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.GodownName;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Narration;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Extra2;
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
    /// Function to Update values in Godown Table
    /// </summary>
    /// <param name="godowninfo"></param>
    public void GodownEdit(GodownInfo godowninfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
            sprmparam.Value = godowninfo.GodownId;
            sprmparam = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.GodownName;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Narration;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Extra2;
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
    /// Function to get all the values from Godown Table
    /// </summary>
    /// <returns></returns>
    public List<DataTable> GodownViewAll()
    {
        List<DataTable> listObj = new List<DataTable>();
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("GodownViewAll", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    /// Function to get particular values from Godown table based on the parameter
    /// </summary>
    /// <param name="godownId"></param>
    /// <returns></returns>
 
    public GodownInfo GodownView(decimal godownId )
    {
        GodownInfo godowninfo =new GodownInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
            sprmparam.Value = godownId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                godowninfo.GodownId = Convert.ToDecimal(sdrreader[0].ToString());
                godowninfo.GodownName= sdrreader[1].ToString();
                godowninfo.Narration= sdrreader[2].ToString();
                godowninfo.ExtraDate=Convert.ToDateTime(sdrreader[3].ToString());
                godowninfo.Extra1= sdrreader[4].ToString();
                godowninfo.Extra2= sdrreader[5].ToString();
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
        return godowninfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter
    /// </summary>
    /// <param name="GodownId"></param>
    public void GodownDelete(decimal GodownId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
            sprmparam.Value = GodownId;
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
    /// Function to  get the next id for Godown table
    /// </summary>
    /// <returns></returns>
    public int GodownGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownMax", sqlcon);
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
    /// Function to get all the values from Godown Table
    /// </summary>
    /// <returns></returns>
    public List<DataTable> GodownOnlyViewAll()
    {
        List<DataTable> listObj = new List<DataTable>();
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
            SqlDataAdapter sdaadapter = new SqlDataAdapter("GodownOnlyViewAll", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
    /// Function to insert values to Godown Table with same name
    /// </summary>
    /// <param name="godowninfo"></param>
    /// <returns></returns>
    public decimal GodownAddWithoutSameName(GodownInfo godowninfo)
    {
       // bool isSave = false;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownAddWithoutSameName", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.GodownName;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Narration;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Extra2;
            decimal decWork = Convert.ToDecimal( sccmd.ExecuteScalar());
            if (decWork > 0)
            {
               return decWork;
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
    /// Function to get particular values from Godown table based on the parameter with narration
    /// </summary>
    /// <param name="decGodownId"></param>
    /// <returns></returns>
    public GodownInfo GodownWithNarrationView(decimal decGodownId)
    {
        GodownInfo godowninfo = new GodownInfo();
        SqlDataReader sdrreader = null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownWithNarrationView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
            sprmparam.Value = decGodownId;
            sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                godowninfo.GodownId = Convert.ToDecimal(sdrreader[0].ToString());
                godowninfo.GodownName = sdrreader[1].ToString();
                godowninfo.Narration = sdrreader[2].ToString();
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
        return godowninfo;
    }
   /// <summary>
   /// Function to check the existance of godown
   /// </summary>
   /// <param name="strGodownName"></param>
   /// <param name="strGodownId"></param>
   /// <returns></returns>
    public bool GodownCheckIfExist(String strGodownName, decimal strGodownId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sqlcmd = new SqlCommand("GodownCheckIfExist", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sqlcmd.Parameters.Add("@godownName", SqlDbType.VarChar);
            sprmparam.Value = strGodownName;
            sprmparam = sqlcmd.Parameters.Add("@godownId", SqlDbType.Decimal);
            sprmparam.Value = strGodownId;
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
    /// Function to Update values in Godown Table
    /// </summary>
    /// <param name="godowninfo"></param>
    /// <returns></returns>
    public bool GodownEditParticularField(GodownInfo godowninfo)
    {
        bool isEdit = false;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("godownEditParticularField", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownId", SqlDbType.Decimal);
            sprmparam.Value = godowninfo.GodownId;
            sprmparam = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.GodownName;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = godowninfo.Narration;
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
    /// Function to delete particular details based on the parameter by checking reference
    /// </summary>
    /// <param name="decGodownId"></param>
    /// <returns></returns>
    public decimal GodownCheckReferenceAndDelete(decimal decGodownId)
    {
        decimal decReturnValue = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sqlcmd = new SqlCommand("GodownCheckReferenceAndDelete", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sqlcmd.Parameters.Add("@godownId", SqlDbType.Decimal);
            sprmparam.Value = decGodownId;
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
    /// <summary>
    /// Function to get the godownId by godownname
    /// </summary>
    /// <param name="strGodown"></param>
    /// <returns></returns>
    public GodownInfo GodownIdByGodownName(string strGodown)
    {
        GodownInfo godowninfo = new GodownInfo();
        SqlDataReader sdrreader = null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@godownName", SqlDbType.VarChar);
            sprmparam.Value = strGodown;
            sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                godowninfo.GodownId = Convert.ToDecimal(sdrreader[0].ToString());
                
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
        return godowninfo;
    }
    /// <summary>
    /// Function to get default godownId by productName
    /// </summary>
    /// <param name="productName"></param>
    /// <returns></returns>
    public decimal DefaultGodownIDViewByProductName(string productName)
    {
        decimal godownId = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("GodownIdViewByProductName", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@productName", SqlDbType.VarChar);
            sprmparam.Value = productName;
            godownId = Convert.ToDecimal(sccmd.ExecuteScalar());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return godownId;
    }
}
}
