using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for FinancialYearInfo    
//</summary>    
namespace ENTITY    
{    
public class FinancialYearInfo    
{    
    private decimal _financialYearId;    
    private DateTime _fromDate;    
    private DateTime _toDate;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal FinancialYearId    
    {    
        get { return _financialYearId; }    
        set { _financialYearId = value; }    
    }    
    public DateTime FromDate    
    {    
        get { return _fromDate; }    
        set { _fromDate = value; }    
    }    
    public DateTime ToDate    
    {    
        get { return _toDate; }    
        set { _toDate = value; }    
    }    
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    public string Extra1    
    {    
        get { return _extra1; }    
        set { _extra1 = value; }    
    }    
    public string Extra2    
    {    
        get { return _extra2; }    
        set { _extra2 = value; }    
    }    
    
}    
}
