using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for ServiceDetailsInfo    
//</summary>    
namespace ENTITY    
{    
public class ServiceDetailsInfo    
{    
    private decimal _serviceDetailsId;    
    private decimal _serviceMasterId;    
    private decimal _serviceId;    
    private string _measure;
    private decimal _exchangeRateId;    
    private decimal _amount;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal ServiceDetailsId    
    {    
        get { return _serviceDetailsId; }    
        set { _serviceDetailsId = value; }    
    }    
    public decimal ServiceMasterId    
    {    
        get { return _serviceMasterId; }    
        set { _serviceMasterId = value; }    
    }    
    public decimal ServiceId    
    {    
        get { return _serviceId; }    
        set { _serviceId = value; }    
    }    
    public string Measure    
    {    
        get { return _measure; }    
        set { _measure = value; }    
    }
    public decimal ExchangeRateId
    {
        get { return _exchangeRateId; }
        set { _exchangeRateId = value; }
    } 
    public decimal Amount    
    {    
        get { return _amount; }    
        set { _amount = value; }    
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
