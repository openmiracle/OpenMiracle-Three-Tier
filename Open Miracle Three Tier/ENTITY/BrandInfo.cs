using System;    
using System.Collections.Generic;    
using System.Text;
using ENTITY;   
//<summary>    
//Summary description for BrandInfo    
//</summary>    
namespace ENTITY    
{    
public class BrandInfo    
{    
    private decimal _brandId;    
    private string _brandName;    
    private string _narration;
    private string _manufacturer;
    private DateTime _extraDate;    
    private string _extra1;    
    private string _extra2;
    
    
    public decimal BrandId    
    {    
        get { return _brandId; }    
        set { _brandId = value; }    
    }    
    public string BrandName    
    {    
        get { return _brandName; }    
        set { _brandName = value; }    
    }    
    public string Narration    
    {    
        get { return _narration; }    
        set { _narration = value; }    
    }
    public string Manufacturer
    {
        get { return _manufacturer; }
        set { _manufacturer = value; }
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
