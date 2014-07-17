using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;    
//<summary>    
//Summary description for CounterInfo    
//</summary>    
namespace ENTITY    
{    
public class CounterInfo    
{    
    private decimal _counterId;    
    private string _counterName;    
    private string _narration;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal CounterId    
    {    
        get { return _counterId; }    
        set { _counterId = value; }    
    }    
    public string CounterName    
    {    
        get { return _counterName; }    
        set { _counterName = value; }    
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
