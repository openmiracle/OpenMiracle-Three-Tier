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
//Summary description for DebitNoteDetailsSP    
//</summary>    
namespace OpenMiracle.DAL    
{    
public class DebitNoteDetailsSP:DBConnection    
{    
    /// <summary>
    /// Function to insert values to DebitNoteDetails Table
    /// </summary>
    /// <param name="debitnotedetailsinfo"></param>
    /// <returns></returns>
    public decimal DebitNoteDetailsAdd(DebitNoteDetailsInfo debitnotedetailsinfo)
    {
        decimal decDebitNoteDetails = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("DebitNoteDetailsAdd", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            
            sprmparam = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.DebitNoteMasterId;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.Credit;
            sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.Debit;
            sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.ExchangeRateId;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = debitnotedetailsinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = debitnotedetailsinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = debitnotedetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = debitnotedetailsinfo.Extra2;
            sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
            sprmparam.Value = debitnotedetailsinfo.ExtraDate;
            decDebitNoteDetails = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return decDebitNoteDetails;
    }
    /// <summary>
    /// Function to Update values in DebitNoteDetails Table
    /// </summary>
    /// <param name="debitnotedetailsinfo"></param>
    public void DebitNoteDetailsEdit(DebitNoteDetailsInfo debitnotedetailsinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("DebitNoteDetailsEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@debitNoteDetailsId", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.DebitNoteDetailsId;
            sprmparam = sccmd.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.DebitNoteMasterId;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@credit", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.Credit;
            sprmparam = sccmd.Parameters.Add("@debit", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.Debit;
            sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
            sprmparam.Value = debitnotedetailsinfo.ExchangeRateId;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = debitnotedetailsinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = debitnotedetailsinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = debitnotedetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = debitnotedetailsinfo.Extra2;
            sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
            sprmparam.Value = debitnotedetailsinfo.ExtraDate;
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
    /// Function to get all the values from DebitNoteDetails Table
    /// </summary>
    /// <returns></returns>
    public DataTable DebitNoteDetailsViewAll()
    {
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteDetailsViewAll", sqlcon);
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
    /// Function to get particular values from DebitNoteDetails table based on the parameter
    /// </summary>
    /// <param name="debitNoteDetailsId"></param>
    /// <returns></returns>
    public DebitNoteDetailsInfo DebitNoteDetailsView(decimal debitNoteDetailsId )
    {
        DebitNoteDetailsInfo debitnotedetailsinfo =new DebitNoteDetailsInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("DebitNoteDetailsView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@debitNoteDetailsId", SqlDbType.Decimal);
            sprmparam.Value = debitNoteDetailsId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                debitnotedetailsinfo.DebitNoteDetailsId=decimal.Parse(sdrreader[0].ToString());
                debitnotedetailsinfo.DebitNoteMasterId=decimal.Parse(sdrreader[1].ToString());
                debitnotedetailsinfo.LedgerId=decimal.Parse(sdrreader[2].ToString());
                debitnotedetailsinfo.Credit=decimal.Parse(sdrreader[3].ToString());
                debitnotedetailsinfo.Debit=decimal.Parse(sdrreader[4].ToString());
                debitnotedetailsinfo.ExchangeRateId=decimal.Parse(sdrreader[5].ToString());
                debitnotedetailsinfo.ChequeNo= sdrreader[6].ToString();
                debitnotedetailsinfo.ChequeDate=DateTime.Parse(sdrreader[7].ToString());
                debitnotedetailsinfo.Extra1= sdrreader[8].ToString();
                debitnotedetailsinfo.Extra2= sdrreader[9].ToString();
                debitnotedetailsinfo.ExtraDate=DateTime.Parse(sdrreader[10].ToString());
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
        return debitnotedetailsinfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter
    /// </summary>
    /// <param name="DebitNoteDetailsId"></param>
    public void DebitNoteDetailsDelete(decimal DebitNoteDetailsId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("DebitNoteDetailsDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@debitNoteDetailsId", SqlDbType.Decimal);
            sprmparam.Value = DebitNoteDetailsId;
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
    /// Function to  get the next id for DebitNoteDetails table
    /// </summary>
    /// <returns></returns>
    public int DebitNoteDetailsGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("DebitNoteDetailsMax", sqlcon);
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
    /// Function to get particular values from DebitNoteDetails table based on the parameter in master table
    /// </summary>
    /// <param name="decMasterId"></param>
    /// <returns></returns>
    public List<DataTable> DebitNoteDetailsViewByMasterId(decimal decMasterId)
    {
        List<DataTable> listObj = new List<DataTable>();
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("DebitNoteDetailsViewByMasterId", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sdaadapter.SelectCommand.Parameters.Add("@debitNoteMasterId", SqlDbType.Decimal).Value = decMasterId;
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
   
}
}
