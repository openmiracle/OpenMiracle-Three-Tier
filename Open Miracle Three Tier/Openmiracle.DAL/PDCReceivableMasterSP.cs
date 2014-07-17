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
//Summary description for PDCReceivableMasterSP    
//</summary>    
namespace OpenMiracle.DAL    
{    
public class PDCReceivableMasterSP:DBConnection    
{
    /// <summary>
    /// Function to insert values to PDCReceivableMaster Table
    /// </summary>
    /// <param name="pdcreceivablemasterinfo"></param>
    /// <returns></returns>
    public decimal PDCReceivableMasterAdd(PDCReceivableMasterInfo pdcreceivablemasterinfo)
    {
        decimal decIdentity = 0;
        try
        {
          if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableMasterAdd", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.VoucherNo;
            sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.InvoiceNo;
            sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.SuffixPrefixId;
            sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
            sprmparam.Value = pdcreceivablemasterinfo.Date;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.Amount;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = pdcreceivablemasterinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.Narration;
            sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.UserId;
            sprmparam = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.BankId;
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.VoucherTypeId;
            sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.FinancialYearId;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.Extra2;
            decIdentity = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return decIdentity;
    }
    /// <summary>
    /// Function to Update values in PDCReceivableMaster Table
    /// </summary>
    /// <param name="pdcreceivablemasterinfo"></param>
    public void PDCReceivableMasterEdit(PDCReceivableMasterInfo pdcreceivablemasterinfo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableMasterEdit", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.PdcReceivableMasterId;
            sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.VoucherNo;
            sprmparam = sccmd.Parameters.Add("@invoiceNo", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.InvoiceNo;
            sprmparam = sccmd.Parameters.Add("@suffixPrefixId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.SuffixPrefixId;
            sprmparam = sccmd.Parameters.Add("@date", SqlDbType.DateTime);
            sprmparam.Value = pdcreceivablemasterinfo.Date;
            sprmparam = sccmd.Parameters.Add("@ledgerId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.LedgerId;
            sprmparam = sccmd.Parameters.Add("@amount", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.Amount;
            sprmparam = sccmd.Parameters.Add("@chequeNo", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.ChequeNo;
            sprmparam = sccmd.Parameters.Add("@chequeDate", SqlDbType.DateTime);
            sprmparam.Value = pdcreceivablemasterinfo.ChequeDate;
            sprmparam = sccmd.Parameters.Add("@narration", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.Narration;
            sprmparam = sccmd.Parameters.Add("@userId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.UserId;
            sprmparam = sccmd.Parameters.Add("@bankId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.BankId;
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.VoucherTypeId;
            sprmparam = sccmd.Parameters.Add("@financialYearId", SqlDbType.Decimal);
            sprmparam.Value = pdcreceivablemasterinfo.FinancialYearId;
            sprmparam = sccmd.Parameters.Add("@extraDate", SqlDbType.DateTime);
            sprmparam.Value = pdcreceivablemasterinfo.ExtraDate;
            sprmparam = sccmd.Parameters.Add("@extra1", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.Extra1;
            sprmparam = sccmd.Parameters.Add("@extra2", SqlDbType.VarChar);
            sprmparam.Value = pdcreceivablemasterinfo.Extra2;
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
    /// Function to get all the values from PDCReceivableMaster Table
    /// </summary>
    /// <returns></returns>
    public DataTable PDCReceivableMasterViewAll()
    {
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCReceivableMasterViewAll", sqlcon);
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
    /// Function to get particular values from PDCReceivableMaster Table based on the parameter
    /// </summary>
    /// <param name="pdcReceivableMasterId"></param>
    /// <returns></returns>
    public PDCReceivableMasterInfo PDCReceivableMasterView(decimal pdcReceivableMasterId )
    {
        PDCReceivableMasterInfo pdcreceivablemasterinfo =new PDCReceivableMasterInfo();
        SqlDataReader sdrreader =null;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableMasterView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value = pdcReceivableMasterId;
             sdrreader = sccmd.ExecuteReader();
            while (sdrreader.Read())
            {
                pdcreceivablemasterinfo.PdcReceivableMasterId=decimal.Parse(sdrreader[0].ToString());
                pdcreceivablemasterinfo.VoucherNo= sdrreader[1].ToString();
                pdcreceivablemasterinfo.InvoiceNo= sdrreader[2].ToString();
                pdcreceivablemasterinfo.SuffixPrefixId=decimal.Parse(sdrreader[3].ToString());
                pdcreceivablemasterinfo.Date=DateTime.Parse(sdrreader[4].ToString());
                pdcreceivablemasterinfo.LedgerId=decimal.Parse(sdrreader[5].ToString());
                pdcreceivablemasterinfo.Amount=decimal.Parse(sdrreader[6].ToString());
                pdcreceivablemasterinfo.ChequeNo= sdrreader[7].ToString();
                pdcreceivablemasterinfo.ChequeDate=DateTime.Parse(sdrreader[8].ToString());
                pdcreceivablemasterinfo.Narration= sdrreader[9].ToString();
                pdcreceivablemasterinfo.UserId=decimal.Parse(sdrreader[10].ToString());
                pdcreceivablemasterinfo.BankId=decimal.Parse(sdrreader[11].ToString());
                pdcreceivablemasterinfo.VoucherTypeId=decimal.Parse(sdrreader[12].ToString());
                pdcreceivablemasterinfo.FinancialYearId=decimal.Parse(sdrreader[13].ToString());
                pdcreceivablemasterinfo.ExtraDate=DateTime.Parse(sdrreader[14].ToString());
                pdcreceivablemasterinfo.Extra1= sdrreader[15].ToString();
                pdcreceivablemasterinfo.Extra2= sdrreader[16].ToString();
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
        return pdcreceivablemasterinfo;
    }
    /// <summary>
    /// Function to delete particular details based on the parameter From Table PDCReceivableMaster
    /// </summary>
    /// <param name="PdcReceivableMasterId"></param>
    public void PDCReceivableMasterDelete(decimal PdcReceivableMasterId)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableMasterDelete", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value = PdcReceivableMasterId;
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
    /// Function to  get the next id for PDCReceivableMaster Table
    /// </summary>
    /// <returns></returns>
    public int PDCReceivableMasterGetMax()
    {
        int max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableMasterMax", sqlcon);
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
    /// Function to  get PDCReceivable Max UnderVoucherType PlusOne
    /// </summary>
    /// <param name="decVoucherTypeId"></param>
    /// <returns></returns>
    public decimal PDCReceivableMaxUnderVoucherTypePlusOne(decimal decVoucherTypeId)
    {
        decimal max = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableMaxUnderVoucherType", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = decVoucherTypeId;
            max = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
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
    /// Function to PDCReceivable Max Under VoucherType
    /// </summary>
    /// <param name="decVoucherTypeId"></param>
    /// <returns></returns>
    public string PDCReceivableMaxUnderVoucherType(decimal decVoucherTypeId)
    {
        string max = "0";
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableMaxUnderVoucherType", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = decVoucherTypeId;
            max = sccmd.ExecuteScalar().ToString();
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
    /// Function to PDCReceivable Check Existence for voucherNo
    /// </summary>
    /// <param name="voucherNo"></param>
    /// <param name="voucherTypeId"></param>
    /// <param name="decpdcReceivableId"></param>
    /// <returns></returns>
    public bool PDCReceivableCheckExistence(string voucherNo, decimal voucherTypeId, decimal decpdcReceivableId)
    {
        bool isSave = false;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableCheckExistence", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
            sprmparam.Value = voucherNo;
            sprmparam = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value = decpdcReceivableId;
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = voucherTypeId;
            sccmd.ExecuteNonQuery();
            object obj = sccmd.ExecuteScalar();
            if (obj != null)
            {
                
                if (Convert.ToDecimal(obj.ToString()) == 0)
                {
                    isSave = true;
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
        return isSave;
    }
   /// <summary>
    /// Function to PDCReceivable Voucher CheckRreference Updating
   /// </summary>
   /// <param name="decMasterId"></param>
   /// <param name="voucherTypeId"></param>
   /// <returns></returns>
    public bool PDCReceivableVoucherCheckRreferenceUpdating(decimal decMasterId, decimal voucherTypeId)
    {
        bool isExist = false;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableVoucherCheckRreferenceUpdating", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.VarChar);
            sprmparam.Value = decMasterId;
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = voucherTypeId;
            isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "OpenMiracle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        finally
        {
            sqlcon.Close();
        }
        return isExist;
    }
   /// <summary>
    /// Function to PDCReceivableDelete Master based on the parameter
   /// </summary>
   /// <param name="PdcReceivableId"></param>
   /// <param name="decVoucherTypeId"></param>
   /// <param name="strVoucherNo"></param>
    public void PDCReceivableDeleteMaster(decimal PdcReceivableId, decimal decVoucherTypeId, string strVoucherNo)
    {
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableDeleteMaster", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value =PdcReceivableId;
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = decVoucherTypeId;
            sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
            sprmparam.Value = strVoucherNo;
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
    /// Ledger posting id get by using pdc id for updation 
    /// </summary>
    /// <param name="pdcMasterId"></param>
    /// <returns></returns>
    public List<DataTable> LedgerPostingIdByPDCReceivableId(decimal pdcMasterId)
    {
        List<DataTable> listObjpdcReceivableId = new List<DataTable>();
        DataTable dtbl = new DataTable();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("LedgerPostingIdByPDCReceivableId", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sdaadapter.SelectCommand.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value = pdcMasterId;
            sdaadapter.Fill(dtbl);
            listObjpdcReceivableId.Add(dtbl);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return listObjpdcReceivableId;
    }
   /// <summary>
    /// Function to print the PDCReceivable Voucher 
   /// </summary>
   /// <param name="decPDCReceivableId"></param>
   /// <param name="decCompanyId"></param>
   /// <returns></returns>
    public DataSet PDCReceivableVoucherPrinting(decimal decPDCReceivableId, decimal decCompanyId)
    {
        DataSet dSt = new DataSet();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("PDCReceivableVoucherPrinting", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sdaadapter.SelectCommand.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value = decPDCReceivableId;
            sprmparam = sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal);
            sprmparam.Value = decCompanyId;
            sdaadapter.Fill(dSt);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return dSt;
    }
    /// <summary>
    /// Function to search the PDCReceivable  
    /// </summary>
    /// <param name="dtFromdate"></param>
    /// <param name="dtTodate"></param>
    /// <param name="strVoucherNo"></param>
    /// <param name="strLedgerName"></param>
    /// <returns></returns>
    public List<DataTable> PDCReceivableRegisterSearch(DateTime dtFromdate, DateTime dtTodate, string strVoucherNo, string strLedgerName)
    {
        List<DataTable> ListObj = new List<DataTable>();
        DataTable dtbl = new DataTable();
        dtbl.Columns.Add("SlNo", typeof(decimal));
        dtbl.Columns["SlNo"].AutoIncrement = true;
        dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
        dtbl.Columns["SlNo"].AutoIncrementStep = 1;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sqlcmd = new SqlCommand("PDCReceivableRegisterSearch", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add("@voucherNo", SqlDbType.VarChar).Value = strVoucherNo;
            sqlcmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
            sqlcmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtTodate;
            sqlcmd.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
            SqlDataAdapter sqlda = new SqlDataAdapter();
            sqlda.SelectCommand = sqlcmd;
            sqlda.Fill(dtbl);
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
    /// Function to use PdcReceivableReport Search
    /// </summary>
    /// <param name="dtFromdate"></param>
    /// <param name="dtToDate"></param>
    /// <param name="strVoucherType"></param>
    /// <param name="strLedgerName"></param>
    /// <param name="dtcheckfromdate"></param>
    /// <param name="dtCheckdateto"></param>
    /// <param name="strchequeNo"></param>
    /// <param name="strvoucherNo"></param>
    /// <param name="strstatus"></param>
    /// <returns></returns>
    public List<DataTable> PdcReceivableReportSearch(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus)
    {
        List<DataTable> ListObj = new List<DataTable>();
        DataTable dtbl = new DataTable();
        dtbl.Columns.Add("SlNo", typeof(decimal));
        dtbl.Columns["SlNo"].AutoIncrement = true;
        dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
        dtbl.Columns["SlNo"].AutoIncrementStep = 1;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcReceivableReportSearch", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
            sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
            sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
            sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
            sdaadapter.SelectCommand.Parameters.Add("@chequeDateFrom", SqlDbType.DateTime).Value = dtcheckfromdate;
            sdaadapter.SelectCommand.Parameters.Add("@chequeDateTo", SqlDbType.DateTime).Value = dtCheckdateto;
            sdaadapter.SelectCommand.Parameters.Add("@chequeNo", SqlDbType.Char).Value = strchequeNo;
            sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.Char).Value = strvoucherNo;
            sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
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
    /// Function to print the report in search criteria
    /// </summary>
    /// <param name="dtFromdate"></param>
    /// <param name="dtToDate"></param>
    /// <param name="strVoucherType"></param>
    /// <param name="strLedgerName"></param>
    /// <param name="dtcheckfromdate"></param>
    /// <param name="dtCheckdateto"></param>
    /// <param name="strchequeNo"></param>
    /// <param name="strvoucherNo"></param>
    /// <param name="strstatus"></param>
    /// <param name="decCompanyId"></param>
    /// <returns></returns>
    public DataSet PdcreceivableReportPrinting(DateTime dtFromdate, DateTime dtToDate, string strVoucherType, string strLedgerName, DateTime dtcheckfromdate, DateTime dtCheckdateto, string strchequeNo, string strvoucherNo, string strstatus, decimal decCompanyId)
    {
        DataSet dst = new DataSet();
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataAdapter sdaadapter = new SqlDataAdapter("PdcreceivableReportPrinting", sqlcon);
            sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sdaadapter.SelectCommand.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = dtFromdate;
            sdaadapter.SelectCommand.Parameters.Add("@companyId", SqlDbType.Decimal).Value = decCompanyId;
            sdaadapter.SelectCommand.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtToDate;
            sdaadapter.SelectCommand.Parameters.Add("@voucherTypeName", SqlDbType.VarChar).Value = strVoucherType;
            sdaadapter.SelectCommand.Parameters.Add("@ledgerName", SqlDbType.VarChar).Value = strLedgerName;
            sdaadapter.SelectCommand.Parameters.Add("@chequeDateFrom", SqlDbType.DateTime).Value = dtcheckfromdate;
            sdaadapter.SelectCommand.Parameters.Add("@chequeDateTo", SqlDbType.DateTime).Value = dtCheckdateto;
            sdaadapter.SelectCommand.Parameters.Add("@chequeNo", SqlDbType.Char).Value = strchequeNo;
            sdaadapter.SelectCommand.Parameters.Add("@voucherNo", SqlDbType.Char).Value = strvoucherNo;
            sdaadapter.SelectCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = strstatus;
            sdaadapter.Fill(dst);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            sqlcon.Close();
        }
        return dst;
    }
    
    /// <summary>
    /// Function get the PdcReceivableMaster for updation
    /// </summary>
    /// <param name="decVouchertypeid"></param>
    /// <param name="strVoucherNo"></param>
    /// <returns></returns>
    public decimal PdcReceivableMasterIdView(decimal decVouchertypeid, string strVoucherNo)
    {
        decimal decid = 0;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
           
            
            SqlCommand sccmd = new SqlCommand("PdcReceivableMasterIdView", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@voucherTypeId", SqlDbType.Decimal);
            sprmparam.Value = decVouchertypeid;
            sprmparam = sccmd.Parameters.Add("@voucherNo", SqlDbType.VarChar);
            sprmparam.Value = strVoucherNo;
            decid = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        finally
        {
          
            sqlcon.Close();
        }
        return decid;
    }
   /// <summary>
    /// Function to get ReferenceCheck for updation
   /// </summary>
   /// <param name="decPDCReceivableMasterId"></param>
   /// <returns></returns>
    public bool PDCReceivableReferenceCheck(decimal decPDCReceivableMasterId)
    {
        bool isExist = false;
        try
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlCommand sccmd = new SqlCommand("PDCReceivableReferenceCheck", sqlcon);
            sccmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sprmparam = new SqlParameter();
            sprmparam = sccmd.Parameters.Add("@pdcReceivableMasterId", SqlDbType.Decimal);
            sprmparam.Value = decPDCReceivableMasterId;
            isExist = bool.Parse(sccmd.ExecuteScalar().ToString());
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
