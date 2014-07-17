using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for BonusDedutionInfo    
//</summary>    
namespace ENTITY    
{    
public class BonusDedutionInfo    
{    
    private decimal _bonusDeductionId;    
    private decimal _employeeId;    
    private DateTime _date;    
    private DateTime _month;    
    private decimal _bonusAmount;    
    private decimal _deductionAmount;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal BonusDeductionId    
    {    
        get { return _bonusDeductionId; }    
        set { _bonusDeductionId = value; }    
    }    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }    
    public DateTime Month    
    {    
        get { return _month; }    
        set { _month = value; }    
    }    
    public decimal BonusAmount    
    {    
        get { return _bonusAmount; }    
        set { _bonusAmount = value; }    
    }    
    public decimal DeductionAmount    
    {    
        get { return _deductionAmount; }    
        set { _deductionAmount = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
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
