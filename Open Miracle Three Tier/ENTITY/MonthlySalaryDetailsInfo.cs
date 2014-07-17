using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY; 
//<summary>    
//Summary description for MonthlySalaryDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class MonthlySalaryDetailsInfo    
{    
    private decimal _monthlySalaryDetailsId;    
    private decimal _employeeId;    
    private decimal _salaryPackageId;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    private decimal _monthlySalaryId;    
    
    public decimal MonthlySalaryDetailsId    
    {    
        get { return _monthlySalaryDetailsId; }    
        set { _monthlySalaryDetailsId = value; }    
    }    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public decimal SalaryPackageId    
    {    
        get { return _salaryPackageId; }    
        set { _salaryPackageId = value; }    
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
    public decimal MonthlySalaryId    
    {    
        get { return _monthlySalaryId; }    
        set { _monthlySalaryId = value; }    
    }    
    
}    
}
