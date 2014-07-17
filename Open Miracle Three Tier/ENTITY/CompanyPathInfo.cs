using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for CompanyPathInfo    
//</summary>    
namespace ENTITY    
{    
public class CompanyPathInfo    
{    
    private decimal _companyId;    
    private string _companyName;    
    private string _companyPath;    
    private bool _isDefault;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal CompanyId    
    {    
        get { return _companyId; }    
        set { _companyId = value; }    
    }    
    public string CompanyName    
    {    
        get { return _companyName; }    
        set { _companyName = value; }    
    }    
    public string CompanyPath    
    {    
        get { return _companyPath; }    
        set { _companyPath = value; }    
    }    
    public bool IsDefault    
    {    
        get { return _isDefault; }    
        set { _isDefault = value; }    
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
