using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;  
//<summary>    
//Summary description for HolidayInfo    
//</summary>    
namespace ENTITY    
{    
public class HolidayInfo    
{    
    private decimal _holidayId;    
    private DateTime _date;    
    private string _holidayName;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal HolidayId    
    {    
        get { return _holidayId; }    
        set { _holidayId = value; }    
    }    
    public DateTime Date    
    {    
        get { return _date; }    
        set { _date = value; }    
    }    
    public string HolidayName    
    {    
        get { return _holidayName; }    
        set { _holidayName = value; }    
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
