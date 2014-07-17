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
//Summary description for PurchaseReturnBilltaxSP    
//</summary>    
namespace OpenMiracle.DAL
{  
    
public class PurchaseReturnBilltaxSP:DBConnection    
{   
    /// <summary>
    /// Function to insert values to PurchaseReturnBilltax Table
    /// </summary>
    /// <param name="purchasereturnbilltaxinfo"></param>
    public void PurchaseReturnBilltaxAdd(PurchaseReturnBilltaxInfo purchasereturnbilltaxinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxAdd", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
            sprmparam.Value = purchasereturnbilltaxinfo.PurchaseReturnMasterId;
            sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
            sprmparam.Value = purchasereturnbilltaxinfo.TaxId;
            sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
            sprmparam.Value = purchasereturnbilltaxinfo.TaxAmount;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = purchasereturnbilltaxinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = purchasereturnbilltaxinfo.Extra2;
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
    /// Function to Update values in PurchaseReturnBilltax Table
    /// </summary>
    /// <param name="purchasereturnbilltaxinfo"></param>
    public void PurchaseReturnBilltaxEdit(PurchaseReturnBilltaxInfo purchasereturnbilltaxinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@purchaseReturnBillTaxId", SqlDbType.Decimal);
            sprmparam.Value = purchasereturnbilltaxinfo.PurchaseReturnBillTaxId;
            sprmparam = sccmd.Parameters.Add("@purchaseReturnMasterId", SqlDbType.Decimal);
            sprmparam.Value = purchasereturnbilltaxinfo.PurchaseReturnMasterId;
            sprmparam = sccmd.Parameters.Add("@taxId", SqlDbType.Decimal);
            sprmparam.Value = purchasereturnbilltaxinfo.TaxId;
            sprmparam = sccmd.Parameters.Add("@taxAmount", SqlDbType.Decimal);
            sprmparam.Value = purchasereturnbilltaxinfo.TaxAmount;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = purchasereturnbilltaxinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = purchasereturnbilltaxinfo.Extra2;
            sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
            sprmparam.Value = purchasereturnbilltaxinfo.ExtraDate;
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
    /// Function to get all the values from PurchaseReturnBilltax Table
    /// </summary>
    /// <returns></returns>
    public DataTable PurchaseReturnBilltaxViewAll()
    {
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("PurchaseReturnBilltaxViewAll", sqlcon);
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
    /// Function to get particular values from PurchaseReturnBilltax Table based on the parameter
    /// </summary>
    /// <param name="purchaseReturnBillTaxId"></param>
    /// <returns></returns>
    public PurchaseReturnBilltaxInfo PurchaseReturnBilltaxView(decimal purchaseReturnBillTaxId )
    {
        PurchaseReturnBilltaxInfo purchasereturnbilltaxinfo =new PurchaseReturnBilltaxInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@purchaseReturnBillTaxId", SqlDbType.Decimal);
            sprmparam.Value = purchaseReturnBillTaxId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                purchasereturnbilltaxinfo.PurchaseReturnBillTaxId=decimal.Parse(sdrreader[0].ToString());
                purchasereturnbilltaxinfo.PurchaseReturnMasterId=decimal.Parse(sdrreader[1].ToString());
                purchasereturnbilltaxinfo.TaxId=decimal.Parse(sdrreader[2].ToString());
                purchasereturnbilltaxinfo.TaxAmount=decimal.Parse(sdrreader[3].ToString());
                purchasereturnbilltaxinfo.Extra1= sdrreader[4].ToString();
                purchasereturnbilltaxinfo.Extra2= sdrreader[5].ToString();
                purchasereturnbilltaxinfo.ExtraDate=DateTime.Parse(sdrreader[6].ToString());
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
        return purchasereturnbilltaxinfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter From Table PurchaseReturnBilltax
    /// </summary>
    /// <param name="PurchaseReturnBillTaxId"></param>
    public void PurchaseReturnBilltaxDelete(decimal PurchaseReturnBillTaxId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@purchaseReturnBillTaxId", SqlDbType.Decimal);
            sprmparam.Value = PurchaseReturnBillTaxId;
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
    /// Function to  get the next id for PurchaseReturnBilltax Table
    /// </summary>
    /// <returns></returns>
    public int PurchaseReturnBilltaxGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PurchaseReturnBilltaxMax", sqlcon);
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
}
}
