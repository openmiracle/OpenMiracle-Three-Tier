using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;  
//<summary>    
//Summary description for ServiceInfo    
//</summary>    
namespace ENTITY    
{    
public class ServiceInfo    
{    
    private decimal _serviceId;    
    private string _serviceName;
    private decimal _serviceCategoryId;    
    private decimal _rate;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal ServiceId    
    {    
        get { return _serviceId; }    
        set { _serviceId = value; }    
    }    
    public string ServiceName    
    {    
        get { return _serviceName; }    
        set { _serviceName = value; }    
    }
    public decimal ServiceCategoryId    
    {
        get { return _serviceCategoryId; }
        set { _serviceCategoryId = value; }    
    }    
    public decimal Rate    
    {    
        get { return _rate; }    
        set { _rate = value; }    
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
