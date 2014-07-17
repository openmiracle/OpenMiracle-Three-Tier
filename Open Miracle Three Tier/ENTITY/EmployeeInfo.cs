using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for EmployeeInfo    
//</summary>    
namespace ENTITY    
{    
public class EmployeeInfo    
{    
    private decimal _employeeId;    
    private decimal _designationId;    
    private string _employeeName;    
    private string _employeeCode;    
    private DateTime _dob;    
    private string _maritalStatus;    
    private string _gender;    
    private string _qualification;    
    private string _address;    
    private string _phoneNumber;    
    private string _mobileNumber;    
    private string _email;
    private DateTime _joiningDate;
    private DateTime _terminationDate;    
    private bool _isActive;    
    private string _narration;    
    private string _bloodGroup;    
    private string _passportNo;    
    private DateTime _passportExpiryDate;    
    private string _labourCardNumber;    
    private DateTime _labourCardExpiryDate;    
    private string _visaNumber;    
    private DateTime _visaExpiryDate;    
    private string _salaryType;    
    private decimal _dailyWage;
    private string _bankName;
    private string _branchName;
    private string _bankAccountNumber;
    private string _branchCode;
    private string _panNumber;
    private string _pfNumber;
    private string _esiNumber;
    private DateTime _extraDate;
    private string _extra1;
    private string _extra2;
    private decimal _defaultPackageId;


    public decimal DefaultPackageId
    {
        get { return _defaultPackageId; }
        set{ _defaultPackageId = value;}
        
    }
    
    public decimal EmployeeId    
    {    
        get { return _employeeId; }    
        set { _employeeId = value; }    
    }    
    public decimal DesignationId    
    {    
        get { return _designationId; }    
        set { _designationId = value; }    
    }    
    public string EmployeeName    
    {    
        get { return _employeeName; }    
        set { _employeeName = value; }    
    }    
    public string EmployeeCode    
    {    
        get { return _employeeCode; }    
        set { _employeeCode = value; }    
    }    
    public DateTime Dob    
    {    
        get { return _dob; }    
        set { _dob = value; }    
    }    
    public string MaritalStatus    
    {    
        get { return _maritalStatus; }    
        set { _maritalStatus = value; }    
    }    
    public string Gender    
    {    
        get { return _gender; }    
        set { _gender = value; }    
    }    
    public string Qualification    
    {    
        get { return _qualification; }    
        set { _qualification = value; }    
    }    
    public string Address    
    {    
        get { return _address; }    
        set { _address = value; }    
    }    
    public string PhoneNumber    
    {    
        get { return _phoneNumber; }    
        set { _phoneNumber = value; }    
    }    
    public string MobileNumber    
    {    
        get { return _mobileNumber; }    
        set { _mobileNumber = value; }    
    }    
    public string Email    
    {    
        get { return _email; }    
        set { _email = value; }    
    }
    public DateTime JoiningDate
    {
        get { return _joiningDate; }
        set { _joiningDate = value; }
    }    
    public DateTime TerminationDate    
    {    
        get { return _terminationDate; }    
        set { _terminationDate = value; }    
    }    
    public bool IsActive    
    {    
        get { return _isActive; }    
        set { _isActive = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }    
    public string BloodGroup    
    {    
        get { return _bloodGroup; }    
        set { _bloodGroup = value; }    
    }    
    public string PassportNo    
    {    
        get { return _passportNo; }    
        set { _passportNo = value; }    
    }    
    public DateTime PassportExpiryDate    
    {    
        get { return _passportExpiryDate; }    
        set { _passportExpiryDate = value; }    
    }    
    public string LabourCardNumber    
    {    
        get { return _labourCardNumber; }    
        set { _labourCardNumber = value; }    
    }    
    public DateTime LabourCardExpiryDate    
    {    
        get { return _labourCardExpiryDate; }    
        set { _labourCardExpiryDate = value; }    
    }    
    public string VisaNumber    
    {    
        get { return _visaNumber; }    
        set { _visaNumber = value; }    
    }    
    public DateTime VisaExpiryDate    
    {    
        get { return _visaExpiryDate; }    
        set { _visaExpiryDate = value; }    
    }    
    public string SalaryType    
    {    
        get { return _salaryType; }    
        set { _salaryType = value; }    
    }    
    public decimal DailyWage    
    {    
        get { return _dailyWage; }    
        set { _dailyWage = value; }    
    }
    public string BankName
    {
        get { return _bankName; }
        set { _bankName = value; }
    }
    public string BranchName
    {
        get { return _branchName; }
        set { _branchName = value; }
    }
    public string BankAccountNumber
    {
        get { return _bankAccountNumber; }
        set { _bankAccountNumber = value; }
    }
    public string BranchCode
    {
        get { return _branchCode; }
        set { _branchCode = value; }
    }
    public string PanNumber
    {
        get { return _panNumber; }
        set { _panNumber = value; }
    }
    public string PfNumber
    {
        get { return _pfNumber; }
        set { _pfNumber = value; }
    }
    public string EsiNumber
    {
        get { return _esiNumber; }
        set { _esiNumber = value; }
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
