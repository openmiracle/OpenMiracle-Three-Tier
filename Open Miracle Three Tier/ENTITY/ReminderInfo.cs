using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for RemainderInfo    
//</summary>    
namespace ENTITY    
{    
public class ReminderInfo    
{    
    private decimal _reminderId;    
    private DateTime _fromDate;    
    private DateTime _toDate;    
    private string _remindAbout;    
    private string _extra1;    
    private string _extra2;    
    private DateTime _extraDate;    
    
    public decimal ReminderId    
    {    
        get { return _reminderId; }    
        set { _reminderId = value; }    
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
    public string RemindAbout    
    {    
        get { return _remindAbout; }    
        set { _remindAbout = value; }    
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
