using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for DesignationInfo    
//</summary>    
namespace ENTITY    
{    
public class DesignationInfo    
{    
    private decimal _designationId;    
    private string _designationName;    
    private decimal _leaveDays;    
    private decimal _advanceAmount;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal DesignationId    
    {    
        get { return _designationId; }    
        set { _designationId = value; }    
    }    
    public string DesignationName    
    {    
        get { return _designationName; }    
        set { _designationName = value; }    
    }    
    public decimal LeaveDays    
    {    
        get { return _leaveDays; }    
        set { _leaveDays = value; }    
    }    
    public decimal AdvanceAmount    
    {    
        get { return _advanceAmount; }    
        set { _advanceAmount = value; }    
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
