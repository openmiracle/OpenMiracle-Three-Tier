using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for DailySalaryVoucherDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class DailySalaryVoucherDetailsInfo    
{    
    private decimal _dailySalaryVoucherDetailsId;
    private decimal _dailySalaryVoucherMasterId;    
    private decimal _employeeId;    
    private decimal _wage;    
    private string _status;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;  
    
    public decimal DailySalaryVoucherDetailsId    
    {    
        get { return _dailySalaryVoucherDetailsId; }    
        set { _dailySalaryVoucherDetailsId = value; }    
    }    
    public decimal DailySalaryVocherMasterId    
    {
        get { return _dailySalaryVoucherMasterId; }
        set { _dailySalaryVoucherMasterId = value; }    
    }    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public decimal Wage    
    {    
        get { return _wage; }    
        set { _wage = value; }    
    }    
    public string Status    
    {    
        get { return _status; }    
        set { _status = value; }    
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
