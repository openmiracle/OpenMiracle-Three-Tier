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
//Summary description for JournalDetailsSP    
//</summary>    
namespace OpenMiracle.DAL   
{    
public class JournalDetailsSP:DBConnection    
{    
   /// <summary>
    /// Function to insert values to JournalDetails Table
   /// </summary>
   /// <param name="journaldetailsinfo"></param>
   /// <returns></returns>
    public decimal JournalDetailsAdd(JournalDetailsInfo journaldetailsinfo)
    {
        decimal decId = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("JournalDetailsAdd", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.JournalMasterId;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.Credit;
            sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.Debit;
            sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.ExchangeRateId;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = journaldetailsinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = journaldetailsinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
            sprmparam.Value = journaldetailsinfo.ExtraDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = journaldetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = journaldetailsinfo.Extra2;
            decId = Convert.ToDecimal(sccmd.ExecuteScalar());
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
    /// Function to Update values in JournalDetails Table
    /// </summary>
    /// <param name="journaldetailsinfo"></param>
    public void JournalDetailsEdit(JournalDetailsInfo journaldetailsinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("JournalDetailsEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@journalDetailsId", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.JournalDetailsId;
            sprmparam = sccmd.Parameters.Add("@journalMasterId", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.JournalMasterId;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.Credit;
            sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.Debit;
            sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
            sprmparam.Value = journaldetailsinfo.ExchangeRateId;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = journaldetailsinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = journaldetailsinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
            sprmparam.Value = journaldetailsinfo.ExtraDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = journaldetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = journaldetailsinfo.Extra2;
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
    /// Function to get all the values from JournalDetails Table
    /// </summary>
    /// <returns></returns>
    public DataTable JournalDetailsViewAll()
    {
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalDetailsViewAll", sqlcon);
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
    /// Function to get particular values from JournalDetails table based on the parameter
    /// </summary>
    /// <param name="journalDetailsId"></param>
    /// <returns></returns>
    public JournalDetailsInfo JournalDetailsView(decimal journalDetailsId )
    {
        JournalDetailsInfo journaldetailsinfo =new JournalDetailsInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("JournalDetailsView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@journalDetailsId", SqlDbType.Decimal);
            sprmparam.Value = journalDetailsId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                journaldetailsinfo.JournalDetailsId=decimal.Parse(sdrreader[0].ToString());
                journaldetailsinfo.JournalMasterId=decimal.Parse(sdrreader[1].ToString());
                journaldetailsinfo.LedgerId=decimal.Parse(sdrreader[2].ToString());
                journaldetailsinfo.Credit=decimal.Parse(sdrreader[3].ToString());
                journaldetailsinfo.Debit=decimal.Parse(sdrreader[4].ToString());
                journaldetailsinfo.ExchangeRateId = decimal.Parse(sdrreader[5].ToString());
                journaldetailsinfo.ChequeNo= sdrreader[6].ToString();
                journaldetailsinfo.ChequeDate=DateTime.Parse(sdrreader[7].ToString());
                journaldetailsinfo.ExtraDate=DateTime.Parse(sdrreader[8].ToString());
                journaldetailsinfo.Extra1= sdrreader[9].ToString();
                journaldetailsinfo.Extra2= sdrreader[10].ToString();
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
        return journaldetailsinfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter
    /// </summary>
    /// <param name="JournalDetailsId"></param>
    public void JournalDetailsDelete(decimal JournalDetailsId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("JournalDetailsDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@journalDetailsId", SqlDbType.Decimal);
            sprmparam.Value = JournalDetailsId;
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
    /// Function to  get the next id for JournalDetails table
    /// </summary>
    /// <returns></returns>
    public int JournalDetailsGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("JournalDetailsMax", sqlcon);
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
    /// Function to get particular values from JournalDetails table based on the parameter in master table
    /// </summary>
    /// <param name="decMasterId"></param>
    /// <returns></returns>
    public List<DataTable> JournalDetailsViewByMasterId(decimal decMasterId)
    {
        List<DataTable> ListObj = new List<DataTable>();
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("JournalDetailsViewByMasterId", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sdaadapter.SelectCommand.Parameters.Add("@journalMasterId", SqlDbType.Decimal).Value = decMasterId;
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
}
}
