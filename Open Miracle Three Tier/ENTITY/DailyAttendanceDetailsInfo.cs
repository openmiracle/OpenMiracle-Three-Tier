using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;  
//<summary>    
//Summary description for DailyAttendanceDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class DailyAttendanceDetailsInfo    
{    
    private decimal _dailyAttendanceDetailsId;    
    private decimal _dailyAttendanceMasterId;    
    private decimal _employeeId;    
    private string _status;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal DailyAttendanceDetailsId    
    {    
        get { return _dailyAttendanceDetailsId; }    
        set { _dailyAttendanceDetailsId = value; }    
    }    
    public decimal DailyAttendanceMasterId    
    {    
        get { return _dailyAttendanceMasterId; }    
        set { _dailyAttendanceMasterId = value; }    
    }    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public string Status    
    {    
        get { return _status; }    
        set { _status = value; }    
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
