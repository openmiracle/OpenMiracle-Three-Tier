using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for TaxInfo    
//</summary>    
namespace ENTITY    
{    
public class TaxInfo    
{    
    private decimal _taxId;    
    private string _taxName;    
    private string _applicableOn;    
    private decimal _rate;    
    private string _calculatingMode;    
    private string _narration;    
    private bool _isActive;    
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;    
    
    public decimal TaxId    
    {    
        get { return _taxId; }    
        set { _taxId = value; }    
    }    
    public string TaxName    
    {    
        get { return _taxName; }    
        set { _taxName = value; }    
    }    
    public string ApplicableOn    
    {    
        get { return _applicableOn; }    
        set { _applicableOn = value; }    
    }    
    public decimal Rate    
    {    
        get { return _rate; }    
        set { _rate = value; }    
    }    
    public string CalculatingMode    
    {    
        get { return _calculatingMode; }    
        set { _calculatingMode = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }    
    public bool IsActive    
    {    
        get { return _isActive; }    
        set { _isActive = value; }    
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
