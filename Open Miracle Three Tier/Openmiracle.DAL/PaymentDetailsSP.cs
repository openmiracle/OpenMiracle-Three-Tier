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
//Summary description for PaymentDetailsSP    
//</summary>    
namespace OpenMiracle.DAL  
{    
public class PaymentDetailsSP:DBConnection    
{    
    /// <summary>
    /// Function to insert values to PaymentDetails Table
    /// </summary>
    /// <param name="paymentdetailsinfo"></param>
    /// <returns></returns>
    public decimal PaymentDetailsAdd(PaymentDetailsInfo paymentdetailsinfo)
    {
        decimal decPaymentDetailsId = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PaymentDetailsAdd", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.PaymentMasterId;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.Amount;
            sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.ExchangeRateId;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = paymentdetailsinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = paymentdetailsinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = paymentdetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = paymentdetailsinfo.Extra2;
            decPaymentDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return decPaymentDetailsId;
    }
    /// <summary>
    /// Function to Update values in PaymentDetails Table
    /// </summary>
    /// <param name="paymentdetailsinfo"></param>
    /// <returns></returns>
    public decimal PaymentDetailsEdit(PaymentDetailsInfo paymentdetailsinfo)
    {
        decimal decPaymentDetailsId = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PaymentDetailsEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@paymentDetailsId", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.PaymentDetailsId;
            sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.PaymentMasterId;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.Amount;
            sprmparam = sccmd.Parameters.Add("@exchangeRateId", SqlDbType.Decimal);
            sprmparam.Value = paymentdetailsinfo.ExchangeRateId;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = paymentdetailsinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = paymentdetailsinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = paymentdetailsinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = paymentdetailsinfo.Extra2;
            decPaymentDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return decPaymentDetailsId;
    }
    /// <summary>
    /// Function to get all the values from PaymentDetails Table
    /// </summary>
    /// <returns></returns>
    public DataTable PaymentDetailsViewAll()
    {
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("PaymentDetailsViewAll", sqlcon);
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
    /// Function to get particular values from PaymentDetails Table based on the parameter
    /// </summary>
    /// <param name="paymentDetailsId"></param>
    /// <returns></returns>
    public PaymentDetailsInfo PaymentDetailsView(decimal paymentDetailsId )
    {
        PaymentDetailsInfo paymentdetailsinfo =new PaymentDetailsInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PaymentDetailsView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@paymentDetailsId", SqlDbType.Decimal);
            sprmparam.Value = paymentDetailsId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                paymentdetailsinfo.PaymentDetailsId=decimal.Parse(sdrreader[0].ToString());
                paymentdetailsinfo.PaymentMasterId=decimal.Parse(sdrreader[1].ToString());
                paymentdetailsinfo.LedgerId=decimal.Parse(sdrreader[2].ToString());
                paymentdetailsinfo.Amount=decimal.Parse(sdrreader[3].ToString());
                paymentdetailsinfo.ExchangeRateId = decimal.Parse(sdrreader["exchangeRateId"].ToString());
                paymentdetailsinfo.ChequeNo= sdrreader[4].ToString();
                paymentdetailsinfo.ChequeDate=DateTime.Parse(sdrreader[5].ToString());
                paymentdetailsinfo.ExtraDate=DateTime.Parse(sdrreader[6].ToString());
                paymentdetailsinfo.Extra1= sdrreader[7].ToString();
                paymentdetailsinfo.Extra2= sdrreader[8].ToString();
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
        return paymentdetailsinfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter From Table PaymentDetails
    /// </summary>
    /// <param name="PaymentDetailsId"></param>
    public void PaymentDetailsDelete(decimal PaymentDetailsId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PaymentDetailsDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@paymentDetailsId", SqlDbType.Decimal);
            sprmparam.Value = PaymentDetailsId;
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
    /// Function to  get the next id for PaymentDetails Table
    /// </summary>
    /// <returns></returns>
    public int PaymentDetailsGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PaymentDetailsMax", sqlcon);
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
    /// Function to Payment Details View 
    /// </summary>
    /// <param name="paymentMastertId"></param>
    /// <returns></returns>
    public List<DataTable> PaymentDetailsViewByMasterId(decimal paymentMastertId)
    {
        List<DataTable> listObj = new List<DataTable>();
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PaymentDetailsViewByMasterId", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@paymentMasterId", SqlDbType.Decimal);
            sprmparam.Value = paymentMastertId;
            SqlDataAdapter sqlda = new SqlDataAdapter();
            sqlda.SelectCommand = sccmd;
            sqlda.Fill(dtbl);
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
