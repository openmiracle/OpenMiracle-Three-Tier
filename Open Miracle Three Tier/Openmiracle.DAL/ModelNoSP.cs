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
//Summary description for ModelNoSP    
//</summary>     
namespace OpenMiracle.DAL
{    
public class ModelNoSP:DBConnection    
{
    /// <summary>
    /// Function to add modelNo to modelNo table with differnt modelNo
    /// </summary>
    /// <param name="modelnoinfo"></param>
    /// <returns></returns>
    public decimal ModelNoAddWithDifferentModelNo(ModelNoInfo modelnoinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("ModelNoAddWithDifferentModelNo", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.ModelNo;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.Narration;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.Extra2;
            decimal decWork=Convert.ToDecimal( sccmd.ExecuteScalar());
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
    /// Function to Update values in ModelNo Table
    /// </summary>
    /// <param name="modelnoinfo"></param>
    public void ModelNoEdit(ModelNoInfo modelnoinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("ModelNoEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
            sprmparam.Value = modelnoinfo.ModelNoId;
            sprmparam = sccmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.ModelNo;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.Narration;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.Extra2;
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
    /// Function to get all the values from ModelNo Table
    /// </summary>
    /// <returns></returns>
    public List<DataTable> ModelNoViewAll()
    {
        List<DataTable> listObj = new List<DataTable>();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("ModelNoViewAll", sqlcon);
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
    /// Function to get particular values from ModelNo table based on the parameter
    /// </summary>
    /// <param name="modelNoId"></param>
    /// <returns></returns>
    public ModelNoInfo ModelNoView(decimal modelNoId )
    {
        ModelNoInfo modelnoinfo =new ModelNoInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("ModelNoView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
            sprmparam.Value = modelNoId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                modelnoinfo.ModelNoId = Convert.ToDecimal(sdrreader[0].ToString());
                modelnoinfo.ModelNo= sdrreader[1].ToString();
                modelnoinfo.Narration= sdrreader[2].ToString();
                modelnoinfo.ExtraDate=Convert.ToDateTime(sdrreader[3].ToString());
                modelnoinfo.Extra1= sdrreader[4].ToString();
                modelnoinfo.Extra2= sdrreader[5].ToString();
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
        return modelnoinfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter
    /// </summary>
    /// <param name="ModelNoId"></param>
    public void ModelNoDelete(decimal ModelNoId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("ModelNoDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
            sprmparam.Value = ModelNoId;
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
    /// Function to  get the next id for ModelNo table
    /// </summary>
    /// <returns></returns>
    public int ModelNoGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("ModelNoMax", sqlcon);
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
    /// Function to get all the values from ModelNo Table
   /// </summary>
   /// <returns></returns> 
    public List<DataTable> ModelNoOnlyViewAll()
    {
        List<DataTable> listObj = new List<DataTable>();
        
        try
        {
            if (sqlcon.State == ConnectionState.Closed) 
            {
                sqlcon.Open();
            }
            DataTable dtbl = new DataTable();
            SqlDataAdapter sdaadapter = new SqlDataAdapter("ModelNoOnlyViewAll", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
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
    /// Function to get particular values from ModelNo table based on the parameter with narration
    /// </summary>
    /// <param name="decModelNoId"></param>
    /// <returns></returns>
    public ModelNoInfo ModelNoWithNarrationView(decimal decModelNoId)
    {
        ModelNoInfo modelnoinfo = new ModelNoInfo();
        SqlDataReader sdrreader = null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("ModelNoWithNarrationView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
            sprmparam.Value = decModelNoId;
            sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                modelnoinfo.ModelNoId = Convert.ToDecimal(sdrreader[0].ToString());
                modelnoinfo.ModelNo = sdrreader[1].ToString();
                modelnoinfo.Narration = sdrreader[2].ToString();    
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
        return modelnoinfo;
    }
    /// <summary>
    /// Function to check existance of modelNo
    /// </summary>
    /// <param name="strModelNo"></param>
    /// <param name="decModelNoId"></param>
    /// <returns></returns>
    public bool ModelCheckIfExist(String strModelNo, decimal decModelNoId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sqlcmd = new SqlCommand("ModelCheckIfExist", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sqlcmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
            sprmparam.Value = strModelNo;
            sprmparam = sqlcmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
            sprmparam.Value = decModelNoId;
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
    /// Function to Update values in ModelNo Table
    /// </summary>
    /// <param name="modelnoinfo"></param>
    /// <returns></returns>
    public bool ModelNoEditParticularFeilds(ModelNoInfo modelnoinfo)
    {
        bool isEdit = false;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("ModelNoEditParticularFeild", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
            sprmparam.Value = modelnoinfo.ModelNoId;
            sprmparam = sccmd.Parameters.Add("@modelNo", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.ModelNo;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = modelnoinfo.Narration;
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
    /// <param name="decModelNoId"></param>
    /// <returns></returns>
    public decimal ModelNoCheckReferenceAndDelete(decimal decModelNoId)
    {
        decimal decReturnValue = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sqlcmd = new SqlCommand("ModelNoCheckReferenceAndDelete", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sqlcmd.Parameters.Add("@modelNoId", SqlDbType.Decimal);
            sprmparam.Value = decModelNoId;
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
