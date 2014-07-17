using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;  
//<summary>    
//Summary description for BudgetMasterInfo    
//</summary>    
namespace ENTITY    
{    
public class BudgetMasterInfo    
{    
    private decimal _budgetMasterId;    
    private string _budgetName;    
    private string _type;    
    private decimal _totalDr;    
    private decimal _totalCr;    
    private DateTime _fromDate;    
    private DateTime _toDate;    
    private string _narration;    
    private string _extra1;    
    private string _extra2;    
    private DateTime _extraDate;    
    
    public decimal BudgetMasterId    
    {    
        get { return _budgetMasterId; }    
        set { _budgetMasterId = value; }    
    }    
    public string BudgetName    
    {    
        get { return _budgetName; }    
        set { _budgetName = value; }    
    }    
    public string Type    
    {    
        get { return _type; }    
        set { _type = value; }    
    }    
    public decimal TotalDr    
    {    
        get { return _totalDr; }    
        set { _totalDr = value; }    
    }    
    public decimal TotalCr    
    {    
        get { return _totalCr; }    
        set { _totalCr = value; }    
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
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
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
    public DateTime ExtraDate    
    {    
        get { return _extraDate; }    
        set { _extraDate = value; }    
    }    
    
}    
}
